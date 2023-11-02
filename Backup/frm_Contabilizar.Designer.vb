<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contabilizar
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
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.lsv_Remisiones = New Modulo_Proceso.cp_Listview
        Me.ContextMenuStripCopiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItemCopiar = New System.Windows.Forms.ToolStripMenuItem
        Me.gbx_Cajero = New System.Windows.Forms.GroupBox
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cajero = New Modulo_Proceso.cp_Textbox
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Contabilizar = New System.Windows.Forms.Button
        Me.gbx_Remisiones.SuspendLayout()
        Me.ContextMenuStripCopiar.SuspendLayout()
        Me.gbx_Cajero.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Remisiones.Controls.Add(Me.chk_Todos)
        Me.gbx_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(3, 77)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(778, 325)
        Me.gbx_Remisiones.TabIndex = 0
        Me.gbx_Remisiones.TabStop = False
        Me.gbx_Remisiones.Text = "Remisiones"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(552, 12)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(217, 23)
        Me.Lbl_Registros.TabIndex = 50
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(9, 20)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 1
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.CheckBoxes = True
        Me.lsv_Remisiones.ContextMenuStrip = Me.ContextMenuStripCopiar
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(3, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter1
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 15
        Me.lsv_Remisiones.Row10 = 0
        Me.lsv_Remisiones.Row2 = 15
        Me.lsv_Remisiones.Row3 = 25
        Me.lsv_Remisiones.Row4 = 25
        Me.lsv_Remisiones.Row5 = 15
        Me.lsv_Remisiones.Row6 = 0
        Me.lsv_Remisiones.Row7 = 0
        Me.lsv_Remisiones.Row8 = 0
        Me.lsv_Remisiones.Row9 = 0
        Me.lsv_Remisiones.Size = New System.Drawing.Size(772, 284)
        Me.lsv_Remisiones.TabIndex = 0
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStripCopiar
        '
        Me.ContextMenuStripCopiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItemCopiar})
        Me.ContextMenuStripCopiar.Name = "ContextMenuStripCopiar"
        Me.ContextMenuStripCopiar.Size = New System.Drawing.Size(153, 48)
        '
        'CopiarToolStripMenuItemCopiar
        '
        Me.CopiarToolStripMenuItemCopiar.Name = "CopiarToolStripMenuItemCopiar"
        Me.CopiarToolStripMenuItemCopiar.Size = New System.Drawing.Size(152, 22)
        Me.CopiarToolStripMenuItemCopiar.Text = "Copiar"
        '
        'gbx_Cajero
        '
        Me.gbx_Cajero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cajero.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Cajero.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Cajero.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Cajero.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Cajero.Controls.Add(Me.tbx_Cajero)
        Me.gbx_Cajero.Location = New System.Drawing.Point(3, 4)
        Me.gbx_Cajero.Name = "gbx_Cajero"
        Me.gbx_Cajero.Size = New System.Drawing.Size(778, 70)
        Me.gbx_Cajero.TabIndex = 1
        Me.gbx_Cajero.TabStop = False
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(109, 41)
        Me.cmb_CajaBancaria.MaxDropDownItems = 15
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(461, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 3
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(30, 46)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 2
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Nothing
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Me.tbx_Cajero
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.Location = New System.Drawing.Point(109, 14)
        Me.cmb_Cajero.MaxDropDownItems = 15
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 1
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'tbx_Cajero
        '
        Me.tbx_Cajero.Control_Siguiente = Nothing
        Me.tbx_Cajero.Filtrado = False
        Me.tbx_Cajero.Location = New System.Drawing.Point(109, 14)
        Me.tbx_Cajero.MaxLength = 12
        Me.tbx_Cajero.Name = "tbx_Cajero"
        Me.tbx_Cajero.Size = New System.Drawing.Size(55, 20)
        Me.tbx_Cajero.TabIndex = 4
        Me.tbx_Cajero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Cajero.Visible = False
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(13, 18)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(90, 13)
        Me.lbl_Cajero.TabIndex = 0
        Me.lbl_Cajero.Text = "Cajero Verificador"
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Controls.Add(Me.btn_Contabilizar)
        Me.gbx_Controles.Location = New System.Drawing.Point(3, 407)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 10
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Contabilizar
        '
        Me.btn_Contabilizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Contabilizar.Enabled = False
        Me.btn_Contabilizar.Image = Global.Modulo_Proceso.My.Resources.Resources.bundle_24x24x32b
        Me.btn_Contabilizar.Location = New System.Drawing.Point(12, 13)
        Me.btn_Contabilizar.Name = "btn_Contabilizar"
        Me.btn_Contabilizar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Contabilizar.TabIndex = 9
        Me.btn_Contabilizar.Text = "&Contabilizar"
        Me.btn_Contabilizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Contabilizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Contabilizar.UseVisualStyleBackColor = True
        '
        'frm_Contabilizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.gbx_Cajero)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "frm_Contabilizar"
        Me.Text = "Contabilizar"
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_Remisiones.PerformLayout()
        Me.ContextMenuStripCopiar.ResumeLayout(False)
        Me.gbx_Cajero.ResumeLayout(False)
        Me.gbx_Cajero.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Cajero As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lsv_Remisiones As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Contabilizar As System.Windows.Forms.Button
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Cajero As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStripCopiar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItemCopiar As System.Windows.Forms.ToolStripMenuItem
End Class
