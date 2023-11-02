Imports System.IO

Public Class frm_ReporteFallasS

    Private Sub frm_ReporteFallasS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbx_Usuario.Text = UsuarioN

        cmb_Modulo.AgregaParametro("@Status", "A", 0)
        cmb_Menu.AgregaParametro("@Clave_Modulo", "0", 0)
        cmb_Opcion.AgregaParametro("@Id_Menu", 0, 1)

        cmb_Modulo.Actualizar()

    End Sub

    Private Sub cmb_Modulo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Modulo.SelectedIndexChanged
        SegundosDesconexion = 0
        If cmb_Modulo.SelectedIndex = 0 Then
            cmb_Menu.ActualizaValorParametro("@Clave_Modulo", "0")
        Else
            cmb_Menu.ActualizaValorParametro("@Clave_Modulo", cmb_Modulo.SelectedValue)
        End If

        cmb_Menu.Actualizar()

    End Sub

    Private Sub cmb_Menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Menu.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_Opcion.ActualizaValorParametro("@Id_Menu", cmb_Menu.SelectedValue)
        cmb_Opcion.Actualizar()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If cmb_Opcion.SelectedValue = 0 Then
            MsgBox("Debe Seleccionar una Opción.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Opcion.Focus()
            Exit Sub
        End If
        If tbx_Descripcion.Text = "" Then
            MsgBox("Debe indicar una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If
        Dim Id_Reporte As Integer = 0
        Id_Reporte = Cn_Fallas.fn_ReporteFallasS_Crear(cmb_Modulo.SelectedValue, cmb_Opcion.SelectedValue, tbx_Descripcion.Text, tbx_Etiqueta.Text, tbx_Ubicacion.Text, cmb_Modulo.Text, cmb_Menu.Text, cmb_Opcion.Text, tbx_Usuario.Text, IIf(tbx_Adjunto.Text = "", "No", "Si"))
        If Id_Reporte > 0 Then
            Call Correo()
            MsgBox("El Reporte se ha guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_Descripcion.Clear()
            tbx_Etiqueta.Clear()
            tbx_Ubicacion.Clear()
            tbx_Adjunto.Clear()
        Else
            MsgBox("Ocurrió un error al intentar guardar el Reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub Correo()
        Dim Detalle As String
        Detalle = "                Sucursal: " & SucursalN & Chr(13) _
              & "                   Fecha: " & Now.Date.ToShortDateString & Chr(13) _
              & "                  Módulo: " & cmb_Modulo.Text & Chr(13) _
              & "                    Menu: " & cmb_Menu.Text & Chr(13) _
              & "                  Opcion: " & cmb_Opcion.Text & Chr(13) _
              & "     Usuario que Reporta: " & tbx_Usuario.Text & Chr(13) _
              & "      Etiqueta de Equipo: " & tbx_Etiqueta.Text & Chr(13) _
              & "               Ubicación: " & tbx_Ubicacion.Text & Chr(13) _
              & " Descripción de la Falla: " & tbx_Descripcion.Text & Chr(13) & Chr(13) _
              & "Agente de Servicios SIAC " & Now.Date.Year.ToString & "."

        Dim DetalleHTML As String = "<html><body><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>" _
                                      & "<tr><td colspan='4'><hr /></td></tr>" _
                                      & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Fecha:</b></label></td><td>" & Now.Date.ToShortDateString & " " & Now.ToShortTimeString & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Modulo Que Falla:</b></label></td><td>" & ModuloNombre & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Menu:</b></label></td><td>" & cmb_Menu.Text & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Opcion:</b></label></td><td>" & cmb_Opcion.Text & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Usuario Registro:</b></label></td><td>" & UsuarioN & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Numero de Etiqueta:</b></label></td><td>" & tbx_Etiqueta.Text & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Ubicacion:</b></label></td><td>" & tbx_Ubicacion.Text & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Descripcion De Falla:</b></label></td><td>" & tbx_Descripcion.Text & "</td><td></td><td></td></tr>" _
                                      & "<tr><td align='right'><label><b>Archivo Adjunto:</b></label></td><td>" & tbx_Adjunto.Text & "</td><td></td><td></td></tr>" _
                                      & "<tr><td colspan='4'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table><br/><br/></body></html>"
        'Enviar el Reporte por correo


        If Not Cn_Proceso.fn_AlertasGeneradas_Guardar("48", Detalle, Nothing, True, "FALLA EN SISTEMA", tbx_Adjunto.Text, DetalleHTML) Then
            MsgBox("Ocurrió un error al intentar enviar la falla por Correo Electrónico.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
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
        tbx_Adjunto.Text = Dialogo.FileName

        If tbx_Adjunto.Text <> "" Then
            Try
                Dim MyFile As New FileInfo(tbx_Adjunto.Text)
                FileSize = MyFile.Length
            Catch

            End Try
        End If
        If FileSize > 500000 Then 'El tamaño esta en Bytes
            MsgBox("El Archivo seleccionado es muy grande para enviarse como adjunto en el mensaje. Intente reducir el Archivo o seleccione otro.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Adjunto.Clear()
            GoTo Regreso
        End If

    End Sub

    Private Sub tbx_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Descripcion.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class