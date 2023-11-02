<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteFallasS
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
        Me.Gbx_Mensaje = New System.Windows.Forms.GroupBox
        Me.Pct_Alerta = New System.Windows.Forms.PictureBox
        Me.Lbl_Mensaje = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_Descripcion = New System.Windows.Forms.GroupBox
        Me.tbx_Descripcion = New System.Windows.Forms.RichTextBox
        Me.btn_Adjunto = New System.Windows.Forms.Button
        Me.tbx_Adjunto = New Modulo_Proceso.cp_Textbox
        Me.Lbl_Adjunto = New System.Windows.Forms.Label
        Me.tbx_Ubicacion = New Modulo_Proceso.cp_Textbox
        Me.Lbl_Ubicacion = New System.Windows.Forms.Label
        Me.tbx_Etiqueta = New Modulo_Proceso.cp_Textbox
        Me.Lbl_NEquipo = New System.Windows.Forms.Label
        Me.Lbl_DescripcionFalla = New System.Windows.Forms.Label
        Me.tbx_Usuario = New Modulo_Proceso.cp_Textbox
        Me.Lbl_UsuarioRep = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Gbx_Falla = New System.Windows.Forms.GroupBox
        Me.cmb_Opcion = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Menu = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Lbl_Opcion = New System.Windows.Forms.Label
        Me.Lbl_Menu = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Lbl_ModuloFalla = New System.Windows.Forms.Label
        Me.cmb_Modulo = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Gbx_Mensaje.SuspendLayout()
        CType(Me.Pct_Alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Descripcion.SuspendLayout()
        Me.Gbx_Falla.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Mensaje
        '
        Me.Gbx_Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Mensaje.Controls.Add(Me.Pct_Alerta)
        Me.Gbx_Mensaje.Controls.Add(Me.Lbl_Mensaje)
        Me.Gbx_Mensaje.Location = New System.Drawing.Point(8, 155)
        Me.Gbx_Mensaje.Name = "Gbx_Mensaje"
        Me.Gbx_Mensaje.Size = New System.Drawing.Size(442, 76)
        Me.Gbx_Mensaje.TabIndex = 1
        Me.Gbx_Mensaje.TabStop = False
        '
        'Pct_Alerta
        '
        Me.Pct_Alerta.Image = Global.Modulo_Proceso.My.Resources.Resources.ErrorSistemaGrande
        Me.Pct_Alerta.Location = New System.Drawing.Point(29, 9)
        Me.Pct_Alerta.Name = "Pct_Alerta"
        Me.Pct_Alerta.Size = New System.Drawing.Size(66, 61)
        Me.Pct_Alerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pct_Alerta.TabIndex = 1
        Me.Pct_Alerta.TabStop = False
        '
        'Lbl_Mensaje
        '
        Me.Lbl_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Mensaje.Location = New System.Drawing.Point(101, 16)
        Me.Lbl_Mensaje.Name = "Lbl_Mensaje"
        Me.Lbl_Mensaje.Size = New System.Drawing.Size(324, 54)
        Me.Lbl_Mensaje.TabIndex = 0
        Me.Lbl_Mensaje.Text = "Para agilizar la atención de su reporte es necesario que describa la falla lo mas" & _
            " claro posible."
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(8, 543)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(442, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(296, 14)
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
        Me.Gbx_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Descripcion)
        Me.Gbx_Descripcion.Controls.Add(Me.btn_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_Adjunto)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Ubicacion)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_Ubicacion)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Etiqueta)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_NEquipo)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_DescripcionFalla)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Usuario)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_UsuarioRep)
        Me.Gbx_Descripcion.Controls.Add(Me.Label12)
        Me.Gbx_Descripcion.Location = New System.Drawing.Point(8, 235)
        Me.Gbx_Descripcion.Name = "Gbx_Descripcion"
        Me.Gbx_Descripcion.Size = New System.Drawing.Size(442, 302)
        Me.Gbx_Descripcion.TabIndex = 2
        Me.Gbx_Descripcion.TabStop = False
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Location = New System.Drawing.Point(29, 71)
        Me.tbx_Descripcion.MaxLength = 3000
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(375, 100)
        Me.tbx_Descripcion.TabIndex = 3
        Me.tbx_Descripcion.Text = ""
        '
        'btn_Adjunto
        '
        Me.btn_Adjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Adjunto.Location = New System.Drawing.Point(410, 267)
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
        Me.tbx_Adjunto.Location = New System.Drawing.Point(29, 269)
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
        Me.Lbl_Adjunto.Location = New System.Drawing.Point(26, 253)
        Me.Lbl_Adjunto.Name = "Lbl_Adjunto"
        Me.Lbl_Adjunto.Size = New System.Drawing.Size(148, 13)
        Me.Lbl_Adjunto.TabIndex = 9
        Me.Lbl_Adjunto.Text = "Adjuntar un Archivo(Opcional)"
        '
        'tbx_Ubicacion
        '
        Me.tbx_Ubicacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Ubicacion.Control_Siguiente = Me.btn_Adjunto
        Me.tbx_Ubicacion.Filtrado = True
        Me.tbx_Ubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Ubicacion.Location = New System.Drawing.Point(29, 230)
        Me.tbx_Ubicacion.MaxLength = 100
        Me.tbx_Ubicacion.Name = "tbx_Ubicacion"
        Me.tbx_Ubicacion.Size = New System.Drawing.Size(375, 20)
        Me.tbx_Ubicacion.TabIndex = 8
        Me.tbx_Ubicacion.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Ubicacion
        '
        Me.Lbl_Ubicacion.AutoSize = True
        Me.Lbl_Ubicacion.Location = New System.Drawing.Point(26, 214)
        Me.Lbl_Ubicacion.Name = "Lbl_Ubicacion"
        Me.Lbl_Ubicacion.Size = New System.Drawing.Size(176, 13)
        Me.Lbl_Ubicacion.TabIndex = 7
        Me.Lbl_Ubicacion.Text = "Ubicación o Descripción del Equipo"
        '
        'tbx_Etiqueta
        '
        Me.tbx_Etiqueta.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Etiqueta.Control_Siguiente = Me.tbx_Ubicacion
        Me.tbx_Etiqueta.Filtrado = True
        Me.tbx_Etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Etiqueta.Location = New System.Drawing.Point(29, 190)
        Me.tbx_Etiqueta.MaxLength = 50
        Me.tbx_Etiqueta.Name = "tbx_Etiqueta"
        Me.tbx_Etiqueta.Size = New System.Drawing.Size(198, 21)
        Me.tbx_Etiqueta.TabIndex = 6
        Me.tbx_Etiqueta.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_NEquipo
        '
        Me.Lbl_NEquipo.AutoSize = True
        Me.Lbl_NEquipo.Location = New System.Drawing.Point(26, 174)
        Me.Lbl_NEquipo.Name = "Lbl_NEquipo"
        Me.Lbl_NEquipo.Size = New System.Drawing.Size(229, 13)
        Me.Lbl_NEquipo.TabIndex = 5
        Me.Lbl_NEquipo.Text = "Número de Etiqueta del Equipo (cuando exista)"
        '
        'Lbl_DescripcionFalla
        '
        Me.Lbl_DescripcionFalla.AutoSize = True
        Me.Lbl_DescripcionFalla.Location = New System.Drawing.Point(26, 53)
        Me.Lbl_DescripcionFalla.Name = "Lbl_DescripcionFalla"
        Me.Lbl_DescripcionFalla.Size = New System.Drawing.Size(114, 13)
        Me.Lbl_DescripcionFalla.TabIndex = 2
        Me.Lbl_DescripcionFalla.Text = "Descripción de la Falla"
        '
        'tbx_Usuario
        '
        Me.tbx_Usuario.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Usuario.Control_Siguiente = Nothing
        Me.tbx_Usuario.Filtrado = True
        Me.tbx_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Usuario.Location = New System.Drawing.Point(29, 29)
        Me.tbx_Usuario.MaxLength = 150
        Me.tbx_Usuario.Name = "tbx_Usuario"
        Me.tbx_Usuario.ReadOnly = True
        Me.tbx_Usuario.Size = New System.Drawing.Size(375, 21)
        Me.tbx_Usuario.TabIndex = 1
        Me.tbx_Usuario.TabStop = False
        Me.tbx_Usuario.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Lbl_UsuarioRep
        '
        Me.Lbl_UsuarioRep.AutoSize = True
        Me.Lbl_UsuarioRep.Location = New System.Drawing.Point(26, 13)
        Me.Lbl_UsuarioRep.Name = "Lbl_UsuarioRep"
        Me.Lbl_UsuarioRep.Size = New System.Drawing.Size(105, 13)
        Me.Lbl_UsuarioRep.TabIndex = 0
        Me.Lbl_UsuarioRep.Text = "Usuario que Reporta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(410, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "*"
        '
        'Gbx_Falla
        '
        Me.Gbx_Falla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Falla.Controls.Add(Me.cmb_Opcion)
        Me.Gbx_Falla.Controls.Add(Me.cmb_Menu)
        Me.Gbx_Falla.Controls.Add(Me.Lbl_Opcion)
        Me.Gbx_Falla.Controls.Add(Me.Lbl_Menu)
        Me.Gbx_Falla.Controls.Add(Me.Label10)
        Me.Gbx_Falla.Controls.Add(Me.Label9)
        Me.Gbx_Falla.Controls.Add(Me.Label7)
        Me.Gbx_Falla.Controls.Add(Me.Lbl_ModuloFalla)
        Me.Gbx_Falla.Controls.Add(Me.cmb_Modulo)
        Me.Gbx_Falla.Location = New System.Drawing.Point(8, 11)
        Me.Gbx_Falla.Name = "Gbx_Falla"
        Me.Gbx_Falla.Size = New System.Drawing.Size(442, 140)
        Me.Gbx_Falla.TabIndex = 0
        Me.Gbx_Falla.TabStop = False
        '
        'cmb_Opcion
        '
        Me.cmb_Opcion.Clave = ""
        Me.cmb_Opcion.Control_Siguiente = Nothing
        Me.cmb_Opcion.DisplayMember = "Descripcion"
        Me.cmb_Opcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Opcion.Empresa = False
        Me.cmb_Opcion.Filtro = Nothing
        Me.cmb_Opcion.FormattingEnabled = True
        Me.cmb_Opcion.Location = New System.Drawing.Point(29, 112)
        Me.cmb_Opcion.MaxDropDownItems = 20
        Me.cmb_Opcion.Name = "cmb_Opcion"
        Me.cmb_Opcion.Pista = False
        Me.cmb_Opcion.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Opcion.StoredProcedure = "Usr_OpcionesMenu_Get"
        Me.cmb_Opcion.Sucursal = False
        Me.cmb_Opcion.TabIndex = 7
        Me.cmb_Opcion.Tipo = 0
        Me.cmb_Opcion.ValueMember = "Id_Opcion"
        '
        'cmb_Menu
        '
        Me.cmb_Menu.Clave = ""
        Me.cmb_Menu.Control_Siguiente = Me.cmb_Opcion
        Me.cmb_Menu.DisplayMember = "Descripcion"
        Me.cmb_Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Menu.Empresa = False
        Me.cmb_Menu.Filtro = Nothing
        Me.cmb_Menu.FormattingEnabled = True
        Me.cmb_Menu.Location = New System.Drawing.Point(29, 72)
        Me.cmb_Menu.MaxDropDownItems = 20
        Me.cmb_Menu.Name = "cmb_Menu"
        Me.cmb_Menu.Pista = False
        Me.cmb_Menu.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Menu.StoredProcedure = "usr_MenusModulo_get"
        Me.cmb_Menu.Sucursal = False
        Me.cmb_Menu.TabIndex = 4
        Me.cmb_Menu.Tipo = 0
        Me.cmb_Menu.ValueMember = "Id_Menu"
        '
        'Lbl_Opcion
        '
        Me.Lbl_Opcion.AutoSize = True
        Me.Lbl_Opcion.Location = New System.Drawing.Point(26, 96)
        Me.Lbl_Opcion.Name = "Lbl_Opcion"
        Me.Lbl_Opcion.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Opcion.TabIndex = 6
        Me.Lbl_Opcion.Text = "Opción"
        '
        'Lbl_Menu
        '
        Me.Lbl_Menu.AutoSize = True
        Me.Lbl_Menu.Location = New System.Drawing.Point(26, 54)
        Me.Lbl_Menu.Name = "Lbl_Menu"
        Me.Lbl_Menu.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_Menu.TabIndex = 3
        Me.Lbl_Menu.Text = "Menú"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(410, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(410, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(410, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "*"
        '
        'Lbl_ModuloFalla
        '
        Me.Lbl_ModuloFalla.AutoSize = True
        Me.Lbl_ModuloFalla.Location = New System.Drawing.Point(26, 14)
        Me.Lbl_ModuloFalla.Name = "Lbl_ModuloFalla"
        Me.Lbl_ModuloFalla.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_ModuloFalla.TabIndex = 0
        Me.Lbl_ModuloFalla.Text = "Módulo que Falla"
        '
        'cmb_Modulo
        '
        Me.cmb_Modulo.Clave = Nothing
        Me.cmb_Modulo.Control_Siguiente = Me.cmb_Menu
        Me.cmb_Modulo.DisplayMember = "Descripcion"
        Me.cmb_Modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Modulo.Empresa = False
        Me.cmb_Modulo.Filtro = Nothing
        Me.cmb_Modulo.FormattingEnabled = True
        Me.cmb_Modulo.Location = New System.Drawing.Point(29, 30)
        Me.cmb_Modulo.MaxDropDownItems = 20
        Me.cmb_Modulo.Name = "cmb_Modulo"
        Me.cmb_Modulo.Pista = False
        Me.cmb_Modulo.Size = New System.Drawing.Size(375, 21)
        Me.cmb_Modulo.StoredProcedure = "Usr_Modulos_Get"
        Me.cmb_Modulo.Sucursal = False
        Me.cmb_Modulo.TabIndex = 1
        Me.cmb_Modulo.Tipo = 0
        Me.cmb_Modulo.ValueMember = "Clave"
        '
        'frm_ReporteFallasS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(458, 604)
        Me.Controls.Add(Me.Gbx_Mensaje)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Descripcion)
        Me.Controls.Add(Me.Gbx_Falla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReporteFallasS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Fallas en Sistema."
        Me.Gbx_Mensaje.ResumeLayout(False)
        CType(Me.Pct_Alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Descripcion.ResumeLayout(False)
        Me.Gbx_Descripcion.PerformLayout()
        Me.Gbx_Falla.ResumeLayout(False)
        Me.Gbx_Falla.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Mensaje As System.Windows.Forms.GroupBox
    Friend WithEvents Pct_Alerta As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Adjunto As System.Windows.Forms.Button
    Friend WithEvents tbx_Adjunto As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Adjunto As System.Windows.Forms.Label
    Friend WithEvents tbx_Ubicacion As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Ubicacion As System.Windows.Forms.Label
    Friend WithEvents tbx_Etiqueta As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_NEquipo As System.Windows.Forms.Label
    Friend WithEvents Lbl_DescripcionFalla As System.Windows.Forms.Label
    Friend WithEvents tbx_Usuario As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_UsuarioRep As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Gbx_Falla As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Opcion As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Menu As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Opcion As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ModuloFalla As System.Windows.Forms.Label
    Friend WithEvents cmb_Modulo As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Descripcion As System.Windows.Forms.RichTextBox
End Class
