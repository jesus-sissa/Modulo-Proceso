Public Class frm_PrepararResguardo
    Public dt_Resguardos As DataTable
    Private Total As Decimal = 0.0

    Private Sub frm_PrepararResguardo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_CajaBancaria.Actualizar()

        cmb_Moneda.Actualizar()

        dt_Resguardos = Cn_Proceso.fn_PrepararResguardoConsulta(0, 0)
        Dg_Resguardos.DataSource = dt_Resguardos

        Dg_Resguardos.Name = "Dg_Resguardos"

        BanderA = True

        'quita el ordenado de columnas al dgv
        Dg_Resguardos.RowHeadersVisible = False
        'For Each columna As DataGridViewColumn In Dg_Resguardos.Columns
        '    columna.SortMode = DataGridViewColumnSortMode.NotSortable
        'Next

    End Sub

    Private Sub ColoreaColumnas_dgv()
        For Each Fila As DataGridViewRow In Dg_Resguardos.Rows
            Fila.Cells(4).Style.BackColor = Color.LightGreen
            Fila.Cells(6).Style.BackColor = Color.LightGreen
            Fila.Cells(8).Style.BackColor = Color.LightGreen
            Fila.Cells(10).Style.BackColor = Color.LightGreen
            Fila.Cells(12).Style.BackColor = Color.LightGreen
            Fila.Cells(14).Style.BackColor = Color.LightGreen
        Next
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        SegundosDesconexion = 0

        If BanderA = True Then
            cmb_Moneda.SelectedValue = 0
        End If
    End Sub

    Private Sub Dg_Resguardos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Dg_Resguardos.DataError
        MsgBox("Valor Invalido, Capture un  numero", MsgBoxStyle.Critical)
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        If BanderA = True Then
            Call LlenaGrid()
        End If
    End Sub

    Private Sub LlenaGrid()
        SegundosDesconexion = 0

        If BanderA = True Then
            dt_Resguardos = Cn_Proceso.fn_PrepararResguardoConsulta(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue)
            Dg_Resguardos.DataSource = dt_Resguardos
            Call ColoreaColumnas_dgv()
        End If

    End Sub

    Private Sub Btn_resguardo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Resguardo.Click
        SegundosDesconexion = 0

        If ValidaCampos() = True Then
            If Cn_Proceso.fn_PrepararResguardoValidaResguardo(dt_Resguardos, cmb_CajaBancaria.SelectedValue) = True Then
                Dim frm As New frm_Dialogo2014

                frm.Tipo = 3
                frm.ImporteTotal = Total
                frm.Nombre_Origen = "DEPARTAMENTO BOVEDA (RESGUARDO)"
                frm.Nombre_Destino = "DEPARTAMENTO PROCESO"
                frm.IdCajaBancaria = cmb_CajaBancaria.SelectedValue
                frm.Id_Moneda = cmb_Moneda.SelectedValue
                frm.Denominaciones = Dg_Resguardos.DataSource

                'Consultar la Clave y el Domicilio del Origen
                Dim dt As DataTable = Cn_Proceso.fn_ConsultaDatosOrigen(SucursalId)
                If dt.Rows.Count > 0 Then
                    frm.Domicilio_Origen = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
                    frm.Domicilio_Destino = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
                    'frm.CiaTV = dt.Rows(0)("Nombre") 'Esta CiaTV esta mal porque es la cia propia  siempre
                    'se debe buscar la cia del Cliente Dotado
                    'mas abajo la obtengo en el DataRow
                End If

                frm.ShowDialog()
                cmb_CajaBancaria.SelectedValue = 0

            End If
        Else
            MsgBox("Favor de llenar todos los campos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Function ValidaCampos() As Boolean

        If cmb_CajaBancaria.SelectedValue = 0 Then Return False
        If cmb_Moneda.SelectedValue = 0 Then Return False
        If Total = 0 Then Return False

        Return True

    End Function

    Private Sub Dg_Resguardos_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Resguardos.CellValueChanged
        
        If Dg_Resguardos IsNot Nothing And e.RowIndex >= 0 And Not e.ColumnIndex = 15 AndAlso Not IsDBNull(Dg_Resguardos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then

            If Dg_Resguardos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value > Dg_Resguardos.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value Then
                MsgBox("No existe suficiente saldo para resguardar la cantidad seleccionada")
                Dg_Resguardos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.0
                Exit Sub
            End If

            Dim Cantidad As Decimal = 0
            Cantidad += Dg_Resguardos.Rows(e.RowIndex).Cells("Resguardar").Value
            Cantidad += Dg_Resguardos.Rows(e.RowIndex).Cells("ResguardarA").Value
            Cantidad += Dg_Resguardos.Rows(e.RowIndex).Cells("ResguardarB").Value
            Cantidad += Dg_Resguardos.Rows(e.RowIndex).Cells("ResguardarC").Value
            Cantidad += Dg_Resguardos.Rows(e.RowIndex).Cells("ResguardarD").Value
            Cantidad += Dg_Resguardos.Rows(e.RowIndex).Cells("ResguardarE").Value

            Cantidad = Cantidad * CDec(Dg_Resguardos.Rows(e.RowIndex).Cells("Denominacion").Value)
            Dg_Resguardos.Rows(e.RowIndex).Cells("Importe").Value = Cantidad
            Call CalculaTotal()
        End If
    End Sub

    Private Sub CalculaTotal()
        Dim dr_Total As DataRow

        If dt_Resguardos IsNot Nothing AndAlso dt_Resguardos.Rows.Count > 0 Then
            Dim totalp As Decimal = 0

            For Each dr_Total In dt_Resguardos.Rows
                totalp += (dr_Total("Importe"))
            Next

            Total = totalp

        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Dg_Resguardos_CellValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Resguardos.CellValidated

        If e.ColumnIndex = 4 And Not IsDBNull(Dg_Resguardos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            If Dg_Resguardos.Item(e.ColumnIndex, e.RowIndex).Value < 0 Then
                MsgBox("La cantidad a resguardar no puede ser negativa", MsgBoxStyle.Critical, frm_MENU.Text)
                Dg_Resguardos.Item(e.ColumnIndex, e.RowIndex).Value = 0.0

            End If
        End If

    End Sub

    Private Sub gb1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb1.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub Dg_Resguardos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dg_Resguardos.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub Dg_Resguardos_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dg_Resguardos.ColumnHeaderMouseClick
        Call ColoreaColumnas_dgv()
    End Sub
End Class