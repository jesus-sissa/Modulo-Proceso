<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DescargarRemision
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
        Me.Btn_Descargar = New System.Windows.Forms.Button()
        Me.tbx_numeroRemision = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.tbx_path = New System.Windows.Forms.TextBox()
        Me.btn_path = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Descargar
        '
        Me.Btn_Descargar.Location = New System.Drawing.Point(42, 157)
        Me.Btn_Descargar.Name = "Btn_Descargar"
        Me.Btn_Descargar.Size = New System.Drawing.Size(133, 39)
        Me.Btn_Descargar.TabIndex = 5
        Me.Btn_Descargar.Text = "Descargar"
        Me.Btn_Descargar.UseVisualStyleBackColor = True
        '
        'tbx_numeroRemision
        '
        Me.tbx_numeroRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_numeroRemision.Location = New System.Drawing.Point(42, 103)
        Me.tbx_numeroRemision.Name = "tbx_numeroRemision"
        Me.tbx_numeroRemision.Size = New System.Drawing.Size(272, 38)
        Me.tbx_numeroRemision.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Remision:"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(181, 157)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(133, 39)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'tbx_path
        '
        Me.tbx_path.Enabled = False
        Me.tbx_path.Location = New System.Drawing.Point(42, 22)
        Me.tbx_path.Name = "tbx_path"
        Me.tbx_path.Size = New System.Drawing.Size(272, 20)
        Me.tbx_path.TabIndex = 7
        '
        'btn_path
        '
        Me.btn_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_path.Location = New System.Drawing.Point(318, 22)
        Me.btn_path.Name = "btn_path"
        Me.btn_path.Size = New System.Drawing.Size(39, 20)
        Me.btn_path.TabIndex = 8
        Me.btn_path.Text = "***"
        Me.btn_path.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_path.UseVisualStyleBackColor = True
        '
        'frm_DescargarRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_path)
        Me.Controls.Add(Me.tbx_path)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Descargar)
        Me.Controls.Add(Me.tbx_numeroRemision)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_DescargarRemision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descargar Remisiones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Descargar As Button
    Friend WithEvents tbx_numeroRemision As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents tbx_path As TextBox
    Friend WithEvents btn_path As Button
End Class
