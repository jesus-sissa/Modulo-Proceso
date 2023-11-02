<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FichasDesglose
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
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Tab_Desglose = New System.Windows.Forms.TabControl
        Me.Tab_Efectivo = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Efectivo = New Modulo_Proceso.cp_Listview
        Me.Tab_Cheques = New System.Windows.Forms.TabPage
        Me.Lbl_Registros1 = New System.Windows.Forms.Label
        Me.lsv_Cheques = New Modulo_Proceso.cp_Listview
        Me.Tab_Otros = New System.Windows.Forms.TabPage
        Me.Lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Otros = New Modulo_Proceso.cp_Listview
        Me.Tab_Parciales = New System.Windows.Forms.TabPage
        Me.lbl_DobleClick = New System.Windows.Forms.Label
        Me.Lbl_Registros3 = New System.Windows.Forms.Label
        Me.lsv_Parciales = New Modulo_Proceso.cp_Listview
        Me.gbx_Controles.SuspendLayout()
        Me.Tab_Desglose.SuspendLayout()
        Me.Tab_Efectivo.SuspendLayout()
        Me.Tab_Cheques.SuspendLayout()
        Me.Tab_Otros.SuspendLayout()
        Me.Tab_Parciales.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(3, 493)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(718, 50)
        Me.gbx_Controles.TabIndex = 1
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(569, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 29
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Tab_Desglose
        '
        Me.Tab_Desglose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Desglose.Controls.Add(Me.Tab_Efectivo)
        Me.Tab_Desglose.Controls.Add(Me.Tab_Cheques)
        Me.Tab_Desglose.Controls.Add(Me.Tab_Otros)
        Me.Tab_Desglose.Controls.Add(Me.Tab_Parciales)
        Me.Tab_Desglose.Location = New System.Drawing.Point(3, 6)
        Me.Tab_Desglose.Name = "Tab_Desglose"
        Me.Tab_Desglose.SelectedIndex = 0
        Me.Tab_Desglose.Size = New System.Drawing.Size(718, 485)
        Me.Tab_Desglose.TabIndex = 2
        '
        'Tab_Efectivo
        '
        Me.Tab_Efectivo.Controls.Add(Me.Lbl_Registros)
        Me.Tab_Efectivo.Controls.Add(Me.lsv_Efectivo)
        Me.Tab_Efectivo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Efectivo.Name = "Tab_Efectivo"
        Me.Tab_Efectivo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Efectivo.Size = New System.Drawing.Size(710, 459)
        Me.Tab_Efectivo.TabIndex = 0
        Me.Tab_Efectivo.Text = "Efectivo"
        Me.Tab_Efectivo.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(547, 3)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(157, 23)
        Me.Lbl_Registros.TabIndex = 50
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Efectivo
        '
        Me.lsv_Efectivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Efectivo.FullRowSelect = True
        Me.lsv_Efectivo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_Efectivo.HideSelection = False
        Me.lsv_Efectivo.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Efectivo.Lvs = ListViewColumnSorter1
        Me.lsv_Efectivo.MultiSelect = False
        Me.lsv_Efectivo.Name = "lsv_Efectivo"
        Me.lsv_Efectivo.Row1 = 20
        Me.lsv_Efectivo.Row10 = 0
        Me.lsv_Efectivo.Row2 = 12
        Me.lsv_Efectivo.Row3 = 20
        Me.lsv_Efectivo.Row4 = 20
        Me.lsv_Efectivo.Row5 = 20
        Me.lsv_Efectivo.Row6 = 0
        Me.lsv_Efectivo.Row7 = 0
        Me.lsv_Efectivo.Row8 = 0
        Me.lsv_Efectivo.Row9 = 0
        Me.lsv_Efectivo.Size = New System.Drawing.Size(698, 424)
        Me.lsv_Efectivo.TabIndex = 1
        Me.lsv_Efectivo.UseCompatibleStateImageBehavior = False
        Me.lsv_Efectivo.View = System.Windows.Forms.View.Details
        '
        'Tab_Cheques
        '
        Me.Tab_Cheques.Controls.Add(Me.Lbl_Registros1)
        Me.Tab_Cheques.Controls.Add(Me.lsv_Cheques)
        Me.Tab_Cheques.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Cheques.Name = "Tab_Cheques"
        Me.Tab_Cheques.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Cheques.Size = New System.Drawing.Size(710, 442)
        Me.Tab_Cheques.TabIndex = 1
        Me.Tab_Cheques.Text = "Cheques"
        Me.Tab_Cheques.UseVisualStyleBackColor = True
        '
        'Lbl_Registros1
        '
        Me.Lbl_Registros1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros1.Location = New System.Drawing.Point(539, 3)
        Me.Lbl_Registros1.Name = "Lbl_Registros1"
        Me.Lbl_Registros1.Size = New System.Drawing.Size(155, 23)
        Me.Lbl_Registros1.TabIndex = 50
        Me.Lbl_Registros1.Text = "Registros: 0"
        Me.Lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Cheques
        '
        Me.lsv_Cheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cheques.FullRowSelect = True
        Me.lsv_Cheques.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_Cheques.HideSelection = False
        Me.lsv_Cheques.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Cheques.Lvs = ListViewColumnSorter2
        Me.lsv_Cheques.MultiSelect = False
        Me.lsv_Cheques.Name = "lsv_Cheques"
        Me.lsv_Cheques.Row1 = 30
        Me.lsv_Cheques.Row10 = 0
        Me.lsv_Cheques.Row2 = 30
        Me.lsv_Cheques.Row3 = 20
        Me.lsv_Cheques.Row4 = 10
        Me.lsv_Cheques.Row5 = 0
        Me.lsv_Cheques.Row6 = 0
        Me.lsv_Cheques.Row7 = 0
        Me.lsv_Cheques.Row8 = 0
        Me.lsv_Cheques.Row9 = 0
        Me.lsv_Cheques.Size = New System.Drawing.Size(688, 397)
        Me.lsv_Cheques.TabIndex = 0
        Me.lsv_Cheques.UseCompatibleStateImageBehavior = False
        Me.lsv_Cheques.View = System.Windows.Forms.View.Details
        '
        'Tab_Otros
        '
        Me.Tab_Otros.Controls.Add(Me.Lbl_Registros2)
        Me.Tab_Otros.Controls.Add(Me.lsv_Otros)
        Me.Tab_Otros.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Otros.Name = "Tab_Otros"
        Me.Tab_Otros.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Otros.Size = New System.Drawing.Size(710, 442)
        Me.Tab_Otros.TabIndex = 2
        Me.Tab_Otros.Text = "Otros"
        Me.Tab_Otros.UseVisualStyleBackColor = True
        '
        'Lbl_Registros2
        '
        Me.Lbl_Registros2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros2.Location = New System.Drawing.Point(540, 3)
        Me.Lbl_Registros2.Name = "Lbl_Registros2"
        Me.Lbl_Registros2.Size = New System.Drawing.Size(155, 23)
        Me.Lbl_Registros2.TabIndex = 50
        Me.Lbl_Registros2.Text = "Registros: 0"
        Me.Lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Otros
        '
        Me.lsv_Otros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Otros.FullRowSelect = True
        Me.lsv_Otros.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_Otros.HideSelection = False
        Me.lsv_Otros.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Otros.Lvs = ListViewColumnSorter3
        Me.lsv_Otros.MultiSelect = False
        Me.lsv_Otros.Name = "lsv_Otros"
        Me.lsv_Otros.Row1 = 30
        Me.lsv_Otros.Row10 = 0
        Me.lsv_Otros.Row2 = 20
        Me.lsv_Otros.Row3 = 40
        Me.lsv_Otros.Row4 = 0
        Me.lsv_Otros.Row5 = 0
        Me.lsv_Otros.Row6 = 0
        Me.lsv_Otros.Row7 = 0
        Me.lsv_Otros.Row8 = 0
        Me.lsv_Otros.Row9 = 0
        Me.lsv_Otros.Size = New System.Drawing.Size(688, 397)
        Me.lsv_Otros.TabIndex = 0
        Me.lsv_Otros.UseCompatibleStateImageBehavior = False
        Me.lsv_Otros.View = System.Windows.Forms.View.Details
        '
        'Tab_Parciales
        '
        Me.Tab_Parciales.Controls.Add(Me.lbl_DobleClick)
        Me.Tab_Parciales.Controls.Add(Me.Lbl_Registros3)
        Me.Tab_Parciales.Controls.Add(Me.lsv_Parciales)
        Me.Tab_Parciales.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Parciales.Name = "Tab_Parciales"
        Me.Tab_Parciales.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Parciales.Size = New System.Drawing.Size(710, 442)
        Me.Tab_Parciales.TabIndex = 3
        Me.Tab_Parciales.Text = "Parciales"
        Me.Tab_Parciales.UseVisualStyleBackColor = True
        '
        'lbl_DobleClick
        '
        Me.lbl_DobleClick.AutoSize = True
        Me.lbl_DobleClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DobleClick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_DobleClick.Location = New System.Drawing.Point(6, 13)
        Me.lbl_DobleClick.Name = "lbl_DobleClick"
        Me.lbl_DobleClick.Size = New System.Drawing.Size(167, 13)
        Me.lbl_DobleClick.TabIndex = 51
        Me.lbl_DobleClick.Text = "Doble clik para ver detalles."
        '
        'Lbl_Registros3
        '
        Me.Lbl_Registros3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros3.Location = New System.Drawing.Point(539, 3)
        Me.Lbl_Registros3.Name = "Lbl_Registros3"
        Me.Lbl_Registros3.Size = New System.Drawing.Size(165, 23)
        Me.Lbl_Registros3.TabIndex = 50
        Me.Lbl_Registros3.Text = "Registros: 0"
        Me.Lbl_Registros3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Parciales
        '
        Me.lsv_Parciales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Parciales.FullRowSelect = True
        Me.lsv_Parciales.HideSelection = False
        Me.lsv_Parciales.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Parciales.Lvs = ListViewColumnSorter4
        Me.lsv_Parciales.MultiSelect = False
        Me.lsv_Parciales.Name = "lsv_Parciales"
        Me.lsv_Parciales.Row1 = 10
        Me.lsv_Parciales.Row10 = 0
        Me.lsv_Parciales.Row2 = 12
        Me.lsv_Parciales.Row3 = 20
        Me.lsv_Parciales.Row4 = 20
        Me.lsv_Parciales.Row5 = 20
        Me.lsv_Parciales.Row6 = 0
        Me.lsv_Parciales.Row7 = 0
        Me.lsv_Parciales.Row8 = 0
        Me.lsv_Parciales.Row9 = 0
        Me.lsv_Parciales.Size = New System.Drawing.Size(698, 407)
        Me.lsv_Parciales.TabIndex = 3
        Me.lsv_Parciales.UseCompatibleStateImageBehavior = False
        Me.lsv_Parciales.View = System.Windows.Forms.View.Details
        '
        'frm_DesgloseModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(724, 549)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.Tab_Desglose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(730, 577)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_DesgloseModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desglose"
        Me.gbx_Controles.ResumeLayout(False)
        Me.Tab_Desglose.ResumeLayout(False)
        Me.Tab_Efectivo.ResumeLayout(False)
        Me.Tab_Cheques.ResumeLayout(False)
        Me.Tab_Otros.ResumeLayout(False)
        Me.Tab_Parciales.ResumeLayout(False)
        Me.Tab_Parciales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Tab_Desglose As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Efectivo As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Efectivo As Modulo_Proceso.cp_Listview
    Friend WithEvents Tab_Cheques As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Otros As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Cheques As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_Otros As Modulo_Proceso.cp_Listview
    Friend WithEvents Tab_Parciales As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Parciales As Modulo_Proceso.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros3 As System.Windows.Forms.Label
    Friend WithEvents lbl_DobleClick As System.Windows.Forms.Label
End Class
