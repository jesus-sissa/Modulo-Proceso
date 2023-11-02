Imports System.IO

Public Class frm_DescargarArchivo

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub frm_DescargarArchivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Cn_Proceso.fn_ModulosArchivos_LlenarLista(lsv_Archivos, ModuloClave) Then
            MsgBox("Ocurrió un error al intentar consultar los Archivios.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        lsv_Archivos.SmallImageList = ImageList1

        For Each elemento As ListViewItem In lsv_Archivos.Items
            If Microsoft.VisualBasic.Right((elemento.SubItems(1).Text), 3) = "DOC" Then
                elemento.ImageIndex = 0 ' word 97-2003
            ElseIf Microsoft.VisualBasic.Right((elemento.SubItems(1).Text), 4) = "DOCX" Then
                elemento.ImageIndex = 1 ' word 2007-2010
            ElseIf Microsoft.VisualBasic.Right((elemento.SubItems(1).Text), 3) = "PPS" Then
                elemento.ImageIndex = 2 ' powerpoint 97-2003
            ElseIf Microsoft.VisualBasic.Right((elemento.SubItems(1).Text), 4) = "PPSX" Then
                elemento.ImageIndex = 3 ' powerpoint 2007-2010
            ElseIf Microsoft.VisualBasic.Right((elemento.SubItems(1).Text), 3) = "PDF" Then
                elemento.ImageIndex = 4 ' pdf
            End If
        Next
    End Sub

    Private Sub lsv_Archivos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Archivos.DoubleClick, btn_Descargar.Click
        If lsv_Archivos.SelectedItems.Count = 0 Then Exit Sub
        Call DescargarArchivo()
    End Sub

    Sub DescargarArchivo()
        Dim Dialogo As New FolderBrowserDialog With {.Description = "Destino del Archivo.", .ShowNewFolderButton = True}
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            lsv_Archivos.SelectedItems.Clear()
            Exit Sub
        End If

        Dim CarpetaDestino As String = Dialogo.SelectedPath
        If CarpetaDestino.Length = 3 Then
            CarpetaDestino = CarpetaDestino & lsv_Archivos.SelectedItems(0).SubItems(1).Text
        Else
            CarpetaDestino = CarpetaDestino & "\" & lsv_Archivos.SelectedItems(0).SubItems(1).Text
        End If

        Try
            If File.Exists(CarpetaDestino) Then
                lsv_Archivos.SelectedItems.Clear()
                MsgBox("El Archivo ya existe. Imposible Continuar.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Dim fileData As Byte() = Cn_Proceso.fn_Archivos_Descargar(lsv_Archivos.SelectedItems(0).Tag)

            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New FileStream(CarpetaDestino, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()
                End Using

                'Open File
                If MsgBox("El Archivo se descargó correctamente. Desea Abrirlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                    Process.Start(CarpetaDestino)
                    lsv_Archivos.SelectedItems.Clear()
                End If
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar guardar el Archivo. " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Archivos.SelectedItems.Clear()
        End Try
    End Sub

    Private Sub lsv_Archivos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Archivos.SelectedIndexChanged
        If lsv_Archivos.SelectedItems.Count > 0 Then
            btn_Descargar.Enabled = True
        Else
            btn_Descargar.Enabled = False
        End If
    End Sub
End Class