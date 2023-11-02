<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecuentoD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RecuentoD))
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Casets = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.gbx_Clientes = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosClientes = New System.Windows.Forms.Label
        Me.gbx_Desglose = New System.Windows.Forms.GroupBox
        Me.gbx_Envases = New System.Windows.Forms.GroupBox
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.spl_Detalles = New System.Windows.Forms.SplitContainer
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.lsv_Deglose = New Modulo_Proceso.cp_Listview
        Me.lsv_Clientes = New Modulo_Proceso.cp_Listview
        Me.lsv_Casets = New Modulo_Proceso.cp_Listview
        Me.gbx_Casets.SuspendLayout()
        Me.gbx_Clientes.SuspendLayout()
        Me.gbx_Desglose.SuspendLayout()
        Me.gbx_Envases.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.spl_Detalles.Panel1.SuspendLayout()
        Me.spl_Detalles.Panel2.SuspendLayout()
        Me.spl_Detalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Casets
        '
        Me.gbx_Casets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Casets.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Casets.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Casets.Controls.Add(Me.lsv_Casets)
        Me.gbx_Casets.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Casets.Location = New System.Drawing.Point(4, 6)
        Me.gbx_Casets.Name = "gbx_Casets"
        Me.gbx_Casets.Size = New System.Drawing.Size(805, 277)
        Me.gbx_Casets.TabIndex = 0
        Me.gbx_Casets.TabStop = False
        Me.gbx_Casets.Text = "Casets"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(639, 15)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(160, 21)
        Me.Lbl_Registros.TabIndex = 53
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(10, 19)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 6
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(53, 13)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(94, 20)
        Me.dtp_Fecha.TabIndex = 5
        '
        'gbx_Clientes
        '
        Me.gbx_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Clientes.Controls.Add(Me.lbl_RegistrosClientes)
        Me.gbx_Clientes.Controls.Add(Me.lsv_Clientes)
        Me.gbx_Clientes.Location = New System.Drawing.Point(4, 287)
        Me.gbx_Clientes.Name = "gbx_Clientes"
        Me.gbx_Clientes.Size = New System.Drawing.Size(805, 146)
        Me.gbx_Clientes.TabIndex = 1
        Me.gbx_Clientes.TabStop = False
        Me.gbx_Clientes.Text = "Clientes"
        '
        'lbl_RegistrosClientes
        '
        Me.lbl_RegistrosClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosClientes.Location = New System.Drawing.Point(639, 12)
        Me.lbl_RegistrosClientes.Name = "lbl_RegistrosClientes"
        Me.lbl_RegistrosClientes.Size = New System.Drawing.Size(160, 21)
        Me.lbl_RegistrosClientes.TabIndex = 53
        Me.lbl_RegistrosClientes.Text = "Registros: 0"
        Me.lbl_RegistrosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Desglose
        '
        Me.gbx_Desglose.Controls.Add(Me.lsv_Deglose)
        Me.gbx_Desglose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Desglose.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Desglose.Name = "gbx_Desglose"
        Me.gbx_Desglose.Size = New System.Drawing.Size(411, 207)
        Me.gbx_Desglose.TabIndex = 2
        Me.gbx_Desglose.TabStop = False
        Me.gbx_Desglose.Text = "Desglose"
        '
        'gbx_Envases
        '
        Me.gbx_Envases.Controls.Add(Me.lsv_Envases)
        Me.gbx_Envases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Envases.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Envases.Name = "gbx_Envases"
        Me.gbx_Envases.Size = New System.Drawing.Size(390, 207)
        Me.gbx_Envases.TabIndex = 3
        Me.gbx_Envases.TabStop = False
        Me.gbx_Envases.Text = "Envases"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 644)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(807, 50)
        Me.Gbx_Botones.TabIndex = 4
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(661, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Image = Global.Modulo_Proceso.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(7, 14)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 0
        Me.btn_Imprimir.Text = "&Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'spl_Detalles
        '
        Me.spl_Detalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spl_Detalles.Location = New System.Drawing.Point(4, 437)
        Me.spl_Detalles.Name = "spl_Detalles"
        '
        'spl_Detalles.Panel1
        '
        Me.spl_Detalles.Panel1.Controls.Add(Me.gbx_Envases)
        '
        'spl_Detalles.Panel2
        '
        Me.spl_Detalles.Panel2.Controls.Add(Me.gbx_Desglose)
        Me.spl_Detalles.Size = New System.Drawing.Size(805, 207)
        Me.spl_Detalles.SplitterDistance = 390
        Me.spl_Detalles.TabIndex = 5
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter4
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 20
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 20
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(384, 188)
        Me.lsv_Envases.TabIndex = 1
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'lsv_Deglose
        '
        Me.lsv_Deglose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Deglose.FullRowSelect = True
        Me.lsv_Deglose.HideSelection = False
        Me.lsv_Deglose.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Deglose.Lvs = ListViewColumnSorter3
        Me.lsv_Deglose.MultiSelect = False
        Me.lsv_Deglose.Name = "lsv_Deglose"
        Me.lsv_Deglose.Row1 = 20
        Me.lsv_Deglose.Row10 = 0
        Me.lsv_Deglose.Row2 = 20
        Me.lsv_Deglose.Row3 = 20
        Me.lsv_Deglose.Row4 = 30
        Me.lsv_Deglose.Row5 = 0
        Me.lsv_Deglose.Row6 = 0
        Me.lsv_Deglose.Row7 = 0
        Me.lsv_Deglose.Row8 = 0
        Me.lsv_Deglose.Row9 = 0
        Me.lsv_Deglose.Size = New System.Drawing.Size(405, 188)
        Me.lsv_Deglose.TabIndex = 1
        Me.lsv_Deglose.UseCompatibleStateImageBehavior = False
        Me.lsv_Deglose.View = System.Windows.Forms.View.Details
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(7, 36)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter2
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 40
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 10
        Me.lsv_Clientes.Row3 = 10
        Me.lsv_Clientes.Row4 = 10
        Me.lsv_Clientes.Row5 = 10
        Me.lsv_Clientes.Row6 = 10
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(792, 104)
        Me.lsv_Clientes.TabIndex = 0
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'lsv_Casets
        '
        Me.lsv_Casets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Casets.FullRowSelect = True
        Me.lsv_Casets.HideSelection = False
        Me.lsv_Casets.Location = New System.Drawing.Point(7, 39)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Casets.Lvs = ListViewColumnSorter1
        Me.lsv_Casets.MultiSelect = False
        Me.lsv_Casets.Name = "lsv_Casets"
        Me.lsv_Casets.Row1 = 10
        Me.lsv_Casets.Row10 = 0
        Me.lsv_Casets.Row2 = 10
        Me.lsv_Casets.Row3 = 10
        Me.lsv_Casets.Row4 = 10
        Me.lsv_Casets.Row5 = 10
        Me.lsv_Casets.Row6 = 10
        Me.lsv_Casets.Row7 = 15
        Me.lsv_Casets.Row8 = 0
        Me.lsv_Casets.Row9 = 0
        Me.lsv_Casets.Size = New System.Drawing.Size(792, 232)
        Me.lsv_Casets.TabIndex = 0
        Me.lsv_Casets.UseCompatibleStateImageBehavior = False
        Me.lsv_Casets.View = System.Windows.Forms.View.Details
        '
        'frm_RecuentoD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 699)
        Me.Controls.Add(Me.spl_Detalles)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Clientes)
        Me.Controls.Add(Me.gbx_Casets)
        Me.MinimizeBox = False
        Me.Name = "frm_RecuentoD"
        Me.Text = "Casets de Recuento"
        Me.gbx_Casets.ResumeLayout(False)
        Me.gbx_Casets.PerformLayout()
        Me.gbx_Clientes.ResumeLayout(False)
        Me.gbx_Desglose.ResumeLayout(False)
        Me.gbx_Envases.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.spl_Detalles.Panel1.ResumeLayout(False)
        Me.spl_Detalles.Panel2.ResumeLayout(False)
        Me.spl_Detalles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Casets As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Casets As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Clientes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Clientes As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Desglose As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Deglose As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Envases As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents spl_Detalles As System.Windows.Forms.SplitContainer
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosClientes As System.Windows.Forms.Label
End Class
