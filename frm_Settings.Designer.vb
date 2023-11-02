<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settings))
        Me.lbl_bdd = New System.Windows.Forms.Label
        Me.lbl_server = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Lbl_TipoE = New System.Windows.Forms.Label
        Me.Lbl_Sucursal = New System.Windows.Forms.Label
        Me.btn_First = New System.Windows.Forms.Button
        Me.btn_Back = New System.Windows.Forms.Button
        Me.btn_Next = New System.Windows.Forms.Button
        Me.btn_Last = New System.Windows.Forms.Button
        Me.gbx_TeclasNavega = New System.Windows.Forms.GroupBox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.lbl_Usuario = New System.Windows.Forms.Label
        Me.lbl_Contra = New System.Windows.Forms.Label
        Me.tbx_Contra = New System.Windows.Forms.TextBox
        Me.tbx_Sucursal = New Modulo_Proceso.cp_Textbox
        Me.tbx_Usuario = New Modulo_Proceso.cp_Textbox
        Me.cmb_Esquema = New Modulo_Proceso.cp_cmb_Manual
        Me.tbx_NombreServidor = New Modulo_Proceso.cp_Textbox
        Me.tbx_NombreBDD = New Modulo_Proceso.cp_Textbox
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.gbx_TeclasNavega.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_bdd
        '
        Me.lbl_bdd.AutoSize = True
        Me.lbl_bdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bdd.Location = New System.Drawing.Point(27, 89)
        Me.lbl_bdd.Name = "lbl_bdd"
        Me.lbl_bdd.Size = New System.Drawing.Size(90, 13)
        Me.lbl_bdd.TabIndex = 4
        Me.lbl_bdd.Text = "Base de Datos"
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_server.Location = New System.Drawing.Point(65, 57)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(54, 13)
        Me.lbl_server.TabIndex = 2
        Me.lbl_server.Text = "Servidor"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(215, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Guardar.CausesValidation = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Lbl_TipoE
        '
        Me.Lbl_TipoE.AutoSize = True
        Me.Lbl_TipoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TipoE.Location = New System.Drawing.Point(12, 25)
        Me.Lbl_TipoE.Name = "Lbl_TipoE"
        Me.Lbl_TipoE.Size = New System.Drawing.Size(105, 13)
        Me.Lbl_TipoE.TabIndex = 0
        Me.Lbl_TipoE.Text = "Tipo de Esquema"
        '
        'Lbl_Sucursal
        '
        Me.Lbl_Sucursal.AutoSize = True
        Me.Lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sucursal.Location = New System.Drawing.Point(61, 185)
        Me.Lbl_Sucursal.Name = "Lbl_Sucursal"
        Me.Lbl_Sucursal.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_Sucursal.TabIndex = 10
        Me.Lbl_Sucursal.Text = "Sucursal"
        Me.Lbl_Sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_First
        '
        Me.btn_First.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_First.Location = New System.Drawing.Point(6, 14)
        Me.btn_First.Name = "btn_First"
        Me.btn_First.Size = New System.Drawing.Size(65, 30)
        Me.btn_First.TabIndex = 0
        Me.btn_First.Text = "|<"
        Me.btn_First.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.Enabled = False
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.Location = New System.Drawing.Point(101, 14)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(65, 30)
        Me.btn_Back.TabIndex = 1
        Me.btn_Back.Text = "<<"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'btn_Next
        '
        Me.btn_Next.Enabled = False
        Me.btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(194, 14)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(65, 30)
        Me.btn_Next.TabIndex = 2
        Me.btn_Next.Text = ">>"
        Me.btn_Next.UseVisualStyleBackColor = True
        '
        'btn_Last
        '
        Me.btn_Last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Last.Location = New System.Drawing.Point(290, 14)
        Me.btn_Last.Name = "btn_Last"
        Me.btn_Last.Size = New System.Drawing.Size(65, 30)
        Me.btn_Last.TabIndex = 3
        Me.btn_Last.Tag = ""
        Me.btn_Last.Text = ">|"
        Me.btn_Last.UseVisualStyleBackColor = True
        '
        'gbx_TeclasNavega
        '
        Me.gbx_TeclasNavega.Controls.Add(Me.btn_First)
        Me.gbx_TeclasNavega.Controls.Add(Me.btn_Last)
        Me.gbx_TeclasNavega.Controls.Add(Me.btn_Back)
        Me.gbx_TeclasNavega.Controls.Add(Me.btn_Next)
        Me.gbx_TeclasNavega.Enabled = False
        Me.gbx_TeclasNavega.Location = New System.Drawing.Point(6, 224)
        Me.gbx_TeclasNavega.Name = "gbx_TeclasNavega"
        Me.gbx_TeclasNavega.Size = New System.Drawing.Size(361, 50)
        Me.gbx_TeclasNavega.TabIndex = 1
        Me.gbx_TeclasNavega.TabStop = False
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 278)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(361, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(67, 121)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Usuario.TabIndex = 6
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_Contra
        '
        Me.lbl_Contra.AutoSize = True
        Me.lbl_Contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contra.Location = New System.Drawing.Point(46, 153)
        Me.lbl_Contra.Name = "lbl_Contra"
        Me.lbl_Contra.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Contra.TabIndex = 8
        Me.lbl_Contra.Text = "Contraseña"
        '
        'tbx_Contra
        '
        Me.tbx_Contra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Contra.Location = New System.Drawing.Point(123, 146)
        Me.tbx_Contra.MaxLength = 20
        Me.tbx_Contra.Name = "tbx_Contra"
        Me.tbx_Contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbx_Contra.Size = New System.Drawing.Size(232, 26)
        Me.tbx_Contra.TabIndex = 9
        '
        'tbx_Sucursal
        '
        Me.tbx_Sucursal.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Sucursal.Filtrado = True
        Me.tbx_Sucursal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Sucursal.Location = New System.Drawing.Point(123, 178)
        Me.tbx_Sucursal.MaxLength = 20
        Me.tbx_Sucursal.Name = "tbx_Sucursal"
        Me.tbx_Sucursal.Size = New System.Drawing.Size(232, 26)
        Me.tbx_Sucursal.TabIndex = 11
        Me.tbx_Sucursal.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Usuario
        '
        Me.tbx_Usuario.Control_Siguiente = Me.tbx_Contra
        Me.tbx_Usuario.Filtrado = True
        Me.tbx_Usuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Usuario.Location = New System.Drawing.Point(123, 114)
        Me.tbx_Usuario.MaxLength = 20
        Me.tbx_Usuario.Name = "tbx_Usuario"
        Me.tbx_Usuario.Size = New System.Drawing.Size(232, 26)
        Me.tbx_Usuario.TabIndex = 7
        Me.tbx_Usuario.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Esquema
        '
        Me.cmb_Esquema.Control_Siguiente = Me.tbx_NombreServidor
        Me.cmb_Esquema.DisplayMember = "display"
        Me.cmb_Esquema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Esquema.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Esquema.FormattingEnabled = True
        Me.cmb_Esquema.Location = New System.Drawing.Point(123, 20)
        Me.cmb_Esquema.MaxDropDownItems = 20
        Me.cmb_Esquema.Name = "cmb_Esquema"
        Me.cmb_Esquema.Size = New System.Drawing.Size(190, 24)
        Me.cmb_Esquema.TabIndex = 1
        Me.cmb_Esquema.ValueMember = "value"
        '
        'tbx_NombreServidor
        '
        Me.tbx_NombreServidor.Control_Siguiente = Me.tbx_NombreBDD
        Me.tbx_NombreServidor.Filtrado = True
        Me.tbx_NombreServidor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NombreServidor.Location = New System.Drawing.Point(123, 50)
        Me.tbx_NombreServidor.MaxLength = 30
        Me.tbx_NombreServidor.Name = "tbx_NombreServidor"
        Me.tbx_NombreServidor.Size = New System.Drawing.Size(232, 26)
        Me.tbx_NombreServidor.TabIndex = 3
        Me.tbx_NombreServidor.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NombreBDD
        '
        Me.tbx_NombreBDD.Control_Siguiente = Me.tbx_Usuario
        Me.tbx_NombreBDD.Filtrado = True
        Me.tbx_NombreBDD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NombreBDD.Location = New System.Drawing.Point(123, 82)
        Me.tbx_NombreBDD.MaxLength = 20
        Me.tbx_NombreBDD.Name = "tbx_NombreBDD"
        Me.tbx_NombreBDD.Size = New System.Drawing.Size(232, 26)
        Me.tbx_NombreBDD.TabIndex = 5
        Me.tbx_NombreBDD.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Controls.Add(Me.Lbl_TipoE)
        Me.gbx_Datos.Controls.Add(Me.tbx_Contra)
        Me.gbx_Datos.Controls.Add(Me.lbl_server)
        Me.gbx_Datos.Controls.Add(Me.tbx_Sucursal)
        Me.gbx_Datos.Controls.Add(Me.lbl_bdd)
        Me.gbx_Datos.Controls.Add(Me.lbl_Contra)
        Me.gbx_Datos.Controls.Add(Me.tbx_NombreServidor)
        Me.gbx_Datos.Controls.Add(Me.tbx_Usuario)
        Me.gbx_Datos.Controls.Add(Me.tbx_NombreBDD)
        Me.gbx_Datos.Controls.Add(Me.lbl_Usuario)
        Me.gbx_Datos.Controls.Add(Me.cmb_Esquema)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Sucursal)
        Me.gbx_Datos.Location = New System.Drawing.Point(6, 6)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(361, 214)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 334)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_TeclasNavega)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(320, 280)
        Me.Name = "frm_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes Cadenas de  Conexión"
        Me.gbx_TeclasNavega.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbx_NombreBDD As Modulo_Proceso.cp_Textbox
    Friend WithEvents tbx_NombreServidor As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_bdd As System.Windows.Forms.Label
    Friend WithEvents lbl_server As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_Esquema As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents Lbl_TipoE As System.Windows.Forms.Label
    Friend WithEvents Lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents btn_First As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Next As System.Windows.Forms.Button
    Friend WithEvents btn_Last As System.Windows.Forms.Button
    Friend WithEvents gbx_TeclasNavega As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Usuario As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents tbx_Sucursal As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Contra As System.Windows.Forms.Label
    Friend WithEvents tbx_Contra As System.Windows.Forms.TextBox
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
End Class
