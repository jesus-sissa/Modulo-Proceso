Imports System.Data.SqlClient

Public Class frm_MaterialesInventario

    Dim _Departamento As Dpto

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_Inv_Materiales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Aqui se llena la lista
        Cn_Proceso.fn_InventarioMateriales_LlenarLista(lsv_Catalogo, _Departamento)

        lsv_Catalogo.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_Catalogo.Columns(3).TextAlign = HorizontalAlignment.Right
        lsv_Catalogo.Columns(4).TextAlign = HorizontalAlignment.Right

        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)

    End Sub

    Private Sub lsv_Catalogo_AlActualizar() Handles lsv_Catalogo.AlActualizar
        'Aqui se ocultan y se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then

            BTN_Exportar.Enabled = False

        Else

            BTN_Exportar.Enabled = True

        End If
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        SegundosDesconexion = 0

        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 2, 0)

    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 2, frm_MENU.prg_Barra)
    End Sub

    Public Sub New(ByVal Departamento As Dpto)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _Departamento = Departamento
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
    End Sub
End Class