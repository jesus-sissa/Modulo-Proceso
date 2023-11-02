Imports System.Data.SqlClient
Imports Modulo_Proceso.Cn_Datos
Imports Modulo_Proceso.FuncionesGlobales

''' <summary>
''' Es un combobox que se alimenta de un storedprocedure solamente especificando @Pista = '', puede o no alimentar una variable global
''' </summary>
''' <remarks></remarks>
Public Class cp_cmb_Simple
    Inherits cp_Combobox

#Region "Variables Privadas"

    Private Tbl As DataTable

    Private _StoredProcedure As String

    Private _Sucursal As Boolean = False

    Private _Empresa As Boolean = False

    Private _Pista As Boolean = True

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

    ''' <summary>
    ''' Es el stored procedure del que se va a alimentar el combobox
    ''' </summary>
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
        If StoredProcedure = "" Then MsgBox("Debe asignar la propiedad stored procedure al elemento " & Me.Name, MsgBoxStyle.Critical, frm_MENU.Text)
        Tbl = CreaTabla()
        fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
        Me.MaxDropDownItems = 20
    End Sub

    Public Sub Actualizar(ByVal Tbl As DataTable)
        fn_CargaCombo(Me, Tbl, ValueMember, DisplayMember)
    End Sub
#End Region

#Region "Funciones"

    Private Function CreaTabla() As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando(_StoredProcedure, CommandType.StoredProcedure, Cnn)
        If _Pista Then Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
        If _Sucursal Then Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        If _Empresa Then Crea_Parametro(Cmd, "@Id_Empresa", SqlDbType.Int, EmpresaId)

        Return EjecutaConsulta(Cmd)
    End Function

#End Region

End Class
