<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CatalogoCasaV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CatalogoCasaV))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.Tab_catalogo = New System.Windows.Forms.TabControl
        Me.tab_listado = New System.Windows.Forms.TabPage
        Me.lbl_status = New System.Windows.Forms.Label
        Me.cmb_status = New Modulo_Proceso.cp_cmb_Manual
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_bajaReing = New System.Windows.Forms.Button
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_catalogo = New Modulo_Proceso.cp_Listview
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.tab_nuevo = New System.Windows.Forms.TabPage
        Me.tbx_NombreCasa = New Modulo_Proceso.cp_Textbox
        Me.gbx_codigoBarras = New System.Windows.Forms.GroupBox
        Me.tbx_finNumeroCB = New Modulo_Proceso.cp_Textbox
        Me.lbl_finNumeroCB = New System.Windows.Forms.Label
        Me.tbx_inicioNumeroCB = New Modulo_Proceso.cp_Textbox
        Me.lbl_inicioNumeroCB = New System.Windows.Forms.Label
        Me.tbx_finImporteCB = New Modulo_Proceso.cp_Textbox
        Me.lbl_finImporteCB = New System.Windows.Forms.Label
        Me.tbx_inicioImporteCB = New Modulo_Proceso.cp_Textbox
        Me.lbl_InicioImporteCB = New System.Windows.Forms.Label
        Me.tbx_longitudCB = New Modulo_Proceso.cp_Textbox
        Me.lbl_longitudCB = New System.Windows.Forms.Label
        Me.chk_tieneCB = New System.Windows.Forms.CheckBox
        Me.gbx_BandaMagnetica = New System.Windows.Forms.GroupBox
        Me.tbx_finNumeroMicr = New Modulo_Proceso.cp_Textbox
        Me.lbl_FinNumeroMicr = New System.Windows.Forms.Label
        Me.tbx_inicioNumeroMicr = New Modulo_Proceso.cp_Textbox
        Me.lbl_inicioNumeroMicr = New System.Windows.Forms.Label
        Me.tbx_finImporteMicr = New Modulo_Proceso.cp_Textbox
        Me.lbl_finImporteMicr = New System.Windows.Forms.Label
        Me.tbx_inicioImporteMicr = New Modulo_Proceso.cp_Textbox
        Me.lbl_inicioImporteMicr = New System.Windows.Forms.Label
        Me.tbx_longitudMicr = New Modulo_Proceso.cp_Textbox
        Me.lbl_longitudMicr = New System.Windows.Forms.Label
        Me.chk_tieneBM = New System.Windows.Forms.CheckBox
        Me.lbl_nombreCasa = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Tab_catalogo.SuspendLayout()
        Me.tab_listado.SuspendLayout()
        Me.tab_nuevo.SuspendLayout()
        Me.gbx_codigoBarras.SuspendLayout()
        Me.gbx_BandaMagnetica.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_catalogo
        '
        Me.Tab_catalogo.Controls.Add(Me.tab_listado)
        Me.Tab_catalogo.Controls.Add(Me.tab_nuevo)
        Me.Tab_catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_catalogo.Name = "Tab_catalogo"
        Me.Tab_catalogo.SelectedIndex = 0
        Me.Tab_catalogo.Size = New System.Drawing.Size(784, 561)
        Me.Tab_catalogo.TabIndex = 0
        '
        'tab_listado
        '
        Me.tab_listado.Controls.Add(Me.lbl_status)
        Me.tab_listado.Controls.Add(Me.cmb_status)
        Me.tab_listado.Controls.Add(Me.btn_modificar)
        Me.tab_listado.Controls.Add(Me.btn_bajaReing)
        Me.tab_listado.Controls.Add(Me.btn_cerrar)
        Me.tab_listado.Controls.Add(Me.lbl_Registros)
        Me.tab_listado.Controls.Add(Me.lsv_catalogo)
        Me.tab_listado.Controls.Add(Me.btn_Exportar)
        Me.tab_listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_listado.Name = "tab_listado"
        Me.tab_listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_listado.TabIndex = 0
        Me.tab_listado.Text = "Listado"
        Me.tab_listado.UseVisualStyleBackColor = True
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(8, 9)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(66, 13)
        Me.lbl_status.TabIndex = 14
        Me.lbl_status.Text = "Mostrar Solo"
        '
        'cmb_status
        '
        Me.cmb_status.Control_Siguiente = Nothing
        Me.cmb_status.DisplayMember = "display"
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(80, 6)
        Me.cmb_status.MaxDropDownItems = 20
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(167, 21)
        Me.cmb_status.TabIndex = 13
        Me.cmb_status.ValueMember = "value"
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Image = Global.Modulo_Proceso.My.Resources.Resources.Editar
        Me.btn_modificar.Location = New System.Drawing.Point(155, 502)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_modificar.TabIndex = 12
        Me.btn_modificar.Text = "&Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_bajaReing
        '
        Me.btn_bajaReing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_bajaReing.Enabled = False
        Me.btn_bajaReing.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_bajaReing.Location = New System.Drawing.Point(9, 502)
        Me.btn_bajaReing.Name = "btn_bajaReing"
        Me.btn_bajaReing.Size = New System.Drawing.Size(140, 30)
        Me.btn_bajaReing.TabIndex = 11
        Me.btn_bajaReing.Text = "&Baja/Reing."
        Me.btn_bajaReing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_bajaReing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_bajaReing.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(630, 502)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_cerrar.TabIndex = 10
        Me.btn_cerrar.Text = "&Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(633, 17)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 13)
        Me.lbl_Registros.TabIndex = 9
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_catalogo
        '
        Me.lsv_catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_catalogo.FullRowSelect = True
        Me.lsv_catalogo.HideSelection = False
        Me.lsv_catalogo.Location = New System.Drawing.Point(9, 33)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_catalogo.MultiSelect = False
        Me.lsv_catalogo.Name = "lsv_catalogo"
        Me.lsv_catalogo.Row1 = 60
        Me.lsv_catalogo.Row10 = 0
        Me.lsv_catalogo.Row2 = 0
        Me.lsv_catalogo.Row3 = 0
        Me.lsv_catalogo.Row4 = 0
        Me.lsv_catalogo.Row5 = 0
        Me.lsv_catalogo.Row6 = 0
        Me.lsv_catalogo.Row7 = 0
        Me.lsv_catalogo.Row8 = 0
        Me.lsv_catalogo.Row9 = 0
        Me.lsv_catalogo.Size = New System.Drawing.Size(764, 463)
        Me.lsv_catalogo.TabIndex = 8
        Me.lsv_catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_catalogo.View = System.Windows.Forms.View.Details
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(484, 502)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 6
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'tab_nuevo
        '
        Me.tab_nuevo.Controls.Add(Me.tbx_NombreCasa)
        Me.tab_nuevo.Controls.Add(Me.gbx_codigoBarras)
        Me.tab_nuevo.Controls.Add(Me.chk_tieneCB)
        Me.tab_nuevo.Controls.Add(Me.gbx_BandaMagnetica)
        Me.tab_nuevo.Controls.Add(Me.chk_tieneBM)
        Me.tab_nuevo.Controls.Add(Me.lbl_nombreCasa)
        Me.tab_nuevo.Controls.Add(Me.btn_Cancelar)
        Me.tab_nuevo.Controls.Add(Me.btn_Guardar)
        Me.tab_nuevo.Location = New System.Drawing.Point(4, 22)
        Me.tab_nuevo.Name = "tab_nuevo"
        Me.tab_nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_nuevo.Size = New System.Drawing.Size(776, 535)
        Me.tab_nuevo.TabIndex = 1
        Me.tab_nuevo.Text = "Nuevo"
        Me.tab_nuevo.UseVisualStyleBackColor = True
        '
        'tbx_NombreCasa
        '
        Me.tbx_NombreCasa.Control_Siguiente = Nothing
        Me.tbx_NombreCasa.Filtrado = True
        Me.tbx_NombreCasa.Location = New System.Drawing.Point(89, 23)
        Me.tbx_NombreCasa.MaxLength = 50
        Me.tbx_NombreCasa.Name = "tbx_NombreCasa"
        Me.tbx_NombreCasa.Size = New System.Drawing.Size(339, 20)
        Me.tbx_NombreCasa.TabIndex = 1
        Me.tbx_NombreCasa.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'gbx_codigoBarras
        '
        Me.gbx_codigoBarras.Controls.Add(Me.tbx_finNumeroCB)
        Me.gbx_codigoBarras.Controls.Add(Me.lbl_finNumeroCB)
        Me.gbx_codigoBarras.Controls.Add(Me.tbx_inicioNumeroCB)
        Me.gbx_codigoBarras.Controls.Add(Me.lbl_inicioNumeroCB)
        Me.gbx_codigoBarras.Controls.Add(Me.tbx_finImporteCB)
        Me.gbx_codigoBarras.Controls.Add(Me.lbl_finImporteCB)
        Me.gbx_codigoBarras.Controls.Add(Me.tbx_inicioImporteCB)
        Me.gbx_codigoBarras.Controls.Add(Me.lbl_InicioImporteCB)
        Me.gbx_codigoBarras.Controls.Add(Me.tbx_longitudCB)
        Me.gbx_codigoBarras.Controls.Add(Me.lbl_longitudCB)
        Me.gbx_codigoBarras.Enabled = False
        Me.gbx_codigoBarras.Location = New System.Drawing.Point(239, 205)
        Me.gbx_codigoBarras.Name = "gbx_codigoBarras"
        Me.gbx_codigoBarras.Size = New System.Drawing.Size(189, 154)
        Me.gbx_codigoBarras.TabIndex = 5
        Me.gbx_codigoBarras.TabStop = False
        Me.gbx_codigoBarras.Text = "Parametros Código de Barras"
        '
        'tbx_finNumeroCB
        '
        Me.tbx_finNumeroCB.Control_Siguiente = Nothing
        Me.tbx_finNumeroCB.Filtrado = True
        Me.tbx_finNumeroCB.Location = New System.Drawing.Point(95, 124)
        Me.tbx_finNumeroCB.MaxLength = 2
        Me.tbx_finNumeroCB.Name = "tbx_finNumeroCB"
        Me.tbx_finNumeroCB.Size = New System.Drawing.Size(45, 20)
        Me.tbx_finNumeroCB.TabIndex = 9
        Me.tbx_finNumeroCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_finNumeroCB.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_finNumeroCB
        '
        Me.lbl_finNumeroCB.AutoSize = True
        Me.lbl_finNumeroCB.Location = New System.Drawing.Point(29, 127)
        Me.lbl_finNumeroCB.Name = "lbl_finNumeroCB"
        Me.lbl_finNumeroCB.Size = New System.Drawing.Size(61, 13)
        Me.lbl_finNumeroCB.TabIndex = 8
        Me.lbl_finNumeroCB.Text = "Fin Numero"
        '
        'tbx_inicioNumeroCB
        '
        Me.tbx_inicioNumeroCB.Control_Siguiente = Nothing
        Me.tbx_inicioNumeroCB.Filtrado = True
        Me.tbx_inicioNumeroCB.Location = New System.Drawing.Point(95, 97)
        Me.tbx_inicioNumeroCB.MaxLength = 2
        Me.tbx_inicioNumeroCB.Name = "tbx_inicioNumeroCB"
        Me.tbx_inicioNumeroCB.Size = New System.Drawing.Size(45, 20)
        Me.tbx_inicioNumeroCB.TabIndex = 7
        Me.tbx_inicioNumeroCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_inicioNumeroCB.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_inicioNumeroCB
        '
        Me.lbl_inicioNumeroCB.AutoSize = True
        Me.lbl_inicioNumeroCB.Location = New System.Drawing.Point(18, 100)
        Me.lbl_inicioNumeroCB.Name = "lbl_inicioNumeroCB"
        Me.lbl_inicioNumeroCB.Size = New System.Drawing.Size(72, 13)
        Me.lbl_inicioNumeroCB.TabIndex = 6
        Me.lbl_inicioNumeroCB.Text = "Inicio Numero"
        '
        'tbx_finImporteCB
        '
        Me.tbx_finImporteCB.Control_Siguiente = Nothing
        Me.tbx_finImporteCB.Filtrado = True
        Me.tbx_finImporteCB.Location = New System.Drawing.Point(95, 71)
        Me.tbx_finImporteCB.MaxLength = 2
        Me.tbx_finImporteCB.Name = "tbx_finImporteCB"
        Me.tbx_finImporteCB.Size = New System.Drawing.Size(45, 20)
        Me.tbx_finImporteCB.TabIndex = 5
        Me.tbx_finImporteCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_finImporteCB.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_finImporteCB
        '
        Me.lbl_finImporteCB.AutoSize = True
        Me.lbl_finImporteCB.Location = New System.Drawing.Point(31, 74)
        Me.lbl_finImporteCB.Name = "lbl_finImporteCB"
        Me.lbl_finImporteCB.Size = New System.Drawing.Size(59, 13)
        Me.lbl_finImporteCB.TabIndex = 4
        Me.lbl_finImporteCB.Text = "Fin Importe"
        '
        'tbx_inicioImporteCB
        '
        Me.tbx_inicioImporteCB.Control_Siguiente = Nothing
        Me.tbx_inicioImporteCB.Filtrado = True
        Me.tbx_inicioImporteCB.Location = New System.Drawing.Point(95, 45)
        Me.tbx_inicioImporteCB.MaxLength = 2
        Me.tbx_inicioImporteCB.Name = "tbx_inicioImporteCB"
        Me.tbx_inicioImporteCB.Size = New System.Drawing.Size(45, 20)
        Me.tbx_inicioImporteCB.TabIndex = 3
        Me.tbx_inicioImporteCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_inicioImporteCB.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_InicioImporteCB
        '
        Me.lbl_InicioImporteCB.AutoSize = True
        Me.lbl_InicioImporteCB.Location = New System.Drawing.Point(20, 48)
        Me.lbl_InicioImporteCB.Name = "lbl_InicioImporteCB"
        Me.lbl_InicioImporteCB.Size = New System.Drawing.Size(70, 13)
        Me.lbl_InicioImporteCB.TabIndex = 2
        Me.lbl_InicioImporteCB.Text = "Inicio Importe"
        '
        'tbx_longitudCB
        '
        Me.tbx_longitudCB.Control_Siguiente = Nothing
        Me.tbx_longitudCB.Filtrado = True
        Me.tbx_longitudCB.Location = New System.Drawing.Point(95, 19)
        Me.tbx_longitudCB.MaxLength = 2
        Me.tbx_longitudCB.Name = "tbx_longitudCB"
        Me.tbx_longitudCB.Size = New System.Drawing.Size(45, 20)
        Me.tbx_longitudCB.TabIndex = 1
        Me.tbx_longitudCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_longitudCB.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_longitudCB
        '
        Me.lbl_longitudCB.AutoSize = True
        Me.lbl_longitudCB.Location = New System.Drawing.Point(42, 22)
        Me.lbl_longitudCB.Name = "lbl_longitudCB"
        Me.lbl_longitudCB.Size = New System.Drawing.Size(48, 13)
        Me.lbl_longitudCB.TabIndex = 0
        Me.lbl_longitudCB.Text = "Longitud"
        '
        'chk_tieneCB
        '
        Me.chk_tieneCB.AutoSize = True
        Me.chk_tieneCB.Location = New System.Drawing.Point(89, 250)
        Me.chk_tieneCB.Name = "chk_tieneCB"
        Me.chk_tieneCB.Size = New System.Drawing.Size(137, 17)
        Me.chk_tieneCB.TabIndex = 4
        Me.chk_tieneCB.Text = "Tiene Codigo de Barras"
        Me.chk_tieneCB.UseVisualStyleBackColor = True
        '
        'gbx_BandaMagnetica
        '
        Me.gbx_BandaMagnetica.Controls.Add(Me.tbx_finNumeroMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.lbl_FinNumeroMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.tbx_inicioNumeroMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.lbl_inicioNumeroMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.tbx_finImporteMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.lbl_finImporteMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.tbx_inicioImporteMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.lbl_inicioImporteMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.tbx_longitudMicr)
        Me.gbx_BandaMagnetica.Controls.Add(Me.lbl_longitudMicr)
        Me.gbx_BandaMagnetica.Enabled = False
        Me.gbx_BandaMagnetica.Location = New System.Drawing.Point(239, 49)
        Me.gbx_BandaMagnetica.Name = "gbx_BandaMagnetica"
        Me.gbx_BandaMagnetica.Size = New System.Drawing.Size(189, 150)
        Me.gbx_BandaMagnetica.TabIndex = 2
        Me.gbx_BandaMagnetica.TabStop = False
        Me.gbx_BandaMagnetica.Text = "Parametros Banda Magnetica"
        '
        'tbx_finNumeroMicr
        '
        Me.tbx_finNumeroMicr.Control_Siguiente = Nothing
        Me.tbx_finNumeroMicr.Filtrado = True
        Me.tbx_finNumeroMicr.Location = New System.Drawing.Point(95, 124)
        Me.tbx_finNumeroMicr.MaxLength = 2
        Me.tbx_finNumeroMicr.Name = "tbx_finNumeroMicr"
        Me.tbx_finNumeroMicr.Size = New System.Drawing.Size(45, 20)
        Me.tbx_finNumeroMicr.TabIndex = 9
        Me.tbx_finNumeroMicr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_finNumeroMicr.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_FinNumeroMicr
        '
        Me.lbl_FinNumeroMicr.AutoSize = True
        Me.lbl_FinNumeroMicr.Location = New System.Drawing.Point(29, 127)
        Me.lbl_FinNumeroMicr.Name = "lbl_FinNumeroMicr"
        Me.lbl_FinNumeroMicr.Size = New System.Drawing.Size(61, 13)
        Me.lbl_FinNumeroMicr.TabIndex = 8
        Me.lbl_FinNumeroMicr.Text = "Fin Numero"
        '
        'tbx_inicioNumeroMicr
        '
        Me.tbx_inicioNumeroMicr.Control_Siguiente = Nothing
        Me.tbx_inicioNumeroMicr.Filtrado = True
        Me.tbx_inicioNumeroMicr.Location = New System.Drawing.Point(95, 97)
        Me.tbx_inicioNumeroMicr.MaxLength = 2
        Me.tbx_inicioNumeroMicr.Name = "tbx_inicioNumeroMicr"
        Me.tbx_inicioNumeroMicr.Size = New System.Drawing.Size(45, 20)
        Me.tbx_inicioNumeroMicr.TabIndex = 7
        Me.tbx_inicioNumeroMicr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_inicioNumeroMicr.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_inicioNumeroMicr
        '
        Me.lbl_inicioNumeroMicr.AutoSize = True
        Me.lbl_inicioNumeroMicr.Location = New System.Drawing.Point(18, 100)
        Me.lbl_inicioNumeroMicr.Name = "lbl_inicioNumeroMicr"
        Me.lbl_inicioNumeroMicr.Size = New System.Drawing.Size(72, 13)
        Me.lbl_inicioNumeroMicr.TabIndex = 6
        Me.lbl_inicioNumeroMicr.Text = "Inicio Numero"
        '
        'tbx_finImporteMicr
        '
        Me.tbx_finImporteMicr.Control_Siguiente = Nothing
        Me.tbx_finImporteMicr.Filtrado = True
        Me.tbx_finImporteMicr.Location = New System.Drawing.Point(95, 71)
        Me.tbx_finImporteMicr.MaxLength = 2
        Me.tbx_finImporteMicr.Name = "tbx_finImporteMicr"
        Me.tbx_finImporteMicr.Size = New System.Drawing.Size(45, 20)
        Me.tbx_finImporteMicr.TabIndex = 5
        Me.tbx_finImporteMicr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_finImporteMicr.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_finImporteMicr
        '
        Me.lbl_finImporteMicr.AutoSize = True
        Me.lbl_finImporteMicr.Location = New System.Drawing.Point(31, 74)
        Me.lbl_finImporteMicr.Name = "lbl_finImporteMicr"
        Me.lbl_finImporteMicr.Size = New System.Drawing.Size(59, 13)
        Me.lbl_finImporteMicr.TabIndex = 4
        Me.lbl_finImporteMicr.Text = "Fin Importe"
        '
        'tbx_inicioImporteMicr
        '
        Me.tbx_inicioImporteMicr.Control_Siguiente = Nothing
        Me.tbx_inicioImporteMicr.Filtrado = True
        Me.tbx_inicioImporteMicr.Location = New System.Drawing.Point(95, 45)
        Me.tbx_inicioImporteMicr.MaxLength = 2
        Me.tbx_inicioImporteMicr.Name = "tbx_inicioImporteMicr"
        Me.tbx_inicioImporteMicr.Size = New System.Drawing.Size(45, 20)
        Me.tbx_inicioImporteMicr.TabIndex = 3
        Me.tbx_inicioImporteMicr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_inicioImporteMicr.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_inicioImporteMicr
        '
        Me.lbl_inicioImporteMicr.AutoSize = True
        Me.lbl_inicioImporteMicr.Location = New System.Drawing.Point(20, 48)
        Me.lbl_inicioImporteMicr.Name = "lbl_inicioImporteMicr"
        Me.lbl_inicioImporteMicr.Size = New System.Drawing.Size(70, 13)
        Me.lbl_inicioImporteMicr.TabIndex = 2
        Me.lbl_inicioImporteMicr.Text = "Inicio Importe"
        '
        'tbx_longitudMicr
        '
        Me.tbx_longitudMicr.Control_Siguiente = Nothing
        Me.tbx_longitudMicr.Filtrado = True
        Me.tbx_longitudMicr.Location = New System.Drawing.Point(95, 19)
        Me.tbx_longitudMicr.MaxLength = 2
        Me.tbx_longitudMicr.Name = "tbx_longitudMicr"
        Me.tbx_longitudMicr.Size = New System.Drawing.Size(45, 20)
        Me.tbx_longitudMicr.TabIndex = 1
        Me.tbx_longitudMicr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_longitudMicr.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_longitudMicr
        '
        Me.lbl_longitudMicr.AutoSize = True
        Me.lbl_longitudMicr.Location = New System.Drawing.Point(42, 22)
        Me.lbl_longitudMicr.Name = "lbl_longitudMicr"
        Me.lbl_longitudMicr.Size = New System.Drawing.Size(48, 13)
        Me.lbl_longitudMicr.TabIndex = 0
        Me.lbl_longitudMicr.Text = "Longitud"
        '
        'chk_tieneBM
        '
        Me.chk_tieneBM.AutoSize = True
        Me.chk_tieneBM.Location = New System.Drawing.Point(89, 97)
        Me.chk_tieneBM.Name = "chk_tieneBM"
        Me.chk_tieneBM.Size = New System.Drawing.Size(140, 17)
        Me.chk_tieneBM.TabIndex = 3
        Me.chk_tieneBM.Text = "Tiene Banda Magnetica"
        Me.chk_tieneBM.UseVisualStyleBackColor = True
        '
        'lbl_nombreCasa
        '
        Me.lbl_nombreCasa.AutoSize = True
        Me.lbl_nombreCasa.Location = New System.Drawing.Point(12, 26)
        Me.lbl_nombreCasa.Name = "lbl_nombreCasa"
        Me.lbl_nombreCasa.Size = New System.Drawing.Size(71, 13)
        Me.lbl_nombreCasa.TabIndex = 0
        Me.lbl_nombreCasa.Text = "Nombre Casa"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(288, 403)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 7
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(89, 403)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(89, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 138)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox1"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(89, 49)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Tiene Banda Magnetica"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre Casa"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.Modulo_Proceso.My.Resources.Resources.Cancelar
        Me.Button1.Location = New System.Drawing.Point(252, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.Button2.Location = New System.Drawing.Point(46, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Guardar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_CatalogoCasaV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CatalogoCasaV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo Casas Valeras"
        Me.Tab_catalogo.ResumeLayout(False)
        Me.tab_listado.ResumeLayout(False)
        Me.tab_listado.PerformLayout()
        Me.tab_nuevo.ResumeLayout(False)
        Me.tab_nuevo.PerformLayout()
        Me.gbx_codigoBarras.ResumeLayout(False)
        Me.gbx_codigoBarras.PerformLayout()
        Me.gbx_BandaMagnetica.ResumeLayout(False)
        Me.gbx_BandaMagnetica.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_listado As System.Windows.Forms.TabPage
    Friend WithEvents tab_nuevo As System.Windows.Forms.TabPage
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents lsv_catalogo As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_bajaReing As System.Windows.Forms.Button
    Friend WithEvents gbx_codigoBarras As System.Windows.Forms.GroupBox
    Friend WithEvents chk_tieneCB As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_BandaMagnetica As System.Windows.Forms.GroupBox
    Friend WithEvents chk_tieneBM As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_nombreCasa As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbx_NombreCasa As Modulo_Proceso.cp_Textbox
    Friend WithEvents tbx_inicioNumeroMicr As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_inicioNumeroMicr As System.Windows.Forms.Label
    Friend WithEvents tbx_finImporteMicr As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_finImporteMicr As System.Windows.Forms.Label
    Friend WithEvents tbx_inicioImporteMicr As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_inicioImporteMicr As System.Windows.Forms.Label
    Friend WithEvents tbx_longitudMicr As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_longitudMicr As System.Windows.Forms.Label
    Friend WithEvents tbx_finNumeroCB As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_finNumeroCB As System.Windows.Forms.Label
    Friend WithEvents tbx_inicioNumeroCB As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_inicioNumeroCB As System.Windows.Forms.Label
    Friend WithEvents tbx_finImporteCB As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_finImporteCB As System.Windows.Forms.Label
    Friend WithEvents tbx_inicioImporteCB As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_InicioImporteCB As System.Windows.Forms.Label
    Friend WithEvents tbx_longitudCB As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_longitudCB As System.Windows.Forms.Label
    Friend WithEvents tbx_finNumeroMicr As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_FinNumeroMicr As System.Windows.Forms.Label
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents cmb_status As Modulo_Proceso.cp_cmb_Manual
End Class
