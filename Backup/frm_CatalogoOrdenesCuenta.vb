Imports Modulo_Proceso.Cn_Proceso
Public Class frm_CatalogoOrdenesCuentas

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If CInt(btn_Guardar.Tag) = 0 Then 'Guardar

            If Not Validar() Then
                Exit Sub
            End If

            If Not fn_BanorteClientes_Create(tbx_Cuenta.Text, tbx_Cliente.Text, cmb_CajaBancaria.SelectedValue) Then
                MsgBox("Ocurrió un error al intentar guardar dato.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
            MsgBox("Se guardó con éxito..", MsgBoxStyle.Information, frm_MENU.Text)
        ElseIf CInt(btn_Guardar.Tag) = 1 Then 'Modificar
            btn_Cancelar.Enabled = False
            btn_Guardar.Tag = 0
            tbx_Cliente.Enabled = True
            If Not fn_BanorteClientes_Update(cmb_CajaBancaria.SelectedValue, tbx_Cliente.Text, lsv_CuentasClientes.SelectedItems(0).Tag) Then
                MsgBox("Ocurrió un error al intentar guardar dato.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
            MsgBox("Se actualizó  con éxito..", MsgBoxStyle.Information, frm_MENU.Text)
        End If
        Limpiar()
        CargarLista()
    End Sub

    Private Function Validar() As Boolean
   
        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Seleccione una Caja Bancaria, porvafor", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Function
            Return False
        End If

        If tbx_Cliente.Text = "" Then
            MsgBox("Debe escribir un nombre de Cliente", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Function
            Return False
        End If

        If tbx_Cuenta.Text = "" Then
            MsgBox("Debe escribir una Cuenta.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Function
            Return False
        End If
        Return True
    End Function

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        btn_Cancelar.Enabled = True
        tbx_Cuenta.Enabled = False
        btn_Guardar.Tag = 1
        tbx_Cuenta.Text = lsv_CuentasClientes.SelectedItems(0).Text
        tbx_Cliente.Text = lsv_CuentasClientes.SelectedItems(0).SubItems(1).Text
        cmb_CajaBancaria.SelectedValue = IIf(lsv_CuentasClientes.SelectedItems(0).SubItems(4).Text = "", 0, lsv_CuentasClientes.SelectedItems(0).SubItems(4).Text)
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        Dim Status As String = ""
        If lsv_CuentasClientes.SelectedItems.Count = 0 Then Exit Sub
        If lsv_CuentasClientes.SelectedItems(0).SubItems(3).Text = "ACTIVO" Then Status = "B"
        If lsv_CuentasClientes.SelectedItems(0).SubItems(3).Text = "BAJA" Then Status = "A"
        btn_Cancelar.Enabled = True

        If Not fn_BanorteClientes_Baja(lsv_CuentasClientes.SelectedItems(0).Tag, Status) Then
            MsgBox("Ocurrió un error al intentar dar de baja el Cliente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        CargarLista()

    End Sub


    Private Sub btn_CerrarExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerrarExp.Click
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        btn_Guardar.Tag = 0
        btn_Cancelar.Enabled = False
        Limpiar()
    End Sub

    Private Sub lsv_CuentasClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_CuentasClientes.SelectedIndexChanged
        btn_Modificar.Enabled = lsv_CuentasClientes.SelectedItems.Count > 0
        btn_Baja.Enabled = lsv_CuentasClientes.SelectedItems.Count > 0
    End Sub

    Private Sub frm_CatalogoOrdenesCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_CajaBancaria.Actualizar()
        CargarLista()
    End Sub

    Public Sub Limpiar()
        cmb_CajaBancaria.SelectedValue = 0
        tbx_Cliente.Text = String.Empty
        tbx_Cuenta.Text = String.Empty
    End Sub

    Public Sub CargarLista()
        fn_BanorteClientes_Get("T", lsv_CuentasClientes)
        lsv_CuentasClientes.Columns(4).Width = 0
    End Sub
End Class