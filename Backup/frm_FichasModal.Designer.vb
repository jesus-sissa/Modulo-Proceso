<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FichasModal
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
        Me.gbx_Fichas = New System.Windows.Forms.GroupBox
        Me.lbl_DobleClick = New System.Windows.Forms.Label
        Me.tbx_DifOtros = New System.Windows.Forms.TextBox
        Me.tbx_DifCheques = New System.Windows.Forms.TextBox
        Me.tbx_DifEfectivo = New System.Windows.Forms.TextBox
        Me.tbx_TotOtros = New System.Windows.Forms.TextBox
        Me.tbx_TotCheques = New System.Windows.Forms.TextBox
        Me.tbx_TotEfectivo = New System.Windows.Forms.TextBox
        Me.lbl_DifOtros = New System.Windows.Forms.Label
        Me.lbl_DifCheques = New System.Windows.Forms.Label
        Me.lbl_DifEfectivo = New System.Windows.Forms.Label
        Me.lbl_Otros = New System.Windows.Forms.Label
        Me.lbl_Cheques = New System.Windows.Forms.Label
        Me.lbl_Importe = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Fichas = New Modulo_Proceso.cp_Listview
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Fichas.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Fichas
        '
        Me.gbx_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Fichas.Controls.Add(Me.lbl_DobleClick)
        Me.gbx_Fichas.Controls.Add(Me.tbx_DifOtros)
        Me.gbx_Fichas.Controls.Add(Me.tbx_DifCheques)
        Me.gbx_Fichas.Controls.Add(Me.tbx_DifEfectivo)
        Me.gbx_Fichas.Controls.Add(Me.tbx_TotOtros)
        Me.gbx_Fichas.Controls.Add(Me.tbx_TotCheques)
        Me.gbx_Fichas.Controls.Add(Me.tbx_TotEfectivo)
        Me.gbx_Fichas.Controls.Add(Me.lbl_DifOtros)
        Me.gbx_Fichas.Controls.Add(Me.lbl_DifCheques)
        Me.gbx_Fichas.Controls.Add(Me.lbl_DifEfectivo)
        Me.gbx_Fichas.Controls.Add(Me.lbl_Otros)
        Me.gbx_Fichas.Controls.Add(Me.lbl_Cheques)
        Me.gbx_Fichas.Controls.Add(Me.lbl_Importe)
        Me.gbx_Fichas.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Fichas.Controls.Add(Me.lsv_Fichas)
        Me.gbx_Fichas.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Fichas.Name = "gbx_Fichas"
        Me.gbx_Fichas.Size = New System.Drawing.Size(718, 491)
        Me.gbx_Fichas.TabIndex = 0
        Me.gbx_Fichas.TabStop = False
        Me.gbx_Fichas.Text = "Fichas"
        '
        'lbl_DobleClick
        '
        Me.lbl_DobleClick.AutoSize = True
        Me.lbl_DobleClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DobleClick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_DobleClick.Location = New System.Drawing.Point(6, 17)
        Me.lbl_DobleClick.Name = "lbl_DobleClick"
        Me.lbl_DobleClick.Size = New System.Drawing.Size(167, 13)
        Me.lbl_DobleClick.TabIndex = 2
        Me.lbl_DobleClick.Text = "Doble clik para ver detalles."
        '
        'tbx_DifOtros
        '
        Me.tbx_DifOtros.BackColor = System.Drawing.Color.White
        Me.tbx_DifOtros.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbx_DifOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_DifOtros.Location = New System.Drawing.Point(549, 463)
        Me.tbx_DifOtros.Name = "tbx_DifOtros"
        Me.tbx_DifOtros.ReadOnly = True
        Me.tbx_DifOtros.Size = New System.Drawing.Size(140, 21)
        Me.tbx_DifOtros.TabIndex = 13
        Me.tbx_DifOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbx_DifCheques
        '
        Me.tbx_DifCheques.BackColor = System.Drawing.Color.White
        Me.tbx_DifCheques.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbx_DifCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_DifCheques.Location = New System.Drawing.Point(324, 463)
        Me.tbx_DifCheques.Name = "tbx_DifCheques"
        Me.tbx_DifCheques.ReadOnly = True
        Me.tbx_DifCheques.Size = New System.Drawing.Size(140, 21)
        Me.tbx_DifCheques.TabIndex = 11
        Me.tbx_DifCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbx_DifEfectivo
        '
        Me.tbx_DifEfectivo.BackColor = System.Drawing.Color.White
        Me.tbx_DifEfectivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbx_DifEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_DifEfectivo.Location = New System.Drawing.Point(88, 463)
        Me.tbx_DifEfectivo.Name = "tbx_DifEfectivo"
        Me.tbx_DifEfectivo.ReadOnly = True
        Me.tbx_DifEfectivo.Size = New System.Drawing.Size(140, 21)
        Me.tbx_DifEfectivo.TabIndex = 9
        Me.tbx_DifEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbx_TotOtros
        '
        Me.tbx_TotOtros.BackColor = System.Drawing.Color.White
        Me.tbx_TotOtros.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbx_TotOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotOtros.Location = New System.Drawing.Point(549, 436)
        Me.tbx_TotOtros.Name = "tbx_TotOtros"
        Me.tbx_TotOtros.ReadOnly = True
        Me.tbx_TotOtros.Size = New System.Drawing.Size(140, 21)
        Me.tbx_TotOtros.TabIndex = 7
        Me.tbx_TotOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbx_TotCheques
        '
        Me.tbx_TotCheques.BackColor = System.Drawing.Color.White
        Me.tbx_TotCheques.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbx_TotCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotCheques.Location = New System.Drawing.Point(324, 437)
        Me.tbx_TotCheques.Name = "tbx_TotCheques"
        Me.tbx_TotCheques.ReadOnly = True
        Me.tbx_TotCheques.Size = New System.Drawing.Size(140, 21)
        Me.tbx_TotCheques.TabIndex = 5
        Me.tbx_TotCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbx_TotEfectivo
        '
        Me.tbx_TotEfectivo.BackColor = System.Drawing.Color.White
        Me.tbx_TotEfectivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbx_TotEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotEfectivo.Location = New System.Drawing.Point(88, 436)
        Me.tbx_TotEfectivo.Name = "tbx_TotEfectivo"
        Me.tbx_TotEfectivo.ReadOnly = True
        Me.tbx_TotEfectivo.Size = New System.Drawing.Size(140, 21)
        Me.tbx_TotEfectivo.TabIndex = 3
        Me.tbx_TotEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_DifOtros
        '
        Me.lbl_DifOtros.AutoSize = True
        Me.lbl_DifOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DifOtros.Location = New System.Drawing.Point(495, 467)
        Me.lbl_DifOtros.Name = "lbl_DifOtros"
        Me.lbl_DifOtros.Size = New System.Drawing.Size(51, 13)
        Me.lbl_DifOtros.TabIndex = 12
        Me.lbl_DifOtros.Text = "Dif. Otros"
        '
        'lbl_DifCheques
        '
        Me.lbl_DifCheques.AutoSize = True
        Me.lbl_DifCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DifCheques.Location = New System.Drawing.Point(252, 468)
        Me.lbl_DifCheques.Name = "lbl_DifCheques"
        Me.lbl_DifCheques.Size = New System.Drawing.Size(68, 13)
        Me.lbl_DifCheques.TabIndex = 10
        Me.lbl_DifCheques.Text = "Dif. Cheques"
        '
        'lbl_DifEfectivo
        '
        Me.lbl_DifEfectivo.AutoSize = True
        Me.lbl_DifEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DifEfectivo.Location = New System.Drawing.Point(18, 467)
        Me.lbl_DifEfectivo.Name = "lbl_DifEfectivo"
        Me.lbl_DifEfectivo.Size = New System.Drawing.Size(65, 13)
        Me.lbl_DifEfectivo.TabIndex = 8
        Me.lbl_DifEfectivo.Text = "Dif. Efectivo"
        '
        'lbl_Otros
        '
        Me.lbl_Otros.AutoSize = True
        Me.lbl_Otros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Otros.Location = New System.Drawing.Point(487, 441)
        Me.lbl_Otros.Name = "lbl_Otros"
        Me.lbl_Otros.Size = New System.Drawing.Size(59, 13)
        Me.lbl_Otros.TabIndex = 6
        Me.lbl_Otros.Text = "Total Otros"
        '
        'lbl_Cheques
        '
        Me.lbl_Cheques.AutoSize = True
        Me.lbl_Cheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cheques.Location = New System.Drawing.Point(243, 441)
        Me.lbl_Cheques.Name = "lbl_Cheques"
        Me.lbl_Cheques.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Cheques.TabIndex = 4
        Me.lbl_Cheques.Text = "Total Cheques"
        '
        'lbl_Importe
        '
        Me.lbl_Importe.AutoSize = True
        Me.lbl_Importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Importe.Location = New System.Drawing.Point(9, 441)
        Me.lbl_Importe.Name = "lbl_Importe"
        Me.lbl_Importe.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Importe.TabIndex = 2
        Me.lbl_Importe.Text = "Total Efectivo"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(528, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(184, 15)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Fichas
        '
        Me.lsv_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Fichas.FullRowSelect = True
        Me.lsv_Fichas.HideSelection = False
        Me.lsv_Fichas.Location = New System.Drawing.Point(3, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Fichas.Lvs = ListViewColumnSorter1
        Me.lsv_Fichas.MultiSelect = False
        Me.lsv_Fichas.Name = "lsv_Fichas"
        Me.lsv_Fichas.Row1 = 10
        Me.lsv_Fichas.Row10 = 0
        Me.lsv_Fichas.Row2 = 10
        Me.lsv_Fichas.Row3 = 10
        Me.lsv_Fichas.Row4 = 10
        Me.lsv_Fichas.Row5 = 10
        Me.lsv_Fichas.Row6 = 10
        Me.lsv_Fichas.Row7 = 10
        Me.lsv_Fichas.Row8 = 10
        Me.lsv_Fichas.Row9 = 10
        Me.lsv_Fichas.Size = New System.Drawing.Size(709, 395)
        Me.lsv_Fichas.TabIndex = 1
        Me.lsv_Fichas.UseCompatibleStateImageBehavior = False
        Me.lsv_Fichas.View = System.Windows.Forms.View.Details
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(3, 494)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(569, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_FichasModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(724, 549)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Fichas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(730, 577)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_FichasModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fichas"
        Me.gbx_Fichas.ResumeLayout(False)
        Me.gbx_Fichas.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Fichas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_Fichas As Modulo_Proceso.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents tbx_TotOtros As System.Windows.Forms.TextBox
    Friend WithEvents tbx_TotCheques As System.Windows.Forms.TextBox
    Friend WithEvents tbx_TotEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Otros As System.Windows.Forms.Label
    Friend WithEvents lbl_Cheques As System.Windows.Forms.Label
    Friend WithEvents lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents tbx_DifEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DifEfectivo As System.Windows.Forms.Label
    Friend WithEvents tbx_DifOtros As System.Windows.Forms.TextBox
    Friend WithEvents tbx_DifCheques As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DifOtros As System.Windows.Forms.Label
    Friend WithEvents lbl_DifCheques As System.Windows.Forms.Label
    Friend WithEvents lbl_DobleClick As System.Windows.Forms.Label
End Class
