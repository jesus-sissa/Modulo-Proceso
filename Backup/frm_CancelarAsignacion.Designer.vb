<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelarAsignacion
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
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Cajero = New System.Windows.Forms.GroupBox
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New System.Windows.Forms.TextBox
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Servicios = New Modulo_Proceso.cp_Listview
        Me.ContextMenuStripCopiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Recibir = New System.Windows.Forms.Button
        Me.gbx_Envases = New System.Windows.Forms.GroupBox
        Me.lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.gbx_Cajero.SuspendLayout()
        Me.gbx_Servicios.SuspendLayout()
        Me.ContextMenuStripCopiar.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Envases.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Cajero
        '
        Me.gbx_Cajero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cajero.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Cajero.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Cajero.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Cajero.Name = "gbx_Cajero"
        Me.gbx_Cajero.Size = New System.Drawing.Size(778, 42)
        Me.gbx_Cajero.TabIndex = 0
        Me.gbx_Cajero.TabStop = False
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = ""
        Me.cmb_Cajero.Control_Siguiente = Nothing
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Nothing
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.Location = New System.Drawing.Point(101, 13)
        Me.cmb_Cajero.MaxDropDownItems = 20
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cajero.StoredProcedure = "Pro_Servicios_GetCajeros"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 1
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(9, 16)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(90, 13)
        Me.lbl_Cajero.TabIndex = 7
        Me.lbl_Cajero.Text = "Cajero Verificador"
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Servicios.Controls.Add(Me.btn_Buscar)
        Me.gbx_Servicios.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Buscar)
        Me.gbx_Servicios.Controls.Add(Me.lsv_Servicios)
        Me.gbx_Servicios.Location = New System.Drawing.Point(3, 46)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(778, 229)
        Me.gbx_Servicios.TabIndex = 1
        Me.gbx_Servicios.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(628, 15)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(143, 23)
        Me.Lbl_Registros.TabIndex = 50
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(548, 11)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Location = New System.Drawing.Point(101, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(441, 20)
        Me.tbx_Buscar.TabIndex = 2
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(52, 16)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 1
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'lsv_Servicios
        '
        Me.lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Servicios.CheckBoxes = True
        Me.lsv_Servicios.ContextMenuStrip = Me.ContextMenuStripCopiar
        Me.lsv_Servicios.FullRowSelect = True
        Me.lsv_Servicios.HideSelection = False
        Me.lsv_Servicios.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Servicios.Lvs = ListViewColumnSorter1
        Me.lsv_Servicios.MultiSelect = False
        Me.lsv_Servicios.Name = "lsv_Servicios"
        Me.lsv_Servicios.Row1 = 10
        Me.lsv_Servicios.Row10 = 0
        Me.lsv_Servicios.Row2 = 30
        Me.lsv_Servicios.Row3 = 10
        Me.lsv_Servicios.Row4 = 10
        Me.lsv_Servicios.Row5 = 10
        Me.lsv_Servicios.Row6 = 0
        Me.lsv_Servicios.Row7 = 0
        Me.lsv_Servicios.Row8 = 0
        Me.lsv_Servicios.Row9 = 0
        Me.lsv_Servicios.Size = New System.Drawing.Size(766, 183)
        Me.lsv_Servicios.TabIndex = 6
        Me.lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStripCopiar
        '
        Me.ContextMenuStripCopiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem})
        Me.ContextMenuStripCopiar.Name = "ContextMenuStripCopiar"
        Me.ContextMenuStripCopiar.Size = New System.Drawing.Size(153, 48)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Recibir)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(632, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 5
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Recibir
        '
        Me.btn_Recibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recibir.Enabled = False
        Me.btn_Recibir.Image = Global.Modulo_Proceso.My.Resources.Resources.Cancelar
        Me.btn_Recibir.Location = New System.Drawing.Point(6, 11)
        Me.btn_Recibir.Name = "btn_Recibir"
        Me.btn_Recibir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibir.TabIndex = 4
        Me.btn_Recibir.Text = "&Cancelar"
        Me.btn_Recibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibir.UseVisualStyleBackColor = True
        '
        'gbx_Envases
        '
        Me.gbx_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Envases.Controls.Add(Me.lbl_Registros2)
        Me.gbx_Envases.Controls.Add(Me.lsv_Envases)
        Me.gbx_Envases.Location = New System.Drawing.Point(4, 280)
        Me.gbx_Envases.Name = "gbx_Envases"
        Me.gbx_Envases.Size = New System.Drawing.Size(776, 227)
        Me.gbx_Envases.TabIndex = 52
        Me.gbx_Envases.TabStop = False
        '
        'lbl_Registros2
        '
        Me.lbl_Registros2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros2.Location = New System.Drawing.Point(627, 11)
        Me.lbl_Registros2.Name = "lbl_Registros2"
        Me.lbl_Registros2.Size = New System.Drawing.Size(141, 23)
        Me.lbl_Registros2.TabIndex = 50
        Me.lbl_Registros2.Text = "Registros: 0"
        Me.lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(4, 37)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter2
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 10
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 30
        Me.lsv_Envases.Row3 = 10
        Me.lsv_Envases.Row4 = 10
        Me.lsv_Envases.Row5 = 10
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(766, 184)
        Me.lsv_Envases.TabIndex = 6
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'frm_CancelarAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Envases)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Servicios)
        Me.Controls.Add(Me.gbx_Cajero)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CancelarAsignacion"
        Me.Text = "Cancelar Asignaciones"
        Me.gbx_Cajero.ResumeLayout(False)
        Me.gbx_Cajero.PerformLayout()
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Servicios.PerformLayout()
        Me.ContextMenuStripCopiar.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Envases.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Cajero As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Servicios As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Servicios As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents gbx_Envases As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents ContextMenuStripCopiar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
