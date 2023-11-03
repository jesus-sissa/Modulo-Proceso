Imports Modulo_Proceso.Cn_Proceso
Imports Modulo_Proceso.FuncionesGlobales

Public Class frm_DetalleDepositos

    Private Sub frm_ConsultaDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0
        Cmb_grupo.AgregaParametro("@Id_CajaBancaria", 0, 1)
        cmb_Moneda.Actualizar()

        cmb_CajaBancaria.Actualizar()

        Cmb_Clientes.AgregaParametro("@Status", "A", 0)
        Cmb_Clientes.Actualizar()

        Cmb_ClientesP.AgregaParametro("@Activos", "", 0)
        Cmb_ClientesP.AgregaParametro("@Id_CajaBancaria", 0, 1)
        Cmb_ClientesP.AgregaParametro("@Id_Cia", 0, 1)
        Cmb_ClientesP.Actualizar()

        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()
        Cmb_Compañia.Actualizar()

        lsv_Dotaciones.Columns.Add("Remision")
        lsv_Dotaciones.Columns.Add("Fecha")
        lsv_Dotaciones.Columns.Add("Sesion")
        lsv_Dotaciones.Columns.Add("Cliente")
        lsv_Dotaciones.Columns.Add("Moneda")
        lsv_Dotaciones.Columns.Add("Importe")
        lsv_Dotaciones.Columns.Add("Envases")
        lsv_Dotaciones.Columns.Add("EnvasesSN")
        lsv_Dotaciones.Columns.Add("Status")

        lsv_Desglose.Columns.Add("Presentacion")
        lsv_Desglose.Columns.Add("Denominacion")
        lsv_Desglose.Columns.Add("Cantidad")
        lsv_Desglose.Columns.Add("Importe")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Dim Dpto As String = ""
        LimpiarListas()
        Me.Refresh()
        If Validar() Then
            If rdb_Proceso.Checked Then
                Dpto = "P"
            ElseIf rdb_Morralla.Checked Then
                Dpto = "M"
            ElseIf rdb_Todo.Checked Then
                Dpto = "T"
            End If
            If Not fn_DetalleDepositos_LlenarRemisiones(lsv_Dotaciones, cmb_CajaBancaria.SelectedValue, IIf(Chk_Clientes.Checked, 0, Cmb_Clientes.SelectedValue), _
                                                        cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Moneda.SelectedValue, CInt(Cmb_grupo.SelectedValue), Dpto, _
                                                        Cmb_ClientesP.SelectedValue, Cmb_Compañia.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotaciones.Items.Count)
            If lsv_Dotaciones.Items.Count > 0 Then
                btn_Exportar.Enabled = True
                Btn_ExportarEsp.Enabled = True
            Else
                Btn_ExportarEsp.Enabled = False
                btn_Exportar.Enabled = False
            End If
        End If
    End Sub

    Private Sub LlenarClientes()
        If Cmb_Compañia.SelectedValue = 1 Then
            If Chk_Clientes.Checked = False Then
                Cmb_Clientes.Enabled = True
            End If
            Cmb_ClientesP.Enabled = False
            Cmb_ClientesP.Visible = False
            Cmb_ClientesP.SelectedIndex = 0
            Cmb_Clientes.Visible = True
            Cmb_Clientes.Actualizar()
        Else
            If Chk_Clientes.Checked = False Then
                Cmb_ClientesP.Enabled = True
            End If
            Cmb_Clientes.Enabled = False
            Cmb_Clientes.SelectedIndex = 0
            Cmb_ClientesP.Visible = True
            Cmb_Clientes.Visible = False
            Cmb_ClientesP.ActualizaValorParametro("@Activos", "A")
            Cmb_ClientesP.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
            Cmb_ClientesP.ActualizaValorParametro("@Id_Cia", Cmb_Compañia.SelectedValue)
            Cmb_ClientesP.Actualizar()
        End If
    End Sub

    Private Function Validar() As Boolean
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If Cmb_Clientes.SelectedIndex = 0 And Chk_Clientes.Checked = False And Cmb_ClientesP.SelectedIndex = 0 Then
            MsgBox("Seleccione un Cliente o Marque Todos", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Clientes.Focus()
            Cmb_ClientesP.Focus()
            Return False
        End If

        If cmb_Desde.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesión Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Return False
        End If

        If cmb_Hasta.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesión Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Hasta.Focus()
            Return False
        End If

        If cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If

        If chk_Grupo.Checked = False And Cmb_grupo.SelectedValue = 0 Then
            MsgBox("Debe seleccionar un Grupo o marcar la casilla «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_grupo.Focus()
            Return False
        End If

        If rdb_Proceso.Checked = False And rdb_Morralla.Checked = False And rdb_Todo.Checked = False Then
            MsgBox("Debe seleccionar el Tipo de Consulta(Proceso, Morralla o Ambos).", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        Return True
    End Function

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Desde.SelectedValue = cmb_Hasta.SelectedValue
        End If
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Hasta.SelectedValue = cmb_Desde.SelectedValue
        End If
    End Sub

    Private Sub lsv_dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        lsv_Desglose.Items.Clear()
        If lsv_Dotaciones.SelectedItems.Count > 0 Then
            If Not fn_DetalleDepositos_LlenarDetalle(lsv_Desglose, lsv_Dotaciones.SelectedItems(0).Tag, CInt(cmb_Moneda.SelectedValue)) Then
                MsgBox("Ha ocurrido un error al intentar llenar el detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Desglose.Items.Count)
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Call LimpiarListas()
        Cmb_grupo.ActualizaValorParametro("@Id_CajaBancaria", cmb_CajaBancaria.SelectedValue)
        Cmb_grupo.Actualizar()
        If cmb_CajaBancaria.SelectedIndex <> 0 And Cmb_Compañia.SelectedIndex <> 0 Then
            Call LlenarClientes()
        End If
        'If Cmb_grupo.Items.Count >= 2 Then chk_Grupo.Enabled = True Else chk_Grupo.Enabled = False
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If MsgBox("Segun el rango de fechas seleccionado, este reporte puede tardar algunos segundos o incluso minutos en generarse. Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim Dpto As Char = ""
        If rdb_Proceso.Checked Then
            Dpto = "P"
        ElseIf rdb_Morralla.Checked Then
            Dpto = "M"
        ElseIf rdb_Todo.Checked Then
            Dpto = "T"
        End If
        Dim Encabezado1 As String = cmb_CajaBancaria.Text & "   DETALLE DE DEPOSITOS/CONCENTRACIONES(" & cmb_Moneda.Text & ")"
        Dim Encabezado2 As String = "DEL  " & Microsoft.VisualBasic.Left(cmb_Desde.Text, 10) & "  AL  " & Microsoft.VisualBasic.Left(cmb_Hasta.Text, 10)
        If lsv_Dotaciones.Items.Count > 0 Then
            fn_DetalleDepositos_GenerarExcel(cmb_CajaBancaria.SelectedValue, Cmb_Clientes.SelectedValue, cmb_Moneda.SelectedValue, cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, CInt(Cmb_grupo.SelectedValue), Dpto, Encabezado1, Encabezado2, frm_MENU.prg_Barra, Cmb_ClientesP.SelectedValue, Cmb_Compañia.SelectedValue)
        End If
    End Sub

    Private Sub rdb_Proceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Proceso.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0
        lsv_Dotaciones.Items.Clear()
        lsv_Desglose.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_Desglose.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Dotaciones.Items.Count)
        btn_Exportar.Enabled = False
        Btn_ExportarEsp.Enabled = False

    End Sub

    Private Sub chk_Grupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        Call LimpiarListas()
        Cmb_grupo.SelectedIndex = 0
        Cmb_grupo.Enabled = Not chk_Grupo.Checked
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover, gbx_Botones.MouseHover, gbx_Desglose.MouseHover, gbx_Dotaciones.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Moneda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Moneda.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If Cmb_grupo.Enabled Then
                Cmb_grupo.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_Grupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Btn_ExportarEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ExportarEsp.Click
        SegundosDesconexion = 0
        If MsgBox("Segun el rango de fechas seleccionado, este reporte puede tardar algunos segundos o incluso minutos en generarse. Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Dpto As Char = ""
        If rdb_Proceso.Checked Then
            Dpto = "P"
        ElseIf rdb_Morralla.Checked Then
            Dpto = "M"
        ElseIf rdb_Todo.Checked Then
            Dpto = "T"
        End If
        Dim Encabezado1 As String = cmb_CajaBancaria.Text & "   DETALLE DE DEPOSITOS/CONCENTRACIONES(" & cmb_Moneda.Text & ")"
        Dim Encabezado2 As String = "DEL  " & Microsoft.VisualBasic.Left(cmb_Desde.Text, 10) & "  AL  " & Microsoft.VisualBasic.Left(cmb_Hasta.Text, 10)
        If lsv_Dotaciones.Items.Count > 0 Then
            fn_DetalleDepositos_GenerarExcelEspecial(cmb_CajaBancaria.SelectedValue, Cmb_Clientes.SelectedValue, cmb_Moneda.SelectedValue, cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, CInt(Cmb_grupo.SelectedValue), Dpto, Encabezado1, Encabezado2, frm_MENU.prg_Barra, Cmb_ClientesP.SelectedValue, Cmb_Compañia.SelectedValue)
        End If
    End Sub

    Private Sub btn_ExportarVales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarVales.Click
        SegundosDesconexion = 0
        If MsgBox("Segun el rango de fechas seleccionado, este reporte puede tardar algunos segundos o incluso minutos en generarse. Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Dpto As Char = ""
        If rdb_Proceso.Checked Then
            Dpto = "P"
        ElseIf rdb_Morralla.Checked Then
            Dpto = "M"
        ElseIf rdb_Todo.Checked Then
            Dpto = "T"
        End If
        Dim Encabezado1 As String = cmb_CajaBancaria.Text & "   DETALLE DE DEPOSITOS/CONCENTRACIONES(" & cmb_Moneda.Text & ")"
        Dim Encabezado2 As String = "DEL  " & Microsoft.VisualBasic.Left(cmb_Desde.Text, 10) & "  AL  " & Microsoft.VisualBasic.Left(cmb_Hasta.Text, 10)
        If lsv_Dotaciones.Items.Count > 0 Then
            fn_DetalleDepositos_GenerarExcelVales(cmb_CajaBancaria.SelectedValue, Cmb_Clientes.SelectedValue, cmb_Moneda.SelectedValue, cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, CInt(Cmb_grupo.SelectedValue), Dpto, Encabezado1, Encabezado2, frm_MENU.prg_Barra, Cmb_ClientesP.SelectedValue, Cmb_Compañia.SelectedValue)
        End If
    End Sub

    Private Sub chk_Grupo_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Grupo.CheckedChanged
        SegundosDesconexion = 0
        Cmb_grupo.SelectedValue = 0
        Cmb_grupo.Enabled = Not chk_Grupo.Checked
        Call LimpiarListas()

    End Sub

    Public Shared Function fn_DetalleDepositos_GenerarExcel(ByVal Id_CajaBancaria As Integer, ByVal Id_Cliente As Integer, ByVal Id_Moneda As Integer, ByVal Desde As Integer, ByVal Hasta As Integer, ByVal Id_GrupoF As Integer, ByVal Dpto As Char, ByVal Encabezado1 As String, ByVal Encabezado2 As String, ByVal Bar As ToolStripProgressBar, ByVal Id_ClienteP As Integer, ByVal Id_Cia As Integer) As Boolean
        SegundosDesconexion = 0
        Dim Dt_Servicios As DataTable
        Dim Dt_Desglose As DataTable
        Dim Dt_Denominaciones As DataTable
        Dim Dt_Cheques As DataTable
        Dim Servicio, Cliente As Integer
        Dim j As Integer = 4
        Dim Suma As String
        Dim Letra_Final As String
        Dim Letra_FinalN As Integer
        Dim Letra_FinBilletes As Char = "G"
        Dim Letra_FinBilletesN As Integer = 71
        Dim Letra_FinDBilletes As Integer

        Bar.Value = 0
        Dt_Denominaciones = fn_DetalleDepositos_GetDenominaciones(Id_Moneda)
        If Dt_Denominaciones Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar las Denominaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If Dt_Denominaciones.Rows.Count = 0 Then
            MsgBox("No existen Denominaciones para la Moneda seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        'Traer los Depósitos
        Dt_Servicios = fn_DetalleDepositos_GetServicios(Id_CajaBancaria, Id_Cliente, Id_Moneda, Desde, Hasta, Id_GrupoF, Dpto, Id_ClienteP, Id_Cia)
        If Dt_Servicios Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If Dt_Servicios.Rows.Count = 0 Then
            MsgBox("No se econtró información con los parámetros seleccionados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        'Traer el dsglose
        Dt_Desglose = fn_DetalleDepositos_GetDesglose(Id_CajaBancaria, Id_Cliente, Id_Moneda, Desde, Hasta, Id_GrupoF, Dpto, Id_ClienteP, Id_Cia)
        If Dt_Desglose Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar el Desglose de Efectivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        Dt_Cheques = Fn_DetalleDepositos_Cheques(frm_DetalleDepositos.cmb_CajaBancaria.SelectedValue, frm_DetalleDepositos.Cmb_Clientes.SelectedValue, frm_DetalleDepositos.cmb_Desde.SelectedValue, frm_DetalleDepositos.cmb_Hasta.SelectedValue, frm_DetalleDepositos.cmb_Moneda.SelectedValue, True, frm_DetalleDepositos.Cmb_grupo.SelectedValue, Id_ClienteP, Id_Cia)
        If Dt_Cheques Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Cheques.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        If Dt_Desglose.Rows.Count = 0 And Dt_Cheques.Rows.Count = 0 Then
            MsgBox("No se econtró información con los parámetros seleccionados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If

        frm_MENU.prg_Barra.Maximum = Dt_Servicios.Rows.Count + 1
        Bar.Maximum = Dt_Servicios.Rows.Count + 1

        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Dim objExcel As Object
        '-----para Microsoft Office(Excel)
        Try
            ObjetoHC = "Excel.Application"
            objExcel = CreateObject(ObjetoHC)
            versionHC = True
        Catch ex As Exception
            versionHC = False
        End Try

        '-----para KingSoft Office (Spreadsheets) 
        If versionHC = False Then
            Try
                ObjetoHC = "Ket.Application"
                objExcel = CreateObject(ObjetoHC)
                versionHC = True
            Catch ex As Exception
                versionHC = False
            End Try
        End If

        If Not versionHC Then
            MsgBox("No se encontró ningún software para exportar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        With objExcel

            'Creando el libro
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1


            'Creando los encabezados
            .Range("A1:G1").Merge()
            .Range("A2:G2").Merge()
            .Range("A1:A2").Font.Bold = True
            .Range("A1").Value = Encabezado1
            .Range("A2").Value = Encabezado2
            .Range("A3").Value = "FECHA"
            .Range("B3").Value = "REMISION"
            .Range("C3").Value = "ORIGEN"
            .Range("D3").Value = "IMPORTE TOTAL"
            .Range("E3").Value = "ENVASES"
            .Range("F3").Value = "BOLSAS"
            .Range("G3").Value = "MAZOS"

            For Each row As DataRow In Dt_Denominaciones.Rows
                If Microsoft.VisualBasic.Left(row("presentacion"), 1) = "B" Then
                    Letra_FinDBilletes += 1
                End If
                .Range(LetrA(72 + Dt_Denominaciones.Rows.IndexOf(row)) & 2).Value = Microsoft.VisualBasic.Left(row("Presentacion"), 1)
                .Range(LetrA(72 + Dt_Denominaciones.Rows.IndexOf(row)) & 3).Value = CDec(row("Denominacion"))
                If Microsoft.VisualBasic.Left(row("Presentacion"), 1) = "M" Then
                    .Range(LetrA(72 + Dt_Denominaciones.Rows.IndexOf(row)) & 1).Value = row("CantidadXbolsa")
                Else
                    Letra_FinBilletes = LetrA(72 + Dt_Denominaciones.Rows.IndexOf(row))
                    Letra_FinBilletesN = 72 + Dt_Denominaciones.Rows.IndexOf(row)
                End If
                Letra_Final = 72 + Dt_Denominaciones.Rows.IndexOf(row)
                Letra_FinalN = 72 + Dt_Denominaciones.Rows.IndexOf(row)
            Next

            Dim Fila_Anterior As Integer = 1 'para controlar el ciclo del Efectivo y Cheques
            Servicio = 0
            Cliente = 0
            For Each Dr_Servicio As DataRow In Dt_Servicios.Rows
                If Servicio = 0 And Cliente = 0 Then
                    Servicio = Dr_Servicio.Item("Id_Servicio")
                    Cliente = Dr_Servicio.Item("Id_ClienteP")
                ElseIf Servicio <> Dr_Servicio.Item("Id_Servicio") Or Cliente <> Dr_Servicio.Item("Id_ClienteP") Then
                    Servicio = Dr_Servicio.Item("Id_Servicio")
                    Cliente = Dr_Servicio.Item("Id_ClienteP")
                    j += 1
                End If

                .Range("A" & j).Value = Format(CDate(Dr_Servicio.Item("Fecha")), "MM/dd/yyyy") 'Dr_Servicio.Item("Fecha") 
                .Range("B" & j).Value = Dr_Servicio.Item("Remision")
                .Range("C" & j).Value = Dr_Servicio.Item("Cliente")
                .Range("D" & j).Value = Dr_Servicio.Item("Importe")
                .Range("E" & j).Value = Dr_Servicio.Item("Envases") + Dr_Servicio.Item("EnvasesSN")
                .Range("F" & j).Value = 0
                .Range("G" & j).Value = 0
                .Range("D" & j).NumberFormat = "#,##0.00"

                Dim EfectivoTemporal() As DataRow

                If Fila_Anterior <> j Then
                    Fila_Anterior = j
                    'Efectivo
                    EfectivoTemporal = Dt_Desglose.Select("Id_Servicio=" & Dr_Servicio("Id_Servicio"))

                    For IEfe As Integer = 0 To EfectivoTemporal.Length - 1
                        For Each row As DataRow In Dt_Denominaciones.Rows
                            If row.Item("Id_Denominacion") = EfectivoTemporal(IEfe)("Id_Denominacion") Then
                                .Range(LetrA(72 + Dt_Denominaciones.Rows.IndexOf(row)) & j).Value = EfectivoTemporal(IEfe)("Cantidad")
                                Dim columna As Integer = 72 + Dt_Denominaciones.Rows.Count - 1
                                Exit For
                            End If
                        Next
                    Next IEfe

                    Dim ChequesTemporales() As DataRow
                    ChequesTemporales = Dt_Cheques.Select("Id_Servicio=" & Dr_Servicio("Id_Servicio"))
                    If ChequesTemporales.Length > 0 Then
                        Dim Formula As String

                        .Range(LetrA(Letra_Final + 1) & j).FormulaLocal = "=SI(SUMA(" & LetrA(Letra_Final + 2) & j & "+" & LetrA(Letra_Final + 3) & j & ") = 0,"""",SUMA(" & LetrA(Letra_Final + 2) & j & "+" & LetrA(Letra_Final + 3) & j & "))"

                        If ChequesTemporales(0)("cheques_propios") > 0 Then
                            .Range(LetrA(Letra_Final + 2) & j).value = ChequesTemporales(0)("cheques_propios")
                        End If
                        If ChequesTemporales(0)("cheques_otros") > 0 Then
                            .Range(LetrA(Letra_Final + 3) & j).value = ChequesTemporales(0)("cheques_otros")
                        End If
                        If ChequesTemporales(0)("Importe_Cheques") > 0 Then
                            .Range(LetrA(Letra_Final + 4) & j).value = ChequesTemporales(0)("Importe_Cheques")
                        End If
                        If ChequesTemporales(0)("Cheques_PropiosImp") > 0 Then
                            .Range(LetrA(Letra_Final + 5) & j).value = ChequesTemporales(0)("Cheques_PropiosImp")
                        End If
                        If ChequesTemporales(0)("Cheques_OtrosImp") > 0 Then
                            .Range(LetrA(Letra_Final + 6) & j).value = ChequesTemporales(0)("Cheques_OtrosImp")
                        End If


                        Dim ColumnaF As Integer = Letra_Final
                        Formula = "="
                        For Each t As DataRow In Dt_Denominaciones.Rows
                            If ColumnaF = 89 And j = 4 Then
                                Formula = "=(" & LetrA(ColumnaF) & 3 & "*" & LetrA(ColumnaF) & j & ")"
                            Else
                                Formula &= "+" & "(" & LetrA(ColumnaF) & 3 & "*" & LetrA(ColumnaF) & j & ")"
                            End If
                            ColumnaF -= 1
                        Next
                        Formula &= "+(" & (LetrA(Letra_Final + 4) & j) & ")"
                        .Range(LetrA(Letra_Final + 7) & j).FormulaLocal = Formula
                    End If
                End If
                Bar.Value += 1
            Next

            .Range(LetrA(Letra_Final + 1) & 3).Value = "CANT CHEQUES"
            .Range(LetrA(Letra_Final + 2) & 3).Value = "CANT PROPIOS"
            .Range(LetrA(Letra_Final + 3) & 3).Value = "CANT OTROS"
            .Range(LetrA(Letra_Final + 4) & 3).Value = "CHEQUES IMPORTE"
            .Range(LetrA(Letra_Final + 5) & 3).Value = "PROPIOS IMPORTE"
            .Range(LetrA(Letra_Final + 6) & 3).Value = "OTROS IMPORTE"
            .Range(LetrA(Letra_Final + 7) & 3).value = "COMPROBACION"

            'MAZOS Y BOLSAS
            Suma = "=Suma"
            Dim Bolsas As Decimal = 0.0

            Dim BolsasT As Decimal = 0.0
            For I As Integer = 4 To j
                BolsasT = 0

                For k = Letra_FinBilletesN + 1 To Letra_FinalN
                    If .range(LetrA(k) & I).value IsNot Nothing Then
                        Bolsas = CDec(.range(LetrA(k) & I).value) / .range(LetrA(k) & 1).value
                        BolsasT += Bolsas
                    End If
                Next
                .Range("F" & I).value = BolsasT
                If Letra_FinBilletesN = 71 Then
                    .Range("G" & I).Formula = 0
                Else
                    .Range("G" & I).FormulaLocal = Suma & "(H" & I & ":" & LetrA(71 + Letra_FinDBilletes) & I & ")/1000"
                End If

                .Range("F" & I).NumberFormat = "#,##0.000"
                .Range("G" & I).NumberFormat = "#,##0.000"
            Next
            'Limpiar las cantidades por bolsa
            For k = Letra_FinBilletesN + 1 To Letra_FinalN
                .range(LetrA(k) & 1).value = ""
            Next
            'SUMATORIAS
            j += 1
            For I As Integer = 68 To Letra_FinalN + 7
                .Range(LetrA(I) & j).FormulaLocal = Suma & "(" & LetrA(I) & 4 & ":" & LetrA(I) & j - 1 & ")"
            Next

            .Range("H2:" & LetrA(Letra_Final) & 2).Borders.Value = True
            Letra_Final = LetrA(Letra_Final + 7)

            .Range(Letra_Final & 3).ColumnWidth = 16
            .Range("H2:Y2").Font.Bold = True
            .Range("A3:" & Letra_Final & 3).Wraptext = True
            .Range("A3:" & Letra_Final & 3).RowHeight = 35
            .Range("A3:" & Letra_Final & 3).Font.Bold = True
            .Range("A3:" & Letra_Final & j).Borders.Value = True
            .Range("A" & j & ":" & Letra_Final & j).Font.Bold = True
            .Range("D" & j & ":" & Letra_Final & j).NumberFormat = "#,##0.00"
            .Range(Letra_Final & 4 & ":" & Letra_Final & j).NumberFormat = "#,##0.00"

            'Mostrando el libro
            .Range("A:" & Letra_Final).EntireColumn.AutoFit()
            .Visible = True

        End With
        Bar.Value = Bar.Maximum
        Return True
        Bar.Value = Bar.Minimum
    End Function

    Private Sub cmb_Hasta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Cmb_grupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_grupo.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Morralla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Morralla.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub rdb_Todo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Todo.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub

    Private Sub Chk_Clientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Clientes.CheckedChanged
        SegundosDesconexion = 0
        Cmb_Clientes.SelectedValue = 0
        Cmb_ClientesP.SelectedIndex = 0
        Cmb_Clientes.Enabled = Not Chk_Clientes.Checked
        Cmb_ClientesP.Enabled = Not Chk_Clientes.Checked

    End Sub

    Private Sub Cmb_Compañia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Compañia.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
        If cmb_CajaBancaria.SelectedIndex <> 0 And Cmb_Compañia.SelectedIndex <> 0 Then
            Call LlenarClientes()
        End If
        Cmb_Clientes.SelectedValue = 0
        Cmb_ClientesP.SelectedIndex = 0
    End Sub

    Private Sub Cmb_ClientesP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_ClientesP.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LimpiarListas()
    End Sub


End Class