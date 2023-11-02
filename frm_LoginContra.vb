Imports System.Web.Security

Public Class frm_LoginContra

    Dim Dt_Contras As DataTable

    Private Sub frm_LoginContra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dt_Contras = Cn_Login.UsuariosContra_Consultar10(UsuarioId)
    End Sub

    Private Sub cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancel.Click
        BanderA = False
        Me.Close()
    End Sub

    Private Sub cmd_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_OK.Click
        Call Validar()
    End Sub

    Sub Validar()
        Dim BanderA_Local As Boolean
        Dim Fecha_Utilizada As String
        If tbx_Nueva.Text <> tbx_Nueva1.Text Then
            MsgBox("La confirmación no coincide con la nueva Contraseña.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Dim HashLocal As String = FormsAuthentication.HashPasswordForStoringInConfigFile(tbx_Nueva.Text, "SHA1")

        If Not FuncionesGlobales.fn_Valida_Cadena(tbx_Nueva.Text, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            'En caso de que el nombre no sea valido
            MsgBox("Indique una Contraseña válida.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nueva.Focus()
            Exit Sub
        End If

        BanderA_Local = FuncionesGlobales.fn_Valida_Contra(tbx_Nueva.Text)
        tbx_Nueva.Text = ""
        tbx_Nueva1.Text = ""
        If BanderA_Local Then
            'Validar que no sea igual a las ultimas 10 claves
            For Each dr As DataRow In Dt_Contras.Rows
                If HashLocal = dr("Contra") Then
                    Fecha_Utilizada = dr("Fecha")
                    BanderA_Local = False
                    Exit For
                End If
            Next
            If BanderA_Local Then
                'guardar la nueva clave
                If Cn_Login.UsuariosContra_Update(UsuarioId, HashLocal) > 0 Then
                    BanderA = True
                Else
                    BanderA = False
                End If

                Me.Close()
            Else
                MsgBox("La contraseña nueva no debe ser igual a una de las últimas 10 utilizadas (Esta la utilizó el " & Fecha_Utilizada & ").", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            MsgBox("La contraseña nueva no cumple con los requerimientos." & Chr(13) & "Por lo menos 4 Números." & Chr(13) & "Por lo menos 4 Letras." & Chr(13) & "Por lo menos 1 Mayúscula." & Chr(13) & "Por lo menos 1 Minúscula.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub tbx_Nueva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Nueva.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbx_Nueva1.Focus()
        End If
    End Sub

    Private Sub tbx_Nueva1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Nueva1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Validar()
        End If
    End Sub


End Class