Imports Modulo_Proceso.Cn_Proceso

Public Class frm_CartasAccesoConsulta

    Private Sub frm_CartasAccesoConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_FechaDesde.Value = Now.Date
        dtp_FechaHasta.MinDate = dtp_FechaDesde.Value
        dtp_FechaHasta.Value = Now.Date
        cmb_Empleado.Actualizar()
        cmb_Status.AgregarItem("A", "ACTIVA")
        cmb_Status.AgregarItem("C", "CANCELADA")

        lsv_Catalogo.Columns.Add("Fecha")
        lsv_Catalogo.Columns.Add("UsuarioRegistro")
        lsv_Catalogo.Columns.Add("UsuarioAutoriza")
        lsv_Catalogo.Columns.Add("Observaciones")
        lsv_Catalogo.Columns.Add("FechaInicio")
        lsv_Catalogo.Columns.Add("FechaFin")
        lsv_Catalogo.Columns.Add("Status")
    End Sub

    Sub Botones()
        btn_Autorizar.Enabled = lsv_Catalogo.SelectedItems.Count > 0 AndAlso lsv_Catalogo.SelectedItems(0).SubItems(6).Text = "ACTIVA"
        btn_Cancelar.Enabled = lsv_Catalogo.SelectedItems.Count > 0 AndAlso lsv_Catalogo.SelectedItems(0).SubItems(6).Text = "ACTIVA"
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
    End Sub

    Private Sub chk_Empleados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Empleados.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros2.Text = "Registros: 0"
        cmb_Empleado.Enabled = Not chk_Empleados.Checked
        cmb_Empleado.SelectedValue = 0
        Call Botones()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros2.Text = "Registros: 0"
        cmb_Status.Enabled = Not chk_Status.Checked
        cmb_Status.SelectedValue = "0"
        Call Botones()
    End Sub

    Private Sub cmb_Empleado_Status_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Empleado.SelectedIndexChanged, cmb_Status.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros2.Text = "Registros: 0"
        Call Botones()
    End Sub

    Private Sub dtp_FechaDesde_FechaHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged, dtp_FechaHasta.ValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Lbl_Registros2.Text = "Registros: 0"
        dtp_FechaHasta.MinDate = dtp_FechaDesde.Value
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If cmb_Empleado.SelectedValue = 0 AndAlso Not chk_Empleados.Checked Then
            MsgBox("Seleccione un Empleado o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleado.Focus()
            Exit Sub
        End If

        If cmb_Status.SelectedValue = "0" AndAlso Not chk_Status.Checked Then
            MsgBox("Seleccione el Status o marque la casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        If Not fn_CartasAccesoConsulta_LlenarLista(lsv_Catalogo, cmb_Empleado.SelectedValue, dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, cmb_Status.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
        Call Botones()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Detalle.Items.Clear()
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            If Not fn_CartasAccesoConsulta_LlenarDetalle(lsv_Detalle, lsv_Catalogo.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar cargar el detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros2, lsv_Detalle.Items.Count)
        Call Botones()
    End Sub

    Private Sub btn_Autorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Autorizar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.PedirObservaciones = True
        frm.Max_Caracteres_Obs = 200
        frm.ShowDialog()

        If frm.Firma Then
            If fn_CartasAccesoConsulta_Validar(lsv_Catalogo.SelectedItems(0).Tag, CInt(frm.tbx_Empleado.Text.Trim), frm.Observaciones) Then
                Dim Dr_InfoUsuarioAutoriza As DataRow = fn_CartasAccesoConsulta_UsuarioAutoriza(CInt(frm.tbx_Empleado.Text.Trim))

                If Dr_InfoUsuarioAutoriza IsNot Nothing Then
                    Dim Descripcion As String = "AUTORIZACION DE MEMO DE ACCESO"

                    Dim Detalle As String = Descripcion & " PARA: " & lsv_Detalle.Items.Count & " USUARIOS" & Chr(13) & Chr(13) _
                                            & "Agente de Servicios SIAC " & Now.Year.ToString

                    Dim DetalleHTML As String = "<html><body><table class=reference cellspacing=0 cellpadding=0 border=0><tr><td colspan='3' align='center'><b>" & Descripcion & "</b></td></tr>" _
                                                & "<tr><td colspan='3' align='left' style='font-family:Arial; font-size:11'><b>Asunto: </b>" & lsv_Catalogo.SelectedItems(0).SubItems(3).Text & "</td></tr>" _
                                                & "<tr><td colspan='3' align='left' style='font-family:Arial; font-size:11'><b>Autorizado por: </b>" & Dr_InfoUsuarioAutoriza("Clave") & " - " & Dr_InfoUsuarioAutoriza("Nombre") & "</td></tr>" _
                                                & "<tr><td colspan='3' align='left' style='font-family:Arial; font-size:11'><b>Fecha de Autorización: </b>" & Now.ToShortDateString & "  " & Now.ToShortTimeString & "</td></tr>" _
                                                & "<tr><td colspan='3' align='left' style='font-family:Arial; font-size:11'><b>Observaciones de Autorización: </b>" & frm.Observaciones & "</td></tr>" _
                                                & "<tr><td colspan='3' align='center'><br>" & FuncionesGlobales.fn_ListviewToHTML(lsv_Detalle, "Usuarios Autorizados", 0, 0, 11, True) _
                                                & "<br><tr><td colspan='3' align='center' style='font-family:Arial; font-size:10'><b>Pie<b></td></tr></table>"

                    fn_AlertasGeneradas_Guardar("40", Detalle, Nothing, True, Descripcion, Nothing, DetalleHTML)
                End If

                MsgBox("Se Autorizó correctamente la Carta de Acceso.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("No se pudo Autorizar la Carta de Acceso.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

            If Not fn_CartasAccesoConsulta_LlenarLista(lsv_Catalogo, cmb_Empleado.SelectedValue, dtp_FechaDesde.Value, dtp_FechaHasta.Value, cmb_Status.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Call Botones()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim FormaValida As New frm_FirmaElectronica
        FormaValida.ShowDialog()

        If FormaValida.Firma Then
            If Cn_Proceso.fn_CartasAccesoConsulta_ActualizarStatus(lsv_Catalogo.SelectedItems(0).Tag, "C") Then
                'MsgBox("Registro modificado.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

            If Not fn_CartasAccesoConsulta_LlenarLista(lsv_Catalogo, cmb_Empleado.SelectedValue, dtp_FechaDesde.Value, dtp_FechaHasta.Value, cmb_Status.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call Botones()
        Else
            MsgBox("No se validó la autorización.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub
End Class