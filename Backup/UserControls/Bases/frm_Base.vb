Public Class frm_Base
    Inherits Windows.Forms.Form

    Public Event F2(ByVal sender As Object, ByVal e As System.EventArgs)

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = System.Windows.Forms.Keys.F2 Then
            RaiseEvent F2(Me, New System.EventArgs)
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

End Class
