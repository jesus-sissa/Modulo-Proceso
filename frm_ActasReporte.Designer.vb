<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActasReporte
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ActasReporte))
        Me.gbx_Actas = New System.Windows.Forms.GroupBox()
        Me.rtb_Comentarios2 = New System.Windows.Forms.RichTextBox()
        Me.rtb_Comentarios = New System.Windows.Forms.RichTextBox()
        Me.lbl_Actas = New System.Windows.Forms.Label()
        Me.lsv_Actas = New Modulo_Proceso.cp_Listview()
        Me.ContextMenuStripCopiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Reporte = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Datos = New System.Windows.Forms.GroupBox()
        Me.cmb_TipoDiferencia = New Modulo_Proceso.cp_cmb_Manual()
        Me.chk_Diferencia = New System.Windows.Forms.CheckBox()
        Me.lbl_Diferencia = New System.Windows.Forms.Label()
        Me.cmb_Clientes = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Cia = New System.Windows.Forms.Label()
        Me.cmb_Cia = New Modulo_Proceso.cp_cmb_Simple()
        Me.Chk_Clientes = New System.Windows.Forms.CheckBox()
        Me.chk_TodasCias = New System.Windows.Forms.CheckBox()
        Me.chk_Cajas = New System.Windows.Forms.CheckBox()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label()
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_SesionHasta = New System.Windows.Forms.Label()
        Me.lbl_Sesion = New System.Windows.Forms.Label()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.cmb_SesionHasta = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.cmb_SesionDesde = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.gbx_Actas.SuspendLayout()
        Me.ContextMenuStripCopiar.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
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
        Me.gbx_Actas.Location = New System.Drawing.Point(5, 186)
        Me.gbx_Actas.Name = "gbx_Actas"
        Me.gbx_Actas.Size = New System.Drawing.Size(793, 319)
        Me.gbx_Actas.TabIndex = 1
        Me.gbx_Actas.TabStop = False
        '
        'rtb_Comentarios2
        '
        Me.rtb_Comentarios2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Comentarios2.BackColor = System.Drawing.SystemColors.Control
        Me.rtb_Comentarios2.Location = New System.Drawing.Point(402, 252)
        Me.rtb_Comentarios2.Name = "rtb_Comentarios2"
        Me.rtb_Comentarios2.ReadOnly = True
        Me.rtb_Comentarios2.Size = New System.Drawing.Size(385, 61)
        Me.rtb_Comentarios2.TabIndex = 3
        Me.rtb_Comentarios2.Text = ""
        '
        'rtb_Comentarios
        '
        Me.rtb_Comentarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rtb_Comentarios.BackColor = System.Drawing.SystemColors.Control
        Me.rtb_Comentarios.Location = New System.Drawing.Point(6, 252)
        Me.rtb_Comentarios.Name = "rtb_Comentarios"
        Me.rtb_Comentarios.ReadOnly = True
        Me.rtb_Comentarios.Size = New System.Drawing.Size(385, 61)
        Me.rtb_Comentarios.TabIndex = 2
        Me.rtb_Comentarios.Text = ""
        '
        'lbl_Actas
        '
        Me.lbl_Actas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Actas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Actas.Location = New System.Drawing.Point(648, 16)
        Me.lbl_Actas.Name = "lbl_Actas"
        Me.lbl_Actas.Size = New System.Drawing.Size(139, 15)
        Me.lbl_Actas.TabIndex = 1
        Me.lbl_Actas.Text = "Registros: 0"
        Me.lbl_Actas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Actas
        '
        Me.lsv_Actas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Actas.ContextMenuStrip = Me.ContextMenuStripCopiar
        Me.lsv_Actas.FullRowSelect = True
        Me.lsv_Actas.HideSelection = False
        Me.lsv_Actas.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Actas.Lvs = ListViewColumnSorter1
        Me.lsv_Actas.MultiSelect = False
        Me.lsv_Actas.Name = "lsv_Actas"
        Me.lsv_Actas.Row1 = 5
        Me.lsv_Actas.Row10 = 7
        Me.lsv_Actas.Row2 = 5
        Me.lsv_Actas.Row3 = 5
        Me.lsv_Actas.Row4 = 10
        Me.lsv_Actas.Row5 = 10
        Me.lsv_Actas.Row6 = 10
        Me.lsv_Actas.Row7 = 7
        Me.lsv_Actas.Row8 = 7
        Me.lsv_Actas.Row9 = 7
        Me.lsv_Actas.Size = New System.Drawing.Size(781, 210)
        Me.lsv_Actas.TabIndex = 0
        Me.lsv_Actas.UseCompatibleStateImageBehavior = False
        Me.lsv_Actas.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStripCopiar
        '
        Me.ContextMenuStripCopiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem})
        Me.ContextMenuStripCopiar.Name = "ContextMenuStripCopiar"
        Me.ContextMenuStripCopiar.Size = New System.Drawing.Size(110, 26)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Reporte)
        Me.Gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 505)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(792, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Reporte
        '
        Me.btn_Reporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Reporte.Image = Global.Modulo_Proceso.My.Resources.Resources.Compare
        Me.btn_Reporte.Location = New System.Drawing.Point(151, 12)
        Me.btn_Reporte.Name = "btn_Reporte"
        Me.btn_Reporte.Size = New System.Drawing.Size(140, 30)
        Me.btn_Reporte.TabIndex = 1
        Me.btn_Reporte.Text = "Reimprimir Reporte"
        Me.btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Reporte.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(5, 12)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(644, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.cmb_TipoDiferencia)
        Me.gbx_Datos.Controls.Add(Me.chk_Diferencia)
        Me.gbx_Datos.Controls.Add(Me.lbl_Diferencia)
        Me.gbx_Datos.Controls.Add(Me.cmb_Clientes)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cia)
        Me.gbx_Datos.Controls.Add(Me.cmb_Cia)
        Me.gbx_Datos.Controls.Add(Me.Chk_Clientes)
        Me.gbx_Datos.Controls.Add(Me.chk_TodasCias)
        Me.gbx_Datos.Controls.Add(Me.chk_Cajas)
        Me.gbx_Datos.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Datos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Datos.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Datos.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Datos.Controls.Add(Me.lbl_SesionHasta)
        Me.gbx_Datos.Controls.Add(Me.lbl_Sesion)
        Me.gbx_Datos.Controls.Add(Me.lbl_Desde)
        Me.gbx_Datos.Controls.Add(Me.dtp_Desde)
        Me.gbx_Datos.Controls.Add(Me.cmb_SesionHasta)
        Me.gbx_Datos.Controls.Add(Me.cmb_SesionDesde)
        Me.gbx_Datos.Location = New System.Drawing.Point(6, 2)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(792, 178)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'cmb_TipoDiferencia
        '
        Me.cmb_TipoDiferencia.Control_Siguiente = Nothing
        Me.cmb_TipoDiferencia.DisplayMember = "display"
        Me.cmb_TipoDiferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDiferencia.FormattingEnabled = True
        Me.cmb_TipoDiferencia.Location = New System.Drawing.Point(115, 153)
        Me.cmb_TipoDiferencia.MaxDropDownItems = 20
        Me.cmb_TipoDiferencia.Name = "cmb_TipoDiferencia"
        Me.cmb_TipoDiferencia.Size = New System.Drawing.Size(228, 21)
        Me.cmb_TipoDiferencia.TabIndex = 22
        Me.cmb_TipoDiferencia.ValueMember = "value"
        '
        'chk_Diferencia
        '
        Me.chk_Diferencia.AutoSize = True
        Me.chk_Diferencia.Location = New System.Drawing.Point(349, 156)
        Me.chk_Diferencia.Name = "chk_Diferencia"
        Me.chk_Diferencia.Size = New System.Drawing.Size(56, 17)
        Me.chk_Diferencia.TabIndex = 21
        Me.chk_Diferencia.Text = "Todos"
        Me.chk_Diferencia.UseVisualStyleBackColor = True
        '
        'lbl_Diferencia
        '
        Me.lbl_Diferencia.AutoSize = True
        Me.lbl_Diferencia.Location = New System.Drawing.Point(15, 156)
        Me.lbl_Diferencia.Name = "lbl_Diferencia"
        Me.lbl_Diferencia.Size = New System.Drawing.Size(94, 13)
        Me.lbl_Diferencia.TabIndex = 20
        Me.lbl_Diferencia.Text = "Tipo de Diferencia"
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
        Me.cmb_Clientes.Location = New System.Drawing.Point(115, 126)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(336, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_ClientesProceso_ByCajaAndCiaStatus"
        Me.cmb_Clientes.Sucursal = False
        Me.cmb_Clientes.TabIndex = 16
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_ClienteP"
        '
        'lbl_Cia
        '
        Me.lbl_Cia.AutoSize = True
        Me.lbl_Cia.Location = New System.Drawing.Point(33, 100)
        Me.lbl_Cia.Name = "lbl_Cia"
        Me.lbl_Cia.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Cia.TabIndex = 12
        Me.lbl_Cia.Text = "Cia de Traslado"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Control_Siguiente = Nothing
        Me.cmb_Cia.DisplayMember = "Nombre"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(115, 98)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(336, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 13
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'Chk_Clientes
        '
        Me.Chk_Clientes.AutoSize = True
        Me.Chk_Clientes.Location = New System.Drawing.Point(456, 128)
        Me.Chk_Clientes.Name = "Chk_Clientes"
        Me.Chk_Clientes.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Clientes.TabIndex = 17
        Me.Chk_Clientes.Text = "Todos"
        Me.Chk_Clientes.UseVisualStyleBackColor = True
        '
        'chk_TodasCias
        '
        Me.chk_TodasCias.AutoSize = True
        Me.chk_TodasCias.Location = New System.Drawing.Point(456, 102)
        Me.chk_TodasCias.Name = "chk_TodasCias"
        Me.chk_TodasCias.Size = New System.Drawing.Size(56, 17)
        Me.chk_TodasCias.TabIndex = 11
        Me.chk_TodasCias.Text = "Todos"
        Me.chk_TodasCias.UseVisualStyleBackColor = True
        '
        'chk_Cajas
        '
        Me.chk_Cajas.AutoSize = True
        Me.chk_Cajas.Location = New System.Drawing.Point(456, 75)
        Me.chk_Cajas.Name = "chk_Cajas"
        Me.chk_Cajas.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cajas.TabIndex = 11
        Me.chk_Cajas.Text = "Todos"
        Me.chk_Cajas.UseVisualStyleBackColor = True
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(69, 125)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 14
        Me.lbl_Cliente.Text = "Cliente"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(628, 144)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 18
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(35, 74)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 8
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
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(115, 71)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(335, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 10
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(51, 48)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 4
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(93, 44)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 5
        '
        'lbl_SesionHasta
        '
        Me.lbl_SesionHasta.AutoSize = True
        Me.lbl_SesionHasta.Location = New System.Drawing.Point(194, 48)
        Me.lbl_SesionHasta.Name = "lbl_SesionHasta"
        Me.lbl_SesionHasta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_SesionHasta.TabIndex = 6
        Me.lbl_SesionHasta.Text = "Sesion"
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Location = New System.Drawing.Point(194, 19)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Sesion.TabIndex = 2
        Me.lbl_Sesion.Text = "Sesion"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(48, 21)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(93, 17)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'cmb_SesionHasta
        '
        Me.cmb_SesionHasta.Clave = Nothing
        Me.cmb_SesionHasta.Control_Siguiente = Nothing
        Me.cmb_SesionHasta.DisplayMember = "Numero_Sesion"
        Me.cmb_SesionHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SesionHasta.Empresa = False
        Me.cmb_SesionHasta.Filtro = Nothing
        Me.cmb_SesionHasta.FormattingEnabled = True
        Me.cmb_SesionHasta.Location = New System.Drawing.Point(242, 43)
        Me.cmb_SesionHasta.MaxDropDownItems = 20
        Me.cmb_SesionHasta.Name = "cmb_SesionHasta"
        Me.cmb_SesionHasta.Pista = False
        Me.cmb_SesionHasta.Size = New System.Drawing.Size(101, 21)
        Me.cmb_SesionHasta.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_SesionHasta.Sucursal = True
        Me.cmb_SesionHasta.TabIndex = 7
        Me.cmb_SesionHasta.Tipo = 0
        Me.cmb_SesionHasta.ValueMember = "Id_Sesion"
        '
        'cmb_SesionDesde
        '
        Me.cmb_SesionDesde.Clave = Nothing
        Me.cmb_SesionDesde.Control_Siguiente = Nothing
        Me.cmb_SesionDesde.DisplayMember = "Numero_Sesion"
        Me.cmb_SesionDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SesionDesde.Empresa = False
        Me.cmb_SesionDesde.Filtro = Nothing
        Me.cmb_SesionDesde.FormattingEnabled = True
        Me.cmb_SesionDesde.Location = New System.Drawing.Point(242, 16)
        Me.cmb_SesionDesde.MaxDropDownItems = 20
        Me.cmb_SesionDesde.Name = "cmb_SesionDesde"
        Me.cmb_SesionDesde.Pista = False
        Me.cmb_SesionDesde.Size = New System.Drawing.Size(101, 21)
        Me.cmb_SesionDesde.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_SesionDesde.Sucursal = True
        Me.cmb_SesionDesde.TabIndex = 3
        Me.cmb_SesionDesde.Tipo = 0
        Me.cmb_SesionDesde.ValueMember = "Id_Sesion"
        '
        'frm_ActasReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 561)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Actas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(820, 600)
        Me.Name = "frm_ActasReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Actas de Diferencia"
        Me.gbx_Actas.ResumeLayout(False)
        Me.ContextMenuStripCopiar.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Actas As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Actas As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_SesionDesde As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Actas As System.Windows.Forms.Label
    Friend WithEvents rtb_Comentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_SesionHasta As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Chk_Clientes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Cajas As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents lbl_SesionHasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents rtb_Comentarios2 As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Reporte As System.Windows.Forms.Button
    Friend WithEvents lbl_Cia As System.Windows.Forms.Label
    Friend WithEvents cmb_Cia As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Clientes As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_TodasCias As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_TipoDiferencia As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents chk_Diferencia As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Diferencia As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStripCopiar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
