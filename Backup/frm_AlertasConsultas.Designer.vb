<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AlertasConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AlertasConsultas))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.cmb_Tipo = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Status = New Modulo_Proceso.cp_cmb_Manual
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.chk_Tipo = New System.Windows.Forms.CheckBox
        Me.lbl_Estatus = New System.Windows.Forms.Label
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.lbl_FechaHasta = New System.Windows.Forms.Label
        Me.lbl_FechaDesde = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Alertas = New Modulo_Proceso.cp_Listview
        Me.gbx_Descripcion = New System.Windows.Forms.GroupBox
        Me.tbx_Descripcion = New System.Windows.Forms.RichTextBox
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.lsv_Detalle = New Modulo_Proceso.cp_Listview
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Descripcion.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Tipo)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.chk_Tipo)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Estatus)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.chk_Status)
        Me.gbx_Filtro.Controls.Add(Me.lbl_FechaHasta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_FechaDesde)
        Me.gbx_Filtro.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(768, 99)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Clave = Nothing
        Me.cmb_Tipo.Control_Siguiente = Nothing
        Me.cmb_Tipo.DisplayMember = "Descripcion"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.Empresa = False
        Me.cmb_Tipo.Filtro = Nothing
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(50, 42)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Pista = False
        Me.cmb_Tipo.Size = New System.Drawing.Size(345, 21)
        Me.cmb_Tipo.StoredProcedure = "Cat_AlertasTipos_Get"
        Me.cmb_Tipo.Sucursal = False
        Me.cmb_Tipo.TabIndex = 5
        Me.cmb_Tipo.Tipo = 0
        Me.cmb_Tipo.ValueMember = "Clave_AlertaTipo"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(50, 69)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(345, 21)
        Me.cmb_Status.TabIndex = 8
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(463, 62)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 10
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Tipo
        '
        Me.chk_Tipo.AutoSize = True
        Me.chk_Tipo.Location = New System.Drawing.Point(401, 46)
        Me.chk_Tipo.Name = "chk_Tipo"
        Me.chk_Tipo.Size = New System.Drawing.Size(56, 17)
        Me.chk_Tipo.TabIndex = 6
        Me.chk_Tipo.Text = "Todos"
        Me.chk_Tipo.UseVisualStyleBackColor = True
        '
        'lbl_Estatus
        '
        Me.lbl_Estatus.AutoSize = True
        Me.lbl_Estatus.Location = New System.Drawing.Point(16, 45)
        Me.lbl_Estatus.Name = "lbl_Estatus"
        Me.lbl_Estatus.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Estatus.TabIndex = 4
        Me.lbl_Estatus.Text = "Tipo"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(7, 71)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 7
        Me.lbl_Status.Text = "Status"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(192, 16)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(50, 16)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(401, 73)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 9
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'lbl_FechaHasta
        '
        Me.lbl_FechaHasta.AutoSize = True
        Me.lbl_FechaHasta.Location = New System.Drawing.Point(151, 20)
        Me.lbl_FechaHasta.Name = "lbl_FechaHasta"
        Me.lbl_FechaHasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_FechaHasta.TabIndex = 2
        Me.lbl_FechaHasta.Text = "Hasta"
        '
        'lbl_FechaDesde
        '
        Me.lbl_FechaDesde.AutoSize = True
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(6, 20)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_FechaDesde.TabIndex = 0
        Me.lbl_FechaDesde.Text = "Desde"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(768, 50)
        Me.gbx_Botones.TabIndex = 4
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(622, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Datos.Controls.Add(Me.lsv_Alertas)
        Me.gbx_Datos.Location = New System.Drawing.Point(8, 107)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(768, 97)
        Me.gbx_Datos.TabIndex = 1
        Me.gbx_Datos.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(622, 7)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 20)
        Me.Lbl_Registros.TabIndex = 48
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Alertas
        '
        Me.lsv_Alertas.AllowColumnReorder = True
        Me.lsv_Alertas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Alertas.FullRowSelect = True
        Me.lsv_Alertas.HideSelection = False
        Me.lsv_Alertas.Location = New System.Drawing.Point(3, 33)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Alertas.Lvs = ListViewColumnSorter1
        Me.lsv_Alertas.MultiSelect = False
        Me.lsv_Alertas.Name = "lsv_Alertas"
        Me.lsv_Alertas.Row1 = 7
        Me.lsv_Alertas.Row10 = 0
        Me.lsv_Alertas.Row2 = 5
        Me.lsv_Alertas.Row3 = 20
        Me.lsv_Alertas.Row4 = 15
        Me.lsv_Alertas.Row5 = 15
        Me.lsv_Alertas.Row6 = 15
        Me.lsv_Alertas.Row7 = 7
        Me.lsv_Alertas.Row8 = 5
        Me.lsv_Alertas.Row9 = 8
        Me.lsv_Alertas.Size = New System.Drawing.Size(762, 59)
        Me.lsv_Alertas.TabIndex = 1
        Me.lsv_Alertas.Tag = "id_Bitacora"
        Me.lsv_Alertas.UseCompatibleStateImageBehavior = False
        Me.lsv_Alertas.View = System.Windows.Forms.View.Details
        '
        'gbx_Descripcion
        '
        Me.gbx_Descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Descripcion.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_Descripcion.Location = New System.Drawing.Point(8, 210)
        Me.gbx_Descripcion.Name = "gbx_Descripcion"
        Me.gbx_Descripcion.Size = New System.Drawing.Size(449, 283)
        Me.gbx_Descripcion.TabIndex = 2
        Me.gbx_Descripcion.TabStop = False
        Me.gbx_Descripcion.Text = "Descripción"
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Descripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_Descripcion.Location = New System.Drawing.Point(3, 16)
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.ReadOnly = True
        Me.tbx_Descripcion.Size = New System.Drawing.Size(443, 264)
        Me.tbx_Descripcion.TabIndex = 1
        Me.tbx_Descripcion.TabStop = False
        Me.tbx_Descripcion.Text = ""
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.lsv_Detalle)
        Me.gbx_Detalle.Location = New System.Drawing.Point(463, 210)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(313, 283)
        Me.gbx_Detalle.TabIndex = 3
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Detalle"
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.AllowColumnReorder = True
        Me.lsv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter2
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Row1 = 20
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 75
        Me.lsv_Detalle.Row3 = 0
        Me.lsv_Detalle.Row4 = 0
        Me.lsv_Detalle.Row5 = 0
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(307, 264)
        Me.lsv_Detalle.TabIndex = 0
        Me.lsv_Detalle.Tag = "id_Bitacora"
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'frm_AlertasConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Descripcion)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_AlertasConsultas"
        Me.Text = "Consulta de Alertas Generadas"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Descripcion.ResumeLayout(False)
        Me.gbx_Detalle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_FechaHasta As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaDesde As System.Windows.Forms.Label
    Friend WithEvents lsv_Alertas As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents chk_Tipo As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Estatus As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents cmb_Tipo As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Detalle As Modulo_Proceso.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
