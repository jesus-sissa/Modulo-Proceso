<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteBilletesFalsos
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
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cbx_Corte = New System.Windows.Forms.CheckBox
        Me.tbx_Corte = New Modulo_Proceso.cp_Textbox
        Me.lbl_Corte = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_TipoConsulta = New System.Windows.Forms.Label
        Me.Tab_TipoConsulta = New System.Windows.Forms.TabControl
        Me.Tab_Fecha = New System.Windows.Forms.TabPage
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Tab_Sesion = New System.Windows.Forms.TabPage
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox
        Me.lbl_Total_Servicios = New System.Windows.Forms.Label
        Me.lsv_Servicios = New Modulo_Proceso.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Fichas = New System.Windows.Forms.GroupBox
        Me.lsv_Fichas = New Modulo_Proceso.cp_Listview
        Me.gbx_Desglose = New System.Windows.Forms.GroupBox
        Me.lsv_Efectivo = New Modulo_Proceso.cp_Listview
        Me.gbx_Falsos = New System.Windows.Forms.GroupBox
        Me.lsv_Falsos = New Modulo_Proceso.cp_Listview
        Me.spl_Desgloses = New System.Windows.Forms.SplitContainer
        Me.gbx_Parametros.SuspendLayout()
        Me.Tab_TipoConsulta.SuspendLayout()
        Me.Tab_Fecha.SuspendLayout()
        Me.Tab_Sesion.SuspendLayout()
        Me.gbx_Servicios.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Fichas.SuspendLayout()
        Me.gbx_Desglose.SuspendLayout()
        Me.gbx_Falsos.SuspendLayout()
        Me.spl_Desgloses.Panel1.SuspendLayout()
        Me.spl_Desgloses.Panel2.SuspendLayout()
        Me.spl_Desgloses.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Parametros.Controls.Add(Me.cbx_Corte)
        Me.gbx_Parametros.Controls.Add(Me.tbx_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.lbl_TipoConsulta)
        Me.gbx_Parametros.Controls.Add(Me.Tab_TipoConsulta)
        Me.gbx_Parametros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Parametros.Location = New System.Drawing.Point(8, 1)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(867, 132)
        Me.gbx_Parametros.TabIndex = 2
        Me.gbx_Parametros.TabStop = False
        Me.gbx_Parametros.Text = "Datos"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(270, 87)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 9
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cbx_Corte
        '
        Me.cbx_Corte.AutoSize = True
        Me.cbx_Corte.Location = New System.Drawing.Point(420, 51)
        Me.cbx_Corte.Name = "cbx_Corte"
        Me.cbx_Corte.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Corte.TabIndex = 8
        Me.cbx_Corte.Text = "Todos"
        Me.cbx_Corte.UseVisualStyleBackColor = True
        '
        'tbx_Corte
        '
        Me.tbx_Corte.Control_Siguiente = Nothing
        Me.tbx_Corte.Filtrado = False
        Me.tbx_Corte.Location = New System.Drawing.Point(305, 49)
        Me.tbx_Corte.MaxLength = 10
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.Size = New System.Drawing.Size(109, 20)
        Me.tbx_Corte.TabIndex = 7
        Me.tbx_Corte.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(267, 51)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Corte.TabIndex = 87
        Me.lbl_Corte.Text = "Corte"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(58, 75)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 83
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(61, 101)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 1
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_TipoConsulta
        '
        Me.lbl_TipoConsulta.AutoSize = True
        Me.lbl_TipoConsulta.Location = New System.Drawing.Point(9, 49)
        Me.lbl_TipoConsulta.Name = "lbl_TipoConsulta"
        Me.lbl_TipoConsulta.Size = New System.Drawing.Size(87, 13)
        Me.lbl_TipoConsulta.TabIndex = 82
        Me.lbl_TipoConsulta.Text = "Tipo de Consulta"
        '
        'Tab_TipoConsulta
        '
        Me.Tab_TipoConsulta.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Tab_TipoConsulta.Controls.Add(Me.Tab_Fecha)
        Me.Tab_TipoConsulta.Controls.Add(Me.Tab_Sesion)
        Me.Tab_TipoConsulta.Location = New System.Drawing.Point(100, 43)
        Me.Tab_TipoConsulta.Name = "Tab_TipoConsulta"
        Me.Tab_TipoConsulta.SelectedIndex = 0
        Me.Tab_TipoConsulta.Size = New System.Drawing.Size(145, 86)
        Me.Tab_TipoConsulta.TabIndex = 2
        '
        'Tab_Fecha
        '
        Me.Tab_Fecha.Controls.Add(Me.dtp_Hasta)
        Me.Tab_Fecha.Controls.Add(Me.dtp_Desde)
        Me.Tab_Fecha.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Fecha.Name = "Tab_Fecha"
        Me.Tab_Fecha.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Fecha.Size = New System.Drawing.Size(137, 57)
        Me.Tab_Fecha.TabIndex = 0
        Me.Tab_Fecha.Text = "Por Fecha"
        Me.Tab_Fecha.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(1, 29)
        Me.dtp_Hasta.MinDate = New Date(2009, 8, 13, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 1
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(1, 3)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 0
        '
        'Tab_Sesion
        '
        Me.Tab_Sesion.Controls.Add(Me.cmb_Hasta)
        Me.Tab_Sesion.Controls.Add(Me.cmb_Desde)
        Me.Tab_Sesion.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Sesion.Name = "Tab_Sesion"
        Me.Tab_Sesion.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Sesion.Size = New System.Drawing.Size(137, 57)
        Me.Tab_Sesion.TabIndex = 1
        Me.Tab_Sesion.Text = "Por Sesion"
        Me.Tab_Sesion.UseVisualStyleBackColor = True
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Control_Siguiente = Nothing
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(3, 30)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 1
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Control_Siguiente = Nothing
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(3, 3)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 0
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(25, 23)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 80
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(104, 19)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 1
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Total_Servicios)
        Me.gbx_Servicios.Controls.Add(Me.lsv_Servicios)
        Me.gbx_Servicios.Location = New System.Drawing.Point(8, 139)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(867, 133)
        Me.gbx_Servicios.TabIndex = 3
        Me.gbx_Servicios.TabStop = False
        Me.gbx_Servicios.Text = "Servicios"
        '
        'lbl_Total_Servicios
        '
        Me.lbl_Total_Servicios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total_Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total_Servicios.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total_Servicios.Location = New System.Drawing.Point(690, 16)
        Me.lbl_Total_Servicios.Name = "lbl_Total_Servicios"
        Me.lbl_Total_Servicios.Size = New System.Drawing.Size(174, 13)
        Me.lbl_Total_Servicios.TabIndex = 1
        Me.lbl_Total_Servicios.Text = "Registros: 0"
        Me.lbl_Total_Servicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Servicios
        '
        Me.lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Servicios.FullRowSelect = True
        Me.lsv_Servicios.HideSelection = False
        Me.lsv_Servicios.Location = New System.Drawing.Point(7, 32)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Servicios.Lvs = ListViewColumnSorter1
        Me.lsv_Servicios.MultiSelect = False
        Me.lsv_Servicios.Name = "lsv_Servicios"
        Me.lsv_Servicios.Row1 = 5
        Me.lsv_Servicios.Row10 = 5
        Me.lsv_Servicios.Row2 = 10
        Me.lsv_Servicios.Row3 = 6
        Me.lsv_Servicios.Row4 = 4
        Me.lsv_Servicios.Row5 = 13
        Me.lsv_Servicios.Row6 = 15
        Me.lsv_Servicios.Row7 = 4
        Me.lsv_Servicios.Row8 = 10
        Me.lsv_Servicios.Row9 = 5
        Me.lsv_Servicios.Size = New System.Drawing.Size(854, 95)
        Me.lsv_Servicios.TabIndex = 0
        Me.lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 704)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(867, 50)
        Me.gbx_Botones.TabIndex = 4
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(718, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 28
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Fichas
        '
        Me.gbx_Fichas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Fichas.Controls.Add(Me.lsv_Fichas)
        Me.gbx_Fichas.Location = New System.Drawing.Point(8, 278)
        Me.gbx_Fichas.Name = "gbx_Fichas"
        Me.gbx_Fichas.Size = New System.Drawing.Size(867, 208)
        Me.gbx_Fichas.TabIndex = 5
        Me.gbx_Fichas.TabStop = False
        Me.gbx_Fichas.Text = "Fichas"
        '
        'lsv_Fichas
        '
        Me.lsv_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Fichas.FullRowSelect = True
        Me.lsv_Fichas.HideSelection = False
        Me.lsv_Fichas.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Fichas.Lvs = ListViewColumnSorter2
        Me.lsv_Fichas.MultiSelect = False
        Me.lsv_Fichas.Name = "lsv_Fichas"
        Me.lsv_Fichas.Row1 = 10
        Me.lsv_Fichas.Row10 = 7
        Me.lsv_Fichas.Row2 = 10
        Me.lsv_Fichas.Row3 = 10
        Me.lsv_Fichas.Row4 = 10
        Me.lsv_Fichas.Row5 = 10
        Me.lsv_Fichas.Row6 = 10
        Me.lsv_Fichas.Row7 = 10
        Me.lsv_Fichas.Row8 = 10
        Me.lsv_Fichas.Row9 = 10
        Me.lsv_Fichas.Size = New System.Drawing.Size(855, 183)
        Me.lsv_Fichas.TabIndex = 0
        Me.lsv_Fichas.UseCompatibleStateImageBehavior = False
        Me.lsv_Fichas.View = System.Windows.Forms.View.Details
        '
        'gbx_Desglose
        '
        Me.gbx_Desglose.Controls.Add(Me.lsv_Efectivo)
        Me.gbx_Desglose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Desglose.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Desglose.Name = "gbx_Desglose"
        Me.gbx_Desglose.Size = New System.Drawing.Size(430, 205)
        Me.gbx_Desglose.TabIndex = 6
        Me.gbx_Desglose.TabStop = False
        Me.gbx_Desglose.Text = "Efectivo"
        '
        'lsv_Efectivo
        '
        Me.lsv_Efectivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Efectivo.FullRowSelect = True
        Me.lsv_Efectivo.HideSelection = False
        Me.lsv_Efectivo.Location = New System.Drawing.Point(7, 19)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Efectivo.Lvs = ListViewColumnSorter3
        Me.lsv_Efectivo.MultiSelect = False
        Me.lsv_Efectivo.Name = "lsv_Efectivo"
        Me.lsv_Efectivo.Row1 = 20
        Me.lsv_Efectivo.Row10 = 0
        Me.lsv_Efectivo.Row2 = 20
        Me.lsv_Efectivo.Row3 = 20
        Me.lsv_Efectivo.Row4 = 20
        Me.lsv_Efectivo.Row5 = 0
        Me.lsv_Efectivo.Row6 = 0
        Me.lsv_Efectivo.Row7 = 0
        Me.lsv_Efectivo.Row8 = 0
        Me.lsv_Efectivo.Row9 = 0
        Me.lsv_Efectivo.Size = New System.Drawing.Size(415, 180)
        Me.lsv_Efectivo.TabIndex = 0
        Me.lsv_Efectivo.UseCompatibleStateImageBehavior = False
        Me.lsv_Efectivo.View = System.Windows.Forms.View.Details
        '
        'gbx_Falsos
        '
        Me.gbx_Falsos.Controls.Add(Me.lsv_Falsos)
        Me.gbx_Falsos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Falsos.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Falsos.Name = "gbx_Falsos"
        Me.gbx_Falsos.Size = New System.Drawing.Size(434, 205)
        Me.gbx_Falsos.TabIndex = 7
        Me.gbx_Falsos.TabStop = False
        Me.gbx_Falsos.Text = "Falsos"
        '
        'lsv_Falsos
        '
        Me.lsv_Falsos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Falsos.FullRowSelect = True
        Me.lsv_Falsos.HideSelection = False
        Me.lsv_Falsos.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Falsos.Lvs = ListViewColumnSorter4
        Me.lsv_Falsos.MultiSelect = False
        Me.lsv_Falsos.Name = "lsv_Falsos"
        Me.lsv_Falsos.Row1 = 30
        Me.lsv_Falsos.Row10 = 0
        Me.lsv_Falsos.Row2 = 30
        Me.lsv_Falsos.Row3 = 30
        Me.lsv_Falsos.Row4 = 0
        Me.lsv_Falsos.Row5 = 0
        Me.lsv_Falsos.Row6 = 0
        Me.lsv_Falsos.Row7 = 0
        Me.lsv_Falsos.Row8 = 0
        Me.lsv_Falsos.Row9 = 0
        Me.lsv_Falsos.Size = New System.Drawing.Size(422, 180)
        Me.lsv_Falsos.TabIndex = 0
        Me.lsv_Falsos.UseCompatibleStateImageBehavior = False
        Me.lsv_Falsos.View = System.Windows.Forms.View.Details
        '
        'spl_Desgloses
        '
        Me.spl_Desgloses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spl_Desgloses.Location = New System.Drawing.Point(8, 493)
        Me.spl_Desgloses.Name = "spl_Desgloses"
        '
        'spl_Desgloses.Panel1
        '
        Me.spl_Desgloses.Panel1.Controls.Add(Me.gbx_Desglose)
        '
        'spl_Desgloses.Panel2
        '
        Me.spl_Desgloses.Panel2.Controls.Add(Me.gbx_Falsos)
        Me.spl_Desgloses.Size = New System.Drawing.Size(868, 205)
        Me.spl_Desgloses.SplitterDistance = 430
        Me.spl_Desgloses.TabIndex = 8
        '
        'frm_ReporteBilletesFalsos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 761)
        Me.Controls.Add(Me.spl_Desgloses)
        Me.Controls.Add(Me.gbx_Fichas)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Servicios)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 800)
        Me.Name = "frm_ReporteBilletesFalsos"
        Me.Text = "Reporte de Billetes Falsos"
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.Tab_TipoConsulta.ResumeLayout(False)
        Me.Tab_Fecha.ResumeLayout(False)
        Me.Tab_Sesion.ResumeLayout(False)
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Fichas.ResumeLayout(False)
        Me.gbx_Desglose.ResumeLayout(False)
        Me.gbx_Falsos.ResumeLayout(False)
        Me.spl_Desgloses.Panel1.ResumeLayout(False)
        Me.spl_Desgloses.Panel2.ResumeLayout(False)
        Me.spl_Desgloses.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cbx_Corte As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Corte As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoConsulta As System.Windows.Forms.Label
    Friend WithEvents Tab_TipoConsulta As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Fecha As System.Windows.Forms.TabPage
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tab_Sesion As System.Windows.Forms.TabPage
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents gbx_Servicios As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Servicios As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Fichas As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Fichas As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Desglose As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Efectivo As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Falsos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Falsos As Modulo_Proceso.cp_Listview
    Friend WithEvents spl_Desgloses As System.Windows.Forms.SplitContainer
    Friend WithEvents lbl_Total_Servicios As System.Windows.Forms.Label
End Class
