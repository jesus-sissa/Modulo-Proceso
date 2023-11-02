<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AbrirSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AbrirSesion))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.Btn_Eliminar = New System.Windows.Forms.Button
        Me.ils_Sesion = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl_TxtStatus = New System.Windows.Forms.TextBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.lbl_TxtFecha = New System.Windows.Forms.TextBox
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.lbl_TxtSupervisor = New System.Windows.Forms.TextBox
        Me.lbl_Supervisor = New System.Windows.Forms.Label
        Me.lbl_Sesion = New System.Windows.Forms.Label
        Me.Lbl_TxtSesion = New System.Windows.Forms.TextBox
        Me.gbx_Pendientes = New System.Windows.Forms.GroupBox
        Me.gbx_Principal = New System.Windows.Forms.GroupBox
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lsv_Pendientes = New Modulo_Proceso.cp_Listview
        Me.gbx_Pendientes.SuspendLayout()
        Me.gbx_Principal.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.ImageList = Me.ils_Sesion
        Me.Btn_Eliminar.Location = New System.Drawing.Point(6, 13)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Eliminar.TabIndex = 8
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'ils_Sesion
        '
        Me.ils_Sesion.ImageStream = CType(resources.GetObject("ils_Sesion.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ils_Sesion.TransparentColor = System.Drawing.Color.Transparent
        Me.ils_Sesion.Images.SetKeyName(0, "encrypted.png")
        Me.ils_Sesion.Images.SetKeyName(1, "decrypted.png")
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
        Me.gbx_Pendientes.Location = New System.Drawing.Point(9, 212)
        Me.gbx_Pendientes.Name = "gbx_Pendientes"
        Me.gbx_Pendientes.Size = New System.Drawing.Size(466, 321)
        Me.gbx_Pendientes.TabIndex = 0
        Me.gbx_Pendientes.TabStop = False
        Me.gbx_Pendientes.Text = "Pendientes"
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
        Me.gbx_Principal.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Principal.Name = "gbx_Principal"
        Me.gbx_Principal.Size = New System.Drawing.Size(466, 202)
        Me.gbx_Principal.TabIndex = 2
        Me.gbx_Principal.TabStop = False
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.Btn_Eliminar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 539)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(466, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(322, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 9
        Me.btn_Cerrar.Text = "&Cerrar Ventana"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lsv_Pendientes
        '
        Me.lsv_Pendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Pendientes.FullRowSelect = True
        Me.lsv_Pendientes.HideSelection = False
        Me.lsv_Pendientes.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Pendientes.Lvs = ListViewColumnSorter1
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
        Me.lsv_Pendientes.Size = New System.Drawing.Size(460, 302)
        Me.lsv_Pendientes.TabIndex = 0
        Me.lsv_Pendientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Pendientes.View = System.Windows.Forms.View.Details
        '
        'frm_AbrirSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 591)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Principal)
        Me.Controls.Add(Me.gbx_Pendientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "frm_AbrirSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sesion"
        Me.gbx_Pendientes.ResumeLayout(False)
        Me.gbx_Principal.ResumeLayout(False)
        Me.gbx_Principal.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents Lbl_TxtSesion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_TxtSupervisor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Supervisor As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents ils_Sesion As System.Windows.Forms.ImageList
    Friend WithEvents gbx_Pendientes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Pendientes As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Principal As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
End Class
