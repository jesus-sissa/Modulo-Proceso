Imports Modulo_Proceso.Cn_Proceso

Public Class frm_SaldoCuadre
    Dim SumaA As Decimal
    Dim SumaN As Decimal
    Dim Diff As Decimal

    Private Sub frm_SaldoModif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        cmb_CajaBancaria.Actualizar()
        cmb_Moneda.Actualizar()

        cmb_Presentacion.AgregarItem("B", "BILLETES")
        cmb_Presentacion.AgregarItem("M", "MONEDA")
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click

        If cmb_CajaBancaria.SelectedIndex = 0 Then
            MsgBox("Indique Una Caja Bancaria", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Moneda.SelectedIndex = 0 Then
            MsgBox("Indique Una Moneda", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Presentacion.SelectedIndex = 0 And Chk_Todas.Checked = False Then
            MsgBox("Indique Una Presentacion", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call LlenarLista()

    End Sub

    Private Sub LlenarLista()
        SegundosDesconexion = 0
        Dgv_Saldo.DataSource = Nothing
        Dgv_Saldo.Columns.Clear()

        Dim Dt_Saldos As DataTable = fn_SaldoCuadre_LlenarLista(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue, IIf(Chk_Todas.Checked, "T", cmb_Presentacion.SelectedValue))
        Dim Fila As Integer = 0

        If Dt_Saldos Is Nothing Then
            MsgBox("Error Al Cargar La Informacion", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dt_Saldos.Columns(5).ReadOnly = False
        Dt_Saldos.Columns(6).ReadOnly = False
        Dt_Saldos.Columns(7).ReadOnly = False
        Dt_Saldos.Columns(8).ReadOnly = False
        Dt_Saldos.Columns(9).ReadOnly = False
        Dt_Saldos.Columns(10).ReadOnly = False
        Dt_Saldos.Columns(11).ReadOnly = False
        Dt_Saldos.Columns(12).ReadOnly = False

        SumaA = 0
        SumaN = 0
        Diff = 0

        Dgv_Saldo.DataSource = Dt_Saldos

        For Each Row As DataRow In Dt_Saldos.Rows
            If Fila <> Dt_Saldos.Rows.Count Then
                Dgv_Saldo.Rows(Fila).Cells(2).Tag = Dgv_Saldo.Rows(Fila).Cells(0).Value
                Dgv_Saldo.Rows(Fila).Cells(11).Value = CDec((Row("Cantidad")) + CDec(Row("CantidadA")) + CDec(Row("CantidadB")) + CDec(Row("CantidadC")) + CDec(Row("CantidadD")) + CDec(Row("CantidadE")))
                Dgv_Saldo.Rows(Fila).Cells(12).Value = FormatCurrency(CDec(Row("Suma") * CDec(Row("Denominacion"))), 2, )

                SumaA += CInt(Dgv_Saldo.Rows(Fila).Cells(4).Value)
                SumaN += CInt(Dgv_Saldo.Rows(Fila).Cells(12).Value)

                If Row("Presentacion") = "MONEDA" Then
                    Dgv_Saldo.Rows(Fila).Cells(6).ReadOnly = True
                    Dgv_Saldo.Rows(Fila).Cells(7).ReadOnly = True
                    Dgv_Saldo.Rows(Fila).Cells(8).ReadOnly = True
                    Dgv_Saldo.Rows(Fila).Cells(9).ReadOnly = True
                    Dgv_Saldo.Rows(Fila).Cells(10).ReadOnly = True
                End If
                Fila += 1
            End If
        Next

        lbl_Total.Text = "Importe Anterior Total: " & FormatNumber(SumaA, 2, TriState.True)
        lbl_Total1.Text = "Importe Nuevo Total: " & FormatNumber(SumaN, 2, TriState.True)

        Diff = SumaN - SumaA

        Dgv_Saldo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_Saldo.RowHeadersWidth = 30

        lbl_Diferencia.Text = "Diferencia: " & FormatNumber(Diff, 2, TriState.True)

        Dgv_Saldo.Columns(11).ReadOnly = True
        Dgv_Saldo.Columns(12).ReadOnly = True
        Dgv_Saldo.Columns(0).Visible = False
        btn_Guardar.Enabled = True
        Dgv_Saldo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

    End Sub

    Private Sub LimpiarLista()
        SegundosDesconexion = 0
        If Dgv_Saldo.DataSource IsNot Nothing Then
            CType(Dgv_Saldo.DataSource, DataTable).Clear()
        End If
        btn_Guardar.Enabled = False
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_Presentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Presentacion.SelectedIndexChanged
        Call LimpiarLista()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        Dim Fila As Integer = 0

        If Dgv_Saldo Is Nothing Then
            MsgBox("No Hay Informacion Para Guardar", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Diff <> 0 Then
            MsgBox("EL Nuevo Importe No Councuerda Con El Anterior", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If fn_SaldoCuadre_UpdateCompleto(cmb_CajaBancaria.SelectedValue, Dgv_Saldo) Then
            Call LlenarLista()
        End If

    End Sub

    Private Sub Dgv_Saldo_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Saldo.CellEndEdit
        SegundosDesconexion = 0
        Dim Fila As Integer = 0
        SumaN = 0

        For Each Row As DataGridViewRow In Dgv_Saldo.Rows
            Row.Cells(11).Value = CDec(Row.Cells(5).Value) + CDec(Row.Cells(6).Value) + CDec(Row.Cells(7).Value) + _
                CDec(Row.Cells(8).Value) + CDec(Row.Cells(9).Value) + CDec(Row.Cells(10).Value)
            Row.Cells(12).Value = FormatCurrency(CDec(Row.Cells(11).Value) * CDec(Row.Cells(2).Value))
            SumaN += CInt(Row.Cells(12).Value)
        Next
        lbl_Total1.Text = "Importe Nuevo Total: " & FormatNumber(CDec(SumaN), 2, TriState.True)
        Diff = SumaN - SumaA
        lbl_Diferencia.Text = "Diferencia: " & FormatNumber(Diff, 2, TriState.True)
        Dgv_Saldo.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = FormatNumber(CInt(Dgv_Saldo.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString), 0, TriState.True)

        If Dgv_Saldo.Rows(e.RowIndex).Cells(5).Value < 0 Or Dgv_Saldo.Rows(e.RowIndex).Cells(6).Value < 0 Or _
        Dgv_Saldo.Rows(e.RowIndex).Cells(7).Value < 0 Or Dgv_Saldo.Rows(e.RowIndex).Cells(8).Value < 0 Or _
        Dgv_Saldo.Rows(e.RowIndex).Cells(9).Value < 0 Or Dgv_Saldo.Rows(e.RowIndex).Cells(10).Value < 0 Then

            Dgv_Saldo.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Coral
            Exit Sub
        Else
            Dgv_Saldo.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub Dgv_Saldo_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles Dgv_Saldo.CellValidating
        If e.ColumnIndex <> 1 Then
            e.Cancel = (Not IsNumeric(e.FormattedValue)) OrElse (CSng(e.FormattedValue) < 0)
        End If
    End Sub

    Private Sub Chk_Todas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Todas.CheckedChanged
        Call LimpiarLista()
        cmb_Presentacion.SelectedValue = "0"
        cmb_Presentacion.Enabled = Not Chk_Todas.Checked
    End Sub
End Class