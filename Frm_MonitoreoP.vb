Imports Modulo_Proceso.Cn_Proceso
Public Class Frm_MonitoreoP
    'Private Id_Sesion As Integer = 0
    Private Abierto As Boolean
    'recoleccion
    Private recRecibidos As Integer = 0
    Private recAsignadosProceso As Integer = 0
    'Proceso
    Private proRecibidos As Integer = 0
    Private procAsignadosCajeros As Integer = 0
    Private RecibidosCajeros As Integer = 0

    Private Iniciados As Integer = 0
    Private Verificados As Integer = 0
    Private Contabilizados As Integer = 0

    Private change As Boolean = False


    Private Sub Frm_MonitoreoP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tmr_Hora.Start()
        Monitoreo()
        'Me.btn_proc_recibidoscajeros.BackColor = Color.FromArgb(251, 220, 38)
        'Me.btn_proc_recibidoscajeros.ForeColor = Color.White
        'Me.btn_proc_iniciados.BackColor = Color.FromArgb(47, 179, 68)
        'Me.btn_proc_iniciados.ForeColor = Color.White
        'Me.btn_proc_verificados.BackColor = Color.FromArgb(47, 179, 68)
        'Me.btn_proc_verificados.ForeColor = Color.White
        'Me.btn_proc_contabilizados.BackColor = Color.FromArgb(47, 179, 68)
        'Me.btn_proc_contabilizados.ForeColor = Color.White


    End Sub

    Sub Monitoreo()
        SegundosDesconexion = 0
        Try

            Verificar()

            recRecibidos = fn_AsignarProcesoLlenalista()
            btn_rec_recibidos.Text = recRecibidos.ToString()
            recAsignadosProceso = fn_RecibirLotesBoveda_Monitoreo()
            btn_rec_asignadosproceso.Text = recAsignadosProceso.ToString()

            proRecibidos = fn_AsignarServicios_Monitoreo()
            btn_proc_recibidos.Text = proRecibidos.ToString()
            procAsignadosCajeros = fn_RecibirServicio_Monitoreo()
            btn_proc_asignadoscajero.Text = procAsignadosCajeros.ToString()
            RecibidosCajeros = fn_RecibirServicioV_Monitoreo()
            btn_proc_recibidoscajeros.Text = RecibidosCajeros.ToString()

            Iniciados = fn_RecibirServicioI_Monitoreo()
            btn_proc_iniciados.Text = Iniciados.ToString()
            Verificados = fn_RecibirServicioVE_Monitoreo()
            btn_proc_verificados.Text = Verificados.ToString()
            Contabilizados = fn_RecibirServicioCO_Monitoreo()
            btn_proc_contabilizados.Text = Contabilizados.ToString()
            proceso.Text = "PROCESO:" + fn_ServiciosTotal_Monitoreo.ToString()


            Dim tbl As DataTable
            tbl = fn_MonitoreoTiempo()
            If (CInt(tbl.Rows(0)("ER")) > 0) Then

                Me.btn_rec_recibidos.BackColor = System.Drawing.Color.FromArgb(214, 57, 57)
                btn_rec_recibidos.ForeColor = Color.White
            Else
                If recRecibidos > 0 Then
                    btn_rec_recibidos.BackColor = Color.FromArgb(47, 179, 68)
                    btn_rec_recibidos.ForeColor = Color.White
                Else
                    btn_rec_recibidos.BackColor = Color.White
                    btn_rec_recibidos.ForeColor = Color.FromArgb(30, 41, 59)
                End If

            End If
            If (CInt(tbl.Rows(0)("EP")) > 0) Then
                Me.btn_rec_asignadosproceso.BackColor = System.Drawing.Color.FromArgb(214, 57, 57)
                btn_rec_asignadosproceso.ForeColor = Color.White
            Else
                If recAsignadosProceso > 0 Then
                    btn_rec_asignadosproceso.BackColor = Color.FromArgb(47, 179, 68)
                    btn_rec_asignadosproceso.ForeColor = System.Drawing.Color.White
                Else
                    btn_rec_asignadosproceso.BackColor = Color.White
                    btn_rec_asignadosproceso.ForeColor = Color.FromArgb(30, 41, 59)
                End If

            End If
            If (CInt(tbl.Rows(0)("RP")) > 0) Then
                Me.btn_proc_recibidos.BackColor = System.Drawing.Color.FromArgb(214, 57, 57)
                Me.btn_proc_recibidos.ForeColor = Color.White
            Else
                If proRecibidos > 0 Then
                    btn_proc_recibidos.BackColor = Color.FromArgb(47, 179, 68)
                    btn_proc_recibidos.ForeColor = System.Drawing.Color.White
                Else
                    btn_proc_recibidos.BackColor = Color.White
                    btn_proc_recibidos.ForeColor = Color.FromArgb(30, 41, 59)
                End If


            End If
            If (CInt(tbl.Rows(0)("AC")) > 0) Then
                Me.btn_proc_asignadoscajero.BackColor = System.Drawing.Color.FromArgb(214, 57, 57)
                Me.btn_proc_asignadoscajero.ForeColor = Color.White
            Else
                If procAsignadosCajeros > 0 Then
                    btn_proc_asignadoscajero.BackColor = Color.FromArgb(47, 179, 68)
                    btn_proc_asignadoscajero.ForeColor = System.Drawing.Color.White
                Else
                    btn_proc_asignadoscajero.BackColor = Color.White
                    btn_proc_asignadoscajero.ForeColor = Color.FromArgb(30, 41, 59)
                End If

            End If

            If RecibidosCajeros <> (Iniciados + Verificados + Contabilizados) Then
                btn_proc_recibidoscajeros.BackColor = System.Drawing.Color.FromArgb(214, 57, 57)
                btn_proc_recibidoscajeros.ForeColor = Color.White
            Else
                If RecibidosCajeros > 0 Then
                    Me.btn_proc_recibidoscajeros.BackColor = Color.FromArgb(47, 179, 68)
                    Me.btn_proc_recibidoscajeros.ForeColor = Color.White
                Else
                    Me.btn_proc_recibidoscajeros.BackColor = Color.White
                    Me.btn_proc_recibidoscajeros.ForeColor = Color.FromArgb(30, 41, 59)
                End If

            End If

            If Iniciados > 0 Then
                Me.btn_proc_iniciados.BackColor = Color.FromArgb(47, 179, 68)
                Me.btn_proc_iniciados.ForeColor = Color.White
            Else
                Me.btn_proc_iniciados.BackColor = Color.White
                Me.btn_proc_iniciados.ForeColor = Color.FromArgb(30, 41, 59)
            End If
            If Verificados > 0 Then
                Me.btn_proc_verificados.BackColor = Color.FromArgb(47, 179, 68)
                Me.btn_proc_verificados.ForeColor = Color.White
            Else
                Me.btn_proc_verificados.BackColor = Color.White
                Me.btn_proc_verificados.ForeColor = Color.FromArgb(30, 41, 59)
            End If

            If Contabilizados > 0 Then
                Me.btn_proc_contabilizados.BackColor = Color.FromArgb(47, 179, 68)
                Me.btn_proc_contabilizados.ForeColor = Color.White
            Else
                Me.btn_proc_contabilizados.BackColor = Color.White
                Me.btn_proc_contabilizados.ForeColor = Color.FromArgb(30, 41, 59)
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

                lbl_TxtStatus.BackColor = Color.FromArgb(116, 184, 22)
                lbl_TxtStatus.ForeColor = Color.White
                Abierto = True
            Else

                lbl_TxtStatus.BackColor = Color.FromArgb(214, 57, 57)
                Abierto = False
            End If
            If CInt(row("Id_Sesion").ToString) > SesionId Then
                SesionId = CInt(row("Id_Sesion").ToString)
            End If
        Else
                Lbl_TxtSesion.Text = 0

            Abierto = False
        End If
        If Abierto Then fn_AbrirSesion_LlenarLista(lsv_Pendientes)
    End Sub
    Dim cont As Integer
    Private Sub tmr_Hora_Tick(sender As Object, e As EventArgs) Handles tmr_Hora.Tick
        GroupBox3.Text = "SESION-" + System.DateTime.Now.ToLongTimeString
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

    Private Sub Frm_MonitoreoP_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Timer1.Stop()
        tmr_Hora.Stop()
    End Sub
End Class