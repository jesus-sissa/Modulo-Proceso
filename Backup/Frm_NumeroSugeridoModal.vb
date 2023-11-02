Public Class Frm_NumeroSugeridoModal
    Private _Valor As Integer = 1

    Public Property valor() As Integer
        Get
            Return tbx_Valor.Text
        End Get
        Set(ByVal value As Integer)
            _Valor = value
        End Set
    End Property

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub tbx_Valor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_Valor.TextChanged
        If tbx_Valor.Text = "" Then
            MsgBox("Debe escribir un valor.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Valor.Text = _Valor
        ElseIf CInt(tbx_Valor.Text) < _Valor Then
            MsgBox("El valor no puede ser inferior a " & _Valor, MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Valor.Text = _Valor
        End If
        tbx_Valor.ForeColor = Color.Red
    End Sub

    Private Sub Frm_NumeroSugeridoModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tbx_Valor.Text = _Valor
    End Sub
End Class