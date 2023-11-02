Imports Modulo_Proceso.Cn_Proceso
Imports Modulo_Proceso.FuncionesGlobales

Public Class frm_CuentasModal

    Public Id_ClienteP As Integer
    Public Id_Banco As Integer = 0

    Private Sub frm_CuentasModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Banco.Actualizar()

        If Id_Banco > 0 Then
            cmb_Banco.SelectedValue = Id_Banco
            cmb_Banco.Enabled = False
        End If

        If lsv_CuentasAdd.Columns.Count = 0 Then
            For Each Col As ColumnHeader In lsv_Cuentas.Columns
                lsv_CuentasAdd.Columns.Add(Col.Clone)
            Next
        End If

        fn_CuentasModal_Referencias(lsv_Referencias, -1, -1)

        If lsv_ReferenciasAdd.Columns.Count = 0 Then
            For Each Col As ColumnHeader In lsv_Referencias.Columns
                lsv_ReferenciasAdd.Columns.Add(Col.Clone)
            Next
        End If

    End Sub

    Private Sub cmb_Banco_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedValueChanged
        SegundosDesconexion = 0

        cmb_ClientesP.ValorParametro = cmb_Banco.SelectedValue
        cmb_ClientesP.Actualizar()
    End Sub

    Private Sub lsv_Cuentas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Cuentas.SelectedIndexChanged
        If lsv_Cuentas.SelectedItems.Count > 0 Then
            btn_Guardar.Enabled = True
            fn_CuentasModal_Referencias(lsv_Referencias, lsv_Cuentas.SelectedItems(0).Tag, cmb_ClientesP.SelectedValue)
        Else
            btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub cmb_ClientesP_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ClientesP.SelectedValueChanged
        SegundosDesconexion = 0

        fn_CuentasModal_LlenarExistentes(lsv_Cuentas, cmb_ClientesP.SelectedValue, cmb_Banco.SelectedValue)
        'para que se agreguen las columnas
        btn_Guardar.Enabled = False
    End Sub

    Private Sub cbx_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Todos.CheckedChanged
        If cbx_Todos.Checked Then
            cmb_ClientesP.SelectedValue = 0
            cmb_ClientesP.Enabled = False
        Else
            cmb_ClientesP.Enabled = True
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If lsv_Cuentas.SelectedItems.Count > 0 Then
            'Aqui se validan las referencias
            For Each item As ListViewItem In lsv_Referencias.CheckedItems
                If Not fn_Proceso_ValidarReferencias(Id_ClienteP, item.Tag) Then
                    MsgBox("Ya existe la Referencia para el Cliente.", MsgBoxStyle.Information, frm_MENU.Text)
                    Exit Sub
                End If
            Next

            'Aqui se agregan las columnas en las tablas de destino
            If lsv_CuentasAdd.Columns.Count = 0 Then
                For Each Col As ColumnHeader In lsv_Cuentas.Columns
                    lsv_CuentasAdd.Columns.Add(Col.Clone)
                Next
            End If

            If lsv_ReferenciasAdd.Columns.Count = 0 Then
                For Each Col As ColumnHeader In lsv_Referencias.Columns
                    lsv_ReferenciasAdd.Columns.Add(Col.Clone)
                Next
            End If

            'revisar si la cuenta seleccionada ya existe para el cliente
            'si existe ya no se agrega
            For Each element As ListViewItem In lsv_CuentasAdd.Items
                If element.Tag = lsv_Cuentas.SelectedItems(0).Tag Then GoTo Referencias
            Next
            lsv_CuentasAdd.Items.Add(lsv_Cuentas.SelectedItems(0).Clone())

Referencias:
            'Si la referencia seleccionada ya existe en la lista de abajo, ya no se agrega
            'y se le avisa al usuario
            For Each item As ListViewItem In lsv_Referencias.CheckedItems
                For Each element As ListViewItem In lsv_ReferenciasAdd.Items
                    If element.Tag = item.Tag Then
                        MsgBox("La Referencia " & item.Text & " ya existe en la Lista.", MsgBoxStyle.Information, frm_MENU.Text)
                        GoTo Siguiente
                    End If
                Next
                With lsv_ReferenciasAdd.Items.Add(item.Clone)
                    .SubItems(1).Tag = lsv_Cuentas.SelectedItems(0).Tag
                End With
Siguiente:
            Next
            tbx_Buscar.Clear()
            tbx_BuscarR.Clear()
        End If
    End Sub

    Private Sub Btn_GuardarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_GuardarTodo.Click
        SegundosDesconexion = 0

        If lsv_CuentasAdd.Items.Count = 0 Then
            MsgBox("No ha agregado Cuentas para Guardar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim Cuentas(lsv_CuentasAdd.Items.Count - 1) As Integer
        Dim Referencias(lsv_ReferenciasAdd.Items.Count - 1) As Integer

        'Lenar un arreglo con los IDs de las Cuentas agregadas
        For Each element As ListViewItem In lsv_CuentasAdd.Items
            Cuentas(element.Index) = element.Tag
        Next

        'Lenar un arreglo con los IDs de las Referencias agregadas
        For Each element As ListViewItem In lsv_ReferenciasAdd.Items
            Referencias(element.Index) = element.Tag
        Next

        'Enviar el CLiente, las Cuentas y las Referencias a la funcion para Guardarlas
        If fn_CuentasModal_Guardar(Id_ClienteP, Cuentas, Referencias) Then
            Me.Close()
        Else
            MsgBox("Ha ocurrido un error inesperado al intentar guardar las Cuentas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Cuentas_AlActualizar() Handles lsv_Cuentas.AlActualizar
        lsv_Referencias.Items.Clear()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        SegundosDesconexion = 0

        If tbx_Buscar.Text <> "" Then
            FuncionesGlobales.fn_Buscar_enListViewPredict(lsv_Cuentas, tbx_Buscar.Text.Trim, 1)
        End If
    End Sub

    Private Sub tbx_buscarR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_BuscarR.TextChanged
        SegundosDesconexion = 0

        If tbx_BuscarR.Text <> "" Then
            FuncionesGlobales.fn_Buscar_enListViewPredict(lsv_Referencias, tbx_BuscarR.Text.Trim, 1)
        End If
    End Sub

    Private Sub lsv_Cuentas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cuentas.MouseHover, lsv_CuentasAdd.MouseHover, lsv_Referencias.MouseHover, lsv_ReferenciasAdd.MouseHover
        SegundosDesconexion = 0
    End Sub

End Class