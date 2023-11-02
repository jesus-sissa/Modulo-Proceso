Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ConsultaDotaciones

    Private Sub frm_ConsultaDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_dotaciones.Columns.Add("Remision")
        lsv_dotaciones.Columns.Add("Fecha")
        lsv_dotaciones.Columns.Add("Sesion")
        lsv_dotaciones.Columns.Add("Cliente")
        lsv_dotaciones.Columns.Add("Moneda")
        lsv_dotaciones.Columns.Add("Importe")
        lsv_dotaciones.Columns.Add("Envases")
        lsv_dotaciones.Columns.Add("Envases SN")
        lsv_dotaciones.Columns.Add("Status")

        lsv_Desglose.Columns.Add("Denominacion")
        lsv_Desglose.Columns.Add("Cantidad")
        lsv_Desglose.Columns.Add("CantidadA")
        lsv_Desglose.Columns.Add("CantidadB")
        lsv_Desglose.Columns.Add("CantidadC")
        lsv_Desglose.Columns.Add("CantidadD")
        lsv_Desglose.Columns.Add("CantidadE")

        cmb_Moneda.Actualizar()
        cmb_CajaBancaria.Actualizar()
        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()

        cmb_Status.AgregarItem("SO", "SOLICITADA")
        cmb_Status.AgregarItem("CA", "CANCELADA")
        cmb_Status.AgregarItem("AD", "ASIGNADA A DOTADOR")
        cmb_Status.AgregarItem("VD", "ACEPTADA POR DOTADOR")
        cmb_Status.AgregarItem("VA", "VALIDADA")
        cmb_Status.AgregarItem("EB", "ENVIADA A BÓVEDA")
        cmb_Status.AgregarItem("RB", "RECIBIDA EN BOVEDA")
        cmb_Status.AgregarItem("DB", "DEVUELTA POR BOVEDA")
        cmb_Status.AgregarItem("DE", "DESPACHADA")
        cmb_Status.AgregarItem("EN", "ENTREGADA")


        'If Not fn_ConsultaDotaciones_LlenarRemisiones(lsv_dotaciones, 0, "S", Nothing, Nothing, 0, 0, 0, "0", 0) Then
        '   MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        '   Exit Sub
        'End If

        'If Not fn_ConsultaDotaciones_LlenarDetalle(lsv_Desglose, 0) Then
        '   MsgBox("Ha ocurrido un error al intentar llenar el detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
        '   Exit Sub
        'End If

    End Sub

    Private Sub frm_ConsultaDepositos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 And cbx_Monedas.Focused Then SendKeys.Send(Chr(Keys.Tab))
        If Asc(e.KeyChar) = 13 And cbx_Corte.Focused Then SendKeys.Send(Chr(Keys.Tab))
        If Asc(e.KeyChar) = 13 And cbx_Status.Focused Then SendKeys.Send(Chr(Keys.Tab))
    End Sub

    Private Sub cbx_Monedas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmb_Moneda.Enabled = Not cbx_Monedas.Checked
        If cbx_Monedas.Checked Then
            cmb_Moneda.SelectedValue = "0"
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        lsv_dotaciones.Items.Clear()
        lsv_Desglose.Items.Clear()
        btn_Exportar.Enabled = False
        If Validar() Then
            Dim TipoConsulta As Char
            Dim Corte As Integer
            If cbx_Corte.Checked Then Corte = 0 Else Corte = CInt(tbx_Corte.Text)
            TipoConsulta = "S"
            If Not fn_ConsultaDotaciones_LlenarRemisiones(lsv_dotaciones, cmb_CajaBancaria.SelectedValue, TipoConsulta, Nothing, Nothing, _
                                                   cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Moneda.SelectedValue, cmb_Status.SelectedValue, _
                                                   Corte) Then

                MsgBox("Ha ocurrido un error al intentar llenar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            btn_Exportar.Enabled = lsv_dotaciones.Items.Count > 0
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_dotaciones.Items.Count)
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Moneda.SelectedValue = "0" And Not cbx_Monedas.Checked Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Status.SelectedValue = "0" And Not cbx_Status.Checked Then
            MsgBox("Debe seleccionar un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If (tbx_Corte.Text = "" Or (Not tbx_Corte.Text = "" AndAlso tbx_Corte.Text = 0)) And Not cbx_Corte.Checked Then
            MsgBox("Debe seleccionar un Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Desde.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesion Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_Hasta.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesion Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        Return True
    End Function

    Private Sub dtp_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(Chr(Keys.Tab))
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Desde.SelectedValue = cmb_Hasta.SelectedValue
        End If
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        Call Limpiar()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Hasta.SelectedValue = cmb_Desde.SelectedValue
        End If
    End Sub

    Private Sub cbx_Monedas_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Monedas.CheckedChanged
        Call Limpiar()
        cmb_Moneda.Enabled = Not cbx_Monedas.Checked
        If cbx_Monedas.Checked Then
            cmb_Moneda.SelectedValue = "0"
        End If
    End Sub

    Private Sub cbx_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Status.CheckedChanged
        Call Limpiar()
        cmb_Status.Enabled = Not cbx_Status.Checked
        If cbx_Status.Checked Then
            cmb_Status.SelectedValue = "0"
        End If
    End Sub

    Private Sub cbx_Corte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Corte.CheckedChanged
        Call Limpiar()
        tbx_Corte.Enabled = Not cbx_Corte.Checked
        If cbx_Corte.Checked Then
            tbx_Corte.Text = ""
        End If
    End Sub

    Private Sub lsv_dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_dotaciones.SelectedIndexChanged
        lsv_Desglose.Items.Clear()
        If lsv_dotaciones.SelectedItems.Count > 0 Then
            If Not fn_ConsultaDotaciones_LlenarDetalle(lsv_Desglose, lsv_dotaciones.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar consultar el Desglose de la Dotación.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Desglose.Items.Count)
    End Sub

    Sub Limpiar()
        SegundosDesconexion = 0
        lsv_dotaciones.Items.Clear()
        lsv_Desglose.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_dotaciones.Items.Count)
        btn_Exportar.Enabled = False
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub Tab_TipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Limpiar()
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub tbx_Corte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Corte.TextChanged
        Call Limpiar()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Limpiar()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_dotaciones, 2, "CONSULTA DE DOTACIONES", 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_dotaciones_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_dotaciones.MouseHover, lsv_Desglose.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click

        If lsv_dotaciones.Items.Count <> 0 Then
            Dim remision As String = lsv_dotaciones.SelectedItems(0).SubItems(0).Text
            Clipboard.SetText(remision)
        End If

    End Sub
End Class