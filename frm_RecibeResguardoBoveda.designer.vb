<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecibeResguardoBoveda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RecibeResguardoBoveda))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Recibe = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_Registros1 = New System.Windows.Forms.Label
        Me.lsv_ResguardosD = New Modulo_Proceso.cp_Listview
        Me.lsv_Resguardos = New Modulo_Proceso.cp_Listview
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.lbl_Registros2 = New System.Windows.Forms.Label
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(614, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 38
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Recibe
        '
        Me.btn_Recibe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recibe.Enabled = False
        Me.btn_Recibe.Image = CType(resources.GetObject("btn_Recibe.Image"), System.Drawing.Image)
        Me.btn_Recibe.Location = New System.Drawing.Point(6, 14)
        Me.btn_Recibe.Name = "btn_Recibe"
        Me.btn_Recibe.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibe.TabIndex = 37
        Me.btn_Recibe.Text = "&Recibe"
        Me.btn_Recibe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibe.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Recibe)
        Me.Gbx_Botones.Location = New System.Drawing.Point(12, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(760, 50)
        Me.Gbx_Botones.TabIndex = 44
        Me.Gbx_Botones.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(632, 9)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(146, 15)
        Me.Lbl_Registros.TabIndex = 55
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Registros1
        '
        Me.Lbl_Registros1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros1.Location = New System.Drawing.Point(632, 157)
        Me.Lbl_Registros1.Name = "Lbl_Registros1"
        Me.Lbl_Registros1.Size = New System.Drawing.Size(146, 15)
        Me.Lbl_Registros1.TabIndex = 56
        Me.Lbl_Registros1.Text = "Registros: 0"
        Me.Lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ResguardosD
        '
        Me.lsv_ResguardosD.AllowColumnReorder = True
        Me.lsv_ResguardosD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ResguardosD.FullRowSelect = True
        Me.lsv_ResguardosD.HideSelection = False
        Me.lsv_ResguardosD.Location = New System.Drawing.Point(12, 180)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ResguardosD.Lvs = ListViewColumnSorter1
        Me.lsv_ResguardosD.MultiSelect = False
        Me.lsv_ResguardosD.Name = "lsv_ResguardosD"
        Me.lsv_ResguardosD.Row1 = 10
        Me.lsv_ResguardosD.Row10 = 0
        Me.lsv_ResguardosD.Row2 = 20
        Me.lsv_ResguardosD.Row3 = 15
        Me.lsv_ResguardosD.Row4 = 0
        Me.lsv_ResguardosD.Row5 = 0
        Me.lsv_ResguardosD.Row6 = 0
        Me.lsv_ResguardosD.Row7 = 0
        Me.lsv_ResguardosD.Row8 = 0
        Me.lsv_ResguardosD.Row9 = 0
        Me.lsv_ResguardosD.Size = New System.Drawing.Size(760, 143)
        Me.lsv_ResguardosD.TabIndex = 45
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
        Me.lsv_Resguardos.Location = New System.Drawing.Point(12, 27)
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
        Me.lsv_Resguardos.Row6 = 0
        Me.lsv_Resguardos.Row7 = 0
        Me.lsv_Resguardos.Row8 = 0
        Me.lsv_Resguardos.Row9 = 0
        Me.lsv_Resguardos.Size = New System.Drawing.Size(760, 119)
        Me.lsv_Resguardos.TabIndex = 41
        Me.lsv_Resguardos.UseCompatibleStateImageBehavior = False
        Me.lsv_Resguardos.View = System.Windows.Forms.View.Details
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(10, 353)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter3
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 10
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 20
        Me.lsv_Envases.Row3 = 15
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(760, 143)
        Me.lsv_Envases.TabIndex = 60
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'lbl_Registros2
        '
        Me.lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros2.Location = New System.Drawing.Point(630, 333)
        Me.lbl_Registros2.Name = "lbl_Registros2"
        Me.lbl_Registros2.Size = New System.Drawing.Size(146, 15)
        Me.lbl_Registros2.TabIndex = 59
        Me.lbl_Registros2.Text = "Registros: 0"
        Me.lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_RecibeResguardoBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lsv_Envases)
        Me.Controls.Add(Me.lbl_Registros2)
        Me.Controls.Add(Me.Lbl_Registros1)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.lsv_ResguardosD)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.lsv_Resguardos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_RecibeResguardoBoveda"
        Me.Text = "Recibe Resguardo de Boveda"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Resguardos As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibe As System.Windows.Forms.Button
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ResguardosD As Modulo_Proceso.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros1 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_Registros2 As System.Windows.Forms.Label
End Class
