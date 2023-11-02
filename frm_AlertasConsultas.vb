Imports Modulo_Proceso.Cn_Fallas

Public Class frm_AlertasConsultas

    Private Sub frm_AlertasConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.MinDate = dtp_Desde.Value

        lsv_Alertas.Columns.Add("Fecha")
        lsv_Alertas.Columns.Add("Hora")
        lsv_Alertas.Columns.Add("Nombre")
        lsv_Alertas.Columns.Add("Descripcion")
        lsv_Alertas.Columns.Add("Detalle")
        lsv_Alertas.Columns.Add("NombreAtendio")
        lsv_Alertas.Columns.Add("FechaAtencion")
        lsv_Alertas.Columns.Add("Hora")
        lsv_Alertas.Columns.Add("Status")

        lsv_Detalle.Columns.Add("Clave")
        lsv_Detalle.Columns.Add("Descripcion")

        cmb_Tipo.Actualizar()

        cmb_Status.AgregarItem("A", "ACTIVA")
        cmb_Status.AgregarItem("V", "VALIDADA")
        cmb_Status.AgregarItem("C", "CANCELADA")
    End Sub

    Sub Limpiar()
        lsv_Alertas.Items.Clear()
        tbx_Descripcion.Clear()
        lsv_Detalle.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Detalle.Items.Count)
    End Sub

    Private Sub Botones()
        btn_Exportar.Enabled = lsv_Alertas.Items.Count > 0
    End Sub

    Private Sub dtp_DesdeHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged, dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
        dtp_Hasta.MinDate = dtp_Desde.Value
        Call Botones()
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0
            If cmb_Tipo.Enabled Then
                cmb_Tipo.Focus()
            ElseIf cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_TipoStatus_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipo.SelectedValueChanged, cmb_Status.SelectedValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
        Call Botones()
    End Sub

    Private Sub cmb_Tipo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Tipo.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Tipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Tipo.CheckedChanged
        SegundosDesconexion = 0

        Call Limpiar()
        cmb_Tipo.SelectedValue = "0"
        cmb_Tipo.Enabled = Not chk_Tipo.Checked
        Call Botones()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        Call Limpiar()
        cmb_Status.SelectedValue = "0"
        cmb_Status.Enabled = Not chk_Status.Checked
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If cmb_Tipo.SelectedValue = "0" AndAlso Not chk_Tipo.Checked Then
            MsgBox("Seleccione el Tipo de Alerta o marque la casilla de «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If

        If cmb_Status.SelectedValue = "0" AndAlso Not chk_Status.Checked Then
            MsgBox("Seleccione el Status o marque la casilla de «Todos»", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        Call Limpiar()

        If Not fn_AlertasGeneradas_LlenarListaFiltrada(lsv_Alertas, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Tipo.SelectedValue, cmb_Status.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Detalle.Items.Count)
        btn_Exportar.Enabled = lsv_Alertas.Items.Count > 0
    End Sub

    Private Sub lsv_Alertas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Alertas.SelectedIndexChanged
        tbx_Descripcion.Clear()
        lsv_Detalle.Items.Clear()
        If lsv_Alertas.SelectedItems.Count = 0 Then Exit Sub

        Dim Cadena As New System.Text.StringBuilder

        'Mostrar los datos
        Cadena.Append("Fecha: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Hora: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(1).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Nombre: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(2).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Descripción: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(3).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Detalle: ")
        Cadena.Append(Chr(13))
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(4).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Atendió: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(5).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Fecha: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(6).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Hora: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(7).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        Cadena.Append("Estatus: ")
        Cadena.Append(lsv_Alertas.SelectedItems(0).SubItems(8).Text)
        Cadena.Append(Chr(13))
        Cadena.Append(Chr(13))

        tbx_Descripcion.Text = Cadena.ToString

        'Mostrar el detalle de la alerta
        If Not fn_AlertasGeneradas_LlenarListaDetalle(lsv_Detalle, lsv_Alertas.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar cargar el detalle de la Alerta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Alertas, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class