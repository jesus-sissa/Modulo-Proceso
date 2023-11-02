Public Class frm_LotesEfectivo_Enviar

    Private Sub frm_LotesEfectivo_Enviar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False
        cmb_CajaBancaria.Actualizar()
        BanderA = True
        cmb_Destino.AgregarItem("1", "MORRALLA")
        cmb_Destino.AgregarItem("2", "CAJEROS")
        cmb_Destino.AgregarItem("3", "CLASIFICADO")
        cmb_Destino.AgregarItem("4", "NOMINAS")
        cmb_Destino.AgregarItem("15", "CAJA GENERAL")
        cmb_Destino.AgregarItem("25", "OTROS")

        Lsv_Efectivo.Columns.Add("Remision")
        Lsv_Efectivo.Columns.Add("Caja")
        Lsv_Efectivo.Columns.Add("Usuario")
        Lsv_Efectivo.Columns.Add("Fecha Envia")
        Lsv_Efectivo.Columns.Add("Hora Envia")
        Lsv_Efectivo.Columns.Add("Moneda")
        Lsv_Efectivo.Columns.Add("Importe")
        Lsv_Efectivo.Columns.Add("Envases")

        Lsv_EfectivoD.Columns.Clear()
        Lsv_EfectivoD.Items.Clear()
        Lsv_EfectivoD.Columns.Add("Denominacion")
        Lsv_EfectivoD.Columns.Add("Cantidad")
        Lsv_EfectivoD.Columns.Add("CantidadA")
        Lsv_EfectivoD.Columns.Add("CantidadB")
        Lsv_EfectivoD.Columns.Add("CantidadC")
        Lsv_EfectivoD.Columns.Add("CantidadD")
        Lsv_EfectivoD.Columns.Add("CantidadE")
        Lsv_EfectivoD.Columns.Add("Importe")

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

    End Sub

    Private Sub Lsv_Efectivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Efectivo.SelectedIndexChanged
        SegundosDesconexion = 0
        Lsv_EfectivoD.Items.Clear()
        Lbl_Registros3.Text = "Registros: 0"

        If Lsv_Efectivo.SelectedItems.Count > 0 Then
            If Not Cn_Proceso.fn_CancelaEnvioEfectivoDLlenalista(Lsv_EfectivoD, Lsv_Efectivo.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un error al intentar consultar el desglose del Lote Seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If Not Cn_Proceso.fn_CancelarEnvioProceso_Envases(Lsv_Efectivo.SelectedItems(0).SubItems(10).Text, lsv_Envases) Then
                MsgBox("Ocurrió un error al intentar consultar el desglose del Lote Seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            FuncionesGlobales.RegistrosNum(Lbl_Registros3, Lsv_EfectivoD.Items.Count)
        End If

    End Sub

    Private Sub Lsv_Efectivo_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Efectivo.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Efectivo.CheckedItems.Count = 0 Then
            btn_Enviar.Enabled = False
        Else
            btn_Enviar.Enabled = True
        End If
    End Sub

    Private Sub btn_Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Enviar.Click
        SegundosDesconexion = 0

        '----verificar si existe el lote a Enviar Status='A'
        For Each lotesVer As ListViewItem In Lsv_Efectivo.CheckedItems
            If Not Cn_Proceso.fn_LoteEfectivo_Verificar(lotesVer.Tag, "A") Then
                MsgBox("Algunos de los Lotes ya no esta disponibles u Ocurrió un error al consultar lotes, se actualizará la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call LlenaLista()
                Exit Sub
            End If
        Next
        ''-----enviar Lotes de efectivo

        If Cn_Proceso.fn_LotesEfectivo_Status(Lsv_Efectivo, "E") Then
            MsgBox("Lotes(s) Enviado(s) correctamente", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ocurrió un error al enviar los lotes.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Call LlenaLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub LlenaLista()
        SegundosDesconexion = 0

        Lsv_Efectivo.Items.Clear()
        Lsv_EfectivoD.Items.Clear()
        lsv_Envases.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros3.Text = "Registros: 0"
        lbl_Registros2.Text = "Registros: 0"
        btn_Enviar.Enabled = False

        If Not Cn_Proceso.fn_CancelaEnvioEfectivoLlenalista(Lsv_Efectivo, cmb_CajaBancaria.SelectedValue, cmb_Destino.SelectedValue, "A") Then
            MsgBox("Ocurrió un error al intentar consultar los Lotes Enviados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, Lsv_Efectivo.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros3, Lsv_EfectivoD.Items.Count)

    End Sub

    Private Sub chk_CajaTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_CajaTodos.CheckedChanged
        Lsv_Efectivo.Items.Clear()
        Lsv_EfectivoD.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros3.Text = "Registros: 0"

        If chk_CajaTodos.Checked = True Then
            cmb_CajaBancaria.Enabled = False
            cmb_CajaBancaria.SelectedIndex = 0

            If cmb_Destino.SelectedValue <> "0" Then Call LlenaLista()
        Else
            cmb_CajaBancaria.Enabled = True
        End If
    End Sub

    Private Sub cmb_Destino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Destino.SelectedIndexChanged

        If cmb_Destino.SelectedValue = "0" Then Exit Sub

        If cmb_CajaBancaria.SelectedValue = 0 AndAlso Not chk_CajaTodos.Checked Then
            MsgBox("Seleccione una Caja Bancaria o marque la casilla «Todos» . ", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If

        If cmb_Destino.SelectedValue <> "0" Then
            Call LlenaLista()
        End If

    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        If BanderA Then
            If cmb_Destino.SelectedValue = "0" Then
                'MsgBox("Seleccione un destino. ", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Destino.Focus()
                Exit Sub
            Else
                Call LlenaLista()
            End If
        End If
    End Sub
End Class