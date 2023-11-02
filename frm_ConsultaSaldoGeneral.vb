Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ConsultaSaldoGeneral

    Private Sub frm_ConsultaSaldo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_CajaBancaria.Actualizar()
        cmb_Moneda.Actualizar()
        cmb_Presentacion.AgregarItem("B", "BILLETES")
        cmb_Presentacion.AgregarItem("M", "MONEDAS")
        cmb_Presentacion.AgregarItem("T", "TODAS")


    End Sub

    Public Sub ActualizarConsulta() Handles cmb_CajaBancaria.SelectedValueChanged, cmb_Moneda.SelectedValueChanged, cmb_Presentacion.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Mazos.Items.Clear()
        If cmb_CajaBancaria.SelectedValue = 0 Then Exit Sub
        If cmb_Moneda.SelectedValue = 0 Then Exit Sub
        If cmb_Presentacion.SelectedValue = "0" Then Exit Sub
        tbx_Total.Text = Format(fn_ConsultaSaldoGeneral_LlenarLista(lsv_Catalogo, cmb_CajaBancaria.SelectedValue, cmb_Presentacion.SelectedValue, cmb_Moneda.SelectedValue), "n2")
        fn_ConsultaSaldoGeneral_LlenarMazos(lsv_Mazos, cmb_CajaBancaria.SelectedValue, cmb_Presentacion.SelectedValue, cmb_Moneda.SelectedValue)
        FuncionesGlobales.RagistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
        FuncionesGlobales.RagistrosNum(Lbl_Registros2, lsv_Mazos.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover, lsv_Mazos.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class