Public Class frm_Dialogo2014

    Enum TipoR As Byte
        Dotacion = 1
        Envio_Efectivo = 2
        Resguardo = 3
        Dotacion_Flotante = 4
        Entrada_Efectivo = 5
    End Enum

    Public IdCajaBancariaD As Integer
    Public Tipo_Lote As Integer
    Public Envases As Integer = 0
    Public EnvasesSN As Integer = 0
    Public Cantidad_Sobres As Integer = 0
    Public IdCajaBancaria As Integer = 0
    Public ImporteTotal As Decimal = 0.0
    Public Tipo As TipoR = TipoR.Dotacion
    'Public Info(3) As String ' Data Reader
    Public DotacionID As Integer = 0
    Public Id_Moneda As Integer = 0
    Public TipodeCambio As Decimal = 1D
    Public Nombre_Origen As String = ""
    Public Clave_Destino As String = ""
    Public Clave_Plantilla As String = ""
    Public Nombre_Destino As String = ""
    Public Domicilio_Origen As String = ""
    Public Domicilio_Destino As String = ""
    Public CiaTV As String = ""
    Public Denominaciones As DataTable
    Public Importe_Doc As Decimal = 0
    Public Importe_Efectivo As Decimal = 0
    Public IdCliente As Long
    Public Moneda As Integer = MonedaID
    'Private Info(3) As String
    ''Nuevo
    Dim Id_R As Integer
    Dim Numero As Integer
    Public faltante As Boolean = False
    Public Utiliza_Rd As String = "N"

    Private Sub frm_Dialago2014_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_CiaTV.Text = Cn_Proceso.fn_ValidaMateriales_Cia(CiaId)
        cmb_TipoEnvase.Actualizar()
        'cmb_TipoEnvase.Text = "MATERIAL"
        cmb_TipoEnvase.Enabled = True

        cmb_TipoImpresion.AgregarItem("P", "SOLO PIEZAS")
        cmb_TipoImpresion.AgregarItem("I", "SOLO IMPORTES")
        cmb_TipoImpresion.AgregarItem("PI", "PIEZAS E IMPORTES")
        cmb_TipoImpresion.Visible = False

        Dim dt_Plantilla As DataTable = Cn_Proceso.fn_ConsultarPlantilla()
        If dt_Plantilla Is Nothing Then
            MsgBox("Ocurrió un Error al intentar obtener los Datos de la Plantilla de Impresión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If
        If dt_Plantilla.Rows.Count = 0 Then
            MsgBox("No se encontraron los Datos de la Plantilla de Impresión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If

        If Id_Moneda <> MonedaId Then
            rdo_No.Checked = True
            rdo_No.Enabled = False
            rdo_Si.Enabled = False
        End If

        If Tipo = TipoR.Dotacion Then
            lbl_NombreCliente.Text = Nombre_Destino
            lbl_NombreCompañia.Text = Nombre_Origen
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_Clave.Text = Clave_Destino
            lbl_CiaTV.Text = CiaTV
            lbl_CiaTV.Visible = True
            Clave_Plantilla = dt_Plantilla.Rows(0)("PlantillaDotacion")
        ElseIf Tipo = TipoR.Envio_Efectivo Then
            lbl_NombreCliente.Text = Nombre_Origen
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_CiaTV.Visible = False
            Clave_Plantilla = dt_Plantilla.Rows(0)("PlantillaEfectivo")
        ElseIf Tipo = TipoR.Resguardo Then
            lbl_NombreCliente.Text = Nombre_Origen
            lbl_NombreCompañia.Text = Nombre_Destino
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_CiaTV.Visible = False
            Clave_Plantilla = dt_Plantilla.Rows(0)("PlantillaResguardo")
        ElseIf Tipo = TipoR.Dotacion_Flotante Then

        ElseIf Tipo = TipoR.Entrada_Efectivo Then
            lbl_NombreCliente.Text = Nombre_Origen
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_CiaTV.Visible = False
            btn_Imprimir.Visible = False '--
            btn_Guardar.Enabled = True
        End If
        lsv_Envases.Columns.Add("Tipo de Envase")
        lsv_Envases.Columns.Add("Numero de Envase")
        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 45, 0, 0, 0, 0, 0, 0, 0, 0)

        btn_Guardar.Enabled = False
        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False

        ''Remisiones 
        Generar_RemisionD()
    End Sub
    Public Function Generar_RemisionD()
        Dim data As DataTable
        data = Cn_Proceso.fn_Cliente_Padre(IdCliente)
        If data.Rows.Count > 0 Then
            If data.Rows(0)("UtilizaRemisionD") = "S" Then
                Obtener_NumeroRemision()
                Utiliza_Rd = "S"
                btn_Guardar.Enabled = True
                btn_Imprimir.Enabled = False
            End If
        End If
    End Function

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        'Inicializar la variable de desconexion
        'SegundosDesconexion = 0
        'For Each item As ListViewItem In lsv_Envases.Items
        '    If item.SubItems(1).Text = tbx_Numero.Text.Trim Then
        '        MsgBox("El Envase ya existe en la Lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        '        Exit Sub
        '    End If
        'Next
        'If cmb_TipoEnvase.SelectedValue = 0 Or tbx_Numero.Text.Trim = "" Then
        '    Exit Sub
        'Else
        '    With lsv_Envases.Items.Add(cmb_TipoEnvase.Text)
        '        .Tag = cmb_TipoEnvase.SelectedValue.ToString
        '        .SubItems.Add(tbx_Numero.Text.Trim)
        '    End With
        'End If
        'tbx_Numero.Clear()
        'tbx_Numero.Focus()

        SegundosDesconexion = 0

        If tbx_Numero.Text = "" Then
            MsgBox("Indique el Número del Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.Focus()
            Exit Sub
        End If
        If cmb_TipoEnvase.SelectedValue = 0 Then
            MsgBox("Indique el Tipo de Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoEnvase.Focus()
            Exit Sub
        End If
        Dim Fila_Inicial As Integer = 0

        If FuncionesGlobales.fn_Buscar_enListView(lsv_Envases, tbx_Numero.Text, 2, 0) Then
            MsgBox("En envase indicado ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.SelectAll()
            tbx_Numero.Focus()
            Exit Sub
        End If
        lsv_Envases.Items.Add(cmb_TipoEnvase.Text)
        lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = cmb_TipoEnvase.SelectedValue.ToString
        lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(tbx_Numero.Text)
        tbx_Numero.Text = ""
        tbx_Numero.Focus()
    End Sub

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        If Utiliza_Rd = "S" Then Regresar_StatusRemision()
        Me.Close()
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0
        Dim Contador As Integer = 0
        Dim Cadena As String = ""
        Dim Sellos As String = ""
        Dim EnvasesBillete As Integer = 0
        Dim EnvasesMorralla As Integer = 0
        Dim EnvasesDcumentos As Integer = 0
        Dim EnvasesSN As Integer = 0

        If Not ValidarDatosRemision(EnvasesBillete, EnvasesMorralla, EnvasesDcumentos, EnvasesSN) Then
            Exit Sub 'salir en caso de no cumplir validaciones
        End If
        If rdo_No.Checked = False And rdo_Si.Checked = False Then
            MsgBox("Indique si se imprimirá el Desglose de Denominaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            Exit Sub
        End If
        If cmb_TipoImpresion.Visible Then
            If cmb_TipoImpresion.SelectedValue = "0" Then
                MsgBox("Seleccione como desea imprimir el Desglose por Denominación.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_TipoImpresion.Focus()
                Exit Sub
            End If
        End If
        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.SelectAll()
            tbx_Remision.Focus()
            Exit Sub
        End If
        If Cn_Proceso.fn_Remision_Existe(CLng(tbx_Remision.Text), CiaId) = True Then
            MsgBox("El Número de Remisión capturado ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.SelectAll()
            tbx_Remision.Focus()
            Exit Sub
        End If
        If tbx_Envases.Text.Trim = "" Then tbx_Envases.Text = "0"
        Envases = lsv_Envases.Items.Count
        EnvasesSN = CInt(tbx_Envases.Text)
        Contador = Envases + EnvasesSN
        If Contador = 0 Then
            MsgBox("Indique por lo menos un Envase para poder continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.SelectAll()
            tbx_Numero.Focus()
            Exit Sub
        End If
        If lsv_Envases.Items.Count > 0 Then
            For I As Integer = 0 To lsv_Envases.Items.Count - 1
                If I = 0 Then
                    Sellos = lsv_Envases.Items(I).SubItems(1).Text
                Else
                    Sellos = Sellos & ", " & lsv_Envases.Items(I).SubItems(1).Text
                End If
            Next
        End If

        'Leer los datos de Origen
        Dim dt_Origen As DataTable = Cn_Proceso.fn_Sucursales_ReadDatos()
        If dt_Origen Is Nothing Then
            MsgBox("Ocurrió un Error al intentar obtener los Datos de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Origen.Rows.Count = 0 Then
            MsgBox("Ocurrió un Error al intentar obtener los Datos de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Domicilio_Origen = dt_Origen.Rows(0)("Direccion") & ", " & dt_Origen.Rows(0)("Ciudad") & ", " & dt_Origen.Rows(0)("Estado")
        'Declaracion de tablas y variables para la impresion
        Dim Dt_DotacionesRem As DataTable = Nothing
        Dim Dt_Impresion As DataTable = Nothing
        Dim Dt_DotacionesD As DataTable = Nothing
        Dim B1000 As Decimal = 0.0
        Dim B500 As Decimal = 0.0
        Dim B200 As Decimal = 0.0
        Dim B100 As Decimal = 0.0
        Dim B50 As Decimal = 0.0
        Dim B20 As Decimal = 0.0
        Dim B10 As Decimal = 0.0
        Dim B5 As Decimal = 0.0
        Dim B2 As Decimal = 0.0
        Dim B1 As Decimal = 0.0
        Dim M100 As Decimal = 0.0
        Dim M50 As Decimal = 0.0
        Dim M20 As Decimal = 0.0
        Dim M10 As Decimal = 0.0
        Dim M5 As Decimal = 0.0
        Dim M2 As Decimal = 0.0
        Dim M1 As Decimal = 0.0
        Dim M05 As Decimal = 0.0
        Dim M02 As Decimal = 0.0
        Dim M025 As Decimal = 0.0
        Dim M01 As Decimal = 0.0
        Dim M005 As Decimal = 0.0
        Dim M002 As Decimal = 0.0
        Dim M001 As Decimal = 0.0
        'Case de Denominaciones y dt_Impresion
        Select Case Tipo
            Case TipoR.Dotacion
                Dt_DotacionesRem = Cn_Proceso.fn_ConsultaDotaciones_ImprimeRemision(DotacionID)
                If Dt_DotacionesRem Is Nothing Then
                    MsgBox("Error al Cargar los Importes.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                If Dt_DotacionesRem.Rows.Count = 0 Then
                    MsgBox("No se encontró información de la Dotación.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                Dt_DotacionesD = Cn_Proceso.fn_ConsultaDotacionesD_ImprimeRemision(DotacionID)
                If Dt_DotacionesD Is Nothing Then
                    MsgBox("Error al Cargar las Denominaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                'Esta validacion se elimina ya que si existen dotaciones sin desglose (Documentos)
                'If Dt_DotacionesD.Rows.Count = 0 Then
                '    MsgBox("No hay Información a Imprimir.", MsgBoxStyle.Critical, frm_MENU.Text)
                '    Exit Sub
                'End If
                For I As Integer = 0 To Dt_DotacionesD.Rows.Count - 1
                    If Dt_DotacionesD.Rows(I)("Presentacion") = "B" Then
                        Select Case Dt_DotacionesD.Rows(I)("Denominacion")
                            Case 1000
                                B1000 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 500
                                B500 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 200
                                B200 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 100
                                B100 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 50
                                B50 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 20
                                B20 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 10
                                B10 = Dt_DotacionesD.Rows(I)("Cantidad")
                        End Select
                    ElseIf Dt_DotacionesD.Rows(I)("Presentacion") = "M" Then
                        Select Case Dt_DotacionesD.Rows(I)("Denominacion")
                            Case 100
                                M100 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 50
                                M50 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 20
                                M20 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 10
                                M10 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 5
                                M5 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 2
                                M2 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 1
                                M1 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 0.5
                                M05 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 0.2
                                M02 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 0.1
                                M01 = Dt_DotacionesD.Rows(I)("Cantidad")
                            Case 0.05
                                M005 = Dt_DotacionesD.Rows(I)("Cantidad")
                        End Select
                    End If
                Next
                Dt_Impresion = Cn_Proceso.fn_ConsultarPlantillaCampos(Clave_Plantilla)
            Case TipoR.Envio_Efectivo
                If Id_Moneda = MonedaId Then 'Moneda Nacional
                    For Each Row As DataRow In Denominaciones.Rows
                        If Row("Presentacion") = "BILLETE" Then
                            Select Case Decimal.Parse(Row("Moneda"))
                                Case 1000
                                    B1000 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 500
                                    B500 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 200
                                    B200 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 100
                                    B100 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 50
                                    B50 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 20
                                    B20 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 10
                                    B10 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 5
                                    B5 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 2
                                    B2 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 1
                                    B1 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                            End Select
                        ElseIf Row("Presentacion") = "MONEDA" Then
                            Select Case Decimal.Parse(Row("Moneda"))
                                Case 100
                                    M100 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 50
                                    M50 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 20
                                    M20 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 10
                                    M10 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 5
                                    M5 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 2
                                    M2 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 1
                                    M1 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 0.5
                                    M05 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 0.2
                                    M02 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 0.1
                                    M01 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                                Case 0.05
                                    M005 = Row("Cantidad") + Row("Cantidad1") + Row("Cantidad2") + Row("Cantidad3") + Row("Cantidad4") + Row("Cantidad5")
                            End Select
                        End If

                    Next
                End If
                Dt_Impresion = Cn_Proceso.fn_ConsultarPlantillaCampos(Clave_Plantilla)
            Case TipoR.Resguardo
                If Id_Moneda = MonedaId Then 'Moneda Nacional
                    For Each Row As DataRow In Denominaciones.Rows
                        If Row("Presentacion") = "BILLETE" Then
                            Select Case Decimal.Parse(Row("Denominacion"))
                                Case Decimal.Parse(1000)
                                    B1000 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(500)
                                    B500 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(200)
                                    B200 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(100)
                                    B100 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(50)
                                    B50 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(20)
                                    B20 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(10)
                                    B10 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(5)
                                    B5 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(2)
                                    B2 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(1)
                                    B1 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                            End Select
                        ElseIf Row("Presentacion") = "MONEDA" Then
                            Select Case Decimal.Parse(Row("Denominacion"))
                                Case Decimal.Parse(100)
                                    M100 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(50)
                                    M50 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(20)
                                    M20 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(10)
                                    M10 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(5)
                                    M5 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(2)
                                    M2 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(1)
                                    M1 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(0.5)
                                    M05 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(0.2) 
                                    M02 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(0.1)
                                    M01 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                                Case Decimal.Parse(0.05)
                                    M005 = Row("Resguardar") + Row("ResguardarA") + Row("ResguardarB") + Row("ResguardarC") + Row("ResguardarD") + Row("ResguardarE")
                            End Select
                        End If


                    Next
                End If
                Dt_Impresion = Cn_Proceso.fn_ConsultarPlantillaCampos(Clave_Plantilla)
        End Select
        If Dt_Impresion Is Nothing Then
            Me.Cursor = Cursors.Default
            MsgBox("Ocurrió un Error al intentar consultar la Plantilla para Impresión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Dt_Impresion.Rows.Count = 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("No se encontró Información para la Plantilla de Impresión. Consulte al Administrador del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dt_Impresion.Columns.Add("Valor")
        For Each dr_Impresion As DataRow In Dt_Impresion.Rows
            dr_Impresion("Valor") = ""
            Select Case dr_Impresion("Nombre").ToString.ToUpper
                Case "NOMBRECIA" 'Impresion Cia
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = "Traslada: " & lbl_CiaTV.Text
                    End Select
                Case "CLAVERUTA" 'Impresion Ruta
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = Clave_Destino
                    End Select
                Case "NUMEROUNIDAD"
                    dr_Impresion("Valor") = ""
                Case "FECHA"
                    dr_Impresion("Valor") = Date.Today.ToShortDateString
                Case "HORARIOMATUTINO"
                    dr_Impresion("Valor") = ""
                Case "HORARIOVESPERTINO"
                    dr_Impresion("Valor") = ""
                Case "HORARIONOCTURNO"
                    dr_Impresion("Valor") = ""
                Case "SERVICIONORMAL"
                    dr_Impresion("Valor") = ""
                Case "SERVICIOEXTRAORDINARIO"
                    dr_Impresion("Valor") = ""
                Case "CLAVECLIENTEORIGEN"
                    dr_Impresion("Valor") = ""
                Case "CLIENTEORIGEN" 'Impresion Cliente Origen
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = dt_Origen.Rows(0)("Empresa")
                        Case TipoR.Envio_Efectivo
                            dr_Impresion("Valor") = lbl_NombreCompañia.Text
                        Case TipoR.Resguardo
                            dr_Impresion("Valor") = lbl_NombreCompañia.Text
                    End Select
                Case "DIRECCIONORIGEN"
                    dr_Impresion("Valor") = Domicilio_Origen
                Case "CLAVECLIENTEDESTINO"
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = "Cte: " & Clave_Destino
                    End Select
                Case "CLIENTEDESTINO"
                    dr_Impresion("Valor") = lbl_NombreCliente.Text
                Case "DIRECCIONDESTINO"
                    dr_Impresion("Valor") = Domicilio_Destino
                Case "IMPORTEEFECTIVO" 'Impresion Efectivo
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = ""
                        Case TipoR.Envio_Efectivo
                            dr_Impresion("Valor") = Format(ImporteTotal, "n2")
                        Case TipoR.Resguardo
                            dr_Impresion("Valor") = Format(ImporteTotal, "n2")
                    End Select
                Case "IMPORTEDOCTOS" ' Impresion Doctos
                    dr_Impresion("Valor") = ""
                Case "IMPORTEMONEDANACIONAL" 'Impresion Moneda Nacional
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = Format(IIf(Dt_DotacionesRem.Rows(0)("Id_Moneda") = MonedaId, Dt_DotacionesRem.Rows(0)("Importe_Efectivo"), 0), "n2")
                        Case TipoR.Envio_Efectivo
                            dr_Impresion("Valor") = Format(IIf(Id_Moneda = MonedaId, ImporteTotal, 0), "n2")
                        Case TipoR.Resguardo
                            dr_Impresion("Valor") = Format(IIf(Id_Moneda = MonedaId, ImporteTotal, 0), "n2")
                    End Select
                Case "IMPORTEMONEDAEXTRANJERA" 'Impresion Moneda Extranjera
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = Format(IIf(Dt_DotacionesRem.Rows(0)("Id_Moneda") = MonedaId, 0, Dt_DotacionesRem.Rows(0)("Importe_Efectivo")), "n2")
                        Case TipoR.Envio_Efectivo
                            dr_Impresion("Valor") = Format(IIf(Id_Moneda = MonedaId, 0, ImporteTotal), "n2")
                        Case TipoR.Resguardo
                            dr_Impresion("Valor") = Format(IIf(Id_Moneda = MonedaId, 0, ImporteTotal), "n2")
                    End Select
                Case "IMPORTEOTROS" 'Impresion Equivalente Moneda Nacional
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = Format(CDec(Dt_DotacionesRem.Rows(0)("Importe_Documentos")), "n2")
                        Case TipoR.Envio_Efectivo
                            dr_Impresion("Valor") = Format(0, "n2")
                        Case TipoR.Resguardo
                            dr_Impresion("Valor") = Format(0, "n2")
                    End Select
                Case "IMPORTEEQUIVALENTEMN" 'Impresion Equivalente Moneda Nacional
                    dr_Impresion("Valor") = ""
                Case "IMPORTETOTAL"
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = Format(CDec(Dt_DotacionesRem.Rows(0)("Importe")), "n2")
                        Case TipoR.Envio_Efectivo
                            dr_Impresion("Valor") = Format(ImporteTotal, "N2")
                        Case TipoR.Resguardo
                            dr_Impresion("Valor") = Format(ImporteTotal, "N2")
                    End Select
                Case "ENVASESBILLETES"
                    dr_Impresion("Valor") = EnvasesBillete
                Case "ENVASESMORRALLA"
                    dr_Impresion("Valor") = EnvasesMorralla & " + " & EnvasesSN & " SN"
                Case "ENVASESOTROS"
                    dr_Impresion("Valor") = 0
                Case "ENVASESDOCUMENTOS"
                    dr_Impresion("Valor") = EnvasesDcumentos & " (Otros)"
                Case "ENVASESSN"
                    dr_Impresion("Valor") = ""
                Case "ENVASESTOTAL"
                    dr_Impresion("Valor") = Contador
                Case "CANTIDADLETRA"
                    Select Case Tipo
                        Case TipoR.Dotacion
                            dr_Impresion("Valor") = FuncionesGlobales.fn_EnLetras(Dt_DotacionesRem.Rows(0)("Importe"), Dt_DotacionesRem.Rows(0)("Id_Moneda"))
                        Case TipoR.Envio_Efectivo
                            dr_Impresion("Valor") = FuncionesGlobales.fn_EnLetras(ImporteTotal, Id_Moneda)
                        Case TipoR.Resguardo
                            dr_Impresion("Valor") = FuncionesGlobales.fn_EnLetras(ImporteTotal, Id_Moneda)
                    End Select
                Case "NUMEROMACH"
                    dr_Impresion("Valor") = ""
                Case "SELLOS"
                    dr_Impresion("Valor") = Sellos
                Case "DESCRIPCIONMATERIALES"
                    dr_Impresion("Valor") = ""
                Case "HORAREMITENTE"
                    dr_Impresion("Valor") = System.DateTime.Now.ToLongTimeString
                Case "NOMBREREMITENTE"
                    dr_Impresion("Valor") = UsuarioN
                Case "CANTIDADSOBRES"
                    Select Case Tipo
                        Case TipoR.Dotacion
                            If Dt_DotacionesRem.Rows(0)("Cantidad_Sobres") > 0 Then
                                dr_Impresion("Valor") = "SOBRES: " & Dt_DotacionesRem.Rows(0)("Cantidad_Sobres")
                            End If
                    End Select
                Case "B1000P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B1000, "N2")
                    End If
                Case "B1000I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B1000 * 1000, "N2")
                    End If
                Case "B0500P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B500, "N2")
                    End If
                Case "B0500I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B500 * 500, "N2")
                    End If
                Case "B0200P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B200, "N2")
                    End If
                Case "B0200I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B200 * 200, "N2")
                    End If
                Case "B0100P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B100, "N2")
                    End If
                Case "B0100I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B100 * 100, "N2")
                    End If
                Case "B0050P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B50, "N2")
                    End If
                Case "B0050I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B50 * 50, "N2")
                    End If
                Case "B0020P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B20, "N2")
                    End If
                Case "B0020I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B20 * 20, "N2")
                    End If
                Case "B0010P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B10, "N2")
                    End If
                Case "B0010I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B10 * 10, "N2")
                    End If
                Case "B0005P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B5, "N2")
                    End If
                Case "B0005I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B5 * 5, "N2")
                    End If
                Case "B0002P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B2, "N2")
                    End If
                Case "B0002I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B2 * 2, "N2")
                    End If
                Case "B0001P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B1, "N2")
                    End If
                Case "B0001I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(B1 * 1, "N2")
                    End If
                Case "M0100P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M100, "N2")
                    End If
                Case "M0100I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M100 * 100, "N2")
                    End If
                Case "M0050P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M50, "N2")
                    End If
                Case "M0050I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M50 * 50, "N2")
                    End If
                Case "M0020P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M20, "N2")
                    End If
                Case "M0020I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M20 * 20, "N2")
                    End If
                Case "M0010P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M10, "N2")
                    End If
                Case "M0010I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M10 * 10, "N2")
                    End If
                Case "M0005P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M5, "N2")
                    End If
                Case "M0005I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M5 * 5, "N2")
                    End If
                Case "M0002P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M2, "N2")
                    End If
                Case "M0002I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M2 * 2, "N2")
                    End If
                Case "M0001P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M1, "N2")
                    End If
                Case "M0001I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M1 * 1, "N2")
                    End If
                Case "M0C50P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M05, "N2")
                    End If
                Case "M0C50I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M05 * 0.5, "N2")
                    End If
                Case "M0C25P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M025, "N2")
                    End If
                Case "M0C25I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M025 * 0.25, "N2")
                    End If
                Case "M0C20P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M02, "N2")
                    End If
                Case "M0C20I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M02 * 0.2, "N2")
                    End If
                Case "M0C10P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M01, "N2")
                    End If
                Case "M0C10I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M01 * 0.1, "N2")
                    End If
                Case "M0C05P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M005, "N2")
                    End If
                Case "M0C05I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M005 * 0.05, "N2")
                    End If
                Case "M0C02P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M002, "N2")
                    End If
                Case "M0C02I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M002 * 0.02, "N2")
                    End If
                Case "M0C01P"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "P") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M001, "N2")
                    End If
                Case "M0C01I"
                    If (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "I") Or (rdo_Si.Checked And cmb_TipoImpresion.SelectedValue = "PI") Then
                        dr_Impresion("Valor") = Format(M001 * 0.01, "N2")
                    End If
                Case "TOTALEFECTIVODESGLOSE"
                    If rdo_Si.Checked Then
                        Select Case Tipo
                            Case TipoR.Dotacion
                                dr_Impresion("Valor") = Format(CDec(Dt_DotacionesRem.Rows(0)("Importe_Efectivo")), "n2")
                            Case TipoR.Envio_Efectivo
                                dr_Impresion("Valor") = Format(ImporteTotal, "N2")
                            Case TipoR.Resguardo
                                dr_Impresion("Valor") = Format(ImporteTotal, "N2")
                        End Select
                    End If
            End Select
        Next
        If Not cp_Impresion2014.Imprimir2014(Dt_Impresion) Then
            MsgBox("Ocurrió un Error al intentar Imprimir la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            Exit Sub
        End If
        SegundosDesconexion = 0
        If MsgBox("Se imprimió correctamente ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
            btn_Guardar.Enabled = True
        Else
            btn_Guardar.Enabled = False
        End If
    End Sub

    Function ValidarDatosRemision(ByRef EnvasesBillete As Integer, ByRef EnvasesMorralla As Integer, _
                            ByRef EnvasesDcumentos As Integer, ByRef EnvasesSN As Integer) As Boolean
        SegundosDesconexion = 0
        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            tbx_Remision.Focus()
            Return False
        End If
        'Validar los Envases
        For Each Elemento As ListViewItem In lsv_Envases.Items
            If Microsoft.VisualBasic.Left(Elemento.Text, 2) = "BI" Then EnvasesBillete += 1 : Continue For
            If Microsoft.VisualBasic.Left(Elemento.Text, 2) = "MI" Then EnvasesBillete += 1 : Continue For
            If Microsoft.VisualBasic.Left(Elemento.Text, 2) = "MO" Then EnvasesMorralla += 1 : Continue For
            If Microsoft.VisualBasic.Left(Elemento.Text, 2) = "DO" Then EnvasesDcumentos += 1 : Continue For
            If Microsoft.VisualBasic.Left(Elemento.Text, 2) = "OT" Then EnvasesDcumentos += 1 : Continue For
            If Microsoft.VisualBasic.Left(Elemento.Text, 2) = "MA" Then EnvasesDcumentos += 1 : Continue For
        Next
        If tbx_Envases.Text = "" Then tbx_Envases.Text = "0"
        EnvasesSN = Integer.Parse(tbx_Envases.Text)
        If (lsv_Envases.Items.Count + EnvasesSN) <= 0 Then
            MsgBox("Debe indicar por lo menos un Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            tbx_Numero.Focus()
            Return False
        End If
        ' validar numero de Remision
        If Cn_Proceso.fn_Remision_Existe(CLng(tbx_Remision.Text), CiaId) Then
            MsgBox("El Número de Remisión indicado ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            tbx_Remision.Focus()
            Return False
        End If
        Return True '-->
    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        'Se valida la remision         
        If Utiliza_Rd = "S" Then
            If Cn_Proceso.fn_Remision_Existe(CLng(tbx_Remision.Text), CiaId) = True Then
                MsgBox("El Número de Remisión capturado ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Remision.SelectAll()
                tbx_Remision.Focus()
                Exit Sub
            End If
            If lsv_Envases.Items.Count = 0 Then
                MsgBox("Debe agreagar un envase como minimo. ", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        '
        If Tipo = TipoR.Entrada_Efectivo Then
            'esta validacion es porque no imprime y la validacion esta en Imprimir
            If Not ValidarDatosRemision(0, 0, 0, 0) Then Exit Sub
        End If
        Envases = 0
        EnvasesSN = 0
        Envases = lsv_Envases.Items.Count
        EnvasesSN = Val(tbx_Envases.Text)
     
        Select Case Tipo
            Case TipoR.Dotacion '1 Dotacion...Se le agrego Importe_Documentos
                If Cn_Proceso.fn_ValidaDotRemision_Create(DotacionID, lsv_Envases, Envases, EnvasesSN, CLng(tbx_Remision.Text), IdCajaBancaria, _
                                          ImporteTotal, Id_Moneda, Importe_Doc, Importe_Efectivo) = True Then
                    Cn_Proceso.fn_deleteT(Id_R)
                    MsgBox("La dotacion de efectivo se realizó de manera correcta.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            Case TipoR.Envio_Efectivo '2 Envio de Efectivo
                If Cn_Proceso.Fn_LoteEfectivo_CreateCR(lsv_Envases, Envases, EnvasesSN, CLng(tbx_Remision.Text), IdCajaBancaria, ImporteTotal, _
                                                       Id_Moneda, Tipo_Lote, IdCajaBancariaD) Then
                    Cn_Proceso.fn_deleteT(Id_R)
                    MsgBox("La preparación de envio de efectivo se guardó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
                'If Cn_Proceso.fn_LotesEfectivo_Create(lsv_Envases, Envases, EnvasesSN, tbx_Remision.Text, IdCajaBancaria, _
                '     este estaba antes              ImporteTotal, Id_Moneda) = True Then
                '    MsgBox("Registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                'End If
            Case TipoR.Resguardo '3 Resguardo
                If Cn_Proceso.fn_PreparaResguardo_Create(frm_PrepararResguardo.dt_Resguardos, lsv_Envases, Envases, EnvasesSN, _
                                         CLng(tbx_Remision.Text), IdCajaBancaria, ImporteTotal, Id_Moneda) = True Then
                    Cn_Proceso.fn_deleteT(Id_R)
                    MsgBox("El resguardo de efectivo se realizó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            Case TipoR.Entrada_Efectivo '5 Entrada de efectivo
                If Cn_Proceso.Fn_EntradaSaldo_Guardar(lsv_Envases, Envases, EnvasesSN, CLng(tbx_Remision.Text), IdCajaBancaria, ImporteTotal, _
                                                   Id_Moneda, Tipo_Lote, IdCajaBancariaD) Then
                    Cn_Proceso.fn_deleteT(Id_R)
                    MsgBox("La entrada de efectivo se realizó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
        End Select
        Me.Close()
    End Sub

    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Numero.TextChanged
        Btn_Agregar.Enabled = False
        If tbx_Numero.Text.Trim <> "" Then
            Btn_Agregar.Enabled = True
        End If
    End Sub

    Private Sub rdo_Si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Si.CheckedChanged
        cmb_TipoImpresion.SelectedValue = "0"
        If rdo_Si.Checked Then
            cmb_TipoImpresion.Visible = True
        Else
            cmb_TipoImpresion.Visible = False
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        lsv_Envases.Items(lsv_Envases.SelectedItems(0).Index).Remove()
    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged
        If lsv_Envases.SelectedItems.Count > 0 Then
            btn_Eliminar.Enabled = True
        Else
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub Obtener_NumeroRemision()
        Dim tbl As DataTable
        tbl = Cn_Proceso.fn_VerificarNr(Clave_Destino)
        If (tbl.Rows.Count > 0 And tbl.Rows(0)("Minn").ToString() <> "" And tbl.Rows(0)("ID").ToString() <> "") Then
            tbx_Remision.Text = tbl.Rows(0)("Num").ToString()
            Numero = tbl.Rows(0)("Minn").ToString()
            Id_R = CInt(tbl.Rows(0)("ID").ToString())
            faltante = True
        Else
            Dim table As DataTable = Cn_Proceso.fn_NumeroR(Clave_Destino)
            tbx_Remision.Text = table.Rows(0)(0).ToString()
            Numero = CInt(table.Rows(0)("Num").ToString())
        End If
    End Sub

    Private Sub Regresar_StatusRemision()
        If faltante Then
            Cn_Proceso.fn_RegresarSta(Id_R)
        Else
            Cn_Proceso.fn_Des_Remision(Clave_Destino, Numero)
        End If
    End Sub

    Private Sub frm_Dialogo2014_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If Utiliza_Rd = "S" Then Regresar_StatusRemision()
    End Sub
End Class