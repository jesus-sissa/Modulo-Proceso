<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TabularCheques
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
        Me.lbl_Banco = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_Importe = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Generar = New System.Windows.Forms.Button
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.gbx_Buscar = New System.Windows.Forms.GroupBox
        Me.cbx_GenerarTabular = New System.Windows.Forms.CheckBox
        Me.cbx_ImagenTrasera = New System.Windows.Forms.CheckBox
        Me.tbx_ImporteLimite = New Modulo_Proceso.cp_Textbox
        Me.cbx_ImagenFrontal = New System.Windows.Forms.CheckBox
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.cmb_banco = New Modulo_Proceso.cp_cmb_Simple
        Me.gbx_Ubicaciones = New System.Windows.Forms.GroupBox
        Me.btn_Destino = New System.Windows.Forms.Button
        Me.btn_Origen = New System.Windows.Forms.Button
        Me.tbx_Destino = New System.Windows.Forms.TextBox
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.tbx_Origen = New System.Windows.Forms.TextBox
        Me.lbl_Origen = New System.Windows.Forms.Label
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gbx_Buscar.SuspendLayout()
        Me.gbx_Ubicaciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Banco
        '
        Me.lbl_Banco.AutoSize = True
        Me.lbl_Banco.Location = New System.Drawing.Point(154, 23)
        Me.lbl_Banco.Name = "lbl_Banco"
        Me.lbl_Banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Banco.TabIndex = 2
        Me.lbl_Banco.Text = "Banco"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(9, 23)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(13, 49)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 5
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_Importe
        '
        Me.lbl_Importe.AutoSize = True
        Me.lbl_Importe.Location = New System.Drawing.Point(13, 77)
        Me.lbl_Importe.Name = "lbl_Importe"
        Me.lbl_Importe.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Importe.TabIndex = 10
        Me.lbl_Importe.Text = "Importe Límite"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(402, 19)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Generar
        '
        Me.btn_Generar.Enabled = False
        Me.btn_Generar.Image = Global.Modulo_Proceso.My.Resources.Resources.Proceso
        Me.btn_Generar.Location = New System.Drawing.Point(6, 19)
        Me.btn_Generar.Name = "btn_Generar"
        Me.btn_Generar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Generar.TabIndex = 0
        Me.btn_Generar.Text = "&Generar"
        Me.btn_Generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Generar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Generar.UseVisualStyleBackColor = True
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(54, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(54, 45)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 6
        '
        'gbx_Buscar
        '
        Me.gbx_Buscar.Controls.Add(Me.cbx_GenerarTabular)
        Me.gbx_Buscar.Controls.Add(Me.cbx_ImagenTrasera)
        Me.gbx_Buscar.Controls.Add(Me.tbx_ImporteLimite)
        Me.gbx_Buscar.Controls.Add(Me.lbl_Importe)
        Me.gbx_Buscar.Controls.Add(Me.cbx_ImagenFrontal)
        Me.gbx_Buscar.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Buscar.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Buscar.Controls.Add(Me.dtp_Desde)
        Me.gbx_Buscar.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Buscar.Controls.Add(Me.lbl_Desde)
        Me.gbx_Buscar.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Buscar.Controls.Add(Me.cmb_banco)
        Me.gbx_Buscar.Controls.Add(Me.lbl_Banco)
        Me.gbx_Buscar.Location = New System.Drawing.Point(12, 12)
        Me.gbx_Buscar.Name = "gbx_Buscar"
        Me.gbx_Buscar.Size = New System.Drawing.Size(548, 113)
        Me.gbx_Buscar.TabIndex = 0
        Me.gbx_Buscar.TabStop = False
        Me.gbx_Buscar.Text = "Buscar"
        '
        'cbx_GenerarTabular
        '
        Me.cbx_GenerarTabular.AutoSize = True
        Me.cbx_GenerarTabular.Location = New System.Drawing.Point(436, 74)
        Me.cbx_GenerarTabular.Name = "cbx_GenerarTabular"
        Me.cbx_GenerarTabular.Size = New System.Drawing.Size(103, 17)
        Me.cbx_GenerarTabular.TabIndex = 12
        Me.cbx_GenerarTabular.Text = "Generar Tabular"
        Me.cbx_GenerarTabular.UseVisualStyleBackColor = True
        '
        'cbx_ImagenTrasera
        '
        Me.cbx_ImagenTrasera.AutoSize = True
        Me.cbx_ImagenTrasera.Location = New System.Drawing.Point(436, 48)
        Me.cbx_ImagenTrasera.Name = "cbx_ImagenTrasera"
        Me.cbx_ImagenTrasera.Size = New System.Drawing.Size(100, 17)
        Me.cbx_ImagenTrasera.TabIndex = 9
        Me.cbx_ImagenTrasera.Text = "Imagen Trasera"
        Me.cbx_ImagenTrasera.UseVisualStyleBackColor = True
        '
        'tbx_ImporteLimite
        '
        Me.tbx_ImporteLimite.Control_Siguiente = Nothing
        Me.tbx_ImporteLimite.Filtrado = True
        Me.tbx_ImporteLimite.Location = New System.Drawing.Point(96, 74)
        Me.tbx_ImporteLimite.MaxLength = 10
        Me.tbx_ImporteLimite.Name = "tbx_ImporteLimite"
        Me.tbx_ImporteLimite.Size = New System.Drawing.Size(110, 20)
        Me.tbx_ImporteLimite.TabIndex = 11
        Me.tbx_ImporteLimite.Text = "10000"
        Me.tbx_ImporteLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImporteLimite.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cbx_ImagenFrontal
        '
        Me.cbx_ImagenFrontal.AutoSize = True
        Me.cbx_ImagenFrontal.Location = New System.Drawing.Point(436, 22)
        Me.cbx_ImagenFrontal.Name = "cbx_ImagenFrontal"
        Me.cbx_ImagenFrontal.Size = New System.Drawing.Size(96, 17)
        Me.cbx_ImagenFrontal.TabIndex = 4
        Me.cbx_ImagenFrontal.Text = "Imagen Frontal"
        Me.cbx_ImagenFrontal.UseVisualStyleBackColor = True
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(198, 47)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = False
        Me.cmb_Moneda.Size = New System.Drawing.Size(140, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_ComboGet"
        Me.cmb_Moneda.Sucursal = False
        Me.cmb_Moneda.TabIndex = 8
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(152, 49)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 7
        Me.lbl_Moneda.Text = "Moneda"
        '
        'cmb_banco
        '
        Me.cmb_banco.Control_Siguiente = Nothing
        Me.cmb_banco.DisplayMember = "Nombre"
        Me.cmb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_banco.Empresa = False
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.Location = New System.Drawing.Point(198, 20)
        Me.cmb_banco.MaxDropDownItems = 20
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Pista = True
        Me.cmb_banco.Size = New System.Drawing.Size(232, 21)
        Me.cmb_banco.StoredProcedure = "Cat_Bancos_Get"
        Me.cmb_banco.Sucursal = False
        Me.cmb_banco.TabIndex = 3
        Me.cmb_banco.ValueMember = "Clave"
        '
        'gbx_Ubicaciones
        '
        Me.gbx_Ubicaciones.Controls.Add(Me.btn_Destino)
        Me.gbx_Ubicaciones.Controls.Add(Me.btn_Origen)
        Me.gbx_Ubicaciones.Controls.Add(Me.tbx_Destino)
        Me.gbx_Ubicaciones.Controls.Add(Me.lbl_Destino)
        Me.gbx_Ubicaciones.Controls.Add(Me.tbx_Origen)
        Me.gbx_Ubicaciones.Controls.Add(Me.lbl_Origen)
        Me.gbx_Ubicaciones.Location = New System.Drawing.Point(12, 131)
        Me.gbx_Ubicaciones.Name = "gbx_Ubicaciones"
        Me.gbx_Ubicaciones.Size = New System.Drawing.Size(548, 78)
        Me.gbx_Ubicaciones.TabIndex = 1
        Me.gbx_Ubicaciones.TabStop = False
        Me.gbx_Ubicaciones.Text = "Ubicaciones"
        '
        'btn_Destino
        '
        Me.btn_Destino.Location = New System.Drawing.Point(513, 43)
        Me.btn_Destino.Name = "btn_Destino"
        Me.btn_Destino.Size = New System.Drawing.Size(26, 23)
        Me.btn_Destino.TabIndex = 5
        Me.btn_Destino.Text = "..."
        Me.btn_Destino.UseVisualStyleBackColor = True
        '
        'btn_Origen
        '
        Me.btn_Origen.Location = New System.Drawing.Point(513, 17)
        Me.btn_Origen.Name = "btn_Origen"
        Me.btn_Origen.Size = New System.Drawing.Size(26, 23)
        Me.btn_Origen.TabIndex = 2
        Me.btn_Origen.Text = "..."
        Me.btn_Origen.UseVisualStyleBackColor = True
        '
        'tbx_Destino
        '
        Me.tbx_Destino.BackColor = System.Drawing.Color.White
        Me.tbx_Destino.Location = New System.Drawing.Point(50, 45)
        Me.tbx_Destino.Name = "tbx_Destino"
        Me.tbx_Destino.ReadOnly = True
        Me.tbx_Destino.Size = New System.Drawing.Size(457, 20)
        Me.tbx_Destino.TabIndex = 4
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(6, 48)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 3
        Me.lbl_Destino.Text = "Destino"
        '
        'tbx_Origen
        '
        Me.tbx_Origen.BackColor = System.Drawing.Color.White
        Me.tbx_Origen.Location = New System.Drawing.Point(50, 19)
        Me.tbx_Origen.Name = "tbx_Origen"
        Me.tbx_Origen.ReadOnly = True
        Me.tbx_Origen.Size = New System.Drawing.Size(457, 20)
        Me.tbx_Origen.TabIndex = 1
        '
        'lbl_Origen
        '
        Me.lbl_Origen.AutoSize = True
        Me.lbl_Origen.Location = New System.Drawing.Point(6, 22)
        Me.lbl_Origen.Name = "lbl_Origen"
        Me.lbl_Origen.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Origen.TabIndex = 0
        Me.lbl_Origen.Text = "Origen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Generar)
        Me.GroupBox1.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 60)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'frm_TabularCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 280)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbx_Ubicaciones)
        Me.Controls.Add(Me.gbx_Buscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_TabularCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Tabular de Cheques"
        Me.gbx_Buscar.ResumeLayout(False)
        Me.gbx_Buscar.PerformLayout()
        Me.gbx_Ubicaciones.ResumeLayout(False)
        Me.gbx_Ubicaciones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Banco As System.Windows.Forms.Label
    Friend WithEvents cmb_banco As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents tbx_ImporteLimite As Modulo_Proceso.cp_Textbox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Generar As System.Windows.Forms.Button
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents gbx_Ubicaciones As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_ImagenTrasera As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_ImagenFrontal As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_GenerarTabular As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Destino As System.Windows.Forms.Button
    Friend WithEvents btn_Origen As System.Windows.Forms.Button
    Friend WithEvents tbx_Destino As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents tbx_Origen As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
