<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AcumuladosXCajeros
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
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox
        Me.btn_TiemposCajeroCliente = New System.Windows.Forms.Button
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.btn_Rutas = New System.Windows.Forms.Button
        Me.btn_PiezasGlobal = New System.Windows.Forms.Button
        Me.btn_RemisionesGlobal = New System.Windows.Forms.Button
        Me.btn_Tiempos = New System.Windows.Forms.Button
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.btn_Importes = New System.Windows.Forms.Button
        Me.btn_Piezas = New System.Windows.Forms.Button
        Me.btn_Remisiones = New System.Windows.Forms.Button
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.chk_Cajero = New System.Windows.Forms.CheckBox
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lsv_Listado = New Modulo_Proceso.cp_Listview
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveCajero = New Modulo_Proceso.cp_Textbox
        Me.btn_PiezasSinDificultad = New System.Windows.Forms.Button
        Me.gbx_Parametros.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.btn_PiezasSinDificultad)
        Me.gbx_Parametros.Controls.Add(Me.btn_TiemposCajeroCliente)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Parametros.Controls.Add(Me.btn_Rutas)
        Me.gbx_Parametros.Controls.Add(Me.btn_PiezasGlobal)
        Me.gbx_Parametros.Controls.Add(Me.btn_RemisionesGlobal)
        Me.gbx_Parametros.Controls.Add(Me.btn_Tiempos)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Parametros.Controls.Add(Me.btn_Importes)
        Me.gbx_Parametros.Controls.Add(Me.btn_Piezas)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Desde)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.tbx_ClaveCajero)
        Me.gbx_Parametros.Controls.Add(Me.chk_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.btn_Remisiones)
        Me.gbx_Parametros.Location = New System.Drawing.Point(5, 0)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(880, 211)
        Me.gbx_Parametros.TabIndex = 0
        Me.gbx_Parametros.TabStop = False
        '
        'btn_TiemposCajeroCliente
        '
        Me.btn_TiemposCajeroCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_TiemposCajeroCliente.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_TiemposCajeroCliente.Location = New System.Drawing.Point(632, 132)
        Me.btn_TiemposCajeroCliente.Name = "btn_TiemposCajeroCliente"
        Me.btn_TiemposCajeroCliente.Size = New System.Drawing.Size(168, 30)
        Me.btn_TiemposCajeroCliente.TabIndex = 19
        Me.btn_TiemposCajeroCliente.Text = "&Tiempos Cajero Cliente"
        Me.btn_TiemposCajeroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_TiemposCajeroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TiemposCajeroCliente.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Hasta.Location = New System.Drawing.Point(636, 64)
        Me.dtp_Hasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_Hasta.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(103, 20)
        Me.dtp_Hasta.TabIndex = 18
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Desde.Location = New System.Drawing.Point(636, 40)
        Me.dtp_Desde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_Desde.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(103, 20)
        Me.dtp_Desde.TabIndex = 17
        '
        'btn_Rutas
        '
        Me.btn_Rutas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Rutas.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Rutas.Location = New System.Drawing.Point(632, 174)
        Me.btn_Rutas.Name = "btn_Rutas"
        Me.btn_Rutas.Size = New System.Drawing.Size(168, 30)
        Me.btn_Rutas.TabIndex = 16
        Me.btn_Rutas.Text = "&Rutas"
        Me.btn_Rutas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Rutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Rutas.UseVisualStyleBackColor = True
        '
        'btn_PiezasGlobal
        '
        Me.btn_PiezasGlobal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_PiezasGlobal.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_PiezasGlobal.Location = New System.Drawing.Point(248, 174)
        Me.btn_PiezasGlobal.Name = "btn_PiezasGlobal"
        Me.btn_PiezasGlobal.Size = New System.Drawing.Size(186, 30)
        Me.btn_PiezasGlobal.TabIndex = 15
        Me.btn_PiezasGlobal.Text = "&Piezas Global"
        Me.btn_PiezasGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PiezasGlobal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PiezasGlobal.UseVisualStyleBackColor = True
        '
        'btn_RemisionesGlobal
        '
        Me.btn_RemisionesGlobal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_RemisionesGlobal.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_RemisionesGlobal.Location = New System.Drawing.Point(91, 138)
        Me.btn_RemisionesGlobal.Name = "btn_RemisionesGlobal"
        Me.btn_RemisionesGlobal.Size = New System.Drawing.Size(140, 30)
        Me.btn_RemisionesGlobal.TabIndex = 14
        Me.btn_RemisionesGlobal.Text = "&Remisiones Global"
        Me.btn_RemisionesGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_RemisionesGlobal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_RemisionesGlobal.UseVisualStyleBackColor = True
        '
        'btn_Tiempos
        '
        Me.btn_Tiempos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Tiempos.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Tiempos.Location = New System.Drawing.Point(632, 96)
        Me.btn_Tiempos.Name = "btn_Tiempos"
        Me.btn_Tiempos.Size = New System.Drawing.Size(168, 30)
        Me.btn_Tiempos.TabIndex = 13
        Me.btn_Tiempos.Text = "&TiemposXcajero"
        Me.btn_Tiempos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Tiempos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Tiempos.UseVisualStyleBackColor = True
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(39, 71)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 11
        Me.lbl_Moneda.Text = "Moneda"
        '
        'btn_Importes
        '
        Me.btn_Importes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Importes.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Importes.Location = New System.Drawing.Point(440, 96)
        Me.btn_Importes.Name = "btn_Importes"
        Me.btn_Importes.Size = New System.Drawing.Size(186, 30)
        Me.btn_Importes.TabIndex = 10
        Me.btn_Importes.Text = "&ImportesXcajero"
        Me.btn_Importes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Importes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Importes.UseVisualStyleBackColor = True
        '
        'btn_Piezas
        '
        Me.btn_Piezas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Piezas.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Piezas.Location = New System.Drawing.Point(248, 138)
        Me.btn_Piezas.Name = "btn_Piezas"
        Me.btn_Piezas.Size = New System.Drawing.Size(186, 30)
        Me.btn_Piezas.TabIndex = 9
        Me.btn_Piezas.Text = "&PiezasXcajeroConDificultad"
        Me.btn_Piezas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Piezas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Piezas.UseVisualStyleBackColor = True
        '
        'btn_Remisiones
        '
        Me.btn_Remisiones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Remisiones.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Remisiones.Location = New System.Drawing.Point(91, 96)
        Me.btn_Remisiones.Name = "btn_Remisiones"
        Me.btn_Remisiones.Size = New System.Drawing.Size(140, 30)
        Me.btn_Remisiones.TabIndex = 8
        Me.btn_Remisiones.Text = "&RemisionesXcajero"
        Me.btn_Remisiones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Remisiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Remisiones.UseVisualStyleBackColor = True
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(48, 45)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Cajero.TabIndex = 4
        Me.lbl_Cajero.Text = "Cajero"
        '
        'chk_Cajero
        '
        Me.chk_Cajero.AutoSize = True
        Me.chk_Cajero.Location = New System.Drawing.Point(528, 43)
        Me.chk_Cajero.Name = "chk_Cajero"
        Me.chk_Cajero.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cajero.TabIndex = 7
        Me.chk_Cajero.Text = "Todos"
        Me.chk_Cajero.UseVisualStyleBackColor = True
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(48, 17)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(233, 17)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(513, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(361, 15)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Dotaciones
        '
        Me.gbx_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Dotaciones.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_Listado)
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(5, 236)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(880, 270)
        Me.gbx_Dotaciones.TabIndex = 1
        Me.gbx_Dotaciones.TabStop = False
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(880, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 11)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(731, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lsv_Listado
        '
        Me.lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Listado.FullRowSelect = True
        Me.lsv_Listado.HideSelection = False
        Me.lsv_Listado.Location = New System.Drawing.Point(3, 38)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Listado.Lvs = ListViewColumnSorter3
        Me.lsv_Listado.MultiSelect = False
        Me.lsv_Listado.Name = "lsv_Listado"
        Me.lsv_Listado.Row1 = 8
        Me.lsv_Listado.Row10 = 5
        Me.lsv_Listado.Row2 = 15
        Me.lsv_Listado.Row3 = 8
        Me.lsv_Listado.Row4 = 5
        Me.lsv_Listado.Row5 = 5
        Me.lsv_Listado.Row6 = 5
        Me.lsv_Listado.Row7 = 5
        Me.lsv_Listado.Row8 = 5
        Me.lsv_Listado.Row9 = 5
        Me.lsv_Listado.Size = New System.Drawing.Size(874, 232)
        Me.lsv_Listado.TabIndex = 1
        Me.lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(91, 68)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(232, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 12
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Control_Siguiente = Nothing
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(274, 14)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 3
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Control_Siguiente = Nothing
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(91, 14)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 1
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Me.btn_Remisiones
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Me.tbx_ClaveCajero
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.ItemHeight = 13
        Me.cmb_Cajero.Location = New System.Drawing.Point(91, 41)
        Me.cmb_Cajero.MaxDropDownItems = 20
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(425, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 5
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveCajero
        '
        Me.tbx_ClaveCajero.Control_Siguiente = Nothing
        Me.tbx_ClaveCajero.Filtrado = True
        Me.tbx_ClaveCajero.Location = New System.Drawing.Point(94, 41)
        Me.tbx_ClaveCajero.MaxLength = 12
        Me.tbx_ClaveCajero.Name = "tbx_ClaveCajero"
        Me.tbx_ClaveCajero.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveCajero.TabIndex = 6
        Me.tbx_ClaveCajero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveCajero.Visible = False
        '
        'btn_PiezasSinDificultad
        '
        Me.btn_PiezasSinDificultad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_PiezasSinDificultad.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_PiezasSinDificultad.Location = New System.Drawing.Point(248, 96)
        Me.btn_PiezasSinDificultad.Name = "btn_PiezasSinDificultad"
        Me.btn_PiezasSinDificultad.Size = New System.Drawing.Size(186, 30)
        Me.btn_PiezasSinDificultad.TabIndex = 20
        Me.btn_PiezasSinDificultad.Text = "&PiezasXcajeroSinDificultad"
        Me.btn_PiezasSinDificultad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PiezasSinDificultad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PiezasSinDificultad.UseVisualStyleBackColor = True
        '
        'frm_AcumuladosXCajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 561)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Dotaciones)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_AcumuladosXCajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acumulados por Cajeros"
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Remisiones As System.Windows.Forms.Button
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveCajero As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents chk_Cajero As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_Dotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Listado As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents btn_Piezas As System.Windows.Forms.Button
    Friend WithEvents btn_Importes As System.Windows.Forms.Button
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents btn_Tiempos As System.Windows.Forms.Button
    Friend WithEvents btn_RemisionesGlobal As System.Windows.Forms.Button
    Friend WithEvents btn_PiezasGlobal As System.Windows.Forms.Button
    Friend WithEvents btn_Rutas As System.Windows.Forms.Button
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_TiemposCajeroCliente As System.Windows.Forms.Button
    Friend WithEvents btn_PiezasSinDificultad As System.Windows.Forms.Button
End Class
