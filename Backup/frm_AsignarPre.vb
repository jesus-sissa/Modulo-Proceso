Imports Modulo_Proceso.Cn_Proceso
Public Class frm_AsignarPre
    Dim tbl As DataTable
    Private Sub frm_AsignarPre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        tbl = New DataTable
        cmb_Cajero.AgregaParametro("@Status", "A", 0)
        cmb_Cajero.Actualizar()
        cmb_CajaBancaria.Actualizar()
        lsv_Dotacion.Columns.Add("Remision")
        lsv_Dotacion.Columns.Add("Caja")
        lsv_Dotacion.Columns.Add("Cliente")
        lsv_Dotacion.Columns.Add("Fecha Captura")
        lsv_Dotacion.Columns.Add("Moneda")
        lsv_Dotacion.Columns.Add("Importe")
        lsv_Dotacion.Columns.Add("Id_Remision")
        lsv_Dotacion.Columns.Add("Asignado a")
        lsv_Dotacion.Columns.Add("Status")
        'Call LlenaLista(0)
    End Sub

    Private Sub LlenaLista(ByVal Id_Caja As Integer)
        SegundosDesconexion = 0
        If cmb_CajaBancaria.SelectedValue = 0 Then Exit Sub
        Cn_Proceso.fn_AsignarPreparacion(lsv_Dotacion, Id_Caja)
        lsv_Dotacion.CheckBoxes = True
        lsv_Dotacion.Columns(5).TextAlign = HorizontalAlignment.Right
        'lsv_Dotacion.Columns(10).Width = 0
        'lsv_Dotacion.Columns(11).Width = 0

        'lsv_DotacionD.Items.Clear()
        'lsv_Envases.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotacion.Items.Count)
        tbl = fn_EnviaBovedaLlenalistaEnvases(lsv_Dotacion)
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0
        LlenaLista(cmb_CajaBancaria.SelectedValue)
    End Sub

    Private Sub btn_Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asignar.Click
        SegundosDesconexion = 0

        If SesionId = 0 Then
            MsgBox("No es posible Asignar Depósitos porque no hay Sesión Abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Cajero.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Cajero.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Dim Id_Servicios(lsv_Dotacion.CheckedItems.Count - 1) As Integer

        'For I As Integer = 0 To lsv_Dotacion.CheckedItems.Count - 1
        '    Id_Servicios(I) = lsv_Dotacion.CheckedItems(I).Tag
        '    If Not fn_RegresoaBoveda_Validar(lsv_Dotacion.CheckedItems(I).Tag) Then
        '        MsgBox("La Remisión número " & lsv_Dotacion.CheckedItems(I).Text & " ya no está disponible.", MsgBoxStyle.Critical, frm_MENU.Text)
        '        fn_AsignarServicios_LlenarLista(lsv_Dotacion, cmb_CajaBancaria.SelectedValue)
        '        Exit Sub
        '    End If
        'Next
        For Each item In lsv_Dotacion.CheckedItems
            fn_AsignarPreparacionV(lsv_Dotacion, item.SubItems(6).Text, cmb_Cajero.SelectedValue, UsuarioId)
        Next
        LlenaLista(cmb_CajaBancaria.SelectedValue)
        'If Not fn_AsignarServicios_Asignar(Id_Servicios, cmb_Cajero.SelectedValue, tbx_RemSeleccionados, tbx_EnvS) Then
        '    MsgBox("Ocurrio un error al intentar asignar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
        'Else
        '    MsgBox("Se han asignado correctamente todos los Servicios.", MsgBoxStyle.Information, frm_MENU.Text)
        'End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If tbx_Buscar.Text.Trim() = String.Empty Then Exit Sub
        If Not BuscarBoveda() Then
            Call Buscar_Envase(tbx_Buscar.Text)
        End If
    End Sub
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In lsv_Dotacion.Items
            If (item.SubItems(0).Text = Remision) Then
                item.Selected = True
            End If
        Next
    End Sub
    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0
        'Marcar la remisión buscada
        fn_BuscarSeleccionarMarca_enListView(lsv_Dotacion, Remision, 0)
        tbx_Buscar.Focus()
        tbx_Buscar.SelectAll()
    End Sub
    Sub Buscar_Envase(ByVal Numero As String)
        For Each row As DataRow In tbl.Rows
            If (row(1).ToString() = Numero) Then
                Buscar(row(0).ToString())
                Seleccionar(row(0).ToString)
                Exit Sub
            End If
        Next
    End Sub
    Function BuscarBoveda() As Boolean
        SegundosDesconexion = 0

        If Not fn_BuscarSeleccionarMarca_enListView(lsv_Dotacion, tbx_Buscar.Text.Trim, 1) Then
            Return False
        End If
        tbx_Buscar.SelectAll()
        tbx_Buscar.Focus()

        Dim elementoSeleccionado As String = lsv_Dotacion.SelectedItems(0).SubItems(0).Text
        If elementoSeleccionado <> 0 Then
            'lsv_Dotacion.Items(0).Selected = True
        End If
        Return True
    End Function

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        SegundosDesconexion = 0
        If tbx_Buscar.Text.Trim() = String.Empty Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarBoveda() Then
                Call Buscar_Envase(tbx_Buscar.Text)
            End If
        End If
    End Sub
End Class