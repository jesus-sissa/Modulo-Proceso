<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PrepararResguardo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PrepararResguardo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.gb = New System.Windows.Forms.GroupBox
        Me.Dg_Resguardos = New System.Windows.Forms.DataGridView
        Me.Btn_Resguardo = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Id_Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Resguardar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResguardarA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResguardarB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResguardarC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResguardarD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResguardarE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tbx_Total = New Modulo_Proceso.cp_Textbox
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.gb1.SuspendLayout()
        Me.gb.SuspendLayout()
        CType(Me.Dg_Resguardos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Caja
        '
        Me.lbl_Caja.AutoSize = True
        Me.lbl_Caja.Location = New System.Drawing.Point(9, 16)
        Me.lbl_Caja.Name = "lbl_Caja"
        Me.lbl_Caja.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Caja.TabIndex = 27
        Me.lbl_Caja.Text = "Caja Bancaria"
        '
        'gb1
        '
        Me.gb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb1.Controls.Add(Me.tbx_Total)
        Me.gb1.Controls.Add(Me.lbl_Moneda)
        Me.gb1.Controls.Add(Me.cmb_Moneda)
        Me.gb1.Controls.Add(Me.lbl_Caja)
        Me.gb1.Controls.Add(Me.cmb_CajaBancaria)
        Me.gb1.Location = New System.Drawing.Point(3, 3)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(778, 77)
        Me.gb1.TabIndex = 32
        Me.gb1.TabStop = False
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(33, 43)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 47
        Me.lbl_Moneda.Text = "Moneda"
        '
        'gb
        '
        Me.gb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb.Controls.Add(Me.Dg_Resguardos)
        Me.gb.Location = New System.Drawing.Point(3, 86)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(778, 406)
        Me.gb.TabIndex = 33
        Me.gb.TabStop = False
        '
        'Dg_Resguardos
        '
        Me.Dg_Resguardos.AllowUserToAddRows = False
        Me.Dg_Resguardos.AllowUserToDeleteRows = False
        Me.Dg_Resguardos.AllowUserToResizeColumns = False
        Me.Dg_Resguardos.AllowUserToResizeRows = False
        Me.Dg_Resguardos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Dg_Resguardos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Resguardos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Denominacion, Me.Presentacion, Me.Denominacion, Me.Saldo, Me.Resguardar, Me.SaldoA, Me.ResguardarA, Me.SaldoB, Me.ResguardarB, Me.SaldoC, Me.ResguardarC, Me.SaldoD, Me.ResguardarD, Me.SaldoE, Me.ResguardarE, Me.Id_Moneda, Me.Importe})
        Me.Dg_Resguardos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Resguardos.Location = New System.Drawing.Point(3, 16)
        Me.Dg_Resguardos.MultiSelect = False
        Me.Dg_Resguardos.Name = "Dg_Resguardos"
        Me.Dg_Resguardos.Size = New System.Drawing.Size(772, 387)
        Me.Dg_Resguardos.TabIndex = 0
        '
        'Btn_Resguardo
        '
        Me.Btn_Resguardo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Resguardo.Image = CType(resources.GetObject("Btn_Resguardo.Image"), System.Drawing.Image)
        Me.Btn_Resguardo.Location = New System.Drawing.Point(4, 12)
        Me.Btn_Resguardo.Name = "Btn_Resguardo"
        Me.Btn_Resguardo.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Resguardo.TabIndex = 34
        Me.Btn_Resguardo.Text = "Resguardo"
        Me.Btn_Resguardo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Resguardo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Resguardo.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 35
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Resguardo)
        Me.Gbx_Botones.Location = New System.Drawing.Point(3, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.Gbx_Botones.TabIndex = 36
        Me.Gbx_Botones.TabStop = False
        '
        'Id_Denominacion
        '
        Me.Id_Denominacion.DataPropertyName = "Id_Denominacion"
        Me.Id_Denominacion.HeaderText = "Id_Denominacion"
        Me.Id_Denominacion.Name = "Id_Denominacion"
        Me.Id_Denominacion.Visible = False
        Me.Id_Denominacion.Width = 115
        '
        'Presentacion
        '
        Me.Presentacion.DataPropertyName = "Presentacion"
        Me.Presentacion.HeaderText = "Presentacion"
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.ReadOnly = True
        Me.Presentacion.Width = 94
        '
        'Denominacion
        '
        Me.Denominacion.DataPropertyName = "Denominacion"
        Me.Denominacion.HeaderText = "Denominacion"
        Me.Denominacion.Name = "Denominacion"
        Me.Denominacion.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 59
        '
        'Resguardar
        '
        Me.Resguardar.DataPropertyName = "Resguardar"
        Me.Resguardar.HeaderText = "Resguardar"
        Me.Resguardar.Name = "Resguardar"
        Me.Resguardar.Width = 87
        '
        'SaldoA
        '
        Me.SaldoA.DataPropertyName = "SaldoA"
        Me.SaldoA.HeaderText = "SaldoA"
        Me.SaldoA.Name = "SaldoA"
        Me.SaldoA.ReadOnly = True
        Me.SaldoA.Width = 66
        '
        'ResguardarA
        '
        Me.ResguardarA.DataPropertyName = "ResguardarA"
        Me.ResguardarA.HeaderText = "ResguardarA"
        Me.ResguardarA.Name = "ResguardarA"
        Me.ResguardarA.Width = 94
        '
        'SaldoB
        '
        Me.SaldoB.DataPropertyName = "SaldoB"
        Me.SaldoB.HeaderText = "SaldoB"
        Me.SaldoB.Name = "SaldoB"
        Me.SaldoB.ReadOnly = True
        Me.SaldoB.Width = 66
        '
        'ResguardarB
        '
        Me.ResguardarB.DataPropertyName = "ResguardarB"
        Me.ResguardarB.HeaderText = "ResguardarB"
        Me.ResguardarB.Name = "ResguardarB"
        Me.ResguardarB.Width = 94
        '
        'SaldoC
        '
        Me.SaldoC.DataPropertyName = "SaldoC"
        Me.SaldoC.HeaderText = "SaldoC"
        Me.SaldoC.Name = "SaldoC"
        Me.SaldoC.ReadOnly = True
        Me.SaldoC.Width = 66
        '
        'ResguardarC
        '
        Me.ResguardarC.DataPropertyName = "ResguardarC"
        Me.ResguardarC.HeaderText = "ResguardarC"
        Me.ResguardarC.Name = "ResguardarC"
        Me.ResguardarC.Width = 94
        '
        'SaldoD
        '
        Me.SaldoD.DataPropertyName = "SaldoD"
        Me.SaldoD.HeaderText = "SaldoD"
        Me.SaldoD.Name = "SaldoD"
        Me.SaldoD.ReadOnly = True
        Me.SaldoD.Width = 67
        '
        'ResguardarD
        '
        Me.ResguardarD.DataPropertyName = "ResguardarD"
        Me.ResguardarD.HeaderText = "ResguardarD"
        Me.ResguardarD.Name = "ResguardarD"
        Me.ResguardarD.Width = 95
        '
        'SaldoE
        '
        Me.SaldoE.DataPropertyName = "SaldoE"
        Me.SaldoE.HeaderText = "SaldoE"
        Me.SaldoE.Name = "SaldoE"
        Me.SaldoE.ReadOnly = True
        Me.SaldoE.Width = 66
        '
        'ResguardarE
        '
        Me.ResguardarE.DataPropertyName = "ResguardarE"
        Me.ResguardarE.HeaderText = "ResguardarE"
        Me.ResguardarE.Name = "ResguardarE"
        Me.ResguardarE.Width = 94
        '
        'Id_Moneda
        '
        Me.Id_Moneda.DataPropertyName = "Id_Moneda"
        Me.Id_Moneda.HeaderText = "Id_Moneda"
        Me.Id_Moneda.Name = "Id_Moneda"
        Me.Id_Moneda.Visible = False
        Me.Id_Moneda.Width = 86
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle1
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 67
        '
        'tbx_Total
        '
        Me.tbx_Total.Control_Siguiente = Nothing
        Me.tbx_Total.Filtrado = True
        Me.tbx_Total.Location = New System.Drawing.Point(583, 43)
        Me.tbx_Total.MaxLength = 10
        Me.tbx_Total.Name = "tbx_Total"
        Me.tbx_Total.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Total.TabIndex = 48
        Me.tbx_Total.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        Me.tbx_Total.Visible = False
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(85, 40)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 46
        Me.cmb_Moneda.ValueMember = "id_Moneda"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(85, 13)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 28
        Me.cmb_CajaBancaria.ValueMember = "id_CajaBancaria"
        '
        'frm_PrepararResguardo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.gb1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_PrepararResguardo"
        Me.Text = "Preparar resguardos"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.gb.ResumeLayout(False)
        CType(Me.Dg_Resguardos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents Dg_Resguardos As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Resguardo As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tbx_Total As Modulo_Proceso.cp_Textbox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Id_Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Resguardar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResguardarA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResguardarB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResguardarC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResguardarD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResguardarE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
