<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecibirServicioRec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RecibirServicioRec))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Recibir = New System.Windows.Forms.Button
        Me.gbx_Lista = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New System.Windows.Forms.TextBox
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_RemisionesD = New Modulo_Proceso.cp_Listview
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.lsv_Remisiones = New Modulo_Proceso.cp_Listview
        Me.gbx_botones.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.btn_Recibir)
        Me.gbx_botones.Location = New System.Drawing.Point(6, 507)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(773, 50)
        Me.gbx_botones.TabIndex = 1
        Me.gbx_botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Recibir
        '
        Me.btn_Recibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recibir.Enabled = False
        Me.btn_Recibir.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Recibir.Location = New System.Drawing.Point(6, 13)
        Me.btn_Recibir.Name = "btn_Recibir"
        Me.btn_Recibir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibir.TabIndex = 0
        Me.btn_Recibir.Text = "&Recibir"
        Me.btn_Recibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibir.UseVisualStyleBackColor = True
        '
        'gbx_Lista
        '
        Me.gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lista.Controls.Add(Me.lsv_RemisionesD)
        Me.gbx_Lista.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Lista.Controls.Add(Me.btn_Buscar)
        Me.gbx_Lista.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Lista.Controls.Add(Me.lbl_Buscar)
        Me.gbx_Lista.Controls.Add(Me.lsv_Envases)
        Me.gbx_Lista.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Lista.Location = New System.Drawing.Point(6, 4)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(773, 502)
        Me.gbx_Lista.TabIndex = 0
        Me.gbx_Lista.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(532, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(235, 15)
        Me.Lbl_Registros.TabIndex = 55
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(321, 11)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Location = New System.Drawing.Point(52, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(263, 20)
        Me.tbx_Buscar.TabIndex = 1
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar"
        '
        'lsv_RemisionesD
        '
        Me.lsv_RemisionesD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_RemisionesD.FullRowSelect = True
        Me.lsv_RemisionesD.HideSelection = False
        Me.lsv_RemisionesD.Location = New System.Drawing.Point(402, 279)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_RemisionesD.Lvs = ListViewColumnSorter1
        Me.lsv_RemisionesD.MultiSelect = False
        Me.lsv_RemisionesD.Name = "lsv_RemisionesD"
        Me.lsv_RemisionesD.Row1 = 30
        Me.lsv_RemisionesD.Row10 = 0
        Me.lsv_RemisionesD.Row2 = 30
        Me.lsv_RemisionesD.Row3 = 30
        Me.lsv_RemisionesD.Row4 = 0
        Me.lsv_RemisionesD.Row5 = 0
        Me.lsv_RemisionesD.Row6 = 0
        Me.lsv_RemisionesD.Row7 = 0
        Me.lsv_RemisionesD.Row8 = 0
        Me.lsv_RemisionesD.Row9 = 0
        Me.lsv_RemisionesD.Size = New System.Drawing.Size(364, 217)
        Me.lsv_RemisionesD.TabIndex = 56
        Me.lsv_RemisionesD.UseCompatibleStateImageBehavior = False
        Me.lsv_RemisionesD.View = System.Windows.Forms.View.Details
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(6, 279)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter2
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 40
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 50
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(390, 217)
        Me.lsv_Envases.TabIndex = 5
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.CheckBoxes = True
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter3
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 8
        Me.lsv_Remisiones.Row10 = 0
        Me.lsv_Remisiones.Row2 = 7
        Me.lsv_Remisiones.Row3 = 7
        Me.lsv_Remisiones.Row4 = 7
        Me.lsv_Remisiones.Row5 = 20
        Me.lsv_Remisiones.Row6 = 22
        Me.lsv_Remisiones.Row7 = 22
        Me.lsv_Remisiones.Row8 = 0
        Me.lsv_Remisiones.Row9 = 0
        Me.lsv_Remisiones.Size = New System.Drawing.Size(761, 233)
        Me.lsv_Remisiones.TabIndex = 4
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'frm_RecibirServicioRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Lista)
        Me.Controls.Add(Me.gbx_botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_RecibirServicioRec"
        Me.Text = "Recibir Servicios de Bóveda"
        Me.gbx_botones.ResumeLayout(False)
        Me.gbx_Lista.ResumeLayout(False)
        Me.gbx_Lista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_RemisionesD As Modulo_Proceso.cp_Listview
End Class
