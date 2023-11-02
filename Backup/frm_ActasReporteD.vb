Public Class frm_ActasReporteD
    Public Id_Remision As Integer

    Private Sub frm_DetallesActaDiferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Remisiones.Columns.Add("Moneda")
        lsv_Remisiones.Columns.Add("Efectivo")
        lsv_Remisiones.Columns.Add("Documentos")
        lsv_Remisiones.Columns.Add("Tipo Cambio")

        lsv_Fichas.Columns.Add("Ficha")
        lsv_Fichas.Columns.Add("Efectivo")
        lsv_Fichas.Columns.Add("Documentos")
        lsv_Fichas.Columns.Add("Otros")

        lsv_Desglose.Columns.Add("Presentación")
        lsv_Desglose.Columns.Add("Denominación")
        lsv_Desglose.Columns.Add("Cantidad")
        lsv_Desglose.Columns.Add("Importe")


        lsv_TotFichas.Columns.Add("Denominación")
        lsv_TotFichas.Columns.Add("Importe")
        lsv_TotFichas.Columns.Add("Cantidad")

        If Not Cn_Proceso.fn_DetalleRemisionLlenalista(lsv_Remisiones, Id_Remision) Then
            MsgBox("Ocurrio un error al Llenar la lista de Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not Cn_Proceso.fn_FichasLlenalista(lsv_Fichas, Id_Remision) Then
            MsgBox("Ocurrio un error al Llenar la lista de Fichas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not Cn_Proceso.fn_FichasTotalesLlenalista(lsv_TotFichas, Id_Remision) Then
            MsgBox("Ocurrio un error al Llenar la lista del Total de Fichas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call TotalRemision()
        'Call SumarFichas()
        Call TotalFichas()
        Call TotalFichasGeneral()

    End Sub

    Private Sub lsv_Fichas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.SelectedIndexChanged

        If lsv_Fichas.SelectedItems().Count = 0 Then
            lsv_Desglose.Items.Clear()
            lbl_TotFicha.Text = "$0.00"
            lbl_NumeroFicha.Text = "0"
            Exit Sub
        End If

        If Not Cn_Proceso.fn_FichasDetalleLlenalista(lsv_Desglose, lsv_Fichas.SelectedItems(0).Tag) Then
            MsgBox("Ocurrio un error al Llenar los detalles de la Ficha.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        lbl_NumeroFicha.Text = lsv_Fichas.SelectedItems(0).SubItems(0).Text
        lbl_TotalFichas.Text = lsv_Fichas.SelectedItems(0).SubItems(3).Text
        Call TotalFichas()

    End Sub

    'Sub SumarFichas()
    '    Dim Total As Decimal
    '    For Each Importe As ListViewItem In lsv_Fichas.Items
    '        Total += (CDec(Importe.SubItems(3).Text) + CDec(Importe.SubItems(4).Text) + CDec(Importe.SubItems(5).Text))
    '    Next
    '    lbl_TotalFichas.Text = FormatCurrency(Total)
    'End Sub

    Sub TotalRemision()
        lsv_Remisiones.Columns.Add("Total", 200)
        lsv_Remisiones.Columns(4).TextAlign = HorizontalAlignment.Right
        For Each Importe As ListViewItem In lsv_Remisiones.Items
            Importe.SubItems.Add(Format(Format(((CDec(Importe.SubItems(1).Text) + CDec(Importe.SubItems(2).Text)) * CDec(Importe.SubItems(3).Text)), "##,##0.00")))
        Next
    End Sub

    Sub TotalFichas()
        Dim Total As Decimal
        For Each Importe As ListViewItem In lsv_Desglose.Items
            Total += (CDec(Importe.SubItems(2).Text))
        Next
        lbl_TotFicha.Text = FormatCurrency(Total)
    End Sub

    Sub TotalFichasGeneral()
        Dim Total As Decimal
        For Each Importe As ListViewItem In lsv_TotFichas.Items
            Total += (CDec(Importe.SubItems(1).Text))
        Next
        lbl_TotFichaGeneral.Text = FormatCurrency(Total)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub lsv_Fichas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.DoubleClick
        Dim frm As New frm_FichasDesglose
        frm.Id_Ficha = lsv_Fichas.SelectedItems(0).Tag
        frm.ShowDialog()
    End Sub
End Class