Imports System.Data.SqlClient
Imports Modulo_Proceso.Cn_Datos
Imports Modulo_Proceso.FuncionesGlobales

Public Class cn_Mensajes

    Public Shared Msg As New ToolTip With {.BackColor = Color.OrangeRed, .InitialDelay = 20, .ToolTipIcon = ToolTipIcon.Info, .ToolTipTitle = frm_MENU.Text, .UseAnimation = True, .UseFading = True}

#Region "Ver Mensajes"

    Public Shared Function fn_VerMensajes_LlenarLista(ByVal lsv As cp_Listview, ByVal Status As Char, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal Remitente As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Mensajes_GetNuevo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(cmd, "@Usuario_Destino", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
        Crea_Parametro(cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)
        Crea_Parametro(cmd, "@Remitente", SqlDbType.Int, Remitente)
        ' Crea_Parametro(cmd, "@Destinatario", SqlDbType.Int, Destinatario)
        'Today

        Try
            lsv.Actualizar(cmd, "Id_Mensaje")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VerMensajes_LlenarListaEnviados(ByVal lsv As cp_Listview, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal Destinatario As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Mensajes_GetEnviados", CommandType.StoredProcedure, Crea_ConexionSTD)

        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
        Crea_Parametro(cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)
        Crea_Parametro(cmd, "@Usuario_Destino", SqlDbType.Int, Destinatario)

        Try
            lsv.Actualizar(cmd, "Id_Mensaje")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VerMensajes_Leer(ByVal Id As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("Cat_Mensajes_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Mensaje", SqlDbType.Int, Id)

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

    Public Shared Function fn_VerMensajes_Status(ByVal Id As Integer, ByVal Status As Char) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Mensajes_Status", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Mensaje", SqlDbType.Int, Id)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(cmd, "@Estacion_Atendido", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Usuario_Atendido", SqlDbType.Int, UsuarioId)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Mensajes_Contar() As Integer
        If ModuloClave Is Nothing Then Return 0
        Dim cmd As SqlCommand = Crea_Comando("Cat_Mensajes_Contar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Modulo_Destino", SqlDbType.VarChar, ModuloClave)
        Crea_Parametro(cmd, "@Usuario_Destino", SqlDbType.Int, UsuarioId)

        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

#End Region

#Region "Enviar Mensajes"

    Public Shared Function fn_EnviarMensajes_LlenarLista(ByVal lsv As cp_Listview)
        Dim cmd As SqlCommand = Crea_Comando("Usr_Modulos_ComboGet", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            lsv.Actualizar(cmd, "Clave_Modulo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EnviarMensajes_LlenarListaU(ByVal lsv As cp_Listview)
        Dim cmd As SqlCommand = Crea_Comando("Usr_UsuariosCombo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EnviarMensajes_Enviar(ByVal Modulos() As String, ByVal Asunto As String, ByVal Mensaje As String) As Boolean

        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim cmd As SqlCommand

        For Each M As String In Modulos

            cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_Mensajes_Create")
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Modulo_Registro", SqlDbType.VarChar, ModuloClave)
            Crea_Parametro(cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Crea_Parametro(cmd, "@Mensaje", SqlDbType.Text, Mensaje)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Modulo_Destino", SqlDbType.VarChar, M)

            Try
                If EjecutarNonQueryT(cmd) = 0 Then
                    Tr.Rollback()
                    Return False
                End If
            Catch ex As Exception
                Tr.Rollback()
                TrataEx(ex)
                Return False
            End Try
        Next

        Tr.Commit()
        Return True

    End Function

    Public Shared Function fn_EnviarMensajesU_Enviar(ByVal Usuarios() As Integer, ByVal Asunto As String, ByVal Mensaje As String) As Boolean

        Dim Tr As SqlTransaction = crear_Trans(Crea_ConexionSTD)
        Dim cmd As SqlCommand

        For Each M As Integer In Usuarios

            cmd = Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_Mensajes_Create")
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Modulo_Registro", SqlDbType.VarChar, ModuloClave)
            Crea_Parametro(cmd, "@Asunto", SqlDbType.VarChar, Asunto)
            Crea_Parametro(cmd, "@Mensaje", SqlDbType.Text, Mensaje)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Modulo_Destino", SqlDbType.VarChar, "")
            Crea_Parametro(cmd, "@Usuario_Destino", SqlDbType.VarChar, M)

            Try
                If EjecutarNonQueryT(cmd) = 0 Then
                    Tr.Rollback()
                    Return False
                End If
            Catch ex As Exception
                Tr.Rollback()
                TrataEx(ex)
                Return False
            End Try
        Next

        Tr.Commit()
        Return True

    End Function

    Public Shared Function fn_EnviarMensajesU_EnviarMail(ByVal lsv As cp_Listview, ByVal Asunto As String, ByVal Mensaje As String) As Boolean
        For Each Elemento As ListViewItem In lsv.CheckedItems
            If Elemento.SubItems(3).Text = "S" And Elemento.SubItems(2).Text <> "" Then
                Cn_Mail.fn_Enviar_Mail(Elemento.SubItems(2).Text, Asunto, Mensaje, "")
            End If
        Next
        Return True
    End Function

    Public Shared Function fn_EnviarMensajes_Responder(ByVal Asunto As String, ByVal Mensaje As String, ByVal ModuloDestino As String, ByVal UsuarioDestino As Integer) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_Mensajes_Create", CommandType.StoredProcedure, Cnn)

        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(cmd, "@Modulo_Registro", SqlDbType.VarChar, ModuloClave)
        Crea_Parametro(cmd, "@Asunto", SqlDbType.VarChar, Asunto)
        Crea_Parametro(cmd, "@Mensaje", SqlDbType.Text, Mensaje)
        Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Crea_Parametro(cmd, "@Modulo_Destino", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Usuario_Destino", SqlDbType.Int, UsuarioDestino)

        Try
            EjecutarScalar(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "Contar Mensajes"

    Public Shared Sub ActualizarMensajes()
        If SucursalId = Nothing Then Exit Sub
        Dim Mensajes As Integer = fn_Mensajes_Contar()
        frm_MENU.tsb_LeerMensajes.Text = Mensajes & " Mensajes Nuevos"

        If Mensajes > 0 Then

            Msg.Show(Mensajes & " Mensajes Nuevos", frm_MENU.ToolStrip, frm_MENU.ToolStrip.Location.X + frm_MENU.ToolStrip.Width, frm_MENU.ToolStrip.Location.Y)
            frm_MENU.tsb_LeerMensajes.Image = My.Resources.redled
        Else
            frm_MENU.tsb_LeerMensajes.Image = My.Resources.greenled
        End If

    End Sub

#End Region

   
End Class
