
Public Class frm_ActasReporte

    Private Sub frm_ReporteActas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_CajaBancaria.Actualizar()
        'cmb_Cliente.Actualizar(Cn_Proceso.fn_ValidarActas_LlenarClientes(cmb_CajaBancaria.SelectedValue))
        cmb_SesionDesde.AgregaParametro("@Fecha", dtp_Desde.Value, 2)
        cmb_SesionDesde.Actualizar()

        cmb_Cia.Actualizar()

        cmb_SesionHasta.AgregaParametro("@Fecha", dtp_Hasta.Value, 2)
        cmb_SesionHasta.Actualizar()

        cmb_Clientes.AgregaParametro("@Id_CajaBancaria", -1, 1)
        cmb_Clientes.AgregaParametro("@Id_Cia", -1, 1)
        cmb_Clientes.AgregaParametro("@Status", "A", 0)
        cmb_Clientes.Actualizar()


        lsv_Actas.Columns.Add("Fecha")
        lsv_Actas.Columns.Add("Acta")
        lsv_Actas.Columns.Add("Remision")
        lsv_Actas.Columns.Add("Caja")
        lsv_Actas.Columns.Add("Cliente")
        lsv_Actas.Columns.Add("Tipo Diferencia")
        lsv_Actas.Columns.Add("Nombre")
        lsv_Actas.Columns.Add("Status")


        cmb_TipoDiferencia.AgregarItem("C", "CONTRA REMISION")
        cmb_TipoDiferencia.AgregarItem("F", "EN FICHA")
        cmb_TipoDiferencia.AgregarItem("P", "EN PARCIAL")

    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged

        SegundosDesconexion = 0
        Call Limpiar()
        cmb_SesionDesde.ActualizaValorParametro("@Fecha", dtp_Desde.Value)
        cmb_SesionDesde.Actualizar()
        If cmb_SesionDesde.Items.Count = 2 Then
            cmb_SesionDesde.SelectedIndex = 1
        End If

    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged

        SegundosDesconexion = 0
        Call Limpiar()
        cmb_SesionHasta.ActualizaValorParametro("@Fecha", dtp_Hasta.Value)
        cmb_SesionHasta.Actualizar()
        If cmb_SesionHasta.Items.Count = 2 Then
            cmb_SesionHasta.SelectedIndex = 1
        End If

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click

        SegundosDesconexion = 0
        Call LlenaLista()

    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click

        SegundosDesconexion = 0
        If lsv_Actas.Items.Count = 0 Then Exit Sub
        FuncionesGlobales.fn_Exportar_Excel(lsv_Actas, 2, "REPORTE DE ACTAS", 0, 3, frm_MENU.prg_Barra)

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click

        Me.Close()

    End Sub

    Private Sub cmb_Sesion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_SesionDesde.SelectedValueChanged, cmb_SesionHasta.SelectedValueChanged

        SegundosDesconexion = 0
        Call Limpiar()

    End Sub

    Private Sub chk_Cajas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cajas.CheckedChanged

        SegundosDesconexion = 0
        cmb_CajaBancaria.SelectedValue = "0"
        cmb_CajaBancaria.Enabled = False = chk_Cajas.Checked
        Call Limpiar()

    End Sub

    Private Sub Chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Clientes.CheckedChanged

        SegundosDesconexion = 0
        cmb_Clientes.SelectedValue = "0"
        cmb_Clientes.Enabled = False = Chk_Clientes.Checked
        Call Limpiar()

    End Sub

    Private Sub lsv_Actas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Actas.SelectedIndexChanged

        SegundosDesconexion = 0
        If lsv_Actas.SelectedItems.Count = 0 Then
            rtb_Comentarios.Clear()
            rtb_Comentarios2.Clear()
            btn_Reporte.Enabled = False
            Exit Sub
        Else
            btn_Reporte.Enabled = True
        End If

        'If lsv_Actas.SelectedItems(0).SubItems(5).Text = "CONTRA REMISION" Then
        '    btn_Reporte.Enabled = False
        'Else
        '    btn_Reporte.Enabled = True
        'End If


        rtb_Comentarios.Clear()
        rtb_Comentarios2.Clear()
        rtb_Comentarios.Text = lsv_Actas.SelectedItems(0).SubItems(8).Text
        If lsv_Actas.SelectedItems(0).SubItems(7).Text = "VALIDADA" Then
            rtb_Comentarios2.Text = lsv_Actas.SelectedItems(0).SubItems(9).Text
        ElseIf lsv_Actas.SelectedItems(0).SubItems(7).Text = "CANCELADA" Then
            rtb_Comentarios2.Text = lsv_Actas.SelectedItems(0).SubItems(10).Text
        End If

    End Sub

    Private Sub frm_ReporteActas_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        rtb_Comentarios.Width = (gbx_Actas.Width / 2) - 15
        rtb_Comentarios2.Width = rtb_Comentarios.Width
        rtb_Comentarios2.Left = rtb_Comentarios.Left + rtb_Comentarios.Width + 20

    End Sub

    Sub LlenaLista()

        If cmb_SesionDesde.SelectedValue = "0" Then
            MsgBox("Seleccione la Sesión.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_SesionDesde.Focus()
            Exit Sub
        End If

        If cmb_SesionHasta.SelectedValue = "0" Then
            MsgBox("Seleccione la Sesión.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_SesionHasta.Focus()
            Exit Sub
        End If

        If cmb_CajaBancaria.Enabled And cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Seleccione la Caja Bancaria o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If

        If cmb_Cia.Enabled And cmb_Cia.SelectedValue = "0" Then
            MsgBox("Seleccione la Compañia o marque la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If

        If cmb_Clientes.Enabled And cmb_Clientes.SelectedValue = "0" Then
            MsgBox("Seleccione el Cliente o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Exit Sub
        End If

        If cmb_TipoDiferencia.Enabled And cmb_TipoDiferencia.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo de Diferencia o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Clientes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        If Not Cn_Proceso.fn_ReporteActasLlenalista(lsv_Actas, CInt(cmb_Clientes.SelectedValue), CInt(cmb_CajaBancaria.SelectedValue), CInt(cmb_SesionDesde.SelectedValue), CInt(cmb_SesionHasta.SelectedValue), CInt(cmb_Cia.SelectedValue), cmb_TipoDiferencia.SelectedValue) Then
            MsgBox("Ocurrio un error al Cargar la lista de Actas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Me.Cursor = Cursors.Default
        FuncionesGlobales.RegistrosNum(lbl_Actas, lsv_Actas.Items.Count)
        If lsv_Actas.Items.Count > 0 Then btn_Exportar.Enabled = True

    End Sub

    Sub Limpiar()

        lsv_Actas.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Actas, lsv_Actas.Items.Count)
        If lsv_Actas.Items.Count > 0 Then
            btn_Exportar.Enabled = True
        Else
            btn_Exportar.Enabled = False
        End If
        rtb_Comentarios.Clear()
        rtb_Comentarios2.Clear()

    End Sub

    Private Sub btn_Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reporte.Click

        Dim Sumador As Integer = 0

        If lsv_Actas.SelectedItems.Count = 0 Then Exit Sub

        'If lsv_Actas.SelectedItems(0).SubItems(7).Text <> "VALIDADA" Then
        '    MsgBox("No se puede Reimprimir un acta PENDIENTE o CANCELADA.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    Exit Sub
        'End If

        Me.Cursor = Cursors.WaitCursor

        Dim Ds As New ds_Reportes
        Dim frm_Reporte As New frm_Reporte
        If lsv_Actas.SelectedItems(0).SubItems(5).Text = "EN FICHA" Then

            If Not Cn_Proceso.fn_ImprimirActaDiferencia(Ds.tbl_ActaDiferencia, lsv_Actas.SelectedItems(0).Tag, 1) Then
                MsgBox("No se logro Reimprimir el Acta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Call CargarEnvasesyLogo(Ds)

            Dim rpt As New rpt_ActaDiferencias
            frm_Reporte.crv.ReportSource = rpt
            rpt.SetDataSource(Ds)

        ElseIf lsv_Actas.SelectedItems(0).SubItems(5).Text = "CONTRA REMISION" Then

            If Not Cn_Proceso.fn_ImprimirActaDiferencia(Ds.tbl_ActaDiferencia, lsv_Actas.SelectedItems(0).Tag, 2) Then
                MsgBox("No se logro Reimprimir el Acta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Call CargarEnvasesyLogo(Ds)

            If Not Cn_Proceso.fn_VerificarDepositos_Resultados(Ds.Tbl_DesgloseActas, Ds.Tables("tbl_ActaDiferencia").Rows(0)("Id_Servicio")) Then
                MsgBox("No se logro Reimprimir el Acta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            For Each row As DataRow In Ds.Tables("Tbl_DesgloseActas").Rows
                If (CDec(row("Rem_Efvo")) - CDec(row("Real_Ficha"))) > 0 Or (CDec(row("Rem_Doc")) - CDec(row("Real_Doc"))) > 0 Then
                    Sumador += 1
                ElseIf (CDec(row("Rem_Efvo")) - CDec(row("Real_Ficha"))) < 0 Or (CDec(row("Rem_Doc")) - CDec(row("Real_Doc"))) < 0 Then
                    Sumador += 1
                End If
            Next

            If Sumador <= 1 Then
                Dim rpt As New rpt_ActaDiferencias
                frm_Reporte.crv.ReportSource = rpt
                rpt.SetDataSource(Ds)
            ElseIf Sumador > 1 Then
                'Por el momento queda en exit sub ya que el reporte 2 
                'aun esta en proceso de diseño 
                'MsgBox("Reporte en Construcción.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
                'Dim rpt As New rpt_ActaDiferencias2
                'frm_Reporte.crv.ReportSource = rpt
                'rpt.SetDataSource(Ds)
            End If

        End If

        frm_Reporte.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Sub CargarEnvasesyLogo(ByRef Ds As ds_Reportes)

        If Not Cn_Proceso.fn_CargarEnvasesActaDiferencia(Ds.tbl_EnvasesActa, Ds.Tables("tbl_ActaDiferencia").Rows(0)("Id_Remision")) Then
            MsgBox("No se logro Reimprimir el Acta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If Not Cn_Proceso.fn_VerReportes_LlenarLogo(Ds.Tbl_DatosEmpresa) Then
            MsgBox("No se logro Reimprimir el Acta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Limpiar()
        If cmb_Cia.SelectedValue = "0" Then Exit Sub
        cmb_Clientes.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
        cmb_Clientes.ActualizaValorParametro("@Id_Cia", cmb_Cia.SelectedValue)
        cmb_Clientes.ActualizaValorParametro("@Status", "A")
        cmb_Clientes.Actualizar()
    End Sub

    Private Sub chk_TodasCias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TodasCias.CheckedChanged
        SegundosDesconexion = 0
        cmb_Cia.SelectedValue = "0"
        cmb_Cia.Enabled = False = chk_TodasCias.Checked
        Call Limpiar()
    End Sub

    Private Sub lsv_Actas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Actas.DoubleClick

        Dim frm As New frm_ActasReporteD
        frm.Id_Remision = lsv_Actas.SelectedItems(0).SubItems(11).Text
        frm.lbl_RemisionNum.Text = FormatCurrency(lsv_Actas.SelectedItems(0).SubItems(12).Text)
        frm.ShowDialog()

    End Sub

    Private Sub chk_Diferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Diferencia.CheckedChanged
        SegundosDesconexion = 0
        cmb_TipoDiferencia.SelectedValue = "0"
        cmb_TipoDiferencia.Enabled = False = chk_Diferencia.Checked
        Call Limpiar()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        If lsv_Actas.Items.Count <> 0 Then
            Dim remision As String = lsv_Actas.SelectedItems(0).SubItems(2).Text
            Clipboard.SetText(remision)
        End If
    End Sub
End Class