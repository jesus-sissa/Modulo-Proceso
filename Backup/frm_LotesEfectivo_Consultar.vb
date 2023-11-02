Public Class frm_LotesEfectivo_Consultar


    Private Sub frm_LotesEfectivo_Consultar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_CajaBancaria.Actualizar()

        '---cuando son eviados mostrar
        cmb_Destino.AgregarItem("1", "MORRALLA")
        cmb_Destino.AgregarItem("2", "CAJEROS")
        cmb_Destino.AgregarItem("3", "CLASIFICADO")
        cmb_Destino.AgregarItem("4", "NOMINAS")
        cmb_Destino.AgregarItem("15", "CAJA GENERAL")
        cmb_Destino.AgregarItem("25", "OTROS")
        '-+-----

        '--Cuando son para recibir --------
        cmb_Origen.AgregarItem("5", "MORRALLA")
        cmb_Origen.AgregarItem("7", "CAJEROS")
        cmb_Origen.AgregarItem("8", "CLASIFICADO")
        cmb_Origen.AgregarItem("9", "NOMINAS")
        cmb_Origen.AgregarItem("16", "CAJA GENERAL")
        cmb_Origen.AgregarItem("26", "CAJERO VERIFICADOR")
        '-*---------------

        With lsv_EfectivoE
            .Columns.Add("Remision")
            .Columns.Add("Caja Origen")
            .Columns.Add("Caja Destino")
            .Columns.Add("Destino")
            .Columns.Add("Usuario")
            .Columns.Add("Fecha Envia")
            .Columns.Add("Hora Envia")
            .Columns.Add("Moneda")
            .Columns.Add("Importe")
            .Columns.Add("Envases")
        End With

        With lsv_EfectivoED
            .Columns.Clear()
            .Items.Clear()
            .Columns.Add("Denominacion")
            .Columns.Add("Cantidad")
            .Columns.Add("CantidadA")
            .Columns.Add("CantidadB")
            .Columns.Add("CantidadC")
            .Columns.Add("CantidadD")
            .Columns.Add("CantidadE")
            .Columns.Add("Importe")
        End With


        With lsv_EfectivoR
            .Columns.Add("Remision")
            .Columns.Add("Caja Origen")
            .Columns.Add("Caja Destino")
            .Columns.Add("Destino")
            .Columns.Add("Usuario")
            .Columns.Add("Fecha Envia")
            .Columns.Add("Hora Envia")
            .Columns.Add("Moneda")
            .Columns.Add("Importe")
            .Columns.Add("Envases")
        End With

        With lsv_EfectivoRD
            .Columns.Clear()
            .Columns.Add("Denominacion")
            .Columns.Add("Cantidad")
            .Columns.Add("CantidadA")
            .Columns.Add("CantidadB")
            .Columns.Add("CantidadC")
            .Columns.Add("CantidadD")
            .Columns.Add("CantidadE")
            .Columns.Add("Importe")
        End With

    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0

        lsv_EfectivoE.Items.Clear()
        lsv_EfectivoED.Items.Clear()
        lsv_EfectivoR.Items.Clear()
        lsv_EfectivoRD.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesE, lsv_EfectivoE.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesED, lsv_EfectivoED.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesR, lsv_EfectivoR.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesRD, lsv_EfectivoRD.Items.Count)
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MostrarLotesEnviados.Click
        Call LimpiarListas()

        If cmb_CajaBancaria.SelectedValue = 0 AndAlso Not chk_CajaTodos.Checked Then
            MsgBox("Seleccione una Caja Bancaria o marque la casilla <Todos>.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If

        If cmb_Destino.SelectedValue = 0 Then
            MsgBox("Deleccione un Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Destino.Focus()
            Exit Sub
        End If


        Call LlenarListaLotesEnviados()
    End Sub

    Private Sub LlenarListaLotesEnviados()
        SegundosDesconexion = 0

        If Not Cn_Proceso.fn_ReporteLotesEfectivo_ConsultarE(lsv_EfectivoE, cmb_CajaBancaria.SelectedValue, cmb_Destino.SelectedValue, _
                                                     dtp_Desde.Value.Date, dtp_Hasta.Value.Date) Then
            MsgBox("Ocurrió un error al intentar consultar los Lotes de Efectivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesE, lsv_EfectivoE.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesED, lsv_EfectivoED.Items.Count)
    End Sub

    Private Sub btn_MostrarLotesRecibidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MostrarLotesRecibidos.Click
        SegundosDesconexion = 0

        If cmb_CajaBancaria.SelectedValue = 0 AndAlso Not chk_CajaTodos.Checked Then
            MsgBox("Seleccione una Caja Bancaria o marque la casilla <Todos>.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If

        If cmb_Origen.SelectedValue = 0 Then
            MsgBox("Seleccione un Origen.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Origen.Focus()
            Exit Sub
        End If
        Call LlenarListaLotesRecibidos()
    End Sub

    Private Sub LlenarListaLotesRecibidos()
        SegundosDesconexion = 0

        If Not Cn_Proceso.fn_ReporteLotesEfectivo_ConsultarR(lsv_EfectivoR, cmb_CajaBancaria.SelectedValue, cmb_Origen.SelectedValue, _
                                                     dtp_Desde.Value.Date, dtp_Hasta.Value.Date) Then
            MsgBox("Ocurrió un error al intentar consultar los Lotes de Efectivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesR, lsv_EfectivoR.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesRD, lsv_EfectivoRD.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub



    Private Sub lsv_EfectivoE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_EfectivoE.SelectedIndexChanged
        lsv_EfectivoED.Items.Clear()
        lbl_RegistrosLotesED.Text = "Registros: 0"

        If lsv_EfectivoE.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_CancelaEnvioEfectivoDLlenalista(lsv_EfectivoED, lsv_EfectivoE.SelectedItems(0).Tag)

            lsv_EfectivoED.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv_EfectivoED.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_EfectivoED.Columns(3).TextAlign = HorizontalAlignment.Right
        Else
            lsv_EfectivoED.Items.Clear()
        End If

        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesED, lsv_EfectivoED.Items.Count)
    End Sub

    Private Sub chk_CajaTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_CajaTodos.CheckedChanged
        Call LimpiarListas()
        If chk_CajaTodos.Checked = True Then
            cmb_CajaBancaria.Enabled = False
            cmb_CajaBancaria.SelectedIndex = 0
        Else
            cmb_CajaBancaria.Enabled = True
        End If

        lsv_EfectivoE.Items.Clear()
        lsv_EfectivoED.Items.Clear()
        lsv_EfectivoR.Items.Clear()
        lsv_EfectivoRD.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesR, lsv_EfectivoR.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesRD, lsv_EfectivoRD.Items.Count)

        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesE, lsv_EfectivoE.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesED, lsv_EfectivoED.Items.Count)
    End Sub

    Private Sub chk_DestinoTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DestinoTodos.CheckedChanged
        Call LimpiarListas()
        If chk_DestinoTodos.Checked = True Then
            cmb_Destino.Enabled = False
            cmb_Destino.SelectedIndex = 0

        Else
            cmb_Destino.Enabled = True
        End If
    End Sub

    Private Sub chk_OrigenTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_OrigenTodos.CheckedChanged
        Call LimpiarListas()
        If chk_OrigenTodos.Checked = True Then
            cmb_Origen.Enabled = False
            cmb_Origen.SelectedIndex = 0

        Else
            cmb_Origen.Enabled = True
        End If
    End Sub

    Private Sub lsv_EfectivoR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_EfectivoR.SelectedIndexChanged
        lsv_EfectivoRD.Items.Clear()
        lbl_RegistrosLotesRD.Text = "Registros: 0"

        If lsv_EfectivoR.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_CancelaEnvioEfectivoDLlenalista(lsv_EfectivoRD, lsv_EfectivoR.SelectedItems(0).Tag)

            lsv_EfectivoRD.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv_EfectivoRD.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_EfectivoRD.Columns(3).TextAlign = HorizontalAlignment.Right
        Else
            lsv_EfectivoRD.Items.Clear()
        End If
        FuncionesGlobales.RegistrosNum(lbl_RegistrosLotesRD, lsv_EfectivoRD.Items.Count)
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Destino_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Destino.SelectedValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Origen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Origen.SelectedValueChanged
        Call LimpiarListas()
    End Sub
End Class