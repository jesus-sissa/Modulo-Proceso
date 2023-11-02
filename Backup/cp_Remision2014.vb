
Public Structure cp_Remision2014

    Private _Dt_Impresion As DataTable

    Public Property Dt_DatosImpresion() As DataTable
        Get
            Return _Dt_Impresion
        End Get
        Set(ByVal value As DataTable)
            _Dt_Impresion = value
        End Set
    End Property


End Structure

Public Class cp_Impresion2014

    Private WithEvents _Documento As Printing.PrintDocument
    Private _Remision As cp_Remision2014

    Public Sub New(ByVal Remision As cp_Remision2014)
        _Remision = Remision
        _Documento = New Printing.PrintDocument
    End Sub

    Public Sub New(ByVal Dt_Impresion As DataTable)
        _Remision.Dt_DatosImpresion = Dt_Impresion
        _Documento = New Printing.PrintDocument
    End Sub

    Private Function ValidarImpresora() As Boolean

        Dim ResolucionMax As Integer = (From p As Printing.PrinterResolution In _Documento.PrinterSettings.PrinterResolutions Where p.Y > 0 Order By p.Y Descending Select p.Y).FirstOrDefault

        If ResolucionMax > 200 Then
            Select Case MsgBox("La impresora " & _Documento.PrinterSettings.PrinterName & " parece no ser la indicada para las remisiones. Desea continuar?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, frm_MENU.Text)
                Case MsgBoxResult.Yes
                    Return True
                Case MsgBoxResult.No
                    Dim print As New PrintDialog With {.Document = _Documento}
                    If print.ShowDialog = DialogResult.Cancel Then
                        Return False
                    Else
                        Return True
                    End If
                Case MsgBoxResult.Cancel
                    Return False
            End Select
        Else
            Return True
        End If
    End Function

    Public Shared Function Imprimir2014(ByVal Dt_Impresion As DataTable) As Boolean
        Dim yo As New cp_Impresion2014(Dt_Impresion)
        If Not yo.ValidarImpresora() Then Return False

        yo._Documento.DefaultPageSettings = New Printing.PageSettings With {.Landscape = False}

        Try
            yo._Documento.Print()
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Private Sub pd_PrintPage_2014(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _Documento.PrintPage
        e.HasMorePages = False
        Dim Alineacion As System.Drawing.StringAlignment
        Dim lcX As Integer
        Dim lcY As Integer
        Dim lcW As Integer
        Dim lcH As Integer
        Dim lcFuente As Integer

        For Each dr_Imprimir As DataRow In _Remision.Dt_DatosImpresion.Rows
            lcX = dr_Imprimir("X")
            lcY = dr_Imprimir("Y")
            lcW = dr_Imprimir("Ancho")
            lcH = dr_Imprimir("Alto")
            lcFuente = dr_Imprimir("Fuente")

            Select Case dr_Imprimir("Alineacion")
                Case "DERECHA"
                    Alineacion = StringAlignment.Far
                Case "CENTRO"
                    Alineacion = StringAlignment.Center
                Case "IZQUIERDA"
                    Alineacion = StringAlignment.Near
            End Select
            CrearLinea(e.Graphics, dr_Imprimir("Valor"), lcFuente, lcX, lcY, lcW, lcH, Alineacion)
        Next
    End Sub

    Private Sub CrearLinea(ByRef G As System.Drawing.Graphics, ByVal Texto As String, ByVal FontSize As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal W As Integer, ByVal H As Integer, ByVal Alineacion As Drawing.StringAlignment)
        Dim Font As New Font("Arial", FontSize)
        Dim lc_Alineacion As New Drawing.StringFormat
        Dim Rectangulo As New Rectangle(X, Y, W, H)
        lc_Alineacion.Alignment = Alineacion
        G.PageUnit = GraphicsUnit.Millimeter

        G.DrawString(Texto, Font, Brushes.Black, Rectangulo, lc_Alineacion)
    End Sub
End Class