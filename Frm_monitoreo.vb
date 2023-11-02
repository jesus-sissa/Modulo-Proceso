Imports Modulo_Proceso.Cn_Proceso
Public Class Frm_monitoreo
    Private Id_Sesion As Integer = 0
    Private Abierto As Boolean
    Private Sub Frm_monitoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Monitoreo()

    End Sub
    Sub Monitoreo()
        SegundosDesconexion = 0
        Try
            Timer1.Enabled = True
            tmr_Hora.Enabled = True
            Verificar()
            Button1.Text = "Recibidos : " + fn_AsignarProcesoLlenalista().ToString()
            Button2.Text = "Asignados a proceso: " + fn_RecibirLotesBoveda_Monitoreo().ToString()
            Button3.Text = "Recibidos : " + fn_AsignarServicios_Monitoreo().ToString()
            Button4.Text = "Asignados a cajero: " + fn_RecibirServicio_Monitoreo().ToString
            Button5.Text = "Recibidos por cajero: " + fn_RecibirServicioV_Monitoreo().ToString
            Button6.Text = "Iniciados: " + fn_RecibirServicioI_Monitoreo.ToString()
            Button7.Text = "Verificados: " + fn_RecibirServicioVE_Monitoreo.ToString()
            Button8.Text = "Contabilizados: " + fn_RecibirServicioCO_Monitoreo.ToString()
            proceso.Text = "PROCESO:" + fn_ServiciosTotal_Monitoreo.ToString()
            '

            Dim tbl As DataTable
            tbl = fn_MonitoreoTiempo()
            If (CInt(tbl.Rows(0)("ER")) > 0) Then
                Me.Button1.BackColor = System.Drawing.Color.Red
            Else
                Button1.BackColor = GroupBox1.BackColor
            End If
            If (CInt(tbl.Rows(0)("EP")) > 0) Then
                Me.Button2.BackColor = System.Drawing.Color.Red
            Else
                Button1.BackColor = GroupBox1.BackColor
            End If
            If (CInt(tbl.Rows(0)("RP")) > 0) Then
                Me.Button3.BackColor = System.Drawing.Color.Red
            Else
                Button1.BackColor = GroupBox1.BackColor
            End If
            If (CInt(tbl.Rows(0)("AC")) > 0) Then
                Me.Button4.BackColor = System.Drawing.Color.Red
            Else
                Button4.BackColor = GroupBox1.BackColor
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Monitoreo()
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
            'Id_Sesion =  ' row("Id_Sesion")

            Lbl_TxtSesion.Text = row("Numero_Sesion")
            lbl_TxtFecha.Text = row("Fecha_Sesion")
            lbl_TxtSupervisor.Text = row("Supervisor")
            lbl_TxtStatus.Text = row("Status")

            If row("Status") = "ABIERTA" Then

                lbl_TxtStatus.BackColor = Color.Green
                Abierto = True
            Else

                lbl_TxtStatus.BackColor = Color.Red
                Abierto = False
            End If
        Else
            Lbl_TxtSesion.Text = 0

            Abierto = False
        End If
        If Abierto Then fn_AbrirSesion_LlenarLista(lsv_Pendientes)
    End Sub
    Dim cont As Integer
    Private Sub tmr_Hora_Tick(sender As Object, e As EventArgs) Handles tmr_Hora.Tick
        lbl_Hora.Text = Date.Today.ToShortDateString + "   " + System.DateTime.Now.ToLongTimeString
        'If (f1.Visible) Then
        '    f1.Visible = False
        'Else
        '    f1.Visible = True
        'End If

        'If (f2.Visible) Then
        '    f2.Visible = False
        'Else
        '    f2.Visible = True
        'End If

        'If (f3.Visible) Then
        '    f3.Visible = False
        'Else
        '    f3.Visible = True
        'End If
    End Sub

    Private Sub lbl_Hora_Click(sender As Object, e As EventArgs) Handles lbl_Hora.Click
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class