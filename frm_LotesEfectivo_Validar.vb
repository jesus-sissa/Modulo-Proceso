Public Class frm_LotesEfectivo_Validar

    Private Sub frm_LotesEfectivo_Validar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_CajaBancaria.Actualizar()

        cmb_Origen.AgregarItem("5", "MORRALLA")
        cmb_Origen.AgregarItem("7", "CAJEROS")
        cmb_Origen.AgregarItem("8", "CLASIFICADO")
        cmb_Origen.AgregarItem("9", "NOMINAS")
        cmb_Origen.AgregarItem("16", "CAJA GENERAL")
        cmb_Origen.AgregarItem("26", "CAJERO VERIFICADOR")

        Lsv_Efectivo.Columns.Add("Remision")
        Lsv_Efectivo.Columns.Add("Caja Origen")
        Lsv_Efectivo.Columns.Add("Caja Destino")
        Lsv_Efectivo.Columns.Add("Usuario")
        Lsv_Efectivo.Columns.Add("Fecha Envia")
        Lsv_Efectivo.Columns.Add("Hora Envia")
        Lsv_Efectivo.Columns.Add("Moneda")
        Lsv_Efectivo.Columns.Add("Importe")
        Lsv_Efectivo.Columns.Add("Envases")

        Lsv_EfectivoD.Columns.Clear()
        Lsv_EfectivoD.Columns.Add("Denominacion")
        Lsv_EfectivoD.Columns.Add("Cantidad")
        Lsv_EfectivoD.Columns.Add("CantidadA")
        Lsv_EfectivoD.Columns.Add("CantidadB")
        Lsv_EfectivoD.Columns.Add("CantidadC")
        Lsv_EfectivoD.Columns.Add("CantidadD")
        Lsv_EfectivoD.Columns.Add("CantidadE")
        Lsv_EfectivoD.Columns.Add("Importe")

        lsv_Envases.Columns.Add("Tipo Numero")
        lsv_Envases.Columns.Add("Envase")


    End Sub

    Private Sub ckb_Caja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Caja.CheckedChanged
        SegundosDesconexion = 0
        Lsv_Efectivo.Items.Clear()
        Lsv_EfectivoD.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros3.Text = "Registros: 0"
        btn_Validar.Enabled = False

        cmb_CajaBancaria.SelectedIndex = 0
        If chk_Caja.Checked = True Then
            cmb_CajaBancaria.Enabled = False
        Else
            cmb_CajaBancaria.Enabled = True
        End If

        Call LlenaLista()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LlenaLista()
    End Sub

    Private Sub cmb_Origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Origen.SelectedIndexChanged
        Call LlenaLista()
    End Sub

    Private Sub LlenaLista()
        SegundosDesconexion = 0
        Lsv_Efectivo.Items.Clear()
        Lsv_EfectivoD.Items.Clear()
        lsv_Envases.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros3.Text = "Registros: 0"
        lbl_Registros2.Text = "Registros: 0"
        btn_Validar.Enabled = False

        If cmb_Origen.SelectedValue = 0 Then
            Exit Sub
        End If
        If cmb_CajaBancaria.Enabled = True AndAlso cmb_CajaBancaria.SelectedValue = 0 Then
            Exit Sub
        End If

        If Not Cn_Proceso.fn_CancelaEnvioEfectivoLlenalista(Lsv_Efectivo, cmb_CajaBancaria.SelectedValue, cmb_Origen.SelectedValue, "RC") Then
            MsgBox("Ocurrió un error al intentar consultar los Lotes Enviados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        FuncionesGlobales.RegistrosNum(Lbl_Registros, Lsv_Efectivo.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros3, Lsv_EfectivoD.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Envases.Items.Count)

    End Sub

    Private Sub Lsv_Efectivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Efectivo.SelectedIndexChanged
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
            FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Envases.Items.Count)
        End If
    End Sub

    Private Sub Lsv_Efectivo_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Efectivo.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Efectivo.CheckedItems.Count = 0 Then
            btn_Validar.Enabled = False
        Else
            btn_Validar.Enabled = True
        End If

    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        Dim firma As New frm_FirmaElectronica
        firma.ShowDialog()

        If firma.Firma Then
            Dim UsuarioRecibe As Integer = CInt(firma.tbx_Empleado.Text.Trim)

            '----verificar si existe el lote a Recibir status='RC'
            For Each lotesVer As ListViewItem In Lsv_Efectivo.CheckedItems
                If Not Cn_Proceso.fn_LoteEfectivo_Verificar(lotesVer.Tag, "RC") Then
                    MsgBox("Algunos de los Lotes ya no esta disponibles u Ocurrió un error al consultar lotes, se actualizará la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Call LlenaLista()
                    Exit Sub
                End If
            Next

            ''-----Pendiente este va en validacion ----'status ='VA'
            If Cn_Proceso.fn_AceptaEnvioEfectivoProceso(Lsv_Efectivo, UsuarioRecibe) Then
                MsgBox("Lote(s) Validado(s) correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("Ocurrió un error al recibir los lotes.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

            Call LlenaLista()

        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class