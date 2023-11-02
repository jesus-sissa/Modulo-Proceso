<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisorImagenes
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
        Me.gbx_Imagen = New System.Windows.Forms.GroupBox
        Me.pct_Imagen = New System.Windows.Forms.PictureBox
        Me.gbx_Imagen.SuspendLayout()
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Imagen
        '
        Me.gbx_Imagen.Controls.Add(Me.pct_Imagen)
        Me.gbx_Imagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Imagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Imagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbx_Imagen.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Imagen.Name = "gbx_Imagen"
        Me.gbx_Imagen.Size = New System.Drawing.Size(728, 426)
        Me.gbx_Imagen.TabIndex = 9
        Me.gbx_Imagen.TabStop = False
        Me.gbx_Imagen.Text = "Click sobre la imagen para cerrar"
        '
        'pct_Imagen
        '
        Me.pct_Imagen.BackColor = System.Drawing.SystemColors.Window
        Me.pct_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Imagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_Imagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pct_Imagen.Location = New System.Drawing.Point(3, 16)
        Me.pct_Imagen.Name = "pct_Imagen"
        Me.pct_Imagen.Size = New System.Drawing.Size(722, 407)
        Me.pct_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Imagen.TabIndex = 0
        Me.pct_Imagen.TabStop = False
        '
        'frm_VisorImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 426)
        Me.Controls.Add(Me.gbx_Imagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(467, 398)
        Me.Name = "frm_VisorImagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor de Imagenes"
        Me.gbx_Imagen.ResumeLayout(False)
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Imagen As System.Windows.Forms.GroupBox
    Friend WithEvents pct_Imagen As System.Windows.Forms.PictureBox
End Class
