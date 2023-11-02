<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GenerarZip
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
        Me.lbl_Archivo = New System.Windows.Forms.Label
        Me.tbx_Archivo = New System.Windows.Forms.TextBox
        Me.btn_SeleccionarArchivo = New System.Windows.Forms.Button
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.tbx_Nombre = New System.Windows.Forms.TextBox
        Me.mc_Nombre = New System.Windows.Forms.MonthCalendar
        Me.lbl_Banco = New System.Windows.Forms.Label
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.tbx_Destino = New System.Windows.Forms.TextBox
        Me.btn_SeleccionarDestino = New System.Windows.Forms.Button
        Me.btn_Comprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.pb_Progreso = New System.Windows.Forms.ProgressBar
        Me.cmb_Banco = New Modulo_Proceso.cp_cmb_Simple
        Me.SuspendLayout()
        '
        'lbl_Archivo
        '
        Me.lbl_Archivo.AutoSize = True
        Me.lbl_Archivo.Location = New System.Drawing.Point(47, 15)
        Me.lbl_Archivo.Name = "lbl_Archivo"
        Me.lbl_Archivo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Archivo.TabIndex = 0
        Me.lbl_Archivo.Text = "Archivo"
        '
        'tbx_Archivo
        '
        Me.tbx_Archivo.BackColor = System.Drawing.Color.White
        Me.tbx_Archivo.Location = New System.Drawing.Point(96, 12)
        Me.tbx_Archivo.Name = "tbx_Archivo"
        Me.tbx_Archivo.ReadOnly = True
        Me.tbx_Archivo.Size = New System.Drawing.Size(202, 20)
        Me.tbx_Archivo.TabIndex = 1
        '
        'btn_SeleccionarArchivo
        '
        Me.btn_SeleccionarArchivo.Location = New System.Drawing.Point(304, 10)
        Me.btn_SeleccionarArchivo.Name = "btn_SeleccionarArchivo"
        Me.btn_SeleccionarArchivo.Size = New System.Drawing.Size(25, 23)
        Me.btn_SeleccionarArchivo.TabIndex = 2
        Me.btn_SeleccionarArchivo.Text = "..."
        Me.btn_SeleccionarArchivo.UseVisualStyleBackColor = True
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(11, 41)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(79, 13)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre Nuevo"
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.BackColor = System.Drawing.Color.White
        Me.tbx_Nombre.Location = New System.Drawing.Point(96, 38)
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.ReadOnly = True
        Me.tbx_Nombre.Size = New System.Drawing.Size(202, 20)
        Me.tbx_Nombre.TabIndex = 4
        '
        'mc_Nombre
        '
        Me.mc_Nombre.Location = New System.Drawing.Point(342, 10)
        Me.mc_Nombre.Name = "mc_Nombre"
        Me.mc_Nombre.TabIndex = 5
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(52, 67)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Banco.TabIndex = 6
        Me.lbl_Banco.Text = "Banco"
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(47, 94)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 8
        Me.lbl_Destino.Text = "Destino"
        '
        'tbx_Destino
        '
        Me.tbx_Destino.BackColor = System.Drawing.Color.White
        Me.tbx_Destino.Location = New System.Drawing.Point(96, 91)
        Me.tbx_Destino.Name = "tbx_Destino"
        Me.tbx_Destino.ReadOnly = True
        Me.tbx_Destino.Size = New System.Drawing.Size(202, 20)
        Me.tbx_Destino.TabIndex = 9
        '
        'btn_SeleccionarDestino
        '
        Me.btn_SeleccionarDestino.Location = New System.Drawing.Point(304, 88)
        Me.btn_SeleccionarDestino.Name = "btn_SeleccionarDestino"
        Me.btn_SeleccionarDestino.Size = New System.Drawing.Size(25, 23)
        Me.btn_SeleccionarDestino.TabIndex = 2
        Me.btn_SeleccionarDestino.Text = "..."
        Me.btn_SeleccionarDestino.UseVisualStyleBackColor = True
        '
        'btn_Comprimir
        '
        Me.btn_Comprimir.Enabled = False
        Me.btn_Comprimir.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Comprimir.Location = New System.Drawing.Point(12, 179)
        Me.btn_Comprimir.Name = "btn_Comprimir"
        Me.btn_Comprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Comprimir.TabIndex = 10
        Me.btn_Comprimir.Text = "&Comprimir"
        Me.btn_Comprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Comprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Comprimir.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(450, 179)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 11
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'pb_Progreso
        '
        Me.pb_Progreso.Location = New System.Drawing.Point(12, 142)
        Me.pb_Progreso.Maximum = 200
        Me.pb_Progreso.Name = "pb_Progreso"
        Me.pb_Progreso.Size = New System.Drawing.Size(318, 23)
        Me.pb_Progreso.TabIndex = 12
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Control_Siguiente = Nothing
        Me.cmb_Banco.DisplayMember = "Nombre"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(96, 64)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = True
        Me.cmb_Banco.Size = New System.Drawing.Size(202, 21)
        Me.cmb_Banco.StoredProcedure = "Cat_Bancos_Get"
        Me.cmb_Banco.Sucursal = False
        Me.cmb_Banco.TabIndex = 7
        Me.cmb_Banco.ValueMember = "Clave"
        '
        'frm_GenerarZip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 221)
        Me.Controls.Add(Me.pb_Progreso)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.btn_Comprimir)
        Me.Controls.Add(Me.tbx_Destino)
        Me.Controls.Add(Me.lbl_Destino)
        Me.Controls.Add(Me.cmb_Banco)
        Me.Controls.Add(Me.lbl_Banco)
        Me.Controls.Add(Me.mc_Nombre)
        Me.Controls.Add(Me.tbx_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.btn_SeleccionarDestino)
        Me.Controls.Add(Me.btn_SeleccionarArchivo)
        Me.Controls.Add(Me.tbx_Archivo)
        Me.Controls.Add(Me.lbl_Archivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 250)
        Me.Name = "frm_GenerarZip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Archivo Zip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Archivo As System.Windows.Forms.Label
    Friend WithEvents tbx_Archivo As System.Windows.Forms.TextBox
    Friend WithEvents btn_SeleccionarArchivo As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents mc_Nombre As System.Windows.Forms.MonthCalendar
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
    Friend WithEvents cmb_Banco As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents tbx_Destino As System.Windows.Forms.TextBox
    Friend WithEvents btn_SeleccionarDestino As System.Windows.Forms.Button
    Friend WithEvents btn_Comprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents pb_Progreso As System.Windows.Forms.ProgressBar
End Class
