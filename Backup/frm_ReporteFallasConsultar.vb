Imports Modulo_Proceso.Cn_Actualizaciones

Public Class frm_ReporteFallasConsultar

    Private Sub frm_ActualizacionesConsultar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Datos.Columns.Add("Fecha")
        lsv_Datos.Columns.Add("Modulo")
        lsv_Datos.Columns.Add("Menu")
        lsv_Datos.Columns.Add("Opcion")
        lsv_Datos.Columns.Add("Descripcion")
        lsv_Datos.Columns.Add("UsuarioAsignado")
        lsv_Datos.Columns.Add("Status")
        lsv_Datos.Columns.Add("FechaFin")

        Call LimpiaGrid()

    End Sub

    Sub Limpiar()
        'limpiar los controles
        Call LimpiaGrid()
        tbx_Descripcion.Clear()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, Me.Text, 0, 2, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Consultar.Click
        Dim Fdesde As Date
        Dim Fhasta As Date
        If Not chk_Fecha.Checked Then
            If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
                MsgBox("El periodo de fechas parece estar incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_Desde.Focus()
                Exit Sub
            End If
            Fdesde = dtp_Desde.Value.Date
            Fhasta = dtp_Hasta.Value.Date
        Else
            Fdesde = #1/1/2010#
            Fhasta = Now.Date
        End If
        If Not Cn_Fallas.fn_ReporteFallas_LlenarLista(lsv_Datos, ModuloClave, Fdesde, Fhasta) Then
            MsgBox("Ha ocurrido un error al intentar consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Datos.Items.Count)
        btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        Call Limpiar()
        If lsv_Datos.SelectedItems.Count = 0 Then Exit Sub
        Dim cadena As New System.Text.StringBuilder
        'mostrar los datos
        cadena.Append("Fecha Registro: ")
        cadena.Append(lsv_Datos.SelectedItems(0).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        cadena.Append("Módulo: ")
        cadena.Append(lsv_Datos.SelectedItems(0).SubItems(2).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        cadena.Append("Tipo de Tarea: ")
        cadena.Append(lsv_Datos.SelectedItems(0).SubItems(1).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        cadena.Append("Menú: ")
        cadena.Append(lsv_Datos.SelectedItems(0).SubItems(3).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        cadena.Append("Opción o Pantalla: ")
        cadena.Append(lsv_Datos.SelectedItems(0).SubItems(4).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        cadena.Append("Descripcion: ")
        cadena.Append(lsv_Datos.SelectedItems(0).SubItems(5).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        cadena.Append("Usuario Seguimiento: ")
        cadena.Append(lsv_Datos.SelectedItems(0).SubItems(6).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        cadena.Append("Estatus: ")
        cadena.Append(lsv_Datos.SelectedItems(0).SubItems(7).Text)
        cadena.Append(Chr(13))
        cadena.Append(Chr(13))

        If lsv_Datos.SelectedItems(0).SubItems(7).Text = "PENDIENTE" Then

        ElseIf lsv_Datos.SelectedItems(0).SubItems(7).Text = "ASIGNADA" Then

        ElseIf lsv_Datos.SelectedItems(0).SubItems(7).Text = "FINALIZADA" Then
            cadena.Append("Fecha Fin: ")
            cadena.Append(lsv_Datos.SelectedItems(0).SubItems(8).Text)
            cadena.Append(Chr(13))
            cadena.Append(Chr(13))
            cadena.Append("Comentarios: ")
            cadena.Append(lsv_Datos.SelectedItems(0).SubItems(9).Text)
        ElseIf lsv_Datos.SelectedItems(0).SubItems(7).Text = "CANCELADA" Then
            cadena.Append("Comentarios de la Cancelación: ")
            cadena.Append(lsv_Datos.SelectedItems(0).SubItems(10).Text)
        End If

        tbx_Descripcion.Text = cadena.ToString
        Call LlenarSeguimientoDGV()
        btn_Incidencia.Enabled = True
        If lsv_Datos.SelectedItems(0).SubItems(7).Text = "CANCELADA" Or lsv_Datos.SelectedItems(0).SubItems(7).Text = "FINALIZADA" Then
            btn_Incidencia.Enabled = False
        End If
    End Sub

    Sub LimpiaGrid()
        rtb_Incidencia.Clear()
        dgv_Seguimiento.DataSource = Nothing
        dgv_Seguimiento.Columns.Clear()
        dgv_Seguimiento.Rows.Clear()
        dgv_Seguimiento.Columns.Add("Fecha", "Fecha")
        dgv_Seguimiento.Columns.Add("Hora", "Hora")
        dgv_Seguimiento.Columns.Add("Registro", "Registro")
        dgv_Seguimiento.Columns.Add("Descripcion", "Descripcion")
        dgv_Seguimiento.Columns.Add("Avance", "Avance")
    End Sub

    Sub LlenarSeguimientoDGV()
        'Llenar Seguimiento
        Call LimpiaGrid()
        If Not Cn_Fallas.fn_TareasAtender_LlenarListaDGV(lsv_Datos.SelectedItems(0).Tag, dgv_Seguimiento) Then
            MsgBox("Ha ocurrido un error al intentar mostrar el Seguimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            Exit Sub
        End If
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        lsv_Datos.Items.Clear()
        btn_Exportar.Enabled = False
        Call Limpiar()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        lsv_Datos.Items.Clear()
        btn_Exportar.Enabled = False
        Call Limpiar()
    End Sub

    Private Sub chk_Fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Fecha.CheckedChanged
        lsv_Datos.Items.Clear()
        btn_Exportar.Enabled = False
        FuncionesGlobales.RegistrosNum(lbl_Registros, 0)
        Call Limpiar()
        dtp_Desde.Enabled = Not chk_Fecha.Checked
        dtp_Hasta.Enabled = Not chk_Fecha.Checked
    End Sub

    Private Sub btn_Incidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Incidencia.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        If lsv_Datos.SelectedItems.Count = 0 Then
            MsgBox("Primero debe seleccionar un Reporte para Registrar incidencias.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Datos.Focus()
            Exit Sub
        End If

        If rtb_Incidencia.TextLength < 20 Then
            MsgBox("Debe indicar Observaciones mas descriptivas(Mínimo 20 caracteres).", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Incidencia.Focus()
            SegundosDesconexion = 0
            Exit Sub
        End If
        'Buscar el Ultimo Avance
        Dim Avance As Integer = 0
        If dgv_Seguimiento.Rows.Count > 0 Then
            Avance = Val(dgv_Seguimiento.Rows(dgv_Seguimiento.Rows.Count - 1).Cells(5).Value)
        End If
        If Not Cn_Fallas.fn_TareasUsuario_Indicencia(lsv_Datos.SelectedItems(0).Tag, rtb_Incidencia.Text, Avance) Then
            MsgBox("Ha ocurrido un error al intentar guardar la Incidencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            Exit Sub
        Else
            'Enviar el Mail de registor de la incidencia
            Dim Pie As String = "Agente de Servicios SIAC " & Now.Year.ToString
            Dim DetalleHTML As String = "<html><body><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>" _
                           & "<tr><td colspan='4' align='center'> REGISTRO DE INCIDENCIA </td></tr>" _
                           & "<tr><td colspan='4'><hr /></td></tr>" _
                           & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td> " & SucursalN & "</td><td></td><td></td></tr>" _
                           & "<tr><td align='right'><label><b>El usuario:</b></label></td><td> " & UsuarioN & " HA REGISTRADO UNA INCIDENCIA</td><td></td><td></td></tr>" _
                           & "<tr><td align='right'><label><b>Tarea:</b></label></td><td>" & lsv_Datos.SelectedItems(0).SubItems(4).Text & "</td><td></td><td></td></tr>" _
                           & "<tr><td align='right'><label><b>Modulo:</b></label></td><td>" & lsv_Datos.SelectedItems(0).SubItems(1).Text & "</td><td></td><td></td></tr>" _
                           & "<tr><td align='right'><label><b>Menu:</b></label></td><td>" & lsv_Datos.SelectedItems(0).SubItems(2).Text & "</td><td></td><td></td></tr>" _
                           & "<tr><td align='right'><label><b>Opcion:</b></label></td><td>" & lsv_Datos.SelectedItems(0).SubItems(3).Text & "</td><td></td><td></td></tr>" _
                           & "<tr><td align='right'><label><b>Incidencia:</b></label></td><td>" & rtb_Incidencia.Text & "</td><td></td><td></td></tr>" _
                           & "<tr><td align='right'><label><b>Avance:</b></label></td><td>" & Avance.ToString & "</td><td></td><td></td></tr>" _
                           & "<tr><td colspan='4'><hr /></td></tr><tr><td colspan='3' align='center'>" & Pie & "</td></tr></table><br/><br/></body></html>"
            Cn_Mail.fn_Enviar_MailHTML(Mail_ReporteFallas.Trim, "REGISTRO DE INCIDENCIA", DetalleHTML, "")

            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            SegundosDesconexion = 0
            rtb_Incidencia.Clear()
            Call LlenarSeguimientoDGV()
        End If
    End Sub

    Private Sub rtb_Incidencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Incidencia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

End Class