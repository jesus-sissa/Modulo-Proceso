<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GuardarArchivo
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_GuardarXficha = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbx_Datos = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.Lbl_Azul = New System.Windows.Forms.Label()
        Me.Lbl_Verde = New System.Windows.Forms.Label()
        Me.lsv_Servicios = New Modulo_Proceso.cp_Listview()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_GuardarXficha)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 513)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(788, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_GuardarXficha
        '
        Me.btn_GuardarXficha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardarXficha.Enabled = False
        Me.btn_GuardarXficha.Image = Global.Modulo_Proceso.My.Resources.Resources.fileexport
        Me.btn_GuardarXficha.Location = New System.Drawing.Point(284, 11)
        Me.btn_GuardarXficha.Name = "btn_GuardarXficha"
        Me.btn_GuardarXficha.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarXficha.TabIndex = 43
        Me.btn_GuardarXficha.Text = "&Generar 1 x Ficha"
        Me.btn_GuardarXficha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarXficha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarXficha.UseVisualStyleBackColor = True
        Me.btn_GuardarXficha.Visible = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(639, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 42
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.fileexport
        Me.btn_Guardar.Location = New System.Drawing.Point(9, 11)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 41
        Me.btn_Guardar.Text = "&Generar Normal"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Azul)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Verde)
        Me.gbx_Datos.Controls.Add(Me.lsv_Servicios)
        Me.gbx_Datos.Location = New System.Drawing.Point(3, 27)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(788, 491)
        Me.gbx_Datos.TabIndex = 2
        Me.gbx_Datos.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(596, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(185, 15)
        Me.Lbl_Registros.TabIndex = 53
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Azul
        '
        Me.Lbl_Azul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Azul.AutoSize = True
        Me.Lbl_Azul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Azul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_Azul.Location = New System.Drawing.Point(153, 467)
        Me.Lbl_Azul.Name = "Lbl_Azul"
        Me.Lbl_Azul.Size = New System.Drawing.Size(137, 13)
        Me.Lbl_Azul.TabIndex = 2
        Me.Lbl_Azul.Text = "Verificados en Morralla"
        '
        'Lbl_Verde
        '
        Me.Lbl_Verde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Verde.AutoSize = True
        Me.Lbl_Verde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Verde.ForeColor = System.Drawing.Color.Green
        Me.Lbl_Verde.Location = New System.Drawing.Point(9, 467)
        Me.Lbl_Verde.Name = "Lbl_Verde"
        Me.Lbl_Verde.Size = New System.Drawing.Size(138, 13)
        Me.Lbl_Verde.TabIndex = 1
        Me.Lbl_Verde.Text = "Verificados en Proceso"
        '
        'lsv_Servicios
        '
        Me.lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Servicios.CheckBoxes = True
        Me.lsv_Servicios.ForeColor = System.Drawing.Color.Green
        Me.lsv_Servicios.FullRowSelect = True
        Me.lsv_Servicios.HideSelection = False
        Me.lsv_Servicios.Location = New System.Drawing.Point(5, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Servicios.Lvs = ListViewColumnSorter1
        Me.lsv_Servicios.MultiSelect = False
        Me.lsv_Servicios.Name = "lsv_Servicios"
        Me.lsv_Servicios.Row1 = 50
        Me.lsv_Servicios.Row10 = 0
        Me.lsv_Servicios.Row2 = 50
        Me.lsv_Servicios.Row3 = 10
        Me.lsv_Servicios.Row4 = 10
        Me.lsv_Servicios.Row5 = 0
        Me.lsv_Servicios.Row6 = 0
        Me.lsv_Servicios.Row7 = 0
        Me.lsv_Servicios.Row8 = 0
        Me.lsv_Servicios.Row9 = 0
        Me.lsv_Servicios.Size = New System.Drawing.Size(776, 428)
        Me.lsv_Servicios.TabIndex = 0
        Me.lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'frm_GuardarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_GuardarArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios Disponibles"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Azul As System.Windows.Forms.Label
    Friend WithEvents Lbl_Verde As System.Windows.Forms.Label
    Friend WithEvents btn_GuardarXficha As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Servicios As cp_Listview
End Class
