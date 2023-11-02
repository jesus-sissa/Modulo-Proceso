Imports Modulo_Proceso.FuncionesGlobales
Imports Modulo_Proceso.Cn_Datos
Imports System.Data.SqlClient

Public Class Cn_DepositosXcuenta

#Region "Depositos por cuenta Detallado"

    Public Shared Function fn_DepositosPorCuenta_GetCuentas(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Cuentas_GetByCajayMoneda", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetCuentasCombo(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasCombo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GenerarExcel(ByVal Tipo As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Id_Desde As Integer, ByVal Hasta As DateTime, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Id_Cuenta As Integer, ByVal Hijos As Char, ByVal Id_Cia As Integer) As Boolean

        Dim Denominaciones As DataTable = fn_DepositosPorCuenta_GetDenominaciones(Id_Moneda)
        If Denominaciones Is Nothing Then Return False
        Dim Cuentas As DataTable
        Dim CuentasEfectivo As DataTable
        Dim CuentasCheques As DataTable
        Dim Cta, Cte As Integer
        Dim j As Integer = 2

        Select Case Tipo
            Case 1  'Por Fecha de Aplicación del Archivo Txt
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
            Case 2  'Por Fecha_FinV, no toma en cuenta los archivos TXT
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
            Case 3  'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)
                'Haciendo Join con Pro_Archivos
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
            Case 4 'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)

                'Case 4  'Por Cliente
                '    Cuentas = fn_DepositosPorCuenta_GetByCliente(Id_CajaBancaria, Id_Grupo, Id_Moneda, Id_Desde, Id_Hasta, Id_Cliente, Hijos)

        End Select
        frm_MENU.prg_Barra.Maximum = Cuentas.Rows.Count + 2
        frm_MENU.prg_Barra.Value = 0

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim App As Object
        Dim suma As String = ""
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            App = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                App = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If Not versionHC Then
            Return False
        End If
        'Creando el libro
        App.SheetsInNewWorkbook = 1
        App.Workbooks.Add()

        Dim Hoja As Object

        If App.Worksheets(1).name = "Sheet1" Then
            Hoja = App.Sheets("Sheet1")
            suma = "=Sum"
        Else
            Hoja = App.Sheets("Hoja1")
            suma = "=Suma"
        End If

        With App

            'Creando los encabezados
            .Range("1:1").Font.Bold = True
            .Range("A1").Value = "CLIENTE"
            .Range("B1").Value = "CUENTA"

            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & 1).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
            Next

            Dim Cheques As String = LetrA(67 + Denominaciones.Rows.Count + 0)
            Dim TotalC As String = LetrA(67 + Denominaciones.Rows.Count + 1)
            Dim Propios As String = LetrA(67 + Denominaciones.Rows.Count + 2)
            Dim TotalCP As String = LetrA(67 + Denominaciones.Rows.Count + 3)
            Dim Otros As String = LetrA(67 + Denominaciones.Rows.Count + 4)
            Dim TotalCO As String = LetrA(67 + Denominaciones.Rows.Count + 5)
            Dim Fichas As String = LetrA(67 + Denominaciones.Rows.Count + 6)
            Dim Mazos As String = LetrA(67 + Denominaciones.Rows.Count + 7)
            Dim CiaTV As String = LetrA(67 + Denominaciones.Rows.Count + 8)

            .Range(Cheques & 1).Value = "Cheques"
            .Range(TotalC & 1).Value = "TotalC"
            .Range(Propios & 1).Value = "Propios"
            .Range(TotalCP & 1).Value = "TotalCP"
            .Range(Otros & 1).Value = "Otros"
            .Range(TotalCO & 1).Value = "TotalCO"
            .Range(Fichas & 1).Value = "Fichas"
            .Range(Mazos & 1).Value = "Mazos"
            .Range(CiaTV & 1).Value = "Proveedor"
            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
            For Each FilaC As DataRow In Cuentas.Rows
                If Cta = 0 And Cte = 0 Then
                    Cta = FilaC.Item("Id_Cuenta")
                    Cte = FilaC.Item("Id_ClienteP")
                ElseIf Cta <> FilaC.Item("Id_Cuenta") Or Cte <> FilaC.Item("Id_ClienteP") Then
                    Cta = FilaC.Item("Id_Cuenta")
                    Cte = FilaC.Item("Id_ClienteP")
                    j += 1
                End If
                .Range("A" & j).Value = FilaC.Item("Nombre_Comercial")
                .Range("B" & j).Value = FilaC.Item("Numero_Cuenta")
                If Tipo = 1 Then
                    .Range(CiaTV & j).Value = FilaC.Item("CiaTV")
                End If

                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Efectivo
                    For Each FilaE As DataRow In CuentasEfectivo.Rows
                        If FilaE.Item("Id_Cuenta") = Cta And FilaE.Item("Id_ClienteP") = Cte Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    'Cheques
                    For Each Fila As DataRow In CuentasCheques.Rows
                        If Fila.Item("Id_Cuenta") = Cta And Fila.Item("Id_ClienteP") = Cte Then
                            .Range(Cheques & j).Value += Fila.Item("Cheques")
                            .Range(TotalC & j).Value += Fila.Item("TotalC")
                            .Range(Propios & j).Value += Fila.Item("Propios")
                            .Range(TotalCP & j).Value += Fila.Item("TotalCP")
                            .Range(Otros & j).Value += Fila.Item("Otros")
                            .Range(TotalCO & j).Value += Fila.Item("TotalCO")
                            .Range(Fichas & j).Value += Fila.Item("Fichas")
                            Exit For
                        End If
                    Next
                End If
                '.Range(Mazos & j).Formula = Suma & "(C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j & ")"
                .Range(Mazos & j).Formula = suma & "(C" & j & ":H" & j & ")/1000"

                frm_MENU.prg_Barra.Value += 1
            Next
            j += 1
            .Range("B" & j & ":" & Mazos & j + 7).Font.Bold = True
            .Range("B" & j).Value = "Suma"
            .Range("C" & j & ":" & Mazos & j).Formula = suma & "(C2:C" & (j - 1) & ")"
            .Range("C" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

            j += 2

            .Range("B" & j).Value = "Denominaciones"
            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & j).Value = row("Denominacion")
            Next

            j += 2

            .Range("B" & j).Value = "Total Importe"
            .Range("C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j).Formula = "=C" & j - 2 & " * C" & (j - 4)
            .Range("C" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

            j += 1

            .Range(Cheques & j).Value = "Efectivo"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = suma & "(" & "C" & (j - 1) & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & (j - 1) & ")"

            j += 1

            .Range(Cheques & j).Value = "Cheques"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 6)

            j += 1

            .Range(Cheques & j).Value = "Total"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 2) & " + " & TotalC & (j - 1)

            'Mostrando el libro
            .Range("A:" & Mazos).EntireColumn.AutoFit()
            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
            .Visible = True
        End With
        Return True
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetDenominaciones(ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesMoneda_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '******************************** POR FECHA DE APLICACION DEL TXT ********************************

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '******************************** POR FECHA_FINV EN PRO_SERVICIOS ***********************************

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '********************************POR FECHA_ENTRADA EN BO_BOVEDA y PRO ARCHIVOS ***********************************

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas3", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas3", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques3", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '********************************POR FECHA_ENTRADA EN BO_BOVEDA SIN PRO ARCHIVOS ***********************************

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas4", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas4", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques4", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '********************************POR CUENTA Y FECHA_APLICACION EN PRO_ARCHIVOS ***********************************

    Public Shared Function fn_DepositosPorCuenta_GenerarExcelXcuenta(ByVal Tipo As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Id_Desde As Integer, ByVal Hasta As DateTime, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Id_Cuenta As Integer, ByVal Hijos As Char, ByVal Id_Cia As Integer) As Boolean

        Dim Denominaciones As DataTable = fn_DepositosPorCuenta_GetDenominaciones(Id_Moneda)
        If Denominaciones Is Nothing Then Return False
        Dim Cuentas As DataTable
        Dim CuentasEfectivo As DataTable
        Dim CuentasCheques As DataTable
        Dim Cta As Integer = 0
        Dim Cte As Integer = 0
        Dim Ref As Integer = 0
        Dim j As Integer = 2

        Select Case Tipo
            Case 1  'Por Fecha de Aplicación del Archivo Txt

            Case 2  'Por Fecha_FinV, no toma en cuenta los archivos TXT

            Case 3  'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

            Case 4 'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

            Case 5  'Por Cuenta y Fecha_Aplicacion del TXT
                'Haciendo Join con Pro_Archivos
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)

        End Select
        frm_MENU.prg_Barra.Maximum = Cuentas.Rows.Count + 2
        frm_MENU.prg_Barra.Value = 0

        '----
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim App As Object
        Dim suma As String = ""
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            App = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                App = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If Not versionHC Then
            Return False
        End If
        'Creando el libro
        App.SheetsInNewWorkbook = 1
        App.Workbooks.Add()

        Dim Hoja As Object

        If App.Worksheets(1).name = "Sheet1" Then
            Hoja = App.Sheets("Sheet1")
            suma = "=Sum"
        Else
            Hoja = App.Sheets("Hoja1")
            suma = "=Suma"
        End If
        '----

        With App

            'Creando los encabezados
            .Range("1:1").Font.Bold = True
            .Range("A1").Value = "CLIENTE"
            .Range("B1").Value = "CUENTA"
            .Range("C1").Value = "REFERENCIA"

            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & 1).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
            Next

            Dim Cheques As String = LetrA(68 + Denominaciones.Rows.Count + 0)
            Dim TotalC As String = LetrA(68 + Denominaciones.Rows.Count + 1)
            Dim Propios As String = LetrA(68 + Denominaciones.Rows.Count + 2)
            Dim TotalCP As String = LetrA(68 + Denominaciones.Rows.Count + 3)
            Dim Otros As String = LetrA(68 + Denominaciones.Rows.Count + 4)
            Dim TotalCO As String = LetrA(68 + Denominaciones.Rows.Count + 5)
            Dim Fichas As String = LetrA(68 + Denominaciones.Rows.Count + 6)
            Dim Mazos As String = LetrA(68 + Denominaciones.Rows.Count + 7)
            Dim CiaTV As String = LetrA(68 + Denominaciones.Rows.Count + 8)

            .Range(Cheques & 1).Value = "Cheques"
            .Range(TotalC & 1).Value = "TotalC"
            .Range(Propios & 1).Value = "Propios"
            .Range(TotalCP & 1).Value = "TotalCP"
            .Range(Otros & 1).Value = "Otros"
            .Range(TotalCO & 1).Value = "TotalCO"
            .Range(Fichas & 1).Value = "Fichas"
            .Range(Mazos & 1).Value = "Mazos"
            .Range(CiaTV & 1).Value = "Proveedor"

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
            For Each FilaC As DataRow In Cuentas.Rows
                If Cta = 0 And Cte = 0 Then
                    Cta = FilaC.Item("Id_Cuenta")
                    Cte = FilaC.Item("Id_ClienteP")
                    Ref = FilaC.Item("Id_Referencia")
                ElseIf Cta <> FilaC.Item("Id_Cuenta") Or Cte <> FilaC.Item("Id_ClienteP") Or Ref <> FilaC.Item("Id_Referencia") Then
                    Cta = FilaC.Item("Id_Cuenta")
                    Cte = FilaC.Item("Id_ClienteP")
                    Ref = FilaC.Item("Id_Referencia")
                    j += 1
                End If
                .Range("A" & j).Value = FilaC.Item("Nombre_Comercial")
                .Range("B" & j).Value = FilaC.Item("Numero_Cuenta")
                .Range("C" & j).Value = FilaC.Item("Referencia")
                .Range(CiaTV & j).Value = FilaC.Item("CiaTV")

                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Efectivo
                    For Each FilaE As DataRow In CuentasEfectivo.Rows
                        If FilaE.Item("Id_Cuenta") = Cta And FilaE.Item("Id_ClienteP") = Cte And FilaE.Item("Id_Referencia") = Ref Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    'Cheques
                    For Each Fila As DataRow In CuentasCheques.Rows
                        If Fila.Item("Id_Cuenta") = Cta And Fila.Item("Id_ClienteP") = Cte And Fila.Item("Id_Referencia") = Ref Then
                            .Range(Cheques & j).Value += Fila.Item("Cheques")
                            .Range(TotalC & j).Value += Fila.Item("TotalC")
                            .Range(Propios & j).Value += Fila.Item("Propios")
                            .Range(TotalCP & j).Value += Fila.Item("TotalCP")
                            .Range(Otros & j).Value += Fila.Item("Otros")
                            .Range(TotalCO & j).Value += Fila.Item("TotalCO")
                            .Range(Fichas & j).Value += Fila.Item("Fichas")
                            Exit For
                        End If
                    Next
                End If
                '.Range(Mazos & j).Formula = Suma & "(C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j & ")"
                .Range(Mazos & j).Formula = suma & "(D" & j & ":I" & j & ")/1000"

                frm_MENU.prg_Barra.Value += 1
            Next
            j += 1
            .Range("B" & j & ":" & Mazos & j + 7).Font.Bold = True
            .Range("B" & j).Value = "Suma"
            .Range("D" & j & ":" & Mazos & j).Formula = suma & "(D2:D" & (j - 1) & ")"
            .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

            j += 2

            .Range("B" & j).Value = "Denominaciones"
            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = row("Denominacion")
            Next

            j += 2

            .Range("B" & j).Value = "Total Importe"
            .Range("D" & j & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & j).Formula = "=D" & j - 2 & " * D" & (j - 4)
            .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

            j += 1

            .Range(Cheques & j).Value = "Efectivo"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = suma & "(" & "D" & (j - 1) & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & (j - 1) & ")"

            j += 1

            .Range(Cheques & j).Value = "Cheques"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 6)

            j += 1

            .Range(Cheques & j).Value = "Total"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 2) & " + " & TotalC & (j - 1)

            'Mostrando el libro
            .Range("A:" & Mazos).EntireColumn.AutoFit()
            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
            .Visible = True
        End With
        Return True
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas5", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas5", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques5", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    '********************************POR CUENTA Y FECHA_APLICACION EN PRO_ARCHIVOS ***********************************

    Public Shared Function fn_DepositosPorCuenta_GenerarExcelXcuentaAgrupado(ByVal Tipo As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Id_Desde As Integer, ByVal Hasta As DateTime, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Id_Cuenta As Integer, ByVal Hijos As Char, ByVal Id_Cia As Integer) As Boolean

        Dim Denominaciones As DataTable = fn_DepositosPorCuenta_GetDenominaciones(Id_Moneda)
        If Denominaciones Is Nothing Then Return False
        Dim Clientes As DataTable
        Dim Cuentas As DataTable
        Dim CuentasEfectivo As DataTable
        Dim CuentasCheques As DataTable

        Dim Cta As Integer = 0
        Dim Cte As Integer = 0
        Dim Ref As Integer = 0

        Dim CtaS As String = ""
        Dim CteS As String = ""
        Dim RefS As String = ""

        Dim j As Integer = 2

        Select Case Tipo
            Case 1  'Por Fecha de Aplicación del Archivo Txt

            Case 2  'Por Fecha_FinV, no toma en cuenta los archivos TXT

            Case 3  'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

            Case 4 'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

            Case 5  'Por Cuenta y Fecha_Aplicacion del TXT
                'Haciendo Join con Pro_Archivos
                'Traer los Clientes
                Clientes = fn_DepositosPorCuenta_GetByTXTfechasCuentas6AgrupadoClientes(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
                'Traer las Cuentas y Referencias
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas6Agrupado(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo6Agrupado(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques6Agrupado(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)

        End Select
        frm_MENU.prg_Barra.Maximum = Cuentas.Rows.Count + 2
        frm_MENU.prg_Barra.Value = 0

        '-------------
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim App As Object
        Dim suma As String = ""
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            App = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                App = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If
        If Not versionHC Then
            Return False
        End If
        'Creando el libro
        App.SheetsInNewWorkbook = 1
        App.Workbooks.Add()

        Dim Hoja As Object

        If App.Worksheets(1).name = "Sheet1" Then
            Hoja = App.Sheets("Sheet1")
            suma = "=Sum"
        Else
            Hoja = App.Sheets("Hoja1")
            suma = "=Suma"
        End If

        '----------------
        With App

            'Creando los encabezados
            .Range("1:1").Font.Bold = True
            .Range("A1").Value = "CLIENTE"
            .Range("B1").Value = "CUENTA"
            .Range("C1").Value = "REFERENCIA"

            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & 1).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
            Next

            Dim Cheques As String = LetrA(68 + Denominaciones.Rows.Count + 0)
            Dim TotalC As String = LetrA(68 + Denominaciones.Rows.Count + 1)
            Dim Propios As String = LetrA(68 + Denominaciones.Rows.Count + 2)
            Dim TotalCP As String = LetrA(68 + Denominaciones.Rows.Count + 3)
            Dim Otros As String = LetrA(68 + Denominaciones.Rows.Count + 4)
            Dim TotalCO As String = LetrA(68 + Denominaciones.Rows.Count + 5)
            Dim Fichas As String = LetrA(68 + Denominaciones.Rows.Count + 6)
            Dim Mazos As String = LetrA(68 + Denominaciones.Rows.Count + 7)
            Dim CiaTV As String = LetrA(68 + Denominaciones.Rows.Count + 8)

            .Range(Cheques & 1).Value = "Cheques"
            .Range(TotalC & 1).Value = "TotalC"
            .Range(Propios & 1).Value = "Propios"
            .Range(TotalCP & 1).Value = "TotalCP"
            .Range(Otros & 1).Value = "Otros"
            .Range(TotalCO & 1).Value = "TotalCO"
            .Range(Fichas & 1).Value = "Fichas"
            .Range(Mazos & 1).Value = "Mazos"
            .Range(CiaTV & 1).Value = "CiaTV"

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
            For Each FilaC As DataRow In Cuentas.Rows
                If CtaS = "" And RefS = "" Then
                    CtaS = FilaC.Item("Numero_Cuenta")
                    RefS = FilaC.Item("Referencia")
                ElseIf CtaS <> FilaC.Item("Numero_Cuenta") Or RefS <> FilaC.Item("Referencia") Then
                    CtaS = FilaC.Item("Numero_Cuenta")
                    RefS = FilaC.Item("Referencia")
                    j += 1
                End If
                '.Range("A" & j).Value = FilaC.Item("Nombre_Comercial")
                .Range("B" & j).Value = FilaC.Item("Numero_Cuenta")
                .Range("C" & j).Value = FilaC.Item("Referencia")

                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Nombre del Cliente
                    For Each FilaE As DataRow In Clientes.Rows
                        If FilaE.Item("Numero_Cuenta") = CtaS And FilaE.Item("Referencia") = RefS Then
                            .Range("A" & j).Value = FilaE.Item("Nombre_Comercial")
                            .Range(CiaTV & j).value = FilaE.Item("CiaTV")
                            Exit For
                        End If
                    Next
                    'Efectivo
                    For Each FilaE As DataRow In CuentasEfectivo.Rows
                        If FilaE.Item("Numero_Cuenta") = CtaS And FilaE.Item("Referencia") = RefS Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    'Cheques
                    For Each Fila As DataRow In CuentasCheques.Rows
                        If Fila.Item("Numero_Cuenta") = CtaS And Fila.Item("Referencia") = RefS Then
                            .Range(Cheques & j).Value += Fila.Item("Cheques")
                            .Range(TotalC & j).Value += Fila.Item("TotalC")
                            .Range(Propios & j).Value += Fila.Item("Propios")
                            .Range(TotalCP & j).Value += Fila.Item("TotalCP")
                            .Range(Otros & j).Value += Fila.Item("Otros")
                            .Range(TotalCO & j).Value += Fila.Item("TotalCO")
                            .Range(Fichas & j).Value += Fila.Item("Fichas")
                            Exit For
                        End If
                    Next
                End If
                '.Range(Mazos & j).Formula = Suma & "(C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j & ")"
                .Range(Mazos & j).Formula = suma & "(D" & j & ":I" & j & ")/1000"

                frm_MENU.prg_Barra.Value += 1
            Next
            j += 1
            .Range("B" & j & ":" & Mazos & j + 7).Font.Bold = True
            .Range("B" & j).Value = "Suma"
            .Range("D" & j & ":" & Mazos & j).Formula = suma & "(D2:D" & (j - 1) & ")"
            .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

            j += 2

            .Range("B" & j).Value = "Denominaciones"
            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = row("Denominacion")
            Next

            j += 2

            .Range("B" & j).Value = "Total Importe"
            .Range("D" & j & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & j).Formula = "=D" & j - 2 & " * D" & (j - 4)
            .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

            j += 1

            .Range(Cheques & j).Value = "Efectivo"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = suma & "(" & "D" & (j - 1) & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & (j - 1) & ")"

            j += 1

            .Range(Cheques & j).Value = "Cheques"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 6)

            j += 1

            .Range(Cheques & j).Value = "Total"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 2) & " + " & TotalC & (j - 1)

            'Mostrando el libro
            .Range("A:" & Mazos).EntireColumn.AutoFit()
            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
            .Visible = True
        End With
        Return True
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas6AgrupadoClientes(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas6Clientes", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas6Agrupado(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas6", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo6Agrupado(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas6", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques6Agrupado(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques6", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Depositos por cuenta Agrupado"

    Public Shared Function fn_DepositosPorCuenta_GetClientesYcuentas(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_CuentasYclientes_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuentaAgrupado_GenerarExcel(ByVal Tipo As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Id_Desde As Integer, ByVal Hasta As DateTime, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Id_Cuenta As Integer, ByVal Hijos As Char, ByVal Id_Cia As Integer, ByVal Corte_Turno As Integer, _
                                                                      ByVal TipoReporte As String, ByVal CajaBancaria As String, ByVal GrupoProceso As String, ByVal Corte As String, ByVal Moneda As String, ByVal sDesde As String, ByVal SesionD As String, ByVal sHasta As String, ByVal SesionH As String, ByVal CompaniaTV As String) As Boolean
        Dim Denominaciones As DataTable = fn_DepositosPorCuenta_GetDenominaciones(Id_Moneda)
        If Denominaciones Is Nothing Then Return False
        Dim Cuentas As DataTable
        Dim Clientes As DataTable
        Dim CuentasEfectivo As DataTable
        Dim CuentasCheques As DataTable
        Dim Cta As Integer = 0
        Dim Cte As Integer = 0
        Dim j As Integer = 2
        'IMPORTANTE: Las Consultas son Agrupadas por Id_Cuenta por lo tanto no tienen el Nombre de Ciente
        'debo crear un Datatable que contenga todos los Clientes con sus respectivas Cuentas
        'para tomarlas de ahi en un recorrido final

        Clientes = fn_DepositosPorCuenta_GetClientesYcuentas(Id_CajaBancaria, Id_Moneda)

        Select Case Tipo
            Case 1  'Por Fecha de Aplicación del Archivo Txt
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentasAgrupado(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Corte_Turno)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivoAgrupado(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Corte_Turno)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasChequesAgrupado(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Corte_Turno)
            Case 2  'Por Fecha_FinV, no toma en cuenta los archivos TXT
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques2(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
            Case 3  'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)
                'Haciendo Join con Pro_Archivos
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques3(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
            Case 4 'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)
                'Traer las Fichas y las Cuentas
                Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer el Efectivo
                CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
                'Traer los cheques
                CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques4(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)

                'Case 4  'Por Cliente
                '    Cuentas = fn_DepositosPorCuenta_GetByCliente(Id_CajaBancaria, Id_Grupo, Id_Moneda, Id_Desde, Id_Hasta, Id_Cliente, Hijos)

        End Select
        frm_MENU.prg_Barra.Maximum = Cuentas.Rows.Count + 2
        frm_MENU.prg_Barra.Value = 0

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim App As Object
        Dim suma As String = ""
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            App = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                App = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        'Creando el libro
        App.SheetsInNewWorkbook = 1
        App.Workbooks.Add()

        Dim Hoja As Object

        If App.Worksheets(1).name = "Sheet1" Then
            Hoja = App.Sheets("Sheet1")
            suma = "=Sum"
        Else
            Hoja = App.Sheets("Hoja1")
            suma = "=Suma"
        End If

        With App

            'Creando los encabezados
            .Range("1:1").Font.Bold = True
            .Range("A1").Value = "CLIENTE"
            .Range("B1").Value = "CUENTA"

            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & 1).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
            Next

            Dim Cheques As String = LetrA(67 + Denominaciones.Rows.Count + 0)
            Dim TotalC As String = LetrA(67 + Denominaciones.Rows.Count + 1)
            Dim Propios As String = LetrA(67 + Denominaciones.Rows.Count + 2)
            Dim TotalCP As String = LetrA(67 + Denominaciones.Rows.Count + 3)
            Dim Otros As String = LetrA(67 + Denominaciones.Rows.Count + 4)
            Dim TotalCO As String = LetrA(67 + Denominaciones.Rows.Count + 5)
            Dim Fichas As String = LetrA(67 + Denominaciones.Rows.Count + 6)
            Dim Mazos As String = LetrA(67 + Denominaciones.Rows.Count + 7)
            Dim CiaTV As String = LetrA(67 + Denominaciones.Rows.Count + 8)
            Dim TotalEfectivo As String = LetrA(67 + Denominaciones.Rows.Count + 9)

            .Range(Cheques & 1).Value = "Cheques"
            .Range(TotalC & 1).Value = "TotalC"
            .Range(Propios & 1).Value = "Propios"
            .Range(TotalCP & 1).Value = "TotalCP"
            .Range(Otros & 1).Value = "Otros"
            .Range(TotalCO & 1).Value = "TotalCO"
            .Range(Fichas & 1).Value = "Fichas"
            .Range(Mazos & 1).Value = "Mazos"
            .Range(CiaTV & 1).Value = "Proveedor"
            .Range(TotalEfectivo & 1).Value = "TotalEfectivo"

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques

            For Each FilaC As DataRow In Cuentas.Rows
                If Cta = 0 Then
                    Cta = FilaC.Item("Id_Cuenta")
                ElseIf Cta <> FilaC.Item("Id_Cuenta") Then
                    Cta = FilaC.Item("Id_Cuenta")
                    j += 1
                End If
                .Range("A" & j).Value = "" 'FilaC.Item("Nombre_Comercial")
                .Range("B" & j).Value = FilaC.Item("Numero_Cuenta")

                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Cliente
                    For Each FilaCl As DataRow In Clientes.Rows
                        If FilaCl.Item("Id_Cuenta") = Cta Then
                            .Range("A" & j).Value = FilaCl.Item("Nombre_Comercial")
                            .Range(CiaTV & j).Value = FilaCl.Item("CiaTV")
                            Exit For
                        End If
                    Next

                    'Efectivo
                    For Each FilaE As DataRow In CuentasEfectivo.Rows
                        If FilaE.Item("Id_Cuenta") = Cta Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    'Cheques
                    For Each Fila As DataRow In CuentasCheques.Rows
                        If Fila.Item("Id_Cuenta") = Cta Then
                            .Range(Cheques & j).Value += Fila.Item("Cheques")
                            .Range(TotalC & j).Value += Fila.Item("TotalC")
                            .Range(Propios & j).Value += Fila.Item("Propios")
                            .Range(TotalCP & j).Value += Fila.Item("TotalCP")
                            .Range(Otros & j).Value += Fila.Item("Otros")
                            .Range(TotalCO & j).Value += Fila.Item("TotalCO")
                            .Range(Fichas & j).Value += Fila.Item("Fichas")
                            Exit For
                        End If
                    Next
                    'Total Efectivo
                    'De la letra C hasta la letra que se llene en denominaciones
                    For ILocal As Integer = 67 To 66 + Denominaciones.Rows.Count
                        'Multiplicar el valor de la Denominación con su cantidad por fila.
                        .Range(TotalEfectivo & j).Value += CDec(Mid(.Range(LetrA(ILocal) & 1).Value, 2)) * CDec(.Range(LetrA(ILocal) & j).Value)
                    Next
                    .Range(TotalEfectivo & j).NumberFormat = "#,##0.00"
                End If
                '.Range(Mazos & j).Formula = Suma & "(C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j & ")"
                .Range(Mazos & j).Formula = Suma & "(C" & j & ":H" & j & ")/1000"

                frm_MENU.prg_Barra.Value += 1
            Next
            j += 1
            .Range("B" & j & ":" & TotalEfectivo & j + 7).Font.Bold = True
            .Range("B" & j).Value = "Suma"
            .Range("C" & j & ":" & Mazos & j).Formula = Suma & "(C2:C" & (j - 1) & ")"
            .Range("C" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"
            .Range(TotalEfectivo & j).Formula = Suma & "(" & TotalEfectivo & "2:" & TotalEfectivo & (j - 1) & ")"
            .Range(TotalEfectivo & j).NumberFormat = "#,##0.00"

            j += 2

            .Range("B" & j).Value = "Denominaciones"
            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(67 + Denominaciones.Rows.IndexOf(row)) & j).Value = row("Denominacion")
            Next

            j += 2

            .Range("B" & j).Value = "Total Importe"
            .Range("C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j).Formula = "=C" & j - 2 & " * C" & (j - 4)
            .Range("C" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

            j += 1

            .Range(Cheques & j).Value = "Efectivo"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = Suma & "(" & "C" & (j - 1) & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & (j - 1) & ")"

            j += 1

            .Range(Cheques & j).Value = "Cheques"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 6)

            j += 1

            .Range(Cheques & j).Value = "Total"
            .Range(TotalC & j).NumberFormat = "#,##0.00"
            .Range(TotalC & j).Formula = "=" & TotalC & (j - 2) & " + " & TotalC & (j - 1)

            .Range("A:" & TotalEfectivo).EntireColumn.AutoFit()

            .Range("A" & j).Value = "FILTROS UTILIZADOS:"

            j += 1

            .Range("A" & j).Value = "Tipo Reporte:  " & TipoReporte

            j += 1

            .Range("A" & j).Value = "Caja Bancaria:  " & CajaBancaria

            j += 1

            .Range("A" & j).Value = "Grupo Proceso:  " & GrupoProceso

            j += 1

            .Range("A" & j).Value = "Corte:  " & Corte

            j += 1

            .Range("A" & j).Value = "Moneda:  " & Moneda

            j += 1

            .Range("A" & j).Value = "Desde:  " & sDesde & "   Sesión: " & SesionD

            j += 1

            .Range("A" & j).Value = "Hasta:  " & sHasta & "   Sesión: " & SesionH

            j += 1

            .Range("A" & j).Value = "Compañía TV:  " & CompaniaTV

            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
            'Mostrando el libro
            .Visible = True
        End With
        Return True
    End Function

    '******************************** POR FECHA DE APLICACION DEL TXT ********************************

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentasAgrupado(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Corte_Turno As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentasAgrupado", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Corte_Turno", SqlDbType.Int, Corte_Turno)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivoAgrupado(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Corte_Turno As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasAgrupado", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Corte_Turno", SqlDbType.Int, Corte_Turno)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasChequesAgrupado(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Corte_Turno As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasChequesAgrupado", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Crea_Parametro(cmd, "@Corte_Turno", SqlDbType.Int, Corte_Turno)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    ''******************************** POR FECHA_FINV EN PRO_SERVICIOS ***********************************

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas2", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas2", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques2(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques2", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    ''********************************POR FECHA_ENTRADA EN BO_BOVEDA y PRO ARCHIVOS ***********************************

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas3", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas3", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques3(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques3", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    ''********************************POR FECHA_ENTRADA EN BO_BOVEDA SIN PRO ARCHIVOS ***********************************

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas4", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas4", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques4(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques4", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    ''********************************POR CUENTA Y FECHA_APLICACION EN PRO_ARCHIVOS ***********************************

    'Public Shared Function fn_DepositosPorCuenta_GenerarExcelXcuenta(ByVal Tipo As Integer, ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Id_Desde As Integer, ByVal Hasta As DateTime, ByVal Id_Hasta As Integer, ByVal Id_Cliente As Integer, ByVal Id_Cuenta As Integer, ByVal Hijos As Char, ByVal Id_Cia As Integer) As Boolean

    '    Dim Denominaciones As DataTable = fn_DepositosPorCuenta_GetDenominaciones(Id_Moneda)
    '    If Denominaciones Is Nothing Then Return False
    '    Dim Cuentas As DataTable
    '    Dim CuentasEfectivo As DataTable
    '    Dim CuentasCheques As DataTable
    '    Dim Cta As Integer = 0
    '    Dim Cte As Integer = 0
    '    Dim Ref As Integer = 0
    '    Dim j As Integer = 2
    '    Dim Suma As String

    '    Select Case Tipo
    '        Case 1  'Por Fecha de Aplicación del Archivo Txt

    '        Case 2  'Por Fecha_FinV, no toma en cuenta los archivos TXT

    '        Case 3  'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

    '        Case 4 'Por Fech_Entrada en Bo_Boveda (Fecha del Traslado)

    '        Case 5  'Por Cuenta y Fecha_Aplicacion del TXT
    '            'Haciendo Join con Pro_Archivos
    '            'Traer las Fichas y las Cuentas
    '            Cuentas = fn_DepositosPorCuenta_GetByTXTfechasCuentas5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
    '            'Traer el Efectivo
    '            CuentasEfectivo = fn_DepositosPorCuenta_GetByTXTfechasEfectivo5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)
    '            'Traer los cheques
    '            CuentasCheques = fn_DepositosPorCuenta_GetByTXTfechasCheques5(Id_CajaBancaria, Id_Grupo, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia, Id_Cuenta)

    '    End Select
    '    frm_MENU.prg_Barra.Maximum = Cuentas.Rows.Count + 2
    '    frm_MENU.prg_Barra.Value = 0
    '    'Dim  As New Excel.Application
    '    Dim App = CreateObject("Excel.Application")
    '    With App

    '        'Creando el libro
    '        .Workbooks.Add()
    '        .SheetsInNewWorkbook = 1

    '        'If CType(.Worksheets(1), app.Worksheet).Name = "Hoja1" Then Suma = "=Suma" Else Suma = "=Sum"
    '        Suma = "=Suma"
    '        'Creando los encabezados
    '        .Range("1:1").Font.Bold = True
    '        .Range("A1").Value = "CLIENTE"
    '        .Range("B1").Value = "CUENTA"
    '        .Range("C1").Value = "REFERENCIA"

    '        For Each row As DataRow In Denominaciones.Rows
    '            .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & 1).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1) & row("Denominacion")
    '        Next

    '        Dim Cheques As String = LetrA(68 + Denominaciones.Rows.Count + 0)
    '        Dim TotalC As String = LetrA(68 + Denominaciones.Rows.Count + 1)
    '        Dim Propios As String = LetrA(68 + Denominaciones.Rows.Count + 2)
    '        Dim TotalCP As String = LetrA(68 + Denominaciones.Rows.Count + 3)
    '        Dim Otros As String = LetrA(68 + Denominaciones.Rows.Count + 4)
    '        Dim TotalCO As String = LetrA(68 + Denominaciones.Rows.Count + 5)
    '        Dim Fichas As String = LetrA(68 + Denominaciones.Rows.Count + 6)
    '        Dim Mazos As String = LetrA(68 + Denominaciones.Rows.Count + 7)

    '        .Range(Cheques & 1).Value = "Cheques"
    '        .Range(TotalC & 1).Value = "TotalC"
    '        .Range(Propios & 1).Value = "Propios"
    '        .Range(TotalCP & 1).Value = "TotalCP"
    '        .Range(Otros & 1).Value = "Otros"
    '        .Range(TotalCO & 1).Value = "TotalCO"
    '        .Range(Fichas & 1).Value = "Fichas"
    '        .Range(Mazos & 1).Value = "Mazos"
    '        Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
    '        For Each FilaC As DataRow In Cuentas.Rows
    '            If Cta = 0 And Cte = 0 Then
    '                Cta = FilaC.Item("Id_Cuenta")
    '                Cte = FilaC.Item("Id_ClienteP")
    '                Ref = FilaC.Item("Id_Referencia")
    '            ElseIf Cta <> FilaC.Item("Id_Cuenta") Or Cte <> FilaC.Item("Id_ClienteP") Or Ref <> FilaC.Item("Id_Referencia") Then
    '                Cta = FilaC.Item("Id_Cuenta")
    '                Cte = FilaC.Item("Id_ClienteP")
    '                Ref = FilaC.Item("Id_Referencia")
    '                j += 1
    '            End If
    '            .Range("A" & j).Value = FilaC.Item("Nombre_Comercial")
    '            .Range("B" & j).Value = FilaC.Item("Numero_Cuenta")
    '            .Range("C" & j).Value = FilaC.Item("Referencia")

    '            If Fila_Anterior <> j Then
    '                Fila_Anterior = j
    '                'Efectivo
    '                For Each FilaE As DataRow In CuentasEfectivo.Rows
    '                    If FilaE.Item("Id_Cuenta") = Cta And FilaE.Item("Id_ClienteP") = Cte And FilaE.Item("Id_Referencia") = Ref Then
    '                        For Each row As DataRow In Denominaciones.Rows
    '                            If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
    '                                .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad")
    '                                Exit For
    '                            End If
    '                        Next
    '                    End If
    '                Next
    '                'Cheques
    '                For Each Fila As DataRow In CuentasCheques.Rows
    '                    If Fila.Item("Id_Cuenta") = Cta And Fila.Item("Id_ClienteP") = Cte And Fila.Item("Id_Referencia") = Ref Then
    '                        .Range(Cheques & j).Value += Fila.Item("Cheques")
    '                        .Range(TotalC & j).Value += Fila.Item("TotalC")
    '                        .Range(Propios & j).Value += Fila.Item("Propios")
    '                        .Range(TotalCP & j).Value += Fila.Item("TotalCP")
    '                        .Range(Otros & j).Value += Fila.Item("Otros")
    '                        .Range(TotalCO & j).Value += Fila.Item("TotalCO")
    '                        .Range(Fichas & j).Value += Fila.Item("Fichas")
    '                        Exit For
    '                    End If
    '                Next
    '            End If
    '            '.Range(Mazos & j).Formula = Suma & "(C" & j & ":" & LetrA(67 + Denominaciones.Rows.Count - 1) & j & ")"
    '            .Range(Mazos & j).Formula = Suma & "(D" & j & ":I" & j & ")/1000"

    '            frm_MENU.prg_Barra.Value += 1
    '        Next
    '        j += 1
    '        .Range("B" & j & ":" & Mazos & j + 7).Font.Bold = True
    '        .Range("B" & j).Value = "Suma"
    '        .Range("D" & j & ":" & Mazos & j).Formula = Suma & "(D2:D" & (j - 1) & ")"
    '        .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

    '        j += 2

    '        .Range("B" & j).Value = "Denominaciones"
    '        For Each row As DataRow In Denominaciones.Rows
    '            .Range(LetrA(68 + Denominaciones.Rows.IndexOf(row)) & j).Value = row("Denominacion")
    '        Next

    '        j += 2

    '        .Range("B" & j).Value = "Total Importe"
    '        .Range("D" & j & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & j).Formula = "=D" & j - 2 & " * D" & (j - 4)
    '        .Range("D" & j & ":" & Mazos & j).NumberFormat = "#,##0.00"

    '        j += 1

    '        .Range(Cheques & j).Value = "Efectivo"
    '        .Range(TotalC & j).NumberFormat = "#,##0.00"
    '        .Range(TotalC & j).Formula = Suma & "(" & "D" & (j - 1) & ":" & LetrA(68 + Denominaciones.Rows.Count - 1) & (j - 1) & ")"

    '        j += 1

    '        .Range(Cheques & j).Value = "Cheques"
    '        .Range(TotalC & j).NumberFormat = "#,##0.00"
    '        .Range(TotalC & j).Formula = "=" & TotalC & (j - 6)

    '        j += 1

    '        .Range(Cheques & j).Value = "Total"
    '        .Range(TotalC & j).NumberFormat = "#,##0.00"
    '        .Range(TotalC & j).Formula = "=" & TotalC & (j - 2) & " + " & TotalC & (j - 1)

    '        'Mostrando el libro
    '        .Range("A:" & Mazos).EntireColumn.AutoFit()
    '        frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum
    '        .Visible = True
    '    End With
    '    Return True
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCuentas5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCuentas5", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasEfectivo5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechas5", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_DepositosPorCuenta_GetByTXTfechasCheques5(ByVal Id_CajaBancaria As Integer, ByVal Id_Grupo As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer, ByVal Id_Cuenta As Integer) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Pro_Fichas_ReporteFechasCheques5", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
    '    Crea_Parametro(cmd, "@Id_Grupo", SqlDbType.Int, Id_Grupo)
    '    Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
    '    Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
    '    Crea_Parametro(cmd, "@Id_Cuenta", SqlDbType.Int, Id_Cuenta)
    '    Try
    '        Return EjecutaConsulta(cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

#End Region

#Region "Dep. por Cuenta Reporte de Procesos"

    Public Shared Function fn_ReporteProcesos_GetDenominaciones(ByVal Id_Moneda As Integer, ByVal Presentacion As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_DenominacionesP_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Presentacion", SqlDbType.VarChar, Presentacion)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteProcesos_GetArchivos(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_Archivos_GetReporteProcesos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteProcesos_GetArchivosD(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As String, ByVal Hasta As String, ByVal Id_Cia As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Pro_ArchivosD_GetReporteProcesos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
        Crea_Parametro(cmd, "@Id_Moneda", SqlDbType.Int, Id_Moneda)
        Crea_Parametro(cmd, "@Desde", SqlDbType.VarChar, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.VarChar, Hasta)
        Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReporteProcesos_GenerarExcel(ByVal Id_CajaBancaria As Integer, ByVal Id_Moneda As Integer, ByVal Desde As DateTime, ByVal Hasta As DateTime, ByVal Id_Cia As Integer) As Boolean

        Dim Denominaciones As DataTable = fn_ReporteProcesos_GetDenominaciones(Id_Moneda, "B")
        If Denominaciones Is Nothing Then Return False
        Dim Archivos As DataTable
        Dim ArchivosD As DataTable
        Dim Arc As Integer = 0
        Dim Cia As String = ""
        Dim j As Integer = 2
        Dim Piezas As Integer = 0

        'Traer las Fichas y las Cuentas
        Archivos = fn_ReporteProcesos_GetArchivos(Id_CajaBancaria, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)
        'Traer el Efectivo
        ArchivosD = fn_ReporteProcesos_GetArchivosD(Id_CajaBancaria, Id_Moneda, FuncionesGlobales.fn_Fecha102(Desde.ToShortDateString), FuncionesGlobales.fn_Fecha102(Hasta.ToShortDateString), Id_Cia)

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim App As Object
        Dim suma As String = ""
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            App = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                App = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If
        If Not versionHC Then
            Return False
        End If
        'Creando el libro
        App.SheetsInNewWorkbook = 1
        App.Workbooks.Add()

        Dim Hoja As Object

        If App.Worksheets(1).name = "Sheet1" Then
            Hoja = App.Sheets("Sheet1")
            suma = "=Sum"
        Else
            Hoja = App.Sheets("Hoja1")
            suma = "=Suma"
        End If

        With App

            'Creando los encabezados
            .Range("1:1").Font.Bold = True
            .Range("A1").Value = "FECHA"
            .Range("B1").Value = "PROCESO(CIA TV)"
            .Range("C1").Value = "COMPROBANTE"
            .Range("D1").Value = "ENVASES"
            .Range("E1").Value = "MAZOS"
            .Range("F1").Value = "IMPORTE TOTAL"


            For Each row As DataRow In Denominaciones.Rows
                .Range(LetrA(71 + Denominaciones.Rows.IndexOf(row)) & 1).Value = row("Denominacion")
            Next

            Dim Morralla As String = LetrA(71 + Denominaciones.Rows.Count + 0)
            Dim Num_Proceso As String = LetrA(71 + Denominaciones.Rows.Count + 1)

            .Range(Morralla & 1).Value = "Morralla"
            .Range(Num_Proceso & 1).Value = "Num Proceso"

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo
            frm_MENU.prg_Barra.Maximum = Archivos.Rows.Count + 1
            frm_MENU.prg_Barra.Value = 0

            For Each FilaC As DataRow In Archivos.Rows
                If Arc = 0 And Cia = "" Then
                    Arc = FilaC.Item("Id_Archivo")
                    Cia = FilaC.Item("Cia")
                ElseIf Arc <> FilaC.Item("Id_Archivo") Or Cia <> FilaC.Item("Cia") Then
                    Arc = FilaC.Item("Id_Archivo")
                    Cia = FilaC.Item("Cia")
                    j += 1
                End If
                .Range("A" & j).Value = FilaC.Item("Fecha")
                .Range("B" & j).Value = FilaC.Item("Cia")

                Piezas = 0
                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Efectivo
                    For Each FilaE As DataRow In ArchivosD.Rows
                        If FilaE.Item("Id_Archivo") = Arc And FilaE.Item("Cia") = Cia Then
                            For Each row As DataRow In Denominaciones.Rows
                                If row.Item("Id_Denominacion") = FilaE.Item("Id_Denominacion") Then
                                    .Range(LetrA(71 + Denominaciones.Rows.IndexOf(row)) & j).Value = FilaE.Item("Cantidad") * FilaE.Item("Denominacion")
                                    Piezas += FilaE.Item("Cantidad")
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
                .Range("E" & j).Value = Piezas / 1000
                .Range("F" & j).Formula = Suma & "(G" & j & ":" & Morralla & j & ")"
                .Range(Morralla & j).Value = FilaC.Item("Morralla")
                .Range(Num_Proceso & j).Value = FilaC.Item("Num_Proceso")
                .Range("E" & j & ":" & Morralla & j).NumberFormat = "#,##0.00"

                frm_MENU.prg_Barra.Value += 1
            Next
            .Range("A1:" & Morralla & j).Borders.Value = True
            .Range("A1:" & Morralla & j).Font.Name = "Arial"
            .Range("A1:" & Morralla & j).Font.Bold = True
            .Range("A1:" & Morralla & j).Font.Size = 8

            'Sumatorias
            j += 1
            .Range("D" & j & ":" & Morralla & j).Formula = Suma & "(D2:D" & j - 1 & ")"
            .Range("D" & j & ":" & Morralla & j).NumberFormat = "#,##0.00"
            .Range("B" & j).Value = "Suma"
            .Range("B" & j & ":" & Morralla & j).Font.Bold = True

            frm_MENU.prg_Barra.Value = frm_MENU.prg_Barra.Maximum

            'Mostrando el libro
            .Range("A:" & Morralla).EntireColumn.AutoFit()
            .Visible = True
        End With
        Return True

    End Function

#End Region


End Class
