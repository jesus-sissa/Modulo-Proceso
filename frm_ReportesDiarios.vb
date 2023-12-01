Imports Modulo_Proceso.Cn_Proceso
Imports CrystalDecisions.CrystalReports.Engine

Public Class frm_ReportesDiarios

    Dim FechaSugerida As Date
    Dim tbl As DataTable


    Private Sub Ver_Reporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        cmb_Moneda.Actualizar()
        cmb_CajaBancaria.Actualizar()

        'cmb_Cajero.AgregaParametro("@Id_Puesto", FuncionesGlobales.fn_ParametrosGlobales(FuncionesGlobales.ParametrosGlobales.Puesto_Cajero), 1)
        'cmb_Cajero.AgregaParametro("@Status", "A", 0)
        cmb_Cajero.Actualizar()

        cmb_Corte.AgregarParametros("@Id_Sesion", SqlDbType.Int, 0)
        cmb_Corte.AgregarParametros("@Id_CajaBancaria", SqlDbType.Int, 0)
        cmb_Corte.Actualizar()

        cmb_Sesiones.ValorParametro = dtp_Fecha.Value
        cmb_Sesiones.Actualizar()

        cmb_Reporte.AgregarItem("1", "Hoja de Trabajo")
        cmb_Reporte.AgregarItem("2", "Relacion de Servicios por Verificador")
        cmb_Reporte.AgregarItem("3", "Archivo de Depositos")

        cmb_cia.Actualizar()

        ValidarDiaSugerido()

    End Sub

    Sub ValidarDiaSugerido()
        If (Microsoft.VisualBasic.Left(frm_MENU.lbl_Hora.Text, 2)) >= 18 Then
            dtp_FechaAplicacion.Value = DateAdd(DateInterval.Day, 1, Today)

            If Today.DayOfWeek = DayOfWeek.Friday Then
                dtp_FechaAplicacion.Value = DateAdd(DateInterval.Day, 3, Today)
            ElseIf Today.DayOfWeek = DayOfWeek.Saturday Then
                dtp_FechaAplicacion.Value = DateAdd(DateInterval.Day, 2, Today)
            ElseIf Today.DayOfWeek = DayOfWeek.Sunday Then
                dtp_FechaAplicacion.Value = DateAdd(DateInterval.Day, 1, Today)
            End If
        Else
            If Today.DayOfWeek = DayOfWeek.Saturday Then
                dtp_FechaAplicacion.Value = DateAdd(DateInterval.Day, 2, Today)
            ElseIf Today.DayOfWeek = DayOfWeek.Sunday Then
                dtp_FechaAplicacion.Value = DateAdd(DateInterval.Day, 1, Today)
            End If
        End If
        lbl_DiaSemana.Text = Dias(DatePart(DateInterval.Weekday, dtp_FechaAplicacion.Value.Date, FirstDayOfWeek.Sunday))
        FechaSugerida = dtp_FechaAplicacion.Value.Date
    End Sub

    Private Sub cmb_Grupo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Grupo.SelectedValueChanged
        If cmb_Sesiones.SelectedValue Is Nothing Then Exit Sub
        cmb_Corte.LimpiarParametros()
        cmb_Corte.AgregarParametros("@Id_Sesion", SqlDbType.Int, cmb_Sesiones.SelectedValue)
        cmb_Corte.AgregarParametros("@Id_CajaBancaria", SqlDbType.Int, cmb_CajaBancaria.SelectedValue)
        cmb_Corte.Actualizar()
    End Sub

    Private Sub cmb_Sesiones_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sesiones.SelectedValueChanged
        If cmb_Sesiones.SelectedValue Is Nothing Then Exit Sub
        cmb_Corte.LimpiarParametros()
        cmb_Corte.AgregarParametros("@Id_Sesion", SqlDbType.Int, cmb_Sesiones.SelectedValue)
        cmb_Corte.AgregarParametros("@Id_CajaBancaria", SqlDbType.Int, cmb_CajaBancaria.SelectedValue)
        cmb_Corte.Actualizar()
    End Sub

    Private Sub dtp_Fecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fecha.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(Chr(Keys.Tab))
            e.Handled = True
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0
        If Validar(IIf(cmb_CajaBancaria.Text = "CAJA GENERAL BANREGIO- SISSA", False, True)) Then
            'Si es archivo de deposito
            If cmb_Reporte.SelectedValue = 3 Then
                If (cmb_CajaBancaria.Text = "CAJA GENERAL BANREGIO- SISSA") Then
                    Dim Arch As New frm_GuardarArchivo
                    Dim Dt As DataTable = fn_RemisionesApi(cmb_CajaBancaria.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Grupo.SelectedValue, cmb_Corte.SelectedValue)
                    Arch.Actualizar(Dt)
                    Arch.NombreCliente = cmb_CajaBancaria.Text
                    Arch.Fecha_Aplicacion = dtp_FechaAplicacion.Value
                    Arch.Id_CajaBancaria = cmb_CajaBancaria.SelectedValue
                    Arch.Id_Sesion = cmb_Sesiones.SelectedValue
                    Arch.Corte_Turno = cmb_Corte.SelectedValue
                    Arch.ShowDialog()

                    Exit Sub
                Else
                    'Archivo TXT de Depósitos
                    Dim Arch As New frm_GuardarArchivo
                    Arch.Id_Cia = cmb_cia.SelectedValue

                    fn_DepositoClientes_LlenarFichas(Arch.Fichas, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                    fn_DepositoClientes_LlenarFichasEfectivo(Arch.Fichas_Efectivo, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                    fn_DepositoClientes_LlenarFichasEfectivoFalso(Arch.Fichas_EfectivoFalso, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                    fn_DepositoClientes_LlenarCheques(Arch.Cheques, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                    Dim Dt As DataTable = fn_DepositoClientes_CrearTabla(cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                    Arch.Actualizar(Dt)
                    Arch.NombreCliente = cmb_CajaBancaria.Text
                    Arch.Fecha_Aplicacion = dtp_FechaAplicacion.Value
                    Arch.Id_CajaBancaria = cmb_CajaBancaria.SelectedValue
                    Arch.Id_Moneda = cmb_Moneda.SelectedValue
                    Arch.Id_Cajero = cmb_Cajero.SelectedValue
                    Arch.Id_GrupoDepo = cmb_Grupo.SelectedValue
                    Arch.Id_Sesion = cmb_Sesiones.SelectedValue
                    Arch.Corte_Turno = cmb_Corte.SelectedValue

                    Arch.ShowDialog()

                    Exit Sub
                End If

            End If

            Dim frm As New frm_Reporte
            Dim rpt As New rpt_HojaTrabajo
            Dim Ds As New ds_Reportes
            Dim Billetes As New ds_Reportes
            Dim Monedas As New ds_Reportes

            If fn_VerReportes_LlenarHojaTrabjo(Ds.Tbl_HojaTrabajo, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue) And
                fn_VerReportes_LlenarHojaTrabjo2(Billetes.Tbl_Denominacion, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, "B") And
                fn_VerReportes_LlenarHojaTrabjo2(Monedas.Tbl_Denominacion, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, "M") And
                fn_VerReportes_LlenarLogo(Ds.Tbl_DatosEmpresa) Then

                Select Case cmb_Reporte.SelectedValue
                    Case 1

                        CType(rpt.Section1.ReportObjects("str_CajaBancaria"), TextObject).Text = cmb_CajaBancaria.Text


                        If cmb_Grupo.SelectedIndex = 0 Then
                            CType(rpt.Section1.ReportObjects("str_GrupoFacturacion"), TextObject).Text = "TODOS"
                        Else
                            CType(rpt.Section1.ReportObjects("str_GrupoFacturacion"), TextObject).Text = cmb_Grupo.Text
                        End If
                        CType(rpt.Section1.ReportObjects("str_Moneda"), TextObject).Text = cmb_Moneda.Text
                        CType(rpt.Section1.ReportObjects("dat_Fecha"), TextObject).Text = dtp_Fecha.Value.ToShortDateString
                        CType(rpt.Section1.ReportObjects("int_Sesion"), TextObject).Text = cmb_Sesiones.Text
                        If cmb_Corte.SelectedValue = "0" Then
                            CType(rpt.Section1.ReportObjects("str_Corte"), TextObject).Text = "TODOS"
                        Else
                            CType(rpt.Section1.ReportObjects("str_Corte"), TextObject).Text = cmb_Corte.Text
                        End If
                    Case 2
                        CType(rpt.Section1.ReportObjects("str_CajaBancaria"), TextObject).Text = cmb_CajaBancaria.Text
                        If cmb_Cajero.SelectedIndex = 0 Then
                            CType(rpt.Section1.ReportObjects("str_GrupoFacturacion"), TextObject).Text = "TODOS"
                        Else
                            CType(rpt.Section1.ReportObjects("str_GrupoFacturacion"), TextObject).Text = cmb_Cajero.Text
                        End If
                        CType(rpt.Section1.ReportObjects("txt_Grupo"), TextObject).Text = "VERIFICADOR"
                        CType(rpt.Section1.ReportObjects("str_Moneda"), TextObject).Text = cmb_Moneda.Text
                        CType(rpt.Section1.ReportObjects("dat_Fecha"), TextObject).Text = dtp_Fecha.Value.ToShortDateString
                        CType(rpt.Section1.ReportObjects("int_Sesion"), TextObject).Text = cmb_Sesiones.Text
                        If cmb_Corte.SelectedValue = "0" Then
                            CType(rpt.Section1.ReportObjects("str_Corte"), TextObject).Text = "TODOS"
                        Else
                            CType(rpt.Section1.ReportObjects("str_Corte"), TextObject).Text = cmb_Corte.Text
                        End If


                        CType(rpt.GroupFooterSection1.ReportObjects("Text14"), TextObject).Text = ""
                        CType(rpt.GroupFooterSection1.ReportObjects("Text3"), TextObject).Color = Color.White
                        CType(rpt.GroupFooterSection1.ReportObjects("Text9"), TextObject).Text = "SERVICIOS POR VERIFICADOR"
                    Case 3 'lo puse arriba
                        'Dim Arch As New frm_GuardarArchivo
                        'Arch.Id_Cia = cmb_cia.SelectedValue

                        'fn_DepositoClientes_LlenarFichas(Arch.Fichas, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                        'fn_DepositoClientes_LlenarFichasEfectivo(Arch.Fichas_Efectivo, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                        'fn_DepositoClientes_LlenarCheques(Arch.Cheques, cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue)
                        'Arch.Actualizar(fn_DepositoClientes_CrearTabla(cmb_Moneda.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Sesiones.SelectedValue, cmb_Corte.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue))
                        'Arch.NombreCliente = cmb_CajaBancaria.Text
                        'Arch.Fecha_Aplicacion = dtp_Fecha.Value
                        'Arch.Id_CajaBancaria = cmb_CajaBancaria.SelectedValue
                        'Arch.Id_Moneda = cmb_Moneda.SelectedValue
                        'Arch.Id_Cajero = cmb_Cajero.SelectedValue
                        'Arch.Id_GrupoDepo = cmb_Grupo.SelectedValue
                        'Arch.Id_Sesion = cmb_Sesiones.SelectedValue

                        'FuncionesGlobales.MostrarVentana(Arch, False)
                        'Exit Sub
                End Select

                rpt.SetDataSource(Ds)
                frm.crv.ReportSource = rpt

                rpt.Subreports(0).SetDataSource(Billetes)
                rpt.Subreports(1).SetDataSource(Monedas)

                'FuncionesGlobales.MostrarVentana(frm, True)
                frm.WindowState = FormWindowState.Maximized
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Function Validar(type As Boolean) As Boolean
        If cmb_Reporte.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Tipo de Reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Reporte.Focus()
            Return False
        End If
        If (type = False AndAlso cmb_Moneda.SelectedValue = "0" And Not cbx_Moneda.Checked) Or (type And cmb_Moneda.SelectedValue = "0") Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If
        If cmb_Grupo.SelectedValue = "0" And (cmb_Reporte.SelectedValue = "1" Or cmb_Reporte.SelectedValue = "3") And Not cbx_TProceso.Checked Then
            MsgBox("Debe seleccionar un Grupo de Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Grupo.Focus()
            Return False
        End If
        If cmb_Sesiones.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesión.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Sesiones.Focus()
            Return False
        End If
        If cmb_Corte.SelectedValue = "0" And Not cbx_Todos.Checked Then
            MsgBox("Debe seleccionar un Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Corte.Focus()
            Return False
        End If
        If cmb_Cajero.SelectedValue = "0" And cmb_Reporte.SelectedValue = "2" And Not cbx_TCajero.Checked Then
            cmb_Cajero.Focus()
            MsgBox("Debe seleccionar un Cajero.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If (type = False AndAlso cmb_cia.SelectedValue = "0" And Not cbx_Cia.Checked) Or (type And cmb_cia.SelectedValue = "0") Then
            'If cmb_cia.SelectedValue = "0" And cmb_Reporte.SelectedValue = "3" And type And Not cbx_Cia.Checked Then
            MsgBox("Debe seleccionar una Compañía de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_cia.Focus()
            Return False
        End If

        If dtp_FechaAplicacion.Enabled Then
            If dtp_FechaAplicacion.Value.Date = FechaSugerida Then
                Return True
            Else
                If MsgBox("La Fecha de Aplicación seleccionada parece ser incorrecta. ¿ Desea continuar ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    Return False
                End If
            End If
        End If

        Return True
    End Function

    Private Sub cbx_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Todos.CheckedChanged
        If cbx_Todos.Checked Then cmb_Corte.SelectedValue = "0"
        cmb_Corte.Enabled = Not cbx_Todos.Checked
    End Sub

    Private Sub cbx_Todos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_Todos.KeyPress, cbx_TProceso.KeyPress, cbx_TCajero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0

        cmb_Grupo.ValorParametro = cmb_CajaBancaria.SelectedValue
        cmb_Grupo.Actualizar()
        CajaBanregio()
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        cmb_Sesiones.ValorParametro = dtp_Fecha.Value
        cmb_Sesiones.Actualizar()

        If cmb_Sesiones.Items.Count = 2 Then
            cmb_Sesiones.SelectedIndex = 1
        End If
    End Sub

    Private Sub cmb_Reporte_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Reporte.SelectedValueChanged
        cmb_Moneda.Enabled = cmb_Reporte.SelectedValue > "0"
        cbx_Moneda.Enabled = cmb_Reporte.SelectedValue > "0"
        cmb_CajaBancaria.Enabled = cmb_Reporte.SelectedValue > "0"
        cmb_Grupo.Enabled = cmb_Reporte.SelectedValue = "1" Or cmb_Reporte.SelectedValue = "3"
        cbx_TProceso.Enabled = cmb_Reporte.SelectedValue = "1" Or cmb_Reporte.SelectedValue = "3"
        dtp_Fecha.Enabled = cmb_Reporte.SelectedValue > "0"
        cmb_Sesiones.Enabled = cmb_Reporte.SelectedValue > "0"
        cmb_Corte.Enabled = cmb_Reporte.SelectedValue > "0"
        cbx_Todos.Enabled = cmb_Reporte.SelectedValue > "0"
        tbx_ClaveCajero.Enabled = cmb_Reporte.SelectedValue >= "2"
        cmb_Cajero.Enabled = cmb_Reporte.SelectedValue >= "2"
        cbx_TCajero.Enabled = cmb_Reporte.SelectedValue >= "2"
        cmb_cia.Enabled = cmb_Reporte.SelectedValue = "3"
        cbx_Cia.Enabled = cmb_Reporte.SelectedValue = "3"
        dtp_FechaAplicacion.Enabled = cmb_Reporte.SelectedValue = "3"

    End Sub
    Sub CajaBanregio()
        If (cmb_CajaBancaria.Text = "CAJA GENERAL BANREGIO- SISSA" And cmb_Reporte.SelectedValue = 3) Then
            'cmb_Moneda.SelectedIndex = 0
            cbx_TProceso.Checked = True
            cbx_Todos.Checked = True
            cbx_TCajero.Checked = True
            cbx_Moneda.Checked = True
            cbx_Cia.Checked = True
            'cmb_cia.SelectedIndex = 0
            'cmb_Moneda.Enabled = False
            'cmb_cia.Enabled = False
        ElseIf (cmb_Reporte.SelectedIndex > 0) Then
            'cmb_Moneda.SelectedIndex = 0
            cbx_TProceso.Checked = False
            cbx_Todos.Checked = False
            cbx_TCajero.Checked = False
            cbx_Moneda.Checked = False
            cbx_Cia.Checked = False
            'cmb_cia.SelectedIndex = 0
            'cmb_Moneda.Enabled = True
            'cmb_cia.Enabled = True
        End If
    End Sub
    Private Sub Combo_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.EnabledChanged, cmb_Sesiones.EnabledChanged, cmb_Grupo.EnabledChanged, cmb_Corte.EnabledChanged, cmb_Cajero.EnabledChanged, cmb_CajaBancaria.EnabledChanged
        sender.SelectedValue = "0"
    End Sub

    Private Sub cbx_TProceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TProceso.CheckedChanged
        If cbx_TProceso.Checked Then cmb_Grupo.SelectedValue = "0"
        cmb_Grupo.Enabled = Not cbx_TProceso.Checked
    End Sub

    Private Sub cbx_TCajero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TCajero.CheckedChanged
        If cbx_TCajero.Checked Then cmb_Cajero.SelectedValue = "0"
        cmb_Cajero.Enabled = Not cbx_TCajero.Checked
        tbx_ClaveCajero.Enabled = Not cbx_TCajero.Checked
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dtp_FechaAplicacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaAplicacion.ValueChanged
        lbl_DiaSemana.Text = Dias(DatePart(DateInterval.Weekday, dtp_FechaAplicacion.Value.Date, FirstDayOfWeek.Sunday))
    End Sub

    Private Sub cmb_cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cia.SelectedIndexChanged

    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged

    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged

    End Sub

    Private Sub cbx_Cia_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_Cia.CheckedChanged
        If cbx_Cia.Checked Then cmb_cia.SelectedValue = "0"
        cmb_cia.Enabled = Not cbx_Cia.Checked
    End Sub

    Private Sub cbx_Moneda_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_Moneda.CheckedChanged
        If cbx_Moneda.Checked Then cmb_Moneda.SelectedValue = "0"
        cmb_Moneda.Enabled = Not cbx_Moneda.Checked
    End Sub

    Private Sub cmb_Reporte_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class