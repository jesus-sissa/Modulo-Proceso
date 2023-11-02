Imports Modulo_Proceso.Cn_Proceso
Imports System.IO

Public Class frm_Rastreo

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Buscar()
    End Sub

    Private Sub Buscar()
        SegundosDesconexion = 0

        If tbx_Remision.Text <> "" Then
            cmb_Cia.ValorParametro = CLng(tbx_Remision.Text)
            cmb_Cia.Actualizar()

            If cmb_Cia.Items.Count = 2 Then
                cmb_Cia.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub frm_Rastreo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Cia.ValorParametro = 0
        cmb_Cia.Actualizar()

        If Not fn_Rastreo_LlenarImportes(lsv_Importe, 0) Then
            MsgBox("Ha ocurrido un error al intentar llenar los importes", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not fn_Rastreo_LlenarEnvases(lsv_Envases, 0) Then
            MsgBox("Ha ocurrido un error al intentar llenar los envases", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Importe.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Envases.Items.Count)

    End Sub

    Private Sub tbx_Remision_EnterPress() Handles tbx_Remision.EnterPress
        Buscar()
    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedIndexChanged
        SegundosDesconexion = 0

        If Not fn_Rastreo_LlenarImportes(lsv_Importe, cmb_Cia.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar consultar los Importes.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not fn_Rastreo_LlenarEnvases(lsv_Envases, cmb_Cia.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar llenar los envases", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Dim row As DataRow = fn_Rastreo_LlenarBoveda(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_FechaEntrada.Text = row("Fecha_Entrada").ToString
            tbx_HoraEntrada.Text = row("Hora_Entrada").ToString
            tbx_FechaSalida.Text = row("Fecha_Salida").ToString
            tbx_HoraSalida.Text = row("Hora_Salida").ToString
            tbx_UsuarioEntrada.Text = row("Usuario_Entrada").ToString
            tbx_UsuarioSalida.Text = row("Usuario_Salida").ToString
            cbx_DotacionPro.Checked = (row("DotacionPro").ToString = "S")
            cbx_DotacionMorralla.Checked = (row("DotacionMorr").ToString = "S")
            cbx_DotacionATM.Checked = (row("DotacionATM").ToString = "S")
            cbx_Materiales.Checked = (row("Material").ToString = "S")
            cbx_ConcentracionATM.Checked = (row("ConcentracionATM").ToString = "S")
            cbx_CustodiaATM.Checked = (row("CustodiaATM").ToString = "S")
            cbx_DotacionNom.Checked = (row("DotacionNom").ToString = "S")
            tbx_Status.Text = row("Status").ToString
        Else
            tbx_FechaEntrada.Clear()
            tbx_HoraEntrada.Clear()
            tbx_FechaSalida.Clear()
            tbx_HoraSalida.Clear()
            tbx_UsuarioEntrada.Clear()
            tbx_UsuarioSalida.Clear()
            cbx_DotacionPro.Checked = False
            cbx_DotacionMorralla.Checked = False
            cbx_DotacionATM.Checked = False
            cbx_Materiales.Checked = False
            cbx_ConcentracionATM.Checked = False
            cbx_CustodiaATM.Checked = False
            cbx_DotacionNom.Checked = False
            tbx_Status.Clear()
        End If

        row = fn_Rastreo_LlenarProceso(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_Sesion.Text = row("Numero_Sesion").ToString
            tbx_CajaBancaria.Text = row("Caja").ToString
            tbx_Cliente.Text = row("Cliente").ToString
            tbx_CiaProceso.Text = row("CiaProceso").ToString
            tbx_Cajero.Text = row("Cajero").ToString
            tbx_GrupoDeposito.Text = row("GrupoDepo").ToString
            tbx_FechaRecepcion.Text = row("Fecha_Recibe").ToString
            tbx_FechaAsignacion.Text = row("Fecha_Asigna").ToString
            tbx_FechaInicioVerificacion.Text = row("Fecha_InicioV").ToString
            tbx_FechaFinVerificacion.Text = row("Fecha_FinV").ToString
            tbx_FechaContabilizacion.Text = row("Fecha_Contabiliza").ToString
            tbx_Fichas.Text = row("Cantidad_Fichas").ToString
            tbx_FichasContabilizadas.Text = row("Cantidad_FichasC").ToString
            tbx_Corte.Text = row("Corte_Turno").ToString
            tbx_EstacionRecibe.Text = row("Estacion_Recibe").ToString
            tbx_EstacionAsigna.Text = row("Estacion_Asigna").ToString
            tbx_EstacionVerifica.Text = row("Estacion_Verifica").ToString
            tbx_MinutosVerificando.Text = row("MinutosVerificando").ToString
            tbx_StatusPro.Text = row("Status").ToString
            'Datos del Archivo de texto en caso de que exista
            If row("NumeroArchivo") = 0 Then
                tbx_ArchivoNumero.Text = ""
            Else
                tbx_ArchivoNumero.Text = row("NumeroArchivo").ToString
            End If
            tbx_ArchivoFechaG.Text = row("FechaGenera").ToString
            tbx_ArchivoHoraG.Text = row("HoraGenera").ToString
            tbx_ArchivoFechaA.Text = row("FechaAplicacion").ToString
            tbx_ArchivoUsuarioG.Text = row("UsuarioGenera").ToString


        Else
            tbx_Sesion.Clear()
            tbx_CajaBancaria.Clear()
            tbx_Cliente.Clear()
            tbx_CiaProceso.Clear()
            tbx_Cajero.Clear()
            tbx_GrupoDeposito.Clear()
            tbx_FechaRecepcion.Clear()
            tbx_FechaAsignacion.Clear()
            tbx_FechaInicioVerificacion.Clear()
            tbx_FechaFinVerificacion.Clear()
            tbx_FechaContabilizacion.Clear()
            tbx_Fichas.Clear()
            tbx_FichasContabilizadas.Clear()
            tbx_Corte.Clear()
            tbx_EstacionRecibe.Clear()
            tbx_EstacionAsigna.Clear()
            tbx_EstacionVerifica.Clear()
            tbx_MinutosVerificando.Clear()
            tbx_StatusPro.Clear()

            tbx_ArchivoNumero.Clear()
            tbx_ArchivoFechaG.Clear()
            tbx_ArchivoHoraG.Clear()
            tbx_ArchivoFechaA.Clear()
            tbx_ArchivoUsuarioG.Clear()
        End If

        row = fn_Rastreo_LlenarProDotaciones(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_FechaCaptura.Text = row("Fecha_Captura").ToString
            tbx_FechaValida.Text = row("Fecha_Valida").ToString
            tbx_FechaEntrega.Text = row("Fecha_Entrega").ToString
            tbx_FechaCancela.Text = row("Fecha_Cancela").ToString
            tbx_Caja.Text = row("Caja").ToString
            tbx_NombreCliente.Text = row("Cliente").ToString
            tbx_UsuarioCaptura.Text = row("Usuario_Captura").ToString
            tbx_UsuarioValida.Text = row("Usuario_Valida").ToString
            tbx_UsuarioCancela.Text = row("Usuario_Cancela").ToString
            tbx_Importe.Text = row("Importe").ToString
            tbx_Envases.Text = row("Envases").ToString
            tbx_Moneda.Text = row("Moneda").ToString
            tbx_Tipo.Text = row("Tipo").ToString
            tbx_StatusDP.Text = row("Status").ToString
        Else
            tbx_FechaCaptura.Clear()
            tbx_FechaValida.Clear()
            tbx_FechaEntrega.Clear()
            tbx_FechaCancela.Clear()
            tbx_Caja.Clear()
            tbx_NombreCliente.Clear()
            tbx_UsuarioCaptura.Clear()
            tbx_UsuarioValida.Clear()
            tbx_UsuarioCancela.Clear()
            tbx_Importe.Clear()
            tbx_Envases.Clear()
            tbx_Moneda.Clear()
            tbx_Tipo.Clear()
            tbx_StatusDP.Clear()
        End If

        row = fn_Rastreo_LlenarCajDotaciones(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_FechaCapturaC.Text = row("Fecha_Captura").ToString
            tbx_FechaValidaC.Text = row("Fecha_Valida").ToString
            tbx_FechaEntregaC.Text = row("Fecha_Entrega").ToString
            tbx_FechaCancelaC.Text = row("Fecha_Cancela").ToString
            tbx_CajaC.Text = row("Caja").ToString
            tbx_NumeroCajeroC.Text = row("Numero_Cajero").ToString
            tbx_CajeroC.Text = row("Cajero").ToString
            tbx_UsuarioCapturaC.Text = row("Usuario_Captura").ToString
            tbx_UsuarioValidaC.Text = row("Usuario_Valida").ToString
            tbx_UsuarioCancelaC.Text = row("Usuario_Cancela").ToString
            tbx_ImporteC.Text = row("Importe").ToString
            tbx_EnvasesC.Text = row("Envases").ToString
            tbx_MonedaC.Text = row("Moneda").ToString
            tbx_StatusDC.Text = row("Status").ToString
        Else
            tbx_FechaCapturaC.Clear()
            tbx_FechaValidaC.Clear()
            tbx_FechaEntregaC.Clear()
            tbx_FechaCancelaC.Clear()
            tbx_CajaC.Clear()
            tbx_NumeroCajeroC.Clear()
            tbx_CajeroC.Clear()
            tbx_UsuarioCapturaC.Clear()
            tbx_UsuarioValidaC.Clear()
            tbx_UsuarioCancelaC.Clear()
            tbx_ImporteC.Clear()
            tbx_EnvasesC.Clear()
            tbx_MonedaC.Clear()
            tbx_StatusDC.Clear()
        End If

        row = fn_Rastreo_LlenarMateriales(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_DestinoM.Text = row("Destino")
            tbx_FechaRegistroM.Text = row("Fehca_Registro")
            tbx_HoraRegistroM.Text = row("Hora_Registro")
            tbx_UsuarioRegistroM.Text = row("Fehca_Valida")
            tbx_FechaValidaM.Text = row("Hora_Valida")
            tbx_HoraValidaM.Text = row("Usuario_Registro")
            tbx_UsuarioValidaM.Text = row("usuario_Valida")
            tbx_StatusM.Text = row("Status")
        Else
            tbx_DestinoM.Clear()
            tbx_FechaRegistroM.Clear()
            tbx_HoraRegistroM.Clear()
            tbx_UsuarioRegistroM.Clear()
            tbx_FechaValidaM.Clear()
            tbx_HoraValidaM.Clear()
            tbx_UsuarioValidaM.Clear()
            tbx_StatusM.Clear()
        End If

        row = fn_Rastreo_LlenarTraslado(cmb_Cia.SelectedValue)
        If row IsNot Nothing Then
            tbx_RutaT.Text = row("Ruta")
            tbx_FechaT.Text = row("Fecha")
            tbx_OrigenT.Text = row("Origen")
            tbx_DestinoT.Text = row("Destino")
            tbx_CajeroT.Text = row("Cajero")
            tbx_OperadorT.Text = row("Operador")
            tbx_HorarioRecoleccionT.Text = row("HR_Recoleccion")
            tbx_HorarioEntregaT.Text = row("HR_Entrega")
            tbx_StatusT.Text = row("Status")
        Else
            tbx_RutaT.Clear()
            tbx_FechaT.Clear()
            tbx_OrigenT.Clear()
            tbx_DestinoT.Clear()
            tbx_CajeroT.Clear()
            tbx_OperadorT.Clear()
            tbx_HorarioRecoleccionT.Clear()
            tbx_HorarioEntregaT.Clear()
            tbx_StatusT.Clear()
        End If

        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Importe.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Envases.Items.Count)

    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Importe_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Importe.MouseHover, lsv_Envases.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub tab_Traslado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_Traslado.MouseHover, tab_Boveda.MouseHover, Tab_DotacionesC.MouseHover, tab_DotacionesP.MouseHover, Tab_Materiales.MouseHover, tab_Remisiones.MouseHover, TabProceso.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub tc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc.SelectedIndexChanged
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Importe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Importe.SelectedIndexChanged

    End Sub
    Private Sub tbx_Remision_EnterPress(ByRef Cancel As System.Boolean) Handles tbx_Remision.EnterPress

    End Sub

    Private Sub btn_verRmision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_verRmision.Click
        If tbx_Remision.Text.Trim = "" Then Exit Sub
        Try

            Dim noti As DataTable = Cn_Proceso.obtenerNotificacion(tbx_Remision.Text.Trim)
            Dim dtRemisionImporte As DataTable = Cn_Proceso.obtenerRemisionWebImporte(tbx_Remision.Text.Trim)
            Dim dtEnvases As DataTable = Cn_Proceso.obtenerEnvases(tbx_Remision.Text.Trim)
            Dim dtMonedas As DataTable = Cn_Proceso.obtenerImporteMoneda(tbx_Remision.Text.Trim)

            Dim envases As String = Cn_Proceso.obtenerEnvases(dtEnvases)
            Dim cantEnvaseBillete As String = Cn_Proceso.obtenerEnvaseMoneda(dtEnvases)
            Dim cantEnvaseMixto As String = Cn_Proceso.obtenerEnvaseMixto(dtEnvases)
            Dim cantEnvaseMorr As String = Cn_Proceso.obtenerEnvaseMorralla(dtEnvases)

            Dim impPesos As Decimal = Cn_Proceso.obtenerMonenadaNacional(dtMonedas)
            Dim impExtranjero As Decimal = Cn_Proceso.obtenerMonedaExtranjera(dtMonedas)
            Dim impDoctos As Decimal = Cn_Proceso.obtenerDocumentos(dtMonedas)


            If dtRemisionImporte.Rows.Count = 0 Then
                Dim dr As DataRow = dtRemisionImporte.NewRow()
                dr("Mil") = 0
                dr("Cien") = 0
                dr("MVeinte") = 0
                dr("MDos") = 0
                dr("MPVeinte") = 0
                dr("Quinientos") = 0
                dr("Cincuenta") = 0
                dr("MDiez") = 0
                dr("MUno") = 0
                dr("MPDiez") = 0
                dr("Docientos") = 0
                dr("Veinte") = 0
                dr("MCinco") = 0
                dr("MPCincuenta") = 0
                dr("MPCinco") = 0
                dr("Id_RemisionesWebImportes") = 0
                dr("Id_Remision") = 0
                dr("Id_RemisionReal") = 0
                dtRemisionImporte.Rows.Add(dr)
            End If
            Dim stream As MemoryStream = RemisionDigital.Class1.crearPDF(noti(0)("Numero_Remision").ToString(), noti(0)("Fecha").ToString(), noti(0)("Hora").ToString(), noti(0)("Envases").ToString() & "+ " + noti(0)("EnvasesSN").ToString() & " S/N", envases, CStr(impDoctos + impExtranjero + impPesos), FuncionesGlobales.fn_EnLetras((impDoctos + impExtranjero + impPesos).ToString()), noti(0)("NombreClienteOrigen").ToString(), noti(0)("ClaveClienteOrigen").ToString(), noti(0)("DireccionOrigen").ToString(), noti(0)("NombreClienteDestino").ToString(), noti(0)("DireccionDestino").ToString(), noti(0)("Clave_Ruta").ToString(), noti(0)("CiaTraslada").ToString(), noti(0)("Unidad").ToString(), noti(0)("Cajero").ToString(), noti(0)("UsuarioClienteFirma").ToString(), Convert.ToString(impPesos), Convert.ToString(impExtranjero), Convert.ToString(impDoctos), cantEnvaseBillete.ToString(), cantEnvaseMorr.ToString(), cantEnvaseMixto.ToString(), dtRemisionImporte.Rows(0)("Mil").ToString(), dtRemisionImporte.Rows(0)("Quinientos").ToString(), dtRemisionImporte.Rows(0)("Docientos").ToString(), dtRemisionImporte.Rows(0)("Cien").ToString(), dtRemisionImporte.Rows(0)("Cincuenta").ToString(), dtRemisionImporte.Rows(0)("Veinte").ToString(), dtRemisionImporte.Rows(0)("MVeinte").ToString(), dtRemisionImporte.Rows(0)("MDiez").ToString(), dtRemisionImporte.Rows(0)("MCinco").ToString(), dtRemisionImporte.Rows(0)("MDos").ToString(), dtRemisionImporte.Rows(0)("MUno").ToString(), dtRemisionImporte.Rows(0)("MPCincuenta").ToString(), dtRemisionImporte.Rows(0)("MPVeinte").ToString(), dtRemisionImporte.Rows(0)("MPDiez").ToString(), dtRemisionImporte.Rows(0)("MPCinco").ToString(), noti(0)("Comentarios").ToString())

            Dim frm As New frm_ConsultaRemision
            frm.ms = stream
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al buscar la remision." + ex.Message)
        End Try
    End Sub
End Class