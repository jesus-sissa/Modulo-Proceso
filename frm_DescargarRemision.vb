Imports System.IO
Imports FuncionesGlobales.FuncionesGlobales
Public Class frm_DescargarRemision

    Dim _path As String
    Private Sub Btn_Descargar_Click(sender As Object, e As EventArgs) Handles Btn_Descargar.Click

        If _path = "" Then
            MsgBox("Seleccione la ruta de descarga.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        Dim NumeroRemision As Decimal = 0
        If tbx_numeroRemision.Text.Trim() <> "" AndAlso IsNumeric(tbx_numeroRemision.Text.Trim()) Then
            NumeroRemision = CDec(tbx_numeroRemision.Text)
        Else
            tbx_numeroRemision.Focus()
            Exit Sub
        End If

        Try

            Dim notificiones As DataTable = Remision_Digital.obtenerNotificacion(Remision_Digital.obtenerPunto(NumeroRemision))

            If notificiones.Rows.Count > 0 Then
                '  im Query = dt.AsEnumerable.Where(Function(dr) dr("column name").ToString = "something").ToList
                Dim remisiones As DataTable = notificiones.AsEnumerable.Where(Function(r) r("Numero_Remision").ToString = NumeroRemision).CopyToDataTable()
                For Each noti As DataRow In remisiones.Rows
                    Dim dtRemisionImporte As DataTable = Remision_Digital.obtenerRemisionWebImporte(noti("Numero_Remision"))
                    Dim dtEnvases As DataTable = Remision_Digital.obtenerEnvases(noti("Numero_Remision"))
                    Dim dtMonedas As DataTable = Remision_Digital.obtenerImporteMoneda(noti("Numero_Remision"))

                    Dim envases As String = Remision_Digital.obtenerEnvases(dtEnvases)
                    Dim cantEnvaseBillete As Integer = Remision_Digital.obtenerEnvaseMoneda(dtEnvases)
                    Dim cantEnvaseMixto As Integer = Remision_Digital.obtenerEnvaseMixto(dtEnvases)
                    Dim cantEnvaseMorr As Integer = Remision_Digital.obtenerEnvaseMorralla(dtEnvases)

                    Dim impPesos As Decimal = Remision_Digital.obtenerMonenadaNacional(dtMonedas)
                    Dim impExtranjero As Decimal = Remision_Digital.obtenerMonenadaExtranjera(dtMonedas)
                    Dim impDoctos As Decimal = Remision_Digital.obtenerDocumentos(dtMonedas)

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

                    Dim pdf As MemoryStream = Remision_Digital.crearPDF(noti("Numero_Remision").ToString(), noti("Fecha").ToString(), noti("Hora").ToString(),
                                                                           noti("Envases").ToString() + "+ " + noti("EnvasesSN").ToString() + " S/N", envases, Convert.ToString(impDoctos + impExtranjero + impPesos), fn_EnLetras((impDoctos + impExtranjero + impPesos).ToString()),
                                                                           noti("NombreClienteOrigen").ToString(), noti("ClaveClienteOrigen").ToString(), noti("DireccionOrigen").ToString(),
                                                                           noti("NombreClienteDestino").ToString(), noti("DireccionDestino").ToString(), noti("Clave_Ruta").ToString(),
                                                                           noti("CiaTraslada").ToString(), noti("Unidad").ToString(), noti("Cajero").ToString(),
                                                                           noti("UsuarioClienteFirma").ToString(), Convert.ToString(impPesos), Convert.ToString(impExtranjero), Convert.ToString(impDoctos),
                                                                           cantEnvaseBillete.ToString(), cantEnvaseMorr.ToString(), cantEnvaseMixto.ToString(),
                                                                           dtRemisionImporte.Rows(0)("Mil").ToString(), dtRemisionImporte.Rows(0)("Quinientos").ToString(), dtRemisionImporte.Rows(0)("Docientos").ToString(),
                                                                           dtRemisionImporte.Rows(0)("Cien").ToString(), dtRemisionImporte.Rows(0)("Cincuenta").ToString(), dtRemisionImporte.Rows(0)("Veinte").ToString(),
                                                                           dtRemisionImporte.Rows(0)("MVeinte").ToString(), dtRemisionImporte.Rows(0)("MDiez").ToString(), dtRemisionImporte.Rows(0)("MCinco").ToString(),
                                                                           dtRemisionImporte.Rows(0)("MDos").ToString(), dtRemisionImporte.Rows(0)("MUno").ToString(), dtRemisionImporte.Rows(0)("MPCincuenta").ToString(),
                                                                           dtRemisionImporte.Rows(0)("MPVeinte").ToString(), dtRemisionImporte.Rows(0)("MPDiez").ToString(), dtRemisionImporte.Rows(0)("MPCinco").ToString(), noti("Comentarios").ToString())


                    'guardar pdf

                    If pdf IsNot Nothing Then
                        Dim pdfile As String = _path + "\" + NumeroRemision.ToString() + ".pdf"
                        If File.Exists(pdfile) Then
                            File.Delete(pdfile)
                        End If
                        Dim fs As FileStream = File.Create(pdfile)
                        fs.Write(pdf.ToArray(), 0, pdf.Length)
                        fs.Close()
                        tbx_numeroRemision.Text = ""
                        tbx_numeroRemision.Focus()
                        MsgBox("Descargado Corractamente", MsgBoxStyle.Information, frm_MENU.Text)
                    End If
                Next
            Else
                MsgBox("No se pudo descargar la Remision.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_numeroRemision.Focus()
            End If
        Catch ex As Exception
            MsgBox("Falta Informacion(Firma,autorizacion,etc) en la remision, no se puede descargar Remision", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click
        Dim Folder As New FolderBrowserDialog()
        If Folder.ShowDialog = DialogResult.OK Then
            _path = Folder.SelectedPath
            tbx_path.Text = Folder.SelectedPath
        End If
    End Sub

    Private Sub frm_DescargarRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class