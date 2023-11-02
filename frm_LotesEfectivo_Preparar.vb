Imports Modulo_Proceso.Cn_Proceso

Public Class frm_LotesEfectivo_Preparar
    Dim dt_denominaciones As DataTable

    Private Sub frm_LotesEfectivo_Preparar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_CajaBancaria.Actualizar()
        cmb_CajaBancariaD.Actualizar()

        cmb_Presentacion.AgregarItem("B", "BILLETE")
        cmb_Presentacion.AgregarItem("M", "MONEDA")

        cmb_CSRemision.AgregarItem("CR", "CON REMISION")
        cmb_CSRemision.AgregarItem("SR", "SIN REMISION")

        '--------17/05/2014
        cmb_Destino.AgregarItem("1", "MORRALLA")
        cmb_Destino.AgregarItem("2", "CAJEROS")
        cmb_Destino.AgregarItem("3", "CLASIFICADO")
        cmb_Destino.AgregarItem("4", "NOMINAS")
        cmb_Destino.AgregarItem("15", "CAJA GENERAL")
        cmb_Destino.AgregarItem("25", "OTROS")

        Me.Text = "Prepara Envio Efectivo desde Proceso"
        '---------------------
        cmb_Moneda.Actualizar()
        tbx_Total.Text = Format(0, "c")
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

    Private Sub ActualizarLista()

        dt_denominaciones = fn_EnviarEfectivo_LlenarGridviewProceso(cmb_CajaBancaria.SelectedValue, cmb_Presentacion.SelectedValue, cmb_Moneda.SelectedValue)
        dgv_Denominaciones.DataSource = dt_denominaciones
        Call ColoreaColumnas_dgv()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged

        If cmb_CajaBancariaD.Items.Count > 0 Then
            cmb_CajaBancariaD.SelectedValue = cmb_CajaBancaria.SelectedValue

            If dt_denominaciones IsNot Nothing Then
                dt_denominaciones.Rows.Clear()
                dgv_Denominaciones.DataSource = dt_denominaciones
            End If

        End If
    End Sub

    Private Sub cmb_Presentacion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Presentacion.SelectedValueChanged
        If cmb_Presentacion.SelectedValue Is Nothing Then Exit Sub

        If dt_denominaciones IsNot Nothing Then
            dt_denominaciones.Rows.Clear()
            dgv_Denominaciones.DataSource = dt_denominaciones
        End If
    End Sub

    Private Sub cmb_Moneda_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedValueChanged
        If cmb_Moneda.SelectedValue Is Nothing Then Exit Sub

        If dt_denominaciones IsNot Nothing Then
            dt_denominaciones.Rows.Clear()
            dgv_Denominaciones.DataSource = dt_denominaciones
        End If
    End Sub

    Private Sub dgv_Denominaciones_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Denominaciones.CellEndEdit
        Dim CantidadStr As String = ""
        If Not IsNumeric(dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
            Exit Sub
        End If
        If dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value < 0 Then
            MsgBox("La cantidad a enviar no puede ser negativa.", MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
        End If
        CantidadStr = "(" & dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & " Piezas)"
        If dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value > dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value Then
            MsgBox("No existe suficiente saldo para enviar la cantidad capturada. " & vbCr & CantidadStr, MsgBoxStyle.Critical, frm_MENU.Text)
            dgv_Denominaciones.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
        End If
        Call ActualizarImporte(e.RowIndex)
        Call ActualizarTotal()
    End Sub

    Private Sub ActualizarImporte(ByVal Row As Integer)
        Dim Cantidades() As String = {"Cantidad", "Cantidad1", "Cantidad2", "Cantidad3", "Cantidad4", "Cantidad5"}
        Dim CantidadTipos As Integer = 0
        Dim Importe As Decimal = 0.0
        For i As Integer = 0 To Cantidades.Length - 1
            CantidadTipos += CInt(dgv_Denominaciones.Rows(Row).Cells(Cantidades(i)).Value)
        Next
        Importe = CDec(dgv_Denominaciones.Rows(Row).Cells("Denominacion").Value) * CantidadTipos
        dgv_Denominaciones.Rows(Row).Cells("Importe").Value = Importe
    End Sub

    Private Sub ActualizarTotal()
        Dim Total As Decimal = 0
        For Each Importe As DataGridViewRow In dgv_Denominaciones.Rows
            Total += CDec(Importe.Cells("Importe").Value)
        Next
        tbx_Total.Text = Format(Total, "c")
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
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
        If cmb_Destino.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Destino.Focus()
            Return False
        End If
        If cmb_CSRemision.SelectedValue = "0" Then
            MsgBox("Debe Seleccionar si es con Remision o No.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Destino.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If Not ValidarCampos() Then Exit Sub
        If CDec(tbx_Total.Text) <= 0 Then
            MsgBox("El Importe para enviar debe ser mayor de cero.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_CSRemision.SelectedValue = "CR" Then 'CON REMISION
            Dim frm As New frm_Dialogo2014
            frm.Tipo = frm_Dialogo2014.TipoR.Envio_Efectivo
            frm.ImporteTotal = tbx_Total.Text
            frm.IdCajaBancaria = cmb_CajaBancaria.SelectedValue
            frm.IdCajaBancariaD = cmb_CajaBancariaD.SelectedValue
            frm.Tipo_Lote = cmb_Destino.SelectedValue
            frm.Id_Moneda = cmb_Moneda.SelectedValue
            frm.lbl_NombreCompañia.Text = "DPTO. PROCESO - " & cmb_CajaBancaria.Text
            frm.Nombre_Origen = "DPTO. " & cmb_Destino.Text & " - " & cmb_CajaBancariaD.Text 'Data Reader
            frm.Denominaciones = dgv_Denominaciones.DataSource

            'Consultar la Clave y el Domicilio del Origen
            Dim dt As DataTable = Cn_Proceso.fn_ConsultaDatosOrigen(SucursalId)
            If dt.Rows.Count > 0 Then
                frm.Domicilio_Origen = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
                frm.Domicilio_Destino = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
            End If
            frm.ShowDialog()
            cmb_Moneda.SelectedValue = 0

        ElseIf cmb_CSRemision.SelectedValue = "SR" Then 'SIN REMISION

            If Cn_Proceso.Fn_LoteEfectivo_CreateSR(cmb_Destino.SelectedValue, cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue, _
                                                       dgv_Denominaciones.DataSource, cmb_CajaBancariaD.SelectedValue, CDec(tbx_Total.Text.Trim)) Then
                MsgBox("El lote se guardó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                cmb_Moneda.SelectedValue = 0
            Else
                MsgBox("Ocurrió un Error al intentar Guardar el Registro.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If

        End If

        If dt_denominaciones IsNot Nothing Then
            dt_denominaciones.Rows.Clear()
            dgv_Denominaciones.DataSource = dt_denominaciones
        End If
        tbx_Total.Clear()
        tbx_Total.Text = Format(0, "c")
    End Sub

    Private Sub cmb_Destino_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Destino.SelectedValueChanged

        Select Case cmb_Destino.SelectedValue

            Case "3", "0"
                'CLASIFICADO
                cmb_CSRemision.Enabled = True
                cmb_CSRemision.SelectedValue = "0"
            Case Else
                cmb_CSRemision.SelectedValue = "CR"
                cmb_CSRemision.Enabled = False
        End Select
    End Sub

    Private Sub dgv_Denominaciones_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_Denominaciones.DataError
        MsgBox("Dato No válido, Capture un  número.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub dgv_Denominaciones_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_Denominaciones.ColumnHeaderMouseClick
        Call ColoreaColumnas_dgv()
    End Sub

    Private Sub btn_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mostrar.Click
        SegundosDesconexion = 0
        If Not ValidarCampos() Then Exit Sub
        Call ActualizarLista()
        Call ActualizarTotal()
    End Sub
End Class