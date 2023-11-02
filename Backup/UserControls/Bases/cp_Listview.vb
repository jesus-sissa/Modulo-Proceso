Public Class cp_Listview
    Inherits ListView

#Region "Eventos"
    'Este evento se producira al ejecutarse la funcion Actualizar
    Event AlActualizar()
#End Region

#Region "Variables Privadas"
    Private _1 As Integer = 10
    Private _2 As Integer = 10
    Private _3 As Integer = 10
    Private _4 As Integer = 10
    Private _5 As Integer = 10
    Private _6 As Integer = 10
    Private _7 As Integer = 10
    Private _8 As Integer = 10
    Private _9 As Integer = 10
    Private _10 As Integer = 10
    Private _Lvs As New ListViewColumnSorter
#End Region

#Region "Propiedades"

    Public Property Lvs() As ListViewColumnSorter
        Get
            Return _Lvs
        End Get
        Set(ByVal value As ListViewColumnSorter)
            _Lvs = value
        End Set
    End Property

    Public Property Row1() As Integer
        Get
            Return _1
        End Get
        Set(ByVal value As Integer)
            _1 = value
        End Set
    End Property

    Public Property Row2() As Integer
        Get
            Return _2
        End Get
        Set(ByVal value As Integer)
            _2 = value
        End Set
    End Property

    Public Property Row3() As Integer
        Get
            Return _3
        End Get
        Set(ByVal value As Integer)
            _3 = value
        End Set
    End Property

    Public Property Row4() As Integer
        Get
            Return _4
        End Get
        Set(ByVal value As Integer)
            _4 = value
        End Set
    End Property

    Public Property Row5() As Integer
        Get
            Return _5
        End Get
        Set(ByVal value As Integer)
            _5 = value
        End Set
    End Property

    Public Property Row6() As Integer
        Get
            Return _6
        End Get
        Set(ByVal value As Integer)
            _6 = value
        End Set
    End Property

    Public Property Row7() As Integer
        Get
            Return _7
        End Get
        Set(ByVal value As Integer)
            _7 = value
        End Set
    End Property

    Public Property Row8() As Integer
        Get
            Return _8
        End Get
        Set(ByVal value As Integer)
            _8 = value
        End Set
    End Property

    Public Property Row9() As Integer
        Get
            Return _9
        End Get
        Set(ByVal value As Integer)
            _9 = value
        End Set
    End Property

    Public Property Row10() As Integer
        Get
            Return _10
        End Get
        Set(ByVal value As Integer)
            _10 = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Sub New()

        'Aqui se fijan las variables que personalizan el control
        Me.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        Me.MultiSelect = False
        Me.HideSelection = False
        Me.AllowColumnReorder = False
        Me.ListViewItemSorter = Lvs
        Me.View = Windows.Forms.View.Details
        Me.Width = 700
        Me.Height = 414
        Me.FullRowSelect = True

    End Sub

    Public Sub Actualizar(ByVal Cmd As SqlClient.SqlCommand, ByVal PK As String)
        'Aqui se obtiene la conexion del command
        Dim Cnn As SqlClient.SqlConnection = Cmd.Connection

        'Aqui se Abre la conexion
        Cnn.Open()

        'Aqui se quita el flitrado para poder actualizar
        Me.ListViewItemSorter = Lvs
        Me.Sorting = SortOrder.None
        Lvs.Order = SortOrder.None
        Lvs.SortColumn = Nothing

        'Aqui se actualiza la lista
        FuncionesGlobales.fn_CargaListaCMDtag(Cmd, Me, 0, PK)

        'Aqui se cierra la conexio
        Cnn.Close()

        'Aqui se ajustan las columnas al cambiar el tamaño de la ventana
        FuncionesGlobales.fn_Columna(Me, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10)
        Me.AllowColumnReorder = False
        'Aqui se llama al procedimiento actualizar para acciones
        'posteriores en la capa de presentacion
        RaiseEvent AlActualizar()

    End Sub

    Public Sub Actualizar(ByVal Tbl As DataTable, ByVal PK As String, Optional ByVal Hide() As String = Nothing)

        ''Aqui se quita el flitrado para poder actualizar
        'Me.ListViewItemSorter = Lvs
        'Me.Sorting = SortOrder.None
        'Lvs.Order = SortOrder.None
        'Lvs.SortColumn = Nothing

        ''Aqui se actualiza la lista
        'Me.Clear()
        'For Each col As DataColumn In Tbl.Columns
        '    If Not col.ColumnName.ToUpper = PK.ToUpper And ((Hide IsNot Nothing AndAlso Array.IndexOf(Hide, col.ColumnName) < 0) Or Hide Is Nothing) Then
        '        Dim Tc As ColumnHeader = Me.Columns.Add(col.ColumnName)
        '        If (col.DataType Is GetType(Integer)) Or (col.DataType Is GetType(Decimal)) Then
        '            Tc.TextAlign = HorizontalAlignment.Right
        '        Else
        '            Tc.TextAlign = HorizontalAlignment.Left
        '        End If
        '    End If
        'Next

        'For Each row As DataRow In Tbl.Rows
        '    Dim Tag As Integer = row.Item(PK.ToUpper)
        '    Dim Arr As New List(Of String)
        '    For I As Integer = 0 To row.ItemArray.Count - 1
        '        If Not Array.IndexOf(row.ItemArray, row.Item(PK.ToUpper)) = I And ((Hide IsNot Nothing AndAlso Array.IndexOf(Hide, Tbl.Columns(I).ColumnName.ToUpper) < 0) Or Hide Is Nothing) Then
        '            If Tbl.Columns(I).DataType Is GetType(Date) Then
        '                Arr.Add(CType(row.Item(I), Date).ToShortDateString)
        '            Else
        '                Arr.Add(row.Item(I))
        '            End If

        '        End If
        '    Next
        '    Me.Items.Add(New ListViewItem(Arr.ToArray) With {.Tag = Tag})
        'Next


        ''Aqui se ajustan las columnas al cambiar el tamaño de la ventana
        'FuncionesGlobales.fn_Columna(Me, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10)

        ''Aqui se llama al procedimiento actualizar para acciones
        ''posteriores en la capa de presentacion
        'RaiseEvent AlActualizar()

        'Aqui se obtiene la conexion del command

        'Aqui se quita el flitrado para poder actualizar
        Me.ListViewItemSorter = Lvs
        Me.Sorting = SortOrder.None
        Lvs.Order = SortOrder.None
        Lvs.SortColumn = Nothing

        'Aqui se actualiza la lista
        FuncionesGlobales.fn_CargaListaDataTableTag(Tbl, Me, 0, PK)

        'Aqui se cierra la conexio


        'Aqui se ajustan las columnas al cambiar el tamaño de la ventana
        FuncionesGlobales.fn_Columna(Me, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10)

        'Aqui se llama al procedimiento actualizar para acciones
        'posteriores en la capa de presentacion
        RaiseEvent AlActualizar()

    End Sub

