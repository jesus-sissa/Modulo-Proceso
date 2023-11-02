Imports System.Windows.Forms
Imports Modulo_Proceso.FuncionesGlobales
Imports System.Threading
Imports System.Globalization
Imports System.Deployment.Application

Public Class frm_MENU

    Private Segundos As Integer = 0

    Private Sub frm_MENU_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If LoginId > 0 Then
            Cn_Login.Login_CerrarSesion()
            'Insertar en Usr_Log
            If TipoBloqueo <> 0 Then
                Cn_Login.fn_Log_Create("CIERRE DE SESION(DESPUES DE BLOQUEO)")
            Else
                Cn_Login.fn_Log_Create("CIERRE DE SESION")
            End If
        End If

    End Sub

    Private Sub frm_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        Call Deshabilitar_Todo()

        'Cambiar la configuración regional
        'Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES", False)

        ' Obtengo la informacion de formato numerico
        Dim nfi As Globalization.NumberFormatInfo = Thread.CurrentThread.CurrentCulture.NumberFormat
        ' Obtengo la informacion de formato fecha
        Dim Dfi As Globalization.DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        If nfi.NumberDecimalSeparator <> "." Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.NumberGroupSeparator <> "," Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.CurrencySymbol <> "$" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortDatePattern <> "dd/MM/yyyy" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada(" & Dfi.ShortDatePattern & ").", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortTimePattern <> "HH:mm:ss" And Dfi.ShortTimePattern <> "hh:mm tt" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada(" & Dfi.ShortTimePattern & ").", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        tmr_Inicio.Enabled = True

        Dias(1) = "Domingo"
        Dias(2) = "Lunes"
        Dias(3) = "Martes"
        Dias(4) = "Miércoles"
        Dias(5) = "Jueves"
        Dias(6) = "Viernes"
        Dias(7) = "Sábado"
    End Sub

    Private Sub tmr_Inicio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Inicio.Tick
        TipoBloqueo = 0
        SegundosDesconexion = 0
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        Dim frmSet As New frm_Settings
        'verificar Si hay tipoesquema y Datos de conexion
        If My.Settings.TipoEsquema = "0" Then
            frmSet.ShowDialog()
            If My.Settings.TipoEsquema = "0" Then
                MsgBox("No se ha especificado el tipo de esquema a utilizar.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If

        If Cn_Proceso.fn_CuentaSettings() = 10 Then
            frmSet.ShowDialog()
            If Cn_Proceso.fn_CuentaSettings() = 10 Then
                MsgBox("No se han capturado el nombre del Servidor y la Base de Datos.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If
        '---------------
        frm_Login.ShowDialog()
        If SucursalId = 0 Then
            Me.Close()
            Exit Sub
        End If

        Me.Text = "SIAC. Módulo Proceso v" & ModuloVersion & "  ** Conectado A: " & SucursalDatos

        'Esta funcion trae el ultimo tipo de cambio para hoy
        Cn_Proceso.fn_Menu_TipoCambioM()
        'Esta funcion toma el tipo de cambio de hoy y lo clona para mañana
        Cn_Proceso.fn_Menu_TipoCambio()

        cn_Mensajes.ActualizarMensajes()
        tmr_Hora.Enabled = True

    End Sub

    Private Sub tmr_Hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Hora.Tick
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString

        Segundos += 1
        SegundosDesconexion += 1
        If SegundosDesconexion >= (MinutosDesconexion * 60) Then
            SegundosDesconexion = 0
            tmr_Hora.Enabled = False
            'Insertar en Usr_Log
            Cn_Login.fn_Log_Create("BLOQUEO POR INACTIVIDAD")
            TipoBloqueo = 2
            Call CerrarModales()
            Me.Hide()
            frm_Login.ShowDialog()
            tmr_Hora.Enabled = True
        End If
        If Segundos = 300 Then
            cn_Mensajes.ActualizarMensajes()
            Segundos = 0
        End If
    End Sub

    Sub CerrarModales()
        Dim Contador As Integer = Application.OpenForms.Count
        For ILocal As Integer = 0 To Contador - 1
            If Application.OpenForms(ILocal).Modal Then
                Application.OpenForms(ILocal).Dispose()
            End If
        Next
    End Sub

    Sub Deshabilitar_Todo()
        Dim SubSub As Integer = 0
        'MenuStrip
        For Each element As ToolStripItem In MenuStrip.Items
            If TypeOf (element) Is ToolStripMenuItem Then
                SubSub = 0
                For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                    If TypeOf (Child) Is ToolStripMenuItem Then
                        For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                            SubSub = SubSub + 1
                            If TypeOf (SubChild) Is ToolStripMenuItem And SubChild.Tag <> "" Then
                                SubChild.Enabled = False
                            End If
                        Next
                        If SubSub = 0 And Child.Tag <> "" Then
                            Child.Enabled = False
                        End If

                    End If
                Next
            End If
        Next
        'ToolStrip
        For Each element As ToolStripItem In ToolStrip.Items
            If TypeOf (element) Is ToolStripButton Then
                If element.Tag <> "" Then
                    element.Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub tsb_Bloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Bloquear.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BLOQUEAR SISTEMA")

        TipoBloqueo = 1
        tmr_Hora.Enabled = False
        Me.Hide()
        frm_Login.ShowDialog()
        tmr_Hora.Enabled = True
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AdministrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarSesionToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ABRIR O CERRAR SESION")

        Dim FRM As New frm_AbrirSesion
        MostrarVentana(FRM, False)
    End Sub

    Private Sub GenerarCorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCorteToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GENERAR CORTE-TURNO")

        Dim frm As New frm_Corte
        MostrarVentana(frm, False)
    End Sub

    Private Sub RecibirServiciosDeBóvedaIndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibirServiciosDeBóvedaIndividualToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR SERVICIOS DE BOVEDA(INDIVIDUAL)")
        MostrarVentana(frm_RecibirServicioRec)
    End Sub

    Private Sub RegresarServicioABovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegresarServicioABovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REGRESAR SERVICIOS A BOVEDA")
        MostrarVentana(frm_RegresoaBoveda)
    End Sub

    Private Sub AsignarServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarServiciosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ASIGNAR SERVICIOS A VERIFICADOR")

        MostrarVentana(frm_AsignarServicios)
    End Sub

    Private Sub CancelarAsignacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarAsignacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ASIGNACION A VERIFICADOR")

        MostrarVentana(frm_CancelarAsignacion)
    End Sub

    Private Sub EnvioProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnvioProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PREPARAR ENVIO DE EFECTIVO")

        'frm_EnviarEfectivo.Origen = frm_EnviarEfectivo.Tipo.Proceso
        MostrarVentana(frm_LotesEfectivo_Preparar)
    End Sub

    Private Sub CancelaProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR EFECTIVO")

        MostrarVentana(frm_LotesEfectivo_Cancelar)
    End Sub

    Private Sub EliminarFichaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarFichaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ELIMINAR FICHA")

        MostrarVentana(frm_EliminarFicha)
    End Sub

    Private Sub PrepararDotacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrepararDotacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAPTURAR DOTACIONES")

        Dim frm As New frm_DotacionesCapturar
        'Dim frm As New frm_CrearDotacionesH2H
        MostrarVentana(frm)
    End Sub

    Private Sub EnviarDotacionesABovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarDotacionesABovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR DOTACIONES A BOVEDA")

        MostrarVentana(frm_EnviarDotaBoveda)
    End Sub

    Private Sub CancelarEnvioABovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarEnvioABovedaToolStripMenuItem.Click

        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ENVIO DE DOTACIONES A BOVEDA")
        MostrarVentana(frm_CancelaEnvioBoveda)
    End Sub

    Private Sub RecibirDotacionesDesdeBovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibirDotacionesDesdeBovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR DOTACIONES REGRESADAS DE BOVEDA")

        MostrarVentana(frm_RecibeDotacionRegBoveda)
    End Sub

    Private Sub ContabilizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContabilizarToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONTABILIZAR SERVICIOS")

        MostrarVentana(frm_Contabilizar)
    End Sub

    Private Sub CapturarResguardoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarResguardoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PREPARAR RESGUARDO DE SALDO")
        MostrarVentana(frm_PrepararResguardo)
    End Sub

    Private Sub EnviarResguardoABovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarResguardoABovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIO DE RESGUARDO DE SALDO A BOVEDA")

        MostrarVentana(frm_ResguardoaBoveda)
    End Sub

    Private Sub CancelarEnvioABovedaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarEnvioABovedaToolStripMenuItem1.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ENVIO DE RESGUARDO DE SALDO A BOVEDA")

        MostrarVentana(frm_CancelaRegEnvioBoveda)
    End Sub

    Private Sub RecibirResguardoDeBovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibirResguardoDeBovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR RESGUARDO DE BOVEDA")

        MostrarVentana(frm_RecibeResguardoBoveda)
    End Sub

    Private Sub CancelarDotacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarDotacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR DOTACIONES")

        MostrarVentana(frm_DotacionesCancelar)
    End Sub

    Private Sub CancelaResguardoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaResguardoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR RESGUARDO DE SALDO")

        MostrarVentana(frm_CancelaResguardo)
    End Sub

    Private Sub ReintegraResguardoAlSaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReintegraResguardoAlSaldoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REINTEGRAR RESGUARDO AL SALDO")

        frm_CancelaResguardo.Tipo = frm_CancelaResguardo.Modo.Reintegra
        MostrarVentana(frm_CancelaResguardo)
    End Sub

    Private Sub ConsultaDeSaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeSaldoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE SALDO")

        MostrarVentana(frm_ConsultaSaldo)
    End Sub

    'Private Sub ConsultaDeSaldoGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeSaldoGeneralToolStripMenuItem.Click
    '    'Inicializar la variable de desconexion
    '    SegundosDesconexion = 0
    '    'Validar la Sesion
    '    If Not Cn_Login.fn_ValidaSesion(LoginId) Then
    '        End
    '    End If
    '    'Insertar en Usr_Log
    '    Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE SALDO GENERAL")

    '    MostrarVentana(frm_ConsultaSaldoGeneral)
    'End Sub

    Private Sub HojaDeTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HojaDeTrabajoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTES DIARIOS")

        Dim frm As New frm_ReportesDiarios
        MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaDeDotacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeDotacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE DOTACIONES")

        MostrarVentana(frm_ConsultaDotaciones)
    End Sub

    Private Sub ConsultaDeDepositosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeDepositosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE DEPOSITOS")

        MostrarVentana(frm_ConsultaDepositos)
    End Sub

    Private Sub ClientesProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE CLIENTES CON PROCESO")

        MostrarVentana(frm_ClientesProceso)
    End Sub

    Private Sub ReimprimirCorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimprimirCorteToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REIMPRESION DE CORTE")

        MostrarVentana(frm_ReimprimirCorte)
    End Sub

    Private Sub ValidarDotacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarDotacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR DOTACIONES")

        MostrarVentana(frm_DotacionesValidar)
    End Sub

    Private Sub DepositosPorCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositosPorCuentaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEPOSITOS POR CUENTA")

        Dim frm As New frm_DepositosPorCuenta
        MostrarVentana(frm, False)
    End Sub

    Private Sub ComprimirArchivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprimirArchivosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GENERAR ARCHIVO ZIP")

        Dim frm As New frm_GenerarZip
        MostrarVentana(frm, False)
    End Sub

    Private Sub CatalogoDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeCuentasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE CUENTAS BANCARIAS")

        MostrarVentana(frm_CatalogoCuentas, True)
    End Sub

    '-----------------------------------------------------------------------
    'ToolStrip
    '-----------------------------------------------------------------------

    Private Sub tsb_LeerMensajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_LeerMensajes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub tsb_EnviarMensajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_EnviarMensajes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub tsb_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Salir.Click
        Me.Close()
    End Sub

    Private Sub tsb_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Clientes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE CLIENTES CON PROCESO")

        MostrarVentana(frm_ClientesProceso)
    End Sub

    Private Sub tsb_Cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Cuentas.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE CUENTAS BANCARIAS")

        MostrarVentana(frm_CatalogoCuentas, True)
    End Sub

    Private Sub tsb_EfectivoEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_EfectivoEnviar.Click
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR EFECTIVO")

        Dim frm As New frm_LotesEfectivo_Enviar
        MostrarVentana(frm)
    End Sub

    Private Sub tsb_EfectivoCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_EfectivoCancelar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR EFECTIVO")

        MostrarVentana(frm_LotesEfectivo_Cancelar)
    End Sub

  

    Private Sub tsb_DotacionesCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DotacionesCapturar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAPTURAR DOTACIONES")

        MostrarVentana(frm_DotacionesCapturar)
    End Sub

    Private Sub tsb_DotacionesValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DotacionesValidar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR DOTACIONES")

        MostrarVentana(frm_DotacionesValidar)
    End Sub

    Private Sub tsb_DotacionesCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DotacionesCancelar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR DOTACIONES")

        MostrarVentana(frm_DotacionesCancelar)
    End Sub

    Private Sub tsb_DotacionesEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DotacionesEnviar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR DOTACIONES A BOVEDA")

        MostrarVentana(frm_EnviarDotaBoveda)
    End Sub

    Private Sub tsb_DotacionesRecibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DotacionesRecibir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR DOTACIONES REGRESADAS DE BOVEDA")

        MostrarVentana(frm_RecibeDotacionRegBoveda)
    End Sub

    Private Sub tsb_ServiciosAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ServiciosAsignar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ASIGNAR SERVICIOS A VERIFICADOR")

        MostrarVentana(frm_AsignarServicios)
    End Sub

    Private Sub tsb_ServiciosAsignarCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ServiciosAsignarCancela.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ASIGNACION A VERIFICADOR")

        MostrarVentana(frm_CancelarAsignacion)
    End Sub

    Private Sub tsb_ServiciosContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ServiciosContabilizar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONTABILIZAR SERVICIOS")

        MostrarVentana(frm_Contabilizar)
    End Sub

    Private Sub tsb_RecibirServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_RecibirServicios.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR SERVICIOS DE BOVEDA")

        MostrarVentana(frm_RecibirServicioRec)
    End Sub

    Private Sub RastreoDeRemisionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RastreoDeRemisionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RASTREO DE REMISIONES")

        FuncionesGlobales.MostrarVentana(frm_Rastreo)
    End Sub

    Private Sub TabularPorRemisiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabularPorRemisiónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE TABULAR")

        Dim frm As New frm_ReporteTabular
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub DigitalizarChequesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DigitalizarChequesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DIGITALIZAR CHEQUES")

        FuncionesGlobales.MostrarVentana(frm_Scan, True)
    End Sub

    Private Sub TXTAdminToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAdminToolStripMenuItem1.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ADMINISTRAR ARCHIVOS TXT")

        FuncionesGlobales.MostrarVentana(frm_TXTadmin, True)
    End Sub

    Private Sub DesbloquearUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesbloquearUsuariosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESBLOQUEAR USUARIOS")

        FuncionesGlobales.MostrarVentana(frm_Usuarios, True)
    End Sub

    Private Sub TabularDeChequesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabularDeChequesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: TABULAR DE CHEQUES")

        Dim frm As New frm_TabularCheques
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaDeChequesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeChequesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE CHEQUES")

        FuncionesGlobales.MostrarVentana(frm_ConsultaCheques, True)
    End Sub

    Private Sub ReportarFallaEnEquipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnEquipoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN EQUIPO")

        Dim frm As New frm_ReporteFallas
        frm.ShowDialog()
    End Sub

    Private Sub ReportarFallaEnSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnSistemaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN SISTEMA")

        Dim frm As New frm_ReporteFallasS
        frm.ShowDialog()
    End Sub

    Private Sub ActualizacionesInstaladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizacionesInstaladasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTAR ACTUALIZACIONES INSTALADAS")

        FuncionesGlobales.MostrarVentana(frm_ActualizacionesConsultar, True)
    End Sub

    Private Sub CambiarDenominacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarDenominacionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIAR DENOMINACIONES")

        Dim frm As New frm_CambiarDenominaciones
        frm.Tipo = 1

        frm.ShowDialog()
    End Sub

    Private Sub TransferenciaDeSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferenciaDeSaldosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: TRANSFERENCIA DE SALDOS")

        Dim frm As New frm_CambiarDenominaciones
        frm.Tipo = 2
        frm.Text = "Transferencia de Saldos"
        frm.ShowDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACERCA DE...")

        Dim frm As New frm_About
        frm.ShowDialog()
    End Sub

    Private Sub RecibirMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibirMaterialToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR MATERIALES")

        Dim frm As New frm_MaterialesAcepta(Dpto.PROCESO)
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub InventarioDeMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioDeMaterialToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: INVENTARIO DE MATERIALES")

        Dim frm As New frm_MaterialesInventario(Dpto.PROCESO)
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaEntradasDeMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaEntradasDeMaterialToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE DE ENTRADAS DE MATERIALES")

        Dim frm As New frm_MaterialesReporte(Dpto.PROCESO)
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub LeerMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub EnviarMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub VerPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerPToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VER PRESENTACIONES")

        FuncionesGlobales.MostrarVentana(frm_PresentacionesVer)
    End Sub

    Private Sub SeguimientoAFallasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoAFallasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SEGUIMIENTO A FALLAS")

        Dim Frm As New frm_ReporteFallasConsultar
        FuncionesGlobales.MostrarVentana(Frm, True)
    End Sub

    Private Sub SolicitudDeEquipoServicioYOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeEquipoServicioYOtrosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SOLICITUD DE EQUIPO, SERVICIO Y OTROS")

        Dim Frm As New frm_ReporteFallasI
        FuncionesGlobales.MostrarVentana(Frm, False)
    End Sub

    Private Sub ConsultaDeAlertasRecibidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAlertasRecibidasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ALERTAS RECIBIDAS")

        Dim Frm As New frm_AlertasConsultas
        FuncionesGlobales.MostrarVentana(Frm, True)
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        Call InstallUpdateSyncWithInfo()
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing
        Me.Cursor = Cursors.WaitCursor
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                Me.Cursor = Cursors.Default
                MsgBox("La actualización no se puede descargar en este momento. " + Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            Catch ioe As InvalidOperationException
                Me.Cursor = Cursors.Default
                MsgBox("Esta no es una Aplicacion ClickOnce. No se puede actualizar. Error: " & ioe.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Me.Cursor = Cursors.Default
                    Dim dr As DialogResult = MsgBox("Está disponible la nueva versión " & info.AvailableVersion.ToString & ". Desea Instalarla Ahora?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MsgBox("El Sistema ha detectado una actualización marcada como obligatoria. La versión mínima requerida es " & _
                        info.MinimumRequiredVersion.ToString() & _
                        ". Se instalará la Actualización y se reiniciará el Sistema.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Text)
                End If
                Me.Cursor = Cursors.WaitCursor
                If (doUpdate) Then
                    Try
                        AD.Update()
                        Me.Cursor = Cursors.Default
                        MsgBox("La Actualización se instaló correctamente, El Sistema se reiniciará.", MsgBoxStyle.Exclamation, Me.Text)
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        Me.Cursor = Cursors.Default
                        MsgBox("No se pudo instalar la Actualziación. " & Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.Text)
                        Return
                    End Try
                End If
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No se encontraron Actualizaciones Disponibles.", MsgBoxStyle.Information, Me.Text)
            End If
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Esta no es una aplicación ClickOnce Válida.", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub

    Private Sub CartaDeAccesoParaEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartaDeAccesoParaEmpleadosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GENERAR CARTA DE ACCESO")

        Dim Frm As New frm_CartaAcceso
        FuncionesGlobales.MostrarVentana(Frm, True)
    End Sub

    Private Sub ConsultaCartasDeAccesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCartasDeAccesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA CARTAS DE ACCESO")

        Dim Frm As New frm_CartasAccesoConsulta
        FuncionesGlobales.MostrarVentana(Frm, True)
    End Sub

    Private Sub VerificaciónPorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificaciónPorToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VERIFICACION POR CAJEROS")

        Dim Frm As New frm_VerificacionXCajeros
        FuncionesGlobales.MostrarVentana(Frm, True)
    End Sub


    Private Sub CatálogoEmpleadosQueAutorizaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoEmpleadosQueAutorizaToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE EMPLEADOS QUE AUTORIZA")

        Dim frm As New frm_EmpleadosAutoriza
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ValidarArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarArchivoToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR ARCHIVO")

        Dim frm As New frm_ValidarArchivo
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub DescargarManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargarManualDeUsuarioToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESCARGAR MANUAL DE USUARIO")

        Dim frm As New frm_DescargarArchivo
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub ValesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESCARGAR MANUAL DE USUARIO")

        Dim frm As New frm_Vales
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub DetalleDeDepositosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalleDeDepositosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DETALLE DE DEPOSITOS")

        FuncionesGlobales.MostrarVentana(frm_DetalleDepositos, True)
    End Sub

    Private Sub SaldoPorVerificadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoPorVerificadorToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SALDO POR VERIFICADOR")

        FuncionesGlobales.MostrarVentana(frm_ProcesoSaldos, True)
    End Sub

    Private Sub SaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SALDOS")

        FuncionesGlobales.MostrarVentana(frm_SaldoCuadre, True)
    End Sub

    Private Sub CatalogarServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogarServiciosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGAR SERVICIOS ENTRADA")
        Dim frm As New frm_CatalogarServicios
        frm.Tipo_Movimiento = "E"
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub CatalogarServiciosSalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogarServiciosSalidaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGAR SERVICIOS SALIDA")
        Dim frm As New frm_CatalogarServicios
        frm.Tipo_Movimiento = "S"
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub GrupoDeDepositoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoDeDepositoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE GRUPOS DE DEPOSITO")
        Dim frm As New frm_GrupoDeposito
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub GrupoDeDotaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoDeDotaciónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE GRUPOS DE DOTACION")
        Dim frm As New frm_GrupoDota
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ValidarActasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarActasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDACIÓN DE ACTAS")
        Dim frm As New frm_ActasValidar
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ReporteDeActasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeActasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE DE ACTAS")
        Dim frm As New frm_ActasReporte
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub SaldosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SALDOS")
        Dim frm As New frm_Saldos
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub TiposDeDiferenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeDiferenciaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: TIPOS DE DIFERENCIA")
        Dim frm As New frm_TiposdeDiferencia
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ParametrosBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParametrosBancosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PARAMETROS BANCOS")
        Dim frm As New frm_CajasBancarias
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub BilletesFalsosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BilletesFalsosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BILLETES FALSOS")
        Dim frm As New frm_ReporteBilletesFalsos
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub CatálgoDeCasasValerasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálgoDeCasasValerasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATÁLOGO DE CASAS VALERAS")

        Dim frm As New frm_CatalogoCasaV
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub DigitalizarValesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DigitalizarValesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DIGITALIZAR VALES DE DESPENSA")

        Dim frm As New frm_ValesdeDespensa
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ReporteLotesDeEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteLotesDeEfectivoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE LOTES DE EFECTIVO")

        Dim frm As New frm_LotesEfectivo_Consultar
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub BarraDeHerramientasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeHerramientasToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.BarraDeHerramientasToolStripMenuItem.Checked
    End Sub

    Private Sub BarraDeEstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeEstadoToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.BarraDeEstadoToolStripMenuItem.Checked
    End Sub

    Private Sub EntradaDeSaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDeSaldoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENTRADA DE SALDO")

        MostrarVentana(frm_LotesEfectivo_EntradaSaldo)
    End Sub

    Private Sub ConsultaDeSaldo2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeSaldo2ToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE SALDO 2")
        Dim frm As New frm_ConsultaSaldosProc
        MostrarVentana(frm, True)
    End Sub

    Private Sub EnviarEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarEfectivoToolStripMenuItem.Click
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR EFECTIVO")

        Dim frm As New frm_LotesEfectivo_Enviar
        MostrarVentana(frm)
    End Sub

    Private Sub CancelarEnvioDeEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarEnvioDeEfectivoToolStripMenuItem.Click
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ENVIO DE EFECTIVO")

        Dim frm As New frm_LotesEfectivo_CancelarEnvio
        MostrarVentana(frm)
    End Sub

    Private Sub RecibirDevolucionDeEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibirDevolucionDeEfectivoToolStripMenuItem.Click
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR DEVOLUCION DE EFECTIVO")

        Dim frm As New frm_LotesEfectivo_RecibirDev
        MostrarVentana(frm)
    End Sub

    Private Sub CancelarDevolucionDeEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarDevolucionDeEfectivoToolStripMenuItem.Click
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR DEVOLUCION DE EFECTIVO")

        Dim frm As New frm_LotesEfectivo_CancelarDev
        MostrarVentana(frm)
    End Sub

    Private Sub AceptaProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptaProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACEPTAR EFECTIVO")
        Dim frm As New frm_LotesEfectivo_Aceptar

        MostrarVentana(frm)
    End Sub

    Private Sub tsb_EfectivoRecibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_EfectivoRecibir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACEPTAR EFECTIVO")
        Dim frm As New frm_LotesEfectivo_Aceptar

        MostrarVentana(frm)
    End Sub

    Private Sub ValidarEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidarEfectivoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: VALIDAR EFECTIVO")
        Dim frm As New frm_LotesEfectivo_Validar

        MostrarVentana(frm)
    End Sub

    Private Sub RegresarEfectivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegresarEfectivoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REGRESAR EFECTIVO")
        Dim frm As New frm_LotesEfectivo_Regresar

        MostrarVentana(frm)
    End Sub

    Private Sub tsb_prepararEfectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_prepararEfectivo.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PREPARAR ENVIO DE EFECTIVO")

        'frm_EnviarEfectivo.Origen = frm_EnviarEfectivo.Tipo.Proceso
        MostrarVentana(frm_LotesEfectivo_Preparar)
    End Sub

    Private Sub RecuentoEnSitioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecuentoEnSitioToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECUENTO EN SITIO")

        MostrarVentana(frm_RecuentoD, True)
    End Sub

    Private Sub AnalisisDeEfectivoPorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalisisDeEfectivoPorClienteToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ANALISIS DE EFECTIVO POR CLIENTE")

        Dim Frm As New frm_EfectivoXCliente
        MostrarVentana(Frm, True)
    End Sub

    Private Sub ConfigurarPlantillaDeImpresionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurarPlantillaDeImpresionToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONFIGURAR PLANTILLA DE IMPRESION")
        Dim Frm As New frm_ConfigurarPlantilla
        MostrarVentana(Frm, False)
    End Sub

    Private Sub ConsultaDeImportesProcesadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeImportesProcesadosToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE IMPORTES PROCESADOS")

        Dim Frm As New frm_ConsultaDepositosLavado
        MostrarVentana(Frm, True)
    End Sub

    Private Sub AcumuladosYPromediosPorCajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcumuladosYPromediosPorCajeroToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACUMULADOS Y PROMEDIOS POR CAJERO")

        Dim Frm As New frm_AcumuladosXCajeros
        MostrarVentana(Frm, True)
    End Sub

    Private Sub EnviarArchivosDepositosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarArchivosDepositosToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACUMULADOS Y PROMEDIOS POR CAJERO")

        Dim Frm As New frm_ArchivoDepositos
        MostrarVentana(Frm, True)
    End Sub

    Private Sub ProcesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesosToolStripMenuItem.Click

    End Sub

    Private Sub ConsultarOrdenesServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarOrdenesServicioToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACUMULADOS Y PROMEDIOS POR CAJERO")

        Dim Frm As New frm_OrdenesServicios
        MostrarVentana(Frm, True)
    End Sub

    Private Sub CatálogoOrdenesCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoOrdenesCuentaToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACUMULADOS Y PROMEDIOS POR CAJERO")

        Dim Frm As New frm_CatalogoOrdenesCuentas
        MostrarVentana(Frm, True)
    End Sub


    Private Sub ConsultarReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarReToolStripMenuItem.Click
        Dim frm As New frm_ConsultaRemision
        frm.Show()
    End Sub

    Private Sub AsignarPreparacionAVerificadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarPreparacionAVerificadorToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACUMULADOS Y PROMEDIOS POR CAJERO")

        Dim Frm As New frm_AsignarPre
        MostrarVentana(Frm, True)
    End Sub
End Class
