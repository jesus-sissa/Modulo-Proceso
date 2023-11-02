<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LoginContra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LoginContra))
        Me.Lbl_NuevaContra = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.Lbl_ConfNuevaContra = New System.Windows.Forms.Label
        Me.cmd_Cancel = New System.Windows.Forms.Button
        Me.cmd_OK = New System.Windows.Forms.Button
        Me.Lbl_Mensaje = New System.Windows.Forms.Label
        Me.tbx_Nueva1 = New System.Windows.Forms.TextBox
        Me.tbx_Nueva = New System.Windows.Forms.TextBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_NuevaContra
        '
        Me.Lbl_NuevaContra.AutoSize = True
        Me.Lbl_NuevaContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NuevaContra.Location = New System.Drawing.Point(114, 9)
        Me.Lbl_NuevaContra.Name = "Lbl_NuevaContra"
        Me.Lbl_NuevaContra.Size = New System.Drawing.Size(112, 13)
        Me.Lbl_NuevaContra.TabIndex = 0
        Me.Lbl_NuevaContra.Text = "Nueva Contraseña"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 9)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(103, 103)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 2
        Me.LogoPictureBox.TabStop = False
        '
        'Lbl_ConfNuevaContra
        '
        Me.Lbl_ConfNuevaContra.AutoSize = True
        Me.Lbl_ConfNuevaContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ConfNuevaContra.Location = New System.Drawing.Point(114, 59)
        Me.Lbl_ConfNuevaContra.Name = "Lbl_ConfNuevaContra"
        Me.Lbl_ConfNuevaContra.Size = New System.Drawing.Size(169, 13)
        Me.Lbl_ConfNuevaContra.TabIndex = 2
        Me.Lbl_ConfNuevaContra.Text = "Confirmar Nueva Contraseña"
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_Cancel.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.cmd_Cancel.Location = New System.Drawing.Point(153, 186)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Cancel.TabIndex = 6
        Me.cmd_Cancel.Text = "&Cancelar"
        Me.cmd_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_OK.CausesValidation = False
        Me.cmd_OK.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.cmd_OK.Location = New System.Drawing.Point(12, 186)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(140, 30)
        Me.cmd_OK.TabIndex = 5
        Me.cmd_OK.Text = "&Aceptar"
        Me.cmd_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Lbl_Mensaje
        '
        Me.Lbl_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Mensaje.Location = New System.Drawing.Point(12, 120)
        Me.Lbl_Mensaje.Name = "Lbl_Mensaje"
        Me.Lbl_Mensaje.Size = New System.Drawing.Size(286, 51)
        Me.Lbl_Mensaje.TabIndex = 4
        Me.Lbl_Mensaje.Text = "Las contraseñas solo deben contener Letras, Numeros y los siguientes caracteres a" & _
            "dicionales: ""."", "","", ""-"", ""("", "")"", ""@"""
        Me.Lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbx_Nueva1
        '
        Me.tbx_Nueva1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Nueva1.Location = New System.Drawing.Point(117, 75)
        Me.tbx_Nueva1.MaxLength = 14
        Me.tbx_Nueva1.Name = "tbx_Nueva1"
        Me.tbx_Nueva1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Nueva1.Size = New System.Drawing.Size(166, 26)
        Me.tbx_Nueva1.TabIndex = 3
        '
        'tbx_Nueva
        '
        Me.tbx_Nueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Nueva.Location = New System.Drawing.Point(117, 25)
        Me.tbx_Nueva.MaxLength = 14
        Me.tbx_Nueva.Name = "tbx_Nueva"
        Me.tbx_Nueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Nueva.Size = New System.Drawing.Size(166, 26)
        Me.tbx_Nueva.TabIndex = 1
        '
        'frm_LoginContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(308, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbx_Nueva)
        Me.Controls.Add(Me.tbx_Nueva1)
        Me.Controls.Add(Me.Lbl_Mensaje)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Controls.Add(Me.cmd_OK)
        Me.Controls.Add(Me.Lbl_ConfNuevaContra)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.Lbl_NuevaContra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_LoginContra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_NuevaContra As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_ConfNuevaContra As System.Windows.Forms.Label
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_OK As System.Windows.Forms.Button
    Friend WithEvents Lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents tbx_Nueva1 As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Nueva As System.Windows.Forms.TextBox
End Class
