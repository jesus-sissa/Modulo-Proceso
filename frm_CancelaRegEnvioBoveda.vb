Public Class frm_CancelaRegEnvioBoveda

    Private Sub frm_CancelaRegEnvioBoveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista

        lsv_Resguardos.Columns.Add("Fecha")
        lsv_Resguardos.Columns.Add("Envia")
        lsv_Resguardos.Columns.Add("Hora")
        lsv_Resguardos.Columns.Add("Remisiones")
        lsv_Resguardos.Columns.Add("Envases")
        lsv_Resguardos.Columns.Add("Estatus")

        Call Llenalista()

        lsv_ResguardosD.Columns.Add("Remision")
        lsv_ResguardosD.Columns.Add("Importe")
        lsv_ResguardosD.Columns.Add("Envases")
        lsv_ResguardosD.Columns.Add("IDREM")
        lsv_ResguardosD.Columns.Add("IDRE")
        lsv_ResguardosD.Columns.Add("IDCB")


        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

    End Sub

    Private Sub lsv_Resguardos_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Resguardos.ItemChecked
        If lsv_Resguardos.CheckedItems.Count = 0 Then
            btn_Cancelar.Enabled = False
        Else
            btn_Cancelar.Enabled = True
        End If
    End Sub

    Private Sub lsv_Resguardos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_ResguardosD.Items.Clear()
        lsv_Envases.Items.Clear()

        If lsv_Resguardos.SelectedItems.Count = 0 Then
            FuncionesGlobales.RegistrosNum(Lbl_Registros2, lsv_ResguardosD.Items.Count)
            lsv_Resguardos.Items.Clear()
            Exit Sub
        Else
            Cn_Proceso.fn_CancelaEnvioResgBovedaDLlenalista(lsv_ResguardosD, lsv_Resguardos.SelectedItems(0).Tag)
            'lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros2, lsv_ResguardosD.Items.Count)

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        Dim Elementos As ListViewItem

        If lsv_Resguardos.CheckedItems.Count = 0 Then
            MsgBox("Selecciona, una venta ", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        For Each Elementos In lsv_Resguardos.CheckedItems
            If Cn_Proceso.fn_ValidaCanceaResgEnvioBoveda(Elementos.Tag) = True Then
                MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, Me.Text)
                Llenalista()
                Exit Sub
            End If
        Next

        frm.Bloquear = True
        frm.ShowDialog()

        If frm.Firma = True Then
            Try
                For Each Elementos In lsv_Resguardos.CheckedItems
                    Cn_Proceso.fn_CancelaResgBoveda_Cancelar(Elementos.Tag)
                Next

            Catch ex As Exception
                MsgBox("Error al Cancelar", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End Try

            MsgBox("Operacion Exitosa", MsgBoxStyle.Information, Me.Text)
            Call Llenalista()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Llenalista()
        lsv_Resguardos.Items.Clear()
        lsv_Envases.Items.Clear()

        Cn_Proceso.fn_CancelaEnvioResgBovedaLlenalista(lsv_Resguardos)
        lsv_Resguardos.CheckBoxes = True
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Resguardos.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros2, lsv_ResguardosD.Items.Count)
    End Sub

    Private Sub lsv_Resguardos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardos.MouseHover, lsv_ResguardosD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_ResguardosD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ResguardosD.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()
        If lsv_ResguardosD.Items.Count > 0 AndAlso lsv_ResguardosD.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_ResguardosD.SelectedItems(0).SubItems(6).Text, lsv_Envases)
        End If

        FuncionesGlobales.RegistrosNum(lbl_Resgistros3, lsv_Envases.Items.Count)
    End Sub
End Class