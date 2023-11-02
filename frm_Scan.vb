Imports System.IO
Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class frm_Scan

    Private Declare Function BInit Lib "buicap32.dll" Alias "BUICInit" () As Integer
    Private Declare Function BExit Lib "buicap32.dll" Alias "BUICExit" () As Integer
    Private Declare Function BScan Lib "buicap32.dll" Alias "BUICScan" (ByVal iJobType As Integer, ByVal lpFront As String, ByVal lpLenFront As String, ByVal lpBack As String, ByVal lpLenBack As String, ByVal lpCode As String, ByVal lpLenCode As String) As Integer
    Private Declare Function BStatus Lib "buicap32.dll" Alias "BUICStatus" () As Integer
    Private Declare Function BGetMICR Lib "buicap32.dll" Alias "BUICSetMicrLine" (ByVal InputFile As String, ByVal page As Integer, ByVal MicrLine As String, ByVal MicrLineSize As String) As Integer
    Private Declare Function BEject Lib "buicap32.dll" Alias "BUICEjectDocument" () As Integer

    Dim Contador As Integer = 1
    Dim Nombre_Front As String = ""
    Dim Nombre_Back As String = ""

    Function Inicia_Scanner() As Boolean
        Dim k As Integer
        Try
            For k = 1 To 3
                If k > 1 Then
                    'LBRep.Text = LBRep.Text + CStr(Time) + " : Reintentando inicializar el scanner, espere un momento... Intento " + CStr(k) + " de 3." + Chr(13)
                    'LBRep.SelStart = Len(LBRep)
                    'LBRep.Refresh()
                End If
                If BInit = 1 Then
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
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor
        lsv_Datos.Items.Clear()
        lsv_Log.Items.Clear()
        btn_Inicio.Enabled = False
        btn_Atascos.Enabled = False
        'pct_Front.Image = Nothing
        'pct_Back.Image = Nothing
        txt_MICR.Clear()
        If Inicia_Scanner() = True Then
            btn_Escanear.Enabled = True
            btn_Finalizar.Enabled = True
            Call Agrega_Log("Scanner Inicializado.")
        Else
            Call Agrega_Log("No se encontró el scanner o no se pudo inicializar.")
            MsgBox("No se encontró el scanner o no se pudo inicializar.", 16 + 0, frm_Menu.Text)
            btn_Inicio.Enabled = True
        End If
        Contador = 1
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Finalizar.Click
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor
        BExit()
        btn_Inicio.Enabled = True
        btn_Escanear.Enabled = False
        btn_Finalizar.Enabled = False
        btn_Atascos.Enabled = False
        Call Agrega_Log("Scanner liberado.")
        If lsv_Datos.Items.Count > 0 Then
            btn_Guardar.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Escanear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Escanear.Click
        SegundosDesconexion = 0

        Dim LenFront As String = ""
        Dim LenBack As String = ""
        Dim Code As String = ""
        Dim CodeS As String = ""
        Dim Car As String = ""
        Dim LenCode As String = ""
        Dim k As Integer = 0
        Dim Ruta As String
        Dim Resu As Integer

        'Iniciar la escaneada
        Me.Cursor = Cursors.WaitCursor
        btn_Atascos.Enabled = True
        Ruta = txt_Ruta.Text
        Nombre_Front = ""
        Nombre_Back = ""
        If BStatus = 1 Then
            Do
                LenFront = Space(64)
                LenBack = Space(64)
                Code = Space(200)
                LenCode = Space(16)

                'Contador += 1
                If Len(Ruta) <= 3 Then 'en caso de que sea c:\
                    Nombre_Front = Ruta & "F" & FuncionesGlobales.fn_PonerCeros(Trim(Str(Contador)), 4) & ".tif"
                    Nombre_Back = Ruta & "B" & FuncionesGlobales.fn_PonerCeros(Trim(Str(Contador)), 4) & ".tif"
                Else
                    Nombre_Front = Ruta & "\F" & FuncionesGlobales.fn_PonerCeros(Trim(Str(Contador)), 4) & ".tif"
                    Nombre_Back = Ruta & "\B" & FuncionesGlobales.fn_PonerCeros(Trim(Str(Contador)), 4) & ".tif"
                End If

                Resu = BScan(7, Nombre_Front, LenFront, Nombre_Back, LenBack, Code, LenCode)

                If Val(LenCode) <> 0 Then
                    pct_Front.ImageLocation = Nombre_Front
                    pct_Back.ImageLocation = Nombre_Back
                    pct_Front.Tag = Nombre_Front
                    pct_Back.Tag = Nombre_Back
                    CodeS = Trim(Code)
                    For k = 1 To Len(CodeS) - 1
                        Car = Mid(CodeS, k, 1)
                        If InStr(1, "0123456789", Car) = 0 Then
                            CodeS = Replace(CodeS, Car, "-")
                        End If
                    Next
                    'CodeS = Replace(CodeS, "-", "")
                    txt_MICR.Text = CodeS
                    Call Agrega_Cheque(txt_MICR.Text, Nombre_Front, Nombre_Back)
                    Call Agrega_Log("Cheque Capturado correctamente. " & Nombre_Front)
                    Contador += 1
                End If
            Loop Until Val(LenCode) = 0
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Coloque por lo menos un Cheque en la Bandeja del Equipo.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Datos.Items.Count > 0 Then
            btn_Guardar.Enabled = True
            btn_Manual1.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Sub Agrega_Cheque(ByVal Micr As String, ByVal RutaFront As String, ByVal RutaBack As String)
        SegundosDesconexion = 0

        Dim Elemento As New ListViewItem
        Elemento.Text = Trim(Str(lsv_Datos.Items.Count + 1))
        Elemento.SubItems.Add(Micr)
        Elemento.SubItems.Add(RutaFront)
        Elemento.SubItems.Add(RutaBack)
        Elemento.SubItems.Add("PENDIENTE")
        Elemento.SubItems.Add("0")
        lsv_Datos.Sorting = SortOrder.None
        lsv_Datos.Items.Insert(0, Elemento)

    End Sub

    Sub Agrega_Log(ByVal Cadena As String)
        lsv_Log.Items.Add(Trim(Str(lsv_Log.Items.Count + 1)))
        lsv_Log.Items(lsv_Log.Items.Count - 1).SubItems.Add(TimeString)
        lsv_Log.Items(lsv_Log.Items.Count - 1).SubItems.Add(Cadena)
    End Sub

    Private Sub btn_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ruta.Click
        SegundosDesconexion = 0

        dlg_Ruta.ShowNewFolderButton = False
        dlg_Ruta.SelectedPath = Application.StartupPath.ToString
        dlg_Ruta.ShowDialog()
        If dlg_Ruta.SelectedPath = "" Then
            MsgBox("Seleccione la Ubicación para las Imágenes.", 16 + 0, frm_MENU.Text)
            Exit Sub
        Else
            txt_Ruta.Text = dlg_Ruta.SelectedPath
            'Aqui se eliminan todas las imagenes anteriores
            If System.IO.Directory.GetFiles(txt_Ruta.Text, "*.tif").Length > 0 Then
                'If MsgBox("Se encontrarón algunas imagenes en la carpeta destino, al generar el archivo las imagenes se eliminarán. ¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                Kill(txt_Ruta.Text & "\*.tif")
                'Else
                'Exit Sub
                'End If
            End If
            btn_Inicio.Enabled = True
        End If
    End Sub

    Private Sub frm_Scan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Datos.Columns.Add("ID", 40)
        lsv_Datos.Columns.Add("MICR", 300)
        lsv_Datos.Columns.Add("Front", 200)
        lsv_Datos.Columns.Add("Back", 200)
        lsv_Datos.Columns.Add("Guardado", 50)

        lsv_Log.Columns.Add("ID", 40)
        lsv_Log.Columns.Add("Hora", 80)
        lsv_Log.Columns.Add("Mensaje", 360)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Resu As Integer
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasCheques_GetId", CommandType.StoredProcedure, con)
        Dim sql As String = ""
        Me.Cursor = Cursors.WaitCursor
        Dim NoEncontrados As Integer = 0
        Dim EncontradosImagen As Integer = 0
        Dim DT As DataTable

        'Primero buscar el Id en SIAC..Pro_FichasCheques
        For I As Integer = 0 To lsv_Datos.Items.Count - 1
            com.Parameters.Clear()

            Cn_Datos.Crea_Parametro(com, "@Clave_Banco", SqlDbType.VarChar, Mid(lsv_Datos.Items(I).SubItems(1).Text, 11, 3))
            Cn_Datos.Crea_Parametro(com, "@Cuenta", SqlDbType.VarChar, Mid(lsv_Datos.Items(I).SubItems(1).Text, 16, 11))
            Cn_Datos.Crea_Parametro(com, "@Numero", SqlDbType.VarChar, Mid(lsv_Datos.Items(I).SubItems(1).Text, 28, 7))
            DT = Cn_Datos.EjecutaConsulta(com)
            If DT.Rows.Count > 0 Then
                If DT.Rows(0)("Imagen") = 0 Then
                    'si no se encontró la imagen me pone el Id_Cheque en el tag para
                    'que se guarde en el siguiente ciclo
                    lsv_Datos.Items(I).Tag = DT.Rows(0)("Id_Cheque")
                Else
                    'si la imagen ya existe no me pone el tag para que no se guarde
                    'porque ya esta guardada con anterioridad
                    lsv_Datos.Items(I).Tag = 0
                    lsv_Datos.Items(I).ForeColor = Color.Green
                    lsv_Datos.Items(I).SubItems(1).ForeColor = Color.Green
                    lsv_Datos.Items(I).SubItems(2).ForeColor = Color.Green
                    lsv_Datos.Items(I).SubItems(3).ForeColor = Color.Green
                    lsv_Datos.Items(I).SubItems(4).ForeColor = Color.Green
                    EncontradosImagen += 1
                End If
            Else
                'marcarlo en rojo cuando no se encontró el cheque
                lsv_Datos.Items(I).Tag = 0
                lsv_Datos.Items(I).ForeColor = Color.Red
                lsv_Datos.Items(I).SubItems(1).ForeColor = Color.Red
                lsv_Datos.Items(I).SubItems(2).ForeColor = Color.Red
                lsv_Datos.Items(I).SubItems(3).ForeColor = Color.Red
                lsv_Datos.Items(I).SubItems(4).ForeColor = Color.Red
                NoEncontrados += 1
            End If
            DT.Clear()
        Next
        If NoEncontrados > 0 Or EncontradosImagen > 0 Then
            If MsgBox(NoEncontrados & " Cheques no se han procesado." & Chr(13) & EncontradosImagen & " Cheques. La imagen ya ha sido guardada anteriormente." & Chr(13) & Chr(13) & " Desea continuar y guardar solo los restantes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Me.Cursor = Cursors.Default
                MsgBox("No se guardó ninguna Imagen.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
        End If

        'Se guardan solo los que se encontraron en la Base de datos ChequesI..Pro_FichasChequesI
        com = Cn_Datos.Crea_Comando("Pro_FichasChequesI_Create", CommandType.StoredProcedure, con)
        For I As Integer = 0 To lsv_Datos.Items.Count - 1
            'convertir la imagen a Bytes
            If lsv_Datos.Items(I).Tag > 0 Then 'Solo se guardan los que se encontró el Id
                Dim fs1 As New System.IO.FileStream(lsv_Datos.Items(I).SubItems(2).Text, System.IO.FileMode.Open)
                Dim fs2 As New System.IO.FileStream(lsv_Datos.Items(I).SubItems(3).Text, System.IO.FileMode.Open)
                Dim imageAsBytes1 As Byte() = New Byte(fs1.Length - 1) {}
                Dim imageAsBytes2 As Byte() = New Byte(fs2.Length - 1) {}
                fs1.Read(imageAsBytes1, 0, imageAsBytes1.Length)
                fs1.Close()
                fs2.Read(imageAsBytes2, 0, imageAsBytes2.Length)
                fs2.Close()
                'Guardar en SQL
                com.Parameters.Clear()
                Cn_Datos.Crea_Parametro(com, "@Id_Cheque", SqlDbType.BigInt, lsv_Datos.Items(I).Tag)
                Cn_Datos.Crea_Parametro(com, "@Front1", SqlDbType.Image, imageAsBytes1)
                Cn_Datos.Crea_Parametro(com, "@Back1", SqlDbType.Image, imageAsBytes2)
                Resu = Cn_Datos.EjecutarNonQuery(com)
                If Resu > 0 Then
                    Agrega_Log("Cheque Guardado. " & lsv_Datos.Items(I).SubItems(1).Text)
                    lsv_Datos.Items(I).SubItems(4).Text = "SI"
                Else
                    Agrega_Log("No se pudo Guardar en Cheque. " & lsv_Datos.Items(I).SubItems(1).Text)
                    lsv_Datos.Items(I).SubItems(4).Text = "NO"
                    lsv_Datos.Items(I).ForeColor = Color.Red
                End If
            Else
                lsv_Datos.Items(I).SubItems(4).Text = "NO"
            End If
        Next
        com.Connection.Close()
        com.Dispose()
        Me.Cursor = Cursors.Default
        btn_Guardar.Enabled = False
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor
        Try
            BExit()
        Catch

        End Try
        Me.Close()
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        btn_Eliminar.Enabled = False
        'mostrar las imagenes en los PCTs
        If lsv_Datos.SelectedItems.Count = 0 Then Exit Sub
        Try
            pct_Front.ImageLocation = lsv_Datos.SelectedItems(0).SubItems(2).Text
            pct_Front.Load()
            pct_Back.ImageLocation = lsv_Datos.SelectedItems(0).SubItems(3).Text
            pct_Back.Load()
            btn_Eliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_Atascos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Atascos.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If BEject = 0 Then
            MsgBox("Bandeja liberdada.", vbInformation, frm_MENU.Text)
        Else
            MsgBox("Error " + CStr(BEject), vbCritical, frm_MENU.Text)
        End If
    End Sub

    Private Sub pct_Front_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Front.MouseHover
        pct_Front.Cursor = Cursors.SizeAll
        pct_Front.Width = Me.Width - 45
        pct_Front.Height = (pct_Front.Width * 0.383)
        pct_Back.Visible = False
        gbx_Imagen.Height = pct_Front.Top + pct_Front.Height + 20
    End Sub

    Private Sub pct_Front_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Front.MouseLeave
        pct_Front.Cursor = Cursors.Default
        pct_Front.Width = 460
        pct_Front.Height = 182
        pct_Back.Visible = True
        gbx_Imagen.Height = pct_Front.Top + pct_Front.Height + 35
    End Sub

    Private Sub pct_Back_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Back.MouseHover
        pct_Back.Cursor = Cursors.SizeAll
        pct_Back.Width = Me.Width - 45
        pct_Back.Height = (pct_Back.Width * 0.383)
        pct_Back.Left = pct_Front.Left
        pct_Front.Visible = False
        gbx_Imagen.Height = pct_Back.Top + pct_Back.Height + 20
    End Sub

    Private Sub pct_Back_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pct_Back.MouseLeave
        pct_Back.Cursor = Cursors.Default
        pct_Back.Width = 460
        pct_Back.Height = 182
        pct_Back.Left = pct_Front.Left + pct_Front.Width + 6
        pct_Front.Visible = True
        gbx_Imagen.Height = pct_Back.Top + pct_Back.Height + 35
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        'Elimina el cheque de la lista, elimina las imagenes y reordena el indice
        Try
            Dim Banda As String = lsv_Datos.SelectedItems(0).SubItems(1).Text
            'Borrar Imagenes
            My.Computer.FileSystem.DeleteFile(lsv_Datos.SelectedItems(0).SubItems(2).Text)
            My.Computer.FileSystem.DeleteFile(lsv_Datos.SelectedItems(0).SubItems(3).Text)
            lsv_Datos.SelectedItems(0).Remove()
            'corregir la numeración de la primer columna
            'en indice que se reasigna es descendente
            For I As Integer = 0 To lsv_Datos.Items.Count - 1
                lsv_Datos.Items(I).Text = lsv_Datos.Items.Count - I
            Next
            btn_Eliminar.Enabled = False
            Agrega_Log("Se eliminó el Cheque: " & Banda)
            MsgBox("Cheque eliminado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Catch Ex As Exception
            FuncionesGlobales.fn_GuardaError("frm_Scan.Btn_Eliminar", "0", Ex.Message, True)
            MsgBox("Ocurrió un error al intentar eliminar el Cheque de la lista." & vbCr & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)

        End Try
    End Sub

    Private Sub btn_Manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual1.Click
        SegundosDesconexion = 0

        If lsv_Datos.Items.Count = 0 Then
            MsgBox("Primero debe escanear el Cheque que va a capturar manualmente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        txt_MICR.Enabled = True
        txt_MICR.Clear()
        txt_MICR.Focus()
        btn_Manual2.Enabled = True
        btn_Manual1.Enabled = False
        lsv_Datos.Items.Clear()
    End Sub

    Private Sub btn_Manual2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual2.Click
        SegundosDesconexion = 0

        If txt_MICR.Text.Length < 34 Then
            MsgBox("Lectura Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            txt_MICR.SelectAll()
            txt_MICR.Focus()
            Exit Sub
        End If
        If Not Modulo_Proceso.FuncionesGlobales.ValidaMICR(txt_MICR.Text) Then Exit Sub
        txt_MICR.Enabled = False
        btn_Manual1.Enabled = True
        btn_Manual2.Enabled = False
        lsv_Datos.Items.Clear()
        'Call Agrega_Cheque(txt_MICR.Text, Nombre_Front, Nombre_Back)
        'Ya no se agrega porque el nombre de la imagen ya no coincide y marca error al guardar.
        'Cuando se escanea se guarda la imagen e inmediatamente las variables de nombre se modifican por la siguiente
        'por eso al guardar marcaba error
        '19-Ago-2011
        Dim Elemento As New ListViewItem
        Elemento.Text = Trim(Str(lsv_Datos.Items.Count + 1))
        Elemento.SubItems.Add(txt_MICR.Text)
        Elemento.SubItems.Add(pct_Front.Tag.ToString)
        Elemento.SubItems.Add(pct_Back.Tag.ToString)
        Elemento.SubItems.Add("PENDIENTE")
        Elemento.SubItems.Add("0")
        lsv_Datos.Sorting = SortOrder.None
        lsv_Datos.Items.Insert(0, Elemento)

        Call Agrega_Log("Cheque MANUAL correctamente. " & txt_MICR.Text & " - " & Nombre_Front)
        If lsv_Datos.Items.Count > 0 Then
            btn_Guardar.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub gbx_Imagen_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Imagen.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.MouseHover, lsv_Log.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class