Imports System.Web.Security

Public Class frm_Usuarios

    Dim LvsU As New ListViewColumnSorter

    Private Sub frm_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Usuarios.Columns.Add("Clave")
        lsv_Usuarios.Columns.Add("Nombre")
        lsv_Usuarios.Columns.Add("Tipo")
        lsv_Usuarios.Columns.Add("Status")
        Call Consultar_Usuarios()
    End Sub

    Sub Consultar_Usuarios()
        'Cargar Lista de Usurios
        Cn_Proceso.fn_Usuarios_Consultar(lsv_Usuarios, LvsU)

        'Aqui se ajutan las filas del list view
        FuncionesGlobales.fn_Columna(lsv_Usuarios, 10, 35, 15, 20, 0, 0, 0, 0, 0, 0)

        'Aqui se declara el ordenador
        lsv_Usuarios.ListViewItemSorter = LvsU
        btn_Bloquear.Enabled = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Usuarios.Items.Count)
    End Sub

    Private Sub frm_Usuarios_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        FuncionesGlobales.fn_Columna(lsv_Usuarios, 10, 35, 15, 20, 0, 0, 0, 0, 0, 0)
    End Sub

    Private Sub lsv_Usuarios_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsv_Usuarios.ColumnClick
        'Aqui se reordenan las columnas del listview
        If e.Column = LvsU.SortColumn Then
            If LvsU.Order = Windows.Forms.SortOrder.Ascending Then
                LvsU.Order = Windows.Forms.SortOrder.Descending
            Else
                LvsU.Order = Windows.Forms.SortOrder.Ascending
            End If
        Else
            LvsU.SortColumn = e.Column
            LvsU.Order = Windows.Forms.SortOrder.Ascending
        End If
        lsv_Usuarios.Sort()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Usuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Usuarios.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Bloquear.Enabled = False
        If lsv_Usuarios.SelectedItems.Count = 0 Then Exit Sub
        btn_Bloquear.Enabled = True
    End Sub

    Private Sub btn_Bloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bloquear.Click
        SegundosDesconexion = 0

        If lsv_Usuarios.SelectedItems.Count = 0 Then Exit Sub
        If lsv_Usuarios.SelectedItems(0).SubItems(3).Text = "BLOQUEADO" Then
            Cn_Proceso.fn_Usuarios_Bloquear(lsv_Usuarios.SelectedItems(0).Tag, "A")
        End If
        Call Consultar_Usuarios()
    End Sub

    Private Sub lsv_Usuarios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Usuarios.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class