Public Class cp_Combobox
    Inherits ComboBox

#Region "Eventos"
    Event ClickButton(ByVal sendes As Object, ByVal e As System.EventArgs)
#End Region

#Region "Variables Privadas"

    Private _Control_Siguiente As Control

#End Region

#Region "Propiedades"

    Public Property Control_Siguiente() As Control
        Get
            Return _Control_Siguiente
        End Get
        Set(ByVal value As Control)
            _Control_Siguiente = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Sub New()
        Me.DropDownStyle = ComboBoxStyle.DropDownList
        Me.MaxDropDownItems = 20
        Me.Width = 228
        Me.Height = 21
    End Sub
#End Region

#Region "Eventos Manejados"

    Private Sub cp_tbx_Texbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then

            'Aqui se pasa al siguiente control con enter
            If _Control_Siguiente Is Nothing Then SendKeys.Send(Chr(9)) Else _Control_Siguiente.Focus()
            e.Handled = True
            If TypeOf (_Control_Siguiente) Is Button Then RaiseEvent ClickButton(Me, New System.EventArgs)
            'If Not _Control_Siguiente Is Nothing Then
            '    SendKeys.Send(Chr(9)) '_Control_Siguiente.Focus()
            '    e.Handled = True
            '    If TypeOf (_Control_Siguiente) Is Button Then RaiseEvent ClickButton(Me, New System.EventArgs)
            'End If

        End If
    End Sub

#End Region

End Class
