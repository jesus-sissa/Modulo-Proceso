<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelaRegEnvioBoveda
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
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CancelaRegEnvioBoveda))
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.lsv_ResguardosD = New Modulo_Proceso.cp_Listview
        Me.lsv_Resguardos = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_Registros2 = New System.Windows.Forms.Label
        Me.lbl_Resgistros3 = New System.Windows.Forms.Label
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsv_ResguardosD
        '
        Me.lsv_ResguardosD.AllowColumnReorder = True
        Me.lsv_ResguardosD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ResguardosD.FullRowSelect = True
        Me.lsv_ResguardosD.HideSelection = False
        Me.lsv_ResguardosD.Location = New System.Drawing.Point(12, 178)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ResguardosD.Lvs = ListViewColumnSorter1
        Me.lsv_ResguardosD.MultiSelect = False
        Me.lsv_ResguardosD.Name = "lsv_ResguardosD"
        Me.lsv_ResguardosD.Row1 = 10
        Me.lsv_ResguardosD.Row10 = 0
        Me.lsv_ResguardosD.Row2 = 80
        Me.lsv_ResguardosD.Row3 = 0
        Me.lsv_ResguardosD.Row4 = 0
        Me.lsv_ResguardosD.Row5 = 0
        Me.lsv_ResguardosD.Row6 = 0
        Me.lsv_ResguardosD.Row7 = 0
        Me.lsv_ResguardosD.Row8 = 0
        Me.lsv_ResguardosD.Row9 = 0
        Me.lsv_ResguardosD.Size = New System.Drawing.Size(693, 128)
        Me.lsv_ResguardosD.TabIndex = 42
        Me.lsv_ResguardosD.UseCompatibleStateImageBehavior = False
        Me.lsv_ResguardosD.View = System.Windows.Forms.View.Details
        '
        'lsv_Resguardos
        '
        Me.lsv_Resguardos.AllowColumnReorder = True
        Me.lsv_Resguardos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Resguardos.FullRowSelect = True
        Me.lsv_Resguardos.HideSelection = False
        Me.lsv_Resguardos.Location = New System.Drawing.Point(12, 35)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Resguardos.Lvs = ListViewColumnSorter2
        Me.lsv_Resguardos.MultiSelect = False
        Me.lsv_Resguardos.Name = "lsv_Resguardos"
        Me.lsv_Resguardos.Row1 = 10
        Me.lsv_Resguardos.Row10 = 0
        Me.lsv_Resguardos.Row2 = 10
        Me.lsv_Resguardos.Row3 = 10
        Me.lsv_Resguardos.Row4 = 10
        Me.lsv_Resguardos.Row5 = 10
        Me.lsv_Resguardos.Row6 = 10
        Me.lsv_Resguardos.Row7 = 10
        Me.lsv_Resguardos.Row8 = 0
        Me.lsv_Resguardos.Row9 = 0
        Me.lsv_Resguardos.Size = New System.Drawing.Size(693, 111)
        Me.lsv_Resguardos.TabIndex = 41
        Me.lsv_Resguardos.UseCompatibleStateImageBehavior = False
        Me.lsv_Resguardos.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(12, 476)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(693, 50)
        Me.Gbx_Botones.TabIndex = 43
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(547, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 40
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 39
        Me.btn_Cancelar.Text = "&Cancela"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(558, 9)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(147, 23)
        Me.Lbl_Registros.TabIndex = 50
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Registros2
        '
        Me.Lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros2.Location = New System.Drawing.Point(550, 153)
        Me.Lbl_Registros2.Name = "Lbl_Registros2"
        Me.Lbl_Registros2.Size = New System.Drawing.Size(155, 23)
        Me.Lbl_Registros2.TabIndex = 51
        Me.Lbl_Registros2.Text = "Registros: 0"
        Me.Lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Resgistros3
        '
        Me.lbl_Resgistros3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Resgistros3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Resgistros3.Location = New System.Drawing.Point(549, 312)
        Me.lbl_Resgistros3.Name = "lbl_Resgistros3"
        Me.lbl_Resgistros3.Size = New System.Drawing.Size(155, 23)
        Me.lbl_Resgistros3.TabIndex = 55
        Me.lbl_Resgistros3.Text = "Registros: 0"
        Me.lbl_Resgistros3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(11, 342)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter3
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 10
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 80
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(693, 132)
        Me.lsv_Envases.TabIndex = 54
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'frm_CancelaRegEnvioBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 538)
        Me.Controls.Add(Me.lbl_Resgistros3)
        Me.Controls.Add(Me.lsv_Envases)
        Me.Controls.Add(Me.Lbl_Registros2)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.lsv_ResguardosD)
        Me.Controls.Add(Me.lsv_Resguardos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_CancelaRegEnvioBoveda"
        Me.Text = "Cancela Resg Envío a Bóveda"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Resguardos As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_ResguardosD As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Resgistros3 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
End Class
