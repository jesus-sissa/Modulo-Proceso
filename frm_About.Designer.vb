<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_About
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

    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_About))
        Me.TextBoxDescription = New System.Windows.Forms.TextBox
        Me.OKButton = New System.Windows.Forms.Button
        Me.Gbx_About = New System.Windows.Forms.GroupBox
        Me.lbl_Creditos = New System.Windows.Forms.Label
        Me.pnl_Pantalla = New System.Windows.Forms.Panel
        Me.Lsv_Programadores = New System.Windows.Forms.ListView
        Me.LabelCompanyName = New System.Windows.Forms.Label
        Me.LabelCopyright = New System.Windows.Forms.Label
        Me.LabelVersion = New System.Windows.Forms.Label
        Me.LabelProductName = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.tmr_Move = New System.Windows.Forms.Timer(Me.components)
        Me.Gbx_About.SuspendLayout()
        Me.pnl_Pantalla.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BackColor = System.Drawing.Color.White
        Me.TextBoxDescription.ForeColor = System.Drawing.Color.Black
        Me.TextBoxDescription.Location = New System.Drawing.Point(160, 120)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescription.Size = New System.Drawing.Size(257, 123)
        Me.TextBoxDescription.TabIndex = 0
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(348, 447)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&Aceptar"
        '
        'Gbx_About
        '
        Me.Gbx_About.Controls.Add(Me.lbl_Creditos)
        Me.Gbx_About.Controls.Add(Me.pnl_Pantalla)
        Me.Gbx_About.Controls.Add(Me.LabelCompanyName)
        Me.Gbx_About.Controls.Add(Me.LabelCopyright)
        Me.Gbx_About.Controls.Add(Me.LabelVersion)
        Me.Gbx_About.Controls.Add(Me.LabelProductName)
        Me.Gbx_About.Controls.Add(Me.LogoPictureBox)
        Me.Gbx_About.Controls.Add(Me.TextBoxDescription)
        Me.Gbx_About.Controls.Add(Me.OKButton)
        Me.Gbx_About.Location = New System.Drawing.Point(8, 7)
        Me.Gbx_About.Name = "Gbx_About"
        Me.Gbx_About.Size = New System.Drawing.Size(429, 476)
        Me.Gbx_About.TabIndex = 1
        Me.Gbx_About.TabStop = False
        '
        'lbl_Creditos
        '
        Me.lbl_Creditos.AutoSize = True
        Me.lbl_Creditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Creditos.Location = New System.Drawing.Point(6, 259)
        Me.lbl_Creditos.Name = "lbl_Creditos"
        Me.lbl_Creditos.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Creditos.TabIndex = 7
        Me.lbl_Creditos.Text = "Créditos:"
        '
        'pnl_Pantalla
        '
        Me.pnl_Pantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_Pantalla.Controls.Add(Me.Lsv_Programadores)
        Me.pnl_Pantalla.Location = New System.Drawing.Point(6, 275)
        Me.pnl_Pantalla.Name = "pnl_Pantalla"
        Me.pnl_Pantalla.Size = New System.Drawing.Size(411, 158)
        Me.pnl_Pantalla.TabIndex = 6
        '
        'Lsv_Programadores
        '
        Me.Lsv_Programadores.BackgroundImageTiled = True
        Me.Lsv_Programadores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lsv_Programadores.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lsv_Programadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.Lsv_Programadores.Location = New System.Drawing.Point(3, 100)
        Me.Lsv_Programadores.MultiSelect = False
        Me.Lsv_Programadores.Name = "Lsv_Programadores"
        Me.Lsv_Programadores.Scrollable = False
        Me.Lsv_Programadores.Size = New System.Drawing.Size(401, 51)
        Me.Lsv_Programadores.TabIndex = 0
        Me.Lsv_Programadores.UseCompatibleStateImageBehavior = False
        Me.Lsv_Programadores.View = System.Windows.Forms.View.Details
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompanyName.Location = New System.Drawing.Point(157, 88)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(260, 30)
        Me.LabelCompanyName.TabIndex = 5
        Me.LabelCompanyName.Text = "Nombre de la Compañía"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyright.Location = New System.Drawing.Point(157, 62)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(60, 13)
        Me.LabelCopyright.TabIndex = 4
        Me.LabelCopyright.Text = "Copyright"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.Location = New System.Drawing.Point(157, 39)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(49, 13)
        Me.LabelVersion.TabIndex = 3
        Me.LabelVersion.Text = "Versión"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(157, 18)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(83, 13)
        Me.LabelProductName.TabIndex = 2
        Me.LabelProductName.Text = "ProductName"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Modulo_Proceso.My.Resources.Resources.LogoSIAC
        Me.LogoPictureBox.Location = New System.Drawing.Point(10, 120)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(125, 30)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'tmr_Move
        '
        Me.tmr_Move.Interval = 50
        '
        'frm_About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(444, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gbx_About)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 500)
        Me.Name = "frm_About"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Gbx_About.ResumeLayout(False)
        Me.Gbx_About.PerformLayout()
        Me.pnl_Pantalla.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_About As System.Windows.Forms.GroupBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents lbl_Creditos As System.Windows.Forms.Label
    Friend WithEvents pnl_Pantalla As System.Windows.Forms.Panel
    Friend WithEvents tmr_Move As System.Windows.Forms.Timer
    Friend WithEvents Lsv_Programadores As System.Windows.Forms.ListView

End Class
