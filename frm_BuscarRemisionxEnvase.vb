Imports Modulo_Proceso.Cn_Proceso
Public Class frm_BuscarRemisionxEnvase
    Private Sub frm_BuscarRemisionxEnvase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If tbx_Envase.Text.Trim = String.Empty Then Exit Sub
        NumeroRemision = BuscarRemisionxEnvase(tbx_Envase.Text.Trim)
        Close()
    End Sub
End Class