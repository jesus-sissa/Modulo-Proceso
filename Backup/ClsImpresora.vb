Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class ClsImpresora


#Region "Variables"

    Private components As System.ComponentModel.Container
    Private printFont As Font
    Private pd As PrintDocument
    Private linesPerPage As Single = 0
    Private count As Integer = 0
    Private Linea As String = Nothing
    Private dt_lineas As DataTable
    Private _AnchoPapel As Integer = 400
    Private _AltoPapel As Integer = 600
    Private _TamañoFuente As Integer = 10

#End Region

#Region "Propiedades"

    Public Property AnchoPapel() As Integer
        Get
            Return _AnchoPapel
        End Get
        Set(ByVal value As Integer)
            _AnchoPapel = value
        End Set
    End Property

    Public Property AltoPapel() As Integer
        Get
            Return _AltoPapel
        End Get
        Set(ByVal value As Integer)
            _AltoPapel = value
        End Set
    End Property

    Public Property TamañoFuente() As Integer
        Get
            Return _TamañoFuente
        End Get
        Set(ByVal value As Integer)
            _TamañoFuente = value
        End Set

    End Property

#End Region

    Public Sub AgregarLinea(ByVal cadena As String, ByVal Posx As Integer, ByVal Posy As Integer)
        Dim dr_linea As DataRow

        dr_linea = dt_lineas.NewRow
        dr_linea("Cadena") = cadena
        dr_linea("Posx") = Posx
        dr_linea("Posy") = Posy
        dt_lineas.Rows.Add(dr_linea)

    End Sub

    Public Sub Imprimir()

        pd = New PrintDocument()
        Dim CofgPapel As New PageSettings
        Dim TamañoPapel As New PaperSize

        TamañoPapel.Height = _AltoPapel
        TamañoPapel.Width = _AnchoPapel
        CofgPapel.PaperSize = TamañoPapel
        CofgPapel.Landscape = False

        pd.DefaultPageSettings = CofgPapel

        Try
            printFont = New Font("Arial", _TamañoFuente)
            AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
            pd.Print()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim dr_linea As DataRow

        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

        For Each dr_linea In dt_lineas.Rows

            If linesPerPage < count Then
                ev.HasMorePages = False
            End If

            ev.Graphics.DrawString(dr_linea("Cadena").ToString, printFont, Brushes.Black, dr_linea("Posx").ToString, dr_linea("Posy").ToString, New StringFormat())
            count += 1
        Next

        ev.HasMorePages = False

    End Sub


    Public Sub New()

        dt_lineas = New DataTable
        dt_lineas.Columns.Add("Cadena")
        dt_lineas.Columns.Add("Posx")
        dt_lineas.Columns.Add("Posy")

    End Sub

End Class
