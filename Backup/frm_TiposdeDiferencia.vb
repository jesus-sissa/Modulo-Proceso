
Public Class frm_TiposdeDiferencia

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_TiposdeDiferencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  
        cmb_TipoDiferencia.AgregarItem("1", "FALTANTES")
        cmb_TipoDiferencia.AgregarItem("2", "SOBRANTE")

        cmb_TipoDiferenciaNew.AgregarItem("1", "FALTANTES")
        cmb_TipoDiferenciaNew.AgregarItem("2", "SOBRANTE")

        lsv_Catalogo.Columns.Add("Tipo")
        lsv_Catalogo.Columns.Add("Descripcion")
        lsv_Catalogo.Columns.Add("Status")

    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        lsv_Catalogo.Items.Clear()
        FuncionesGlobales.fn_Menu_Progreso(70)

        Call Cn_Proceso.fn_TipoDiferencia_LlenarLista(lsv_Catalogo, cmb_TipoDiferencia.SelectedValue)

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
        If cmb_TipoDiferenciaNew.SelectedValue = 0 Then
            MsgBox("Seleccione el tipo de Diferencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoDiferenciaNew.Focus()
            Exit Sub
        End If

        If tbx_Descripcion.Text.Trim = "" Then
            MsgBox("Indique la Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        If Cn_Proceso.fn_TipoDiferencia_ValidarDescripcion(tbx_Descripcion.Text.Trim, cmb_TipoDiferenciaNew.SelectedValue) Then
            MsgBox("La Descripcion que capturó ya existe", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        If Tab_Nuevo.Text = "Nuevo" Then
            'Si se esta Insertando
            If Cn_Proceso.fn_TipoDirefencia_Nuevo(tbx_Descripcion.Text.Trim, cmb_TipoDiferenciaNew.SelectedValue) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                tbx_Descripcion.Clear()
                FuncionesGlobales.fn_Menu_Progreso(60)
                Call LlenarLista()
                cmb_TipoDiferencia.SelectedValue = "0"
            Else
                MsgBox("No se pudo agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            ''Si se esta actualizando
            If Cn_Proceso.fn_TipoDirefencia_Actualizar(cmb_TipoDiferenciaNew.SelectedValue, tbx_Descripcion.Text.Trim, cmb_TipoDiferenciaNew.Tag) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                tbx_Descripcion.Clear()
                Tab_Nuevo.Text = "Nuevo"
                Tab_Catalogo.SelectedTab = tab_Listado
                FuncionesGlobales.fn_Menu_Progreso(60)
                Call LlenarLista()
                cmb_TipoDiferencia.SelectedValue = "0"
            Else
                MsgBox("No se pudo editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        End If
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Dim dt As DataTable = Cn_Proceso.fn_TipoDiferencia_ObtenValores(lsv_Catalogo.SelectedItems(0).Tag)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            tbx_Descripcion.Text = dt.Rows(0)("Descripcion")
            cmb_TipoDiferenciaNew.SelectedValue = dt.Rows(0)("Tipo")
            cmb_TipoDiferenciaNew.Tag = dt.Rows(0)("Id_TipoDiferencia")
        End If
        Tab_Nuevo.Text = "Modificar"
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        If lsv_Catalogo.SelectedItems(0).SubItems(2).Text = "ACTIVO" Then
            Cn_Proceso.fn_TipoDiferencia_Baja(lsv_Catalogo.SelectedItems(0).Tag)
        Else
            Cn_Proceso.fn_TipoDiferencia_Alta(lsv_Catalogo.SelectedItems(0).Tag)
        End If
        Call LlenarLista()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        BTN_Modificar.Enabled = (lsv_Catalogo.SelectedItems.Count > 0)
        Btn_Baja.Enabled = (lsv_Catalogo.SelectedItems.Count > 0)
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la Variable de Desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged

        If Tab_Catalogo.SelectedIndex = 1 Then
            cmb_TipoDiferenciaNew.Focus()
        Else
            SegundosDesconexion = 0
            tbx_Descripcion.Clear()
            Tab_Nuevo.Text = "Nuevo"
            lsv_Catalogo.SelectedItems.Clear()

            Tab_Catalogo.SelectedTab = tab_Listado

        End If
    End Sub

    Private Sub cmb_TipoDiferencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDiferencia.SelectedIndexChanged
        If cmb_TipoDiferencia.SelectedValue = "0" Then
            lsv_Catalogo.Items.Clear()
            BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
            btn_Guardar.Enabled = lsv_Catalogo.Items.Count > 0
            Btn_Baja.Enabled = lsv_Catalogo.Items.Count > 0
            BTN_Modificar.Enabled = lsv_Catalogo.Items.Count > 0
            FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
            Exit Sub
        End If
        Call LlenarLista()
    End Sub
End Class