<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ArchivosBanregioDepositos
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
        Me.components = New System.ComponentModel.Container()
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox()
        Me.lbl_RegistrosD = New System.Windows.Forms.Label()
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox()
        Me.lbl_RegistrosE = New System.Windows.Forms.Label()
        Me.ContextMenuStripCopiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Envases = New System.Windows.Forms.GroupBox()
        Me.lbl_RegistrosC = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Dgv_Depositos = New System.Windows.Forms.DataGridView()
        Me.Dgv_Efectivo = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgv_Cheques = New System.Windows.Forms.DataGridView()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbx_Servicios.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.ContextMenuStripCopiar.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Envases.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Dgv_Depositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Efectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Cheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.Dgv_Depositos)
        Me.gbx_Servicios.Controls.Add(Me.lbl_RegistrosD)
        Me.gbx_Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Servicios.Location = New System.Drawing.Point(9, 7)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(1155, 250)
        Me.gbx_Servicios.TabIndex = 4
        Me.gbx_Servicios.TabStop = False
        Me.gbx_Servicios.Text = "Depositos"
        '
        'lbl_RegistrosD
        '
        Me.lbl_RegistrosD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosD.Location = New System.Drawing.Point(969, 16)
        Me.lbl_RegistrosD.Name = "lbl_RegistrosD"
        Me.lbl_RegistrosD.Size = New System.Drawing.Size(169, 17)
        Me.lbl_RegistrosD.TabIndex = 4
        Me.lbl_RegistrosD.Text = "Registros: 0"
        Me.lbl_RegistrosD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Controls.Add(Me.Dgv_Efectivo)
        Me.gbx_Detalle.Controls.Add(Me.lbl_RegistrosE)
        Me.gbx_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Detalle.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(475, 252)
        Me.gbx_Detalle.TabIndex = 1
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Detalle efectivo"
        '
        'lbl_RegistrosE
        '
        Me.lbl_RegistrosE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosE.Location = New System.Drawing.Point(298, 16)
        Me.lbl_RegistrosE.Name = "lbl_RegistrosE"
        Me.lbl_RegistrosE.Size = New System.Drawing.Size(169, 17)
        Me.lbl_RegistrosE.TabIndex = 4
        Me.lbl_RegistrosE.Text = "Registros: 0"
        Me.lbl_RegistrosE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContextMenuStripCopiar
        '
        Me.ContextMenuStripCopiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem})
        Me.ContextMenuStripCopiar.Name = "ContextMenuStripCopiar"
        Me.ContextMenuStripCopiar.Size = New System.Drawing.Size(110, 26)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 527)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(1155, 50)
        Me.gbx_Botones.TabIndex = 5
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Location = New System.Drawing.Point(1006, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Envases
        '
        Me.gbx_Envases.Controls.Add(Me.Dgv_Cheques)
        Me.gbx_Envases.Controls.Add(Me.lbl_RegistrosC)
        Me.gbx_Envases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Envases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Envases.Location = New System.Drawing.Point(484, 3)
        Me.gbx_Envases.Name = "gbx_Envases"
        Me.gbx_Envases.Size = New System.Drawing.Size(668, 252)
        Me.gbx_Envases.TabIndex = 1
        Me.gbx_Envases.TabStop = False
        Me.gbx_Envases.Text = "Detalle cheques"
        '
        'lbl_RegistrosC
        '
        Me.lbl_RegistrosC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosC.Location = New System.Drawing.Point(491, 16)
        Me.lbl_RegistrosC.Name = "lbl_RegistrosC"
        Me.lbl_RegistrosC.Size = New System.Drawing.Size(169, 17)
        Me.lbl_RegistrosC.TabIndex = 4
        Me.lbl_RegistrosC.Text = "Registros: 0"
        Me.lbl_RegistrosC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.7316!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.2684!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbx_Detalle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbx_Envases, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 263)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1155, 258)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Dgv_Depositos
        '
        Me.Dgv_Depositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Depositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Depositos.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Depositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Depositos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Dgv_Depositos.Location = New System.Drawing.Point(3, 36)
        Me.Dgv_Depositos.Name = "Dgv_Depositos"
        Me.Dgv_Depositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Depositos.Size = New System.Drawing.Size(1143, 208)
        Me.Dgv_Depositos.TabIndex = 5
        '
        'Dgv_Efectivo
        '
        Me.Dgv_Efectivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Efectivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Efectivo.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Efectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Efectivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.Dgv_Efectivo.Location = New System.Drawing.Point(6, 36)
        Me.Dgv_Efectivo.Name = "Dgv_Efectivo"
        Me.Dgv_Efectivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Efectivo.Size = New System.Drawing.Size(463, 184)
        Me.Dgv_Efectivo.TabIndex = 6
        '
        'Column9
        '
        Me.Column9.FillWeight = 99.25558!
        Me.Column9.HeaderText = "Tipo"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.FillWeight = 99.84301!
        Me.Column10.HeaderText = "Denominacion"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.FillWeight = 100.2847!
        Me.Column11.HeaderText = "Cantidad"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.FillWeight = 100.6167!
        Me.Column12.HeaderText = "Importe"
        Me.Column12.Name = "Column12"
        '
        'Dgv_Cheques
        '
        Me.Dgv_Cheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Cheques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgv_Cheques.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Cheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Cheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17})
        Me.Dgv_Cheques.Location = New System.Drawing.Point(6, 36)
        Me.Dgv_Cheques.Name = "Dgv_Cheques"
        Me.Dgv_Cheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Cheques.Size = New System.Drawing.Size(656, 184)
        Me.Dgv_Cheques.TabIndex = 7
        '
        'Column13
        '
        Me.Column13.FillWeight = 51.1583!
        Me.Column13.HeaderText = "Tipo"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 61
        '
        'Column14
        '
        Me.Column14.FillWeight = 100.4657!
        Me.Column14.HeaderText = "Referencia"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 99
        '
        'Column15
        '
        Me.Column15.FillWeight = 139.8183!
        Me.Column15.HeaderText = "Banda magnetica"
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 139
        '
        'Column16
        '
        Me.Column16.FillWeight = 107.1235!
        Me.Column16.HeaderText = "N.º Seguridad"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 117
        '
        'Column17
        '
        Me.Column17.FillWeight = 101.4342!
        Me.Column17.HeaderText = "Importe"
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 78
        '
        'Column1
        '
        Me.Column1.FillWeight = 80.97167!
        Me.Column1.HeaderText = "N.º "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 87.59199!
        Me.Column2.HeaderText = "Divisa"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 93.54224!
        Me.Column3.HeaderText = "Remesa"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 98.89022!
        Me.Column4.HeaderText = "Referencia"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 103.6969!
        Me.Column5.HeaderText = "Importe T."
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.FillWeight = 108.0171!
        Me.Column6.HeaderText = "Importe F."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 111.9!
        Me.Column7.HeaderText = "Diferencia"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.FillWeight = 115.3899!
        Me.Column8.HeaderText = "Tipo dif."
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Frm_ArchivosBanregioDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 585)
        Me.Controls.Add(Me.gbx_Servicios)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Frm_ArchivosBanregioDepositos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Detalle.ResumeLayout(False)
        Me.ContextMenuStripCopiar.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Envases.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Dgv_Depositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Efectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Cheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_Servicios As GroupBox
    Friend WithEvents lbl_RegistrosD As Label
    Friend WithEvents gbx_Detalle As GroupBox
    Friend WithEvents lbl_RegistrosE As Label
    Friend WithEvents ContextMenuStripCopiar As ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbx_Botones As GroupBox
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents gbx_Envases As GroupBox
    Friend WithEvents lbl_RegistrosC As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Dgv_Depositos As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Private WithEvents Dgv_Efectivo As DataGridView
    Private WithEvents Dgv_Cheques As DataGridView
End Class
