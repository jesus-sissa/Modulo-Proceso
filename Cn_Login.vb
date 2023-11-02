Imports System.Collections
Imports System.Windows.Forms

Public Class Cn_Login

    Public Shared Function UsuarioClave_Consultar(ByVal clave As String) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_UsuariosClave_Read", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Empleado", SqlDbType.VarChar, clave)
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function Usuarios_Read(ByVal Id As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_UsuariosLogin_Read", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.BigInt, Id)
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function Permisos_Read(ByVal Id As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Permisos_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.BigInt, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function PermisosControles_Read(ByVal Id As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_PermisosControles_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.BigInt, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function Usuarios_Bloquear(ByVal Id As Integer) As Integer
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Usuarios_Status", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.BigInt, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")

            Dim valor As Integer = Cn_Datos.EjecutarNonQuery(Cmd)
            Return valor
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function Login_Insertar() As Integer
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Login_Create", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.BigInt, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.BigInt, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
            Cn_Datos.Crea_Parametro(Cmd, "@Version", SqlDbType.VarChar, ModuloVersion)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Bloqueo", SqlDbType.Int, TipoBloqueo)

            Dim valor As Integer = Cn_Datos.EjecutarScalar(Cmd)
            Return valor
        Catch Ex As Exception
            FuncionesGlobales.TrataEx(Ex)
            Return 0
        End Try
    End Function

    Public Shared Function Login_CerrarSesion() As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Login_CierraSesion", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Login", SqlDbType.Int, LoginId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)

            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            FuncionesGlobales.TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function UsuariosContra_Update(ByVal Id_Usuario As Integer, ByVal Contra As String) As Integer
        Dim Valor As Integer
        Dim tr As SqlClient.SqlTransaction
        Dim Cnn As SqlClient.SqlConnection
        Dim Cmd As SqlClient.SqlCommand
        Dim Id_Contra As Integer = 0
        Try
            Cnn = Cn_Datos.Crea_ConexionSTD
            tr = Cn_Datos.crear_Trans(Cnn)
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Usr_Contras_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Usuario)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(Cmd, "@Contra", SqlDbType.VarChar, Contra)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
            Cn_Datos.Crea_Parametro(Cmd, "@Modulo_Version", SqlDbType.VarChar, ModuloVersion)

            Id_Contra = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Usr_UsuariosContra_Update")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.BigInt, Id_Usuario)
            Cn_Datos.Crea_Parametro(Cmd, "@Contra", SqlDbType.VarChar, Contra)

            valor = Cn_Datos.EjecutarNonQueryT(Cmd)
        Catch ex As Exception
            tr.Rollback()
            Cmd.Dispose()
            FuncionesGlobales.TrataEx(ex)
        End Try
        tr.Commit()
        Cmd.Dispose()
        Return valor
    End Function

    Public Shared Function UsuariosContra_Consultar10(ByVal Id As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Contras_Get10", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function Usuarios_Horas(ByVal Id_Empleado As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_UsuariosHoras_Read", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.BigInt, Id_Empleado)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
        If Tbl.Rows.Count > 0 Then
            Tbl.Dispose()
            Return True
        Else
            Tbl.Dispose()
            Return False
        End If

    End Function

    Public Shared Function Empresas_Consultar() As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empresas_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function Sucursales_Consultar(ByVal Id_Empresa As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_SucursalesEmpresa_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empresa", SqlDbType.VarChar, Id_Empresa)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function GetSession() As Integer
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_Sesion_GetActiva", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Return Cn_Datos.EjecutarScalar(cmd)
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_ObtenTurno() As Integer
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Turnos_ActualGet", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.BigInt, SucursalId)

            Return Cn_Datos.EjecutarScalar(Cmd)
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return 0
        End Try

    End Function

    Public Shared Function fn_ObtenTipoMoneda(ByVal IdMoneda As Integer) As String

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Monedas_ReadTipoCambio", CommandType.StoredProcedure, Cnn)
            Dim dt_lc As New DataTable

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.BigInt, IdMoneda)

            dt_lc = Cn_Datos.EjecutaConsulta(Cmd)

            If dt_lc.Rows.Count > 0 Then
                Return (dt_lc.Rows(0)(1).ToString)
            Else
                Return ""
            End If
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return ""
        End Try
    End Function

    Public Shared Function fn_Login_Read(ByVal Id_Login As Integer) As DataTable

        Dim CmD1 As New SqlClient.SqlCommand
        Dim Dt As DataTable

        Try
            CmD1 = Cn_Datos.Crea_Comando("Usr_Login_Read", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(CmD1, "@Id_Login", SqlDbType.BigInt, Id_Login)

            Dt = Cn_Datos.EjecutaConsulta(CmD1)

            Return Dt
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ValidaSesion(ByVal Id_Login As Integer) As Boolean
        Dim Dt As DataTable = fn_Login_Read(Id_Login)
        If Dt IsNot Nothing Then
            If Dt.Rows.Count > 0 Then
                If Dt.Rows(0)("Status") = "A" Then
                    Return True
                Else
                    MsgBox("Su Sesión ha expirado ya que usted inició Sesión en Otra estación de Trabajo:" & Chr(13) & Chr(13) & "Estación: " & Dt.Rows(0)("Estacion_Cierre") & Chr(13) & "Hora: " & Dt.Rows(0)("Fecha_Cierre") & Chr(13) & Chr(13) & "Por Seguridad el sistema se cerrará...", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If
            End If
        End If
        MsgBox("Su Sesión no se ha podido validar. Es probable que haya problemas de comunicación con el Servidor." & Chr(13) & Chr(13) & "Por Seguridad el sistema se cerrará...", MsgBoxStyle.Critical, frm_MENU.Text)
        Return False
    End Function

    Public Shared Function fn_Log_Create(ByVal Descripcion As String) As Boolean
        Dim CmD As New SqlClient.SqlCommand
        Dim Id_Log As Integer
        Try
            CmD = Cn_Datos.Crea_Comando("Usr_Log_Create", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(CmD, "@Id_Empleado", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(CmD, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
            Cn_Datos.Crea_Parametro(CmD, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Cn_Datos.Crea_Parametro(CmD, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(CmD, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
            Cn_Datos.Crea_Parametro(CmD, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
            Cn_Datos.Crea_Parametro(CmD, "@Modulo_Version", SqlDbType.VarChar, ModuloVersion)
            Cn_Datos.Crea_Parametro(CmD, "@Id_Login", SqlDbType.Int, LoginId)

            Id_Log = Cn_Datos.EjecutarScalar(CmD)

            Return Id_Log > 0
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function Programadores_Get() As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Programadores_Get", CommandType.StoredProcedure, Cnn)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return Tbl
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function ParametrosGlobales_Leer() As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ParametrosG_Read", CommandType.StoredProcedure, Cnn)

            Return Cn_Datos.EjecutaConsulta(Cmd)

        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

#Region "Auditoria de Software"

    Public Shared Function fn_Software_Existe() As Boolean
        Try
            'Solo regresa falso cuando se hizo  bien la consulta y 
            'la cantidad de filas es = 0
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("usr_EstacionSoftware_Existe", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl IsNot Nothing Then
                If Tbl.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If

        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return True
        End Try
    End Function

    Public Shared Function fn_Software_Create() As Boolean
        Dim Lista(1) As String
        Dim Contador As Integer = 0
        Try
            'Buscar los Programas instalados
            Using uninstalled As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
                For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                    Using key As Microsoft.Win32.RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                        Dim Dname As String = Convert.ToString(key.GetValue("DisplayName"))
                        If Not String.IsNullOrEmpty(Dname) Then
                            If InStr(1, Dname.ToUpper, "ACTUALIZACIÓN DE SEGURIDAD") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "SECURITY UPDATE") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "ACTUALIZACIÓN PARA") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "UPDATE FOR") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "ACTUALIZACIÓN CRÍTICA") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "CRITICAL UPDATE") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "HOTFIX") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "REVISIÓN PARA") > 0 Then
                                Continue For
                            ElseIf InStr(1, Dname.ToUpper, "REVISION FOR") > 0 Then
                                Continue For
                            Else
                                ReDim Preserve Lista(Contador)
                                Lista(Contador) = Dname.ToUpper
                                Contador += 1
                            End If
                        End If
                    End Using
                Next
            End Using
            If Contador = 0 Then
                Return False
                Exit Function
            End If

        Catch ex As Exception
            frm_MENU.prg_Barra.Value = 0
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try

        frm_MENU.prg_Barra.Value = 0
        frm_MENU.prg_Barra.Maximum = Contador + 1
        Dim Cnn As SqlClient.SqlConnection
        Dim Tr As SqlClient.SqlTransaction
        Dim CmD As SqlClient.SqlCommand
        Dim Id_EstacionS As Integer

        Try
            'Guardar en la BD
            Cnn = Cn_Datos.Crea_ConexionSTD
            Tr = Cn_Datos.crear_Trans(Cnn)
            'Insertar la Cabecera
            CmD = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Usr_EstacionSoftware_Create")
            Cn_Datos.Crea_Parametro(CmD, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(CmD, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(CmD, "@Usuario_Firmado", SqlDbType.Int, UsuarioId)
            Id_EstacionS = Cn_Datos.EjecutarScalarT(CmD)
            'Insertar el Detalle
            For i As Integer = 0 To Contador - 1
                CmD.Parameters.Clear()
                CmD = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Usr_EstacionSoftwareD_Create")
                Cn_Datos.Crea_Parametro(CmD, "@Id_EstacionS", SqlDbType.VarChar, Id_EstacionS)
                Cn_Datos.Crea_Parametro(CmD, "@Software", SqlDbType.VarChar, Lista(i))

                Cn_Datos.EjecutarNonQueryT(CmD)
                frm_MENU.prg_Barra.Value += 1
            Next i
            Tr.Commit()
            CmD.Dispose()
            Cnn.Dispose()
            frm_MENU.prg_Barra.Value = 0
            Return True
        Catch ex As Exception
            Tr.Rollback()
            CmD.Dispose()
            Cnn.Dispose()
            frm_MENU.prg_Barra.Value = 0
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Verificar Licenciamiento"
    Public Shared Function fn_ObtieneValoresLicencia() As Integer

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ParametrosG_Read", CommandType.StoredProcedure, Cnn)
        Dim dt_Valores As DataTable

        Try
            '------------------------------------
            dt_Valores = Cn_Datos.EjecutaConsulta(cmd)

            If dt_Valores Is Nothing OrElse dt_Valores.Rows.Count = 0 Then
                Return 0
            End If

            '---Recuperar Valores---       'filas y columnas
            Dim Cadena1() As Array = {New Integer() {3, 7, 10, 12, 16, 18, 21, 27}, _
                                          New Integer() {5, 8, 12, 16, 22, 30, 32, 39}, _
                                          New Integer() {6, 15}}

            Dim ValoresCadena() As String = {Cn_Encripta.fn_Decode(dt_Valores.Rows(0)("S_Empresa").ToString), _
                                          Cn_Encripta.fn_Decode(dt_Valores.Rows(0)("E_Local").ToString), _
                                          Cn_Encripta.fn_Decode(dt_Valores.Rows(0)("Path").ToString)}

            Dim ValoresFinales() As String = {"", "", ""}

            Dim Val_Final As String = ""
            Dim Letra As Byte = 0

            '---------------------
            For i As Byte = 0 To Cadena1.Length - 1

                '---------------------
                For j As Byte = 0 To Cadena1(i).Length - 1
                    Letra = Cadena1(i).GetValue(j) '3,7,10
                    'recoorre la cadena hash
                    For k As Byte = 0 To ValoresCadena(i).Length - 1

                        If k = Letra Then
                            Val_Final += ValoresCadena(i)(Letra - 1).ToString

                            Exit For
                        End If

                    Next k
                    '-------------------hash
                Next j
                ValoresFinales(i) = Val_Final
                Val_Final = ""
                '--------------------
            Next i
            '-----------Iniciar el proceso de validacion-----
            Dim MxUsrL As Integer = ValoresFinales(0).Substring(0, 4)
            Dim MxUsrM As Integer = ValoresFinales(0).Substring(4, 4)
            Dim ExpDat As String = FuncionesGlobales.fn_Fecha102((ValoresFinales(1).Insert(2, "/")).Insert(5, "/"))
            Dim HrsMxSes As Byte = ValoresFinales(2)

            '-- Valida la fecha Expira de la Licencia ----
            If ExpDat.Trim <= dt_Valores.Rows(0)("Fecha").ToString.Trim Then
                dt_Valores.Dispose()
                Return 1 'Fecha Expirada
            End If
            dt_Valores.Dispose()
            '---------Cierra Sesiones Colgadas
            cmd = Cn_Datos.Crea_Comando("Usr_Login_CierraSesionGeneral", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
            Cn_Datos.Crea_Parametro(cmd, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@MaxHorasesion", SqlDbType.TinyInt, HrsMxSes)

            Cn_Datos.EjecutarNonQuery(cmd)

            '--------Cuenta USuarios Activos Locales(L) o Moviles(M)
            cmd.Parameters.Clear()
            cmd = Cn_Datos.Crea_Comando("Usr_Login_CuentaSesiones", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Usuario", SqlDbType.VarChar, "L")
            Dim TotalL As Integer = Cn_Datos.EjecutarScalar(cmd)

            If TotalL >= MxUsrL Then
                Return 2 'MAximo usuarios locales
            End If

            Return 9    ' <> de -1 a 2 kiere decir que no hay falla alguna

        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)

            Return -1 'error
        End Try

    End Function

#End Region

#Region "Verificar Licenciamiento2014"

    Public Shared Function fn_ObtieneValoresLicencia2014() As Integer

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ParametrosG_Read", CommandType.StoredProcedure, Cnn)

        Try
            Dim dt_Valores As DataTable = Cn_Datos.EjecutaConsulta(cmd)
            If dt_Valores Is Nothing OrElse dt_Valores.Rows.Count = 0 Then
                dt_Valores.Dispose()
                Return 0
            End If

            '-Verificar que no haya campos Vacios
            If dt_Valores.Rows(0)("S_Empresa") = "" OrElse dt_Valores.Rows(0)("E_Local") = "" _
                OrElse dt_Valores.Rows(0)("Path") = "" OrElse dt_Valores.Rows(0)("R_Empresa") = "" _
                OrElse dt_Valores.Rows(0)("MasterEmpresa") = "" OrElse dt_Valores.Rows(0)("SlaveEmpresa") = "" Then
                dt_Valores.Dispose()
                Return 0
            End If

            '----Verificar Servidor y Base de Datos 1Septiembre-2014
            Dim Regsvr As String = Cn_Encripta.fn_Decode(dt_Valores(0)("MasterEmpresa").ToString)
            Dim Regbdd As String = Cn_Encripta.fn_Decode(dt_Valores(0)("SlaveEmpresa").ToString)
            Dim NombreServer As String = ObtenerCadena(Regsvr)
            Dim NombreBDD As String = ObtenerCadena(Regbdd)

            If Cnn.DataSource.ToString.ToUpper <> NombreServer.ToUpper OrElse Cnn.Database.ToString.ToUpper <> NombreBDD.ToUpper Then
                dt_Valores.Dispose()
                Return 3 ' Servidor y/o BDD Diferentes al Registrado en la Licencia
            End If

            '---Recuperar Valores---       'filas y columnas
            Dim Cadena1() As Array = {New Integer() {3, 7, 10, 12, 16, 18, 21, 27}, _
                                      New Integer() {5, 8, 12, 16, 22, 30, 32, 39}, _
                                      New Integer() {6, 15}}

            Dim ValoresCadena() As String = {Cn_Encripta.fn_Decode(dt_Valores(0)("S_Empresa").ToString), _
                                             Cn_Encripta.fn_Decode(dt_Valores(0)("E_Local").ToString), _
                                             Cn_Encripta.fn_Decode(dt_Valores(0)("Path").ToString)}

            Dim ValoresFinales() As String = {"", "", ""}
            Dim Val_Final As String = ""
            Dim Letra As Byte = 0

            For i As Byte = 0 To Cadena1.Length - 1
                For j As Byte = 0 To Cadena1(i).Length - 1
                    Letra = Cadena1(i).GetValue(j)
                    For k As Byte = 0 To ValoresCadena(i).Length - 1
                        If k = Letra Then
                            Val_Final += ValoresCadena(i)(Letra - 1).ToString
                            Exit For
                        End If
                    Next k
                Next j
                ValoresFinales(i) = Val_Final
                Val_Final = ""
            Next i

            Dim MxUsrL As Integer = ValoresFinales(0).Substring(0, 4)
            Dim MxUsrM As Integer = ValoresFinales(0).Substring(4, 4)
            Dim ExpDat As String = FuncionesGlobales.fn_Fecha102((ValoresFinales(1).Insert(2, "/")).Insert(5, "/"))
            Dim HrsMxSes As Byte = ValoresFinales(2)

            '-- Valida la fecha Expira de la Licencia ----
            If ExpDat.Trim <= dt_Valores.Rows(0)("Fecha").ToString.Trim Then
                dt_Valores.Dispose()
                Return 1
            End If

            cmd = Cn_Datos.Crea_Comando("Usr_Login_CierraSesionGeneral", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
            Cn_Datos.Crea_Parametro(cmd, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@MaxHorasesion", SqlDbType.TinyInt, HrsMxSes)
            Cn_Datos.EjecutarNonQuery(cmd)

            cmd = Cn_Datos.Crea_Comando("Usr_Login_CuentaSesiones", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Usuario", SqlDbType.VarChar, "L")
            Dim TotalL As Integer = Cn_Datos.EjecutarScalar(cmd)

            If TotalL >= MxUsrL Then
                dt_Valores.Dispose()
                Return 2
            End If

            dt_Valores.Dispose()
            Return 9

        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, False)
            Return -1
        End Try

    End Function

    Private Shared Function ObtenerCadena(ByVal CadenaRnd As String) As String
        Dim Posiciones() As Integer = {7, 11, 13, 17, 19, 23, 29, 31, 37, _
                                      41, 43, 47, 53, 59, 61, 67, 71, 73, _
                                      79, 83, 89, 97, 101, 103, 107, 109, _
                                      113, 127, 131, 137, 139, 149, 151, 157, _
                                      163, 167, 173, 179, 181, 191, 193, 197, _
                                      199, 211, 223, 227, 229, 233, 239, 241}
        Dim CadenaPasador As String = ""
        Dim CadenaNueva As String = ""
        For pos As Integer = 0 To Posiciones.Length - 1
            If Posiciones(pos) > (CadenaRnd.Length - 3) Then Exit For
            CadenaPasador = CadenaRnd.Substring(Posiciones(pos) - 1, 1)
            CadenaNueva += CadenaPasador
        Next
        Return CadenaNueva
    End Function

#End Region

End Class
