Imports Modulo_Proceso.Cn_Proceso
Imports Modulo_Proceso.FuncionesGlobales

Public Class frm_FichasModal

    Public Id_Remision As Integer
    Dim TotalEfectivo As Decimal = 0.0
    Dim TotalCheques As Decimal = 0.0
    Dim TotalOtros As Decimal = 0.0
    Dim DifEfectivo As Decimal = 0.0
    Dim DifCheques As Decimal = 0.0
    Dim DifOtros As Decimal = 0.0

    Private Sub frm_FichasModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not fn_FichasModal_LlenarLista(lsv_Fichas, Id_Remision) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call CalcularTotales()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Fichas.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Fichas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.DoubleClick
        SegundosDesconexion = 0

        Dim frm As New frm_FichasDesglose
        frm.Id_Ficha = lsv_Fichas.SelectedItems(0).Tag
        frm.ShowDialog()

    End Sub

    Private Sub lsv_Fichas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.MouseHover
        SegundosDesconexion = 0
    End Sub

    Sub CalcularTotales()
        For Each Ficha As ListViewItem In lsv_Fichas.Items
            TotalEfectivo += CDec(Ficha.SubItems(3).Text)
            TotalCheques += CDec(Ficha.SubItems(4).Text)
            TotalOtros += CDec(Ficha.SubItems(5).Text)
            DifEfectivo += CDec(Ficha.SubItems(6).Text)
            DifCheques += CDec(Ficha.SubItems(7).Text)
            DifOtros += CDec(Ficha.SubItems(8).Text)
        Next
        tbx_TotEfectivo.Text = FormatCurrency(TotalEfectivo)
        tbx_TotCheques.Text = FormatCurrency(TotalCheques)
        tbx_TotOtros.Text = FormatCurrency(TotalOtros)
        tbx_DifEfectivo.Text = FormatCurrency(DifEfectivo)
        tbx_DifCheques.Text = FormatCurrency(DifCheques)
        tbx_DifOtros.Text = FormatCurrency(DifOtros)
    End Sub

End Class