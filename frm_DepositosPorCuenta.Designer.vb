<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DepositosPorCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DepositosPorCuenta))
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cbx_TProceso = New System.Windows.Forms.CheckBox
        Me.lbl_Grupo = New System.Windows.Forms.Label
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.cbx_SubClientes = New System.Windows.Forms.CheckBox
        Me.lbl_Cuenta = New System.Windows.Forms.Label
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.lbl_Aplica = New System.Windows.Forms.Label
        Me.chk_Corte = New System.Windows.Forms.CheckBox
        Me.tbx_Corte = New Modulo_Proceso.cp_Textbox
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_Corte = New System.Windows.Forms.Label
        Me.cmb_Cia = New Modulo_Proceso.cp_cmb_Simple
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.lbl_CompaniaTV = New System.Windows.Forms.Label
        Me.chk_Cia = New System.Windows.Forms.CheckBox
        Me.cmb_Tipo = New Modulo_Proceso.cp_cmb_Manual
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Grupo = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_Cuenta = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Cliente = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Parametro
        Me.Lbl_SesionH = New System.Windows.Forms.Label
        Me.Lbl_SesionD = New System.Windows.Forms.Label
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Parametro
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ImprimirAgrupado = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Procesos = New System.Windows.Forms.Button
        Me.gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(21, 50)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 2
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cbx_TProceso
        '
        Me.cbx_TProceso.AutoSize = True
        Me.cbx_TProceso.Enabled = False
        Me.cbx_TProceso.Location = New System.Drawing.Point(381, 75)
        Me.cbx_TProceso.Name = "cbx_TProceso"
        Me.cbx_TProceso.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TProceso.TabIndex = 7
        Me.cbx_TProceso.Text = "Todos"
        Me.cbx_TProceso.UseVisualStyleBackColor = True
        '
        'lbl_Grupo
        '
        Me.lbl_Grupo.AutoSize = True
        Me.lbl_Grupo.Location = New System.Drawing.Point(16, 76)
        Me.lbl_Grupo.Name = "lbl_Grupo"
        Me.lbl_Grupo.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Grupo.TabIndex = 5
        Me.lbl_Grupo.Text = "Grupo Proceso"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(48, 129)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 12
        Me.lbl_Moneda.Text = "Moneda"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(57, 160)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 14
        Me.lbl_Desde.Text = "Desde"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Enabled = False
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(103, 156)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 15
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(59, 186)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 18
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Enabled = False
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(103, 182)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 19
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(12, 22)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(84, 13)
        Me.lbl_Tipo.TabIndex = 0
        Me.lbl_Tipo.Text = "Tipo de Reporte"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(55, 213)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 22
        Me.lbl_Cliente.Text = "Cliente"
        '
        'cbx_SubClientes
        '
        Me.cbx_SubClientes.AutoSize = True
        Me.cbx_SubClientes.Enabled = False
        Me.cbx_SubClientes.Location = New System.Drawing.Point(438, 214)
        Me.cbx_SubClientes.Name = "cbx_SubClientes"
        Me.cbx_SubClientes.Size = New System.Drawing.Size(113, 17)
        Me.cbx_SubClientes.TabIndex = 24
        Me.cbx_SubClientes.Text = "Incluir SubClientes"
        Me.cbx_SubClientes.UseVisualStyleBackColor = True
        '
        'lbl_Cuenta
        '
        Me.lbl_Cuenta.AutoSize = True
        Me.lbl_Cuenta.Location = New System.Drawing.Point(53, 240)
        Me.lbl_Cuenta.Name = "lbl_Cuenta"
        Me.lbl_Cuenta.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Cuenta.TabIndex = 25
        Me.lbl_Cuenta.Text = "Cuenta"
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Aplica)
        Me.gbx_Filtro.Controls.Add(Me.chk_Corte)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Corte)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Corte)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cia)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CompaniaTV)
        Me.gbx_Filtro.Controls.Add(Me.chk_Cia)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Tipo)
        Me.gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cuenta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cuenta)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.cbx_SubClientes)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.cbx_TProceso)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Tipo)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_SesionH)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_SesionD)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Desde)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtro.Location = New System.Drawing.Point(6, 3)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(682, 297)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'lbl_Aplica
        '
        Me.lbl_Aplica.AutoSize = True
        Me.lbl_Aplica.Location = New System.Drawing.Point(221, 103)
        Me.lbl_Aplica.Name = "lbl_Aplica"
        Me.lbl_Aplica.Size = New System.Drawing.Size(182, 13)
        Me.lbl_Aplica.TabIndex = 11
        Me.lbl_Aplica.Text = "* Sólo aplica al reporte de Agrupados"
        '
        'chk_Corte
        '
        Me.chk_Corte.AutoSize = True
        Me.chk_Corte.Enabled = False
        Me.chk_Corte.Location = New System.Drawing.Point(159, 102)
        Me.chk_Corte.Name = "chk_Corte"
        Me.chk_Corte.Size = New System.Drawing.Size(56, 17)
        Me.chk_Corte.TabIndex = 10
        Me.chk_Corte.Text = "Todos"
        Me.chk_Corte.UseVisualStyleBackColor = True
        '
        'tbx_Corte
        '
        Me.tbx_Corte.Control_Siguiente = Me.cmb_Moneda
        Me.tbx_Corte.Enabled = False
        Me.tbx_Corte.Filtrado = True
        Me.tbx_Corte.Location = New System.Drawing.Point(103, 100)
        Me.tbx_Corte.MaxLength = 2
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Corte.TabIndex = 9
        Me.tbx_Corte.Text = "0"
        Me.tbx_Corte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Corte.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Me.dtp_Desde
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.Enabled = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(103, 126)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(272, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 13
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(65, 103)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Corte.TabIndex = 8
        Me.lbl_Corte.Text = "Corte"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Control_Siguiente = Me.btn_Imprimir
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(103, 264)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(272, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 28
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Enabled = False
        Me.btn_Imprimir.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Imprimir.Location = New System.Drawing.Point(9, 13)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 0
        Me.btn_Imprimir.Text = "&Dep. X Cuenta"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'lbl_CompaniaTV
        '
        Me.lbl_CompaniaTV.AutoSize = True
        Me.lbl_CompaniaTV.Location = New System.Drawing.Point(6, 267)
        Me.lbl_CompaniaTV.Name = "lbl_CompaniaTV"
        Me.lbl_CompaniaTV.Size = New System.Drawing.Size(88, 13)
        Me.lbl_CompaniaTV.TabIndex = 27
        Me.lbl_CompaniaTV.Text = "Compañía de TV"
        '
        'chk_Cia
        '
        Me.chk_Cia.AutoSize = True
        Me.chk_Cia.Location = New System.Drawing.Point(381, 266)
        Me.chk_Cia.Name = "chk_Cia"
        Me.chk_Cia.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cia.TabIndex = 29
        Me.chk_Cia.Text = "Todas"
        Me.chk_Cia.UseVisualStyleBackColor = True
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Me.cmb_CajaBancaria
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(102, 19)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(335, 21)
        Me.cmb_Tipo.TabIndex = 1
        Me.cmb_Tipo.ValueMember = "value"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Me.cmb_Grupo
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Enabled = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(103, 48)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 4
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Grupo
        '
        Me.cmb_Grupo.Cia = False
        Me.cmb_Grupo.Control_Siguiente = Me.tbx_Corte
        Me.cmb_Grupo.DisplayMember = "Descripcion"
        Me.cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Grupo.Empresa = False
        Me.cmb_Grupo.Enabled = False
        Me.cmb_Grupo.FormattingEnabled = True
        Me.cmb_Grupo.Location = New System.Drawing.Point(103, 73)
        Me.cmb_Grupo.MaxDropDownItems = 20
        Me.cmb_Grupo.Name = "cmb_Grupo"
        Me.cmb_Grupo.NombreParametro = "@Id_CajaBancaria"
        Me.cmb_Grupo.Pista = True
        Me.cmb_Grupo.Size = New System.Drawing.Size(272, 21)
        Me.cmb_Grupo.StoredProcedure = "Cat_GrupoDeposito_Get"
        Me.cmb_Grupo.Sucursal = False
        Me.cmb_Grupo.TabIndex = 6
        Me.cmb_Grupo.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_Grupo.ValorParametro = Nothing
        Me.cmb_Grupo.ValueMember = "Id_GrupoDepo"
        '
        'cmb_Cuenta
        '
        Me.cmb_Cuenta.Control_Siguiente = Me.cmb_Cia
        Me.cmb_Cuenta.DisplayMember = "Numero_Cuenta"
        Me.cmb_Cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cuenta.Empresa = False
        Me.cmb_Cuenta.Enabled = False
        Me.cmb_Cuenta.FormattingEnabled = True
        Me.cmb_Cuenta.Location = New System.Drawing.Point(103, 237)
        Me.cmb_Cuenta.MaxDropDownItems = 20
        Me.cmb_Cuenta.Name = "cmb_Cuenta"
        Me.cmb_Cuenta.Pista = False
        Me.cmb_Cuenta.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Cuenta.StoredProcedure = Nothing
        Me.cmb_Cuenta.Sucursal = False
        Me.cmb_Cuenta.TabIndex = 26
        Me.cmb_Cuenta.ValueMember = "Id_Cuenta"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Control_Siguiente = Me.cmb_Cuenta
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Enabled = False
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(102, 210)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(330, 21)
        Me.cmb_Cliente.StoredProcedure = "cat_Clientes_GetPadres"
        Me.cmb_Cliente.Sucursal = False
        Me.cmb_Cliente.TabIndex = 23
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Cia = False
        Me.cmb_Hasta.Control_Siguiente = Nothing
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.Enabled = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(243, 183)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.NombreParametro = "@Fecha"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 21
        Me.cmb_Hasta.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Hasta.ValorParametro = Nothing
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'Lbl_SesionH
        '
        Me.Lbl_SesionH.AutoSize = True
        Me.Lbl_SesionH.Location = New System.Drawing.Point(198, 186)
        Me.Lbl_SesionH.Name = "Lbl_SesionH"
        Me.Lbl_SesionH.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SesionH.TabIndex = 20
        Me.Lbl_SesionH.Text = "Sesión"
        '
        'Lbl_SesionD
        '
        Me.Lbl_SesionD.AutoSize = True
        Me.Lbl_SesionD.Location = New System.Drawing.Point(198, 160)
        Me.Lbl_SesionD.Name = "Lbl_SesionD"
        Me.Lbl_SesionD.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SesionD.TabIndex = 16
        Me.Lbl_SesionD.Text = "Sesión"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Cia = False
        Me.cmb_Desde.Control_Siguiente = Nothing
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.Enabled = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(243, 157)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.NombreParametro = "@Fecha"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 17
        Me.cmb_Desde.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Desde.ValorParametro = Nothing
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_ImprimirAgrupado)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Procesos)
        Me.Gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 306)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(682, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'btn_ImprimirAgrupado
        '
        Me.btn_ImprimirAgrupado.Enabled = False
        Me.btn_ImprimirAgrupado.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_ImprimirAgrupado.Location = New System.Drawing.Point(155, 13)
        Me.btn_ImprimirAgrupado.Name = "btn_ImprimirAgrupado"
        Me.btn_ImprimirAgrupado.Size = New System.Drawing.Size(170, 30)
        Me.btn_ImprimirAgrupado.TabIndex = 1
        Me.btn_ImprimirAgrupado.Text = "&Dep. X Cta. Agrupado"
        Me.btn_ImprimirAgrupado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprimirAgrupado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImprimirAgrupado.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(536, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Procesos
        '
        Me.btn_Procesos.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Procesos.Location = New System.Drawing.Point(331, 13)
        Me.btn_Procesos.Name = "btn_Procesos"
        Me.btn_Procesos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Procesos.TabIndex = 2
        Me.btn_Procesos.Text = "&Rep. Procesos"
        Me.btn_Procesos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Procesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Procesos.UseVisualStyleBackColor = True
        '
        'frm_DepositosPorCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 361)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 390)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 390)
        Me.Name = "frm_DepositosPorCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Depósitos Por Cuenta"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cbx_TProceso As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Grupo As System.Windows.Forms.Label
    Friend WithEvents cmb_Grupo As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents cmb_Cliente As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cbx_SubClientes As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Cuenta As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Cuenta As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Cia As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_CompaniaTV As System.Windows.Forms.Label
    Friend WithEvents chk_Cia As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_SesionH As System.Windows.Forms.Label
    Friend WithEvents Lbl_SesionD As System.Windows.Forms.Label
    Friend WithEvents btn_Procesos As System.Windows.Forms.Button
    Friend WithEvents btn_ImprimirAgrupado As System.Windows.Forms.Button
    Friend WithEvents chk_Corte As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Corte As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents lbl_Aplica As System.Windows.Forms.Label
End Class
