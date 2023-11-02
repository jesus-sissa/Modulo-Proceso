Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Imports System.Collections

Public Class Cn_Datos

    Public Shared Function Crea_Conexion(ByVal cadena As String) As SqlConnection
        Dim Cone As SqlConnection = New SqlConnection(cadena)
        Return Cone
    End Function

    Public Shared Function Crea_ConexionSTD() As SqlConnection
        Dim Cone As SqlConnection = New SqlConnection(Cnx_Datos)
        Return Cone
    End Function

    Public Shared Function crear_Trans(ByVal cn As SqlConnection) As SqlTransaction
        cn.Open()
        Dim tr As SqlTransaction = cn.BeginTransaction()
        Return tr
    End Function

    Public Shared Function Crea_Comando(ByVal Consulta As String, ByVal Tipo As CommandType, ByVal cone As SqlConnection) As SqlCommand
        Dim Com As SqlCommand = New SqlCommand(Consulta, cone)
        Com.CommandType = Tipo
        Return Com
    End Function

    Public Shared Function Crea_ComandoT(ByVal cn As SqlConnection, ByVal tr As SqlTransaction, ByVal Tipo As CommandType, ByVal Texto As String) As SqlCommand
        Dim cmd As String = Texto
        Dim comandoSQL As New SqlCommand(cmd, cn, tr)
        comandoSQL.CommandType = Tipo
        Return comandoSQL
    End Function

    Public Shared Function EjecutaConsulta(ByVal command As SqlCommand) As DataTable
        Dim tabla As DataTable
        Try
            command.Connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            tabla = New DataTable()
            tabla.Load(reader)
            reader.Close()
            command.Connection.Close()
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
        Finally
            command.Connection.Close()
        End Try
        Return tabla
    End Function

    Public Shared Function EjecutaConsultaT(ByVal command As SqlCommand) As DataTable
        Dim tabla As DataTable
        Try
            'command.Connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            tabla = New DataTable()
            tabla.Load(reader)
            reader.Close()
            'command.Connection.Close()
        Catch ex As Exception
            Throw ex
        Finally
            'command.Connection.Close()
        End Try
        Return tabla
    End Function

    Public Shared Function EjecutarNonQuery(ByVal command As SqlCommand) As Integer
        Dim renglonesAfectados As Integer = -1
        Try
            command.Connection.Open()
            renglonesAfectados = command.ExecuteNonQuery()
        Catch ex1 As Exception
            Throw ex1
        Finally
            command.Connection.Close()
        End Try
        Return renglonesAfectados
    End Function

    Public Shared Function EjecutarNonQueryT(ByVal command As SqlCommand) As Integer
        Dim renglonesAfectados As Integer = -1
        Try
            renglonesAfectados = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            'command.Connection.Close();
        Finally

        End Try
        Return renglonesAfectados
    End Function

    Public Shared Function EjecutarScalarT(ByVal command As SqlCommand) As Integer
        Dim Identidad As Object = ""
        Try
            Identidad = command.ExecuteScalar()
        Catch ex As Exception
            Throw ex
            'command.Connection.Close();
        Finally
        End Try
        Return Convert.ToInt32(Identidad)
    End Function

    Public Shared Function EjecutarScalar(ByVal command As SqlCommand) As Object
        Dim valorObtenido As Object = ""

        Try
            command.Connection.Open()
            valorObtenido = command.ExecuteScalar()
        Catch ex As Exception
            Throw ex
        Finally
            command.Connection.Close()
        End Try
        Return valorObtenido
    End Function

    Public Shared Function Crea_Parametro(ByRef cm As SqlCommand, ByVal Nombre As String, ByVal Tipo As SqlDbType, ByVal Valor As Object, Optional ByVal Mayusculas As Boolean = True) As SqlParameter
        Dim Para As New SqlParameter()
        Para = cm.CreateParameter()
        Para.ParameterName = Nombre
        Para.SqlDbType = Tipo

        Select Case Tipo
            Case SqlDbType.Int
                Para.Value = Integer.Parse(Valor.ToString())
            Case SqlDbType.Decimal
                Para.Value = Decimal.Parse(Valor.ToString())
            Case SqlDbType.BigInt
                Para.Value = Long.Parse(Valor.ToString())
            Case SqlDbType.VarChar
                If Mayusculas Then
                    Para.Value = Valor.ToString().Trim.ToUpper()
                Else
                    Para.Value = Valor.ToString().Trim
                End If
            Case SqlDbType.Text
                If Mayusculas Then
                    Para.Value = Valor.ToString().Trim.ToUpper()
                Else
                    Para.Value = Valor.ToString().Trim
                End If
            Case SqlDbType.Money
                Para.Value = Double.Parse(Valor.ToString())
            Case SqlDbType.DateTime
                Para.Value = CDate(Valor.ToString())
            Case SqlDbType.Date
                Para.Value = CDate(Valor.ToString())
            Case SqlDbType.Time
                Para.Value = Valor.ToString.Trim
            Case SqlDbType.Image
                Para.Value = Valor
            Case Else
                Para.Value = Valor
        End Select
        cm.Parameters.Add(Para)
        Return Para
    End Function

End Class
