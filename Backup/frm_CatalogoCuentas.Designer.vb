<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CatalogoCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CatalogoCuentas))
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.chk_Activas = New System.Windows.Forms.CheckBox
        Me.tbx_Banco = New Modulo_Proceso.cp_Textbox
        Me.cmb_Banco = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Banco = New System.Windows.Forms.Label
        Me.btn_Detalles = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.btn_Banco = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New Modulo_Proceso.cp_Textbox
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Proceso.cp_Listview
        Me.Tab_Detalles = New System.Windows.Forms.TabPage
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_BajaRef = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Referencias = New System.Windows.Forms.GroupBox
        Me.btn_BuscarRefDetalles = New System.Windows.Forms.Button
        Me.tbx_BuscarRefDetalles = New Modulo_Proceso.cp_Textbox
        Me.lbl_BuscarDetalles = New System.Windows.Forms.Label
        Me.Btn_AgregarReferenciaDetalles = New System.Windows.Forms.Button
        Me.lsv_ReferenciaDetalles = New Modulo_Proceso.cp_Listview
        Me.tbx_ReferenciaDetalles = New Modulo_Proceso.cp_Textbox
        Me.lbl_ReferenciaDetalles = New System.Windows.Forms.Label
        Me.gbx_Cuentas = New System.Windows.Forms.GroupBox
        Me.btn_Banco2 = New System.Windows.Forms.Button
        Me.cmb_Banco2 = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Banco2 = New System.Windows.Forms.Label
        Me.tbx_CuentaDetalles = New Modulo_Proceso.cp_Textbox
        Me.cmb_PaisDetalles = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_EstadoDetalles = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_CiudadDetalles = New Modulo_Proceso.cp_cmb_Parametro
        Me.lbl_CiudadDetalles = New System.Windows.Forms.Label
        Me.lbl_EstadoDetalles = New System.Windows.Forms.Label
        Me.lbl_PaisDetalles = New System.Windows.Forms.Label
        Me.lbl_CuentaDetalles = New System.Windows.Forms.Label
        Me.lbl_MonedaDetalles = New System.Windows.Forms.Label
        Me.lbl_ReferenciaFijaDetalles = New System.Windows.Forms.Label
        Me.lbl_ReferenciadaDetalles = New System.Windows.Forms.Label
        Me.cmb_MonedaDetalles = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_ReferenciaFijaDetalles = New Modulo_Proceso.cp_cmb_Manual
        Me.cmb_ReferenciadaDetalles = New Modulo_Proceso.cp_cmb_Manual
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Detalles.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Referencias.SuspendLayout()
        Me.gbx_Cuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Detalles)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 561)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.chk_Activas)
        Me.tab_Listado.Controls.Add(Me.tbx_Banco)
        Me.tab_Listado.Controls.Add(Me.cmb_Banco)
        Me.tab_Listado.Controls.Add(Me.lbl_Banco)
        Me.tab_Listado.Controls.Add(Me.btn_Detalles)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.btn_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.btn_Banco)
        Me.tab_Listado.Controls.Add(Me.btn_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(551, 55)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(217, 23)
        Me.lbl_Registros.TabIndex = 50
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_Activas
        '
        Me.chk_Activas.AutoSize = True
        Me.chk_Activas.Checked = True
        Me.chk_Activas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Activas.Location = New System.Drawing.Point(57, 58)
        Me.chk_Activas.Name = "chk_Activas"
        Me.chk_Activas.Size = New System.Drawing.Size(164, 17)
        Me.chk_Activas.TabIndex = 7
        Me.chk_Activas.Text = "Solo mostrar Cuentas Activas"
        Me.chk_Activas.UseVisualStyleBackColor = True
        '
        'tbx_Banco
        '
        Me.tbx_Banco.Control_Siguiente = Nothing
        Me.tbx_Banco.Filtrado = True
        Me.tbx_Banco.Location = New System.Drawing.Point(57, 32)
        Me.tbx_Banco.MaxLength = 12
        Me.tbx_Banco.Name = "tbx_Banco"
        Me.tbx_Banco.Size = New System.Drawing.Size(80, 20)
        Me.tbx_Banco.TabIndex = 4
        Me.tbx_Banco.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Clave = "Clave"
        Me.cmb_Banco.Control_Siguiente = Nothing
        Me.cmb_Banco.DisplayMember = "Nombre_Comercial"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.Filtro = Me.tbx_Banco
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(143, 31)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = False
        Me.cmb_Banco.Size = New System.Drawing.Size(482, 21)
        Me.cmb_Banco.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_Banco.Sucursal = True
        Me.cmb_Banco.TabIndex = 5
        Me.cmb_Banco.Tipo = 0
        Me.cmb_Banco.ValueMember = "Id_CajaBancaria"
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(13, 35)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Banco.TabIndex = 3
        Me.lbl_Banco.Text = "Banco"
        '
        'btn_Detalles
        '
        Me.btn_Detalles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Detalles.Enabled = False
        Me.btn_Detalles.Image = Global.Modulo_Proceso.My.Resources.Resources.Editar
        Me.btn_Detalles.Location = New System.Drawing.Point(151, 497)
        Me.btn_Detalles.Name = "btn_Detalles"
        Me.btn_Detalles.Size = New System.Drawing.Size(140, 30)
        Me.btn_Detalles.TabIndex = 10
        Me.btn_Detalles.Text = "&Detalles"
        Me.btn_Detalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Detalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Detalles.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 497)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 13
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(297, 497)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 11
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.Btn_Baja.Location = New System.Drawing.Point(5, 497)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 9
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        Me.Btn_Baja.Visible = False
        '
        'btn_Banco
        '
        Me.btn_Banco.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Banco.Location = New System.Drawing.Point(630, 29)
        Me.btn_Banco.Name = "btn_Banco"
        Me.btn_Banco.Size = New System.Drawing.Size(26, 23)
        Me.btn_Banco.TabIndex = 6
        Me.btn_Banco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Banco.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(74, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 81)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 20
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 15
        Me.lsv_Catalogo.Row3 = 15
        Me.lsv_Catalogo.Row4 = 20
        Me.lsv_Catalogo.Row5 = 20
        Me.lsv_Catalogo.Row6 = 20
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(762, 410)
        Me.lsv_Catalogo.TabIndex = 8
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'Tab_Detalles
        '
        Me.Tab_Detalles.Controls.Add(Me.gbx_Botones)
        Me.Tab_Detalles.Controls.Add(Me.gbx_Referencias)
        Me.Tab_Detalles.Controls.Add(Me.gbx_Cuentas)
        Me.Tab_Detalles.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Detalles.Name = "Tab_Detalles"
        Me.Tab_Detalles.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Detalles.Size = New System.Drawing.Size(776, 535)
        Me.Tab_Detalles.TabIndex = 1
        Me.Tab_Detalles.Text = "Detalles"
        Me.Tab_Detalles.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_BajaRef)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 480)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(770, 47)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(624, 11)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 2
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_BajaRef
        '
        Me.btn_BajaRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_BajaRef.Enabled = False
        Me.btn_BajaRef.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_BajaRef.Location = New System.Drawing.Point(152, 11)
        Me.btn_BajaRef.Name = "btn_BajaRef"
        Me.btn_BajaRef.Size = New System.Drawing.Size(140, 30)
        Me.btn_BajaRef.TabIndex = 1
        Me.btn_BajaRef.Text = "&Baja/Reingreso"
        Me.btn_BajaRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BajaRef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BajaRef.UseVisualStyleBackColor = True
        Me.btn_BajaRef.Visible = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        Me.btn_Guardar.Visible = False
        '
        'gbx_Referencias
        '
        Me.gbx_Referencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Referencias.Controls.Add(Me.btn_BuscarRefDetalles)
        Me.gbx_Referencias.Controls.Add(Me.tbx_BuscarRefDetalles)
        Me.gbx_Referencias.Controls.Add(Me.lbl_BuscarDetalles)
        Me.gbx_Referencias.Controls.Add(Me.Btn_AgregarReferenciaDetalles)
        Me.gbx_Referencias.Controls.Add(Me.lsv_ReferenciaDetalles)
        Me.gbx_Referencias.Controls.Add(Me.tbx_ReferenciaDetalles)
        Me.gbx_Referencias.Controls.Add(Me.lbl_ReferenciaDetalles)
        Me.gbx_Referencias.Enabled = False
        Me.gbx_Referencias.Location = New System.Drawing.Point(4, 173)
        Me.gbx_Referencias.Name = "gbx_Referencias"
        Me.gbx_Referencias.Size = New System.Drawing.Size(769, 301)
        Me.gbx_Referencias.TabIndex = 1
        Me.gbx_Referencias.TabStop = False
        Me.gbx_Referencias.Text = "Referencias"
        '
        'btn_BuscarRefDetalles
        '
        Me.btn_BuscarRefDetalles.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_BuscarRefDetalles.Location = New System.Drawing.Point(565, 16)
        Me.btn_BuscarRefDetalles.Name = "btn_BuscarRefDetalles"
        Me.btn_BuscarRefDetalles.Size = New System.Drawing.Size(74, 23)
        Me.btn_BuscarRefDetalles.TabIndex = 3
        Me.btn_BuscarRefDetalles.Text = "B&uscar"
        Me.btn_BuscarRefDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarRefDetalles.UseVisualStyleBackColor = True
        '
        'tbx_BuscarRefDetalles
        '
        Me.tbx_BuscarRefDetalles.Control_Siguiente = Me.btn_BuscarRefDetalles
        Me.tbx_BuscarRefDetalles.Filtrado = False
        Me.tbx_BuscarRefDetalles.Location = New System.Drawing.Point(103, 19)
        Me.tbx_BuscarRefDetalles.Name = "tbx_BuscarRefDetalles"
        Me.tbx_BuscarRefDetalles.Size = New System.Drawing.Size(457, 20)
        Me.tbx_BuscarRefDetalles.TabIndex = 2
        Me.tbx_BuscarRefDetalles.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_BuscarDetalles
        '
        Me.lbl_BuscarDetalles.AutoSize = True
        Me.lbl_BuscarDetalles.Location = New System.Drawing.Point(54, 22)
        Me.lbl_BuscarDetalles.Name = "lbl_BuscarDetalles"
        Me.lbl_BuscarDetalles.Size = New System.Drawing.Size(43, 13)
        Me.lbl_BuscarDetalles.TabIndex = 1
        Me.lbl_BuscarDetalles.Text = "Buscar:"
        '
        'Btn_AgregarReferenciaDetalles
        '
        Me.Btn_AgregarReferenciaDetalles.Image = Global.Modulo_Proceso.My.Resources.Resources.Agregar
        Me.Btn_AgregarReferenciaDetalles.Location = New System.Drawing.Point(565, 45)
        Me.Btn_AgregarReferenciaDetalles.Name = "Btn_AgregarReferenciaDetalles"
        Me.Btn_AgregarReferenciaDetalles.Size = New System.Drawing.Size(130, 29)
        Me.Btn_AgregarReferenciaDetalles.TabIndex = 6
        Me.Btn_AgregarReferenciaDetalles.Text = "Agregar"
        Me.Btn_AgregarReferenciaDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_AgregarReferenciaDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AgregarReferenciaDetalles.UseVisualStyleBackColor = True
        Me.Btn_AgregarReferenciaDetalles.Visible = False
        '
        'lsv_ReferenciaDetalles
        '
        Me.lsv_ReferenciaDetalles.AllowColumnReorder = True
        Me.lsv_ReferenciaDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ReferenciaDetalles.FullRowSelect = True
        Me.lsv_ReferenciaDetalles.HideSelection = False
        Me.lsv_ReferenciaDetalles.Location = New System.Drawing.Point(6, 80)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ReferenciaDetalles.Lvs = ListViewColumnSorter2
        Me.lsv_ReferenciaDetalles.MultiSelect = False
        Me.lsv_ReferenciaDetalles.Name = "lsv_ReferenciaDetalles"
        Me.lsv_ReferenciaDetalles.Row1 = 25
        Me.lsv_ReferenciaDetalles.Row10 = 10
        Me.lsv_ReferenciaDetalles.Row2 = 20
        Me.lsv_ReferenciaDetalles.Row3 = 10
        Me.lsv_ReferenciaDetalles.Row4 = 10
        Me.lsv_ReferenciaDetalles.Row5 = 10
        Me.lsv_ReferenciaDetalles.Row6 = 10
        Me.lsv_ReferenciaDetalles.Row7 = 10
        Me.lsv_ReferenciaDetalles.Row8 = 10
        Me.lsv_ReferenciaDetalles.Row9 = 10
        Me.lsv_ReferenciaDetalles.Size = New System.Drawing.Size(757, 215)
        Me.lsv_ReferenciaDetalles.TabIndex = 0
        Me.lsv_ReferenciaDetalles.UseCompatibleStateImageBehavior = False
        Me.lsv_ReferenciaDetalles.View = System.Windows.Forms.View.Details
        '
        'tbx_ReferenciaDetalles
        '
        Me.tbx_ReferenciaDetalles.Control_Siguiente = Me.Btn_AgregarReferenciaDetalles
        Me.tbx_ReferenciaDetalles.Filtrado = True
        Me.tbx_ReferenciaDetalles.Location = New System.Drawing.Point(103, 49)
        Me.tbx_ReferenciaDetalles.MaxLength = 50
        Me.tbx_ReferenciaDetalles.Name = "tbx_ReferenciaDetalles"
        Me.tbx_ReferenciaDetalles.Size = New System.Drawing.Size(457, 20)
        Me.tbx_ReferenciaDetalles.TabIndex = 5
        Me.tbx_ReferenciaDetalles.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ReferenciaDetalles.Visible = False
        '
        'lbl_ReferenciaDetalles
        '
        Me.lbl_ReferenciaDetalles.AutoSize = True
        Me.lbl_ReferenciaDetalles.Location = New System.Drawing.Point(3, 52)
        Me.lbl_ReferenciaDetalles.Name = "lbl_ReferenciaDetalles"
        Me.lbl_ReferenciaDetalles.Size = New System.Drawing.Size(94, 13)
        Me.lbl_ReferenciaDetalles.TabIndex = 4
        Me.lbl_ReferenciaDetalles.Text = "Nueva Referencia"
        Me.lbl_ReferenciaDetalles.Visible = False
        '
        'gbx_Cuentas
        '
        Me.gbx_Cuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cuentas.Controls.Add(Me.btn_Banco2)
        Me.gbx_Cuentas.Controls.Add(Me.cmb_Banco2)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_Banco2)
        Me.gbx_Cuentas.Controls.Add(Me.tbx_CuentaDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_CiudadDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_EstadoDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_PaisDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_CuentaDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_MonedaDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_ReferenciaFijaDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.lbl_ReferenciadaDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.cmb_CiudadDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.cmb_EstadoDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.cmb_PaisDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.cmb_MonedaDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.cmb_ReferenciaFijaDetalles)
        Me.gbx_Cuentas.Controls.Add(Me.cmb_ReferenciadaDetalles)
        Me.gbx_Cuentas.Location = New System.Drawing.Point(4, 6)
        Me.gbx_Cuentas.Name = "gbx_Cuentas"
        Me.gbx_Cuentas.Size = New System.Drawing.Size(769, 161)
        Me.gbx_Cuentas.TabIndex = 0
        Me.gbx_Cuentas.TabStop = False
        Me.gbx_Cuentas.Text = "Cuentas"
        '
        'btn_Banco2
        '
        Me.btn_Banco2.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Banco2.Location = New System.Drawing.Point(489, 16)
        Me.btn_Banco2.Name = "btn_Banco2"
        Me.btn_Banco2.Size = New System.Drawing.Size(26, 23)
        Me.btn_Banco2.TabIndex = 3
        Me.btn_Banco2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Banco2.UseVisualStyleBackColor = True
        '
        'cmb_Banco2
        '
        Me.cmb_Banco2.Clave = "Clave"
        Me.cmb_Banco2.Control_Siguiente = Nothing
        Me.cmb_Banco2.DisplayMember = "Nombre_Comercial"
        Me.cmb_Banco2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco2.Empresa = False
        Me.cmb_Banco2.FormattingEnabled = True
        Me.cmb_Banco2.Location = New System.Drawing.Point(83, 18)
        Me.cmb_Banco2.MaxDropDownItems = 20
        Me.cmb_Banco2.Name = "cmb_Banco2"
        Me.cmb_Banco2.Pista = False
        Me.cmb_Banco2.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Banco2.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_Banco2.Sucursal = True
        Me.cmb_Banco2.TabIndex = 2
        Me.cmb_Banco2.Tipo = 0
        Me.cmb_Banco2.ValueMember = "Id_CajaBancaria"
        '
        'lbl_Banco2
        '
        Me.lbl_Banco2.AutoSize = True
        Me.lbl_Banco2.Location = New System.Drawing.Point(39, 22)
        Me.lbl_Banco2.Name = "lbl_Banco2"
        Me.lbl_Banco2.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Banco2.TabIndex = 0
        Me.lbl_Banco2.Text = "Banco"
        '
        'tbx_CuentaDetalles
        '
        Me.tbx_CuentaDetalles.Control_Siguiente = Me.cmb_PaisDetalles
        Me.tbx_CuentaDetalles.Filtrado = True
        Me.tbx_CuentaDetalles.Location = New System.Drawing.Point(424, 73)
        Me.tbx_CuentaDetalles.MaxLength = 50
        Me.tbx_CuentaDetalles.Name = "tbx_CuentaDetalles"
        Me.tbx_CuentaDetalles.Size = New System.Drawing.Size(268, 20)
        Me.tbx_CuentaDetalles.TabIndex = 11
        Me.tbx_CuentaDetalles.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_PaisDetalles
        '
        Me.cmb_PaisDetalles.Control_Siguiente = Me.cmb_EstadoDetalles
        Me.cmb_PaisDetalles.DisplayMember = "Nombre"
        Me.cmb_PaisDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PaisDetalles.Empresa = False
        Me.cmb_PaisDetalles.FormattingEnabled = True
        Me.cmb_PaisDetalles.Location = New System.Drawing.Point(83, 100)
        Me.cmb_PaisDetalles.MaxDropDownItems = 20
        Me.cmb_PaisDetalles.Name = "cmb_PaisDetalles"
        Me.cmb_PaisDetalles.Pista = True
        Me.cmb_PaisDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_PaisDetalles.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_PaisDetalles.Sucursal = False
        Me.cmb_PaisDetalles.TabIndex = 13
        Me.cmb_PaisDetalles.ValueMember = "Id_Pais"
        '
        'cmb_EstadoDetalles
        '
        Me.cmb_EstadoDetalles.Cia = False
        Me.cmb_EstadoDetalles.Control_Siguiente = Me.cmb_CiudadDetalles
        Me.cmb_EstadoDetalles.DisplayMember = "Nombre"
        Me.cmb_EstadoDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EstadoDetalles.Empresa = False
        Me.cmb_EstadoDetalles.FormattingEnabled = True
        Me.cmb_EstadoDetalles.Location = New System.Drawing.Point(424, 100)
        Me.cmb_EstadoDetalles.MaxDropDownItems = 20
        Me.cmb_EstadoDetalles.Name = "cmb_EstadoDetalles"
        Me.cmb_EstadoDetalles.NombreParametro = "@Id_Pais"
        Me.cmb_EstadoDetalles.Pista = True
        Me.cmb_EstadoDetalles.Size = New System.Drawing.Size(268, 21)
        Me.cmb_EstadoDetalles.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_EstadoDetalles.Sucursal = False
        Me.cmb_EstadoDetalles.TabIndex = 15
        Me.cmb_EstadoDetalles.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_EstadoDetalles.ValorParametro = Nothing
        Me.cmb_EstadoDetalles.ValueMember = "Id_Estado"
        '
        'cmb_CiudadDetalles
        '
        Me.cmb_CiudadDetalles.Cia = False
        Me.cmb_CiudadDetalles.Control_Siguiente = Nothing
        Me.cmb_CiudadDetalles.DisplayMember = "Nombre"
        Me.cmb_CiudadDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadDetalles.Empresa = False
        Me.cmb_CiudadDetalles.FormattingEnabled = True
        Me.cmb_CiudadDetalles.Location = New System.Drawing.Point(83, 127)
        Me.cmb_CiudadDetalles.MaxDropDownItems = 20
        Me.cmb_CiudadDetalles.Name = "cmb_CiudadDetalles"
        Me.cmb_CiudadDetalles.NombreParametro = "@Id_Estado"
        Me.cmb_CiudadDetalles.Pista = True
        Me.cmb_CiudadDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_CiudadDetalles.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_CiudadDetalles.Sucursal = False
        Me.cmb_CiudadDetalles.TabIndex = 17
        Me.cmb_CiudadDetalles.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_CiudadDetalles.ValorParametro = Nothing
        Me.cmb_CiudadDetalles.ValueMember = "Id_Ciudad"
        '
        'lbl_CiudadDetalles
        '
        Me.lbl_CiudadDetalles.AutoSize = True
        Me.lbl_CiudadDetalles.Location = New System.Drawing.Point(37, 130)
        Me.lbl_CiudadDetalles.Name = "lbl_CiudadDetalles"
        Me.lbl_CiudadDetalles.Size = New System.Drawing.Size(40, 13)
        Me.lbl_CiudadDetalles.TabIndex = 16
        Me.lbl_CiudadDetalles.Text = "Ciudad"
        Me.lbl_CiudadDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_EstadoDetalles
        '
        Me.lbl_EstadoDetalles.AutoSize = True
        Me.lbl_EstadoDetalles.Location = New System.Drawing.Point(378, 103)
        Me.lbl_EstadoDetalles.Name = "lbl_EstadoDetalles"
        Me.lbl_EstadoDetalles.Size = New System.Drawing.Size(40, 13)
        Me.lbl_EstadoDetalles.TabIndex = 14
        Me.lbl_EstadoDetalles.Text = "Estado"
        Me.lbl_EstadoDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_PaisDetalles
        '
        Me.lbl_PaisDetalles.AutoSize = True
        Me.lbl_PaisDetalles.Location = New System.Drawing.Point(50, 103)
        Me.lbl_PaisDetalles.Name = "lbl_PaisDetalles"
        Me.lbl_PaisDetalles.Size = New System.Drawing.Size(27, 13)
        Me.lbl_PaisDetalles.TabIndex = 12
        Me.lbl_PaisDetalles.Text = "Pais"
        Me.lbl_PaisDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_CuentaDetalles
        '
        Me.lbl_CuentaDetalles.AutoSize = True
        Me.lbl_CuentaDetalles.Location = New System.Drawing.Point(377, 76)
        Me.lbl_CuentaDetalles.Name = "lbl_CuentaDetalles"
        Me.lbl_CuentaDetalles.Size = New System.Drawing.Size(41, 13)
        Me.lbl_CuentaDetalles.TabIndex = 10
        Me.lbl_CuentaDetalles.Text = "Cuenta"
        Me.lbl_CuentaDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_MonedaDetalles
        '
        Me.lbl_MonedaDetalles.AutoSize = True
        Me.lbl_MonedaDetalles.Location = New System.Drawing.Point(31, 76)
        Me.lbl_MonedaDetalles.Name = "lbl_MonedaDetalles"
        Me.lbl_MonedaDetalles.Size = New System.Drawing.Size(46, 13)
        Me.lbl_MonedaDetalles.TabIndex = 8
        Me.lbl_MonedaDetalles.Text = "Moneda"
        Me.lbl_MonedaDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ReferenciaFijaDetalles
        '
        Me.lbl_ReferenciaFijaDetalles.AutoSize = True
        Me.lbl_ReferenciaFijaDetalles.Location = New System.Drawing.Point(359, 42)
        Me.lbl_ReferenciaFijaDetalles.Name = "lbl_ReferenciaFijaDetalles"
        Me.lbl_ReferenciaFijaDetalles.Size = New System.Drawing.Size(59, 26)
        Me.lbl_ReferenciaFijaDetalles.TabIndex = 6
        Me.lbl_ReferenciaFijaDetalles.Text = "Referencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fija"
        Me.lbl_ReferenciaFijaDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ReferenciadaDetalles
        '
        Me.lbl_ReferenciadaDetalles.AutoSize = True
        Me.lbl_ReferenciadaDetalles.Location = New System.Drawing.Point(6, 42)
        Me.lbl_ReferenciadaDetalles.Name = "lbl_ReferenciadaDetalles"
        Me.lbl_ReferenciadaDetalles.Size = New System.Drawing.Size(71, 26)
        Me.lbl_ReferenciadaDetalles.TabIndex = 4
        Me.lbl_ReferenciadaDetalles.Text = "Cuenta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Referenciada"
        Me.lbl_ReferenciadaDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmb_MonedaDetalles
        '
        Me.cmb_MonedaDetalles.Control_Siguiente = Me.tbx_CuentaDetalles
        Me.cmb_MonedaDetalles.DisplayMember = "Nombre"
        Me.cmb_MonedaDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MonedaDetalles.Empresa = False
        Me.cmb_MonedaDetalles.FormattingEnabled = True
        Me.cmb_MonedaDetalles.Location = New System.Drawing.Point(83, 73)
        Me.cmb_MonedaDetalles.MaxDropDownItems = 20
        Me.cmb_MonedaDetalles.Name = "cmb_MonedaDetalles"
        Me.cmb_MonedaDetalles.Pista = True
        Me.cmb_MonedaDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_MonedaDetalles.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_MonedaDetalles.Sucursal = True
        Me.cmb_MonedaDetalles.TabIndex = 9
        Me.cmb_MonedaDetalles.ValueMember = "Id_Moneda"
        '
        'cmb_ReferenciaFijaDetalles
        '
        Me.cmb_ReferenciaFijaDetalles.Control_Siguiente = Me.cmb_MonedaDetalles
        Me.cmb_ReferenciaFijaDetalles.DisplayMember = "display"
        Me.cmb_ReferenciaFijaDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ReferenciaFijaDetalles.Enabled = False
        Me.cmb_ReferenciaFijaDetalles.FormattingEnabled = True
        Me.cmb_ReferenciaFijaDetalles.Location = New System.Drawing.Point(424, 46)
        Me.cmb_ReferenciaFijaDetalles.MaxDropDownItems = 20
        Me.cmb_ReferenciaFijaDetalles.Name = "cmb_ReferenciaFijaDetalles"
        Me.cmb_ReferenciaFijaDetalles.Size = New System.Drawing.Size(268, 21)
        Me.cmb_ReferenciaFijaDetalles.TabIndex = 7
        Me.cmb_ReferenciaFijaDetalles.ValueMember = "value"
        '
        'cmb_ReferenciadaDetalles
        '
        Me.cmb_ReferenciadaDetalles.Control_Siguiente = Me.cmb_ReferenciaFijaDetalles
        Me.cmb_ReferenciadaDetalles.DisplayMember = "display"
        Me.cmb_ReferenciadaDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ReferenciadaDetalles.FormattingEnabled = True
        Me.cmb_ReferenciadaDetalles.Location = New System.Drawing.Point(83, 46)
        Me.cmb_ReferenciadaDetalles.MaxDropDownItems = 20
        Me.cmb_ReferenciadaDetalles.Name = "cmb_ReferenciadaDetalles"
        Me.cmb_ReferenciadaDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_ReferenciadaDetalles.TabIndex = 5
        Me.cmb_ReferenciadaDetalles.ValueMember = "value"
        '
        'frm_CatalogoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CatalogoCuentas"
        Me.Text = " Catalogo de Cuentas"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Detalles.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Referencias.ResumeLayout(False)
        Me.gbx_Referencias.PerformLayout()
        Me.gbx_Cuentas.ResumeLayout(False)
        Me.gbx_Cuentas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Detalles As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Detalles As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Proceso.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
    Friend WithEvents cmb_Banco As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Referencias As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_AgregarReferenciaDetalles As System.Windows.Forms.Button
    Friend WithEvents lsv_ReferenciaDetalles As Modulo_Proceso.cp_Listview
    Friend WithEvents tbx_ReferenciaDetalles As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_ReferenciaDetalles As System.Windows.Forms.Label
    Friend WithEvents gbx_Cuentas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Banco2 As System.Windows.Forms.Label
    Friend WithEvents tbx_CuentaDetalles As Modulo_Proceso.cp_Textbox
    Friend WithEvents cmb_PaisDetalles As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_EstadoDetalles As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents cmb_CiudadDetalles As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_CiudadDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_EstadoDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_PaisDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_CuentaDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_MonedaDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_ReferenciaFijaDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_ReferenciadaDetalles As System.Windows.Forms.Label
    Friend WithEvents cmb_MonedaDetalles As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_ReferenciaFijaDetalles As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents cmb_ReferenciadaDetalles As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Banco As Modulo_Proceso.cp_Textbox
    Friend WithEvents btn_Banco As System.Windows.Forms.Button
    Friend WithEvents cmb_Banco2 As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Banco2 As System.Windows.Forms.Button
    Friend WithEvents chk_Activas As System.Windows.Forms.CheckBox
    Friend WithEvents btn_BajaRef As System.Windows.Forms.Button
    Friend WithEvents btn_BuscarRefDetalles As System.Windows.Forms.Button
    Friend WithEvents tbx_BuscarRefDetalles As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_BuscarDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
