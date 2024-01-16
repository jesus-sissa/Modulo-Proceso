Imports Modulo_Proceso.Cn_Proceso
Imports CrystalDecisions.CrystalReports.Engine

Public Class frm_GuardarArchivo
    Public Id_Cia As Integer
    Public Fichas As New ds_Reportes.Tbl_FichasDataTable
    Public Fichas_Efectivo As New ds_Reportes.Tbl_FichasEfectivoDataTable
    Public Fichas_EfectivoFalso As New ds_Reportes.Tbl_FichasFalsosDataTable
    Public Cheques As New ds_Reportes.Tbl_ChequesDataTable
    Public NombreCliente, Moneda As String
    Public Fecha_Aplicacion As Date
    Public Id_CajaBancaria As Integer
    Public Id_Moneda As Integer
    Public Id_Cajero As Integer
    Public Id_GrupoDepo As Integer
    Public Id_Sesion As Integer
    Public Corte_Turno As Integer
    Dim Dt_DenominacionesB As DataTable
    Dim Dt_DenominacionesM As DataTable

    Dim tbl As DataTable

    Public Sub Actualizar(ByVal DataSource As DataTable)
        lsv_Servicios.Actualizar(DataSource, "Id_Servicio")
        Timer1.Enabled = True
        Lbl_Registros.Text = "Registros: " & lsv_Servicios.Items.Count
    End Sub

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub lsv_Servicios_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Servicios.ItemChecked
        SegundosDesconexion = 0

        btn_Guardar.Enabled = lsv_Servicios.CheckedItems.Count > 0
        btn_GuardarXficha.Enabled = lsv_Servicios.CheckedItems.Count > 0
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If lsv_Servicios.Items.Count = 0 Then
            MsgBox("No existen Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Servicios.CheckedItems.Count = 0 Then
            MsgBox("No ha seleccionado ningún Depósito.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim row As DataRow = fn_GuardarArchivo_ObtenNombre(Id_CajaBancaria, Fecha_Aplicacion, Id_Cia)

        'Exit Sub
        If row("Tipo_Archivo") = "AFIRME" Then
            Call Archivo_AFIRME(row)
        ElseIf row("Tipo_Archivo") = "BANORTE" Then
            Call Archivo_Banorte(row)
        ElseIf row("Tipo_Archivo") = "SANTANDER" Then
            Call Archivo_SANTANDER(row)
        ElseIf row("Tipo_Archivo") = "BAJIO" Then
            Call Archivo_BAJIO(row)
        Else
            Call Archivo_OTROS(row)
        End If
       

    End Sub

    Private Sub Archivo_OTROS(ByVal Row As DataRow)
        Dim Path As String
        Dim Numero As String
        Dim Nombre_ArchivoD As String
        Dim Nombre_ArchivoC As String
        Dim NombreCorto_ArchivoD As String
        Dim NombreCorto_ArchivoC As String
        Dim Numero_Proceso As Integer = 0
        Dim Numero_Archivo As String
        Dim Fecha As String
        Dim Fecha103 As String
        Dim Fila As Integer = 0
        Dim frm As New frm_Reporte
        Dim Reporte As New rpt_CorteProceso
        Dim Ds As New ds_Reportes
        Dim ClaveCia As String = ""
        Dim Numero_Plaza As String
        Dim CR As String
        Dim DigitoSeguro As Boolean = False
        Dim TieneCR As Boolean = False
        Dim Tipo_Referencia As String = ""
        Dim Longitud_Referencia As Integer = 10
        Dim Tipo_Archivo As String = ""
        Dim Clave_ProveedorArchivo As String = ""
        Dim Line As String = ""
        Dim LineC As String = ""
        Dim Etapa As Integer = 0

        Try
            With New FolderBrowserDialog
                If Not .ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
                Path = .SelectedPath
                .Dispose()
            End With

            Fecha = Format(Row("Fecha"), "yyMMdd")
            Fecha103 = Format(Row("Fecha"), "dd/MM/yyyy")
            Numero_Proceso = Row("NumeroP") 'Desde la BD ya me da el Ultimo + 1
            ClaveCia = Row("Cia")
            Numero_Plaza = Row("Numero_Plaza")
            CR = Row("CR")
            Tipo_Referencia = Row("Tipo_Referencia")
            Longitud_Referencia = Row("Longitud_Referencia")
            Tipo_Archivo = Row("Tipo_Archivo")
            Clave_ProveedorArchivo = Row("Clave_ProveedorArchivo")

            If Row("DigitoSeguro") = "S" Then DigitoSeguro = True Else DigitoSeguro = False
            If Row("CR") <> "" Then TieneCR = True Else TieneCR = False

            With New Frm_NumeroSugeridoModal
                .valor = Row("Numero") 'Desde la BD ya me da el Ultimo + 1
                .ShowDialog()
                Numero = Format(.valor, "00")
                Numero_Archivo = Format(.valor, "00")
                .Dispose()
            End With

            Nombre_ArchivoD = Path & "\D" & CR & Numero_Plaza & Trim(ClaveCia) & Fecha & "_" & Numero & ".txt"
            Nombre_ArchivoC = Path & "\C" & CR & Numero_Plaza & Trim(ClaveCia) & Fecha & "_" & Numero & ".txt"

            Etapa = 1
            FileOpen(1, Nombre_ArchivoD, OpenMode.Output)
            Etapa = 2
            FileOpen(2, Nombre_ArchivoC, OpenMode.Output)
            Etapa = 3

            Dim qd = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Where i.Checked = True _
                     Select f


            Dim qc = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Join c In Cheques On c.Id_Ficha Equals f.Id_Ficha _
                     Where i.Checked = True _
                     Select c

            'En otros bancos el Orden sigue siendo como estaba antes
            'Orden= D, Fecha, CIA, Numero Archivo, Cantidad, Importe
            Line &= "D,"
            Line &= Format(Row("Fecha"), "yyyyMMdd") & ","
            If Trim(ClaveCia) <> "" Then Line &= Trim(ClaveCia) & ","
            Line &= Numero & ","
            Line &= qd.Count & ","
            Line &= Format(qd.Sum(Function(f As ds_Reportes.Tbl_FichasRow) f.IEfectivo + f.IChequesP + f.IChequesO), "#0.00")

            LineC &= "C,"
            LineC &= Format(Row("Fecha"), "yyyyMMdd") & ","
            If Trim(ClaveCia) <> "" Then LineC &= Trim(ClaveCia) & ","
            LineC &= Numero & ","
            LineC &= qc.Count & ","
            LineC &= Format(qc.Sum(Function(v As ds_Reportes.Tbl_ChequesRow) v.Importe), "#0.00")

            WriteLine(1, Line.ToCharArray)
            WriteLine(2, LineC.ToCharArray)

            'Armar las Filas de las Fichas y Cheques segun sea el caso
            For Each ficha As ds_Reportes.Tbl_FichasRow In qd
                Line = ""

                Fila += 1

                With ficha

                    Line &= Fila & ","
                    Line &= .Cuenta & ","
                    Line &= .Remision & ","
                    Line &= FuncionesGlobales.fn_PonerCeros(.Referencia, Longitud_Referencia) & ","
                    Line &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                    Line &= Format(.IEfectivo, "#0.00") & ","
                    Line &= Format(.IChequesP, "#0.00") & ","
                    Line &= Format(.IChequesO, "#0.00") & ","
                    Line &= Format(.ITotal, "#0.00") & ","
                    Line &= Format(.DEfectivo, "#0.00") & ","
                    Line &= .TipoD & ","

                    Dim Id_Ficha As Integer = .Id_Ficha

                    Dim Query As System.Collections.Generic.IEnumerable(Of ds_Reportes.Tbl_FichasEfectivoRow) = From d In Fichas_Efectivo.ToList Where d.Id_Ficha = Id_Ficha Select d

                    For Each Den As ds_Reportes.Tbl_FichasEfectivoRow In Query
                        Line &= Den.Presentacion & Format(Den.Denominacion, "#0.##") & ","
                        Line &= Den.Cantidad & ","
                        Line &= Format(Den.Importe, "#0.##") & ","
                    Next

                    Line = Microsoft.VisualBasic.Left(Line, Len(Line) - 1)

                    WriteLine(1, Line.ToCharArray)

                    For Each che As ds_Reportes.Tbl_ChequesRow In From c In qc Where c.Id_Ficha = Id_Ficha Select c
                        LineC = ""
                        LineC &= Fila & ","
                        LineC &= .Cuenta & ","
                        LineC &= .Remision & ","
                        LineC &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                        LineC &= che.MICR.Substring(0, 4) & che.MICR.Substring(5, 9) & che.MICR.Substring(15, 11) & che.MICR.Substring(27) & ","
                        LineC &= Format(che.Importe, "#0.00")
                        If DigitoSeguro Then
                            If che.Numero_Valida <> "" Then LineC &= "," & che.Numero_Valida.PadLeft(8, "0")
                        End If

                        WriteLine(2, LineC.ToCharArray)
                    Next

                End With
            Next

            FileClose(1)
            FileClose(2)

            If MsgBox("Se generó correctamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then

                Dim ArchivoD As Byte()
                Dim ArchivoC As Byte()

                'Convert File to bytes Array
                ArchivoD = FuncionesGlobales.ReadFile(Nombre_ArchivoD)
                ArchivoC = FuncionesGlobales.ReadFile(Nombre_ArchivoC)

                Dim De = From d In qd _
                                   Join fe In Fichas_Efectivo.ToList On d.Id_Ficha Equals fe.Id_Ficha _
                                   Group fe By fe.Id_Denominacion, fe.Denominacion Into Group _
                                   Select Id_Denominacion, _
                                   Denominacion, _
                                   Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                                   Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)

                NombreCorto_ArchivoD = System.IO.Path.GetFileName(Nombre_ArchivoD)
                NombreCorto_ArchivoC = System.IO.Path.GetFileName(Nombre_ArchivoC)
                Dim Id_Archivo As Integer = fn_GuardarArchivo_Guardar(Numero_Proceso, Numero, Nombre_ArchivoD, Fecha_Aplicacion, Id_CajaBancaria, Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, De, qd, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, NombreCorto_ArchivoD, NombreCorto_ArchivoC)
                If Id_Archivo = 0 Then
                    MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    frm.crv.ReportSource = fn_GuardarArchivo_GenerarReporte(Id_Archivo, Fecha_Aplicacion.ToShortDateString)
                    frm.ShowDialog()
                    MsgBox("Todos los cambios se aplicaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    lsv_Servicios.Items.Clear()
                    btn_Guardar.Enabled = False
                    btn_GuardarXficha.Enabled = False
                End If
            Else
                MsgBox("No se ha efectuado ningún cambio.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        Catch ex As Exception
            If Etapa = 2 Then
                FileClose(1)
            ElseIf Etapa >= 3 Then
                FileClose(1)
                FileClose(2)
            End If
            MsgBox("Ocurrió el siguiente error al intentar generar los archivos: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub Archivo_Banorte(ByVal Row As DataRow)
        Dim Path As String
        Dim Numero As String
        Dim Nombre_ArchivoD As String
        Dim Nombre_ArchivoC As String
        Dim NombreCorto_ArchivoD As String
        Dim NombreCorto_ArchivoC As String
        Dim Numero_Proceso As Integer = 0
        Dim Numero_Archivo As String
        Dim Fecha As String
        Dim Fecha103 As String
        Dim Fila As Integer = 0
        Dim frm As New frm_Reporte
        Dim Reporte As New rpt_CorteProceso
        Dim Ds As New ds_Reportes
        Dim ClaveCia As String = ""
        Dim Numero_Plaza As String
        Dim CR As String
        Dim DigitoSeguro As Boolean = False
        Dim TieneCR As Boolean = False
        Dim Tipo_Referencia As String = ""
        Dim Longitud_Referencia As Integer = 10
        Dim Tipo_Archivo As String = ""
        Dim Clave_ProveedorArchivo As String = ""
        Dim Line As String = ""
        Dim LineC As String = ""
        Dim Etapa As Integer = 0

        Try
            With New FolderBrowserDialog
                If Not .ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
                Path = .SelectedPath
                .Dispose()
            End With

            Fecha = Format(Row("Fecha"), "yyMMdd")
            Fecha103 = Format(Row("Fecha"), "dd/MM/yyyy")
            Numero_Proceso = Row("NumeroP") 'Desde la BD ya me da el Ultimo + 1
            ClaveCia = Row("Cia")
            Numero_Plaza = Row("Numero_Plaza")
            CR = Row("CR")
            Tipo_Referencia = Row("Tipo_Referencia")
            Longitud_Referencia = Row("Longitud_Referencia")
            Tipo_Archivo = Row("Tipo_Archivo")
            Clave_ProveedorArchivo = Row("Clave_ProveedorArchivo")

            If Row("DigitoSeguro") = "S" Then DigitoSeguro = True Else DigitoSeguro = False

            If Row("CR") <> "" Then TieneCR = True Else TieneCR = False

            With New Frm_NumeroSugeridoModal
                .valor = Row("Numero") 'Desde la BD ya me da el Ultimo + 1
                .ShowDialog()
                Numero = Format(.valor, "00")
                Numero_Archivo = Format(.valor, "00")
                .Dispose()
            End With

            Nombre_ArchivoD = Path & "\D" & CR & Numero_Plaza & Trim(ClaveCia) & Fecha & "_" & Numero & ".txt"
            Nombre_ArchivoC = Path & "\C" & CR & Numero_Plaza & Trim(ClaveCia) & Fecha & "_" & Numero & ".txt"

            Etapa = 1
            FileOpen(1, Nombre_ArchivoD, OpenMode.Output)
            Etapa = 2
            FileOpen(2, Nombre_ArchivoC, OpenMode.Output)
            Etapa = 3

            Dim qd = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Where i.Checked = True _
                     Select f

            Dim qc = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Join c In Cheques On c.Id_Ficha Equals f.Id_Ficha _
                     Where i.Checked = True _
                     Select c

            'En Banorte cambiaron el orden de los campos y agregaron uno nuevo (CR)
            'Ahora el Orden de los campos es similar al orden en el Nombre del Archivo
            'Orden= D, CR, CIA, Fecha, Numero Archivo, Cantidad, Importe
            Line &= "D,"
            Line &= Trim(CR) & ","
            If Trim(ClaveCia) <> "" Then Line &= Trim(ClaveCia) & ","
            Line &= Format(Row("Fecha"), "yyyyMMdd") & ","
            Line &= Numero & ","
            Line &= qd.Count & ","
            Line &= Format(qd.Sum(Function(f As ds_Reportes.Tbl_FichasRow) f.IEfectivo + f.IChequesP + f.IChequesO), "#0.00")



            LineC &= "C,"
            LineC &= Trim(CR) & ","
            If Trim(ClaveCia) <> "" Then LineC &= Trim(ClaveCia) & ","
            LineC &= Format(Row("Fecha"), "yyyyMMdd") & ","
            LineC &= Numero & ","
            LineC &= qc.Count & ","
            LineC &= Format(qc.Sum(Function(v As ds_Reportes.Tbl_ChequesRow) v.Importe), "#0.00")


            WriteLine(1, Line.ToCharArray)
            WriteLine(2, LineC.ToCharArray)

            'Armar las Filas de las Fichas y Cheques segun sea el caso
            For Each ficha As ds_Reportes.Tbl_FichasRow In qd
                Line = ""

                Fila += 1

                With ficha

                    Line &= Fila & ","
                    Line &= .Cuenta & ","
                    Line &= .Remision & ","
                    Line &= FuncionesGlobales.fn_PonerCeros(.Referencia, Longitud_Referencia) & ","
                    Line &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                    Line &= Format(.IEfectivo, "#0.00") & ","
                    Line &= Format(.IChequesP, "#0.00") & ","
                    Line &= Format(.IChequesO, "#0.00") & ","
                    Line &= Format(.ITotal, "#0.00") & ","

                    If .DEfectivo < 0 Then
                        Line &= Format(0, "#0.00") & ","
                    Else
                        Line &= Format(0, "#0.00") & ","
                    End If

                    Line &= .TipoD & ","

                    Dim Id_Ficha As Integer = .Id_Ficha



                    Dim Query As System.Collections.Generic.IEnumerable(Of ds_Reportes.Tbl_FichasEfectivoRow) = From d In Fichas_Efectivo.ToList Where d.Id_Ficha = Id_Ficha Select d

                    For Each Den As ds_Reportes.Tbl_FichasEfectivoRow In Query
                        Line &= Den.Presentacion & Format(Den.Denominacion, "#0.##") & ","
                        Line &= Den.Cantidad & ","
                        Line &= Format(Den.Importe, "#0.##") & ","
                    Next

                    Line = Microsoft.VisualBasic.Left(Line, Len(Line) - 1)

                    WriteLine(1, Line.ToCharArray)

                    For Each che As ds_Reportes.Tbl_ChequesRow In From c In qc Where c.Id_Ficha = Id_Ficha Select c
                        LineC = ""
                        LineC &= Fila & ","
                        LineC &= .Cuenta & ","
                        LineC &= .Remision & ","
                        LineC &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                        LineC &= che.MICR.Substring(0, 4) & che.MICR.Substring(5, 9) & che.MICR.Substring(15, 11) & che.MICR.Substring(27) & ","
                        LineC &= Format(che.Importe, "#0.00")
                        If DigitoSeguro Then
                            If che.Numero_Valida <> "" Then LineC &= "," & che.Numero_Valida.PadLeft(8, "0")

                        End If

                        WriteLine(2, LineC.ToCharArray)
                    Next

                End With
            Next

            FileClose(1)
            FileClose(2)

            If MsgBox("Se generó correctamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then

                Dim ArchivoD As Byte()
                Dim ArchivoC As Byte()
                'Convert File to bytes Array
                ArchivoD = FuncionesGlobales.ReadFile(Nombre_ArchivoD)
                ArchivoC = FuncionesGlobales.ReadFile(Nombre_ArchivoC)



                Dim De = From d In qd _
                                   Join fe In Fichas_Efectivo.ToList On d.Id_Ficha Equals fe.Id_Ficha _
                                   Group fe By fe.Id_Denominacion, fe.Denominacion Into Group _
                                   Select Id_Denominacion, _
                                   Denominacion, _
                                   Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                                   Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)

                NombreCorto_ArchivoD = System.IO.Path.GetFileName(Nombre_ArchivoD)
                NombreCorto_ArchivoC = System.IO.Path.GetFileName(Nombre_ArchivoC)

                Dim Id_Archivo As Integer = fn_GuardarArchivo_Guardar(Numero_Proceso, Numero, Nombre_ArchivoD, Fecha_Aplicacion, Id_CajaBancaria, Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, De, qd, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, NombreCorto_ArchivoD, NombreCorto_ArchivoC)

                If Id_Archivo = 0 Then
                    MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    frm.crv.ReportSource = fn_GuardarArchivo_GenerarReporte(Id_Archivo, Fecha_Aplicacion.ToShortDateString)
                    frm.ShowDialog()
                    MsgBox("Todos los cambios se aplicaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    lsv_Servicios.Items.Clear()
                    btn_Guardar.Enabled = False
                    btn_GuardarXficha.Enabled = False
                End If
            Else
                MsgBox("No se ha efectuado ningún cambio.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        Catch ex As Exception
            If Etapa = 2 Then
                FileClose(1)
            ElseIf Etapa >= 3 Then
                FileClose(1)
                FileClose(2)
            End If
            MsgBox("Ocurrió el siguiente error al intentar generar los archivos: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub Archivo_AFIRME(ByVal Row As DataRow)

        Dim Path As String
        Dim Numero As String
        Dim Nombre_ArchivoD As String
        Dim Nombre_ArchivoC As String
        Dim NombreCorto_ArchivoD As String
        Dim NombreCorto_ArchivoC As String
        Dim Numero_Proceso As Integer = 0
        Dim Numero_Archivo As String
        Dim Fecha As String
        Dim Fecha103 As String
        Dim Fila As Integer = 0
        Dim frm As New frm_Reporte
        Dim Reporte As New rpt_CorteProceso
        Dim Ds As New ds_Reportes
        Dim ClaveCia As String = ""
        Dim Numero_Plaza As String
        Dim CR As String
        Dim DigitoSeguro As Boolean = False
        Dim TieneCR As Boolean = False
        Dim Tipo_Referencia As String = ""
        Dim Longitud_Referencia As Integer = 10
        Dim Tipo_Archivo As String = ""
        Dim Clave_ProveedorArchivo As String = ""
        Dim Line As String = ""
        Dim LineC As String = ""
        Dim Etapa As Integer = 0

        Try
            With New FolderBrowserDialog
                If Not .ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
                Path = .SelectedPath
                .Dispose()
            End With

            Fecha = Format(Row("Fecha"), "yyMMdd")
            Fecha103 = Format(Row("Fecha"), "dd/MM/yyyy")
            Numero_Proceso = Row("NumeroP") 'Desde la BD ya me da el Ultimo + 1
            ClaveCia = Row("Cia")
            Numero_Plaza = Row("Numero_Plaza")
            CR = Row("CR")
            Tipo_Referencia = Row("Tipo_Referencia")
            Longitud_Referencia = Row("Longitud_Referencia")
            Tipo_Archivo = Row("Tipo_Archivo")
            Clave_ProveedorArchivo = Row("Clave_ProveedorArchivo")

            If Row("DigitoSeguro") = "S" Then DigitoSeguro = True Else DigitoSeguro = False
            If Row("CR") <> "" Then TieneCR = True Else TieneCR = False

            With New Frm_NumeroSugeridoModal
                .valor = Row("Numero") 'Desde la BD ya me da el Ultimo + 1
                .ShowDialog()
                Numero = Format(.valor, "00")
                Numero_Archivo = Format(.valor, "00")
                .Dispose()
            End With

            'SE AGREGA EL NOMBRE DEL ARCHIVO
            'TDDSSSPPXX (T=Tipo; DD=Dia; SSS=CR; PP=Clave_Proveedor; XX=Consecutivo)
            Nombre_ArchivoD = ""
            Nombre_ArchivoD &= Path & "\D"
            Nombre_ArchivoD &= Microsoft.VisualBasic.Left(Fecha103, 2)
            Nombre_ArchivoD &= FuncionesGlobales.fn_PonerCeros(CR, 3)
            Nombre_ArchivoD &= FuncionesGlobales.fn_PonerCeros(Clave_ProveedorArchivo, 2)
            Nombre_ArchivoD &= FuncionesGlobales.fn_PonerCeros(Numero_Archivo, 2)
            Nombre_ArchivoD &= ".txt"

            Nombre_ArchivoC = ""
            Nombre_ArchivoC &= Path & "\C"
            Nombre_ArchivoC &= Microsoft.VisualBasic.Left(Fecha103, 2)
            Nombre_ArchivoC &= FuncionesGlobales.fn_PonerCeros(CR, 3)
            Nombre_ArchivoC &= FuncionesGlobales.fn_PonerCeros(Clave_ProveedorArchivo, 2)
            Nombre_ArchivoC &= FuncionesGlobales.fn_PonerCeros(Numero_Archivo, 2)
            Nombre_ArchivoC &= ".txt"

            Etapa = 1
            FileOpen(1, Nombre_ArchivoD, OpenMode.Output)
            Etapa = 2
            FileOpen(2, Nombre_ArchivoC, OpenMode.Output)
            Etapa = 3


            Dim qd = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Where i.Checked = True _
                     Select f


            Dim qc = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Join c In Cheques On c.Id_Ficha Equals f.Id_Ficha _
                     Where i.Checked = True _
                     Select c

            'T,AAAAMMDD,XX,RR,MM,SSS,PP
            'Tipo= C o D; AAAAMMDD=Fecha; XX=Consecutivo; RR=Cantidad Lineas; MM=Importe; SSS=CR; PP=Clave_ProveedorArchivo
            Line &= "D,"
            Line &= Format(Row("Fecha"), "yyyyMMdd") & ","
            Line &= Numero_Archivo & ","
            Line &= qd.Count & ","
            Line &= Format(qd.Sum(Function(f As ds_Reportes.Tbl_FichasRow) f.IEfectivo + f.IChequesP + f.IChequesO), "#0.00") & ","
            Line &= CR & ","
            Line &= Clave_ProveedorArchivo

            LineC &= "C,"
            LineC &= Format(Row("Fecha"), "yyyyMMdd") & ","
            If Trim(ClaveCia) <> "" Then LineC &= Trim(ClaveCia) & ","
            LineC &= Numero_Archivo & ","
            LineC &= qc.Count & ","
            LineC &= Format(qc.Sum(Function(v As ds_Reportes.Tbl_ChequesRow) v.Importe), "#0.00") & ","
            LineC &= CR & ","
            LineC &= Clave_ProveedorArchivo

            WriteLine(1, Line.ToCharArray)
            WriteLine(2, LineC.ToCharArray)

            'Armar las Filas de las Fichas y Cheques segun sea el caso
            For Each ficha As ds_Reportes.Tbl_FichasRow In qd
                Line = ""

                Fila += 1
                With ficha

                    Line &= Fila & ","
                    Line &= .Cuenta & ","
                    Line &= .Remision & ","
                    Line &= FuncionesGlobales.fn_PonerCeros(.Referencia, Longitud_Referencia) & ","
                    Line &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                    Line &= Format(.IEfectivo, "#0.00") & ","
                    Line &= Format(.IChequesP, "#0.00") & ","
                    Line &= Format(.IChequesO, "#0.00") & ","
                    Line &= Format(.ITotal, "#0.00") & ","
                    Line &= Format(.DEfectivo, "#0.00") & ","
                    Line &= .TipoD & ","

                    Dim Id_Ficha As Integer = .Id_Ficha

                    Dim Query As System.Collections.Generic.IEnumerable(Of ds_Reportes.Tbl_FichasEfectivoRow) = From d In Fichas_Efectivo.ToList Where d.Id_Ficha = Id_Ficha Select d

                    For Each Den As ds_Reportes.Tbl_FichasEfectivoRow In Query
                        Line &= Den.Presentacion & Format(Den.Denominacion, "#0.##") & ","
                        Line &= Den.Cantidad & ","
                        Line &= Format(Den.Importe, "#0.##") & ","
                    Next

                    Line = Microsoft.VisualBasic.Left(Line, Len(Line) - 1)

                    WriteLine(1, Line.ToCharArray)

                    For Each che As ds_Reportes.Tbl_ChequesRow In From c In qc Where c.Id_Ficha = Id_Ficha Select c
                        LineC = ""
                        LineC &= Fila & ","
                        LineC &= .Cuenta & ","
                        LineC &= .Remision & ","
                        LineC &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                        LineC &= che.MICR.Substring(0, 4) & che.MICR.Substring(5, 9) & che.MICR.Substring(15, 11) & che.MICR.Substring(27) & ","
                        LineC &= Format(che.Importe, "#0.00")
                        If DigitoSeguro Then
                            If che.Numero_Valida <> "" Then LineC &= "," & che.Numero_Valida.PadLeft(8, "0")
                        End If

                        WriteLine(2, LineC.ToCharArray)
                    Next

                End With
            Next

            FileClose(1)
            FileClose(2)

            SegundosDesconexion = 0
            If MsgBox("Se generó correctamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then

                Dim ArchivoD As Byte()
                Dim ArchivoC As Byte()
                'Convert File to bytes Array
                ArchivoD = FuncionesGlobales.ReadFile(Nombre_ArchivoD)
                ArchivoC = FuncionesGlobales.ReadFile(Nombre_ArchivoC)

                Dim De = From d In qd _
                                   Join fe In Fichas_Efectivo.ToList On d.Id_Ficha Equals fe.Id_Ficha _
                                   Group fe By fe.Id_Denominacion, fe.Denominacion Into Group _
                                   Select Id_Denominacion, _
                                   Denominacion, _
                                   Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                                   Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)

                NombreCorto_ArchivoD = System.IO.Path.GetFileName(Nombre_ArchivoD)
                NombreCorto_ArchivoC = System.IO.Path.GetFileName(Nombre_ArchivoC)
                Dim Id_Archivo As Integer = fn_GuardarArchivo_Guardar(Numero_Proceso, Numero, Nombre_ArchivoD, Fecha_Aplicacion, Id_CajaBancaria, Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, De, qd, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, NombreCorto_ArchivoD, NombreCorto_ArchivoC)
                If Id_Archivo = 0 Then
                    MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    frm.crv.ReportSource = fn_GuardarArchivo_GenerarReporte(Id_Archivo, Fecha_Aplicacion.ToShortDateString)
                    frm.ShowDialog()
                    MsgBox("Todos los cambios se aplicaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    lsv_Servicios.Items.Clear()
                    btn_Guardar.Enabled = False
                    btn_GuardarXficha.Enabled = False
                End If
            Else
                MsgBox("No se ha efectuado ningún cambio.", MsgBoxStyle.Information, frm_MENU.Text)
            End If

        Catch ex As Exception
            If Etapa = 2 Then
                FileClose(1)
            ElseIf Etapa >= 3 Then
                FileClose(1)
                FileClose(2)
            End If
            MsgBox("Ocurrió el siguiente error al intentar generar los archivos: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try

    End Sub

    Enum Clacon As Integer
        DepositoEfectivo = 0
        SobranteDeposito = 142
        FaltanteDeposito = 643
        SobrantesinFicha = 1275
        FaltanteBilleteFalso = 1777
    End Enum

    Private Sub Archivo_SANTANDER(ByVal Row As DataRow)
        Dim Path As String
        Dim Numero As String
        Dim Nombre_ArchivoD As String
        Dim Nombre_ArchivoC As String
        Dim NombreCorto_ArchivoD As String
        Dim NombreCorto_ArchivoC As String
        Dim Numero_Proceso As Integer = 0
        Dim Numero_Archivo As String
        Dim Fecha As String
        Dim Fecha103 As String
        Dim frm As New frm_Reporte
        Dim Reporte As New rpt_CorteProceso
        Dim Ds As New ds_Reportes
        Dim ClaveCia As String = ""
        Dim Numero_Plaza As String
        Dim CR As String
        Dim DigitoSeguro As Boolean = False
        Dim TieneCR As Boolean = False
        Dim Tipo_Referencia As String = ""
        Dim Longitud_Referencia As Integer = 10
        Dim Tipo_Archivo As String = ""
        Dim Clave_ProveedorArchivo As String = ""
        Dim Line As String = ""
        Dim LineC As String = ""
        Dim Etapa As Integer = 0 'Para control de avance

        Try
            With New FolderBrowserDialog
                If Not .ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
                Path = .SelectedPath
                .Dispose()
            End With

            Fecha = Format(Row("Fecha"), "yyMMdd")
            Fecha103 = Format(Row("Fecha"), "dd/MM/yyyy")
            Numero_Proceso = Row("NumeroP") 'Desde la BD ya me da el Ultimo + 1
            ClaveCia = Row("Cia")
            Numero_Plaza = Row("Numero_Plaza")
            CR = Row("CR")
            Tipo_Referencia = Row("Tipo_Referencia")
            Longitud_Referencia = Row("Longitud_Referencia")
            Tipo_Archivo = Row("Tipo_Archivo")
            Clave_ProveedorArchivo = Row("Clave_ProveedorArchivo")

            If Row("DigitoSeguro") = "S" Then DigitoSeguro = True Else DigitoSeguro = False
            If Row("CR") <> "" Then TieneCR = True Else TieneCR = False

            With New Frm_NumeroSugeridoModal
                .valor = Row("Numero") 'Desde la BD ya me da el Ultimo + 1
                .ShowDialog()
                Numero = Format(.valor, "000")
                Numero_Archivo = Format(.valor, "000")
                .Dispose()
            End With

            Nombre_ArchivoD = ""
            Nombre_ArchivoD &= Path & "\dm"
            Nombre_ArchivoD &= FuncionesGlobales.fn_PonerCeros(CR, 4)
            Nombre_ArchivoD &= FuncionesGlobales.fn_PonerCeros(Clave_ProveedorArchivo, 5)
            Nombre_ArchivoD &= Format(Row("Fecha"), "yyyyMMdd")
            Nombre_ArchivoD &= FuncionesGlobales.fn_PonerCeros(Numero_Archivo, 3)
            Nombre_ArchivoD &= ".txt"

            'Le Agrege los cheques como lo hace banorte
            Nombre_ArchivoC = ""
            Nombre_ArchivoC &= Path & "\cm"
            Nombre_ArchivoC &= FuncionesGlobales.fn_PonerCeros(CR, 4)
            Nombre_ArchivoC &= FuncionesGlobales.fn_PonerCeros(Clave_ProveedorArchivo, 5)
            Nombre_ArchivoC &= Format(Row("Fecha"), "yyyyMMdd")
            Nombre_ArchivoC &= FuncionesGlobales.fn_PonerCeros(Numero_Archivo, 3)
            Nombre_ArchivoC &= ".txt"

            Etapa = 1
            FileOpen(1, Nombre_ArchivoD, OpenMode.Output)
            Etapa = 2
            FileOpen(2, Nombre_ArchivoC, OpenMode.Output)
            Etapa = 3

            '*************ESTO YA ESTABA*********************
            'Dim qd = From i As ListViewItem In lsv_Servicios.CheckedItems _
            '        Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
            '        Where i.Checked = True And f.IEfectivo > 0 _
            '        Select f
            Dim qd = From i As ListViewItem In lsv_Servicios.CheckedItems _
                    Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                    Where i.Checked = True _
                    Select f

            'Consulta para Generar Cheques
            Dim qc = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Join c In Cheques On c.Id_Ficha Equals f.Id_Ficha _
                     Where i.Checked = True _
                     Select c

            LineC &= "C,"
            LineC &= Trim(CR) & ","
            If Trim(ClaveCia) <> "" Then LineC &= Trim(ClaveCia) & ","
            LineC &= Format(Row("Fecha"), "yyyyMMdd") & ","
            LineC &= Numero & ","
            LineC &= qc.Count & ","
            LineC &= Format(qc.Sum(Function(v As ds_Reportes.Tbl_ChequesRow) v.Importe), "#0.00")

            WriteLine(2, LineC.ToCharArray)

            Dim TipoClaconAnterior As Integer = 0
            Dim ExisteDiferencia As Boolean = False
            Dim ExisteDiferenciaFalsos As Boolean = False
            Dim Fila As Integer = 0
            Dim Numero_Transacciones As String = ""
            Dim Numero_Consecutivo As String
            Dim Cabecera As String = ""
            Dim ImporteTotalArchivo As Decimal = 0
            Dim Cantidad_Fichas As Integer = qd.Count

            For Each ficha As ds_Reportes.Tbl_FichasRow In qd
                Dim ImporteFalso As Decimal = 0
                'Para que no agregue las lineas que taen Efectivo=0 y Cheques>0
                'Santander no acepta importe de cheques en sus archivos.
                'Pero si traemos todas las fichas para que el importe cheques salga en el corte (Crystal)
                'Por el asunto de los Jimal que si manejan cheques (pero ese efectivo y cheques se manda a PANA)
                If ficha.IEfectivo <= 0 Then Continue For

                Dim Query_Falsos As IEnumerable(Of ds_Reportes.Tbl_FichasFalsosRow) = From d In Fichas_EfectivoFalso.ToList Where d.Id_Ficha = ficha.Id_Ficha Select d
                For Each Falso As ds_Reportes.Tbl_FichasFalsosRow In Query_Falsos
                    ImporteFalso += Falso.ImporteFalso
                Next
Diferencia:
                Line = ""
                Fila += 1
                Numero_Consecutivo = FuncionesGlobales.fn_PonerCeros(Fila.ToString, 5)
                With ficha

                    Dim Id_Ficha As Integer = .Id_Ficha
                    Line &= Numero_Consecutivo & ","

                    If ExisteDiferencia Then
                        If ExisteDiferenciaFalsos Then
                            Line &= FuncionesGlobales.fn_PonerCeros(Clacon.FaltanteBilleteFalso, 6) & ","
                            TipoClaconAnterior = Clacon.FaltanteBilleteFalso
                        ElseIf .TipoD = "F" Then
                            Line &= FuncionesGlobales.fn_PonerCeros(Clacon.FaltanteDeposito, 6) & ","
                            TipoClaconAnterior = Clacon.FaltanteDeposito
                        ElseIf .TipoD = "S" Then
                            Line &= FuncionesGlobales.fn_PonerCeros(Clacon.SobranteDeposito, 6) & ","
                            TipoClaconAnterior = Clacon.SobranteDeposito
                        End If
                    Else
                        Line &= FuncionesGlobales.fn_PonerCeros(Clacon.DepositoEfectivo, 6) & ","
                        TipoClaconAnterior = Clacon.DepositoEfectivo
                    End If
                    If .Convenio.Trim <> "" Then
                        Line &= FuncionesGlobales.fn_PonerCeros("", 12) & ","
                    Else
                        Line &= FuncionesGlobales.fn_PonerCeros(.Cuenta.Trim, 12) & ","
                    End If
                    Line &= FuncionesGlobales.fn_PonerCeros(.Convenio.Trim, 11) & ","
                    Line &= FuncionesGlobales.fn_PonerCeros(Microsoft.VisualBasic.Right(.Remision, 10), 10) & ","
                    Line &= FuncionesGlobales.fn_PonerCeros(.FolioFicha.Trim, 10) & ","
                    Line &= FuncionesGlobales.Poner_Espacios_Blanco(.Referencia.Trim, 40, 1) & ","
                    Line &= FuncionesGlobales.fn_PonerCeros(CR.Trim, 4) & ","
                    Line &= Microsoft.VisualBasic.Right(.Divisa.Trim, 3) & ","

                    If ExisteDiferencia Then
                        If ExisteDiferenciaFalsos Then
                            Line &= Format(ImporteFalso, "#0000000000000000.0000") & ","
                            Line &= Format(ImporteFalso, "#0000000000000000.0000") & ","
                            ImporteTotalArchivo += ImporteFalso
                        ElseIf .TipoD = "S" OrElse .TipoD = "F" Then
                            Line &= "0000000000000000.0000" & ","
                            Line &= Format(Math.Abs(.DiceContener - .IEfectivo), "#0000000000000000.0000") & ","
                            ImporteTotalArchivo += Math.Abs(.DiceContener - .IEfectivo)
                        End If
                    Else
                        Line &= Format(.IEfectivo, "#0000000000000000.0000") & ","
                        Line &= Format(.DiceContener, "#0000000000000000.0000") & ","
                        ImporteTotalArchivo += .DiceContener
                    End If

                    Line &= FuncionesGlobales.fn_PonerCeros("", 21) & ","
                    Line &= "0,"

                    If ExisteDiferencia Then
                        If ExisteDiferenciaFalsos Then
                            For Each Falso As ds_Reportes.Tbl_FichasFalsosRow In Query_Falsos
                                Line &= Falso.DenominacionBanco.Trim & ","
                                Line &= FuncionesGlobales.fn_PonerCeros(Falso.CantidadFalsos, 6) & ","
                                Line &= Format(Falso.ImporteFalso, "#0000000000000000.0000") & ","
                            Next
                        End If
                    Else
                        Dim Query As IEnumerable(Of ds_Reportes.Tbl_FichasEfectivoRow) = From d In Fichas_Efectivo.ToList Where d.Id_Ficha = Id_Ficha Select d
                        For Each Den As ds_Reportes.Tbl_FichasEfectivoRow In Query
                            Line &= Den.DenominacionBanco.Trim & ","
                            Line &= FuncionesGlobales.fn_PonerCeros(Den.Cantidad, 6) & ","
                            Line &= Format(Den.Importe, "#0000000000000000.0000") & ","
                        Next
                    End If

                    Line = Microsoft.VisualBasic.Left(Line, Len(Line) - 1)
                    WriteLine(1, Line.ToCharArray)

                    '*******************LE AGREGUE PARA QUE GENERE POR EL MOMENTO CHEQUES COMO LO GENERA BANORTE
                    For Each che As ds_Reportes.Tbl_ChequesRow In From c In qc Where c.Id_Ficha = Id_Ficha Select c
                        LineC = ""
                        LineC &= Fila & ","
                        LineC &= .Cuenta & ","
                        LineC &= .Remision & ","
                        LineC &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                        LineC &= che.MICR.Substring(0, 4) & che.MICR.Substring(5, 9) & che.MICR.Substring(15, 11) & che.MICR.Substring(27) & ","
                        LineC &= Format(che.Importe, "#0.00")
                        If DigitoSeguro Then
                            If che.Numero_Valida <> "" Then LineC &= "," & che.Numero_Valida.PadLeft(8, "0")
                        End If

                        WriteLine(2, LineC.ToCharArray)
                    Next
                    '********************

                    If ExisteDiferencia Then
                        ExisteDiferencia = False
                        ExisteDiferenciaFalsos = False
                        If Math.Abs(.DEfectivo) - ImporteFalso <> 0 And TipoClaconAnterior = Clacon.FaltanteBilleteFalso Then
                            ExisteDiferencia = True
                            GoTo Diferencia
                        End If
                    Else
                        'SI EXISTE DIFERENCIA PARA SANTANDER SE TIENE QUE CREAR OTRA LINEA ABAJO DE LA FICHA DONDE TIENE LA DIFERENCIA
                        'POR ESO REGRESO AL INICIO DEL WITH SIN LLEGAR AL NEXT DEL FOR
                        If .DiceContener < .IEfectivo OrElse .DiceContener > .IEfectivo Then
                            If .ContieneFalsos = "S" Then ExisteDiferenciaFalsos = True
                            ExisteDiferencia = True
                            GoTo Diferencia
                        End If

                    End If

                End With
                Numero_Transacciones = Numero_Consecutivo
            Next

            '*******************AGREGO LA CABECERA DE LOS IMPORTES****************
            Cabecera &= "D,"
            Cabecera &= Format(Row("Fecha"), "yyyyMMdd") & ","
            Cabecera &= FuncionesGlobales.fn_PonerCeros(Clave_ProveedorArchivo, 5) & ","
            Cabecera &= FuncionesGlobales.fn_PonerCeros(Numero_Archivo, 3) & ","
            Cabecera &= FuncionesGlobales.fn_PonerCeros(Numero_Transacciones, 16) & ","

            If Id_Moneda = MonedaId Then
                Cabecera &= Format(ImporteTotalArchivo, "#0000000000000000.0000") & ","
                Cabecera &= "0000000000000000.0000"
            Else
                Cabecera &= "0000000000000000.0000,"
                Cabecera &= Format(ImporteTotalArchivo, "#0000000000000000.0000")
            End If
            '**********************************************************************

            FileClose(1)
            FileClose(2)
            'Hasta aqui el archivo se ha creado pero sin la cabecera
            'Se lee el contenido del archivo, se inserta la cabecera y luego se inserta el contenido
            'para que quede el archivo listo para enviar

            Dim Contenido As String = ""
            Contenido = My.Computer.FileSystem.ReadAllText(Nombre_ArchivoD) 'LEEO TODO EL ARCHIVO Y LO ALMACENO EN LA VARIABLE
            System.IO.File.Delete(Nombre_ArchivoD)

            Dim Escribir As New System.IO.StreamWriter(Nombre_ArchivoD, False) 'HAGO UN STREAMWRITER DE ESE ARCHIVO 
            Escribir.WriteLine(Cabecera, 0) 'AGREGO LA LINEA DE LA  CABECERA 
            Escribir.Write(Contenido.Trim) 'AGREGO TODO EL CUERPO DEL ARCHIVO
            Escribir.Close() 'CIERRO EL ARCHIVO

            '**************DE AQUI PA ARRIBA YA ESTABA

            SegundosDesconexion = 0
            If MsgBox("Se generó correctamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then

                Dim ArchivoD As Byte()
                Dim ArchivoC As Byte()
                ArchivoD = FuncionesGlobales.ReadFile(Nombre_ArchivoD)
                ArchivoC = FuncionesGlobales.ReadFile(Nombre_ArchivoC)

                Dim De = From d In qd _
                        Join fe In Fichas_Efectivo.ToList On d.Id_Ficha Equals fe.Id_Ficha _
                       Group fe By fe.Id_Denominacion, fe.Denominacion Into Group _
                       Select Id_Denominacion, _
                       Denominacion, _
                       Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                       Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)

                NombreCorto_ArchivoD = System.IO.Path.GetFileName(Nombre_ArchivoD)
                NombreCorto_ArchivoC = System.IO.Path.GetFileName(Nombre_ArchivoC)

                Dim Id_Archivo As Integer = fn_GuardarArchivo_Guardar(Numero_Proceso, Numero, Nombre_ArchivoD, Fecha_Aplicacion, Id_CajaBancaria, Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, De, qd, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, NombreCorto_ArchivoD, NombreCorto_ArchivoC)
                If Id_Archivo = 0 Then
                    MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    frm.crv.ReportSource = fn_GuardarArchivo_GenerarReporte(Id_Archivo, Fecha_Aplicacion.ToShortDateString)
                    frm.ShowDialog()
                    MsgBox("Todos los cambios se aplicaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    lsv_Servicios.Items.Clear()
                    btn_Guardar.Enabled = False
                    btn_GuardarXficha.Enabled = False
                End If
                ArchivoD = Nothing
                ArchivoC = Nothing
            Else
                MsgBox("No se ha efectuado ningún cambio.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        Catch ex As Exception
            If Etapa = 2 Then
                FileClose(1)
            ElseIf Etapa >= 3 Then
                FileClose(1)
                FileClose(2)
            End If
            MsgBox("Ocurrió el siguiente error al intentar generar los archivos: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try

    End Sub

    Private Sub Archivo_BAJIO(ByVal Row As DataRow)
        Dim Path As String
        Dim Nombre_ArchivoD As String
        'Dim Nombre_ArchivoC As String
        Dim NombreCorto_ArchivoD As String
        Dim NombreCorto_ArchivoC As String
        Dim Numero_Proceso As Integer = 0
        Dim Numero_Archivo As String
        Dim Fecha As String
        Dim Fecha103 As String
        Dim Fila As Integer = 0
        Dim frm As New frm_Reporte
        Dim Reporte As New rpt_CorteProceso
        Dim Ds As New ds_Reportes
        Dim ClaveCia As String = ""
        Dim Numero_Plaza As String
        Dim CR As String
        Dim DigitoSeguro As Boolean = False
        Dim TieneCR As Boolean = False
        Dim Tipo_Referencia As String = ""
        Dim Longitud_Referencia As Integer = 10
        Dim Tipo_Archivo As String = ""
        Dim Clave_ProveedorArchivo As String = ""
        Dim Cabecera As String = ""
        Dim Line As String = ""
        Dim LineC As String = ""
        Dim Etapa As Integer = 0
        Dim ImportePesos As Decimal = 0.0
        Dim ImportePesosSTR As String = ""
        Dim ImporteCheques As Decimal = 0.0
        Dim ImporteChequesSTR As String = ""
        Dim DiceContenerSTR As String = ""
        Dim ContieneSTR As String = ""
        Dim ExisteDiferencia As Boolean = False
        Dim ImporteDiferencia As Decimal = 0.0
        Dim ImporteDiferenciaSTR As String = ""
        Dim Id_ServicioActual As Integer = 0

        Try
            With New FolderBrowserDialog
                If Not .ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
                Path = .SelectedPath
                .Dispose()
            End With
            'NOMBRE DEL ARCHIVO
            Fecha = Format(Row("Fecha"), "yyyyMMdd")
            Fecha103 = Format(Row("Fecha"), "dd/MM/yyyy")
            Numero_Proceso = Row("NumeroP") 'Desde la BD ya me da el Ultimo + 1
            ClaveCia = Row("Cia")
            Numero_Plaza = Row("Numero_Plaza")
            CR = Row("CR")
            Tipo_Referencia = Row("Tipo_Referencia")
            Longitud_Referencia = Row("Longitud_Referencia")
            Tipo_Archivo = Row("Tipo_Archivo")
            Clave_ProveedorArchivo = Row("Clave_ProveedorArchivo")

            If Row("DigitoSeguro") = "S" Then DigitoSeguro = True Else DigitoSeguro = False
            If Row("CR") <> "" Then TieneCR = True Else TieneCR = False

            With New Frm_NumeroSugeridoModal
                .valor = Row("Numero") 'Desde la BD ya me da el Ultimo + 1
                .ShowDialog()
                Numero_Archivo = Format(.valor, "000")
                .Dispose()
            End With
            'Consultar las denominaciones ya que este layout requiere todas las denominaciones aunque no vengan en la ficha
            Dt_DenominacionesB = Cn_Proceso.fn_ConsultarDenominaciones(Id_Moneda, "B")
            Dt_DenominacionesM = Cn_Proceso.fn_ConsultarDenominaciones(Id_Moneda, "M")

            'Ejemplo: "DEP1234520151201002.TXT"
            Nombre_ArchivoD = Path & "\DEP" & Trim(Clave_ProveedorArchivo) & Fecha & Numero_Archivo & ".txt"

            Etapa = 1
            FileOpen(1, Nombre_ArchivoD, OpenMode.Output)
            Etapa = 3

            Dim ListaFichas = From i As ListViewItem In lsv_Servicios.CheckedItems _
                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                     Where i.Checked = True _
                     Select f Order By f.Id_Servicio, f.Id_Ficha

                'ENCABEZADO
                'Orden= DEP, NumeroProv, aaaammdd, NumeroArchivo, CantidadDepositosPesos, ImportePesos, CantidadDepositosDolares, ImporteDolares
                'La cabecera se generará hasta el final porque no se sabe cuantas filas serán (ya que puede haber diferencias)
            Cabecera &= "DEP,"
            Cabecera &= Trim(Clave_ProveedorArchivo) & ","
            Cabecera &= Format(Row("Fecha"), "yyyyMMdd") & ","
            Cabecera &= Numero_Archivo & ","
            Cabecera &= FuncionesGlobales.fn_PonerCeros(ListaFichas.Count.ToString, 4) & ","
            ImportePesos = ListaFichas.Sum(Function(f As ds_Reportes.Tbl_FichasRow) f.IEfectivo)
            ImportePesosSTR = Format(ImportePesos, "#0.00")
            ImportePesosSTR = Replace(ImportePesosSTR, ".", "")
            Cabecera &= FuncionesGlobales.fn_PonerCeros(ImportePesosSTR, 11) & ","
            Cabecera &= "0000,00000000000"
                'WriteLine(1, Line.ToCharArray)

                'EN BANJIO ES UNA FILA POR CADA FICHA PERO SOLO LA PRIMERA LLEVA EL DESGLOSE (LA SUMA DE TODAS)
                'LAS DEMAS NO LLEVAN DESGLOSE

                'Armar las Filas de las Fichas y Cheques segun sea el caso
            Fila = 0
            For Each ficha As ds_Reportes.Tbl_FichasRow In ListaFichas
                Line = ""

                Fila += 1

                With ficha

                    If .DEfectivo <> 0 Then ExisteDiferencia = True Else ExisteDiferencia = False

                    Line &= FuncionesGlobales.fn_PonerCeros(Fila.ToString, 4) & ","
                    Line &= "D,"
                        'Cuenta
                    Line &= FuncionesGlobales.fn_PonerCeros(.Cuenta, 12) & ","
                        'Remision
                    Line &= FuncionesGlobales.fn_PonerCeros(.Remision, 11) & ","
                        'Referencia
                    Line &= FuncionesGlobales.fn_PonerEspaciosDer(.Referencia, Longitud_Referencia) & ","
                        'Numero de Plaza
                    Line &= Numero_Plaza & "," 'Sucursal donde fué realizado el proceso de verificacion
                        'Divisa
                    Line &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                        'Dice Contener
                    DiceContenerSTR = Format(.DiceContener, "#0.00")
                    DiceContenerSTR = Replace(DiceContenerSTR, ".", "")
                    Line &= FuncionesGlobales.fn_PonerCeros(DiceContenerSTR, 11) & ","


                    If Id_ServicioActual = ficha.Id_Servicio Then
                            'Contiene
                        Line &= FuncionesGlobales.fn_PonerCeros("0", 11) & ","
                        Line &= ","
                        Line &= ","
                        Line &= ","
                        Line &= ","
                        Line &= ","
                    ElseIf Id_ServicioActual <> ficha.Id_Servicio Then
                        Id_ServicioActual = .Id_Servicio
                        'Sumar el importe de todas las fichas de este Id_Servicio
                        'Para que solo aparezca en la primer ficha
                        Dim ImporteXservicio As Decimal = 0.0
                        For Each ficha2 As ds_Reportes.Tbl_FichasRow In ListaFichas
                            If ficha2.Id_Servicio = Id_ServicioActual Then
                                ImporteXservicio += ficha2.IEfectivo
                            End If
                        Next

                        'Contiene
                        ContieneSTR = Format(ImporteXservicio, "#0.00")
                        ContieneSTR = Replace(ContieneSTR, ".", "")
                        Line &= FuncionesGlobales.fn_PonerCeros(ContieneSTR, 11) & ","
                        Line &= ","
                        Line &= ","
                        Line &= ","
                        Line &= ","
                        Line &= ","

                        Dim Id_Ficha As Integer = .Id_Ficha
                            'Antes se desplegaba el desglose por cada ficha
                            'Dim Query As System.Collections.Generic.IEnumerable(Of ds_Reportes.Tbl_FichasEfectivoRow) = From d In Fichas_Efectivo.ToList Where d.Id_Ficha = Id_Ficha Select d
                            'Ahora debe ser el desglose de todas las fichas sumado y desplegado solo en la primera ficha
                        Dim Desglose = From d In ListaFichas _
                                    Join fe In Fichas_Efectivo.ToList On d.Id_Ficha Equals fe.Id_Ficha _
                                    Where (d.Id_Servicio = CDec(Id_ServicioActual)) _
                                    Group fe By fe.Presentacion, fe.Id_Denominacion, fe.Denominacion Into Group _
                                    Select Presentacion, Id_Denominacion, Denominacion, _
                                   Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                                   Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)

                            'Where (d.Id_Servicio = CDec(Id_ServicioActual)) _


                            'Dim De = From d In ListaFichas _
                            '           Join fe In Fichas_Efectivo.ToList On d.Id_Ficha Equals fe.Id_Ficha _
                            '           Group fe By fe.Id_Denominacion, fe.Denominacion Into Group _
                            '           Select Id_Denominacion, _
                            '           Denominacion, _
                            '           Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                            '           Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)


                        Dim Encontrado As Boolean = False
                            'Billetes
                        For Each Dr_Fila As DataRow In Dt_DenominacionesB.Rows
                            Encontrado = False
                                'As ds_Reportes.Tbl_FichasEfectivoRow
                            For Each Den In Desglose
                                If CDec(Dr_Fila("Denominacion")) = CDec(Den.Denominacion) And Den.Presentacion = "B" Then
                                    Line &= Den.Cantidad & ","
                                    Encontrado = True
                                    Exit For
                                    End If
                            Next
                            If Not Encontrado Then Line &= "0,"
                        Next Dr_Fila
                            'Monedas
                        For Each Dr_FilaM As DataRow In Dt_DenominacionesM.Rows
                            Encontrado = False
                                'As ds_Reportes.Tbl_FichasEfectivoRow
                            For Each Den In Desglose
                                If CDec(Dr_FilaM("Denominacion")) = CDec(Den.Denominacion) And Den.Presentacion = "M" Then
                                    Line &= Den.Cantidad & ","
                                    Encontrado = True
                                    Exit For
                                    End If
                            Next
                            If Not Encontrado Then Line &= "0,"
                        Next Dr_FilaM

                        Line = Microsoft.VisualBasic.Left(Line, Len(Line) - 1)
                        End If

                    WriteLine(1, Line.ToCharArray)

                    If ExisteDiferencia Then
                        Fila += 1
                        Line = FuncionesGlobales.fn_PonerCeros(Fila.ToString, 4) & ","
                        If .DEfectivo > 0 Then
                            Line &= "S,"
                            ImporteDiferencia = .DEfectivo
                        Else
                            Line &= "F,"
                            ImporteDiferencia = (.DEfectivo * -1)
                            End If
                        Line &= FuncionesGlobales.fn_PonerCeros(.Cuenta, 12) & ","
                        Line &= FuncionesGlobales.fn_PonerCeros(.Remision, 11) & ","
                        Line &= FuncionesGlobales.fn_PonerEspaciosDer(.Referencia, Longitud_Referencia) & ","
                        Line &= Numero_Plaza & "," 'Sucursal donde fué realizado el proceso de verificacion
                        Line &= Microsoft.VisualBasic.Right(.Divisa, 2) & ","
                        ImporteDiferenciaSTR = Format(ImporteDiferencia, "#0.00")
                        ImporteDiferenciaSTR = Replace(ImporteDiferenciaSTR, ".", "")
                        Line &= FuncionesGlobales.fn_PonerCeros(ImporteDiferenciaSTR, 11) & ","
                        Line &= "00000000000,"
                        Line &= ","
                        Line &= ","
                        Line &= ","
                        Line &= ","
                        Line &= ","
                        Line &= "," 'le pongo una coma extra para que mas adelante se la quite como a todas las lineas

                        Line = Microsoft.VisualBasic.Left(Line, Len(Line) - 1)
                        WriteLine(1, Line.ToCharArray)

                        ExisteDiferencia = False
                        ImporteDiferencia = 0
                        End If
                    End With
            Next

            FileClose(1)

                'Hasta aqui el archivo se ha creado pero sin la cabecera
                'Se lee el contenido del archivo, se inserta la cabecera y luego se inserta el contenido
                'para que quede el archivo listo para enviar

            Dim Contenido As String = ""
            Contenido = My.Computer.FileSystem.ReadAllText(Nombre_ArchivoD) 'LEEO TODO EL ARCHIVO Y LO ALMACENO EN LA VARIABLE
            System.IO.File.Delete(Nombre_ArchivoD)

            Dim Escribir As New System.IO.StreamWriter(Nombre_ArchivoD, False) 'HAGO UN STREAMWRITER DE ESE ARCHIVO 
            Cabecera = Microsoft.VisualBasic.Left(Cabecera, 23) & FuncionesGlobales.fn_PonerCeros(Fila, 4) & Microsoft.VisualBasic.Right(Cabecera, 29)
            Escribir.WriteLine(Cabecera, 0) 'AGREGO LA LINEA DE LA  CABECERA 
            Escribir.Write(Contenido.Trim) 'AGREGO TODO EL CUERPO DEL ARCHIVO
            Escribir.Close() 'CIERRO EL ARCHIVO

            If MsgBox("Se generó correctamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then

                Dim ArchivoD As Byte()
                Dim ArchivoC As Byte()

                    'Convert File to bytes Array
                ArchivoD = FuncionesGlobales.ReadFile(Nombre_ArchivoD)

                Dim De = From d In ListaFichas _
                   Join fe In Fichas_Efectivo.ToList On d.Id_Ficha Equals fe.Id_Ficha _
                   Group fe By fe.Id_Denominacion, fe.Denominacion Into Group _
                   Select Id_Denominacion, _
                   Denominacion, _
                   Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                   Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)

                NombreCorto_ArchivoD = System.IO.Path.GetFileName(Nombre_ArchivoD)
                NombreCorto_ArchivoC = ""
                Dim Id_Archivo As Integer = fn_GuardarArchivo_Guardar(Numero_Proceso, CInt(Numero_Archivo), Nombre_ArchivoD, Fecha_Aplicacion, Id_CajaBancaria, Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, De, ListaFichas, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, NombreCorto_ArchivoD, NombreCorto_ArchivoC)
                If Id_Archivo = 0 Then
                    MsgBox("Ha ocurrido un error al guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    frm.crv.ReportSource = fn_GuardarArchivo_GenerarReporte(Id_Archivo, Fecha_Aplicacion.ToShortDateString)
                    frm.ShowDialog()
                    MsgBox("Todos los cambios se aplicaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    lsv_Servicios.Items.Clear()
                    btn_Guardar.Enabled = False
                    btn_GuardarXficha.Enabled = False
                    End If
            Else
                MsgBox("No se ha efectuado ningún cambio.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
        Catch ex As Exception
            If Etapa = 2 Then
                FileClose(1)
            ElseIf Etapa >= 3 Then
                FileClose(1)
            End If
            MsgBox("Ocurrió el siguiente error al intentar generar los archivos: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Public Function contarChequesPropios(ByVal ch As ds_Reportes.Tbl_ChequesRow) As Decimal
        If ch.Propio = "S" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function contarChequesOtros(ByVal ch As ds_Reportes.Tbl_ChequesRow) As Decimal
        If ch.Propio = "N" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub lsv_Servicios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        For Each Elemento As ListViewItem In lsv_Servicios.Items
            If Elemento.SubItems(4).Text = "M" Then
                Elemento.ForeColor = Color.Blue
            End If
        Next
        lsv_Servicios.Refresh()
    End Sub

    Private Sub btn_GuardarXficha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarXficha.Click
        SegundosDesconexion = 0

        '***************************************************************************
        'Esta opción es para el Cliente Pollo Loco. Banregio Solicita que se genere
        'un archivo por cada Ficha de Depósito
        '***************************************************************************

        If lsv_Servicios.Items.Count = 0 Then
            MsgBox("No existen Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Servicios.CheckedItems.Count = 0 Then
            MsgBox("No ha seleccionado ningún Depósito.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Path As String
        Dim Numero As String
        Dim NombreArchivo As String
        Dim NombreCorto_ArchivoD As String
        Dim NombreCorto_ArchivoC As String
        Dim Numero_Proceso As Integer = 0
        Dim NumeroArchivo As Integer = 1
        Dim Fecha As String
        Dim Fila As Integer = 0
        Dim frm As New frm_Reporte
        Dim Reporte As New rpt_CorteProceso
        Dim Ds As New ds_Reportes
        Dim ClaveCia As String = ""
        Dim Numero_Plaza As String
        Dim CR As String
        Dim line As String = ""
        Dim lineC As String = ""
        Dim Id_Ficha As Integer = 0
        Dim DigitoSeguro As Boolean = False
        Dim TieneCR As Boolean = False
        Dim Tipo_Referencia As String = ""
        Dim Longitud_Referencia As Integer = 10
        Dim Id_Archivo As Integer = 0

        Dim Query As System.Collections.Generic.IEnumerable(Of ds_Reportes.Tbl_FichasEfectivoRow)

        Dim qd = From i As ListViewItem In lsv_Servicios.CheckedItems _
                                     Join f In Fichas On CDec(i.Tag) Equals (f.Id_Servicio) _
                                     Where i.Checked = True _
                                     Select f

        If MsgBox("Se generará un Archivo de D y un Archivo C por cada Ficha de Depósito. En total " & (qd.Count * 2).ToString & " Archivos. Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) <> MsgBoxResult.Yes Then
            qd = Nothing
            MsgBox("No se generó ningún Archivo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Exit Sub
        End If

        With New FolderBrowserDialog
            If Not .ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
            Path = .SelectedPath
            .Dispose()
        End With

        Dim row As DataRow = fn_GuardarArchivo_ObtenNombre(Id_CajaBancaria, Fecha_Aplicacion, Id_Cia)
        Fecha = Format(row("Fecha"), "yyMMdd")
        Numero_Proceso = row("NumeroP") 'Desde la BD me da el Ultimo + 1
        ClaveCia = row("Cia")
        Numero_Plaza = row("Numero_Plaza")
        CR = row("CR")
        Tipo_Referencia = row("Tipo_Referencia")
        Longitud_Referencia = row("Longitud_Referencia")
        If row("DigitoSeguro") = "S" Then DigitoSeguro = True Else DigitoSeguro = False
        If row("CR") <> "" Then TieneCR = True Else TieneCR = False

        '*****************************************
        'Se omite el numero de compañia de traslado en el nombre de archivo
        'solo para los archivos de banregio
        'If Numero_Plaza <> "" Then ClaveCia = ""
        '*****************************************

        With New Frm_NumeroSugeridoModal
            .valor = row("Numero")
            .ShowDialog()
            NumeroArchivo = .valor
            Numero = Format(NumeroArchivo, "00") 'Desde la BD me da el Ultimo + 1

            .Dispose()
        End With

        For Each ficha As ds_Reportes.Tbl_FichasRow In qd

            '*** Esta seccion estaba inmediatamente fuera del For
            Id_Ficha = ficha.Id_Ficha
            line = ""
            lineC = ""
            Id_Archivo = 0

            'Obtener los Cheques
            Dim qc = From f In Fichas _
                 Join c In Cheques On c.Id_Ficha Equals f.Id_Ficha _
                 Where f.Id_Ficha = Id_Ficha _
                 Select c

            'Armar el Nombre del Archivo
            NombreArchivo = Path & "\D" & CR & Numero_Plaza & Trim(ClaveCia) & Fecha & "_" & Numero & ".txt"
            Dim NombreArchivoC As String = Path & "\C" & CR & Numero_Plaza & Trim(ClaveCia) & Fecha & "_" & Numero & ".txt"
            FileOpen(1, NombreArchivo, OpenMode.Output)
            FileOpen(2, NombreArchivoC, OpenMode.Output)

            'Armar la linea del Encabezado
            If TieneCR Then '**Solo Banorte por lo pronto pidió este cambio
                'En Banorte cambiaron el orden de los campos y agregaron uno nuevo (CR)
                'Ahora el Orden de los campos es similar al orden en el Nombre del Archivo
                'Orden= D, CR, CIA, Fecha, Numero Archivo, Cantidad, Importe
                line &= "D,"
                line &= Trim(CR) & ","
                If Trim(ClaveCia) <> "" Then line &= Trim(ClaveCia) & ","
                line &= Format(row("Fecha"), "yyyyMMdd") & ","
                line &= Numero & ","
                line &= "1,"
                line &= Format(qd.Select(Function(f As ds_Reportes.Tbl_FichasRow) f.IEfectivo + f.IChequesP + f.IChequesO), "#0.00")

                lineC &= "C,"
                lineC &= Trim(CR) & ","
                If Trim(ClaveCia) <> "" Then lineC &= Trim(ClaveCia) & ","
                lineC &= Format(row("Fecha"), "yyyyMMdd") & ","
                lineC &= Numero & ","
                lineC &= qc.Count & ","
                lineC &= Format(qc.Sum(Function(v As ds_Reportes.Tbl_ChequesRow) v.Importe), "#0.00")
            Else
                'En otros bancos el Orden sigue siendo como estaba antes
                'Orden= D, Fecha, CIA, Numero Archivo, Cantidad, Importe
                line &= "D,"
                line &= Format(row("Fecha"), "yyyyMMdd") & ","
                If Trim(ClaveCia) <> "" Then line &= Trim(ClaveCia) & ","
                line &= Numero & ","
                line &= "1,"
                line &= Format(ficha.IEfectivo + ficha.IChequesP + ficha.IChequesO, "#0.00")

                lineC &= "C,"
                lineC &= Format(row("Fecha"), "yyyyMMdd") & ","
                If Trim(ClaveCia) <> "" Then lineC &= Trim(ClaveCia) & ","
                lineC &= Numero & ","
                lineC &= qc.Count & ","
                lineC &= Format(qc.Sum(Function(v As ds_Reportes.Tbl_ChequesRow) v.Importe), "#0.00")
            End If
            'Escribir Encabezado
            WriteLine(1, line.ToCharArray)
            WriteLine(2, lineC.ToCharArray)

            'Armar una línea por cada Ficha
            line = ""
            Fila = 1
            With ficha
                line &= Fila & ","
                line &= .Cuenta & ","
                line &= .Remision & ","
                line &= FuncionesGlobales.fn_PonerCeros(.Referencia, Longitud_Referencia) & ","
                line &= .Divisa & ","
                line &= Format(.IEfectivo, "#0.00") & ","
                line &= Format(.IChequesP, "#0.00") & ","
                line &= Format(.IChequesO, "#0.00") & ","
                line &= Format(.ITotal, "#0.00") & ","
                line &= Format(.DEfectivo, "#0.00") & ","
                line &= .TipoD & ","

                Query = From d In Fichas_Efectivo.ToList Where d.Id_Ficha = Id_Ficha Select d
                For Each Den As ds_Reportes.Tbl_FichasEfectivoRow In Query
                    line &= Den.Presentacion & Format(Den.Denominacion, "#0.##") & ","
                    line &= Den.Cantidad & ","
                    line &= Format(Den.Importe, "#0.##") & ","
                Next
                'Quitar la coma que queda al final
                line = Microsoft.VisualBasic.Left(line, Len(line) - 1)
                WriteLine(1, line.ToCharArray)

                'Armar una linea por cada uno de los Cheques
                For Each che As ds_Reportes.Tbl_ChequesRow In From c In qc Where c.Id_Ficha = Id_Ficha Select c
                    lineC = ""
                    lineC &= Fila & ","
                    lineC &= .Cuenta & ","
                    lineC &= .Remision & ","
                    lineC &= .Divisa & ","
                    lineC &= che.MICR.Substring(0, 4) & che.MICR.Substring(5, 9) & che.MICR.Substring(15, 11) & che.MICR.Substring(27) & ","
                    lineC &= Format(che.Importe, "#0.00")
                    If DigitoSeguro Then
                        If che.Numero_Valida <> "" Then lineC &= "," & che.Numero_Valida.PadLeft(8, "0")
                    End If
                    WriteLine(2, lineC.ToCharArray)
                Next

            End With

            'Cerrar los Archivos
            FileClose(1)
            FileClose(2)

            Dim ArchivoD As Byte()
            Dim ArchivoC As Byte()
            'SE CONVIERTEN LOS ARCHIVOS A BYTES PARA GUARDARLOS EN LA BD
            ArchivoD = FuncionesGlobales.ReadFile(NombreArchivo)
            ArchivoC = FuncionesGlobales.ReadFile(NombreArchivoC)

            'Consultar las Denominaciones Agrupadas para Pro_ArchivosD
            Dim De = From fe In Fichas_Efectivo.ToList _
                           Where fe.Id_Ficha = Id_Ficha _
                           Group fe By fe.Id_Denominacion, fe.Denominacion Into Group _
                           Select Id_Denominacion, _
                           Denominacion, _
                           Cantidad = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Cantidad), _
                           Importe = Group.Sum(Function(f As ds_Reportes.Tbl_FichasEfectivoRow) f.Importe)

            'Guardar el Archivo
            NombreCorto_ArchivoD = System.IO.Path.GetFileName(NombreArchivo)
            NombreCorto_ArchivoC = ""
            Id_Archivo = fn_GuardarArchivo_Guardar1xFicha(Numero_Proceso, NumeroArchivo, NombreArchivo, Fecha_Aplicacion, Id_CajaBancaria, Id_Moneda, Id_Cajero, Id_GrupoDepo, Id_Sesion, De, Id_Ficha, Id_Cia, Corte_Turno, ArchivoD, ArchivoC, NombreCorto_ArchivoD, NombreCorto_ArchivoC)
            If Id_Archivo = 0 Then
                MsgBox("Ha ocurrido un error al guardar los datos del Archivo " & Numero, MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                'Solo mostrar el reporte cuando hay solo una Ficha en la Remision
                If qd.Count = 1 Then
                    frm.crv.ReportSource = fn_GuardarArchivo_GenerarReporte(Id_Archivo, Fecha_Aplicacion.ToShortDateString)
                    frm.ShowDialog()
                End If
                'Avanzar el numero de Archivo por si hay mas Fichas
                NumeroArchivo += 1
                Numero = Format(NumeroArchivo, "00")
                Numero_Proceso += 1
            End If
        Next
        MsgBox("Todos los cambios se aplicaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        lsv_Servicios.Items.Clear()
        btn_Guardar.Enabled = False
        btn_GuardarXficha.Enabled = False
        

    End Sub

    Private Sub lsv_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.SelectedIndexChanged
        'SegundosDesconexion = 0

        'If lsv_Servicios.SelectedItems.Count > 0 Then
        '    Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_Servicios.SelectedItems(0).SubItems(5).Text, lsv_Envases)
        'End If

    End Sub

    Private Sub frm_GuardarArchivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lsv_Envases.Columns.Add("Tipo Envase")
        'lsv_Envases.Columns.Add("Numero")
        tbl = fn_DepositoClientes_CrearTablaEnvase(Id_Moneda, Id_CajaBancaria, Id_GrupoDepo, Id_Sesion, Corte_Turno, Id_Cajero, CiaId)
        'FuncionesGlobales.MostrarVentana(Arch, False)


    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SegundosDesconexion = 0
        'Call Buscar_Envase(tbx_Buscar.Text)
    End Sub

    'Private Sub Buscar(ByVal Remision As String)
    '    SegundosDesconexion = 0

    '    'Marcar la remisión buscada
    '    fn_BuscarSeleccionarMarca_enListView(lsv_Servicios, Remision, 0)
    '    tbx_Buscar.Focus()
    '    tbx_Buscar.SelectAll()
    'End Sub

    'Sub Buscar_Envase(ByVal Numero As String)
    '    For Each row As DataRow In tbl.Rows
    '        If (row(1).ToString() = Numero) Then
    '            Buscar(row(0).ToString())
    '            Seleccionar(row(0).ToString)
    '            Exit Sub
    '        End If
    '    Next
    'End Sub
    'Sub Seleccionar(ByVal Remision As String)
    '    For Each item As ListViewItem In lsv_Servicios.Items
    '        If (item.SubItems(0).Text = Remision) Then
    '            item.Selected = True
    '        End If
    '    Next
    'End Sub

    'Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Asc(e.KeyChar) = 13 Then
    '        Call Buscar_Envase(tbx_Buscar.Text)
    '        tbx_Buscar.Focus()
    '    End If
    'End Sub
End Class