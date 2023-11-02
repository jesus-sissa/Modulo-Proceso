Imports System.Data.SqlClient
Imports Modulo_Proceso.Cn_Datos
Imports Modulo_Proceso.FuncionesGlobales

Public Class cp_cmb_SimpleFiltradoParam
    Inherits cp_Combobox

    'Varchar = 0
    'Integer = 1
    'Fecha = 2
    'Long=3
#Region "Eventos"
    Public Event SeleccionManual(ByVal Id As Integer)
#End Region

#Region "Variables Privadas"

    Private Tbl As DataTable

    Private _StoredProcedure As String

    Private _Sucursal As Boolean = False

    Private _Empresa As Boolean = False

    Private _Pista As Boolean = True

    Private WithEvents _Filtro As TextBox

    Private _Clave As String

    Private _Actualizar As Boolean = True

    Private _Tipo As Integer = 0

    Private Parametros As DataTable


#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Indica si se envia o no el parametro  @Pista
    ''' </summary>
    Public Property Pista() As Boolean
        Get
            Return _Pista
        End Get
        Set(ByVal value As Boolean)
            _Pista = value
        End Set
    End Property

    ''' <summary>
    ''' Indica si se va a enviar la variable global Empresa al StoredProcedure
    ''' </summary>
    Public Property Empresa() As Boolean
        Get
            Return _Empresa
        End Get
        Set(ByVal value As Boolean)
            _Empresa = value
        End Set
    End Property

    ''' <summary>
    ''' Indica si se va a enviar o no la variable global sucursal al stored procedure
    ''' </summary>
    Public Property Sucursal() As Boolean
        Get
            Return _Sucursal
        End Get
        Set(ByVal value As Boolean)
            _Sucursal = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
        End Set
    End Property

    Public Property StoredProcedure() As String
        Get
            Return _StoredProcedure
        End Get
        Set(ByVal value As String)
            _StoredProcedure = value
        End Set
    End Property

    Public Property Filtro() As TextBox
        Get
            Return _Filtro
        End Get
        Set(ByVal value As TextBox)
            _Filtro = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Actualiza el contenido del combo utilizando el stored procedure
    ''' </summary>
    ''' <remarks>'si requiere la sucursal hay que marcar sucursal como true</remarks>
    Public Sub Actualizar()
        If StoredProcedure = "" Then MsgBox("Debe asignar la propiedad stored procedure al elemento " & Me.Name, MsgBoxStyle.Critical, frm_MENU.Text)
        Tbl = CreaTabla()
        fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
        Me.MaxDropDownItems = 20
    End Sub

    'Public Sub Actualizar(ByVal Source As DataTable)
    '    If Tbl IsNot Nothing Then Tbl.Clear()
    '    Tbl = Source.Copy
    '    If Tbl.Rows.Count > 0 Then
    '        If Tbl(0).Item(DisplayMember) = "Seleccione..." Then Tbl.Rows(0).Delete()
    '    End If
    '    fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
    'End Sub

    Public Sub AgregaParametro(ByVal param As String, ByVal valor As String, ByVal Tipo As Integer)
        Dim dr_P As DataRow
        dr_P = Parametros.NewRow

        dr_P("Parametro") = param
        dr_P("Valor") = valor
        dr_P("TipoD") = Tipo
        Parametros.Rows.Add(dr_P)

    End Sub
    Public Sub LimpiarParametros()
        Parametros.Clear()
    End Sub

    Public Sub ActualizaValorParametro(ByVal param As String, ByVal valor As String)
        Dim dr_P As DataRow

        For Each dr_P In Parametros.Rows

            If dr_P("Parametro") = param Then
                dr_P("Valor") = valor
            End If
        Next

    End Sub


#End Region

#Region "Funciones"

    Function CreaTabla() As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando(_StoredProcedure, CommandType.StoredProcedure, Cnn)
        Dim dr_P As DataRow
        If _Pista Then Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        If _Sucursal Then Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        If _Empresa Then Crea_Parametro(Cmd, "@Id_Empresa", SqlDbType.Int, EmpresaId)
        If _Tipo > 0 Then Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, _Tipo)

        If Parametros.Rows.Count > 0 Then

            For Each dr_P In Parametros.Rows
                Select Case dr_P("TipoD")

                    Case 0
                        Crea_Parametro(Cmd, dr_P("Parametro").ToString(), SqlDbType.VarChar, dr_P("Valor").ToString())
                    Case 1
                        Crea_Parametro(Cmd, dr_P("Parametro").ToString(), SqlDbType.Int, dr_P("Valor").ToString())
                    Case 2
                        Crea_Parametro(Cmd, dr_P("Parametro").ToString(), SqlDbType.DateTime, dr_P("Valor").ToString())
                    Case 3
                        Crea_Parametro(Cmd, dr_P("Parametro").ToString(), SqlDbType.BigInt, dr_P("Valor").ToString())

                End Select

            Next

        End If

        Return EjecutaConsulta(Cmd)

    End Function

#End Region

#Region "Eventos Manejados"

    ''' <summary>
    ''' busca el valor del textbox en la columna clave
    ''' </summary>
    Private Sub _Filtro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _Filtro.TextChanged
        If Not _Filtro.Text = "" Then
            If Not Tbl Is Nothing Then
                For Each element As DataRow In Tbl.Rows
                    If element(Clave) = _Filtro.Text Then
                        Me.SelectedIndex = Tbl.Rows.IndexOf(element)
                        Exit Sub
                    End If
                Next
                Me.SelectedIndex = 0
            End If
        End If

    End Sub

    ''' <summary>
    ''' escribe en el filtro el numero de clave que se ha seleccionado
    ''' </summary>
    Private Sub cp_cmb_SimpleFiltrado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
        If _Filtro Is Nothing Then Exit Sub
        If Not _Filtro.Focused Then
            _Filtro.Text = Tbl.Rows(Me.SelectedIndex)(Clave)
            RaiseEvent SeleccionManual(Me.SelectedValue)
        End If
    End Sub

#End Region

    Public Sub New()

        Parametros = New DataTable
        Parametros.Columns.Add("Parametro")
        Parametros.Columns.Add("Valor")
        Parametros.Columns.Add("TipoD")

    End Sub
End Class

