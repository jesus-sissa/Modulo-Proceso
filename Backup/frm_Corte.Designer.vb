<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Corte
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
        Me.lbl_Sesion = New System.Windows.Forms.Label
        Me.tbx_Sesion = New System.Windows.Forms.TextBox
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_CorteActual = New System.Windows.Forms.Label
        Me.tbx_CorteActual = New System.Windows.Forms.TextBox
        Me.Btn_Generar = New System.Windows.Forms.Button
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Location = New System.Drawing.Point(64, 12)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Sesion.TabIndex = 0
        Me.lbl_Sesion.Text = "Sesion"
        '
        'tbx_Sesion
        '
        Me.tbx_Sesion.Location = New System.Drawing.Point(109, 12)
        Me.tbx_Sesion.Name = "tbx_Sesion"
        Me.tbx_Sesion.Size = New System.Drawing.Size(115, 20)
        Me.tbx_Sesion.TabIndex = 1
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(30, 38)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 2
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'lbl_CorteActual
        '
        Me.lbl_CorteActual.AutoSize = True
        Me.lbl_CorteActual.Location = New System.Drawing.Point(38, 65)
        Me.lbl_CorteActual.Name = "lbl_CorteActual"
        Me.lbl_CorteActual.Size = New System.Drawing.Size(65, 13)
        Me.lbl_CorteActual.TabIndex = 4
        Me.lbl_CorteActual.Text = "Corte Actual"
        '
        'tbx_CorteActual
        '
        Me.tbx_CorteActual.Location = New System.Drawing.Point(109, 65)
        Me.tbx_CorteActual.Name = "tbx_CorteActual"
        Me.tbx_CorteActual.Size = New System.Drawing.Size(100, 20)
        Me.tbx_CorteActual.TabIndex = 5
        '
        'Btn_Generar
        '
        Me.Btn_Generar.Enabled = False
        Me.Btn_Generar.Image = Global.Modulo_Proceso.My.Resources.Resources.fileexport
        Me.Btn_Generar.Location = New System.Drawing.Point(12, 101)
        Me.Btn_Generar.Name = "Btn_Generar"
        Me.Btn_Generar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Generar.TabIndex = 24
        Me.Btn_Generar.Text = "Generar"
        Me.Btn_Generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Generar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Generar.UseVisualStyleBackColor = True
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(109, 38)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(327, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 3
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(296, 101)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 23
        Me.btn_Cerrar.Text = "&Cerrar Ventana"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_Corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 141)
        Me.Controls.Add(Me.Btn_Generar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.tbx_CorteActual)
        Me.Controls.Add(Me.lbl_CorteActual)
        Me.Controls.Add(Me.cmb_CajaBancaria)
        Me.Controls.Add(Me.lbl_CajaBancaria)
        Me.Controls.Add(Me.tbx_Sesion)
        Me.Controls.Add(Me.lbl_Sesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 170)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 170)
        Me.Name = "frm_Corte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents tbx_Sesion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_CorteActual As System.Windows.Forms.Label
    Friend WithEvents tbx_CorteActual As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Generar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
End Class
