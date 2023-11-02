<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EfectivoXCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EfectivoXCliente))
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.gbx_Listado = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Listado = New Modulo_Proceso.cp_Listview
        Me.gbx_Filtros = New System.Windows.Forms.GroupBox
        Me.tbx_Filtro = New System.Windows.Forms.TextBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cmb_Presentacion = New Modulo_Proceso.cp_cmb_Manual
        Me.cmb_Cliente = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Presentacion = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Listado.SuspendLayout()
        Me.gbx_Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 485)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(774, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(628, 14)
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
        'gbx_Listado
        '
        Me.gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Listado.Controls.Add(Me.lbl_Registros)
        Me.gbx_Listado.Controls.Add(Me.lsv_Listado)
        Me.gbx_Listado.Location = New System.Drawing.Point(5, 119)
        Me.gbx_Listado.Name = "gbx_Listado"
        Me.gbx_Listado.Size = New System.Drawing.Size(774, 367)
        Me.gbx_Listado.TabIndex = 1
        Me.gbx_Listado.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(621, 10)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(147, 23)
        Me.lbl_Registros.TabIndex = 0
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Listado
        '
        Me.lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Listado.FullRowSelect = True
        Me.lsv_Listado.HideSelection = False
        Me.lsv_Listado.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Listado.Lvs = ListViewColumnSorter1
        Me.lsv_Listado.MultiSelect = False
        Me.lsv_Listado.Name = "lsv_Listado"
        Me.lsv_Listado.Row1 = 7
        Me.lsv_Listado.Row10 = 10
        Me.lsv_Listado.Row2 = 6
        Me.lsv_Listado.Row3 = 7
        Me.lsv_Listado.Row4 = 5
        Me.lsv_Listado.Row5 = 35
        Me.lsv_Listado.Row6 = 7
        Me.lsv_Listado.Row7 = 5
        Me.lsv_Listado.Row8 = 7
        Me.lsv_Listado.Row9 = 10
        Me.lsv_Listado.Size = New System.Drawing.Size(763, 325)
        Me.lsv_Listado.TabIndex = 1
        Me.lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'gbx_Filtros
        '
        Me.gbx_Filtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtros.Controls.Add(Me.tbx_Filtro)
        Me.gbx_Filtros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Presentacion)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Presentacion)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtros.Controls.Add(Me.Label2)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtros.Location = New System.Drawing.Point(5, 2)
        Me.gbx_Filtros.Name = "gbx_Filtros"
        Me.gbx_Filtros.Size = New System.Drawing.Size(774, 111)
        Me.gbx_Filtros.TabIndex = 0
        Me.gbx_Filtros.TabStop = False
        '
        'tbx_Filtro
        '
        Me.tbx_Filtro.Location = New System.Drawing.Point(81, 45)
        Me.tbx_Filtro.Name = "tbx_Filtro"
        Me.tbx_Filtro.Size = New System.Drawing.Size(80, 20)
        Me.tbx_Filtro.TabIndex = 5
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(228, 70)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 9
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cmb_Presentacion
        '
        Me.cmb_Presentacion.Control_Siguiente = Nothing
        Me.cmb_Presentacion.DisplayMember = "display"
        Me.cmb_Presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Presentacion.FormattingEnabled = True
        Me.cmb_Presentacion.Location = New System.Drawing.Point(81, 76)
        Me.cmb_Presentacion.MaxDropDownItems = 20
        Me.cmb_Presentacion.Name = "cmb_Presentacion"
        Me.cmb_Presentacion.Size = New System.Drawing.Size(141, 21)
        Me.cmb_Presentacion.TabIndex = 8
        Me.cmb_Presentacion.ValueMember = "value"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Filtro
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(167, 45)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 6
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'lbl_Presentacion
        '
        Me.lbl_Presentacion.AutoSize = True
        Me.lbl_Presentacion.Location = New System.Drawing.Point(7, 79)
        Me.lbl_Presentacion.Name = "lbl_Presentacion"
        Me.lbl_Presentacion.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Presentacion.TabIndex = 7
        Me.lbl_Presentacion.Text = "Presentacion"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(36, 48)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 4
        Me.lbl_Cliente.Text = "Cliente"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(268, 18)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(81, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(227, 24)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'frm_EfectivoXCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 537)
        Me.Controls.Add(Me.gbx_Listado)
        Me.Controls.Add(Me.gbx_Filtros)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "frm_EfectivoXCliente"
        Me.Text = "Analisis de Efectivo por Cliente"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Listado.ResumeLayout(False)
        Me.gbx_Filtros.ResumeLayout(False)
        Me.gbx_Filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Listado As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Presentacion As System.Windows.Forms.Label
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents cmb_Presentacion As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents cmb_Cliente As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents tbx_Filtro As System.Windows.Forms.TextBox
End Class
