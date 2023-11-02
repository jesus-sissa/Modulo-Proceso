Public Class frm_DotacionesCancelar

    Private Sub frm_CancelaDotaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Lsv_Dotacion.Columns.Add("Remision")
        Lsv_Dotacion.Columns.Add("CajaBancaria")
        Lsv_Dotacion.Columns.Add("Cliente")
        Lsv_Dotacion.Columns.Add("FechaCaptura")
        Lsv_Dotacion.Columns.Add("FechaEntrega")
        Lsv_Dotacion.Columns.Add("Moneda")
        Lsv_Dotacion.Columns.Add("Importe")
        Lsv_Dotacion.Columns.Add("Envases")
        Lsv_Dotacion.Columns.Add("Status")
        
        Lsv_DotacionD.Columns.Add("Denominacion")
        Lsv_DotacionD.Columns.Add("Cantidad")
        Lsv_DotacionD.Columns.Add("CantidadA")
        Lsv_DotacionD.Columns.Add("CantidadB")
        Lsv_DotacionD.Columns.Add("CantidadC")
        Lsv_DotacionD.Columns.Add("CantidadD")
        Lsv_DotacionD.Columns.Add("CantidadE")
        Lsv_DotacionD.Columns.Add("Importe")

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

        cmb_CajaBancaria.Actualizar()

    End Sub

    Private Sub Lsv_Dotacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Dotacion.SelectedIndexChanged

       
        SegundosDesconexion = 0

        Lsv_DotacionD.Items.Clear()
        lsv_Envases.Items.Clear()
        btn_Cancelar.Enabled = False

        If Lsv_Dotacion.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_ValidaDotDLlenalista(Lsv_DotacionD, Lsv_Dotacion.SelectedItems(0).Tag)

            Lsv_DotacionD.Columns(0).TextAlign = HorizontalAlignment.Right
            Lsv_DotacionD.Columns(1).TextAlign = HorizontalAlignment.Right
            Lsv_DotacionD.Columns(2).TextAlign = HorizontalAlignment.Right
            Lsv_DotacionD.Columns(3).TextAlign = HorizontalAlignment.Right
            Lsv_DotacionD.Columns(4).TextAlign = HorizontalAlignment.Right
            Lsv_DotacionD.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_DotacionD.Columns(6).TextAlign = HorizontalAlignment.Right
            Cn_Proceso.fn_Get_Envases2(Lsv_Dotacion.SelectedItems(0).SubItems(9).Text, lsv_Envases)
            btn_Cancelar.Enabled = True
        End If

        FuncionesGlobales.RegistrosNum(Lbl_Registros1, Lsv_DotacionD.Items.Count)
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = True
        frm.Min_Caracteres_Obs = 0

        frm.ShowDialog()
        If frm.Firma Then
            If Cn_Proceso.fn_CancelaDotaciones(Lsv_Dotacion.SelectedItems(0).Tag, frm.Observaciones) Then
                MsgBox("Registro Cancelado.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            Call LlenaLista()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub ckb_Caja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_Caja.CheckedChanged
        SegundosDesconexion = 0
        If ckb_Caja.Checked = True Then
            cmb_CajaBancaria.Enabled = False
            tbx_CajaBancaria.Enabled = False
            tbx_CajaBancaria.Text = ""
            cmb_CajaBancaria.SelectedIndex = 0
            Call LlenaLista()
        Else
            Lsv_Dotacion.Items.Clear()
            Lsv_DotacionD.Items.Clear()
            FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
            FuncionesGlobales.RegistrosNum(Lbl_Registros1, 0)
            cmb_CajaBancaria.Enabled = True
            tbx_CajaBancaria.Enabled = True
        End If
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged

        Call LlenaLista()
    End Sub

    Private Sub LlenaLista()
        SegundosDesconexion = 0

        Lsv_Dotacion.Items.Clear()
        Lsv_DotacionD.Items.Clear()
        lsv_Envases.Items.Clear()
        btn_Cancelar.Enabled = False
        If cmb_CajaBancaria.Enabled And cmb_CajaBancaria.SelectedValue = 0 Then Exit Sub

        Cn_Proceso.fn_CancelaDotLlenalista(Lsv_Dotacion, cmb_CajaBancaria.SelectedValue)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, Lsv_Dotacion.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, Lsv_DotacionD.Items.Count)
    End Sub

    Private Sub Lsv_Dotacion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Dotacion.MouseHover, Lsv_DotacionD.MouseHover
        SegundosDesconexion = 0
    End Sub


    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged

    End Sub

    Private Sub Lsv_DotacionD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_DotacionD.SelectedIndexChanged

    End Sub

   
    Private Sub Lsv_Dotacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Dotacion.Click
      
    End Sub

   

    Private Sub Gbx_Filtro_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbx_Filtro.Enter

    End Sub
End Class