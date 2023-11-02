Imports Modulo_Proceso.FuncionesGlobales
Imports Modulo_Proceso.Cn_Proceso

Public Class frm_RegresoaBoveda

    Public tbl As DataTable

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Buscar_Envase(tbx_Buscar.Text)

        'fn_BuscaryMarca_enListView(lsv_Servicios, tbx_Buscar.Text, 0)
    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        'Marcar la remisión buscada

        FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Servicios, Remision, 0)
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
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In lsv_Servicios.Items
            If (item.SubItems(0).Text = Remision) Then
                item.Selected = True
            End If
        Next
    End Sub

    Private Sub btn_Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Regresar.Click
        SegundosDesconexion = 0

        If lsv_Servicios.CheckedItems.Count > 0 Then
            Dim Id_Servicio(lsv_Servicios.CheckedItems.Count - 1) As Integer
            Dim Id_Remision(lsv_Servicios.CheckedItems.Count - 1) As Integer
            Dim CantEnv As Integer = 0

            For I As Integer = 0 To lsv_Servicios.CheckedItems.Count - 1
                Id_Servicio(I) = lsv_Servicios.CheckedItems(I).Tag
                Id_Remision(I) = CInt(lsv_Servicios.CheckedItems(I).SubItems(7).Text)
                CantEnv += CInt(lsv_Servicios.CheckedItems(I).SubItems(5).Text) + CInt(lsv_Servicios.CheckedItems(I).SubItems(6).Text)

                If Not fn_RegresoaBoveda_Validar(Id_Servicio(I)) Then
                    MsgBox("Los servicios ya no se encuentran disponibles, es posible que se hayan afectado desde otra estación de trabajo. Se actualizará la pantalla lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Call LlenarLista()
                    Exit Sub
                End If
            Next

            If Not fn_RegresoaBoveda_Enviar(Id_Servicio, Id_Remision, lsv_Servicios.CheckedItems.Count, CantEnv) Then
                MsgBox("Ha ocurrido un error al intentar enviar los Servicios a Bóoveda.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                Microsoft.VisualBasic.MsgBox("Los Servicios se enviaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If

            Call LlenarLista()
        End If
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0

        lsv_Servicios.Items.Clear()
        lsv_Envases.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        'chk_Todos.Checked = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Servicios.Items.Count)

        BanderA = False
        btn_Regresar.Enabled = False

        If Not fn_RegresoaBoveda_LlenarLista(lsv_Servicios) Then
            MsgBox("Ocurrió un error al intentar consultar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If


        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Servicios.Items.Count)
        BanderA = True

        ' ''>>
        tbl = fn_RegresoaBoveda_LlenarListaEnvases(lsv_Servicios)
        ' ''<<

        'Call fn_RegresoaBoveda_LlenarLista(lsv_Servicios)
        'FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Servicios.Items.Count)
    End Sub

    Private Sub frm_RegresoaBoveda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

        Call LlenarLista()
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        'SegundosDesconexion = 0
        'If Asc(e.KeyChar) = 13 Then
        '    fn_BuscaryMarca_enListView(lsv_Servicios, tbx_Buscar.Text, 0)
        '    tbx_Buscar.SelectionStart = 0
        '    tbx_Buscar.SelectionLength = Len(tbx_Buscar.Text)
        'End If

        If Asc(e.KeyChar) = 13 Then
            'Call Buscar()
            Buscar_Envase(tbx_Buscar.Text)
        End If

    End Sub

    Private Sub lsv_Servicios_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Servicios.ItemChecked
        SegundosDesconexion = 0

        btn_Regresar.Enabled = lsv_Servicios.CheckedItems.Count > 0
        If BanderA Then lsv_Servicios.Items(e.Item.Index).Selected = True
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SegundosDesconexion = 0

        'If chk_Todos.Checked Then
        '    For Each it As ListViewItem In lsv_Servicios.Items
        '        it.Checked = True
        '    Next
        'Else
        '    For Each it As ListViewItem In lsv_Servicios.Items
        '        it.Checked = False
        '    Next
        'End If
    End Sub

    Private Sub lsv_Servicios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()
        If lsv_Servicios.Items.Count > 0 AndAlso lsv_Servicios.SelectedItems.Count > 0 Then
            fn_Envases_Get(lsv_Envases, lsv_Servicios.SelectedItems(0).Tag)
        End If

        lbl_Registros2.Text = "Registros: " & lsv_Envases.Items.Count
    End Sub
End Class