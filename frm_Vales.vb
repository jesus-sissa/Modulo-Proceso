Imports Modulo_Proceso.Cn_Proceso
Imports Microsoft.Office.Interop


Public Class frm_Vales
    Private Sub frm_Vales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cmb_Cliente.AgregaParametro("@Id_CajaBancaria", 0, 1)
        Cmb_Cliente.AgregaParametro("@Status", "A", 0)
        Cmb_Cliente.Actualizar()
        Cmb_Caja_Bancaria.Actualizar()

        Cmb_Desde.AgregaParametro("@Fecha", Dtp_Desde.Value.Date, 2)
        Cmb_Desde.AgregaParametro("@Tipo_Sesion", 0, 1)
        Cmb_Desde.Actualizar()
        
        Cmb_Hasta.AgregaParametro("@Fecha", Dtp_Hasta.Value.Date, 2)
        Cmb_Hasta.AgregaParametro("@Tipo_Sesion", 0, 1)
        Cmb_Hasta.Actualizar()
        
        Lsv_Listado.Columns.Add("Fecha")
        Lsv_Listado.Columns.Add("Clave")
        Lsv_Listado.Columns.Add("Cliente")
        Lsv_Listado.Columns.Add("Documento")
        Lsv_Listado.Columns.Add("Importe")
        Lsv_Listado.Columns.Add("Observacion")

        Btn_FormatoExcel.Enabled = False
        Btn_Exportar.Enabled = False
    End Sub

    Private Sub LlenarLista()
        Cursor.Current = Cursors.WaitCursor
        If Cmb_Desde.SelectedValue = 0 Then
            MsgBox("Seleccione Una Sesion", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Desde.Focus()
            Exit Sub
        End If
        If Cmb_Hasta.SelectedValue = 0 Then
            MsgBox("Seleccione Una Sesion", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Hasta.Focus()
            Exit Sub
        End If
        If Cmb_Caja_Bancaria.SelectedValue = 0 Then
            MsgBox("indique una Caja Bancaria", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Caja_Bancaria.Focus()
            Exit Sub
        End If
        If Cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Intique un cliente", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Cliente.Focus()
            Exit Sub
        End If
        If Dtp_Desde.Value.Date > Dtp_Hasta.Value.Date Then
            MsgBox("Las Fechas son Incorectas", MsgBoxStyle.Critical, frm_MENU.Text)
            Dtp_Desde.Focus()
            Exit Sub
        End If
        Call Fn_Vales_Llenarlista(Lsv_Listado, Cmb_Caja_Bancaria.SelectedValue, Cmb_Cliente.SelectedValue, Cmb_Desde.SelectedValue, Cmb_Hasta.SelectedValue)
        If Lsv_Listado.Items.Count = 0 Then
            Btn_FormatoExcel.Enabled = False
        Else
            Btn_FormatoExcel.Enabled = True
        End If
        If Lsv_Listado.Items.Count = 0 Then
            Btn_Exportar.Enabled = False
        Else
            Btn_Exportar.Enabled = True
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, Lsv_Listado.Items.Count)
    End Sub

    Private Sub Limpiar_Lista()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, Lsv_Listado.Items.Count)
        SegundosDesconexion = 0
        Lsv_Listado.Items.Clear()
        Btn_FormatoExcel.Enabled = False
        Btn_Exportar.Enabled = False
    End Sub

    Private Sub GenerarExcel()

        Dim Dt As DataTable
        Dt = Fn_Vales_DataTable()
        If Dt Is Nothing Then
            MsgBox("Error No Hay Informacion En La Tabla")
            Exit Sub
        End If
        If Dt.Rows.Count = 0 Then
            MsgBox("Error No Hay egistros")
            Exit Sub
        End If
        '--------------
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim Xlsx As Object
        Dim suma As String = ""

        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            Xlsx = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                Xlsx = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        'Creando el libro
        'Dim objApp As Excel.Application
        'Dim objBook As Excel.Workbook
        'Dim Hoja As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value

        'objApp = New Excel.Application
        'objBook = objApp.Workbooks.Add(misValue)
        'Hoja = CType(objBook.Sheets("Hoja1"), Excel.Worksheet)
        '
        Xlsx.SheetsInNewWorkbook = 1
        Dim Book = Xlsx.Workbooks.Add
        Dim Hoja = Book.Sheets(1)

        If Xlsx.Worksheets(1).name = "Sheet1" Then
            ' Hoja = Xlsx.Sheets("Sheet1")
            suma = "=SUM"
        Else
            'Hoja = Xlsx.Sheets("Hoja1")
            suma = "=SUMA"
        End If
        '------------
        Dim Fila As Integer = 3
        Dim Columna As Integer = 2
        Dim X As Integer = 1
        Dim ListaFechas As New List(Of String)
        Hoja.Range("C1").value = "Del" & " " & Dtp_Desde.Value.Date & " " & "Al" & " " & Dtp_Hasta.Value.Date
        Hoja.Range("A2").value = "DIA"

        'ListaFechas.Add(Lsv_Listado.Items(1).Text)

        For Each I As DataRow In Dt.Rows
            Hoja.cells(2, Columna).value = I("descripcion")
            X += 1
            Columna += 1

        Next

        For Each r As ListViewItem In Lsv_Listado.Items
            If Not ListaFechas.Contains(r.Text) Then
                ListaFechas.Add(r.Text)
            End If
        Next

        For Each F As Date In ListaFechas
            'Dim _fecha As String = Format(CDate(F), "MM/dd/yyy")
            Hoja.Range("A" & CStr(Fila)).value = F
            Fila += 1
        Next

        Fila = 3
        For Each F As String In ListaFechas
            Columna = 2
            For Each T As DataRow In Dt.Rows
                Dim total As Single = 0
                For Each I As ListViewItem In Lsv_Listado.Items
                    If I.Text = F And I.SubItems(3).Text = T("descripcion") Then
                        total += CSng(I.SubItems(4).Text)
                    End If
                Next
                If CStr(total) <> 0 Then
                    Hoja.Cells(Fila, Columna) = CStr(total)
                End If
                If ListaFechas.IndexOf(F) = ListaFechas.Count - 1 Then
                    Dim Direc5 As String = Hoja.Cells(3, Columna).address & ":" & Hoja.Cells(Fila, Columna).address
                    Hoja.Range(Hoja.Cells(Fila + 1, Columna), Hoja.Cells(Fila + 1, Columna)).FormulaLocal = "=SUMA(" + Direc5 + ")"
                    'Hoja.Cells(Fila + 1, Columna).value = "=SUMA(" & Direc5 & ")"
                End If
                Columna += 1
            Next
            Dim Direc3 As String = Hoja.Range("B" & CStr(Fila)).address & ":" & Hoja.Cells(Fila, Columna - 1).address
            'Hoja.Cells(Fila, Columna).Value = "=SUMA(" & Direc3 & ")"
            Hoja.Range(Hoja.Cells(Fila, Columna), Hoja.Cells(Fila, Columna)).FormulaLocal = "=SUMA(" & Direc3 & ")"
            Fila += 1
        Next

        Dim Direc As String = Hoja.Range("A" & CStr(Fila)).Address & ":" & Hoja.Cells(2, Columna).Address
        Dim Direc2 As String = Hoja.Range("B2").address & ":" & Hoja.Cells(2, Columna).address
        Dim Direc4 As String = Hoja.Range("B" & CStr(Fila)).address & ":" & Hoja.Cells(Fila, Columna - 1).address
        Dim Direc6 As String = Hoja.Cells(3, Columna).address & ":" & Hoja.Cells(Fila - 1, Columna).address
        Dim Direc7 As String = Hoja.Range("B3").address & ":" & Hoja.cells(Fila, Columna).address
        'Worksheets("Sheet1").Range("A1:B3").Formula = "=RAND()" 
        ' Hoja.Cells(Fila, Columna).value = "=SUMA(" & Direc6 & ")"
        Hoja.Range(Hoja.Cells(Fila, Columna), Hoja.Cells(Fila, Columna)).FormulaLocal = "=SUMA(" & Direc6 & ")"

        Hoja.Range("A" & CStr(Fila)).Value = "TOTAL"
        Hoja.Range("A" & CStr(Fila)).Font.Bold = True
        Hoja.Range("A" & CStr(Fila)).Font.Underline = True
        Hoja.Range("A" & CStr(Fila)).interior.color = System.Drawing.ColorTranslator.ToOle(Color.LightBlue)

        Hoja.Range(Direc).Borders.value = True
        Hoja.Range(Direc2).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightBlue)
        Hoja.Range(Direc2).Wraptext = True
        Hoja.Range(Direc2).RowHeight = 45
        Hoja.Range(Direc2).ColumnWidth = 15
        Hoja.Range(Direc2).HorizontalAlignment = -4108
        Hoja.Range(Direc2).Font.Bold = True
        Hoja.Range(Direc4).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Yellow)
        Hoja.Range(Direc7).NumberFormat = "$#,##0.00"

        Hoja.Range("A2").Font.Bold = True
        Hoja.Range("A2").interior.color = System.Drawing.ColorTranslator.ToOle(Color.LightBlue)
        Hoja.Range("C1").VerticalAlignment = -4108
        Hoja.Range("C1").Font.Size = 13
        Hoja.Range("C1").HorizontalAlignment = -4108
        Hoja.Range("C1:G1").Merge()

        Hoja.Cells(2, Columna).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightBlue)
        Hoja.Cells(2, Columna).value = "TOTAL"


        With Hoja.PageSetup
            .zoom = False
            .FitToPagesTall = 9
            .fitTopageswide = 1
        End With

        Xlsx.visible = True
        'objApp.Visible = True
        Xlsx = Nothing

    End Sub

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Cmb_Caja_Bancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Caja_Bancaria.SelectedIndexChanged
        Call Limpiar_Lista()
        Cmb_Cliente.Enabled = Not Cmb_Caja_Bancaria.SelectedValue = 0
        Cmb_Cliente.ActualizaValorParametro("@Id_CajaBancaria", Cmb_Caja_Bancaria.SelectedValue)
        Cmb_Cliente.Actualizar()
    End Sub

    Private Sub Cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Cliente.SelectedIndexChanged
        Call Limpiar_Lista()
    End Sub

    Private Sub Btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Mostrar.Click
        Call Limpiar_Lista()
        Call LlenarLista()
    End Sub

    Private Sub Dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Desde.ValueChanged
        Call Limpiar_Lista()
        Cmb_Desde.ActualizaValorParametro("@Fecha", Dtp_Desde.Value.Date)
        Cmb_Desde.Actualizar()
        If Cmb_Desde.Items.Count > 1 Then Cmb_Desde.SelectedIndex = 1
    End Sub

    Private Sub Dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Hasta.ValueChanged
        Call Limpiar_Lista()
        Cmb_Hasta.ActualizaValorParametro("@Fecha", Dtp_Hasta.Value.Date)
        Cmb_Hasta.Actualizar()
        If Cmb_Hasta.Items.Count > 1 Then Cmb_Hasta.SelectedIndex = 1
    End Sub

    Private Sub Btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_FormatoExcel.Click
        SegundosDesconexion = 0
        Call GenerarExcel()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(Lsv_Listado, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub
End Class