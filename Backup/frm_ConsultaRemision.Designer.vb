<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaRemision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaRemision))
        Me.pdf = New AxAcroPDFLib.AxAcroPDF
        CType(Me.pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pdf
        '
        Me.pdf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdf.Enabled = True
        Me.pdf.Location = New System.Drawing.Point(0, 0)
        Me.pdf.Name = "pdf"
        Me.pdf.OcxState = CType(resources.GetObject("pdf.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdf.Size = New System.Drawing.Size(964, 587)
        Me.pdf.TabIndex = 0
        '
        'frm_ConsultaRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 587)
        Me.Controls.Add(Me.pdf)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ConsultaRemision"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remision Digital"
        CType(Me.pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pdf As AxAcroPDFLib.AxAcroPDF
End Class
