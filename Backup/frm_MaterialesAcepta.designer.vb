<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MaterialesAcepta
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
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lsv_VentasD = New Modulo_Proceso.cp_Listview
        Me.lsv_Ventas = New Modulo_Proceso.cp_Listview
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_Registros1 = New System.Windows.Forms.Label
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.Gbx_Botones.TabIndex = 47
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Validar
        '
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Validar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 6
        Me.btn_Validar.Text = "&Aceptar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(620, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 7
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lsv_VentasD
        '
        Me.lsv_VentasD.AllowColumnReorder = True
        Me.lsv_VentasD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VentasD.FullRowSelect = True
        Me.lsv_VentasD.HideSelection = False
        Me.lsv_VentasD.Location = New System.Drawing.Point(12, 243)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_VentasD.Lvs = ListViewColumnSorter1
        Me.lsv_VentasD.MultiSelect = False
        Me.lsv_VentasD.Name = "lsv_VentasD"
        Me.lsv_VentasD.Row1 = 10
        Me.lsv_VentasD.Row10 = 0
        Me.lsv_VentasD.Row2 = 60
        Me.lsv_VentasD.Row3 = 10
        Me.lsv_VentasD.Row4 = 0
        Me.lsv_VentasD.Row5 = 0
        Me.lsv_VentasD.Row6 = 0
        Me.lsv_VentasD.Row7 = 0
        Me.lsv_VentasD.Row8 = 0
        Me.lsv_VentasD.Row9 = 0
        Me.lsv_VentasD.Size = New System.Drawing.Size(766, 250)
        Me.lsv_VentasD.TabIndex = 5
        Me.lsv_VentasD.TabStop = False
        Me.lsv_VentasD.UseCompatibleStateImageBehavior = False
        Me.lsv_VentasD.View = System.Windows.Forms.View.Details
        '
        'lsv_Ventas
        '
        Me.lsv_Ventas.AllowColumnReorder = True
        Me.lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Ventas.FullRowSelect = True
        Me.lsv_Ventas.HideSelection = False
        Me.lsv_Ventas.Location = New System.Drawing.Point(12, 27)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Ventas.Lvs = ListViewColumnSorter2
        Me.lsv_Ventas.MultiSelect = False
        Me.lsv_Ventas.Name = "lsv_Ventas"
        Me.lsv_Ventas.Row1 = 10
        Me.lsv_Ventas.Row10 = 0
        Me.lsv_Ventas.Row2 = 10
        Me.lsv_Ventas.Row3 = 50
        Me.lsv_Ventas.Row4 = 10
        Me.lsv_Ventas.Row5 = 0
        Me.lsv_Ventas.Row6 = 0
        Me.lsv_Ventas.Row7 = 0
        Me.lsv_Ventas.Row8 = 0
        Me.lsv_Ventas.Row9 = 0
        Me.lsv_Ventas.Size = New System.Drawing.Size(766, 195)
        Me.lsv_Ventas.TabIndex = 4
        Me.lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(532, 9)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(246, 15)
        Me.Lbl_Registros.TabIndex = 53
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Registros1
        '
        Me.Lbl_Registros1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros1.Location = New System.Drawing.Point(594, 225)
        Me.Lbl_Registros1.Name = "Lbl_Registros1"
        Me.Lbl_Registros1.Size = New System.Drawing.Size(184, 15)
        Me.Lbl_Registros1.TabIndex = 54
        Me.Lbl_Registros1.Text = "Registros: 0"
        Me.Lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_MaterialesAcepta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Lbl_Registros1)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.lsv_VentasD)
        Me.Controls.Add(Me.lsv_Ventas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_MaterialesAcepta"
        Me.Text = "Valida Ventas Materiales"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Ventas As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents lsv_VentasD As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros1 As System.Windows.Forms.Label
End Class
