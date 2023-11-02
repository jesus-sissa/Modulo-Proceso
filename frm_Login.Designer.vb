<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frm_Login
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents tbx_Numero As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Clave As System.Windows.Forms.TextBox
    Friend WithEvents cmd_OK As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.tbx_Numero = New System.Windows.Forms.TextBox
        Me.tbx_Clave = New System.Windows.Forms.TextBox
        Me.Lbl_Siac = New System.Windows.Forms.Label
        Me.lbl_Modulo = New System.Windows.Forms.Label
        Me.cmd_Cancel = New System.Windows.Forms.Button
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmd_OK = New System.Windows.Forms.Button
        Me.lbl_Bloqueado = New System.Windows.Forms.Label
        Me.lbl_Sitio = New System.Windows.Forms.Label
        Me.Cmb_Sitio = New System.Windows.Forms.ComboBox
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(223, 84)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(85, 13)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "&ID de Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(223, 126)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(71, 13)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Numero.Location = New System.Drawing.Point(226, 100)
        Me.tbx_Numero.MaxLength = 4
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(120, 23)
        Me.tbx_Numero.TabIndex = 3
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Clave.Location = New System.Drawing.Point(226, 142)
        Me.tbx_Clave.MaxLength = 14
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Clave.Size = New System.Drawing.Size(119, 29)
        Me.tbx_Clave.TabIndex = 5
        '
        'Lbl_Siac
        '
        Me.Lbl_Siac.AutoSize = True
        Me.Lbl_Siac.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Siac.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Siac.Location = New System.Drawing.Point(64, 272)
        Me.Lbl_Siac.Name = "Lbl_Siac"
        Me.Lbl_Siac.Size = New System.Drawing.Size(361, 18)
        Me.Lbl_Siac.TabIndex = 10
        Me.Lbl_Siac.Text = "SIAC. Sistema Integral de Administración y Control"
        Me.Lbl_Siac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Modulo
        '
        Me.lbl_Modulo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Modulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Modulo.Location = New System.Drawing.Point(12, 237)
        Me.lbl_Modulo.Name = "lbl_Modulo"
        Me.lbl_Modulo.Size = New System.Drawing.Size(469, 29)
        Me.lbl_Modulo.TabIndex = 9
        Me.lbl_Modulo.Text = "Módulo Proceso"
        Me.lbl_Modulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.White
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_Cancel.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.cmd_Cancel.Location = New System.Drawing.Point(351, 177)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(120, 30)
        Me.cmd_Cancel.TabIndex = 7
        Me.cmd_Cancel.Text = "&Cancelar"
        Me.cmd_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Modulo_Proceso.My.Resources.Resources.LogoSIAC
        Me.LogoPictureBox.Location = New System.Drawing.Point(15, 100)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(195, 40)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 11
        Me.LogoPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Modulo_Proceso.My.Resources.Resources.lock
        Me.PictureBox1.Location = New System.Drawing.Point(351, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.White
        Me.cmd_OK.CausesValidation = False
        Me.cmd_OK.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.cmd_OK.Location = New System.Drawing.Point(226, 177)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(120, 30)
        Me.cmd_OK.TabIndex = 6
        Me.cmd_OK.Text = "&Aceptar"
        Me.cmd_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'lbl_Bloqueado
        '
        Me.lbl_Bloqueado.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bloqueado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Bloqueado.Location = New System.Drawing.Point(12, 206)
        Me.lbl_Bloqueado.Name = "lbl_Bloqueado"
        Me.lbl_Bloqueado.Size = New System.Drawing.Size(469, 66)
        Me.lbl_Bloqueado.TabIndex = 8
        Me.lbl_Bloqueado.Text = "BLOQUEADO POR INACTIVIDAD"
        Me.lbl_Bloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Bloqueado.Visible = False
        '
        'lbl_Sitio
        '
        Me.lbl_Sitio.AutoSize = True
        Me.lbl_Sitio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sitio.Location = New System.Drawing.Point(223, 38)
        Me.lbl_Sitio.Name = "lbl_Sitio"
        Me.lbl_Sitio.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Sitio.TabIndex = 0
        Me.lbl_Sitio.Text = "&Sitio"
        Me.lbl_Sitio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_Sitio
        '
        Me.Cmb_Sitio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Sitio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Sitio.FormattingEnabled = True
        Me.Cmb_Sitio.Location = New System.Drawing.Point(226, 54)
        Me.Cmb_Sitio.Name = "Cmb_Sitio"
        Me.Cmb_Sitio.Size = New System.Drawing.Size(142, 24)
        Me.Cmb_Sitio.TabIndex = 1
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmd_Cancel
        Me.ClientSize = New System.Drawing.Size(492, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cmb_Sitio)
        Me.Controls.Add(Me.lbl_Sitio)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_Modulo)
        Me.Controls.Add(Me.Lbl_Siac)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Controls.Add(Me.cmd_OK)
        Me.Controls.Add(Me.tbx_Clave)
        Me.Controls.Add(Me.tbx_Numero)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.lbl_Bloqueado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Siac As System.Windows.Forms.Label
    Friend WithEvents lbl_Modulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Bloqueado As System.Windows.Forms.Label
    Friend WithEvents lbl_Sitio As System.Windows.Forms.Label
    Friend WithEvents Cmb_Sitio As System.Windows.Forms.ComboBox

End Class
