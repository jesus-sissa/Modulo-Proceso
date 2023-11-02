<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NumeroSugeridoModal
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
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.tbx_Valor = New Modulo_Proceso.cp_Textbox
        Me.SuspendLayout()
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.Image = Global.Modulo_Proceso.My.Resources.Resources.apply
        Me.btn_Aceptar.Location = New System.Drawing.Point(72, 71)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Aceptar.TabIndex = 1
        Me.btn_Aceptar.Text = "&Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'tbx_Valor
        '
        Me.tbx_Valor.Control_Siguiente = Nothing
        Me.tbx_Valor.Filtrado = False
        Me.tbx_Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Valor.ForeColor = System.Drawing.Color.Red
        Me.tbx_Valor.Location = New System.Drawing.Point(12, 12)
        Me.tbx_Valor.MaxLength = 10
        Me.tbx_Valor.Name = "tbx_Valor"
        Me.tbx_Valor.Size = New System.Drawing.Size(268, 53)
        Me.tbx_Valor.TabIndex = 0
        Me.tbx_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Valor.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Frm_NumeroSugeridoModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.tbx_Valor)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 150)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 150)
        Me.Name = "Frm_NumeroSugeridoModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numero de Archivo sugerido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents tbx_Valor As Modulo_Proceso.cp_Textbox
End Class
