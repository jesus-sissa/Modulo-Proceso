Imports System.Data.SqlClient
Imports Modulo_Proceso.Cn_Datos
Imports Modulo_Proceso.FuncionesGlobales

Public Class cp_cmb_Parametro
    Inherits cp_Combobox

#Region "Variables Privadas"

    Private Tbl As DataTable

    Private _StoredProcedure As String

    Private _NombreParametro As String

    Private _ValorParametro As Object

    Private _Tipodedatos As System.Data.SqlDbType

    Private _Sucursal As Boolean = False

    Private _Empresa As Boolean = False

    Private _Cia As Boolean = False

    Private _Pista As Boolean = True

#End Region

#Region "Propiedades"

    Public Property Cia() As Boolean
        Get
            Return _Cia
        End Get
        Set(ByVal value As Boolean)
            _Cia = value
        End Set
    End Property

    Public Property Pista() As Boolean
        Get
            Return _Pista
        End Get
        Set(ByVal value As Boolean)
            _Pista = value
        End Set
    End Property

    Public Property Sucursal() As Boolean
        Get
            Return _Sucursal
        End Get
        Set(ByVal value As Boolean)
            _Sucursal = value
        End Set
    End Property

    Public Property Empresa() As Boolean
        Get
            Return _Empresa
        End Get
        Set(ByVal value As Boolean)
            _Empresa = value
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

    Public Property NombreParametro() As String
        Get
            Return _NombreParametro
        End Get
        Set(ByVal value As String)
            _NombreParametro = value
        End Set
    End Property

    Public Property ValorParametro() As Object
        Get
            Return _ValorParametro
        End Get
        Set(ByVal value As Object)
            _ValorParametro = value
        End Set
    End Property

    Public Property Tipodedatos() As System.Data.SqlDbType
        Get
            Return _Tipodedatos
        End Get
        Set(ByVal value As System.Data.SqlDbType)
            _Tipodedatos = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Actualiza el contenido del combo utilizando el stored procedure
    ''' </summary>
    ''' <remarks>'si requiere la sucursal hay que marcar sucursal como true</remarks>
    Public Sub Actualizar()
        If _ValorParametro Is Nothing Then Exit Sub
        If StoredProcedure = "" Then MsgBox("Debe asignar la propiedad stored procedure al elemento " & Me.Name, MsgBoxStyle.Critical, frm_MENU.Text)

        Try
            Tbl = CreaTabla()
            fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
            Me.MaxDropDownItems = 20
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Exit Sub
        End Try
    End Sub

#End Region

#Region "Funciones"

    ''' <summary>
    ''' Crea una tabla basada en las propiedades del combo
    ''' </summary>
    ''' <returns>Es la tabla resultante de la funcion ejecutaconsulta</returns>
    ''' <remarks>Esta funcion es global</remarks>
    Private Function CreaTabla() As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando(_StoredProcedure, CommandType.StoredProcedure, Cnn)
        If _Pista Then Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        If Not NombreParametro = "" Then Crea_Parametro(Cmd, _NombreParametro, _Tipodedatos, _ValorParametro)
        If _Sucursal Then Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        If _Empresa Then Crea_Parametro(Cmd, "@Id_Empresa", SqlDbType.Int, EmpresaId)
        If _Cia Then Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)

        Try
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetSource() As DataTable
        Return Tbl
    End Function

#End Region

End Class
