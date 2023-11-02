Imports System.Data.SqlClient

Public Class Cn_Fallas

#Region "Reporte de Fallas"

    Public Shared Function fn_ReporteFallas_Crear(ByVal Id_SubClase As Integer, ByVal Id_Inventario As Integer, ByVal Descripcion As String, ByVal Etiqueta As String, ByVal Ubicacion As String, ByVal Identificacion As String, ByVal UsuarioQReporta As String, ByVal TipoDEquipo As String, ByVal ArchivoAdjunto As String) As Integer
        Dim Id_Reporte As Integer = 0
        Dim Id_Tarea As Integer = 0
        Dim DescripcionTarea As String = ""
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Inv_ReporteFallas_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Modulo_Registro", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Subclase", SqlDbType.Int, Id_SubClase)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, Id_Inventario)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Etiqueta", SqlDbType.VarChar, Etiqueta)
            Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, Ubicacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            Id_Reporte = Cn_Datos.EjecutarScalarT(Cmd)

            'Guardar la Tarea
            DescripcionTarea = Descripcion & Chr(13) _
            & "ETIQUETA: " & Etiqueta & Chr(13) _
            & "UBICACION: " & Ubicacion & Chr(13) & Chr(13) _
            & "IDENTIFICACION: " & Chr(13) & Identificacion & Chr(13) _
            & "USUARIO QUE REPORTA: " & UsuarioQReporta & Chr(13) _
            & "ARCHIVO ADJUNTO: " & ArchivoAdjunto & Chr(13)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Usr_Tareas_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, DescripcionTarea)
            Cn_Datos.Crea_Parametro(Cmd, "@Opcion", SqlDbType.VarChar, "FALLA EN EQUIPO")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2) '1=Desarrollo; 2=Soporte
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Opcion", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Reporte", SqlDbType.Int, Id_Reporte)
            Id_Tarea = Cn_Datos.EjecutarScalarT(Cmd)

            Tr.Commit()
            Cmd.Dispose()
            Cnn.Dispose()

            Return Id_Reporte
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            Cnn.Dispose()
            FuncionesGlobales.TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ReporteFallasS_Crear(ByVal Clave_Modulo As String, ByVal Id_Opcion As Integer, ByVal Descripcion As String, ByVal Etiqueta As String, ByVal Ubicacion As String, ByVal ModuloQFalla As String, ByVal Menu As String, ByVal Opcion As String, ByVal UsuarioQReporta As String, ByVal ArchivoAdjunto As String) As Integer
        Dim Id_Reporte As Integer = 0
        Dim Id_Tarea As Integer = 0
        Dim DescripcionTarea As String = ""
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Usr_ReporteFallas_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Modulo_Registro", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Opcion", SqlDbType.Int, Id_Opcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Etiqueta", SqlDbType.VarChar, Etiqueta)
            Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, Ubicacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Id_Reporte = Cn_Datos.EjecutarScalarT(Cmd)

            'Guardar la Tarea
            DescripcionTarea = Chr(13) & "USUARIO QUE REPORTA: " & UsuarioQReporta & Chr(13) _
            & "ETIQUETA: " & Etiqueta & Chr(13) _
            & "UBICACION: " & Ubicacion & Chr(13) _
            & "DESCRIPCION: " & Descripcion _
            & "ARCHIVO ADJUNTO: " & ArchivoAdjunto & Chr(13) & Chr(13)


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Usr_Tareas_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
            Cn_Datos.Crea_Parametro(Cmd, "@Opcion", SqlDbType.VarChar, Opcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, DescripcionTarea)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1) '1=Desarrollo; 2=Soporte
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Opcion", SqlDbType.Int, Id_Opcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Reporte", SqlDbType.Int, Id_Reporte)
            Id_Tarea = Cn_Datos.EjecutarScalarT(Cmd)

            Tr.Commit()
            Cmd.Dispose()
            Cnn.Dispose()

            Return Id_Reporte
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            Cnn.Dispose()
            FuncionesGlobales.TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ReporteFallas_ReadByClave(ByVal Clave_Inventario As String) As DataTable
        Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Inv_Inventario_ReadByClave", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Try
            Cn_Datos.Crea_Parametro(cmd, "@Clave_Inventario", SqlDbType.VarChar, Clave_Inventario)

            Return Cn_Datos.EjecutaConsulta(cmd)
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Inventario_Read(ByVal Id_Inventario As String) As DataTable
        Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Inv_Inventario_Read", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Inventario", SqlDbType.VarChar, Id_Inventario)

            Return Cn_Datos.EjecutaConsulta(cmd)
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteFallas_LlenarLista(ByVal lsv As cp_Listview, ByVal Clave_Modulo As String, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_Tareas_GetByUsuario", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
        Cn_Datos.Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Cn_Datos.Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
        Try
            lsv.Actualizar(cmd, "Id_Tarea")
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TareasAtender_LlenarListaDGV(ByVal Id_Tarea As Integer, ByVal dgv As DataGridView) As Boolean
        Dim dt As DataTable
        dgv.DataSource = Nothing
        dgv.Columns.Clear()
        dgv.Rows.Clear()
        Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_TareasD_Get", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Tarea", SqlDbType.Int, Id_Tarea)
        Try
            dt = Cn_Datos.EjecutaConsulta(cmd)
            dgv.DataSource = dt
            dgv.Columns(0).Visible = False
            dgv.Columns(1).Width = dgv.Width * 0.1 '70
            dgv.Columns(2).Width = dgv.Width * 0.1 '50
            dgv.Columns(3).Width = dgv.Width * 0.2 '150
            dgv.Columns(4).Width = dgv.Width * 0.4 '200
            dgv.Columns(5).Width = dgv.Width * 0.1 '50
            dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            For Each Columna As DataGridViewColumn In dgv.Columns
                Columna.ReadOnly = True
            Next
            dgv.AllowDrop = False
            dgv.AllowUserToAddRows = False
            dgv.AllowUserToOrderColumns = False
            dgv.AllowUserToResizeColumns = True
            dgv.AllowUserToResizeRows = True
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TareasUsuario_Indicencia(ByVal Id_Tarea As Integer, ByVal Descripcion As String, ByVal Porcentaje_Avance As Integer) As Boolean
        Dim Cmd As SqlCommand
        Try
            Cmd = Cn_Datos.Crea_Comando("Usr_TareasD_Create", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Tarea", SqlDbType.Int, Id_Tarea)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Porcentaje_Avance", SqlDbType.TinyInt, Porcentaje_Avance)
            Cn_Datos.EjecutarNonQuery(Cmd)

            Cmd.Dispose()
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Solicitud de Equipo, Servicio, otros"

    Public Shared Function fn_ReporteFallasI_Crear(ByVal Tipo As Integer, ByVal Descripcion As String, ByVal EquipoQueSustituye As String, ByVal Fecha_Requerida As Date, ByVal Hora_Requerida As String, ByVal Motivo_Solicitud As String, ByVal Departamento_Designado As Integer, ByVal Usuario_Designado As Integer, ByVal TipoSolicitud As String, ByVal Cantidad_Solicitada As Integer, ByVal Nombre_Usuario As String, ByVal Nombre_Departamento As String, ByVal Usuario_Solicita As String, ByVal Adjunto As String) As Integer
        Dim Id_Solicitud As Integer = 0
        Dim Id_Tarea As Integer = 0
        Dim DescripcionTarea As String = ""
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Usr_Solicitudes_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Modulo_Registro", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo) '1=Equipo; 2=Servicio; 3=Otros
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@EquipoQueSustituye", SqlDbType.VarChar, EquipoQueSustituye)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Requerida", SqlDbType.Date, Fecha_Requerida)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Requerida", SqlDbType.Time, Hora_Requerida)
            Cn_Datos.Crea_Parametro(Cmd, "@Motivo_Solicitud", SqlDbType.Text, Motivo_Solicitud)
            Cn_Datos.Crea_Parametro(Cmd, "@Departamento_Designado", SqlDbType.Int, Departamento_Designado)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Designado", SqlDbType.Int, Usuario_Designado)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Solicitada", SqlDbType.Int, Cantidad_Solicitada)
            Id_Solicitud = Cn_Datos.EjecutarScalarT(Cmd)

            'Guardar la Tarea 
            DescripcionTarea = Descripcion & Chr(13) & Chr(13) _
            & "MOTIVO: " & Motivo_Solicitud & Chr(13) & Chr(13) _
            & "FECHA REQUERIDA: " & Fecha_Requerida.ToShortDateString & " HORA REQUERIDA:" & FormatDateTime(Hora_Requerida) & Chr(13) _
            & "ESTACION REGISTRO: " & EstacioN & Chr(13) _
            & "EQUIPO QUE SUSTITUYE: " & EquipoQueSustituye & Chr(13) _
            & "DEPARTAMENTO ASIGNADO: " & Nombre_Departamento & Chr(13) _
            & "USUARIO SOLICITA: " & Usuario_Solicita & Chr(13) _
            & "USUARIO DESIGNADO: " & Nombre_Usuario & Chr(13) _
            & "CANTIDAD SOLICITADA: " & Cantidad_Solicitada _
            & "ARCHIVO ADJUNTO: " & Adjunto

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Usr_Tareas_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(Cmd, "@Opcion", SqlDbType.VarChar, TipoSolicitud)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Text, DescripcionTarea)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3) '1=Desarrollo; 2=Soporte; 3=Solicitud
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Opcion", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Reporte", SqlDbType.Int, Id_Solicitud)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            Tr.Commit()
            Cmd.Dispose()
            Cnn.Dispose()

            Return Id_Solicitud
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            Cnn.Dispose()
            FuncionesGlobales.TrataEx(ex, False)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ReporteFallasI_ReadEmpleados(ByVal Id_Departamento As String) As DataTable
        Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_ComboGetByDepto", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.VarChar, Id_Departamento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            Return Cn_Datos.EjecutaConsulta(cmd)
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "ALERTAS CONSULTAS"

    Public Shared Function fn_AlertasGeneradas_LlenarListaFiltrada(ByVal lsv As cp_Listview, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal Tipo As String, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradas_GetFiltrado", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
        Cn_Datos.Crea_Parametro(cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)
        Cn_Datos.Crea_Parametro(cmd, "@Destino", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(cmd, "@Tipo", SqlDbType.VarChar, Tipo)
        Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            lsv.Actualizar(cmd, "Id_Alerta")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AlertasGeneradas_LlenarListaDetalle(ByVal lsv As cp_Listview, ByVal Id_Alerta As Integer) As Boolean
        Dim cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradasD_Get", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
        Try
            lsv.Actualizar(cmd, "Id_Entidad")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

End Class
