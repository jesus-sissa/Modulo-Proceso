<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FirmaConexion
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
        Me.gbx_Conexion = New System.Windows.Forms.GroupBox
        Me.Tbx_Contra = New System.Windows.Forms.TextBox
        Me.Lbl_Contraseña = New System.Windows.Forms.Label
        Me.gbx_Conexion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Conexion
        '
        Me.gbx_Conexion.Controls.Add(Me.Tbx_Contra)
        Me.gbx_Conexion.Controls.Add(Me.Lbl_Contraseña)
        Me.gbx_Conexion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Conexion.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Conexion.Name = "gbx_Conexion"
        Me.gbx_Conexion.Size = New System.Drawing.Size(334, 62)
        Me.gbx_Conexion.TabIndex = 0
        Me.gbx_Conexion.TabStop = False
        '
        'Tbx_Contra
        '
        Me.Tbx_Contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Contra.Location = New System.Drawing.Point(119, 22)
        Me.Tbx_Contra.MaxLength = 20
        Me.Tbx_Contra.Name = "Tbx_Contra"
        Me.Tbx_Contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tbx_Contra.Size = New System.Drawing.Size(209, 26)
        Me.Tbx_Contra.TabIndex = 1
        Me.Tbx_Contra.UseSystemPasswordChar = True
        '
        'Lbl_Contraseña
        '
        Me.Lbl_Contraseña.AutoSize = True
        Me.Lbl_Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contraseña.Location = New System.Drawing.Point(6, 25)
        Me.Lbl_Contraseña.Name = "Lbl_Contraseña"
        Me.Lbl_Contraseña.Size = New System.Drawing.Size(107, 20)
        Me.Lbl_Contraseña.TabIndex = 0
        Me.Lbl_Contraseña.Text = "Contraseña:"
        '
        'frm_FirmaConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 62)
        Me.Controls.Add(Me.gbx_Conexion)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 100)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(350, 100)
        Me.Name = "frm_FirmaConexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Acceso"
        Me.gbx_Conexion.ResumeLayout(False)
        Me.gbx_Conexion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Conexion As System.Windows.Forms.GroupBox
    Friend WithEvents Tbx_Contra As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contraseña As System.Windows.Forms.Label
End Class
