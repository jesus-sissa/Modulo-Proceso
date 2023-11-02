
Public Class frm_ReporteFallasI

    Dim TipoSolicitud As String = ""
    Dim Tipo As Integer = 0

    Private Sub frm_ReporteFallas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_FechaRequerida.Value = DateTime.Now
        dtp_HoraRequerida.Value = DateTime.Now
        cmb_UsuarioDesignado.AgregaParametro("@Id_Departamento", -1, 1)
        cmb_UsuarioDesignado.Actualizar()
        cmb_DeptoDesignado.Actualizar()
        tbx_UsuarioSolicita.Text = UsuarioN
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        Dim Mensaje As String
        If rdb_Equipo.Checked Then
            TipoSolicitud = "Solicitud de Equipo"
            Mensaje = " del Equipo que Solicita."
            Tipo = 1
        ElseIf rdb_Servicios.Checked Then
            TipoSolicitud = "Solicitud de Servicio"
            Mensaje = " del Servicio que Solicita."
            Tipo = 2
        ElseIf rdb_Otros.Checked Then
            TipoSolicitud = "Solicitud Otros"
            Mensaje = " de lo que Solicita."
            Tipo = 3
        Else
            MsgBox("Seleccione el Tipo de Solicitud.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If rtb_Descripcion.Text = "" Then
            MsgBox("Capture la Descripción " & Mensaje, MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Descripcion.Focus()
            Exit Sub
        End If
        If tbx_CantidadSolicitada.Text.Trim = "" Or tbx_CantidadSolicitada.Text.Trim = "0" Then
            MsgBox("Capture la Cantidad Solicitada.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CantidadSolicitada.Focus()
            Exit Sub
        End If
        If cmb_DeptoDesignado.SelectedValue = 0 Then
            MsgBox("Seleccione el Departamento Designado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DeptoDesignado.Focus()
            Exit Sub
        End If
        If cmb_UsuarioDesignado.SelectedValue = 0 Then
            MsgBox("Seleccione el Usuario Designado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_UsuarioDesignado.Focus()
            Exit Sub
        End If
        If rtb_MotivoSolicitud.Text = "" Then
            MsgBox("Debe indicar el Motivo de la Solicitud.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_MotivoSolicitud.Focus()
            Exit Sub
        End If

        Dim Id_Solicitud As Integer = 0
        Id_Solicitud = Cn_Fallas.fn_ReporteFallasI_Crear(Tipo, rtb_Descripcion.Text, tbx_EquipoSustituye.Text, dtp_FechaRequerida.Value.Date, dtp_HoraRequerida.Value.TimeOfDay.ToString, rtb_MotivoSolicitud.Text, cmb_DeptoDesignado.SelectedValue, cmb_UsuarioDesignado.SelectedValue, TipoSolicitud, CInt(tbx_CantidadSolicitada.Text), cmb_UsuarioDesignado.Text, cmb_DeptoDesignado.Text, tbx_UsuarioSolicita.Text, IIf(tbx_Adjunto.Text = "", "No", "Si"))

        If Id_Solicitud > 0 Then
            Call Correo()
            MsgBox("La Solicitud se ha guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call Limpiar()
        Else
            MsgBox("Ocurrió un error al intentar guardar la Solicitud.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub Correo()
        Dim Detalle As String
        Detalle = "                Sucursal: " & SucursalN & Chr(13) _
                 & "                   Fecha: " & Now.Date.ToShortDateString & Chr(13) _
                 & "       Tipo de Solicitud: " & TipoSolicitud & Chr(13) _
                 & "             Descripción: " & rtb_Descripcion.Text & Chr(13) _
                 & "                Cantidad: " & tbx_CantidadSolicitada.Text & Chr(13) _
                 & "    Usuario que Solicita: " & tbx_UsuarioSolicita.Text & Chr(13) _
                 & "     Motivo de Solicitud: " & rtb_MotivoSolicitud.Text & Chr(13) _
                 & "  Departamento Designado: " & cmb_DeptoDesignado.Text & Chr(13) _
                 & "       Usuario Designado: " & cmb_UsuarioDesignado.Text & Chr(13) & Chr(13) _
                 & "Agente de Servicios SIAC " & Now.Date.Year.ToString & "."


        Dim DetalleHTML As String = "<html><body><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>" _
                                        & "<tr><td colspan='4' align='center'>" & TipoSolicitud & "</td></tr>" _
                                        & "<tr><td colspan='4'><hr /></td></tr>" _
                                        & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Modulo Registro:</b></label></td><td>" & ModuloNombre & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Estacion Registro:</b></label></td><td>" & EstacioN & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Fecha:</b></label></td><td>" & Now.Date.ToShortDateString & " " & Now.ToShortTimeString & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Tipo de Solicitud:</b></label></td><td>" & TipoSolicitud.ToUpper & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Descripción:</b></label></td><td>" & rtb_Descripcion.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Equipo Que Sustituye:</b></label></td><td>" & tbx_EquipoSustituye.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Cantidad:</b></label></td><td>" & tbx_CantidadSolicitada.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Usuario que Solicita:</b></label></td><td>" & tbx_UsuarioSolicita.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Motivo de Solicitud:</b></label></td><td>" & rtb_MotivoSolicitud.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Departamento Designado:</b></label></td><td>" & cmb_DeptoDesignado.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Usuario Designado:</b></label></td><td>" & cmb_UsuarioDesignado.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Archivo Adjunto:</b></label></td><td>" & tbx_Adjunto.Text & "</td><td></td><td></td></tr>" _
                                        & "<tr><td colspan='4'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table><br/><br/></body></html>"

        'Generar Alerta y enviar Correo
        If Not Cn_Proceso.fn_AlertasGeneradas_Guardar("29", Detalle, Nothing, True, TipoSolicitud.ToUpper, Tbx_Adjunto.Text, DetalleHTML) Then
            MsgBox("Ocurrió un error al intentar enviar la falla por Correo Electrónico.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Sub Limpiar()
        rdb_Equipo.Checked = False
        rdb_Otros.Checked = False
        rdb_Servicios.Checked = False
        rtb_Descripcion.Clear()
        tbx_EquipoSustituye.Clear()
        tbx_EquipoSustituye.Enabled = False
        tbx_CantidadSolicitada.Clear()
        dtp_FechaRequerida.Value = Today.Date
        dtp_HoraRequerida.Value = Now
        cmb_UsuarioDesignado.SelectedValue = 0
        cmb_DeptoDesignado.SelectedValue = 0
        rtb_MotivoSolicitud.Clear()
        Tbx_Adjunto.Clear()
    End Sub

    Private Sub tbx_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rdb_Equipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Equipo.CheckedChanged
        SegundosDesconexion = 0

        If rdb_Equipo.Checked Then
            tbx_EquipoSustituye.Enabled = True
        Else
            tbx_EquipoSustituye.Enabled = False
        End If
    End Sub

    Private Sub rdb_Servicios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Servicios.CheckedChanged
        SegundosDesconexion = 0

        If rdb_Servicios.Checked Then
            cmb_DeptoDesignado.SelectedValue = DepartamentoID
            tbx_CantidadSolicitada.Text = 1
            tbx_CantidadSolicitada.Enabled = False
        Else
            cmb_DeptoDesignado.SelectedValue = 0
            tbx_CantidadSolicitada.Clear()
            tbx_CantidadSolicitada.Enabled = True
        End If
    End Sub

    Private Sub cmb_DeptoDesignado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DeptoDesignado.SelectedIndexChanged
        SegundosDesconexion = 0

        If cmb_DeptoDesignado.SelectedValue = 0 Then
            cmb_UsuarioDesignado.ActualizaValorParametro("@Id_Departamento", -1)
            cmb_UsuarioDesignado.Actualizar()
        Else
            cmb_UsuarioDesignado.ActualizaValorParametro("@Id_Departamento", cmb_DeptoDesignado.SelectedValue)
            cmb_UsuarioDesignado.Actualizar()
        End If
    End Sub

    Private Sub rtb_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Descripcion.KeyPress
        SegundosDesconexion = 0

        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rtb_MotivoSolicitud_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SegundosDesconexion = 0

        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Adjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Adjunto.Click
        SegundosDesconexion = 0
        Dim FileSize As Long = 0
        Dim Dialogo As New OpenFileDialog
        Dialogo.Multiselect = False
        Try
            Dialogo.InitialDirectory = "C:\"
        Catch
        End Try
Regreso:
        Dialogo.FileName = ""
        FileSize = 0
        Dialogo.ShowDialog()
        Tbx_Adjunto.Text = Dialogo.FileName

        If Tbx_Adjunto.Text <> "" Then
            Try
                Dim MyFile As New System.IO.FileInfo(Tbx_Adjunto.Text)
                FileSize = MyFile.Length
            Catch

            End Try
        End If
        If FileSize > 500000 Then 'El tamaño esta en Bytes
            MsgBox("El Archivo seleccionado es muy grande para enviarse como adjunto en el mensaje. Intente reducir el Archivo o seleccione otro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Tbx_Adjunto.Clear()
            GoTo Regreso
        End If
    End Sub
End Class