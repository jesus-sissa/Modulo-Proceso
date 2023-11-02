<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BuscarRemisionxEnvase
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
        Me.lbl_Remision = New System.Windows.Forms.Label()
        Me.tbx_Envase = New Modulo_Proceso.cp_Textbox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(15, 18)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Remision.TabIndex = 6
        Me.lbl_Remision.Text = "Envase"
        '
        'tbx_Envase
        '
        Me.tbx_Envase.Control_Siguiente = Nothing
        Me.tbx_Envase.Filtrado = True
        Me.tbx_Envase.Location = New System.Drawing.Point(71, 15)
        Me.tbx_Envase.MaxLength = 20
        Me.tbx_Envase.Name = "tbx_Envase"
        Me.tbx_Envase.Size = New System.Drawing.Size(200, 20)
        Me.tbx_Envase.TabIndex = 5
        Me.tbx_Envase.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Buscar.Location = New System.Drawing.Point(277, 12)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(22, 23)
        Me.btn_Buscar.TabIndex = 7
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'frm_BuscarRemisionxEnvase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 63)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.lbl_Remision)
        Me.Controls.Add(Me.tbx_Envase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_BuscarRemisionxEnvase"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Buscar As Button
    Friend WithEvents lbl_Remision As Label
    Friend WithEvents tbx_Envase As cp_Textbox
End Class
