Imports System.Data.SqlClient
Imports Modulo_Proceso.Cn_Datos
Imports Modulo_Proceso.FuncionesGlobales

Public Class cp_cmb_SimpleParametros
    Inherits cp_Combobox

#Region "Variables Privadas"

    Private Tbl As DataTable

    Private _StoredProcedure As String

    Private _Sucursal As Boolean = False

    Private _Pista As Boolean = True

    Private _Cia As Boolean = False

    Private Cmd As SqlCommand = Crea_Comando(_StoredProcedure, CommandType.StoredProcedure, Nothing)

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

    Public Property StoredProcedure() As String
        Get
            Return _StoredProcedure
        End Get
        Set(ByVal value As String)
            _StoredProcedure = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Actualiza el contenido del combo utilizando el stored procedure
    ''' </summary>
    ''' <remarks>'si requiere la sucursal hay que marcar sucursal como true</remarks>
    Public Sub Actualizar()
        If Not _StoredProcedure = "" Then
            Tbl = CreaTabla()
            fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
            Me.MaxDropDownItems = 20
        End If
    End Sub

    ''' <summary>
    ''' Quita todos los parametros del procedimiento almacenado
    ''' </summary>
    Public Sub LimpiarParametros()
        Cmd.Parameters.Clear()
    End Sub

    ''' <summary>
    ''' Agrega un nuevo parametro a la consulta
    ''' </summary>
    ''' <param name="Nombre">Es el nombre del parametro</param>
    ''' <param name="tipo">Es el tipo de datos de sql</param>
    ''' <param name="valor">Es el valor del parametro</param>
    Public Sub AgregarParametros(ByVal Nombre As String, ByVal tipo As SqlDbType, ByVal valor As Object)
        Crea_Parametro(Cmd, Nombre, tipo, valor)
    End Sub

#End Region

#Region "Funciones"

    Private Function CreaTabla() As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Cmd.Connection = Cnn
        Cmd.CommandText = _StoredProcedure
        Cmd.CommandType = CommandType.StoredProcedure
        If _Pista Then Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        If _Sucursal Then Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        If _Cia Then Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)

        Return EjecutaConsulta(Cmd)
    End Function

#End Region

End Class