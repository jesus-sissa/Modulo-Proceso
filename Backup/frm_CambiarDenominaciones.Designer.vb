<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CambiarDenominaciones
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbx_Origen = New System.Windows.Forms.GroupBox
        Me.tbx_ImporteActualO = New Modulo_Proceso.cp_Textbox
        Me.lbl_ImporteActualO = New System.Windows.Forms.Label
        Me.tbx_ImporteO = New Modulo_Proceso.cp_Textbox
        Me.lbl_Importe = New System.Windows.Forms.Label
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_CajaBancariaO = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.dgv_CajaBancariaO = New System.Windows.Forms.DataGridView
        Me.Id_Denominacion1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Presentacion1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Denominacion1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cambio1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_Destino = New System.Windows.Forms.GroupBox
        Me.tbx_ImporteActualD = New Modulo_Proceso.cp_Textbox
        Me.lbl_ImporteActualD = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbx_ImporteD = New Modulo_Proceso.cp_Textbox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_CajaBancariaD = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.dgv_CajaBancariaD = New System.Windows.Forms.DataGridView
        Me.Id_Denominacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Presentacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Denominacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cambio2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Origen.SuspendLayout()
        CType(Me.dgv_CajaBancariaO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Destino.SuspendLayout()
        CType(Me.dgv_CajaBancariaD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Origen
        '
        Me.gbx_Origen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Origen.Controls.Add(Me.tbx_ImporteActualO)
        Me.gbx_Origen.Controls.Add(Me.lbl_ImporteActualO)
        Me.gbx_Origen.Controls.Add(Me.tbx_ImporteO)
        Me.gbx_Origen.Controls.Add(Me.lbl_Importe)
        Me.gbx_Origen.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Origen.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Origen.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Origen.Controls.Add(Me.cmb_CajaBancariaO)
        Me.gbx_Origen.Controls.Add(Me.dgv_CajaBancariaO)
        Me.gbx_Origen.Location = New System.Drawing.Point(7, 7)
        Me.gbx_Origen.Name = "gbx_Origen"
        Me.gbx_Origen.Size = New System.Drawing.Size(450, 542)
        Me.gbx_Origen.TabIndex = 0
        Me.gbx_Origen.TabStop = False
        Me.gbx_Origen.Text = "Origen"
        '
        'tbx_ImporteActualO
        '
        Me.tbx_ImporteActualO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_ImporteActualO.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ImporteActualO.Control_Siguiente = Nothing
        Me.tbx_ImporteActualO.Filtrado = False
        Me.tbx_ImporteActualO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ImporteActualO.Location = New System.Drawing.Point(48, 514)
        Me.tbx_ImporteActualO.MaxLength = 10
        Me.tbx_ImporteActualO.Multiline = True
        Me.tbx_ImporteActualO.Name = "tbx_ImporteActualO"
        Me.tbx_ImporteActualO.ReadOnly = True
        Me.tbx_ImporteActualO.Size = New System.Drawing.Size(133, 23)
        Me.tbx_ImporteActualO.TabIndex = 6
        Me.tbx_ImporteActualO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImporteActualO.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'lbl_ImporteActualO
        '
        Me.lbl_ImporteActualO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ImporteActualO.AutoSize = True
        Me.lbl_ImporteActualO.Location = New System.Drawing.Point(8, 519)
        Me.lbl_ImporteActualO.Name = "lbl_ImporteActualO"
        Me.lbl_ImporteActualO.Size = New System.Drawing.Size(34, 13)
        Me.lbl_ImporteActualO.TabIndex = 5
        Me.lbl_ImporteActualO.Text = "Saldo"
        '
        'tbx_ImporteO
        '
        Me.tbx_ImporteO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_ImporteO.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ImporteO.Control_Siguiente = Nothing
        Me.tbx_ImporteO.Filtrado = False
        Me.tbx_ImporteO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ImporteO.Location = New System.Drawing.Point(311, 513)
        Me.tbx_ImporteO.MaxLength = 10
        Me.tbx_ImporteO.Multiline = True
        Me.tbx_ImporteO.Name = "tbx_ImporteO"
        Me.tbx_ImporteO.ReadOnly = True
        Me.tbx_ImporteO.Size = New System.Drawing.Size(133, 23)
        Me.tbx_ImporteO.TabIndex = 8
        Me.tbx_ImporteO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImporteO.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'lbl_Importe
        '
        Me.lbl_Importe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Importe.AutoSize = True
        Me.lbl_Importe.Location = New System.Drawing.Point(264, 518)
        Me.lbl_Importe.Name = "lbl_Importe"
        Me.lbl_Importe.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Importe.TabIndex = 7
        Me.lbl_Importe.Text = "Importe"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(34, 51)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 2
        Me.lbl_Moneda.Text = "Moneda"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(86, 48)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(251, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 3
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(7, 23)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cmb_CajaBancariaO
        '
        Me.cmb_CajaBancariaO.Clave = "Clave"
        Me.cmb_CajaBancariaO.Control_Siguiente = Me.cmb_Moneda
        Me.cmb_CajaBancariaO.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancariaO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancariaO.Empresa = False
        Me.cmb_CajaBancariaO.Filtro = Nothing
        Me.cmb_CajaBancariaO.FormattingEnabled = True
        Me.cmb_CajaBancariaO.Location = New System.Drawing.Point(86, 21)
        Me.cmb_CajaBancariaO.MaxDropDownItems = 20
        Me.cmb_CajaBancariaO.Name = "cmb_CajaBancariaO"
        Me.cmb_CajaBancariaO.Pista = False
        Me.cmb_CajaBancariaO.Size = New System.Drawing.Size(358, 21)
        Me.cmb_CajaBancariaO.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancariaO.Sucursal = True
        Me.cmb_CajaBancariaO.TabIndex = 1
        Me.cmb_CajaBancariaO.Tipo = 0
        Me.cmb_CajaBancariaO.ValueMember = "Id_CajaBancaria"
        '
        'dgv_CajaBancariaO
        '
        Me.dgv_CajaBancariaO.AllowUserToAddRows = False
        Me.dgv_CajaBancariaO.AllowUserToDeleteRows = False
        Me.dgv_CajaBancariaO.AllowUserToResizeColumns = False
        Me.dgv_CajaBancariaO.AllowUserToResizeRows = False
        Me.dgv_CajaBancariaO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_CajaBancariaO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_CajaBancariaO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CajaBancariaO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Denominacion1, Me.Presentacion1, Me.Denominacion1, Me.Cantidad1, Me.Cambio1})
        Me.dgv_CajaBancariaO.Location = New System.Drawing.Point(6, 75)
        Me.dgv_CajaBancariaO.Name = "dgv_CajaBancariaO"
        Me.dgv_CajaBancariaO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_CajaBancariaO.Size = New System.Drawing.Size(439, 432)
        Me.dgv_CajaBancariaO.TabIndex = 4
        '
        'Id_Denominacion1
        '
        Me.Id_Denominacion1.DataPropertyName = "Id_Denominacion"
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Id_Denominacion1.DefaultCellStyle = DataGridViewCellStyle8
        Me.Id_Denominacion1.HeaderText = "Id_Denominacion"
        Me.Id_Denominacion1.Name = "Id_Denominacion1"
        Me.Id_Denominacion1.ReadOnly = True
        Me.Id_Denominacion1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Id_Denominacion1.Visible = False
        Me.Id_Denominacion1.Width = 115
        '
        'Presentacion1
        '
        Me.Presentacion1.DataPropertyName = "Presentacion"
        Me.Presentacion1.HeaderText = "Presentacion"
        Me.Presentacion1.Name = "Presentacion1"
        Me.Presentacion1.ReadOnly = True
        Me.Presentacion1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Presentacion1.Width = 94
        '
        'Denominacion1
        '
        Me.Denominacion1.DataPropertyName = "Denominacion"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Denominacion1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Denominacion1.HeaderText = "Denominacion"
        Me.Denominacion1.Name = "Denominacion1"
        Me.Denominacion1.ReadOnly = True
        Me.Denominacion1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Cantidad1
        '
        Me.Cantidad1.DataPropertyName = "Cantidad"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad1.DefaultCellStyle = DataGridViewCellStyle10
        Me.Cantidad1.HeaderText = "Cantidad"
        Me.Cantidad1.Name = "Cantidad1"
        Me.Cantidad1.ReadOnly = True
        Me.Cantidad1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cantidad1.Width = 74
        '
        'Cambio1
        '
        Me.Cambio1.DataPropertyName = "Cambio"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Cambio1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Cambio1.HeaderText = "Cambio"
        Me.Cambio1.Name = "Cambio1"
        Me.Cambio1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cambio1.Width = 67
        '
        'gbx_Destino
        '
        Me.gbx_Destino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Destino.Controls.Add(Me.tbx_ImporteActualD)
        Me.gbx_Destino.Controls.Add(Me.lbl_ImporteActualD)
        Me.gbx_Destino.Controls.Add(Me.Label1)
        Me.gbx_Destino.Controls.Add(Me.tbx_ImporteD)
        Me.gbx_Destino.Controls.Add(Me.Label2)
        Me.gbx_Destino.Controls.Add(Me.cmb_CajaBancariaD)
        Me.gbx_Destino.Controls.Add(Me.dgv_CajaBancariaD)
        Me.gbx_Destino.Location = New System.Drawing.Point(464, 7)
        Me.gbx_Destino.Name = "gbx_Destino"
        Me.gbx_Destino.Size = New System.Drawing.Size(450, 542)
        Me.gbx_Destino.TabIndex = 1
        Me.gbx_Destino.TabStop = False
        Me.gbx_Destino.Text = "Destino"
        '
        'tbx_ImporteActualD
        '
        Me.tbx_ImporteActualD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_ImporteActualD.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_ImporteActualD.Control_Siguiente = Nothing
        Me.tbx_ImporteActualD.Filtrado = False
        Me.tbx_ImporteActualD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ImporteActualD.Location = New System.Drawing.Point(47, 514)
        Me.tbx_ImporteActualD.MaxLength = 10
        Me.tbx_ImporteActualD.Multiline = True
        Me.tbx_ImporteActualD.Name = "tbx_ImporteActualD"
        Me.tbx_ImporteActualD.ReadOnly = True
        Me.tbx_ImporteActualD.Size = New System.Drawing.Size(133, 23)
        Me.tbx_ImporteActualD.TabIndex = 4
        Me.tbx_ImporteActualD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImporteActualD.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'lbl_ImporteActualD
        '
        Me.lbl_ImporteActualD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ImporteActualD.AutoSize = True
        Me.lbl_ImporteActualD.Location = New System.Drawing.Point(7, 520)
        Me.lbl_ImporteActualD.Name = "lbl_ImporteActualD"
        Me.lbl_ImporteActualD.Size = New System.Drawing.Size(34, 13)
        Me.lbl_ImporteActualD.TabIndex = 3
        Me.lbl_ImporteActualD.Text = "Saldo"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 517)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Importe"
        '
        'tbx_ImporteD
        '
        Me.tbx_ImporteD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_ImporteD.BackColor = System.Drawing.Color.White
        Me.tbx_ImporteD.Control_Siguiente = Nothing
        Me.tbx_ImporteD.Filtrado = True
        Me.tbx_ImporteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ImporteD.Location = New System.Drawing.Point(311, 511)
        Me.tbx_ImporteD.MaxLength = 10
        Me.tbx_ImporteD.Name = "tbx_ImporteD"
        Me.tbx_ImporteD.ReadOnly = True
        Me.tbx_ImporteD.Size = New System.Drawing.Size(133, 23)
        Me.tbx_ImporteD.TabIndex = 6
        Me.tbx_ImporteD.TabStop = False
        Me.tbx_ImporteD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImporteD.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Caja Bancaria"
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
        Me.cmb_CajaBancariaD.Location = New System.Drawing.Point(86, 21)
        Me.cmb_CajaBancariaD.MaxDropDownItems = 20
        Me.cmb_CajaBancariaD.Name = "cmb_CajaBancariaD"
        Me.cmb_CajaBancariaD.Pista = False
        Me.cmb_CajaBancariaD.Size = New System.Drawing.Size(358, 21)
        Me.cmb_CajaBancariaD.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancariaD.Sucursal = True
        Me.cmb_CajaBancariaD.TabIndex = 1
        Me.cmb_CajaBancariaD.Tipo = 0
        Me.cmb_CajaBancariaD.ValueMember = "Id_CajaBancaria"
        '
        'dgv_CajaBancariaD
        '
        Me.dgv_CajaBancariaD.AllowUserToAddRows = False
        Me.dgv_CajaBancariaD.AllowUserToDeleteRows = False
        Me.dgv_CajaBancariaD.AllowUserToResizeColumns = False
        Me.dgv_CajaBancariaD.AllowUserToResizeRows = False
        Me.dgv_CajaBancariaD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_CajaBancariaD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_CajaBancariaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CajaBancariaD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Denominacion2, Me.Presentacion2, Me.Denominacion2, Me.Cantidad2, Me.Cambio2})
        Me.dgv_CajaBancariaD.Location = New System.Drawing.Point(6, 75)
        Me.dgv_CajaBancariaD.Name = "dgv_CajaBancariaD"
        Me.dgv_CajaBancariaD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_CajaBancariaD.Size = New System.Drawing.Size(438, 432)
        Me.dgv_CajaBancariaD.TabIndex = 2
        '
        'Id_Denominacion2
        '
        Me.Id_Denominacion2.DataPropertyName = "Id_Denominacion"
        Me.Id_Denominacion2.HeaderText = "Id_Denominacion"
        Me.Id_Denominacion2.Name = "Id_Denominacion2"
        Me.Id_Denominacion2.ReadOnly = True
        Me.Id_Denominacion2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Id_Denominacion2.Visible = False
        Me.Id_Denominacion2.Width = 115
        '
        'Presentacion2
        '
        Me.Presentacion2.DataPropertyName = "Presentacion"
        Me.Presentacion2.HeaderText = "Presentacion"
        Me.Presentacion2.Name = "Presentacion2"
        Me.Presentacion2.ReadOnly = True
        Me.Presentacion2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Presentacion2.Width = 94
        '
        'Denominacion2
        '
        Me.Denominacion2.DataPropertyName = "Denominacion"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Denominacion2.DefaultCellStyle = DataGridViewCellStyle12
        Me.Denominacion2.HeaderText = "Denominacion"
        Me.Denominacion2.Name = "Denominacion2"
        Me.Denominacion2.ReadOnly = True
        Me.Denominacion2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Cantidad2
        '
        Me.Cantidad2.DataPropertyName = "Cantidad"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad2.DefaultCellStyle = DataGridViewCellStyle13
        Me.Cantidad2.HeaderText = "Cantidad"
        Me.Cantidad2.Name = "Cantidad2"
        Me.Cantidad2.ReadOnly = True
        Me.Cantidad2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cantidad2.Width = 74
        '
        'Cambio2
        '
        Me.Cambio2.DataPropertyName = "Cambio"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N0"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Cambio2.DefaultCellStyle = DataGridViewCellStyle14
        Me.Cambio2.HeaderText = "Cambio"
        Me.Cambio2.Name = "Cambio2"
        Me.Cambio2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cambio2.Width = 67
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_botones.Location = New System.Drawing.Point(7, 552)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(907, 50)
        Me.gbx_botones.TabIndex = 2
        Me.gbx_botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(761, 14)
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
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Generar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'frm_CambiarDenominaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 609)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_Destino)
        Me.Controls.Add(Me.gbx_Origen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CambiarDenominaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Denominaciones"
        Me.gbx_Origen.ResumeLayout(False)
        Me.gbx_Origen.PerformLayout()
        CType(Me.dgv_CajaBancariaO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Destino.ResumeLayout(False)
        Me.gbx_Destino.PerformLayout()
        CType(Me.dgv_CajaBancariaD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Origen As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_CajaBancariaO As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancariaO As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents gbx_Destino As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancariaD As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents dgv_CajaBancariaD As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_ImporteD As Modulo_Proceso.cp_Textbox
    Friend WithEvents tbx_ImporteO As Modulo_Proceso.cp_Textbox
    Friend WithEvents Id_Denominacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Presentacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cambio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Denominacion1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Presentacion1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominacion1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cambio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbx_ImporteActualO As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_ImporteActualO As System.Windows.Forms.Label
    Friend WithEvents tbx_ImporteActualD As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_ImporteActualD As System.Windows.Forms.Label
End Class
