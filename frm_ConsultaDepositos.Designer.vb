<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaDepositos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaDepositos))
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox()
        Me.cbx_cajero = New System.Windows.Forms.CheckBox()
        Me.cbx_caja = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_Clientes = New System.Windows.Forms.CheckBox()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.lbl_Clientes = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.cbx_Corte = New System.Windows.Forms.CheckBox()
        Me.lbl_Corte = New System.Windows.Forms.Label()
        Me.cbx_Status = New System.Windows.Forms.CheckBox()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label()
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.lbl_DobleClick = New System.Windows.Forms.Label()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.ContextMenuStripCopiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItemCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.Btn_Desbloquear = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.lsv_Dotaciones = New Modulo_Proceso.cp_Listview()
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Clientes = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.txt_Clave = New Modulo_Proceso.cp_Textbox()
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Simple()
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Simple()
        Me.tbx_Corte = New Modulo_Proceso.cp_Textbox()
        Me.cmb_Status = New Modulo_Proceso.cp_cmb_Manual()
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.gbx_Parametros.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripCopiar.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.cbx_cajero)
        Me.gbx_Parametros.Controls.Add(Me.cbx_caja)
        Me.gbx_Parametros.Controls.Add(Me.Label1)
        Me.gbx_Parametros.Controls.Add(Me.cbx_Clientes)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Parametros.Controls.Add(Me.txt_Clave)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Clientes)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Desde)
        Me.gbx_Parametros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Parametros.Controls.Add(Me.cbx_Corte)
        Me.gbx_Parametros.Controls.Add(Me.tbx_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Corte)
        Me.gbx_Parametros.Controls.Add(Me.cbx_Status)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Status)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Status)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Parametros.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(1034, 223)
        Me.gbx_Parametros.TabIndex = 0
        Me.gbx_Parametros.TabStop = False
        '
        'cbx_cajero
        '
        Me.cbx_cajero.AutoSize = True
        Me.cbx_cajero.Location = New System.Drawing.Point(509, 162)
        Me.cbx_cajero.Name = "cbx_cajero"
        Me.cbx_cajero.Size = New System.Drawing.Size(56, 17)
        Me.cbx_cajero.TabIndex = 22
        Me.cbx_cajero.Text = "Todos"
        Me.cbx_cajero.UseVisualStyleBackColor = True
        '
        'cbx_caja
        '
        Me.cbx_caja.AutoSize = True
        Me.cbx_caja.Location = New System.Drawing.Point(509, 17)
        Me.cbx_caja.Name = "cbx_caja"
        Me.cbx_caja.Size = New System.Drawing.Size(56, 17)
        Me.cbx_caja.TabIndex = 21
        Me.cbx_caja.Text = "Todos"
        Me.cbx_caja.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cajero"
        '
        'cbx_Clientes
        '
        Me.cbx_Clientes.AutoSize = True
        Me.cbx_Clientes.Location = New System.Drawing.Point(624, 103)
        Me.cbx_Clientes.Name = "cbx_Clientes"
        Me.cbx_Clientes.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Clientes.TabIndex = 18
        Me.cbx_Clientes.Text = "Todos"
        Me.cbx_Clientes.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(103, 187)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 12
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Clientes
        '
        Me.lbl_Clientes.AutoSize = True
        Me.lbl_Clientes.Location = New System.Drawing.Point(57, 103)
        Me.lbl_Clientes.Name = "lbl_Clientes"
        Me.lbl_Clientes.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Clientes.TabIndex = 15
        Me.lbl_Clientes.Text = "Cliente"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(585, 40)
        Me.dtp_Hasta.MinDate = New Date(2009, 8, 13, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 14
        Me.dtp_Hasta.Visible = False
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(585, 15)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 13
        Me.dtp_Desde.Visible = False
        '
        'cbx_Corte
        '
        Me.cbx_Corte.AutoSize = True
        Me.cbx_Corte.Location = New System.Drawing.Point(218, 132)
        Me.cbx_Corte.Name = "cbx_Corte"
        Me.cbx_Corte.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Corte.TabIndex = 11
        Me.cbx_Corte.Text = "Todos"
        Me.cbx_Corte.UseVisualStyleBackColor = True
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(65, 132)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Corte.TabIndex = 9
        Me.lbl_Corte.Text = "Corte"
        '
        'cbx_Status
        '
        Me.cbx_Status.AutoSize = True
        Me.cbx_Status.Location = New System.Drawing.Point(414, 73)
        Me.cbx_Status.Name = "cbx_Status"
        Me.cbx_Status.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Status.TabIndex = 8
        Me.cbx_Status.Text = "Todos"
        Me.cbx_Status.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(59, 74)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 6
        Me.lbl_Status.Text = "Status"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(58, 45)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 2
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(238, 45)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 4
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(24, 18)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'gbx_Dotaciones
        '
        Me.gbx_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Dotaciones.Controls.Add(Me.Datos)
        Me.gbx_Dotaciones.Controls.Add(Me.lbl_DobleClick)
        Me.gbx_Dotaciones.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_Dotaciones)
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(3, 232)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(1034, 363)
        Me.gbx_Dotaciones.TabIndex = 1
        Me.gbx_Dotaciones.TabStop = False
        Me.gbx_Dotaciones.Text = "Depósitos"
        '
        'Datos
        '
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Location = New System.Drawing.Point(3, 345)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(14, 15)
        Me.Datos.TabIndex = 3
        Me.Datos.Visible = False
        '
        'lbl_DobleClick
        '
        Me.lbl_DobleClick.AutoSize = True
        Me.lbl_DobleClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DobleClick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_DobleClick.Location = New System.Drawing.Point(6, 18)
        Me.lbl_DobleClick.Name = "lbl_DobleClick"
        Me.lbl_DobleClick.Size = New System.Drawing.Size(167, 13)
        Me.lbl_DobleClick.TabIndex = 0
        Me.lbl_DobleClick.Text = "Doble clik para ver detalles."
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(558, 10)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(473, 17)
        Me.Lbl_Registros.TabIndex = 1
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContextMenuStripCopiar
        '
        Me.ContextMenuStripCopiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItemCopiar})
        Me.ContextMenuStripCopiar.Name = "ContextMenuStripCopiar"
        Me.ContextMenuStripCopiar.Size = New System.Drawing.Size(110, 26)
        '
        'CopiarToolStripMenuItemCopiar
        '
        Me.CopiarToolStripMenuItemCopiar.Name = "CopiarToolStripMenuItemCopiar"
        Me.CopiarToolStripMenuItemCopiar.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItemCopiar.Text = "Copiar"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.Btn_Desbloquear)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 593)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(1034, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'Btn_Desbloquear
        '
        Me.Btn_Desbloquear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Desbloquear.Image = Global.Modulo_Proceso.My.Resources.Resources.decrypted
        Me.Btn_Desbloquear.Location = New System.Drawing.Point(155, 13)
        Me.Btn_Desbloquear.Name = "Btn_Desbloquear"
        Me.Btn_Desbloquear.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Desbloquear.TabIndex = 1
        Me.Btn_Desbloquear.Text = "&Desbloquear"
        Me.Btn_Desbloquear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Desbloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Desbloquear.UseVisualStyleBackColor = True
        Me.Btn_Desbloquear.Visible = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(885, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lsv_Dotaciones
        '
        Me.lsv_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotaciones.ContextMenuStrip = Me.ContextMenuStripCopiar
        Me.lsv_Dotaciones.FullRowSelect = True
        Me.lsv_Dotaciones.HideSelection = False
        Me.lsv_Dotaciones.Location = New System.Drawing.Point(9, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotaciones.Lvs = ListViewColumnSorter1
        Me.lsv_Dotaciones.MultiSelect = False
        Me.lsv_Dotaciones.Name = "lsv_Dotaciones"
        Me.lsv_Dotaciones.Row1 = 9
        Me.lsv_Dotaciones.Row10 = 9
        Me.lsv_Dotaciones.Row2 = 9
        Me.lsv_Dotaciones.Row3 = 9
        Me.lsv_Dotaciones.Row4 = 5
        Me.lsv_Dotaciones.Row5 = 25
        Me.lsv_Dotaciones.Row6 = 25
        Me.lsv_Dotaciones.Row7 = 5
        Me.lsv_Dotaciones.Row8 = 9
        Me.lsv_Dotaciones.Row9 = 5
        Me.lsv_Dotaciones.Size = New System.Drawing.Size(1016, 325)
        Me.lsv_Dotaciones.TabIndex = 2
        Me.lsv_Dotaciones.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotaciones.View = System.Windows.Forms.View.Details
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Nothing
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Nothing
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.Location = New System.Drawing.Point(103, 158)
        Me.cmb_Cajero.MaxDropDownItems = 15
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 23
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.txt_Clave
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(218, 99)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Clientes.Sucursal = True
        Me.cmb_Clientes.TabIndex = 17
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'txt_Clave
        '
        Me.txt_Clave.Control_Siguiente = Me.cmb_Clientes
        Me.txt_Clave.Filtrado = False
        Me.txt_Clave.Location = New System.Drawing.Point(103, 101)
        Me.txt_Clave.MaxLength = 12
        Me.txt_Clave.Name = "txt_Clave"
        Me.txt_Clave.Size = New System.Drawing.Size(109, 20)
        Me.txt_Clave.TabIndex = 16
        Me.txt_Clave.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Control_Siguiente = Nothing
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(280, 42)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 5
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Control_Siguiente = Nothing
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(103, 42)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 3
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'tbx_Corte
        '
        Me.tbx_Corte.Control_Siguiente = Nothing
        Me.tbx_Corte.Filtrado = False
        Me.tbx_Corte.Location = New System.Drawing.Point(103, 130)
        Me.tbx_Corte.MaxLength = 10
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.Size = New System.Drawing.Size(109, 20)
        Me.tbx_Corte.TabIndex = 10
        Me.tbx_Corte.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(103, 69)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(305, 21)
        Me.cmb_Status.TabIndex = 7
        Me.cmb_Status.ValueMember = "value"
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
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(103, 15)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 1
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'frm_ConsultaDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 647)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Dotaciones)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaDepositos"
        Me.Text = "Consulta de Depositos"
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.gbx_Dotaciones.PerformLayout()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripCopiar.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Dotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Dotaciones As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents tbx_Corte As Modulo_Proceso.cp_Textbox
    Friend WithEvents cbx_Corte As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Btn_Desbloquear As System.Windows.Forms.Button
    Friend WithEvents cbx_Status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Status As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_DobleClick As System.Windows.Forms.Label
    Friend WithEvents lbl_Clientes As System.Windows.Forms.Label
    Friend WithEvents cmb_Clientes As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents txt_Clave As Modulo_Proceso.cp_Textbox
    Friend WithEvents cbx_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStripCopiar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItemCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbx_cajero As CheckBox
    Friend WithEvents cbx_caja As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Cajero As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Datos As DataGridView
End Class
