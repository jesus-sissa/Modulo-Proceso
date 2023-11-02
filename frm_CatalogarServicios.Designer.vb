<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CatalogarServicios
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
        Me.components = New System.ComponentModel.Container
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CatalogarServicios))
        Me.gbx_TipoServicio = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_TipoDotación = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_Sesion = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.chk_Omitir = New System.Windows.Forms.CheckBox
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.ContextMenuStripCopiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItemCopiar = New System.Windows.Forms.ToolStripMenuItem
        Me.lsv_Servicios = New Modulo_Proceso.cp_Listview
        Me.cmb_Sesion = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_TipoDotacion = New Modulo_Proceso.cp_cmb_Manual
        Me.gbx_TipoServicio.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Servicios.SuspendLayout()
        Me.ContextMenuStripCopiar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_TipoServicio
        '
        Me.gbx_TipoServicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_TipoServicio.Controls.Add(Me.btn_Guardar)
        Me.gbx_TipoServicio.Controls.Add(Me.btn_Cerrar)
        Me.gbx_TipoServicio.Controls.Add(Me.cmb_TipoDotacion)
        Me.gbx_TipoServicio.Controls.Add(Me.lbl_TipoDotación)
        Me.gbx_TipoServicio.Location = New System.Drawing.Point(9, 502)
        Me.gbx_TipoServicio.Name = "gbx_TipoServicio"
        Me.gbx_TipoServicio.Size = New System.Drawing.Size(766, 50)
        Me.gbx_TipoServicio.TabIndex = 2
        Me.gbx_TipoServicio.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(367, 12)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(620, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_TipoDotación
        '
        Me.lbl_TipoDotación.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_TipoDotación.Location = New System.Drawing.Point(9, 21)
        Me.lbl_TipoDotación.Name = "lbl_TipoDotación"
        Me.lbl_TipoDotación.Size = New System.Drawing.Size(72, 13)
        Me.lbl_TipoDotación.TabIndex = 0
        Me.lbl_TipoDotación.Text = "Tipo Entrada:"
        Me.lbl_TipoDotación.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.cmb_Sesion)
        Me.gbx_Datos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Datos.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.lbl_Sesion)
        Me.gbx_Datos.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Location = New System.Drawing.Point(9, 6)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(766, 72)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(560, 35)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(17, 45)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(76, 13)
        Me.lbl_CajaBancaria.TabIndex = 4
        Me.lbl_CajaBancaria.Text = "Caja Bancaria:"
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Location = New System.Drawing.Point(197, 20)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Sesion.TabIndex = 2
        Me.lbl_Sesion.Text = "Sesión:"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(50, 20)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(96, 16)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.lbl_Registros)
        Me.gbx_Servicios.Controls.Add(Me.chk_Omitir)
        Me.gbx_Servicios.Controls.Add(Me.chk_Todos)
        Me.gbx_Servicios.Controls.Add(Me.lsv_Servicios)
        Me.gbx_Servicios.Location = New System.Drawing.Point(9, 84)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(766, 412)
        Me.gbx_Servicios.TabIndex = 1
        Me.gbx_Servicios.TabStop = False
        Me.gbx_Servicios.Text = "Servicios"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(620, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 13)
        Me.lbl_Registros.TabIndex = 2
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_Omitir
        '
        Me.chk_Omitir.AutoSize = True
        Me.chk_Omitir.Location = New System.Drawing.Point(68, 15)
        Me.chk_Omitir.Name = "chk_Omitir"
        Me.chk_Omitir.Size = New System.Drawing.Size(114, 17)
        Me.chk_Omitir.TabIndex = 1
        Me.chk_Omitir.Text = "Omitir Catalogados"
        Me.chk_Omitir.UseVisualStyleBackColor = True
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(6, 15)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 0
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'ContextMenuStripCopiar
        '
        Me.ContextMenuStripCopiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItemCopiar})
        Me.ContextMenuStripCopiar.Name = "ContextMenuStripCopiar"
        Me.ContextMenuStripCopiar.Size = New System.Drawing.Size(110, 26)
        '
        'CopiarToolStripMenuItemCopiar
        '
        Me.CopiarToolStripMenuItemCopiar.Name = "CopiarToolStripMenuItemCopiar"
        Me.CopiarToolStripMenuItemCopiar.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItemCopiar.Text = "Copiar"
        '
        'lsv_Servicios
        '
        Me.lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Servicios.CheckBoxes = True
        Me.lsv_Servicios.ContextMenuStrip = Me.ContextMenuStripCopiar
        Me.lsv_Servicios.FullRowSelect = True
        Me.lsv_Servicios.HideSelection = False
        Me.lsv_Servicios.Location = New System.Drawing.Point(6, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Servicios.Lvs = ListViewColumnSorter1
        Me.lsv_Servicios.MultiSelect = False
        Me.lsv_Servicios.Name = "lsv_Servicios"
        Me.lsv_Servicios.Row1 = 10
        Me.lsv_Servicios.Row10 = 0
        Me.lsv_Servicios.Row2 = 10
        Me.lsv_Servicios.Row3 = 20
        Me.lsv_Servicios.Row4 = 30
        Me.lsv_Servicios.Row5 = 10
        Me.lsv_Servicios.Row6 = 15
        Me.lsv_Servicios.Row7 = 0
        Me.lsv_Servicios.Row8 = 0
        Me.lsv_Servicios.Row9 = 0
        Me.lsv_Servicios.Size = New System.Drawing.Size(754, 368)
        Me.lsv_Servicios.TabIndex = 3
        Me.lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'cmb_Sesion
        '
        Me.cmb_Sesion.Clave = Nothing
        Me.cmb_Sesion.Control_Siguiente = Nothing
        Me.cmb_Sesion.DisplayMember = "Numero_Sesion"
        Me.cmb_Sesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sesion.Empresa = False
        Me.cmb_Sesion.Filtro = Nothing
        Me.cmb_Sesion.FormattingEnabled = True
        Me.cmb_Sesion.Location = New System.Drawing.Point(245, 17)
        Me.cmb_Sesion.MaxDropDownItems = 20
        Me.cmb_Sesion.Name = "cmb_Sesion"
        Me.cmb_Sesion.Pista = False
        Me.cmb_Sesion.Size = New System.Drawing.Size(101, 21)
        Me.cmb_Sesion.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Sesion.Sucursal = True
        Me.cmb_Sesion.TabIndex = 3
        Me.cmb_Sesion.Tipo = 0
        Me.cmb_Sesion.ValueMember = "Id_Sesion"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(96, 41)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 6
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'cmb_TipoDotacion
        '
        Me.cmb_TipoDotacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_TipoDotacion.Control_Siguiente = Nothing
        Me.cmb_TipoDotacion.DisplayMember = "display"
        Me.cmb_TipoDotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDotacion.FormattingEnabled = True
        Me.cmb_TipoDotacion.Location = New System.Drawing.Point(87, 18)
        Me.cmb_TipoDotacion.MaxDropDownItems = 20
        Me.cmb_TipoDotacion.Name = "cmb_TipoDotacion"
        Me.cmb_TipoDotacion.Size = New System.Drawing.Size(274, 21)
        Me.cmb_TipoDotacion.TabIndex = 1
        Me.cmb_TipoDotacion.ValueMember = "value"
        '
        'frm_CatalogarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Servicios)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_TipoServicio)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CatalogarServicios"
        Me.Text = "Catalogar Servicios"
        Me.gbx_TipoServicio.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Servicios.PerformLayout()
        Me.ContextMenuStripCopiar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_TipoDotacion As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents gbx_TipoServicio As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TipoDotación As System.Windows.Forms.Label
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_Servicios As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Servicios As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Omitir As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Sesion As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStripCopiar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItemCopiar As System.Windows.Forms.ToolStripMenuItem
End Class
