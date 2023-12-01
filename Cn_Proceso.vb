Imports System.Data.SqlClient
Imports Modulo_Proceso.Cn_Datos
Imports Modulo_Proceso.FuncionesGlobales
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Windows.Forms

Public Class Cn_Proceso

#Region "Menu"

    Public Shared Function fn_Menu_TipoCambioM() As Boolean
        'Si no hay tipo de cambio para hoy se trae el ultimo que encuentre
        Dim cmd As SqlCommand = Crea_Comando("Cat_TipoCambio_Copiar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Menu_TipoCambio() As Boolean
        'Revisar si existe Tipo de Cambio para Mañana. SI no hay clona el de hoy para mañana
        Dim dt As DataTable
        Dim Fecha As Date = DateAdd(DateInterval.Day, 1, Now.Date)
        Dim cmd As SqlCommand = Crea_Comando("Cat_TipoCambio_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Fecha", SqlDbType.DateTime, Fecha)
        Try
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    'si hay tipo de cambio para mañana
                    'no hacer nada
                Else
                    'no hay tipo de cambio para mañana
                    'debo insertarlo
                    cmd = Crea_Comando("Cat_TipoCambio_CopiarProceso", CommandType.StoredProcedure, Crea_ConexionSTD)
                    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(cmd, "@FechaOrigen", SqlDbType.Date, Now.Date)
                    Crea_Parametro(cmd, "@FechaDestino", SqlDbType.Date, Fecha)
                    Return EjecutarNonQuery(cmd) > 0
                End If
            End If

            'cmd = Crea_Comando("Cat_TipoCambio_Copiar", CommandType.StoredProcedure, Crea_ConexionSTD)
            'Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AlertasDestinos_Consultar(ByVal Clave_Alerta As String) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasDestinos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_Alerta)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AlertasGeneradas_Guardar(ByVal Clave_AlertaTipo As String, ByVal Detalles As String, ByVal AlertasD As DataTable, ByVal EnviarMail As Boolean, ByVal Asunto As String, ByVal Adjunto As String, ByVal DetallesHTML As String) As Boolean
        Dim Id_Alerta As Integer = 0
        Dim cmd As SqlCommand
        Dim Dt_Destinos As DataTable
        Dim Encabezado As String = ""
        Dim Pie As String = ""

        Try
            'Obtener los Destinos
            Dt_Destinos = fn_AlertasDestinos_Consultar(Clave_AlertaTipo)
            If Dt_Destinos IsNot Nothing Then
                If Dt_Destinos.Rows.Count = 0 Then
                    MsgBox("No se encotnraron destinatarios para enviar la Alerta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If
                If Adjunto <> "" Then
                    Detalles = Detalles & Chr(13) & Chr(13) & "(Ver archivo adjunto)"
                End If

                'Guardar la alerta para cada destino
                For Each Destino As DataRow In Dt_Destinos.Rows
                    cmd = Crea_Comando("Cat_AlertasGeneradas_CreateUna", CommandType.StoredProcedure, Crea_ConexionSTD())
                    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
                    Crea_Parametro(cmd, "@Detalles", SqlDbType.VarChar, Detalles)
                    Crea_Parametro(cmd, "@Id_EmpleadoDestino", SqlDbType.Int, Destino("Id_Empleado"))
                    Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(cmd, "@Tipo_Alerta", SqlDbType.Int, 1)
                    Id_Alerta = CInt(EjecutarScalar(cmd))
                    'Guardar el Detalle para cada alerta generada
                    If AlertasD IsNot Nothing Then
                        For Each dr As DataRow In AlertasD.Rows
                            cmd.Parameters.Clear()
                            cmd = Crea_Comando("Cat_AlertasGeneradasD_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
                            Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
                            Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, dr("Id"))
                            Crea_Parametro(cmd, "@Clave_Entidad", SqlDbType.VarChar, dr("Clave"))
                            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, dr("Nombre"))
                            EjecutarNonQuery(cmd)
                        Next
                    End If
                    If EnviarMail Then
                        Select Case Clave_AlertaTipo
                            Case "39"
                                Encabezado = "DIFERENCIA EN AUDITORIA DE CAJEROS"

                        End Select

                        Pie = "Agente de Servicios SIAC " & Now.Year.ToString

                        If DetallesHTML = "" Then
                            Cn_Mail.fn_Enviar_Mail(Destino("Mail"), Asunto, Detalles, Adjunto)
                            'Cn_Mail.fn_Enviar_Mail("raul.coss@sissaseguridad.com", Asunto, Detalles, Adjunto)
                            'Cn_Mail.fn_Enviar_Mail("jose.nuncio@sissaseguridad.com", Asunto, Detalles, Adjunto)
                            'Exit Function
                        Else
                            DetallesHTML = Replace(DetallesHTML, "Encabezado", Encabezado)
                            DetallesHTML = Replace(DetallesHTML, "Pie", Pie)

                            Cn_Mail.fn_Enviar_MailHTML(Destino("Mail"), Asunto, DetallesHTML, Adjunto)
                            'Cn_Mail.fn_Enviar_MailHTML("raul.coss@sissaseguridad.com", Asunto, DetallesHTML, Adjunto)
                            'Cn_Mail.fn_Enviar_MailHTML("jose.nuncio@sissaseguridad.com", Asunto, DetallesHTML, Adjunto)
                            'Exit Function
                        End If
                    End If
                Next
                Return True
            Else
                'No se encontraron destinos
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AlertasGeneradas_Existe(ByVal Clave_AlertaTipo As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradas_Existe", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return True
        End Try
    End Function

#End Region

#Region "BuscarCliente"

    'Public Shared Function fn_BuscarClientes_LlenarLista(Optional ByVal Cliente As Boolean = True) As Boolean
    '    Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesCombo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
    '    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
    '    If Cliente = False Then
    '        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "P")
    '    Else
    '        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
    '    End If
    '    Try
    '        Frm_BuscarCliente.lsv_Clientes.Actualizar(cmd, "Id_Cliente")
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function


    ''' <summary>
    ''' Llena la lista lsv_Clientes
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarLista(ByVal lsv As cp_Listview, ByVal SoloActivos As Boolean, Optional ByVal Cliente As Boolean = True) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_GetBuscaCliente", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        If Cliente = False Then
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "P")
        Else
            If SoloActivos Then
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            End If
        End If

        Try
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientesP_LlenarLista(ByVal lsv As cp_Listview, ByVal SoloActivos As Boolean, ByVal Id_CajaBancaria As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_GetBuscaCliente", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        If SoloActivos Then
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        End If

        Try
            lsv.Actualizar(cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes con Empleados
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarListaEmpleados(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_ComboGetActivos", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes con Cajas Bancarias
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarListaCajasBancarias(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_ComboGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            lsv.Actualizar(cmd, "Id_CajaBancaria")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Seguimiento_BuscarLlamadas(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_SolicitudServicio_GetBuscaSolicitud", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            lsv.Actualizar(Cmd, "Id_Solicitud")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "AbrirSesion"

    Public Shared Function fn_AbrirSesion_Verificar() As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Pro_Sesion_Verificar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AbrirSesion_LlenarLista(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Sesion_Pendientes", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            lsv.Actualizar(cmd, "Id_Orden")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_AbrirSesion_Abrir(ByVal Numero_Sesion As Integer, ByVal Usuario_Sesion As Integer) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Pro_Sesion_Abrir", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Numero_Sesion", SqlDbType.Int, Numero_Sesion)
        Crea_Parametro(cmd, "@Usuario_Sesion", SqlDbType.Int, Usuario_Sesion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_AbrirSesion_Cerrar(ByVal Id_Sesion As Integer, ByVal Usuario_Sesion As Integer) As Boolean
        Using Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

            If Not fn_AbrirSesion_CerrarSesion(Tr, Id_Sesion, Usuario_Sesion) Then Return False

            If Not fn_AbrirSesion_CerrarCortes(Tr, Id_Sesion) Then Return False

            Tr.Commit()
        End Using
    End Function

    Public Shared Function fn_AbrirSesion_CerrarSesion(ByVal Tr As SqlTransaction, ByVal Id_Sesion As Integer, ByVal Usuario_Sesion As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Sesion_Cerrar")
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Usuario_Cierre", SqlDbType.Int, Usuario_Sesion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "B")

        Try
            Return EjecutarNonQueryT(cmd) >= 0
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AbrirSesion_CerrarCortes(ByVal Tr As SqlTransaction, ByVal Id_Sesion As Integer)
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Cortes_CerrarTodos")
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)

        Try
            Return EjecutarNonQueryT(cmd) >= 0
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Corte"
    Public Shared Function fn_Corte_CorteActual(ByVal Id_CajaBancaria As Integer, ByVal Id_Sesion As Integer) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Pro_Cortes_GetActual", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function
    Public Shared Function fn_Corte_Crear(ByVal Id_Sesion As Integer, ByVal Id_Cajabancaria As Integer) As Boolean
        Using Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
            Dim NumeroNuevo As Integer = fn_Corte_Cerrar(Tr, Id_Sesion, Id_Cajabancaria)

            If NumeroNuevo = 0 Then Return False

            If Not fn_Corte_Abrir(Tr, Id_Sesion, Id_Cajabancaria, NumeroNuevo) Then Return False

            Tr.Commit()
            Return True
        End Using
    End Function
    Public Shared Function fn_Corte_Cerrar(ByVal Tr As SqlTransaction, ByVal Id_Sesion As Integer, ByVal Id_CajaBancaria As Integer) As Integer
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Cortes_Close")
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Return EjecutarScalarT(cmd)
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function
    Public Shared Function fn_Corte_Abrir(ByVal Tr As SqlTransaction, ByVal Id_Sesion As Integer, ByVal Id_CajaBancaria As Integer, ByVal NumeroCorte As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Cortes_Create")
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@NumeroCorte", SqlDbType.Int, NumeroCorte)

        Try
            Return EjecutarNonQueryT(cmd) > 0
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region

#Region "Recibir Servisios de Bóveda2 (individual y ya no en lotes)"

    Public Shared Function fn_RecLotesBoveda_ValidarNew(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRecProceso_Statusvalidar", "@ID_LoteRP")

    End Function

    Public Shared Function fn_RecibirLotesBoveda_LlenarListaNew(ByRef lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRecProceso_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Destino", SqlDbType.VarChar, "P")
            lsv.Actualizar(Cmd, "Id_LoteRP")

            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecibirLotesBoveda_LlenarListaNewEnvase(ByRef lsv As cp_Listview) As DataTable
        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRecProceso_GetEnvases", CommandType.StoredProcedure, Cnn)
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRecProceso_GetEnvases", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Destino", SqlDbType.VarChar, "P")

            dt = EjecutaConsulta(Cmd)
     
            Return dt
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReciboLotesBoveda_GuardarNew(ByVal Id_Usuario As Integer, ByVal lsv As cp_Listview) As Boolean
        Dim Tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Crea_ConexionSTD)
        For Each Elemento As ListViewItem In lsv.CheckedItems
            If Not fn_ReciboLotesBoveda_InsertarNew(Tr, Id_Usuario, Elemento.Tag) Then Return False
            If Not fn_ReciboLotesBoveda_ActualizarNew(Tr, Elemento.Tag, Id_Usuario) Then Return False
        Next
        Tr.Commit()
        Return True
    End Function

    Public Shared Function fn_ReciboLotesBoveda_InsertarNew(ByVal Tr As SqlTransaction, ByVal Id_Usuario As Integer, ByVal Id_LoteRP As Integer) As Boolean
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Servicios_Create2")
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Id_Usuario", SqlDbType.Int, Id_Usuario)
        Crea_Parametro(Cmd, "@Id_LoteRP", SqlDbType.Int, Id_LoteRP)
        Crea_Parametro(Cmd, "@Estacion_Recibe", SqlDbType.VarChar, EstacioN)

        Try
            If EjecutarScalarT(Cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                MsgBox("No se pudo recibir el lote porque no hay Sesion abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReciboLotesBoveda_ActualizarNew(ByVal Tr As SqlTransaction, ByVal Id_LoteRP As Integer, ByVal Usuario As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "CAT_LotesRecProceso_Validar")
        Crea_Parametro(cmd, "@Id_LoteRP", SqlDbType.Int, Id_LoteRP)
        Crea_Parametro(cmd, "@Usuario", SqlDbType.Int, Usuario)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                MsgBox("No se pudo recibir el lote porque no se encuentra la Remisión", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_Envases(ByVal Id_Remision As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get3", CommandType.StoredProcedure, Crea_ConexionSTD)
            'Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get3New", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_RemisionesD(ByVal Id_Remision As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            lsv.Actualizar(cmd, "Id_Moneda")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Recibir Servicios de Boveda"

    Public Shared Function fn_RecLotesBoveda_Validar(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRemisiones_Statusvalidar", "@ID_lote")

    End Function

    Public Shared Function fn_RecibirLotesBoveda_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByVal Tipolote As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, Tipolote)

            'Aqui se Actualiza la lista
            lsv_Catalogo.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_RecibirLotesBovedaDotacionesD_Llenalista(ByRef lsv As cp_Listview, ByVal ID_Lote As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GetServicios", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, ID_Lote)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Remision")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_RecibirLotesBovedaDotacionesD_LlenaEnvases(ByVal lsv As cp_Listview, ByVal ID_Lote As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Envases_GetLote", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ID_Lote)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Envase")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ReciboLotesBoveda_Guardar(ByVal Id_Usuario As Integer, ByVal Id_Lote As Integer) As Boolean
        Dim Tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Crea_ConexionSTD)

        If Not fn_ReciboLotesBoveda_Insertar(Tr, Id_Usuario, Id_Lote) Then Return False

        If Not fn_ReciboLotesBoveda_Actualizar(Tr, Id_Lote, Id_Usuario) Then Return False

        Tr.Commit()
        Return True

    End Function

    Public Shared Function fn_ReciboLotesBoveda_Insertar(ByVal Tr As SqlTransaction, ByVal Id_Usuario As Integer, ByVal Id_Lote As Integer) As Boolean
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Servicios_Create")
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Id_Usuario", SqlDbType.Int, Id_Usuario)
        Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, Id_Lote)
        Crea_Parametro(Cmd, "@Estacion_Recibe", SqlDbType.VarChar, EstacioN)

        Try
            If EjecutarScalarT(Cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                MsgBox("No se pudo recibir el lote porque no hay sesion abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReciboLotesBoveda_Actualizar(ByVal Tr As SqlTransaction, ByVal ID_lote As Integer, ByVal Usuario As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "CAT_LotesRemisiones_StatusValida")
        Crea_Parametro(cmd, "@ID_lote", SqlDbType.Int, ID_lote)
        Crea_Parametro(cmd, "@Usuario", SqlDbType.Int, Usuario)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                MsgBox("No se pudo recibir el lote porque no se encuentra")
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscaryMarca_enListView(ByRef Lista As ListView, ByVal cadena As String, ByVal Columna As Integer) As Boolean
        Dim n As Integer
        Dim col As Integer

        Lista.SelectedItems.Clear()
        If Columna = 0 Then
            For n = 0 To Lista.Items.Count - 1
                For col = 0 To Lista.Columns.Count - 1
                    If col = 0 Then
                        If InStr(1, Lista.Items(n).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Checked = True
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscaryMarca_enListView = True
                            Exit Function
                        End If
                    Else
                        If InStr(1, Lista.Items(n).SubItems(col).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Checked = True
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscaryMarca_enListView = True
                            Exit Function
                        End If
                    End If
                Next col
            Next n
        Else
            'Se busca conicidencia exacta solamente cuando se especifica la columna
            If Columna > Lista.Columns.Count Then
                fn_BuscaryMarca_enListView = False
                Exit Function
            Else
                For n = 0 To Lista.Items.Count - 1
                    If Columna = 1 Then
                        If Lista.Items(n).Text = cadena Then
                            Lista.Items(n).Checked = True
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscaryMarca_enListView = True
                            Exit Function
                        End If
                    Else
                        If Lista.Items(n).SubItems(Columna - 1).Text = 0 Then
                            Lista.Items(n).Checked = True
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscaryMarca_enListView = True
                            Exit Function
                        End If
                    End If
                Next n
            End If
        End If
        fn_BuscaryMarca_enListView = False
    End Function

    Public Shared Function fn_BuscarSeleccionarMarca_enListView(ByRef Lista As ListView, ByVal cadena As String, ByVal Columna As Integer) As Boolean
        Dim n As Integer
        Dim col As Integer

        Lista.SelectedItems.Clear()
        If Columna = 0 Then
            For n = 0 To Lista.Items.Count - 1
                For col = 0 To Lista.Columns.Count - 1
                    If col = 0 Then
                        If InStr(1, Lista.Items(n).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            Return True
                        End If
                    Else
                        If InStr(1, Lista.Items(n).SubItems(col).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            Return True
                        End If
                    End If
                Next col
            Next n
        Else
            If Columna > Lista.Columns.Count Then
                Return False
            Else
                For n = 0 To Lista.Items.Count - 1
                    If Columna = 1 Then
                        If InStr(1, Lista.Items(n).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            Return True
                        End If

                    Else
                        If InStr(1, Lista.Items(n).SubItems(Columna - 1).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            fn_BuscarSeleccionarMarca_enListView = True
                            Return True
                        End If
                    End If
                    'simon
                    If Columna = 2 Then
                        If InStr(1, Lista.Items(n).SubItems(2).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).Checked = True
                            Lista.Items(n).EnsureVisible()
                            Return True
                        End If
                    End If
                    'simon
                Next n
            End If
        End If
        Return False
    End Function

    Public Shared Function fn_ValidarDependencias(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String) As Boolean

        'Aqui se valida una dependencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, Id)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region

#Region "Regreso de Servicios a Boveda"
    Public Shared Function fn_RegresoaBoveda_LlenarLista(ByVal Lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetRecibidos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, 0)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, 0)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "RC")
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

        Try
            Lsv.Actualizar(cmd, "Id_Servicio")
            Lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(7).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RegresoaBoveda_Enviar(ByVal Id_Servicio() As Integer, ByVal Id_Remision() As Integer, ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        Dim Id_Lote As Integer = fn_RegresoaBoveda_InsertarLote(Tr, Cantidad_Remisiones, Cantidad_Envases)
        If Id_Lote = 0 Then Return False

        For Each remision As Integer In Id_Remision
            If Not fn_RegresoaBoveda_InsertarRemisiones(Tr, remision, Id_Lote) Then Return False
        Next

        For Each Servicio As Integer In Id_Servicio
            If Not fn_RegresoaBoveda_ActualizarServicios(Tr, Servicio) Then Return False
        Next

        Tr.Commit()
        Return True
    End Function

    Public Shared Function fn_RegresoaBoveda_InsertarLote(ByVal Tr As SqlTransaction, ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer) As Integer
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Tipo_Lote", SqlDbType.Int, 4)
        Crea_Parametro(cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
        Crea_Parametro(cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
        Crea_Parametro(cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            Dim Id As Integer = EjecutarScalarT(cmd)
            If Id = 0 Then
                Tr.Rollback()
                Return Id
            Else
                Return Id
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_RegresoaBoveda_InsertarRemisiones(ByVal Tr As SqlTransaction, ByVal Id_Remision As Integer, ByVal Id_Lote As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
        Crea_Parametro(cmd, "@Id_lote", SqlDbType.Int, Id_Lote)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Afectadas As Integer = EjecutarNonQueryT(cmd)
            If Afectadas = 0 Then
                Tr.Rollback()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RegresoaBoveda_ActualizarServicios(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Servicios_Update")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

        Try
            Dim Afectadas As Integer = EjecutarNonQueryT(cmd)
            If Afectadas = 0 Then
                Tr.Rollback()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RegresoaBoveda_Validar(ByVal Id_Servicio As Integer, Optional ByVal Status As String = Nothing) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Validar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
        If Not Status = Nothing Then Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutaConsulta(cmd).Rows.Count > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Asignar Servicios"
    Public Shared Function fn_AsignarServicios_ObtenCajero() As Integer
        Return fn_ParametrosGlobales(ParametrosGlobales.Puesto_Cajero)
    End Function

    Public Shared Function fn_AsignarServicios_LlenarLista(ByVal Lsv As cp_Listview, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetAsignar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "RC")
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

        Try
            Lsv.Actualizar(cmd, "Id_Servicio")
            Lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(7).Dispose()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AsignarServicios_Asignar(ByVal Id_Servicios() As Integer, ByVal Id_Cajero As Integer, ByVal Cantidad_Servicios As Integer, ByVal Cantidad_Envases As Integer) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        Dim Id_Asigna As Integer = fn_AsignarServicios_CrearAsignacion(Tr, Id_Cajero, Cantidad_Servicios, Cantidad_Envases)
        If Id_Asigna = 0 Then Return False

        For Each Id_Servicio As Integer In Id_Servicios
            If Not fn_AsignaServicios_AsignarServicio(Tr, Id_Asigna, Id_Servicio) Then Return False
            If Not fn_AsignaServicios_ActualizaServicio(Tr, Id_Servicio, Id_Cajero) Then Return False
        Next

        Tr.Commit()
        Return True
    End Function

    Public Shared Function fn_AsignarServicios_CrearAsignacion(ByVal Tr As SqlTransaction, ByVal Id_Cajero As Integer, ByVal Cantidad_Servicios As Integer, ByVal Cantidad_Envases As Integer) As Integer
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Asigna_Create")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Supervisor_Asigna", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Cantidad_Servicios", SqlDbType.Int, Cantidad_Servicios)
        Crea_Parametro(cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Dim Id As Integer = EjecutarScalarT(cmd)
            If Id > 0 Then
                Return Id
            Else
                Tr.Rollback()
                Return 0
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_AsignaServicios_AsignarServicio(ByVal Tr As SqlTransaction, ByVal Id_Asigna As Integer, ByVal Id_Servicio As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_AsignaD_Create")
        Crea_Parametro(cmd, "@Id_Asigna", SqlDbType.Int, Id_Asigna)
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AsignaServicios_ActualizaServicio(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer, ByVal Cajero As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Servicios_Asignar")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
        Crea_Parametro(cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Cajero)
        Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If

        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Cancelar Asignacion"
    Public Shared Function fn_CancelarAsignacion_LlenarLista(ByVal Lsv As cp_Listview, ByVal Id_Cajero As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetAsignados", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)

        Try
            Lsv.Actualizar(cmd, "Id_Servicio")
            Lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarAsignacion_Cancelar(ByVal Id_Servicios() As Integer, ByVal Id_Remision() As Integer, ByVal Id_Usuario As Integer, ByVal Cajero As Integer, ByVal Cantidad_Servicios As Integer, ByVal Cantidad_Envases As Integer) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        Dim Id_Cancela As Integer = fn_CancelarAsignacion_InsertarRegistro(Tr, Id_Usuario, Cajero, Cantidad_Servicios, Cantidad_Envases)
        If Id_Cancela = 0 Then Return False
        For I As Integer = 0 To Id_Servicios.Length - 1
            Dim Id_Asigna As Integer = fn_CancelarAsignacion_EliminarDetalle(Tr, Id_Remision(I), Id_Cancela)
            If Id_Asigna = 0 Then Return False
            If Not fn_CancelarAsignacion_Recalcular(Tr, Id_Remision(I), Id_Usuario, Id_Asigna) Then Return False
            If Not fn_CancelarAsignacion_ActualizarServicios(Tr, Id_Servicios(I)) Then Return False
        Next

        Tr.Commit()
        Return True
    End Function

    Public Shared Function fn_CancelarAsignacion_InsertarRegistro(ByVal Tr As SqlTransaction, ByVal Usuario_Cancela As Integer, ByVal Cajero As Integer, ByVal Cantidad_Servicios As Integer, ByVal Cantidad_Envases As Integer) As Integer
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_AsignaCancela_Create")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, SesionId)
        Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, Usuario_Cancela)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Cajero)
        Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Cantidad_Servicios", SqlDbType.Int, Cantidad_Servicios)
        Crea_Parametro(cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)

        Try
            Return EjecutarScalarT(cmd)
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_CancelarAsignacion_EliminarDetalle(ByVal Tr As SqlTransaction, ByVal Id_Remision As Integer, ByVal Id_Cancela As Integer) As Integer
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_AsignaD_Cancela")
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Crea_Parametro(cmd, "@Id_Cancela", SqlDbType.Int, Id_Cancela)

        Try

            Return EjecutarScalarT(cmd)
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_CancelarAsignacion_Recalcular(ByVal Tr As SqlTransaction, ByVal Id_Remision As Integer, ByVal Id_Usuario As Integer, ByVal Id_Asigna As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Asigna_Recalcular")
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, Id_Usuario)
        Crea_Parametro(cmd, "@Id_Asigna", SqlDbType.Int, Id_Asigna)
        Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)

        Try
            EjecutarNonQueryT(cmd)
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarAsignacion_ActualizarServicios(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Servicios_CancelarAsignacion")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If

        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Prepara Envio Efectivo "

    Public Shared Function fn_PreparaEnvioEfectivo_Create(ByVal dt As DataTable, ByVal lsvEnvases As ListView, ByVal Envases As Integer, ByVal EnvasesSN As Integer _
                                        , ByVal NumRemision As Integer, ByVal IdCajaBancaria As Integer, ByVal ImporteTotal As Decimal) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim CantidadEnvases As Integer
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim lc_identity As Integer
        Dim lc_idEfectivo As Integer
        Dim DR As DataRow
        Dim Elemento As ListViewItem

        CantidadEnvases = Envases + EnvasesSN

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.Int, NumRemision)
            Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, ImporteTotal)

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_Create") 'efectivo

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 7)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)

            lc_idEfectivo = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, dt.Rows(5))
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, DR(4)) 'Raul dice que cantidad de Piezas
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, 0)
            Cn_Datos.EjecutarNonQueryT(Cmd)


            For Each DR In dt.Rows

                If DR(4) > 0 Then

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivoD_Create") 'efectivo
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, lc_idEfectivo)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, DR(0))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, DR(4))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, 0)
                    Cn_Datos.EjecutarNonQueryT(Cmd)

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Saldo_Update")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, DR(0))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, DR(4))
                    Cn_Datos.EjecutarNonQueryT(Cmd)

                End If


            Next

            For Each Elemento In lsvEnvases.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.Tag.ToString)
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next



        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_ValidaMateriales_Cia(ByVal Id As Integer) As String
        Dim Valores() As Object

        Valores = fn_ObtenValores(Id, "Cat_Cias_Read", "@Id_Cia", False)

        Return Valores(2).ToString

    End Function

    Public Shared Function fn_ObtenValores(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String, ByVal Sucursal As Boolean) As Array
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)

        If Not Parametro = "" Then
            Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.Int, Id)
        End If

        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado")
                Return Nothing
            Else
                Return Tbl.Rows(0).ItemArray
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    'Public Shared Function fn_LotesEfectivo_Create(ByVal lsvEnvases As ListView, ByVal Envases As Integer, ByVal EnvasesSN As Integer, _
    '                                            ByVal NumRemision As Integer, ByVal IdCajaBancaria As Integer, ByVal ImporteTotal As Decimal, ByVal Moneda As Integer) As Boolean

    '    'ya no se uso porque se reemplazo 17/05/2014 por la funcion <Fn_LoteEfectivo_CreateSR>

    '    'Es para cuando es un Lote de Efectivo
    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand
    '    Dim resulset As Integer = 0
    '    Dim CantidadEnvases As Integer
    '    Dim lc_Transaccion As SqlClient.SqlTransaction
    '    Dim lc_identity As Integer
    '    Dim Id_LoteE As Integer
    '    Dim Elemento As ListViewItem

    '    CantidadEnvases = Envases + EnvasesSN

    '    lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

    '    Try

    '        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.Int, NumRemision)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
    '        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, ImporteTotal)

    '        lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

    '        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Moneda)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, ImporteTotal)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, 0)

    '        Cn_Datos.EjecutarNonQueryT(Cmd)

    '        For Each Elemento In lsvEnvases.Items

    '            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
    '            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
    '            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
    '            Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.Tag.ToString)
    '            Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
    '            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

    '            Cn_Datos.EjecutarNonQueryT(Cmd)
    '        Next

    '        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_Create")
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, frm_EnviarEfectivo.cmb_Destino.SelectedValue)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, frm_EnviarEfectivo.cmb_CajaBancaria.SelectedValue)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, frm_EnviarEfectivo.cmb_Moneda.SelectedValue)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancariaD", SqlDbType.Int, frm_EnviarEfectivo.cmb_CajaBancariaD.SelectedValue)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Diferencia", SqlDbType.Decimal, 0.0)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, ImporteTotal)

    '        Id_LoteE = Cn_Datos.EjecutarScalarT(Cmd)

    '        For Each Row As DataRow In TryCast(frm_EnviarEfectivo.dgv_Denominaciones.DataSource, DataTable).Rows

    '            If Row("Importe") > 0 Then

    '                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
    '                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
    '                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, frm_EnviarEfectivo.cmb_Moneda.SelectedValue)
    '                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(Row("Importe")))
    '                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, 0)

    '                Cn_Datos.EjecutarNonQueryT(Cmd)

    '                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivoD_Create")
    '                Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, Id_LoteE)
    '                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
    '                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
    '                If Not frm_EnviarEfectivo.Origen = frm_EnviarEfectivo.Tipo.Cajeros Then
    '                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
    '                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
    '                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
    '                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
    '                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))
    '                End If

    '                Cn_Datos.EjecutarNonQueryT(Cmd)

    '                Select Case frm_EnviarEfectivo.Origen
    '                    Case frm_EnviarEfectivo.Tipo.Proceso

    '                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Restar")
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
    '                        Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))

    '                        Cn_Datos.EjecutarNonQueryT(Cmd)

    '                    Case frm_EnviarEfectivo.Tipo.Morralla

    '                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mor_Saldo_Restar")
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
    '                        Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))

    '                        Cn_Datos.EjecutarNonQueryT(Cmd)

    '                    Case frm_EnviarEfectivo.Tipo.Clasificado

    '                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cla_Saldo_Restar")
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
    '                        Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))

    '                        Cn_Datos.EjecutarNonQueryT(Cmd)

    '                    Case frm_EnviarEfectivo.Tipo.Nominas

    '                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Nom_Saldo_Restar")
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
    '                        Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))

    '                        Cn_Datos.EjecutarNonQueryT(Cmd)

    '                    Case frm_EnviarEfectivo.Tipo.Cajeros

    '                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Saldo_Update")
    '                        Cn_Datos.Crea_Parametro(Cmd, "@ID_Sucursal", SqlDbType.Int, SucursalId)
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
    '                        Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
    '                        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
    '                        Cn_Datos.EjecutarNonQueryT(Cmd)

    '                End Select

    '            End If

    '        Next

    '    Catch ex As Exception
    '        lc_Transaccion.Rollback()
    '        Cnn.Close()
    '        TrataEx(ex)
    '        Return False
    '    End Try

    '    lc_Transaccion.Commit()
    '    Cnn.Close()
    '    Return True

    'End Function

    Public Shared Function fn_ValidaRemision(ByVal NumeroRemision As Long, ByVal Id_Cia As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_Remisiones_Existe", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True ' No existe
            Else
                Return False 'Si Existe
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarClave(ByVal clave As String, ByVal Parametro As String, ByVal Procedure As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)
        'Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, clave)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Enviar Efectivo"
    Public Shared Function fn_EnviarEfectivo_LlenarGridviewProceso(ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Saldo_GetByCaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            With Tbl
                .Columns("Cantidad").ReadOnly = False
                .Columns("Cantidad1").ReadOnly = False
                .Columns("Cantidad2").ReadOnly = False
                .Columns("Cantidad3").ReadOnly = False
                .Columns("Cantidad4").ReadOnly = False
                .Columns("Cantidad5").ReadOnly = False
                .Columns("Importe").ReadOnly = False
            End With
            Return Tbl

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EnviarEfectivo_LlenarGridviewMorralla(ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Mor_Saldo_GetByCaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            With Tbl
                .Columns("Cantidad").ReadOnly = False
                .Columns("Cantidad1").ReadOnly = False
                .Columns("Cantidad2").ReadOnly = False
                .Columns("Cantidad3").ReadOnly = False
                .Columns("Cantidad4").ReadOnly = False
                .Columns("Cantidad5").ReadOnly = False
                .Columns("Importe").ReadOnly = False
            End With
            Return Tbl

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EnviarEfectivo_LlenarGridviewClasificado(ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cla_Saldo_GetByCaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            With Tbl
                .Columns("Cantidad").ReadOnly = False
                .Columns("Cantidad1").ReadOnly = False
                .Columns("Cantidad2").ReadOnly = False
                .Columns("Cantidad3").ReadOnly = False
                .Columns("Cantidad4").ReadOnly = False
                .Columns("Cantidad5").ReadOnly = False
                .Columns("Importe").ReadOnly = False
            End With
            Return Tbl

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EnviarEfectivo_LlenarGridviewNominas(ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Nom_Saldo_GetByCaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            With Tbl
                .Columns("Cantidad").ReadOnly = False
                .Columns("Cantidad1").ReadOnly = False
                .Columns("Cantidad2").ReadOnly = False
                .Columns("Cantidad3").ReadOnly = False
                .Columns("Cantidad4").ReadOnly = False
                .Columns("Cantidad5").ReadOnly = False
                .Columns("Importe").ReadOnly = False
            End With
            Return Tbl

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EnviarEfectivo_LlenarGridviewCajeros(ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Caj_Saldo_GetByCaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            With Tbl
                .Columns("Cantidad").ReadOnly = False
                .Columns("Importe").ReadOnly = False
            End With
            Return Tbl

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EnviarEfectivo_LlenarGridviewCajaGeneral(ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer, ByVal Tipo As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_SaldoGeneral_GetByCaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            With Tbl
                .Columns("Cantidad").ReadOnly = False
                .Columns("Cantidad1").ReadOnly = False
                .Columns("Cantidad2").ReadOnly = False
                .Columns("Cantidad3").ReadOnly = False
                .Columns("Cantidad4").ReadOnly = False
                .Columns("Cantidad5").ReadOnly = False
                .Columns("Importe").ReadOnly = False
            End With
            Return Tbl

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Cancela Envio Efectivo"

    Public Shared Function fn_CancelaEnvioEfectivoLlenalista(ByVal lsv As cp_Listview, ByVal ID_CajaBancaria As Integer, ByVal TipoLote As Integer, ByVal Status As String) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesEfectivo_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, ID_CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status) '--
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_LoteE")
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).Width = 0
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            lsv.Columns(11).Width = 0
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaEnvioEfectivoDLlenalista(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesEfectivoD_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, Id_Lote)

            'Aqui se Actualiza la lista
            With lsv
                .Actualizar(Cmd, "Id_LoteE")
                .Columns(0).TextAlign = HorizontalAlignment.Right
                .Columns(1).TextAlign = HorizontalAlignment.Right
                .Columns(2).TextAlign = HorizontalAlignment.Right
                .Columns(3).TextAlign = HorizontalAlignment.Right
                .Columns(4).TextAlign = HorizontalAlignment.Right
                .Columns(5).TextAlign = HorizontalAlignment.Right
                .Columns(6).TextAlign = HorizontalAlignment.Right
                .Columns(8).TextAlign = HorizontalAlignment.Right
            End With
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaEnvioEfectivoProceso(ByVal lsv_Efectivo As cp_Listview) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
              For Each lotes As ListViewItem In lsv_Efectivo.CheckedItems

                lsv.Items.Clear()
                fn_CancelaEnvioEfectivoDLlenalista(lsv, lotes.Tag) 'id_lote

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusCancela")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, lotes.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                For Each Elemento In lsv.Items

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Sumar")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, lotes.SubItems(8).Text) 'id_cajabancaria
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                    Cn_Datos.EjecutarNonQueryT(Cmd)

                Next
            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_CancelaEnvioEfectivoMorralla(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mor_Saldo_Sumar")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_CancelaEnvioEfectivoClasificado(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cla_Saldo_Sumar")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_CancelaEnvioEfectivoNominas(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Nom_Saldo_Sumar")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_CancelaEnvioEfectivoCajeros(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_SaldoCancela_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

#End Region

#Region "Enviar Efectivo New 09/junio 2014"

    Public Shared Function fn_LotesEfectivo_Status(ByVal lsv_Efectivo As cp_Listview, ByVal Status As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_Transaccion As SqlClient.SqlTransaction
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            For Each lotes As ListViewItem In lsv_Efectivo.CheckedItems

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesEfectivo_UpdateStatus")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, lotes.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

#End Region

#Region "Aceptar Envio de Efectivo"

    'Public Shared Function fn_AceptaEnvioEfectivoLlenalista(ByVal lsv As cp_Listview, ByVal Caja As Integer, ByVal TipoLote As Integer) As Boolean
    '    Try ' 9junio 2014
    '        'Aqui se llena el Listview

    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesEfectivo_GetAceptar", CommandType.StoredProcedure, Cnn)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A") 'A
    '        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)
    '        lsv.Actualizar(Cmd, "Id_LoteE")

    '        lsv.Columns(10).Width = 0
    '        lsv.Columns(11).Width = 0
    '        lsv.Columns(4).TextAlign = HorizontalAlignment.Right
    '        lsv.Columns(5).TextAlign = HorizontalAlignment.Right
    '        lsv.Columns(7).TextAlign = HorizontalAlignment.Right
    '        lsv.Columns(8).TextAlign = HorizontalAlignment.Right
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function

    Public Shared Function fn_LoteEfectivo_Verificar(ByVal IdLote As Integer, ByVal Status As String) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesEfectivo_Read", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IdLote)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            Dim dt_lote As DataTable = EjecutaConsulta(Cmd)

            If dt_lote.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Validar_CancelacionEnvioEfectivoOtros(ByVal lsv_Efectivo As cp_Listview, ByVal IdUsuario_Recibe As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_Transaccion As SqlClient.SqlTransaction
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try
            For Each lotes As ListViewItem In lsv_Efectivo.CheckedItems
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusValida") ''ok
                Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, lotes.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Recibe", SqlDbType.Int, IdUsuario_Recibe)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AceptaEnvioEfectivoProceso(ByVal lsv_Efectivo As cp_Listview, ByVal IdUsuario_Recibe As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim lsv As New cp_Listview
        Dim Elemento As New ListViewItem
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try

            For Each lotes As ListViewItem In lsv_Efectivo.CheckedItems

                lsv.Items.Clear()
                fn_CancelaEnvioEfectivoDLlenalista(lsv, lotes.Tag)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusValida") ''ok
                Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, lotes.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Recibe", SqlDbType.Int, IdUsuario_Recibe)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                For Each Elemento In lsv.Items

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Sumar") ''ok

                    Dim ss As String = lsv.Columns.Count
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, lotes.SubItems(11).Text) 'caja bancaria


                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                    Cn_Datos.EjecutarNonQueryT(Cmd)
                Next

            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AceptaEnvioEfectivoMorralla(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer, ByVal UsuarioId As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusValida") ''ok
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Recibe", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mor_Saldo_Sumar") ''ok
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AceptaEnvioEfectivoClasificado(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer, ByVal UsuarioId As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusValida") ''ok
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Recibe", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cla_Saldo_Sumar") ''ok
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AceptaEnvioEfectivoNominas(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer, ByVal UsuarioId As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusValida") ''ok
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Recibe", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Nom_Saldo_Sumar") ''ok
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AceptaEnvioEfectivoCajeros(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer, ByVal UsuarioId As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusValida") ''ok
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Recibe", SqlDbType.Int, UsuarioId)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_SaldoCancela_Update") ''ok
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, CInt(Elemento.SubItems(1).Text) + CInt(Elemento.SubItems(2).Text) + CInt(Elemento.SubItems(3).Text) + _
                                                                           CInt(Elemento.SubItems(4).Text) + CInt(Elemento.SubItems(5).Text) + CInt(Elemento.SubItems(6).Text))

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AceptaEnvioEfectivoCajaGeneral(ByVal IDLOte As Integer, ByVal IdCajaBancaria As Integer, ByVal UsuarioID As Integer, ByVal TipoSaldo As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Elemento As New ListViewItem
        Dim lsv As New cp_Listview

        fn_CancelaEnvioEfectivoDLlenalista(lsv, IDLOte)
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_StatusValida") ''ok
            Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, IDLOte)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Recibe", SqlDbType.Int, UsuarioID)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items
                'Tipo 2 sera cuando el envio Provenga de ATMs
                'En todos los demás casos sera Tipo 1
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_SaldoGeneral_Sumar") ''ok
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, TipoSaldo)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

#End Region

#Region "Eliminar Ficha"

    Public Shared Function fn_EliminarFicha_LlenarCias(ByVal Txt_Buscar As Long, ByRef cmb As cp_cmb_Simple) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Cias_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Numero_Remision", SqlDbType.BigInt, Txt_Buscar)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            cmb.Actualizar(Tbl)
            Return Tbl.Rows.Count > 1
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EliminarFicha_LlenarListview(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "Id_Ficha")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EliminarFicha_DatosRemision(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_Remisiones_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EliminarFicha_Eliminar(ByVal Id_Ficha As Integer, ByVal Id_Servicio As Integer, ByVal Remision As Long, ByVal Numero_Ficha As String, ByVal Moneda As String, ByVal Importe As String, ByVal Cheques As String, ByVal Observaciones As String) As Boolean
        Using Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
            Dim EliminoMonto As Boolean = False

            If Not fn_EliminarFicha_EliminarCompleto(Tr, Id_Ficha) Then Return False

            If Not fn_EliminarFicha_ActualizarFichas(Tr, Id_Servicio) Then Return False

            fn_GuardaBitacora(19, "REM: " & Remision & ", Ficha: " & Numero_Ficha & " Moneda: " & Moneda & " Importe: " & Importe & " Cheques: " & Cheques & " Observaciones: " & Observaciones)
            Tr.Commit()
        End Using
        Return True
    End Function

    Private Shared Function fn_EliminarFicha_EliminarCompleto(ByVal Tr As SqlTransaction, ByVal Id_Ficha As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Fichas_DeleteCompleto")
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            EjecutarNonQueryT(cmd)
            Return True
            
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Private Shared Function fn_EliminarFicha_EliminarOtros(ByVal Tr As SqlTransaction, ByVal Id_Ficha As Integer) As Char
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_FichasOtros_DeleteByFicha")
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return "S"
            Else
                Return "N"
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return "R"
        End Try
    End Function

    Private Shared Function fn_EliminarFicha_EliminarCheques(ByVal Tr As SqlTransaction, ByVal Id_Ficha As Integer) As Char
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_FichasCheques_DeleteByFicha")
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return "S"
            Else
                Return "N"
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return "R"
        End Try
    End Function

    Private Shared Function fn_EliminarFicha_EliminarFalsos(ByVal Tr As SqlTransaction, ByVal Id_Ficha As Integer) As Char
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_FichasFalsos_DeleteByFicha")
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return "S"
            Else
                Return "N"
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return "R"
        End Try
    End Function

    Private Shared Function fn_EliminarFicha_EliminarEfectivo(ByVal Tr As SqlTransaction, ByVal Id_Ficha As Integer) As Char
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_FichasEfectivo_DeleteByFicha")
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return "S"
            Else
                Return "N"
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return "R"
        End Try
    End Function

    Private Shared Function fn_EliminarFicha_EliminarFicha(ByVal Tr As SqlTransaction, ByVal Id_Ficha As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Fichas_Delete")
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Private Shared Function fn_EliminarFicha_ActualizarFichas(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer)
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Servicios_ActualizaFichas")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
        Crea_Parametro(cmd, "@Contiene_Falsos", SqlDbType.VarChar, "N")
        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If

        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Preparar Dotaciones"

    Public Shared Function fn_PrepararDotaciones_LlenarClientes(ByVal Id_CajaBancaria As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_ByCajaAndCia", CommandType.StoredProcedure, Crea_ConexionSTD)
        'Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_GetByCia", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ProCajasBancarias_GetCR(ByVal Id_CajaBancaria As Integer) As Integer
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

            Return CInt(EjecutaConsulta(cmd).Rows(0)("CR"))
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PrepararDotaciones_LlenarDenominaciones(ByVal Id_Moneda As Integer, ByVal Presentacion As Char) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesPresentacion_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            Tbl.Columns.Add(New DataColumn("Cantidad") With {.DataType = GetType(Integer), .ReadOnly = False})
            Tbl.Columns.Add(New DataColumn("CantidadA") With {.DataType = GetType(Integer), .ReadOnly = False})
            Tbl.Columns.Add(New DataColumn("CantidadB") With {.DataType = GetType(Integer), .ReadOnly = False})
            Tbl.Columns.Add(New DataColumn("CantidadC") With {.DataType = GetType(Integer), .ReadOnly = False})
            Tbl.Columns.Add(New DataColumn("CantidadD") With {.DataType = GetType(Integer), .ReadOnly = False})
            Tbl.Columns.Add(New DataColumn("CantidadE") With {.DataType = GetType(Integer), .ReadOnly = False})
            Tbl.Columns.Add(New DataColumn("Importe") With {.DataType = GetType(Decimal), .ReadOnly = False})
            Return Tbl
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PrepararDotaciones_Guardar(ByVal Id_CajaBancaria As Integer, ByVal Id_ClienteP As Integer, _
                                                         ByVal Id_Moneda As Integer, ByVal Importe As Decimal, ByVal Fecha_Entrega As Date, _
                                                         ByVal Documentos As Char, ByVal Nomina As Char, ByVal Cantidad_Sobres As Integer, _
                                                         ByVal Tblb As DataTable, ByVal Tblm As DataTable, ByVal HoraSolicita As String, _
                                                         ByVal Tipo_Salida As Integer, ByVal Imp_Documentos As Decimal, ByVal Imp_Nom As Decimal, _
                                                         ByVal Id_CS As String) As Boolean

        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        Dim Id_Dotacion As Integer = fn_PrepararDotaciones_Crear_Dotacion(Tr, Id_CajaBancaria, Id_ClienteP, Id_Moneda, Importe, Fecha_Entrega, Documentos, Nomina, Cantidad_Sobres, HoraSolicita, Tipo_Salida, Imp_Documentos, Imp_Nom, Id_CS)

        If Id_Dotacion = 0 Then Return False

        If Documentos = "N" OrElse Importe > 0 OrElse Imp_Nom > 0 Then
            For Each Row As DataRow In Tblb.Rows
                If Not IsDBNull(Row("Importe")) AndAlso Not Row("Importe") = 0 Then
                    If Not fn_PrepararDotaciones_Crear_Detalle(Tr, Id_Dotacion, Row) Then Return False
                End If
            Next

            For Each Row As DataRow In Tblm.Rows
                If Not IsDBNull(Row("Importe")) AndAlso Not Row("Importe") = 0 Then
                    If Not fn_PrepararDotaciones_Crear_Detalle(Tr, Id_Dotacion, Row) Then Return False
                End If
            Next
        End If

        Tr.Commit()
        Return True
    End Function


    Public Shared Function fn_PrepararDotacionesH2H_Guardar(ByVal Archivo As List(Of Banorte.OdesArchivo), ByVal lsvDotaciones As cp_Listview, ByVal lsvDenominacion As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, _
                                                         ByVal Importe As Decimal, ByVal Fecha_Entrega As Date, _
                                                         ByVal Documentos As Char, ByVal Nomina As Char, ByVal Cantidad_Sobres As Integer, _
                                                         ByVal HoraSolicita As String, _
                                                         ByVal Tipo_Salida As Integer, ByVal Imp_Documentos As Decimal, ByVal Imp_Nom As Decimal, ByVal Id_Mon As Integer, ByRef _Servicio As BaseOrdenServicio) As Boolean

        Dim j As Integer = 0
        Dim IdDotaciones(j) As Integer
        Dim Id_ClienteP As Integer = 0
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        Try

            Dim Tipo As Integer = 1
            If Nomina = "S" Then Tipo = 3
            Dim Imp As Decimal = 0.0

            For Each Dotacion As ListViewItem In lsvDotaciones.CheckedItems
                j = 0
                ReDim IdDotaciones(j)


                If TypeOf _Servicio Is OrdenDotacionesClientes Then
                    Id_ClienteP = fn_ClienteProceso_GetID(Id_CajaBancaria, Dotacion.SubItems(3).Text)
                ElseIf TypeOf _Servicio Is OrdenDotacionesDivisas Then
                    Id_ClienteP = fn_ClienteProcesoID_GetCR(Id_CajaBancaria, Dotacion.SubItems(1).Text)
                End If


                'obtenemos la moneda unica que pudiera traer dotacionesD,esto con el objetivo de guardar una dotación para cada moneda
                Dim DotDMonedas = (From DD As ds_Banorte.DotacionesDRow In _Servicio.dsBanorte.DotacionesD _
                                              Where DD.Id_Dotacion = Dotacion.Tag _
                                              Select DD.Id_Moneda).Distinct()


                For Each Moneda In DotDMonedas


                    Dim DotacionesD = (From DD As ds_Banorte.DotacionesDRow In _Servicio.dsBanorte.DotacionesD _
                                      Where DD.Id_Moneda = Moneda _
                                      And DD.Id_Dotacion = Dotacion.Tag _
                                      Select DD)

                    Imp = DotacionesD.Sum(Function(r As ds_Banorte.DotacionesDRow) r.Importe)

                    Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_DotacionesH2H_Create")
                    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
                    Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
                    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                    Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
                    Crea_Parametro(cmd, "@Importe", SqlDbType.Money, (Imp + Imp_Documentos + Imp_Nom))
                    Crea_Parametro(cmd, "@Fecha_Entrega", SqlDbType.DateTime, Fecha_Entrega)
                    Crea_Parametro(cmd, "@Usuario_Captura", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Documentos", SqlDbType.VarChar, Documentos)
                    Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "SO")
                    Crea_Parametro(cmd, "@Hora_SolicitaBanco", SqlDbType.VarChar, HoraSolicita)
                    Crea_Parametro(cmd, "@Cantidad_Sobres", SqlDbType.Int, Cantidad_Sobres)
                    Crea_Parametro(cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(cmd, "@Tipo_Salida", SqlDbType.TinyInt, Tipo_Salida)
                    Crea_Parametro(cmd, "@Importe_Efectivo", SqlDbType.Money, Imp)
                    Crea_Parametro(cmd, "@Importe_Documentos", SqlDbType.Money, Imp_Documentos)
                    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, CInt(Moneda)) 'Id_Moneda

                    Dim Id As Integer = EjecutarScalarT(cmd)

                    IdDotaciones(j) = Id
                    j += 1
                    ReDim Preserve IdDotaciones(j)

                    If Id < 0 Then
                        Tr.Rollback()
                        Return 0
                    End If

                    For Each Denomincion In DotacionesD
                        cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_DotacionesD_Create1")
                        Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.Int, Id)
                        Crea_Parametro(cmd, "@Id_Denominacion", SqlDbType.Int, CInt(Denomincion.Id_Denominacion))
                        Crea_Parametro(cmd, "@Cantidad", SqlDbType.Money, CDec(Denomincion.Cantidad))
                        EjecutarNonQueryT(cmd)
                    Next

                    cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_DotacionesH2H_CreateH2H")
                    Crea_Parametro(cmd, "@Odes", SqlDbType.VarChar, Dotacion.Text)
                    Crea_Parametro(cmd, "@Id_DotacionSiac", SqlDbType.Int, Id)

                    If Tipo_Salida = 1 Then
                        Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(1).Text)
                        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Dotacion.SubItems(2).Text)
                        Crea_Parametro(cmd, "@Numero_Cuenta", SqlDbType.Int, Dotacion.SubItems(3).Text)
                        Crea_Parametro(cmd, "@Id_TipoSolicitud", SqlDbType.Int, Dotacion.SubItems(7).Text)
                        Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Dotacion.SubItems(5).Text)
                        Crea_Parametro(cmd, "@Fecha", SqlDbType.VarChar, Dotacion.SubItems(6).Text)

                    ElseIf Tipo_Salida = 2 Then
                        Crea_Parametro(cmd, "@Id_cr", SqlDbType.Int, Dotacion.SubItems(1).Text)
                        Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(2).Text)
                        Crea_Parametro(cmd, "@Id_ProveedorProceso", SqlDbType.Int, Dotacion.SubItems(4).Text)
                        Crea_Parametro(cmd, "@Id_ProveedorTraslado", SqlDbType.Int, Dotacion.SubItems(5).Text)
                        Crea_Parametro(cmd, "@Id_TipoSolicitud", SqlDbType.Int, Dotacion.SubItems(6).Text)
                        Crea_Parametro(cmd, "@Fecha", SqlDbType.VarChar, Dotacion.SubItems(7).Text)
                    ElseIf Tipo_Salida = 6 Then
                        Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(1).Text)
                        Crea_Parametro(cmd, "@Id_ProveedorProceso", SqlDbType.Int, Dotacion.SubItems(2).Text)
                        Crea_Parametro(cmd, "@Id_ProveedorTraslado", SqlDbType.Int, Dotacion.SubItems(3).Text)
                        Crea_Parametro(cmd, "@Fecha", SqlDbType.VarChar, Dotacion.SubItems(4).Text)
                    End If

                    Dim Id_DotaH2H As Integer = EjecutarScalarT(cmd)

                    For Each Denomincion In DotacionesD
                        cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_DotacionesDH2H_CreateH2H")
                        Crea_Parametro(cmd, "@Id_DotH2H", SqlDbType.Int, Id_DotaH2H)
                        Crea_Parametro(cmd, "@Id_Divisa", SqlDbType.Int, CInt(Denomincion.ID_Divisa))
                        Crea_Parametro(cmd, "@Id_TipoDivisa", SqlDbType.Money, CInt(Denomincion.ID_TipoDivisa))
                        Crea_Parametro(cmd, "@Denominacion", SqlDbType.Decimal, Denomincion.Denominacion)
                        Crea_Parametro(cmd, "@Cantidad", SqlDbType.Money, Denomincion.Cantidad)
                        Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Denomincion.Importe)
                        EjecutarNonQueryT(cmd)
                    Next
                    Tr.Commit()
                Next
            Next

            Dim OdesConfirma As Banorte.Confirmacion = Nothing
            OdesConfirma = New Banorte.Confirmacion(Archivo)
            OdesConfirma.CrearXmlElement()

            If Not OdesConfirma.Enviar() Then
                fn_OdesServicios_Cancelar(IdDotaciones)
                Throw New ApplicationException("Ocurrió un error al intentar confirmar servicios")
            End If
            IdDotaciones = Nothing
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            IdDotaciones = Nothing
            Return False
        End Try
        Return True
    End Function

    


    Private Shared Function fn_PrepararDotaciones_Crear_Dotacion(ByVal Tr As SqlTransaction, ByVal Id_CajaBancaria As Integer, _
                                                                 ByVal Id_ClienteP As Integer, ByVal Id_Moneda As Integer, _
                                                                 ByVal Importe As Decimal, ByVal Fecha_Entrega As Date, ByVal Documentos As Char, _
                                                                 ByVal Nomina As Char, ByVal Cantidad_Sobres As Integer, _
                                                                 ByVal HoraSolicita As String, ByVal Tipo_Salida As Integer, ByVal Imp_Doc As Decimal, ByVal Imp_Nominas As Decimal, _
                                                                 ByVal Id_CS As String) As Integer
        Dim Tipo As Integer = 1
        If Nomina = "S" Then Tipo = 3
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Dotaciones_Create")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Importe", SqlDbType.Money, (Importe + Imp_Doc + Imp_Nominas))
        Crea_Parametro(cmd, "@Fecha_Entrega", SqlDbType.DateTime, Fecha_Entrega)
        Crea_Parametro(cmd, "@Usuario_Captura", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Documentos", SqlDbType.VarChar, Documentos)
        Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "SO")
        Crea_Parametro(cmd, "@Hora_SolicitaBanco", SqlDbType.VarChar, HoraSolicita)
        Crea_Parametro(cmd, "@Cantidad_Sobres", SqlDbType.Int, Cantidad_Sobres)
        Crea_Parametro(cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Tipo_Salida", SqlDbType.TinyInt, Tipo_Salida)
        Crea_Parametro(cmd, "@Importe_Efectivo", SqlDbType.Money, Importe)
        Crea_Parametro(cmd, "@Importe_Documentos", SqlDbType.Money, Imp_Doc)
        Crea_Parametro(cmd, "@Id_CS", SqlDbType.VarChar, Id_CS)
        Try
            Dim Id As Integer = EjecutarScalarT(cmd)
            If Id > 0 Then
                Return Id
            Else
                Tr.Rollback()
                Return 0
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    
    Private Shared Function fn_PrepararDotaciones_Crear_Detalle(ByVal Tr As SqlTransaction, ByVal Id_Dotacion As Integer, ByVal row As DataRow) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_DotacionesD_Create")
        Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)
        Crea_Parametro(cmd, "@Id_Denominacion", SqlDbType.Int, row("Id_Denominacion"))
        If Not IsDBNull(row("Cantidad")) Then Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, row("Cantidad"))
        If Not IsDBNull(row("CantidadA")) Then Crea_Parametro(cmd, "@CantidadA", SqlDbType.Int, row("CantidadA"))
        If Not IsDBNull(row("CantidadB")) Then Crea_Parametro(cmd, "@CantidadB", SqlDbType.Int, row("CantidadB"))
        If Not IsDBNull(row("CantidadC")) Then Crea_Parametro(cmd, "@CantidadC", SqlDbType.Int, row("CantidadC"))
        If Not IsDBNull(row("CantidadD")) Then Crea_Parametro(cmd, "@CantidadD", SqlDbType.Int, row("CantidadD"))
        If Not IsDBNull(row("CantidadE")) Then Crea_Parametro(cmd, "@CantidadE", SqlDbType.Int, row("CantidadE"))

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_PrepararDotacion_ValidarGrupoDota(ByVal Id_ClienteP As Integer) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_GetGrupoDota", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ClienteProceso_GetID(ByVal Id_CajaBancaria As Integer, ByVal NumeroCuenta As String) As Integer
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_ClientesProceso_GetID", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Numero_Cuenta", SqlDbType.VarChar, NumeroCuenta)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

            Return CInt(EjecutarScalar(cmd))
        Catch ex As Exception
            TrataEx(ex)
            Return -1
        End Try
    End Function

    Public Shared Function fn_ClienteProcesoID_GetCR(ByVal Id_CajaBancaria As Integer, ByVal Cr As String) As Integer
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_ClienteProceso_GetCR", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@CR_Cliente", SqlDbType.VarChar, Cr)
            Return CInt(EjecutarScalar(cmd))
        Catch ex As Exception
            TrataEx(ex)
            Return -1
        End Try
    End Function




#End Region

#Region "Enviar Resguardo a Boveda"

    Public Shared Function fn_ValidaDotDLlenalista(ByVal lsv As cp_Listview, ByVal IdDotacion As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_DotacionesD_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, IdDotacion)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidaBoveda(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Pro_dotaciones_ValidarStatus", "@Id_Dotacion")

    End Function

    Public Shared Function fn_Boveda_Nuevo(ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer, ByVal dt As DataTable) As Boolean
        'Aqui se inserta un nuevo registro

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim lc_dr As DataRow

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 17)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)


            For Each lc_dr In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_remision", SqlDbType.Int, CInt(lc_dr("Id_remision")))
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_dotaciones_Status")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, CInt(lc_dr("Id_Dotacion")))
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "EB")
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next



        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_EnviaBovedaLlenalista(ByVal lsv As cp_Listview, ByVal Caja As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Dotaciones_GetEnviarBoveda1y3", CommandType.StoredProcedure, Cnn)
            If Caja <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "VA")
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Validacion de Dotaciones"

    Public Shared Function fn_ConsultaDatosOrigen(ByVal Id_Sucursal As Integer) As DataTable
        Dim dT As DataTable
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, Id_Sucursal)
            dT = Cn_Datos.EjecutaConsulta(Cmd)
            Return dT

        Catch ex As Exception
            TrataEx(ex)
            Return dT
        End Try

    End Function

    Public Shared Function fn_ValidaDotLlenalista(ByVal lsv As cp_Listview, ByVal Caja As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_DotacionesValidar1y3_Get", CommandType.StoredProcedure, Cnn)
            If Caja <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "SO")

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidaDotTipoCambio(ByVal IdMoneda As Integer) As String
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim dt As DataTable

        Try

            Cmd = Cn_Datos.Crea_Comando("Cat_Monedas_ReadTipoCambio", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, IdMoneda)

            dt = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return dt.Rows(0)(4).ToString
            End If


        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidaDotValidaDotacion(ByVal lsv As ListView, ByVal IdCajaBancaria As Integer) As Boolean
        'Aqui se valida el saldo
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim dt As DataTable
        Dim Elemento As ListViewItem

        Try
            Dim Tipo As Char
            Dim q = From i As ListViewItem In lsv.Items _
                    Where i.SubItems(2).Text <> 0 _
                    Or i.SubItems(3).Text <> 0 _
                    Or i.SubItems(4).Text <> 0 _
                    Or i.SubItems(5).Text <> 0 _
                    Or i.SubItems(6).Text <> 0 _
                    Select i

            If q.Count > 0 Then
                Tipo = "S"
            Else
                Tipo = "N"
            End If


            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_Comando("Pro_Saldo_Verif", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@PorTipos", SqlDbType.VarChar, Tipo)
                dt = Cn_Datos.EjecutaConsulta(Cmd)

                If dt.Rows.Count = 0 Then
                    Return False
                End If

            Next

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

        Return True

    End Function

    Public Shared Function fn_ValidaDotRemision_Create(ByVal DotacionID As Integer, ByVal lsvEnvases As ListView, ByVal Envases As Integer, ByVal EnvasesSN As Integer, _
                                                ByVal NumRemision As Long, ByVal IdCajaBancaria As Integer, ByVal ImporteTotal As Decimal, ByVal Moneda As Integer, ByVal Importe_Doc As Decimal, ByVal Importe_Efectivo As Decimal) As Boolean
        'Validar Dotaciones
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim CantidadEnvases As Integer
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim lsv As New cp_Listview
        Dim Id_ClienteP As Integer = 0
        Dim Cliente_Origen As Integer = 0
        Dim Cliente_Destino As Integer = 0

        CantidadEnvases = Envases + EnvasesSN

        fn_ValidaDotDLlenalista(lsv, DotacionID)

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            'Obtener el Id_Cliente de la Caja Bancaria y el Id_ClienteP de la Dotacion
            Dim dt As DataTable
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_DotacionesCliente_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, DotacionID)
            dt = Cn_Datos.EjecutaConsultaT(Cmd)
            If dt.Rows.Count > 0 Then
                Id_ClienteP = dt.Rows(0)("Id_ClienteP")
                'Es el Id_Cliente de la Caja Bancaria
                Cliente_Origen = dt.Rows(0)("Id_ClienteCB")
                'Es el Id_Cliente de Cat_ClientesProceso cuando el Id_Cia = CiaId
                If dt.Rows(0)("Id_Cia") = CiaId Then
                    Cliente_Destino = dt.Rows(0)("Id_Cliente")
                Else
                    Cliente_Destino = 0
                End If
            End If

            'Insertar al Remision
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumRemision)
            Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, ImporteTotal)
            Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Origen", SqlDbType.Int, Cliente_Origen)
            Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Destino", SqlDbType.Int, Cliente_Destino)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            'Insertar el Detalle de la Remision
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, Importe_Efectivo)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, Importe_Doc)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            Dim Tipo As Char
            Dim q = From i As ListViewItem In lsv.Items _
                    Where i.SubItems(2).Text <> 0 _
                    Or i.SubItems(3).Text <> 0 _
                    Or i.SubItems(4).Text <> 0 _
                    Or i.SubItems(5).Text <> 0 _
                    Or i.SubItems(6).Text <> 0 _
                    Select i

            If q.Count > 0 Then
                Tipo = "S"
            Else
                Tipo = "N"
            End If

            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@PorTipos", SqlDbType.VarChar, Tipo)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

            For Each Elemento In lsvEnvases.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.Tag.ToString)
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Dotaciones_StatusValida")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, DotacionID)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_valida", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)

            Cn_Datos.EjecutarNonQueryT(Cmd)


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

