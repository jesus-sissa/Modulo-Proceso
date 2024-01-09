Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Modulo_Proceso.Cn_Datos
Public Class Remision_Digital

#Region "Funciones"
    ''
    Public Shared Function obtenerPunto(ByVal NumeroRemision As String) As Integer

        Try
            Dim cmd As SqlCommand = Crea_Comando("Tv_Punto_Remision", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
            Return EjecutarScalar(cmd)
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function obtenerNotificacion(ByVal IdPunto As Integer) As DataTable

        Try
            Dim cmd As SqlCommand = Crea_Comando("Tv_Puntos_ObtenerNotificacion", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Punto", SqlDbType.Int, IdPunto)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function obtenerRemisionWebImporte(ByVal NumeroRemision As String) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("NotificacionImportesWebTraslado", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function obtenerEnvases(ByVal NumeroRemision As String) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("NotificacionEnvasesTraslado", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function obtenerImporteMoneda(ByVal NumeroRemision As String) As DataTable
        Try
            Dim cmd As SqlCommand = Crea_Comando("NotificacionMonedaTraslado", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function obtenerEnvases(ByVal dtEnvases As DataTable) As String
        Dim envases As String = String.Empty
        For Each envase As DataRow In dtEnvases.Rows
            envases += "[" + envase("Numero").ToString() + "]"
        Next
    End Function

    Public Shared Function obtenerEnvaseMoneda(ByVal dtEnvases As DataTable)
        Return (From envase In dtEnvases.AsEnumerable()
                Where envase("Tipo Envase") = "BILLETE"
                Select envase).Count()
    End Function

    Public Shared Function obtenerEnvaseMixto(ByVal dtEnvases As DataTable)
        Return (From envase In dtEnvases.AsEnumerable()
                Where envase("Tipo Envase") = "MIXTO"
                Select envase).Count()
    End Function

    Public Shared Function obtenerEnvaseMorralla(ByVal dtEnvases As DataTable)
        Return (From envase In dtEnvases.AsEnumerable()
                Where envase("Tipo Envase") = "MORRALLA"
                Select envase).Count()
    End Function

    Public Shared Function obtenerMonenadaNacional(ByVal datos As DataTable) As Decimal
        Dim monedaNacional As Decimal = 0
        For Each moneda As DataRow In datos.Rows
            If moneda("Moneda").ToString() = "PESOS" Then
                monedaNacional += Convert.ToDecimal(moneda("Efectivo"))
            End If
        Next
        Return monedaNacional
    End Function

    Public Shared Function obtenerMonenadaExtranjera(ByVal datos As DataTable) As Decimal
        Dim monedaExt As Decimal = 0
        For Each moneda As DataRow In datos.Rows
            If moneda("Moneda").ToString() <> "PESOS" Then
                monedaExt += Convert.ToDecimal(moneda("Efectivo")) * Convert.ToDecimal(moneda("Tipo Cambio"))
            End If
        Next
        Return monedaExt
    End Function

    Public Shared Function obtenerDocumentos(ByVal datos As DataTable) As Decimal
        Dim doc As Decimal = 0
        For Each moneda As DataRow In datos.Rows
            doc += Convert.ToDecimal(moneda("Documentos"))
        Next
        Return doc
    End Function

#End Region

#Region "PDF"
    Shared pdfw As PdfWriter
    Public Shared Function crearPDF(NumeroRemision As String, Fecha As String, Hora As String, CantidadEnvases As String,
                             NumeroEnvase As String, ImporteTotal As String,
                             Importe_le As String, NombreOrigen As String, ClaveClienteOrigen As String,
                             DireccionOrigen As String, NombreDestino As String,
                             DireccionDestino As String, Clave_Ruta As String, NombreTraslado As String,
                             Descripcion As String, NombreEmpleado As String, NombreFirma As String,
                             Mon_Na As String, Mon_Ex As String, Mon_Otros As String,
                             Env_B As String, Env_M As String, Env_MIX As String, Mil As String,
                             Quinientos As String, Doscientos As String, Cien As String,
                             Cincuenta As String, Veinte As String, VeinteM As String, Diez As String, Cinco As String,
                             Dos As String, Uno As String, PCincuenta As String, PVeinte As String,
                             PDiez As String, PCinco As String, Notas As String) As MemoryStream

        Dim ms As MemoryStream = New MemoryStream()
        Dim doc As New Document(PageSize.A4, 15.0F, 15.0F, 40.0F, 30.0F)

        pdfw = PdfWriter.GetInstance(doc, ms)
        Dim fontN As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
        Dim fontB As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
        Dim fontB12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
        Dim cvacio As PdfPCell = New PdfPCell(New Phrase())
        cvacio.Border = 0
        doc.Open()
        Dim tabla As PdfPTable = New PdfPTable(4)
        Dim col1 As PdfPCell
        Dim col2 As PdfPCell
        Dim col3 As PdfPCell
        Dim col4 As PdfPCell
#Region "Encabezado"
        ''Encabezado
        tabla.WidthPercentage = 95
        Dim ancho As Single() = New Single() {4.5F, 9.0F, 1.0F, 4.0F}
        tabla.SetWidths(ancho)
        Dim img As Image
        img = Image.GetInstance(Convert.FromBase64String("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"))

        'img = Image.GetInstance("\\MVIRTUAL-PC\Users\MVirtual\Desktop\IVAN\PROYECTO REMISION DIGITAL\TV MOVIL 25-02-2020 Materiales\WsTv2012_33\Imagenes\Logosissa.png")
        'img = Image.GetInstance("C:\Users\LOGO\Logosissa.png")
        img.ScaleToFit(80.0F, 90.0F)
        img.SpacingBefore = 20.0F
        img.SpacingAfter = 10.0F
        img.SetAbsolutePosition(40.0F, 720.0F)
        doc.Add(img)
        tabla.AddCell(cvacio)
        col2 = New PdfPCell(New Phrase("Servicio Integral de Seguridad. S.A. de C.V.", fontB12))
        col2.Border = 0
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col2)
        tabla.AddCell(cvacio)
        tabla.AddCell(cvacio)

        tabla.AddCell(cvacio)
        col2 = New PdfPCell(New Phrase("ALVAREZ NTE. 209 MONTERREY, N.L. C.P. 64000" + vbCrLf + "CONMUTADOR: 8047-4545, 8047-4546 FAX 8047 4550" + vbCrLf + "www.sissaseguridad.com", fontN))
        col2.Border = 0
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col2)
        tabla.AddCell(cvacio)
        col3 = New PdfPCell(New Phrase("REMISION:" + vbCrLf + NumeroRemision + vbCrLf, fontB))
        col3.Border = 0
        tabla.AddCell(col3)

        tabla.AddCell(cvacio)
        col2 = New PdfPCell(iTextSharp.text.Image.GetInstance(Codigo_barras(NumeroRemision)))
        col2.Border = 0
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col2)
        tabla.AddCell(cvacio)
        col3 = New PdfPCell(New Phrase("Ruta:" + vbCrLf + Clave_Ruta + vbCrLf + "Unidad:" + vbCr + Descripcion, fontN))
        col3.Border = 0
        tabla.AddCell(col3)
        doc.Add(tabla)
        ''Cuerpo1
        Dim tabla2 As PdfPTable = New PdfPTable(12)
        tabla2.WidthPercentage = 95
        'Dim ancho2 = New Single() {2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        Dim ancho2 = New Single() {2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        tabla2.SetWidths(ancho2)
        doc.Add(New Paragraph(" "))

        col1 = New PdfPCell(New Phrase("Billetes", fontB))
        col1.Colspan = 6
        col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla2.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Monedas", fontB))
        col2.Colspan = 6
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla2.AddCell(col2)

        tabla2.AddCell("1000")
        tabla2.AddCell("500")
        tabla2.AddCell("200")
        tabla2.AddCell("100")
        tabla2.AddCell("50")
        tabla2.AddCell("20")
        tabla2.AddCell("20")
        tabla2.AddCell("10")
        tabla2.AddCell("5")
        tabla2.AddCell("2")
        tabla2.AddCell("1")
        tabla2.AddCell(".50")
        'tabla2.AddCell(".20")
        'tabla2.AddCell(".10")
        'tabla2.AddCell(".05")

        col1 = New PdfPCell(New Phrase(FormatNumber(Mil, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Quinientos, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Doscientos, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Cien, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Cincuenta, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Veinte, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(VeinteM, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Diez, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Cinco, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Dos, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(Uno, 2), fontB))
        tabla2.AddCell(col1)

        col1 = New PdfPCell(New Phrase(FormatNumber(PCincuenta, 2), fontB))
        tabla2.AddCell(col1)

        'tabla2.AddCell(FormatNumber(Quinientos, 2))
        'tabla2.AddCell(FormatNumber(Doscientos, 2))
        'tabla2.AddCell(FormatNumber(Cien, 2))
        'tabla2.AddCell(FormatNumber(Cincuenta, 2))
        'tabla2.AddCell(FormatNumber(Veinte, 2))
        'tabla2.AddCell(FormatNumber(VeinteM, 2))
        'tabla2.AddCell(FormatNumber(Diez, 2))
        'tabla2.AddCell(FormatNumber(Cinco, 2))
        'tabla2.AddCell(FormatNumber(Dos, 2))
        'tabla2.AddCell(FormatNumber(Uno, 2))
        'tabla2.AddCell(FormatNumber(PCincuenta, 2))
        'tabla2.AddCell(PVeinte)
        'tabla2.AddCell(PDiez)
        'tabla2.AddCell(PCinco)
        doc.Add(tabla2)
#End Region

#Region "Cuerpo 1 PDF"
        'Cuerpo1
        doc.Add(New Paragraph(" "))
        tabla = New PdfPTable(4)
        tabla.WidthPercentage = 95
        ancho = New Single() {4.0F, 4.0F, 4.0F, 4.0F}
        tabla.SetWidths(ancho)

        col1 = New PdfPCell(New Phrase("VALORES RECIBIDOS DE :", fontB))
        col1.Border = 0
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(NombreOrigen, fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        col3 = New PdfPCell(New Phrase("MONEDA NACIONAL:", fontB))
        col3.Border = 0
        tabla.AddCell(col3)
        col4 = New PdfPCell(New Phrase(FormatNumber(Mon_Na, 2), fontN))
        col4.Border = 0
        tabla.AddCell(col4)

        col1 = New PdfPCell(New Phrase("NUM. CLIENTE:", fontB))
        col1.Border = 0
        tabla.AddCell(col1)

        col2 = New PdfPCell(New Phrase(ClaveClienteOrigen, fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        col3 = New PdfPCell(New Phrase("MONEDA EXTRANJERA:", fontB))
        col3.Border = 0
        tabla.AddCell(col3)
        col4 = New PdfPCell(New Phrase(FormatNumber(Mon_Ex, ), fontN))
        col4.Border = 0
        tabla.AddCell(col4)

        col1 = New PdfPCell(New Phrase("FECHA:", fontB))
        col1.Border = 0
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Fecha, fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        col3 = New PdfPCell(New Phrase("OTROS:", fontB))
        col3.Border = 0
        tabla.AddCell(col3)
        col4 = New PdfPCell(New Phrase(FormatNumber(Mon_Otros, 2), fontN))
        col4.Border = 0
        tabla.AddCell(col4)

        col1 = New PdfPCell(New Phrase("DIRECCION:", fontB))
        col1.Border = 0
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(DireccionOrigen, fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        col3 = New PdfPCell(New Phrase("TOTAL:", fontB))
        col3.Border = 0
        col3.BackgroundColor = BaseColor.LIGHT_GRAY
        tabla.AddCell(col3)
        col4 = New PdfPCell(New Phrase(FormatNumber(ImporteTotal, 2), fontN))
        col4.Border = 0
        col4.BackgroundColor = BaseColor.LIGHT_GRAY 'iTextSharp.text.pdf.ExtendedColor.LIGHT_GRAY ' BaseColor.LIGHT_GRAY
        tabla.AddCell(col4)
        doc.Add(tabla)
#End Region
#Region "Cuerpo 2 PDF"
        'Cuerpo2
        doc.Add(New Paragraph(" "))
        tabla = New PdfPTable(8)
        tabla.WidthPercentage = 95
        ancho = New Single() {4.0F, 2.0F, 4.0F, 2.0F, 4.0F, 2.0F, 4.0F, 2.0F}
        tabla.SetWidths(ancho)

        col1 = New PdfPCell(New Phrase("ENVASES CON BILLETES:", fontB))
        col1.Border = 0
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Env_B, fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        col1 = New PdfPCell(New Phrase("ENVASES CON MORRALLA:", fontB))
        col1.Border = 0
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Env_M, fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        col1 = New PdfPCell(New Phrase("ENVASES MIXTOS:", fontB))
        col1.Border = 0
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Env_MIX, fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        col1 = New PdfPCell(New Phrase("ENVASES TOTALES:", fontB))
        col1.Border = 0
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(CantidadEnvases, fontN))
        col2.Border = 0
        tabla.AddCell(col2)

        col1 = New PdfPCell(New Phrase("IMPORTE EN LETRAS:", fontB))
        col1.Border = 0
        col1.Colspan = 2
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Importe_le, fontN))
        col2.Border = 0
        col2.Colspan = 6
        tabla.AddCell(col2)

        col1 = New PdfPCell(New Phrase("ENTREGAR ENVASES EN:", fontB))
        col1.Border = 0
        col1.Colspan = 2
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(NombreDestino + "(" + DireccionDestino + ")", fontN))
        col2.Border = 0
        col2.Colspan = 6
        tabla.AddCell(col2)

        'col1 = New PdfPCell(New Phrase("DIRECCIÓN:", fontB))
        'col1.Border = 0
        'col1.Colspan = 2
        'tabla.AddCell(col1)
        'col2 = New PdfPCell(New Phrase(DireccionDestino, fontN))
        'col2.Border = 0
        'col2.Colspan = 6
        'tabla.AddCell(col2)

        col1 = New PdfPCell(New Phrase("SELLOS:", fontB))
        col1.Border = 0
        col1.Colspan = 2
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(NumeroEnvase, fontN))
        col2.Border = 0
        col2.Colspan = 6
        tabla.AddCell(col2)

        col1 = New PdfPCell(New Phrase("NOTAS:", fontB))
        col1.Border = 0
        col1.Colspan = 2
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Notas, fontN))
        col2.Border = 0
        col2.Colspan = 6

        tabla.AddCell(col2)
        doc.Add(tabla)
        doc.Add(New Paragraph("         ___________________________________________________________________________"))
        'Cuerpo firmas
        doc.Add(New Paragraph(" "))
