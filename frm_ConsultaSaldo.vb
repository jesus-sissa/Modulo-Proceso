Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ConsultaSaldo

    Private Sub frm_ConsultaSaldo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_CajaBancaria.Actualizar()
        cmb_Moneda.Actualizar()
        cmb_Presentacion.AgregarItem("B", "BILLETES")
        cmb_Presentacion.AgregarItem("M", "MONEDAS")
        cmb_Presentacion.AgregarItem("T", "TODAS")

        'cargar las columnas de las listas
        lsv_Catalogo.Columns.Add("Presentacion")
        lsv_Catalogo.Columns.Add("Denominacion")
        lsv_Catalogo.Columns.Add("SaldoSC")
        lsv_Catalogo.Columns.Add("SaldoA")
        lsv_Catalogo.Columns.Add("SaldoB")
        lsv_Catalogo.Columns.Add("SaldoC")
        lsv_Catalogo.Columns.Add("SaldoD")
        lsv_Catalogo.Columns.Add("SaldoE")
        lsv_Catalogo.Columns.Add("Importe")


        lsv_Mazos.Columns.Add("Presentacion")
        lsv_Mazos.Columns.Add("Denominacion")
        lsv_Mazos.Columns.Add("Saldo")
        lsv_Mazos.Columns.Add("Mazos")
        lsv_Mazos.Columns.Add("Fajillas")
        lsv_Mazos.Columns.Add("Bolsas")
        lsv_Mazos.Columns.Add("Picos")
        lsv_Mazos.Columns.Add("Importe")

    End Sub

    Public Sub ActualizarConsulta() Handles cmb_CajaBancaria.SelectedValueChanged, cmb_Moneda.SelectedValueChanged, cmb_Presentacion.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lsv_Mazos.Items.Clear()
        If cmb_CajaBancaria.SelectedIndex <= 0 Or cmb_Moneda.SelectedIndex <= 0 Or cmb_Presentacion.SelectedIndex <= 0 Then Exit Sub
        tbx_Total.Text = Format(fn_ConsultaSaldo_LlenarLista(lsv_Catalogo, cmb_CajaBancaria.SelectedValue, cmb_Presentacion.SelectedValue, cmb_Moneda.SelectedValue), "n2")
        fn_ConsultaSaldo_LlenarMazos(lsv_Mazos, cmb_CajaBancaria.SelectedValue, cmb_Presentacion.SelectedValue, cmb_Moneda.SelectedValue)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Mazos.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover, lsv_Mazos.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Catalogo.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_Presentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Presentacion.SelectedIndexChanged
        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Catalogo.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub
End Class