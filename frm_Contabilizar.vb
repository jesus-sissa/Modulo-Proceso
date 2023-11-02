Imports Modulo_Proceso.Cn_Proceso

Public Class frm_Contabilizar

    Private Sub frm_Contabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Cajero.AgregaParametro("@Status", "A", 0)
        cmb_Cajero.Actualizar()
        cmb_CajaBancaria.Actualizar()

        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Cia. Traslado")
        lsv_Remisiones.Columns.Add("Caja Bancaria")
        lsv_Remisiones.Columns.Add("Cliente")
        lsv_Remisiones.Columns.Add("Importe")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("EnvasesSN")
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0
        lsv_Remisiones.Items.Clear()
        btn_Contabilizar.Enabled = False
        chk_Todos.Checked = False
        If cmb_Cajero.SelectedValue <> "0" And cmb_CajaBancaria.SelectedValue <> "0" Then
            Call fn_Contabilizar_LlenarLista(lsv_Remisiones, cmb_Cajero.SelectedValue, cmb_CajaBancaria.SelectedValue)
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Remisiones.Items.Count)
    End Sub

    Private Sub cmb_Cajero_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cajero.SelectedValueChanged
        SegundosDesconexion = 0
        lsv_Remisiones.Items.Clear()
        btn_Contabilizar.Enabled = False
        chk_Todos.Checked = False
        If cmb_Cajero.SelectedValue <> "0" And cmb_CajaBancaria.SelectedValue <> "0" Then
            Call fn_Contabilizar_LlenarLista(lsv_Remisiones, cmb_Cajero.SelectedValue, cmb_CajaBancaria.SelectedValue)
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Remisiones.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Contabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Contabilizar.Click
        SegundosDesconexion = 0

        If Validar() Then
            Dim frm As New frm_FirmaElectronica
            frm.ShowDialog()
            If frm.Firma Then

                'Verificar si hay Lotes de Efectivo pendientes de Recibirle
                If Cn_Proceso.fn_LoteEfectivo_Verificar2Cont(cmb_Cajero.SelectedValue) Then
                    MsgBox("Existen lotes de Efectivo pendientes de recibirle a " & cmb_Cajero.Text, MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                If fn_Contabilizar_Guardar(lsv_Remisiones, cmb_Cajero.SelectedValue, frm.tbx_Empleado.Text, cmb_CajaBancaria.SelectedValue) Then
                    MsgBox("Se han contabilizado exitosamente los Servicios.", MsgBoxStyle.Information, frm_MENU.Text)
                    Call fn_Contabilizar_LlenarLista(lsv_Remisiones, cmb_Cajero.SelectedValue, cmb_CajaBancaria.SelectedValue)
                    btn_Contabilizar.Enabled = False
                    chk_Todos.Checked = False
                Else
                    MsgBox("Ha ocurrido un error al intentar contabilizar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0
        If cmb_Cajero.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Cajero.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cajero.Focus()
            Return False
        End If

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If lsv_Remisiones.CheckedItems.Count = 0 Then
            MsgBox("Debe seleccionar al menos un Servicio para Contabilizar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        Return True
    End Function

    Private Sub lsv_Remisiones_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Remisiones.ItemChecked
        SegundosDesconexion = 0
        btn_Contabilizar.Enabled = lsv_Remisiones.CheckedItems.Count > 0
        If lsv_Remisiones.Items.Count = lsv_Remisiones.CheckedItems.Count Then
            chk_Todos.Checked = True
        End If
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0
        If chk_Todos.Checked Then
            For Each it As ListViewItem In lsv_Remisiones.Items
                it.Checked = True
            Next
        Else
            For Each it As ListViewItem In lsv_Remisiones.Items
                it.Checked = False
            Next
        End If
    End Sub

    Private Sub CopiarToolStripMenuItemCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItemCopiar.Click

        If lsv_Remisiones.Items.Count <> 0 Then
            Dim remision As String = lsv_Remisiones.SelectedItems(0).SubItems(0).Text
            Clipboard.SetText(remision)
        End If

    End Sub
End Class