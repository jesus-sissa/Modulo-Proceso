Imports Modulo_Proceso.Cn_Proceso
Imports fs = Microsoft.VisualBasic.FileIO.FileSystem
Imports System.Drawing.Imaging
Imports System.IO


Public Class frm_TabularCheques

    Private Sub frm_TabularCheques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_banco.Actualizar()
        cmb_Moneda.Actualizar()

        Validar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Generar.Click
        SegundosDesconexion = 0

        If tbx_Origen.Text.Trim = "" Then
            MsgBox("Capture un Origen", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Destino.Focus()
            Exit Sub
        End If

        Dim Archivos As Array = System.IO.Directory.GetFiles(tbx_Origen.Text, "*.txt")
        Dim Desde As Date = DateSerial(dtp_Desde.Value.Year, dtp_Desde.Value.Month, dtp_Desde.Value.Day)
        Dim Hasta As Date = DateSerial(dtp_Hasta.Value.Year, dtp_Hasta.Value.Month, dtp_Hasta.Value.Day)
        Dim Indice As Integer = 0
        Dim ImporteTotal As Decimal = 0
        Dim ChequesArchivo, ChequesDB As Integer

        'Aqui se valida que no exista el archivo
        If fs.FileExists(tbx_Destino.Text & "\DCHSISSA.txt") Then
            If MsgBox("El archivo '" & tbx_Destino.Text & "\DCHSISSA.txt' ya existe desea reemplazarlo?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                fs.DeleteFile(tbx_Destino.Text & "\DCHSISSA.txt")
            Else
                MsgBox("No se realizó ningún movimiento.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
        End If

        'Aqui se eliminan todas las imagenes anteriores
        If System.IO.Directory.GetFiles(tbx_Destino.Text, "*.tif").Length > 0 Then
            If MsgBox("Se encontrarón algunas imagenes en la carpeta destino, al generar el archivo las imagenes se eliminarán. ¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                Kill(tbx_Destino.Text & "\*.tif")
            Else
                MsgBox("No se realizó ningún movimiento.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
        End If

        'En esta variable se va a almacenar todo el contenido del archivo
        Dim Datos As New List(Of String)

        'En esta tabla se van a almacenar los datos de los archivos para el reporte Tabular
        Dim Tbl As New DataTable
        With Tbl
            .Columns.Add(New DataColumn("Clave", GetType(String)))
            .Columns.Add(New DataColumn("Importe", GetType(Decimal)))
            .Columns.Add(New DataColumn("Propio", GetType(String)))
        End With

        'Aqui se copian los cheques a la variable
        For Each Archivo As String In Archivos
            Dim Nombre As String = Split(Archivo, "\")(Split(Archivo, "\").Length - 1)
            Dim Año As String = Nombre.Substring(1 + 9, 2)
            Dim Mes As String = Nombre.Substring(3 + 9, 2)
            Dim Dia As String = Nombre.Substring(5 + 9, 2)

            'Esta linea valida que el archivo tenga el nombre con el formato correcto
            If Microsoft.VisualBasic.Left(Nombre, 1) = "C" And IsNumeric(Año) And IsNumeric(Mes) And IsNumeric(Dia) Then

                'Esta linea valida que el archivo cumpla con el rango de fechas seleccionado
                If DateSerial(Año, Mes, Dia) >= Desde And DateSerial(Año, Mes, Dia) <= Hasta Then

                    'Aqui se lee el archivo
                    Dim rdr As New System.IO.StreamReader(Archivo)
                    Dim Contenido() As String = Split(rdr.ReadToEnd, Chr(13))

                    'Aqui se procesa linea por linea el archivo de origen
                    For i As Integer = 1 To Contenido.Length - 1

                        Dim Campos As Array = Split(Contenido(i), ",")

                        'Esta linea valida que la linea no este vacia, como por ejemplo un enter al final
                        If Campos.Length > 1 Then

                            'Estas dos variables son para los totales del encabezado
                            Indice += 1
                            ImporteTotal += CDec(Campos(5)) 'CDec(Campos(Campos.Length - 1))

                            'Aqui se pasa la linea a la variable con el nuevo indice
                            Datos.Add(Indice & Microsoft.VisualBasic.Right(Contenido(i), Len(Contenido(i)) - Contenido(i).IndexOf(",")))

                            'Aqui se obtienen los datos necesarios de la banda magnetica
                            'Ojo esta banda magnetica no tiene separadores
                            Dim BandaMagnetica As String = Campos(4)
                            Dim Clave_Banco As String = Mid(BandaMagnetica, 10, 3)
                            Dim Cuenta As String = Mid(BandaMagnetica, 14, 11)
                            Dim Numero As String = Mid(BandaMagnetica, 25, 7)

                            'Aqui se obtiene la imagen de la base de datos
                            'If Clave_Banco = cmb_banco.SelectedValue Then
                            Dim Id_Cheque As Long = fn_Buscar_IdCheque(Clave_Banco, Cuenta, Numero)

                            If Id_Cheque > 0 Then
                                If (cbx_ImagenFrontal.Checked Or cbx_ImagenTrasera.Checked) AndAlso fn_LeerCheque(Id_Cheque, tbx_Destino.Text, Cuenta & "_" & Numero) Then
                                    ChequesDB += 1
                                End If
                            End If
                            If (cbx_ImagenFrontal.Checked Or cbx_ImagenTrasera.Checked) Then ChequesArchivo += 1

                            'End If

                            'Aqui se guardan los datos en una tabla para el reporte tabular
                            Dim row As DataRow = Tbl.NewRow
                            row("Clave") = Clave_Banco
                            row("Importe") = CDec(Campos(5)) 'CDec(Campos(Campos.Length - 1))
                            Tbl.Rows.Add(row)

                        End If
                    Next
                End If
            End If
        Next

        'Aqui se Agrega el encabezado al principio de la variable
        Datos.Insert(0, "C," & Microsoft.VisualBasic.Format(Today, "yyyyMMdd") & "," & "00," & Indice & "," & Microsoft.VisualBasic.Format(ImporteTotal, "#0.00"))

        'Aqui se vacia el contenido de la variable en el archivo de texto
        FileOpen(1, tbx_Destino.Text & "\DCHSISSA.txt", OpenMode.Output)
        For Each Linea As String In Datos
            WriteLine(1, Linea.ToCharArray)
        Next
        FileClose(1)

        'Aqui se genera el reporte tabular
        If cbx_GenerarTabular.Checked Then

            Dim Maximo As Decimal = tbx_ImporteLimite.Text
            Dim Cheques = From c As DataRow In Tbl.Rows _
                          Join b As DataRow In CType(cmb_banco.DataSource, DataTable).Rows On c("Clave").ToString Equals b("Clave").ToString _
                          Select New With { _
                          .Clave = c("Clave"), _
                          .Banco = b("Nombre"), _
                          .ChMen = If(c("Importe") <= Maximo, 1, 0), _
                          .IMen = If(c("Importe") <= Maximo, CDec(c("Importe")), 0), _
                          .ChMay = If(c("Importe") > Maximo, 1, 0), _
                          .IMay = If(c("Importe") > Maximo, CDec(c("Importe")), 0)}

            Dim Propios = From c In Cheques Where c.Clave = cmb_banco.SelectedValue Select c
            Dim Otros = From c In Cheques Where c.Clave <> cmb_banco.SelectedValue Select c

            '------------
            Dim versionHC As Boolean = False
            Dim ObjetoHC As String = ""
            Dim xls As Object
            Dim suma As String = ""
            '-----para Microsoft Office(Excel)
            Try
                ObjetoHC = "Excel.Application"
                xls = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try

            '-----para KingSoft Office (Spreadsheets) 
            If versionHC = False Then
                Try
                    ObjetoHC = "Ket.Application"
                    xls = CreateObject(ObjetoHC)
                    versionHC = True
                Catch ex As Exception
                    versionHC = False
                End Try
            End If
            If Not versionHC Then
                MsgBox("Ocurrió un error al intentar generar el reporte de Excel.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            'Creando el libro

            xls.SheetsInNewWorkbook = 3
            xls.Workbooks.Add()
            Dim Hoja As Object

            If xls.Worksheets(1).name = "Sheet1" Then
                suma = "=Sum"
            Else
                suma = "=Suma"
            End If
            '------------

            Dim Fila As Integer = 3

            Dim wshPropios As Object = xls.Sheets(1)
            wshPropios.Name = "Propios"

            wshPropios.Range("A1:E5").Borders.value = True '(lEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            wshPropios.Range("A1:E2").Font.Bold = True

            With wshPropios.Range("A1:E1")
                .Merge()
                .Value = "CHEQUES PROPIOS"
                .HorizontalAlignment = -4108 'Excel.Constants.xlCenter
            End With

            wshPropios.Range("B2").Value = "BANCO"
            wshPropios.Range("C2").Value = "NOMBRE"
            wshPropios.Range("D2").Value = "CHEQUES"
            wshPropios.Range("E2").Value = "IMPORTE"

            wshPropios.Range("A3").Value = "Menores a " & tbx_ImporteLimite.Text & " (<=) "
            wshPropios.Range("B3").Value = cmb_banco.SelectedValue
            wshPropios.Range("C3").Value = cmb_banco.Text
            wshPropios.Range("D3").Value = Propios.Sum(Function(f) f.ChMen)
            wshPropios.Range("E3").NumberFormat = "#,##0.00"
            wshPropios.Range("E3").Value = Propios.Sum(Function(f) f.IMen)

            wshPropios.Range("A4").Value = "Mayores a " & tbx_ImporteLimite.Text & " (>) "
            wshPropios.Range("B4").Value = cmb_banco.SelectedValue
            wshPropios.Range("C4").Value = cmb_banco.Text
            Dim Mayores = From r As DataRow In Tbl.Rows Where r("Importe") > CDec(tbx_ImporteLimite.Text) And r("Clave") = cmb_banco.SelectedValue Select r
            wshPropios.Range("D4").Value = Propios.Sum(Function(f) f.ChMay)
            wshPropios.Range("E4").NumberFormat = "#,##0.00"
            wshPropios.Range("E4").Value = Propios.Sum(Function(f) f.IMay)

            wshPropios.Range("D5").Value = Propios.Sum(Function(f) f.ChMay + f.ChMen)
            wshPropios.Range("E5").NumberFormat = "#,##0.00"
            wshPropios.Range("E5").Value = Propios.Sum(Function(f) f.IMay + f.IMen)

            wshPropios.Range("A:E").EntireColumn.AutoFit()

            Dim wshOtrosBancos As Object = xls.Sheets(2)
            wshOtrosBancos.Name = "Otros Bancos"

            wshOtrosBancos.Range("A1:F2").Font.Bold = True

            wshOtrosBancos.Range("A1:F1").Merge()
            wshOtrosBancos.Range("A1:F1").HorizontalAlignment = -4108 'Excel.Constants.xlCenter
            wshOtrosBancos.Range("A1:F1").Value = "CHEQUES DE OTROS BANCOS"

            wshOtrosBancos.Range("A2:A3").Merge()
            wshOtrosBancos.Range("A2:A3").Value = "CLAVE"

            wshOtrosBancos.Range("B2:B3").Merge()
            wshOtrosBancos.Range("B2:B3").Value = "BANCO"

            wshOtrosBancos.Range("C2:D2").Merge()
            wshOtrosBancos.Range("C2:D2").Value = "Menores a " & tbx_ImporteLimite.Text & " (<=) "
            wshOtrosBancos.Range("C3").Value = "CHEQUES"
            wshOtrosBancos.Range("D3").Value = "IMPORTE"

            wshOtrosBancos.Range("E2:F2").Merge()
            wshOtrosBancos.Range("E2:F2").Value = "Mayores a " & tbx_ImporteLimite.Text & " (>) "
            wshOtrosBancos.Range("E3").Value = "CHEQUES"
            wshOtrosBancos.Range("F3").Value = "IMPORTE"

            Dim Reporte = From c In Otros _
                        Group c By Clave = c.Clave, Banco = c.Banco Into g = Group _
                        Select New With { _
                        .Clave = Clave, _
                        .Banco = Banco, _
                        .ChMen = g.Sum(Function(p) p.ChMen), _
                        .IMen = g.Sum(Function(p) p.IMen), _
                        .ChMay = g.Sum(Function(p) p.ChMay), _
                        .IMay = g.Sum(Function(p) p.IMay)}

            For i As Integer = 0 To Reporte.Count - 1
                Fila += 1
                wshOtrosBancos.Range("A" & Fila).Value = Reporte(i).Clave
                wshOtrosBancos.Range("B" & Fila).Value = Reporte(i).Banco
                wshOtrosBancos.Range("C" & Fila).Value = Reporte(i).ChMen
                wshOtrosBancos.Range("D" & Fila).NumberFormat = "#,##0.00"
                wshOtrosBancos.Range("D" & Fila).Value = Reporte(i).IMen
                wshOtrosBancos.Range("E" & Fila).Value = Reporte(i).ChMay
                wshOtrosBancos.Range("F" & Fila).NumberFormat = "#,##0.00"
                wshOtrosBancos.Range("F" & Fila).Value = Reporte(i).IMay
            Next

            Fila += 1
            Dim TipoR = Reporte.GetType
            wshOtrosBancos.Range("C" & Fila).Value = Reporte.Sum(Function(p) p.ChMen)
            wshOtrosBancos.Range("D" & Fila).NumberFormat = "#,##0.00"
            wshOtrosBancos.Range("D" & Fila).Value = Reporte.Sum(Function(p) p.IMen)
            wshOtrosBancos.Range("E" & Fila).Value = Reporte.Sum(Function(p) p.ChMay)
            wshOtrosBancos.Range("F" & Fila).NumberFormat = "#,##0.00"
            wshOtrosBancos.Range("F" & Fila).Value = Reporte.Sum(Function(p) p.IMay)

            wshOtrosBancos.Range("A1:F" & Fila).Borders.value = True '(xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous

            wshOtrosBancos.Cells.EntireColumn.AutoFit()

            xls.Visible = True
        End If

        'Aqui se informa de la finalizacion del proceso
        If ChequesDB = ChequesArchivo Then
            MsgBox("Todos los Cheques se han exportado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("En la base de datos solo se han encontrado " & ChequesDB & " de los " & ChequesArchivo & " Cheques del banco.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        End If

    End Sub

    Public Function sumarMenor(ByVal Valor As IEnumerable) As Decimal
        Dim Total As Decimal
        For Each elemento In Valor
            Total = elemento.IMen
        Next
        Return Total
    End Function

    Public Function sumarMayor(ByVal Valor As IEnumerable) As Decimal
        Dim Total As Decimal
        For Each elemento In Valor
            Total = elemento.IMay
        Next
        Return Total
    End Function

    Private Function fn_LeerCheque(ByVal Id_Cheque As Long, ByVal Path As String, ByVal Micr As String) As Boolean
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasChequesI_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_Cheque", SqlDbType.BigInt, Id_Cheque)

        'Leer de SQL
        Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

        If dt.Rows.Count > 0 Then
            'Aqui se obtiene la imagen frontal
            If cbx_ImagenFrontal.Checked Then
                Dim ms1 As MemoryStream = New MemoryStream(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
                ms1.Write(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
                Image.FromStream(ms1, True).Save(Path & "\" & Micr & "F.tif", ImageFormat.Tiff)
            End If

            'Aqui se obtiene la imagen trasera
            If cbx_ImagenTrasera.Checked Then
                Dim ms2 As MemoryStream = New MemoryStream(dt.Rows(0)("Back1"), 0, dt.Rows(0)("Back1").Length)
                ms2.Write(dt.Rows(0)("Back1"), 0, dt.Rows(0)("Back1").Length)
                Image.FromStream(ms2, True).Save(Path & "\" & Micr & "B.tif", ImageFormat.Tiff)
            End If

            Return True
        Else
            Return False
        End If
    End Function

    Public Function fn_Buscar_IdCheque(ByVal Clave_Banco As String, ByVal Cuenta As String, ByVal Numero As String) As Long
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasCheques_GetId", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Clave_Banco", SqlDbType.VarChar, Clave_Banco)
        Cn_Datos.Crea_Parametro(cmd, "@Cuenta", SqlDbType.VarChar, Cuenta)
        Cn_Datos.Crea_Parametro(cmd, "@Numero", SqlDbType.VarChar, Numero)

        Try
            Dim tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
            If tbl.Rows.Count > 0 Then
                If tbl.Rows(0).Item("Imagen") = 0 Then
                    Return 0
                Else
                    Return tbl.Rows(0)("Id_Cheque")
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Private Sub btn_Origen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Origen.Click
        SegundosDesconexion = 0

        If Not fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            tbx_Origen.Text = fbd.SelectedPath
        End If

        Validar()
    End Sub

    Private Sub btn_Destino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Destino.Click
        SegundosDesconexion = 0

        If Not fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            tbx_Destino.Text = fbd.SelectedPath
        End If

        Validar()
    End Sub

    Private Sub Validar()
        SegundosDesconexion = 0

        If cmb_banco.SelectedValue = 0 Then
            btn_Generar.Enabled = False
        End If

        If cmb_Moneda.SelectedValue = 0 Then
            btn_Generar.Enabled = False
        End If

        If tbx_Origen.Text = "" Then
            btn_Generar.Enabled = False
        End If

        If tbx_Destino.Text = "" Then
            btn_Generar.Enabled = False
        End If

        If Not IsNumeric(tbx_ImporteLimite.Text) Then
            btn_Generar.Enabled = False
        End If

        btn_Generar.Enabled = True
    End Sub

    Private Sub cmb_banco_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_banco.SelectedValueChanged
        Validar()
    End Sub

    Private Sub cmb_Moneda_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedValueChanged
        Validar()
    End Sub

    Private Sub tbx_ImporteLimite_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_ImporteLimite.TextChanged
        Validar()
    End Sub


End Class