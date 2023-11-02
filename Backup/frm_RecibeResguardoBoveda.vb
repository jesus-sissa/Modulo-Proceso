Public Class frm_RecibeResguardoBoveda

    Private Sub frm_RecibeResguardoCajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista
        Call LlenaLista()
        lsv_ResguardosD.Columns.Clear()
        lsv_ResguardosD.Columns.Add("Remision")
        lsv_ResguardosD.Columns.Add("Importe")
        lsv_ResguardosD.Columns.Add("Envases")

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

    End Sub

    Private Sub lsv_Ventas_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Resguardos.ItemChecked
        SegundosDesconexion = 0

        If lsv_Resguardos.CheckedItems.Count = 0 Then
            btn_Recibe.Enabled = False
        Else
            btn_Recibe.Enabled = True
        End If
    End Sub

    Private Sub btn_Recibe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibe.Click
        SegundosDesconexion = 0
        If SesionId = 0 Then
            MsgBox("No es posible Recibir los Lotes porque no hay Sesión Abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim firma As New frm_FirmaElectronica
        firma.ShowDialog()

        If firma.Firma Then
            For Each Elemento As ListViewItem In lsv_Resguardos.CheckedItems
                If Cn_Proceso.fn_ValidaReciboEnvioCajero(Elemento.Tag) = True Then
                    MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, Me.Text)
                    LlenaLista()
                    Exit Sub
                End If
            Next

            For Each Elemento In lsv_Resguardos.CheckedItems
                If Not Cn_Proceso.fn_RecibeResgEnvioBoveda(Elemento.Tag, CInt(firma.tbx_Empleado.Text.Trim)) Then
                    MsgBox("Ocurrió un Error al intentar recibir el Lote.", MsgBoxStyle.Critical, frm_MENU.Text)
                    LlenaLista()
                    Exit Sub
                End If
            Next
            MsgBox("Registro Recibido.", MsgBoxStyle.Information, frm_MENU.Text)

            Call LlenaLista()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LlenaLista()
        SegundosDesconexion = 0

        btn_Recibe.Enabled = False
        lsv_ResguardosD.Items.Clear()
        Cn_Proceso.fn_ReciboResgEnvioCajeroLlenalista(lsv_Resguardos)
        lsv_Resguardos.CheckBoxes = True
        lsv_Resguardos.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_Resguardos.Columns(3).TextAlign = HorizontalAlignment.Right

    End Sub

    Private Sub lsv_Resguardos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_ResguardosD.Items.Clear()
        If lsv_Resguardos.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Cn_Proceso.fn_CancelaEnvioResgBovedaDLlenalista(lsv_ResguardosD, lsv_Resguardos.SelectedItems(0).Tag)
            lsv_ResguardosD.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_ResguardosD.Columns(2).TextAlign = HorizontalAlignment.Right
        End If
    End Sub

    Private Sub lsv_Resguardos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardos.MouseHover, lsv_ResguardosD.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_ResguardosD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ResguardosD.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()
        If lsv_ResguardosD.Items.Count > 0 AndAlso lsv_ResguardosD.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_ResguardosD.SelectedItems(0).SubItems(6).Text, lsv_Envases)
        End If

        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Envases.Items.Count)
    End Sub
End Class