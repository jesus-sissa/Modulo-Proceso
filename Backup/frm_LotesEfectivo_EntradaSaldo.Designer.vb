<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LotesEfectivo_EntradaSaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LotesEfectivo_EntradaSaldo))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_RecibirSaldo = New System.Windows.Forms.Button
        Me.gbx_Caja = New System.Windows.Forms.GroupBox
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Presentacion = New System.Windows.Forms.Label
        Me.cmb_Presentacion = New Modulo_Proceso.cp_cmb_Manual
        Me.lbl_CajaBancariaD = New System.Windows.Forms.Label
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_CajaBancariaD = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.gbx_Denominaciones = New System.Windows.Forms.GroupBox
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.tbx_Total = New System.Windows.Forms.TextBox
        Me.dgv_Denominaciones = New System.Windows.Forms.DataGridView
        Me.Id_Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_mostrar = New System.Windows.Forms.Button
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Caja.SuspendLayout()
        Me.gbx_Denominaciones.SuspendLayout()
        CType(Me.dgv_Denominaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_RecibirSaldo)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 503)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(776, 49)
        Me.gbx_Botones.TabIndex = 0
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_RecibirSaldo
        '
        Me.btn_RecibirSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_RecibirSaldo.Image = Global.Modulo_Proceso.My.Resources.Resources.bundle_24x24x32b
        Me.btn_RecibirSaldo.Location = New System.Drawing.Point(6, 13)
        Me.btn_RecibirSaldo.Name = "btn_RecibirSaldo"
        Me.btn_RecibirSaldo.Size = New System.Drawing.Size(140, 30)
        Me.btn_RecibirSaldo.TabIndex = 0
        Me.btn_RecibirSaldo.Text = "&RecibirSaldo"
        Me.btn_RecibirSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_RecibirSaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_RecibirSaldo.UseVisualStyleBackColor = True
        '
        'gbx_Caja
        '
        Me.gbx_Caja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Caja.Controls.Add(Me.btn_mostrar)
        Me.gbx_Caja.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Caja.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Caja.Controls.Add(Me.lbl_Presentacion)
        Me.gbx_Caja.Controls.Add(Me.cmb_Presentacion)
        Me.gbx_Caja.Controls.Add(Me.lbl_CajaBancariaD)
        Me.gbx_Caja.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Caja.Controls.Add(Me.cmb_CajaBancariaD)
        Me.gbx_Caja.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Caja.Location = New System.Drawing.Point(4, 8)
        Me.gbx_Caja.Name = "gbx_Caja"
        Me.gbx_Caja.Size = New System.Drawing.Size(776, 132)
        Me.gbx_Caja.TabIndex = 1
        Me.gbx_Caja.TabStop = False
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(75, 75)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 6
        Me.lbl_Moneda.Text = "Moneda"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Clave = Nothing
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.Filtro = Nothing
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(130, 72)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 7
        Me.cmb_Moneda.Tipo = 0
        Me.cmb_Moneda.ValueMember = "id_Moneda"
        '
        'lbl_Presentacion
        '
        Me.lbl_Presentacion.AutoSize = True
        Me.lbl_Presentacion.Location = New System.Drawing.Point(52, 102)
        Me.lbl_Presentacion.Name = "lbl_Presentacion"
        Me.lbl_Presentacion.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Presentacion.TabIndex = 8
        Me.lbl_Presentacion.Text = "Presentacion"
        '
        'cmb_Presentacion
        '
        Me.cmb_Presentacion.Control_Siguiente = Nothing
        Me.cmb_Presentacion.DisplayMember = "display"
        Me.cmb_Presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Presentacion.FormattingEnabled = True
        Me.cmb_Presentacion.Location = New System.Drawing.Point(130, 99)
        Me.cmb_Presentacion.MaxDropDownItems = 20
        Me.cmb_Presentacion.Name = "cmb_Presentacion"
        Me.cmb_Presentacion.Size = New System.Drawing.Size(183, 21)
        Me.cmb_Presentacion.TabIndex = 9
        Me.cmb_Presentacion.ValueMember = "value"
        '
        'lbl_CajaBancariaD
        '
        Me.lbl_CajaBancariaD.AutoSize = True
        Me.lbl_CajaBancariaD.Location = New System.Drawing.Point(9, 46)
        Me.lbl_CajaBancariaD.Name = "lbl_CajaBancariaD"
        Me.lbl_CajaBancariaD.Size = New System.Drawing.Size(112, 13)
        Me.lbl_CajaBancariaD.TabIndex = 3
        Me.lbl_CajaBancariaD.Text = "Caja Bancaria Destino"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(14, 19)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(107, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria Origen"
        '
        'cmb_CajaBancariaD
        '
        Me.cmb_CajaBancariaD.Clave = "Clave"
        Me.cmb_CajaBancariaD.Control_Siguiente = Nothing
        Me.cmb_CajaBancariaD.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancariaD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancariaD.Empresa = False
        Me.cmb_CajaBancariaD.Filtro = Nothing
        Me.cmb_CajaBancariaD.FormattingEnabled = True
        Me.cmb_CajaBancariaD.Location = New System.Drawing.Point(130, 43)
        Me.cmb_CajaBancariaD.MaxDropDownItems = 20
        Me.cmb_CajaBancariaD.Name = "cmb_CajaBancariaD"
        Me.cmb_CajaBancariaD.Pista = False
        Me.cmb_CajaBancariaD.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancariaD.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancariaD.Sucursal = True
        Me.cmb_CajaBancariaD.TabIndex = 5
        Me.cmb_CajaBancariaD.Tipo = 0
        Me.cmb_CajaBancariaD.ValueMember = "Id_CajaBancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(130, 16)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 2
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'gbx_Denominaciones
        '
        Me.gbx_Denominaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Denominaciones.Controls.Add(Me.lbl_Total)
        Me.gbx_Denominaciones.Controls.Add(Me.tbx_Total)
        Me.gbx_Denominaciones.Controls.Add(Me.dgv_Denominaciones)
        Me.gbx_Denominaciones.Location = New System.Drawing.Point(4, 146)
        Me.gbx_Denominaciones.Name = "gbx_Denominaciones"
        Me.gbx_Denominaciones.Size = New System.Drawing.Size(776, 351)
        Me.gbx_Denominaciones.TabIndex = 2
        Me.gbx_Denominaciones.TabStop = False
        Me.gbx_Denominaciones.Text = "Denominaciones"
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(613, 328)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Total.TabIndex = 1
        Me.lbl_Total.Text = "Total"
        '
        'tbx_Total
        '
        Me.tbx_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Total.Location = New System.Drawing.Point(650, 325)
        Me.tbx_Total.Name = "tbx_Total"
        Me.tbx_Total.Size = New System.Drawing.Size(117, 20)
        Me.tbx_Total.TabIndex = 2
        Me.tbx_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgv_Denominaciones
        '
        Me.dgv_Denominaciones.AllowUserToAddRows = False
        Me.dgv_Denominaciones.AllowUserToDeleteRows = False
        Me.dgv_Denominaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Denominaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Denominacion, Me.Moneda, Me.Presentacion, Me.Saldo, Me.Cantidad, Me.SaldoA, Me.Cantidad1, Me.SaldoB, Me.Cantidad2, Me.SaldoC, Me.Cantidad3, Me.SaldoD, Me.Cantidad4, Me.SaldoE, Me.Cantidad5, Me.Importe})
        Me.dgv_Denominaciones.Location = New System.Drawing.Point(6, 19)
        Me.dgv_Denominaciones.Name = "dgv_Denominaciones"
        Me.dgv_Denominaciones.RowHeadersVisible = False
        Me.dgv_Denominaciones.Size = New System.Drawing.Size(761, 300)
        Me.dgv_Denominaciones.TabIndex = 0
        '
        'Id_Denominacion
        '
        Me.Id_Denominacion.DataPropertyName = "Id_Denominacion"
        Me.Id_Denominacion.HeaderText = "Id_Denominacion"
        Me.Id_Denominacion.Name = "Id_Denominacion"
        Me.Id_Denominacion.ReadOnly = True
        Me.Id_Denominacion.Visible = False
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Moneda.DefaultCellStyle = DataGridViewCellStyle15
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        Me.Moneda.Width = 80
        '
        'Presentacion
        '
        Me.Presentacion.DataPropertyName = "Presentacion"
        Me.Presentacion.HeaderText = "Presentacion"
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle16
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Width = 70
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle17
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 70
        '
        'SaldoA
        '
        Me.SaldoA.DataPropertyName = "SaldoA"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SaldoA.DefaultCellStyle = DataGridViewCellStyle18
        Me.SaldoA.HeaderText = "SaldoA"
        Me.SaldoA.Name = "SaldoA"
        Me.SaldoA.ReadOnly = True
        Me.SaldoA.Width = 70
        '
        'Cantidad1
        '
        Me.Cantidad1.DataPropertyName = "Cantidad1"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad1.DefaultCellStyle = DataGridViewCellStyle19
        Me.Cantidad1.HeaderText = "Cantidad"
        Me.Cantidad1.Name = "Cantidad1"
        Me.Cantidad1.Width = 70
        '
        'SaldoB
        '
        Me.SaldoB.DataPropertyName = "SaldoB"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SaldoB.DefaultCellStyle = DataGridViewCellStyle20
        Me.SaldoB.HeaderText = "SaldoB"
        Me.SaldoB.Name = "SaldoB"
        Me.SaldoB.ReadOnly = True
        Me.SaldoB.Width = 70
        '
        'Cantidad2
        '
        Me.Cantidad2.DataPropertyName = "Cantidad2"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad2.DefaultCellStyle = DataGridViewCellStyle21
        Me.Cantidad2.HeaderText = "Cantidad"
        Me.Cantidad2.Name = "Cantidad2"
        Me.Cantidad2.Width = 70
        '
        'SaldoC
        '
        Me.SaldoC.DataPropertyName = "SaldoC"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SaldoC.DefaultCellStyle = DataGridViewCellStyle22
        Me.SaldoC.HeaderText = "SaldoC"
        Me.SaldoC.Name = "SaldoC"
        Me.SaldoC.ReadOnly = True
        Me.SaldoC.Width = 70
        '
        'Cantidad3
        '
        Me.Cantidad3.DataPropertyName = "Cantidad3"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad3.DefaultCellStyle = DataGridViewCellStyle23
        Me.Cantidad3.HeaderText = "Cantidad"
        Me.Cantidad3.Name = "Cantidad3"
        Me.Cantidad3.Width = 70
        '
        'SaldoD
        '
        Me.SaldoD.DataPropertyName = "SaldoD"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SaldoD.DefaultCellStyle = DataGridViewCellStyle24
        Me.SaldoD.HeaderText = "SaldoD"
        Me.SaldoD.Name = "SaldoD"
        Me.SaldoD.ReadOnly = True
        Me.SaldoD.Width = 70
        '
        'Cantidad4
        '
        Me.Cantidad4.DataPropertyName = "Cantidad4"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad4.DefaultCellStyle = DataGridViewCellStyle25
        Me.Cantidad4.HeaderText = "Cantidad"
        Me.Cantidad4.Name = "Cantidad4"
        Me.Cantidad4.Width = 70
        '
        'SaldoE
        '
        Me.SaldoE.DataPropertyName = "SaldoE"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SaldoE.DefaultCellStyle = DataGridViewCellStyle26
        Me.SaldoE.HeaderText = "SaldoE"
        Me.SaldoE.Name = "SaldoE"
        Me.SaldoE.ReadOnly = True
        Me.SaldoE.Width = 70
        '
        'Cantidad5
        '
        Me.Cantidad5.DataPropertyName = "Cantidad5"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad5.DefaultCellStyle = DataGridViewCellStyle27
        Me.Cantidad5.HeaderText = "Cantidad"
        Me.Cantidad5.Name = "Cantidad5"
        Me.Cantidad5.Width = 70
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "C2"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle28
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 120
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_mostrar.Location = New System.Drawing.Point(399, 75)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_mostrar.TabIndex = 15
        Me.btn_mostrar.Text = "&Mostrar"
        Me.btn_mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'frm_LotesEfectivo_EntradaSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Caja)
        Me.Controls.Add(Me.gbx_Denominaciones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_LotesEfectivo_EntradaSaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Saldo"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Caja.ResumeLayout(False)
        Me.gbx_Caja.PerformLayout()
        Me.gbx_Denominaciones.ResumeLayout(False)
        Me.gbx_Denominaciones.PerformLayout()
        CType(Me.dgv_Denominaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_RecibirSaldo As System.Windows.Forms.Button
    Friend WithEvents gbx_Caja As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Presentacion As System.Windows.Forms.Label
    Friend WithEvents cmb_Presentacion As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_CajaBancariaD As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancariaD As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Denominaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents tbx_Total As System.Windows.Forms.TextBox
    Friend WithEvents dgv_Denominaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Id_Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
End Class
