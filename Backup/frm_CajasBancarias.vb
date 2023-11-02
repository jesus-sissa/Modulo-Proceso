Imports Modulo_Proceso.Cn_Proceso

Public Class frm_CajasBancarias

    Private Sub frm_CajasBancarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        Cmb_DigSeg.AgregarItem("S", "SI")
        Cmb_DigSeg.AgregarItem("N", "NO")
        Cmb_RefDepo.AgregarItem("N", "NUMERICO")
        Cmb_RefDepo.AgregarItem("A", "ALFABETICO")
        Cmb_RefDepo.AgregarItem("AN", "ALFANUMERICO")
        Cmb_CajasBancarias.Actualizar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Limpiar()
        SegundosDesconexion = 0
        Tbx_NumPlaza.Clear()
        Cmb_DigSeg.SelectedIndex = 0
        Tbx_CR.Clear()
        Cmb_RefDepo.SelectedIndex = 0
        Tbx_LongRefepo.Clear()
        Tbx_TipoArchivo.Clear()
        Tbx_ClaveProvedorA.Clear()

    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click

        SegundosDesconexion = 0
        If Cmb_DigSeg.SelectedIndex = 0 Then
            MsgBox("Indique Digito Seguro", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_DigSeg.Focus()
            Exit Sub
        End If
        If Cmb_RefDepo.SelectedIndex = 0 Then
            MsgBox("Indique la Referencia del Departamento", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_RefDepo.Focus()
            Exit Sub
        End If
        If Tbx_LongRefepo.Text = "" Then
            Tbx_LongRefepo.Text = "10"
        End If

        If Fn_CajasBancarias_Guardar(Cmb_CajasBancarias.SelectedValue, Tbx_NumPlaza.Text, Cmb_DigSeg.SelectedValue, Tbx_CR.Text, Cmb_RefDepo.SelectedValue, Tbx_LongRefepo.Text, Tbx_TipoArchivo.Text, Tbx_ClaveProvedorA.Text) Then
            MsgBox("Los parámetros se guardaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ocurrió un error al intentar guardar lops parámetros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Call Limpiar()
        End If

    End Sub

    Private Sub Cmb_CajasBancarias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_CajasBancarias.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Limpiar()
        Gbx_Datos1.Enabled = False
        Gbx_Datos2.Enabled = False

        If Cmb_CajasBancarias.SelectedIndex = 0 Then
            Exit Sub
        End If

        Dim Dt_Datos As DataTable = Fn_CajasBancarias_Datos(Cmb_CajasBancarias.SelectedValue)

        Tbx_NumPlaza.Text = Dt_Datos.Rows(0)("Numero_Plaza").ToString
        If Dt_Datos.Rows(0)("Digito_Seguro").ToString = "" Then
            Cmb_DigSeg.SelectedIndex = 0
        Else
            Cmb_DigSeg.SelectedValue = Dt_Datos.Rows(0)("Digito_Seguro").ToString
        End If

        Tbx_CR.Text = Dt_Datos.Rows(0)("CR").ToString
        If Dt_Datos.Rows(0)("Tipo_ReferenciaDepo").ToString = "" Then
            Cmb_RefDepo.SelectedIndex = 0
        Else
            Cmb_RefDepo.SelectedValue = Dt_Datos.Rows(0)("Tipo_ReferenciaDepo").ToString
        End If
        Tbx_LongRefepo.Text = Dt_Datos.Rows(0)("Longitud_ReferenciaDepo").ToString
        Tbx_TipoArchivo.Text = Dt_Datos.Rows(0)("Tipo_Archivo").ToString
        Tbx_ClaveProvedorA.Text = Dt_Datos.Rows(0)("Clave_ProveedorArchivo").ToString

        Gbx_Datos1.Enabled = True
        Gbx_Datos2.Enabled = True
        Btn_Guardar.Enabled = True

    End Sub

End Class