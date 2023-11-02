Public Class frm_FirmaConexion

    Public Validar As Boolean = False
    Dim Firma As String

    Private Sub Tbx_Contra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbx_Contra.KeyPress
        SegundosDesconexion = 0
        Validar = False
        If Asc(e.KeyChar) = Keys.Enter Then
            Firma = "SiST3MaSiaC" & DateTime.Now.Hour & DateTime.Now.Minute
            If Tbx_Contra.Text = "" Then
                MsgBox("Introdusca una Contraseña.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Firma <> Tbx_Contra.Text.Trim Then
                    MsgBox("Contraseña Incorecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Tbx_Contra.SelectAll()
                    Tbx_Contra.Focus()
                    Exit Sub
                Else
                    Validar = True
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub frm_FirmaConexion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Validar = False
            Me.Close()
        End If
    End Sub

End Class