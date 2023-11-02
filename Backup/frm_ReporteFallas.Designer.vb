<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteFallas
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
        Me.Gbx_Fallas = New System.Windows.Forms.GroupBox
        Me.chk_Otro = New System.Windows.Forms.CheckBox
        Me.tbx_Referencia = New Modulo_Proceso.cp_Textbox
        Me.tbx_Empleado = New Modulo_Proceso.cp_Textbox
        Me.Lbl_NReferencia = New System.Windows.Forms.Label
        Me.chk_Etiqueta = New System.Windows.Forms.CheckBox
        Me.cmb_Inventario = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.tbx_Marca = New Modulo_Proceso.cp_Textbox
        Me.tbx_Modelo = New Modulo_Proceso.cp_Textbox
        Me.tbx_Serie = New Modulo_Proceso.cp_Textbox
        Me.Lbl_Inventario = New System.Windows.Forms.Label
        Me.Lbl_Ejemplo = New System.Windows.Forms.Label
        Me.Lbl_Serie = New System.Windows.Forms.Label
        Me.Lbl_Modelo = New System.Windows.Forms.Label
        Me.Lbl_Marca = New System.Windows.Forms.Label
        Me.cmb_Subclase = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Clase = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Subtipo = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Lbl_SubClase = New System.Windows.Forms.Label
        Me.Lbl_Clase = New System.Windows.Forms.Label
        Me.Lbl_Subtipo = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.tbx_Etiqueta = New Modulo_Proceso.cp_Textbox
        Me.cmb_Tipo = New Modulo_Proceso.cp_cmb_Simple
        Me.Label10 = New System.Windows.Forms.Label
        Me.Lbl_Etiqueta = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Lbl_TipoEquipo = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_Descripcion = New System.Windows.Forms.GroupBox
        Me.tbx_Descripcion = New System.Windows.Forms.RichTextBox
        Me.btn_Adjunto = New System.Windows.Forms.Button
        Me.tbx_Adjunto = New Modulo_Proceso.cp_Textbox
        Me.Lbl_Adjunto = New System.Windows.Forms.Label
        Me.tbx_Ubicacion = New Modulo_Proceso.cp_Textbox
        Me.Lbl_Ubicacion = New System.Windows.Forms.Label
        Me.Lbl_DescripcionFalla = New System.Windows.Forms.Label
        Me.Lbl_UsuarioReporta = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Mensaje = New System.Windows.Forms.GroupBox
        Me.Pct_Alerta = New System.Windows.Forms.PictureBox
        Me.Lbl_Mensaje = New System.Windows.Forms.Label
        Me.Gbx_Fallas.SuspendLayout()
        Me.Gbx_Descripcion.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.Gbx_Mensaje.SuspendLayout()
        CType(Me.Pct_Alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gbx_Fallas
        '
        Me.Gbx_Fallas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Fallas.Controls.Add(Me.chk_Otro)
        Me.Gbx_Fallas.Controls.Add(Me.tbx_Referencia)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_NReferencia)
        Me.Gbx_Fallas.Controls.Add(Me.chk_Etiqueta)
        Me.Gbx_Fallas.Controls.Add(Me.cmb_Inventario)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Inventario)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Ejemplo)
        Me.Gbx_Fallas.Controls.Add(Me.tbx_Serie)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Serie)
        Me.Gbx_Fallas.Controls.Add(Me.tbx_Modelo)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Modelo)
        Me.Gbx_Fallas.Controls.Add(Me.tbx_Marca)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Marca)
        Me.Gbx_Fallas.Controls.Add(Me.cmb_Subclase)
        Me.Gbx_Fallas.Controls.Add(Me.cmb_Clase)
        Me.Gbx_Fallas.Controls.Add(Me.cmb_Subtipo)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_SubClase)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Clase)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Subtipo)
        Me.Gbx_Fallas.Controls.Add(Me.Label11)
        Me.Gbx_Fallas.Controls.Add(Me.tbx_Etiqueta)
        Me.Gbx_Fallas.Controls.Add(Me.Label10)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_Etiqueta)
        Me.Gbx_Fallas.Controls.Add(Me.Label9)
        Me.Gbx_Fallas.Controls.Add(Me.Label7)
        Me.Gbx_Fallas.Controls.Add(Me.Lbl_TipoEquipo)
        Me.Gbx_Fallas.Controls.Add(Me.cmb_Tipo)
        Me.Gbx_Fallas.Location = New System.Drawing.Point(12, 7)
        Me.Gbx_Fallas.Name = "Gbx_Fallas"
        Me.Gbx_Fallas.Size = New System.Drawing.Size(563, 298)
        Me.Gbx_Fallas.TabIndex = 0
        Me.Gbx_Fallas.TabStop = False
        '
        'chk_Otro
        '
        Me.chk_Otro.AutoSize = True
        Me.chk_Otro.Enabled = False
        Me.chk_Otro.Location = New System.Drawing.Point(507, 177)
        Me.chk_Otro.Name = "chk_Otro"
        Me.chk_Otro.Size = New System.Drawing.Size(46, 17)
        Me.chk_Otro.TabIndex = 26
        Me.chk_Otro.Text = "Otro"
        Me.chk_Otro.UseVisualStyleBackColor = True
        '
        'tbx_Referencia
        '
        Me.tbx_Referencia.BackColor = System.Drawing.SystemColors.Control
        Me.tbx_Referencia.Control_Siguiente = Me.tbx_Empleado
        Me.tbx_Referencia.Enabled = False
        Me.tbx_Referencia.Filtrado = True
        Me.tbx_Referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Referencia.Location = New System.Drawing.Point(126, 256)
        Me.tbx_Referencia.MaxLength = 50
        Me.tbx_Referencia.Name = "tbx_Referencia"
        Me.tbx_Referencia.ReadOnly = True
        Me.tbx_Referencia.Size = New System.Drawing.Size(171, 21)
        Me.tbx_Referencia.TabIndex = 25
        Me.tbx_Referencia.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Empleado
        '
        Me.tbx_Empleado.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Empleado.Control_Siguiente = Nothing
        Me.tbx_Empleado.Enabled = False
        Me.tbx_Empleado.Filtrado = True
        Me.tbx_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Empleado.Location = New System.Drawing.Point(126, 14)
        Me.tbx_Empleado.MaxLength = 50
        Me.tbx_Empleado.Name = "tbx_Empleado"
        Me.tbx_Empleado.Size = New System.Drawing.Size(375, 21)
        Me.tbx_Empleado.TabIndex = 1
        Me.tbx_Empleado.TabStop = False
        Me.tbx_Empleado.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_NReferencia
        '
        Me.Lbl_NReferencia.AutoSize = True
        Me.Lbl_NReferencia.Location = New System.Drawing.Point(41, 261)
        Me.Lbl_NReferencia.Name = "Lbl_NReferencia"
        Me.Lbl_NReferencia.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_NReferencia.TabIndex = 24
        Me.Lbl_NReferencia.Text = "No. Referencia"
        '
        'chk_Etiqueta
        '
        Me.chk_Etiqueta.AutoSize = True
        Me.chk_Etiqueta.Location = New System.Drawing.Point(330, 21)
        Me.chk_Etiqueta.Name = "chk_Etiqueta"
        Me.chk_Etiqueta.Size = New System.Drawing.Size(108, 17)
        Me.chk_Etiqueta.TabIndex = 2
        Me.chk_Etiqueta.Text = "No tiene Etiqueta"
        Me.chk_Etiqueta.UseVisualStyleBackColor = True
        '
        'cmb_Inventario
        '
        Me.cmb_Inventario.Clave = "Descripcion"
        Me.cmb_Inventario.Control_Siguiente = Me.tbx_Marca
        Me.cmb_Inventario.DisplayMember = "Descripcion"
        Me.cmb_Inventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Inventario.Empresa = False
        Me.cmb_Inventario.Enabled = False
        Me.cmb_Inventario.Filtro = Nothing
        Me.cmb_Inventario.FormattingEnabled = True
        Me.cmb_Inventario.Location = New System.Drawing.Point(126, 175)
        Me.cmb_Inventario.MaxDropDownItems = 20
        Me.cmb_Inventario.Name = "cmb_Inventario"
        Me.cmb_Inventario.Pista = False
        Me.cmb_Inventario.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Inventario.StoredProcedure = "Inv_Inventario_ComboGet"
        Me.cmb_Inventario.Sucursal = False
        Me.cmb_Inventario.TabIndex = 17
        Me.cmb_Inventario.Tipo = 0
        Me.cmb_Inventario.ValueMember = "Id_Inventario"
        '
        'tbx_Marca
        '
        Me.tbx_Marca.BackColor = System.Drawing.SystemColors.Control
        Me.tbx_Marca.Control_Siguiente = Me.tbx_Modelo
        Me.tbx_Marca.Enabled = False
        Me.tbx_Marca.Filtrado = True
        Me.tbx_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Marca.Location = New System.Drawing.Point(126, 202)
        Me.tbx_Marca.MaxLength = 50
        Me.tbx_Marca.Name = "tbx_Marca"
        Me.tbx_Marca.ReadOnly = True
        Me.tbx_Marca.Size = New System.Drawing.Size(375, 21)
        Me.tbx_Marca.TabIndex = 19
        Me.tbx_Marca.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Modelo
        '
        Me.tbx_Modelo.BackColor = System.Drawing.SystemColors.Control
        Me.tbx_Modelo.Control_Siguiente = Me.tbx_Serie
        Me.tbx_Modelo.Enabled = False
        Me.tbx_Modelo.Filtrado = True
        Me.tbx_Modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Modelo.Location = New System.Drawing.Point(126, 229)
        Me.tbx_Modelo.MaxLength = 50
        Me.tbx_Modelo.Name = "tbx_Modelo"
        Me.tbx_Modelo.ReadOnly = True
        Me.tbx_Modelo.Size = New System.Drawing.Size(171, 21)
        Me.tbx_Modelo.TabIndex = 21
        Me.tbx_Modelo.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Serie
        '
        Me.tbx_Serie.BackColor = System.Drawing.SystemColors.Control
        Me.tbx_Serie.Control_Siguiente = Me.tbx_Empleado
        Me.tbx_Serie.Enabled = False
        Me.tbx_Serie.Filtrado = True
        Me.tbx_Serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Serie.Location = New System.Drawing.Point(340, 229)
        Me.tbx_Serie.MaxLength = 50
        Me.tbx_Serie.Name = "tbx_Serie"
        Me.tbx_Serie.ReadOnly = True
        Me.tbx_Serie.Size = New System.Drawing.Size(161, 21)
        Me.tbx_Serie.TabIndex = 23
        Me.tbx_Serie.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Inventario
        '
        Me.Lbl_Inventario.AutoSize = True
        Me.Lbl_Inventario.Location = New System.Drawing.Point(66, 178)
        Me.Lbl_Inventario.Name = "Lbl_Inventario"
        Me.Lbl_Inventario.Size = New System.Drawing.Size(54, 13)
        Me.Lbl_Inventario.TabIndex = 16
        Me.Lbl_Inventario.Text = "Inventario"
        '
        'Lbl_Ejemplo
        '
        Me.Lbl_Ejemplo.AutoSize = True
        Me.Lbl_Ejemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ejemplo.Location = New System.Drawing.Point(123, 45)
        Me.Lbl_Ejemplo.Name = "Lbl_Ejemplo"
        Me.Lbl_Ejemplo.Size = New System.Drawing.Size(150, 13)
        Me.Lbl_Ejemplo.TabIndex = 3
        Me.Lbl_Ejemplo.Text = "Ejemplo: 0306020201015"
        '
        'Lbl_Serie
        '
        Me.Lbl_Serie.AutoSize = True
        Me.Lbl_Serie.Location = New System.Drawing.Point(303, 234)
        Me.Lbl_Serie.Name = "Lbl_Serie"
        Me.Lbl_Serie.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_Serie.TabIndex = 22
        Me.Lbl_Serie.Text = "Serie"
        '
        'Lbl_Modelo
        '
        Me.Lbl_Modelo.AutoSize = True
        Me.Lbl_Modelo.Location = New System.Drawing.Point(79, 234)
        Me.Lbl_Modelo.Name = "Lbl_Modelo"
        Me.Lbl_Modelo.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_Modelo.TabIndex = 20
        Me.Lbl_Modelo.Text = "Modelo"
        '
        'Lbl_Marca
        '
        Me.Lbl_Marca.AutoSize = True
        Me.Lbl_Marca.Location = New System.Drawing.Point(83, 207)
        Me.Lbl_Marca.Name = "Lbl_Marca"
        Me.Lbl_Marca.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Marca.TabIndex = 18
        Me.Lbl_Marca.Text = "Marca"
        '
        'cmb_Subclase
        '
        Me.cmb_Subclase.Clave = "Clave"
        Me.cmb_Subclase.Control_Siguiente = Me.tbx_Marca
        Me.cmb_Subclase.DisplayMember = "Descripcion"
        Me.cmb_Subclase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Subclase.Empresa = False
        Me.cmb_Subclase.Enabled = False
        Me.cmb_Subclase.Filtro = Nothing
        Me.cmb_Subclase.FormattingEnabled = True
        Me.cmb_Subclase.Location = New System.Drawing.Point(126, 148)
        Me.cmb_Subclase.MaxDropDownItems = 20
        Me.cmb_Subclase.Name = "cmb_Subclase"
        Me.cmb_Subclase.Pista = False
        Me.cmb_Subclase.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Subclase.StoredProcedure = "Inv_SubClases_Get"
        Me.cmb_Subclase.Sucursal = False
        Me.cmb_Subclase.TabIndex = 14
        Me.cmb_Subclase.Tipo = 0
        Me.cmb_Subclase.ValueMember = "Id_SubClase"
        '
        'cmb_Clase
        '
        Me.cmb_Clase.Clave = "Clave"
        Me.cmb_Clase.Control_Siguiente = Me.cmb_Subclase
        Me.cmb_Clase.DisplayMember = "Descripcion"
        Me.cmb_Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clase.Empresa = False
        Me.cmb_Clase.Enabled = False
        Me.cmb_Clase.Filtro = Nothing
        Me.cmb_Clase.FormattingEnabled = True
        Me.cmb_Clase.Location = New System.Drawing.Point(126, 121)
        Me.cmb_Clase.MaxDropDownItems = 20
        Me.cmb_Clase.Name = "cmb_Clase"
        Me.cmb_Clase.Pista = False
        Me.cmb_Clase.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Clase.StoredProcedure = "inv_Clases_get"
        Me.cmb_Clase.Sucursal = False
        Me.cmb_Clase.TabIndex = 11
        Me.cmb_Clase.Tipo = 0
        Me.cmb_Clase.ValueMember = "Id_Clase"
        '
        'cmb_Subtipo
        '
        Me.cmb_Subtipo.Clave = "Clave"
        Me.cmb_Subtipo.Control_Siguiente = Me.cmb_Clase
        Me.cmb_Subtipo.DisplayMember = "Descripcion"
        Me.cmb_Subtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Subtipo.Empresa = False
        Me.cmb_Subtipo.Enabled = False
        Me.cmb_Subtipo.Filtro = Nothing
        Me.cmb_Subtipo.FormattingEnabled = True
        Me.cmb_Subtipo.Location = New System.Drawing.Point(126, 94)
        Me.cmb_Subtipo.MaxDropDownItems = 20
        Me.cmb_Subtipo.Name = "cmb_Subtipo"
        Me.cmb_Subtipo.Pista = False
        Me.cmb_Subtipo.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Subtipo.StoredProcedure = "inv_Subtipos_get"
        Me.cmb_Subtipo.Sucursal = False
        Me.cmb_Subtipo.TabIndex = 8
        Me.cmb_Subtipo.Tipo = 0
        Me.cmb_Subtipo.ValueMember = "Id_Subtipo"
        '
        'Lbl_SubClase
        '
        Me.Lbl_SubClase.AutoSize = True
        Me.Lbl_SubClase.Location = New System.Drawing.Point(69, 151)
        Me.Lbl_SubClase.Name = "Lbl_SubClase"
        Me.Lbl_SubClase.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_SubClase.TabIndex = 13
        Me.Lbl_SubClase.Text = "Subclase"
        '
        'Lbl_Clase
        '
        Me.Lbl_Clase.AutoSize = True
        Me.Lbl_Clase.Location = New System.Drawing.Point(87, 124)
        Me.Lbl_Clase.Name = "Lbl_Clase"
        Me.Lbl_Clase.Size = New System.Drawing.Size(33, 13)
        Me.Lbl_Clase.TabIndex = 10
        Me.Lbl_Clase.Text = "Clase"
        '
        'Lbl_Subtipo
        '
        Me.Lbl_Subtipo.AutoSize = True
        Me.Lbl_Subtipo.Location = New System.Drawing.Point(77, 97)
        Me.Lbl_Subtipo.Name = "Lbl_Subtipo"
        Me.Lbl_Subtipo.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Subtipo.TabIndex = 7
        Me.Lbl_Subtipo.Text = "Subtipo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(507, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "*"
        '
        'tbx_Etiqueta
        '
        Me.tbx_Etiqueta.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Etiqueta.Control_Siguiente = Me.cmb_Tipo
        Me.tbx_Etiqueta.Filtrado = True
        Me.tbx_Etiqueta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Etiqueta.Location = New System.Drawing.Point(126, 16)
        Me.tbx_Etiqueta.MaxLength = 50
        Me.tbx_Etiqueta.Name = "tbx_Etiqueta"
        Me.tbx_Etiqueta.Size = New System.Drawing.Size(198, 26)
        Me.tbx_Etiqueta.TabIndex = 1
        Me.tbx_Etiqueta.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Me.cmb_Subtipo
        Me.cmb_Tipo.DisplayMember = "Descripcion"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.Empresa = False
        Me.cmb_Tipo.Enabled = False
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(126, 67)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Pista = False
        Me.cmb_Tipo.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Tipo.StoredProcedure = "Inv_Tipos_Get"
        Me.cmb_Tipo.Sucursal = False
        Me.cmb_Tipo.TabIndex = 5
        Me.cmb_Tipo.ValueMember = "Id_Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(507, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "*"
        '
        'Lbl_Etiqueta
        '
        Me.Lbl_Etiqueta.AutoSize = True
        Me.Lbl_Etiqueta.Location = New System.Drawing.Point(75, 21)
        Me.Lbl_Etiqueta.Name = "Lbl_Etiqueta"
        Me.Lbl_Etiqueta.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Etiqueta.TabIndex = 0
        Me.Lbl_Etiqueta.Text = "Etiqueta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(507, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(507, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "*"
        '
        'Lbl_TipoEquipo
        '
        Me.Lbl_TipoEquipo.AutoSize = True
        Me.Lbl_TipoEquipo.Location = New System.Drawing.Point(41, 70)
        Me.Lbl_TipoEquipo.Name = "Lbl_TipoEquipo"
        Me.Lbl_TipoEquipo.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_TipoEquipo.TabIndex = 4
        Me.Lbl_TipoEquipo.Text = "Tipo de Equipo"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Gbx_Descripcion
        '
        Me.Gbx_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Descripcion)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Empleado)
        Me.Gbx_Descripcion.Controls.Add(Me.btn_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Ubicacion)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_Ubicacion)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_DescripcionFalla)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_UsuarioReporta)
        Me.Gbx_Descripcion.Controls.Add(Me.Label12)
        Me.Gbx_Descripcion.Location = New System.Drawing.Point(12, 380)
        Me.Gbx_Descripcion.Name = "Gbx_Descripcion"
        Me.Gbx_Descripcion.Size = New System.Drawing.Size(563, 193)
        Me.Gbx_Descripcion.TabIndex = 2
        Me.Gbx_Descripcion.TabStop = False
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbx_Descripcion.Location = New System.Drawing.Point(126, 39)
        Me.tbx_Descripcion.MaxLength = 3000
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(375, 100)
        Me.tbx_Descripcion.TabIndex = 5
        Me.tbx_Descripcion.Text = ""
        '
        'btn_Adjunto
        '
        Me.btn_Adjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Adjunto.Location = New System.Drawing.Point(507, 168)
        Me.btn_Adjunto.Name = "btn_Adjunto"
        Me.btn_Adjunto.Size = New System.Drawing.Size(29, 23)
        Me.btn_Adjunto.TabIndex = 11
        Me.btn_Adjunto.Text = "..."
        Me.btn_Adjunto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Adjunto.UseVisualStyleBackColor = True
        '
        'tbx_Adjunto
        '
        Me.tbx_Adjunto.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Adjunto.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Adjunto.Filtrado = True
        Me.tbx_Adjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Adjunto.Location = New System.Drawing.Point(126, 169)
        Me.tbx_Adjunto.MaxLength = 100
        Me.tbx_Adjunto.Name = "tbx_Adjunto"
        Me.tbx_Adjunto.ReadOnly = True
        Me.tbx_Adjunto.Size = New System.Drawing.Size(375, 20)
        Me.tbx_Adjunto.TabIndex = 10
        Me.tbx_Adjunto.TabStop = False
        Me.tbx_Adjunto.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Adjunto
        '
        Me.Lbl_Adjunto.AutoSize = True
        Me.Lbl_Adjunto.Location = New System.Drawing.Point(20, 174)
        Me.Lbl_Adjunto.Name = "Lbl_Adjunto"
        Me.Lbl_Adjunto.Size = New System.Drawing.Size(100, 13)
        Me.Lbl_Adjunto.TabIndex = 9
        Me.Lbl_Adjunto.Text = "Adjuntar un Archivo"
        '
        'tbx_Ubicacion
        '
        Me.tbx_Ubicacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Ubicacion.Control_Siguiente = Me.btn_Adjunto
        Me.tbx_Ubicacion.Filtrado = True
        Me.tbx_Ubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Ubicacion.Location = New System.Drawing.Point(126, 145)
        Me.tbx_Ubicacion.MaxLength = 100
        Me.tbx_Ubicacion.Name = "tbx_Ubicacion"
        Me.tbx_Ubicacion.Size = New System.Drawing.Size(375, 20)
        Me.tbx_Ubicacion.TabIndex = 8
        Me.tbx_Ubicacion.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Ubicacion
        '
        Me.Lbl_Ubicacion.AutoSize = True
        Me.Lbl_Ubicacion.Location = New System.Drawing.Point(66, 148)
        Me.Lbl_Ubicacion.Name = "Lbl_Ubicacion"
        Me.Lbl_Ubicacion.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_Ubicacion.TabIndex = 7
        Me.Lbl_Ubicacion.Text = "Ubicacion"
        '
        'Lbl_DescripcionFalla
        '
        Me.Lbl_DescripcionFalla.AutoSize = True
        Me.Lbl_DescripcionFalla.Location = New System.Drawing.Point(6, 44)
        Me.Lbl_DescripcionFalla.Name = "Lbl_DescripcionFalla"
        Me.Lbl_DescripcionFalla.Size = New System.Drawing.Size(114, 13)
        Me.Lbl_DescripcionFalla.TabIndex = 4
        Me.Lbl_DescripcionFalla.Text = "Descripción de la Falla"
        '
        'Lbl_UsuarioReporta
        '
        Me.Lbl_UsuarioReporta.AutoSize = True
        Me.Lbl_UsuarioReporta.Location = New System.Drawing.Point(15, 17)
        Me.Lbl_UsuarioReporta.Name = "Lbl_UsuarioReporta"
        Me.Lbl_UsuarioReporta.Size = New System.Drawing.Size(105, 13)
        Me.Lbl_UsuarioReporta.TabIndex = 0
        Me.Lbl_UsuarioReporta.Text = "Usuario que Reporta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(507, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "*"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 579)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(563, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(417, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Mensaje
        '
        Me.Gbx_Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Mensaje.Controls.Add(Me.Pct_Alerta)
        Me.Gbx_Mensaje.Controls.Add(Me.Lbl_Mensaje)
        Me.Gbx_Mensaje.Location = New System.Drawing.Point(12, 309)
        Me.Gbx_Mensaje.Name = "Gbx_Mensaje"
        Me.Gbx_Mensaje.Size = New System.Drawing.Size(563, 62)
        Me.Gbx_Mensaje.TabIndex = 1
        Me.Gbx_Mensaje.TabStop = False
        '
        'Pct_Alerta
        '
        Me.Pct_Alerta.Image = Global.Modulo_Proceso.My.Resources.Resources.Atencion
        Me.Pct_Alerta.Location = New System.Drawing.Point(69, 10)
        Me.Pct_Alerta.Name = "Pct_Alerta"
        Me.Pct_Alerta.Size = New System.Drawing.Size(48, 47)
        Me.Pct_Alerta.TabIndex = 1
        Me.Pct_Alerta.TabStop = False
        '
        'Lbl_Mensaje
        '
        Me.Lbl_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Mensaje.Location = New System.Drawing.Point(123, 14)
        Me.Lbl_Mensaje.Name = "Lbl_Mensaje"
        Me.Lbl_Mensaje.Size = New System.Drawing.Size(399, 38)
        Me.Lbl_Mensaje.TabIndex = 0
        Me.Lbl_Mensaje.Text = "Para agilizar la atención de su reporte es necesario que describa la falla lo mas" & _
            " claro posible."
        '
        'frm_ReporteFallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(584, 641)
        Me.Controls.Add(Me.Gbx_Mensaje)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Descripcion)
        Me.Controls.Add(Me.Gbx_Fallas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(590, 670)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(590, 670)
        Me.Name = "frm_ReporteFallas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Fallas en Mobiliario y Equipo"
        Me.Gbx_Fallas.ResumeLayout(False)
        Me.Gbx_Fallas.PerformLayout()
        Me.Gbx_Descripcion.ResumeLayout(False)
        Me.Gbx_Descripcion.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.Gbx_Mensaje.ResumeLayout(False)
        CType(Me.Pct_Alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Fallas As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_SubClase As System.Windows.Forms.Label
    Friend WithEvents Lbl_Clase As System.Windows.Forms.Label
    Friend WithEvents Lbl_Subtipo As System.Windows.Forms.Label
    Friend WithEvents Lbl_TipoEquipo As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Subtipo As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Subclase As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Clase As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_UsuarioReporta As System.Windows.Forms.Label
    Friend WithEvents Lbl_DescripcionFalla As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Etiqueta As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Etiqueta As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbx_Ubicacion As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Ubicacion As System.Windows.Forms.Label
    Friend WithEvents Gbx_Mensaje As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents Pct_Alerta As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Adjunto As System.Windows.Forms.Button
    Friend WithEvents tbx_Adjunto As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Adjunto As System.Windows.Forms.Label
    Friend WithEvents tbx_Empleado As Modulo_Proceso.cp_Textbox
    Friend WithEvents tbx_Modelo As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Modelo As System.Windows.Forms.Label
    Friend WithEvents tbx_Marca As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Marca As System.Windows.Forms.Label
    Friend WithEvents tbx_Serie As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Serie As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ejemplo As System.Windows.Forms.Label
    Friend WithEvents cmb_Inventario As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Inventario As System.Windows.Forms.Label
    Friend WithEvents chk_Etiqueta As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Referencia As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_NReferencia As System.Windows.Forms.Label
    Friend WithEvents chk_Otro As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Descripcion As System.Windows.Forms.RichTextBox
End Class
