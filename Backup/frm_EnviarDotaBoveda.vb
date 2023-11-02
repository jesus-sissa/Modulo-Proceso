Imports Modulo_Proceso.Cn_Proceso
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_EnviarDotaBoveda

    Dim tbl As DataTable

    Private Sub frm_EnviaraBoveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista
        tbl = New DataTable
        lsv_Dotacion.Columns.Add("Remision")
        lsv_Dotacion.Columns.Add("Caja")
        lsv_Dotacion.Columns.Add("Cliente")
        lsv_Dotacion.Columns.Add("Fecha Captura")
        lsv_Dotacion.Columns.Add("Moneda")
        lsv_Dotacion.Columns.Add("Importe")
        lsv_Dotacion.Columns.Add("Status")

        lsv_DotacionD.Columns.Add("Denominacion")
        lsv_DotacionD.Columns.Add("Cantidad")
        lsv_DotacionD.Columns.Add("CantidadA")
        lsv_DotacionD.Columns.Add("CantidadB")
        lsv_DotacionD.Columns.Add("CantidadC")
        lsv_DotacionD.Columns.Add("CantidadD")
        lsv_DotacionD.Columns.Add("CantidadE")

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

        Call LlenaLista()
    End Sub

    Private Sub lsv_Ventas_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Dotacion.ItemChecked
        If lsv_Dotacion.CheckedItems.Count = 0 Then
            btn_Enviar.Enabled = False
            btn_ImprimirReporte.Enabled = False
        Else
            btn_Enviar.Enabled = True
            btn_ImprimirReporte.Enabled = True
        End If
    End Sub

    Private Sub lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Dotacion.SelectedItems.Count = 0 Then
            Cn_Proceso.fn_ValidaDotDLlenalista(lsv_DotacionD, 0)
            lsv_DotacionD.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Items.Clear()

            'Exit Sub
        Else
            Cn_Proceso.fn_ValidaDotDLlenalista(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)
            lsv_DotacionD.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv_DotacionD.Columns(6).TextAlign = HorizontalAlignment.Right

            Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_Dotacion.SelectedItems(0).SubItems(10).Text, lsv_Envases)

        End If

        FuncionesGlobales.RegistrosNum(lbl_Registros1, lsv_DotacionD.Items.Count)
    End Sub

    Private Sub btn_Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Enviar.Click
        SegundosDesconexion = 0

        Dim Elementos As ListViewItem
        Dim CantidadRemisiones As Integer = 0
        Dim CantidadEnvases As Integer = 0
        Dim lc_dt As New DataTable
        Dim lc_dr As DataRow

        lc_dt.TableName = "detalle"
        lc_dt.Columns.Add("Id_Dotacion", GetType(Integer))
        lc_dt.Columns.Add("Id_remision", GetType(Integer))

        'validar status 

        If lsv_Dotacion.CheckedItems.Count = 0 Then
            MsgBox("Seleccione por lo menos una Dotación.", 16, frm_MENU.Text)
            Exit Sub
        End If


        For Each Elementos In lsv_Dotacion.CheckedItems
            If Cn_Proceso.fn_ValidaBoveda(Elementos.Tag.ToString) = True Then
                MsgBox("Algunas de las Dotaciones ya no están disponibles, se actualizara la ventana.", MsgBoxStyle.Critical, frm_MENU.Text)
                'llena lista
                Call LlenaLista()
                Exit Sub
            End If

        Next

        Try
            For Each Elementos In lsv_Dotacion.CheckedItems
                CantidadRemisiones += 1
                CantidadEnvases += Elementos.SubItems(11).Text

                lc_dr = lc_dt.NewRow
                lc_dr("Id_Dotacion") = Elementos.Tag
                lc_dr("Id_remision") = Elementos.SubItems(10).Text
                lc_dt.Rows.Add(lc_dr)

            Next

            If Cn_Proceso.fn_Boveda_Nuevo(CantidadRemisiones, CantidadEnvases, lc_dt) = False Then
                MsgBox("Ocurrió un Error al intentar envier las Dotaciones.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub

            End If

        Catch ex As Exception
            Exit Sub
        End Try

        MsgBox("Las Dotaciones se enviaron corerctamente.", MsgBoxStyle.Information, frm_MENU.Text)

        LlenaLista()
        lsv_DotacionD.Items.Clear()
        lsv_Envases.Items.Clear()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LlenaLista()

        Cn_Proceso.fn_EnviaBovedaLlenalista(lsv_Dotacion, 0)
        lsv_Dotacion.CheckBoxes = True
        lsv_Dotacion.Columns(5).TextAlign = HorizontalAlignment.Right
        lsv_Dotacion.Columns(10).Width = 0
        lsv_Dotacion.Columns(11).Width = 0

        lsv_DotacionD.Items.Clear()
        lsv_Envases.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotacion.Items.Count)

        tbl = fn_EnviaBovedaLlenalistaEnvases(lsv_Dotacion)
    End Sub

    Private Sub cbx_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Todos.CheckedChanged
        For Each item As ListViewItem In lsv_Dotacion.Items
            item.Checked = cbx_Todos.Checked
        Next
    End Sub

    Private Sub lsv_Dotacion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.MouseHover, lsv_DotacionD.MouseHover
        SegundosDesconexion = 0
    End Sub


    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        'Marcar la remisión buscada
        fn_BuscarSeleccionarMarca_enListView(lsv_Dotacion, Remision, 0)
        tbx_Buscar.Focus()
        tbx_Buscar.SelectAll()
    End Sub

    Sub Buscar_Envase(ByVal Numero As String)
        For Each row As DataRow In tbl.Rows
            If (row(1).ToString() = Numero) Then
                Buscar(row(0).ToString())
                Seleccionar(row(0).ToString)
                Exit Sub
            End If
        Next
    End Sub
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In lsv_Dotacion.Items
            If (item.SubItems(0).Text = Remision) Then
                item.Selected = True
            End If
        Next
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If Not BuscarBoveda() Then
            Call Buscar_Envase(tbx_Buscar.Text)
        End If
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarBoveda() Then
                Call Buscar_Envase(tbx_Buscar.Text)
            End If
           
        End If
    End Sub
    Function BuscarBoveda() As Boolean
        SegundosDesconexion = 0

        If Not fn_BuscarSeleccionarMarca_enListView(lsv_Dotacion, tbx_Buscar.Text.Trim, 1) Then
            Return False
        End If
        tbx_Buscar.SelectAll()
        tbx_Buscar.Focus()

        Dim elementoSeleccionado As String = lsv_Dotacion.SelectedItems(0).SubItems(0).Text
        If elementoSeleccionado <> 0 Then
            'lsv_Dotacion.Items(0).Selected = True
        End If
        Return True
    End Function


    Private Sub tbx_Buscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Buscar.KeyDown

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImprimirReporte.Click

        Try

            Dim nombreDocumento As String
            nombreDocumento = DateTime.Now.ToString("dd-MM-yyyy")
            nombreDocumento += DateTime.Now.ToString("-HH-mm-ss")

            'Generamos el reporte
            Dim documento As New Document()
            PdfWriter.GetInstance(documento, New FileStream("C:\ReportesDenominaciones\" + nombreDocumento + ".pdf", FileMode.Create))
            documento.Open()

            'Agregamos el encabezado
            Dim encabezado As New Paragraph("SISSA")
            encabezado.Alignment = Element.ALIGN_CENTER
            documento.Add(encabezado)
            documento.Add(New Paragraph(" "))

            'fuentes que utilizamos en la tabla del reporte
            Dim font As New iTextSharp.text.Font

            Dim FontColour = New BaseColor(Color.Black)
            Dim fontEncabezado = FontFactory.GetFont("ITALIC", 8, 1, FontColour)
            Dim fontDatos = FontFactory.GetFont("NORMAL", 6, 1, FontColour)
            ' Dim fontEncabezado As New iTextSharp.text.Font(iTextSharp.text.Font.ITALIC, 8.0F, iTextSharp.text.Font.BOLD, Color.BLACK)
            'Dim fontDatos As New iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6.0F, iTextSharp.text.Font.BOLD, Color.BLACK)

            'Agregamos la tabla del reporte
            Dim tabla As New PdfPTable(10)
            tabla.HorizontalAlignment = Element.ALIGN_CENTER

            'Definimos el ancho de las columnas
            Dim intTblWidth() As Integer = {50, 25, 30, 10, 10, 10, 10, 10, 10, 20}
            tabla.SetWidths(intTblWidth)

            'Nombre de la fila
            tabla.AddCell(New Paragraph("Cliente", fontEncabezado))
            tabla.AddCell(New Paragraph("Remision", fontEncabezado))
            tabla.AddCell(New Paragraph("Envases", fontEncabezado))
            tabla.AddCell(New Paragraph("1000", fontEncabezado))
            tabla.AddCell(New Paragraph("500", fontEncabezado))
            tabla.AddCell(New Paragraph("200", fontEncabezado))
            tabla.AddCell(New Paragraph("100", fontEncabezado))
            tabla.AddCell(New Paragraph("50", fontEncabezado))
            tabla.AddCell(New Paragraph("20", fontEncabezado))
            tabla.AddCell(New Paragraph("Importe", fontEncabezado))

            'Con este for llenamos la tabla del documento
            For i As Integer = 0 To lsv_Dotacion.Items.Count - 1

                If lsv_Dotacion.Items(i).Checked = True Then

                    tbl = Cn_Proceso.fn_GenerarReporte(lsv_Dotacion.Items(i).SubItems(0).Text)

                    tabla.AddCell(New Paragraph(tbl.Rows(0)("Cliente").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("Numero_Remesion").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("Envases").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("DenominacionMil").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("DenominacionQuinientos").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("DenominacionDoscientos").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("DenominacionCien").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("DenominacionCincuenta").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(tbl.Rows(0)("DenominacionVeinte").ToString(), fontDatos))
                    tabla.AddCell(New Paragraph(Format(tbl.Rows(0)("Importe"), "0"), fontDatos)) 'le quitamos los 4 Ceros al importe
                End If
            Next
            documento.Add(tabla)
            documento.Close()

            System.Diagnostics.Process.Start("C:\ReportesDenominaciones\" + nombreDocumento + ".pdf")

        Catch ex As Exception


            If ex.Message = "No hay ninguna fila en la posición 0." Then
                MsgBox("Seleccione solo reportes que se hayan terminado su preparacion")
            Else
                MsgBox("Lo sentimos algo salio mal " + ex.Message)
            End If


        End Try

 
    End Sub
End Class