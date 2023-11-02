<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReimprimirCorte
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
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Extraer = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.gbx_Fichas = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Proceso.cp_Listview
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_cia = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Grupo = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_Corte = New Modulo_Proceso.cp_cmb_SimpleParametros
        Me.tbx_ClaveCajero = New Modulo_Proceso.cp_Textbox
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_Cia = New System.Windows.Forms.Label
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.cbx_TGrupos = New System.Windows.Forms.CheckBox
        Me.cbx_TTraslado = New System.Windows.Forms.CheckBox
        Me.cbx_TCajero = New System.Windows.Forms.CheckBox
        Me.cbx_Todos = New System.Windows.Forms.CheckBox
        Me.lbl_Corte = New System.Windows.Forms.Label
        Me.lbl_Grupo = New System.Windows.Forms.Label
        Me.Cp_cmb_Parametro1 = New Modulo_Proceso.cp_cmb_Parametro
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Fichas.SuspendLayout()
        Me.gbx_Parametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Imprimir.Enabled = False
        Me.btn_Imprimir.Image = Global.Modulo_Proceso.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(9, 11)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 0
        Me.btn_Imprimir.Text = "&Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Extraer)
        Me.gbx_Controles.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Controles.Controls.Add(Me.btn_Imprimir)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(3, 499)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Extraer
        '
        Me.btn_Extraer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Extraer.Enabled = False
        Me.btn_Extraer.Image = Global.Modulo_Proceso.My.Resources.Resources.Actualizar
        Me.btn_Extraer.Location = New System.Drawing.Point(301, 11)
        Me.btn_Extraer.Name = "btn_Extraer"
        Me.btn_Extraer.Size = New System.Drawing.Size(140, 30)
        Me.btn_Extraer.TabIndex = 2
        Me.btn_Extraer.Text = "Extraer Archivos"
        Me.btn_Extraer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Extraer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Extraer.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_Proceso.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(155, 11)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 1
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'gbx_Fichas
        '
        Me.gbx_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Fichas.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Fichas.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_Fichas.Location = New System.Drawing.Point(3, 204)
        Me.gbx_Fichas.Name = "gbx_Fichas"
        Me.gbx_Fichas.Size = New System.Drawing.Size(778, 289)
        Me.gbx_Fichas.TabIndex = 1
        Me.gbx_Fichas.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(580, 15)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(192, 15)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 33)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 15
        Me.lsv_Catalogo.Row2 = 7
        Me.lsv_Catalogo.Row3 = 7
        Me.lsv_Catalogo.Row4 = 8
        Me.lsv_Catalogo.Row5 = 8
        Me.lsv_Catalogo.Row6 = 8
        Me.lsv_Catalogo.Row7 = 10
        Me.lsv_Catalogo.Row8 = 8
        Me.lsv_Catalogo.Row9 = 25
        Me.lsv_Catalogo.Size = New System.Drawing.Size(772, 253)
        Me.lsv_Catalogo.TabIndex = 1
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.cmb_cia)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Cia)
        Me.gbx_Parametros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Parametros.Controls.Add(Me.tbx_ClaveCajero)
        Me.gbx_Parametros.Controls.Add(Me.cbx_TGrupos)
        Me.gbx_Parametros.Controls.Add(Me.cbx_TTraslado)
        Me.gbx_Parametros.Controls.Add(Me.cbx_TCajero)
        Me.gbx_Parametros.Controls.Add(Me.cbx_Todos)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Grupo)
        Me.gbx_Parametros.Controls.Add(Me.Cp_cmb_Parametro1)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Grupo)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Parametros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Parametros.Location = New System.Drawing.Point(3, 12)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(778, 186)
        Me.gbx_Parametros.TabIndex = 0
        Me.gbx_Parametros.TabStop = False
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(274, 20)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(136, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 3
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Me.cmb_Moneda
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(91, 47)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 6
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Me.cmb_cia
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(91, 73)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(283, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 8
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'cmb_cia
        '
        Me.cmb_cia.Control_Siguiente = Me.cmb_Grupo
        Me.cmb_cia.DisplayMember = "Nombre"
        Me.cmb_cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cia.Empresa = False
        Me.cmb_cia.FormattingEnabled = True
        Me.cmb_cia.Location = New System.Drawing.Point(91, 100)
        Me.cmb_cia.MaxDropDownItems = 20
        Me.cmb_cia.Name = "cmb_cia"
        Me.cmb_cia.Pista = True
        Me.cmb_cia.Size = New System.Drawing.Size(387, 21)
        Me.cmb_cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_cia.Sucursal = False
        Me.cmb_cia.TabIndex = 10
        Me.cmb_cia.ValueMember = "Id_Cia"
        '
        'cmb_Grupo
        '
        Me.cmb_Grupo.Cia = False
        Me.cmb_Grupo.Control_Siguiente = Me.cmb_Corte
        Me.cmb_Grupo.DisplayMember = "Descripcion"
        Me.cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Grupo.Empresa = False
        Me.cmb_Grupo.FormattingEnabled = True
        Me.cmb_Grupo.Location = New System.Drawing.Point(91, 127)
        Me.cmb_Grupo.MaxDropDownItems = 20
        Me.cmb_Grupo.Name = "cmb_Grupo"
        Me.cmb_Grupo.NombreParametro = "@Id_CajaBancaria"
        Me.cmb_Grupo.Pista = True
        Me.cmb_Grupo.Size = New System.Drawing.Size(173, 21)
        Me.cmb_Grupo.StoredProcedure = "Cat_GrupoDeposito_Get"
        Me.cmb_Grupo.Sucursal = False
        Me.cmb_Grupo.TabIndex = 13
        Me.cmb_Grupo.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_Grupo.ValorParametro = Nothing
        Me.cmb_Grupo.ValueMember = "Id_GrupoDepo"
        '
        'cmb_Corte
        '
        Me.cmb_Corte.Cia = False
        Me.cmb_Corte.Control_Siguiente = Me.tbx_ClaveCajero
        Me.cmb_Corte.DisplayMember = "Descripcion"
        Me.cmb_Corte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corte.FormattingEnabled = True
        Me.cmb_Corte.Location = New System.Drawing.Point(389, 129)
        Me.cmb_Corte.MaxDropDownItems = 20
        Me.cmb_Corte.Name = "cmb_Corte"
        Me.cmb_Corte.Pista = False
        Me.cmb_Corte.Size = New System.Drawing.Size(89, 21)
        Me.cmb_Corte.StoredProcedure = "Pro_Cortes_Get"
        Me.cmb_Corte.Sucursal = False
        Me.cmb_Corte.TabIndex = 16
        Me.cmb_Corte.ValueMember = "Numero_Corte"
        '
        'tbx_ClaveCajero
        '
        Me.tbx_ClaveCajero.Control_Siguiente = Me.cmb_Cajero
        Me.tbx_ClaveCajero.Filtrado = True
        Me.tbx_ClaveCajero.Location = New System.Drawing.Point(91, 155)
        Me.tbx_ClaveCajero.MaxLength = 12
        Me.tbx_ClaveCajero.Name = "tbx_ClaveCajero"
        Me.tbx_ClaveCajero.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveCajero.TabIndex = 19
        Me.tbx_ClaveCajero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveCajero.Visible = False
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Me.tbx_ClaveCajero
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.ItemHeight = 13
        Me.cmb_Cajero.Location = New System.Drawing.Point(91, 154)
        Me.cmb_Cajero.MaxDropDownItems = 20
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(387, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 20
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(546, 145)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 22
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(47, 23)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Control_Siguiente = Me.cmb_Hasta
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(91, 19)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(136, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 1
        Me.cmb_Desde.ValueMember = "Id_Sesion"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(233, 26)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_Cia
        '
        Me.lbl_Cia.AutoSize = True
        Me.lbl_Cia.Location = New System.Drawing.Point(10, 104)
        Me.lbl_Cia.Name = "lbl_Cia"
        Me.lbl_Cia.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Cia.TabIndex = 9
        Me.lbl_Cia.Text = "Cia. Traslado"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(9, 51)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 4
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(42, 158)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Cajero.TabIndex = 18
        Me.lbl_Cajero.Text = "Cajero"
        '
        'cbx_TGrupos
        '
        Me.cbx_TGrupos.AutoSize = True
        Me.cbx_TGrupos.Location = New System.Drawing.Point(270, 131)
        Me.cbx_TGrupos.Name = "cbx_TGrupos"
        Me.cbx_TGrupos.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TGrupos.TabIndex = 14
        Me.cbx_TGrupos.Text = "Todos"
        Me.cbx_TGrupos.UseVisualStyleBackColor = True
        '
        'cbx_TTraslado
        '
        Me.cbx_TTraslado.AutoSize = True
        Me.cbx_TTraslado.Location = New System.Drawing.Point(484, 103)
        Me.cbx_TTraslado.Name = "cbx_TTraslado"
        Me.cbx_TTraslado.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TTraslado.TabIndex = 11
        Me.cbx_TTraslado.Text = "Todos"
        Me.cbx_TTraslado.UseVisualStyleBackColor = True
        '
        'cbx_TCajero
        '
        Me.cbx_TCajero.AutoSize = True
        Me.cbx_TCajero.Location = New System.Drawing.Point(484, 156)
        Me.cbx_TCajero.Name = "cbx_TCajero"
        Me.cbx_TCajero.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TCajero.TabIndex = 21
        Me.cbx_TCajero.Text = "Todos"
        Me.cbx_TCajero.UseVisualStyleBackColor = True
        '
        'cbx_Todos
        '
        Me.cbx_Todos.AutoSize = True
        Me.cbx_Todos.Location = New System.Drawing.Point(484, 132)
        Me.cbx_Todos.Name = "cbx_Todos"
        Me.cbx_Todos.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Todos.TabIndex = 17
        Me.cbx_Todos.Text = "Todos"
        Me.cbx_Todos.UseVisualStyleBackColor = True
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(348, 132)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Corte.TabIndex = 15
        Me.lbl_Corte.Text = "Corte"
        '
        'lbl_Grupo
        '
        Me.lbl_Grupo.AutoSize = True
        Me.lbl_Grupo.Location = New System.Drawing.Point(4, 130)
        Me.lbl_Grupo.Name = "lbl_Grupo"
        Me.lbl_Grupo.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Grupo.TabIndex = 12
        Me.lbl_Grupo.Text = "Grupo Proceso"
        '
        'Cp_cmb_Parametro1
        '
        Me.Cp_cmb_Parametro1.Cia = False
        Me.Cp_cmb_Parametro1.Control_Siguiente = Nothing
        Me.Cp_cmb_Parametro1.DisplayMember = "Descripcion"
        Me.Cp_cmb_Parametro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cp_cmb_Parametro1.Empresa = False
        Me.Cp_cmb_Parametro1.FormattingEnabled = True
        Me.Cp_cmb_Parametro1.Location = New System.Drawing.Point(546, -75)
        Me.Cp_cmb_Parametro1.MaxDropDownItems = 20
        Me.Cp_cmb_Parametro1.Name = "Cp_cmb_Parametro1"
        Me.Cp_cmb_Parametro1.NombreParametro = "@Id_CajaBancaria"
        Me.Cp_cmb_Parametro1.Pista = True
        Me.Cp_cmb_Parametro1.Size = New System.Drawing.Size(156, 21)
        Me.Cp_cmb_Parametro1.StoredProcedure = "Cat_GrupoDeposito_Get"
        Me.Cp_cmb_Parametro1.Sucursal = False
        Me.Cp_cmb_Parametro1.TabIndex = 2
        Me.Cp_cmb_Parametro1.Tipodedatos = System.Data.SqlDbType.Int
        Me.Cp_cmb_Parametro1.ValorParametro = Nothing
        Me.Cp_cmb_Parametro1.ValueMember = "Id_GrupoDepo"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(36, 76)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 7
        Me.lbl_Moneda.Text = "Moneda"
        '
        'frm_ReimprimirCorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Fichas)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ReimprimirCorte"
        Me.Text = "Reimprime Corte"
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Fichas.ResumeLayout(False)
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents lsv_Catalogo As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Fichas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cmb_cia As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Cia As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveCajero As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents cbx_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Corte As Modulo_Proceso.cp_cmb_SimpleParametros
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents lbl_Grupo As System.Windows.Forms.Label
    Friend WithEvents cmb_Grupo As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cbx_TGrupos As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_TTraslado As System.Windows.Forms.CheckBox
    Friend WithEvents Cp_cmb_Parametro1 As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents cbx_TCajero As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Extraer As System.Windows.Forms.Button
End Class
