<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usuarios
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
        Me.gbx_Usuarios = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Usuarios = New System.Windows.Forms.ListView
        Me.gbx_BotonesU = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Bloquear = New System.Windows.Forms.Button
        Me.gbx_Usuarios.SuspendLayout()
        Me.gbx_BotonesU.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Usuarios
        '
        Me.gbx_Usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Usuarios.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Usuarios.Controls.Add(Me.lsv_Usuarios)
        Me.gbx_Usuarios.Location = New System.Drawing.Point(6, 0)
        Me.gbx_Usuarios.Name = "gbx_Usuarios"
        Me.gbx_Usuarios.Size = New System.Drawing.Size(772, 493)
        Me.gbx_Usuarios.TabIndex = 4
        Me.gbx_Usuarios.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(568, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(198, 11)
        Me.Lbl_Registros.TabIndex = 55
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Usuarios
        '
        Me.lsv_Usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Usuarios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lsv_Usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Usuarios.FullRowSelect = True
        Me.lsv_Usuarios.HideSelection = False
        Me.lsv_Usuarios.Location = New System.Drawing.Point(3, 30)
        Me.lsv_Usuarios.MultiSelect = False
        Me.lsv_Usuarios.Name = "lsv_Usuarios"
        Me.lsv_Usuarios.Size = New System.Drawing.Size(766, 460)
        Me.lsv_Usuarios.TabIndex = 1
        Me.lsv_Usuarios.UseCompatibleStateImageBehavior = False
        Me.lsv_Usuarios.View = System.Windows.Forms.View.Details
        '
        'gbx_BotonesU
        '
        Me.gbx_BotonesU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_BotonesU.Controls.Add(Me.btn_Cerrar)
        Me.gbx_BotonesU.Controls.Add(Me.btn_Bloquear)
        Me.gbx_BotonesU.Location = New System.Drawing.Point(6, 499)
        Me.gbx_BotonesU.Name = "gbx_BotonesU"
        Me.gbx_BotonesU.Size = New System.Drawing.Size(772, 50)
        Me.gbx_BotonesU.TabIndex = 6
        Me.gbx_BotonesU.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(626, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 4
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Bloquear
        '
        Me.btn_Bloquear.Enabled = False
        Me.btn_Bloquear.Image = Global.Modulo_Proceso.My.Resources.Resources.decrypted
        Me.btn_Bloquear.Location = New System.Drawing.Point(6, 12)
        Me.btn_Bloquear.Name = "btn_Bloquear"
        Me.btn_Bloquear.Size = New System.Drawing.Size(140, 30)
        Me.btn_Bloquear.TabIndex = 2
        Me.btn_Bloquear.Text = "&Desbloquear"
        Me.btn_Bloquear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Bloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Bloquear.UseVisualStyleBackColor = True
        '
        'frm_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_BotonesU)
        Me.Controls.Add(Me.gbx_Usuarios)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Usuarios"
        Me.Text = "Desbloquear Usuarios."
        Me.gbx_Usuarios.ResumeLayout(False)
        Me.gbx_BotonesU.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Usuarios As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Usuarios As System.Windows.Forms.ListView
    Friend WithEvents gbx_BotonesU As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Bloquear As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
