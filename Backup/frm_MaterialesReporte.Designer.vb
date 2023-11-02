<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MaterialesReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MaterialesReporte))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cmb_Status = New Modulo_Proceso.cp_cmb_Manual
        Me.Lbl_Status = New System.Windows.Forms.Label
        Me.Lbl_FechaFin = New System.Windows.Forms.Label
        Me.Lbl_FechaIni = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lbl_Registros1 = New System.Windows.Forms.Label
        Me.lsv_VentasD = New Modulo_Proceso.cp_Listview
        Me.lsv_Ventas = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(8, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(768, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(622, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Status)
        Me.Gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_FechaFin)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_FechaIni)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(8, 12)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(768, 70)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(270, 15)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(109, 15)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(376, 43)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 6
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(438, 35)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(109, 41)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(261, 21)
        Me.cmb_Status.TabIndex = 5
        Me.cmb_Status.ValueMember = "value"
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(66, 44)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 4
        Me.Lbl_Status.Text = "Status"
        '
        'Lbl_FechaFin
        '
        Me.Lbl_FechaFin.AutoSize = True
        Me.Lbl_FechaFin.Location = New System.Drawing.Point(210, 19)
        Me.Lbl_FechaFin.Name = "Lbl_FechaFin"
        Me.Lbl_FechaFin.Size = New System.Drawing.Size(54, 13)
        Me.Lbl_FechaFin.TabIndex = 2
        Me.Lbl_FechaFin.Text = "Fecha Fin"
        '
        'Lbl_FechaIni
        '
        Me.Lbl_FechaIni.AutoSize = True
        Me.Lbl_FechaIni.Location = New System.Drawing.Point(38, 19)
        Me.Lbl_FechaIni.Name = "Lbl_FechaIni"
        Me.Lbl_FechaIni.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_FechaIni.TabIndex = 0
        Me.Lbl_FechaIni.Text = "Fecha Inicio"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(575, 85)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(201, 15)
        Me.Lbl_Registros.TabIndex = 53
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Registros1
        '
        Me.lbl_Registros1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros1.Location = New System.Drawing.Point(595, 225)
        Me.lbl_Registros1.Name = "lbl_Registros1"
        Me.lbl_Registros1.Size = New System.Drawing.Size(181, 15)
        Me.lbl_Registros1.TabIndex = 54
        Me.lbl_Registros1.Text = "Registros: 0"
        Me.lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_VentasD
        '
        Me.lsv_VentasD.AllowColumnReorder = True
        Me.lsv_VentasD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VentasD.FullRowSelect = True
        Me.lsv_VentasD.HideSelection = False
        Me.lsv_VentasD.Location = New System.Drawing.Point(8, 243)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_VentasD.Lvs = ListViewColumnSorter1
        Me.lsv_VentasD.MultiSelect = False
        Me.lsv_VentasD.Name = "lsv_VentasD"
        Me.lsv_VentasD.Row1 = 10
        Me.lsv_VentasD.Row10 = 0
        Me.lsv_VentasD.Row2 = 60
        Me.lsv_VentasD.Row3 = 10
        Me.lsv_VentasD.Row4 = 0
        Me.lsv_VentasD.Row5 = 0
        Me.lsv_VentasD.Row6 = 0
        Me.lsv_VentasD.Row7 = 0
        Me.lsv_VentasD.Row8 = 0
        Me.lsv_VentasD.Row9 = 0
        Me.lsv_VentasD.Size = New System.Drawing.Size(768, 250)
        Me.lsv_VentasD.TabIndex = 2
        Me.lsv_VentasD.TabStop = False
        Me.lsv_VentasD.UseCompatibleStateImageBehavior = False
        Me.lsv_VentasD.View = System.Windows.Forms.View.Details
        '
        'lsv_Ventas
        '
        Me.lsv_Ventas.AllowColumnReorder = True
        Me.lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Ventas.FullRowSelect = True
        Me.lsv_Ventas.HideSelection = False
        Me.lsv_Ventas.Location = New System.Drawing.Point(8, 103)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Ventas.Lvs = ListViewColumnSorter2
        Me.lsv_Ventas.MultiSelect = False
        Me.lsv_Ventas.Name = "lsv_Ventas"
        Me.lsv_Ventas.Row1 = 10
        Me.lsv_Ventas.Row10 = 0
        Me.lsv_Ventas.Row2 = 10
        Me.lsv_Ventas.Row3 = 50
        Me.lsv_Ventas.Row4 = 10
        Me.lsv_Ventas.Row5 = 0
        Me.lsv_Ventas.Row6 = 0
        Me.lsv_Ventas.Row7 = 0
        Me.lsv_Ventas.Row8 = 0
        Me.lsv_Ventas.Row9 = 0
        Me.lsv_Ventas.Size = New System.Drawing.Size(768, 119)
        Me.lsv_Ventas.TabIndex = 1
        Me.lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'frm_MaterialesReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.lbl_Registros1)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.lsv_VentasD)
        Me.Controls.Add(Me.lsv_Ventas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_MaterialesReporte"
        Me.Text = "Reporte de Entradas de Materiales"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_VentasD As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_Ventas As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_FechaFin As System.Windows.Forms.Label
    Friend WithEvents Lbl_FechaIni As System.Windows.Forms.Label
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros1 As System.Windows.Forms.Label
End Class
