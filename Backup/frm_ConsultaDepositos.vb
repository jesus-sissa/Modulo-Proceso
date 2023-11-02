Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ConsultaDepositos

    Private Sub frm_ConsultaDepositos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lsv_Dotaciones.Columns.Add("Remision")
        lsv_Dotaciones.Columns.Add("Cia")
        lsv_Dotaciones.Columns.Add("Fecha")
        lsv_Dotaciones.Columns.Add("Sesion")
        lsv_Dotaciones.Columns.Add("Caja")
        lsv_Dotaciones.Columns.Add("Cliente")
        lsv_Dotaciones.Columns.Add("Fichas")
        lsv_Dotaciones.Columns.Add("Importe")
        lsv_Dotaciones.Columns.Add("Envases")
        lsv_Dotaciones.Columns.Add("Envases SN")
        lsv_Dotaciones.Columns.Add("Cajero")
        lsv_Dotaciones.Columns.Add("Status")


        cmb_CajaBancaria.Actualizar()
        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()

        cmb_Status.AgregarItem("RC", "RECIBIDO")
        cmb_Status.AgregarItem("AS", "ASIGNADO")
        cmb_Status.AgregarItem("AC", "ACEPTADO POR CAJERO")
        cmb_Status.AgregarItem("IN", "INICIADO")
        cmb_Status.AgregarItem("BL", "BLOQUEADO")
        cmb_Status.AgregarItem("VE", "VERIFICADO")
        cmb_Status.AgregarItem("CO", "CONTABILIZADO")
        cmb_Status.AgregarItem("DB", "EN TRANSITO A BOVEDA")
        cmb_Status.AgregarItem("DV", "DEVUELTO A BOVEDA")
        cmb_Status.AgregarItem("RE", "RETENIDO")
        cmb_Status.AgregarItem("RB", "RETENIDO A BOVEDA")
        cmb_Status.AgregarItem("RR", "RETENIDO EN BOVEDA")
        cmb_Status.AgregarItem("DC", "DEVUELTO AL CLIENTE")

        cmb_Clientes.AgregaParametro("@Status", "T", 0)
        cmb_Clientes.Actualizar()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call LlenarLista()
    End Sub

    Private Sub LlenarLista()
        Call Limpiar()
        SegundosDesconexion = 0
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotaciones.Items.Count)
        lsv_Dotaciones.Items.Clear()
        btn_Exportar.Enabled = False
        If Validar() Then
            Dim TipoConsulta As Char
            Dim Corte As Integer

            If cbx_Corte.Checked Then Corte = 0 Else Corte = CInt(tbx_Corte.Text)
            TipoConsulta = "S"
            If Not fn_ConsultaDepositos_LlenarRemisiones(lsv_Dotaciones, cmb_CajaBancaria.SelectedValue, TipoConsulta, dtp_Desde.Value, dtp_Hasta.Value, _
                                                   cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Status.SelectedValue, _
                                                   Corte, cmb_Clientes.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            btn_Exportar.Enabled = lsv_Dotaciones.Items.Count > 0

            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotaciones.Items.Count)

            For Each Item As ListViewItem In lsv_Dotaciones.Items
                If Item.SubItems(11).Text = "BLOQUEADO" Then
                    Item.ForeColor = Color.Red
                End If
            Next
        End If
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
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
        If cmb_Status.SelectedValue = "0" And Not cbx_Status.Checked Then
            MsgBox("Debe seleccionar un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If (tbx_Corte.Text = "" Or (Not tbx_Corte.Text = "" AndAlso tbx_Corte.Text = 0)) And Not cbx_Corte.Checked Then
            MsgBox("Debe seleccionar un Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If cmb_Clientes.SelectedValue = "0" And Not cbx_Clientes.Checked Then
            MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If


        Return True
    End Function

    Sub Limpiar()
        SegundosDesconexion = 0
        Lbl_Registros.Text = "Registros: 0"
        Btn_Desbloquear.Visible = False
        lsv_Dotaciones.Items.Clear()
        btn_Exportar.Enabled = False
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        dtp_Hasta.MinDate = dtp_Desde.Value

        Call Limpiar()
    End Sub

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        Call Limpiar()
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

    Private Sub dtp_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress, dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(Chr(Keys.Tab))
            e.Handled = True
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

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub Tab_TipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Limpiar()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub tbx_Corte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Corte.TextChanged
        Call Limpiar()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub lsv_dotaciones_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.DoubleClick
        If lsv_Dotaciones.SelectedItems.Count > 0 Then
            Dim frm As New frm_FichasModal
            frm.Id_Remision = lsv_Dotaciones.SelectedItems(0).Tag

            frm.ShowDialog()
        End If
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Dotaciones, 2, "CONSULTA DE DEPOSITOS", 0, 1, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.SelectedIndexChanged
        SegundosDesconexion = 0
        Btn_Desbloquear.Visible = False
        If lsv_Dotaciones.SelectedItems.Count > 0 Then
            If lsv_Dotaciones.SelectedItems(0).SubItems(11).Text = "BLOQUEADO" Then
                Btn_Desbloquear.Visible = True
            End If
        End If
    End Sub

    Private Sub Btn_Desbloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Desbloquear.Click
        SegundosDesconexion = 0
        Btn_Desbloquear.Visible = False
        Me.Refresh()
        If Fn_ConsultaDepositos_Desbloqueo(lsv_Dotaciones.SelectedItems(0).SubItems(12).Text, "IN") = False Then
            MsgBox("Ocurio un Error al Intentar Desbloquear el Deposito", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call LlenarLista()
    End Sub

    Private Sub cbx_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Clientes.CheckedChanged
        Call Limpiar()
        cmb_Clientes.Enabled = Not cbx_Clientes.Checked
        txt_Clave.Enabled = Not cbx_Clientes.Checked
        If cbx_Clientes.Checked Then
            cmb_Clientes.SelectedValue = "0"
        End If
    End Sub

    Private Sub CopiarToolStripMenuItemCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItemCopiar.Click
        If lsv_Dotaciones.Items.Count <> 0 Then
            Dim remision As String = lsv_Dotaciones.SelectedItems(0).SubItems(0).Text
            Clipboard.SetText(remision)
        End If
    End Sub
End Class