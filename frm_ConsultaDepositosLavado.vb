Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ConsultaDepositosLavado

    Private Sub frm_ConsultaDepositosLavado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 And Tab_TipoConsulta.Focused Then SendKeys.Send(Chr(Keys.Tab))
        If Asc(e.KeyChar) = 13 And cbx_Corte.Focused Then SendKeys.Send(Chr(Keys.Tab))
    End Sub

    Private Sub frm_ConsultaDepositosLavado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Depositos.Columns.Add("Remision")
        lsv_Depositos.Columns.Add("Cia")
        lsv_Depositos.Columns.Add("EntradaProceso")
        lsv_Depositos.Columns.Add("Sesion")
        lsv_Depositos.Columns.Add("Caja")
        lsv_Depositos.Columns.Add("Cliente")
        lsv_Depositos.Columns.Add("Importe")
        lsv_Depositos.Columns.Add("Diferencia")
        lsv_Depositos.Columns.Add("Cajero")


        cmb_CajaBancaria.Actualizar()
        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()

        Tab_TipoConsulta.SelectedTab = Tab_Sesion
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
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Depositos.Items.Count)
        lsv_Depositos.Items.Clear()
        btn_Exportar.Enabled = False
        If Validar() Then
            Dim TipoConsulta As Char
            Dim Corte As Integer

            If cbx_Corte.Checked Then Corte = 0 Else Corte = CInt(tbx_Corte.Text)
            If Tab_TipoConsulta.SelectedTab Is Tab_Fecha Then TipoConsulta = "F" Else TipoConsulta = "S"
            If Not fn_ConsultaDepositos_LlenarProcesado(lsv_Depositos, cmb_CajaBancaria.SelectedValue, TipoConsulta, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, _
                                                   cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, Corte) Then
                MsgBox("Ha ocurrido un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            btn_Exportar.Enabled = lsv_Depositos.Items.Count > 0

            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Depositos.Items.Count)

            
        End If
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If (tbx_Corte.Text = "" Or (Not tbx_Corte.Text = "" AndAlso tbx_Corte.Text = 0)) And Not cbx_Corte.Checked Then
            MsgBox("Debe seleccionar un Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If Tab_TipoConsulta.SelectedTab Is Tab_Sesion And cmb_Desde.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesion Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If Tab_TipoConsulta.SelectedTab Is Tab_Sesion And cmb_Hasta.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesion Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        Return True
    End Function

    Sub Limpiar()
        Lbl_Registros.Text = "Registros: 0"
        SegundosDesconexion = 0
        lsv_Depositos.Items.Clear()
        btn_Exportar.Enabled = False
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        dtp_Hasta.MinDate = dtp_Desde.Value

        Call Limpiar()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress, dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(Chr(Keys.Tab))
            e.Handled = True
        End If
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Hasta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedIndexChanged

    End Sub

    Private Sub cbx_Corte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Corte.CheckedChanged
        Call Limpiar()
        tbx_Corte.Enabled = Not cbx_Corte.Checked
        If cbx_Corte.Checked Then
            tbx_Corte.Text = ""
        End If
    End Sub

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        Call Limpiar()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Desde.SelectedValue = cmb_Hasta.SelectedValue
        End If
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        Call Limpiar()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Hasta.SelectedValue = cmb_Desde.SelectedValue
        End If
    End Sub

    Private Sub tbx_Corte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Corte.TextChanged
        Call Limpiar()
    End Sub

    Private Sub Tab_TipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_TipoConsulta.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Depositos, 2, "CONSULTA DE DEPOSITOS(IMPORTE PROCESADO)", 0, 0, frm_MENU.prg_Barra)
    End Sub
End Class