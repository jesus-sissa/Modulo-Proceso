Imports Modulo_Proceso.FuncionesGlobales
Imports Modulo_Proceso.Cn_Datos
Imports System.Data.SqlClient

Public Class Cn_Actualizaciones

#Region "Actualizaciones"

    Public Shared Function fn_Actualizaciones_LlenarLista(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Usr_Actualizaciones_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Try
            lsv.Actualizar(cmd, "Id_Actualizacion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Actualizaciones_Read(ByVal Id_Actualizacion As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Usr_Actualizaciones_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Actualizacion", SqlDbType.VarChar, Id_Actualizacion)
        Try
            Dim dt As DataTable
            dt = Cn_Datos.EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

End Class
