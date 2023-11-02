<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelaEnvioBoveda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CancelaEnvioBoveda))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Dotacion = New Modulo_Proceso.cp_Listview
        Me.lsv_DotacionD = New Modulo_Proceso.cp_Listview
        Me.lbl_registros3 = New System.Windows.Forms.Label
        Me.lsv_envases = New Modulo_Proceso.cp_Listview
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox1.Controls.Add(Me.btn_Cancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 476)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 50)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(562, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 40
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 39
        Me.btn_Cancelar.Text = "&Cancela"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(564, 9)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(147, 23)
        Me.Lbl_Registros.TabIndex = 49
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Registros2
        '
        Me.lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros2.Location = New System.Drawing.Point(556, 156)
        Me.lbl_Registros2.Name = "lbl_Registros2"
        Me.lbl_Registros2.Size = New System.Drawing.Size(155, 23)
        Me.lbl_Registros2.TabIndex = 50
        Me.lbl_Registros2.Text = "Registros: 0"
        Me.lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Dotacion
        '
        Me.lsv_Dotacion.AllowColumnReorder = True
        Me.lsv_Dotacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotacion.FullRowSelect = True
        Me.lsv_Dotacion.HideSelection = False
        Me.lsv_Dotacion.Location = New System.Drawing.Point(3, 35)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotacion.Lvs = ListViewColumnSorter1
        Me.lsv_Dotacion.MultiSelect = False
        Me.lsv_Dotacion.Name = "lsv_Dotacion"
        Me.lsv_Dotacion.Row1 = 10
        Me.lsv_Dotacion.Row10 = 0
        Me.lsv_Dotacion.Row2 = 30
        Me.lsv_Dotacion.Row3 = 10
        Me.lsv_Dotacion.Row4 = 10
        Me.lsv_Dotacion.Row5 = 10
        Me.lsv_Dotacion.Row6 = 10
        Me.lsv_Dotacion.Row7 = 0
        Me.lsv_Dotacion.Row8 = 0
        Me.lsv_Dotacion.Row9 = 0
        Me.lsv_Dotacion.Size = New System.Drawing.Size(708, 110)
        Me.lsv_Dotacion.TabIndex = 41
        Me.lsv_Dotacion.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotacion.View = System.Windows.Forms.View.Details
        '
        'lsv_DotacionD
        '
        Me.lsv_DotacionD.AllowColumnReorder = True
        Me.lsv_DotacionD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionD.FullRowSelect = True
        Me.lsv_DotacionD.HideSelection = False
        Me.lsv_DotacionD.Location = New System.Drawing.Point(3, 187)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_DotacionD.Lvs = ListViewColumnSorter2
        Me.lsv_DotacionD.MultiSelect = False
        Me.lsv_DotacionD.Name = "lsv_DotacionD"
        Me.lsv_DotacionD.Row1 = 10
        Me.lsv_DotacionD.Row10 = 0
        Me.lsv_DotacionD.Row2 = 70
        Me.lsv_DotacionD.Row3 = 0
        Me.lsv_DotacionD.Row4 = 0
        Me.lsv_DotacionD.Row5 = 0
        Me.lsv_DotacionD.Row6 = 0
        Me.lsv_DotacionD.Row7 = 0
        Me.lsv_DotacionD.Row8 = 0
        Me.lsv_DotacionD.Row9 = 0
        Me.lsv_DotacionD.Size = New System.Drawing.Size(708, 128)
        Me.lsv_DotacionD.TabIndex = 42
        Me.lsv_DotacionD.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionD.View = System.Windows.Forms.View.Details
        '
        'lbl_registros3
        '
        Me.lbl_registros3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_registros3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registros3.Location = New System.Drawing.Point(556, 324)
        Me.lbl_registros3.Name = "lbl_registros3"
        Me.lbl_registros3.Size = New System.Drawing.Size(155, 23)
        Me.lbl_registros3.TabIndex = 54
        Me.lbl_registros3.Text = "Registros: 0"
        Me.lbl_registros3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_envases
        '
        Me.lsv_envases.AllowColumnReorder = True
        Me.lsv_envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_envases.FullRowSelect = True
        Me.lsv_envases.HideSelection = False
        Me.lsv_envases.Location = New System.Drawing.Point(3, 358)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_envases.Lvs = ListViewColumnSorter3
        Me.lsv_envases.MultiSelect = False
        Me.lsv_envases.Name = "lsv_envases"
        Me.lsv_envases.Row1 = 10
        Me.lsv_envases.Row10 = 0
        Me.lsv_envases.Row2 = 70
        Me.lsv_envases.Row3 = 0
        Me.lsv_envases.Row4 = 0
        Me.lsv_envases.Row5 = 0
        Me.lsv_envases.Row6 = 0
        Me.lsv_envases.Row7 = 0
        Me.lsv_envases.Row8 = 0
        Me.lsv_envases.Row9 = 0
        Me.lsv_envases.Size = New System.Drawing.Size(708, 112)
        Me.lsv_envases.TabIndex = 53
        Me.lsv_envases.UseCompatibleStateImageBehavior = False
        Me.lsv_envases.View = System.Windows.Forms.View.Details
        '
        'frm_CancelaEnvioBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 538)
        Me.Controls.Add(Me.lbl_registros3)
        Me.Controls.Add(Me.lsv_envases)
        Me.Controls.Add(Me.lbl_Registros2)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lsv_Dotacion)
        Me.Controls.Add(Me.lsv_DotacionD)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_CancelaEnvioBoveda"
        Me.Text = "Cancela Envio a Boveda"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Dotacion As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_DotacionD As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lbl_registros3 As System.Windows.Forms.Label
    Friend WithEvents lsv_envases As Modulo_Proceso.cp_Listview
End Class
