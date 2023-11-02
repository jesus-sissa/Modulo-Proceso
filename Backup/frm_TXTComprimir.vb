Imports Ionic.Utils.Zip

Public Class frm_TXTComprimir

    Private Sub btn_Comprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Comprimir.Click
        SegundosDesconexion = 0

        Dim Destino As String = ""
        If tbx_Destino.Text.Length < 4 Then
            MsgBox("Indique un Nombre de Archivo válido.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Archivo.SelectAll()
            tbx_Archivo.Focus()
            Exit Sub
        End If
        If tbx_Destino.Text.Length <= 4 Then
            Destino = tbx_Destino.Text & tbx_Archivo.Text & ".zip"
        Else
            Destino = tbx_Destino.Text & "\" & tbx_Archivo.Text & ".zip"
        End If
        Try
            Dim zip As New ZipFile(Destino)
            zip.Comment = "SISSA. Sistema Integral de Administración y Control."

            'Por defecto agrega recursivamente archivos y
            'subdirectorios dentro del directorio original
            'zip.AddDirectory("c:\Temp")
            For I As Integer = 0 To lsv_Datos.Items.Count - 1
                zip.AddFile(lsv_Datos.Items(I).Text)
            Next I
            zip.Save()
            MsgBox("Archivo generado con éxito. " & Destino, MsgBoxStyle.Information, frm_MENU.Text)
        Catch
            MsgBox("Ocurrió un error al intentar Generar el Archivo " & Destino, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_Descomprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Descomprimir.Click
        SegundosDesconexion = 0

        Dim zipSalida As ZipFile = ZipFile.Read("c:\Archivo.zip")
        zipSalida.ExtractAll("c:\TmpSalida")
    End Sub

    Private Sub btn_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Seleccionar.Click
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        Dim Dialogo As New OpenFileDialog
        btn_Comprimir.Enabled = False
        If rb_Archivos.Checked Then
            Dialogo.Multiselect = True
            Dialogo.InitialDirectory = "c:\"
            Dialogo.ShowDialog()
            For I As Integer = 0 To Dialogo.FileNames.Count - 1
                lsv_Datos.Items.Add(Dialogo.FileNames(I).ToString)
            Next
            tbx_Archivo.Text = Dialogo.SafeFileNames(0).ToString
        ElseIf rb_Carpeta.Checked Then
            dlg_Folder.SelectedPath = "c:\"
            dlg_Folder.ShowNewFolderButton = False
            dlg_Folder.ShowDialog()

        End If

        If lsv_Datos.Items.Count > 0 Then
            btn_Comprimir.Enabled = True
        Else
            btn_Comprimir.Enabled = False
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_Comprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Datos.Columns.Add("Archivo", lsv_Datos.Width - 50)
    End Sub

    Private Sub btn_Destino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Destino.Click
        SegundosDesconexion = 0

        dlg_Folder.SelectedPath = "c:\"
        dlg_Folder.ShowNewFolderButton = True
        dlg_Folder.ShowDialog()
        If dlg_Folder.SelectedPath = "" Then

        Else
            tbx_Destino.Text = dlg_Folder.SelectedPath
        End If
    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class