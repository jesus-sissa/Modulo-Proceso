<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CartaAcceso
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
        Me.Gbx_Personalizar = New System.Windows.Forms.GroupBox
        Me.cmb_Empleado = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveEmpleado = New Modulo_Proceso.cp_Textbox
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.tbx_Empresa = New Modulo_Proceso.cp_Textbox
        Me.tbx_Asunto = New Modulo_Proceso.cp_Textbox
        Me.lbl_Empresa = New System.Windows.Forms.Label
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.lsv_PersonasAutorizadas = New Modulo_Proceso.cp_Listview
        Me.Lbl_Tipo = New System.Windows.Forms.Label
        Me.Gbx_TipoCarta = New System.Windows.Forms.GroupBox
        Me.rdb_Otro = New System.Windows.Forms.RadioButton
        Me.rdb_NuevoIngreso = New System.Windows.Forms.RadioButton
        Me.rdb_Falta = New System.Windows.Forms.RadioButton
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaInicio = New System.Windows.Forms.Label
        Me.lbl_Dirigida = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.lbl_Autoriza = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Asunto = New System.Windows.Forms.GroupBox
        Me.cmb_DirigidoA = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Autoriza = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Gbx_Personalizar.SuspendLayout()
        Me.Gbx_TipoCarta.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Asunto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Personalizar
        '
        Me.Gbx_Personalizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Personalizar.Controls.Add(Me.cmb_Empleado)
        Me.Gbx_Personalizar.Controls.Add(Me.btn_Borrar)
        Me.Gbx_Personalizar.Controls.Add(Me.tbx_ClaveEmpleado)
        Me.Gbx_Personalizar.Controls.Add(Me.lbl_Empleado)
        Me.Gbx_Personalizar.Controls.Add(Me.tbx_Empresa)
        Me.Gbx_Personalizar.Controls.Add(Me.lbl_Empresa)
        Me.Gbx_Personalizar.Controls.Add(Me.btn_Agregar)
        Me.Gbx_Personalizar.Controls.Add(Me.lsv_PersonasAutorizadas)
        Me.Gbx_Personalizar.Location = New System.Drawing.Point(6, 4)
        Me.Gbx_Personalizar.Name = "Gbx_Personalizar"
        Me.Gbx_Personalizar.Size = New System.Drawing.Size(771, 277)
        Me.Gbx_Personalizar.TabIndex = 0
        Me.Gbx_Personalizar.TabStop = False
        '
        'cmb_Empleado
        '
        Me.cmb_Empleado.Clave = "Clave_Empleado"
        Me.cmb_Empleado.Control_Siguiente = Nothing
        Me.cmb_Empleado.DisplayMember = "Nombre"
        Me.cmb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado.Empresa = False
        Me.cmb_Empleado.Filtro = Me.tbx_ClaveEmpleado
        Me.cmb_Empleado.FormattingEnabled = True
        Me.cmb_Empleado.Location = New System.Drawing.Point(83, 18)
        Me.cmb_Empleado.MaxDropDownItems = 20
        Me.cmb_Empleado.Name = "cmb_Empleado"
        Me.cmb_Empleado.Pista = True
        Me.cmb_Empleado.Size = New System.Drawing.Size(344, 21)
        Me.cmb_Empleado.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Empleado.Sucursal = True
        Me.cmb_Empleado.TabIndex = 5
        Me.cmb_Empleado.Tipo = 0
        Me.cmb_Empleado.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveEmpleado
        '
        Me.tbx_ClaveEmpleado.Control_Siguiente = Nothing
        Me.tbx_ClaveEmpleado.Filtrado = True
        Me.tbx_ClaveEmpleado.Location = New System.Drawing.Point(83, 19)
        Me.tbx_ClaveEmpleado.MaxLength = 12
        Me.tbx_ClaveEmpleado.Name = "tbx_ClaveEmpleado"
        Me.tbx_ClaveEmpleado.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveEmpleado.TabIndex = 4
        Me.tbx_ClaveEmpleado.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveEmpleado.Visible = False
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar.Enabled = False
        Me.btn_Borrar.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_Borrar.Location = New System.Drawing.Point(6, 237)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar.TabIndex = 1
        Me.btn_Borrar.Text = "&Borrar"
        Me.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(23, 22)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Empleado.TabIndex = 3
        Me.lbl_Empleado.Text = "Empleado"
        '
        'tbx_Empresa
        '
        Me.tbx_Empresa.Control_Siguiente = Me.tbx_Asunto
        Me.tbx_Empresa.Filtrado = False
        Me.tbx_Empresa.Location = New System.Drawing.Point(83, 45)
        Me.tbx_Empresa.Name = "tbx_Empresa"
        Me.tbx_Empresa.ReadOnly = True
        Me.tbx_Empresa.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Empresa.TabIndex = 9
        Me.tbx_Empresa.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Asunto
        '
        Me.tbx_Asunto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Asunto.Control_Siguiente = Nothing
        Me.tbx_Asunto.Filtrado = True
        Me.tbx_Asunto.Location = New System.Drawing.Point(83, 84)
        Me.tbx_Asunto.MaxLength = 600
        Me.tbx_Asunto.Multiline = True
        Me.tbx_Asunto.Name = "tbx_Asunto"
        Me.tbx_Asunto.Size = New System.Drawing.Size(682, 115)
        Me.tbx_Asunto.TabIndex = 19
        Me.tbx_Asunto.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Empresa
        '
        Me.lbl_Empresa.AutoSize = True
        Me.lbl_Empresa.Location = New System.Drawing.Point(29, 48)
        Me.lbl_Empresa.Name = "lbl_Empresa"
        Me.lbl_Empresa.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Empresa.TabIndex = 8
        Me.lbl_Empresa.Text = "Empresa"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Proceso.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(497, 37)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 10
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lsv_PersonasAutorizadas
        '
        Me.lsv_PersonasAutorizadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_PersonasAutorizadas.FullRowSelect = True
        Me.lsv_PersonasAutorizadas.HideSelection = False
        Me.lsv_PersonasAutorizadas.Location = New System.Drawing.Point(6, 73)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_PersonasAutorizadas.Lvs = ListViewColumnSorter1
        Me.lsv_PersonasAutorizadas.MultiSelect = False
        Me.lsv_PersonasAutorizadas.Name = "lsv_PersonasAutorizadas"
        Me.lsv_PersonasAutorizadas.Row1 = 5
        Me.lsv_PersonasAutorizadas.Row10 = 0
        Me.lsv_PersonasAutorizadas.Row2 = 30
        Me.lsv_PersonasAutorizadas.Row3 = 30
        Me.lsv_PersonasAutorizadas.Row4 = 0
        Me.lsv_PersonasAutorizadas.Row5 = 0
        Me.lsv_PersonasAutorizadas.Row6 = 0
        Me.lsv_PersonasAutorizadas.Row7 = 0
        Me.lsv_PersonasAutorizadas.Row8 = 0
        Me.lsv_PersonasAutorizadas.Row9 = 0
        Me.lsv_PersonasAutorizadas.Size = New System.Drawing.Size(759, 158)
        Me.lsv_PersonasAutorizadas.TabIndex = 11
        Me.lsv_PersonasAutorizadas.Tag = "Id_TipoParentesco"
        Me.lsv_PersonasAutorizadas.UseCompatibleStateImageBehavior = False
        Me.lsv_PersonasAutorizadas.View = System.Windows.Forms.View.Details
        '
        'Lbl_Tipo
        '
        Me.Lbl_Tipo.AutoSize = True
        Me.Lbl_Tipo.Location = New System.Drawing.Point(6, 56)
        Me.Lbl_Tipo.Name = "Lbl_Tipo"
        Me.Lbl_Tipo.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_Tipo.TabIndex = 16
        Me.Lbl_Tipo.Text = "Tipo de Carta"
        '
        'Gbx_TipoCarta
        '
        Me.Gbx_TipoCarta.Controls.Add(Me.rdb_Otro)
        Me.Gbx_TipoCarta.Controls.Add(Me.rdb_NuevoIngreso)
        Me.Gbx_TipoCarta.Controls.Add(Me.rdb_Falta)
        Me.Gbx_TipoCarta.Location = New System.Drawing.Point(83, 45)
        Me.Gbx_TipoCarta.Name = "Gbx_TipoCarta"
        Me.Gbx_TipoCarta.Size = New System.Drawing.Size(555, 33)
        Me.Gbx_TipoCarta.TabIndex = 17
        Me.Gbx_TipoCarta.TabStop = False
        '
        'rdb_Otro
        '
        Me.rdb_Otro.AutoSize = True
        Me.rdb_Otro.Location = New System.Drawing.Point(350, 11)
        Me.rdb_Otro.Name = "rdb_Otro"
        Me.rdb_Otro.Size = New System.Drawing.Size(45, 17)
        Me.rdb_Otro.TabIndex = 2
        Me.rdb_Otro.Text = "Otro"
        Me.rdb_Otro.UseVisualStyleBackColor = True
        '
        'rdb_NuevoIngreso
        '
        Me.rdb_NuevoIngreso.AutoSize = True
        Me.rdb_NuevoIngreso.Location = New System.Drawing.Point(6, 11)
        Me.rdb_NuevoIngreso.Name = "rdb_NuevoIngreso"
        Me.rdb_NuevoIngreso.Size = New System.Drawing.Size(95, 17)
        Me.rdb_NuevoIngreso.TabIndex = 1
        Me.rdb_NuevoIngreso.Text = "Nuevo Ingreso"
        Me.rdb_NuevoIngreso.UseVisualStyleBackColor = True
        '
        'rdb_Falta
        '
        Me.rdb_Falta.AutoSize = True
        Me.rdb_Falta.Location = New System.Drawing.Point(147, 11)
        Me.rdb_Falta.Name = "rdb_Falta"
        Me.rdb_Falta.Size = New System.Drawing.Size(155, 17)
        Me.rdb_Falta.TabIndex = 0
        Me.rdb_Falta.Text = "Acceso por Falta o Retardo"
        Me.rdb_Falta.UseVisualStyleBackColor = True
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(83, 19)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 13
        Me.dtp_Fecha.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(40, 23)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FechaInicio.TabIndex = 12
        Me.lbl_FechaInicio.Text = "Fecha"
        '
        'lbl_Dirigida
        '
        Me.lbl_Dirigida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Dirigida.AutoSize = True
        Me.lbl_Dirigida.Location = New System.Drawing.Point(26, 235)
        Me.lbl_Dirigida.Name = "lbl_Dirigida"
        Me.lbl_Dirigida.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Dirigida.TabIndex = 23
        Me.lbl_Dirigida.Text = "Dirigida a"
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(37, 87)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Observaciones.TabIndex = 18
        Me.lbl_Observaciones.Text = "Asunto"
        '
        'lbl_Autoriza
        '
        Me.lbl_Autoriza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Autoriza.AutoSize = True
        Me.lbl_Autoriza.Location = New System.Drawing.Point(32, 208)
        Me.lbl_Autoriza.Name = "lbl_Autoriza"
        Me.lbl_Autoriza.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Autoriza.TabIndex = 20
        Me.lbl_Autoriza.Text = "Autoriza"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
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
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 558)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(771, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(625, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Asunto
        '
        Me.Gbx_Asunto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Asunto.Controls.Add(Me.tbx_Asunto)
        Me.Gbx_Asunto.Controls.Add(Me.lbl_Autoriza)
        Me.Gbx_Asunto.Controls.Add(Me.lbl_Observaciones)
        Me.Gbx_Asunto.Controls.Add(Me.cmb_DirigidoA)
        Me.Gbx_Asunto.Controls.Add(Me.Lbl_Tipo)
        Me.Gbx_Asunto.Controls.Add(Me.lbl_Dirigida)
        Me.Gbx_Asunto.Controls.Add(Me.dtp_Fecha)
        Me.Gbx_Asunto.Controls.Add(Me.Gbx_TipoCarta)
        Me.Gbx_Asunto.Controls.Add(Me.lbl_FechaInicio)
        Me.Gbx_Asunto.Controls.Add(Me.cmb_Autoriza)
        Me.Gbx_Asunto.Location = New System.Drawing.Point(6, 287)
        Me.Gbx_Asunto.Name = "Gbx_Asunto"
        Me.Gbx_Asunto.Size = New System.Drawing.Size(771, 265)
        Me.Gbx_Asunto.TabIndex = 2
        Me.Gbx_Asunto.TabStop = False
        '
        'cmb_DirigidoA
        '
        Me.cmb_DirigidoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_DirigidoA.Clave = "Clave_Empleado"
        Me.cmb_DirigidoA.Control_Siguiente = Nothing
        Me.cmb_DirigidoA.DisplayMember = "Nombre"
        Me.cmb_DirigidoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DirigidoA.Empresa = False
        Me.cmb_DirigidoA.FormattingEnabled = True
        Me.cmb_DirigidoA.Location = New System.Drawing.Point(83, 232)
        Me.cmb_DirigidoA.MaxDropDownItems = 20
        Me.cmb_DirigidoA.Name = "cmb_DirigidoA"
        Me.cmb_DirigidoA.Pista = True
        Me.cmb_DirigidoA.Size = New System.Drawing.Size(400, 21)
        Me.cmb_DirigidoA.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_DirigidoA.Sucursal = True
        Me.cmb_DirigidoA.TabIndex = 25
        Me.cmb_DirigidoA.Tipo = 0
        Me.cmb_DirigidoA.ValueMember = "Id_Empleado"
        '
        'cmb_Autoriza
        '
        Me.cmb_Autoriza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_Autoriza.Clave = "Clave_Empleado"
        Me.cmb_Autoriza.Control_Siguiente = Nothing
        Me.cmb_Autoriza.DisplayMember = "Nombre"
        Me.cmb_Autoriza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Autoriza.Empresa = False
        Me.cmb_Autoriza.FormattingEnabled = True
        Me.cmb_Autoriza.Location = New System.Drawing.Point(83, 205)
        Me.cmb_Autoriza.MaxDropDownItems = 20
        Me.cmb_Autoriza.Name = "cmb_Autoriza"
        Me.cmb_Autoriza.Pista = True
        Me.cmb_Autoriza.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Autoriza.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Autoriza.Sucursal = True
        Me.cmb_Autoriza.TabIndex = 22
        Me.cmb_Autoriza.Tipo = 0
        Me.cmb_Autoriza.ValueMember = "Id_Empleado"
        '
        'frm_CartaAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 615)
        Me.Controls.Add(Me.Gbx_Asunto)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Personalizar)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CartaAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carta de Acceso a Áreas Seguras"
        Me.Gbx_Personalizar.ResumeLayout(False)
        Me.Gbx_Personalizar.PerformLayout()
        Me.Gbx_TipoCarta.ResumeLayout(False)
        Me.Gbx_TipoCarta.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Asunto.ResumeLayout(False)
        Me.Gbx_Asunto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Personalizar As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_PersonasAutorizadas As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Autoriza As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Empresa As System.Windows.Forms.Label
    Friend WithEvents tbx_Asunto As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents Lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents Gbx_TipoCarta As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Otro As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_NuevoIngreso As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Falta As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Autoriza As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Empleado As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveEmpleado As Modulo_Proceso.cp_Textbox
    Friend WithEvents cmb_DirigidoA As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Dirigida As System.Windows.Forms.Label
    Friend WithEvents Gbx_Asunto As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Empresa As Modulo_Proceso.cp_Textbox
End Class
