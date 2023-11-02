Imports System.Collections
Imports System.Windows.Forms

Public Class ListViewColumnSorter
    Implements System.Collections.IComparer

    Private ColumnToSort As Integer
    Private OrderOfSort As SortOrder
    Private ObjectCompare As CaseInsensitiveComparer

    Public Sub New()
        ' Initialize the column to '0'.
        ColumnToSort = 0

        ' Initialize the sort order to 'none'.
        OrderOfSort = SortOrder.None

        ' Initialize the CaseInsensitiveComparer object.
        ObjectCompare = New CaseInsensitiveComparer()
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim string_x As String
        Dim string_y As String

        Dim item_x As ListViewItem
        Dim item_y As ListViewItem

        ' Cast the objects to be compared to ListViewItem objects.
        item_x = DirectCast(x, ListViewItem)
        item_y = DirectCast(y, ListViewItem)

        '  Obtener los valores de los SUb-items
        If item_x.SubItems.Count <= ColumnToSort Then
            string_x = ""
        Else
            string_x = item_x.SubItems(ColumnToSort).Text
        End If

        If item_y.SubItems.Count <= ColumnToSort Then
            string_y = ""
        Else
            string_y = item_y.SubItems(ColumnToSort).Text
        End If

        'Compara en que orden se van ordenar (Ascendent o Descendente)
        If (OrderOfSort = SortOrder.Ascending) Then

            If IsNumeric(string_x) And IsNumeric(string_y) Then

                Return CDec(string_x).CompareTo(CDec(string_y))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
            Else
                Return String.Compare(string_x, string_y)
            End If
        ElseIf OrderOfSort = SortOrder.Descending Then

            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return CDec(string_y).CompareTo(CDec(string_x))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
            Else
                Return String.Compare(string_y, string_x)
            End If
        End If

    End Function

    Public Property SortColumn() As Integer
        Set(ByVal Value As Integer)
            ColumnToSort = Value
        End Set

        Get
            Return ColumnToSort
        End Get
    End Property

    Public Property Order() As SortOrder
        Set(ByVal Value As SortOrder)
            OrderOfSort = Value
        End Set

        Get
            Return OrderOfSort
        End Get
    End Property
End Class
