Public Class frm_EnviarMensajes

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_VerMensajes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not cn_Mensajes.fn_EnviarMensajes_LlenarLista(lsv_Modulos) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        If Not cn_Mensajes.fn_EnviarMensajes_LlenarListaU(lsv_Usuarios) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0
        If Tab_Opciones.SelectedTab Is Tab_Modulo Then
            If lsv_Modulos.CheckedItems.Count = 0 Then
                MsgBox("Debe seleccionar al menos un Destinatario.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If

        ElseIf Tab_Opciones.SelectedTab Is Tab_Usuario Then
            If lsv_Usuarios.CheckedItems.Count = 0 Then
                MsgBox("Debe seleccionar al menos un Destinatario.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        End If

        If tbx_Asunto.Text = "" Then
            MsgBox("Debe Escribir un Asunto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If rtb_Mensaje.Text = "" Then
            MsgBox("Debe Escribir un Mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        Return True
    End Function

    Sub MarcarTodo(ByVal lsv As cp_Listview)
        SegundosDesconexion = 0
        For Each Elemento As ListViewItem In lsv.Items
            Elemento.Checked = True
        Next
    End Sub

    Sub DesmarcarTodo(ByVal lsv As cp_Listview)
        SegundosDesconexion = 0
        For Each Elemento As ListViewItem In lsv.Items
            Elemento.Checked = False
        Next
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If Not Validar() Then Exit Sub
        If Tab_Opciones.SelectedTab Is Tab_Modulo Then
            Dim Modulos(lsv_Modulos.CheckedItems.Count - 1) As String
            For i As Integer = 0 To lsv_Modulos.CheckedItems.Count - 1
                Modulos(i) = lsv_Modulos.CheckedItems(i).Tag
            Next
            If Not cn_Mensajes.fn_EnviarMensajes_Enviar(Modulos, tbx_Asunto.Text, rtb_Mensaje.Text) Then
                MsgBox("Ha ocurrido un error al intentar enviar el Mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                MsgBox("El Mensaje se ha enviado correctamente a todos los Destinatarios.", MsgBoxStyle.Information, frm_MENU.Text)
                chk_Todos.Checked = False
                tbx_Asunto.Clear()
                rtb_Mensaje.Clear()
                DesmarcarTodo(lsv_Modulos)
                cn_Mensajes.ActualizarMensajes()
            End If
        ElseIf Tab_Opciones.SelectedTab Is Tab_Usuario Then
            Dim Usuarios(lsv_Usuarios.CheckedItems.Count - 1) As Integer
            For i As Integer = 0 To lsv_Usuarios.CheckedItems.Count - 1
                Usuarios(i) = lsv_Usuarios.CheckedItems(i).Tag
            Next
            If Not cn_Mensajes.fn_EnviarMensajesU_Enviar(Usuarios, tbx_Asunto.Text, rtb_Mensaje.Text) Then
                MsgBox("Ha ocurrido un error al intentar enviar el Mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else

                'Aqui se envian los Mails a los Usuarios que lo Requieran 
                Dim MensajeLocal As String = "Remitente: " & UsuarioN & Chr(13) & Chr(13) & rtb_Mensaje.Text
                cn_Mensajes.fn_EnviarMensajesU_EnviarMail(lsv_Usuarios, "Mensaje: " & tbx_Asunto.Text, MensajeLocal)

                MsgBox("El Mensaje se ha enviado correctamente a todos los Destinatarios.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_Asunto.Clear()
                rtb_Mensaje.Clear()
                DesmarcarTodo(lsv_Usuarios)
                cn_Mensajes.ActualizarMensajes()
            End If
        End If
    End Sub

    Private Sub rtb_Mensaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Mensaje.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Sub HabilitaBoton() Handles lsv_Modulos.ItemChecked, lsv_Usuarios.ItemChecked, tbx_Asunto.TextChanged, rtb_Mensaje.TextChanged
        SegundosDesconexion = 0

        If Tab_Opciones.SelectedTab Is Tab_Modulo Then
            btn_Guardar.Enabled = lsv_Modulos.CheckedItems.Count > 0 And tbx_Asunto.Text <> "" And rtb_Mensaje.Text <> ""
        ElseIf Tab_Opciones.SelectedTab Is Tab_Usuario Then
            btn_Guardar.Enabled = lsv_Usuarios.CheckedItems.Count > 0 And tbx_Asunto.Text <> "" And rtb_Mensaje.Text <> ""
        End If
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        If chk_Todos.Checked = True Then
            MarcarTodo(lsv_Modulos)
        Else
            DesmarcarTodo(lsv_Modulos)
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Call Buscar()
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then Buscar()
    End Sub

    Sub Buscar()
        Dim Fila_Inicio As Integer = 0
        If lsv_Usuarios.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Usuarios.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Usuarios, tbx_Buscar.Text, 0, Fila_Inicio)
        
    End Sub

    Private Sub lsv_Modulos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Modulos.MouseHover, lsv_Usuarios.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class