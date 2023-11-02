Imports Modulo_Proceso.Cn_Proceso

Public Class frm_EmpleadosAutoriza

    Private Sub frm_EmpleadosAutoriza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Empleados.Actualizar()
        Call Llenar_Lista()
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Sub Llenar_Lista()
        lsv_Empleados.Items.Clear()
        Call fn_EmpleadosAutorizados_LlenarLista(lsv_Empleados)
        btn_baja.Enabled = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Empleados.Items.Count)
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click

        If cmb_Empleados.SelectedValue = 0 Then
            MsgBox("Seleccione un Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleados.Focus()
            Exit Sub
        End If

        For Each elemento As ListViewItem In lsv_Empleados.Items
            If elemento.Tag = cmb_Empleados.SelectedValue Then
                MsgBox("El Empleado ya esta agregado a la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Empleados.SelectedValue = 0
                cmb_Empleados.Focus()
                Exit Sub
            End If
        Next

        If Not fn_EmpleadosAutoriza_Guardar(cmb_Empleados.SelectedValue) Then
            MsgBox("No se pudieron Guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            Call Llenar_Lista()
        End If
        btn_baja.Enabled = lsv_Empleados.SelectedItems.Count > 0
    End Sub

    Private Sub btn_baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baja.Click
        If lsv_Empleados.SelectedItems.Count = 0 Then Exit Sub

        If lsv_Empleados.SelectedItems(0).SubItems(4).Text = "ACTIVO" Then
            If Not fn_EmpleadosAutorizados_AltaBaja(lsv_Empleados.SelectedItems(0).Tag, "B") Then
                MsgBox("Ocurrió un Error al dar de Baja al Empleado seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        ElseIf lsv_Empleados.SelectedItems(0).SubItems(4).Text = "BAJA" Then
            If Not fn_EmpleadosAutorizados_AltaBaja(lsv_Empleados.SelectedItems(0).Tag, "A") Then
                MsgBox("Ocurrió un Error al intentar reactivar al Empleado seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        
        Call Llenar_Lista()
    End Sub

    Private Sub lsv_Empleados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Empleados.SelectedIndexChanged
        btn_baja.Enabled = lsv_Empleados.SelectedItems.Count > 0
    End Sub

End Class