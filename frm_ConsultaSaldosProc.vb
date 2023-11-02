Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ConsultaSaldosProc

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_ConsultaSaldosProc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Moneda.Actualizar()
        cmb_CajaBancaria.Actualizar()
        '----
        cmb_Cajero.AgregaParametro("@Status", "A", 0)
        cmb_Cajero.Actualizar()

        lsv_Billetes.Columns.Add("Denominacion", 100)
        lsv_Billetes.Columns.Add("Cantidad", 150, HorizontalAlignment.Right)
        lsv_Billetes.Columns.Add("Importe", 100, HorizontalAlignment.Right)

        lsv_Monedas.Columns.Add("Denominacion", 100)
        lsv_Monedas.Columns.Add("Cantidad", 150, HorizontalAlignment.Right)
        lsv_Monedas.Columns.Add("Importe", 100, HorizontalAlignment.Right)

        lsv_BillPro.Columns.Add("Denominacion", 100)
        lsv_BillPro.Columns.Add("Cantidad", 150, HorizontalAlignment.Right)
        lsv_BillPro.Columns.Add("Importe", 100, HorizontalAlignment.Right)

        lsv_MonPro.Columns.Add("Denominacion", 100)
        lsv_MonPro.Columns.Add("Cantidad", 150, HorizontalAlignment.Right)
        lsv_MonPro.Columns.Add("Importe", 100, HorizontalAlignment.Right)

        lsv_BillCla.Columns.Add("Denominacion", 100)
        lsv_BillCla.Columns.Add("Cantidad", 150, HorizontalAlignment.Right)
        lsv_BillCla.Columns.Add("Importe", 100, HorizontalAlignment.Right)

        lsv_SaldoBilletes.Columns.Add("Denominacion", 100)
        lsv_SaldoBilletes.Columns.Add("Cantidad", 150, HorizontalAlignment.Right)
        lsv_SaldoBilletes.Columns.Add("Importe", 100, HorizontalAlignment.Right)

        lsv_SaldoMonedas.Columns.Add("Denominacion", 100)
        lsv_SaldoMonedas.Columns.Add("Cantidad", 150, HorizontalAlignment.Right)
        lsv_SaldoMonedas.Columns.Add("Importe", 100, HorizontalAlignment.Right)

    End Sub

    Private Sub LlenaListas()

        If Not fn_ConsultaSaldos_LlenarLista(lsv_Billetes, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, "B", cmb_Cajero.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la Lista de Billetes Verificados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call TotalListas(lsv_Billetes, tbx_TotalB)

        If Not fn_ConsultaSaldos_LlenarLista(lsv_Monedas, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, "M", cmb_Cajero.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la Lista de Monedas Verificadas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call TotalListas(lsv_Monedas, tbx_TotalM)

        '---
        If Not fn_ConsultaSaldosEnvios_LlenarLista(lsv_BillPro, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, "B", 26, cmb_Cajero.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la Lista de Billetes Enviados a Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call TotalListas(lsv_BillPro, tbx_TotBillPro)

        If Not fn_ConsultaSaldosEnvios_LlenarLista(lsv_MonPro, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, "M", 26, cmb_Cajero.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la Lista de Monedas Enviados a Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call TotalListas(lsv_MonPro, tbx_TotMonPro)

        If Not fn_ConsultaSaldosEnvios_LlenarLista(lsv_BillCla, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, "B", 27, cmb_Cajero.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la Lista de Billetes Enviados a Clasificado.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Call TotalListas(lsv_BillCla, tbx_TotBillCla)
        '----------

        If Not fn_ConsultaSaldosEfectivo_LlenaLista(CInt(cmb_CajaBancaria.SelectedValue), CInt(cmb_Moneda.SelectedValue), "B", lsv_SaldoBilletes, cmb_Cajero.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la Lista de Saldo Billetes", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call TotalListas(lsv_SaldoBilletes, tbx_TotSaldoB)

        If Not fn_ConsultaSaldosEfectivo_LlenaLista(CInt(cmb_CajaBancaria.SelectedValue), CInt(cmb_Moneda.SelectedValue), "M", lsv_SaldoMonedas, cmb_Cajero.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la Lista de Saldo Monedas", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call TotalListas(lsv_SaldoMonedas, tbx_TotSaldoM)

        Cn_Login.fn_Log_Create("CONSULTA DE SALDOS: " & cmb_CajaBancaria.Text & " - " & cmb_Moneda.Text)

    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Moneda_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        If Not Validar() Then Exit Sub

        Call LimpiarListas()
        Call LlenaListas()
    End Sub

    Private Sub TotalListas(ByVal Lsv As cp_Listview, ByVal TotalLista As TextBox)
        Dim Total As Decimal

        If Not IsNumeric(TotalLista.Text) Then TotalLista.Text = Format(0, "n2")

        For Each item As ListViewItem In Lsv.Items
            Total += item.SubItems(2).Text
        Next

        TotalLista.Text = Format(CDec(Total), "n2")

    End Sub

    Private Sub LimpiarListas()
        lsv_Billetes.Items.Clear()
        lsv_BillPro.Items.Clear()
        lsv_BillCla.Items.Clear()
        lsv_Monedas.Items.Clear()
        lsv_MonPro.Items.Clear()
        lsv_SaldoBilletes.Items.Clear()
        lsv_SaldoMonedas.Items.Clear()
    End Sub

    Private Function Validar() As Boolean
        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Seleccione una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If cmb_Cajero.SelectedValue = 0 Then
            MsgBox("Seleccione una Cajero Verificador.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If cmb_Moneda.SelectedValue = 0 Then
            MsgBox("Seleccione una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If

        Return True
    End Function
End Class