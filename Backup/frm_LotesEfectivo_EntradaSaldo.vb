Public Class frm_LotesEfectivo_EntradaSaldo
    Dim dt_denominaciones As DataTable

    Private Sub frm_LotesEfectivo_EntradaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_CajaBancaria.Actualizar()
        cmb_CajaBancariaD.Actualizar()

        cmb_Presentacion.AgregarItem("B", "BILLETE")
        cmb_Presentacion.AgregarItem("M", "MONEDA")

        cmb_Moneda.Actualizar()

        dgv_Denominaciones.RowHeadersVisible = False
        For Each columna As DataGridViewColumn In dgv_Denominaciones.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        Call ActualizarTotal()
    End Sub

    Private Sub ActualizarLista()
        dt_denominaciones = Cn_Proceso.fn_EnviarEfectivo_LlenarGridviewProceso(cmb_CajaBancaria.SelectedValue, cmb_Presentacion.SelectedValue, cmb_Moneda.SelectedValue)
        dgv_Denominaciones.DataSource = dt_denominaciones
        Call ColoreaColumnas_dgv()
    End Sub

    Private Sub ColoreaColumnas_dgv()
        For Each Fila As DataGridViewRow In dgv_Denominaciones.Rows
            Fila.Cells(4).Style.BackColor = Color.LightGreen
            Fila.Cells(6).Style.BackColor = Color.LightGreen
            Fila.Cells(8).Style.BackColor = Color.LightGreen
            Fila.Cells(10).Style.BackColor = Color.LightGreen
            Fila.Cells(12).Style.BackColor = Color.LightGreen
            Fila.Cells(14).Style.BackColor = Color.LightGreen
        Next
    End Sub

    Private Sub ActualizarTotal()
        Dim Total As Decimal = 0

        For Each Importe As DataGridViewRow In dgv_Denominaciones.Rows
            Total += CDec(Importe.Cells(15).Value)
        Next

        tbx_Total.Text = Format(Total, "c")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Function ValidarCampos() As Boolean
        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If
        If cmb_CajaBancariaD.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Caja Bancaria de Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancariaD.Focus()
            Return False
        End If
        If cmb_Moneda.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If
        If cmb_Presentacion.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Presentación.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Presentacion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        If cmb_CajaBancariaD.Items.Count > 0 Then
            cmb_CajaBancariaD.SelectedValue = cmb_CajaBancaria.SelectedValue

            If dt_denominaciones IsNot Nothing Then
                dt_denominaciones.Rows.Clear()
                dgv_Denominaciones.DataSource = dt_denominaciones
            End If

        End If
    End Sub

    Private Sub cmb_Moneda_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedValueChanged
        If cmb_Moneda.SelectedValue Is Nothing Then Exit Sub

        If dt_denominaciones IsNot Nothing Then
            dt_denominaciones.Rows.Clear()
            dgv_Denominaciones.DataSource = dt_denominaciones
        End If
    End Sub

    Private Sub cmb_Presentacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Presentacion.SelectedValueChanged
        If cmb_Presentacion.SelectedValue Is Nothing Then Exit Sub

        If dt_denominaciones IsNot Nothing Then
            dt_denominaciones.Rows.Clear()
            dgv_Denominaciones.DataSource = dt_denominaciones
        End If
    End Sub

    Private Sub dgv_Denominaciones_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_Denominaciones.ColumnHeaderMouseClick
        SegundosDesconexion = 0
        Call ColoreaColumnas_dgv()
    End Sub

    Private Sub dgv_Denominaciones_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Denominaciones.CellEndEdit
        Dim Valores() As Integer = {4, 6, 8, 10, 12, 14}

        If Array.IndexOf(Valores, e.ColumnIndex) >= 0 Then
            If Not IsNumeric(dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
            Call ActualizarImporte(e.RowIndex)
            Call ActualizarTotal()
        End If
    End Sub

    Private Sub ActualizarImporte(ByVal Row As Integer)
        Dim Valor As Decimal = 0
        Valor += CDec(dgv_Denominaciones.Rows(Row).Cells(1).Value) * CDec(dgv_Denominaciones.Rows(Row).Cells("Cantidad").Value)
        Valor += CDec(dgv_Denominaciones.Rows(Row).Cells(1).Value) * CDec(dgv_Denominaciones.Rows(Row).Cells(6).Value)
        Valor += CDec(dgv_Denominaciones.Rows(Row).Cells(1).Value) * CDec(dgv_Denominaciones.Rows(Row).Cells(8).Value)
        Valor += CDec(dgv_Denominaciones.Rows(Row).Cells(1).Value) * CDec(dgv_Denominaciones.Rows(Row).Cells(10).Value)
        Valor += CDec(dgv_Denominaciones.Rows(Row).Cells(1).Value) * CDec(dgv_Denominaciones.Rows(Row).Cells(12).Value)
        Valor += CDec(dgv_Denominaciones.Rows(Row).Cells(1).Value) * CDec(dgv_Denominaciones.Rows(Row).Cells(14).Value)
        dgv_Denominaciones.Rows(Row).Cells(15).Value = Valor
    End Sub

    Private Sub dgv_Denominaciones_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Denominaciones.DataError
        MsgBox("Dato No válido, Capture un  número.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub btn_RecibirSaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RecibirSaldo.Click
        SegundosDesconexion = 0

        If Not ValidarCampos() Then Exit Sub
        If CDec(tbx_Total.Text) <= 0 Then
            MsgBox("El Importe para recibir debe ser mayor que cero.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim frm As New frm_Dialogo2014
        frm.Tipo = frm_Dialogo2014.TipoR.Entrada_Efectivo 'tipo 5
        frm.ImporteTotal = tbx_Total.Text
        frm.IdCajaBancaria = cmb_CajaBancaria.SelectedValue '-->
        frm.IdCajaBancariaD = cmb_CajaBancariaD.SelectedValue '-->
        frm.Tipo_Lote = 28 'Otros a Proceso
        frm.Id_Moneda = cmb_Moneda.SelectedValue

        frm.lbl_NombreCompañia.Text = "OTROS  - " & cmb_CajaBancaria.Text
        frm.Nombre_Origen = "DPTO. PROCESO - " & cmb_CajaBancaria.Text
        frm.Denominaciones = dgv_Denominaciones.DataSource

        'Consultar la Clave y el Domicilio del Origen
        Dim dt As DataTable = Cn_Proceso.fn_ConsultaDatosOrigen(SucursalId)
        If dt.Rows.Count > 0 Then
            frm.Domicilio_Origen = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
            frm.Domicilio_Destino = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
        End If
        frm.ShowDialog()
        cmb_Moneda.SelectedValue = 0
    End Sub

    Private Sub btn_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mostrar.Click
        SegundosDesconexion = 0
        If Not ValidarCampos() Then Exit Sub
        Call ActualizarLista()
        Call ActualizarTotal()
    End Sub
End Class