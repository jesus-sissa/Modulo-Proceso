<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaCheques
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
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.gbx_Filtros = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Gbx_TipoCheque = New System.Windows.Forms.GroupBox
        Me.rdb_GeneradosTXT = New System.Windows.Forms.RadioButton
        Me.rdb_Todos = New System.Windows.Forms.RadioButton
        Me.chk_Corte = New System.Windows.Forms.CheckBox
        Me.Lbl_Corte = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.Lbl_SesionH = New System.Windows.Forms.Label
        Me.Lbl_SesionD = New System.Windows.Forms.Label
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.gbx_MICR = New System.Windows.Forms.GroupBox
        Me.txt_MICR = New System.Windows.Forms.TextBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.pbx_Reverso = New System.Windows.Forms.PictureBox
        Me.pbx_Frente = New System.Windows.Forms.PictureBox
        Me.lbl_Reverso = New System.Windows.Forms.Label
        Me.Lbl_Nota2 = New System.Windows.Forms.Label
        Me.Lbl_Nota = New System.Windows.Forms.Label
        Me.lbl_Frente = New System.Windows.Forms.Label
        Me.gbx_Imagenes = New System.Windows.Forms.GroupBox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Parametro
        Me.tbx_Corte = New Modulo_Proceso.cp_Textbox
        Me.tbx_Buscar = New Modulo_Proceso.cp_Textbox
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.lsv_Cheques = New Modulo_Proceso.cp_Listview
        Me.btn_Imagenes = New System.Windows.Forms.Button
        Me.fbd_Imagenes = New System.Windows.Forms.FolderBrowserDialog
        Me.gbx_Filtros.SuspendLayout()
        Me.Gbx_TipoCheque.SuspendLayout()
        Me.gbx_MICR.SuspendLayout()
        CType(Me.pbx_Reverso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_Frente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Imagenes.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(49, 16)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(52, 41)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 4
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(14, 65)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 8
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(449, 87)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(110, 30)
        Me.btn_Mostrar.TabIndex = 14
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'gbx_Filtros
        '
        Me.gbx_Filtros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtros.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Desde)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtros.Controls.Add(Me.Gbx_TipoCheque)
        Me.gbx_Filtros.Controls.Add(Me.chk_Corte)
        Me.gbx_Filtros.Controls.Add(Me.tbx_Corte)
        Me.gbx_Filtros.Controls.Add(Me.Lbl_Corte)
        Me.gbx_Filtros.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Filtros.Controls.Add(Me.btn_Buscar)
        Me.gbx_Filtros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtros.Controls.Add(Me.Lbl_SesionH)
        Me.gbx_Filtros.Controls.Add(Me.Lbl_SesionD)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtros.Controls.Add(Me.Lbl_Buscar)
        Me.gbx_Filtros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.lsv_Cheques)
        Me.gbx_Filtros.Location = New System.Drawing.Point(3, 0)
        Me.gbx_Filtros.Name = "gbx_Filtros"
        Me.gbx_Filtros.Size = New System.Drawing.Size(778, 267)
        Me.gbx_Filtros.TabIndex = 0
        Me.gbx_Filtros.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(537, 124)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(232, 23)
        Me.Lbl_Registros.TabIndex = 50
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Hasta.Location = New System.Drawing.Point(93, 37)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 5
        '
        'dtp_Desde
        '
        Me.dtp_Desde.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Desde.Location = New System.Drawing.Point(93, 13)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'Gbx_TipoCheque
        '
        Me.Gbx_TipoCheque.Controls.Add(Me.rdb_GeneradosTXT)
        Me.Gbx_TipoCheque.Controls.Add(Me.rdb_Todos)
        Me.Gbx_TipoCheque.Location = New System.Drawing.Point(210, 83)
        Me.Gbx_TipoCheque.Name = "Gbx_TipoCheque"
        Me.Gbx_TipoCheque.Size = New System.Drawing.Size(233, 34)
        Me.Gbx_TipoCheque.TabIndex = 13
        Me.Gbx_TipoCheque.TabStop = False
        '
        'rdb_GeneradosTXT
        '
        Me.rdb_GeneradosTXT.AutoSize = True
        Me.rdb_GeneradosTXT.Location = New System.Drawing.Point(14, 11)
        Me.rdb_GeneradosTXT.Name = "rdb_GeneradosTXT"
        Me.rdb_GeneradosTXT.Size = New System.Drawing.Size(140, 17)
        Me.rdb_GeneradosTXT.TabIndex = 0
        Me.rdb_GeneradosTXT.TabStop = True
        Me.rdb_GeneradosTXT.Text = "Solo Generados en TXT"
        Me.rdb_GeneradosTXT.UseVisualStyleBackColor = True
        '
        'rdb_Todos
        '
        Me.rdb_Todos.AutoSize = True
        Me.rdb_Todos.Location = New System.Drawing.Point(166, 11)
        Me.rdb_Todos.Name = "rdb_Todos"
        Me.rdb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rdb_Todos.TabIndex = 1
        Me.rdb_Todos.TabStop = True
        Me.rdb_Todos.Text = "Todos"
        Me.rdb_Todos.UseVisualStyleBackColor = True
        '
        'chk_Corte
        '
        Me.chk_Corte.AutoSize = True
        Me.chk_Corte.Location = New System.Drawing.Point(142, 95)
        Me.chk_Corte.Name = "chk_Corte"
        Me.chk_Corte.Size = New System.Drawing.Size(56, 17)
        Me.chk_Corte.TabIndex = 12
        Me.chk_Corte.Text = "Todos"
        Me.chk_Corte.UseVisualStyleBackColor = True
        '
        'Lbl_Corte
        '
        Me.Lbl_Corte.AutoSize = True
        Me.Lbl_Corte.Location = New System.Drawing.Point(55, 96)
        Me.Lbl_Corte.Name = "Lbl_Corte"
        Me.Lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_Corte.TabIndex = 10
        Me.Lbl_Corte.Text = "Corte"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(449, 123)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 17
        Me.btn_Buscar.Text = "&Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_SesionH
        '
        Me.Lbl_SesionH.AutoSize = True
        Me.Lbl_SesionH.Location = New System.Drawing.Point(194, 41)
        Me.Lbl_SesionH.Name = "Lbl_SesionH"
        Me.Lbl_SesionH.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SesionH.TabIndex = 6
        Me.Lbl_SesionH.Text = "Sesión"
        '
        'Lbl_SesionD
        '
        Me.Lbl_SesionD.AutoSize = True
        Me.Lbl_SesionD.Location = New System.Drawing.Point(194, 16)
        Me.Lbl_SesionD.Name = "Lbl_SesionD"
        Me.Lbl_SesionD.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SesionD.TabIndex = 2
        Me.Lbl_SesionD.Text = "Sesión"
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(11, 127)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_Buscar.TabIndex = 15
        Me.Lbl_Buscar.Text = "Buscar en lista"
        '
        'gbx_MICR
        '
        Me.gbx_MICR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_MICR.Controls.Add(Me.txt_MICR)
        Me.gbx_MICR.Controls.Add(Me.btn_Guardar)
        Me.gbx_MICR.Location = New System.Drawing.Point(3, 273)
        Me.gbx_MICR.Name = "gbx_MICR"
        Me.gbx_MICR.Size = New System.Drawing.Size(778, 56)
        Me.gbx_MICR.TabIndex = 20
        Me.gbx_MICR.TabStop = False
        Me.gbx_MICR.Text = "Modificar Número de Cheque"
        '
        'txt_MICR
        '
        Me.txt_MICR.BackColor = System.Drawing.SystemColors.Window
        Me.txt_MICR.Enabled = False
        Me.txt_MICR.Location = New System.Drawing.Point(6, 22)
        Me.txt_MICR.Name = "txt_MICR"
        Me.txt_MICR.Size = New System.Drawing.Size(382, 20)
        Me.txt_MICR.TabIndex = 0
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(394, 16)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(111, 30)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'pbx_Reverso
        '
        Me.pbx_Reverso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_Reverso.Location = New System.Drawing.Point(317, 32)
        Me.pbx_Reverso.Name = "pbx_Reverso"
        Me.pbx_Reverso.Size = New System.Drawing.Size(290, 121)
        Me.pbx_Reverso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_Reverso.TabIndex = 10
        Me.pbx_Reverso.TabStop = False
        '
        'pbx_Frente
        '
        Me.pbx_Frente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx_Frente.Location = New System.Drawing.Point(5, 32)
        Me.pbx_Frente.Name = "pbx_Frente"
        Me.pbx_Frente.Size = New System.Drawing.Size(290, 121)
        Me.pbx_Frente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_Frente.TabIndex = 7
        Me.pbx_Frente.TabStop = False
        '
        'lbl_Reverso
        '
        Me.lbl_Reverso.AutoSize = True
        Me.lbl_Reverso.Location = New System.Drawing.Point(317, 16)
        Me.lbl_Reverso.Name = "lbl_Reverso"
        Me.lbl_Reverso.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Reverso.TabIndex = 23
        Me.lbl_Reverso.Text = "Reverso"
        '
        'Lbl_Nota2
        '
        Me.Lbl_Nota2.AutoSize = True
        Me.Lbl_Nota2.Location = New System.Drawing.Point(317, 156)
        Me.Lbl_Nota2.Name = "Lbl_Nota2"
        Me.Lbl_Nota2.Size = New System.Drawing.Size(167, 13)
        Me.Lbl_Nota2.TabIndex = 24
        Me.Lbl_Nota2.Text = "Click sobre la imagen para ampliar"
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Location = New System.Drawing.Point(5, 156)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(167, 13)
        Me.Lbl_Nota.TabIndex = 22
        Me.Lbl_Nota.Text = "Click sobre la imagen para ampliar"
        '
        'lbl_Frente
        '
        Me.lbl_Frente.AutoSize = True
        Me.lbl_Frente.Location = New System.Drawing.Point(5, 16)
        Me.lbl_Frente.Name = "lbl_Frente"
        Me.lbl_Frente.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Frente.TabIndex = 21
        Me.lbl_Frente.Text = "Frente"
        '
        'gbx_Imagenes
        '
        Me.gbx_Imagenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Imagenes.Controls.Add(Me.lbl_Frente)
        Me.gbx_Imagenes.Controls.Add(Me.Lbl_Nota)
        Me.gbx_Imagenes.Controls.Add(Me.Lbl_Nota2)
        Me.gbx_Imagenes.Controls.Add(Me.lbl_Reverso)
        Me.gbx_Imagenes.Controls.Add(Me.pbx_Frente)
        Me.gbx_Imagenes.Controls.Add(Me.pbx_Reverso)
        Me.gbx_Imagenes.Location = New System.Drawing.Point(3, 329)
        Me.gbx_Imagenes.Name = "gbx_Imagenes"
        Me.gbx_Imagenes.Size = New System.Drawing.Size(778, 179)
        Me.gbx_Imagenes.TabIndex = 25
        Me.gbx_Imagenes.TabStop = False
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Imagenes)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 508)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Botones.TabIndex = 26
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 16
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(632, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 15
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Cia = False
        Me.cmb_Hasta.Control_Siguiente = Nothing
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(239, 38)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.NombreParametro = "@Fecha"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(111, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 7
        Me.cmb_Hasta.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Hasta.ValorParametro = Nothing
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Cia = False
        Me.cmb_Desde.Control_Siguiente = Nothing
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(239, 13)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.NombreParametro = "@Fecha"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(111, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 3
        Me.cmb_Desde.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Desde.ValorParametro = Nothing
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'tbx_Corte
        '
        Me.tbx_Corte.Control_Siguiente = Nothing
        Me.tbx_Corte.Filtrado = False
        Me.tbx_Corte.Location = New System.Drawing.Point(93, 93)
        Me.tbx_Corte.MaxLength = 2
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.Size = New System.Drawing.Size(43, 20)
        Me.tbx_Corte.TabIndex = 11
        Me.tbx_Corte.Text = "1"
        Me.tbx_Corte.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(93, 124)
        Me.tbx_Buscar.MaxLength = 34
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Buscar.TabIndex = 16
        Me.tbx_Buscar.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(93, 62)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(350, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 9
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'lsv_Cheques
        '
        Me.lsv_Cheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cheques.CheckBoxes = True
        Me.lsv_Cheques.FullRowSelect = True
        Me.lsv_Cheques.HideSelection = False
        Me.lsv_Cheques.Location = New System.Drawing.Point(9, 150)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Cheques.Lvs = ListViewColumnSorter1
        Me.lsv_Cheques.MultiSelect = False
        Me.lsv_Cheques.Name = "lsv_Cheques"
        Me.lsv_Cheques.Row1 = 4
        Me.lsv_Cheques.Row10 = 10
        Me.lsv_Cheques.Row2 = 8
        Me.lsv_Cheques.Row3 = 24
        Me.lsv_Cheques.Row4 = 12
        Me.lsv_Cheques.Row5 = 8
        Me.lsv_Cheques.Row6 = 8
        Me.lsv_Cheques.Row7 = 8
        Me.lsv_Cheques.Row8 = 20
        Me.lsv_Cheques.Row9 = 8
        Me.lsv_Cheques.Size = New System.Drawing.Size(760, 111)
        Me.lsv_Cheques.TabIndex = 19
        Me.lsv_Cheques.UseCompatibleStateImageBehavior = False
        Me.lsv_Cheques.View = System.Windows.Forms.View.Details
        '
        'btn_Imagenes
        '
        Me.btn_Imagenes.Image = Global.Modulo_Proceso.My.Resources.Resources.Actualizar
        Me.btn_Imagenes.Location = New System.Drawing.Point(155, 14)
        Me.btn_Imagenes.Name = "btn_Imagenes"
        Me.btn_Imagenes.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imagenes.TabIndex = 17
        Me.btn_Imagenes.Text = "&Extraer Imagenes"
        Me.btn_Imagenes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imagenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imagenes.UseVisualStyleBackColor = True
        '
        'frm_ConsultaCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Imagenes)
        Me.Controls.Add(Me.gbx_Filtros)
        Me.Controls.Add(Me.gbx_MICR)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaCheques"
        Me.Text = "Consulta de Cheques"
        Me.gbx_Filtros.ResumeLayout(False)
        Me.gbx_Filtros.PerformLayout()
        Me.Gbx_TipoCheque.ResumeLayout(False)
        Me.Gbx_TipoCheque.PerformLayout()
        Me.gbx_MICR.ResumeLayout(False)
        Me.gbx_MICR.PerformLayout()
        CType(Me.pbx_Reverso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_Frente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Imagenes.ResumeLayout(False)
        Me.gbx_Imagenes.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lsv_Cheques As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents pbx_Frente As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_Reverso As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Reverso As System.Windows.Forms.Label
    Friend WithEvents lbl_Frente As System.Windows.Forms.Label
    Friend WithEvents tbx_Buscar As Modulo_Proceso.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents chk_Corte As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Corte As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nota2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents rdb_GeneradosTXT As System.Windows.Forms.RadioButton
    Friend WithEvents Gbx_TipoCheque As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents txt_MICR As System.Windows.Forms.TextBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents gbx_MICR As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_SesionH As System.Windows.Forms.Label
    Friend WithEvents Lbl_SesionD As System.Windows.Forms.Label
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents gbx_Imagenes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Imagenes As System.Windows.Forms.Button
    Friend WithEvents fbd_Imagenes As System.Windows.Forms.FolderBrowserDialog
End Class
