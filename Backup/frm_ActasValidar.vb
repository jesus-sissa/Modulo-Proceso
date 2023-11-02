
Public Class frm_ActasValidar

    Private Sub frm_ValidarActas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_CajaBancaria.Actualizar()
        cmb_Cia.Actualizar()
        cmb_Sesion.AgregaParametro("@Fecha", dtp_Fecha.Value, 2)
        cmb_Sesion.Actualizar()

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
        lsv_Actas.Columns.Add("Comentarios", 0)
        lsv_Actas.Columns.Add("Comentarios1", 0)
        lsv_Actas.Columns.Add("Comentarios2", 0)
        ' ActualizarClientes()

        cmb_ComboDiferencias.AgregaParametro("@Tipo", "0", 1)
        cmb_ComboDiferencias.AgregaParametro("@Status", "A", 0)
        cmb_ComboDiferencias.Actualizar()

        cmb_TipoDiferencia.AgregarItem("C", "CONTRA REMISION")
        cmb_TipoDiferencia.AgregarItem("F", "EN FICHA")
        cmb_TipoDiferencia.AgregarItem("P", "EN PARCIAL")

    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        Dim Sumador As Integer
        SegundosDesconexion = 0
        If lsv_Actas.SelectedItems.Count = 0 Then Exit Sub

        If rtb_Validacion.Text.Length < 15 Then
            MsgBox("La observación para Validación debe ser mas extensa.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Validacion.Focus()
            Exit Sub
        End If

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()

        If frm.Firma = True Then
            frm.Close()
            Call Cn_Proceso.fn_ValidarActas(lsv_Actas.SelectedItems(0).Tag, rtb_Validacion.Text.Trim.ToUpper, CInt(cmb_ComboDiferencias.SelectedValue))
            cmb_ComboDiferencias.SelectedValue = "0"
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
                    If (row("Rem_Efvo") - row("Real_Ficha")) + (row("Rem_Doc") - row("Real_Doc")) > 0 Then
                        Sumador += 1
                    ElseIf (row("Rem_Efvo") - row("Real_Ficha")) + (row("Rem_Doc") - row("Real_Doc")) < 0 Then
                        Sumador += 1
                    End If
                Next

                If Sumador <= 1 Then
                    Dim rpt As New rpt_ActaDiferencias
                    frm_Reporte.crv.ReportSource = rpt
                    rpt.SetDataSource(Ds)
                ElseIf Sumador > 1 Then
                    Dim rpt As New rpt_ActaDiferencias2
                    frm_Reporte.crv.ReportSource = rpt
                    rpt.SetDataSource(Ds)
                End If

            End If

            frm_Reporte.ShowDialog()
            Me.Cursor = Cursors.Default

            Call LlenaLista()
            rtb_Validacion.Clear()
            rtb_Comentarios.Clear()
            rtb_Comentarios2.Clear()

        End If

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

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click

        Me.Close()

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click

        SegundosDesconexion = 0
        Call LlenaLista()

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click

        SegundosDesconexion = 0
        If lsv_Actas.SelectedItems.Count = 0 Then Exit Sub

        If rtb_Validacion.Text.Length < 15 Then
            MsgBox("La observación para Cancelación debe ser mas extensa.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Validacion.Focus()
            Exit Sub
        End If

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()

        If frm.Firma = True Then
            Call Cn_Proceso.fn_CancelarActas(lsv_Actas.SelectedItems(0).Tag, rtb_Validacion.Text.Trim.ToUpper)
            Call LlenaLista()
            rtb_Validacion.Clear()
            rtb_Comentarios.Clear()
            rtb_Comentarios2.Clear()
        End If

    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clientes.SelectedValueChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

    Private Sub cmb_Sesion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sesion.SelectedValueChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        SegundosDesconexion = 0
        Call Limpiar()
        cmb_Sesion.ActualizaValorParametro("@Fecha", dtp_Fecha.Value)
        cmb_Sesion.Actualizar()
        If cmb_Sesion.Items.Count = 2 Then
            cmb_Sesion.SelectedIndex = 1
        End If

    End Sub

    Private Sub lsv_Actas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Actas.SelectedIndexChanged
        SegundosDesconexion = 0
        rtb_Comentarios.Clear()
        rtb_Comentarios2.Clear()
        If lsv_Actas.SelectedItems.Count = 0 Then
            rtb_Comentarios.Clear()
            rtb_Comentarios2.Clear()
            btn_Validar.Enabled = False
            btn_Cancelar.Enabled = False
            Exit Sub
        Else
            btn_Validar.Enabled = True
            btn_Cancelar.Enabled = True
        End If

        rtb_Comentarios.Text = lsv_Actas.SelectedItems(0).SubItems(8).Text
        If lsv_Actas.SelectedItems(0).SubItems(7).Text = "VALIDADA" Then
            rtb_Comentarios2.Text = lsv_Actas.SelectedItems(0).SubItems(9).Text
        ElseIf lsv_Actas.SelectedItems(0).SubItems(7).Text = "CANCELADA" Then
            rtb_Comentarios2.Text = lsv_Actas.SelectedItems(0).SubItems(10).Text
        End If

    End Sub

    Private Sub frm_ValidarActas_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        rtb_Comentarios.Width = (gbx_Actas.Width / 2) - 15
        rtb_Comentarios2.Width = rtb_Comentarios.Width
        rtb_Comentarios2.Left = rtb_Comentarios.Left + rtb_Comentarios.Width + 20
    End Sub

    Sub Limpiar()
        lsv_Actas.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Actas, lsv_Actas.Items.Count)
        rtb_Comentarios.Clear()
        rtb_Comentarios2.Clear()
        rtb_Validacion.Clear()
        btn_Cancelar.Enabled = False
        btn_Validar.Enabled = False
    End Sub

    Sub LlenaLista()
        lsv_Actas.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Actas, lsv_Actas.Items.Count)

        If cmb_Sesion.SelectedValue = "0" Then
            MsgBox("Seleccione la Sesión.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Sesion.Focus()
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

        If Not Cn_Proceso.fn_ValidarActasLlenalista(lsv_Actas, CInt(cmb_Clientes.SelectedValue), CInt(cmb_CajaBancaria.SelectedValue), CInt(cmb_Sesion.SelectedValue), CInt(cmb_Cia.SelectedValue), cmb_TipoDiferencia.SelectedValue) Then
            MsgBox("Ocurrio un error al Cargar la lista de Actas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        FuncionesGlobales.RegistrosNum(lbl_Actas, lsv_Actas.Items.Count)

    End Sub

    Private Sub rtb_Validacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Validacion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
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

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

    Private Sub chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Clientes.CheckedChanged
        SegundosDesconexion = 0
        cmb_Clientes.Enabled = Not chk_Clientes.Checked
        Call Limpiar()
    End Sub

    Private Sub lsv_Actas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Actas.DoubleClick
        Dim frm As New frm_ActasReporteD
        frm.Id_Remision = lsv_Actas.SelectedItems(0).SubItems(11).Text
        frm.lbl_RemisionNum.Text = FormatCurrency(lsv_Actas.SelectedItems(0).SubItems(12).Text)
        frm.ShowDialog()
    End Sub

    Private Sub chk_TodosCajas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TodosCajas.CheckedChanged
        cmb_CajaBancaria.SelectedValue = 0
        cmb_CajaBancaria.Enabled = Not chk_TodosCajas.Checked
        Call Limpiar()
    End Sub

    Private Sub chk_TodasCias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TodasCias.CheckedChanged
        cmb_Cia.SelectedValue = 0
        cmb_Cia.Enabled = Not chk_TodasCias.Checked
        Call Limpiar()
    End Sub

    Private Sub chk_Diferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Diferencia.CheckedChanged
        cmb_TipoDiferencia.SelectedValue = 0
        cmb_TipoDiferencia.Enabled = Not chk_Diferencia.Checked
        Call Limpiar()
    End Sub
End Class