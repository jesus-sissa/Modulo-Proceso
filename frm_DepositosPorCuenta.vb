Imports Modulo_Proceso.Cn_DepositosXcuenta

Public Class frm_DepositosPorCuenta

    Private Sub frmDepositosPorCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Tipo.AgregarItem("1", "Por Fecha de TXT")                   'Pro_Servicios, Pro_Fichas y Pro_Archivos
        cmb_Tipo.AgregarItem("2", "Por Fecha de Verificacion")          'Pro_Servicios y Pro_Fichas
        cmb_Tipo.AgregarItem("3", "Por Fecha de Traslado(con TXT de Depósitos)") 'Bo_Boveda, Pro_Servicios y Pro_Archivos
        cmb_Tipo.AgregarItem("4", "Por Fecha de Traslado")              'Bo_Boveda, Pro_Servicios
        cmb_Tipo.AgregarItem("5", "Por Una Cuenta(con TXT de Depósitos)") 'Pro_Servicios, Pro_Fichas y Pro_Archivos
        'cmb_Tipo.AgregarItem("6", "Por Un Cliente y SubClientes")      'Pro_Servicios

        cmb_CajaBancaria.Actualizar()
        cmb_Moneda.Actualizar()

        cmb_Desde.ValorParametro = dtp_Desde.Value
        cmb_Desde.Actualizar()

        cmb_Hasta.ValorParametro = dtp_Hasta.Value
        cmb_Hasta.Actualizar()

        'cmb_Cuenta.Actualizar(fn_DepositosPorCuenta_GetCuentas(0, 0))

        cmb_Cliente.Actualizar()

        cmb_Cia.Actualizar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub cmb_Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipo.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        cbx_TProceso.Checked = False
        cbx_SubClientes.Checked = False
        cmb_CajaBancaria.Enabled = False
        cmb_Grupo.Enabled = False
        chk_Corte.Checked = False
        chk_Corte.Enabled = False
        tbx_Corte.Enabled = False
        cbx_TProceso.Enabled = False
        cmb_Moneda.Enabled = False
        dtp_Desde.Enabled = False
        cmb_Desde.Enabled = False
        dtp_Hasta.Enabled = False
        cmb_Hasta.Enabled = False
        cmb_Cliente.Enabled = False
        cbx_SubClientes.Enabled = False
        cmb_Cuenta.Enabled = False
        btn_Imprimir.Enabled = False
        btn_ImprimirAgrupado.Enabled = False

        Select Case cmb_Tipo.SelectedValue
            Case "1" 'Por Fecha_Aplicacion en Pro_Archivos
                cmb_CajaBancaria.Enabled = True
                cmb_Grupo.Enabled = True
                chk_Corte.Enabled = True
                tbx_Corte.Enabled = True
                cbx_TProceso.Enabled = True
                cmb_Moneda.Enabled = True
                dtp_Desde.Enabled = True
                cmb_Desde.Enabled = True
                dtp_Hasta.Enabled = True
                cmb_Hasta.Enabled = True
                btn_Imprimir.Enabled = True
                btn_ImprimirAgrupado.Enabled = True
            Case "2" 'Por Fecha_FinV en Pro_Servicios
                cmb_CajaBancaria.Enabled = True
                cmb_Grupo.Enabled = True
                cbx_TProceso.Enabled = True
                cmb_Moneda.Enabled = True
                dtp_Desde.Enabled = True
                cmb_Desde.Enabled = True
                dtp_Hasta.Enabled = True
                cmb_Hasta.Enabled = True
                btn_Imprimir.Enabled = True
                btn_ImprimirAgrupado.Enabled = True
            Case "3" 'por Fecha_Entrada en Bo_Boveda
                cmb_CajaBancaria.Enabled = True
                cmb_Grupo.Enabled = True
                cbx_TProceso.Enabled = True
                cmb_Moneda.Enabled = True
                dtp_Desde.Enabled = True
                cmb_Desde.Enabled = True
                dtp_Hasta.Enabled = True
                cmb_Hasta.Enabled = True
                btn_Imprimir.Enabled = True
                btn_ImprimirAgrupado.Enabled = True
            Case "4"
                cmb_CajaBancaria.Enabled = True
                cmb_Grupo.Enabled = True
                cbx_TProceso.Enabled = True
                cmb_Moneda.Enabled = True
                dtp_Desde.Enabled = True
                cmb_Desde.Enabled = True
                dtp_Hasta.Enabled = True
                cmb_Hasta.Enabled = True
                'cmb_Cliente.Enabled = True
                'cbx_SubClientes.Enabled = True
                btn_Imprimir.Enabled = True
                btn_ImprimirAgrupado.Enabled = True
            Case "5" 'Por una Cuenta Bancaria
                cmb_CajaBancaria.Enabled = True
                cmb_Grupo.Enabled = True
                cbx_TProceso.Enabled = True
                cmb_Moneda.Enabled = True
                dtp_Desde.Enabled = True
                cmb_Desde.Enabled = True
                dtp_Hasta.Enabled = True
                cmb_Hasta.Enabled = True
                cmb_Cuenta.Enabled = True
                btn_Imprimir.Enabled = True
                btn_ImprimirAgrupado.Enabled = True
        End Select
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        If cmb_CajaBancaria.SelectedValue Is Nothing Then Exit Sub
        cmb_Grupo.ValorParametro = cmb_CajaBancaria.SelectedValue

        cmb_Grupo.Actualizar()

        cmb_Cuenta.Actualizar(fn_DepositosPorCuenta_GetCuentasCombo(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue))
    End Sub

    Private Sub cbx_TProceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TProceso.CheckedChanged
        cmb_Grupo.Enabled = Not cbx_TProceso.Checked
    End Sub

    Private Sub Combo_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.EnabledChanged, cmb_Grupo.EnabledChanged, cmb_Moneda.EnabledChanged, cmb_Desde.EnabledChanged, cmb_Hasta.EnabledChanged, cmb_Cliente.EnabledChanged
        Dim cmb As ComboBox = TryCast(sender, ComboBox)
        If Not cmb Is Nothing AndAlso cmb.Enabled = False And cmb.Items.Count > 0 Then cmb.SelectedValue = "0"
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        cmb_Desde.ValorParametro = dtp_Desde.Value
        cmb_Desde.Actualizar()
        If cmb_Desde.Items.Count = 2 Then
            cmb_Desde.SelectedIndex = 1
        End If
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        cmb_Hasta.ValorParametro = dtp_Hasta.Value
        cmb_Hasta.Actualizar()
        If cmb_Hasta.Items.Count = 2 Then
            cmb_Hasta.SelectedIndex = 1
        End If
    End Sub

    Private Sub cmb_Moneda_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedValueChanged
        'cmb_Cuenta.Actualizar(fn_DepositosPorCuenta_GetCuentas(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue))
        If cmb_CajaBancaria.SelectedValue Is Nothing Or cmb_Moneda.SelectedValue Is Nothing Then Exit Sub
        cmb_Cuenta.Actualizar(fn_DepositosPorCuenta_GetCuentasCombo(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue))
    End Sub

    Private Function Validar() As Boolean
        If cmb_CajaBancaria.Enabled And cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If cmb_Grupo.Enabled And cmb_Grupo.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Grupo de Proceso o Todos.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Grupo.Focus()
            Return False
        End If

        If cmb_Moneda.Enabled And cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If
        If CInt(cmb_Tipo.SelectedValue) > 5 Then
            If cmb_Desde.Enabled And cmb_Desde.SelectedValue = "0" Then
                MsgBox("Debe seleccionar una Sesión Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Desde.Focus()
                Return False
            End If

            If cmb_Hasta.Enabled And cmb_Hasta.SelectedValue = "0" Then
                MsgBox("Debe seleccionar una Sesión Final.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Hasta.Focus()
                Return False
            End If
        End If
        If cmb_Cliente.Enabled And cmb_Cliente.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Return False
        End If

        If cmb_Cuenta.Enabled And cmb_Cuenta.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Cuenta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cuenta.Focus()
            Return False
        End If

        If cmb_Cia.Enabled And cmb_Cia.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Compañía de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cia.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ValidarRepProcesos() As Boolean

        If cmb_CajaBancaria.Enabled And cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If cmb_Moneda.Enabled And cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If
        If cmb_Cia.Enabled And cmb_Cia.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Compañía de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cia.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub chk_Cia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cia.CheckedChanged
        If chk_Cia.Checked Then
            cmb_Cia.SelectedValue = 0
            cmb_Cia.Enabled = False
        Else
            cmb_Cia.Enabled = True
        End If
    End Sub

    Private Sub btn_Procesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Procesos.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If ValidarRepProcesos() Then
            Me.Cursor = Cursors.WaitCursor
            If fn_ReporteProcesos_GenerarExcel(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue, dtp_Desde.Value, dtp_Hasta.Value, cmb_Cia.SelectedValue) Then

                Me.Cursor = Cursors.Default
                MsgBox("Reporte Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If Validar() Then
            Dim Hijos As Char
            If cbx_SubClientes.Checked Then Hijos = "S" Else Hijos = "N"
            Me.Cursor = Cursors.WaitCursor
            If cmb_Tipo.SelectedValue = 5 Then 'Por una Cuenta
                If fn_DepositosPorCuenta_GenerarExcelXcuenta(cmb_Tipo.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Moneda.SelectedValue, dtp_Desde.Value, cmb_Desde.SelectedValue, _
                                                   dtp_Hasta.Value, cmb_Hasta.SelectedValue, cmb_Cliente.SelectedValue, cmb_Cuenta.SelectedValue, Hijos, cmb_Cia.SelectedValue) Then

                    Me.Cursor = Cursors.Default
                    MsgBox("Reporte Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    Me.Cursor = Cursors.Default
                    MsgBox("Ocurrió un error al intentar generar el reporte.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            Else
                If fn_DepositosPorCuenta_GenerarExcel(cmb_Tipo.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Moneda.SelectedValue, dtp_Desde.Value, cmb_Desde.SelectedValue, _
                                                   dtp_Hasta.Value, cmb_Hasta.SelectedValue, cmb_Cliente.SelectedValue, cmb_Cuenta.SelectedValue, Hijos, cmb_Cia.SelectedValue) Then

                    Me.Cursor = Cursors.Default

                    MsgBox("Reporte Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    Me.Cursor = Cursors.Default
                    MsgBox("Ocurrió un error al intentar generar el reporte.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btn_ImprimirAgrupado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImprimirAgrupado.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If Validar() Then
            If (tbx_Corte.Text = 0 OrElse tbx_Corte.Text = "") AndAlso Not chk_Corte.Checked Then
                MsgBox("Debe especificar el Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Corte.Focus()
                Exit Sub
            End If

            Dim Hijos As Char
            If cbx_SubClientes.Checked Then Hijos = "S" Else Hijos = "N"
            Me.Cursor = Cursors.WaitCursor
            If cmb_Tipo.SelectedValue = 5 Then '** por Cuenta y por el TXT
                If fn_DepositosPorCuenta_GenerarExcelXcuentaAgrupado(cmb_Tipo.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Moneda.SelectedValue, dtp_Desde.Value, cmb_Desde.SelectedValue, _
                                                                     dtp_Hasta.Value, cmb_Hasta.SelectedValue, cmb_Cliente.SelectedValue, cmb_Cuenta.SelectedValue, Hijos, cmb_Cia.SelectedValue) Then

                    Me.Cursor = Cursors.Default
                    MsgBox("Reporte Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Error al generar el Reporte..", MsgBoxStyle.Critical, frm_MENU.Text)
                End If

            Else
                Dim GrupoProceso As String = cmb_Grupo.Text
                Dim Corte As String = tbx_Corte.Text
                Dim CompaniaTV As String = cmb_Cia.Text
                Dim SesionD As String = cmb_Desde.Text
                Dim SesionH As String = cmb_Hasta.Text
                If cbx_TProceso.Checked Then GrupoProceso = "TODOS"
                If Not tbx_Corte.Enabled Then Corte = "TODOS"
                If chk_Cia.Checked Then CompaniaTV = "TODOS"
                If cmb_Desde.SelectedValue = "0" Then SesionD = "NINGUNA"
                If cmb_Hasta.SelectedValue = "0" Then SesionH = "NINGUNA"

                If fn_DepositosPorCuentaAgrupado_GenerarExcel(cmb_Tipo.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Moneda.SelectedValue, dtp_Desde.Value, cmb_Desde.SelectedValue, _
                                                              dtp_Hasta.Value, cmb_Hasta.SelectedValue, cmb_Cliente.SelectedValue, cmb_Cuenta.SelectedValue, Hijos, cmb_Cia.SelectedValue, tbx_Corte.Text, _
                                                              cmb_Tipo.Text, cmb_CajaBancaria.Text, GrupoProceso, Corte, cmb_Moneda.Text, dtp_Desde.Value.Date, SesionD, dtp_Hasta.Value.Date, SesionH, CompaniaTV) Then

                    Me.Cursor = Cursors.Default
                    MsgBox("Reporte Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Error al generar el Reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
        FuncionesGlobales.fn_Menu_Progreso(0)
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub chk_Corte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Corte.CheckedChanged
        SegundosDesconexion = 0

        tbx_Corte.Text = 0
        tbx_Corte.Enabled = Not chk_Corte.Checked
    End Sub

End Class