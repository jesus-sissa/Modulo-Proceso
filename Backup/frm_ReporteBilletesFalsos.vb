Public Class frm_ReporteBilletesFalsos

    Private Sub frm_ReporteBilletesFalsos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Servicios.Columns.Add("Remision")
        lsv_Servicios.Columns.Add("Cia")
        lsv_Servicios.Columns.Add("Fecha")
        lsv_Servicios.Columns.Add("Sesion")
        lsv_Servicios.Columns.Add("Caja")
        lsv_Servicios.Columns.Add("Cliente")
        lsv_Servicios.Columns.Add("Fichas")
        lsv_Servicios.Columns.Add("Importe")
        lsv_Servicios.Columns.Add("Envases")
        lsv_Servicios.Columns.Add("Envases SN")
        lsv_Servicios.Columns.Add("Cajero")

        lsv_Fichas.Columns.Add("Ficha")
        lsv_Fichas.Columns.Add("Moneda")
        lsv_Fichas.Columns.Add("Tipo")
        lsv_Fichas.Columns.Add("Efectivo")
        lsv_Fichas.Columns.Add("Cheques")
        lsv_Fichas.Columns.Add("Otros")
        lsv_Fichas.Columns.Add("Dif. Efectivo")
        lsv_Fichas.Columns.Add("Dif. Cheques")
        lsv_Fichas.Columns.Add("Dif. Otros")
        lsv_Fichas.Columns.Add("Falsos")

        lsv_Efectivo.Columns.Add("Presentación")
        lsv_Efectivo.Columns.Add("Denominación")
        lsv_Efectivo.Columns.Add("Cantidad")
        lsv_Efectivo.Columns.Add("Importe")


        lsv_Falsos.Columns.Add("Denominación")
        lsv_Falsos.Columns.Add("Cantidad")
        lsv_Falsos.Columns.Add("Importe")

        cmb_CajaBancaria.Actualizar()
        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()

        Tab_TipoConsulta.SelectedTab = Tab_Sesion

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call LlenarLista()
    End Sub

    Private Sub lsv_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0
        If lsv_Servicios.SelectedItems.Count = 0 Then
            lsv_Fichas.Items.Clear()
            lsv_Efectivo.Items.Clear()
            lsv_Falsos.Items.Clear()
            Exit Sub
        End If

        If Not Cn_Proceso.fn_Fichas_LlenarLista(lsv_Fichas, lsv_Servicios.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar consultar las Fichas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub lsv_Fichas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.SelectedIndexChanged
        SegundosDesconexion = 0
        If lsv_Fichas.SelectedItems.Count = 0 Then
            lsv_Efectivo.Items.Clear()
            lsv_Falsos.Items.Clear()
            Exit Sub
        End If

        If Not Cn_Proceso.fn_Fichas_Efectivo(lsv_Efectivo, lsv_Fichas.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar consultar los Desgloses.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not Cn_Proceso.fn_Fichas_EfectivoFalso(lsv_Falsos, lsv_Fichas.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar consultar los Billetes Falsos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub Tab_TipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_TipoConsulta.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call Limpiar()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call Limpiar()
    End Sub

    Private Sub cbx_Corte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Corte.CheckedChanged
        tbx_Corte.Enabled = cbx_Corte.Checked = False
    End Sub

    Private Sub LlenarLista()
        Call Limpiar()
        SegundosDesconexion = 0
        FuncionesGlobales.RegistrosNum(lbl_Total_Servicios, lsv_Servicios.Items.Count)

        If Validar() Then
            Dim TipoConsulta As Char
            Dim Corte As Integer
            If cbx_Corte.Checked Then Corte = 0 Else Corte = CInt(tbx_Corte.Text)
            If Tab_TipoConsulta.SelectedTab Is Tab_Fecha Then TipoConsulta = "F" Else TipoConsulta = "S"
            If Not Cn_Proceso.fn_ConsultaDepositos_BilletesFalsos(lsv_Servicios, cmb_CajaBancaria.SelectedValue, TipoConsulta, dtp_Desde.Value, dtp_Hasta.Value, _
                                                   cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, Corte) Then
                MsgBox("Ha ocurrido un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            FuncionesGlobales.RegistrosNum(lbl_Total_Servicios, lsv_Servicios.Items.Count)
        End If
    End Sub

    Private Sub Limpiar()
        SegundosDesconexion = 0
        FuncionesGlobales.RegistrosNum(lbl_Total_Servicios, lsv_Servicios.Items.Count)
        lsv_Servicios.Items.Clear()
        lsv_Fichas.Items.Clear()
        lsv_Efectivo.Items.Clear()
        lsv_Falsos.Items.Clear()
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If (tbx_Corte.Text = "" Or (Not tbx_Corte.Text = "" AndAlso tbx_Corte.Text = 0)) And Not cbx_Corte.Checked Then
            MsgBox("Debe seleccionar un Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Corte.Focus()
            Return False
        End If

        If Tab_TipoConsulta.SelectedTab Is Tab_Sesion And cmb_Desde.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesion Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Return False
        End If

        If Tab_TipoConsulta.SelectedTab Is Tab_Sesion And cmb_Hasta.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesion Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Hasta.Focus()
            Return False
        End If

        Return True
    End Function

End Class