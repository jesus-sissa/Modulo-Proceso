Imports Modulo_Proceso.Cn_Datos
Imports Modulo_Proceso.FuncionesGlobales

Public Class Cn_Presentaciones

#Region "Ver Presentaciones"

    Public Shared Function fn_VerPresentaciones_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cap_Presentaciones_GetXmodulo", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Try
            lsv.Actualizar(Cmd, "Id_Presentacion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VerPresentacionesI_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Presentacion As Integer) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cap_PresentacionesI_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Presentacion", SqlDbType.Int, Id_Presentacion)
        Try
            lsv.Actualizar(Cmd, "Id_Presentacion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VerPresentacionesImg_Consultar(ByVal Id_Presentacion As Integer) As DataTable
        Dim Dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cap_PresentacionesI_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Presentacion", SqlDbType.Int, Id_Presentacion)
        Try
            Dt = Cn_Datos.EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

End Class
