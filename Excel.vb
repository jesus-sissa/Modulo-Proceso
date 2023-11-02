Imports Microsoft.Office.Interop.Excel
Public Class Excel
    Public Function ExportarExcel(grid As DataGridView, ByVal Bar As ToolStripProgressBar) As Boolean
        Bar.Maximum = (grid.Columns.Count) * grid.Rows.Count + 2
        Bar.Value = 0
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        excel.Workbooks.Add(True)
        Dim IndiceColumna As Integer
        For Each col As DataGridViewColumn In grid.Columns
            IndiceColumna += 1
            excel.Cells(1, IndiceColumna) = col.Name

        Next
        Dim IndiceFila As Integer
        For Each row As DataGridViewRow In grid.Rows
            IndiceFila += 1
            IndiceColumna = 0
            For Each col As DataGridViewColumn In grid.Columns
                IndiceColumna += 1
                excel.Cells(IndiceFila + 1, IndiceColumna) = row.Cells(col.Name).Value
                'excel.Cells.Font
                Bar.Value += 1
            Next
        Next
        Bar.Value = Bar.Maximum
        excel.Visible = True
        Return True
    End Function
End Class
