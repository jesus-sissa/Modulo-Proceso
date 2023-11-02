<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActualizacionesConsultar
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
        Me.grp_Datos = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Datos = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Descripcion = New System.Windows.Forms.GroupBox
        Me.Lbl_Descripcion = New System.Windows.Forms.Label
        Me.tbx_Descripcion = New System.Windows.Forms.RichTextBox
        Me.grp_Datos.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Descripcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Datos
        '
        Me.grp_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Datos.Controls.Add(Me.Lbl_Registros)
        Me.grp_Datos.Controls.Add(Me.lsv_Datos)
        Me.grp_Datos.Location = New System.Drawing.Point(6, 5)
        Me.grp_Datos.Name = "grp_Datos"
        Me.grp_Datos.Size = New System.Drawing.Size(773, 197)
        Me.grp_Datos.TabIndex = 12
        Me.grp_Datos.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(578, 10)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(188, 23)
        Me.Lbl_Registros.TabIndex = 47
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 15
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 15
        Me.lsv_Datos.Row3 = 65
        Me.lsv_Datos.Row4 = 0
        Me.lsv_Datos.Row5 = 0
        Me.lsv_Datos.Row6 = 0
        Me.lsv_Datos.Row7 = 0
        Me.lsv_Datos.Row8 = 0
        Me.lsv_Datos.Row9 = 0
        Me.lsv_Datos.Size = New System.Drawing.Size(761, 155)
        Me.lsv_Datos.TabIndex = 17
        Me.lsv_Datos.Tag = "id_Bitacora"
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(773, 50)
        Me.Gbx_Botones.TabIndex = 13
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Descripcion
        '
        Me.Gbx_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Descripcion.Controls.Add(Me.Lbl_Descripcion)
        Me.Gbx_Descripcion.Controls.Add(Me.tbx_Descripcion)
        Me.Gbx_Descripcion.Location = New System.Drawing.Point(6, 204)
        Me.Gbx_Descripcion.Name = "Gbx_Descripcion"
        Me.Gbx_Descripcion.Size = New System.Drawing.Size(773, 301)
        Me.Gbx_Descripcion.TabIndex = 14
        Me.Gbx_Descripcion.TabStop = False
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(6, 16)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_Descripcion.TabIndex = 2
        Me.Lbl_Descripcion.Text = "Descripción"
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Descripcion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Descripcion.Location = New System.Drawing.Point(9, 32)
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.ReadOnly = True
        Me.tbx_Descripcion.Size = New System.Drawing.Size(757, 260)
        Me.tbx_Descripcion.TabIndex = 1
        Me.tbx_Descripcion.TabStop = False
        Me.tbx_Descripcion.Text = ""
        '
        'frm_ActualizacionesConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Descripcion)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.grp_Datos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ActualizacionesConsultar"
        Me.Text = "Actualizaciones Instaladas Recientemente"
        Me.grp_Datos.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Descripcion.ResumeLayout(False)
        Me.Gbx_Descripcion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents tbx_Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
