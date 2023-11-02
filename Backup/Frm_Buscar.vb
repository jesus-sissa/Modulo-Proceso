Imports Modulo_Proceso.FuncionesGlobales
Imports Modulo_Proceso.Cn_Proceso

Public Class Frm_Buscar

    Public Clave As String
    Public Source As DataTable
    Public Pk As String
    Public Hide() As String = Nothing
    Public CampoClave As String = ""


    Private Sub Frm_BuscarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Clientes.Actualizar(Source, Pk, Hide)
        tbx_Buscar.Focus()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Clientes.Items.Count)
    End Sub

    Private Sub lsv_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Clientes.DoubleClick
        SegundosDesconexion = 0

        Clave = Source.Rows(lsv_Clientes.SelectedItems(0).Index).Item(CampoClave)
        Me.Close()
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Clientes.SelectedItems.Count > 0 Then Clave = Source.Rows(lsv_Clientes.SelectedItems(0).Index).Item(CampoClave)
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 And lsv_Clientes.SelectedItems.Count > 0 Then Me.Close()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged

        Dim Fila_Inicial As Integer = 0
        If lsv_Clientes.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Clientes.SelectedItems(0).Index + 1
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub


    Private Sub lsv_Clientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class