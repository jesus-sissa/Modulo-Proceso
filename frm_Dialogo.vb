Public Class frm_Dialogo

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
    Public Info(3) As String
    Public DotacionID As Integer = 0
    Public Id_Moneda As Integer = 0
    Public TipodeCambio As Decimal = 1D
    Public Nombre_Origen As String = ""
    Public Clave_Destino As String = ""
    Public Nombre_Destino As String = ""
    Public Domicilio_Origen As String = ""
    Public Domicilio_Destino As String = ""
    Public CiaTV As String = ""
    Public Denominaciones As DataTable
    Public Importe_Doc As Decimal = 0
    Public Importe_Efectivo As Decimal = 0

    Private Sub frm_Dialago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_TipoImpresion.AgregarItem("P", "SOLO PIEZAS")
        cmb_TipoImpresion.AgregarItem("I", "SOLO IMPORTES")
        cmb_TipoImpresion.AgregarItem("PI", "PIEZAS E IMPORTES")
        cmb_TipoImpresion.Visible = False

        If Id_Moneda <> MonedaId Then
            rdo_No.Checked = True
            rdo_No.Enabled = False
            rdo_Si.Enabled = False
        End If
        btn_Guardar.Enabled = False
        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False

        If Tipo = TipoR.Dotacion Then

            lbl_NombreCliente.Text = Nombre_Destino
            lbl_NombreCompañia.Text = Nombre_Origen
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_Clave.Text = Clave_Destino
            lbl_CiaTV.Text = CiaTV
            lbl_CiaTV.Visible = True

        ElseIf Tipo = TipoR.Envio_Efectivo Then
            lbl_NombreCliente.Text = Info(0)
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_CiaTV.Visible = False

        ElseIf Tipo = TipoR.Resguardo Then
            lbl_NombreCliente.Text = Info(0)
            lbl_NombreCompañia.Text = Info(1)
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_CiaTV.Visible = False
        ElseIf Tipo = TipoR.Dotacion_Flotante Then

        ElseIf Tipo = TipoR.Entrada_Efectivo Then
            lbl_NombreCliente.Text = Info(0)
            lbl_Domicilio.Text = Domicilio_Destino
            lbl_CiaTV.Visible = False
            btn_Imprimir.Visible = False '--
            btn_Guardar.Enabled = True
        End If

        cmb_TipoEnvase.Actualizar()

        lsv_Envases.Columns.Add("Tipo de Envase")
        lsv_Envases.Columns.Add("Numero de Envase")

        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 50, 0, 0, 0, 0, 0, 0, 0, 0)

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
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
        If FuncionesGlobales.fn_Buscar_enListView(lsv_Envases, tbx_Numero.Text, 2, 0) Then
            MsgBox("El envase indicado ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
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

        Me.Close()
    End Sub

    Function ConsultaImportesDotacion(ByRef Remi As cp_Remision) As Boolean
        SegundosDesconexion = 0
        Dim Extranjera As Boolean
        Dim dt As DataTable
        dt = Cn_Proceso.fn_ConsultaDotaciones_ImprimeRemision(DotacionID)
        If dt Is Nothing Then Return False

        If dt.Rows.Count > 0 Then
            Remi.Moneda = dt.Rows(0)("Moneda")
            If dt.Rows(0)("Id_Moneda") = MonedaId Then 'MonedaId es la moneda local = Variable Global en el Modulo Variables.
                Remi.MonedaExtranjera = 0
                Remi.MonedaNacional = dt.Rows(0)("Importe_Efectivo")
                Remi.TotalEnvio = dt.Rows(0)("Importe_Efectivo")
                Remi.EquivalenteMN = dt.Rows(0)("Importe_Efectivo")
                Extranjera = False
            Else
                Remi.MonedaExtranjera = dt.Rows(0)("Importe_Efectivo")
                Remi.MonedaNacional = 0
                Remi.EquivalenteMN = Decimal.Parse(dt.Rows(0)("Importe_Efectivo")) * Decimal.Parse(dt.Rows(0)("TipoCambio"))
                Remi.TotalEnvio = dt.Rows(0)("Importe_Efectivo")
                Extranjera = True
            End If

            'If dt.Rows(0)("Documentos") = "S" Then
            '    Remi.Efectivo = 0
            '    Remi.Doctos = dt.Rows(0)("Importe")
            'Else
            '    Remi.Efectivo = dt.Rows(0)("Importe")
            '    Remi.Doctos = 0
            'End If
            'Remi.Total = dt.Rows(0)("Importe")
            'Remi.Sobres = dt.Rows(0)("Cantidad_Sobres")

            'Se quito el If por que ya van separados los importes
            Remi.Efectivo = dt.Rows(0)("Importe_Efectivo")
            Remi.Otros = dt.Rows(0)("Importe_Documentos")

            Remi.Total = dt.Rows(0)("Importe") 'Es la suma de Efectivo +Documentos
            Remi.Sobres = dt.Rows(0)("Cantidad_Sobres")

        Else
            Remi.Efectivo = 0
            Remi.Doctos = 0
            Remi.Total = 0
            Remi.EquivalenteMN = 0
            Remi.MonedaExtranjera = 0
            Remi.MonedaNacional = 0
            Remi.TotalEnvio = 0
            Remi.Sobres = 0
            Return False
        End If
        'Consultar las Denominaciones
        If Not Extranjera Then
            dt = Cn_Proceso.fn_ConsultaDotacionesD_ImprimeRemision(DotacionID)
            For I As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(I)("Presentacion") = "B" Then
                    Select Case dt.Rows(I)("Denominacion")
                        Case 1000
                            Remi.B1000 = dt.Rows(I)("Cantidad")
                        Case 500
                            Remi.B500 = dt.Rows(I)("Cantidad")
                        Case 200
                            Remi.B200 = dt.Rows(I)("Cantidad")
                        Case 100
                            Remi.B100 = dt.Rows(I)("Cantidad")
                        Case 50
                            Remi.B50 = dt.Rows(I)("Cantidad")
                        Case 20
                            Remi.B20 = dt.Rows(I)("Cantidad")
                        Case 10
                            Remi.B10 = dt.Rows(I)("Cantidad")
                    End Select
                ElseIf dt.Rows(I)("Presentacion") = "M" Then
                    Select Case dt.Rows(I)("Denominacion")

                        Case 100
                            Remi.M1 = dt.Rows(I)("Cantidad")
                        Case 50
                            Remi.M20 = dt.Rows(I)("Cantidad")
                        Case 20
                            Remi.M20 = dt.Rows(I)("Cantidad")
                        Case 10
                            Remi.M10 = dt.Rows(I)("Cantidad")
                        Case 5
                            Remi.M5 = dt.Rows(I)("Cantidad")
                        Case 2
                            Remi.M2 = dt.Rows(I)("Cantidad")
                        Case 1
                            Remi.M1 = dt.Rows(I)("Cantidad")
                        Case 0.5
                            Remi.M05 = dt.Rows(I)("Cantidad")
                        Case 0.2
                            Remi.M02 = dt.Rows(I)("Cantidad")
                        Case 0.1
                            Remi.M01 = dt.Rows(I)("Cantidad")
                        Case 0.05
                            Remi.M005 = dt.Rows(I)("Cantidad")
                    End Select
                End If
            Next
        End If
        dt.Dispose()
        Return True
    End Function

    Function ValidarDatosRemision(ByRef EnvasesBillete As Integer, ByRef EnvasesMorralla As Integer, _
                                ByRef EnvasesDcumentos As Integer, ByRef EnvasesSN As Integer) As Boolean
        SegundosDesconexion = 0

        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture el Número de Remisión", MsgBoxStyle.Critical, frm_MENU.Text)
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

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0

        'Dim Elemento As ListViewItem
        Dim Cadena As String = ""

        Dim EnvasesBillete As Integer = 0
        Dim EnvasesMorralla As Integer = 0
        Dim EnvasesDcumentos As Integer = 0
        Dim EnvasesSN As Integer = 0

        If Not ValidarDatosRemision(EnvasesBillete, EnvasesMorralla, EnvasesDcumentos, EnvasesSN) Then
            Exit Sub 'salir en caso de no cumplir validaciones
        End If

        btn_Guardar.Enabled = False

        If rdo_No.Checked = False And rdo_Si.Checked = False Then
            MsgBox("Indique si se imprimirá el desglose de Denominaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
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

        'Se imprime
        Dim Remision As New cp_Remision
        Remision.EnvasesBilletes = EnvasesBillete
        Remision.EnvasesMorralla = EnvasesMorralla
        Remision.EnvasesDocumentos = EnvasesDcumentos
        Remision.EnvasesSN = EnvasesSN
        Remision.EnvasesTotal = lsv_Envases.Items.Count + EnvasesSN
        Remision.Sellos = ""
        If lsv_Envases.Items.Count > 0 Then
            For I As Integer = 0 To lsv_Envases.Items.Count - 1
                If I = 0 Then
                    Remision.Sellos = lsv_Envases.Items(I).SubItems(1).Text
                Else
                    Remision.Sellos = Remision.Sellos & ", " & lsv_Envases.Items(I).SubItems(1).Text
                End If
            Next
        End If
        Remision.Servicio = Servicio.No_Imprimir
        Remision.Horario = Horario.No_Imprimir
        Remision.Remitente = UsuarioN
        Remision.Unidad = ""
        Remision.Otros = 0
        Remision.Id_Moneda = Id_Moneda
        Remision.Sobres = 0
        If rdo_Si.Checked Then
            Remision.Imprime_Denominaciones = True
            Select Case cmb_TipoImpresion.SelectedValue
                Case "P"
                    Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Solo_Piezas
                Case "I"
                    Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Solo_Importe
                Case "PI"
                    Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Piezas_e_Importe
            End Select
        Else
            Remision.Imprime_Denominaciones = False
        End If

        'Ya queda fijo. Se imprime en el formato nuevo siempre. EL otro ya no existe
        Remision.Formato2011 = True
        
        Select Case Tipo
            Case TipoR.Dotacion
                Remision.Origen = Nombre_Origen
                Remision.DireccionOrigen = Domicilio_Origen
                Remision.Destino = Nombre_Destino
                Remision.DireccionDestino = Domicilio_Destino
                Remision.Cia = "Traslada: " & lbl_CiaTV.Text
                Remision.Clave = Clave_Destino
                If ConsultaImportesDotacion(Remision) Then
                    If Not cp_Impresion.Imprimir(Remision) Then
                        MsgBox("Ocurrió un Error al intentar Imprimir la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                        SegundosDesconexion = 0
                        Exit Sub
                    End If
                Else
                    MsgBox("No se pudo obtener la información suficiente de la Dotación para Imprimir la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    SegundosDesconexion = 0
                    Exit Sub
                End If
            Case TipoR.Envio_Efectivo
                Remision.Origen = lbl_NombreCompañia.Text
                Remision.DireccionOrigen = Domicilio_Origen
                Remision.Destino = lbl_NombreCliente.Text
                Remision.DireccionDestino = Domicilio_Destino
                Remision.Cia = ""
                Remision.Clave = ""
                If Id_Moneda = MonedaId Then 'Moneda Nacional
                    Remision.EquivalenteMN = 0
                    Remision.Doctos = 0
                    Remision.MonedaExtranjera = 0
                    Remision.MonedaNacional = ImporteTotal
                    Remision.Efectivo = ImporteTotal
                    Remision.Total = ImporteTotal
                    Remision.TotalEnvio = ImporteTotal
                    For Each row As DataRow In Denominaciones.Rows
                        Select Case row("Moneda")
                            Case 1000
                                Remision.B1000 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 500
                                Remision.B500 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 200
                                Remision.B200 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 100 And row("Presentacion") = "BILLETE"
                                Remision.B100 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 50 And row("Presentacion") = "BILLETE"
                                Remision.B50 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 20 And row("Presentacion") = "BILLETE"
                                Remision.B20 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 10 And row("Presentacion") = "BILLETE"
                                Remision.B10 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 5 And row("Presentacion") = "BILLETE"
                                Remision.B5 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 2 And row("Presentacion") = "BILLETE"
                                Remision.B2 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 1 And row("Presentacion") = "BILLETE"
                                Remision.B1 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 20 And row("Presentacion") = "MONEDA"
                                Remision.M20 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 10 And row("Presentacion") = "MONEDA"
                                Remision.M10 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 5 And row("Presentacion") = "MONEDA"
                                Remision.M5 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 2 And row("Presentacion") = "MONEDA"
                                Remision.M2 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 1 And row("Presentacion") = "MONEDA"
                                Remision.M1 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 0.5
                                Remision.M05 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 0.2
                                Remision.M02 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 0.1
                                Remision.M01 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                            Case 0.05
                                Remision.M005 = row("Cantidad") + row("Cantidad1") + row("Cantidad2") + row("Cantidad3") + row("Cantidad4") + row("Cantidad5")
                        End Select
                    Next
                Else 'Moneda Extranjera
                    Remision.MonedaNacional = 0
                    Remision.EquivalenteMN = 0
                    Remision.Doctos = 0
                    Remision.MonedaExtranjera = ImporteTotal
                    Remision.Efectivo = ImporteTotal
                    Remision.Total = ImporteTotal
                    Remision.Imprime_Denominaciones = False
                End If
                If Not cp_Impresion.Imprimir(Remision) Then
                    MsgBox("Ocurrió un Error al intentar Imprimir la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    SegundosDesconexion = 0
                    Exit Sub
                End If
            Case TipoR.Resguardo
                Remision.Origen = lbl_NombreCompañia.Text
                Remision.DireccionOrigen = Domicilio_Origen
                Remision.Destino = lbl_NombreCliente.Text
                Remision.DireccionDestino = Domicilio_Destino
                Remision.Cia = ""
                Remision.Clave = ""
                If Id_Moneda = MonedaId Then 'Moneda Nacional
                    Remision.EquivalenteMN = 0
                    Remision.Doctos = 0
                    Remision.MonedaExtranjera = 0
                    Remision.MonedaNacional = ImporteTotal
                    Remision.Efectivo = ImporteTotal
                    Remision.Total = ImporteTotal
                    Remision.TotalEnvio = ImporteTotal
                    For Each row As DataRow In Denominaciones.Rows
                        Select Case row("Moneda")
                            Case 1000
                                Remision.B1000 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 500
                                Remision.B500 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 200
                                Remision.B200 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 100 And row("Presentacion") = "BILLETE"
                                Remision.B100 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 50 And row("Presentacion") = "BILLETE"
                                Remision.B50 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 20 And row("Presentacion") = "BILLETE"
                                Remision.B20 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 10 And row("Presentacion") = "BILLETE"
                                Remision.B10 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 5 And row("Presentacion") = "BILLETE"
                                Remision.B5 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 2 And row("Presentacion") = "BILLETE"
                                Remision.B2 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 1 And row("Presentacion") = "BILLETE"
                                Remision.B1 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 20 And row("Presentacion") = "MONEDA"
                                Remision.M20 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 10 And row("Presentacion") = "MONEDA"
                                Remision.M10 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 5 And row("Presentacion") = "MONEDA"
                                Remision.M5 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 2 And row("Presentacion") = "MONEDA"
                                Remision.M2 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 1 And row("Presentacion") = "MONEDA"
                                Remision.M1 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 0.5
                                Remision.M05 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 0.2
                                Remision.M02 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 0.1
                                Remision.M01 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                            Case 0.05
                                Remision.M005 = row("Resguardar") + row("ResguardarA") + row("ResguardarB") + row("ResguardarC") + row("ResguardarD") + row("ResguardarE")
                        End Select
                    Next
                Else 'Moneda Extranjera
                    Remision.MonedaNacional = 0
                    Remision.EquivalenteMN = 0
                    Remision.Doctos = 0
                    Remision.MonedaExtranjera = ImporteTotal
                    Remision.Efectivo = ImporteTotal
                    Remision.Total = ImporteTotal
                    Remision.Imprime_Denominaciones = False
                End If
                If Not cp_Impresion.Imprimir(Remision) Then
                    MsgBox("Ocurrió un Error al intentar Imprimir la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    SegundosDesconexion = 0
                    Exit Sub
                End If
        End Select
        SegundosDesconexion = 0
        If MsgBox("Se imprimió correctamente ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
            SegundosDesconexion = 0
            btn_Guardar.Enabled = True
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

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
                    MsgBox("La dotacion de efectivo se realizó de manera correcta.", MsgBoxStyle.Information, frm_MENU.Text)
                End If

            Case TipoR.Envio_Efectivo '2 Envio de Efectivo
                If Cn_Proceso.Fn_LoteEfectivo_CreateCR(lsv_Envases, Envases, EnvasesSN, CLng(tbx_Remision.Text), IdCajaBancaria, ImporteTotal, _
                                                       Id_Moneda, Tipo_Lote, IdCajaBancariaD) Then
                    MsgBox("La preparación de envio de efectivo se guardó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If

                'If Cn_Proceso.fn_LotesEfectivo_Create(lsv_Envases, Envases, EnvasesSN, tbx_Remision.Text, IdCajaBancaria, _
                '     este estaba antes              ImporteTotal, Id_Moneda) = True Then
                '    MsgBox("Registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                'End If

            Case TipoR.Resguardo '3 Resguardo
                If Cn_Proceso.fn_PreparaResguardo_Create(frm_PrepararResguardo.dt_Resguardos, lsv_Envases, Envases, EnvasesSN, _
                                         CLng(tbx_Remision.Text), IdCajaBancaria, ImporteTotal, Id_Moneda) = True Then
                    MsgBox("El resguardo de efectivo se realizó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If

            Case TipoR.Entrada_Efectivo '5 Entrada de efectivo
                If Cn_Proceso.Fn_EntradaSaldo_Guardar(lsv_Envases, Envases, EnvasesSN, CLng(tbx_Remision.Text), IdCajaBancaria, ImporteTotal, _
                                                   Id_Moneda, Tipo_Lote, IdCajaBancariaD) Then
                    MsgBox("La entrada de efectivo se realizó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If

        End Select

        Me.Close()
    End Sub

    Private Sub cmb_TipoEnvase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoEnvase.SelectedIndexChanged
        Call ValidaBotonAgregar()
    End Sub

    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Numero.TextChanged
        Call ValidaBotonAgregar()
    End Sub

    Private Sub ValidaBotonAgregar()

        If cmb_TipoEnvase.SelectedValue <> 0 Then

            If tbx_Numero.Text.Trim <> "" Then
                Btn_Agregar.Enabled = True
            End If

        Else
            Btn_Agregar.Enabled = False
        End If

    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
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

    Private Sub rdo_Si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Si.CheckedChanged
        cmb_TipoImpresion.SelectedValue = "0"
        If rdo_Si.Checked Then
            cmb_TipoImpresion.Visible = True
        Else
            cmb_TipoImpresion.Visible = False
        End If
    End Sub

End Class