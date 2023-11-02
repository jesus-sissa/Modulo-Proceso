
Imports Modulo_Proceso.Cn_Proceso

Public Class frm_DotacionesCapturar

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_PrepararDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmb_TipoDotacion.AgregarItem("1", "DOTACION CLIENTE")
        cmb_TipoDotacion.AgregarItem("2", "DOTACION A SUCURSAL BANCARIA")
        cmb_TipoDotacion.AgregarItem("3", "ENVIO A UNA CAJA PRINCIPAL")
        cmb_TipoDotacion.AgregarItem("4", "DEPOSITO BANXICO")
        cmb_TipoDotacion.AgregarItem("5", "VENTA DE MORRALLA")

        cmb_CajaBancaria.Actualizar()
        cmb_Moneda.Actualizar()
        cmb_Cia.Actualizar()
        ActualizarClientes()
        cmb_Documentos.AgregarItem("S", "Sí")
        cmb_Documentos.AgregarItem("N", "No")
        cmb_Documentos.SelectedValue = "N"

        cmb_Tipos.AgregarItem("S", "Sí")
        cmb_Tipos.AgregarItem("N", "No")
        cmb_Tipos.SelectedValue = "N"

        cmb_Nomina.AgregarItem("S", "Sí")
        cmb_Nomina.AgregarItem("N", "No")
        cmb_Nomina.SelectedValue = "N"

        dgv_Billetes.DataSource = fn_PrepararDotaciones_LlenarDenominaciones(cmb_Moneda.SelectedValue, "B")
        dgv_Monedas.DataSource = fn_PrepararDotaciones_LlenarDenominaciones(cmb_Moneda.SelectedValue, "M")
        Cmb_Servicio.Actualizar(fn_cmbServicio(0))
    End Sub

    Private Sub ActualizarClientes(Optional ByVal sender As Object = Nothing, Optional ByVal e As System.EventArgs = Nothing) Handles cmb_Cia.SelectedValueChanged, cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0

        cmb_Cliente.Actualizar(fn_PrepararDotaciones_LlenarClientes(cmb_CajaBancaria.SelectedValue, cmb_Cia.SelectedValue))
        'Le quite la caja bancaria porque se debe poder dotar clientes de una caja con saldo de la otra
        'If cmb_Cia.SelectedValue = Nothing Then Exit Sub
        'cmb_Cliente.Actualizar(fn_PrepararDotaciones_LlenarClientes(cmb_Cia.SelectedValue))
    End Sub

    Private Sub cmb_Moneda_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedValueChanged
        SegundosDesconexion = 0

        dgv_Billetes.DataSource = fn_PrepararDotaciones_LlenarDenominaciones(cmb_Moneda.SelectedValue, "B")
        dgv_Monedas.DataSource = fn_PrepararDotaciones_LlenarDenominaciones(cmb_Moneda.SelectedValue, "M")
    End Sub

    Private Sub dgv_Billetes_CellValueChanged(ByVal sender As DataGridView, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Billetes.CellValueChanged, dgv_Monedas.CellValueChanged
        Dim Total As Decimal = 0
        If e.RowIndex < 0 Then Exit Sub
        If sender.Columns(e.ColumnIndex).Name.IndexOf("CantidadB") >= 0 Then
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells("CantidadB").Value) Then Total += sender.Rows(e.RowIndex).Cells("CantidadB").Value
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells("CantidadB_A").Value) Then Total += sender.Rows(e.RowIndex).Cells("CantidadB_A").Value
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells("CantidadB_B").Value) Then Total += sender.Rows(e.RowIndex).Cells("CantidadB_B").Value
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells("CantidadB_C").Value) Then Total += sender.Rows(e.RowIndex).Cells("CantidadB_C").Value
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells("CantidadB_D").Value) Then Total += sender.Rows(e.RowIndex).Cells("CantidadB_D").Value
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells("CantidadB_E").Value) Then Total += sender.Rows(e.RowIndex).Cells("CantidadB_E").Value
            sender.Rows(e.RowIndex).Cells("ImporteB").Value = sender.Rows(e.RowIndex).Cells("DenominacionB").Value * Total
        ElseIf sender.Columns(e.ColumnIndex).Name.IndexOf("CantidadM") >= 0 Then
            If Not IsDBNull(sender.Rows(e.RowIndex).Cells("CantidadM").Value) Then sender.Rows(e.RowIndex).Cells("ImporteM").Value = sender.Rows(e.RowIndex).Cells("DenominacionM").Value * sender.Rows(e.RowIndex).Cells("CantidadM").Value
        End If

        If cmb_Nomina.SelectedValue = "S" Then
            tbx_ImpNom.Text = Format(Totalizar(), "n")
        Else
            tbx_Importe.Text = Format(Totalizar(), "n")
        End If

    End Sub

    Private Sub cmb_Documentos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Documentos.SelectedValueChanged

        cmb_Tipos.Enabled = Not cmb_Documentos.SelectedValue = "S"
        tbx_ImpDoc.Enabled = cmb_Documentos.SelectedValue = "S"

        If cmb_Documentos.SelectedValue = "N" Then tbx_ImpDoc.Clear()
        If cmb_Documentos.SelectedValue = "S" Then tbx_ImpNom.Clear()


        cmb_Nomina.Enabled = cmb_Documentos.SelectedValue = "N"

        If cmb_Nomina.Enabled = False Then
            cmb_Nomina.SelectedValue = "0"
            cmb_Nomina.SelectedValue = "N"
            tbx_Sobres.Text = 0
        End If

        If cmb_Nomina.Enabled = False Then tbx_Sobres.Text = 0
        Call LimpiarGrid()
    End Sub

    Sub LimpiarGrid()
        For Each row As DataGridViewRow In dgv_Billetes.Rows
            row.Cells("CantidadB").Value = DBNull.Value
            row.Cells("CantidadB_A").Value = DBNull.Value
            row.Cells("CantidadB_B").Value = DBNull.Value
            row.Cells("CantidadB_C").Value = DBNull.Value
            row.Cells("CantidadB_D").Value = DBNull.Value
            row.Cells("CantidadB_E").Value = DBNull.Value
            row.Cells("ImporteB").Value = DBNull.Value
        Next
        For Each row As DataGridViewRow In dgv_Monedas.Rows
            row.Cells("CantidadM").Value = DBNull.Value
            row.Cells("ImporteM").Value = DBNull.Value
        Next
    End Sub

    Private Sub cmb_Tipos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipos.SelectedValueChanged
        dgv_Billetes.Columns("CantidadB_A").Visible = cmb_Tipos.SelectedValue = "S"
        dgv_Billetes.Columns("CantidadB_B").Visible = cmb_Tipos.SelectedValue = "S"
        dgv_Billetes.Columns("CantidadB_C").Visible = cmb_Tipos.SelectedValue = "S"
        dgv_Billetes.Columns("CantidadB_D").Visible = cmb_Tipos.SelectedValue = "S"
        dgv_Billetes.Columns("CantidadB_E").Visible = cmb_Tipos.SelectedValue = "S"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If SesionId = 0 Then
            MsgBox("No es posible Capturar Dotaciones porque no hay Sesión Abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If validar() Then
            If tbx_Sobres.Text = "" Then tbx_Sobres.Text = 0
            If tbx_ImpDoc.Text = "" Then tbx_ImpDoc.Text = 0
            If tbx_Importe.Text = "" Then tbx_Importe.Text = 0
            If tbx_ImpNom.Text = "" Then tbx_ImpNom.Text = 0

            If fn_PrepararDotaciones_Guardar(cmb_CajaBancaria.SelectedValue, cmb_Cliente.SelectedValue, cmb_Moneda.SelectedValue, tbx_Importe.Text, dtp_Entrega.Value, cmb_Documentos.SelectedValue, cmb_Nomina.SelectedValue, CInt(tbx_Sobres.Text), dgv_Billetes.DataSource, dgv_Monedas.DataSource, Format(dtp_HoraSolicita.Value, "HH:mm"), cmb_TipoDotacion.SelectedValue, tbx_ImpDoc.Text, tbx_ImpNom.Text, IIf(Cmb_Servicio.SelectedValue > 0, Cmb_Servicio.SelectedValue, 0)) Then
                MsgBox("La dotacion se ha guardado correctamente", MsgBoxStyle.Information, frm_MENU.Text)
                Limpiar()
            Else
                MsgBox("Ha ocurrido un error al intentar generar la dotacion", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If

    End Sub

    Private Function validar() As Boolean

        If cmb_TipoDotacion.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Tipo de Dotación.", 16 + 0, frm_MENU.Text)
            cmb_TipoDotacion.Focus()
            Return False
        End If

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", 16 + 0, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If
        If cmb_Cia.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Compañia de Traslado.", 16 + 0, frm_MENU.Text)
            cmb_Cia.Focus()
            Return False
        End If
        If cmb_Cliente.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Cliente.", 16 + 0, frm_MENU.Text)
            cmb_Cliente.Focus()
            Return False
        End If
        If cmb_Cia.SelectedValue = 1 AndAlso Cmb_Servicio.SelectedValue = "0" Then
            MsgBox("Debe indicar un Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Servicio.Focus()
            Return False
        End If
        If cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Moneda.", 16 + 0, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If
        If cmb_Tipos.SelectedValue = "0" And cmb_Documentos.SelectedValue = "N" Then
            MsgBox("Debe seleccionar si la dotacion es por tipos.", 16 + 0, frm_MENU.Text)
            cmb_Tipos.Focus()
            Return False
        End If
        If cmb_Documentos.SelectedValue = "0" Then
            MsgBox("Debe indicar si la Dotación es de Documentos o No.", 16 + 0, frm_MENU.Text)
            cmb_Documentos.Focus()
            Return False
        End If
        If tbx_Importe.Text = "" And cmb_Documentos.SelectedValue = "N" And cmb_Nomina.SelectedValue = "N" Then
            MsgBox("Debe capturar el Importe de la Dotación.", 16 + 0, frm_MENU.Text)
            Return False
        End If

        If tbx_ImpDoc.Text = "" And cmb_Documentos.SelectedValue = "S" Then
            MsgBox("Debe capturar el Importe de los Documentos.", 16 + 0, frm_MENU.Text)
            Return False
        End If

        If tbx_ImpNom.Text = "" And cmb_Nomina.SelectedValue = "0" Then
            MsgBox("Debe capturar el Importe de la Nomina.", 16 + 0, frm_MENU.Text)
            Return False
        End If

        If cmb_Documentos.SelectedValue = "N" Then
            If cmb_Nomina.SelectedValue = "0" Then
                MsgBox("Debe indicar si la Dotación es de Nominas o No.", 16 + 0, frm_MENU.Text)
                cmb_Nomina.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub Limpiar()
        Call LimpiarGrid()
        tbx_Importe.Clear()
        tbx_ImpDoc.Clear()
        tbx_Sobres.Clear()
        tbx_ImpNom.Clear()
        cmb_Cliente.SelectedValue = "0"
    End Sub

    Private Function Totalizar() As Decimal
        Dim Total As Decimal = 0D
        For Each row As DataGridViewRow In dgv_Billetes.Rows
            If Not IsDBNull(row.Cells("ImporteB").Value) Then Total += row.Cells("ImporteB").Value
        Next
        For Each row As DataGridViewRow In dgv_Monedas.Rows
            If Not IsDBNull(row.Cells("ImporteM").Value) Then Total += row.Cells("ImporteM").Value
        Next
        Return Total
    End Function

    Private Sub dtp_Entrega_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Entrega.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmb_Documentos.Focus()
        End If
    End Sub

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        SegundosDesconexion = 0
        If cmb_Cliente.SelectedValue > 0 Then
            Dim Grupo As Integer = fn_PrepararDotacion_ValidarGrupoDota(cmb_Cliente.SelectedValue)
            If Grupo > 0 Then
                cmb_Cliente.Tag = Grupo
            Else
                MsgBox("El cliente no tiene grupo de dotación verifique el catálogo.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Cliente.SelectedValue = "0"
            End If
            If cmb_Cia.SelectedValue = 1 Then
                Cmb_Servicio.Actualizar(fn_cmbServicio(cmb_Cliente.SelectedValue))
                Cmb_Servicio.Enabled = True
            End If
        ElseIf cmb_Cia.SelectedValue > 0 Then
            Cmb_Servicio.Actualizar(fn_cmbServicio(0))
            Cmb_Servicio.Enabled = False
        End If
    End Sub

    Private Sub btn_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cliente.Click
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Primero debe Indicar la Caja Bancaria.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If
        Dim frm As New Frm_BuscarCliente
        frm.Id_CajaBancaria = cmb_CajaBancaria.SelectedValue
        frm.Consulta = Frm_BuscarCliente.Query.ClientesP

        'frm.Source = cmb_Cliente.GetSource
        'frm.Pk = cmb_Cliente.ValueMember
        'frm.CampoClave = cmb_Cliente.Clave

        frm.ShowDialog()

        If frm.Id > 0 Then cmb_Cliente.SelectedValue = frm.Id
    End Sub

    Private Sub cmb_Nomina_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Nomina.SelectedValueChanged
        tbx_Sobres.Enabled = cmb_Nomina.SelectedValue = "S"
        tbx_Sobres.Text = 0
    End Sub

    Private Sub mtb_HoraSolicita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtb_HoraSolicita.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cmb_Tipos.Focus()
        End If
    End Sub

    Private Sub gbx_dotacion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_dotacion.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dgv_Billetes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_Billetes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_TipoDotacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDotacion.SelectedIndexChanged
        If cmb_TipoDotacion.SelectedValue = "0" Then
            gbx_dotacion.Enabled = False
        Else
            gbx_dotacion.Enabled = True
        End If
    End Sub

    Private Sub cmb_Nomina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nomina.SelectedIndexChanged
        tbx_Sobres.Enabled = cmb_Nomina.SelectedValue = "S"
        Call LimpiarGrid()
        tbx_ImpNom.Clear()
    End Sub

End Class