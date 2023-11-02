Imports Modulo_Proceso.Cn_Proceso
Public Class frm_ProcesoSaldos
    Private Sub frm_ProcesoSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Cajeros.Columns.Add("Cajero")
        lsv_Cajeros.Columns.Add("Nombre")
        lsv_Cajeros.Columns.Add("Remisiones", HorizontalAlignment.Right)
        lsv_Cajeros.Columns.Add("Envases", HorizontalAlignment.Right)
        lsv_Cajeros.Columns.Add("Importe", HorizontalAlignment.Right)

        lsv_Detalles.Columns.Add("Caja")
        lsv_Detalles.Columns.Add("Cliente")
        lsv_Detalles.Columns.Add("Compañia")
        lsv_Detalles.Columns.Add("Envases", HorizontalAlignment.Right)
        lsv_Detalles.Columns.Add("Importe", HorizontalAlignment.Right)

        Call CargarListas()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CargarListas()
    End Sub

    Sub CargarListas()
        Call fn_MonitoreoSaldo_CajerosProceso(lsv_Cajeros)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Cajeros.Items.Count)
        Dim Total As Decimal
        For Each J As ListViewItem In lsv_Cajeros.Items
            If Total = 0 Then
                Total = CDec(J.SubItems(4).Text)
            Else
                Total += CDec(J.SubItems(4).Text)
            End If
        Next
        Lbl_Sumatoria.Text = "Total: " & FormatCurrency(Total, 2)
    End Sub

    Private Sub lsv_Cajeros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cajeros.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        If lsv_Cajeros.SelectedItems.Count > 0 Then
            Call fn_MonitoreoSaldo_CajerosDetalle(lsv_Detalles, lsv_Cajeros.SelectedItems(0).Tag)
            FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Detalles.Items.Count)
            Dim Total As Decimal
            For Each J As ListViewItem In lsv_Detalles.Items
                If Total = 0 Then
                    Total = CDec(J.SubItems(5).Text)
                Else
                    Total += CDec(J.SubItems(5).Text)
                End If
            Next
            Lbl_SumatoriaR.Text = "Total por Cajero: " & FormatCurrency(Total, 2)
            FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Detalles.Items.Count)
        End If
        If lsv_Cajeros.SelectedItems.Count <= 0 Then
            lsv_Detalles.Items.Clear()
            FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Detalles.Items.Count)
            Lbl_SumatoriaR.Text = "Total por Cajero: 0"
            Cursor = Cursors.Default
            Exit Sub
        End If

        Cursor = Cursors.Default
    End Sub

End Class