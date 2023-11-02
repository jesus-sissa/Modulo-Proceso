Imports Modulo_Proceso.FuncionesGlobales
Imports Modulo_Proceso.Cn_Proceso

Public Class Frm_BuscarCliente
    Public Cliente As Boolean = True
    Public Llamadas As Boolean = False
    Public Id_CajaBancaria As Integer
    Public Empresa As String
    Public Clave As String
    Public Consulta As Query = Query.Clientes
    Public Id As Integer = 0

    <Flags()> _
    Enum Query As Byte
        Clientes
        Empleados
        CajaBancaria
        ClientesP
        Llamadas
    End Enum

    Private Sub Frm_BuscarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Llenar_Lista()
    End Sub

    Sub Llenar_Lista()
        Me.Cursor = Cursors.WaitCursor
        Select Case Consulta
            Case Query.Clientes
                lsv_Clientes.Row1 = 60
                lsv_Clientes.Row2 = 17
                lsv_Clientes.Row3 = 17
                Dim SoloActivos As Boolean = chk_SoloActivos.Checked = True
                If Not fn_BuscarClientes_LlenarLista(lsv_Clientes, SoloActivos, Cliente) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los clientes", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Clientes"
            Case Query.Empleados
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_BuscarClientes_LlenarListaEmpleados(lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los empleados", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Empleados"
            Case Query.CajaBancaria
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_BuscarClientes_LlenarListaCajasBancarias(lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar las cajas bancarias", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Cajas Bancarias"
            Case Query.ClientesP
                lsv_Clientes.Row1 = 60
                lsv_Clientes.Row2 = 17
                lsv_Clientes.Row3 = 17
                lsv_Clientes.Row4 = 17
                Dim SoloActivos As Boolean = chk_SoloActivos.Checked = True
                If Not fn_BuscarClientesP_LlenarLista(lsv_Clientes, SoloActivos, Id_CajaBancaria) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar los Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Clientes con Servicio de Proceso"
            Case Query.Llamadas
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 65
                If Not fn_Seguimiento_BuscarLlamadas(lsv_Clientes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar las Llamadas.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Llamadas"
                chk_SoloActivos.Visible = False
        End Select
        tbx_Buscar.Focus()
        Me.Cursor = Cursors.Default
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Clientes.Items.Count)
    End Sub

    Private Sub lsv_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Clientes.DoubleClick
        SegundosDesconexion = 0

        Select Case Consulta
            Case Query.Clientes
                Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Empleados
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.CajaBancaria
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.ClientesP
                Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Llamadas
                Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                Empresa = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
        End Select

        Me.Close()
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0

        Select Case Consulta
            Case Query.Clientes
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Empleados
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.CajaBancaria
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

            Case Query.Llamadas
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If

        End Select

    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 And lsv_Clientes.SelectedItems.Count > 0 Then Me.Close()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, 0)
    End Sub

    Private Sub chk_SoloActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SoloActivos.CheckedChanged
        Call Llenar_Lista()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim Fila_Inicial As Integer = 0
        If lsv_Clientes.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Clientes.SelectedItems(0).Index + 1
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub lsv_Clientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class