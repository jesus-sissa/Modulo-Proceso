Imports Modulo_Proceso.Cn_Proceso

Public Class frm_EfectivoXCliente

    Private Sub frm_EfectivoXCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Listado.Columns.Add("Fecha")
        lsv_Listado.Columns.Add("DiaSemana")
        lsv_Listado.Columns.Add("Dia")
        lsv_Listado.Columns.Add("Clave")
        lsv_Listado.Columns.Add("Cliente")
        lsv_Listado.Columns.Add("Presentacion")
        lsv_Listado.Columns.Add("Piezas")
        lsv_Listado.Columns.Add("Importe")

        cmb_Cliente.AgregaParametro("@Status", "A", 0)
        cmb_Cliente.AgregaParametro("@Padres", "N", 0)
        cmb_Cliente.Actualizar()

        cmb_Presentacion.AgregarItem("B", "BILLETE")
        cmb_Presentacion.AgregarItem("M", "MONEDA")
        cmb_Presentacion.AgregarItem("T", "TODOS")

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor

        If dtp_Desde.Value > dtp_Hasta.Value Then
            MsgBox("Fechas No Validas", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If

        If cmb_Presentacion.SelectedIndex = 0 Then
            MsgBox("Seleccione una Presentacion", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Presentacion.Focus()
            Exit Sub
        End If

        If fn_EfectivoXCliente_Llenarlista(lsv_Listado, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Cliente.SelectedValue, cmb_Presentacion.SelectedValue) = False Then
            MsgBox("Error al Cargar los Registros", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_Registros.Text = "Registros: " & lsv_Listado.Items.Count


        lsv_Listado.Columns(6).TextAlign = HorizontalAlignment.Right
        lsv_Listado.Columns(7).TextAlign = HorizontalAlignment.Right
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Listado, 0, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        lsv_Listado.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub

    Private Sub cmb_Presentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Presentacion.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Limpiar()
    End Sub
End Class