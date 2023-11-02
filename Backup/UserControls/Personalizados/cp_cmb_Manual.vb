Public Class cp_cmb_Manual
    Inherits cp_Combobox

    Dim Tbl As New DataTable

#Region "Metodos"

    Public Sub New()
        Me.DataSource = Tbl

        Tbl.Columns.Add("value")
        Tbl.Columns.Add("display")

        Me.ValueMember = "value"
        Me.DisplayMember = "display"

        AgregarItem("0", "Seleccione...")
        Me.MaxDropDownItems = 20

    End Sub

    Public Sub LimpiarItems()
        Tbl.Rows.Clear()
        AgregarItem("0", "Seleccione...")
    End Sub

    Public Sub AgregarItem(ByVal Value As String, ByVal Display As String)

        Dim Row As DataRow = Tbl.NewRow
        Row("value") = Value
        Row("display") = Display
        Tbl.Rows.Add(Row)

    End Sub

#End Region
End Class
