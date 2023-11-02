<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EnviarDotaBoveda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EnviarDotaBoveda))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Enviar = New System.Windows.Forms.Button
        Me.cbx_Todos = New System.Windows.Forms.CheckBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lbl_Registros1 = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New System.Windows.Forms.TextBox
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.lbl_Registros2 = New System.Windows.Forms.Label
        Me.btn_ImprimirReporte = New System.Windows.Forms.Button
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.lsv_DotacionD = New Modulo_Proceso.cp_Listview
        Me.lsv_Dotacion = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(550, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 38
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_ImprimirReporte)
        Me.Gbx_Botones.Controls.Add(Me.btn_Enviar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 482)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(696, 50)
        Me.Gbx_Botones.TabIndex = 43
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Enviar.Enabled = False
        Me.btn_Enviar.Image = CType(resources.GetObject("btn_Enviar.Image"), System.Drawing.Image)
        Me.btn_Enviar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Enviar.TabIndex = 39
        Me.btn_Enviar.Text = "&Enviar"
        Me.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Enviar.UseVisualStyleBackColor = True
        '
        'cbx_Todos
        '
        Me.cbx_Todos.AutoSize = True
        Me.cbx_Todos.Location = New System.Drawing.Point(9, 12)
        Me.cbx_Todos.Name = "cbx_Todos"
        Me.cbx_Todos.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Todos.TabIndex = 44
        Me.cbx_Todos.Text = "Todos"
        Me.cbx_Todos.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(523, 6)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(182, 23)
        Me.Lbl_Registros.TabIndex = 52
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Registros1
        '
        Me.lbl_Registros1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros1.Location = New System.Drawing.Point(515, 185)
        Me.lbl_Registros1.Name = "lbl_Registros1"
        Me.lbl_Registros1.Size = New System.Drawing.Size(190, 23)
        Me.lbl_Registros1.TabIndex = 53
        Me.lbl_Registros1.Text = "Registros: 0"
        Me.lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(400, 11)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 64
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Location = New System.Drawing.Point(131, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(263, 20)
        Me.tbx_Buscar.TabIndex = 63
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(85, 16)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 62
        Me.lbl_Buscar.Text = "Buscar"
        '
        'lbl_Registros2
        '
        Me.lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros2.Location = New System.Drawing.Point(509, 344)
        Me.lbl_Registros2.Name = "lbl_Registros2"
        Me.lbl_Registros2.Size = New System.Drawing.Size(190, 23)
        Me.lbl_Registros2.TabIndex = 65
        Me.lbl_Registros2.Text = "Registros: 0"
        Me.lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_ImprimirReporte
        '
        Me.btn_ImprimirReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ImprimirReporte.Enabled = False
        Me.btn_ImprimirReporte.Image = Global.Modulo_Proceso.My.Resources.Resources.Imprimir
        Me.btn_ImprimirReporte.Location = New System.Drawing.Point(165, 14)
        Me.btn_ImprimirReporte.Name = "btn_ImprimirReporte"
        Me.btn_ImprimirReporte.Size = New System.Drawing.Size(140, 30)
        Me.btn_ImprimirReporte.TabIndex = 40
        Me.btn_ImprimirReporte.Text = "&Imprimir Reporte"
        Me.btn_ImprimirReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprimirReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImprimirReporte.UseVisualStyleBackColor = True
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(9, 366)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 30
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 30
        Me.lsv_Envases.Row3 = 30
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(690, 118)
        Me.lsv_Envases.TabIndex = 66
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'lsv_DotacionD
        '
        Me.lsv_DotacionD.AllowColumnReorder = True
        Me.lsv_DotacionD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionD.FullRowSelect = True
        Me.lsv_DotacionD.HideSelection = False
        Me.lsv_DotacionD.Location = New System.Drawing.Point(9, 214)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_DotacionD.Lvs = ListViewColumnSorter2
        Me.lsv_DotacionD.MultiSelect = False
        Me.lsv_DotacionD.Name = "lsv_DotacionD"
        Me.lsv_DotacionD.Row1 = 10
        Me.lsv_DotacionD.Row10 = 0
        Me.lsv_DotacionD.Row2 = 10
        Me.lsv_DotacionD.Row3 = 10
        Me.lsv_DotacionD.Row4 = 10
        Me.lsv_DotacionD.Row5 = 10
        Me.lsv_DotacionD.Row6 = 10
        Me.lsv_DotacionD.Row7 = 10
        Me.lsv_DotacionD.Row8 = 0
        Me.lsv_DotacionD.Row9 = 0
        Me.lsv_DotacionD.Size = New System.Drawing.Size(690, 124)
        Me.lsv_DotacionD.TabIndex = 42
        Me.lsv_DotacionD.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionD.View = System.Windows.Forms.View.Details
        '
        'lsv_Dotacion
        '
        Me.lsv_Dotacion.AllowColumnReorder = True
        Me.lsv_Dotacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotacion.FullRowSelect = True
        Me.lsv_Dotacion.HideSelection = False
        Me.lsv_Dotacion.Location = New System.Drawing.Point(9, 53)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Dotacion.Lvs = ListViewColumnSorter3
        Me.lsv_Dotacion.MultiSelect = False
        Me.lsv_Dotacion.Name = "lsv_Dotacion"
        Me.lsv_Dotacion.Row1 = 8
        Me.lsv_Dotacion.Row10 = 0
        Me.lsv_Dotacion.Row2 = 25
        Me.lsv_Dotacion.Row3 = 25
        Me.lsv_Dotacion.Row4 = 8
        Me.lsv_Dotacion.Row5 = 8
        Me.lsv_Dotacion.Row6 = 8
        Me.lsv_Dotacion.Row7 = 8
        Me.lsv_Dotacion.Row8 = 0
        Me.lsv_Dotacion.Row9 = 0
        Me.lsv_Dotacion.Size = New System.Drawing.Size(690, 123)
        Me.lsv_Dotacion.TabIndex = 41
        Me.lsv_Dotacion.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotacion.View = System.Windows.Forms.View.Details
        '
        'frm_EnviarDotaBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 538)
        Me.Controls.Add(Me.lsv_Envases)
        Me.Controls.Add(Me.lbl_Registros2)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.lbl_Registros1)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.cbx_Todos)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.lsv_DotacionD)
        Me.Controls.Add(Me.lsv_Dotacion)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_EnviarDotaBoveda"
        Me.Text = "Enviar a Boveda"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_Dotacion As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_DotacionD As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Enviar As System.Windows.Forms.Button
    Friend WithEvents cbx_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros1 As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_ImprimirReporte As System.Windows.Forms.Button
End Class
