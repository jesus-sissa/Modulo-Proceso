<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_MonitoreoP
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tlp_Recepcion = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_rec_asignadosproceso = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.proceso = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_pro_recibidos = New System.Windows.Forms.Label()
        Me.btn_proc_recibidos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_proc_asignadoscajero = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_proc_recibidoscajeros = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_proc_iniciados = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_proc_verificados = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_proc_contabilizados = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbl_TxtSupervisor = New System.Windows.Forms.TextBox()
        Me.Lbl_TxtSesion = New System.Windows.Forms.TextBox()
        Me.lbl_TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lsv_Pendientes = New Modulo_Proceso.cp_Listview()
        Me.lbl_TxtStatus = New System.Windows.Forms.TextBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Supervisor = New System.Windows.Forms.Label()
        Me.lbl_Sesion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_Hora = New System.Windows.Forms.Timer(Me.components)
        Me.btn_rec_recibidos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tlp_Recepcion.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.proceso.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.proceso, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1254, 981)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.tlp_Recepcion)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1248, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RECEPCION"
        '
        'tlp_Recepcion
        '
        Me.tlp_Recepcion.ColumnCount = 3
        Me.tlp_Recepcion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_Recepcion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_Recepcion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_Recepcion.Controls.Add(Me.Panel7, 0, 0)
        Me.tlp_Recepcion.Controls.Add(Me.Panel8, 1, 0)
        Me.tlp_Recepcion.Controls.Add(Me.Panel10, 2, 0)
        Me.tlp_Recepcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Recepcion.Location = New System.Drawing.Point(3, 45)
        Me.tlp_Recepcion.Name = "tlp_Recepcion"
        Me.tlp_Recepcion.RowCount = 1
        Me.tlp_Recepcion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Recepcion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.tlp_Recepcion.Size = New System.Drawing.Size(1242, 191)
        Me.tlp_Recepcion.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.btn_rec_recibidos)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(408, 185)
        Me.Panel7.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(97, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 43)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Recibidos"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.btn_rec_asignadosproceso)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(417, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(408, 185)
        Me.Panel8.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(25, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 43)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Asignados a Proceso"
        '
        'btn_rec_asignadosproceso
        '
        Me.btn_rec_asignadosproceso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_rec_asignadosproceso.BackColor = System.Drawing.Color.White
        Me.btn_rec_asignadosproceso.FlatAppearance.BorderSize = 0
        Me.btn_rec_asignadosproceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rec_asignadosproceso.Font = New System.Drawing.Font("Cambria", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rec_asignadosproceso.Location = New System.Drawing.Point(3, 56)
        Me.btn_rec_asignadosproceso.Name = "btn_rec_asignadosproceso"
        Me.btn_rec_asignadosproceso.Size = New System.Drawing.Size(402, 126)
        Me.btn_rec_asignadosproceso.TabIndex = 2
        Me.btn_rec_asignadosproceso.Text = "--"
        Me.btn_rec_asignadosproceso.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(831, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(408, 185)
        Me.Panel10.TabIndex = 2
        '
        'proceso
        '
        Me.proceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.proceso.Controls.Add(Me.TableLayoutPanel2)
        Me.proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.proceso.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.proceso.Location = New System.Drawing.Point(3, 248)
        Me.proceso.Name = "proceso"
        Me.proceso.Size = New System.Drawing.Size(1248, 435)
        Me.proceso.TabIndex = 1
        Me.proceso.TabStop = False
        Me.proceso.Text = "PROCESO"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 45)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1242, 387)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_pro_recibidos)
        Me.Panel1.Controls.Add(Me.btn_proc_recibidos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 187)
        Me.Panel1.TabIndex = 0
        '
        'lbl_pro_recibidos
        '
        Me.lbl_pro_recibidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_pro_recibidos.AutoSize = True
        Me.lbl_pro_recibidos.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pro_recibidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lbl_pro_recibidos.Location = New System.Drawing.Point(106, 9)
        Me.lbl_pro_recibidos.Name = "lbl_pro_recibidos"
        Me.lbl_pro_recibidos.Size = New System.Drawing.Size(185, 43)
        Me.lbl_pro_recibidos.TabIndex = 4
        Me.lbl_pro_recibidos.Text = "Recibidos"
        '
        'btn_proc_recibidos
        '
        Me.btn_proc_recibidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_proc_recibidos.BackColor = System.Drawing.Color.White
        Me.btn_proc_recibidos.FlatAppearance.BorderSize = 0
        Me.btn_proc_recibidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proc_recibidos.Font = New System.Drawing.Font("Cambria", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proc_recibidos.Location = New System.Drawing.Point(3, 55)
        Me.btn_proc_recibidos.Name = "btn_proc_recibidos"
        Me.btn_proc_recibidos.Size = New System.Drawing.Size(401, 129)
        Me.btn_proc_recibidos.TabIndex = 1
        Me.btn_proc_recibidos.Text = "--"
        Me.btn_proc_recibidos.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_proc_asignadoscajero)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(416, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 187)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 43)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Asignados a Cajeros"
        '
        'btn_proc_asignadoscajero
        '
        Me.btn_proc_asignadoscajero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_proc_asignadoscajero.BackColor = System.Drawing.Color.White
        Me.btn_proc_asignadoscajero.FlatAppearance.BorderSize = 0
        Me.btn_proc_asignadoscajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proc_asignadoscajero.Font = New System.Drawing.Font("Cambria", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proc_asignadoscajero.Location = New System.Drawing.Point(3, 55)
        Me.btn_proc_asignadoscajero.Name = "btn_proc_asignadoscajero"
        Me.btn_proc_asignadoscajero.Size = New System.Drawing.Size(402, 129)
        Me.btn_proc_asignadoscajero.TabIndex = 8
        Me.btn_proc_asignadoscajero.Text = "--"
        Me.btn_proc_asignadoscajero.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btn_proc_recibidoscajeros)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(830, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(409, 187)
        Me.Panel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 43)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Recibidos por Cajeros"
        '
        'btn_proc_recibidoscajeros
        '
        Me.btn_proc_recibidoscajeros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_proc_recibidoscajeros.BackColor = System.Drawing.Color.White
        Me.btn_proc_recibidoscajeros.FlatAppearance.BorderSize = 0
        Me.btn_proc_recibidoscajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proc_recibidoscajeros.Font = New System.Drawing.Font("Cambria", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proc_recibidoscajeros.Location = New System.Drawing.Point(3, 55)
        Me.btn_proc_recibidoscajeros.Name = "btn_proc_recibidoscajeros"
        Me.btn_proc_recibidoscajeros.Size = New System.Drawing.Size(403, 132)
        Me.btn_proc_recibidoscajeros.TabIndex = 10
        Me.btn_proc_recibidoscajeros.Text = "--"
        Me.btn_proc_recibidoscajeros.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btn_proc_iniciados)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 196)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(407, 188)
        Me.Panel4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(97, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 41)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Iniciados"
        '
        'btn_proc_iniciados
        '
        Me.btn_proc_iniciados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_proc_iniciados.BackColor = System.Drawing.Color.White
        Me.btn_proc_iniciados.FlatAppearance.BorderSize = 0
        Me.btn_proc_iniciados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proc_iniciados.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proc_iniciados.Location = New System.Drawing.Point(3, 56)
        Me.btn_proc_iniciados.Name = "btn_proc_iniciados"
        Me.btn_proc_iniciados.Size = New System.Drawing.Size(401, 129)
        Me.btn_proc_iniciados.TabIndex = 31
        Me.btn_proc_iniciados.Text = "--"
        Me.btn_proc_iniciados.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.btn_proc_verificados)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(416, 196)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(408, 188)
        Me.Panel5.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(108, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 41)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Verificados"
        '
        'btn_proc_verificados
        '
        Me.btn_proc_verificados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_proc_verificados.BackColor = System.Drawing.Color.White
        Me.btn_proc_verificados.FlatAppearance.BorderSize = 0
        Me.btn_proc_verificados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proc_verificados.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proc_verificados.Location = New System.Drawing.Point(3, 56)
        Me.btn_proc_verificados.Name = "btn_proc_verificados"
        Me.btn_proc_verificados.Size = New System.Drawing.Size(402, 129)
        Me.btn_proc_verificados.TabIndex = 32
        Me.btn_proc_verificados.Text = "--"
        Me.btn_proc_verificados.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.btn_proc_contabilizados)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(830, 196)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(409, 188)
        Me.Panel6.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(77, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 41)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Contabilizados"
        '
        'btn_proc_contabilizados
        '
        Me.btn_proc_contabilizados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_proc_contabilizados.BackColor = System.Drawing.Color.White
        Me.btn_proc_contabilizados.FlatAppearance.BorderSize = 0
        Me.btn_proc_contabilizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proc_contabilizados.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proc_contabilizados.Location = New System.Drawing.Point(3, 56)
        Me.btn_proc_contabilizados.Name = "btn_proc_contabilizados"
        Me.btn_proc_contabilizados.Size = New System.Drawing.Size(403, 129)
        Me.btn_proc_contabilizados.TabIndex = 33
        Me.btn_proc_contabilizados.Text = "--"
        Me.btn_proc_contabilizados.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Panel9)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 689)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1248, 289)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SESION"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.lbl_TxtSupervisor)
        Me.Panel9.Controls.Add(Me.Lbl_TxtSesion)
        Me.Panel9.Controls.Add(Me.lbl_TxtFecha)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.lsv_Pendientes)
        Me.Panel9.Controls.Add(Me.lbl_TxtStatus)
        Me.Panel9.Controls.Add(Me.lbl_Status)
        Me.Panel9.Controls.Add(Me.lbl_Fecha)
        Me.Panel9.Controls.Add(Me.lbl_Supervisor)
        Me.Panel9.Controls.Add(Me.lbl_Sesion)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 37)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1242, 249)
        Me.Panel9.TabIndex = 0
        '
        'lbl_TxtSupervisor
        '
        Me.lbl_TxtSupervisor.BackColor = System.Drawing.Color.White
        Me.lbl_TxtSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_TxtSupervisor.Font = New System.Drawing.Font("Cambria", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TxtSupervisor.Location = New System.Drawing.Point(621, 42)
        Me.lbl_TxtSupervisor.Name = "lbl_TxtSupervisor"
        Me.lbl_TxtSupervisor.ReadOnly = True
        Me.lbl_TxtSupervisor.Size = New System.Drawing.Size(595, 32)
        Me.lbl_TxtSupervisor.TabIndex = 35
        Me.lbl_TxtSupervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_TxtSesion
        '
        Me.Lbl_TxtSesion.BackColor = System.Drawing.Color.White
        Me.Lbl_TxtSesion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lbl_TxtSesion.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TxtSesion.Location = New System.Drawing.Point(218, 42)
        Me.Lbl_TxtSesion.Name = "Lbl_TxtSesion"
        Me.Lbl_TxtSesion.ReadOnly = True
        Me.Lbl_TxtSesion.Size = New System.Drawing.Size(160, 32)
        Me.Lbl_TxtSesion.TabIndex = 34
        Me.Lbl_TxtSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_TxtFecha
        '
        Me.lbl_TxtFecha.BackColor = System.Drawing.Color.White
        Me.lbl_TxtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_TxtFecha.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TxtFecha.Location = New System.Drawing.Point(25, 42)
        Me.lbl_TxtFecha.Name = "lbl_TxtFecha"
        Me.lbl_TxtFecha.ReadOnly = True
        Me.lbl_TxtFecha.Size = New System.Drawing.Size(160, 32)
        Me.lbl_TxtFecha.TabIndex = 33
        Me.lbl_TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(6, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 34)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Pendientes"
        '
        'lsv_Pendientes
        '
        Me.lsv_Pendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Pendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Pendientes.FullRowSelect = True
        Me.lsv_Pendientes.HideSelection = False
        Me.lsv_Pendientes.Location = New System.Drawing.Point(9, 116)
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
        Me.lsv_Pendientes.Size = New System.Drawing.Size(1227, 127)
        Me.lsv_Pendientes.TabIndex = 10
        Me.lsv_Pendientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Pendientes.View = System.Windows.Forms.View.Details
        '
        'lbl_TxtStatus
        '
        Me.lbl_TxtStatus.BackColor = System.Drawing.Color.White
        Me.lbl_TxtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_TxtStatus.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TxtStatus.Location = New System.Drawing.Point(416, 42)
        Me.lbl_TxtStatus.Name = "lbl_TxtStatus"
        Me.lbl_TxtStatus.ReadOnly = True
        Me.lbl_TxtStatus.Size = New System.Drawing.Size(160, 32)
        Me.lbl_TxtStatus.TabIndex = 9
        Me.lbl_TxtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lbl_Status.Location = New System.Drawing.Point(444, 5)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(98, 34)
        Me.lbl_Status.TabIndex = 8
        Me.lbl_Status.Text = "Status"
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lbl_Fecha.Location = New System.Drawing.Point(52, 5)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(92, 34)
        Me.lbl_Fecha.TabIndex = 6
        Me.lbl_Fecha.Text = "Fecha"
        Me.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Supervisor
        '
        Me.lbl_Supervisor.AutoSize = True
        Me.lbl_Supervisor.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Supervisor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lbl_Supervisor.Location = New System.Drawing.Point(615, 5)
        Me.lbl_Supervisor.Name = "lbl_Supervisor"
        Me.lbl_Supervisor.Size = New System.Drawing.Size(159, 34)
        Me.lbl_Supervisor.TabIndex = 4
        Me.lbl_Supervisor.Text = "Supervisor"
        Me.lbl_Supervisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.lbl_Sesion.Location = New System.Drawing.Point(250, 5)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(102, 34)
        Me.lbl_Sesion.TabIndex = 2
        Me.lbl_Sesion.Text = "Sesion"
        Me.lbl_Sesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'tmr_Hora
        '
        Me.tmr_Hora.Interval = 1000
        '
        'btn_rec_recibidos
        '
        Me.btn_rec_recibidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_rec_recibidos.BackColor = System.Drawing.SystemColors.Window
        Me.btn_rec_recibidos.FlatAppearance.BorderSize = 0
        Me.btn_rec_recibidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rec_recibidos.Font = New System.Drawing.Font("Cambria", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rec_recibidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_rec_recibidos.Location = New System.Drawing.Point(3, 56)
        Me.btn_rec_recibidos.Name = "btn_rec_recibidos"
        Me.btn_rec_recibidos.Size = New System.Drawing.Size(402, 126)
        Me.btn_rec_recibidos.TabIndex = 1
        Me.btn_rec_recibidos.Text = "--"
        Me.btn_rec_recibidos.UseVisualStyleBackColor = False
        '
        'Frm_MonitoreoP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 981)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Frm_MonitoreoP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONITOREO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tlp_Recepcion.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.proceso.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents proceso As GroupBox
    Friend WithEvents tlp_Recepcion As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_proc_recibidos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_proc_asignadoscajero As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_proc_recibidoscajeros As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_proc_iniciados As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_proc_verificados As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_proc_contabilizados As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btn_rec_asignadosproceso As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_pro_recibidos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lbl_Sesion As Label
    Friend WithEvents lbl_Supervisor As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_TxtStatus As TextBox
    Friend WithEvents lbl_Status As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lsv_Pendientes As cp_Listview
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tmr_Hora As Timer
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbl_TxtSupervisor As TextBox
    Friend WithEvents Lbl_TxtSesion As TextBox
    Friend WithEvents lbl_TxtFecha As TextBox
    Public WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_rec_recibidos As Button
End Class
