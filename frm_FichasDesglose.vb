Imports Modulo_Proceso.Cn_Proceso

Public Class frm_FichasDesglose
    Public Id_Ficha As Integer = 0

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_DesgloseModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not fn_DesgloseModal_LlenarEfectivoFicha(lsv_Efectivo, Id_Ficha) Then
            MsgBox("Ha ocurrido un error al intentar obtener el Efectivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Efectivo.Items.Count > 0 Then
            Call AgregarTotalEfectivo()
            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Efectivo.Items.Count - 1)
        End If


        If Not fn_DesgloseModal_LlenarChequesFicha(lsv_Cheques, Id_Ficha) Then
            MsgBox("Ha ocurrido un error al intentar obtener los Cheques.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Cheques.Items.Count > 0 Then
            Call AgregarTotalCheques()
            FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Cheques.Items.Count - 1)
        End If

        If Not fn_DesgloseModal_LlenarOtrosFicha(lsv_Otros, Id_Ficha) Then
            MsgBox("Ha ocurrido un error al intentar obtener los Documentos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Otros.Items.Count > 0 Then
            Call AgregarTotalOtros()
            FuncionesGlobales.RegistrosNum(Lbl_Registros2, lsv_Otros.Items.Count - 1)
        End If

        If Not fn_ParcialesModal_LlenarLista(lsv_Parciales, Id_Ficha) Then
            MsgBox("Ha ocurrido un error al intentar obtener los Parciales.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Parciales.Items.Count > 0 Then
            Call AgregarTotalParciales()
            FuncionesGlobales.RegistrosNum(Lbl_Registros3, lsv_Parciales.Items.Count - 1)
        End If

    End Sub

    Private Sub lsv_Parciales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Parciales.DoubleClick
        If lsv_Parciales.SelectedItems.Count > 0 Then
            Dim frm As New frm_ParcialesModal
            frm.Id_Parcial = lsv_Parciales.SelectedItems(0).Tag

            frm.ShowDialog()
        End If
    End Sub

    Private Sub lsv_Efectivo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Efectivo.MouseHover, lsv_Cheques.MouseHover, lsv_Otros.MouseHover, lsv_Parciales.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub Tab_Desglose_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Desglose.SelectedIndexChanged
        SegundosDesconexion = 0
    End Sub

    Sub AgregarTotalEfectivo()
        lsv_Efectivo.Items.Add("")
        lsv_Efectivo.Items(lsv_Efectivo.Items.Count - 1).SubItems.Add("")
        lsv_Efectivo.Items(lsv_Efectivo.Items.Count - 1).SubItems.Add("")
        lsv_Efectivo.Items(lsv_Efectivo.Items.Count - 1).SubItems.Add("Total: " & FormatCurrency(Totalizar(3, lsv_Efectivo)))
        lsv_Efectivo.Items(lsv_Efectivo.Items.Count - 1).Font = New Font(lsv_Efectivo.Items(lsv_Efectivo.Items.Count - 1).Font, FontStyle.Bold)

    End Sub

    Sub AgregarTotalCheques()
        lsv_Cheques.Items.Add("")
        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add("")
        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add("Total: " & FormatCurrency(Totalizar(2, lsv_Cheques)))
        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add("")
        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).Font = New Font(lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).Font, FontStyle.Bold)

    End Sub

    Sub AgregarTotalOtros()
        lsv_Otros.Items.Add("")
        lsv_Otros.Items(lsv_Otros.Items.Count - 1).SubItems.Add("Total: " & FormatCurrency(Totalizar(1, lsv_Otros)))
        lsv_Otros.Items(lsv_Otros.Items.Count - 1).SubItems.Add("")
        lsv_Otros.Items(lsv_Otros.Items.Count - 1).Font = New Font(lsv_Otros.Items(lsv_Otros.Items.Count - 1).Font, FontStyle.Bold)

    End Sub

    Sub AgregarTotalParciales()
        lsv_Parciales.Items.Add("")
        lsv_Parciales.Items(lsv_Parciales.Items.Count - 1).SubItems.Add("")
        lsv_Parciales.Items(lsv_Parciales.Items.Count - 1).SubItems.Add("")
        lsv_Parciales.Items(lsv_Parciales.Items.Count - 1).SubItems.Add("Total: " & FormatCurrency(Totalizar(3, lsv_Parciales)))
        lsv_Parciales.Items(lsv_Parciales.Items.Count - 1).SubItems.Add("")
        lsv_Parciales.Items(lsv_Parciales.Items.Count - 1).Font = New Font(lsv_Parciales.Items(lsv_Parciales.Items.Count - 1).Font, FontStyle.Bold)

    End Sub


    Private Function Totalizar(ByVal PosicionImporte As Integer, ByVal Lsv As cp_Listview) As Decimal
        Dim Total As Decimal
        For Each Importe As ListViewItem In Lsv.Items
            If Importe.SubItems(0).Text = "" Then Continue For
            Total += CDec(Importe.SubItems(PosicionImporte).Text)
        Next
        Return Total
    End Function


End Class