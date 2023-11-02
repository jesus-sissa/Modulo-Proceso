<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarServicios
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
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AsignarServicios))
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox()
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview()
        Me.lbl_RegistrosS = New System.Windows.Forms.Label()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.lsv_Servicios = New Modulo_Proceso.cp_Listview()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItemCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Asignar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Cajero = New System.Windows.Forms.Label()
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label()
        Me.gbx_Filtros = New System.Windows.Forms.GroupBox()
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.tbx_ClaveCajero = New Modulo_Proceso.cp_Textbox()
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.gbx_Servicios.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.lsv_Envases)
        Me.gbx_Servicios.Controls.Add(Me.lbl_RegistrosS)
        Me.gbx_Servicios.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Servicios.Controls.Add(Me.btn_Buscar)
        Me.gbx_Servicios.Controls.Add(Me.lsv_Servicios)
        Me.gbx_Servicios.Controls.Add(Me.txt_Buscar)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Buscar)
        Me.gbx_Servicios.Location = New System.Drawing.Point(3, 75)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(715, 407)
        Me.gbx_Servicios.TabIndex = 1
        Me.gbx_Servicios.TabStop = False
        Me.gbx_Servicios.Text = "Servicios Disponibles"
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(5, 240)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 40
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 50
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(707, 161)
        Me.lsv_Envases.TabIndex = 7
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'lbl_RegistrosS
        '
        Me.lbl_RegistrosS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosS.Location = New System.Drawing.Point(283, 22)
        Me.lbl_RegistrosS.Name = "lbl_RegistrosS"
        Me.lbl_RegistrosS.Size = New System.Drawing.Size(238, 23)
        Me.lbl_RegistrosS.TabIndex = 5
        Me.lbl_RegistrosS.Text = "Registros Seleccionados: 0"
        Me.lbl_RegistrosS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(527, 22)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(177, 23)
        Me.Lbl_Registros.TabIndex = 3
        Me.Lbl_Registros.Text = "Registros Totales: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(202, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lsv_Servicios
        '
        Me.lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Servicios.CheckBoxes = True
        Me.lsv_Servicios.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lsv_Servicios.FullRowSelect = True
        Me.lsv_Servicios.HideSelection = False
        Me.lsv_Servicios.Location = New System.Drawing.Point(5, 47)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Servicios.Lvs = ListViewColumnSorter2
        Me.lsv_Servicios.MultiSelect = False
        Me.lsv_Servicios.Name = "lsv_Servicios"
        Me.lsv_Servicios.Row1 = 7
        Me.lsv_Servicios.Row10 = 0
        Me.lsv_Servicios.Row2 = 10
        Me.lsv_Servicios.Row3 = 25
        Me.lsv_Servicios.Row4 = 25
        Me.lsv_Servicios.Row5 = 6
        Me.lsv_Servicios.Row6 = 6
        Me.lsv_Servicios.Row7 = 6
        Me.lsv_Servicios.Row8 = 0
        Me.lsv_Servicios.Row9 = 0
        Me.lsv_Servicios.Size = New System.Drawing.Size(707, 187)
        Me.lsv_Servicios.TabIndex = 4
        Me.lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItemCopy})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'CopiarToolStripMenuItemCopy
        '
        Me.CopiarToolStripMenuItemCopy.Name = "CopiarToolStripMenuItemCopy"
        Me.CopiarToolStripMenuItemCopy.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItemCopy.Text = "Copiar"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(65, 21)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(131, 20)
        Me.txt_Buscar.TabIndex = 1
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(19, 24)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(567, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Asignar
        '
        Me.btn_Asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Asignar.Enabled = False
        Me.btn_Asignar.Image = CType(resources.GetObject("btn_Asignar.Image"), System.Drawing.Image)
        Me.btn_Asignar.Location = New System.Drawing.Point(8, 14)
        Me.btn_Asignar.Name = "btn_Asignar"
        Me.btn_Asignar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Asignar.TabIndex = 0
        Me.btn_Asignar.Text = "&Asignar"
        Me.btn_Asignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Asignar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Asignar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox1.Controls.Add(Me.btn_Asignar)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 488)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(46, 16)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Cajero.TabIndex = 0
        Me.lbl_Cajero.Text = "Cajero:"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(10, 43)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(76, 13)
        Me.lbl_CajaBancaria.TabIndex = 3
        Me.lbl_CajaBancaria.Text = "Caja Bancaria:"
        '
        'gbx_Filtros
        '
        Me.gbx_Filtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Filtros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Filtros.Controls.Add(Me.tbx_ClaveCajero)
        Me.gbx_Filtros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtros.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Filtros.Name = "gbx_Filtros"
        Me.gbx_Filtros.Size = New System.Drawing.Size(715, 66)
        Me.gbx_Filtros.TabIndex = 0
        Me.gbx_Filtros.TabStop = False
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Nothing
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Me.tbx_ClaveCajero
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.Location = New System.Drawing.Point(92, 12)
        Me.cmb_Cajero.MaxDropDownItems = 15
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 2
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveCajero
        '
        Me.tbx_ClaveCajero.Control_Siguiente = Nothing
        Me.tbx_ClaveCajero.Filtrado = True
        Me.tbx_ClaveCajero.Location = New System.Drawing.Point(607, 13)
        Me.tbx_ClaveCajero.MaxLength = 12
        Me.tbx_ClaveCajero.Name = "tbx_ClaveCajero"
        Me.tbx_ClaveCajero.Size = New System.Drawing.Size(69, 20)
        Me.tbx_ClaveCajero.TabIndex = 1
        Me.tbx_ClaveCajero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.tbx_ClaveCajero.Visible = False
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(92, 40)
        Me.cmb_CajaBancaria.MaxDropDownItems = 15
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 5
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'frm_AsignarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbx_Servicios)
        Me.Controls.Add(Me.gbx_Filtros)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_AsignarServicios"
        Me.Text = "Asignar Servicios a Verificadores"
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Servicios.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_Filtros.ResumeLayout(False)
        Me.gbx_Filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Servicios As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Servicios As Modulo_Proceso.cp_Listview
    Friend WithEvents txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Asignar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosS As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveCajero As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItemCopy As System.Windows.Forms.ToolStripMenuItem
End Class
