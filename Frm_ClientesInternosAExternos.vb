Imports Modulo_Proceso.Cn_Proceso
Public Class Frm_ClientesInternosAExternos
    Private Sub Frm_ClientesInternosAExternos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Clientes.Actualizar()
        Llenar_Lista()
    End Sub
    Sub Llenar_Lista()
        lsv_Clientes.Items.Clear()
        Call fn_ClientesInternosAExternos_LlenarLista(lsv_Clientes)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Clientes.Items.Count)
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        If cmb_Clientes.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Exit Sub
        End If

        For Each elemento As ListViewItem In lsv_Clientes.Items
            If elemento.Tag = cmb_Clientes.SelectedValue Then
                MsgBox("El Cliente ya esta agregado a la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Clientes.SelectedValue = 0
                cmb_Clientes.Focus()
                Exit Sub
            End If
        Next

        If Not fn_ClientesInternosAExternos_Guardar(cmb_Clientes.SelectedValue) Then
            MsgBox("No se pudieron Guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            Call Llenar_Lista()
        End If
        'btn_baja.Enabled = lsv_Empleados.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Borrar_Click(sender As Object, e As EventArgs) Handles btn_Borrar.Click
        If lsv_Clientes.SelectedItems.Count = 0 Then Exit Sub
        If Not fn_ClientesInternosAExternos_Eliminar(lsv_Clientes.SelectedItems(0).Tag) Then
            MsgBox("Ocurrió un Error al borrar al cliente seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call Llenar_Lista()
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        If lsv_Clientes.SelectedItems.Count > 0 Then
            btn_Borrar.Enabled = True
        Else
            btn_Borrar.Enabled = False
        End If
    End Sub
End Class