#End Region

#Region "Final"
        'doc.Add(New Paragraph(" "))
        'doc.Add(New Paragraph(" "))
        tabla = New PdfPTable(4)
        tabla.WidthPercentage = 95
        ancho = New Single() {4.0F, 3.0F, 3.0F, 4.0F}
        tabla.SetWidths(ancho)
        tabla.AddCell(cvacio)
        col1 = New PdfPCell(New Phrase("FIRMA DE REMITENTE:", fontB))
        col1.Border = 0
        col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase("TRANSPORTACION DE VALORES", fontB))
        col2.Border = 0
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col2)
        tabla.AddCell(cvacio)

        tabla.AddCell(cvacio)
        col1 = New PdfPCell(iTextSharp.text.Image.GetInstance(Qr(NombreFirma)))
        col1.Border = 0
        col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col1)
        col2 = New PdfPCell(iTextSharp.text.Image.GetInstance(Qr(NombreEmpleado)))
        col2.Border = 0
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col2)
        tabla.AddCell(cvacio)

        tabla.AddCell(cvacio)
        col1 = New PdfPCell(New Phrase("FIRMA DE CONSIGNATORIO:", fontB))
        col1.Border = 0
        col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase("FECHA Y HORA DE SERVICIO:", fontB))
        col2.Border = 0
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col2)
        tabla.AddCell(cvacio)

        tabla.AddCell(cvacio)
        col1 = New PdfPCell(iTextSharp.text.Image.GetInstance(Qr(NombreTraslado)))
        col1.Border = 0
        col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase(vbCrLf + " " + vbCrLf + Fecha + vbCrLf + Hora, fontN))
        col2.Border = 0
        col2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        tabla.AddCell(col2)
        tabla.AddCell(cvacio)
        doc.Add(tabla)
        'Cuerpo fin
        doc.Add(New Paragraph(" "))
        'doc.Add(New Paragraph(" "))
        'doc.Add(New Paragraph(" "))
        tabla = New PdfPTable(1)
        tabla.WidthPercentage = 95
        ancho = New Single() {5.0F}
        tabla.SetWidths(ancho)
        doc.Add(New Paragraph("         ___________________________________________________________________________"))
        doc.Add(New Paragraph(" "))
        col1 = New PdfPCell(New Phrase("IMPORTANTE", fontB))
        col1.Border = 0
        col1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'col1.HorizontalAlignment = HorizontalAlignment.Center
        tabla.AddCell(col1)
        col2 = New PdfPCell(New Phrase("° CUALQUIER ALTERACIÓN HACE NULO ESTE DOCUMENTO." + vbCrLf +
        "° LA COMPAÑIA  NO SERA RESPONSABLE POR INCUMPLIMIENTO DE ESTE SERVICIO EN CASOS FORTUITOS O FUERZA MAYOR." + vbCrLf +
        "° LA COMPAÑIA  NO ATENDERA RECLAMACION ALGUNA DESPUES DE 60 DIAS DE LA FECHA DE ESTE UNICO DOCUMENTO." + vbCrLf +
        "° NO ENTREGUE SUS VALORES SI EXISTE DUDA SOBRE LA IDENTIDAD DEL PERSONAL." + vbCrLf +
        "° PARA EFECTOS DE FACTURACION, CADA REMISION REPRESENTA UN SERVICIO.", fontN))
        col2.Border = 0
        tabla.AddCell(col2)
        doc.Add(tabla)

        doc.Close()
