<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FirmaElectronica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FirmaElectronica))
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.lbl_Contraseña = New System.Windows.Forms.Label
        Me.lbl_ley = New System.Windows.Forms.Label
        Me.gbx_Observaciones = New System.Windows.Forms.GroupBox
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.lbl_Maximo = New System.Windows.Forms.Label
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.tbx_Contraseña = New System.Windows.Forms.TextBox
        Me.gbx_Firma = New System.Windows.Forms.GroupBox
        Me.tbx_Empleado = New Modulo_Proceso.cp_Textbox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.gbx_Observaciones.SuspendLayout()
        Me.gbx_Firma.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(33, 19)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(72, 13)
        Me.lbl_Empleado.TabIndex = 0
        Me.lbl_Empleado.Text = "ID de Usuario"
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Location = New System.Drawing.Point(44, 45)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Contraseña.TabIndex = 2
        Me.lbl_Contraseña.Text = "Contraseña"
        '
        'lbl_ley
        '
        Me.lbl_ley.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ley.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ley.Location = New System.Drawing.Point(5, 72)
        Me.lbl_ley.Name = "lbl_ley"
        Me.lbl_ley.Size = New System.Drawing.Size(326, 54)
        Me.lbl_ley.TabIndex = 4
        Me.lbl_ley.Text = "Con base en el Contrato celebrado entre usted y la Empresa, al realizar esta tran" & _
            "sacción Usted está ACEPTANDO las Responsabilidades que resulten de esta acción."
        Me.lbl_ley.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx_Observaciones
        '
        Me.gbx_Observaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Observaciones.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_Observaciones.Controls.Add(Me.lbl_Maximo)
        Me.gbx_Observaciones.Location = New System.Drawing.Point(7, 147)
        Me.gbx_Observaciones.Name = "gbx_Observaciones"
        Me.gbx_Observaciones.Size = New System.Drawing.Size(340, 118)
        Me.gbx_Observaciones.TabIndex = 1
        Me.gbx_Observaciones.TabStop = False
        Me.gbx_Observaciones.Text = "Observaciones"
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(6, 19)
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(325, 78)
        Me.rtb_Observaciones.TabIndex = 2
        Me.rtb_Observaciones.Text = ""
        '
        'lbl_Maximo
        '
        Me.lbl_Maximo.AutoSize = True
        Me.lbl_Maximo.Location = New System.Drawing.Point(6, 100)
        Me.lbl_Maximo.Name = "lbl_Maximo"
        Me.lbl_Maximo.Size = New System.Drawing.Size(120, 13)
        Me.lbl_Maximo.TabIndex = 1
        Me.lbl_Maximo.Text = "Máximo 150 caracteres."
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Image = CType(resources.GetObject("btn_Validar.Image"), System.Drawing.Image)
        Me.btn_Validar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(191, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'tbx_Contraseña
        '
        Me.tbx_Contraseña.Location = New System.Drawing.Point(111, 42)
        Me.tbx_Contraseña.MaxLength = 14
        Me.tbx_Contraseña.Name = "tbx_Contraseña"
        Me.tbx_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Contraseña.Size = New System.Drawing.Size(170, 20)
        Me.tbx_Contraseña.TabIndex = 3
        Me.tbx_Contraseña.UseSystemPasswordChar = True
        '
        'gbx_Firma
        '
        Me.gbx_Firma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Firma.Controls.Add(Me.lbl_ley)
        Me.gbx_Firma.Controls.Add(Me.tbx_Contraseña)
        Me.gbx_Firma.Controls.Add(Me.tbx_Empleado)
        Me.gbx_Firma.Controls.Add(Me.lbl_Empleado)
        Me.gbx_Firma.Controls.Add(Me.lbl_Contraseña)
        Me.gbx_Firma.Location = New System.Drawing.Point(7, 7)
        Me.gbx_Firma.Name = "gbx_Firma"
        Me.gbx_Firma.Size = New System.Drawing.Size(340, 135)
        Me.gbx_Firma.TabIndex = 0
        Me.gbx_Firma.TabStop = False
        '
        'tbx_Empleado
        '
        Me.tbx_Empleado.Control_Siguiente = Me.tbx_Contraseña
        Me.tbx_Empleado.Filtrado = False
        Me.tbx_Empleado.Location = New System.Drawing.Point(111, 16)
        Me.tbx_Empleado.MaxLength = 10
        Me.tbx_Empleado.Name = "tbx_Empleado"
        Me.tbx_Empleado.Size = New System.Drawing.Size(170, 20)
        Me.tbx_Empleado.TabIndex = 1
        Me.tbx_Empleado.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(7, 273)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(340, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'frm_FirmaElectronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Firma)
        Me.Controls.Add(Me.gbx_Observaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FirmaElectronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condiciones de Validación"
        Me.gbx_Observaciones.ResumeLayout(False)
        Me.gbx_Observaciones.PerformLayout()
        Me.gbx_Firma.ResumeLayout(False)
        Me.gbx_Firma.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbx_Empleado As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_Contraseña As System.Windows.Forms.Label
    Friend WithEvents lbl_ley As System.Windows.Forms.Label
    Friend WithEvents gbx_Observaciones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents tbx_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents gbx_Firma As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Maximo As System.Windows.Forms.Label
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
End Class
