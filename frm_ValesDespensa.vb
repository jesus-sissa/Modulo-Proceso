
Public Class frm_ValesdeDespensa

    Private Declare Function BInit Lib "buicap32.dll" Alias "BUICInit" () As Integer
    Private Declare Function BAbout Lib "buicap32.dll" Alias "BUICDisplayAbout" () As Integer
    Private Declare Function BExit Lib "buicap32.dll" Alias "BUICExit" () As Integer
    Private Declare Function BScan Lib "buicap32.dll" Alias "BUICScan" (ByVal iJobType As Integer, ByVal lpFront As String, ByVal lpLenFront As String, ByVal lpBack As String, ByVal lpLenBack As String, ByVal lpCode As String, ByVal lpLenCode As String) As Integer
    Private Declare Function BStatus Lib "buicap32.dll" Alias "BUICStatus" () As Integer
    Private Declare Function BGetMICR Lib "buicap32.dll" Alias "BUICSetMicrLine" (ByVal InputFile As String, ByVal page As Integer, ByVal MicrLine As String, ByVal MicrLineSize As String) As Integer
    Private Declare Function BEject Lib "buicap32.dll" Alias "BUICEjectDocument" () As Integer

    Dim Contador As Integer = 0
    Dim RutaTemporal As String = "C:\SiacTemp\img_Vales"
    Dim dt_casaValera As DataTable = Nothing
    Dim dr_casaV() As DataRow = Nothing

    Function Inicia_Scanner() As Boolean
        Dim k As Integer
        Dim Resu As Integer
        Try
            For k = 1 To 3
                If k > 1 Then
                    'LBRep.Text = LBRep.Text + CStr(Time) + " : Reintentando inicializar el scanner, espere un momento... Intento " + CStr(k) + " de 3." + Chr(13)
                    'LBRep.SelStart = Len(LBRep)
                    'LBRep.Refresh()
                End If
                Resu = BInit
                ' MsgBox("BInit = " & BInit, MsgBoxStyle.Information, frm_Menu.Text)
                If Resu = 1 Then
                    Inicia_Scanner = True
                    Exit Function
                Else
                    Inicia_Scanner = False
                    'LBRep.Text = LBRep.Text + CStr(Time) + " : Error al iniciar el scanner, asegúrese de que este conectado y encendido." + Chr(13)
                    'LBRep.SelStart = Len(LBRep)
                    'LBRep.Refresh()
                    BExit()
                End If
            Next
        Catch
            Inicia_Scanner = False
            BExit()
        End Try
    End Function

    Private Sub btn_Inicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Inicio.Click
        Me.Cursor = Cursors.WaitCursor
        'lsv_Datos.Items.Clear()
        btn_Inicio.Enabled = False
        If Inicia_Scanner() = True Then
            lbl_status.Text = "LISTO"
            lbl_status.ForeColor = Color.Green
            cmb_casavalera.Enabled = False
            btn_Escanear.Enabled = True
            btn_Finalizar.Enabled = True
            ' Call Agrega_Log("Scanner Inicializado.")
        Else
            lbl_status.Text = ""
            cmb_casavalera.Enabled = True
            'Call Agrega_Log("No se encontró el scanner o no se pudo inicializar.")
            MsgBox("No se encontró el scanner o no se pudo inicializar.", 16 + 0, frm_Menu.Text)
            btn_Inicio.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frm_ValesdeDespensa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call BorrarImagenesTemporales()

    End Sub

    Private Sub frm_ValesdeDespensa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If FileIO.FileSystem.DirectoryExists(RutaTemporal) Then
            FileIO.FileSystem.DeleteDirectory(RutaTemporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        lsv_Datos.Columns.Add("Fecha", 130)
        lsv_Datos.Columns.Add("Hora", 100)
        lsv_Datos.Columns.Add("Banda", 300)
        lsv_Datos.Columns.Add("Longitud", 200)
        lsv_Datos.Columns.Add("Importe", 200)
        lsv_Datos.Columns.Add("RutaTemImagenFront", 0)
        lsv_Datos.Columns.Add("RutaTemImagenBack", 0)
        lsv_Datos.Columns.Add("Status", 0)
        lsv_Datos.Columns.Add("Modo Captura", 0)
        lsv_Datos.Columns.Add("NumeroCont", 0)
        cmb_casavalera.AgregaParametro("@Status", "A", 0)
        cmb_casavalera.Actualizar()
        dt_casaValera = cmb_casavalera.DataSource 'pasa el contendo del cmb a dt
        cmb_casavalera.SelectedValue = 0
    End Sub

    Private Sub btn_Escanear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Escanear.Click
        Dim LenFront As String = ""
        Dim LenBack As String = ""
        Dim Code As String = ""
        Dim CodeS As String = ""
        Dim Car As String = ""
        Dim LenCode As String = ""
        Dim k As Integer = 0
        Dim Resu As Integer
        Dim Nombre_Front As String = ""
        Dim Nombre_Back As String = ""
        Me.Cursor = Cursors.WaitCursor

        If Not (FileIO.FileSystem.DirectoryExists(RutaTemporal)) Then
            FileIO.FileSystem.CreateDirectory(RutaTemporal)
        End If

        Dim Importe As Integer = 0
        Dim CadImporte As String = ""

        If BStatus = 1 Then
            Do
                LenFront = Space(64)
                LenBack = Space(64)
                Code = Space(200) '--->
                LenCode = Space(16)

                Contador += 1
                Nombre_Front = RutaTemporal & "\F" & FuncionesGlobales.fn_PonerCeros(Trim(Str(Contador)), 4) & ".tif"
                Nombre_Back = RutaTemporal & "\B" & FuncionesGlobales.fn_PonerCeros(Trim(Str(Contador)), 4) & ".tif"

                Resu = BScan(7, Nombre_Front, LenFront, Nombre_Back, LenBack, Code, LenCode)

                If Val(LenCode) <> 0 Then

                    CodeS = Trim(Code)
                    For k = 1 To Len(CodeS) - 1
                        Car = Mid(CodeS, k, 1)
                        If InStr(1, "0123456789", Car) = 0 Then
                            CodeS = Replace(CodeS, Car, "_")
                        End If
                    Next
                    '--Validar formato antes de agregar a listview
                    CadImporte = CodeS.Substring(dr_casaV(0)("IniImpM"), (CInt(dr_casaV(0)("FinImpM")) - CInt(dr_casaV(0)("IniImpM"))) + 1)
                    Dim NumeroCont As String = CodeS.Substring(dr_casaV(0)("IniNumM"), (CInt(dr_casaV(0)("FinNumM")) - CInt(dr_casaV(0)("IniNumM"))) + 1)

                    If Val(LenCode) <> dr_casaV(0)("LongM") Or Not IsNumeric(CadImporte) OrElse Val(CadImporte) <= 0 Then
                        BExit()
                        btn_Guardar.Enabled = lsv_Datos.Items.Count > 0
                        Me.Cursor = Cursors.Default
                        btn_liberarAtasco.Enabled = True
                        lbl_status.Text = "SIN CONEXION"
                        lbl_status.ForeColor = Color.Red
                        'btn_Inicio.Enabled = True
                        btn_Escanear.Enabled = False
                        btn_Finalizar.Enabled = False
                        Exit Sub
                    End If

                    If Not BuscarValeDigitalizado(CodeS) Then
                        Call Agrega_ValeDespensa(CodeS, CadImporte, Nombre_Front, Nombre_Back, "A", dr_casaV(0)("LongM"), 2, NumeroCont)
                    Else
                        MsgBox("ya se encuentra agregado a la lista,", MsgBoxStyle.Critical, frm_Menu.Text)
                    End If
                    '--------------
                End If
            Loop Until Val(LenCode) = 0
        End If

        btn_Guardar.Enabled = lsv_Datos.Items.Count > 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Function BuscarValeDigitalizado(ByVal Micr_CodBarras As String) As Boolean
        Try
            BuscarValeDigitalizado = False
            For Each buscarVale As ListViewItem In lsv_Datos.Items
                If buscarVale.SubItems(2).Text = Micr_CodBarras Then
                    BuscarValeDigitalizado = True
                End If
            Next
            Return BuscarValeDigitalizado

        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub Agrega_ValeDespensa(ByVal Micr_CB As String, ByVal Importe As String, ByVal NombreF As String, ByVal NombreB As String, _
                            ByVal status As String, ByVal longitud As String, ByVal Modocaptura As Byte, ByVal NumeroCont As String)
        lsv_Datos.Items.Add(Format(Now.Date, "dd/MM/yyyy"))
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(TimeString)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Micr_CB)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(longitud)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Importe)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(NombreF)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(NombreB)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(status)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Modocaptura)
        lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(NumeroCont)

        lsv_Datos.Items(lsv_Datos.Items.Count - 1).BackColor = Color.Khaki
        lbl_Registros.Text = "Registros: " & lsv_Datos.Items.Count
        btn_Guardar.Enabled = lsv_Datos.Items.Count > 0
        btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
    End Sub

    Private Sub BorrarImagenesTemporales()
        Try
            'borra todo el contenido del directorio \img_Vales
            If FileIO.FileSystem.DirectoryExists(RutaTemporal) Then
                FileIO.FileSystem.DeleteDirectory(RutaTemporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            
        Catch ex As Exception
            MsgBox("error al eliminar imagenes temporales. " & ex.Message, MsgBoxStyle.Critical, frm_Menu.Text)
        End Try
    End Sub

    Private Sub btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Finalizar.Click
        'si hay pendientes de guardar  mandar alerta
        For Each Valeguardar As ListViewItem In lsv_Datos.Items
            If Valeguardar.SubItems(7).Text = "A" Then
                If MsgBox("No se han guardado todos los vales de despensa, desea continuar?. ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_Menu.Text) = MsgBoxResult.Yes Then
                    Exit For
                Else
                    Exit Sub
                End If
            End If
        Next

        Me.Cursor = Cursors.WaitCursor
        BExit()
        lbl_status.Text = "SIN CONEXION"
        lbl_status.ForeColor = Color.Red

        Call BorrarImagenesTemporales() '--
        lsv_Datos.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        lsv_Datos.BackColor = Color.White

        btn_Inicio.Enabled = False
        btn_Escanear.Enabled = False
        btn_Finalizar.Enabled = False
        btn_Guardar.Enabled = False

        cmb_casaValera.Enabled = True
        cmb_casaValera.SelectedValue = "0"

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click

        If lsv_Datos.SelectedItems.Count > 0 Then
            For Each micr As ListViewItem In lsv_Datos.SelectedItems
                'borrar imagens en \img_Vales -      'borrar de Listview

                If FileIO.FileSystem.FileExists(micr.SubItems(5).Text) Then
                    My.Computer.FileSystem.DeleteFile(micr.SubItems(5).Text)
                End If

                If FileIO.FileSystem.FileExists(micr.SubItems(6).Text) Then
                    My.Computer.FileSystem.DeleteFile(micr.SubItems(6).Text)
                End If
                micr.Remove()
            Next
        End If
        btn_Guardar.Enabled = lsv_Datos.Items.Count > 0
        btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        For Each guardaVale As ListViewItem In lsv_Datos.Items

            If guardaVale.SubItems(7).Text = "A" Then
                If Cn_Proceso.fn_BuscarExiste_ValesDespensa(cmb_casavalera.SelectedValue, guardaVale.SubItems(2).Text, guardaVale.SubItems(8).Text) Then
                    ' existe
                    guardaVale.SubItems(7).Text = "E"
                    guardaVale.BackColor = Color.LightCoral
                Else
                    Cn_Proceso.fn_Guardar_ValesDespensa(cmb_casavalera.SelectedValue, cmb_casavalera.Text, _
                                                           guardaVale.SubItems(2).Text, guardaVale.SubItems(4).Text, _
                                                           guardaVale.SubItems(9).Text, guardaVale.SubItems(8).Text)
                    'no existe
                    guardaVale.SubItems(7).Text = "G"
                    guardaVale.BackColor = Color.LightGreen
                End If
            End If
        Next

    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        btn_Eliminar.Enabled = lsv_Datos.SelectedItems.Count > 0

    End Sub

    Private Sub chk_CapturarManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_CapturarManual.CheckedChanged
        tbx_MicrCB.Text = String.Empty
        gbx_modoCaptura.Enabled = chk_CapturarManual.Checked
        tbx_MicrCB.Enabled = chk_CapturarManual.Checked
        btn_Agregar.Enabled = chk_CapturarManual.Checked
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click

        If tbx_MicrCB.Text.Trim = "" Then
            MsgBox("Capture el código de barras o  la Banda Magnetica. ", MsgBoxStyle.Critical, frm_Menu.Text)
            tbx_MicrCB.Focus()
            Exit Sub
        End If
        Dim modoCaptura As Byte = 1 'CB
        Dim cadImporte As String = ""
        Dim NumeroCont As String = ""

        If Not rdb_micr.Checked And Not rdb_CodigoBarras.Checked Then
            MsgBox("seleccione el metodo de captura, «codigo barras» ó «cinta magnetica».", MsgBoxStyle.Critical, frm_Menu.Text)
            Exit Sub
        End If

        If rdb_micr.Checked Then
            'medida de Micr - banda magnetica
            modoCaptura = 2
            If dr_casaV(0)("LongM") <> tbx_MicrCB.Text.Length Then
                MsgBox("Longitud de banda magnetica incorrecta, longitud valida es: " & dr_casaV(0)("LongM"), MsgBoxStyle.Critical, frm_Menu.Text)
                tbx_MicrCB.Focus()
                Exit Sub
            End If
            '
            cadImporte = tbx_MicrCB.Text.Substring(dr_casaV(0)("IniImpM"), (CInt(dr_casaV(0)("FinImpM")) - CInt(dr_casaV(0)("IniImpM"))) + 1)
            NumeroCont = tbx_MicrCB.Text.Substring(dr_casaV(0)("IniNumM"), (CInt(dr_casaV(0)("FinNumM")) - CInt(dr_casaV(0)("IniNumM"))) + 1)

            If Not IsNumeric(cadImporte) OrElse Val(cadImporte) <= 0 Then
                MsgBox("Importe incorrecto de la posicion indicada, capture correctamente los digitos de la banda magnetica, ", MsgBoxStyle.Critical, frm_Menu.Text)
                tbx_MicrCB.Focus()
                Exit Sub
            End If

            If Not IsNumeric(NumeroCont) Then
                MsgBox("Numero contable incorrecto de la posicion indicada, capture correctamente los digitos de la banda magnetica, ", MsgBoxStyle.Critical, frm_Menu.Text)
                tbx_MicrCB.Focus()
                Exit Sub
            End If

            If Not BuscarValeDigitalizado(tbx_MicrCB.Text) Then
                Call Agrega_ValeDespensa(tbx_MicrCB.Text, cadImporte, "", "", "A", dr_casaV(0)("LongM"), modoCaptura, NumeroCont)
            Else
                MsgBox("ya se encuentra agregado a la lista,", MsgBoxStyle.Critical, frm_Menu.Text)
            End If

        Else

            'medida de Codigo de barras
            If dr_casaV(0)("LongCB") <> tbx_MicrCB.Text.Length Then
                MsgBox("Longitud de código de barras incorrecta, la longitud correcta es: " & dr_casaV(0)("LongCB"), MsgBoxStyle.Critical, frm_Menu.Text)
                tbx_MicrCB.Focus()
                Exit Sub
            End If
            '
            cadImporte = tbx_MicrCB.Text.Substring(dr_casaV(0)("IniImpCB"), (CInt(dr_casaV(0)("FinImpCB")) - CInt(dr_casaV(0)("IniImpCB"))) + 1)
            NumeroCont = tbx_MicrCB.Text.Substring(dr_casaV(0)("IniNumCB"), (CInt(dr_casaV(0)("FinNumCB")) - CInt(dr_casaV(0)("IniNumCB"))) + 1)

            If Not IsNumeric(cadImporte) OrElse Val(cadImporte) <= 0 Then
                MsgBox("Importe incorrecto de la posicion indicada, capture correctamente los digitos del codigo de barras, ", MsgBoxStyle.Critical, frm_Menu.Text)
                tbx_MicrCB.Focus()
                Exit Sub
            End If

            If Not IsNumeric(NumeroCont) Then
                MsgBox("Numero contable incorrecto de la posicion indicada, capture correctamente los digitos del codigo de barras, ", MsgBoxStyle.Critical, frm_Menu.Text)
                tbx_MicrCB.Focus()
                Exit Sub
            End If

            If Not BuscarValeDigitalizado(tbx_MicrCB.Text) Then
                Call Agrega_ValeDespensa(tbx_MicrCB.Text, cadImporte, "", "", "A", dr_casaV(0)("LongCB"), modoCaptura, NumeroCont)
            Else
                MsgBox("ya se encuentra agregado a la lista,", MsgBoxStyle.Critical, frm_Menu.Text)
            End If
        End If

    End Sub

    Private Sub tbx_MicrCB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_MicrCB.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Agregar_Click(btn_Agregar, New EventArgs)
        End If
    End Sub

    Private Sub cmb_casavalera_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_casavalera.SelectedValueChanged

        If cmb_casavalera.SelectedValue > 0 Then
            dr_casaV = dt_casaValera.Select("Id_Casa=" & cmb_casavalera.SelectedValue)

            btn_Inicio.Enabled = (dr_casaV(0)("Tiene_Micr") = "S")
            rdb_micr.Enabled = (dr_casaV(0)("Tiene_Micr") = "S")
            rdb_micr.Checked = False

            rdb_CodigoBarras.Enabled = (dr_casaV(0)("Tiene_CB") = "S")
            rdb_CodigoBarras.Checked = False

            chk_CapturarManual.Checked = False
        Else
            dr_casaV = Nothing
            rdb_CodigoBarras.Enabled = False
            rdb_micr.Enabled = False
            rdb_CodigoBarras.Checked = False
            rdb_micr.Checked = False
        End If

        chk_CapturarManual.Enabled = cmb_casavalera.SelectedValue > 0
        btn_Inicio.Enabled = cmb_casavalera.SelectedValue > 0

    End Sub

    Private Sub btn_liberarAtasco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_liberarAtasco.Click
        If Inicia_Scanner() Then
            BEject()
            BExit()
            btn_liberarAtasco.Enabled = False
            btn_Inicio.Enabled = True
        End If
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, "Listado de Vales Digitalizados", 0, 0, frm_MENU.prg_Barra)
    End Sub
End Class