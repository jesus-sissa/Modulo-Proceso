Public Class frm_ConfigurarPlantilla

    Private Sub frm_ConfigurarPlantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_PlantillaDotaciones.AgregaParametro("@Status", "A", 0)
        cmb_PlantillaDotaciones.Actualizar()
        cmb_PlantillaEfectivo.AgregaParametro("@Status", "A", 0)
        cmb_PlantillaEfectivo.Actualizar()
        cmb_PlantillaResguardos.AgregaParametro("@Status", "A", 0)
        cmb_PlantillaResguardos.Actualizar()
        Dim Dt_Plantilla As DataTable = Cn_Proceso.fn_ConsultarPlantilla
        If Dt_Plantilla Is Nothing Then
            MsgBox("Ocurrio un Error al Cargar la Plantilla de Impresión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Dt_Plantilla.Rows.Count = 0 Then
            MsgBox("No se ha configurado ninguna Plantilla de Impresión, Consulte a su Administrador de Sistemas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
        Else
            cmb_PlantillaEfectivo.SelectedValue = Dt_Plantilla.Rows(0)("PlantillaEfectivo")
            cmb_PlantillaDotaciones.SelectedValue = Dt_Plantilla.Rows(0)("PlantillaDotacion")
            cmb_PlantillaResguardos.SelectedValue = Dt_Plantilla.Rows(0)("PlantillaResguardo")
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If cmb_PlantillaEfectivo.SelectedValue = 0 Then
            MsgBox("Indique una Plantilla para las Efectivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PlantillaEfectivo.Focus()
            Exit Sub
        End If
        If cmb_PlantillaDotaciones.SelectedValue = 0 Then
            MsgBox("Indique una Plantilla para las Dotaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PlantillaDotaciones.Focus()
            Exit Sub
        End If
        If cmb_PlantillaResguardos.SelectedValue = 0 Then
            MsgBox("Indique una Plantilla para las Resguardos.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PlantillaResguardos.Focus()
            Exit Sub
        End If
        If Cn_Proceso.fn_ModificarPlantilla(cmb_PlantillaDotaciones.SelectedValue, cmb_PlantillaEfectivo.SelectedValue, cmb_PlantillaResguardos.SelectedValue) = False Then
            MsgBox("Ocurrio un Error Al Guardar la Plantilla de Impresión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            MsgBox("Se guardaron los Datos Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub
End Class