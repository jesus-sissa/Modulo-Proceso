Imports Modulo_Proceso.Cn_Proceso
Imports Banorte
Imports System.Xml
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class frm_OrdenesServicios

    Dim WithEvents _OrdenesServicio As IOrdenesServicios
    Dim _BaseOrdenServicio As BaseOrdenServicio
    Dim _TipoDotacionSeleccionado As Integer = 0
    Dim i As Integer = 0
    Dim _DocW As PdfWriter
    Dim Path As String = ""

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_OrdenesServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0
        cmb_CajaBancaria.Enabled = False
        cmb_TipoDotacion.AgregarItem("1", "DOTACION CLIENTE")
        cmb_TipoDotacion.AgregarItem("2", "DOTACION A SUCURSAL BANCARIA")
        cmb_TipoDotacion.AgregarItem("3", "ENVIO A UNA CAJA PRINCIPAL")
        cmb_TipoDotacion.AgregarItem("4", "DEPOSITO BANXICO")
        cmb_TipoDotacion.AgregarItem("5", "VENTA DE MORRALLA")
        cmb_TipoDotacion.AgregarItem("6", "CONCENTRACIONES DIVISAS")
        cmb_TipoDotacion.AgregarItem("7", "DOTACION CAJERO")
        cmb_TipoDotacion.AgregarItem("8", "RETIROS A BANXICO")
        cmb_TipoDotacion.AgregarItem("9", "DEPOSITOS A BANXICO")
        cmb_CajaBancaria.Actualizar()



        cmb_TipoDotacionExp.AgregarItem("1", "DOTACION CLIENTE")
        cmb_TipoDotacionExp.AgregarItem("2", "DOTACION A SUCURSAL BANCARIA")
        cmb_TipoDotacionExp.AgregarItem("3", "ENVIO A UNA CAJA PRINCIPAL")
        cmb_TipoDotacionExp.AgregarItem("4", "DEPOSITO BANXICO")
        cmb_TipoDotacionExp.AgregarItem("5", "VENTA DE MORRALLA")
        cmb_TipoDotacionExp.AgregarItem("6", "CONCENTRACIONES DIVISAS")
        cmb_TipoDotacionExp.AgregarItem("7", "DOTACION CAJERO")
        cmb_TipoDotacionExp.AgregarItem("8", "RETIROS A BANXICO")
        cmb_TipoDotacionExp.AgregarItem("9", "DEPOSITOS A BANXICO")
        cmb_CajaBancariaExp.Actualizar()
        dtp_Fecha.Value = Now()
    End Sub
    Private Sub lsv_Dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.SelectedIndexChanged
        SegundosDesconexion = 0
        If lsv_Dotaciones.SelectedItems.Count = 0 Then Exit Sub
        lsv_Divisa.Items.Clear()
        lsv_Divisa.Actualizar(_BaseOrdenServicio.GetDotacionesD(lsv_Dotaciones.SelectedItems(0).Tag), "Id_Dotacion")

        lsv_Divisa.Columns(5).Width = 0
        lsv_Divisa.Columns(6).Width = 0
        lsv_Divisa.Columns(7).Width = 0
        lsv_Divisa.Columns(8).Width = 0

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If lsv_Dotaciones.CheckedItems.Count = 0 Then
            MsgBox("Seleccione por lo menos una orden para guardar", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not Validar() Then
            Exit Sub
        End If

        For Each item As ListViewItem In lsv_Dotaciones.CheckedItems
            If fn_OrdenesServicio_Valida(item.Text) Then
                MsgBox("Alguna orden selaccionada, ya existe", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Next
        

        Dim Id_CajaBancaria As Integer = CInt((From dr As DataRow In (CType(cmb_CajaBancaria.DataSource, DataTable)) _
                                         Where dr("CR").Equals(cmb_CajaBancaria.SelectedValue) _
                                         Select dr("Id_CajaBancaria")).Single())

        If fn_OrdenServicio_Guardar(lsv_Dotaciones, cmb_TipoDotacion.SelectedValue, ArchivosConfirma(), _BaseOrdenServicio, Id_CajaBancaria, cmb_TipoDotacion.SelectedValue) Then
            MsgBox("La dotacion se ha guardado correctamente", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ha ocurrido un error al intentar generar la dotacion", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        For Each item As ListViewItem In lsv_Dotaciones.CheckedItems
            item.Checked = False
        Next

        chk_TodoOdes.Checked = False

        lsv_Divisa.Items.Clear()

    End Sub

    Private Function ArchivosConfirma() As List(Of Banorte.OdesArchivo)
        Dim OdesArchivos As New List(Of Banorte.OdesArchivo)
        Dim i As Integer = 0

        Dim Archivos As System.Collections.Generic.IEnumerable(Of String) = Nothing
        ' el parametro que se le pasa al metodo Archivos, es la posicion de la columna en el servicio correspondiente
        If TypeOf _BaseOrdenServicio Is OrdenDotacionesDivisas Then
            i = 8
            Archivos = ObtenerArchivos(i)
        ElseIf TypeOf _BaseOrdenServicio Is OrdenConcentracionesDivisas Then
            i = 6
            Archivos = ObtenerArchivos(i)
        ElseIf TypeOf _BaseOrdenServicio Is OrdenDotacionesCajeros Then
            i = 9
            Archivos = ObtenerArchivos(i)
        ElseIf TypeOf _BaseOrdenServicio Is OrdenDotacionesClientes Then
            i = 7
            Archivos = ObtenerArchivos(i)
            'ElseIf TypeOf _BaseOrdenServicio Is OrdenDotacionesRetirosBanxico Then
            '    i = 6
            '    Archivos = ObtenerArchivos(i)
            'ElseIf TypeOf _BaseOrdenServicio Is OrdenDotacionesDepositoBanxico Then
            '    i = 6
            '    Archivos = ObtenerArchivos(i)
        End If

        Dim NumArchivo As Integer = 0

        For Each Archivo In Archivos
            NumArchivo += 1
            Dim Odes As New Banorte.OdesArchivo()
            Odes.NombreArchivo = New String(Archivo.ToArray())
            Odes.NumeroArchivo = NumArchivo

            For Each item As ListViewItem In lsv_Dotaciones.CheckedItems
                If New String(Archivo.ToArray()) = item.SubItems(i).Text Then
                    Dim OdesConfirmar As New Banorte.BaseOdesConfirmacion(item.Text, item.Text & "1", item.SubItems(lsv_Dotaciones.Columns.Count - 1).Text)
                    Odes.OrdeneConfirmada = OdesConfirmar
                End If
            Next
            OdesArchivos.Add(Odes)
        Next
        Return OdesArchivos
    End Function

    Private Function ObtenerArchivos(ByVal i As Integer) As System.Collections.Generic.IEnumerable(Of String)
        Return (From item As ListViewItem In lsv_Dotaciones.CheckedItems _
                        Select item.SubItems(i).Text).Distinct()
    End Function

    Public Function Validar() As Boolean
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Seleccione una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If cmb_TipoDotacion.SelectedValue = "0" Then
            MsgBox("Seleccione una Salida.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        Return True
    End Function

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        If lsv_DotacionesExp.CheckedItems.Count = 0 Then
            MsgBox("Seleccione por lo menos una orden para exportar", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Try

            Dim Consecutivo As Integer = 1

            If Path = "" Then
                Dim dlg As DialogResult = dlg_Dotacion.ShowDialog()

                If dlg = Windows.Forms.DialogResult.OK Then
                    Path = dlg_Dotacion.SelectedPath
                Else
                    MsgBox("Imposible exportar, no se seleccionó ninguna ubicación de destino", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            End If

            Dim di As New DirectoryInfo(Path)
            Consecutivo += di.GetFiles().Count()

            Dim _Doc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 20.0F, 20.0F)

            Dim DocW As PdfWriter = PdfWriter.GetInstance(_Doc, New FileStream(Path & "\" & cmb_TipoDotacionExp.Text & " " & Consecutivo & ".pdf", FileMode.OpenOrCreate))

            Dim font12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL))
            Dim font10 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim font6 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 16, iTextSharp.text.Font.NORMAL))

            _Doc.Open()
            _Doc.PageCount = lsv_DotacionesExp.CheckedItems.Count

            Dim Col1 As PdfPCell
            Dim Col2 As PdfPCell


            Dim DivisaCol1 As PdfPCell
            Dim DivisaCol2 As PdfPCell

            Dim TblTitulo As New PdfPTable(1)
            Dim MsgTitulo As New PdfPCell(New Phrase("Sistema de Administradcion de Efectivo"))
            MsgTitulo.Border = 0
            MsgTitulo.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT
            MsgTitulo.BackgroundColor = New BaseColor(255, 212, 128) 'iTextSharp.text.Color(255, 212, 128)
            TblTitulo.AddCell(MsgTitulo)

            TblTitulo.AddCell(PdfPCellCustom())
            TblTitulo.AddCell(PdfPCellCustom())
            _Doc.Add(TblTitulo)

            Dim dt_CaratulaDescripcion = fn_OrdenServicio_GetCaratula(cmb_Archivo.SelectedValue, dtp_Fecha.Value, cmb_TipoDotacionExp.SelectedValue)

            If dt_CaratulaDescripcion Is Nothing Then
                MsgBox("Ocurrió un error al intentar consultar ordenes, imposible exportar", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Dim TblOrdenCaratulaDes As New PdfPTable(1)

            Dim OrdenCarutalaDes As String = ""

            For k As Integer = 0 To dt_CaratulaDescripcion.Columns.Count - 1
                OrdenCarutalaDes = (dt_CaratulaDescripcion.Columns(k).ColumnName)
                OrdenCarutalaDes &= ": " & dt_CaratulaDescripcion.Rows(0).Item(k).ToString()
                Col1 = New PdfPCell(New Phrase(OrdenCarutalaDes, font10))
                Col1.Border = 0
                TblOrdenCaratulaDes.AddCell(Col1)
            Next
            TblOrdenCaratulaDes.AddCell(PdfPCellCustom())
            TblOrdenCaratulaDes.AddCell(PdfPCellCustom())
            _Doc.Add(TblOrdenCaratulaDes)
         



            Dim dt_Caratula As DataTable = fn_OdesDivisa_GetCaratula(cmb_TipoDotacionExp.SelectedValue, cmb_Archivo.SelectedValue, dtp_Fecha.Value)

            If dt_Caratula Is Nothing Then
                MsgBox("Ocurrió un error al intentar consultar ordenes, imposible exportar", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Dim TblCaratula As PdfPTable = TblCrearColumna(dt_Caratula, dt_Caratula.Columns.Count, font10)

            TblCrearItems(TblCaratula, dt_Caratula, font10)

            _Doc.Add(TblCaratula)
            _Doc.Add(PdfPCellCustom())

            Dim dt_OdesTipoDivisaTotal As DataTable = fn_OdesDivisa_GetTipoDivisaTotal(cmb_TipoDotacionExp.SelectedValue, cmb_Archivo.SelectedValue, dtp_Fecha.Value)

            If dt_OdesTipoDivisaTotal Is Nothing Then
                MsgBox("Ocurrió un error al intentar consultar ordenes, imposible exportar", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Dim TblDivisaTipoTotal As PdfPTable = TblCrearColumna(dt_OdesTipoDivisaTotal, dt_OdesTipoDivisaTotal.Columns.Count, font10)
            TblCrearItems(TblDivisaTipoTotal, dt_OdesTipoDivisaTotal, font10)

            _Doc.Add(TblDivisaTipoTotal)
            _Doc.Add(PdfPCellCustom())


            Dim dt_DivisaTotal As DataTable = fn_OdesDivisa_GetDivisaTotal(cmb_TipoDotacionExp.SelectedValue, cmb_Archivo.SelectedValue, dtp_Fecha.Value)

            If dt_DivisaTotal Is Nothing Then
                MsgBox("Ocurrió un error al intentar consultar ordenes, imposible exportar", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Dim TblDivisaTotal As PdfPTable = TblCrearColumna(dt_DivisaTotal, dt_DivisaTotal.Columns.Count, font10)
            TblCrearItems(TblDivisaTotal, dt_DivisaTotal, font10)
            _Doc.Add(TblDivisaTotal)
            _Doc.NewPage()

            For i As Integer = 0 To lsv_DotacionesExp.Items.Count - 1

                If lsv_DotacionesExp.Items(i).Checked Then


                    Dim TblMaestro As New PdfPTable(1)

                    For j As Integer = 0 To lsv_DotacionesExp.Columns.Count - 1
                        Dim col As String = lsv_DotacionesExp.Columns(j).Text

                        Dim item As String = ""

                        If j = 0 Then
                            item = lsv_DotacionesExp.Items(i).Text
                        Else
                            item = lsv_DotacionesExp.Items(i).SubItems(j).Text
                        End If

                        col &= ": " & item
                        Col1 = New PdfPCell(New Phrase(col, font10))
                        Col1.Border = 0
                        TblMaestro.AddCell(Col1)
                    Next

                    TblMaestro.AddCell(PdfPCellCustom())
                    TblMaestro.AddCell(PdfPCellCustom())
                    _Doc.Add(TblMaestro)

                    Dim TblMaestroDivisaCol As New PdfPTable(5)

                    Dim Divisa As DataTable = fn_OdesDivisa_Get(lsv_DotacionesExp.Items(i).Tag)


                    'Dim TblMaestroDivisaCol As PdfPTable = TblCrearColumna(Divisa, Divisa.Columns.Count, font10)

                    'TblCrearItems(TblMaestroDivisaCol, Divisa, font10)

                    '_Doc.Add(TblCaratula)
                    '_Doc.Add(PdfPCellCustom())


                    For k As Integer = 0 To Divisa.Columns.Count - 1
                        DivisaCol1 = New PdfPCell(New Phrase(Divisa.Columns(k).ColumnName, font10))
                        DivisaCol1.Border = 0
                        Dim FontColour = New BaseColor(35, 31, 32)
                        Dim Calibri8 = FontFactory.GetFont("Calibri", 8, FontColour)
                        DivisaCol1.BackgroundColor = New BaseColor(242, 242, 242) ' BaseC ' BaseColor.LIGHT_GRAY 'iTextSharp.text.Color(255, 212, 128)
                        TblMaestroDivisaCol.AddCell(DivisaCol1)
                    Next


                    For l As Integer = 0 To Divisa.Rows.Count - 1
                        For m As Integer = 0 To Divisa.Columns.Count - 1
                            DivisaCol2 = New PdfPCell(New Phrase(Divisa.Rows(l).Item(m).ToString(), font10))
                            DivisaCol2.Border = 0
                            If l Mod 2 = 0 Then DivisaCol2.BackgroundColor = New BaseColor(242, 242, 242) 'iTextSharp.text.Color(242, 242, 242)
                            TblMaestroDivisaCol.AddCell(DivisaCol2)
                        Next

                    Next

                    _Doc.Add(TblMaestroDivisaCol)

                    Dim TblMsgDetalle As New PdfPTable(1)
                    TblMsgDetalle.AddCell(PdfPCellCustom())
                    _Doc.Add(TblMsgDetalle)

                    Col2 = New PdfPCell(New PdfPCell(New Phrase("Detalle")))
                    Col2.Border = 0
                    TblMsgDetalle.AddCell(Col2)
                    _Doc.Add(TblMsgDetalle)

                    '_Doc.Add(PdfPCellCustom("DETALLE"))
                    '_Doc.Add(PdfPCellCustom())



                    'TblMaestroDivisaCol = Nothing

                    Dim TblDetalle As New PdfPTable(4)

                    Dim SumaDivisa As DataTable = fn_OdesDivisa_GetSuma(lsv_DotacionesExp.Items(i).Tag)

                    'Dim TblDetalle As PdfPTable = TblCrearColumna(SumaDivisa, SumaDivisa.Columns.Count, font10)

                    'TblCrearItems(TblDetalle, SumaDivisa, font10)
                    '_Doc.Add(TblDetalle)
                    '_Doc.Add(PdfPCellCustom())

                    For x As Integer = 0 To SumaDivisa.Columns.Count - 1
                        DivisaCol1 = New PdfPCell(New Phrase(SumaDivisa.Columns(x).ColumnName, font10))
                        DivisaCol1.Border = 0
                        DivisaCol1.BackgroundColor = New BaseColor(255, 212, 128) ' iTextSharp.text.Color(255, 212, 128)
                        TblDetalle.AddCell(DivisaCol1)
                    Next

                    For y As Integer = 0 To SumaDivisa.Rows.Count - 1
                        For z As Integer = 0 To SumaDivisa.Columns.Count - 1
                            DivisaCol2 = New PdfPCell(New Phrase(SumaDivisa.Rows(y).Item(z).ToString(), font10))
                            DivisaCol2.Border = 0
                            DivisaCol2.BackgroundColor = New BaseColor(255, 247, 230) ' iTextSharp.text.Color(255, 247, 230)
                            TblDetalle.AddCell(DivisaCol2)
                        Next
                    Next

                    _Doc.Add(TblDetalle)

                    Dim TblVacio As New PdfPTable(1)
                    TblVacio.AddCell(PdfPCellCustom())
                    _Doc.Add(TblVacio)

                    _Doc.NewPage()
                End If
            Next
            _Doc.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
        MsgBox("Se exportó con exito", MsgBoxStyle.Information, frm_MENU.Text)
    End Sub

    Public Function TblCrearColumna(ByVal dt As DataTable, ByVal CantidadColumna As Integer, ByVal Fuente As iTextSharp.text.Font) As PdfPTable
        Dim Tbl As New PdfPTable(CantidadColumna)
        For i As Integer = 0 To dt.Columns.Count - 1
            Dim Col = New PdfPCell(New Phrase(dt.Columns(i).ColumnName, Fuente))
            Col.Border = 0
            Col.BackgroundColor = New BaseColor(255, 212, 128) ' iTextSharp.text.Color(255, 212, 128)
            Tbl.AddCell(Col)
        Next
        Return Tbl
    End Function


    Public Sub TblCrearItems(ByRef Tbl As PdfPTable, ByVal dt As DataTable, ByVal Fuente As iTextSharp.text.Font)
        For i As Integer = 0 To dt.Rows.Count - 1
            For j As Integer = 0 To dt.Columns.Count - 1
                Dim col = New PdfPCell(New Phrase(dt.Rows(i).Item(j).ToString(), Fuente))
                col.Border = 0
                If i Mod 2 = 0 Then col.BackgroundColor = New BaseColor(242, 242, 242) ' iTextSharp.text.Color(242, 242, 242)
                Tbl.AddCell(col)
            Next
        Next
    End Sub

    Public Function PdfPCellCustom(Optional ByVal texto As String = "") As PdfPCell
        Dim Col1 As New PdfPCell(New Phrase(texto))
        Col1.Border = 0
        Return Col1
    End Function

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        If cmb_TipoDotacionExp.SelectedValue = "0" Then
            MsgBox("Seleccione una Salida.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_CajaBancariaExp.SelectedValue = 0 Then
            MsgBox("Seleccione una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If


        If Not fn_OdesServicio_Get(cmb_TipoDotacionExp.SelectedValue, cmb_CajaBancariaExp.SelectedValue, dtp_Fecha.Value, lsv_DotacionesExp, cmb_Archivo.SelectedValue) Then
            MsgBox("Ocurrió un error al intentar consultar Odes", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_RegistrosExp.Text = "Registro: '" & lsv_DotacionesExp.Items.Count & "'"

        If lsv_DotacionesExp.Items.Count > 0 And cmb_TipoDotacionExp.SelectedValue = 1 Then
            For Each item As ListViewItem In lsv_DotacionesExp.Items
                item.SubItems(lsv_DotacionesExp.Columns.Count - 1).Text = Format(fn_OdesDivisa_Importe(item.Tag), "c")
            Next
        End If
    End Sub

    Private Sub btn_CerrarExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerrarExp.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub lsv_DotacionesExp_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_DotacionesExp.ItemChecked
        btn_Exportar.Enabled = False
        btn_Exportar.Enabled = (lsv_DotacionesExp.CheckedItems.Count = lsv_DotacionesExp.Items.Count)
    End Sub

    Private Sub lsv_DotacionesExp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_DotacionesExp.SelectedIndexChanged
        SegundosDesconexion = 0
        If lsv_DotacionesExp.SelectedItems.Count = 0 Then Exit Sub
        fn_OdesDivisa_Get(lsv_DotacionesExp.SelectedItems(0).Tag, lsv_DivisaExp)
    End Sub

    Private Sub tab_Odes_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles tab_Odes.Selecting
        SegundosDesconexion = 0
        If e.TabPage.Name = "tab_DescargarOdes" Then
            cmb_CajaBancaria.SelectedValue = 0
            cmb_TipoDotacion.SelectedValue = 0
            lsv_Dotaciones.Items.Clear()
            lsv_Divisa.Items.Clear()
        ElseIf e.TabPage.Name = "tab_ExportarOrdenes" Then
            cmb_CajaBancariaExp.SelectedValue = 0
            cmb_TipoDotacionExp.SelectedValue = 0
            lsv_DivisaExp.Items.Clear()
            lsv_DotacionesExp.Items.Clear()
            dtp_Fecha.Value = Date.Now()
        End If
    End Sub

    Private Sub cmb_TipoDotacionExp_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDotacionExp.SelectedValueChanged
        SegundosDesconexion = 0
        lsv_DotacionesExp.Items.Clear()
        lsv_DivisaExp.Items.Clear()
        cmb_CajaBancariaExp.SelectedValue = 0
        cmb_CajaBancariaExp.Enabled = CInt(cmb_TipoDotacionExp.SelectedValue) > 0
        cmb_Archivo.SelectedValue = 0
        cmb_Archivo.Enabled = False
        lbl_RegistrosExp.Text = "Registro: 0"
        chk_Todo.Checked = False
    End Sub

    Private Sub btn_Confirmar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirmar.Click
        SegundosDesconexion = 0
        If lsv_Dotaciones.CheckedItems.Count = 0 Then
            MsgBox("Seleccione ordenes a confirmar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Try
            Dim OdesConfirma As Banorte.Confirmacion = Nothing
            OdesConfirma = New Banorte.Confirmacion(ArchivosConfirma())
            OdesConfirma.CrearXmlElement()

            If Not OdesConfirma.Enviar() Then
                Throw New ApplicationException("Ocurrió un error al intentar confirmar servicios.")
            End If

            MsgBox("La confirmación se realizó con exito.", MsgBoxStyle.Information, frm_MENU.Text)
            cmb_TipoDotacion.SelectedValue = 0
            cmb_TipoDotacion.SelectedValue = _TipoDotacionSeleccionado
            lsv_Dotaciones.Items.Clear()
            lsv_Divisa.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_TipoDotacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDotacion.SelectedValueChanged
        SegundosDesconexion = 0
        cmb_CajaBancaria.SelectedValue = 0
        cmb_CajaBancaria.Enabled = False
        lsv_Divisa.Items.Clear()
        chk_TodoOdes.Checked = False
        Try
            Select Case CInt(cmb_TipoDotacion.SelectedValue)
                Case 1
                    _OrdenesServicio = New OdesDotacionesClientes("90011")
                    _BaseOrdenServicio = New OrdenDotacionesClientes(_OrdenesServicio)
                    _TipoDotacionSeleccionado = cmb_TipoDotacion.SelectedValue
                Case 2
                    _OrdenesServicio = New OdesDotacionesDivisas("90011")
                    _BaseOrdenServicio = New OrdenDotacionesDivisas(_OrdenesServicio)
                    _TipoDotacionSeleccionado = cmb_TipoDotacion.SelectedValue
                Case 6
                    _OrdenesServicio = New OdesDotacionesConcentraciones("90011")
                    _BaseOrdenServicio = New OrdenConcentracionesDivisas(_OrdenesServicio)
                    _TipoDotacionSeleccionado = cmb_TipoDotacion.SelectedValue
                Case 7
                    _OrdenesServicio = New OdesDotacionesAtms("90011")
                    _BaseOrdenServicio = New OrdenDotacionesCajeros(_OrdenesServicio)
                    _TipoDotacionSeleccionado = cmb_TipoDotacion.SelectedValue
                Case 8
                    _OrdenesServicio = New OdesRetencionBancoMexico("90011")
                    _BaseOrdenServicio = New OrdenDotacionesRetirosBanxico(_OrdenesServicio)
                    _TipoDotacionSeleccionado = cmb_TipoDotacion.SelectedValue
                Case 9
                    _OrdenesServicio = New OdesDepositoBancoMexico("90011")
                    _BaseOrdenServicio = New OrdenDotacionesDepositoBanxico(_OrdenesServicio)
                    _TipoDotacionSeleccionado = cmb_TipoDotacion.SelectedValue
            End Select
            System.Threading.Thread.Sleep(2000)
            cmb_CajaBancaria.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
        
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        lbl_Registros.Text = "Registros: 0"
        SegundosDesconexion = 0
        Try
            If CInt(cmb_TipoDotacion.SelectedValue) > 0 And CInt(cmb_TipoDotacion.SelectedValue) > 0 Then
                _BaseOrdenServicio.GestionarOrdenServicio()
                _BaseOrdenServicio.MapearDenominaciones()
                _BaseOrdenServicio.GestionarNombreArchivo()
                _BaseOrdenServicio.CrCajaBancaria = cmb_CajaBancaria.SelectedValue
                lsv_Dotaciones.Actualizar(_BaseOrdenServicio.GetDotaciones(), "Id_Dotacion")
                lbl_Registros.Text = "Registros: '" & lsv_Dotaciones.Items.Count & "'"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_CajaBancariaExp_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancariaExp.SelectedValueChanged
        If cmb_CajaBancariaExp.SelectedValue = 0 Then Exit Sub

        cmb_Archivo.Enabled = cmb_CajaBancariaExp.SelectedValue > 0
        cmb_Archivo.Actualizar(fn_OrdenesArchivo_GetArchivo(dtp_Fecha.Value, cmb_TipoDotacionExp.SelectedValue))
    End Sub


    Private Sub chk_Todo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todo.CheckedChanged
        For Each item As ListViewItem In lsv_DotacionesExp.Items
            item.Checked = chk_Todo.Checked
        Next
    End Sub

    Private Sub chk_TodoOdes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TodoOdes.CheckedChanged
        For Each item As ListViewItem In lsv_Dotaciones.Items
            item.Checked = chk_TodoOdes.Checked
        Next
    End Sub

    Private Sub lsv_Dotaciones_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Dotaciones.ItemChecked
        btn_Guardar.Enabled = False
        btn_Guardar.Enabled = (lsv_DotacionesExp.CheckedItems.Count = lsv_DotacionesExp.Items.Count)
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        cmb_CajaBancariaExp.SelectedValue = 0
        cmb_Archivo.SelectedValue = 0
        cmb_TipoDotacionExp.SelectedValue = 0
    End Sub


    Private Sub cmb_Archivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Archivo.SelectedIndexChanged
        lsv_DotacionesExp.Items.Clear()
        lsv_DivisaExp.Items.Clear()
        lbl_RegistrosExp.Text = "Registros: 0"
        chk_Todo.Checked = False
    End Sub


End Class