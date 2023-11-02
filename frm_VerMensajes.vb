

Public Class frm_VerMensajes

    Dim Remitente As Integer = 0
    Dim Destinatario As Integer = 0
    Dim Desde As Date = #1/1/2010#
    Dim Hasta As Date = Today.AddDays(1)

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_VerMensajes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmb_Empleados.Actualizar()
        dtp_Desde.Value = Today.ToShortDateString
        dtp_Hasta.Value = Today.ToShortDateString

        If Not cn_Mensajes.fn_VerMensajes_LlenarLista(lsv_MensajesRecibidos, "A", Desde, Hasta, Remitente) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        tbx_Tipo.Clear()
        lbl_Nota.Visible = False
        If tab_Mensajes.SelectedIndex = 0 Then
            If cbx_Pendientes.Checked Then
                If Not cn_Mensajes.fn_VerMensajes_LlenarLista(lsv_MensajesRecibidos, "A", Desde, Hasta, Remitente) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                If Not cn_Mensajes.fn_VerMensajes_LlenarLista(lsv_MensajesRecibidos, "T", Desde, Hasta, Remitente) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        Else

            If Not cn_Mensajes.fn_VerMensajes_LlenarListaEnviados(lsv_MensajesEnviados, Desde, Hasta, Destinatario) Then
                MsgBox("Ha ocurrido un error al intentar cargar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

        End If
    End Sub

    Private Sub lsv_Mensajes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_MensajesRecibidos.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Guardar.Enabled = False
        tsm_Atendido.Enabled = False
        btn_Responder.Enabled = False
        lbl_Nota.Visible = False
        tbx_Tipo.Clear()
        If lsv_MensajesRecibidos.SelectedItems.Count > 0 Then
            lbl_Nota.Visible = True
            btn_Responder.Enabled = True
            If lsv_MensajesRecibidos.SelectedItems(0).SubItems(4).Text = "PENDIENTE" Then
                btn_Guardar.Enabled = True
                tsm_Atendido.Enabled = True
                btn_Responder.Enabled = True
            End If
            Dim Row As DataRow = cn_Mensajes.fn_VerMensajes_Leer(lsv_MensajesRecibidos.SelectedItems(0).Tag)
            If Row IsNot Nothing Then
                tbx_Fecha.Text = Row("Fecha")
                tbx_Hora.Text = Row("Hora")
                tbx_Modulo.Text = Row("Modulo")
                tbx_Remitente.Text = Row("Remitente")
                tbx_Asunto.Text = Row("Asunto")
                rtb_Mensaje.Text = Row("Mensaje")
                tbx_Tipo.Text = lsv_MensajesRecibidos.SelectedItems(0).SubItems(3).Text
                If tbx_Tipo.Text = "PERSONALIZADO" Then
                    tbx_Tipo.ForeColor = Color.Red
                    lbl_Nota.Text = "Este mensaje solo puede ser visto por " & UsuarioN
                    lbl_Nota.ForeColor = Color.Red
                Else
                    tbx_Tipo.ForeColor = Color.Black
                    lbl_Nota.Text = "Este mensaje puede ser visto por TODOS los usuarios con acceso a este Módulo"
                    lbl_Nota.ForeColor = Color.Black
                End If
                tbx_Remitente.Tag = Row("Usuario_Registro")
                tbx_Modulo.Tag = Row("Modulo_Registro")
            Else
                MsgBox("Ha ocurrido un error al intentar consultar el Mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            
        Else
            tbx_Fecha.Clear()
            tbx_Hora.Clear()
            tbx_Modulo.Clear()
            tbx_Remitente.Clear()
            tbx_Asunto.Clear()
            rtb_Mensaje.Clear()
        End If
    End Sub


    Private Sub lsv_MensajesEnviados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_MensajesEnviados.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Guardar.Enabled = False
        tsm_Atendido.Enabled = False
        btn_Responder.Enabled = False
        lbl_Nota.Visible = False
        tbx_Tipo.Clear()
        If lsv_MensajesEnviados.SelectedItems.Count > 0 Then
            If lsv_MensajesEnviados.SelectedItems(0).SubItems(3).Text = "PENDIENTE" Then
                btn_Guardar.Enabled = True
                tsm_Atendido.Enabled = True
                btn_Responder.Enabled = True
            End If
            Dim Row As DataRow = cn_Mensajes.fn_VerMensajes_Leer(lsv_MensajesEnviados.SelectedItems(0).Tag)
            If Row IsNot Nothing Then
                tbx_Fecha.Text = Row("Fecha")
                tbx_Hora.Text = Row("Hora")
                tbx_Modulo.Text = Row("Modulo")
                If tab_Mensajes.SelectedIndex = 0 Then
                    tbx_Remitente.Text = Row("Remitente")
                Else
                    tbx_Remitente.Text = Row("Destinatario")
                End If
                tbx_Asunto.Text = Row("Asunto")
                rtb_Mensaje.Text = Row("Mensaje")
                tbx_Tipo.Text = lsv_MensajesEnviados.SelectedItems(0).SubItems(3).Text
                If tbx_Tipo.Text = "PERSONALIZADO" Then
                    tbx_Tipo.ForeColor = Color.Red
                    'lbl_Nota.Text = "Este mensaje solo puede ser visto por " & UsuarioN
                    'lbl_Nota.ForeColor = Color.Red
                Else
                    tbx_Tipo.ForeColor = Color.Black
                    'lbl_Nota.Text = "Este mensaje puede ser visto por TODOS los usuarios con acceso a este Módulo"
                    'lbl_Nota.ForeColor = Color.Black
                End If
            Else
                MsgBox("Ha ocurrido un error al intentar consultar el Mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            tbx_Fecha.Clear()
            tbx_Hora.Clear()
            tbx_Modulo.Clear()
            tbx_Remitente.Clear()
            tbx_Asunto.Clear()
            rtb_Mensaje.Clear()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click, tsm_Atendido.Click
        SegundosDesconexion = 0

        If lsv_MensajesRecibidos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un Mensaje para validar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Not cn_Mensajes.fn_VerMensajes_Status(lsv_MensajesRecibidos.SelectedItems(0).Tag, "V") Then
            MsgBox("Ha ocurrido un error al intentar atender el Mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            cn_Mensajes.ActualizarMensajes()
            MsgBox("El Mensaje se ha atendido correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarLista()
        End If
    End Sub

    Private Sub lsv_Mensajes_AlActualizar() Handles lsv_MensajesRecibidos.AlActualizar, lsv_MensajesEnviados.AlActualizar
        btn_Guardar.Enabled = False
        tsm_Atendido.Enabled = False
        tbx_Fecha.Clear()
        tbx_Hora.Clear()
        tbx_Modulo.Clear()
        tbx_Remitente.Clear()
        tbx_Asunto.Clear()
        rtb_Mensaje.Clear()
        For Each item As ListViewItem In lsv_MensajesRecibidos.Items
            If item.SubItems(4).Text = "PENDIENTE" Then
                item.ImageIndex = 0
                item.Font = New Font(item.SubItems(1).Font, item.SubItems(1).Font.Style Or FontStyle.Bold)
            Else
                item.ImageIndex = 1
            End If
        Next

        For Each item As ListViewItem In lsv_MensajesEnviados.Items
            item.ImageIndex = 2
        Next
    End Sub

    Private Sub frm_VerMensajes_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        SplitContainer1.SplitterDistance = (Width / 2) - 20
    End Sub

    Private Sub cms_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cms.Opening
        e.Cancel = lsv_MensajesRecibidos.SelectedItems.Count = 0
    End Sub

    Private Sub btn_Responder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Responder.Click
        SegundosDesconexion = 0

        If rtb_Respuesta.Text.Length < 2 Then
            MsgBox("Por favor indique un mensaje de Respuesta.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Respuesta.Focus()
            Exit Sub
        End If

        Dim Respuesta As String = rtb_Respuesta.Text & Chr(13) & Chr(13) & "<-- Mensaje Original -->" & Chr(13) & rtb_Mensaje.Text
        If Not cn_Mensajes.fn_EnviarMensajes_Responder("RE : " & tbx_Asunto.Text, Respuesta, tbx_Modulo.Tag, tbx_Remitente.Tag) Then
            MsgBox("Ha ocurrido un error al intentar enviar el mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            MsgBox("El mensaje se ha enviado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        If Not cn_Mensajes.fn_VerMensajes_Status(lsv_MensajesRecibidos.SelectedItems(0).Tag, "V") Then
            MsgBox("Ha ocurrido un error al intentar atender el Mensaje.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            cn_Mensajes.ActualizarMensajes()
            'MsgBox("El Mensaje se ha atendido correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarLista()
        End If

        rtb_Respuesta.Clear()

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_Hasta.Value < dtp_Desde.Value Then
            MsgBox("La Fecha Hasta debe ser menor a Fecha Desde.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Hasta.Focus()
            Exit Sub
        End If

        If cmb_Empleados.SelectedValue = 0 And Not cbx_TodosEmpleados.Checked Then
            MsgBox("Seleccione el " & lbl_Empleado.Text & ".", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleados.Focus()
            Exit Sub
        End If
        ValidarTipoConsulta()
        LlenarLista()

    End Sub

    Sub ValidarTipoConsulta()
        If tab_Mensajes.SelectedIndex = 0 Then
            Destinatario = 0
            If cbx_TodosEmpleados.Checked Then
                Remitente = 0
            Else
                Remitente = cmb_Empleados.SelectedValue
            End If
        ElseIf tab_Mensajes.SelectedIndex = 1 Then
            Remitente = 0
            If cbx_TodosEmpleados.Checked Then
                Destinatario = 0
            Else
                Destinatario = cmb_Empleados.SelectedValue
            End If
        End If
    End Sub

    Sub ValidarFechas()

        If cbx_TodasFechas.Checked Then
            dtp_Desde.Enabled = False
            dtp_Hasta.Enabled = False
            dtp_Desde.Value = Today.ToShortDateString
            dtp_Hasta.Value = Today.ToShortDateString
            Desde = #1/1/2010#
            Hasta = Today.AddDays(1)
        Else
            dtp_Desde.Enabled = True
            dtp_Hasta.Enabled = True
            Desde = dtp_Desde.Value
            Hasta = dtp_Hasta.Value
        End If

    End Sub

    Private Sub tab_Mensajes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_Mensajes.SelectedIndexChanged
        SegundosDesconexion = 0
        If tab_Mensajes.SelectedIndex = 0 Then
            lbl_Empleado.Text = "Remitente"
            lbl_RemitenteDetalle.Text = "Remitente"
            lbl_ModuloRemitente.Visible = True
            lbl_ModuloDestinatario.Visible = False
            rtb_Respuesta.Enabled = True
        ElseIf tab_Mensajes.SelectedIndex = 1 Then
            lbl_Empleado.Text = "Destinatario"
            lbl_RemitenteDetalle.Text = "Destinatario"
            lbl_ModuloRemitente.Visible = False
            lbl_ModuloDestinatario.Visible = True
            rtb_Respuesta.Enabled = False
        End If
        lsv_MensajesRecibidos.Items.Clear()
        lsv_MensajesEnviados.Items.Clear()
        dtp_Desde.Value = Today.ToShortDateString
        dtp_Hasta.Value = Today.ToShortDateString
        cbx_TodasFechas.Checked = True
        cbx_TodosEmpleados.Checked = True
        cbx_Pendientes.Checked = True
        'tbx_Buscar.Clear()
        ValidarTipoConsulta()
        LlenarLista()

    End Sub

    Private Sub cbx_TodasFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TodasFechas.CheckedChanged
        SegundosDesconexion = 0
        If tab_Mensajes.SelectedIndex = 0 Then
            lsv_MensajesRecibidos.Items.Clear()
            ValidarFechas()
        ElseIf tab_Mensajes.SelectedIndex = 1 Then
            lsv_MensajesEnviados.Items.Clear()
            ValidarFechas()
        End If
    End Sub

    Private Sub cbx_TodosEmpleados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TodosEmpleados.CheckedChanged
        SegundosDesconexion = 0
        If tab_Mensajes.SelectedIndex = 0 Then
            lsv_MensajesRecibidos.Items.Clear()
            If cbx_TodosEmpleados.Checked Then
                cmb_Empleados.SelectedValue = 0
                cmb_Empleados.Enabled = False
            Else
                cmb_Empleados.Enabled = True
            End If
        ElseIf tab_Mensajes.SelectedIndex = 1 Then
            lsv_MensajesEnviados.Items.Clear()
            If cbx_TodosEmpleados.Checked Then
                cmb_Empleados.SelectedValue = 0
                cmb_Empleados.Enabled = False
            Else
                cmb_Empleados.Enabled = True
            End If
        End If
    End Sub

    Private Sub cbx_Pendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Pendientes.CheckedChanged
        ValidarFechas()
        ValidarTipoConsulta()
        Call LlenarLista()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged, dtp_Hasta.ValueChanged
        lsv_MensajesEnviados.Items.Clear()
        lsv_MensajesRecibidos.Items.Clear()
        ValidarFechas()
    End Sub

    Private Sub rtb_Respuesta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Respuesta.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Buscar()
    End Sub

    Sub Buscar()
        Dim Fila_Inicio As Integer = 0

        If tab_Mensajes.SelectedIndex = 0 Then
            If lsv_MensajesRecibidos.SelectedItems.Count > 0 Then
                Fila_Inicio = lsv_MensajesRecibidos.SelectedItems(0).Index + 1
            End If
            FuncionesGlobales.fn_Buscar_enListView(lsv_MensajesRecibidos, tbx_Buscar.Text, 0, Fila_Inicio)
        Else
            If lsv_MensajesEnviados.SelectedItems.Count > 0 Then
                Fila_Inicio = lsv_MensajesEnviados.SelectedItems(0).Index + 1
            End If
            FuncionesGlobales.fn_Buscar_enListView(lsv_MensajesEnviados, tbx_Buscar.Text, 0, Fila_Inicio)
        End If
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then Buscar()
    End Sub

    Private Sub lsv_MensajesRecibidos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_MensajesRecibidos.MouseHover, lsv_MensajesEnviados.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class