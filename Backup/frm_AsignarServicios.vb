Imports Modulo_Proceso.Cn_Proceso
Imports Modulo_Proceso.FuncionesGlobales.Func
Imports Modulo_Proceso.FuncionesGlobales.Modo

Public Class frm_AsignarServicios

    Private Columnas() As Integer = {1, 4, 5, 6}
    Private Nombre() As String = {"Remisiones", "Importe", "Envases", "Envases S/N"}
    Private Formatos() As String = {"g", "n", "g", "g"}
    Private Funciones() As FuncionesGlobales.Func = {Conteo, Suma, Suma, Suma}
    Private tbx_RemSeleccionados As String
    Private tbx_EnvS As String
    Private tbl As DataTable


    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_AsignarServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'cmb_Cajero.AgregaParametro("@Id_Puesto", fn_AsignarServicios_ObtenCajero, 1)
        cmb_Cajero.AgregaParametro("@Status", "A", 0)
        cmb_Cajero.Actualizar()
        cmb_CajaBancaria.Actualizar()

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        lsv_Servicios.Items.Clear()
        btn_Asignar.Enabled = False

        Lbl_Registros.Text = "Registros Totales: 0"
        lbl_RegistrosS.Text = "Registros Seleccionados: 0"

        If cmb_CajaBancaria.SelectedValue = 0 Then Exit Sub

        Call fn_AsignarServicios_LlenarLista(lsv_Servicios, cmb_CajaBancaria.SelectedValue)
        Lbl_Registros.Text = "Registros Totales: " & lsv_Servicios.Items.Count.ToString
        ''>>
        tbl = fn_ObtenerEnvases(lsv_Servicios, cmb_CajaBancaria.SelectedValue)
        ''<<

    End Sub

    Private Sub lsv_Servicios_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Servicios.ItemChecked
        SegundosDesconexion = 0

        tbx_RemSeleccionados = lsv_Servicios.CheckedItems.Count

        tbx_EnvS = 0
        For Each Item As ListViewItem In lsv_Servicios.CheckedItems
            tbx_EnvS += CInt(Item.SubItems(5).Text) + CInt(Item.SubItems(6).Text)
        Next

        lbl_RegistrosS.Text = "Registros Seleccionados: " & lsv_Servicios.CheckedItems.Count.ToString

        If lsv_Servicios.CheckedItems.Count > 0 Then
            btn_Asignar.Enabled = True
        Else
            btn_Asignar.Enabled = False
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If Not BuscarBoveda() Then
            Buscar_Envase(txt_Buscar.Text)
        End If
    End Sub

    Public Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If Not fn_BuscaryMarca_enListView(lsv_Servicios, Remision, 1) Then
            MsgBox("No se encontro la Remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        End If
        txt_Buscar.SelectAll()
        txt_Buscar.Focus()
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
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In lsv_Servicios.Items
            If (item.SubItems(0).Text = Remision) Then
                item.Selected = True
            End If
        Next
    End Sub

    'Public Sub Buscar()
    '    SegundosDesconexion = 0

    '    If Not fn_BuscaryMarca_enListView(lsv_Servicios, txt_Buscar.Text, 1) Then
    '        MsgBox("No se encontro la Remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
    '    End If
    '    txt_Buscar.SelectAll()
    '    txt_Buscar.Focus()
    'End Sub

    Private Sub txt_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Buscar.KeyPress

        SegundosDesconexion = 0

        If Asc(e.KeyChar) = 13 Then
            If Not BuscarBoveda() Then
                Buscar_Envase(txt_Buscar.Text)
            End If
        End If
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

        Dim Id_Servicios(lsv_Servicios.CheckedItems.Count - 1) As Integer

        For I As Integer = 0 To lsv_Servicios.CheckedItems.Count - 1
            Id_Servicios(I) = lsv_Servicios.CheckedItems(I).Tag
            If Not fn_RegresoaBoveda_Validar(lsv_Servicios.CheckedItems(I).Tag) Then
                MsgBox("La Remisión número " & lsv_Servicios.CheckedItems(I).Text & " ya no está disponible.", MsgBoxStyle.Critical, frm_MENU.Text)
                fn_AsignarServicios_LlenarLista(lsv_Servicios, cmb_CajaBancaria.SelectedValue)
                Exit Sub
            End If
        Next

        If Not fn_AsignarServicios_Asignar(Id_Servicios, cmb_Cajero.SelectedValue, tbx_RemSeleccionados, tbx_EnvS) Then
            MsgBox("Ocurrio un error al intentar asignar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            MsgBox("Se han asignado correctamente todos los Servicios.", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        lsv_Envases.Items.Clear()

        Call LlenarLista()
    End Sub

    Private Sub lsv_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()

        If lsv_Servicios.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_CancelarEnvioProceso_EnvasesCancelar(lsv_Envases, lsv_Servicios.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged

    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged

    End Sub

   
    Private Sub CopiarToolStripMenuItemCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItemCopy.Click


        If lsv_Servicios.Items.Count <> 0 Then
            Dim remision As String = lsv_Servicios.SelectedItems(0).SubItems(0).Text
            Clipboard.SetText(remision)
        End If


    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
    Function BuscarBoveda() As Boolean
        SegundosDesconexion = 0

        If Not fn_BuscarSeleccionarMarca_enListView(lsv_Servicios, txt_Buscar.Text.Trim, 1) Then
            Return False
        End If
        txt_Buscar.SelectAll()
        txt_Buscar.Focus()

        Dim elementoSeleccionado As String = lsv_Servicios.SelectedItems(0).SubItems(0).Text
        If elementoSeleccionado <> 0 Then
            ' lsv_Servicios.Items(0).Selected = True
        End If

        lsv_Envases.Items(0).Selected = True
        Return True
    End Function

End Class