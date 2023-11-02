<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_monitoreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.proceso = New System.Windows.Forms.GroupBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tmr_Hora = New System.Windows.Forms.Timer(Me.components)
        Me.gbx_Principal = New System.Windows.Forms.GroupBox()
        Me.lbl_TxtStatus = New System.Windows.Forms.TextBox()
        Me.lbl_Sesion = New System.Windows.Forms.Label()
        Me.lbl_Supervisor = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_TxtFecha = New System.Windows.Forms.TextBox()
        Me.lbl_TxtSupervisor = New System.Windows.Forms.TextBox()
        Me.Lbl_TxtSesion = New System.Windows.Forms.TextBox()
        Me.gbx_Pendientes = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lsv_Pendientes = New Modulo_Proceso.cp_Listview()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.proceso.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Principal.SuspendLayout()
        Me.gbx_Pendientes.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_Hora)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 749)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1233, 64)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.ForeColor = System.Drawing.Color.Green
        Me.lbl_Hora.Location = New System.Drawing.Point(1113, 16)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(117, 37)
        Me.lbl_Hora.TabIndex = 1
        Me.lbl_Hora.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1233, 24)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 725)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RECEPCION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Modulo_Proceso.My.Resources.Resources.atras_a_la_izquierda
        Me.PictureBox1.Location = New System.Drawing.Point(245, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 133)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Recibidos :"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(16, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(223, 133)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Asignados a proceso :"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'proceso
        '
        Me.proceso.AutoSize = True
        Me.proceso.Controls.Add(Me.PictureBox7)
        Me.proceso.Controls.Add(Me.Button6)
        Me.proceso.Controls.Add(Me.PictureBox5)
        Me.proceso.Controls.Add(Me.Button8)
        Me.proceso.Controls.Add(Me.Button7)
        Me.proceso.Controls.Add(Me.PictureBox4)
        Me.proceso.Controls.Add(Me.PictureBox3)
        Me.proceso.Controls.Add(Me.PictureBox2)
        Me.proceso.Controls.Add(Me.Button5)
        Me.proceso.Controls.Add(Me.Button3)
        Me.proceso.Controls.Add(Me.Button4)
        Me.proceso.Dock = System.Windows.Forms.DockStyle.Left
        Me.proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceso.Location = New System.Drawing.Point(285, 24)
        Me.proceso.Name = "proceso"
        Me.proceso.Size = New System.Drawing.Size(293, 725)
        Me.proceso.TabIndex = 37
        Me.proceso.TabStop = False
        Me.proceso.Text = "PROCESO"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Modulo_Proceso.My.Resources.Resources.atras_a_la_izquierda
        Me.PictureBox7.Location = New System.Drawing.Point(253, 578)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(34, 80)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 35
        Me.PictureBox7.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(45, 369)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(202, 106)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Iniciados:"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Modulo_Proceso.My.Resources.Resources.atras_a_la_izquierda
        Me.PictureBox5.Location = New System.Drawing.Point(253, 467)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(34, 80)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(45, 593)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(202, 106)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "Contabilizados :"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(45, 481)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(202, 106)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "Verificados:"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Modulo_Proceso.My.Resources.Resources.atras_a_la_izquierda
        Me.PictureBox4.Location = New System.Drawing.Point(253, 355)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Modulo_Proceso.My.Resources.Resources.atras_a_la_izquierda
        Me.PictureBox3.Location = New System.Drawing.Point(253, 222)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Modulo_Proceso.My.Resources.Resources.atras_a_la_izquierda
        Me.PictureBox2.Location = New System.Drawing.Point(253, 81)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(45, 257)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 106)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Recibidos por cajero:"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(45, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(202, 106)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Recibidos :"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(45, 145)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(202, 106)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Asignados a cajero:"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'tmr_Hora
        '
        Me.tmr_Hora.Interval = 1000
        '
        'gbx_Principal
        '
        Me.gbx_Principal.Controls.Add(Me.lbl_TxtStatus)
        Me.gbx_Principal.Controls.Add(Me.lbl_Sesion)
        Me.gbx_Principal.Controls.Add(Me.lbl_Supervisor)
        Me.gbx_Principal.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Principal.Controls.Add(Me.lbl_Status)
        Me.gbx_Principal.Controls.Add(Me.lbl_TxtFecha)
        Me.gbx_Principal.Controls.Add(Me.lbl_TxtSupervisor)
        Me.gbx_Principal.Controls.Add(Me.Lbl_TxtSesion)
        Me.gbx_Principal.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbx_Principal.Location = New System.Drawing.Point(3, 31)
        Me.gbx_Principal.Name = "gbx_Principal"
        Me.gbx_Principal.Size = New System.Drawing.Size(649, 202)
        Me.gbx_Principal.TabIndex = 3
        Me.gbx_Principal.TabStop = False
        '
        'lbl_TxtStatus
        '
        Me.lbl_TxtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TxtStatus.Location = New System.Drawing.Point(107, 153)
        Me.lbl_TxtStatus.Name = "lbl_TxtStatus"
        Me.lbl_TxtStatus.ReadOnly = True
        Me.lbl_TxtStatus.Size = New System.Drawing.Size(160, 29)
        Me.lbl_TxtStatus.TabIndex = 7
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sesion.Location = New System.Drawing.Point(45, 16)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(57, 17)
        Me.lbl_Sesion.TabIndex = 0
        Me.lbl_Sesion.Text = "Sesion"
        Me.lbl_Sesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Supervisor
        '
        Me.lbl_Supervisor.AutoSize = True
        Me.lbl_Supervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Supervisor.Location = New System.Drawing.Point(15, 50)
        Me.lbl_Supervisor.Name = "lbl_Supervisor"
        Me.lbl_Supervisor.Size = New System.Drawing.Size(86, 17)
        Me.lbl_Supervisor.TabIndex = 2
        Me.lbl_Supervisor.Text = "Supervisor"
        Me.lbl_Supervisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(45, 114)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(52, 17)
        Me.lbl_Fecha.TabIndex = 4
        Me.lbl_Fecha.Text = "Fecha"
        Me.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(47, 153)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(54, 17)
        Me.lbl_Status.TabIndex = 6
        Me.lbl_Status.Text = "Status"
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_TxtFecha
        '
        Me.lbl_TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TxtFecha.Location = New System.Drawing.Point(107, 114)
        Me.lbl_TxtFecha.Name = "lbl_TxtFecha"
        Me.lbl_TxtFecha.ReadOnly = True
        Me.lbl_TxtFecha.Size = New System.Drawing.Size(160, 29)
        Me.lbl_TxtFecha.TabIndex = 5
        '
        'lbl_TxtSupervisor
        '
        Me.lbl_TxtSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TxtSupervisor.Location = New System.Drawing.Point(107, 50)
        Me.lbl_TxtSupervisor.Multiline = True
        Me.lbl_TxtSupervisor.Name = "lbl_TxtSupervisor"
        Me.lbl_TxtSupervisor.ReadOnly = True
        Me.lbl_TxtSupervisor.Size = New System.Drawing.Size(355, 58)
        Me.lbl_TxtSupervisor.TabIndex = 3
        Me.lbl_TxtSupervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_TxtSesion
        '
        Me.Lbl_TxtSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TxtSesion.ForeColor = System.Drawing.Color.Navy
        Me.Lbl_TxtSesion.Location = New System.Drawing.Point(107, 14)
        Me.Lbl_TxtSesion.Name = "Lbl_TxtSesion"
        Me.Lbl_TxtSesion.ReadOnly = True
        Me.Lbl_TxtSesion.Size = New System.Drawing.Size(79, 29)
        Me.Lbl_TxtSesion.TabIndex = 1
        Me.Lbl_TxtSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbx_Pendientes
        '
        Me.gbx_Pendientes.Controls.Add(Me.lsv_Pendientes)
        Me.gbx_Pendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Pendientes.Location = New System.Drawing.Point(3, 233)
        Me.gbx_Pendientes.Name = "gbx_Pendientes"
        Me.gbx_Pendientes.Size = New System.Drawing.Size(649, 489)
        Me.gbx_Pendientes.TabIndex = 4
        Me.gbx_Pendientes.TabStop = False
        Me.gbx_Pendientes.Text = "Pendientes"
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.Controls.Add(Me.gbx_Pendientes)
        Me.GroupBox5.Controls.Add(Me.gbx_Principal)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(578, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(655, 725)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SESSION"
        '
        'lsv_Pendientes
        '
        Me.lsv_Pendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Pendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Pendientes.FullRowSelect = True
        Me.lsv_Pendientes.HideSelection = False
        Me.lsv_Pendientes.Location = New System.Drawing.Point(3, 31)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Pendientes.Lvs = ListViewColumnSorter2
        Me.lsv_Pendientes.MultiSelect = False
        Me.lsv_Pendientes.Name = "lsv_Pendientes"
        Me.lsv_Pendientes.Row1 = 15
        Me.lsv_Pendientes.Row10 = 0
        Me.lsv_Pendientes.Row2 = 80
        Me.lsv_Pendientes.Row3 = 0
        Me.lsv_Pendientes.Row4 = 0
        Me.lsv_Pendientes.Row5 = 0
        Me.lsv_Pendientes.Row6 = 0
        Me.lsv_Pendientes.Row7 = 0
        Me.lsv_Pendientes.Row8 = 0
        Me.lsv_Pendientes.Row9 = 0
        Me.lsv_Pendientes.Size = New System.Drawing.Size(643, 455)
        Me.lsv_Pendientes.TabIndex = 0
        Me.lsv_Pendientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Pendientes.View = System.Windows.Forms.View.Details
        '
        'Frm_monitoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 813)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.proceso)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Frm_monitoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_monitoreo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.proceso.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Principal.ResumeLayout(False)
        Me.gbx_Principal.PerformLayout()
        Me.gbx_Pendientes.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents proceso As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents tmr_Hora As Timer
    Friend WithEvents lbl_Hora As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents gbx_Principal As GroupBox
    Friend WithEvents lbl_TxtStatus As TextBox
    Friend WithEvents lbl_Sesion As Label
    Friend WithEvents lbl_Supervisor As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Status As Label
    Friend WithEvents lbl_TxtFecha As TextBox
    Friend WithEvents lbl_TxtSupervisor As TextBox
    Friend WithEvents Lbl_TxtSesion As TextBox
    Friend WithEvents gbx_Pendientes As GroupBox
    Friend WithEvents lsv_Pendientes As cp_Listview
    Friend WithEvents GroupBox5 As GroupBox
End Class
