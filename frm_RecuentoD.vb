Imports CrystalDecisions.CrystalReports.Engine

Public Class frm_RecuentoD

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_RecuentoD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Casets.Columns.Add("N° Caset", 100)
        lsv_Casets.Columns.Add("Fecha", 100)
        lsv_Casets.Columns.Add("Hora", 100)
        lsv_Casets.Columns.Add("Envases", 100)
        lsv_Casets.Columns.Add("Importe", 100)
        lsv_Casets.Columns.Add("Ruta", 100)
        lsv_Casets.Columns.Add("Unidad", 100)

        lsv_Clientes.Columns.Add("Cliente", 100)
        lsv_Clientes.Columns.Add("Efectivo", 100)
        lsv_Clientes.Columns.Add("Despensa", 100)
        lsv_Clientes.Columns.Add("Loteria", 100)
        lsv_Clientes.Columns.Add("Morralla", 100)
        lsv_Clientes.Columns.Add("Otros", 100)
        lsv_Clientes.Columns.Add("Envases", 100)

        lsv_Envases.Columns.Add("Tipo Envase", 100)
        lsv_Envases.Columns.Add("Numero", 100)

        lsv_Deglose.Columns.Add("Moneda", 100)
        lsv_Deglose.Columns.Add("Denominacion", 100)
        lsv_Deglose.Columns.Add("Cantidad", 100)
        lsv_Deglose.Columns.Add("Importe", 100)

        dtp_Fecha.Value = Today.Date

    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        SegundosDesconexion = 0
        Call LimpiarListas()

        If Not Cn_Proceso.fn_RecuentoCasetsLlenaLista(lsv_Casets, dtp_Fecha.Value.Date) Then
            MsgBox("Ocurrio un error al Llenar la Lista de los Casets.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Lbl_Registros.Text = "Registros: " & lsv_Casets.Items.Count

    End Sub

    Private Sub lsv_Casets_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Casets.SelectedIndexChanged
        SegundosDesconexion = 0
        If lsv_Casets.SelectedItems.Count = 0 Then
            lsv_Clientes.Items.Clear()
            lsv_Envases.Items.Clear()
            lsv_Deglose.Items.Clear()
            lbl_RegistrosClientes.Text = "Registros: 0"
            Exit Sub
        End If
        
        lsv_Clientes.Items.Clear()
        lsv_Envases.Items.Clear()
        lsv_Deglose.Items.Clear()
        lbl_RegistrosClientes.Text = "Registros: 0"
        If Not Cn_Proceso.fn_RecuentoClientesCasetLlenaLista(lsv_Clientes, CLng(lsv_Casets.SelectedItems(0).SubItems(0).Text)) Then
            MsgBox("Ocurrio un error al Llenar la Lista de los Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_RegistrosClientes.Text = "Registros: " & lsv_Clientes.Items.Count
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        SegundosDesconexion = 0
        If lsv_Clientes.SelectedItems.Count = 0 Then
            lsv_Envases.Items.Clear()
            lsv_Deglose.Items.Clear()
            Exit Sub
        End If

        lsv_Envases.Items.Clear()
        lsv_Deglose.Items.Clear()

        If Not Cn_Proceso.fn_RecuentoEnvasesClienteLlenaLista(lsv_Envases, CInt(lsv_Clientes.SelectedItems(0).Tag)) Then
            MsgBox("Ocurrio un error al Llenar la Lista de los Envases del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not Cn_Proceso.fn_RecuentoDesgloseClienteLlenaLista(lsv_Deglose, CInt(lsv_Clientes.SelectedItems(0).Tag)) Then
            MsgBox("Ocurrio un error al Llenar la Lista del Desglose del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0
        lsv_Casets.Items.Clear()
        lsv_Clientes.Items.Clear()
        lsv_Envases.Items.Clear()
        lsv_Deglose.Items.Clear()
        Lbl_Registros.Text = "Registros: " & lsv_Casets.Items.Count
        lbl_RegistrosClientes.Text = "Registros: " & lsv_Clientes.Items.Count
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0
        If lsv_Casets.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim frm As New frm_Reporte
        Dim rpt As New rpt_ClientesRecuento
        Dim ds As New ds_Reportes

        If Not Cn_Proceso.fn_VerReportes_LlenarLogo(ds.Tbl_DatosEmpresa) Then
            MsgBox("No se pudo Imprimir el Encabezado del Reporte", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not Cn_Proceso.fn_ReporteRecuentoDesglosexCliente(ds.Tbl_RecuentoDesglose, CLng(lsv_Casets.SelectedItems(0).SubItems(0).Text)) Then
            MsgBox("Ocurrio un error al cargar los datos del desglose.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        CType(rpt.Section2.ReportObjects("txt_NumeroCaset"), TextObject).Text = lsv_Casets.SelectedItems(0).SubItems(0).Text
        CType(rpt.Section2.ReportObjects("txt_Fecha"), TextObject).Text = lsv_Casets.SelectedItems(0).SubItems(1).Text
        CType(rpt.Section2.ReportObjects("txt_Ruta"), TextObject).Text = lsv_Casets.SelectedItems(0).SubItems(5).Text
        CType(rpt.Section2.ReportObjects("txt_Unidad"), TextObject).Text = lsv_Casets.SelectedItems(0).SubItems(6).Text

        rpt.SetDataSource(ds)
        frm.crv.ReportSource = rpt
        frm.ShowDialog()

    End Sub

End Class