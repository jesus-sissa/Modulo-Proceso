<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProcesoSaldos
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
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.Gbx_Cajeros = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_Sumatoria = New System.Windows.Forms.Label
        Me.lsv_Cajeros = New Modulo_Proceso.cp_Listview
        Me.Gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros1 = New System.Windows.Forms.Label
        Me.Lbl_SumatoriaR = New System.Windows.Forms.Label
        Me.lsv_Detalles = New Modulo_Proceso.cp_Listview
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Gbx_Cajeros.SuspendLayout()
        Me.Gbx_Detalle.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Cajeros
        '
        Me.Gbx_Cajeros.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Cajeros.Controls.Add(Me.Lbl_Sumatoria)
        Me.Gbx_Cajeros.Controls.Add(Me.lsv_Cajeros)
        Me.Gbx_Cajeros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbx_Cajeros.Location = New System.Drawing.Point(0, 0)
        Me.Gbx_Cajeros.Name = "Gbx_Cajeros"
        Me.Gbx_Cajeros.Size = New System.Drawing.Size(784, 280)
        Me.Gbx_Cajeros.TabIndex = 3
        Me.Gbx_Cajeros.TabStop = False
        Me.Gbx_Cajeros.Text = "Cajeros"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(631, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(147, 15)
        Me.Lbl_Registros.TabIndex = 54
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Sumatoria
        '
        Me.Lbl_Sumatoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Sumatoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sumatoria.Location = New System.Drawing.Point(538, 258)
        Me.Lbl_Sumatoria.Name = "Lbl_Sumatoria"
        Me.Lbl_Sumatoria.Size = New System.Drawing.Size(237, 16)
        Me.Lbl_Sumatoria.TabIndex = 3
        Me.Lbl_Sumatoria.Text = "TOTAL: 0.00"
        Me.Lbl_Sumatoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Cajeros
        '
        Me.lsv_Cajeros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Cajeros.FullRowSelect = True
        Me.lsv_Cajeros.HideSelection = False
        Me.lsv_Cajeros.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Cajeros.Lvs = ListViewColumnSorter1
        Me.lsv_Cajeros.MultiSelect = False
        Me.lsv_Cajeros.Name = "lsv_Cajeros"
        Me.lsv_Cajeros.Row1 = 10
        Me.lsv_Cajeros.Row10 = 0
        Me.lsv_Cajeros.Row2 = 45
        Me.lsv_Cajeros.Row3 = 13
        Me.lsv_Cajeros.Row4 = 10
        Me.lsv_Cajeros.Row5 = 20
        Me.lsv_Cajeros.Row6 = 0
        Me.lsv_Cajeros.Row7 = 0
        Me.lsv_Cajeros.Row8 = 0
        Me.lsv_Cajeros.Row9 = 0
        Me.lsv_Cajeros.Size = New System.Drawing.Size(772, 221)
        Me.lsv_Cajeros.TabIndex = 1
        Me.lsv_Cajeros.UseCompatibleStateImageBehavior = False
        Me.lsv_Cajeros.View = System.Windows.Forms.View.Details
        '
        'Gbx_Detalle
        '
        Me.Gbx_Detalle.Controls.Add(Me.Lbl_Registros1)
        Me.Gbx_Detalle.Controls.Add(Me.Lbl_SumatoriaR)
        Me.Gbx_Detalle.Controls.Add(Me.lsv_Detalles)
        Me.Gbx_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbx_Detalle.Location = New System.Drawing.Point(0, 0)
        Me.Gbx_Detalle.Name = "Gbx_Detalle"
        Me.Gbx_Detalle.Size = New System.Drawing.Size(784, 277)
        Me.Gbx_Detalle.TabIndex = 4
        Me.Gbx_Detalle.TabStop = False
        Me.Gbx_Detalle.Text = "Detalle"
        '
        'Lbl_Registros1
        '
        Me.Lbl_Registros1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros1.Location = New System.Drawing.Point(628, 16)
        Me.Lbl_Registros1.Name = "Lbl_Registros1"
        Me.Lbl_Registros1.Size = New System.Drawing.Size(150, 15)
        Me.Lbl_Registros1.TabIndex = 54
        Me.Lbl_Registros1.Text = "Registros: 0"
        Me.Lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_SumatoriaR
        '
        Me.Lbl_SumatoriaR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_SumatoriaR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SumatoriaR.Location = New System.Drawing.Point(538, 255)
        Me.Lbl_SumatoriaR.Name = "Lbl_SumatoriaR"
        Me.Lbl_SumatoriaR.Size = New System.Drawing.Size(237, 16)
        Me.Lbl_SumatoriaR.TabIndex = 4
        Me.Lbl_SumatoriaR.Text = "TOTAL: 0.00"
        Me.Lbl_SumatoriaR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Detalles
        '
        Me.lsv_Detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Detalles.FullRowSelect = True
        Me.lsv_Detalles.HideSelection = False
        Me.lsv_Detalles.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Detalles.Lvs = ListViewColumnSorter2
        Me.lsv_Detalles.MultiSelect = False
        Me.lsv_Detalles.Name = "lsv_Detalles"
        Me.lsv_Detalles.Row1 = 10
        Me.lsv_Detalles.Row10 = 0
        Me.lsv_Detalles.Row2 = 30
        Me.lsv_Detalles.Row3 = 30
        Me.lsv_Detalles.Row4 = 10
        Me.lsv_Detalles.Row5 = 5
        Me.lsv_Detalles.Row6 = 13
        Me.lsv_Detalles.Row7 = 0
        Me.lsv_Detalles.Row8 = 0
        Me.lsv_Detalles.Row9 = 0
        Me.lsv_Detalles.Size = New System.Drawing.Size(772, 218)
        Me.lsv_Detalles.TabIndex = 2
        Me.lsv_Detalles.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalles.View = System.Windows.Forms.View.Details
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Gbx_Cajeros)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Gbx_Detalle)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 561)
        Me.SplitContainer1.SplitterDistance = 280
        Me.SplitContainer1.TabIndex = 5
        '
        'frm_ProcesoSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ProcesoSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoreo de Saldos"
        Me.Gbx_Cajeros.ResumeLayout(False)
        Me.Gbx_Detalle.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Detalles As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_Cajeros As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Cajeros As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Sumatoria As System.Windows.Forms.Label
    Friend WithEvents Lbl_SumatoriaR As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
