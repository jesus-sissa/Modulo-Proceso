<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActasValidar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ActasValidar))
        Me.gbx_Actas = New System.Windows.Forms.GroupBox
        Me.rtb_Comentarios2 = New System.Windows.Forms.RichTextBox
        Me.rtb_Comentarios = New System.Windows.Forms.RichTextBox
        Me.lbl_Actas = New System.Windows.Forms.Label
        Me.lsv_Actas = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.lbl_TipoDiferencia = New System.Windows.Forms.Label
        Me.cmb_ComboDiferencias = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.cmb_TipoDiferencia = New Modulo_Proceso.cp_cmb_Manual
        Me.chk_Diferencia = New System.Windows.Forms.CheckBox
        Me.lbl_Diferencia = New System.Windows.Forms.Label
        Me.chk_TodosCajas = New System.Windows.Forms.CheckBox
        Me.chk_TodasCias = New System.Windows.Forms.CheckBox
        Me.chk_Clientes = New System.Windows.Forms.CheckBox
        Me.cmb_Clientes = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Cia = New System.Windows.Forms.Label
        Me.cmb_Cia = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.cmb_Sesion = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.lbl_Sesion = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.rtb_Validacion = New System.Windows.Forms.RichTextBox
        Me.gbx_Validar = New System.Windows.Forms.GroupBox
        Me.gbx_Actas.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Validar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Actas
        '
        Me.gbx_Actas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Actas.Controls.Add(Me.rtb_Comentarios2)
        Me.gbx_Actas.Controls.Add(Me.rtb_Comentarios)
        Me.gbx_Actas.Controls.Add(Me.lbl_Actas)
        Me.gbx_Actas.Controls.Add(Me.lsv_Actas)
        Me.gbx_Actas.Location = New System.Drawing.Point(6, 165)
        Me.gbx_Actas.Name = "gbx_Actas"
        Me.gbx_Actas.Size = New System.Drawing.Size(963, 242)
        Me.gbx_Actas.TabIndex = 3
        Me.gbx_Actas.TabStop = False
        '
        'rtb_Comentarios2
        '
        Me.rtb_Comentarios2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Comentarios2.Location = New System.Drawing.Point(484, 173)
        Me.rtb_Comentarios2.Name = "rtb_Comentarios2"
        Me.rtb_Comentarios2.ReadOnly = True
        Me.rtb_Comentarios2.Size = New System.Drawing.Size(473, 61)
        Me.rtb_Comentarios2.TabIndex = 2
        Me.rtb_Comentarios2.Text = ""
        '
        'rtb_Comentarios
        '
        Me.rtb_Comentarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rtb_Comentarios.Location = New System.Drawing.Point(6, 173)
        Me.rtb_Comentarios.Name = "rtb_Comentarios"
        Me.rtb_Comentarios.ReadOnly = True
        Me.rtb_Comentarios.Size = New System.Drawing.Size(473, 61)
        Me.rtb_Comentarios.TabIndex = 3
        Me.rtb_Comentarios.Text = ""
        '
        'lbl_Actas
        '
        Me.lbl_Actas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Actas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Actas.Location = New System.Drawing.Point(814, 14)
        Me.lbl_Actas.Name = "lbl_Actas"
        Me.lbl_Actas.Size = New System.Drawing.Size(143, 13)
        Me.lbl_Actas.TabIndex = 1
        Me.lbl_Actas.Text = "Registros: 0"
        Me.lbl_Actas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Actas
        '
        Me.lsv_Actas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Actas.FullRowSelect = True
        Me.lsv_Actas.HideSelection = False
        Me.lsv_Actas.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Actas.Lvs = ListViewColumnSorter1
        Me.lsv_Actas.MultiSelect = False
        Me.lsv_Actas.Name = "lsv_Actas"
        Me.lsv_Actas.Row1 = 8
        Me.lsv_Actas.Row10 = 0
        Me.lsv_Actas.Row2 = 6
        Me.lsv_Actas.Row3 = 6
        Me.lsv_Actas.Row4 = 15
        Me.lsv_Actas.Row5 = 30
        Me.lsv_Actas.Row6 = 10
        Me.lsv_Actas.Row7 = 15
        Me.lsv_Actas.Row8 = 8
        Me.lsv_Actas.Row9 = 0
        Me.lsv_Actas.Size = New System.Drawing.Size(951, 130)
        Me.lsv_Actas.TabIndex = 0
        Me.lsv_Actas.UseCompatibleStateImageBehavior = False
        Me.lsv_Actas.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.lbl_TipoDiferencia)
        Me.Gbx_Botones.Controls.Add(Me.cmb_ComboDiferencias)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 503)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(962, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'lbl_TipoDiferencia
        '
        Me.lbl_TipoDiferencia.AutoSize = True
        Me.lbl_TipoDiferencia.Location = New System.Drawing.Point(10, 24)
        Me.lbl_TipoDiferencia.Name = "lbl_TipoDiferencia"
        Me.lbl_TipoDiferencia.Size = New System.Drawing.Size(97, 13)
        Me.lbl_TipoDiferencia.TabIndex = 4
        Me.lbl_TipoDiferencia.Text = "Tipo de Diferencia:"
        '
        'cmb_ComboDiferencias
        '
        Me.cmb_ComboDiferencias.Clave = "Tipo"
        Me.cmb_ComboDiferencias.Control_Siguiente = Nothing
        Me.cmb_ComboDiferencias.DisplayMember = "Descripcion"
        Me.cmb_ComboDiferencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ComboDiferencias.Empresa = False
        Me.cmb_ComboDiferencias.Filtro = Nothing
        Me.cmb_ComboDiferencias.FormattingEnabled = True
        Me.cmb_ComboDiferencias.Location = New System.Drawing.Point(113, 21)
        Me.cmb_ComboDiferencias.MaxDropDownItems = 20
        Me.cmb_ComboDiferencias.Name = "cmb_ComboDiferencias"
        Me.cmb_ComboDiferencias.Pista = False
        Me.cmb_ComboDiferencias.Size = New System.Drawing.Size(330, 21)
        Me.cmb_ComboDiferencias.StoredProcedure = "Cat_TipoDiferencia_GetCombo"
        Me.cmb_ComboDiferencias.Sucursal = False
        Me.cmb_ComboDiferencias.TabIndex = 3
        Me.cmb_ComboDiferencias.Tipo = 0
        Me.cmb_ComboDiferencias.ValueMember = "Id_TipoDiferencia"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(814, 15)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Proceso.My.Resources.Resources.Baja
        Me.btn_Cancelar.Location = New System.Drawing.Point(595, 15)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_Proceso.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(449, 15)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.cmb_TipoDiferencia)
        Me.gbx_Datos.Controls.Add(Me.chk_Diferencia)
        Me.gbx_Datos.Controls.Add(Me.lbl_Diferencia)
        Me.gbx_Datos.Controls.Add(Me.chk_TodosCajas)
        Me.gbx_Datos.Controls.Add(Me.chk_TodasCias)
        Me.gbx_Datos.Controls.Add(Me.chk_Clientes)
        Me.gbx_Datos.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cia)
        Me.gbx_Datos.Controls.Add(Me.cmb_Cia)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Datos.Controls.Add(Me.cmb_Sesion)
        Me.gbx_Datos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Datos.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.lbl_Sesion)
        Me.gbx_Datos.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Location = New System.Drawing.Point(6, 1)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(962, 158)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'cmb_TipoDiferencia
        '
        Me.cmb_TipoDiferencia.Control_Siguiente = Nothing
        Me.cmb_TipoDiferencia.DisplayMember = "display"
        Me.cmb_TipoDiferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDiferencia.FormattingEnabled = True
        Me.cmb_TipoDiferencia.Location = New System.Drawing.Point(113, 130)
        Me.cmb_TipoDiferencia.MaxDropDownItems = 20
        Me.cmb_TipoDiferencia.Name = "cmb_TipoDiferencia"
        Me.cmb_TipoDiferencia.Size = New System.Drawing.Size(228, 21)
        Me.cmb_TipoDiferencia.TabIndex = 25
        Me.cmb_TipoDiferencia.ValueMember = "value"
        '
        'chk_Diferencia
        '
        Me.chk_Diferencia.AutoSize = True
        Me.chk_Diferencia.Location = New System.Drawing.Point(347, 133)
        Me.chk_Diferencia.Name = "chk_Diferencia"
        Me.chk_Diferencia.Size = New System.Drawing.Size(56, 17)
        Me.chk_Diferencia.TabIndex = 24
        Me.chk_Diferencia.Text = "Todos"
        Me.chk_Diferencia.UseVisualStyleBackColor = True
        '
        'lbl_Diferencia
        '
        Me.lbl_Diferencia.AutoSize = True
        Me.lbl_Diferencia.Location = New System.Drawing.Point(13, 133)
        Me.lbl_Diferencia.Name = "lbl_Diferencia"
        Me.lbl_Diferencia.Size = New System.Drawing.Size(94, 13)
        Me.lbl_Diferencia.TabIndex = 23
        Me.lbl_Diferencia.Text = "Tipo de Diferencia"
        '
        'chk_TodosCajas
        '
        Me.chk_TodosCajas.AutoSize = True
        Me.chk_TodosCajas.Location = New System.Drawing.Point(460, 47)
        Me.chk_TodosCajas.Name = "chk_TodosCajas"
        Me.chk_TodosCajas.Size = New System.Drawing.Size(56, 17)
        Me.chk_TodosCajas.TabIndex = 13
        Me.chk_TodosCajas.Text = "Todos"
        Me.chk_TodosCajas.UseVisualStyleBackColor = True
        '
        'chk_TodasCias
        '
        Me.chk_TodasCias.AutoSize = True
        Me.chk_TodasCias.Location = New System.Drawing.Point(461, 72)
        Me.chk_TodasCias.Name = "chk_TodasCias"
        Me.chk_TodasCias.Size = New System.Drawing.Size(56, 17)
        Me.chk_TodasCias.TabIndex = 13
        Me.chk_TodasCias.Text = "Todos"
        Me.chk_TodasCias.UseVisualStyleBackColor = True
        '
        'chk_Clientes
        '
        Me.chk_Clientes.AutoSize = True
        Me.chk_Clientes.Location = New System.Drawing.Point(461, 100)
        Me.chk_Clientes.Name = "chk_Clientes"
        Me.chk_Clientes.Size = New System.Drawing.Size(56, 17)
        Me.chk_Clientes.TabIndex = 13
        Me.chk_Clientes.Text = "Todos"
        Me.chk_Clientes.UseVisualStyleBackColor = True
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave"
        Me.cmb_Clientes.Control_Siguiente = Nothing
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Nothing
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(113, 100)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(342, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_ClientesProceso_ByCajaAndCiaStatus"
        Me.cmb_Clientes.Sucursal = False
        Me.cmb_Clientes.TabIndex = 11
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_ClienteP"
        '
        'lbl_Cia
        '
        Me.lbl_Cia.AutoSize = True
        Me.lbl_Cia.Location = New System.Drawing.Point(22, 75)
        Me.lbl_Cia.Name = "lbl_Cia"
        Me.lbl_Cia.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Cia.TabIndex = 7
        Me.lbl_Cia.Text = "Cia de Traslado"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Control_Siguiente = Nothing
        Me.cmb_Cia.DisplayMember = "Nombre"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(113, 72)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(342, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 8
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(64, 102)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 9
        Me.lbl_Cliente.Text = "Cliente"
        '
        'cmb_Sesion
        '
        Me.cmb_Sesion.Clave = Nothing
        Me.cmb_Sesion.Control_Siguiente = Nothing
        Me.cmb_Sesion.DisplayMember = "Numero_Sesion"
        Me.cmb_Sesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sesion.Empresa = False
        Me.cmb_Sesion.Filtro = Nothing
        Me.cmb_Sesion.FormattingEnabled = True
        Me.cmb_Sesion.Location = New System.Drawing.Point(262, 18)
        Me.cmb_Sesion.MaxDropDownItems = 20
        Me.cmb_Sesion.Name = "cmb_Sesion"
        Me.cmb_Sesion.Pista = False
        Me.cmb_Sesion.Size = New System.Drawing.Size(101, 21)
        Me.cmb_Sesion.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Sesion.Sucursal = True
        Me.cmb_Sesion.TabIndex = 3
        Me.cmb_Sesion.Tipo = 0
        Me.cmb_Sesion.ValueMember = "Id_Sesion"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(638, 120)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 12
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(30, 49)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 4
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
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
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(113, 45)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(341, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 6
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Location = New System.Drawing.Point(214, 21)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Sesion.TabIndex = 2
        Me.lbl_Sesion.Text = "Sesión"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(67, 21)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(113, 17)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'rtb_Validacion
        '
        Me.rtb_Validacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Validacion.Location = New System.Drawing.Point(6, 19)
        Me.rtb_Validacion.MaxLength = 500
        Me.rtb_Validacion.Name = "rtb_Validacion"
        Me.rtb_Validacion.Size = New System.Drawing.Size(948, 64)
        Me.rtb_Validacion.TabIndex = 0
        Me.rtb_Validacion.Text = ""
        '
        'gbx_Validar
        '
        Me.gbx_Validar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Validar.Controls.Add(Me.rtb_Validacion)
        Me.gbx_Validar.Location = New System.Drawing.Point(6, 412)
        Me.gbx_Validar.Name = "gbx_Validar"
        Me.gbx_Validar.Size = New System.Drawing.Size(963, 92)
        Me.gbx_Validar.TabIndex = 2
        Me.gbx_Validar.TabStop = False
        Me.gbx_Validar.Text = "Comnetarios Validación/Cancelación"
        '
        'frm_ActasValidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 561)
        Me.Controls.Add(Me.gbx_Validar)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Actas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(920, 600)
        Me.Name = "frm_ActasValidar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar Actas de Diferencia"
        Me.gbx_Actas.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Botones.PerformLayout()
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_Validar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Actas As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Actas As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Sesion As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Actas As System.Windows.Forms.Label
    Friend WithEvents rtb_Validacion As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_Validar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents rtb_Comentarios2 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtb_Comentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_Cia As System.Windows.Forms.Label
    Friend WithEvents cmb_Cia As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Clientes As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TodosCajas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TodasCias As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_TipoDiferencia As System.Windows.Forms.Label
    Friend WithEvents cmb_ComboDiferencias As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_TipoDiferencia As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents chk_Diferencia As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Diferencia As System.Windows.Forms.Label
End Class