#End Region

#Region "Cancela Dotacion Envio Boveda"


    Public Shared Function fn_ValidaCanceaEnvioBoveda(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRemisiones_StatusValidar", "@ID_lote")

    End Function

    Public Shared Function fn_CancelaEnvioBovedaLlenalista(ByVal lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 17)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaEnvioBovedaDLlenalista(ByVal lsv As cp_Listview, ByVal ID As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GETDotacionesPro", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ID)
            'Aqui se Actualiza la lista

            lsv.Actualizar(Cmd, "Id_Lote")
            lsv.Columns(10).Width = 0
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaBoveda_Cancelar(ByVal Id As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_StatusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Dotaciones_StatusValidaRemision")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()

    End Function

#End Region

#Region "Recibo Dotacion a Cajeros"

    Public Shared Function fn_ValidaReciboEnvioCajero(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRemisiones_StatusValidar", "@ID_lote")

    End Function

    Public Shared Function fn_ReciboEnvioCajeroLlenalista(ByVal lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 20)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_RecibeEnvioCajeroLlenaDetalle(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GETDotacionesPro", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, Id_Lote)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            lsv.Columns(10).Width = 0
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecibeEnvioBoveda(ByVal Id As Integer, ByVal UsuarioId As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_StatusValida")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Dotaciones_StatusValidaRemision")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Return True
    End Function

#End Region

#Region "Contabilizar"

    Public Shared Function fn_LoteEfectivo_Verificar2Cont(ByVal UsuarioEnvia As Integer) As Boolean
        Dim Dt_Lote As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesEfectivo_Read2", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioEnvia)
            Dt_Lote = EjecutaConsulta(Cmd)

            If Dt_Lote.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contabilizar_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Cajero As Integer, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetRecibidos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "VE")
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)

        Try
            lsv.Actualizar(cmd, "Id_Servicio")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Contabilizar_Guardar(ByVal lsv_Servicios As cp_Listview, ByVal Cajero As Integer, ByVal Supervisor As Integer, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        Dim Id_Contabiliza As Integer = fn_Contabilizar_Contabilizar(Tr, Supervisor, Cajero)
        If Id_Contabiliza = 0 Then Return False

        For Each item As ListViewItem In lsv_Servicios.CheckedItems
            'Pendiente Corregir la funcion "fn_Contabilizar_SumarSaldo" ya que no debe sumar el saldo total de las Remisiones
            'Contabilizadas, ya que pudo haber Retiros Parciales
            If Not fn_Contabilizar_SumarSaldo(Tr, item.Tag) Then Return False

            If Not fn_Contabilizar_UpdateServicios(Tr, item.Tag, Supervisor, Id_Contabiliza) Then Return False

            'Si el Id_Servicio existe en Mor_RegistroRemision se debe enviar el saldo de monedas a Mor_Saldo
            If fn_Contabilizar_ExisteRegistroRemision(Tr, item.Tag) Then
                If Not fn_Contabilizar_RestarMonedas(Tr, item.Tag) Then Return False
            End If
            'Aqui se recalcula el movimiento
            If Not fn_Movimiento_Recalcular(Tr, item.Tag) Then Return False
        Next
        'Funcion que Restara SaldoTotal - LO enviado 9/02/2014
        If Not fn_Contabilizar_RestarSaldoEnviado(Tr, Id_CajaBancaria, Cajero) Then Return False
        'Marcar los Lotes_Efectivo como Contabilizado='S'
        If Not fn_Contabilizar_UpdateRetirosParciales(Tr, Cajero, Id_Contabiliza) Then Return False
        Tr.Commit()
        Return True
    End Function
    Private Shared Function fn_Contabilizar_Contabilizar(ByVal Tr As SqlTransaction, ByVal Supervisor As Integer, ByVal Cajero As Integer) As Integer
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Contabiliza_Create")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Supervisor", SqlDbType.Int, Supervisor)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Cajero)

        Try
            Dim Id As Integer = EjecutarScalarT(cmd)
            If Id > 0 Then
                Return Id
            Else
                Tr.Rollback()
                Return 0
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Private Shared Function fn_Contabilizar_UpdateRetirosParciales(ByVal Tr As SqlTransaction, ByVal Cajero As Integer, ByVal Id_Contabiliza As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_LotesEfectivo_Contabiliza")
        Crea_Parametro(cmd, "@Usuario_Envia", SqlDbType.Int, Cajero)
        Crea_Parametro(cmd, "@Id_Contabiliza", SqlDbType.Int, Id_Contabiliza)

        Try

            EjecutarNonQueryT(cmd)
            Return True

        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Private Shared Function fn_Contabilizar_SumarSaldo(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Saldo_SumarServicio")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

        Try
            EjecutarNonQueryT(cmd)
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Private Shared Function fn_Contabilizar_UpdateServicios(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer, ByVal Supervisor As Integer, ByVal Id_Contabiliza As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Servicios_Contabiliza")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
        Crea_Parametro(cmd, "@Usuario_Contabiliza", SqlDbType.Int, Supervisor)
        Crea_Parametro(cmd, "@Id_Contabiliza", SqlDbType.Int, Id_Contabiliza)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contabilizar_ExisteRegistroRemision(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer) As Boolean
        Dim dt As DataTable
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Mor_RegistroRemision_ReadByServicio")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

        Try
            dt = EjecutaConsultaT(cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Private Shared Function fn_Contabilizar_RestarMonedas(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Saldo_RestarMonedas")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

        Try
            EjecutarNonQueryT(cmd)
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Private Shared Function fn_Contabilizar_RestarSaldoEnviado(ByVal Tr As SqlTransaction, ByVal IdCajaBancaria As Integer, ByVal Cajero As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Saldo_RestarLotesEnviados")
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
        Crea_Parametro(cmd, "@Usuario_Envia", SqlDbType.Int, Cajero)

        Try
            EjecutarNonQueryT(cmd)
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Preparar Resguardo"

    Public Shared Function fn_PrepararResguardoConsulta(ByVal Idcaja As Integer, ByVal idMoneda As Integer) As DataTable
        Dim lc_tabla As New DataTable
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_SALDO_GETResguardos", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Idcaja)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, idMoneda)

            lc_tabla = EjecutaConsulta(Cmd)

            lc_tabla.Columns(4).ReadOnly = False
            lc_tabla.Columns(6).ReadOnly = False
            lc_tabla.Columns(8).ReadOnly = False
            lc_tabla.Columns(10).ReadOnly = False
            lc_tabla.Columns(12).ReadOnly = False
            lc_tabla.Columns(14).ReadOnly = False
            lc_tabla.Columns(15).ReadOnly = False

            Return lc_tabla
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_PrepararResguardoValidaResguardo(ByVal dt As DataTable, ByVal IdCajaBancaria As Integer) As Boolean
        'Aqui se valida el saldo
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim dt_paso As New DataTable
        Dim Elemento As DataRow

        Try

            For Each Elemento In dt.Rows

                Cmd = Cn_Datos.Crea_Comando("Pro_Saldo_Verif", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento(0))
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento(4))
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento(6))
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento(8))
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento(10))
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento(12))
                Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento(14))

                dt_paso = Cn_Datos.EjecutaConsulta(Cmd)

                If dt_paso.Rows.Count = 0 Then
                    Return False
                End If

            Next

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

        Return True

    End Function

    Public Shared Function fn_PreparaResguardo_Create(ByVal dt As DataTable, ByVal lsvEnvases As ListView, ByVal Envases As Integer, ByVal EnvasesSN As Integer _
                                            , ByVal NumRemision As Long, ByVal IdCajaBancaria As Integer, ByVal ImporteTotal As Decimal, ByVal Moneda As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim CantidadEnvases As Integer
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim lc_identity As Integer
        Dim lc_idResguardo As Integer
        Dim DR As DataRow
        Dim Elemento As ListViewItem

        CantidadEnvases = Envases + EnvasesSN

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumRemision)
            Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, ImporteTotal)

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Resguardos_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, ImporteTotal)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

            lc_idResguardo = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, ImporteTotal)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, 0)

            Cn_Datos.EjecutarNonQueryT(Cmd)


            For Each DR In dt.Rows

                If DR.Item("Resguardar") > 0 Or DR.Item("ResguardarA") > 0 Or DR.Item("ResguardarB") > 0 Or DR.Item("ResguardarC") > 0 _
                Or DR.Item("ResguardarD") > 0 Or DR.Item("ResguardarE") > 0 Then

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_ResguardosD_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Resguardo", SqlDbType.Int, lc_idResguardo)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, DR.Item("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, DR.Item("Resguardar"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, DR.Item("ResguardarA"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, DR.Item("ResguardarB"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, DR.Item("ResguardarC"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, DR.Item("ResguardarD"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, DR.Item("ResguardarE"))

                    Cn_Datos.EjecutarNonQueryT(Cmd)


                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Update")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, IdCajaBancaria)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, DR.Item("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, DR.Item("Resguardar"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, DR.Item("ResguardarA"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, DR.Item("ResguardarB"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, DR.Item("ResguardarC"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, DR.Item("ResguardarD"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, DR.Item("ResguardarE"))

                    Cn_Datos.EjecutarNonQueryT(Cmd)

                End If


            Next

            For Each Elemento In lsvEnvases.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.Tag.ToString)
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next



        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

#End Region

#Region "Enviar Resguardo a Boveda"

    Public Shared Function fn_EnvBovedaResLlenalista(ByVal lsv As cp_Listview, ByVal Caja As Integer, Optional ByVal tipo As frm_CancelaResguardo.Modo = frm_CancelaResguardo.Modo.Cancela) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Resguardos_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            If tipo = frm_CancelaResguardo.Modo.Cancela Then
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Else
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "DV")
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)

            If Caja <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@id_CajaBancaria", SqlDbType.Int, Caja)
            End If

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Resguardo")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EnvBovedaResDLlenalista(ByVal lsv As cp_Listview, ByVal ID As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ResguardosD_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Resguardo", SqlDbType.Int, ID)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Resguardo")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidaBovedaResg(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_ResguardosD_ValidarStatus", "@Id_Resguardo")

    End Function

    Public Shared Function fn_BovedaResg_Nuevo(ByVal Cantidad_Remisiones As Integer, ByVal Cantidad_Envases As Integer, ByVal dt As DataTable) As Boolean
        'Aqui se inserta un nuevo registro

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim lc_dr As DataRow

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 7)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)


            For Each lc_dr In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_remision", SqlDbType.Int, CInt(lc_dr("Id_remision")))
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Resguardos_Status")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Resguardo", SqlDbType.Int, CInt(lc_dr("Id_Resguardo")))
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "EB")
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next



        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

