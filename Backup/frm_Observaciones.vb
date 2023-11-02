Public Class frm_Observaciones

    Public Observaciones As String

    Private Sub frm_Observaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Observaciones = "-1"
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Observaciones = "-1"
        Me.Close()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click

        SegundosDesconexion = 0
        Observaciones = tbx_Observaciones.Text.Trim

        If Observaciones.Length < 10 Then
            MsgBox("Debe indicar observaciones mas descriptivas.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Observaciones.Focus()
            Exit Sub
        End If
        Me.Close()

    End Sub

End Class