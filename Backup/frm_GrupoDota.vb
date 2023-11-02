
Public Class frm_GrupoDota

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_GrupoDota_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0
        cmb_CajaBancaria.Actualizar()
        cmb_CajaBancaria1.Actualizar()
        lsv_Catalogo.Columns.Add("Descripcion")
        lsv_Catalogo.Columns.Add("Status")
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        BTN_Exportar.Enabled = False
        lsv_Catalogo.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        If cmb_CajaBancaria.SelectedValue = 0 Then Exit Sub
        FuncionesGlobales.fn_Menu_Progreso(70)
        Call Cn_Proceso.fn_GrupoDota_LlenarLista(lsv_Catalogo, lsv_Catalogo.Lvs, cmb_CajaBancaria.SelectedValue)
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        FuncionesGlobales.fn_Menu_Progreso(100)
        FuncionesGlobales.fn_Menu_Progreso(0)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        tbx_Descripcion.Clear()
        Tab_Catalogo.SelectedTab = tab_Listado
        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click, Me.F2
        SegundosDesconexion = 0
        If cmb_CajaBancaria1.SelectedValue = 0 Then
            MsgBox("Seleccione al Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria1.Focus()
            Exit Sub
        End If
        If tbx_Descripcion.Text.Trim = "" Then
            MsgBox("Indique la Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If
        If Cn_Proceso.fn_GrupoDota_ValidarDescripcion(tbx_Descripcion.Text.Trim, cmb_CajaBancaria1.SelectedValue) Then
            MsgBox("La Descripcion que capturó ya existe", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        If Tab_Nuevo.Text = "Nuevo" Then
            'Si se esta Insertando
            If Cn_Proceso.fn_GrupoDota_Nuevo(tbx_Descripcion.Text.Trim, cmb_CajaBancaria1.SelectedValue) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                tbx_Descripcion.Clear()
                FuncionesGlobales.fn_Menu_Progreso(60)
                Call LlenarLista()
            Else
                MsgBox("No se pudo agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            'Si se esta actualizando
            If Cn_Proceso.fn_GrupoDota_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Descripcion.Text.Trim) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                tbx_Descripcion.Clear()
                Tab_Nuevo.Text = "Nuevo"
                Tab_Catalogo.SelectedTab = tab_Listado
                FuncionesGlobales.fn_Menu_Progreso(60)
                Call LlenarLista()
            Else
                MsgBox("No se pudo editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        End If
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        SegundosDesconexion = 0
        Call Buscar()
    End Sub

    Sub Buscar()
        SegundosDesconexion = 0
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        If FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio) Then
            Btn_Baja.Enabled = True
            BTN_Modificar.Enabled = True
        Else
            Btn_Baja.Enabled = False
            BTN_Modificar.Enabled = False
        End If
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Dim dt As DataTable = Cn_Proceso.fn_GrupoDota_ObtenValores(lsv_Catalogo.SelectedItems(0).Tag)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            tbx_Descripcion.Text = dt.Rows(0)("Descripcion")
            cmb_CajaBancaria.SelectedValue = dt.Rows(0)("Id_CajaBancaria")
        End If
        Tab_Nuevo.Text = "Modificar"
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0
        If lsv_Catalogo.SelectedItems(0).SubItems(2).Text = "ACTIVO" Then
            Cn_Proceso.fn_GrupoDota_Baja(lsv_Catalogo.SelectedItems(0).Tag)
        Else
            Cn_Proceso.fn_GrupoDota_Alta(lsv_Catalogo.SelectedItems(0).Tag)
        End If
        Call LlenarLista()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
        BTN_Modificar.Enabled = (lsv_Catalogo.SelectedItems.Count > 0)
        Btn_Baja.Enabled = (lsv_Catalogo.SelectedItems.Count > 0)
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0
        Cn_Proceso.fn_GrupoDota_LlenarLista(lsv_Catalogo, lsv_Catalogo.Lvs, cmb_CajaBancaria.SelectedValue)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        BTN_Modificar.Enabled = (lsv_Catalogo.SelectedItems.Count > 0)
        Btn_Baja.Enabled = (lsv_Catalogo.SelectedItems.Count > 0)
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            Call Buscar()
        End If
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_CajaBancaria1.SelectedValue = cmb_CajaBancaria.SelectedValue
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la Variable de Desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
        cmb_CajaBancaria1.Focus()
    End Sub
End Class