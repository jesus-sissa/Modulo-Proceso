
Imports Modulo_Proceso.Cn_Proceso

Public Class frm_CambiarDenominaciones

    Public Tipo As Integer = 0
    Dim dt_Origen As DataTable
    Dim dt_Destino As DataTable

    Private Sub frm_CambiarDenominaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dt_Origen = fn_CambiarDenominaciones_LlenarDenominaciones(0, 0)
        dt_Destino = fn_CambiarDenominaciones_LlenarDenominaciones(0, 0)
        dgv_CajaBancariaO.DataSource = dt_Origen
        dgv_CajaBancariaD.DataSource = dt_Destino

        cmb_CajaBancariaO.Actualizar()
        cmb_CajaBancariaD.Actualizar()
        cmb_Moneda.Actualizar()
        tbx_ImporteO.Text = 0.0
        tbx_ImporteD.Text = 0.0
        tbx_ImporteActualO.Text = 0.0
        tbx_ImporteActualD.Text = 0.0
        dgv_CajaBancariaD.Enabled = (Tipo = 1)

    End Sub

    Private Sub cmb_Moneda_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_CajaBancariaO.SelectedValue Is Nothing Then Exit Sub
       
        Call LlenarSaldoOrigen()
        Call LlenarSaldoDestino()
    End Sub

    Sub LlenarSaldoOrigen()
        If cmb_CajaBancariaO.SelectedValue = 0 Or cmb_Moneda.SelectedValue = 0 Then
            btn_Guardar.Enabled = False
            tbx_ImporteO.Text = 0.0
            dt_Origen.Rows.Clear()
        Else
            dt_Origen = fn_CambiarDenominaciones_LlenarDenominaciones(cmb_Moneda.SelectedValue, cmb_CajaBancariaO.SelectedValue)
            dgv_CajaBancariaO.DataSource = dt_Origen
            dgv_CajaBancariaO.ClearSelection()
        End If

        tbx_ImporteActualO.Text = Format(TotalMoneda_Origen(), "n")

    End Sub

    Sub LlenarSaldoDestino()

        If cmb_CajaBancariaD.SelectedValue = 0 Or cmb_Moneda.SelectedValue = 0 Then
            btn_Guardar.Enabled = False
            tbx_ImporteD.Text = 0.0
            dt_Destino.Rows.Clear()
        Else
            dt_Destino = fn_CambiarDenominaciones_LlenarDenominaciones(cmb_Moneda.SelectedValue, cmb_CajaBancariaD.SelectedValue)
            dgv_CajaBancariaD.DataSource = dt_Destino
            dgv_CajaBancariaD.ClearSelection()
        End If

        tbx_ImporteActualD.Text = Format(TotalMoneda_Destino(), "n")
    End Sub

    Private Sub cmb_CajaBancariaO_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancariaO.SelectedValueChanged
        SegundosDesconexion = 0
        If cmb_CajaBancariaO.SelectedValue Is Nothing Then Exit Sub
        
        Call LlenarSaldoOrigen()
    End Sub

    Private Sub cmb_CajaBancariaD_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancariaD.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_CajaBancariaD.SelectedValue Is Nothing Then Exit Sub
       
        Call LlenarSaldoDestino()
    End Sub

    Private Sub dgv_CajaBancariaO_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_CajaBancariaO.DataError
        If e.ColumnIndex = 4 Then
            MsgBox("Dato no válido, capture un número entero.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub dgv_CajaBancariaD_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_CajaBancariaD.DataError
        MsgBox("Dato no válido, capture un número entero.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

#Region "Procedimientos Privados"

    Private Function TotalizarO() As Decimal

        Dim Total As Decimal = 0D
        For Each row As DataGridViewRow In dgv_CajaBancariaO.Rows
            If Not IsDBNull(row.Cells("Cambio1").Value) Then Total += row.Cells("Cambio1").Value * row.Cells("Denominacion1").Value
        Next
        Return Total

    End Function

    Private Function TotalMoneda_Origen() As Decimal

        Dim Total As Decimal = 0D
        For Each row As DataGridViewRow In dgv_CajaBancariaO.Rows
            Total += row.Cells("Cantidad1").Value * row.Cells("Denominacion1").Value
        Next
        Return Total

    End Function

    Private Function TotalizarD() As Decimal

        Dim Total As Decimal = 0D
        For Each row As DataGridViewRow In dgv_CajaBancariaD.Rows
            If Not IsDBNull(row.Cells("Cambio2").Value) Then Total += row.Cells("Cambio2").Value * row.Cells("Denominacion2").Value
        Next
        Return Total

    End Function

    Private Function TotalMoneda_Destino() As Decimal

        Dim Total As Decimal = 0D
        For Each row As DataGridViewRow In dgv_CajaBancariaD.Rows
            Total += row.Cells("Cantidad2").Value * row.Cells("Denominacion2").Value
        Next
        Return Total

    End Function

    Sub Limpiar()

        For Each row As DataGridViewRow In dgv_CajaBancariaO.Rows
            row.Cells("Cambio1").Value = DBNull.Value
        Next
        For Each row As DataGridViewRow In dgv_CajaBancariaD.Rows
            row.Cells("Cambio2").Value = DBNull.Value
        Next

        tbx_ImporteO.Text = 0.0
        tbx_ImporteD.Text = 0.0
        tbx_ImporteActualO.Text = 0.0
        tbx_ImporteActualD.Text = 0.0
    End Sub

    Function ValidarDenominaciones()

        For Each DenominacionO As DataGridViewRow In dgv_CajaBancariaO.Rows
            For Each DenominacionD As DataGridViewRow In dgv_CajaBancariaD.Rows

                If DenominacionO.Cells("Presentacion1").Value = DenominacionD.Cells("Presentacion2").Value And DenominacionO.Cells("Denominacion1").Value = DenominacionD.Cells("Denominacion2").Value Then
                    ' Si la Presentación y la Denominación de la Caja Bancaria Origen y la Caja Bancaria Destino 
                    If IsNumeric(DenominacionO.Cells("Cambio1").Value) AndAlso DenominacionO.Cells("Cambio1").Value > 0 AndAlso IsNumeric(DenominacionD.Cells("Cambio2").Value) AndAlso DenominacionD.Cells("Cambio2").Value > 0 Then
                        ' Si se capturó alguna cantidad mayor que cero en la columna "Cambio" en ambas Cajas Bancarias
                        dgv_CajaBancariaO.ClearSelection()
                        dgv_CajaBancariaD.ClearSelection()
                        DenominacionO.Cells("Cambio1").Selected = True
                        DenominacionD.Cells("Cambio2").Selected = True

                        MsgBox("Ha seleccionado la Denominacion " & Val(DenominacionO.Cells("Denominacion1").Value) & " en ambas Cajas Bancarias y esto no está permitido.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Return False
                    End If
                End If
            Next
        Next
        Return True

    End Function

#End Region

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If Tipo = 1 Then 'Cambio denominaciones entre 2 cajas o en la misma caja
            If tbx_ImporteO.Text.Trim <> tbx_ImporteD.Text.Trim Then
                MsgBox("Los Importes a Cambiar deben ser iguales.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If Not ValidarDenominaciones() Then
                Exit Sub
            End If
        Else 'Transferencia de saldo
            If cmb_CajaBancariaD.SelectedValue = 0 Then
                MsgBox("Seleccione la Caja Bancaria Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_CajaBancariaD.Focus()
                Exit Sub
            End If
        End If
            
        'Aquí se hace el cambio denominaciones misma CB 01/09/2015
        If cmb_CajaBancariaO.SelectedValue = cmb_CajaBancariaD.SelectedValue Then
            If fn_CambiarDenominacionesMismaCB_Guardar(cmb_CajaBancariaO.SelectedValue, cmb_CajaBancariaD.SelectedValue, cmb_Moneda.SelectedValue, tbx_ImporteO.Text.Trim, dgv_CajaBancariaO.DataSource, dgv_CajaBancariaD.DataSource, 3) Then
                MsgBox("El Cambio de Denominaciones se ha generado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call Limpiar()
                Call LlenarSaldoOrigen()
                Call LlenarSaldoDestino()
            Else
                MsgBox("Ha ocurrido un error al intentar generar el Cambio de Denominaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else

            If fn_CambiarDenominaciones_Guardar(cmb_CajaBancariaO.SelectedValue, cmb_CajaBancariaD.SelectedValue, cmb_Moneda.SelectedValue, tbx_ImporteO.Text, dgv_CajaBancariaO.DataSource, dgv_CajaBancariaD.DataSource, Tipo) Then
                MsgBox("El Cambio de Denominaciones se ha generado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call Limpiar()
                Call LlenarSaldoOrigen()
                Call LlenarSaldoDestino()
            Else
                MsgBox("Ha ocurrido un error al intentar generar el Cambio de Denominaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub tbx_ImporteD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_ImporteD.TextChanged
        If Tipo = 1 Then btn_Guardar.Enabled = tbx_ImporteO.Text > 0 And tbx_ImporteD.Text > 0
    End Sub

    Private Sub tbx_ImporteO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_ImporteO.TextChanged
        If tbx_ImporteD.Text = "" Then Exit Sub
        If Tipo = 1 Then btn_Guardar.Enabled = tbx_ImporteO.Text > 0 And tbx_ImporteD.Text > 0 Else btn_Guardar.Enabled = tbx_ImporteO.Text > 0
    End Sub

    Private Sub dgv_CajaBancariaO_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv_CajaBancariaO.CellValidating

        If e.ColumnIndex = 4 And IsNumeric(e.FormattedValue) Then
            ' Si la celda que se está editando corresponde a la columna 4 ("Cambio") y el valor capturado es numerico

            If CInt(e.FormattedValue) > CInt(dgv_CajaBancariaO.Rows(e.RowIndex).Cells("Cantidad1").Value) Then
                ' Si la cantidad capturada es mayor a la Cantidad de Saldo

                MsgBox("Cantidad insuficiente.", MsgBoxStyle.Critical, frm_MENU.Text)
                e.Cancel = True     'Impide quitar el foco de la celda que se está editando si no cumple con la validación
                Exit Sub

            End If

        End If

    End Sub

    Private Sub dgv_CajaBancariaO_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_CajaBancariaO.CellValidated
        ' Una vez que la cantidad capturada ha pasado la validación, se actualiza el valor del Importe
        If cmb_CajaBancariaO.SelectedValue = 0 Then Exit Sub
        tbx_ImporteO.Text = Format(TotalizarO(), "n")
    End Sub

    Private Sub dgv_CajaBancariaD_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv_CajaBancariaD.CellValidating
        If e.ColumnIndex = 4 And IsNumeric(e.FormattedValue) Then
            ' Si la celda que se está editando corresponde a la columna 4 ("Cambio") y el valor capturado es numerico

            If CInt(e.FormattedValue) > CInt(dgv_CajaBancariaD.Rows(e.RowIndex).Cells("Cantidad2").Value) Then
                ' Si la cantidad capturada es mayor a la Cantidad de Saldo

                MsgBox("Cantidad insuficiente.", MsgBoxStyle.Critical, frm_MENU.Text)
                e.Cancel = True     'Impide quitar el foco de la celda que se está editando si no cumple con la validación
                Exit Sub

            End If

        End If
    End Sub

    Private Sub dgv_CajaBancariaD_CellValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_CajaBancariaD.CellValidated
        ' Una vez que la cantidad capturada ha pasado la validación, se actualiza el valor del Importe
        tbx_ImporteD.Text = Format(TotalizarD(), "n")
    End Sub

    Private Sub frm_CambiarDenominaciones_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        gbx_Origen.Width = (Me.Width / 2) - 10
        gbx_Destino.Width = (Me.Width / 2) - 10
        gbx_Destino.Left = gbx_Origen.Left + gbx_Origen.Width + 5
        'If Me.Width = 838 Then
        '    gbx_Destino.Location = New Point(419, 12)
        'Else
        '    gbx_Destino.Location = New Point(640, 12)
        'End If

    End Sub

    Private Sub dgv_CajaBancariaO_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_CajaBancariaO.MouseHover, dgv_CajaBancariaD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_CajaBancariaO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancariaO.SelectedIndexChanged
        If Tipo = 2 Then
            'Cuando sea una Transferencia de saldo no me debe dejar seleccionar la misma Caja Bancaria
            If cmb_CajaBancariaO.SelectedValue = cmb_CajaBancariaD.SelectedValue And Not cmb_CajaBancariaO.SelectedValue = 0 Then
                MsgBox("La Caja Bancaria Origen debe ser diferente a la Caja Bancaria Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_CajaBancariaO.SelectedValue = 0
                cmb_CajaBancariaO.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmb_CajaBancariaD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancariaD.SelectedIndexChanged
        If Tipo = 2 Then
            'Cuando sea una Transferencia de saldo no me debe dejar seleccionar la misma Caja Bancaria
            If cmb_CajaBancariaD.SelectedValue = cmb_CajaBancariaO.SelectedValue And Not cmb_CajaBancariaD.SelectedValue = 0 Then
                MsgBox("La Caja Bancaria Destino debe ser diferente a la Caja Bancaria Origen.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_CajaBancariaD.SelectedValue = 0
                cmb_CajaBancariaD.Focus()
                Exit Sub
            End If
        End If
    End Sub

End Class