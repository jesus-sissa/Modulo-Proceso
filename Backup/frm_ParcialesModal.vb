Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ParcialesModal
    Public Id_Parcial As Integer

    Private Sub frm_FichasModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not fn_DesgloseModal_LlenarEfectivoParcial(lsv_Fichas, Id_Parcial) Then
            MsgBox("Ha ocurrido un error al intentar obtener el efectivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Fichas.Items.Count > 0 Then Call TotalizarParciales()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub lsv_Fichas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Sub TotalizarParciales()
        Dim Total As Decimal
        For Each Denominacion As ListViewItem In lsv_Fichas.Items
            Total += CDec(Denominacion.SubItems(3).Text)
        Next

        lsv_Fichas.Items.Add("")
        lsv_Fichas.Items(lsv_Fichas.Items.Count - 1).SubItems.Add("")
        lsv_Fichas.Items(lsv_Fichas.Items.Count - 1).SubItems.Add("")
        lsv_Fichas.Items(lsv_Fichas.Items.Count - 1).SubItems.Add("Total: " & FormatCurrency(Total))
        lsv_Fichas.Items(lsv_Fichas.Items.Count - 1).Font = New Font(lsv_Fichas.Items(lsv_Fichas.Items.Count - 1).Font, FontStyle.Bold)

        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Fichas.Items.Count - 1)
    End Sub

End Class