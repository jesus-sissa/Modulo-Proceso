Public Class frm_RecibeDotacionRegBoveda

    Private Sub frm_RecibeDotacionCajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista
        Llenalista()
    End Sub

    Private Sub lsv_Ventas_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Dotacion.ItemChecked
        If lsv_Dotacion.CheckedItems.Count = 0 Then
            btn_Recibe.Enabled = False
        Else
            btn_Recibe.Enabled = True
        End If
    End Sub

    Private Sub btn_Recibe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibe.Click

        If SesionId = 0 Then
            MsgBox("No es posible Recibir los Lotes porque no hay Sesión Abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim firma As New frm_FirmaElectronica
        firma.ShowDialog()
        If firma.Firma Then
            For Each Elemento As ListViewItem In lsv_Dotacion.CheckedItems
                If Cn_Proceso.fn_ValidaReciboEnvioCajero(Elemento.Tag) = True Then
                    MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If
            Next

            For Each Elemento In lsv_Dotacion.CheckedItems
                If Cn_Proceso.fn_RecibeEnvioBoveda(Elemento.Tag, CInt(firma.tbx_Empleado.Text.Trim)) = True Then
                    MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            Next

            Call Llenalista()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Llenalista()
        SegundosDesconexion = 0

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

        Cn_Proceso.fn_ReciboEnvioCajeroLlenalista(lsv_Dotacion)
        lsv_Dotacion.CheckBoxes = True

        If lsv_Dotacion.SelectedItems.Count > 0 Then
            If Not Cn_Proceso.fn_RecibeEnvioCajeroLlenaDetalle(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar buscar el detalle del lote", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            If Not Cn_Proceso.fn_RecibeEnvioCajeroLlenaDetalle(lsv_DotacionD, 0) Then
                MsgBox("Ha ocurrido un error al intentar buscar el detalle del lote", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotacion.Items.Count)
    End Sub

    Private Sub lsv_Dotacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Dotacion.SelectedItems.Count > 0 Then
            If Not Cn_Proceso.fn_RecibeEnvioCajeroLlenaDetalle(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar buscar el detalle del lote", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            If Not Cn_Proceso.fn_RecibeEnvioCajeroLlenaDetalle(lsv_DotacionD, 0) Then
                MsgBox("Ha ocurrido un error al intentar buscar el detalle del lote", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_DotacionD.Items.Count)
    End Sub

    Private Sub lsv_Dotacion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.MouseHover, lsv_DotacionD.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_DotacionD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_DotacionD.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()
        If lsv_DotacionD.Items.Count > 0 AndAlso lsv_DotacionD.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_DotacionD.SelectedItems(0).SubItems(3).Text, lsv_Envases)
        End If

        lbl_Registro3.Text = "Registros: " & lsv_Envases.Items.Count
    End Sub
End Class