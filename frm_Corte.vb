Imports Modulo_Proceso.Cn_Proceso

Public Class frm_Corte
    Private Id_Sesion As Integer

    Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
        Dim Row As DataRow = fn_AbrirSesion_Verificar()

        If Row("Status") = "CERRADA" Then
            MsgBox("No existe ninguna Sesion abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
        Else
            MyBase.OnShown(e)

            cmb_CajaBancaria.Actualizar()
            tbx_Sesion.Text = Row("Numero_Sesion")
            Id_Sesion = Row("Id_Sesion")

        End If
    End Sub

    Public Sub TryShow()
        Me.Show()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        Btn_Generar.Enabled = cmb_CajaBancaria.SelectedValue > 0
        If Not cmb_CajaBancaria.SelectedValue = 0 Then
            tbx_CorteActual.Text = fn_Corte_CorteActual(cmb_CajaBancaria.SelectedValue, Id_Sesion)
        Else
            tbx_CorteActual.Text = ""
        End If
    End Sub

    Private Sub Btn_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Generar.Click
        SegundosDesconexion = 0

        If cmb_CajaBancaria.SelectedValue > 0 Then
            If fn_Corte_Crear(Id_Sesion, cmb_CajaBancaria.SelectedValue) Then
                cmb_CajaBancaria_SelectedValueChanged(cmb_CajaBancaria, e)
            Else
                MsgBox("Ha ocurrido un error al generar el Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If

    End Sub

    Private Sub frm_Corte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class