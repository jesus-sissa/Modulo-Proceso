Imports System.IO

Public Class frm_ReporteFallas

    Private Sub frm_ReporteFallas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Subtipo.AgregaParametro("@Id_Tipo", 0, 1)
        cmb_Clase.AgregaParametro("@Id_SubTipo", 0, 1)
        cmb_Subclase.AgregaParametro("@Id_Clase", 0, 1)
        cmb_Inventario.AgregaParametro("@Id_SubClase", 0, 1)
        cmb_Tipo.Actualizar()

        tbx_Empleado.Text = UsuarioN
    End Sub

    Private Sub cmb_Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipo.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_Subtipo.ActualizaValorParametro("@Id_Tipo", cmb_Tipo.SelectedValue)
        cmb_Subtipo.Actualizar()
    End Sub

    Private Sub cmb_Subtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Subtipo.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_Clase.ActualizaValorParametro("@Id_SubTipo", cmb_Subtipo.SelectedValue)
        cmb_Clase.Actualizar()
    End Sub

    Private Sub cmb_Clase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Clase.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_Subclase.ActualizaValorParametro("@Id_Clase", cmb_Clase.SelectedValue)
        cmb_Subclase.Actualizar()
    End Sub

    Private Sub cmb_Subclase_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Subclase.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_Inventario.ActualizaValorParametro("@Id_SubClase", cmb_Subclase.SelectedValue)
        cmb_Inventario.Actualizar()
    End Sub

    Private Sub cmb_Inventario_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Inventario.SelectedValueChanged
        SegundosDesconexion = 0
        'Leer os datos y desplegarlos
        If cmb_Inventario.SelectedValue = 0 Then
            tbx_Marca.Clear()
            tbx_Modelo.Clear()
            tbx_Serie.Clear()
            'tbx_Etiqueta.Clear()
            tbx_Referencia.Clear()
            Exit Sub
        End If
        Dim Dt As DataTable
        Dt = Cn_Fallas.fn_Inventario_Read(cmb_Inventario.SelectedValue)
        If Dt IsNot Nothing Then
            If Dt.Rows.Count > 0 Then
                tbx_Marca.Text = Dt.Rows(0)("Marca")
                tbx_Modelo.Text = Dt.Rows(0)("Modelo")
                tbx_Serie.Text = Dt.Rows(0)("Serie")
                tbx_Etiqueta.Text = Dt.Rows(0)("Clave")
                tbx_Referencia.Text = Dt.Rows(0)("Numero")
            End If
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If chk_Etiqueta.Checked Then
            If cmb_Tipo.SelectedValue = 0 Then
                MsgBox("Seleccione un Tipo.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Tipo.Focus()
                Exit Sub
            End If
            If cmb_Subtipo.SelectedValue = 0 Then
                MsgBox("Seleccione un SubTipo.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Subtipo.Focus()
                Exit Sub
            End If
            If cmb_Clase.SelectedValue = 0 Then
                MsgBox("Seleccione una Clase.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Clase.Focus()
                Exit Sub
            End If
            If cmb_Subclase.SelectedValue = 0 Then
                MsgBox("Seleccione una SubClase.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Subclase.Focus()
                Exit Sub
            End If
            If Not chk_Otro.Checked Then
                If cmb_Inventario.SelectedValue = 0 Then
                    MsgBox("Seleccione el Elemento que desea Reportar o marque la casilla «Otro».", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Inventario.Focus()
                    Exit Sub
                End If
            End If
        Else
            If cmb_Inventario.SelectedValue = 0 Then
                MsgBox("Debe indicar el Elemento que desea Reportar. Si no lo localizó por Número de Etiqueta puede seleccionar la casilla «No Tiene Etiqueta» y buscarlo manualmente.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        If tbx_Descripcion.Text = "" Then
            MsgBox("Debe indicar la Descripción de la Falla.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        Dim Id_Reporte As Integer = 0
        Dim Identificacion As String = ""

        Identificacion = "Tipo De Equipo = " & cmb_Tipo.Text & Chr(13)
        Identificacion &= "Subtipo = " & cmb_Subtipo.Text & Chr(13)
        Identificacion &= "Clase = " & cmb_Clase.Text & Chr(13)
        Identificacion &= "Subclase = " & cmb_Subclase.Text & Chr(13)
        Identificacion &= "Inventario = " & cmb_Inventario.Text & Chr(13)
        Identificacion &= "Marca = " & tbx_Marca.Text & Chr(13)
        Identificacion &= "Modelo = " & tbx_Modelo.Text & Chr(13)
        Identificacion &= "Serie = " & tbx_Serie.Text & Chr(13)
        Identificacion &= "Referencia = " & tbx_Referencia.Text & Chr(13)

        Id_Reporte = Cn_Fallas.fn_ReporteFallas_Crear(cmb_Subclase.SelectedValue, cmb_Inventario.SelectedValue, tbx_Descripcion.Text, tbx_Etiqueta.Text, tbx_Ubicacion.Text, Identificacion, tbx_Empleado.Text, cmb_Tipo.Text, IIf(tbx_Adjunto.Text = "", "NO", "SI"))
        If Id_Reporte > 0 Then
            Call Correo()
            MsgBox("El Reporte se ha guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call Limpiar()
            tbx_Etiqueta.Clear()
            If tbx_Etiqueta.Enabled = True Then
                tbx_Etiqueta.Focus()
            ElseIf cmb_Tipo.Enabled = True Then
                cmb_Tipo.Focus()
            End If
        Else
            MsgBox("Ocurrió un error al intentar guardar el Reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub Correo()
        Dim Detalles As String
        Detalles = "                Sucursal: " & SucursalN & Chr(13) _
                & "                   Fecha: " & Now.Date.ToShortDateString & Chr(13) _
                & "                   Clase: " & cmb_Clase.Text & Chr(13) _
                & "                SubClase: " & cmb_Subclase.Text & Chr(13) _
                & "     Usuario que Reporta: " & tbx_Empleado.Text & Chr(13) _
                & "      Etiqueta de Equipo: " & tbx_Etiqueta.Text & Chr(13) _
                & "    Número de Referencia: " & tbx_Referencia.Text & Chr(13) _
                & "               Ubicación: " & tbx_Ubicacion.Text & Chr(13) _
                & " Descripción de la Falla: " & tbx_Descripcion.Text & Chr(13) & Chr(13) _
                & "Agente de Servicios SIAC " & Now.Date.Year.ToString & "."

        Dim DetalleHTML As String = "<html><body><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>" _
                                        & "<tr><td colspan='4'><hr /></td></tr>" _
                                        & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Modulo Registro:</b></label></td><td>" & ModuloNombre & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Usuario Registro:</b></label></td><td>" & UsuarioN & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Estacion Registro:</b></label></td><td>" & EstacioN & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Fecha:</b></label></td><td>" & Now.Date.ToShortDateString & " " & Now.ToShortTimeString & "</td><td></td><td></td></tr>" _
                                        & "<tr><td align='right'><label><b>Etiqueta:</b></label></td><td>" & tbx_Etiqueta.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Tipo de Equipo:</b></label></td><td>" & cmb_Tipo.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Subtipo:</b></label></td><td>" & cmb_Subtipo.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Clase:</b></label></td><td>" & cmb_Clase.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Subclase:</b></label></td><td>" & cmb_Subclase.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Inventario:</b></label></td><td>" & cmb_Inventario.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Marca:</b></label></td><td>" & tbx_Marca.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Modelo:</b></label></td><td>" & tbx_Modelo.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Serie:</b></label></td><td>" & tbx_Serie.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>No. Referencia:</b></label></td><td>" & tbx_Referencia.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Descripcion:</b></label></td><td>" & tbx_Descripcion.Text & "<br></td></tr>" _
                                        & "<tr><td align='right'><label><b>Archivo Adjunto:</b></label></td><td>" & tbx_Adjunto.Text & "<br></td></tr>" _
                                        & "<tr><td colspan='4'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table><br/><br/></body></html>"

        'Enviar el Reporte por correo
        If Not Cn_Proceso.fn_AlertasGeneradas_Guardar("47", Detalles, Nothing, True, "FALLA EN EQUIPO", tbx_Adjunto.Text, DetalleHTML) Then
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

    Private Sub tbx_Etiqueta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Etiqueta.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            SegundosDesconexion = 0
            Call Limpiar()
            'Buscar la Clave en Inv_inventario
            Dim dt As DataTable
            dt = Cn_Fallas.fn_ReporteFallas_ReadByClave(tbx_Etiqueta.Text.Trim)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    cmb_Tipo.SelectedValue = dt.Rows(0)("Id_Tipo")
                    cmb_Subtipo.SelectedValue = dt.Rows(0)("Id_SubTipo")
                    cmb_Clase.SelectedValue = dt.Rows(0)("Id_Clase")
                    cmb_Subclase.SelectedValue = dt.Rows(0)("Id_SubClase")
                    cmb_Inventario.SelectedValue = dt.Rows(0)("Id_Inventario")

                    tbx_Marca.Text = dt.Rows(0)("Marca")
                    tbx_Modelo.Text = dt.Rows(0)("Modelo")
                    tbx_Serie.Text = dt.Rows(0)("Serie")

                    tbx_Descripcion.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Sub Limpiar()
        cmb_Tipo.SelectedValue = 0
        tbx_Marca.Clear()
        tbx_Modelo.Clear()
        tbx_Serie.Clear()
        tbx_Descripcion.Clear()
        tbx_Ubicacion.Clear()
        tbx_Adjunto.Clear()
    End Sub

    Private Sub chk_Etiqueta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Etiqueta.CheckedChanged
        SegundosDesconexion = 0
        tbx_Etiqueta.Clear()
        cmb_Tipo.SelectedValue = 0
        chk_Otro.Checked = False

        If chk_Etiqueta.Checked Then
            tbx_Etiqueta.Enabled = False
            tbx_Etiqueta.BackColor = SystemColors.Control

            cmb_Tipo.Enabled = True
            cmb_Subtipo.Enabled = True
            cmb_Clase.Enabled = True
            cmb_Subclase.Enabled = True
            cmb_Inventario.Enabled = True
            chk_Otro.Enabled = True
            cmb_Tipo.Focus()
        Else
            tbx_Etiqueta.Enabled = True
            tbx_Etiqueta.BackColor = SystemColors.Window

            cmb_Tipo.Enabled = False
            cmb_Subtipo.Enabled = False
            cmb_Clase.Enabled = False
            cmb_Subclase.Enabled = False
            cmb_Inventario.Enabled = False
            chk_Otro.Enabled = False
            tbx_Etiqueta.Focus()
        End If
    End Sub


    Private Sub chk_Otro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Otro.CheckedChanged
        cmb_Inventario.SelectedValue = 0
        cmb_Inventario.Enabled = Not chk_Otro.Checked
    End Sub

    Private Sub tbx_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Descripcion.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class