#End Region

#Region "Cancela Resguardo Envio Boveda"

    Public Shared Function fn_ValidaCanceaResgEnvioBoveda(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRemisiones_StatusValidar", "@ID_lote")

    End Function

    Public Shared Function fn_CancelaEnvioResgBovedaLlenalista(ByVal lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 7)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaEnvioResgBovedaDLlenalista(ByVal lsv As cp_Listview, ByVal ID As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GETResguardos", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ID)
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaResgBoveda_Cancelar(ByVal Id As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_statusCancela")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Resguardos_StatusCancelaEnvio")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()

    End Function

#End Region

#Region "Recibo Resguardo a Cajeros"

    Public Shared Function fn_ReciboResgEnvioCajeroLlenalista(ByVal lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, 12)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_RecibeResgEnvioBoveda(ByVal Id As Integer, ByVal UsuarioId As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_StatusValida")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Resguardos_StatusValidaRemision")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, Id)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Return True
    End Function

#End Region

#Region "Cancelar Dotacion"

    Public Shared Function fn_CancelaDotLlenalista(ByVal lsv As cp_Listview, ByVal Caja As Integer) As Boolean
        Try
            'Aqui se llena el listview 
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_DotacionesCancela1y3_Get", CommandType.StoredProcedure, Cnn)
            If Caja <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@id_CajaBancaria", SqlDbType.Int, Caja)
            End If

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaDotDLlenaLista(ByVal lsv As cp_Listview, ByVal Id_Dotacion As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_DotacionesD_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelaDotaciones_Read(ByVal Id_Dotacion As Integer) As DataTable
        Try
            Dim Dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Dotaciones_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)
            Dt = Cn_Datos.EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CancelaDotaciones_ReadDetalle(ByVal Id_Dotacion As Integer) As DataTable
        Try
            Dim Dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_DotacionesD_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)
            Dt = Cn_Datos.EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CancelaDotaciones(ByVal Id_Dotacion As Integer, ByVal Comentarios_Cancela As String) As Boolean
        'Primero debo hacer una consulta para sacar Id_CajaBancaria, y el Status
        Dim Dt As DataTable
        Dim Dt_Detalle As DataTable
        Dim Id_CajaBancaria As Integer = 0
        Dim St As String = ""
        Dt = fn_CancelaDotaciones_Read(Id_Dotacion)
        If Dt Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los datos de la Dotación.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
            Exit Function
        End If
        If Dt.Rows.Count = 0 Then
            MsgBox("Ocurrió un error al intentar consultar los datos de la Dotación.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
            Exit Function
        End If
        Id_CajaBancaria = Dt.Rows(0)("Id_CajaBancaria")
        St = Dt.Rows(0)("Status")
        Dt.Dispose()
        If St.ToUpper <> "SO" And St.ToUpper <> "VA" Then
            MsgBox("La Dotación ya no está disponible para cancelar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
            Exit Function
        End If
        'Leer el Detalle para regresar el saldo cuando está validada
        If St.ToUpper = "VA" Then
            Dt_Detalle = fn_CancelaDotaciones_ReadDetalle(Id_Dotacion)
            If Dt_Detalle Is Nothing Then
                MsgBox("Ocurrió un error al intentar consultar el desglose de la Dotación.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
                Exit Function
            End If
        End If

        'Proceder con la cancelación
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim Tr As SqlClient.SqlTransaction
        Tr = Cn_Datos.crear_Trans(Cnn)
        Try
            If St.ToUpper = "VA" Then
                For Each Elemento As DataRow In Dt_Detalle.Rows
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Pro_SaldoCancela_Update")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Denominacion", SqlDbType.Int, Elemento("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento("Cantidad"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento("CantidadA"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento("CantidadB"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento("CantidadC"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento("CantidadD"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento("CantidadE"))

                    Cn_Datos.EjecutarNonQueryT(Cmd)
                Next
            End If
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Pro_DotacionesCancela_Status")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Comentarios_Cancela", SqlDbType.VarChar, Comentarios_Cancela)

            Cn_Datos.EjecutarNonQueryT(Cmd)
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        Tr.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_ValidaDotNombCliente(ByVal IDDotacion As Integer) As String()
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim dt As DataTable
        Dim Cadena(4) As String
        Try
            Cmd = Cn_Datos.Crea_Comando("Pro_DotacionesCliente_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, IDDotacion)
            dt = Cn_Datos.EjecutaConsulta(Cmd)

            Cadena(0) = dt.Rows(0)(0).ToString
            Cadena(1) = dt.Rows(0)(1).ToString
            Cadena(2) = dt.Rows(0)(2).ToString
            Cadena(3) = dt.Rows(0)(3).ToString
            Return Cadena
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
        Return Nothing
    End Function

#End Region

#Region "Cancelar Resguardo"

    Public Shared Function fn_CancelaResLlenalista(ByVal lsv As cp_Listview, ByVal Caja As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_DotacionesCancela_Get", CommandType.StoredProcedure, Cnn)

            If Caja <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@id_CajaBancaria", SqlDbType.Int, Caja)
            End If

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CancelaResRemision(ByVal Tipo As frm_CancelaResguardo.Modo, ByVal Items As cp_Listview.CheckedListViewItemCollection) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim lc_Transaccion As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)

        For Each item As ListViewItem In Items
            Dim Elemento As ListViewItem
            Dim lsv As New cp_Listview

            fn_EnvBovedaResDLlenalista(lsv, item.Tag)

            Try
                For Each Elemento In lsv.Items

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_SaldoCancela_Update")
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, item.SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Elemento.SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Elemento.SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Elemento.SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Elemento.SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Elemento.SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Elemento.SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Elemento.SubItems(6).Text)

                    Cn_Datos.EjecutarNonQueryT(Cmd)

                Next

                Select Case Tipo
                    Case frm_CancelaResguardo.Modo.Cancela
                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Resguardos_StatusCancela")
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Resguardo", SqlDbType.Int, item.Tag)
                        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)

                        Cn_Datos.EjecutarNonQueryT(Cmd)

                    Case frm_CancelaResguardo.Modo.Reintegra
                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Resguardos_StatusValida")
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Resguardo", SqlDbType.Int, item.Tag)
                        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)

                        Cn_Datos.EjecutarNonQueryT(Cmd)

                End Select

            Catch ex As Exception
                lc_Transaccion.Rollback()
                Cnn.Close()
                TrataEx(ex)
                Return False
            End Try
        Next

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_ValidaResNombCliente(ByVal IDDotacion As Integer) As String()
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim dt As DataTable
        Dim Cadena(4) As String
        Try

            Cmd = Cn_Datos.Crea_Comando("Pro_DotacionesCliente_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, IDDotacion)
            dt = Cn_Datos.EjecutaConsulta(Cmd)

            Cadena(0) = dt.Rows(0)(0).ToString
            Cadena(1) = dt.Rows(0)(1).ToString
            Cadena(2) = dt.Rows(0)(2).ToString
            Cadena(3) = dt.Rows(0)(3).ToString

            Return Cadena

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try


        Return Nothing

    End Function

#End Region

#Region "Consulta Saldo"

    Public Shared Function fn_ConsultaSaldo_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As Decimal
        Dim cmd As SqlCommand = Crea_Comando("Pro_Saldo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Dim Res As Decimal = 0D
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            lsv.Actualizar(cmd, "Id_Denominacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right

            For Each item As ListViewItem In lsv.Items
                Res += item.SubItems(8).Text
            Next

            Return Res
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ConsultaSaldo_LlenarMazos(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As Decimal
        Dim cmd As SqlCommand = Crea_Comando("Pro_Saldo_GetMazos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Dim Res As Decimal = 0D
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            lsv.Actualizar(cmd, "Id_Denominacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right


            For Each item As ListViewItem In lsv.Items
                Res += item.SubItems(7).Text
            Next

            Return Res
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

#End Region

#Region "Consulta de Saldos2 6/06/2014"
    Public Shared Function fn_ConsultaSaldos_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal CajeroVerificador As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetSaldo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, CajeroVerificador)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            lsv.Actualizar(cmd, "")

            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaSaldosEnvios_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Tipo_Lote As Integer, ByVal CajeroEnvia As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_LotesEfectivoD_GetByUsuario", CommandType.StoredProcedure, Crea_ConexionSTD)

        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Usuario_Envia", SqlDbType.Int, CajeroEnvia)
        Crea_Parametro(cmd, "@Tipo_Lote", SqlDbType.TinyInt, Tipo_Lote)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try

            lsv.Actualizar(cmd, "Id_Denominacion")
            'lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right

            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_EnvioEfectivo_ConsultaEfectivoLotes(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, _
                                                          ByVal Presentacion As Char, ByVal CajeroEnvia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_LotesEfectivo_GetbyUsuario", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Usuario_Envia", SqlDbType.Int, CajeroEnvia)
        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            Return Tbl
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EnviarEfectivo_LlenarGridview(ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer, ByVal CajeroEnvia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_GetByCaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, CajeroEnvia)
        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            Return Tbl

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ConsultaSaldosEfectivo_LlenaLista(ByVal Id_CajaBancarias As Integer, ByVal Id_Moneda As Integer, _
                                                               ByVal Presentacion As String, ByVal Lsv As cp_Listview, ByVal CajeroEnvia As Integer) As Boolean

        Dim Dt_SaldoLotes As New DataTable
        Dim Dt_SaldoCaja As New DataTable

        Dt_SaldoLotes = Cn_Proceso.fn_EnvioEfectivo_ConsultaEfectivoLotes(Id_CajaBancarias, Id_Moneda, Presentacion, CajeroEnvia)
        Dt_SaldoCaja = Cn_Proceso.fn_EnviarEfectivo_LlenarGridview(Id_CajaBancarias, Presentacion, Id_Moneda, CajeroEnvia)

        If Dt_SaldoLotes Is Nothing Then
            MsgBox("Ocurrio un Error al Consultar el Saldo de los Lotes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If Dt_SaldoCaja Is Nothing Then
            MsgBox("Ocurrio un Error al Consultar el Saldo de la Caja.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        With Dt_SaldoCaja
            .Columns("Saldo").ReadOnly = False
            .Columns("Importe").ReadOnly = False
            .Columns("Total").ReadOnly = False
        End With

        For Each RowCaja As DataRow In Dt_SaldoCaja.Rows
            For Each RowLotes As DataRow In Dt_SaldoLotes.Rows
                If RowCaja("Id_Denominacion") = RowLotes("Id_Denominacion") Then
                    RowCaja("Saldo") = (RowCaja("Saldo") - RowLotes("Saldo"))
                    RowCaja("Total") = (RowCaja("Saldo") * CDec(RowCaja("Denominacion")))
                    Exit For
                Else
                    Continue For
                End If
            Next
        Next

        For Each Elem As DataRow In Dt_SaldoCaja.Rows
            Lsv.Items.Add(Elem("Denominacion"))
            Lsv.Items(Lsv.Items.Count - 1).SubItems.Add(Elem("Saldo"))
            Lsv.Items(Lsv.Items.Count - 1).SubItems.Add(FormatNumber(Elem("Total")))
        Next
        Return True

        Dt_SaldoCaja.Dispose()
        Dt_SaldoLotes.Dispose()

    End Function

#End Region

#Region "Consulta Saldo General"

    Public Shared Function fn_ConsultaSaldoGeneral_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As Decimal
        Dim cmd As SqlCommand = Crea_Comando("Pro_SaldoGeneral_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Dim Res As Decimal = 0D
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            lsv.Actualizar(cmd, "Id_Denominacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right

            For Each item As ListViewItem In lsv.Items
                Res += item.SubItems(8).Text
            Next

            Return Res
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ConsultaSaldoGeneral_LlenarMazos(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Presentacion As Char, ByVal Id_Moneda As Integer) As Decimal
        Dim cmd As SqlCommand = Crea_Comando("Pro_SaldoGeneral_GetMazos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Dim Res As Decimal = 0D
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            lsv.Actualizar(cmd, "Id_Denominacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right


            For Each item As ListViewItem In lsv.Items
                Res += item.SubItems(7).Text
            Next

            Return Res
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

#End Region

#Region "Ver Reportes"
    Public Shared Function fn_VerReportes_LlenarHojaTrabjo(ByVal Tbl As ds_Reportes.Tbl_HojaTrabajoDataTable, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte_Turno As Integer, ByVal Cajero As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Rep_HojaTrabajo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Corte_Turno", SqlDbType.Int, Corte_Turno)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Cajero)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

        Try
            Tbl.Rows.Clear()
            cmd.Connection.Open()
            Tbl.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VerReportes_LlenarHojaTrabjo2(ByVal Tbl As ds_Reportes.Tbl_DenominacionDataTable, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte_Turno As Integer, ByVal Cajero As Integer, ByVal Presentacion As Char) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Rep_HojaTrabajo_Sub", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Corte_Turno", SqlDbType.Int, Corte_Turno)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Cajero)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

        Try
            Tbl.Rows.Clear()
            cmd.Connection.Open()
            Tbl.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VerReportes_LlenarLogo(ByVal Tbl As ds_Reportes.Tbl_DatosEmpresaDataTable) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Tbl.Rows.Clear()
            cmd.Connection.Open()
            Tbl.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Consulta de Dotaciones"

    Public Shared Function fn_ConsultaDotaciones_LlenarRemisiones(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, _
                                                                  ByVal Tipo_Consulta As Char, ByVal F_Desde As DateTime, _
                                                                  ByVal F_Hasta As DateTime, ByVal S_Desde As Integer, _
                                                                  ByVal S_Hasta As Integer, ByVal Id_Moneda As Integer, _
                                                                  ByVal Status As String, ByVal CorteCaptura As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Remisiones_GeyByDotaciones", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Tipo_Consulta", SqlDbType.VarChar, Tipo_Consulta)
        If Not F_Desde = Nothing Then Crea_Parametro(cmd, "@F_Desde", SqlDbType.DateTime, F_Desde)
        If Not F_Hasta = Nothing Then Crea_Parametro(cmd, "@F_Hasta", SqlDbType.DateTime, F_Hasta)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, S_Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(cmd, "@CorteCaptura", SqlDbType.Int, CorteCaptura)

        Try
            lsv.Actualizar(cmd, "Id_Dotacion")

            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaDotaciones_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Dotacion As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_DotacionesD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)

        Try
            lsv.Actualizar(cmd, "Id_Dotacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Consulta de Depositos"

    Public Shared Function fn_ConsultaDepositos_LlenarRemisiones(ByVal lsv As cp_Listview,
                                                                 ByVal Id_CajaBancaria As Integer,
                                                                 ByVal Tipo_Consulta As Char,
                                                                 ByVal F_Desde As Date,
                                                                 ByVal F_Hasta As Date,
                                                                 ByVal S_Desde As Integer,
                                                                 ByVal S_Hasta As Integer,
                                                                 ByVal Status As String,
                                                                 ByVal CorteCaptura As Integer,
                                                                 ByVal idClienteP As Integer,
                                                                 ByVal Id_Cajero As Integer, dat As DataGridView) As Boolean

        Dim Cmd As New SqlCommand
        If Tipo_Consulta = "F" Then
            Cmd = Crea_Comando("Pro_Servicios_GetByFechas", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(Cmd, "@F_Desde", SqlDbType.Date, F_Desde)
            Crea_Parametro(Cmd, "@F_Hasta", SqlDbType.Date, F_Hasta)
        ElseIf Tipo_Consulta = "S" Then
            Cmd = Crea_Comando("Pro_Servicios_GetBySesionesPrueba", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(Cmd, "@S_Desde", SqlDbType.Int, S_Desde)
            Crea_Parametro(Cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        End If
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(Cmd, "@CorteCaptura", SqlDbType.Int, CorteCaptura)
        Crea_Parametro(Cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")
        Crea_Parametro(Cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, idClienteP)
        'dat.DataSource = EjecutaConsulta(Cmd)

        Try
            lsv.Actualizar(Cmd, "Id_Remision")

            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).Width = 300
            lsv.Columns(11).Width = 150
            lsv.Columns(12).Width = 100
            lsv.Columns(13).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaDepositos_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Dotacion As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_DotacionesD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)

        Try
            lsv.Actualizar(cmd, "Id_Dotacion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function Fn_ConsultaDepositos_Desbloqueo(ByVal Id_Servicio As Integer, ByVal Status As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_Transaccion As SqlClient.SqlTransaction
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Servicios_Status")
            Crea_Parametro(Cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQueryT(Cmd)

            'Inserta en Usr_Bitacora
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Usr_Bitacora_create")
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 38)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, "Se Desbloqueo el Servicio de Depósito")
            Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
            Crea_Parametro(Cmd, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
            Crea_Parametro(Cmd, "@Version", SqlDbType.VarChar, ModuloVersion)
            Crea_Parametro(Cmd, "@Id", SqlDbType.VarChar, Id_Servicio)
            EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function
#End Region

#Region "Consulta de Depositos (Importes Procesados)"
    'Se toma el importe de las fichas y no de las remisiones
    Public Shared Function fn_ConsultaDepositos_LlenarProcesado(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, _
                                                                  ByVal Tipo_Consulta As Char, ByVal F_Desde As Date, _
                                                                  ByVal F_Hasta As Date, ByVal S_Desde As Integer, _
                                                                  ByVal S_Hasta As Integer, _
                                                                  ByVal CorteCaptura As Integer) As Boolean

        Dim Cmd As New SqlCommand
        If Tipo_Consulta = "F" Then
            Cmd = Crea_Comando("Pro_Servicios_GetProcesado2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(Cmd, "@F_Desde", SqlDbType.Date, F_Desde)
            Crea_Parametro(Cmd, "@F_Hasta", SqlDbType.Date, F_Hasta)
        ElseIf Tipo_Consulta = "S" Then
            Cmd = Crea_Comando("Pro_Servicios_GetProcesado1", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(Cmd, "@S_Desde", SqlDbType.Int, S_Desde)
            Crea_Parametro(Cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        End If
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@CorteCaptura", SqlDbType.Int, CorteCaptura)
        Crea_Parametro(Cmd, "@Dpto_Procesa", SqlDbType.VarChar, "T")
        Crea_Parametro(Cmd, "@Cajero", SqlDbType.Int, 0)

        Try
            lsv.Actualizar(Cmd, "Id_Remision")

            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region


#Region "Billetes falsos"
    Public Shared Function fn_ConsultaDepositos_BilletesFalsos(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, _
                                                                 ByVal Tipo_Consulta As Char, ByVal F_Desde As Date, _
                                                                 ByVal F_Hasta As Date, ByVal S_Desde As Integer, _
                                                                 ByVal S_Hasta As Integer, ByVal CorteCaptura As Integer) As Boolean

        Dim Cmd As New SqlCommand

        Cmd = Crea_Comando("Pro_Servicios_GetFalsos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@F_Desde", SqlDbType.Date, F_Desde)
        Crea_Parametro(Cmd, "@F_Hasta", SqlDbType.Date, F_Hasta)
        Crea_Parametro(Cmd, "@S_Desde", SqlDbType.Int, S_Desde)
        Crea_Parametro(Cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        Crea_Parametro(Cmd, "@CorteCaptura", SqlDbType.Int, CorteCaptura)
        Crea_Parametro(Cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")
        Crea_Parametro(Cmd, "@Tipo_Consulta", SqlDbType.VarChar, Tipo_Consulta)

        Try
            lsv.Actualizar(Cmd, "IDR")

            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).Width = 300
            'lsv.Columns(11).Width = 100
            'lsv.Columns(12).Width = 0

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_Fichas_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "Id_Ficha")

            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Fichas_Efectivo(ByVal lsv As cp_Listview, ByVal Id_Ficha As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            lsv.Actualizar(cmd, "Id_Denominacion")

            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Fichas_EfectivoFalso(ByVal lsv As cp_Listview, ByVal Id_Ficha As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasFalsos_GetbyId_Ficha", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            lsv.Actualizar(cmd, "Id_Ficha")

            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Fichas Modal"

    Public Shared Function fn_FichasModal_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "Id_Ficha")
            'lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Desglose Modal"

    Public Shared Function fn_DesgloseModal_LlenarEfectivoFicha(ByRef lsv As cp_Listview, ByVal Id_Ficha As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)
        Try
            lsv.Actualizar(cmd, "Id_Denominacion")

            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DesgloseModal_LlenarChequesFicha(ByRef lsv As cp_Listview, ByVal Id_Ficha As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasCheques_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            lsv.Actualizar(cmd, "Id_Cheque")

            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DesgloseModal_LlenarOtrosFicha(ByRef lsv As cp_Listview, ByVal Id_Ficha As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasOtros_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)

        Try
            lsv.Actualizar(cmd, "Id_Ficha")

            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DesgloseModal_LlenarEfectivoParcial(ByRef lsv As cp_Listview, ByVal Id_Parcial As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_ParcialesD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Parcial", SqlDbType.Int, Id_Parcial)

        Try
            lsv.Actualizar(cmd, "Id_Parcial")

            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Parciales Modal"

    Public Shared Function fn_ParcialesModal_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Parciales_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "Id_Parcial")

            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Archivo de deposito de clientes"

    Public Shared Function fn_DepositoClientes_CrearTabla(ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte As Integer, ByVal Id_Cajero As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("pro_Fichas_GetReporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositoClientes_CrearTablaEnvase(ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte As Integer, ByVal Id_Cajero As Integer, ByVal Id_Cia As Integer) As DataTable

        Dim dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_GetReporteEnvases", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Sub fn_DepositoClientes_LlenarFichas(ByRef Fichas As ds_Reportes.Tbl_FichasDataTable, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte As Integer, ByVal Id_Cajero As Integer, ByVal Id_Cia As Integer)
        Dim cmd As SqlCommand = Crea_Comando("pro_Fichas_GetDepositos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            cmd.Connection.Open()
            Fichas.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Sub fn_DepositoClientes_LlenarFichasEfectivoFalso(ByRef Fichas As ds_Reportes.Tbl_FichasFalsosDataTable, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte As Integer, ByVal Id_Cajero As Integer, ByVal Id_Cia As Integer)
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasFalsos_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            cmd.Connection.Open()
            Fichas.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Sub fn_DepositoClientes_LlenarFichasEfectivo(ByRef Fichas As ds_Reportes.Tbl_FichasEfectivoDataTable, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte As Integer, ByVal Id_Cajero As Integer, ByVal Id_Cia As Integer)
        Dim cmd As SqlCommand = Crea_Comando("pro_FichasEfectivo_ReporteDenominaciones", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            cmd.Connection.Open()
            Fichas.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Function fn_ConsultarDenominaciones(ByVal Id_Moneda As Integer, ByVal Presentacion As String) As DataTable
        Dim DT As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Denominaciones_GetAsc", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try
            DT = Cn_Datos.EjecutaConsulta(cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Sub fn_DepositoClientes_LlenarCheques(ByRef Fichas As ds_Reportes.Tbl_ChequesDataTable, ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Corte As Integer, ByVal Id_Cajero As Integer, ByVal Id_Cia As Integer)
        Dim cmd As SqlCommand = Crea_Comando("pro_FichasEfectivo_ReporteCheques", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            cmd.Connection.Open()
            Fichas.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

#End Region

#Region "Clientes Proceso Anterior"

    ''' <summary>
    ''' Llena una lista de la tabla Cat_ClientesProceso
    ''' </summary>
    ''' <param name="lsv">Es la lista que se va a llenar</param>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_ClientesProceso_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Id_Cia As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            lsv.Actualizar(cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Clientes_Generales(ByVal id As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_Clientes_Read2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, id)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
        If Tbl.Rows.Count > 0 Then
            Return Tbl.Rows(0)
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function fn_ClientesProceso_Generales(ByVal Id_ClienteP As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_GetById", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
        If Tbl.Rows.Count > 0 Then
            Return Tbl.Rows(0)
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function fn_Clientes_Lugar(ByVal Zona As Integer) As Array
        Dim Resultado(3) As Integer

        Dim Cmd As SqlCommand = Crea_Comando("Cat_PaisesZona_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Zona", SqlDbType.Int, Zona)

        Try
            Return EjecutaConsulta(Cmd).Rows(0).ItemArray
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

        Cmd.Dispose()
        MsgBox("Es cierto")
    End Function


    Public Shared Function fn_Cuentas_Status(ByRef Id As Integer, ByVal Status As String) As DataTable

        Dim Cmd As SqlCommand = Crea_Comando("Cat_ClientesPcuentas_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, Id)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Clientes Proceso Nuevo"

    ''' <summary>
    ''' Llena una lista de la tabla Cat_ClientesProceso
    ''' </summary>
    ''' <param name="lsv">Es la lista que se va a llenar</param>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_ClientesProceso_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Id_Cia As Integer, ByVal Activos As Boolean) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, If(Activos, "S", "N"))

        Try
            lsv.Actualizar(cmd, "Id_ClienteP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Da de alta un nuevo registro en la tabla Cat_ClientesProceso
    ''' </summary>    
    ''' <param name="Clave_Cliente">Es la clave del cliente</param>
    ''' <param name="Direccion_Comercial">Es la Direccion del cliente</param>
    ''' <param name="Id_CajaBancaria">Es el id de la tabla caja bancaria</param>
    ''' <param name="Id_Ciudad">Es el id de la ciudad</param>
    ''' <param name="Id_Cliente">Es el id del cliente</param>
    ''' <param name="Id_Grupo">Es el id del grupo</param>
    ''' <param name="Nombre_Comercial">Es el nombre comercial</param>
    ''' <param name="Numero_Contrato">Es el numero del contrato</param>
    ''' <param name="Requiere_Cuenta">Es un campo S / N que indica si el cliente tiene cuentas</param>
    Public Shared Function fn_ClientesProceso_Crear(ByVal Id_Cliente As Integer, ByVal Id_Cia As Integer, ByVal Clave_Cliente As String, ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer, _
                                                    ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String, ByVal Requiere_Cuenta As Char, ByVal GrupoDepo As Integer, ByVal GrupoDota As Integer, ByVal Usuario_Registro As Integer, ByVal Estacion_Registro As String) As Integer

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)

        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)

        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, GrupoDepo)
        Crea_Parametro(cmd, "@Id_GrupoDota", SqlDbType.Int, GrupoDota)
        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, Usuario_Registro)
        Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, Estacion_Registro)

        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Modifica registro en la tabla Cat_ClientesProceso
    ''' </summary>    
    ''' <param name="Clave_Cliente">Es la clave del cliente</param>
    ''' <param name="Direccion_Comercial">Es la Direccion del cliente</param>
    ''' <param name="Id_CajaBancaria">Es el id de la tabla caja bancaria</param>
    ''' <param name="Id_Ciudad">Es el id de la ciudad</param>
    ''' <param name="Id_Cliente">Es el id del cliente</param>
    ''' <param name="Id_Grupo">Es el id del grupo</param>
    ''' <param name="Nombre_Comercial">Es el nombre comercial</param>
    ''' <param name="Numero_Contrato">Es el numero del contrato</param>
    ''' <param name="Requiere_Cuenta">Es un campo S / N que indica si el cliente tiene cuentas</param>
    Public Shared Function fn_ClientesProceso_Modificar(ByVal Id As Integer, ByVal Id_Cia As Integer, ByVal Id_Cliente As Integer, ByVal Clave_Cliente As String, ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer, _
                                                    ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String, ByVal Requiere_Cuenta As Char, ByVal GrupoDepo As Integer, ByVal GrupoDota As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, GrupoDepo)
        Crea_Parametro(cmd, "@Id_GrupoDota", SqlDbType.Int, GrupoDota)

        Try
            Dim int As Integer = EjecutarNonQuery(cmd)
            If int = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Obtiene toda la informacion del registro seleccionado de la tabla Cat_ClientesProceso
    ''' </summary>
    ''' <param name="Id">Es el registro seleccionado</param>
    ''' <returns>Devuelve un arreglo con los valores del registro</returns>
    Public Shared Function fn_ClientesProceso_Leer(ByVal Id As Integer) As Array
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id)

        Try
            Return EjecutaConsulta(cmd).Rows(0).ItemArray
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Obtiene toda la informacion de la empresa actual
    ''' </summary>
    ''' <returns>Devuelve un arreglo con los valores del registro</returns>
    Public Shared Function fn_ParametrosG_Read() As Array
        Dim cmd As SqlCommand = Crea_Comando("Cat_ParametrosG_Read", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Return EjecutaConsulta(cmd).Rows(0).ItemArray
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Obtiene toda la informacion de la empresa actual
    ''' </summary>
    ''' <returns>Devuelve un arreglo con los valores del registro</returns>
    Public Shared Function fn_Sucursales_Read(ByVal Id_Sucursal As Integer) As DataTable
        Dim dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "Id_Sucursal", SqlDbType.Int, Id_Sucursal)
        Try
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Obtiene toda la informacion de la ciudad actual
    ''' </summary>
    ''' <returns>Devuelve un arreglo con los valores del registro</returns>
    Public Shared Function fn_Ciudad_Read(ByVal Id_Ciudad As Integer) As Array
        Dim cmd As SqlCommand = Crea_Comando("Cat_PaisesCiudad_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)

        Try
            Return EjecutaConsulta(cmd).Rows(0).ItemArray
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Cuentas_Fill(ByRef Id As Integer) As DataTable

        Dim Cmd As SqlCommand = Crea_Comando("Pro_Cuentas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, Id)

        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Referencias_Fill(ByRef Id As Integer) As DataTable

        Dim Cmd As SqlCommand = Crea_Comando("Pro_ReferenciasClientesP_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id)

        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Protected Shared Function fn_ClientesProceso_CrearT(ByRef Tra As SqlTransaction, ByVal Id_Cliente As Integer, ByVal Id_Cia As Integer, ByVal Clave_Cliente As String, ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer, _
                                                    ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String, ByVal Requiere_Cuenta As Char) As Integer

        Dim cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_ClientesProceso_Create")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Return EjecutarScalarT(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try
    End Function

    Public Shared Function fn_ClientesProceso_ModificarT(ByVal Tra As SqlTransaction, ByVal Id As Integer, ByVal Id_Cia As Integer, ByVal Id_Cliente As Integer, ByVal Clave_Cliente As String, ByVal Nombre_Comercial As String, ByVal Direccion_Comercial As String, ByVal Id_Ciudad As Integer, _
                                                    ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Numero_Contrato As String, ByVal Requiere_Cuenta As Char) As Integer

        Dim cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_ClientesProceso_Update")
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Clave_Cliente", SqlDbType.VarChar, Clave_Cliente)
        Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Nombre_Comercial)
        Crea_Parametro(cmd, "@Direccion_Comercial", SqlDbType.VarChar, Direccion_Comercial)
        Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoF", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Numero_Contrato", SqlDbType.VarChar, Numero_Contrato)
        Crea_Parametro(cmd, "@Requiere_Cuenta", SqlDbType.VarChar, Requiere_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Dim int As Integer = EjecutarNonQueryT(cmd)
            If int = 0 Then
                Return 0
            Else
                Return Id
            End If

        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Protected Shared Function fn_Cuentas_Crear(ByVal Tra As SqlTransaction, ByVal Row As DataRow, ByVal Id_CajaBancaria As Integer) As Integer
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_Cuentas_Create")
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Row("Numero_Cuenta"))
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Row("Id_Moneda"))
        Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Row("Id_Ciudad"))
        Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, Row("Modo_Captura"))
        Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Row("Referenciada"))
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Row("Status"))

        Try
            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Protected Shared Function fn_Cuentas_Actualizar(ByVal Tra As SqlTransaction, ByVal Row As DataRow) As Boolean
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Cat_ClientesPcuentas_Update")
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, Row("Id_Cuenta"))
        Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Row("Numero_Cuenta"))
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Row("Id_Moneda"))
        Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Row("Id_Ciudad"))
        Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Row("Referenciada"))

        Try
            EjecutarNonQueryT(Cmd)
            Return Row("Id_Cuenta")
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Protected Shared Function fn_Referencias_Crear(ByVal Tra As SqlTransaction, ByVal Row As DataRow, ByVal IdCuenta As Integer) As Integer
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_CuentasReferencias_Create")
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, IdCuenta)
        Crea_Parametro(Cmd, "@Referencia", SqlDbType.VarChar, Row("Referencia"))
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Row("Status"))

        Try
            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Protected Shared Function fn_Referencias_Actualizar(ByVal Tra As SqlTransaction, ByVal Row As DataRow) As Boolean
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_CuentasReferencias_Update")
        Crea_Parametro(Cmd, "@Id_Referencia", SqlDbType.Int, Row("Id_Referencia"))
        Crea_Parametro(Cmd, "@Referencia", SqlDbType.VarChar, Row("Referencia"))
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Row("Status"))

        Try
            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Public Shared Function fn_ClientesProceso_CrearCuentas(ByVal Cliente As Array, ByVal Tbl_Cuentas As DataTable, ByVal Tbl_Referencias As DataTable) As Boolean
        Dim Tra As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim IdClienteP As Integer = fn_ClientesProceso_CrearT(Tra, CInt(Cliente(0)), CInt(Cliente(1)), Cliente(2), Cliente(3), Cliente(4), CInt(Cliente(5)), CInt(Cliente(6)), CInt(Cliente(7)), Cliente(8), Cliente(9))
        Dim Id_CuentaActual As Integer


        Try
            For Each element As DataRow In Tbl_Cuentas.Rows
                Id_CuentaActual = fn_Cuentas_Crear(Tra, element, IdClienteP)

                For Each Referencia As DataRow In Tbl_Referencias.Rows

                    If Referencia("Id_Cuenta") = element("Id_Cuenta") Then
                        fn_Referencias_Crear(Tra, Referencia, Id_CuentaActual)
                    End If

                Next
            Next

            Tra.Commit()
            Tra.Dispose()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            If Not Tra Is Nothing Then Tra.Rollback()
            Return False
        End Try

    End Function

    Public Shared Function fn_ClientesProceso_ActualizarCuentas(ByVal Cliente As Array, ByVal Id As Integer, ByVal Tbl_Cuentas As DataTable, ByVal Tbl_Referencias As DataTable) As Boolean
        Dim Tra As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim IdClienteP As Integer = fn_ClientesProceso_ModificarT(Tra, Id, CInt(Cliente(1)), CInt(Cliente(0)), Cliente(2), Cliente(3), Cliente(4), CInt(Cliente(5)), CInt(Cliente(6)), CInt(Cliente(7)), Cliente(8), Cliente(9))
        Dim Id_CuentaActual As Integer


        Try
            For Each element As DataRow In Tbl_Cuentas.Rows

                Select Case element("Modificado")
                    Case 1
                        Id_CuentaActual = fn_Cuentas_Actualizar(Tra, element)
                    Case 2
                        Id_CuentaActual = fn_Cuentas_Crear(Tra, element, IdClienteP)
                    Case Else
                        Id_CuentaActual = element("Id_Cuenta")
                End Select



                For Each Referencia As DataRow In Tbl_Referencias.Rows

                    If Referencia("Id_Cuenta") = element("Id_Cuenta") Then
                        Select Case Referencia("Modificado")
                            Case 1
                                fn_Referencias_Actualizar(Tra, Referencia)
                            Case 2
                                fn_Referencias_Crear(Tra, Referencia, Id_CuentaActual)
                        End Select
                    End If

                Next
            Next

            Tra.Commit()
            Tra.Dispose()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            If Not Tra Is Nothing Then Tra.Rollback()
            Return False
        End Try

    End Function

    Public Shared Function fn_Materiales_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_VentAS_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 13)

        Try
            lsv.Actualizar(cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Boveda_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Bo_Boveda_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Saldo_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_VentAS_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 13)

        Try
            lsv.Actualizar(cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proceso_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, fn_ParametrosGlobales(ParametrosGlobales.Id_Cia))

        Try
            lsv.Actualizar(cmd, "Id_Servicio")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Traslado_LlenarLista(ByVal Id As Integer, ByRef lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("TV_PuntosRemisiones_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(cmd, "Id_Punto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proceso_ObtenerCuentas(ByVal Lsv As cp_Listview, ByVal Id_ClienteP As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesP_GetCuentas", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            Lsv.Actualizar(cmd, "Id_Cuenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proceso_ObtenerReferencias(ByVal Lsv As cp_Listview, ByVal Id_ClienteP As Integer, ByVal Id_Cuenta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesP_GetReferencias", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)

        Try
            Lsv.Actualizar(cmd, "Id_Referencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proceso_ValidarReferencias(ByVal Id_ClienteP As Integer, ByVal Id_Referencia As Integer) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesP_ValidarReferencias", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)

        Try
            Return EjecutaConsulta(cmd).Rows.Count = 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proceso_BajaReing(ByVal Id_ClienteP As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesProceso_BajaReing", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Proceso_CuentasBaja_Reing(ByVal Id_ClienteP As Integer, ByVal Id_Cuenta As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesPcuentas_BajaRenig", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Proceso_ReferenciasBaja_Reing(ByVal Id_ClienteP As Integer, ByVal Id_Referencia As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesPreferencias_Baja_Reing", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Catálogo de Cuentas"

    Public Shared Function fn_CuentasModal_Referencias(ByVal Lsv As cp_Listview, ByVal Id_Cuenta As Integer, ByVal Id_ClienteP As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Get3", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        'Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, "S")

        Try
            Lsv.Actualizar(cmd, "Id_Referencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Sub fn_CuentasModal_LlenarExistentes(ByVal lsv As cp_Listview, ByVal Id_ClienteP As Integer, ByVal Id_CajaBancaria As Integer)
        Dim cmd As SqlCommand
        If Id_ClienteP = 0 Then
            cmd = Crea_Comando("Pro_Cuentas_GetTodos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, "S")
        Else
            cmd = Crea_Comando("Pro_Cuentas_GetByClienteP", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, "S")
        End If

        Try
            lsv.Actualizar(cmd, "Id_Cuenta")
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Function fn_CuentasModal_GuardarNueva(ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Status As Char, ByVal Id_CajaBancaria As Integer, ByVal TblRef As DataTable) As Integer()
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim Id(TblRef.Rows.Count) As Integer
        Id(0) = fn_Cuentas_Crear(Tr, Numero_Cuenta, Id_Moneda, Id_Ciudad, Modo_Captura, Referenciada, Referencia_Fija, Status, Id_CajaBancaria)

        If Id(0) = 0 Then Return Nothing
        For Each Referencia As DataRow In TblRef.Rows
            Id(TblRef.Rows.IndexOf(Referencia) + 1) = fn_Referencias_Crear(Tr, Referencia, Id(0))
            If Id(TblRef.Rows.IndexOf(Referencia) + 1) = 0 Then Return Nothing
        Next

        Tr.Commit()
        Return Id
    End Function

    Public Shared Function fn_CuentasModal_Guardar(ByVal Id_ClienteP As Integer, ByVal Cuentas() As Integer, ByVal Referencias() As Integer) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        For Each cuenta As Integer In Cuentas
            If Not fn_CuentasModal_CrearCuenta(Tr, Id_ClienteP, cuenta) Then Return False
        Next

        For Each Referencia As Integer In Referencias
            If Not fn_CuentasModal_CrearReferencia(Tr, Id_ClienteP, Referencia) Then Return False
        Next

        Tr.Commit()
        Return True

    End Function

    Protected Shared Function fn_CuentasModal_CrearCuenta(ByVal Tr As SqlTransaction, ByVal Id_ClienteP As Integer, ByVal Id_Cuenta As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_ClientesPcuentas_Create")
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            Return EjecutarNonQueryT(cmd) > 0
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Protected Shared Function fn_CuentasModal_CrearReferencia(ByVal Tr As SqlTransaction, ByVal Id_ClienteP As Integer, ByVal Id_Referencia As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_ClientesPreferencias_Create")
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            Return EjecutarNonQueryT(cmd) > 0
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Cuentas_LLenarLista(ByVal lsv As cp_Listview, ByVal Id_Banco As Integer, ByVal Activos As Boolean) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Cuentas_GetTodos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Banco)
        Crea_Parametro(cmd, "@Activos", SqlDbType.VarChar, If(Activos, "S", "N"))

        Try
            lsv.Actualizar(cmd, "Id_Cuenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Cuentas_Guardar(ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Status As Char, ByVal Id_CajaBancaria As Integer, ByVal TblRef As DataTable, ByVal CajaBancaria As String, ByVal Moneda As String) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim Cuenta As Integer = fn_Cuentas_Crear(Tr, Numero_Cuenta, Id_Moneda, Id_Ciudad, Modo_Captura, Referenciada, Referencia_Fija, Status, Id_CajaBancaria)

        If Cuenta = 0 Then Return False
        For Each Referencia As DataRow In TblRef.Rows
            If fn_Referencias_Crear(Tr, Referencia, Cuenta) = 0 Then Return False
        Next

        fn_GuardaBitacora(9, "CAJA BANCARIA: '" & CajaBancaria & "', CUENTA: '" & Numero_Cuenta & "', MONEDA: '" & Moneda & "'")

        Tr.Commit()
        Return True
    End Function

    Protected Shared Function fn_Cuentas_Crear(ByVal Tra As SqlTransaction, ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Status As Char, ByVal Id_CajaBancaria As Integer) As Integer
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_Cuentas_Create")
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Numero_Cuenta)
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, Modo_Captura)
        Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Referenciada)
        Crea_Parametro(Cmd, "@Referencia_Fija", SqlDbType.VarChar, Referencia_Fija)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            Return EjecutarScalarT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Protected Shared Function fn_Cuentas_ActualizaCuenta(ByVal Id_Cuenta As Integer, ByVal Tra As SqlTransaction, ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Id_CajaBancaria As Integer) As Integer
        Dim Cmd As SqlCommand = Crea_ComandoT(Tra.Connection, Tra, CommandType.StoredProcedure, "Pro_Cuentas_Update")
        Crea_Parametro(Cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Numero_Cuenta", SqlDbType.VarChar, Numero_Cuenta)
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
        Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, Modo_Captura)
        Crea_Parametro(Cmd, "@Referenciada", SqlDbType.VarChar, Referenciada)
        Crea_Parametro(Cmd, "@Referencia_Fija", SqlDbType.VarChar, Referencia_Fija)

        Try
            Return EjecutarNonQueryT(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Tra.Rollback()
            Return 0
        End Try

    End Function

    Public Shared Function fn_Cuentas_Baja(ByVal Id_Cuenta As Integer, ByVal Status As Char, ByVal Cuenta As String, ByVal CajaBancaria As String, ByVal Moneda As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Cuentas_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

        Try
            fn_GuardaBitacora(11, "CAJA BANCARIA: '" & CajaBancaria & "', CUENTA: '" & Cuenta & "', MONEDA: '" & Moneda & "'")
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try


    End Function

    Public Shared Function fn_Cuentas_Read(ByVal Id_Cuenta As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Pro_Cuentas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)

        Try
            Return EjecutaConsulta(cmd).Rows(0)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_Get(ByVal Id_Cuenta As Integer, ByVal Id_ClienteP As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_Get1(ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Get1", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)


        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Cuentas_Modificar(ByVal Id_Cuentas As Integer, ByVal Numero_Cuenta As String, ByVal Id_Moneda As Integer, ByVal Id_Ciudad As Integer, ByVal Modo_Captura As Integer, ByVal Referenciada As Char, ByVal Referencia_Fija As Char, ByVal Id_CajaBancaria As Integer, ByVal TblRef As DataTable, ByVal CajaBancaria As String, ByVal Moneda As String, ByVal MonedaAnt As String, ByVal CuentaAnt As String) As Boolean
        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        fn_Cuentas_ActualizaCuenta(Id_Cuentas, Tr, Numero_Cuenta, Id_Moneda, Id_Ciudad, Modo_Captura, Referenciada, Referencia_Fija, Id_CajaBancaria)

        For Each Referencia As DataRow In TblRef.Rows
            If Referencia("Modificado") = 2 Then
                If fn_Referencias_Crear(Tr, Referencia, Id_Cuentas) = 0 Then Return False
            End If
        Next

        fn_GuardaBitacora(13, "CAJA BANCARIA: " & CajaBancaria & ", MONEDA DE '" & MonedaAnt & "' A '" & Moneda & ", CUENTA DE '" & CuentaAnt & "' A '" & Numero_Cuenta & "'")

        Tr.Commit()
        Return True
    End Function

    Public Shared Function fn_CuentasReferencias_Baja(ByVal Id_Referencia As Integer) As Boolean
        Dim Cantidad As Integer = 0
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Baja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
        Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)

        Try
            'Dar de Baja en Pro_CuentasReferencias
            Cantidad = EjecutarNonQuery(cmd)
            'Falta dar de baja en Cat_ClientesPreferencias
            cmd = Crea_Comando("Cat_ClientesPreferencias_Baja_Reing2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "B")

            Cantidad += EjecutarNonQuery(cmd)

            If Cantidad > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CuentasReferencias_Reingreso(ByVal Id_Referencia As Integer) As Boolean
        Dim Cantidad As Integer = 0
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasReferencias_Reingreso", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
        Crea_Parametro(cmd, "@Usuario_Reingreso", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Reingreso", SqlDbType.VarChar, EstacioN)

        Try
            'Reingresar en Pro_CuentasReferencias
            Cantidad = EjecutarNonQuery(cmd)

            'Falta reingresar en Cat_ClientesPreferencias
            cmd = Crea_Comando("Cat_ClientesPreferencias_Baja_Reing2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Referencia", SqlDbType.Int, Id_Referencia)
            Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

            Cantidad += EjecutarNonQuery(cmd)

            If Cantidad > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Guardar Archivo"

    Public Shared Function fn_GuardarArchivo_ObtenNombre(ByVal Id_CajaBancaria As Integer, ByVal Fecha_Aplicacion As Date, ByVal Id_Cia As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("pro_Archivos_GetNombre", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Fecha_Aplicacion", SqlDbType.DateTime, Fecha_Aplicacion)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_GuardarArchivo_Guardar(ByVal Num_Proceso As Integer, ByVal Numero_Archivo As Integer, ByVal Nombre_Archivo As String, _
                                                    ByVal Fecha_Aplicacion As Date, ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Id_Cajero As Integer, _
                                                    ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Denominaciones As IEnumerable, _
                                                    ByVal Fichas As IEnumerable(Of ds_Reportes.Tbl_FichasRow), ByVal Id_Cia As Integer, ByVal Corte_Turno As Integer, _
                                                    ByVal ArchivoD As Byte(), ByVal ArchivoC As Byte(), ByVal Nombre_ArchivoD As String, ByVal Nombre_ArchivoC As String) As Integer
        Dim Id_Archivo As Integer
        Dim Cantidad As Integer = 0
        Using tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

            Id_Archivo = fn_GuardarArchivo_CrearArchivo(tr, Num_Proceso, Numero_Archivo, Nombre_Archivo, Fecha_Aplicacion, Id_CajaBancaria, _
                                        Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, Nombre_ArchivoD, Nombre_ArchivoC)

            If Id_Archivo = 0 Then Return 0

            For Each row In Denominaciones
                Cantidad = row.Cantidad
                If Not fn_GuardarArchivo_CrearArchivoD(tr, Id_Archivo, row.Id_Denominacion, Cantidad) Then Return 0
            Next

            For Each row As ds_Reportes.Tbl_FichasRow In Fichas
                If Not fn_GuardarArchivo_ActualizarFicha(tr, CInt(row.Id_Ficha), Id_Archivo) Then Return 0
            Next

            tr.Commit()
        End Using

        Return Id_Archivo
    End Function

    Public Shared Function fn_GuardarArchivo_Guardar1xFicha(ByVal Num_Proceso As Integer, ByVal Numero_Archivo As Integer, ByVal Nombre_Archivo As String, _
                                                            ByVal Fecha_Aplicacion As Date, ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Id_Cajero As Integer, _
                                                            ByVal Id_GrupoDepo As Integer, ByVal Id_Sesion As Integer, ByVal Denominaciones As System.Collections.IEnumerable, _
                                                            ByVal Id_Ficha As Integer, ByVal Id_Cia As Integer, ByVal Corte_Turno As Integer, ByVal ArchivoD As Byte(), ByVal ArchivoC As Byte(), _
                                                            ByVal Nombre_ArchivoD As String, ByVal Nombre_ArchivoC As String) As Integer
        Dim Id_Archivo As Integer
        Dim Cantidad As Integer = 0
        Using tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

            Id_Archivo = fn_GuardarArchivo_CrearArchivo(tr, Num_Proceso, Numero_Archivo, Nombre_Archivo, Fecha_Aplicacion, Id_CajaBancaria, _
                                        Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, Nombre_ArchivoD, Nombre_ArchivoC)

            If Id_Archivo = 0 Then Return 0

            For Each Row In Denominaciones
                Cantidad = Row.Cantidad
                If Not fn_GuardarArchivo_CrearArchivoD(tr, Id_Archivo, Row.Id_Denominacion, Cantidad) Then Return 0
            Next

            If Not fn_GuardarArchivo_ActualizarFicha(tr, Id_Ficha, Id_Archivo) Then Return 0

            tr.Commit()
        End Using

        Return Id_Archivo
    End Function

    Public Shared Function fn_GuardarArchivo_CrearArchivo(ByVal Tr As SqlTransaction, ByVal Num_Proceso As Integer, ByVal Numero_Archivo As Integer, ByVal Nombre_Archivo As String, _
    ByVal Fecha_Aplicacion As Date, ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Id_Cajero As Integer, ByVal Id_GrupoDepo As Integer, _
    ByVal Id_Sesion As Integer, ByVal Id_Cia As Integer, ByVal Corte_Turno As Integer, ByVal ArchivoD As Byte(), ByVal ArchivoC As Byte(), ByVal Nombre_ArchivoD As String, ByVal Nombre_ArchivoC As String) As Integer

        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Archivos_Create")
        Crea_Parametro(cmd, "@Num_Proceso", SqlDbType.Int, Num_Proceso)
        Crea_Parametro(cmd, "@Numero_Archivo", SqlDbType.Int, Numero_Archivo)
        Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Nombre_Archivo, False)
        Crea_Parametro(cmd, "@Fecha_Aplicacion", SqlDbType.DateTime, Fecha_Aplicacion)
        Crea_Parametro(cmd, "@Usuario_Genera", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Corte_Turno", SqlDbType.Int, Corte_Turno)
        Crea_Parametro(cmd, "@ArchivoD", SqlDbType.VarBinary, ArchivoD)
        Crea_Parametro(cmd, "@ArchivoC", SqlDbType.VarBinary, ArchivoC)
        Crea_Parametro(cmd, "@Nombre_ArchivoD", SqlDbType.VarChar, Nombre_ArchivoD, False)
        Crea_Parametro(cmd, "@Nombre_ArchivoC", SqlDbType.VarChar, Nombre_ArchivoC, False)

        Try
            Dim Id As Integer = EjecutarScalarT(cmd)
            If Id > 0 Then
                Return Id
            Else
                Tr.Rollback()
                Return 0
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try

    End Function

    Public Shared Function fn_GuardarArchivo_CrearArchivoD(ByVal Tr As SqlTransaction, ByVal Id_Archivo As Integer, ByVal Id_Denominacion As Integer, ByVal Cantidad As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "pro_ArchivosD_Create")
        Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)
        Crea_Parametro(cmd, "@Id_Denominacion", SqlDbType.Int, Id_Denominacion)
        Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, Cantidad)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GuardarArchivo_ActualizarFicha(ByVal Tr As SqlTransaction, ByVal Id_Ficha As Integer, ByVal Id_Archivo As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Fichas_UpdateArchivo")
        Crea_Parametro(cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)
        Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Sub fn_GuardarArchivo_LlenarDenominacion(ByRef Ds As ds_Reportes, ByVal Id_Archivo As Integer, ByVal Presentacion As Char)

        Dim cmd As SqlCommand = Crea_Comando("pro_ArchivosD_GetByPresentacion", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try
            cmd.Connection.Open()
            Ds.Tbl_Denominacion.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try

    End Sub

    Public Shared Function fn_GuardarArchivo_GenerarReporte(ByVal Id_Archivo As Integer, ByVal Fecha_Aplicacion As String) As rpt_CorteProceso
        'Cuando se genera el reporte originalmente
        Dim rpt As New rpt_CorteProceso
        Dim Ds As New ds_Reportes
        Dim Billetes As New ds_Reportes
        Dim Monedas As New ds_Reportes

        Dim row As DataRow = fn_GuardarArchivo_ObtenerReporte(Id_Archivo)
        With row
            CType(rpt.Section1.ReportObjects("txt_CajaBancaria"), TextObject).Text = "PROCESO DE VALORES " & .Item("NombreCliente")
            CType(rpt.Section1.ReportObjects("txt_Corte"), TextObject).Text = .Item("Numero")
            CType(rpt.Section1.ReportObjects("txt_Moneda"), TextObject).Text = .Item("Moneda")
            CType(rpt.Section1.ReportObjects("txt_TotalEfectivo"), TextObject).Text = Format(.Item("Total_Efectivo"), "n")
            CType(rpt.Section1.ReportObjects("txt_DocFichas"), TextObject).Text = Format(.Item("CFichas"), "n0")
            CType(rpt.Section1.ReportObjects("txt_ImpFichas"), TextObject).Text = Format(.Item("IFichas"), "n2")
            CType(rpt.Section1.ReportObjects("TXT_ImpCheques"), TextObject).Text = Format(.Item("ICheques"), "n2")
            CType(rpt.Section1.ReportObjects("txt_ImpChequesO"), TextObject).Text = Format(.Item("IChequesO"), "n2")
            CType(rpt.Section1.ReportObjects("txt_Diferencia"), TextObject).Text = Format(.Item("DEfectivo"), "n2")
            CType(rpt.Section1.ReportObjects("txt_DocChequesO"), TextObject).Text = Format(.Item("CChequesO"), "n0")
            CType(rpt.Section1.ReportObjects("txt_DocCheques"), TextObject).Text = Format(.Item("CCheques"), "n0")
            CType(rpt.Section1.ReportObjects("txt_Fecha"), TextObject).Text = Fecha_Aplicacion
        End With
        fn_VerReportes_LlenarLogo(Ds.Tbl_DatosEmpresa)
        fn_GuardarArchivo_LlenarDenominacion(Billetes, Id_Archivo, "B")
        fn_GuardarArchivo_LlenarDenominacion(Monedas, Id_Archivo, "M")

        rpt.SetDataSource(Ds)
        rpt.Subreports(0).SetDataSource(Billetes)
        rpt.Subreports(1).SetDataSource(Monedas)
        Return rpt
    End Function

    Public Shared Function fn_GuardarArchivo_ObtenerReporte(ByVal Id_Archivo As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("pro_Archivos_GetReporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Generar Archivos"





#End Region

#Region "Reimprimir Corte"

    Public Shared Function fn_ReimprimirCorte_ListarArchivos(ByRef lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, _
                                                             ByVal Id_GrupoDepo As Integer, ByVal Id_Cajero As Integer, ByVal Id_Cia As Integer, _
                                                             ByVal Id_SesionDesde As Integer, ByVal Id_SesionHasta As Integer, ByVal Id_Moneda As Integer, _
                                                             ByVal Corte As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Archivos_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_SesionDesde", SqlDbType.Int, Id_SesionDesde)
        Crea_Parametro(cmd, "@Id_SesionHasta", SqlDbType.Int, Id_SesionHasta)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)

        Try
            lsv.Actualizar(cmd, "Id_Archivo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReimprimirCorte_Eliminar(ByVal Id_Archivo As Long) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Archivos_Delete", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.BigInt, Id_Archivo)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_Archivos_Extraer(ByVal Id_Archivo As Integer) As DataRow
        Dim dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Archivos_Descarga", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

#End Region

    '    '#Region "Depositos por cuenta"
    '    Public Shared Function fn_DepositosPorCuenta_GetCuentas(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Cuentas_GetByCajayMoneda", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetCuentasCombo(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasCombo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GenerarExcel(ByVal Tipo As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Id_Desde As Integer, ByVal Hasta As DateTime, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Id_Cuenta As Integer, ByVal Hijos As Char, ByVal Id_Cia As Integer) As Boolean

    '        Dim Denominaciones As DataTable = fn_DepositosPorCuenta_GetDenominaciones(Id_Moneda)
    '        If Denominaciones Is Nothing Then Return False
    '        Dim Cuentas As DataTable
    '        Dim CuentasEfectivo As DataTable
    '        Dim CuentasCheques As DataTable
    '        Dim Cta, Cte As Integer
    '        Dim j As Integer = 2
    '        Dim Suma As String

    '        Select Case Tipo
    '            Case 1  'Por Fecha de Aplicación del Archivo Txt
    '                'Traer las Fichas y las Cuentas
    '                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer el Efectivo
    '                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer los cheques
    '                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '            Case 2  'Por Fecha_FinV, no toma en cuenta los archivos TXT
    '                'Traer las Fichas y las Cuentas
    '                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer el Efectivo
    '                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer los cheques
    '                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '            Case 3  'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)
    '                'Haciendo Join con Pro_Archivos
    '                'Traer las Fichas y las Cuentas
    '                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer el Efectivo
    '                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer los cheques
    '                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '            Case 4 'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)
    '                'Traer las Fichas y las Cuentas
    '                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer el Efectivo
    '                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
    '                'Traer los cheques
    '                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)

    '                'Case 4  'Por Cliente
    '                '    Cuentas = fn_DepositosPorCuenta_GetByCliente(Id_CajaBancaria, Id_Grupo, Id_Moneda, Id_Desde, Id_Hasta, Id_Cliente, Hijos)

    '        End Select

    '        frm_MENU.prg_Barra.Maximum = Cuentas.Rows.Count + 2
    '        frm_MENU.prg_Barra.Value = 0

    '        'Dim  As New Excel.Application
    '        Dim App = CreateObject("Excel.Application")
    '        With App

    '            'Creando el libro
    '            .Workbooks.Add()
    '            .SheetsInNewWorkbook = 1

    '            'If CType(.Worksheets(1), app.Worksheet).Name = "Hoja1" Then Suma = "=Suma" Else Suma = "=Sum"
    '            Suma = "=Suma"
    '            'Creando los encabezados
    '            .Range("1:1").Font.Bold = True
    '            .Range("A1").Value = "CLIENTE"
    '            .Range("B1").Value = "CUENTA"

    '            For Each row As DataRow In Denominaciones.Rows
    '                .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & 1).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
    '            Next

    '            Dim Cheques As String = LetrA(67 + Denominaciones.Rows.Count + 0)
    '            Dim TotalC As String = LetrA(67 + Denominaciones.Rows.Count + 1)
    '            Dim Propios As String = LetrA(67 + Denominaciones.Rows.Count + 2)
    '            Dim TotalCP As String = LetrA(67 + Denominaciones.Rows.Count + 3)
    '            Dim Otros As String = LetrA(67 + Denominaciones.Rows.Count + 4)
    '            Dim TotalCO As String = LetrA(67 + Denominaciones.Rows.Count + 5)
    '            Dim Fichas As String = LetrA(67 + Denominaciones.Rows.Count + 6)
    '            Dim Mazos As String = LetrA(67 + Denominaciones.Rows.Count + 7)

    '            .Range(Cheques & 1).Value = "Cheques"
    '            .Range(TotalC & 1).Value = "TotalC"
    '            .Range(Propios & 1).Value = "Propios"
    '            .Range(TotalCP & 1).Value = "TotalCP"
    '            .Range(Otros & 1).Value = "Otros"
    '            .Range(TotalCO & 1).Value = "TotalCO"
    '            .Range(Fichas & 1).Value = "Fichas"
    '            .Range(Mazos & 1).Value = "Mazos"
    '            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
    '            For Each FilaC As DataRow In Cuentas.Rows
    '                If Cta = 0 And Cte = 0 Then
    '                    Cta = FilaC.Item("Id_Cuenta")
    '                    Cte = FilaC.Item("Id_ClienteP")
    '                ElseIf Cta <> FilaC.Item("Id_Cuenta") Or Cte <> FilaC.Item("Id_ClienteP") Then
    '                    Cta = FilaC.Item("Id_Cuenta")
    '                    Cte = FilaC.Item("Id_ClienteP")
    '                    j += 1
    '                End If
    '                .Range("A" & j).Value = FilaC.Item("Nombre_Comercial")
    '                .Range("B" & j).Value = FilaC.Item("Numero_Cuenta")

    '                If Fila_Anterior <> j Then
    '                    Fila_Anterior = j
    '                    'Efectivo
    '                    For Each FilaE As DataRow In CuentasEfectivo.Rows
    '                        If FilaE.Item("Id_Cuenta") = Cta And FilaE.Item("Id_ClienteP") = Cte Then
    '                            For Each row As DataRow In Denominaciones.Rows
    '                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
    '                                    .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
    '                                    Exit For
    '                                End If
    '                            Next
    '                        End If
    '                    Next
    '                    'Cheques
    '                    For Each Fila As DataRow In CuentasCheques.Rows
    '                        If Fila.Item("Id_Cuenta") = Cta And Fila.Item("Id_ClienteP") = Cte Then
    '                            .Range(Cheques & j).Value += Fila.Item("Cheques")
    '                            .Range(TotalC & j).Value += Fila.Item("TotalC")
    '                            .Range(Propios & j).Value += Fila.Item("Propios")
    '                            .Range(TotalCP & j).Value += Fila.Item("TotalCP")
    '                            .Range(Otros & j).Value += Fila.Item("Otros")
    '                            .Range(TotalCO & j).Value += Fila.Item("TotalCO")
    '                            .Range(Fichas & j).Value += Fila.Item("Fichas")
    '                            Exit For
    '                        End If
    '                    Next
    '                End If
    '                '.Range(Mazos & j).Formula = Suma & "(C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j & ")"
    '                .Range(Mazos & j).Formula = Suma & "(C" & j & ":H" & j & ")/1000"

    '                frm_MENU.prg_Barra.Value += 1
    '            Next
    '            j += 1
    '            .Range("B" & j & ":" & Mazos & j + 7).Font.Bold = True
    '            .Range("B" & j).Value = "Suma"
    '            .Range("C" & j & ":" & Mazos & j).Formula = Suma & "(C2:C" & (j - 1) & ")"
    '            .Range("C" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

    '            j += 2

    '            .Range("B" & j).Value = "Denominaciones"
    '            For Each row As DataRow In Denominaciones.Rows
    '                .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & j).Value = row("Denominacion")
    '            Next

    '            j += 2

    '            .Range("B" & j).Value = "Total Importe"
    '            .Range("C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j).Formula = "=C" & j - 2 & " * C" & (j - 4)
    '            .Range("C" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

    '            j += 1

    '            .Range(Cheques & j).Value = "Efectivo"
    '            .Range(TotalC & j).NumberFormat = "#,##0.00"
    '            .Range(TotalC & j).Formula = Suma & "(" & "C" & (j - 1) & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & (j - 1) & ")"

    '            j += 1

    '            .Range(Cheques & j).Value = "Cheques"
    '            .Range(TotalC & j).NumberFormat = "#,##0.00"
    '            .Range(TotalC & j).Formula = "=" & TotalC & (j - 6)

    '            j += 1

    '            .Range(Cheques & j).Value = "Total"
    '            .Range(TotalC & j).NumberFormat = "#,##0.00"
    '            .Range(TotalC & j).Formula = "=" & TotalC & (j - 2) & " + " & TotalC & (j - 1)

    '            'Mostrando el libro
    '            .Range("A:" & Mazos).EntireColumn.AutoFit()
    '            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
    '            .Visible = True
    '        End With
    '        Return True
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetDenominaciones(ByVal Id_Moneda As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesMoneda_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    '******************************** POR FECHA DE APLICACION DEL TXT ********************************

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    '**********************************************************************************

    '    '******************************** POR FECHA_FINV EN PRO_SERVICIOS ***********************************

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas2", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas2", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques2", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    '********************************POR FECHA_ENTRADA EN BO_BOVEDA y PRO ARCHIVOS ***********************************

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas3", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas3", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques3", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    '********************************POR FECHA_ENTRADA EN BO_BOVEDA SIN PRO ARCHIVOS ***********************************

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas4", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas4", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques4", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    '********************************POR CUENTA Y FECHA_APLICACION EN PRO_ARCHIVOS ***********************************
    '    Public Shared Function fn_DepositosPorCuenta_GenerarExcelXcuenta(ByVal Tipo As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Id_Desde As Integer, ByVal Hasta As DateTime, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Id_Cuenta As Integer, ByVal Hijos As Char, ByVal Id_Cia As Integer) As Boolean

    '        Dim Denominaciones As DataTable = fn_DepositosPorCuenta_GetDenominaciones(Id_Moneda)
    '        If Denominaciones Is Nothing Then Return False
    '        Dim Cuentas As DataTable
    '        Dim CuentasEfectivo As DataTable
    '        Dim CuentasCheques As DataTable
    '        Dim Cta As Integer = 0
    '        Dim Cte As Integer = 0
    '        Dim Ref As Integer = 0
    '        Dim j As Integer = 2
    '        Dim Suma As String

    '        Select Case Tipo
    '            Case 1  'Por Fecha de Aplicación del Archivo Txt

    '            Case 2  'Por Fecha_FinV, no toma en cuenta los archivos TXT

    '            Case 3  'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

    '            Case 4 'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

    '            Case 5  'Por Cuenta y Fecha_Aplicacion del TXT
    '                'Haciendo Join con Pro_Archivos
    '                'Traer las Fichas y las Cuentas
    '                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
    '                'Traer el Efectivo
    '                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
    '                'Traer los cheques
    '                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)

    '        End Select
    '        frm_MENU.prg_Barra.Maximum = Cuentas.Rows.Count + 2
    '        frm_MENU.prg_Barra.Value = 0
    '        'Dim  As New Excel.Application
    '        Dim App = CreateObject("Excel.Application")
    '        With App

    '            'Creando el libro
    '            .Workbooks.Add()
    '            .SheetsInNewWorkbook = 1

    '            'If CType(.Worksheets(1), app.Worksheet).Name = "Hoja1" Then Suma = "=Suma" Else Suma = "=Sum"
    '            Suma = "=Suma"
    '            'Creando los encabezados
    '            .Range("1:1").Font.Bold = True
    '            .Range("A1").Value = "CLIENTE"
    '            .Range("B1").Value = "CUENTA"
    '            .Range("C1").Value = "REFERENCIA"

    '            For Each row As DataRow In Denominaciones.Rows
    '                .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & 1).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
    '            Next

    '            Dim Cheques As String = LetrA(68 + Denominaciones.Rows.Count + 0)
    '            Dim TotalC As String = LetrA(68 + Denominaciones.Rows.Count + 1)
    '            Dim Propios As String = LetrA(68 + Denominaciones.Rows.Count + 2)
    '            Dim TotalCP As String = LetrA(68 + Denominaciones.Rows.Count + 3)
    '            Dim Otros As String = LetrA(68 + Denominaciones.Rows.Count + 4)
    '            Dim TotalCO As String = LetrA(68 + Denominaciones.Rows.Count + 5)
    '            Dim Fichas As String = LetrA(68 + Denominaciones.Rows.Count + 6)
    '            Dim Mazos As String = LetrA(68 + Denominaciones.Rows.Count + 7)

    '            .Range(Cheques & 1).Value = "Cheques"
    '            .Range(TotalC & 1).Value = "TotalC"
    '            .Range(Propios & 1).Value = "Propios"
    '            .Range(TotalCP & 1).Value = "TotalCP"
    '            .Range(Otros & 1).Value = "Otros"
    '            .Range(TotalCO & 1).Value = "TotalCO"
    '            .Range(Fichas & 1).Value = "Fichas"
    '            .Range(Mazos & 1).Value = "Mazos"
    '            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
    '            For Each FilaC As DataRow In Cuentas.Rows
    '                If Cta = 0 And Cte = 0 Then
    '                    Cta = FilaC.Item("Id_Cuenta")
    '                    Cte = FilaC.Item("Id_ClienteP")
    '                    Ref = FilaC.Item("Id_Referencia")
    '                ElseIf Cta <> FilaC.Item("Id_Cuenta") Or Cte <> FilaC.Item("Id_ClienteP") Or Ref <> FilaC.Item("Id_Referencia") Then
    '                    Cta = FilaC.Item("Id_Cuenta")
    '                    Cte = FilaC.Item("Id_ClienteP")
    '                    Ref = FilaC.Item("Id_Referencia")
    '                    j += 1
    '                End If
    '                .Range("A" & j).Value = FilaC.Item("Nombre_Comercial")
    '                .Range("B" & j).Value = FilaC.Item("Numero_Cuenta")
    '                .Range("C" & j).Value = FilaC.Item("Referencia")

    '                If Fila_Anterior <> j Then
    '                    Fila_Anterior = j
    '                    'Efectivo
    '                    For Each FilaE As DataRow In CuentasEfectivo.Rows
    '                        If FilaE.Item("Id_Cuenta") = Cta And FilaE.Item("Id_ClienteP") = Cte And FilaE.Item("Id_Referencia") = Ref Then
    '                            For Each row As DataRow In Denominaciones.Rows
    '                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
    '                                    .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
    '                                    Exit For
    '                                End If
    '                            Next
    '                        End If
    '                    Next
    '                    'Cheques
    '                    For Each Fila As DataRow In CuentasCheques.Rows
    '                        If Fila.Item("Id_Cuenta") = Cta And Fila.Item("Id_ClienteP") = Cte And Fila.Item("Id_Referencia") = Ref Then
    '                            .Range(Cheques & j).Value += Fila.Item("Cheques")
    '                            .Range(TotalC & j).Value += Fila.Item("TotalC")
    '                            .Range(Propios & j).Value += Fila.Item("Propios")
    '                            .Range(TotalCP & j).Value += Fila.Item("TotalCP")
    '                            .Range(Otros & j).Value += Fila.Item("Otros")
    '                            .Range(TotalCO & j).Value += Fila.Item("TotalCO")
    '                            .Range(Fichas & j).Value += Fila.Item("Fichas")
    '                            Exit For
    '                        End If
    '                    Next
    '                End If
    '                '.Range(Mazos & j).Formula = Suma & "(C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j & ")"
    '                .Range(Mazos & j).Formula = Suma & "(D" & j & ":I" & j & ")/1000"

    '                frm_MENU.prg_Barra.Value += 1
    '            Next
    '            j += 1
    '            .Range("B" & j & ":" & Mazos & j + 7).Font.Bold = True
    '            .Range("B" & j).Value = "Suma"
    '            .Range("D" & j & ":" & Mazos & j).Formula = Suma & "(D2:D" & (j - 1) & ")"
    '            .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

    '            j += 2

    '            .Range("B" & j).Value = "Denominaciones"
    '            For Each row As DataRow In Denominaciones.Rows
    '                .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = row("Denominacion")
    '            Next

    '            j += 2

    '            .Range("B" & j).Value = "Total Importe"
    '            .Range("D" & j & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & j).Formula = "=D" & j - 2 & " * D" & (j - 4)
    '            .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

    '            j += 1

    '            .Range(Cheques & j).Value = "Efectivo"
    '            .Range(TotalC & j).NumberFormat = "#,##0.00"
    '            .Range(TotalC & j).Formula = Suma & "(" & "D" & (j - 1) & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & (j - 1) & ")"

    '            j += 1

    '            .Range(Cheques & j).Value = "Cheques"
    '            .Range(TotalC & j).NumberFormat = "#,##0.00"
    '            .Range(TotalC & j).Formula = "=" & TotalC & (j - 6)

    '            j += 1

    '            .Range(Cheques & j).Value = "Total"
    '            .Range(TotalC & j).NumberFormat = "#,##0.00"
    '            .Range(TotalC & j).Formula = "=" & TotalC & (j - 2) & " + " & TotalC & (j - 1)

    '            'Mostrando el libro
    '            .Range("A:" & Mazos).EntireColumn.AutoFit()
    '            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
    '            .Visible = True
    '        End With
    '        Return True
    '    End Function


    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas5", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas5", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques5", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    '**********************************************************************************

    '    Public Shared Function fn_DepositosPorCuenta_GetByVerificacion(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Id_Desde As Integer, ByVal Id_Hasta As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteVerificacion", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Id_Desde", SqlDbType.Int, Id_Desde)
    '        Crea_Parametro(cmd, "@Id_Hasta", SqlDbType.Int, Id_Hasta)

    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByTraslado(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable

    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteTraslado", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Desde", SqlDbType.DateTime, Desde)
    '        Crea_Parametro(cmd, "@Hasta", SqlDbType.DateTime, Hasta)

    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByCliente(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Id_Desde As Integer, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Hijos As Char) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteCliente", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Id_Desde", SqlDbType.Int, Id_Desde)
    '        Crea_Parametro(cmd, "@Id_Hasta", SqlDbType.Int, Id_Hasta)
    '        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
    '        Crea_Parametro(cmd, "@Hijos", SqlDbType.VarChar, Hijos)

    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '    Public Shared Function fn_DepositosPorCuenta_GetByCuenta(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Id_Desde As Integer, ByVal Id_Hasta As Integer, ByVal Id_Cuenta As Integer) As DataTable
    '        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteCuenta", CommandType.StoredProcedure, Crea_ConexionSTD)
    '        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '        Crea_Parametro(cmd, "@Id_Desde", SqlDbType.Int, Id_Desde)
    '        Crea_Parametro(cmd, "@Id_Hasta", SqlDbType.Int, Id_Hasta)
    '        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)

    '        Try
    '            Return EjecutaConsulta(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return Nothing
    '        End Try
    '    End Function

    '#End Region

#Region "Dep. por Cuenta Reporte de Procesos"

    Public Shared Function fn_ReporteProcesos_GetDenominaciones(ByVal Id_Moneda As Integer, ByVal Presentacion As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesP_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteProcesos_GetArchivos(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Archivos_GetReporteProcesos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteProcesos_GetArchivosD(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_ArchivosD_GetReporteProcesos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteProcesos_GenerarExcel(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Hasta As DateTime, ByVal Id_Cia As Integer) As Boolean

        Dim Denominaciones As DataTable = fn_ReporteProcesos_GetDenominaciones(Id_Moneda, "B")
        If Denominaciones Is Nothing Then Return False
        Dim Archivos As DataTable
        Dim ArchivosD As DataTable
        Dim Arc As Integer = 0
        Dim Cia As String = ""
        Dim j As Integer = 2
        Dim Suma As String
        Dim Piezas As Integer = 0

        'Traer las Fichas y las Cuentas
        Archivos = fn_ReporteProcesos_GetArchivos(Id_CajaBancaria, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
        'Traer el Efectivo
        ArchivosD = fn_ReporteProcesos_GetArchivosD(Id_CajaBancaria, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)

        'Dim  As New Excel.Application
        Dim App = CreateObject("Excel.Application")
        With App

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1

            'If CType(.Worksheets(1), app.Worksheet).Name = "Hoja1" Then Suma = "=Suma" Else Suma = "=Sum"
            Suma = "=Suma"
            'Creando los encabezados
            .Range("1:1").Font.Bold = True
            .Range("A1").Value = "FECHA"
            .Range("B1").Value = "PROCESO(CIA TV)"
            .Range("C1").Value = "COMPROBANTE"
            .Range("D1").Value = "ENVASES"
            .Range("E1").Value = "MAZOS"
            .Range("F1").Value = "IMPORTE TOTAL"


            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(71 + Denominaciones.Rows.IndexOf(row)) & 1).Value = row("Denominacion")
            Next

            Dim Morralla As String = LetrA(71 + Denominaciones.Rows.Count + 0)
            Dim Num_Proceso As String = LetrA(71 + Denominaciones.Rows.Count + 1)

            .Range(Morralla & 1).Value = "Morralla"
            .Range(Num_Proceso & 1).Value = "Num Proceso"

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo
            frm_MENU.prg_Barra.Maximum = Archivos.Rows.Count + 1
            frm_MENU.prg_Barra.Value = 0

            For Each FilaC As DataRow In Archivos.Rows
                If Arc = 0 And Cia = "" Then
                    Arc = FilaC.Item("Id_Archivo")
                    Cia = FilaC.Item("Cia")
                ElseIf Arc <> FilaC.Item("Id_Archivo") Or Cia <> FilaC.Item("Cia") Then
                    Arc = FilaC.Item("Id_Archivo")
                    Cia = FilaC.Item("Cia")
                    j += 1
                End If
                .Range("A" & j).Value = FilaC.Item("Fecha")
                .Range("B" & j).Value = FilaC.Item("Cia")

                Piezas = 0
                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Efectivo
                    For Each FilaE As DataRow In ArchivosD.Rows
                        If FilaE.Item("Id_Archivo") = Arc And FilaE.Item("Cia") = Cia Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(71 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad") * FilaE.Item("Denominacion")
                                    Piezas += FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
                .Range("E" & j).Value = Piezas / 1000
                .Range("F" & j).Formula = Suma & "(G" & j & ":" & Morralla & j & ")"
                .Range(Morralla & j).Value = FilaC.Item("Morralla")
                .Range(Num_Proceso & j).Value = FilaC.Item("Num_Proceso")
                .Range("E" & j & ":" & Morralla & j).NumberFormat = "#,##0.00"

                frm_MENU.prg_Barra.Value += 1
            Next
            .Range("A1:" & Morralla & j).Borders.Value = True
            .Range("A1:" & Morralla & j).Font.Name = "Arial"
            .Range("A1:" & Morralla & j).Font.Bold = True
            .Range("A1:" & Morralla & j).Font.Size = 8

            'Sumatorias
            j += 1
            .Range("D" & j & ":" & Morralla & j).Formula = Suma & "(D2:D" & j - 1 & ")"
            .Range("D" & j & ":" & Morralla & j).NumberFormat = "#,##0.00"
            .Range("B" & j).Value = "Suma"
            .Range("B" & j & ":" & Morralla & j).Font.Bold = True

            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum

            'Mostrando el libro
            .Range("A:" & Morralla).EntireColumn.AutoFit()
            .Visible = True
        End With
        Return True

    End Function

#End Region

#Region "Acepta Materiales"

    Public Shared Function fn_AceptaMateriales_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByVal Tipo As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_GetDepartamentos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "SO")

        Try
            lsv_Catalogo.Actualizar(cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AceptaMaterialesD_LlenarLista(ByRef Lista As cp_Listview, ByVal Id_VentMat As Integer) As Boolean
        'Return fn_LlenarListaD("Mat_ValidaVentasMaterialesD_Get", "Id_MatVenta", lsv_Catalogo, Id_VentMat)
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_ValidaVentasMaterialesD_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "Id_MatVenta", SqlDbType.Int, Id_VentMat)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AceptaMateriales_Validar(ByVal Id As Integer) As Boolean
        'Return fn_StatusD(Id, "VA", "mat_ventasd_ValidaVentaMat", "@Id_MatVenta", True)
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("mat_ventasd_ValidaVentaMat", CommandType.StoredProcedure, Cnn)
        Dim resulset As Integer = 0

        Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 0)

        Try
            resulset = Cn_Datos.EjecutarScalar(Cmd)

            If resulset > 0 Then
                Return True
            Else
                Return False
            End If

        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AceptaMateriales_ValidaStatus(ByVal Id_MatVenta As Integer, ByVal Status As String) As Boolean
        Dim dt As DataTable
        'Si no lo encuentra regresa Falso y no se podrá validar el lote.
        Try
            Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_StatusValidar", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_MatVenta", SqlDbType.Int, Id_MatVenta)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            dt = EjecutaConsulta(cmd)
            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AceptaMateriales_Aceptar(ByVal Id_MatVentas As Integer, ByVal Tipo As Dpto, ByVal Usuario As Long) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_Aceptar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_MatVentas", SqlDbType.Int, Id_MatVentas)
        Crea_Parametro(cmd, "@Usuario_Entrega", SqlDbType.Int, Usuario)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, CInt(Tipo))
        Crea_Parametro(cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Acepta Materiales Reporte"

    Public Shared Function fn_AceptaMaterialesReporte_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByVal Tipo As Integer, ByVal Fdesde As String, ByVal Fhasta As String, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Mat_Ventas_ReporteDepartamentos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Tipo)
        Crea_Parametro(cmd, "@Fdesde", SqlDbType.VarChar, Fdesde)
        Crea_Parametro(cmd, "@Fhasta", SqlDbType.VarChar, Fhasta)
        If Status <> "" Then 'Parametro Opcional
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        End If

        Try
            lsv_Catalogo.Actualizar(cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AceptaMaterialesDReporte_LlenarLista(ByRef Lista As cp_Listview, ByVal Id_VentMat As Integer) As Boolean

        'Return fn_LlenarListaD("Mat_ValidaVentasMaterialesD_Get", "Id_MatVenta", lsv_Catalogo, Id_VentMat)
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_ValidaVentasMaterialesD_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "Id_MatVenta", SqlDbType.Int, Id_VentMat)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_MatVenta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Inventario Materiales"

    Public Shared Function fn_InventarioMateriales_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByVal Departamento As Dpto) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Inventario_GetSinPrecio", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, CInt(Departamento))

        Try
            lsv_Catalogo.Actualizar(cmd, "Id_Inventario")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Rastreo de remisiones"

    Public Shared Function fn_Rastreo_LlenarImportes(ByRef lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("cat_remisionesD_getid", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "Id_Moneda")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarEnvases(ByRef lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("cat_Envases_getbyremision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "")
            lsv.Columns(0).Text = "Tipo de Envase"
            lsv.Columns(1).Text = "Numero de Envase"
            lsv.Columns(2).Text = "Fecha de Registro"
            lsv.Columns(3).Text = "Hora de Registro"
            lsv.Columns(4).Text = "Usuario de Registro"
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarBoveda(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarProceso(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("pro_servicios_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarProDotaciones(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Pro_Dotaciones_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarCajDotaciones(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Caj_Dotaciones_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarMateriales(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("mat_Ventas_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarTraslado(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Remisiones_RastreoRuta", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Reporte tabular de remisiones"

    Public Shared Function fn_Tabular_LlenarEncabezadoFichas(ByRef tbl As ds_Reportes.Tbl_TabularFichaDataTable, ByVal Id_Remision As Long) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Remisiones_GetReporteTabularFicha", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)

            cmd.Connection.Open()
            tbl.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Tabular_LlenarSubInformesFichas(ByRef tbl As ds_Reportes.Tbl_DenominacionesFichasDataTable, ByVal Id_Remision As Long) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetDenominacionesFichas", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)

            cmd.Connection.Open()
            tbl.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Tabular_LlenarEncabezado(ByVal Tbl As ds_Reportes.Tbl_TabularDataTable, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Remisiones_GetReporteTabular", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            cmd.Connection.Open()
            Tbl.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Tabular_ObtenCajerayCliente(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_Remisiones_GetCajera", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim tbl As DataTable = EjecutaConsulta(cmd)

            If tbl.Rows.Count > 0 Then
                Return tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Cheques Buscar Imagenes"

    Public Shared Function fn_Cheque_BuscaImagen(ByVal Clave_Banco As String, ByVal Cuenta As String, ByVal Numero As String, ByVal Importe As Single) As DataTable
        'Aqui se valida una dependencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasCheques_GetImgs", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.VarChar, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Banco", SqlDbType.VarChar, Clave_Banco)
        Cn_Datos.Crea_Parametro(Cmd, "@Cuenta", SqlDbType.VarChar, Cuenta)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Numero)
        Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.VarChar, Importe)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

        Return Tbl

    End Function

#End Region

#Region "Dialogo"

    Public Shared Function fn_ConsultaDotacionesD_ImprimeRemision(ByVal Id_Dotacion) As DataTable
        Dim dt As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_DotacionesD_GetImprimeRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.BigInt, Id_Dotacion)
        Try
            dt = Cn_Datos.EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return dt
        End Try
    End Function

    Public Shared Function fn_Remision_Existe(ByVal Numero_Remision As Long, ByVal Id_Cia As Long) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_Existe", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Numero_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.BigInt, Id_Cia)
        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ConsultaDotaciones_ImprimeRemision(ByVal Id_Dotacion) As DataTable
        Dim dt As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Dotaciones_GetImprimeRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.BigInt, Id_Dotacion)
        Try
            dt = Cn_Datos.EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ValidaVenta_LlenarImporte(ByVal Id_MatVenta As Integer) As Decimal
        Dim Importe As Decimal
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Mat_Ventas_GetImporte", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_MatVEnta", SqlDbType.Int, Id_MatVenta)
        Try
            Importe = EjecutaConsulta(Cmd).Rows(0)("Importe")
            Return Importe
        Catch ex As Exception
            TrataEx(ex, True)
            Return -1
        End Try
    End Function

    Public Shared Function fn_ConsultarPlantillaCampos(ByVal Clave_Plantilla As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ImpresionPlantillaD_Get2", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Tipo_Plantilla", SqlDbType.Int, 1)
        Crea_Parametro(Cmd, "@Clave_Plantilla", SqlDbType.VarChar, Clave_Plantilla)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Sucursales_ReadDatos() As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Sucursales_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Cmd.Dispose()
            Return Tbl
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Proceso_Cliente(ByVal Id_Cliente As Integer) As DataRow
        Dim dt As New DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Clientes_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                'Valores(0) = dt(0)("Clave_Cliente").ToString
                'Valores(1) = dt(0)("Nombre_Comercial").ToString
                'Valores(2) = dt(0)("DireccionC").ToString
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Desbloquear Usuarios"

    Public Shared Function fn_Usuarios_Bloquear(ByVal Id_Empleado As Integer, ByVal Status As String) As Integer
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Usuarios_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Return Cn_Datos.EjecutarNonQuery(Cmd)
    End Function

    Public Shared Function fn_Usuarios_Consultar(ByRef lsw As ListView, ByRef CS As ListViewColumnSorter) As Boolean
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Usuarios_GetVerificadores", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        lsw.Sorting = Windows.Forms.SortOrder.None
        CS.Order = Windows.Forms.SortOrder.None
        CS.SortColumn = Nothing
        Cmd.Connection.Open()
        Return FuncionesGlobales.fn_CargaListaCMDtag(Cmd, lsw, 0, "Id_Empleado")
        Cmd.Connection.Close()
        Cmd.Dispose()
    End Function

#End Region

#Region "Tabular por Cheques"

    Public Shared Function fn_TabularCheques_LlenarCortes(ByVal Id_Sesion As Integer, ByVal Id_CajaBancaria As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Cortes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Consulta de Cheques"

    Public Shared Function fn_ConsultaCheques_GetCheques(ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_CajaBancaria As Integer, ByVal Corte As Integer, ByVal Generados As Char) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasCheques_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@Id_Session_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Crea_Parametro(cmd, "@Generado", SqlDbType.VarChar, Generados)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_LeerCheque(ByVal Id_Cheque As Long) As DataRow
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasChequesI_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_Cheque", SqlDbType.BigInt, Id_Cheque)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ConsultaCheques_ActualizarNumero(ByVal Id_Cheque As Long, ByVal MICR As String, ByVal Numero As String) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Pro_FichasCheques_UpdateNumero", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Cheque", SqlDbType.Int, Id_Cheque)
            Crea_Parametro(cmd, "@MICR", SqlDbType.VarChar, MICR)
            Crea_Parametro(cmd, "@Numero", SqlDbType.VarChar, Numero)

            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Cambiar Denominaciones"

    Public Shared Function fn_CambiarDenominaciones_LlenarDenominaciones(ByVal Id_Moneda As Integer, ByVal Id_CajaBancaria As Integer) As DataTable

        Dim cmd As SqlCommand = Crea_Comando("Pro_Saldo_GetSinTipos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            Tbl.Columns.Add(New DataColumn("Cambio") With {.DataType = GetType(Integer), .ReadOnly = False})
            'Tbl.Columns.Add(New DataColumn("Prueba") With {.DataType = GetType(DateTime), .ReadOnly = False})
            Return Tbl
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_CambiarDenominaciones_Guardar(ByVal Id_CajaBancariaO As Integer, ByVal Id_CajaBancariaD As Integer, ByVal Id_Moneda As Integer, ByVal Importe As Decimal, ByVal TblO As DataTable, ByVal TblD As DataTable, ByVal Tipo As Integer) As Boolean

        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        '1.- inserta el cambio de denomicaciones
        Dim Id_CambioDenominaciones As Integer = fn_CambiarDenominaciones_CrearCambio(Tr, Id_CajaBancariaO, Id_CajaBancariaD, Id_Moneda, Importe)
        If Id_CambioDenominaciones = 0 Then Return False

        '2.-Actualizando los cambios en Origen y destino
        For Each Row As DataRow In TblO.Rows
            If Not IsDBNull(Row("Cambio")) AndAlso Not Row("Cambio") = 0 Then
                If Not fn_CambiarDenominaciones_Crear_Detalle(Tr, Id_CambioDenominaciones, "E", Row) Then Return False

                ' En esta actualización se considera la Caja Bancaria Origen como Origen y la Caja Bancaria Destino como Destino
                If Not fn_CambiarDenominaciones_ActualizarSaldos(Tr, Id_CajaBancariaO, Id_CajaBancariaD, Row) Then Return False
            End If
        Next

        '3.- como Tipo 1=cambio denominacion hacer lo siguiente
        If Tipo = 1 Then
            For Each Row As DataRow In TblD.Rows
                If Not IsDBNull(Row("Cambio")) AndAlso Not Row("Cambio") = 0 Then
                    If Not fn_CambiarDenominaciones_Crear_Detalle(Tr, Id_CambioDenominaciones, "R", Row) Then Return False

                    ' En esta actualización se considera la Caja Bancaria Destino como Origen y la Caja Bancaria Origen como Destino
                    If Not fn_CambiarDenominaciones_ActualizarSaldos(Tr, Id_CajaBancariaD, Id_CajaBancariaO, Row) Then Return False
                End If
            Next
        End If

        Tr.Commit()
        Return True

    End Function

    Private Shared Function fn_CambiarDenominaciones_CrearCambio(ByVal Tr As SqlTransaction, ByVal Id_CajaBancariaO As Integer, ByVal Id_CajaBancariaD As Integer, ByVal Id_Moneda As Integer, ByVal Importe As Decimal) As Integer

        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_CambioDenominaciones_Create")
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_CajaBancariaO", SqlDbType.Int, Id_CajaBancariaO)
            Crea_Parametro(cmd, "@Id_CajaBancariaD", SqlDbType.Int, Id_CajaBancariaD)
            Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Crea_Parametro(cmd, "@Usuario_Cambio", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Cambio", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Importe)

            Dim Id As Integer = EjecutarScalarT(cmd)
            If Id > 0 Then
                Return Id
            Else
                Tr.Rollback()
                Return 0
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return 0
        End Try

    End Function

    Private Shared Function fn_CambiarDenominaciones_Crear_Detalle(ByVal Tr As SqlTransaction, ByVal Id_CambioDenominaciones As Integer, ByVal Tipo As Char, ByVal row As DataRow) As Boolean

        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_CambioDenominacionesD_Create")
        Crea_Parametro(cmd, "@Id_CambioDenominaciones", SqlDbType.Int, Id_CambioDenominaciones)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.VarChar, Tipo)
        Crea_Parametro(cmd, "@Id_Denominacion", SqlDbType.Int, row("Id_Denominacion"))
        Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, row("Cambio"))

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Private Shared Function fn_CambiarDenominaciones_ActualizarSaldos(ByVal Tr As SqlTransaction, ByVal Id_CajaBancariaO As Integer, ByVal Id_CajaBancariaD As Integer, ByVal row As DataRow) As Boolean

        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Saldo_UpdateOrigenDestino")
        Crea_Parametro(cmd, "@Id_CajaBancariaO", SqlDbType.Int, Id_CajaBancariaO)
        Crea_Parametro(cmd, "@Id_CajaBancariaD", SqlDbType.Int, Id_CajaBancariaD)
        Crea_Parametro(cmd, "@Id_Denominacion", SqlDbType.Int, row("Id_Denominacion"))
        Crea_Parametro(cmd, "@CantidadCambiada", SqlDbType.Int, row("Cambio"))

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_CambiarDenominacionesMismaCB_Guardar(ByVal Id_CajaBancariaO As Integer, ByVal Id_CajaBancariaD As Integer, ByVal Id_Moneda As Integer, ByVal Importe As Decimal, ByVal TblO As DataTable, ByVal TblD As DataTable, ByVal Tipo As Integer) As Boolean

        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)

        '1.- inserta el cambio de denomicaciones
        Dim Id_CambioDenominaciones As Integer = fn_CambiarDenominaciones_CrearCambio(Tr, Id_CajaBancariaO, Id_CajaBancariaD, Id_Moneda, Importe)
        If Id_CambioDenominaciones = 0 Then Return False

        '2.-Actualizando los cambios en Origen y destino
        For Each Row As DataRow In TblO.Rows
            If Not IsDBNull(Row("Cambio")) AndAlso Not Row("Cambio") = 0 Then
                If Not fn_CambiarDenominaciones_Crear_Detalle(Tr, Id_CambioDenominaciones, "E", Row) Then Return False

                ' En esta actualización se considera la Caja Bancaria Origen como Origen se le resta.
                If Not fn_CambiarDenominaciones_ActualizarSaldosOrigen(Tr, Id_CajaBancariaO, Row) Then Return False
            End If
        Next

        'E=entrega , R=Recibe

        '3.- como Tipo 1=cambio denominacion hacer lo siguiente
        For Each Row As DataRow In TblD.Rows
            If Not IsDBNull(Row("Cambio")) AndAlso Not Row("Cambio") = 0 Then
                If Not fn_CambiarDenominaciones_Crear_Detalle(Tr, Id_CambioDenominaciones, "R", Row) Then Return False

                ' En esta actualización se considera la Caja Bancaria Destino  se le suma
                If Not fn_CambiarDenominaciones_ActualizarSaldosDestino(Tr, Id_CajaBancariaD, Row) Then Return False
            End If
        Next

        Tr.Commit()
        Return True

    End Function

    Private Shared Function fn_CambiarDenominaciones_ActualizarSaldosOrigen(ByVal Tr As SqlTransaction, ByVal Id_CajaBancariaO As Integer, ByVal row As DataRow) As Boolean
        'Actualiza saldo misma caja bancaria-->Origen
        'RESTAR
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Saldo_Restar")
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancariaO)
        Crea_Parametro(cmd, "@Id_Denominacion", SqlDbType.Int, row("Id_Denominacion"))
        Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, row("Cambio"))

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Private Shared Function fn_CambiarDenominaciones_ActualizarSaldosDestino(ByVal Tr As SqlTransaction, ByVal Id_CajaBancariaD As Integer, ByVal row As DataRow) As Boolean
        'Actualiza saldo misma caja bancaria -->Destino
        'SUMAR
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Pro_Saldo_Sumar")
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancariaD)
        Crea_Parametro(cmd, "@Id_Denominacion", SqlDbType.Int, row("Id_Denominacion"))
        Crea_Parametro(cmd, "@Cantidad", SqlDbType.Int, row("Cambio"))

        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "CARTAS DE ACCESO"

    Public Shared Function fn_CartasAcceso_Nuevo(ByVal Observaciones As String, ByVal UsuarioAutoriza As Integer, ByVal Items As cp_Listview.ListViewItemCollection, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Tipo As String, ByVal EmpleadoDestino As Integer) As Integer

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Id_Carta As Integer = 0

        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_CartasAcceso_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioRegistro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionRegistro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioAutoriza", SqlDbType.Int, UsuarioAutoriza)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.Date, FechaInicio)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.Date, FechaFin)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Empleado_Destino", SqlDbType.Int, EmpleadoDestino)
            Id_Carta = Cn_Datos.EjecutarScalarT(Cmd)

            If Id_Carta = 0 Then
                trans.Rollback()
                Return 0
            End If

            For Each elemento As ListViewItem In Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_CartasAccesoD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)
                Cn_Datos.Crea_Parametro(Cmd, "@NombreVisitante", SqlDbType.VarChar, elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@EmpresaVisitante", SqlDbType.VarChar, elemento.SubItems(2).Text)
                If EjecutarNonQueryT(Cmd) = 0 Then
                    trans.Rollback()
                    Return 0
                End If
            Next

        Catch ex As Exception
            TrataEx(ex)
            trans.Rollback()
            Return 0
        End Try
        trans.Commit()
        Return Id_Carta

    End Function


    'Public Shared Function fn_CartasAcceso_GeneraReporte(ByVal Id_Carta As Integer) As rpt_CartaAcceso

    'Dim rpt As New rpt_CartaAcceso
    'Dim Ds As New Ds_CartaAcceso

    'fn_CartasAcceso_LlenarDataSet(Ds, Id_Carta)

    'rpt.SetDataSource(Ds)
    'Return rpt

    'End Function


    Public Shared Function fn_CartasAcceso_LlenarDT(ByVal Id_Carta As Integer) As DataTable
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_CartasAcceso_GetRpt", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)

        Try
            Dt = Cn_Datos.EjecutaConsulta(cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CartasAcceso_ObtenerEmpresa() As DataRow

        Dim cmd As SqlCommand = Crea_Comando("Cat_Empresas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Empresa", SqlDbType.Int, EmpresaId)

        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return dt.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "CONSULTA DE CARTAS DE ACCESO"

    Public Shared Function fn_CartasAccesoConsulta_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Empleado As Integer, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime, ByVal Status As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_CartasAcceso_Get", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Crea_Parametro(Cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
            Crea_Parametro(Cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(Cmd, "Id_Carta")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CartasAccesoConsulta_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Carta As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_CartasAccesoD_Get", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)

            lsv.Actualizar(Cmd, "Id_Carta")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CartasAccesoConsulta_ActualizarStatus(ByVal Id_Carta As Integer, ByVal Status As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_CartasAcceso_Status", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(Cmd, "@UsuarioCancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@EstacionCancela", SqlDbType.VarChar, EstacioN)

            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CartasAccesoConsulta_Validar(ByVal Id_Carta As Integer, ByVal Usuario_Valida As Integer, ByVal Observaciones As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_CartasAcceso_Validar", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)
            Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.VarChar, Usuario_Valida)
            Crea_Parametro(Cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Observaciones_Valida", SqlDbType.VarChar, Observaciones)

            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CartasAccesoConsulta_UsuarioAutoriza(ByVal Id_Empleado As Integer) As DataRow
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Empleados_Read", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim dt As DataTable = EjecutaConsulta(Cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Reporte de Verificación por Cajero"

    Public Shared Function fn_VerificacionXCajero_ObtenerDatos(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Corte As Integer, ByVal Id_SesionDesde As Integer, ByVal Id_SesionHasta As Integer, ByVal Id_Cajero As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_ReporteXCajero", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
            Crea_Parametro(cmd, "@Id_SesionDesde", SqlDbType.Int, Id_SesionDesde)
            Crea_Parametro(cmd, "@Id_SesionHasta", SqlDbType.Int, Id_SesionHasta)
            Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")
            'Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_VerificacionXCajero_ObtenerDatosDoctos(ByVal Id_CajaBancaria As Integer, ByVal Corte As Integer, ByVal Id_SesionDesde As Integer, ByVal Id_SesionHasta As Integer, ByVal Id_Cajero As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteXCajeroDoctos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
            Crea_Parametro(cmd, "@Id_SesionDesde", SqlDbType.Int, Id_SesionDesde)
            Crea_Parametro(cmd, "@Id_SesionHasta", SqlDbType.Int, Id_SesionHasta)
            Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_VerificacionXCajero_GetDenominacionesPresentacion(ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesPresentacion_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, "T")

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region


#Region "Reporte de Verificación por Cajero"

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosRemisiones(ByVal SDesde As Integer, ByVal SHasta As Integer, ByVal Id_Cajero As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get3", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosPiezasSinDificultad(ByVal SDesde As Integer, ByVal SHasta As Integer, ByVal Id_Cajero As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get10", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosPiezas(ByVal SDesde As Integer, ByVal SHasta As Integer, ByVal Id_Cajero As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get4", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosImportes(ByVal SDesde As Integer, ByVal SHasta As Integer, ByVal Id_Cajero As Integer, ByVal Id_Moneda As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get5", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")
            Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

            Dim dt As DataTable = EjecutaConsulta(cmd)

            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosTiempos(ByVal SDesde As Integer, ByVal SHasta As Integer, ByVal Id_Cajero As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get6", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosTiemposXcliente(ByVal SDesde As Integer, ByVal SHasta As Integer, ByVal Id_Cajero As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get9", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosRemisionesGlobal(ByVal SDesde As Integer, ByVal SHasta As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get7", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AcumuladosXcajero_ObtenerDatosPiezasGlobal(ByVal SDesde As Integer, ByVal SHasta As Integer) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_Get8", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@SDesde", SqlDbType.Int, SDesde)
            Crea_Parametro(cmd, "@SHasta", SqlDbType.Int, SHasta)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_HorariosRecepcionRutas_Consultar(ByVal FDesde As Date, ByVal FHasta As Date) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("Tv_Programacion_GetHorarios", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@FDesde", SqlDbType.Date, FDesde)
            Crea_Parametro(cmd, "@FHasta", SqlDbType.Date, FHasta)

            Dim dt As DataTable = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region


#Region "Empleados que Autorizan Diferencias"

    Public Shared Function fn_EmpleadosAutoriza_Guardar(ByVal Id_Empleado As Integer) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Pro_DiferenciasAutoriza_Create", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosAutorizados_LlenarLista(ByVal Lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_DiferenciasAutoriza_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")
            Lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosAutorizados_AltaBaja(ByVal Id_Empleado As Integer, ByVal Status As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Pro_DiferenciasAutoriza_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)
            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

#End Region

#Region "DESCARGA MANUAL DE USUARIO"

    Public Shared Function fn_Archivos_Descargar(ByVal Id_Doc As Integer) As Byte()
        Dim dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Doc", SqlDbType.Int, Id_Doc)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Archivo")
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Shared Function fn_ModulosArchivos_LlenarLista(ByRef lsv As cp_Listview, ByVal Clave_Modulo As String) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
        Try
            lsv.Actualizar(Cmd, "Id_Doc")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "Vales"
    Public Shared Function Fn_Vales_Llenarlista(ByVal Lsv_Lista As cp_Listview, ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal SesionDesde As Integer, ByVal SesionHasta As Integer)

        Dim Cmd As SqlCommand = Crea_Comando("Pro_FichasOtros_GetTabular", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@Id_SesionDesde", SqlDbType.Int, SesionDesde)
        Crea_Parametro(Cmd, "@Id_SesionHasta", SqlDbType.Int, SesionHasta)

        Lsv_Lista.Actualizar(Cmd, "Id_Ficha")
        Return True
    End Function

    Public Shared Function Fn_Vales_DataTable() As DataTable
        Dim dt As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Odoctos_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        dt = Cn_Datos.EjecutaConsulta(Cmd)

        Return dt
    End Function

#End Region

#Region "Reporte de Concentraciones"

    Public Shared Function fn_DetalleDepositos_LlenarRemisiones(ByVal lsv As cp_Listview, ByVal Id_CajaBancaria As Integer, _
                                                                ByVal Id_Cliente As Integer, _
                                                                ByVal S_Desde As Integer, ByVal S_Hasta As Integer, _
                                                                ByVal Id_Moneda As Integer, ByVal Id_GrupoF As Integer, _
                                                                ByVal Dpto_Procesa As String, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetProceso", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto_Procesa)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, S_Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Try
            lsv.Actualizar(cmd, "Id_Servicio")

            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DetalleDepositos_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Servicio As Integer, ByVal Id_Moneda As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_GetFacturacion", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            lsv.Actualizar(cmd, "Id_Denominacion")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function Fn_DetalleDepositos_Cheques(ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal S_Desde As Integer, ByVal S_Hasta As Integer, ByVal Id_Moneda As Integer, ByVal Dpto_procesa As String, ByVal Id_GrupoDepo As Integer, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Pro_FichasCheques_GetCheques", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@S_Desde", SqlDbType.Int, S_Desde)
        Crea_Parametro(Cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(Cmd, "@Dpto_procesa", SqlDbType.VarChar, Dpto_procesa)
        Crea_Parametro(Cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Dt = Cn_Datos.EjecutaConsulta(Cmd)

        Return Dt
    End Function

    Public Shared Function Fn_DetalleDepositos_ChequesEsp(ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal S_Desde As Integer, ByVal S_Hasta As Integer, ByVal Id_Moneda As Integer, ByVal Dpto_procesa As String, ByVal Id_GrupoDepo As Integer, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Pro_FichasCheques_GetCheques2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@S_Desde", SqlDbType.Int, S_Desde)
        Crea_Parametro(Cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(Cmd, "@Dpto_procesa", SqlDbType.VarChar, Dpto_procesa)
        Crea_Parametro(Cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Dt = Cn_Datos.EjecutaConsulta(Cmd)

        Return Dt
    End Function

    Public Shared Function fn_DetalleDepositos_GetServicios(ByVal Id_CajaBancaria As Integer, ByVal Id_Clientes As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoDepo As Integer, ByVal Dpto As Char, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetReporteConcePro", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Clientes)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Dt = EjecutaConsulta(cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DetalleDepositos_GetServiciosEsp(ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoDepo As Integer, ByVal Dpto As Char, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetReporteConcePro2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DetalleDepositos_GetDesglose(ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_GetReporteConcePro", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DetalleDepositos_GetDesgloseEsp(ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_GetReporteConcePro2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@S_Desde", SqlDbType.Int, Desde)
        Crea_Parametro(cmd, "@S_Hasta", SqlDbType.Int, Hasta)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, Dpto)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoF)
        Crea_Parametro(cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DetalleDepositos_GetDenominaciones(ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesMoneda_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)

            Return Nothing
        End Try
    End Function

    Public Shared Function Fn_DetalleDepositos_GetOdoctosCat() As DataTable
        Dim Dt As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Odoctos_get", CommandType.StoredProcedure, Crea_ConexionSTD)

        Dt = Cn_Datos.EjecutaConsulta(Cmd)

        Return Dt
    End Function

    Public Shared Function Fn_DetalleDepositos_GetOdoctosEsp(ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal S_Desde As Integer, ByVal S_Hasta As Integer, ByVal Id_Moneda As Integer, ByVal Dpto_procesa As String, ByVal Id_GrupoDepo As Integer, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Pro_FichasOtros_Get2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Crea_Parametro(Cmd, "@S_Desde", SqlDbType.Int, S_Desde)
        Crea_Parametro(Cmd, "@S_Hasta", SqlDbType.Int, S_Hasta)
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(Cmd, "@Dpto_procesa", SqlDbType.VarChar, Dpto_procesa)
        Crea_Parametro(Cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)

        Dt = Cn_Datos.EjecutaConsulta(Cmd)

        Return Dt
    End Function

    Public Shared Function fn_DetalleDepositos_GenerarExcelEspecial(ByVal Id_CajaBancaria As Integer, ByVal id_Cliente As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char, ByVal Encabezado1 As String, ByVal Encabezado2 As String, ByVal Bar As ToolStripProgressBar, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As Boolean

        Dim Dt_Servicios As DataTable
        Dim Dt_Desglose As DataTable
        Dim Dt_Cheques As DataTable 'Cheques
        Dim Ficha As Integer
        Dim j As Integer = 4
        Dim Suma As String
        Dim Letra_Final As String = ""
        Dim Letra_FinalN As Integer
        Dim Letra_FinBilletes As Char = "M"
        Dim Letra_FinBilletesN As Integer = 78
        Dim Letra_FinDBilletes As Integer = 77

        Bar.Value = 0
        'Traer las Denominaciones
        Dim Denominaciones As DataTable = fn_DetalleDepositos_GetDenominaciones(Id_Moneda)
        If Denominaciones Is Nothing Then
            MsgBox("No existen Denominaciones para la Moneda seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        'Traer las Dotaciones
        Dt_Servicios = fn_DetalleDepositos_GetServiciosEsp(Id_CajaBancaria, id_Cliente, Id_Moneda, Desde, Hasta, Id_GrupoF, Dpto, Id_ClienteP, Id_Cia)
        If Dt_Servicios Is Nothing Then
            MsgBox("No Hay Informacion para los datos seleccionados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If
        If Dt_Servicios.Rows.Count = 0 Then
            MsgBox("No Hay Informacion para los datos seleccionados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        'Traer el dsglose
        Dt_Desglose = fn_DetalleDepositos_GetDesgloseEsp(Id_CajaBancaria, id_Cliente, Id_Moneda, Desde, Hasta, Id_GrupoF, Dpto, Id_ClienteP, Id_Cia)
        If Dt_Desglose Is Nothing Then
            MsgBox("Ocurrió un Error al intentar Consultar el Desglose de las Fichas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        'Traer los Cheques
        Dt_Cheques = Fn_DetalleDepositos_ChequesEsp(frm_DetalleDepositos.cmb_CajaBancaria.SelectedValue, id_Cliente, frm_DetalleDepositos.cmb_Desde.SelectedValue, frm_DetalleDepositos.cmb_Hasta.SelectedValue, frm_DetalleDepositos.cmb_Moneda.SelectedValue, True, frm_DetalleDepositos.Cmb_grupo.SelectedValue, Id_ClienteP, Id_Cia)
        If Dt_Cheques Is Nothing Then
            MsgBox("Ocurrió un Error al intentar Consultar los Cheques.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If
        Bar.Maximum = Dt_Servicios.Rows.Count + 1
        'Dim  As New Excel.Application
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim objExcel As Object
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            objExcel = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                objExcel = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If Not versionHC Then
            MsgBox("No se encontró ningún software para exportar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If
        With objExcel

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1

            'Creando los encabezados
            .Range("A1:G1").Merge()
            .Range("A2:G2").Merge()
            .Range("A1:A2").Font.Bold = True
            .Range("A1").Value = Encabezado1
            .Range("A2").Value = Encabezado2
            .Range("A3").Value = "FECHA"
            .Range("B3").Value = "REMISION"
            .Range("C3").Value = "ORIGEN"
            .Range("D3").Value = "NUMERO CUENTA"
            .Range("E3").Value = "REFERENCIA"
            .Range("F3").Value = "IMPORTE EFECTIVO"
            .Range("G3").Value = "IMPORTE CHEQUES"
            .Range("H3").Value = "IMPORTE OTROS"
            .Range("I3").Value = "DIFERENCIA EFECTIVO"
            .Range("J3").Value = "DIFERENCIA CHEQUES"
            .Range("K3").Value = "DIFERENCIA OTROS"
            .Range("L3").Value = "BOLSAS"
            .Range("M3").Value = "MAZOS"



            For Each row As DataRow In Denominaciones.Rows
                If Microsoft.VisualBasic.Left(row("Presentacion"), 1) = "B" Then
                    Letra_FinDBilletes += 1

                End If
                .Range(LetrA(78 + Denominaciones.Rows.IndexOf(row)) & 2).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1)
                .Range(LetrA(78 + Denominaciones.Rows.IndexOf(row)) & 3).Value = CDec(row("Denominacion"))
                If Microsoft.VisualBasic.Left(row("Presentacion"), 1) = "M" Then
                    .Range(LetrA(78 + Denominaciones.Rows.IndexOf(row)) & 1).Value = row("CantidadXbolsa")
                Else
                    Letra_FinBilletes = LetrA(78 + Denominaciones.Rows.IndexOf(row))
                    Letra_FinBilletesN = 78 + Denominaciones.Rows.IndexOf(row)
                End If
                Letra_Final = 78 + Denominaciones.Rows.IndexOf(row)
                Letra_FinalN = 78 + Denominaciones.Rows.IndexOf(row)
            Next
            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
            Ficha = 0
            For Each FilaD As DataRow In Dt_Servicios.Rows
                If Ficha = 0 Then
                    Ficha = FilaD.Item("Id_Ficha")
                ElseIf Ficha <> FilaD.Item("Id_Ficha") Then
                    Ficha = FilaD.Item("Id_Ficha")
                    j += 1
                End If

                .Range("A" & j).Value = FilaD.Item("Fecha")
                .Range("B" & j).Value = FilaD.Item("Remision")
                .Range("C" & j).Value = FilaD.Item("Cliente")
                .Range("D" & j).Value = FilaD.Item("Num_Cuenta")
                .Range("E" & j).Value = FilaD.Item("Referen")
                .Range("F" & j).Value = FilaD.Item("Imp_Efec")
                .Range("G" & j).Value = FilaD.Item("Imp_Cheq")
                .Range("H" & j).Value = FilaD.Item("Imp_Otros")
                .Range("I" & j).Value = FilaD.Item("Dif_Efec")
                .Range("J" & j).Value = FilaD.Item("Dif_Cheq")
                .Range("K" & j).Value = FilaD.Item("Dif_Otros")
                .Range("L" & j).Value = 0
                .Range("M" & j).Value = 0


                'Efectivo
                Dim EfectivoTemporal() As DataRow

                If Fila_Anterior <> j Then
                    Fila_Anterior = j

                    EfectivoTemporal = Dt_Desglose.Select("Id_Ficha=" & FilaD("Id_Ficha"))

                    For IEfe As Integer = 0 To EfectivoTemporal.Length - 1
                        For Each row As DataRow In Denominaciones.Rows
                            If row.Item("Id_Denominacion") = EfectivoTemporal(IEfe)("Id_Denominacion") Then
                                .Range(LetrA(78 + Denominaciones.Rows.IndexOf(row)) & j).Value = EfectivoTemporal(IEfe)("Cantidad")
                                Dim columna As Integer = 78 + Denominaciones.Rows.Count - 1
                                Exit For
                            End If
                        Next
                    Next IEfe

                    Dim ChequesTemporal() As DataRow
                    ChequesTemporal = Dt_Cheques.Select("Id_Ficha=" & FilaD("Id_Ficha"))
                    If ChequesTemporal.Length > 0 Then
                        Dim Formula As String

                        .Range(LetrA(Letra_Final + 1) & j).FormulaLocal = "=SI(SUMA(" & LetrA(Letra_Final + 2) & j & "+" & LetrA(Letra_Final + 3) & j & ") = 0,"""", (" & LetrA(Letra_Final + 2) & j & "+" & LetrA(Letra_Final + 3) & j & "))"
                        If ChequesTemporal(0)("cheques_propios") > 0 Then
                            .Range(LetrA(Letra_Final + 2) & j).value = ChequesTemporal(0)("Cheques_Propios")
                        End If
                        If ChequesTemporal(0)("cheques_otros") > 0 Then
                            .Range(LetrA(Letra_Final + 3) & j).value = ChequesTemporal(0)("Cheques_Otros")
                        End If
                        If ChequesTemporal(0)("Importe_Cheques") > 0 Then
                            .Range(LetrA(Letra_Final + 4) & j).value = ChequesTemporal(0)("Importe_Cheques")
                        End If
                        If ChequesTemporal(0)("Cheques_PropiosImp") > 0 Then
                            .Range(LetrA(Letra_Final + 5) & j).value = ChequesTemporal(0)("Cheques_Propiosimp")
                        End If
                        If ChequesTemporal(0)("Cheques_OtrosImp") > 0 Then
                            .Range(LetrA(Letra_Final + 6) & j).value = ChequesTemporal(0)("Cheques_Otrosimp")
                        End If

                        Dim ColumnaF As Integer = Letra_Final
                        Formula = "="
                        For Each t As DataRow In Denominaciones.Rows
                            If ColumnaF = 95 And j = 4 Then
                                Formula = "=(" & LetrA(ColumnaF) & 3 & "*" & LetrA(ColumnaF) & j & ")"
                            Else
                                Formula &= "+" & "(" & LetrA(ColumnaF) & 3 & "*" & LetrA(ColumnaF) & j & ")"
                            End If
                            ColumnaF -= 1
                        Next

                        Formula &= "+(" & (LetrA(Letra_Final + 4) & j) & ")"
                        .Range(LetrA(Letra_Final + 7) & j).FormulaLocal = Formula

                    End If
                End If
                Bar.Value += 1
            Next

            .Range(LetrA(Letra_Final + 1) & 3).Value = "CANT CHEQUES"
            .Range(LetrA(Letra_Final + 2) & 3).Value = "CANT PROPIOS"
            .Range(LetrA(Letra_Final + 3) & 3).Value = "CANT OTROS"
            .Range(LetrA(Letra_Final + 4) & 3).Value = "CHEQUES IMPORTE"
            .Range(LetrA(Letra_Final + 5) & 3).Value = "PROPIOS IMPORTE"
            .Range(LetrA(Letra_Final + 6) & 3).Value = "OTROS IMPORTE"
            .Range(LetrA(Letra_Final + 7) & 3).value = "COMPROBACION"

            'MAZOS Y BOLSAS
            Suma = "=Suma"
            Dim Bolsas As Decimal = 0.0
            Dim BolsasT As Decimal = 0.0
            For I As Integer = 4 To j
                BolsasT = 0
                For k = Letra_FinBilletesN + 1 To Letra_FinalN
                    If .range(LetrA(k) & I).value IsNot Nothing Then
                        Bolsas = CDec(.range(LetrA(k) & I).value) / .range(LetrA(k) & 1).value
                        BolsasT += Bolsas
                    End If
                Next
                .Range("L" & I).value = BolsasT
                If Letra_FinBilletesN = 77 Then
                    .Range("M" & I).Formula = 0
                Else
                    .Range("M" & I).FormulaLocal = Suma & "(N" & I & ":" & LetrA(Letra_FinDBilletes) & I & ")/1000"
                End If

                .Range("L" & I).NumberFormat = "#,##0.000"
                .Range("M" & I).NumberFormat = "#,##0.000"
            Next
            'Limpiar las cantidades por bolsa
            For k = Letra_FinBilletesN + 1 To Letra_FinalN
                .range(LetrA(k) & 1).value = ""
            Next
            'SUMATORIAS
            j += 1
            For I As Integer = 70 To Letra_FinalN + 7
                .Range(LetrA(I) & j).FormulaLocal = Suma & "(" & LetrA(I) & 4 & ":" & LetrA(I) & j - 1 & ")"
            Next

            .Range("N2:" & LetrA(Letra_Final) & 2).Borders.Value = True
            .Range("N2:" & LetrA(Letra_Final) & 2).Font.Bold = True
            Letra_Final = LetrA(Letra_Final + 7)

            .Range(Letra_Final & 3).ColumnWidth = 16
            .Range("E3").ColumnWidth = 16
            .Range("A3:" & Letra_Final & 3).Wraptext = True
            .Range("A3:" & Letra_Final & 3).RowHeight = 35
            .Range("A3:" & Letra_Final & 3).Font.Bold = True
            .Range("A3:" & Letra_Final & j).Borders.Value = True
            .Range("A" & j & ":" & Letra_Final & j).Font.Bold = True
            .Range("M" & j & ":" & Letra_Final & j).NumberFormat = "#,##0.00"
            .Range(Letra_Final & 4 & ":" & Letra_Final & j).NumberFormat = "#,##0.00"

            'Mostrando el libro
            .Range("A:" & Letra_Final).EntireColumn.AutoFit()
            .Visible = True

        End With
        Bar.Value = Bar.Maximum
        Return True
        Bar.Value = Bar.Minimum
    End Function

    Public Shared Function fn_DetalleDepositos_GenerarExcelVales(ByVal Id_CajaBancaria As Integer, ByVal id_Cliente As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char, ByVal Encabezado1 As String, ByVal Encabezado2 As String, ByVal Bar As ToolStripProgressBar, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As Boolean

        Dim Dt_ODoctos As DataTable
        Dim Dt_Vales As DataTable
        Dim Ficha As Integer
        Dim Fila As Integer = 0
        Dim Suma As String
        Dim HojaActiva As Integer = 0

        Bar.Value = 0

        'Traer las Dotaciones
        Dt_ODoctos = Fn_DetalleDepositos_GetOdoctosCat()
        If Dt_ODoctos Is Nothing Then
            MsgBox("Ocurrió un erorr al intentar consultar el catálogo de Otros Documentos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If
        If Dt_ODoctos.Rows.Count = 0 Then
            MsgBox("No Hay Informacion en el catálogo de Otros Documentos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        'Traer las Fichas con los Documentos
        Dt_Vales = Fn_DetalleDepositos_GetOdoctosEsp(Id_CajaBancaria, id_Cliente, Desde, Hasta, Id_Moneda, True, Id_GrupoF, Id_ClienteP, Id_Cia)
        If Dt_Vales Is Nothing Then
            MsgBox("Ocurrió un Error al intentar Consultar las Fichas de Depósito.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If
        If Dt_Vales.Rows.Count = 0 Then
            MsgBox("No hay informacion de Fichas de Depósito con los filtros seleccionados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        Bar.Maximum = Dt_ODoctos.Rows.Count + 1
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim objExcel As Object
        Dim Book As Object
        Dim Sheet As Object
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            objExcel = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                objExcel = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If Not versionHC Then
            MsgBox("No se encontró ningún software para exportar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        'Creando el libro
        objExcel.SheetsInNewWorkbook = 1
        Book = objExcel.Workbooks.Add()

        For Each Documento As DataRow In Dt_ODoctos.Rows

            Dim ValesTemporal() As DataRow
            ValesTemporal = Dt_Vales.Select("Id_Odocto=" & Documento("Id_Odocto"))
            If ValesTemporal.Length > 0 Then
                Sheet = Book.Sheets.Add()
                If Sheet.name.ToString.ToUpper = "SHEET1" Then Suma = "=Sum" Else Suma = "=Suma"
                Try
                    Sheet.Name = Documento("Descripcion")
                Finally
                End Try
                Sheet.Cells.Font.Name = "Arial"
                'Creando los encabezados
                Sheet.Range("A1:F1").Merge()
                Sheet.Range("A2:F2").Merge()
                Sheet.Range("A3:F3").Merge()
                Sheet.Range("A4:F4").Merge()
                Sheet.Range("A1:F5").Font.Bold = True
                Sheet.Range("A1").Value = Encabezado1
                Sheet.Range("A2").Value = Encabezado2
                Sheet.Range("A3").Value = Documento("Descripcion")
                Sheet.Range("A5").Value = "FECHA"
                Sheet.Range("B5").Value = "REMISION"
                Sheet.Range("C5").Value = "ORIGEN"
                Sheet.Range("D5").Value = "NUMERO CUENTA"
                Sheet.Range("E5").Value = "REFERENCIA"
                Sheet.Range("F5").Value = "IMPORTE"

                Dim Fila_Anterior As Integer = 1
                Ficha = 0
                Fila = 5
                Dim Indice As Integer = 0
                For Indice = 0 To ValesTemporal.Count - 1

                Next
                For Indice = 0 To ValesTemporal.Length - 1
                    If ValesTemporal(Indice)("Importe_Docto") = 0 Then Continue For

                    Fila += 1
                    Sheet.Range("A" & Fila).Value = ValesTemporal(Indice)("Fecha")
                    Sheet.Range("B" & Fila).Value = ValesTemporal(Indice)("Remision")
                    Sheet.Range("C" & Fila).Value = ValesTemporal(Indice)("Cliente")
                    Sheet.Range("D" & Fila).Value = "'" & ValesTemporal(Indice)("Cuenta")
                    Sheet.Range("E" & Fila).Value = "'" & ValesTemporal(Indice)("Referencia")
                    Sheet.Range("F" & Fila).Value = ValesTemporal(Indice)("Importe_Docto")

                Next

                Fila += 1

                Sheet.Range("A5:F" & Fila).Borders.Value = True
                Sheet.Range("F" & Fila).FormulaLocal = Suma & "(F6:F" & Fila - 1 & ")"
                Sheet.Range("F6:F" & Fila).NumberFormat = "#,##0.00"
                Sheet.Range("A" & Fila & ":" & "F" & Fila).Font.Bold = True

                Sheet.Range("A5").ColumnWidth = 13
                Sheet.Range("B5").ColumnWidth = 15
                Sheet.Range("C5").ColumnWidth = 40
                Sheet.Range("D5").ColumnWidth = 19
                Sheet.Range("E5").ColumnWidth = 20
                Sheet.Range("F5").ColumnWidth = 15

            End If
            Bar.Value += 1
            If Bar.Value = Bar.Maximum Then Bar.Maximum += 1
        Next
        '.Range("A:" & Letra_Final).EntireColumn.AutoFit()
        objExcel.Visible = True

        Bar.Value = Bar.Maximum
        Return True
        Bar.Value = Bar.Minimum
    End Function

#End Region

#Region "Saldo_Cuadre"

    Public Shared Function fn_SaldoCuadre_LlenarLista(ByVal Id_Cajabancaria As Integer, ByVal Id_Moneda As Integer, ByVal Presentacion As Char) As DataTable

        Dim Dt As New DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Pro_Saldo_GetCuadre", CommandType.StoredProcedure, Crea_ConexionSTD)

        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Cajabancaria)
        Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(Cmd, "@Presentacion", SqlDbType.Char, Presentacion)
        Try
            Dt = EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
        Return Dt
    End Function

    Public Shared Function fn_SaldoCuadre_UpdateCompleto(ByVal Id_CajaBancaria As Integer, ByVal dgv As DataGridView) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Try
            For Each row As DataGridViewRow In dgv.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Pro_Saldo_UpdateCuadre")
                Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                Crea_Parametro(Cmd, "@Id_Denominacion", SqlDbType.Int, row.Cells(2).Tag)
                Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, CInt(row.Cells(5).Value))
                Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Int, CInt(row.Cells(6).Value))
                Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Int, CInt(row.Cells(7).Value))
                Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Int, CInt(row.Cells(8).Value))
                Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Int, CInt(row.Cells(9).Value))
                Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Int, CInt(row.Cells(10).Value))
                EjecutarNonQueryT(Cmd)
            Next
            Tr.Commit()
            Cmd.Dispose()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            Cnn.Dispose()
            TrataEx(ex, True)
            Return False
        End Try

    End Function

#End Region

#Region "Proceso Saldos"

    Public Shared Function fn_MonitoreoSaldo_CajerosProceso(ByVal lsv As cp_Listview) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetXcajero", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Dpto_procesa", SqlDbType.VarChar, "P")

        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_MonitoreoSaldo_CajerosDetalle(ByVal lsv As cp_Listview, ByVal Id_Cajero As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetXcajeroD", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)

        Try
            lsv.Actualizar(cmd, "")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_SaldoDotacionesLlenalista(ByVal lsv As cp_Listview, ByVal Fecha As Date, ByVal Id_Caja As Integer, ByVal Moneda As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Caja)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Moneda)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_SaldoServiciosDisponibleLlenalista(ByVal lsv As cp_Listview, ByVal Id_Sesion As Integer, ByVal Id_Caja As Integer, ByVal Moneda As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasEfectivo_Get2", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Caja)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1) 'Tipo 1 es para Efetivo Contabilizado y Disponible

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_SaldoServiciosXDisponerLlenalista(ByVal lsv As cp_Listview, ByVal Id_Sesion As Integer, ByVal Id_Caja As Integer, ByVal Moneda As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasEfectivo_Get2", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Caja)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2) 'Tipo 2 es para Efetivo aun sin Contabilizar 

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Catalogar Servicios"

    Public Shared Function fn_CatalogarServiciosLlenalista(ByVal lsv As cp_Listview, ByVal Id_Caja As Integer, ByVal Id_Sesion As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Servicios_Get2", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Caja)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Servicio")
            'lsv.Columns(1).TextAlign = HorizontalAlignment.Left
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(5).TextAlign = HorizontalAlignment.Center
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CatalogarDotacionesLlenalista(ByVal lsv As cp_Listview, ByVal Id_Caja As Integer, ByVal Id_Sesion As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Dotaciones_Get2", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Caja)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            'lsv.Columns(1).TextAlign = HorizontalAlignment.Center
            'lsv.Columns(2).TextAlign = HorizontalAlignment.Center
            'lsv.Columns(3).TextAlign = HorizontalAlignment.Center
            'lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CatalogarServicioUpdate(ByVal lsv As cp_Listview, ByVal Tipo As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

            Dim Contador As Integer = 0

            For Each Elem As ListViewItem In lsv.CheckedItems
                Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Servicios_Update2", CommandType.StoredProcedure, Cnn)
                Crea_Parametro(Cmd, "@Id_Servicio", SqlDbType.Int, Elem.Tag)
                Crea_Parametro(Cmd, "@Tipo_Entrada", SqlDbType.TinyInt, Tipo)
                Contador += EjecutarNonQuery(Cmd)

            Next

            If Contador = lsv.CheckedItems.Count Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CatalogarDotacioensUpdate(ByVal lsv As cp_Listview, ByVal Tipo As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

            Dim Contador As Integer = 0

            For Each Elem As ListViewItem In lsv.CheckedItems
                Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Dotaciones_Update2", CommandType.StoredProcedure, Cnn)
                Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, Elem.Tag)
                Crea_Parametro(Cmd, "@Tipo_Salida", SqlDbType.Int, Tipo)
                Contador += EjecutarNonQuery(Cmd)

            Next

            If Contador = lsv.CheckedItems.Count Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region

#Region "Grupos de Deposito"

    'Eera Array se cambio por DT 7/12/2012
    Public Shared Function fn_GrupoDeposito_ObtenValores(ByVal Id_GrupoDota As Integer) As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_GrupoDeposito_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDota)
        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_GrupoDeposito_ValidarDescripcion(ByVal Descripcion As String, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_GrupoDeposito_ReadDescripcion", CommandType.StoredProcedure, cnn)
        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDeposito_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal Id_CajaBancaria As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDeposito_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            'Aqui se Actualiza la lista
            lsw.Actualizar(Cmd, "Id_GrupoDepo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    '7/12/2012 modificado
    Public Shared Function fn_GrupoDeposito_Nuevo(ByVal Descripcion As String, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDeposito_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    '7/12/2012 modificado
    Public Shared Function fn_GrupoDeposito_Actualizar(ByVal Id_GrupoDepo As Integer, ByVal Descripcion As String) As Boolean
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDeposito_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDeposito_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_GrupoDeposito_Status", "@Id_GrupoDepo")

    End Function

    Public Shared Function fn_GrupoDeposito_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_GrupoDeposito_Status", "@Id_GrupoDepo")

    End Function

    Public Shared Function fn_GrupoDeposito_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_GrupoDeposito_Dependencias", "@Id_GrupoDepo")

    End Function



#End Region

#Region "Grupos de Dotaciones"
    'Eera Array se cambio por DT 7/12/2012

    Public Shared Function fn_GrupoDota_ObtenValores(ByVal Id_GrupoDota As Integer) As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_GrupoDota_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_GrupoDota", SqlDbType.Int, Id_GrupoDota)
        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    'MOdificar chekar 7/10/2012
    Public Shared Function fn_GrupoDota_ValidarDescripcion(ByVal Descripcion As String, ByVal Id_CajaBancaria As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_GrupoDota_ReadDescripcion", CommandType.StoredProcedure, cnn)

        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.VarChar, Id_CajaBancaria)
        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDota_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal Id_CajaBancaria As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDota_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            'Aqui se Actualiza la lista
            lsw.Actualizar(Cmd, "Id_GrupoDota")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
    'modificado 7/12/2012
    Public Shared Function fn_GrupoDota_Nuevo(ByVal Descripcion As String, ByVal Id_CajaBancaria As Integer) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDota_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    '-------MOdificadoeste proc 7/12/2012
    Public Shared Function fn_GrupoDota_Actualizar(ByVal Id_GrupoDota As Integer, ByVal Descripcion As String) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDota_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoDota", SqlDbType.Int, Id_GrupoDota)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDota_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_GrupoDota_Status", "@Id_GrupoDota")

    End Function

    Public Shared Function fn_GrupoDota_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_GrupoDota_Status", "@Id_GrupoDota")

    End Function

    Public Shared Function fn_GrupoDota_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_GrupoDota_Dependencias", "@Id_GrupoDota")

    End Function

#End Region

#Region "Validar Actas"

    Public Shared Function fn_ValidarActasLlenalista(ByVal lsv As cp_Listview, ByVal Id_ClienteP As Integer, ByVal Id_Caja As Integer, ByVal Id_Sesion As Integer, ByVal Id_Cia As Integer, ByVal Tipo_Diferencia As String) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Actas_Get", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            Crea_Parametro(Cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
            Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Caja)
            Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            If Tipo_Diferencia <> "0" Then Crea_Parametro(Cmd, "@Tipo_Diferencia", SqlDbType.VarChar, Tipo_Diferencia)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Acta")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Center
            lsv.Columns(10).Width = 0
            lsv.Columns(11).Width = 0
            lsv.Columns(12).Width = 0
            lsv.Columns(13).Width = 0

            'lsv.Columns(1).TextAlign = HorizontalAlignment.Left
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidarActas(ByVal Id_Acta As Integer, ByVal Observaciones As String, ByVal Id_TipoDiferencia As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_Actas_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Acta", SqlDbType.Int, Id_Acta)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Observaciones)
        'El @Tipo solo es el que especifica si es Validacion o Cancelacion del Acta, ya que ocupo el mismo Procedimiento
        Crea_Parametro(cmd, "@Tipo", SqlDbType.VarChar, "V")
        If Id_TipoDiferencia > 0 Then Crea_Parametro(cmd, "@Id_TipoDiferencia", SqlDbType.Int, Id_TipoDiferencia)

        Try
            Return EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_CancelarActas(ByVal Id_Acta As Integer, ByVal Observaciones As String) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("Pro_Actas_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Acta", SqlDbType.Int, Id_Acta)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Observaciones)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.VarChar, "C")
        'El Tipo solo es el que especifica si es Validacion o Cancelacion del Acta, ya que ocupo el mismo Procedimiento
        Try
            Return EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ImprimirActaDiferencia(ByRef Tbl As DataTable, ByVal Id_Acta As Integer, ByVal TipoActa As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Pro_Actas_GetReporte", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Acta", SqlDbType.Int, Id_Acta)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, TipoActa)
            'TipoActa 1= Reporte x Ficha 
            'TipoActa 2= Reporte x Remision

            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                If Tbl.Rows.Count = 0 Then
                    Return False
                End If
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_CargarEnvasesActaDiferencia(ByRef Tbl As DataTable, ByVal Id_Remision As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Cat_Envases_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                If Tbl.Rows.Count = 0 Then
                    Return False
                End If
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function

    Public Shared Function fn_VerificarDepositos_Resultados(ByRef Tbl As DataTable, ByVal Id_Servicio As Integer) As Boolean
        Using cmd As SqlCommand = Crea_Comando("Pro_Servicios_Totales", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
            Try
                Tbl.Rows.Clear()
                cmd.Connection.Open()
                Tbl.Load(cmd.ExecuteReader)
                cmd.Connection.Close()
                If Tbl.Rows.Count = 0 Then
                    Return False
                End If
                Return True
            Catch ex As Exception
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                TrataEx(ex)
                Return False
            End Try
        End Using
    End Function



    Public Shared Function fn_DetalleRemisionLlenalista(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Moneda")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
    Public Shared Function fn_FichasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Fichas_GetByRemision", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Ficha")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right


            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
    Public Shared Function fn_FichasDetalleLlenalista(ByVal lsv As cp_Listview, ByVal Id_Ficha As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasEfectivo_Get", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Ficha", SqlDbType.Int, Id_Ficha)
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Denominacion")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(10).Width = 0
            'lsv.Columns(1).TextAlign = HorizontalAlignment.Left
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_FichasTotalesLlenalista(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasEfectivo_GetById_Servicio", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Denominacion")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right

            'lsv.Columns(10).Width = 0
            'lsv.Columns(1).TextAlign = HorizontalAlignment.Left
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



#End Region

#Region "Reporte Actas"

    Public Shared Function fn_ReporteActasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Id_Caja As Integer, _
                                                     ByVal Id_SesionDesde As Integer, ByVal Id_SesionHasta As Integer, _
                                                     ByVal Id_Cia As Integer, ByVal Tipo_Diferencia As String) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            'Es el nombre del procediemiento de produccion se comento y se creo uno nuevo para pruebas
            'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Actas_Get2_PruebasA", CommandType.StoredProcedure, Cnn)
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Actas_Get2_PruebasAA", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(Cmd, "@Id_SesionDesde", SqlDbType.Int, Id_SesionDesde)
            Crea_Parametro(Cmd, "@Id_SesionHasta", SqlDbType.Int, Id_SesionHasta)
            Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Caja)
            Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            If Tipo_Diferencia <> "0" Then Crea_Parametro(Cmd, "@Tipo_Diferencia", SqlDbType.VarChar, Tipo_Diferencia)



            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Acta")
            'lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(5).TextAlign = HorizontalAlignment.Center
            lsv.Columns(10).Width = 100
            lsv.Columns(11).Width = 130
            lsv.Columns(12).Width = 130
            lsv.Columns(13).Width = 0
            lsv.Columns(14).Width = 0
            lsv.Columns(15).Width = 0
            lsv.Columns(16).Width = 0
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region

#Region "Tipos de Diferencias llenar lista y Crear Nuevo"

    Public Shared Function fn_TipoDiferencia_LlenarLista(ByRef lsw As cp_Listview, ByVal Tipo As Byte) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDiferencia_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, Tipo)

            'Aqui se Actualiza la lista

            lsw.Actualizar(Cmd, "Id_TipoDiferencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoDiferencia_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_TipoDiferencia_Status", "@Id_TipoDiferencia")

    End Function

    Public Shared Function fn_TipoDiferencia_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_TipoDiferencia_Status", "@Id_TipoDiferencia")

    End Function

    Public Shared Function fn_TipoDiferencia_ObtenValores(ByVal Id_TipoDiferencia As Integer) As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_TipoDiferencia_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_TipoDiferencia", SqlDbType.Int, Id_TipoDiferencia)
        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_TipoDiferencia_ValidarDescripcion(ByVal Descripcion As String, ByVal TipoDiferencia As Byte) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_TipoDiferencia_BuscaDescripcion", CommandType.StoredProcedure, cnn)

        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.TinyInt, TipoDiferencia)
        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoDirefencia_Nuevo(ByVal Descripcion As String, ByVal TipoDiferencia As Byte) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDiferencia_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, TipoDiferencia)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoDirefencia_Actualizar(ByVal TipoDiferencia As Byte, ByVal Descripcion As String, ByVal Id_TipoDiferencia As Integer) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDiferencia_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, TipoDiferencia)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDiferencia", SqlDbType.Int, Id_TipoDiferencia)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Cajas Bancarias"

    Public Shared Function Fn_CajasBancarias_Datos(ByVal Id_Sucursal As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_Sucursal)

        Try
            Dt = EjecutaConsulta(cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function Fn_CajasBancarias_Guardar(ByVal Id_CajaBancaria As Integer, ByVal Numero_Plaza As String, ByVal DigitoSeguro As String, ByVal CR As String, ByVal Tipo_RefDepo As String, ByVal Long_RefDepo As String, ByVal Tipo_Archivo As String, ByVal Clave_ProvArchiv As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_UpdatePro", CommandType.StoredProcedure, Cnn)

        Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(Cmd, "@Numero_Plaza", SqlDbType.VarChar, Numero_Plaza)
        Crea_Parametro(Cmd, "@Digito_Seguro", SqlDbType.VarChar, DigitoSeguro)
        Crea_Parametro(Cmd, "@CR", SqlDbType.VarChar, CR)
        Crea_Parametro(Cmd, "@Tipo_ReferenciasDepo", SqlDbType.VarChar, Tipo_RefDepo)
        Crea_Parametro(Cmd, "@Longitud_ReferenciasDepo", SqlDbType.Int, Long_RefDepo)
        Crea_Parametro(Cmd, "@Tipo_Archivo", SqlDbType.VarChar, Tipo_Archivo)
        Crea_Parametro(Cmd, "@Clave_ProveedorArchivo", SqlDbType.VarChar, Clave_ProvArchiv)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function
#End Region

    Public Shared Function fn_Status(ByVal Id As Integer, ByVal status As Char, ByVal Procedimiento As String, ByVal Campo As String) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)


            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

#Region "FUNCION CUENTA SETTINGS"

    Public Shared Function fn_CuentaSettings() As Integer
        Dim CuentaSettings As Integer = 0
        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) = "SERVDATOS" AndAlso (My.Settings(setting.Name)).ToString.Split(",")(0) = "VACIO" Then
                CuentaSettings += 1
            End If
        Next
        Return CuentaSettings
    End Function

#End Region

#Region "Vales de despensa - Casas Valeras"

    Public Shared Function fn_Guardar_ValesDespensa(ByVal IdCasa As Integer, ByVal NombreCasa As String, ByVal Banda As String, _
                                                    ByVal Importe As Decimal, ByVal Numero As String, ByVal modoCaptura As Byte) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_Vales_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Casa", SqlDbType.Int, IdCasa)
            Crea_Parametro(cmd, "@Nombre_Casa", SqlDbType.VarChar, NombreCasa)
            Crea_Parametro(cmd, "@Banda", SqlDbType.VarChar, Banda)
            Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Importe)
            Crea_Parametro(cmd, "@Numero", SqlDbType.VarChar, Numero)
            Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.TinyInt, modoCaptura)


            EjecutarNonQuery(cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_BuscarExiste_ValesDespensa(ByVal IdCasa As Integer, ByVal Banda As String, ByVal modoCaptura As Byte) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_Vales_Existe", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Casa", SqlDbType.Int, IdCasa)
            Crea_Parametro(cmd, "@Banda", SqlDbType.VarChar, Banda)
            Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.TinyInt, modoCaptura)

            Dim dt_Vales As DataTable = EjecutaConsulta(cmd)

            If dt_Vales IsNot Nothing AndAlso dt_Vales.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_Llenar_listaCasasValeras(ByVal lsv As cp_Listview, ByVal status As String) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_CasasV_GetCombo", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, status)

            lsv.Actualizar(cmd, "Id_Casa")
            lsv.Columns(13).Width = 100
            For C As Integer = 1 To 12
                lsv.Columns(C).Width = 0
            Next

            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_Guardar_CasaValera(ByVal NombreCasa As String, ByVal tieneMicr As Char, ByVal longitudMicr As Byte, _
                                                 ByVal iniImporteMicr As Byte, ByVal finImporteMicr As Byte, ByVal iniNumeroMicr As Byte, _
                                                 ByVal finNumeroMicr As Byte, ByVal TieneCB As Char, ByVal longitudCB As Byte, ByVal iniImporteCB As Byte, _
                                                 ByVal finImporteCB As Byte, ByVal iniNumeroCB As Byte, ByVal finNumeroCB As Byte) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_CasasV_Create", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, NombreCasa)
            Crea_Parametro(cmd, "@Tiene_Micr", SqlDbType.VarChar, tieneMicr)
            Crea_Parametro(cmd, "@Longitud_Micr", SqlDbType.TinyInt, longitudMicr)
            Crea_Parametro(cmd, "@Inicio_ImporteMicr", SqlDbType.TinyInt, iniImporteMicr)
            Crea_Parametro(cmd, "@Fin_ImporteMicr", SqlDbType.TinyInt, finImporteMicr)
            Crea_Parametro(cmd, "@Inicio_NumeroMicr", SqlDbType.TinyInt, iniNumeroMicr)
            Crea_Parametro(cmd, "@Fin_NumeroMicr", SqlDbType.TinyInt, finNumeroMicr)
            Crea_Parametro(cmd, "@Tiene_CB", SqlDbType.VarChar, TieneCB)
            Crea_Parametro(cmd, "@Longitud_CB", SqlDbType.TinyInt, longitudCB)
            Crea_Parametro(cmd, "@Inicio_ImporteCB", SqlDbType.TinyInt, iniImporteCB)
            Crea_Parametro(cmd, "@Fin_ImporteCB", SqlDbType.TinyInt, finImporteCB)
            Crea_Parametro(cmd, "@Inicio_NumeroCB", SqlDbType.TinyInt, iniNumeroCB)
            Crea_Parametro(cmd, "@Fin_NumeroCB", SqlDbType.TinyInt, finNumeroCB)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")

            EjecutarNonQuery(cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_Actualizar_CasaValera(ByVal IdCasa As Integer, ByVal NombreCasa As String, ByVal tieneMicr As Char, ByVal longitudMicr As Byte, _
                                                 ByVal iniImporteMicr As Byte, ByVal finImporteMicr As Byte, ByVal iniNumeroMicr As Byte, _
                                                 ByVal finNumeroMicr As Byte, ByVal TieneCB As Char, ByVal longitudCB As Byte, ByVal iniImporteCB As Byte, _
                                                 ByVal finImporteCB As Byte, ByVal iniNumeroCB As Byte, ByVal finNumeroCB As Byte) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_CasasV_Update", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Casa", SqlDbType.Int, IdCasa)
            Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, NombreCasa)
            Crea_Parametro(cmd, "@Tiene_Micr", SqlDbType.VarChar, tieneMicr)
            Crea_Parametro(cmd, "@Longitud_Micr", SqlDbType.TinyInt, longitudMicr)
            Crea_Parametro(cmd, "@Inicio_ImporteMicr", SqlDbType.TinyInt, iniImporteMicr)
            Crea_Parametro(cmd, "@Fin_ImporteMicr", SqlDbType.TinyInt, finImporteMicr)
            Crea_Parametro(cmd, "@Inicio_NumeroMicr", SqlDbType.TinyInt, iniNumeroMicr)
            Crea_Parametro(cmd, "@Fin_NumeroMicr", SqlDbType.TinyInt, finNumeroMicr)
            Crea_Parametro(cmd, "@Tiene_CB", SqlDbType.VarChar, TieneCB)
            Crea_Parametro(cmd, "@Longitud_CB", SqlDbType.TinyInt, longitudCB)
            Crea_Parametro(cmd, "@Inicio_ImporteCB", SqlDbType.TinyInt, iniImporteCB)
            Crea_Parametro(cmd, "@Fin_ImporteCB", SqlDbType.TinyInt, finImporteCB)
            Crea_Parametro(cmd, "@Inicio_NumeroCB", SqlDbType.TinyInt, iniNumeroCB)
            Crea_Parametro(cmd, "@Fin_NumeroCB", SqlDbType.TinyInt, finNumeroCB)

            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_CambiaStatus_casaValera(ByVal IdCasa As Integer, ByVal Status As Char) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_CasasV_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Casa", SqlDbType.Int, IdCasa)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            EjecutarNonQuery(cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

    Public Shared Function fn_Verifcar_ExisteCasaValera(ByVal nombreCasa As String) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("Pro_CasasV_Existe", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, nombreCasa)

            Dim dt_casas As DataTable = EjecutaConsulta(cmd)
            If dt_casas IsNot Nothing AndAlso dt_casas.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function

#End Region

#Region "Proceso-Enviar Efectivo 17/05/2014"

    Public Shared Function Fn_LoteEfectivo_CreateCR(ByVal lsvEnvases As cp_Listview, ByVal Envases As Integer, ByVal EnvasesSN As Integer, _
                                                      ByVal NumRemision As Long, ByVal Id_CajaBancaria As Integer, ByVal ImporteTotal As Decimal, _
                                                      ByVal Id_Moneda As Integer, ByVal Tipo_Lote As Integer, ByVal Id_CajaBancariaD As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim CantidadEnvases As Integer
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim lc_identity As Integer
        Dim Id_LoteE As Integer
        Dim Elemento As ListViewItem

        CantidadEnvases = Envases + EnvasesSN

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumRemision)
            Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, ImporteTotal)

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsvEnvases.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.Tag.ToString)
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, Tipo_Lote)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancariaD", SqlDbType.Int, Id_CajaBancariaD)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, ImporteTotal)

            Id_LoteE = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, ImporteTotal)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, 0)

            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Row As DataRow In TryCast(frm_LotesEfectivo_Preparar.dgv_Denominaciones.DataSource, DataTable).Rows

                If Row("Importe") > 0 Then

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivoD_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, Id_LoteE)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))
                    Cn_Datos.EjecutarNonQueryT(Cmd)

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Restar")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))

                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function Fn_LoteEfectivo_CreateSR(ByVal Tipo_Lote As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Dt_Deno As DataTable, ByVal Id_CajaBancariaD As Integer, ByVal ImporteTotal As Decimal) As Boolean
        'Se crea un Lote sin uso de Remisiones
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim CantidadEnvases As Integer
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Id_Remision As Integer = 0
        Dim Id_LoteE As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesEfectivo_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, Tipo_Lote)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancariaD", SqlDbType.Int, Id_CajaBancariaD)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, ImporteTotal)

            Id_LoteE = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Row As DataRow In Dt_Deno.Rows

                If Row("Importe") > 0 Then

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivoD_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, Id_LoteE)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))
                    Cn_Datos.EjecutarNonQueryT(Cmd)

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Restar")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function
#End Region

#Region " Consultar  lotes  de efectivo[Enviados y Recibidos]"

    Public Shared Function fn_ReporteLotesEfectivo_ConsultarE(ByVal lsv As cp_Listview, ByVal Caja As Integer, ByVal TipoLote As Integer, _
                                                             ByVal F_Desde As Date, ByVal F_Hasta As Date) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesEfectivo_rptEnviados", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.VarChar, TipoLote)
            Crea_Parametro(Cmd, "@F_Desde", SqlDbType.Date, F_Desde)
            Crea_Parametro(Cmd, "@F_Hasta", SqlDbType.Date, F_Hasta)

            lsv.Actualizar(Cmd, "Id_LoteE")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReporteLotesEfectivo_ConsultarR(ByVal lsv As cp_Listview, ByVal Caja As Integer, ByVal TipoLote As Integer, _
                                                             ByVal F_Desde As Date, ByVal F_Hasta As Date) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesEfectivo_rptRecibidos", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)
            Crea_Parametro(Cmd, "@F_Desde", SqlDbType.Date, F_Desde)
            Crea_Parametro(Cmd, "@F_Hasta", SqlDbType.Date, F_Hasta)

            lsv.Actualizar(Cmd, "Id_LoteE")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Entrada de Saldo"
    Public Shared Function Fn_EntradaSaldo_Guardar(ByVal lsvEnvases As cp_Listview, ByVal Envases As Integer, ByVal EnvasesSN As Integer, _
                                                    ByVal NumRemision As Long, ByVal Id_CajaBancaria As Integer, ByVal ImporteTotal As Decimal, _
                                                    ByVal Id_Moneda As Integer, ByVal Tipo_Lote As Integer, ByVal Id_CajaBancariaD As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim resulset As Integer = 0
        Dim CantidadEnvases As Integer
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim lc_identity As Integer
        Dim Id_LoteE As Integer
        Dim Elemento As ListViewItem

        CantidadEnvases = Envases + EnvasesSN
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumRemision) '
            Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, ImporteTotal)

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd) '

            For Each Elemento In lsvEnvases.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.Tag.ToString)
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivo_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, Tipo_Lote) '----28 Otros->Proceso
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria) '
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases) '
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancariaD", SqlDbType.Int, Id_CajaBancariaD) '
            Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, ImporteTotal) '--

            Id_LoteE = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, ImporteTotal) '-->
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, 0)

            Cn_Datos.EjecutarNonQueryT(Cmd)

            'verificar este dgv-- datos cargados
            For Each Row As DataRow In TryCast(frm_LotesEfectivo_EntradaSaldo.dgv_Denominaciones.DataSource, DataTable).Rows

                If Row("Importe") > 0 Then

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesEfectivoD_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_LoteE", SqlDbType.Int, Id_LoteE) '
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))

                    ''If Not frm_EnviarEfectivo.Origen = frm_EnviarEfectivo.Tipo.Cajeros Then
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))
                    ''End If

                    Cn_Datos.EjecutarNonQueryT(Cmd)

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Saldo_Sumar") ''se suma
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                    Cn_Datos.Crea_Parametro(Cmd, "@ID_Denominacion", SqlDbType.Int, Row("Id_Denominacion"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Money, Row("Cantidad"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadA", SqlDbType.Money, Row("Cantidad1"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadB", SqlDbType.Money, Row("Cantidad2"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadC", SqlDbType.Money, Row("Cantidad3"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadD", SqlDbType.Money, Row("Cantidad4"))
                    Cn_Datos.Crea_Parametro(Cmd, "@CantidadE", SqlDbType.Money, Row("Cantidad5"))

                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function
#End Region

#Region "Recuento en Sitio"

    Public Shared Function fn_RecuentoCasetsLlenaLista(ByVal lsv As cp_Listview, ByVal Fecha As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cli_Cambio_Casete_Get2", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
            lsv.Actualizar(Cmd, "Id_Remision")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecuentoClientesCasetLlenaLista(ByVal lsv As cp_Listview, ByVal N_Caset As Long) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cli_Recuento_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@N_Caset", SqlDbType.BigInt, N_Caset)
            lsv.Actualizar(Cmd, "Id_Recuento")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecuentoEnvasesClienteLlenaLista(ByVal lsv As cp_Listview, ByVal Id_Recuento As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cli_RecuentoEnvases_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Recuento", SqlDbType.BigInt, Id_Recuento)
            lsv.Actualizar(Cmd, "Id_TipoE")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecuentoDesgloseClienteLlenaLista(ByVal lsv As cp_Listview, ByVal Id_Recuento As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cli_RecuentoD_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Recuento", SqlDbType.BigInt, Id_Recuento)
            lsv.Actualizar(Cmd, "")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReporteRecuentoDesglosexCliente(ByVal Tbl As DataTable, ByVal N_Caset As Long) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cli_RecuentoD_GetbyNcaset", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@N_caset", SqlDbType.BigInt, N_Caset)
        Try
            Tbl.Rows.Clear()
            cmd.Connection.Open()
            Tbl.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Efectivo X Cliente"

    Public Shared Function fn_EfectivoXCliente_Llenarlista(ByVal Lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_cliente As Integer, ByVal Presentacion As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Pro_FichasEfectivo_Get2", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_cliente)
        Crea_Parametro(Cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)
        Try
            Lsv.Actualizar(Cmd, "")
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "Configurar Plantilla Impresion"
    Public Shared Function fn_ConsultarPlantilla() As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Usr_ModulosP_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ModificarPlantilla(ByVal Clave_Dotacion As String, ByVal Clave_Efectivo As String, ByVal Clave_Resguardo As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Usr_ModulosP_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Crea_Parametro(Cmd, "@Plantilla_Dotacion", SqlDbType.VarChar, Clave_Dotacion)
        Crea_Parametro(Cmd, "@Plantilla_Efectivo", SqlDbType.VarChar, Clave_Efectivo)
        Crea_Parametro(Cmd, "@Plantilla_Resguardo", SqlDbType.VarChar, Clave_Resguardo)
        Try
            EjecutaConsulta(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function
#End Region


#Region "ArchivoBanorte"
    Public Shared Function fn_Banorte_TipoSolicitud_Obtener(ByRef ds As ds_Banorte.TipoSolicitudDataTable) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("spGet_Banorte_TipoSolicitud", CommandType.StoredProcedure, cnn)
            cmd.Connection.Open()
            ds.Load(cmd.ExecuteReader())
            cmd.Connection.Close()
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
        Return True
    End Function


    Public Shared Function fn_Banorte_Divisa_Obtener(ByRef ds As ds_Banorte.DivisaDataTable) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("spRead_Banorte_Divisa", CommandType.StoredProcedure, cnn)
            cmd.Connection.Open()
            ds.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Banorte_TipoDivisa_Obtener(ByRef ds As ds_Banorte.DivisaTipoDataTable) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("spRead_Banorte_TipoDivisa", CommandType.StoredProcedure, cnn)
            Dim dt = EjecutaConsulta(cmd)
            cmd.Connection.Open()
            ds.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Banorte_TipoDotacion_Obtener(ByVal ds As ds_Banorte.TipoDotacionDataTable)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("spGet_Banorte_TipoDotacion", CommandType.StoredProcedure, cnn)
            cmd.Connection.Open()
            ds.Load(cmd.ExecuteReader())
            cmd.Connection.Close()
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function Fn_DenominacionTotal_Obtener(ByRef ds As ds_Banorte.DenominacionesDataTable) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_Denominaciones_PresentacionGetTotal", CommandType.StoredProcedure, cnn)
            cmd.Connection.Open()
            ds.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function Fn_Dotaciones_Gurdar(ByVal Archivo As List(Of Banorte.OdesArchivo)) As Boolean
        Try
            Dim OdesConfirma As Banorte.Confirmacion = Nothing
            OdesConfirma = New Banorte.Confirmacion(Archivo)
            OdesConfirma.CrearXmlElement()
            If Not OdesConfirma.Enviar() Then
                Throw New ApplicationException("Ocurrió un error al intentar confirmar servicios")
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

#End Region

#Region "Ordenes de Servicio"

    Public Shared Function fn_OrdenServicio_Guardar(ByVal lsv As cp_Listview, ByVal Tipo_Salida As String, ByVal Archivo As List(Of Banorte.OdesArchivo), ByRef _Servicio As BaseOrdenServicio, ByVal Id_CajaBancaria As Integer, ByVal Id_Dotacion As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand = Nothing
        Dim j As Integer = 0
        Dim IdDotaciones(j) As Integer
        Dim yyyy As Integer = 0
        Dim MM As Integer = 0
        Dim d As Integer = 0
        Dim Tipo_Odes As Integer = 0


        Try

            Dim OrdenArchivo As System.Collections.Generic.IEnumerable(Of String)

            If TypeOf _Servicio Is OrdenConcentracionesDivisas Then

                OrdenArchivo = (From item As ListViewItem In lsv.CheckedItems _
                                Where item.Checked = True _
                                Select item.SubItems(6).Text).Distinct()



            ElseIf TypeOf _Servicio Is OrdenDotacionesCajeros Then

                OrdenArchivo = (From item As ListViewItem In lsv.CheckedItems _
                                Where item.Checked = True _
                                Select item.SubItems(9).Text).Distinct()

            ElseIf TypeOf _Servicio Is OrdenDotacionesClientes Then
                OrdenArchivo = (From item As ListViewItem In lsv.CheckedItems _
                               Where item.Checked = True _
                               Select item.SubItems(7).Text).Distinct()
            ElseIf TypeOf _Servicio Is OrdenDotacionesDivisas Then
                OrdenArchivo = (From item As ListViewItem In lsv.CheckedItems _
                                Where item.Checked = True _
                                Select item.SubItems(8).Text).Distinct()
            End If


            For Each item In OrdenArchivo


                cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_OrdenArchivo_Valida")
                Crea_Parametro(cmd, "@NombreArchivo", SqlDbType.VarChar, item.ToString())

                If EjecutaConsultaT(cmd).Rows.Count = 0 Then
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_OrdenArchivo_Create")
                    Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, item.ToString())
                    Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
                    EjecutarNonQueryT(cmd)
                End If
            Next



            For Each Dotacion As ListViewItem In lsv.CheckedItems

                cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_OrdenArchivo_Get")

                If TypeOf _Servicio Is OrdenConcentracionesDivisas Then
                    Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, Dotacion.SubItems(6).Text)
                ElseIf TypeOf _Servicio Is OrdenDotacionesClientes Then
                    Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, Dotacion.SubItems(7).Text)
                ElseIf TypeOf _Servicio Is OrdenDotacionesCajeros Then
                    Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, Dotacion.SubItems(9).Text)
                ElseIf TypeOf _Servicio Is OrdenDotacionesDivisas Then
                    Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, Dotacion.SubItems(8).Text)
                End If

                Dim IdOrdenArchivo As Integer = EjecutarScalarT(cmd)

                If Tipo_Salida = 1 Then

                    cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Banorte_Clientes_Read")
                    Crea_Parametro(cmd, "@Numero_Cuenta", SqlDbType.VarChar, Dotacion.SubItems(2).Text)

                    Dim Cuentas As DataTable = EjecutaConsultaT(cmd)

                    If Cuentas.Rows.Count = 0 Then
                        cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Banorte_Clientes_Create1")
                        Crea_Parametro(cmd, "@Numero_Cuenta", SqlDbType.VarChar, Dotacion.SubItems(2).Text)
                        EjecutarNonQueryT(cmd)
                    End If

                End If


                cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_OrdenServicio_Create")
                Crea_Parametro(cmd, "@Odes", SqlDbType.VarChar, Dotacion.Text)
                Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
                Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                If Tipo_Salida = 1 Then

                    Tipo_Odes = 3 ' se el valor se obtiene desde BD tabla la Banorte_tipoOdes

                    yyyy = Dotacion.SubItems(5).Text.Substring(4, 4)
                    MM = Dotacion.SubItems(5).Text.Substring(2, 2)
                    d = Dotacion.SubItems(5).Text.Substring(0, 2)


                    Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(1).Text)
                    Crea_Parametro(cmd, "@Numero_Cuenta", SqlDbType.VarChar, Dotacion.SubItems(2).Text)
                    Crea_Parametro(cmd, "@Tipo_Solicitud", SqlDbType.Int, Dotacion.SubItems(6).Text)
                    Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Dotacion.SubItems(4).Text)
                    Crea_Parametro(cmd, "@Fecha_Odes", SqlDbType.DateTime, New DateTime(yyyy, MM, d))
                    Crea_Parametro(cmd, "@Numero_Odes", SqlDbType.Int, Dotacion.SubItems(8).Text)
                    Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, IdOrdenArchivo)
                    Crea_Parametro(cmd, "@CR_Cliente", SqlDbType.Int, Dotacion.Text.Substring(4, 4))
                    Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
                    Crea_Parametro(cmd, "@Tipo_Odes", SqlDbType.VarChar, Tipo_Odes)
                    Crea_Parametro(cmd, "@Referencia", SqlDbType.VarChar, Dotacion.SubItems(9).Text)
                    Crea_Parametro(cmd, "@CR", SqlDbType.VarChar, Dotacion.Text.Substring(0, 4))

                ElseIf Tipo_Salida = 2 Then
                    Tipo_Odes = 1
                    yyyy = Dotacion.SubItems(7).Text.Substring(4, 4)
                    MM = Dotacion.SubItems(7).Text.Substring(2, 2)
                    d = Dotacion.SubItems(7).Text.Substring(0, 2)

                    Crea_Parametro(cmd, "@Id_Cr", SqlDbType.Int, Dotacion.SubItems(1).Text)
                    Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(2).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorProceso", SqlDbType.Int, Dotacion.SubItems(4).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorTraslado", SqlDbType.Int, Dotacion.SubItems(5).Text)
                    Crea_Parametro(cmd, "@Tipo_Solicitud", SqlDbType.Int, Dotacion.SubItems(6).Text)
                    Crea_Parametro(cmd, "@Fecha_Odes", SqlDbType.DateTime, New DateTime(yyyy, MM, d))
                    Crea_Parametro(cmd, "@Numero_Odes", SqlDbType.Int, Dotacion.SubItems(9).Text)
                    Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, IdOrdenArchivo)
                    Crea_Parametro(cmd, "@CR_Cliente", SqlDbType.Int, Dotacion.Text.Substring(4, 4))
                    Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
                    Crea_Parametro(cmd, "@Tipo_Odes", SqlDbType.VarChar, Tipo_Odes)
                    Crea_Parametro(cmd, "@CR", SqlDbType.VarChar, Dotacion.Text.Substring(0, 4))
                ElseIf Tipo_Salida = 6 Then
                    Tipo_Odes = 2

                    yyyy = Dotacion.SubItems(5).Text.Substring(4, 4)
                    MM = Dotacion.SubItems(5).Text.Substring(2, 2)
                    d = Dotacion.SubItems(5).Text.Substring(0, 2)

                    Crea_Parametro(cmd, "@Id_Cr", SqlDbType.Int, Dotacion.SubItems(1).Text)
                    Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(2).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorProceso", SqlDbType.Int, Dotacion.SubItems(3).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorTraslado", SqlDbType.Int, Dotacion.SubItems(4).Text)
                    Crea_Parametro(cmd, "@Fecha_Odes", SqlDbType.DateTime, New DateTime(yyyy, MM, d))
                    Crea_Parametro(cmd, "@Numero_Odes", SqlDbType.Int, Dotacion.SubItems(7).Text)
                    Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, IdOrdenArchivo)
                    Crea_Parametro(cmd, "@CR_Cliente", SqlDbType.Int, Dotacion.Text.Substring(0, 4))
                    Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
                    Crea_Parametro(cmd, "@Tipo_Odes", SqlDbType.VarChar, Tipo_Odes)
                    Crea_Parametro(cmd, "@Tipo_Solicitud", SqlDbType.Int, Dotacion.SubItems(9).Text)
                    Crea_Parametro(cmd, "@CR", SqlDbType.VarChar, Dotacion.Text.Substring(4, 4))

                ElseIf Tipo_Salida = 7 Then
                    Tipo_Odes = 4
                    yyyy = Dotacion.SubItems(6).Text.Substring(4, 4)
                    MM = Dotacion.SubItems(6).Text.Substring(2, 2)
                    d = Dotacion.SubItems(6).Text.Substring(0, 2)


                    Crea_Parametro(cmd, "@Id_Cr", SqlDbType.Int, Dotacion.SubItems(1).Text)
                    Crea_Parametro(cmd, "@Id_Proveedor", SqlDbType.Int, Dotacion.SubItems(4).Text)
                    Crea_Parametro(cmd, "@Id_Nemonico", SqlDbType.VarChar, Dotacion.SubItems(5).Text)
                    Crea_Parametro(cmd, "@Fecha_Odes", SqlDbType.DateTime, New DateTime(yyyy, MM, d))
                    Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
                    Crea_Parametro(cmd, "@Tipo_Solicitud", SqlDbType.Int, Dotacion.SubItems(8).Text)
                    Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, IdOrdenArchivo)
                    Crea_Parametro(cmd, "@Numero_Odes", SqlDbType.Int, Dotacion.SubItems(10).Text)
                    Crea_Parametro(cmd, "@Tipo_DotacionAtms", SqlDbType.VarChar, Dotacion.SubItems(7).Text)
                    Crea_Parametro(cmd, "@Tipo_Odes", SqlDbType.VarChar, Tipo_Odes)
                    Crea_Parametro(cmd, "@CR", SqlDbType.VarChar, 0)

                ElseIf Tipo_Salida = 8 Then
                    Tipo_Odes = 6

                    yyyy = Dotacion.SubItems(5).Text.Substring(4, 4)
                    MM = Dotacion.SubItems(5).Text.Substring(2, 2)
                    d = Dotacion.SubItems(5).Text.Substring(0, 2)

                    Crea_Parametro(cmd, "@Id_Cr", SqlDbType.Int, Dotacion.SubItems(1).Text)
                    Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(2).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorProceso", SqlDbType.Int, Dotacion.SubItems(3).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorTraslado", SqlDbType.Int, Dotacion.SubItems(4).Text)
                    Crea_Parametro(cmd, "@Fecha_Odes", SqlDbType.DateTime, New DateTime(yyyy, MM, d))
                    Crea_Parametro(cmd, "@Numero_Odes", SqlDbType.Int, Dotacion.SubItems(7).Text)
                    Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, IdOrdenArchivo)
                    Crea_Parametro(cmd, "@CR_Cliente", SqlDbType.Int, Dotacion.Text.Substring(0, 4))
                    Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
                    Crea_Parametro(cmd, "@Tipo_Odes", SqlDbType.VarChar, Tipo_Odes)
                    Crea_Parametro(cmd, "@Tipo_Solicitud", SqlDbType.Int, Dotacion.SubItems(9).Text)
                    Crea_Parametro(cmd, "@CR", SqlDbType.VarChar, Dotacion.Text.Substring(4, 4))



                ElseIf Tipo_Salida = 9 Then
                    Tipo_Odes = 5

                    yyyy = Dotacion.SubItems(5).Text.Substring(4, 4)
                    MM = Dotacion.SubItems(5).Text.Substring(2, 2)
                    d = Dotacion.SubItems(5).Text.Substring(0, 2)

                    Crea_Parametro(cmd, "@Id_Cr", SqlDbType.Int, Dotacion.SubItems(1).Text)
                    Crea_Parametro(cmd, "@Id_Movimiento", SqlDbType.Int, Dotacion.SubItems(2).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorProceso", SqlDbType.Int, Dotacion.SubItems(3).Text)
                    Crea_Parametro(cmd, "@Id_ProveedorTraslado", SqlDbType.Int, Dotacion.SubItems(4).Text)
                    Crea_Parametro(cmd, "@Fecha_Odes", SqlDbType.DateTime, New DateTime(yyyy, MM, d))
                    Crea_Parametro(cmd, "@Numero_Odes", SqlDbType.Int, Dotacion.SubItems(7).Text)
                    Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, IdOrdenArchivo)
                    Crea_Parametro(cmd, "@CR_Cliente", SqlDbType.Int, Dotacion.Text.Substring(0, 4))
                    Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
                    Crea_Parametro(cmd, "@Tipo_Odes", SqlDbType.VarChar, Tipo_Odes)
                    Crea_Parametro(cmd, "@Tipo_Solicitud", SqlDbType.Int, Dotacion.SubItems(9).Text)
                    Crea_Parametro(cmd, "@CR", SqlDbType.VarChar, Dotacion.Text.Substring(4, 4))

                End If


                Dim Id_OrdenServicio As Integer = EjecutarScalarT(cmd)

                IdDotaciones(j) = Id_OrdenServicio
                j += 1
                ReDim Preserve IdDotaciones(j)

                Dim DotacionesD = (From DD As ds_Banorte.DotacionesDRow In _Servicio.dsBanorte.DotacionesD _
                                      Where DD.Id_Dotacion = Dotacion.Tag _
                                      Select DD)

                For Each Denomincion In DotacionesD
                    cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_OdesDivisa_Create")
                    Crea_Parametro(cmd, "@Id_OdesD", SqlDbType.Int, Id_OrdenServicio)
                    Crea_Parametro(cmd, "@Id_Divisa", SqlDbType.Int, CInt(Denomincion.ID_Divisa))
                    Crea_Parametro(cmd, "@Id_TipoDivisa", SqlDbType.Money, CInt(Denomincion.ID_TipoDivisa))
                    Crea_Parametro(cmd, "@Denominacion", SqlDbType.Money, Denomincion.Denominacion)
                    Crea_Parametro(cmd, "@Cantidad", SqlDbType.Money, Denomincion.Cantidad)
                    Crea_Parametro(cmd, "@Importe", SqlDbType.Money, Denomincion.Importe)
                    EjecutarNonQueryT(cmd)
                Next
            Next

            Tr.Commit()
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Private Shared Function fn_OdesServicios_Cancelar(ByVal IdDotaciones As Integer()) As Boolean
        Dim cmd As SqlCommand = Nothing
        Dim cnn As SqlConnection = Nothing
        Try
            cnn = Crea_ConexionSTD()
            For Each IdDotacion As Integer In IdDotaciones
                cmd = Crea_Comando("Cat_OdesServicioCancela_Status", CommandType.StoredProcedure, cnn)
                Cn_Datos.Crea_Parametro(cmd, "@Id_Odes", SqlDbType.Int, IdDotacion)
                Cn_Datos.Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, "No se pudieron confirmar ordenes con el banco")
                EjecutarNonQuery(cmd)
            Next
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_OdesServicio_Get(ByVal Id_Dotacion As Integer, ByVal Id_CajaBancaria As Integer, ByVal Fecha As Date, ByRef lsv As cp_Listview, ByVal Id_Archivo As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OrdenServicio_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Crea_Parametro(cmd, "@Fecha_Registro", SqlDbType.DateTime, Fecha)
            Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)
            lsv.Actualizar(cmd, "Id_Odes")
        Catch ex As Exception
            Return False
            Return Nothing
        End Try
        Return True
    End Function

    Public Shared Function fn_OdesDivisa_Get(ByVal Id_Odes As Integer, ByRef lsv As cp_Listview)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OdesDivisa_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Odes", SqlDbType.Int, Id_Odes)
            lsv.Actualizar(cmd, "")
        Catch ex As Exception
            Return False
            TrataEx(ex)
        End Try
        Return Nothing
    End Function

    Public Shared Function fn_OdesDivisa_Get(ByVal Id_Odes As Integer)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OdesDivisa_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Odes", SqlDbType.Int, Id_Odes)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            Return Nothing
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OdesDivisa_GetSuma(ByVal Id_Odes As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OdesDivisa_GetSuma", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Odes", SqlDbType.Int, Id_Odes)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            Return Nothing
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OrdenesServicio_Valida(ByVal Odes As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OrdenServicio_Valida", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Odes", SqlDbType.VarChar, Odes)
            Return EjecutaConsulta(cmd).Rows.Count
        Catch ex As Exception
            Return False
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OrdenesArchivo_GetArchivo(ByVal Fecha As DateTime, ByVal TipoDotacion As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OrdenArchivo_Get1", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.DateTime, Fecha)
            Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, TipoDotacion)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            Return Nothing
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OdesDivisa_GetCaratula(ByVal Id_Dotacion As Integer, ByVal Id_Archivo As Integer, ByVal Fecha As DateTime) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OdesDivisa_GetCaratula", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
            Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.DateTime, Fecha)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            Return Nothing
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OdesDivisa_GetTipoDivisaTotal(ByVal Id_Dotacion As Integer, ByVal Id_Archivo As Integer, ByVal Fecha As DateTime) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OdesDivisa_GetTipoDivisaTotal", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
            Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.DateTime, Fecha)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            Return Nothing
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OdesDivisa_GetDivisaTotal(ByVal Id_Dotacion As Integer, ByVal Id_Archivo As Integer, ByVal Fecha As DateTime) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OdesDivisa_GetDivisaTotal", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Id_Dotacion)
            Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.DateTime, Fecha)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            Return Nothing
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OrdenServicio_GetCaratula(ByVal Id_Archivo As Integer, ByVal Fecha As DateTime, ByVal Tipo_Dotacion As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OrdenServicio_GetCaratula", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Archivo", SqlDbType.Int, Id_Archivo)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.DateTime, Fecha) ''Cat_OrdenServicio_GetCaratula
            Crea_Parametro(cmd, "@Tipo_Dotacion", SqlDbType.Int, Tipo_Dotacion)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            Return Nothing
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_OdesDivisa_Importe(ByVal Id_Odes As Integer) As Decimal
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Cat_OdesDivisa_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Odes", SqlDbType.Int, Id_Odes)
            Dim dtDivisa As DataTable = EjecutaConsulta(cmd)
            Return (From dt As DataRow In dtDivisa.Rows).Sum(Function(dr As DataRow) CDec(dr("Importe")))
        Catch ex As Exception
            Return -1.0
            TrataEx(ex)
        End Try
        Return Nothing
    End Function

    Public Shared Function fn_BanorteClientes_Get(ByVal Status As String, ByVal lsv As cp_Listview) As Decimal
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Banorte_Cliente_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            lsv.Actualizar(cmd, "Id_Bc")
        Catch ex As Exception
            Return -1.0
            TrataEx(ex)
        End Try
        Return Nothing
    End Function

    Public Shared Function fn_BanorteClientes_Create(ByVal Numero_Cuenta As String, ByVal Cliente As String, ByVal CajaBancaria As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Banorte_Clientes_Create", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Numero_Cuenta", SqlDbType.VarChar, Numero_Cuenta)
            Crea_Parametro(cmd, "@Nombre_Comercial", SqlDbType.VarChar, Cliente)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.VarChar, CajaBancaria)
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            Return False
            TrataEx(ex)
        End Try
        Return True
    End Function

    Public Shared Function fn_BanorteClientes_Baja(ByVal Id_CB As Integer, ByVal Status As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Banorte_Clientes_Update", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Bc", SqlDbType.Int, Id_CB)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Dim valor = EjecutarScalar(cmd)
        Catch ex As Exception
            Return False
            TrataEx(ex)
        End Try
        Return True
    End Function

    Public Shared Function fn_BanorteClientes_Update(ByVal Id_CajaBancaria As Integer, ByVal Cliente As String, ByVal Id_Bc As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Banorte_Clientes_Update1", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Bc", SqlDbType.Int, Id_Bc)
            Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.VarChar, Id_CajaBancaria)
            Crea_Parametro(cmd, "@NombreComercial", SqlDbType.VarChar, Cliente)
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            Return False
            TrataEx(ex)
        End Try
        Return True
    End Function

#End Region

#Region "REMISION DIGITAL"
    Public Shared Function fn_VerificarNr(ByVal Clave_cliente As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        'Dim Cmd As SqlCommand = Crea_Comando("Nremision_P1", CommandType.StoredProcedure, Cnn)
        'Crea_Parametro(Cmd, "@ClaveC", SqlDbType.VarChar, Clave_cliente)
        Dim Cmd As SqlCommand = Crea_Comando("ComprobarNumeroRemision", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Clave_cliente)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_NumeroR(ByVal Clave_cliente As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        'Dim Cmd As SqlCommand = Crea_Comando("Nremision", CommandType.StoredProcedure, Cnn)
        'Crea_Parametro(Cmd, "@ClaveC", SqlDbType.VarChar, Clave_cliente)
        Dim Cmd As SqlCommand = Crea_Comando("NumeroRemisionNew", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Clave_cliente)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function
    Public Shared Function fn_RegresarSta(ByVal Clave_mat As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Des_Remision_P1", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Libre", SqlDbType.Int, Clave_mat)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_Des_Remision(ByVal Clave_cliente As String, ByVal numero As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        'Dim Cmd As SqlCommand = Crea_Comando("Insert_Rtemporal", CommandType.StoredProcedure, Cnn)
        Dim Cmd As SqlCommand = Crea_Comando("NumeroRemisionTmp", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_C", SqlDbType.VarChar, Clave_cliente)
        Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, numero)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_deleteT(ByVal Clave As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Eliminar_Rtemporal", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@id", SqlDbType.Int, Clave)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_Cliente_Padre(ByVal Id_Cliente As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Cliente_Padre_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AsignarPreparacion(ByVal lsv As cp_Listview, ByVal Caja As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Dotaciones_AsigarPreparacion", CommandType.StoredProcedure, Cnn)
            If Caja <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "VA")
            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Dotacion")
            'EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_AsignarPreparacionV(ByVal lsv As cp_Listview, ByVal Id_Remison As String, ByVal Id_Empleado As Integer, ByVal Id_Asigna As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Preparacion_Set", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.VarChar, Id_Remison)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Asigna", SqlDbType.Int, Id_Asigna)
            'Aqui se Actualiza la lista
            EjecutarNonQuery(Cmd)
            'lsv.Actualizar(Cmd, "Id_Dotacion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "ENVASES"
    Public Shared Function fn_RegresoaBoveda_LlenarListaEnvases(ByRef Lsv As cp_Listview) As DataTable
        Dim dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetRecibidosEnvases", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, 0)
        Crea_Parametro(cmd, "@Id_Cajero", SqlDbType.Int, 0)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "RC")
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

        Try
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Envases_Get(ByVal lsv As cp_Listview, ByVal Id_Servicio As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get7", CommandType.StoredProcedure, Crea_ConexionSTD)
            'Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get7New", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Envases_Get2(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Try
            'Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get3", CommandType.StoredProcedure, Crea_ConexionSTD)
            Dim cmd As SqlCommand = Crea_Comando("  ", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_ObtenerEnvases(ByVal Lsv As cp_Listview, ByVal Id_CajaBancaria As Integer) As DataTable
        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetAsignarEnvases", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "RC")
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")

        Try
            Dt = EjecutaConsulta(cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_EnvasesCancelar(ByVal lsv As cp_Listview, ByVal Id_Servicio As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get7", CommandType.StoredProcedure, Crea_ConexionSTD)
            'Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get7New", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarAsignacion_LlenarListaEnvases(ByVal Lsv As cp_Listview, ByVal Id_Cajero As Integer) As DataTable
        Dim dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetAsignadosEnvases", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Cajero", SqlDbType.Int, Id_Cajero)

        Try
            Dt = EjecutaConsulta(cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Get_Envases2(ByVal Id_Remision As String, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get3", CommandType.StoredProcedure, Crea_ConexionSTD)
            ' Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get3New", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.VarChar, Id_Remision)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function


    Public Shared Function fn_EnviaBovedaLlenalistaEnvases(ByVal lsv As cp_Listview) As DataTable

        Dim dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Dotaciones_GetEnviarBoveda1y3Envases", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, 0)

        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "VA")

        Try
            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_GenerarReporte(ByVal remsion As String) As DataTable

        Dim Dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("ConsultarReporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Remision", SqlDbType.VarChar, remsion)

        Try
            Dt = EjecutaConsulta(cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

#End Region


    ''Ver Remision en PDF
    Public Shared Function obtenerNotificacion(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Buscar_RemisionDigital", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerRemisionWebImporte(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("NotificacionImportesWebTraslado", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerEnvases(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("NotificacionEnvasesTraslado", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerImporteMoneda(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("NotificacionMonedaTraslado", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerEnvases(ByVal dtEnvases As DataTable) As String
        Dim envases As String = String.Empty

        For Each envase As DataRow In dtEnvases.Rows
            envases += "[" & envase("Numero").ToString() & "]"
        Next

        Return envases
    End Function
    Public Shared Function obtenerEnvaseMoneda(ByVal dtEnvases As DataTable) As Integer
        Return (From envase In dtEnvases.AsEnumerable() Where CStr(envase("Tipo Envase")) = "BILLETE" Select envase).Count()
    End Function

    Public Shared Function obtenerEnvaseMixto(ByVal dtEnvases As DataTable) As Integer
        Return (From envase In dtEnvases.AsEnumerable() Where CStr(envase("Tipo Envase")) = "MIXTO" Select envase).Count()
    End Function

    Public Shared Function obtenerEnvaseMorralla(ByVal dtEnvases As DataTable) As Integer
        Return (From envase In dtEnvases.AsEnumerable() Where CStr(envase("Tipo Envase")) = "MORRALLA" Select envase).Count()
    End Function
    Public Shared Function obtenerMonenadaNacional(ByVal datos As DataTable) As Decimal
        Dim monedaNacional As Decimal = 0

        For Each moneda As DataRow In datos.Rows
            If moneda("Moneda").ToString() = "PESOS" Then monedaNacional += Convert.ToDecimal(moneda("Efectivo"))
        Next
        Return monedaNacional
    End Function

    Public Shared Function obtenerMonedaExtranjera(ByVal datos As DataTable) As Decimal
        Dim monedaExt As Decimal = 0

        For Each moneda As DataRow In datos.Rows
            If moneda("Moneda").ToString() <> "PESOS" Then monedaExt += Convert.ToDecimal(moneda("Efectivo")) * Convert.ToDecimal(moneda("Tipo Cambio"))
        Next

        Return monedaExt
    End Function

    Public Shared Function obtenerDocumentos(ByVal datos As DataTable) As Decimal
        Dim doc As Decimal = 0

        For Each moneda As DataRow In datos.Rows
            doc += Convert.ToDecimal(moneda("Documentos"))
        Next

        Return doc
    End Function

    'RemisionDIgital pdf'
    Public Shared Function fn_cmbServicio(ByVal Id_Cliente As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesServiciosCombo_GetMoralla", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@IdCliente", SqlDbType.Int, Id_Cliente)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    'ClientesInternosAExternos
    Public Shared Function fn_ClientesInternosAExternos_LlenarLista(ByVal Lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Get_ClientesInternosAExternos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
    Public Shared Function fn_ClientesInternosAExternos_Guardar(ByVal Id_Cliente As Integer) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Guardar_ClientesInternosAExternos", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function
    Public Shared Function fn_ClientesInternosAExternos_Eliminar(ByVal Id_Cliente As Integer) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Eliminar_ClientesInternosAExternos", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function
    Public Shared Function BuscarRemisionxEnvase(ByVal NumeroRemision As String) As String
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Buscar_RemisionxEnvase", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Envase", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            If Dt.Rows.Count > 0 Then
                Return Dt.Rows(0)(0).ToString
            End If

        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
        Return ""
    End Function
#Region "Empleados que Cancelan Despachos"
    Public Shared Function fn_Guardar_DespachosCancela(ByVal Id_Empleado As Integer) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Guardar_DespachosCancela", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function


    Public Shared Function fn_Lista_DespachosCancela(ByVal Lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Lista_DespachosCancela", CommandType.StoredProcedure, Crea_ConexionSTD)
            Lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Modificar_DespachosCancela(ByVal Id_Empleado As Integer, ByVal Status As String) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Modificar_DespachosCancela", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try

    End Function
#End Region

    'Monitoreo de remisiones 


    Public Shared Function fn_AsignarProcesoLlenalista() As Integer
        Dim tbl As New DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetAsignarProcesoM", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, "P")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

            tbl = EjecutaConsulta(Cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function


    Public Shared Function fn_RecibirLotesBoveda_Monitoreo() As Integer
        Dim tbl As New DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRecProceso_GetM", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Destino", SqlDbType.VarChar, "P")

            tbl = EjecutaConsulta(Cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function

    Public Shared Function fn_AsignarServicios_Monitoreo() As Integer
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Servicios_GetAsignarM", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "RC")
        Crea_Parametro(cmd, "@Dpto_Procesa", SqlDbType.VarChar, "P")
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, SesionId)

        Try
            tbl = EjecutaConsulta(cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function

    Public Shared Function fn_RecibirServicio_Monitoreo() As Integer
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Asigna_GetM", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, SesionId)
        Try
            tbl = EjecutaConsulta(cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function
    Public Shared Function fn_RecibirServicioV_Monitoreo() As Integer
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_AsigacionesM", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, SesionId)
        Try
            tbl = EjecutaConsulta(cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function
    Public Shared Function fn_RecibirServicioI_Monitoreo() As Integer
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_IniciadoM", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, SesionId)
        Try
            tbl = EjecutaConsulta(cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function
    Public Shared Function fn_RecibirServicioVE_Monitoreo() As Integer
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_VerificadoM", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, SesionId)
        Try
            tbl = EjecutaConsulta(cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function
    Public Shared Function fn_RecibirServicioCO_Monitoreo() As Integer
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_ContabilizadoM", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, SesionId)
        Try
            tbl = EjecutaConsulta(cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function
    Public Shared Function fn_ServiciosTotal_Monitoreo() As Integer
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_ServiciosT", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, SesionId)
        Try
            tbl = EjecutaConsulta(cmd)
            If tbl IsNot Nothing Then
                If tbl.Rows.Count > 0 Then
                    Return CInt(tbl.Rows(0)(0).ToString)
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            TrataEx(ex, False)
            Return 0
        End Try
    End Function
    Public Shared Function fn_MonitoreoTiempo() As DataTable
        Dim tbl As New DataTable
        Dim cmd As SqlCommand = Crea_Comando("Bo_Boveda_MonitoreoT", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Session", SqlDbType.Int, SesionId)
        Try
            tbl = EjecutaConsulta(cmd)

            If tbl.Rows.Count > 0 Then
                    Return tbl
                End If



        Catch ex As Exception
            TrataEx(ex, False)

        End Try
        Return tbl
    End Function

    Public Shared Function fn_AlertasGeneradas_ObtenerMails(ByVal Clave_AlertaTipo As String) As DataTable
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_AlertasDestinos_GetMail", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            'TrataEx(ex, SucursalId, UsuarioID) 
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_Movimiento_Recalcular(ByVal Tr As SqlTransaction, ByVal Id_Servicio As Integer)
        Dim cmd As SqlCommand = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_Movimientos_Recalcular")
        Crea_Parametro(cmd, "@Id_Servicio", SqlDbType.Int, Id_Servicio)
        Crea_Parametro(cmd, "@Id_Usuario", SqlDbType.Int, UsuarioId)
        Try
            If EjecutarNonQueryT(cmd) > 0 Then
                Return True
            Else
                Tr.Rollback()
                Return False
            End If
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

#Region "Consulta de importes por recolecciones"

    Public Shared Function fn_ImportesporRecolecciones_llenarlista(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_ActasDiff_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)

        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            lsv.Actualizar(Tbl, "Id_Punto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region
#Region "Api Banregio"
    Public Shared Function fn_RemisionesApi(ByVal Id_CajaBancaria As Integer, ByVal Id_Sesion As Integer, ByVal Id_GrupoDepo As Integer, ByVal Corte As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("SProcedure_RemisionesCheckBanregioApi", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Sesion", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_GrupoDepo", SqlDbType.Int, Id_GrupoDepo)
        Crea_Parametro(cmd, "@Corte", SqlDbType.Int, Corte)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Pro_DepositosApi(ByVal Id_Sesion As Integer, Id_Servicios As String) As DataTable

        Dim cmd As SqlCommand = Crea_Comando("SProcedure_DepositosBanregioApi", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Servicios", SqlDbType.VarChar, Id_Servicios)

        Dim Tbl As DataTable
        Try
            Tbl = EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return New DataTable
        End Try
        Return Tbl
    End Function
    Public Shared Function fn_Pro_RemisionesSeleccionadas(ByVal Id_Sesion As Integer, Id_Servicios As String) As DataTable

        Dim cmd As SqlCommand = Crea_Comando("Pro_Remisiones2Api", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Servicios", SqlDbType.Int, Id_Servicios)

        Dim Tbl As DataTable
        Try
            Tbl = EjecutaConsulta(cmd)


        Catch ex As Exception
            TrataEx(ex)
            Return New DataTable
        End Try
        Return Tbl
    End Function
    Public Shared Function fn_FichasTipos(ByVal Id_Sesion As Integer) As DataTable

        Dim cmd As SqlCommand = Crea_Comando("Pro_FichasTiposApi", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, Id_Sesion)
        Dim Tbl As DataTable
        Try
            Tbl = EjecutaConsulta(cmd)


        Catch ex As Exception
            TrataEx(ex)
            Return New DataTable
        End Try
        Return Tbl
    End Function
    Public Shared Function fn_EfectivoDesglose(ByVal Id_Sesion As Integer, Id_CajaBancaria As Integer, Id_Servicios As String) As DataTable

        Dim cmd As SqlCommand = Crea_Comando("SProcedure_EfectivoDesgloseBanregioApi", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Servicios", SqlDbType.VarChar, Id_Servicios)
        Dim Tbl As DataTable
        Try
            Tbl = EjecutaConsulta(cmd)


        Catch ex As Exception
            TrataEx(ex)
            Return New DataTable
        End Try
        Return Tbl
    End Function
    Public Shared Function fn_Cheques(ByVal Id_Sesion As Integer, Id_CajaBancaria As Integer, Id_Servicios As String) As DataTable

        Dim cmd As SqlCommand = Crea_Comando("SProcedure_ChequesBanregioApi", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_Servicios", SqlDbType.VarChar, Id_Servicios)
        Dim Tbl As DataTable
        Try
            Tbl = EjecutaConsulta(cmd)


        Catch ex As Exception
            TrataEx(ex)
            Return New DataTable
        End Try
        Return Tbl
    End Function
    Public Shared Function fn_ProCuentasApi(ByVal Id_Sesion As Integer, Id_CajaBancaria As Integer, Id_Servicios As String) As DataTable

        Dim cmd As SqlCommand = Crea_Comando("SProcedure_CuentasBanregioApi", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, Id_Sesion)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Servicios", SqlDbType.VarChar, Id_Servicios)

        Dim Tbl As DataTable
        Try
            Tbl = EjecutaConsulta(cmd)


        Catch ex As Exception
            TrataEx(ex)
            Return New DataTable
        End Try
        Return Tbl
    End Function

    Public Shared Function fn_ReadFileList(ByVal Lsv As cp_Listview, ByVal Id_Sesion As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Sprocedure_Read_ArchivosBanregio", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Session", SqlDbType.Int, Id_Sesion)
            Lsv.Actualizar(cmd, "Id_Archivo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function
#End Region
End Class


