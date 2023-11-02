
Public Class frm_CartaAcceso

    Dim Empresa As String
    Dim AsuntoFalta As String = "POR MEDIO DEL PRESENTE SOLICITO QUE SE LE FACILITE EL ACCESO A LAS INSTALACIONES DE VALORES A LA(S) SIGUIENTE(S) PERSONA(S), YA QUE FALTO EL DIA -DD- DE -MMMMMMMM- DEL PRESENTE AÑO POR MOTIVOS PERSONALES"
    Dim AsuntoNuevoIngreso As String = "POR MEDIO DEL PRESENTE SOLICITO QUE SE LE FACILITE EL ACCESO A LAS INSTALACIONES DE VALORES A LA(S) SIGUIENTE(S) PERSONA(S) DE NUEVO INGRESO. ASÍ MISMO AGRADECERÉ SE REALICEN LOS PROCEDIMIENTOS INDICADOS PARA EL INGRESO, E INFORMEN A LA BREVEDAD POSIBLE CUALQUIER ANOMALIA."
    Dim AsuntoExterno As String = "POR MEDIO DEL PRESENTE SOLICITO QUE SE LE FACILITE EL ACCESO A LAS INSTALACIONES DE VALORES A LA(S) SIGUIENTE(S) PERSONA(S). ASÍ MISMO AGRADECERÉ SE REALICEN LOS PROCEDIMIENTOS INDICADOS PARA EL INGRESO, E INFORMEN A LA BREVEDAD POSIBLE CUALQUIER ANOMALIA."
    Dim AsuntoOtro As String = ""

    Dim tt_Asunto As ToolTip

    Private Sub frm_CartaAcceso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_CartaAcceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tt_Asunto = New ToolTip
        Dim dr As DataRow = Cn_Proceso.fn_CartasAcceso_ObtenerEmpresa
        Empresa = dr("Nombre")

        tbx_Empresa.Text = Empresa
        cmb_Empleado.Actualizar()
        cmb_Autoriza.Actualizar()
        cmb_DirigidoA.Actualizar()
        lsv_PersonasAutorizadas.Columns.Add("Clave")
        lsv_PersonasAutorizadas.Columns.Add("Nombre")
        lsv_PersonasAutorizadas.Columns.Add("Empresa")

        dtp_Fecha.Value = Today
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LimpiaPantalla()
        tbx_Asunto.Clear()
        cmb_Autoriza.SelectedValue = 0
        btn_Guardar.Enabled = True
        cmb_DirigidoA.SelectedValue = 0
        rdb_Falta.Checked = False
        rdb_NuevoIngreso.Checked = False
        rdb_Otro.Checked = False
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If cmb_Empleado.SelectedValue = 0 Then
            MsgBox("Seleccione Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleado.Focus()
            Exit Sub
        End If
        lsv_PersonasAutorizadas.Items.Add(tbx_ClaveEmpleado.Text)
        lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).Tag = cmb_Empleado.SelectedValue
        lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).SubItems.Add(cmb_Empleado.Text)
        lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).SubItems.Add(tbx_Empresa.Text)

        cmb_Empleado.SelectedValue = 0
        btn_Guardar.Enabled = True
        cmb_Empleado.Focus()
    End Sub

    Private Sub lsv_PersonasAutorizadas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_PersonasAutorizadas.SelectedIndexChanged
        btn_Borrar.Enabled = lsv_PersonasAutorizadas.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.SelectedItems(0).Index).Remove()
        btn_Guardar.Enabled = (lsv_PersonasAutorizadas.Items.Count > 0)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim frm As New frm_Reporte
        Dim Tipo As Integer = 1 'El 2 es para visitantes pero en este Módulo no se utilizará

        If lsv_PersonasAutorizadas.Items.Count = 0 Then
            MsgBox("Debe agregar por lo menos un Empleado para la Autorización.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleado.Focus()
            Exit Sub
        End If
        If dtp_Fecha.Value.Date < DateTime.Now.Date Then
            MsgBox("La Fecha debe ser mayor o igual a hoy.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Fecha.Focus()
            Exit Sub
        End If
        If tbx_Asunto.Text = "" Then
            MsgBox("Capture el Asunto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Asunto.Focus()
            Exit Sub
        End If
        If cmb_Autoriza.SelectedValue = 0 Then
            MsgBox("Seleccione Autoriza.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Autoriza.Focus()
            Exit Sub
        End If

        If cmb_DirigidoA.SelectedValue = 0 Then
            MsgBox("Seleccione Dirigido a.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DirigidoA.Focus()
            Exit Sub
        End If

        Dim ID As Integer = Cn_Proceso.fn_CartasAcceso_Nuevo(tbx_Asunto.Text, cmb_Autoriza.SelectedValue, lsv_PersonasAutorizadas.Items, dtp_Fecha.Value, dtp_Fecha.Value, Tipo, cmb_DirigidoA.SelectedValue)
        If ID > 0 Then
            'frm.crv.ReportSource = Cn_Proceso.fn_CartasAcceso_GeneraReporte(ID)
            'frm.ShowDialog()
            'ENVIAR LA ALERTA
            MsgBox("Registro Guardado Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            lsv_PersonasAutorizadas.Items.Clear()
            Call LimpiaPantalla()
            btn_Guardar.Enabled = False
            dtp_Fecha.Value = Today
            cmb_Empleado.Focus()
        Else
            MsgBox("No se pudo Generar la Carta de Acceso.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub rdb_Empleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbx_Asunto.Clear()
        tbx_Empresa.Text = ""
        tbx_Empresa.ReadOnly = False
        cmb_Empleado.SelectedValue = 0
        lbl_Empleado.Enabled = False
        tbx_ClaveEmpleado.Enabled = False
        cmb_Empleado.Enabled = False
    End Sub

    Private Sub rdb_Falta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Falta.CheckedChanged
        If rdb_Falta.Checked Then
            tbx_Asunto.Text = AsuntoFalta
        End If
    End Sub

    Private Sub rdb_NuevoIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_NuevoIngreso.CheckedChanged
        If rdb_NuevoIngreso.Checked Then
            tbx_Asunto.Text = AsuntoNuevoIngreso
            tt_Asunto.IsBalloon = True
            tt_Asunto.ToolTipIcon = ToolTipIcon.Warning
            tt_Asunto.ToolTipTitle = "Atención"
        End If
    End Sub

    Private Sub rdb_Otro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Otro.CheckedChanged
        If rdb_Otro.Checked Then
            tbx_Asunto.Text = AsuntoOtro
        End If
    End Sub

    Private Sub GroupBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbx_Personalizar.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

End Class

