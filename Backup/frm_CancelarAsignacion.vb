Imports Modulo_Proceso.Cn_Proceso

Public Class frm_CancelarAsignacion

    Public tbl As DataTable

    Private Sub frm_CancelarAsignacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Servicios.Columns.Add("Remision")
        lsv_Servicios.Columns.Add("Cliente")
        lsv_Servicios.Columns.Add("Importe")
        lsv_Servicios.Columns.Add("Envases")
        lsv_Servicios.Columns.Add("Envases SN")

        lsv_Servicios.Columns.Add("Tipo Envase")
        lsv_Servicios.Columns.Add("Numero")

        cmb_Cajero.AgregaParametro("@Dpto_Procesa", "P", 0)
        cmb_Cajero.Actualizar()
    End Sub

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If Not BuscarBoveda() Then
            Buscar_Envase(tbx_Buscar.Text)
        End If
    End Sub

    Public Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If Not fn_BuscaryMarca_enListView(lsv_Servicios, Remision, 1) Then
            MsgBox("No se encontro la Remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        End If
        tbx_Buscar.SelectAll()
        tbx_Buscar.Focus()
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

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    SegundosDesconexion = 0
        '    fn_BuscaryMarca_enListView(lsv_Servicios, tbx_Buscar.Text, 1)
        '    tbx_Buscar.SelectionStart = 0
        '    tbx_Buscar.SelectionLength = Len(tbx_Buscar.Text)
        'End If

        If Asc(e.KeyChar) = 13 Then
            If Not BuscarBoveda() Then
                Buscar_Envase(tbx_Buscar.Text)
            End If
        End If
    End Sub


    Private Sub cmb_Cajero_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cajero.SelectedValueChanged
        SegundosDesconexion = 0
        Call fn_CancelarAsignacion_LlenarLista(lsv_Servicios, cmb_Cajero.SelectedValue)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Servicios.Items.Count)

        tbl = fn_CancelarAsignacion_LlenarListaEnvases(lsv_Servicios, cmb_Cajero.SelectedValue)
    End Sub

    Private Sub btn_Recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibir.Click
        SegundosDesconexion = 0

        If cmb_Cajero.SelectedValue = 0 Then
            MsgBox("Debe seleccionar primero un Cajero.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Servicios.CheckedItems.Count = 0 Then
            MsgBox("Debe seleccionar al menos una Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Firma As New frm_FirmaElectronica
        Firma.ShowDialog()

        If Firma.Firma Then

            Dim Id_Servicio(lsv_Servicios.CheckedItems.Count - 1) As Integer
            Dim Id_Remision(lsv_Servicios.CheckedItems.Count - 1) As Integer
            Dim Servicios As Integer
            Dim Envases As Integer

            For I As Integer = 0 To lsv_Servicios.CheckedItems.Count - 1
                Id_Servicio(I) = lsv_Servicios.CheckedItems(I).Tag
                Id_Remision(I) = lsv_Servicios.CheckedItems(I).SubItems(5).Text
                Servicios += 1
                Envases += CInt(lsv_Servicios.CheckedItems(I).SubItems(3).Text) + CInt(lsv_Servicios.CheckedItems(I).SubItems(4).Text)

                If Not fn_RegresoaBoveda_Validar(Id_Servicio(I), "AS") And Not fn_RegresoaBoveda_Validar(Id_Servicio(I), "AC") Then
                    MsgBox("La Remisión " & lsv_Servicios.CheckedItems(I).Text & " ya no se encuentra en su status original", MsgBoxStyle.Critical, frm_MENU.Text)
                    fn_CancelarAsignacion_LlenarLista(lsv_Servicios, cmb_Cajero.SelectedValue)
                    Exit Sub
                End If
            Next

            If Not fn_CancelarAsignacion_Cancelar(Id_Servicio, Id_Remision, CInt(Firma.tbx_Empleado.Text.Trim), cmb_Cajero.SelectedValue, Servicios, Envases) Then
                MsgBox("Ha ocurrido un error al intentar cancelar las asignaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
                fn_CancelarAsignacion_LlenarLista(lsv_Servicios, cmb_Cajero.SelectedValue)
            Else
                MsgBox("Todas las asignaciones se han cancelado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                fn_CancelarAsignacion_LlenarLista(lsv_Servicios, cmb_Cajero.SelectedValue)
            End If
        End If


        lsv_Envases.Items.Clear()
    End Sub

    Private Sub lsv_Servicios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Servicios_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Servicios.ItemChecked
        If lsv_Servicios.CheckedItems.Count > 0 Then
            btn_Recibir.Enabled = True
        Else
            btn_Recibir.Enabled = False
        End If
    End Sub

    Private Sub cmb_Cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cajero.SelectedIndexChanged
        btn_Recibir.Enabled = False
    End Sub

    Private Sub lsv_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()
        If lsv_Servicios.Items.Count > 0 AndAlso lsv_Servicios.SelectedItems.Count > 0 Then
            fn_Envases_Get(lsv_Envases, lsv_Servicios.SelectedItems(0).Tag)
        End If

        lbl_Registros2.Text = "Registros: " & lsv_Envases.Items.Count
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click

        If lsv_Servicios.Items.Count <> 0 Then
            Dim remision As String = lsv_Servicios.SelectedItems(0).SubItems(0).Text
            Clipboard.SetText(remision)
        End If
        
    End Sub
    Function BuscarBoveda() As Boolean
        SegundosDesconexion = 0

        If Not fn_BuscarSeleccionarMarca_enListView(lsv_Servicios, tbx_Buscar.Text.Trim, 1) Then
            Return False
        End If
        tbx_Buscar.SelectAll()
        tbx_Buscar.Focus()

        Dim elementoSeleccionado As String = lsv_Servicios.SelectedItems(0).SubItems(0).Text
        If elementoSeleccionado <> 0 Then
            'lsv_Servicios.Items(0).Selected = True
        End If
        Return True
    End Function

End Class