

Partial Public Class ds_Reportes
    Partial Class tbl_EnvasesActaDataTable

        Private Sub tbl_EnvasesActaDataTable_tbl_EnvasesActaRowChanging(ByVal sender As System.Object, ByVal e As tbl_EnvasesActaRowChangeEvent) Handles Me.tbl_EnvasesActaRowChanging

        End Sub

    End Class

    Partial Class tbl_ActaDiferenciaDataTable

        Private Sub tbl_ActaDiferenciaDataTable_tbl_ActaDiferenciaRowChanging(ByVal sender As System.Object, ByVal e As tbl_ActaDiferenciaRowChangeEvent) Handles Me.tbl_ActaDiferenciaRowChanging

        End Sub

    End Class

    Partial Class Tbl_DenominacionDataTable

        Private Sub Tbl_DenominacionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ImporteColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class Tbl_FichasDataTable

        Private Sub Tbl_FichasDataTable_Tbl_FichasRowChanging(ByVal sender As System.Object, ByVal e As Tbl_FichasRowChangeEvent) Handles Me.Tbl_FichasRowChanging

        End Sub

    End Class

End Class
