<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenesServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenesServicios))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_TipoDotacion = New System.Windows.Forms.GroupBox
        Me.cmb_TipoDotacion = New Modulo_Proceso.cp_cmb_Manual
        Me.lbl_TipoDotación = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbx_ListaDotaciones = New System.Windows.Forms.GroupBox
        Me.chk_TodoOdes = New System.Windows.Forms.CheckBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Dotaciones = New Modulo_Proceso.cp_Listview
        Me.gbx_DotacionesD = New System.Windows.Forms.GroupBox
        Me.lsv_Divisa = New Modulo_Proceso.cp_Listview
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Confirmar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.tab_Odes = New System.Windows.Forms.TabControl
        Me.tab_DescargarOdes = New System.Windows.Forms.TabPage
        Me.tab_ExportarOrdenes = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmb_Archivo = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.lbl_Archivo = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cmb_TipoDotacionExp = New Modulo_Proceso.cp_cmb_Manual
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_CajaBancariaExp = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk_Todo = New System.Windows.Forms.CheckBox
        Me.lbl_RegistrosExp = New System.Windows.Forms.Label
        Me.lsv_DotacionesExp = New Modulo_Proceso.cp_Listview
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_CerrarExp = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lsv_DivisaExp = New Modulo_Proceso.cp_Listview
        Me.dlg_Dotacion = New System.Windows.Forms.FolderBrowserDialog
        Me.gbx_TipoDotacion.SuspendLayout()
        Me.gbx_ListaDotaciones.SuspendLayout()
        Me.gbx_DotacionesD.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.tab_Odes.SuspendLayout()
        Me.tab_DescargarOdes.SuspendLayout()
        Me.tab_ExportarOrdenes.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_TipoDotacion
        '
        Me.gbx_TipoDotacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_TipoDotacion.Controls.Add(Me.cmb_TipoDotacion)
        Me.gbx_TipoDotacion.Controls.Add(Me.lbl_TipoDotación)
        Me.gbx_TipoDotacion.Controls.Add(Me.Label1)
        Me.gbx_TipoDotacion.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_TipoDotacion.Controls.Add(Me.Label2)
        Me.gbx_TipoDotacion.Location = New System.Drawing.Point(6, 6)
        Me.gbx_TipoDotacion.Name = "gbx_TipoDotacion"
        Me.gbx_TipoDotacion.Size = New System.Drawing.Size(834, 75)
        Me.gbx_TipoDotacion.TabIndex = 6
        Me.gbx_TipoDotacion.TabStop = False
        '
        'cmb_TipoDotacion
        '
        Me.cmb_TipoDotacion.Control_Siguiente = Nothing
        Me.cmb_TipoDotacion.DisplayMember = "display"
        Me.cmb_TipoDotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDotacion.FormattingEnabled = True
        Me.cmb_TipoDotacion.Location = New System.Drawing.Point(92, 12)
        Me.cmb_TipoDotacion.MaxDropDownItems = 20
        Me.cmb_TipoDotacion.Name = "cmb_TipoDotacion"
        Me.cmb_TipoDotacion.Size = New System.Drawing.Size(400, 21)
        Me.cmb_TipoDotacion.TabIndex = 1
        Me.cmb_TipoDotacion.ValueMember = "value"
        '
        'lbl_TipoDotación
        '
        Me.lbl_TipoDotación.AutoSize = True
        Me.lbl_TipoDotación.Location = New System.Drawing.Point(26, 15)
        Me.lbl_TipoDotación.Name = "lbl_TipoDotación"
        Me.lbl_TipoDotación.Size = New System.Drawing.Size(60, 13)
        Me.lbl_TipoDotación.TabIndex = 0
        Me.lbl_TipoDotación.Text = "Tipo Salida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(498, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "*"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = ""
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(92, 41)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGetCR"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 9
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "CR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Caja Bancaria"
        '
        'gbx_ListaDotaciones
        '
        Me.gbx_ListaDotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ListaDotaciones.Controls.Add(Me.chk_TodoOdes)
        Me.gbx_ListaDotaciones.Controls.Add(Me.lbl_Registros)
        Me.gbx_ListaDotaciones.Controls.Add(Me.lsv_Dotaciones)
        Me.gbx_ListaDotaciones.Location = New System.Drawing.Point(6, 87)
        Me.gbx_ListaDotaciones.Name = "gbx_ListaDotaciones"
        Me.gbx_ListaDotaciones.Size = New System.Drawing.Size(834, 240)
        Me.gbx_ListaDotaciones.TabIndex = 11
        Me.gbx_ListaDotaciones.TabStop = False
        '
        'chk_TodoOdes
        '
        Me.chk_TodoOdes.AutoSize = True
        Me.chk_TodoOdes.Location = New System.Drawing.Point(9, 18)
        Me.chk_TodoOdes.Name = "chk_TodoOdes"
        Me.chk_TodoOdes.Size = New System.Drawing.Size(51, 17)
        Me.chk_TodoOdes.TabIndex = 2
        Me.chk_TodoOdes.Text = "Todo"
        Me.chk_TodoOdes.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.AutoSize = True
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(740, 18)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Registros.TabIndex = 1
        Me.lbl_Registros.Text = "Registros: 0"
        '
        'lsv_Dotaciones
        '
        Me.lsv_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotaciones.CheckBoxes = True
        Me.lsv_Dotaciones.FullRowSelect = True
        Me.lsv_Dotaciones.HideSelection = False
        Me.lsv_Dotaciones.Location = New System.Drawing.Point(6, 37)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotaciones.Lvs = ListViewColumnSorter1
        Me.lsv_Dotaciones.MultiSelect = False
        Me.lsv_Dotaciones.Name = "lsv_Dotaciones"
        Me.lsv_Dotaciones.Row1 = 15
        Me.lsv_Dotaciones.Row10 = 20
        Me.lsv_Dotaciones.Row2 = 15
        Me.lsv_Dotaciones.Row3 = 15
        Me.lsv_Dotaciones.Row4 = 15
        Me.lsv_Dotaciones.Row5 = 15
        Me.lsv_Dotaciones.Row6 = 15
        Me.lsv_Dotaciones.Row7 = 15
        Me.lsv_Dotaciones.Row8 = 20
        Me.lsv_Dotaciones.Row9 = 20
        Me.lsv_Dotaciones.Size = New System.Drawing.Size(822, 197)
        Me.lsv_Dotaciones.TabIndex = 0
        Me.lsv_Dotaciones.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotaciones.View = System.Windows.Forms.View.Details
        '
        'gbx_DotacionesD
        '
        Me.gbx_DotacionesD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DotacionesD.Controls.Add(Me.lsv_Divisa)
        Me.gbx_DotacionesD.Location = New System.Drawing.Point(6, 333)
        Me.gbx_DotacionesD.Name = "gbx_DotacionesD"
        Me.gbx_DotacionesD.Size = New System.Drawing.Size(837, 217)
        Me.gbx_DotacionesD.TabIndex = 12
        Me.gbx_DotacionesD.TabStop = False
        '
        'lsv_Divisa
        '
        Me.lsv_Divisa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Divisa.FullRowSelect = True
        Me.lsv_Divisa.HideSelection = False
        Me.lsv_Divisa.Location = New System.Drawing.Point(6, 12)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Divisa.Lvs = ListViewColumnSorter2
        Me.lsv_Divisa.MultiSelect = False
        Me.lsv_Divisa.Name = "lsv_Divisa"
        Me.lsv_Divisa.Row1 = 10
        Me.lsv_Divisa.Row10 = 10
        Me.lsv_Divisa.Row2 = 10
        Me.lsv_Divisa.Row3 = 10
        Me.lsv_Divisa.Row4 = 10
        Me.lsv_Divisa.Row5 = 10
        Me.lsv_Divisa.Row6 = 10
        Me.lsv_Divisa.Row7 = 10
        Me.lsv_Divisa.Row8 = 10
        Me.lsv_Divisa.Row9 = 10
        Me.lsv_Divisa.Size = New System.Drawing.Size(828, 199)
        Me.lsv_Divisa.TabIndex = 0
        Me.lsv_Divisa.UseCompatibleStateImageBehavior = False
        Me.lsv_Divisa.View = System.Windows.Forms.View.Details
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Confirmar)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_botones.Location = New System.Drawing.Point(6, 560)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(834, 51)
        Me.gbx_botones.TabIndex = 13
        Me.gbx_botones.TabStop = False
        '
        'btn_Confirmar
        '
        Me.btn_Confirmar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Confirmar.Image = Global.Modulo_Proceso.My.Resources.Resources.apply
        Me.btn_Confirmar.Location = New System.Drawing.Point(352, 12)
        Me.btn_Confirmar.Name = "btn_Confirmar"
        Me.btn_Confirmar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Confirmar.TabIndex = 3
        Me.btn_Confirmar.Text = "&Confirmar"
        Me.btn_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Confirmar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(685, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(9, 12)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tab_Odes
        '
        Me.tab_Odes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Odes.Controls.Add(Me.tab_DescargarOdes)
        Me.tab_Odes.Controls.Add(Me.tab_ExportarOrdenes)
        Me.tab_Odes.Location = New System.Drawing.Point(5, 3)
        Me.tab_Odes.Name = "tab_Odes"
        Me.tab_Odes.SelectedIndex = 0
        Me.tab_Odes.Size = New System.Drawing.Size(854, 640)
        Me.tab_Odes.TabIndex = 14
        '
        'tab_DescargarOdes
        '
        Me.tab_DescargarOdes.Controls.Add(Me.gbx_ListaDotaciones)
        Me.tab_DescargarOdes.Controls.Add(Me.gbx_TipoDotacion)
        Me.tab_DescargarOdes.Controls.Add(Me.gbx_botones)
        Me.tab_DescargarOdes.Controls.Add(Me.gbx_DotacionesD)
        Me.tab_DescargarOdes.Location = New System.Drawing.Point(4, 22)
        Me.tab_DescargarOdes.Name = "tab_DescargarOdes"
        Me.tab_DescargarOdes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DescargarOdes.Size = New System.Drawing.Size(846, 614)
        Me.tab_DescargarOdes.TabIndex = 0
        Me.tab_DescargarOdes.Text = "Descargar Ordenes de Servicio"
        Me.tab_DescargarOdes.UseVisualStyleBackColor = True
        '
        'tab_ExportarOrdenes
        '
        Me.tab_ExportarOrdenes.Controls.Add(Me.GroupBox4)
        Me.tab_ExportarOrdenes.Controls.Add(Me.GroupBox1)
        Me.tab_ExportarOrdenes.Controls.Add(Me.GroupBox2)
        Me.tab_ExportarOrdenes.Controls.Add(Me.GroupBox3)
        Me.tab_ExportarOrdenes.Location = New System.Drawing.Point(4, 22)
        Me.tab_ExportarOrdenes.Name = "tab_ExportarOrdenes"
        Me.tab_ExportarOrdenes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ExportarOrdenes.Size = New System.Drawing.Size(846, 614)
        Me.tab_ExportarOrdenes.TabIndex = 1
        Me.tab_ExportarOrdenes.Text = "Exportar Ordenes"
        Me.tab_ExportarOrdenes.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.cmb_Archivo)
        Me.GroupBox4.Controls.Add(Me.lbl_Archivo)
        Me.GroupBox4.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox4.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox4.Controls.Add(Me.btn_Mostrar)
        Me.GroupBox4.Controls.Add(Me.cmb_TipoDotacionExp)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmb_CajaBancariaExp)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(831, 161)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'cmb_Archivo
        '
        Me.cmb_Archivo.Clave = ""
        Me.cmb_Archivo.Control_Siguiente = Nothing
        Me.cmb_Archivo.DisplayMember = "Nombre"
        Me.cmb_Archivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Archivo.Empresa = False
        Me.cmb_Archivo.Filtro = Nothing
        Me.cmb_Archivo.FormattingEnabled = True
        Me.cmb_Archivo.Location = New System.Drawing.Point(92, 97)
        Me.cmb_Archivo.MaxDropDownItems = 20
        Me.cmb_Archivo.Name = "cmb_Archivo"
        Me.cmb_Archivo.NombreParametro = Nothing
        Me.cmb_Archivo.Pista = False
        Me.cmb_Archivo.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Archivo.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_Archivo.Sucursal = True
        Me.cmb_Archivo.TabIndex = 14
        Me.cmb_Archivo.Tipo = 0
        Me.cmb_Archivo.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_Archivo.ValorParametro = Nothing
        Me.cmb_Archivo.ValueMember = "Id_Archivo"
        '
        'lbl_Archivo
        '
        Me.lbl_Archivo.AutoSize = True
        Me.lbl_Archivo.Location = New System.Drawing.Point(43, 100)
        Me.lbl_Archivo.Name = "lbl_Archivo"
        Me.lbl_Archivo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Archivo.TabIndex = 13
        Me.lbl_Archivo.Text = "Archivo"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(49, 23)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 12
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(92, 18)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(196, 20)
        Me.dtp_Fecha.TabIndex = 11
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources.bundle_24x24x32b
        Me.btn_Mostrar.Location = New System.Drawing.Point(352, 124)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 2
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cmb_TipoDotacionExp
        '
        Me.cmb_TipoDotacionExp.Control_Siguiente = Nothing
        Me.cmb_TipoDotacionExp.DisplayMember = "display"
        Me.cmb_TipoDotacionExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDotacionExp.FormattingEnabled = True
        Me.cmb_TipoDotacionExp.Location = New System.Drawing.Point(92, 44)
        Me.cmb_TipoDotacionExp.MaxDropDownItems = 20
        Me.cmb_TipoDotacionExp.Name = "cmb_TipoDotacionExp"
        Me.cmb_TipoDotacionExp.Size = New System.Drawing.Size(400, 21)
        Me.cmb_TipoDotacionExp.TabIndex = 1
        Me.cmb_TipoDotacionExp.ValueMember = "value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo Salida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(498, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "*"
        '
        'cmb_CajaBancariaExp
        '
        Me.cmb_CajaBancariaExp.Clave = ""
        Me.cmb_CajaBancariaExp.Control_Siguiente = Nothing
        Me.cmb_CajaBancariaExp.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancariaExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancariaExp.Empresa = False
        Me.cmb_CajaBancariaExp.Enabled = False
        Me.cmb_CajaBancariaExp.Filtro = Nothing
        Me.cmb_CajaBancariaExp.FormattingEnabled = True
        Me.cmb_CajaBancariaExp.Location = New System.Drawing.Point(92, 71)
        Me.cmb_CajaBancariaExp.MaxDropDownItems = 20
        Me.cmb_CajaBancariaExp.Name = "cmb_CajaBancariaExp"
        Me.cmb_CajaBancariaExp.NombreParametro = Nothing
        Me.cmb_CajaBancariaExp.Pista = False
        Me.cmb_CajaBancariaExp.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancariaExp.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancariaExp.Sucursal = True
        Me.cmb_CajaBancariaExp.TabIndex = 9
        Me.cmb_CajaBancariaExp.Tipo = 0
        Me.cmb_CajaBancariaExp.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancariaExp.ValorParametro = Nothing
        Me.cmb_CajaBancariaExp.ValueMember = "Id_CajaBancaria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Caja Bancaria"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chk_Todo)
        Me.GroupBox1.Controls.Add(Me.lbl_RegistrosExp)
        Me.GroupBox1.Controls.Add(Me.lsv_DotacionesExp)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(834, 214)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'chk_Todo
        '
        Me.chk_Todo.AutoSize = True
        Me.chk_Todo.Location = New System.Drawing.Point(9, 22)
        Me.chk_Todo.Name = "chk_Todo"
        Me.chk_Todo.Size = New System.Drawing.Size(51, 17)
        Me.chk_Todo.TabIndex = 3
        Me.chk_Todo.Text = "Todo"
        Me.chk_Todo.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosExp
        '
        Me.lbl_RegistrosExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosExp.AutoSize = True
        Me.lbl_RegistrosExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosExp.Location = New System.Drawing.Point(737, 27)
        Me.lbl_RegistrosExp.Name = "lbl_RegistrosExp"
        Me.lbl_RegistrosExp.Size = New System.Drawing.Size(75, 13)
        Me.lbl_RegistrosExp.TabIndex = 2
        Me.lbl_RegistrosExp.Text = "Registros: 0"
        '
        'lsv_DotacionesExp
        '
        Me.lsv_DotacionesExp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionesExp.CheckBoxes = True
        Me.lsv_DotacionesExp.FullRowSelect = True
        Me.lsv_DotacionesExp.HideSelection = False
        Me.lsv_DotacionesExp.Location = New System.Drawing.Point(6, 43)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_DotacionesExp.Lvs = ListViewColumnSorter3
        Me.lsv_DotacionesExp.MultiSelect = False
        Me.lsv_DotacionesExp.Name = "lsv_DotacionesExp"
        Me.lsv_DotacionesExp.Row1 = 30
        Me.lsv_DotacionesExp.Row10 = 30
        Me.lsv_DotacionesExp.Row2 = 30
        Me.lsv_DotacionesExp.Row3 = 30
        Me.lsv_DotacionesExp.Row4 = 30
        Me.lsv_DotacionesExp.Row5 = 30
        Me.lsv_DotacionesExp.Row6 = 30
        Me.lsv_DotacionesExp.Row7 = 30
        Me.lsv_DotacionesExp.Row8 = 30
        Me.lsv_DotacionesExp.Row9 = 30
        Me.lsv_DotacionesExp.Size = New System.Drawing.Size(822, 165)
        Me.lsv_DotacionesExp.TabIndex = 0
        Me.lsv_DotacionesExp.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionesExp.View = System.Windows.Forms.View.Details
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btn_CerrarExp)
        Me.GroupBox2.Controls.Add(Me.btn_Exportar)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 560)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(834, 51)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btn_CerrarExp
        '
        Me.btn_CerrarExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CerrarExp.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_CerrarExp.Location = New System.Drawing.Point(685, 12)
        Me.btn_CerrarExp.Name = "btn_CerrarExp"
        Me.btn_CerrarExp.Size = New System.Drawing.Size(140, 30)
        Me.btn_CerrarExp.TabIndex = 1
        Me.btn_CerrarExp.Text = "&Cerrar"
        Me.btn_CerrarExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CerrarExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CerrarExp.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.bundle_24x24x32b
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 12)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lsv_DivisaExp)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 386)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(831, 164)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'lsv_DivisaExp
        '
        Me.lsv_DivisaExp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DivisaExp.FullRowSelect = True
        Me.lsv_DivisaExp.HideSelection = False
        Me.lsv_DivisaExp.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_DivisaExp.Lvs = ListViewColumnSorter4
        Me.lsv_DivisaExp.MultiSelect = False
        Me.lsv_DivisaExp.Name = "lsv_DivisaExp"
        Me.lsv_DivisaExp.Row1 = 10
        Me.lsv_DivisaExp.Row10 = 10
        Me.lsv_DivisaExp.Row2 = 10
        Me.lsv_DivisaExp.Row3 = 10
        Me.lsv_DivisaExp.Row4 = 10
        Me.lsv_DivisaExp.Row5 = 10
        Me.lsv_DivisaExp.Row6 = 10
        Me.lsv_DivisaExp.Row7 = 10
        Me.lsv_DivisaExp.Row8 = 10
        Me.lsv_DivisaExp.Row9 = 10
        Me.lsv_DivisaExp.Size = New System.Drawing.Size(819, 139)
        Me.lsv_DivisaExp.TabIndex = 0
        Me.lsv_DivisaExp.UseCompatibleStateImageBehavior = False
        Me.lsv_DivisaExp.View = System.Windows.Forms.View.Details
        '
        'frm_OrdenesServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 644)
        Me.Controls.Add(Me.tab_Odes)
        Me.Name = "frm_OrdenesServicios"
        Me.Text = "Consulta deOrdenes de Servicios"
        Me.gbx_TipoDotacion.ResumeLayout(False)
        Me.gbx_TipoDotacion.PerformLayout()
        Me.gbx_ListaDotaciones.ResumeLayout(False)
        Me.gbx_ListaDotaciones.PerformLayout()
        Me.gbx_DotacionesD.ResumeLayout(False)
        Me.gbx_botones.ResumeLayout(False)
        Me.tab_Odes.ResumeLayout(False)
        Me.tab_DescargarOdes.ResumeLayout(False)
        Me.tab_ExportarOrdenes.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_TipoDotacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_TipoDotacion As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_TipoDotación As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents gbx_ListaDotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Dotaciones As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_DotacionesD As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Divisa As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tab_Odes As System.Windows.Forms.TabControl
    Friend WithEvents tab_DescargarOdes As System.Windows.Forms.TabPage
    Friend WithEvents tab_ExportarOrdenes As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_DotacionesExp As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_CerrarExp As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_DivisaExp As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cmb_TipoDotacionExp As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancariaExp As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dlg_Dotacion As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_Confirmar As System.Windows.Forms.Button
    Friend WithEvents cmb_Archivo As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents lbl_Archivo As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosExp As System.Windows.Forms.Label
    Friend WithEvents chk_Todo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TodoOdes As System.Windows.Forms.CheckBox
End Class
