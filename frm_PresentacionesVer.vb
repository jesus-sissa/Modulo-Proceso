Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing


Public Class frm_PresentacionesVer

    Dim Dt As DataTable
    Dim FilasTotal As Integer = 0
    Dim FilaActual As Integer = 0

    Private Sub frm_Presentaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lsv_PresentacionesD.Columns.Add("Consecutivo")
        lsv_PresentacionesD.Columns.Add("Titulo")
        lsv_PresentacionesD.Columns.Add("Comentarios")

        If Not Cn_Presentaciones.fn_VerPresentaciones_LlenarLista(lsv_Presentaciones) Then
            MsgBox("Ocurrió un error al intentar leer las Presentaciones Disponibles.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        gbx_Ver.Height = Me.Height - 40

    End Sub

    Private Sub lsv_Presentaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Presentaciones.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_PresentacionesD.Items.Clear()
        If lsv_Presentaciones.SelectedItems.Count = 0 Then
            btn_Ver.Enabled = False
            Exit Sub
        End If
        If Not Cn_Presentaciones.fn_VerPresentacionesI_LlenarLista(lsv_PresentacionesD, lsv_Presentaciones.SelectedItems(0).Tag) Then
            MsgBox("Ocurrió un error al intentar leer las Diapositivas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Ver.Enabled = True

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ver.Click
        SegundosDesconexion = 0

        gbx_Ver.Visible = True

        'Leer las Imagenes y guardarlas en una carpeta temporal

        Dt = Cn_Presentaciones.fn_VerPresentacionesImg_Consultar(lsv_Presentaciones.SelectedItems(0).Tag)
        If Dt Is Nothing Then
            MsgBox("Ocurrió un error al intentar leer las Diapositivas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Dt.Rows.Count = 0 Then
            MsgBox("Ocurrió un error al intentar leer las Diapositivas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        FilasTotal = Dt.Rows.Count
        FilaActual = 0
        btn_Anterior.Enabled = False
        btn_Siguiente.Enabled = True
        lbl_Contador.Text = FilaActual + 1 & " de " & FilasTotal
        'Extraer las imagenes
        If Not IsDBNull(Dt.Rows(FilaActual)("Diapositiva")) Then
            Dim ms1 As MemoryStream = New MemoryStream(Dt.Rows(FilaActual)("Diapositiva"), 0, Dt.Rows(FilaActual)("Diapositiva").Length)
            ms1.Write(Dt.Rows(FilaActual)("Diapositiva"), 0, Dt.Rows(FilaActual)("Diapositiva").Length)
            pct_Diapositiva.Image = Image.FromStream(ms1, True)
            ms1.Close()
        End If
        If FilasTotal = 1 Then btn_Siguiente.Enabled = False
    End Sub

    Private Sub btn_CerrarPresentacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerrarPresentacion.Click
        SegundosDesconexion = 0

        gbx_Ver.Visible = False
        Dt.Dispose()
    End Sub

    Private Sub btn_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Siguiente.Click
        SegundosDesconexion = 0

        FilaActual += 1
        If FilaActual <= (FilasTotal - 1) Then
            btn_Anterior.Enabled = True
        End If

        If Not IsDBNull(Dt.Rows(FilaActual)("Diapositiva")) Then
            Dim ms1 As MemoryStream = New MemoryStream(Dt.Rows(FilaActual)("Diapositiva"), 0, Dt.Rows(FilaActual)("Diapositiva").Length)
            ms1.Write(Dt.Rows(FilaActual)("Diapositiva"), 0, Dt.Rows(FilaActual)("Diapositiva").Length)
            pct_Diapositiva.Image = Image.FromStream(ms1, True)
        End If
        If FilaActual = (FilasTotal - 1) Then
            btn_Siguiente.Enabled = False
        End If
        lbl_Contador.Text = FilaActual + 1 & " de " & FilasTotal
    End Sub

    Private Sub btn_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Anterior.Click
        SegundosDesconexion = 0

        FilaActual -= 1
        If FilaActual >= 0 Then
            btn_Siguiente.Enabled = True
        End If
        Dim ms1 As MemoryStream
        If Not IsDBNull(Dt.Rows(FilaActual)("Diapositiva")) Then
            ms1 = New MemoryStream(Dt.Rows(FilaActual)("Diapositiva"), 0, Dt.Rows(FilaActual)("Diapositiva").Length)
            ms1.Write(Dt.Rows(FilaActual)("Diapositiva"), 0, Dt.Rows(FilaActual)("Diapositiva").Length)
            pct_Diapositiva.Image = Image.FromStream(ms1, True)
        End If
        If FilaActual = 0 Then
            btn_Anterior.Enabled = False
        End If
        lbl_Contador.Text = FilaActual + 1 & " de " & FilasTotal
    End Sub

    Private Sub frm_Presentaciones_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        gbx_Ver.Height = Me.Height - 40
        pct_Diapositiva.Height = gbx_Ver.Height - 75
        gbx_Botones2.Top = gbx_Ver.Height - 55
    End Sub

    Private Sub pct_Diapositiva_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_Diapositiva.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Presentaciones_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Presentaciones.MouseHover, lsv_PresentacionesD.MouseHover
        SegundosDesconexion = 0
    End Sub

End Class