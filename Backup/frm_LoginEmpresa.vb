Public Class frm_LoginEmpresa

    Private Sub cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancel.Click
        BanderA = False
        Me.Close()
        'Application.Exit()
    End Sub

    Private Sub frm_LoginEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = FuncionesGlobales.fn_CargaCombo(cmb_Empresa, Cn_Login.Empresas_Consultar(), "Id_Empresa", "Nombre")
        If Not BanderA Then
            MsgBox("Ocurrió un error al intentar mostrar las Empresas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If UsuarioTipo = 3 Or UsuarioTipo = 4 Then
            cmb_Empresa.SelectedValue = EmpresaId
            cmb_Empresa.Enabled = False
        ElseIf UsuarioTipo = 5 Then
            cmb_Empresa.Enabled = True
        End If
    End Sub

    Private Sub cmb_Empresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Empresa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmb_Sucursal.Focus()
        End If
    End Sub

    Private Sub cmb_Empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empresa.SelectedIndexChanged
        'If cmb_Empresa.SelectedValue < 1 Then Exit Sub
        BanderA = FuncionesGlobales.fn_CargaCombo(cmb_Sucursal, Cn_Login.Sucursales_Consultar(cmb_Empresa.SelectedValue), "Id_Sucursal", "Nombre")
        If Not BanderA Then
            MsgBox("Ocurrió un error al intentar mostrar las Sucursales.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub cmd_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_OK.Click
        Call Validar()
    End Sub

    Sub Validar()
        BanderA = False
        If cmb_Empresa.SelectedValue = 0 Then
            MsgBox("Seleccione una Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            If cmb_Empresa.Enabled Then cmb_Empresa.Focus()
            Exit Sub
        End If
        If cmb_Sucursal.SelectedValue = 0 Then
            MsgBox("Seleccione una Sucursal.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Sucursal.Focus()
            Exit Sub
        End If
        EmpresaId = cmb_Empresa.SelectedValue
        SucursalId = cmb_Sucursal.SelectedValue
        BanderA = True
        Me.Close()
    End Sub

    Private Sub cmb_Sucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Sucursal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Validar()
        End If
    End Sub
End Class