#End Region

        Dim bytes() As Byte = ms.ToArray()
        ms = New MemoryStream()
        ms.Write(bytes, 0, bytes.Length)
        ms.Position = 0
        Return ms
    End Function
    Shared Function Qr(texto As String) As Image
        If texto = "" Then
            texto = "Falta Firma"
        End If
        Dim Qqr As BarcodeQRCode = New BarcodeQRCode(texto, 1000, 1000, Nothing)
        'Dim datam As BarcodeQRCode = New BarcodeQRCode(cadena, dine, dine, Nothing)

        'Dim QqR As QRCoder.QRCodeGenerator = New QRCoder.QRCodeGenerator()
        'Dim ASSCII As ASCIIEncoding = New ASCIIEncoding()
        'Dim z = QqR.CreateQrCode(ASSCII.GetBytes(texto), QRCoder.QRCodeGenerator.ECCLevel.H)
        'Dim png As QRCoder.PngByteQRCode = New QRCoder.PngByteQRCode()
        'png.SetQRCodeData(z)
        'Dim arr = png.GetGraphic(10)
        'Dim ms As MemoryStream = New MemoryStream()
        'ms.Write(arr, 0, arr.Length)
        'Return System.Drawing.Image.FromStream(ms)
        'Dim img As System.Drawing.Bitmap = New System.Drawing.Bitmap(ms)
        'Dim codeBitmap = New System.Drawing.Bitmap(img)
        'Dim image As Image = CType(codeBitmap, Image)
        'pictureBox1.Image = b





        Dim img As Image = Qqr.GetImage()
        img.ScaleAbsolute(60, 60)
        Return img
    End Function
    Shared Function Codigo_barras(NumeroRemision) As Byte()
        Dim code As Barcode128 = New Barcode128()
        code.CodeType = Barcode128.CODE128
        code.Code = NumeroRemision
        code.AltText = NumeroRemision
        code.TextAlignment = Barcode128.UPCA
        Dim bitm As System.Drawing.Bitmap = New System.Drawing.Bitmap(code.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White))
        Using memory As MemoryStream = New MemoryStream()

            bitm.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return memory.ToArray()
        End Using
    End Function
