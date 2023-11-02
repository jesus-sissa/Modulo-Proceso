<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VerificacionXCajeros
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
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.tbx_ClaveCajero = New Modulo_Proceso.cp_Textbox
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.chk_Cajero = New System.Windows.Forms.CheckBox
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.tbx_Corte = New Modulo_Proceso.cp_Textbox
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Parametro
        Me.Lbl_Sesion2 = New System.Windows.Forms.Label
        Me.Lbl_Sesion = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Parametro
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.chk_CajaBancaria = New System.Windows.Forms.CheckBox
        Me.chk_Corte = New System.Windows.Forms.CheckBox
        Me.lbl_Corte = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox
        Me.lsv_Listado = New Modulo_Proceso.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Parametros.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.tbx_ClaveCajero)
        Me.gbx_Parametros.Controls.Add(Me.chk_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.Lbl_Sesion2)
        Me.gbx_Parametros.Controls.Add(Me.Lbl_Sesion)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Desde)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Parametros.Controls.Add(Me.chk_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.chk_Corte)
        Me.gbx_Parametros.Controls.Add(Me.tbx_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Corte)
        Me.gbx_Parametros.Location = New System.Drawing.Point(5, 0)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(775, 214)
        Me.gbx_Parametros.TabIndex = 0
        Me.gbx_Parametros.TabStop = False
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Me.tbx_ClaveCajero
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.ItemHeight = 13
        Me.cmb_Cajero.Location = New System.Drawing.Point(106, 149)
        Me.cmb_Cajero.MaxDropDownItems = 20
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(425, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 19
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(105, 178)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 21
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'tbx_ClaveCajero
        '
        Me.tbx_ClaveCajero.Control_Siguiente = Nothing
        Me.tbx_ClaveCajero.Filtrado = True
        Me.tbx_ClaveCajero.Location = New System.Drawing.Point(106, 150)
        Me.tbx_ClaveCajero.MaxLength = 12
        Me.tbx_ClaveCajero.Name = "tbx_ClaveCajero"
        Me.tbx_ClaveCajero.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveCajero.TabIndex = 18
        Me.tbx_ClaveCajero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveCajero.Visible = False
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(60, 153)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Cajero.TabIndex = 17
        Me.lbl_Cajero.Text = "Cajero"
        '
        'chk_Cajero
        '
        Me.chk_Cajero.AutoSize = True
        Me.chk_Cajero.Location = New System.Drawing.Point(540, 151)
        Me.chk_Cajero.Name = "chk_Cajero"
        Me.chk_Cajero.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cajero.TabIndex = 20
        Me.chk_Cajero.Text = "Todos"
        Me.chk_Cajero.UseVisualStyleBackColor = True
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Me.cmb_Moneda
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(105, 19)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(370, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 2
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Me.tbx_Corte
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(105, 45)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(272, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 5
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'tbx_Corte
        '
        Me.tbx_Corte.Control_Siguiente = Me.dtp_Desde
        Me.tbx_Corte.Filtrado = False
        Me.tbx_Corte.Location = New System.Drawing.Point(105, 72)
        Me.tbx_Corte.MaxLength = 10
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.Size = New System.Drawing.Size(78, 20)
        Me.tbx_Corte.TabIndex = 7
        Me.tbx_Corte.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(106, 98)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 10
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(23, 23)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(50, 48)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 4
        Me.lbl_Moneda.Text = "Moneda"
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Cia = False
        Me.cmb_Hasta.Control_Siguiente = Me.cmb_Cajero
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(252, 125)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.NombreParametro = "@Fecha"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 16
        Me.cmb_Hasta.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Hasta.ValorParametro = Nothing
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'Lbl_Sesion2
        '
        Me.Lbl_Sesion2.AutoSize = True
        Me.Lbl_Sesion2.Location = New System.Drawing.Point(207, 128)
        Me.Lbl_Sesion2.Name = "Lbl_Sesion2"
        Me.Lbl_Sesion2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Sesion2.TabIndex = 15
        Me.Lbl_Sesion2.Text = "Sesión"
        '
        'Lbl_Sesion
        '
        Me.Lbl_Sesion.AutoSize = True
        Me.Lbl_Sesion.Location = New System.Drawing.Point(207, 102)
        Me.Lbl_Sesion.Name = "Lbl_Sesion"
        Me.Lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Sesion.TabIndex = 11
        Me.Lbl_Sesion.Text = "Sesión"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(60, 102)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 9
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(62, 128)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 13
        Me.lbl_Hasta.Text = "Hasta"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Cia = False
        Me.cmb_Desde.Control_Siguiente = Me.dtp_Hasta
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(252, 99)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.NombreParametro = "@Fecha"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 12
        Me.cmb_Desde.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Desde.ValorParametro = Nothing
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(106, 124)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 14
        '
        'chk_CajaBancaria
        '
        Me.chk_CajaBancaria.AutoSize = True
        Me.chk_CajaBancaria.Location = New System.Drawing.Point(483, 21)
        Me.chk_CajaBancaria.Name = "chk_CajaBancaria"
        Me.chk_CajaBancaria.Size = New System.Drawing.Size(56, 17)
        Me.chk_CajaBancaria.TabIndex = 3
        Me.chk_CajaBancaria.Text = "Todos"
        Me.chk_CajaBancaria.UseVisualStyleBackColor = True
        '
        'chk_Corte
        '
        Me.chk_Corte.AutoSize = True
        Me.chk_Corte.Location = New System.Drawing.Point(190, 73)
        Me.chk_Corte.Name = "chk_Corte"
        Me.chk_Corte.Size = New System.Drawing.Size(56, 17)
        Me.chk_Corte.TabIndex = 8
        Me.chk_Corte.Text = "Todos"
        Me.chk_Corte.UseVisualStyleBackColor = True
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(68, 74)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Corte.TabIndex = 6
        Me.lbl_Corte.Text = "Corte"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(513, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(256, 15)
        Me.Lbl_Registros.TabIndex = 56
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
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(5, 220)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(775, 278)
        Me.gbx_Dotaciones.TabIndex = 1
        Me.gbx_Dotaciones.TabStop = False
        '
        'lsv_Listado
        '
        Me.lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Listado.FullRowSelect = True
        Me.lsv_Listado.HideSelection = False
        Me.lsv_Listado.Location = New System.Drawing.Point(3, 42)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Listado.Lvs = ListViewColumnSorter1
        Me.lsv_Listado.MultiSelect = False
        Me.lsv_Listado.Name = "lsv_Listado"
        Me.lsv_Listado.Row1 = 20
        Me.lsv_Listado.Row10 = 5
        Me.lsv_Listado.Row2 = 5
        Me.lsv_Listado.Row3 = 5
        Me.lsv_Listado.Row4 = 5
        Me.lsv_Listado.Row5 = 5
        Me.lsv_Listado.Row6 = 5
        Me.lsv_Listado.Row7 = 5
        Me.lsv_Listado.Row8 = 5
        Me.lsv_Listado.Row9 = 5
        Me.lsv_Listado.Size = New System.Drawing.Size(769, 233)
        Me.lsv_Listado.TabIndex = 0
        Me.lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 500)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(775, 50)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(626, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_VerificacionXCajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Dotaciones)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_VerificacionXCajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificación por Cajeros"
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_Corte As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Corte As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents chk_CajaBancaria As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents Lbl_Sesion2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
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
End Class
