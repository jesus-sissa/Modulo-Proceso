Imports Modulo_Proceso.Cn_Proceso

Public Class frm_Saldos

    Private Sub frm_Saldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_CajaBancaria.Actualizar()
        cmb_Moneda.Actualizar()
        cmb_Sesion.AgregaParametro("@Fecha", dtp_Fecha.Value, 2)
        cmb_Sesion.Actualizar()

        lsv_EntradaxVerificar.Columns.Add("Tipo")
        lsv_EntradaxVerificar.Columns.Add("Importe")
        lsv_EntradasDisponibles.Columns.Add("Tipo")
        lsv_EntradasDisponibles.Columns.Add("Importe")

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        If cmb_Sesion.SelectedValue = "0" Then
            MsgBox("Seleccione la Sesión.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Sesion.Focus()
            Exit Sub
        End If

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Seleccione la Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If

        If cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Selecccione el Tipo de Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor

        If Not fn_SaldoServiciosDisponibleLlenalista(lsv_EntradasDisponibles, cmb_Sesion.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue) Then
            MsgBox("Ocurrio un errror al llenar la Lista de Verificado y Disponible.")
        End If

        If Not fn_SaldoServiciosXDisponerLlenalista(lsv_EntradaxVerificar, cmb_Sesion.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue) Then
            MsgBox("Ocurrio un errror al llenar la Lista por Contabilizar.")
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged

        SegundosDesconexion = 0
        cmb_Sesion.ActualizaValorParametro("@Fecha", dtp_Fecha.Value)
        cmb_Sesion.Actualizar()
        If cmb_Sesion.Items.Count = 2 Then
            cmb_Sesion.SelectedIndex = 1
        End If
        Call Limpiar()

    End Sub

    Sub Limpiar()
        lsv_EntradasDisponibles.Items.Clear()
        lsv_EntradaxVerificar.Items.Clear()
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Sesion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sesion.SelectedIndexChanged
        Call Limpiar()
    End Sub

End Class