#End Region

    Public Shared Function fn_EnLetras(ByVal numero As String, Optional ByVal IDMoneda As Integer = 0) As String

        Dim BandBilion As Boolean
        Dim b, paso, cifra As Integer
        Dim expresion As String = ""
        Dim entero As String = ""
        Dim deci As String = ""
        Dim flag As String = ""
        Dim valor As String = ""
        Dim gOpcionMil As Boolean = False
        Dim Moneda As String

        flag = "N"
        numero = Replace(numero, ",", "")
        '** AQUI REVISAMOS SI EL MONTO TIENE PARTE DECIMAL.
        For paso = 1 To Len(numero) 'DETERMINA CUANTOS CARACTERES TIENE LA CADENA
            If Mid(numero, paso, 1) = "." Or Mid(numero, paso, 1) = "," Then 'DEPENDIENDO DE LA REGIÓN
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, paso, 1) 'EXTAE LA PARTE ENTERA DEL NUMERO
                Else
                    deci = deci + Mid(numero, paso, 1) 'EXTRAE LA PARTE DECIMAL DEL NUMERO
                End If
            End If
        Next paso


        'DEFINIMOS VALOR EN LAS VARIABLES
        'CIFRA Y VALOR PARA USARLAS COMO
        'BANDERAS CONDICIONALES.

        cifra = Len(entero)

        Select Case cifra
            Case Is = 1
                valor = "UNIDAD" 'SIN USAR
            Case Is = 2
                valor = "DECENAS" 'SIN USAR
            Case Is = 3
                valor = "CENTENAS" 'SIN USAR
            Case Is = 4, 5, 6
                valor = "MILES" 'USADO
            Case Is = 7, 8, 9
                valor = "MILION" 'USADO
            Case Is = 10, 11, 12
                valor = "MILIARDOS" 'USADO
            Case Is = 13, 14, 15
                valor = "BILIONES" 'USADO
        End Select

        '*** SI LA CIFRA TIENE VALOR DECIMAL LO ASIGNAMOS AQUI.
        If Len(deci) = 1 Then
            deci = deci & "0/100."  'ANTES TENIA & "0" "/100."
        ElseIf Len(deci) = 2 Then
            deci = deci & "/100."  'ANTES TENIA & "0" "/100."
        ElseIf Len(deci) > 2 Then
            deci = Microsoft.VisualBasic.Left(deci, 2) & "/100."  'ANTES TENIA & "0" "/100."
        Else
            deci = "00/100."
        End If


        flag = "N"
        If Val(numero) >= -999999999999999.0# And Val(numero) <= 999999999999999.0# Then  'SI EL NUMERO ESTA DENTRO DE 0 A 999.999.999
            For paso = Len(entero) To 1 Step -1
                b = Len(entero) - (paso - 1)
                Select Case paso
                    Case 3, 6, 9, 12, 15
                        Select Case Mid(entero, b, 1)
                            Case "1"
                                If Mid(entero, b + 1, 1) = "0" And Mid(entero, b + 2, 1) = "0" Then
                                    expresion = expresion & "CIEN "
                                Else
                                    expresion = expresion & "CIENTO "
                                End If
                            Case "2"
                                expresion = expresion & "DOSCIENTOS "
                            Case "3"
                                expresion = expresion & "TRESCIENTOS "
                            Case "4"
                                expresion = expresion & "CUATROCIENTOS "
                            Case "5"
                                expresion = expresion & "QUINIENTOS "
                            Case "6"
                                expresion = expresion & "SEISCIENTOS "
                            Case "7"
                                expresion = expresion & "SETECIENTOS "
                            Case "8"
                                expresion = expresion & "OCHOCIENTOS "
                            Case "9"
                                expresion = expresion & "NOVECIENTOS "

                        End Select

                    Case 2, 5, 8, 11, 14
                        Select Case Mid(entero, b, 1)
                            Case "1"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    flag = "S"
                                    expresion = expresion & "DIEZ "
                                End If
                                If Mid(entero, b + 1, 1) = "1" Then
                                    flag = "S"
                                    expresion = expresion & "ONCE "
                                End If
                                If Mid(entero, b + 1, 1) = "2" Then
                                    flag = "S"
                                    expresion = expresion & "DOCE "
                                End If
                                If Mid(entero, b + 1, 1) = "3" Then
                                    flag = "S"
                                    expresion = expresion & "TRECE "
                                End If
                                If Mid(entero, b + 1, 1) = "4" Then
                                    flag = "S"
                                    expresion = expresion & "CATORCE "
                                End If
                                If Mid(entero, b + 1, 1) = "5" Then
                                    flag = "S"
                                    expresion = expresion & "QUINCE "
                                End If
                                If Mid(entero, b + 1, 1) > "5" Then
                                    flag = "N"
                                    expresion = expresion & "DIECI"
                                End If

                            Case "2"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "VEINTE "
                                    flag = "S"
                                Else
                                    expresion = expresion & "VEINTI"
                                    flag = "N"
                                End If

                            Case "3"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "TREINTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "TREINTA Y "
                                    flag = "N"
                                End If

                            Case "4"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "CUARENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "CUARENTA Y "
                                    flag = "N"
                                End If

                            Case "5"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "CINCUENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "CINCUENTA Y "
                                    flag = "N"
                                End If

                            Case "6"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "SESENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "SESENTA Y "
                                    flag = "N"
                                End If

                            Case "7"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "SETENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "SETENTA Y "
                                    flag = "N"
                                End If

                            Case "8"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "OCHENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "OCHENTA Y "
                                    flag = "N"
                                End If

                            Case "9"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "NOVENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "NOVENTA Y "
                                    flag = "N"
                                End If

                            Case "0"
                                'EXPRESION = EXPRESION & ""
                                flag = "N"
                        End Select


                    Case 1, 4, 7, 10, 13
                        Select Case Mid(entero, b, 1)
                            Case "1"

                                If flag = "N" Then
                                    If paso = 1 Then
                                        expresion = expresion & "UNO "
                                    Else
                                        expresion = expresion & "UN "
                                    End If
                                End If

                            Case "2"
                                If flag = "N" Then
                                    expresion = expresion & "DOS "
                                End If

                            Case "3"
                                If flag = "N" Then
                                    expresion = expresion & "TRES "
                                End If
                            Case "4"
                                If flag = "N" Then
                                    expresion = expresion & "CUATRO "
                                End If
                            Case "5"
                                If flag = "N" Then
                                    expresion = expresion & "CINCO "
                                End If
                            Case "6"
                                If flag = "N" Then
                                    expresion = expresion & "SEIS "
                                End If
                            Case "7"
                                If flag = "N" Then
                                    expresion = expresion & "SIETE "
                                End If
                            Case "8"
                                If flag = "N" Then
                                    expresion = expresion & "OCHO "
                                End If
                            Case "9"
                                If flag = "N" Then
                                    expresion = expresion & "NUEVE "
                                End If
                        End Select
                End Select

                '*************************************************************************

                '********* MILES PARA MILES
                If paso = 4 And valor = "MILES" Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                        (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                        Len(entero) <= 6) Then
                        expresion = expresion & "MIL "
                    End If
                End If

                '********** MILES PARA MILLONES
                If paso = 4 And valor = "MILION" Then

                    If cifra = 7 And Val(Mid(entero, 2, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If


                    If cifra = 8 And Val(Mid(entero, 3, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 9 And Val(Mid(entero, 4, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If
                End If


                '********** MILES PARA MILLARDOS
                If paso = 4 And valor = "MILIARDOS" Then

                    If cifra = 10 And Val(Mid(entero, 5, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If


                    If cifra = 11 And Val(Mid(entero, 6, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 12 And Val(Mid(entero, 7, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If
                End If

                '********** MILES PARA BILLONES
                If paso = 4 And valor = "BILIONES" Then

                    If cifra = 13 And Val(Mid(entero, 8, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 14 And Val(Mid(entero, 9, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 15 And Val(Mid(entero, 10, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If
                End If

                '**********"INICIAMOS CONDICIONES PARA USAR PALABRA MILES DE MILLONES"*****************
                Select Case gOpcionMil
                    Case True 'DESEA USAR LA PALABRA MILES DE MILLONES
                        'Z********[SOLO PARA MILLARDOS] CUANDO MILLONES ES IGUAL A CERO
                        If paso = 7 And valor = "MILIARDOS" And cifra = 10 _
                        And Val(Mid(entero, 2, 3)) = 0 Then
                            expresion = expresion & "MILLONES "
                        End If


                        If paso = 7 And valor = "MILIARDOS" And cifra = 11 _
                        And Val(Mid(entero, 3, 3)) = 0 Then
                            expresion = expresion & "MILLONES "
                        End If


                        If paso = 7 And valor = "MILIARDOS" And cifra = 12 _
                        And Val(Mid(entero, 4, 3)) = 0 Then
                            expresion = expresion & "MILLONES "
                        End If
                        'Z*****PONER MILLARDOS DE BILLONES ******
                        If paso = 10 And valor = "BILIONES" And cifra = 13 _
                        And Val(Mid(entero, 2, 3)) > 0 Then
                            expresion = expresion & "MIL "
                            BandBilion = True
                        End If

                        If paso = 10 And valor = "BILIONES" And cifra = 14 _
                        And Val(Mid(entero, 3, 3)) > 0 Then
                            expresion = expresion & "MIL "
                            BandBilion = True
                        End If

                        If paso = 10 And valor = "BILIONES" And cifra = 15 _
                        And Val(Mid(entero, 4, 3)) > 0 Then
                            expresion = expresion & "MIL "
                            BandBilion = True
                        End If

                        'Z******** SOLO PARA BILLONES CUANDO MILLARDOS ES MAS DE CERO
                        If paso = 7 And valor = "BILIONES" And cifra = 13 _
                        And Val(Mid(entero, 5, 3)) = 0 And BandBilion Then
                            expresion = expresion & "MILLONES "
                            BandBilion = False
                        End If

                        If paso = 7 And valor = "BILIONES" And cifra = 14 _
                        And Val(Mid(entero, 6, 3)) = 0 And BandBilion Then
                            expresion = expresion & "MILLONES "
                            BandBilion = False
                        End If

                        If paso = 7 And valor = "BILIONES" And cifra = 15 _
                        And Val(Mid(entero, 7, 3)) = 0 And BandBilion Then
                            expresion = expresion & "MILLONES "
                            BandBilion = False
                        End If

                        'Z********** SOLO PARA MILLARDOS PRONUNCIADOS EN MILES DE MILLONES.
                        If paso = 10 And valor = "MILIARDOS" Then
                            expresion = expresion & "MIL "
                        End If
                        '**********"TERMINAMOS CONDICIONES PARA USAR PALABRA MILES DE MILLONES"**********


                        '**********"INICIAMOS CONDICIONES PARA USAR PALABRA MILLARDO(S)"**********
                    Case Else ' DESEA USAR  LA PALABRA MILLARDOS

                        If paso = 10 And valor = "BILIONES" And cifra = 13 _
                        And Val(Mid(entero, 2, 3)) > 0 Then
                            If Val(Mid(entero, 2, 3)) = 1 Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If
                        If paso = 10 And valor = "BILIONES" And cifra = 14 _
                        And Val(Mid(entero, 3, 3)) > 0 Then
                            If Val(Mid(entero, 3, 3)) = 1 Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If
                        If paso = 10 And valor = "BILIONES" And cifra = 15 _
                        And Val(Mid(entero, 4, 3)) > 0 Then
                            If Val(Mid(entero, 4, 3)) = 1 Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If

                        '********** MILLARDOS

                        If paso = 10 And valor = "MILIARDOS" Then
                            If Len(entero) = 10 And Mid(entero, 1, 1) = "1" Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If
                        '**********"TERMINAMOS CONDICIONES PARA USAR PALABRA MILLARDO(S)"**********
                        '**************************************************************************
                End Select

                '*******[SOLO PARA MILLARDOS] CUANDO MILLONES ES MAS DE CERO

                If paso = 7 And valor = "MILIARDOS" And cifra = 10 And
                Val(Mid(entero, 2, 3)) > 0 Then
                    If Val(Mid(entero, 2, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "MILIARDOS" And cifra = 11 _
                And Val(Mid(entero, 3, 3)) > 0 Then
                    If Val(Mid(entero, 3, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "MILIARDOS" And cifra = 12 _
                And Val(Mid(entero, 4, 3)) > 0 Then
                    If Val(Mid(entero, 4, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                '*************************************************


                '******** SOLO BILLONES

                If paso = 7 And valor = "BILIONES" And cifra = 13 _
                And Val(Mid(entero, 5, 3)) > 0 Then
                    If Val(Mid(entero, 5, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "BILIONES" And cifra = 14 _
                And Val(Mid(entero, 6, 3)) > 0 Then
                    If Val(Mid(entero, 6, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "BILIONES" And cifra = 15 _
                And Val(Mid(entero, 7, 3)) > 0 Then
                    If Val(Mid(entero, 7, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If
                '****************************************************


                '********** SOLO PARA MILLONES
                If paso = 7 And valor = "MILION" Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                '******** SOLO PARA BILLONES
                If paso = 13 Then
                    If Len(entero) = 13 And Mid(entero, 1, 1) = "1" Then
                        expresion = expresion & "BILLÓN "
                    Else
                        expresion = expresion & "BILLONES "
                    End If
                End If


            Next paso

            'Agregar Moneda

            If IDMoneda <> 0 Then

                '  Moneda = fn_ObtenTipoMoneda(IDMoneda)
                ' expresion += " " + Moneda + " "
            End If


            '*** EVALUAR QUE ESCRIBIR
            If deci <> "" Then 'SI EL VALOR RESULTANTE ES NEGATIVO CON DECIMAL
                If Mid(entero, 1, 1) = "-" Or Mid(entero, 1, 1) = "(" Then
                    fn_EnLetras = "MENOS " & expresion & "CON " & deci 'ANTES & "/100"
                Else
                    fn_EnLetras = expresion & "CON " & deci 'ANTES & "/100"
                End If
            Else 'SI EL VALOR RESULTANTE ES NEGATIVO SIN DECIMAL
                If Mid(entero, 1, 1) = "-" Or Mid(entero, 1, 1) = "(" Then
                    fn_EnLetras = "MENOS " & expresion
                Else
                    fn_EnLetras = expresion 'SI NO TIENE DECIMAL
                End If
            End If

            If Val(numero) = 0 Then fn_EnLetras = "MONTO ES IGUAL A CERO." 'NO DEBERÍA LLEAGR AQUI
        Else 'SI EL NUMERO A CONVERTIR ESTÁ FUERA DEL RANGO SUPERIOR O INFERIOR
            fn_EnLetras = "ERROR EN EL DATO INTRODUCIDO"
        End If
    End Function

    Public Shared Function fn_ObtenTipoMoneda(ByVal IdMoneda As Integer) As String
        Try
            Dim ClaveSucursal As String = "01"
            Dim cnn As SqlConnection = Crea_Conexion(ClaveSucursal)
            Dim cmd As SqlCommand = Crea_Comando("Cat_Monedas_ReadTipoCambio", CommandType.StoredProcedure, cnn)
            Dim dt_lc As New DataTable

            Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.BigInt, IdMoneda)

            dt_lc = Cn_Datos.EjecutaConsulta(cmd)

            If dt_lc.Rows.Count > 0 Then
                Return (dt_lc.Rows(0)(1).ToString)
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class
