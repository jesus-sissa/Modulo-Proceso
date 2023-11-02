Public Class frm_CancelaEnvioBoveda

    Private Sub frm_CancelaEnvioBoveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista
        lsv_Dotacion.Columns.Add("Fecha")
        lsv_Dotacion.Columns.Add("Envia")
        lsv_Dotacion.Columns.Add("Hora")
        lsv_Dotacion.Columns.Add("Remision")
        lsv_Dotacion.Columns.Add("Envases")
        lsv_Dotacion.Columns.Add("Status")

        lsv_DotacionD.Columns.Add("Remision")
        lsv_DotacionD.Columns.Add("Importe")
        lsv_DotacionD.Columns.Add("IDR")
        lsv_DotacionD.Columns.Add("IDCP")
        lsv_DotacionD.Columns.Add("CB")
        lsv_DotacionD.Columns.Add("IDRU")
        lsv_DotacionD.Columns.Add("IDC")
        lsv_DotacionD.Columns.Add("EO")
        lsv_DotacionD.Columns.Add("ED")
        lsv_DotacionD.Columns.Add("FE")

        lsv_envases.Columns.Add("Tipo Numero")
        lsv_envases.Columns.Add("Numero")


        Call LlenaLista()
    End Sub

    Private Sub lsv_Ventas_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Dotacion.ItemChecked
        If lsv_Dotacion.CheckedItems.Count = 0 Then
            btn_Cancelar.Enabled = False
        Else
            btn_Cancelar.Enabled = True
        End If
    End Sub

    Private Sub lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Dotacion.SelectedItems.Count = 0 Then
            lsv_DotacionD.Items.Clear()
        Else
            Cn_Proceso.fn_CancelaEnvioBovedaDLlenalista(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)
            'lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotacion.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_DotacionD.Items.Count)


    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        Dim Elementos As ListViewItem

        If lsv_Dotacion.CheckedItems.Count = 0 Then
            MsgBox("Selecciona, una venta ", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        For Each Elementos In lsv_Dotacion.CheckedItems
            If Cn_Proceso.fn_ValidaCanceaEnvioBoveda(Elementos.Tag) = True Then
                MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, Me.Text)
                LlenaLista()
                Exit Sub
            End If

        Next

        frm.Bloquear = True
        frm.ShowDialog()

        If frm.Firma = True Then
            Try
                For Each Elementos In lsv_Dotacion.CheckedItems
                    Cn_Proceso.fn_CancelaBoveda_Cancelar(Elementos.Tag)
                Next

            Catch ex As Exception
                MsgBox("Error al Cancelar", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End Try

            MsgBox("Operacion Exitosa", MsgBoxStyle.Information, Me.Text)
            Call LlenaLista()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LlenaLista()
        Cn_Proceso.fn_CancelaEnvioBovedaLlenalista(lsv_Dotacion)
        lsv_Dotacion.CheckBoxes = True
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotacion.Items.Count)
    End Sub

    Private Sub lsv_Dotacion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.MouseHover, lsv_DotacionD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

   
    Private Sub lsv_DotacionD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_DotacionD.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_envases.Items.Clear()
        If lsv_DotacionD.Items.Count > 0 AndAlso lsv_DotacionD.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_DotacionD.SelectedItems(0).SubItems(3).Text, lsv_envases)
        End If

        lbl_registros3.Text = "Registros: " & lsv_envases.Items.Count
    End Sub
End Class