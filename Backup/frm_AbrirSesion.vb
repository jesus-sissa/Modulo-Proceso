Imports Modulo_Proceso.Cn_Proceso

Public Class frm_AbrirSesion
    Private Id_Sesion As Integer = 0
    Private Abierto As Boolean

    Private Sub frm_AbrirSesion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Verificar()
    End Sub

    Sub Verificar()
        Dim row As DataRow = fn_AbrirSesion_Verificar()

        Lbl_TxtSesion.BackColor = Color.White
        lbl_TxtFecha.BackColor = Color.White
        lbl_TxtSupervisor.BackColor = Color.White

        lbl_TxtFecha.ForeColor = Color.Black
        lbl_TxtSupervisor.ForeColor = Color.Black
        lbl_TxtStatus.ForeColor = Color.Black

        If Not row Is Nothing Then
            Id_Sesion = row("Id_Sesion")

            Lbl_TxtSesion.Text = row("Numero_Sesion")
            lbl_TxtFecha.Text = row("Fecha_Sesion")
            lbl_TxtSupervisor.Text = row("Supervisor")
            lbl_TxtStatus.Text = row("Status")

            If row("Status") = "ABIERTA" Then
                Btn_Eliminar.ImageIndex = 0
                Btn_Eliminar.Text = "&Cerrar Sesion"
                lbl_TxtStatus.BackColor = Color.Green
                Abierto = True
            Else
                Btn_Eliminar.ImageIndex = 1
                Btn_Eliminar.Text = "&Abrir Sesion"
                lbl_TxtStatus.BackColor = Color.Red
                Abierto = False
            End If
        Else
            Lbl_TxtSesion.Text = 0
            Btn_Eliminar.ImageIndex = 1
            Btn_Eliminar.Text = "&Abrir Sesion"
            Abierto = False
        End If
        If Abierto Then fn_AbrirSesion_LlenarLista(lsv_Pendientes)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.ShowDialog()
        If Not frm.Firma Then Exit Sub
        Dim Id_Empleado As Integer = CInt(frm.tbx_Empleado.Text)

        If Abierto Then
            'Cerrar Sesión
            fn_AbrirSesion_LlenarLista(lsv_Pendientes)

            For Each item As ListViewItem In lsv_Pendientes.Items
                If CInt(item.Text) > 0 Then
                    MsgBox(UCase("No se se puede cerrar la sesion porque existen " & item.Text & " " & item.SubItems(1).Text), MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Next
            fn_AbrirSesion_Cerrar(Id_Sesion, Id_Empleado)
            lsv_Pendientes.Items.Clear()
            Call Verificar()
        Else
            'Abrir Sesión
            SesionId = fn_AbrirSesion_Abrir(CInt(Lbl_TxtSesion.Text) + 1, Id_Empleado)
            If SesionId <= 0 Then MsgBox("No se pudo abrir la Sesion. Es probable que ya este abierta por otro Usuario.", MsgBoxStyle.Critical, frm_MENU.Text)
            Call Verificar()
        End If
    End Sub

    Private Sub gbx_Principal_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Principal.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Pendientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Pendientes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Pendientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Pendientes.SelectedIndexChanged
        SegundosDesconexion = 0
    End Sub
End Class