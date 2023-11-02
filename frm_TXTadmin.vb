Imports System
Imports System.IO
Imports System.Collections
Imports Microsoft

Public Class frm_TXTadmin

    Dim Temporal As String = My.Application.Info.DirectoryPath & "\TMPENCRIPTA"
    Dim RutaDestino As String = ""
    Dim RutaDestinoCheques As String = ""
    Dim HayCheques As Boolean = False
    Dim ModificoEncriptador As Boolean = False
    Dim RutaGuardarImgB64 As String
    Dim NombreArchivoB64 As String

    Private Sub frm_TXTadmin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Cheques.Columns.Add("Id", 80, HorizontalAlignment.Left)
        lsv_Cheques.Columns.Add("Banco", 80, HorizontalAlignment.Left)
        lsv_Cheques.Columns.Add("Cuenta", 100, HorizontalAlignment.Left)
        lsv_Cheques.Columns.Add("Numero", 90, HorizontalAlignment.Left)
        lsv_Cheques.Columns.Add("Banda", 200, HorizontalAlignment.Left)
        lsv_Cheques.Columns.Add("Importe", 90, HorizontalAlignment.Right)
        lsv_Cheques.Columns.Add("Encontrado", 90, HorizontalAlignment.Left)

        tbx_Encriptador.Text = My.Settings.RutaEncriptador.ToString

        'FuncionesGlobales.fn_Columna(lsv_Cheques, 5, 10, 10, 10, 20, 10, 0, 0, 0, 0)
    End Sub

    Private Sub frm_TXTadmin_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        'lsv_Cheques.Columns(0).Width = 80
        'lsv_Cheques.Columns(1).Width = 80
        'lsv_Cheques.Columns(2).Width = 100
        'lsv_Cheques.Columns(3).Width = 90
        'lsv_Cheques.Columns(4).Width = 200
        'lsv_Cheques.Columns(5).Width = 90
        'lsv_Cheques.Columns(6).Width = 90
        'FuncionesGlobales.fn_Columna(lsv_Cheques, 5, 10, 10, 10, 20, 10, 0, 0, 0, 0)
    End Sub

    Private Sub btn_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ruta.Click
        SegundosDesconexion = 0

        HayCheques = False
        Btn_ExtraerCheques.Enabled = False
        dlg_Archivo.FileName = ""
        dlg_Archivo.Filter = "Archivos de Texto(*.txt)|D*.txt"
        dlg_Archivo.Multiselect = False
        dlg_Archivo.ShowDialog()
        'verificar que se haya seleccionado un archivo
        If dlg_Archivo.FileName = "" Then Exit Sub

        'Hacer lo necesario
        'comprobar que existe la carpeta temporal
        If My.Computer.FileSystem.DirectoryExists(Temporal) Then
            My.Computer.FileSystem.DeleteDirectory(Temporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        My.Computer.FileSystem.CreateDirectory(Temporal)
        'mostrar los datos
        txt_Archivo.Text = dlg_Archivo.SafeFileName
        lbl_Ruta.Text = Replace(dlg_Archivo.FileName, dlg_Archivo.SafeFileName, "")
        txt_Archivo.Tag = Replace(dlg_Archivo.SafeFileName, "D", "C")
        'Copiar los archivos a la carpeta temporal
        My.Computer.FileSystem.CopyFile(dlg_Archivo.FileName, Temporal & "\" & txt_Archivo.Text, True)
        If My.Computer.FileSystem.FileExists(lbl_Ruta.Text & txt_Archivo.Tag) Then
            HayCheques = True
            Btn_ExtraerCheques.Enabled = True
            My.Computer.FileSystem.CopyFile(lbl_Ruta.Text & txt_Archivo.Tag, Temporal & "\" & txt_Archivo.Tag, True)
        End If

        txt_Archivo.Text = Replace(txt_Archivo.Text, ".txt", "")
        txt_Archivo.Tag = Replace(txt_Archivo.Tag, ".txt", "")

        tbx_Consecutivo.Text = VisualBasic.Right(txt_Archivo.Text, 2)
        'txt_Archivo.Text = VisualBasic.Left(txt_Archivo.Text, txt_Archivo.Text.Length - 3)
        'txt_Archivo.Tag = VisualBasic.Left(txt_Archivo.Tag, txt_Archivo.Tag.Length - 3)
        tbx_NombreNuevo.Text = txt_Archivo.Text

        lbl_Fecha.Text = Mid(dlg_Archivo.SafeFileName, 2, 6)


    End Sub


    Private Sub btn_Encriptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Encriptar.Click
        SegundosDesconexion = 0

        Dim Comando As String
        Dim Respuesta As Integer = 0
        Dim Fecha As String = Now.ToString("yyyymmdd") 'Now.Year & Now.Month & Now.Day
        If RutaDestino = "" Then
            MsgBox("Seleccione la Ruta Destino de los Archivos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_Menu.Text)
            tbx_Destino.Focus()
            Exit Sub
        End If
        If tbx_Encriptador.Text.Trim = "" Then
            MsgBox("Seleccione la Ruta del Programa para Encriptar los Archivos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            btn_RutaEncriptador.Focus()
            Exit Sub
        End If
        'Renombrar los Archivos en caso de que el usuario haya cambiado el consecutivo
        If txt_Archivo.Text.Trim <> tbx_NombreNuevo.Text.Trim Then
            My.Computer.FileSystem.RenameFile(Temporal & "\" & txt_Archivo.Text & ".txt", tbx_NombreNuevo.Text & ".txt")
        End If
        If HayCheques Then
            If txt_Archivo.Tag.Trim <> tbx_NombreNuevo.Tag.Trim Then
                My.Computer.FileSystem.RenameFile(Temporal & "\" & txt_Archivo.Tag & ".txt", tbx_NombreNuevo.Tag & ".txt")
            End If
        End If

        'Verificar que la carpeta con la fecha del archivo no exista
        If My.Computer.FileSystem.DirectoryExists(RutaDestino) Then
            'revisar si el archivo existe en la carpeta seleccionada
            If My.Computer.FileSystem.FileExists(RutaDestino & "\" & tbx_NombreNuevo.Text & ".txt.gpg") Then
                If MsgBox("Ya existe un Archivo con ese nombre, Desea Reemplazarlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
                'Existe y hay que eliminarlo para poder crearlo de nuevo
                My.Computer.FileSystem.DeleteFile(RutaDestino & "\" & tbx_NombreNuevo.Text & ".txt.gpg")
                If My.Computer.FileSystem.FileExists(RutaDestino & "\" & tbx_NombreNuevo.Tag & ".txt.gpg") Then
                    My.Computer.FileSystem.DeleteFile(RutaDestino & "\" & tbx_NombreNuevo.Tag & ".txt.gpg")
                End If

            End If
        Else
            'Crear la carpeta
            My.Computer.FileSystem.CreateDirectory(tbx_Destino.Text & "\" & lbl_Fecha.Text)

        End If

        'Encriptar los archivo
        'Comando = Chr(34) & "C:\Archivos de programa\GNU\GnuPG\gpg.exe" & Chr(34) & " --output " & Chr(34) & RutaDestino & "\" & tbx_NombreNuevo.Text & ".txt.gpg" & Chr(34) & " --encrypt --recipient sopesp@afirme.com.mx " & Chr(34) & Temporal & "\" & Trim(tbx_NombreNuevo.Text) & ".txt" & Chr(34)
        Comando = Chr(34) & tbx_Encriptador.Text.Trim & Chr(34) & " --output " & Chr(34) & RutaDestino & "\" & tbx_NombreNuevo.Text & ".txt.gpg" & Chr(34) & " --encrypt --recipient sopesp@afirme.com.mx " & Chr(34) & Temporal & "\" & Trim(tbx_NombreNuevo.Text) & ".txt" & Chr(34)
        Call Shell(Comando, AppWinStyle.NormalFocus)
        If HayCheques Then
            'Comando = Chr(34) & "C:\Archivos de programa\GNU\GnuPG\gpg.exe" & Chr(34) & " --output " & Chr(34) & RutaDestino & "\" & tbx_NombreNuevo.Tag & ".txt.gpg" & Chr(34) & " --encrypt --recipient sopesp@afirme.com.mx " & Chr(34) & Temporal & "\" & Trim(tbx_NombreNuevo.Tag) & ".txt" & Chr(34)
            Comando = Chr(34) & tbx_Encriptador.Text.Trim & Chr(34) & " --output " & Chr(34) & RutaDestino & "\" & tbx_NombreNuevo.Tag & ".txt.gpg" & Chr(34) & " --encrypt --recipient sopesp@afirme.com.mx " & Chr(34) & Temporal & "\" & Trim(tbx_NombreNuevo.Tag) & ".txt" & Chr(34)
            Call Shell(Comando, vbNormalFocus)
        End If
        If ModificoEncriptador Then
            My.Settings.RutaEncriptador = tbx_Encriptador.Text.Trim
            My.Settings.Save()
        End If

        MsgBox("Proceso Terminado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, frm_MENU.Text)
        txt_Archivo.Text = ""
        txt_Archivo.Tag = ""
        tbx_NombreNuevo.Text = ""
        tbx_NombreNuevo.Tag = ""
        tbx_Consecutivo.Text = ""
        tbx_Destino.Text = ""
    End Sub

    Private Sub btn_RutaNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RutaNueva.Click
        SegundosDesconexion = 0

        dlg_Destino.ShowNewFolderButton = True
        dlg_Destino.SelectedPath = "c:\"
        dlg_Destino.ShowDialog()
        If dlg_Destino.SelectedPath = "" Then
            MsgBox("Seleccione la Ubicación Destino.", 16 + 0, frm_Menu.Text)
            btn_Encriptar.Enabled = False
            Exit Sub
        Else
            tbx_Destino.Text = dlg_Destino.SelectedPath
        End If
        If dlg_Archivo.FileName <> "" And dlg_Destino.SelectedPath <> "" Then
            btn_Encriptar.Enabled = True
        End If
        RutaDestino = tbx_Destino.Text & "\" & lbl_Fecha.Text
    End Sub

    Private Sub tbx_Consecutivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Consecutivo.TextChanged
        If txt_Archivo.TextLength <= 0 Then Exit Sub
        tbx_NombreNuevo.Text = VisualBasic.Left(txt_Archivo.Text, txt_Archivo.Text.Length - 2) & FuncionesGlobales.fn_PonerCeros(tbx_Consecutivo.Text.Trim, 2)
        tbx_NombreNuevo.Tag = VisualBasic.Left(txt_Archivo.Tag, txt_Archivo.Tag.Length - 2) & FuncionesGlobales.fn_PonerCeros(tbx_Consecutivo.Text.Trim, 2)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub


    '-------------------------------------------------
    'TAB CHEQUES
    '-------------------------------------------------

    Private Sub btn_RutaArchivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RutaArchivos.Click
        SegundosDesconexion = 0

        Dim Dialogo As New OpenFileDialog
        tbx_ArchivoCheques.Clear()
        lsv_Cheques.Items.Clear()
        Btn_ExtraerCheques.Enabled = False
        tbx_Importe.Clear()
        lbl_Rojo.Visible = False
        lbl_Zoom.Visible = False

        Dialogo.Filter = "Archivos de Texto(*.txt)|C*.txt"
        Dialogo.Multiselect = False
        Dialogo.ShowDialog()
        'verificar que se haya seleccionado un archivo
        If Dialogo.FileName = "" Then Exit Sub

        tbx_ArchivoCheques.Text = Dialogo.SafeFileName
        tbx_ArchivoCheques.Tag = Dialogo.FileName
        NombreArchivoB64 = Dialogo.SafeFileName.Replace("C", "I")
        If tbx_ArchivoCheques.Text <> "" Then
            Call LlenarLista()
        End If
    End Sub

    Private Sub btn_DestinoCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DestinoCheques.Click
        SegundosDesconexion = 0

        Dim Dialogo As New FolderBrowserDialog
        Dialogo.ShowNewFolderButton = True
        Dialogo.SelectedPath = "c:\"
        Dialogo.ShowDialog()
        If Dialogo.SelectedPath = "" Then
            MsgBox("Seleccione la Ubicación Destino.", 16 + 0, frm_Menu.Text)
            Btn_ExtraerCheques.Enabled = False
            Exit Sub
        Else
            tbx_DestinoCheques.Text = Dialogo.SelectedPath
        End If
        If lsv_Cheques.Items.Count > 0 And tbx_DestinoCheques.Text <> "" Then
            Btn_ExtraerCheques.Enabled = True
        Else
            Btn_ExtraerCheques.Enabled = False
        End If
        RutaDestinocheques = tbx_DestinoCheques.Text
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0

        'Leer los cheques y colocarlos en el ListView
        Dim Archivo As New StreamReader(tbx_ArchivoCheques.Tag.ToString)
        Dim sLine As String = ""
        Dim Linea As Integer = 0
        Dim Comas As Byte = 0
        Dim Banda = "", Banco = "", Cuenta = "", Numero = "", Importe As String = ""
        Dim Total As Decimal = 0
        Dim I As Integer
        Dim J As Integer
        Dim HayComa6 As Boolean = False

        Do
            Linea += 1
            sLine = Archivo.ReadLine()
            If Linea > 1 Then
                If Not sLine Is Nothing Then
                    'buscar la tercera coma
                    Banda = ""
                    Comas = 0
                    For I = 0 To sLine.Length - 1
                        If sLine.Substring(I, 1) = "," Then
                            Comas += 1
                            If Comas = 4 Then
                                Banda = sLine.Substring(I + 1, 31)
                            ElseIf Comas = 5 Then
                                HayComa6 = False
                                For J = I + 1 To sLine.Length - 1
                                    If sLine.Substring(J, 1) = "," Then
                                        HayComa6 = True
                                        Exit For
                                    End If
                                Next
                                If Not HayComa6 Then
                                    Importe = sLine.Substring(I + 1, sLine.Length - (I + 1))
                                Else
                                    Importe = sLine.Substring(I + 1, (J - (I + 1)))
                                End If
                                Exit For
                            End If
                        End If
                    Next
                    
                    If Banda <> "" Then
                        'Agregar al ListView
                        Banco = Banda.Substring(9, 3)
                        Cuenta = Banda.Substring(13, 11)
                        Numero = Banda.Substring(24, 7)

                        '"@Clave_Banco", Mid(lsv_Datos.Items(I).SubItems(1).Text, 11, 3))
                        '"@Cuenta", Mid(lsv_Datos.Items(I).SubItems(1).Text, 16, 11))
                        '"@Numero", Mid(lsv_Datos.Items(I).SubItems(1).Text, 28, 7))

                        lsv_Cheques.Items.Add(lsv_Cheques.Items.Count + 1)
                        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add(Banco)
                        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add(Cuenta)
                        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add(Numero)
                        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add(Banda)
                        lsv_Cheques.Items(lsv_Cheques.Items.Count - 1).SubItems.Add(Importe)
                        Total += Decimal.Parse(Importe)
                    End If
                End If
            End If
        Loop Until sLine Is Nothing
        Archivo.Close()
        tbx_Importe.Text = Total
        If lsv_Cheques.Items.Count > 0 And tbx_DestinoCheques.Text <> "" Then
            Btn_ExtraerCheques.Enabled = True
        Else
            Btn_ExtraerCheques.Enabled = False
        End If
    End Sub

    Private Sub Btn_ExtraerCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ExtraerCheques.Click
        SegundosDesconexion = 0

        Dim Dt As DataTable
        Dim ms1 As MemoryStream
        Dim ms2 As MemoryStream
        If rdb_Frente.Checked = False And rdb_Back.Checked = False And rdb_Ambas.Checked = False Then
            MsgBox("Seleccione el tipo de Imagen que se extraerá.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        'recorrer la lista para buscar las imagenes de cada uno de los cheques
        For I As Integer = 0 To lsv_Cheques.Items.Count - 1
            Dt = Cn_Proceso.fn_Cheque_BuscaImagen(lsv_Cheques.Items(I).SubItems(1).Text, lsv_Cheques.Items(I).SubItems(2).Text, lsv_Cheques.Items(I).SubItems(3).Text, lsv_Cheques.Items(I).SubItems(5).Text)
            If Dt.Rows.Count > 0 Then
                'extraer la imagen
                lsv_Cheques.Items(I).Tag = Dt.Rows(0)("Id_Cheque")
                lsv_Cheques.Items(I).SubItems.Add("SI")

                'convertir los bytes a Imagen
                If rdb_Back.Checked = True Then GoTo Solo_Back
                ms1 = New MemoryStream(Dt.Rows(0)("Front1"), 0, Dt.Rows(0)("Front1").Length)
                ms1.Write(Dt.Rows(0)("Front1"), 0, Dt.Rows(0)("Front1").Length)
                Dim newImage1 As Image = Image.FromStream(ms1, True)
                'Mostrarla en el PictureBox
                pct_Front.Image = newImage1
                pct_Front.Image.Save(tbx_DestinoCheques.Text & "\F" & lsv_Cheques.Items(I).SubItems(4).Text & ".png")
                If rdb_Frente.Checked = True Then GoTo Solo_Font
Solo_Back:
                ms2 = New MemoryStream(Dt.Rows(0)("Back1"), 0, Dt.Rows(0)("Back1").Length)
                ms2.Write(Dt.Rows(0)("Back1"), 0, Dt.Rows(0)("Back1").Length)
                Dim newImage2 As Image = Image.FromStream(ms2, True)
                'Mostrarla en el PictureBox
                pct_Back.Image = newImage2
                pct_Back.Image.Save(tbx_DestinoCheques.Text & "\B" & lsv_Cheques.Items(I).SubItems(4).Text & ".png")
Solo_Font:
                lbl_Zoom.Visible = True
            Else
                'marcar la fila con rojo porque no se encontró
                lsv_Cheques.Items(I).ForeColor = Color.Red
                lbl_Rojo.Visible = True
            End If
        Next
    End Sub

    Private Sub LeerCheque(ByVal Id_Cheque As Long)
        SegundosDesconexion = 0

        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasChequesI_Read", CommandType.StoredProcedure, con)
        Dim dt As DataTable = New DataTable()
        'Leer de SQL
        Cn_Datos.Crea_Parametro(com, "@Id_Cheque", SqlDbType.BigInt, lsv_Cheques.SelectedItems(0).Tag)
        dt = Cn_Datos.EjecutaConsulta(com)
        If dt.Rows.Count > 0 Then
            'convertir los bytes a Imagen
            Dim ms1 As MemoryStream = New MemoryStream(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
            ms1.Write(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
            Dim newImage1 As Image = Image.FromStream(ms1, True)

            Dim ms2 As MemoryStream = New MemoryStream(dt.Rows(0)("Back1"), 0, dt.Rows(0)("Back1").Length)
            ms2.Write(dt.Rows(0)("Back1"), 0, dt.Rows(0)("Back1").Length)
            Dim newImage2 As Image = Image.FromStream(ms2, True)
            'Mostrarla en el PictureBox
            pct_Front.Image = newImage1
            pct_Back.Image = newImage2
        Else
            MsgBox("Cheque no Encontrado.", MsgBoxStyle.Information, frm_Menu.Text)
        End If
    End Sub

    Private Sub lsv_Cheques_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cheques.SelectedIndexChanged
        If lsv_Cheques.SelectedItems.Count > 0 Then
            If lsv_Cheques.SelectedItems(0).Tag IsNot Nothing Then
                Call LeerCheque(lsv_Cheques.SelectedItems(0).Tag)
            End If
        Else
            'pct_Back.Dispose()
            'pct_Front.Dispose()
        End If
    End Sub

    Private Sub pct_Front_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Front.MouseHover
        pct_Front.Cursor = Cursors.SizeAll
        pct_Front.Width = Me.Width - 70
        pct_Front.Height = (pct_Front.Width * 0.383)
        pct_Front.Left = 10
        pct_Back.Visible = False
    End Sub

    Private Sub pct_Front_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Front.MouseLeave
        pct_Front.Cursor = Cursors.Default
        pct_Front.Width = 470
        pct_Front.Height = 180
        pct_Front.Left = lsv_Cheques.Left + lsv_Cheques.Width + 6
        pct_Back.Visible = True
    End Sub

    Private Sub pct_Back_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Back.MouseHover
        pct_Back.Cursor = Cursors.SizeAll
        pct_Back.Width = Me.Width - 70
        pct_Back.Height = (pct_Back.Width * 0.383)
        pct_Back.Left = 10
        pct_Back.Top = pct_Front.Top
        pct_Front.Visible = False
    End Sub

    Private Sub pct_Back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Back.MouseLeave
        pct_Back.Cursor = Cursors.Default
        pct_Back.Width = 470
        pct_Back.Height = 180
        pct_Back.Left = lsv_Cheques.Left + lsv_Cheques.Width + 6
        pct_Front.Visible = True
        pct_Back.Top = pct_Front.Top + pct_Front.Height + 6
    End Sub

    Private Sub gbx_Filtro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Filtro.MouseHover, gbx_Cheques.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub Tab_Encriptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Encriptar.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Cheques_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cheques.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_RutaEncriptador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RutaEncriptador.Click
        SegundosDesconexion = 0

        Dim dlg As New OpenFileDialog
        dlg.InitialDirectory = "c:\"
        dlg.Filter = "Archivo Ejecutable(gpg.exe)|*.exe"
        dlg.ShowDialog()
        If dlg.FileName = "" Then
            MsgBox("Para continuar debe seleccionar la Ubicación del Encriptador.", 16 + 0, frm_MENU.Text)
            Exit Sub
        Else
            tbx_Encriptador.Text = dlg.FileName.Trim
            ModificoEncriptador = True
        End If
    End Sub

    Private Sub btn_RutaArchivoI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RutaArchivoI.Click
        With New FolderBrowserDialog
            If Not .ShowDialog() = Windows.Forms.DialogResult.OK Then Exit Sub
            RutaGuardarImgB64 = .SelectedPath & "\"
            tbx_ArchivoI.Text = .SelectedPath & "\"
            .Dispose()
        End With

        btn_GuardaImaB64.Enabled = IIf(lsv_Cheques.Items.Count > 0 And RutaGuardarImgB64 <> "", 1, 0)
    End Sub

    Private Sub btn_GuardaImaB64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardaImaB64.Click
        Dim ms1 As MemoryStream = Nothing
        Dim ms2 As MemoryStream = Nothing
        Dim Line As String
        Try
            Dim fs As FileStream = File.Create(RutaGuardarImgB64 & NombreArchivoB64)
            Dim sw As New StreamWriter(fs)

            For i As Integer = 0 To lsv_Cheques.Items.Count - 1
                Dim Dt As DataTable = Cn_Proceso.fn_Cheque_BuscaImagen(lsv_Cheques.Items(i).SubItems(1).Text, lsv_Cheques.Items(i).SubItems(2).Text, lsv_Cheques.Items(i).SubItems(3).Text, lsv_Cheques.Items(i).SubItems(5).Text)

                If Dt.Rows.Count > 0 Then
                    Line = "F,"
                    Line &= lsv_Cheques.Items(i).SubItems(4).Text & ","
                    Line &= ConvertBytesToBase64(Dt.Rows(0)("Front1"))
                    sw.WriteLine(Line.ToCharArray())
                    Line = ""

                    Line = "B,"
                    Line &= lsv_Cheques.Items(i).SubItems(4).Text & ","
                    Line &= ConvertBytesToBase64(Dt.Rows(0)("Back1"))
                    sw.WriteLine(Line.ToCharArray())
                    Line = ""
                End If
            Next
            sw.Close()
            sw.Close()
            MsgBox("Imagen generada con éxito.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_ArchivoI.Text = ""
            btn_GuardaImaB64.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try 
    End Sub
    Public Function ConvertBytesToBase64(ByVal byts As Byte()) As String
        Return Convert.ToBase64String(byts)
    End Function

    Public Function setFileStream(ByVal path As String, ByVal fla As System.IO.FileAccess) As FileStream
        Return New FileStream(path, FileMode.Open, fla)
    End Function
End Class