#End Region

#Region "Eventos Manejados"

    Private Sub cp_Listview_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Me.ColumnClick
        If Me.Items.Count = 0 Then Exit Sub

        Me.ListViewItemSorter = Lvs

        'Aqui se reordenan las columnas del listview
        If e.Column = Lvs.SortColumn Then
            If Lvs.Order = Windows.Forms.SortOrder.Descending Then
                Lvs.Order = Windows.Forms.SortOrder.Ascending
            Else
                Lvs.Order = Windows.Forms.SortOrder.Descending
            End If
        Else
            Lvs.SortColumn = e.Column
            Lvs.Order = Windows.Forms.SortOrder.Ascending
        End If

        Me.Sort()

    End Sub

    Private Sub cp_Listview_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles Me.ColumnWidthChanging
        'Bloquea las columnas ocultas evitando que se muestren (width=0)      

        Dim x As Byte = Me.Columns.Count
        Dim Columnas(x) As Byte

        If Me.Columns(e.ColumnIndex).Width = 0 Then
            e.Cancel = True
            e.NewWidth = Me.Columns(e.ColumnIndex).Width
        ElseIf Me.Columns(e.ColumnIndex).Width <= 20 Then
            e.Cancel = True
            e.NewWidth = 100
        End If

    End Sub

    Private Sub cp_Listview_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Aqui se ajustan las columnas al cambiar el tamaño de la ventana
        FuncionesGlobales.fn_Columna(Me, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10)
    End Sub

#End Region

End Class
