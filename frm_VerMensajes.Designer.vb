<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VerMensajes
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VerMensajes))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Mensajes = New System.Windows.Forms.GroupBox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_Proceso.cp_Textbox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cmb_Empleados = New Modulo_Proceso.cp_cmb_Simple
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.cbx_TodasFechas = New System.Windows.Forms.CheckBox
        Me.cbx_TodosEmpleados = New System.Windows.Forms.CheckBox
        Me.tab_Mensajes = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cbx_Pendientes = New System.Windows.Forms.CheckBox
        Me.lsv_MensajesRecibidos = New Modulo_Proceso.cp_Listview
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsm_Atendido = New System.Windows.Forms.ToolStripMenuItem
        Me.il_Mensajes = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lsv_MensajesEnviados = New Modulo_Proceso.cp_Listview
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.gbx_Respuesta = New System.Windows.Forms.GroupBox
        Me.rtb_Respuesta = New System.Windows.Forms.RichTextBox
        Me.btn_Responder = New System.Windows.Forms.Button
        Me.gbx_Mensaje = New System.Windows.Forms.GroupBox
        Me.tbx_Hora = New System.Windows.Forms.TextBox
        Me.tbx_Fecha = New System.Windows.Forms.TextBox
        Me.tbx_Remitente = New System.Windows.Forms.TextBox
        Me.tbx_Tipo = New System.Windows.Forms.TextBox
        Me.lbl_Nota = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbx_Asunto = New System.Windows.Forms.TextBox
        Me.lbl_Asunto = New System.Windows.Forms.Label
        Me.tbx_Modulo = New System.Windows.Forms.TextBox
        Me.lbl_RemitenteDetalle = New System.Windows.Forms.Label
        Me.lbl_ModuloDestinatario = New System.Windows.Forms.Label
        Me.lbl_ModuloRemitente = New System.Windows.Forms.Label
        Me.lbl_Hora = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.rtb_Mensaje = New System.Windows.Forms.RichTextBox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbx_Mensajes.SuspendLayout()
        Me.tab_Mensajes.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.cms.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbx_Respuesta.SuspendLayout()
        Me.gbx_Mensaje.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Mensajes
        '
        Me.gbx_Mensajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Mensajes.Controls.Add(Me.btn_Buscar)
        Me.gbx_Mensajes.Controls.Add(Me.lbl_Buscar)
        Me.gbx_Mensajes.Controls.Add(Me.tbx_Buscar)
        Me.gbx_Mensajes.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Mensajes.Controls.Add(Me.cmb_Empleados)
        Me.gbx_Mensajes.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Mensajes.Controls.Add(Me.dtp_Desde)
        Me.gbx_Mensajes.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Mensajes.Controls.Add(Me.lbl_Desde)
        Me.gbx_Mensajes.Controls.Add(Me.cbx_TodasFechas)
        Me.gbx_Mensajes.Controls.Add(Me.cbx_TodosEmpleados)
        Me.gbx_Mensajes.Controls.Add(Me.tab_Mensajes)
        Me.gbx_Mensajes.Controls.Add(Me.lbl_Empleado)
        Me.gbx_Mensajes.Location = New System.Drawing.Point(6, 3)
        Me.gbx_Mensajes.Name = "gbx_Mensajes"
        Me.gbx_Mensajes.Size = New System.Drawing.Size(364, 485)
        Me.gbx_Mensajes.TabIndex = 0
        Me.gbx_Mensajes.TabStop = False
        Me.gbx_Mensajes.Text = "Mensajes"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(307, 102)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(26, 23)
        Me.btn_Buscar.TabIndex = 11
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(24, 107)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 9
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(73, 104)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Buscar.TabIndex = 10
        Me.tbx_Buscar.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = CType(resources.GetObject("btn_Mostrar.Image"), System.Drawing.Image)
        Me.btn_Mostrar.Location = New System.Drawing.Point(71, 75)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mostrar.TabIndex = 8
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cmb_Empleados
        '
        Me.cmb_Empleados.Control_Siguiente = Nothing
        Me.cmb_Empleados.DisplayMember = "Nombre"
        Me.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleados.Empresa = False
        Me.cmb_Empleados.Enabled = False
        Me.cmb_Empleados.FormattingEnabled = True
        Me.cmb_Empleados.Location = New System.Drawing.Point(73, 48)
        Me.cmb_Empleados.MaxDropDownItems = 20
        Me.cmb_Empleados.Name = "cmb_Empleados"
        Me.cmb_Empleados.Pista = False
        Me.cmb_Empleados.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Empleados.StoredProcedure = "Usr_UsuariosCombo_Get"
        Me.cmb_Empleados.Sucursal = True
        Me.cmb_Empleados.TabIndex = 6
        Me.cmb_Empleados.ValueMember = "Id_Empleado"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Enabled = False
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(206, 22)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Enabled = False
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(73, 22)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(170, 26)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(29, 26)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'cbx_TodasFechas
        '
        Me.cbx_TodasFechas.AutoSize = True
        Me.cbx_TodasFechas.Checked = True
        Me.cbx_TodasFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_TodasFechas.Location = New System.Drawing.Point(307, 25)
        Me.cbx_TodasFechas.Name = "cbx_TodasFechas"
        Me.cbx_TodasFechas.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TodasFechas.TabIndex = 4
        Me.cbx_TodasFechas.Text = "Todos"
        Me.cbx_TodasFechas.UseVisualStyleBackColor = True
        '
        'cbx_TodosEmpleados
        '
        Me.cbx_TodosEmpleados.AutoSize = True
        Me.cbx_TodosEmpleados.Checked = True
        Me.cbx_TodosEmpleados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_TodosEmpleados.Location = New System.Drawing.Point(307, 50)
        Me.cbx_TodosEmpleados.Name = "cbx_TodosEmpleados"
        Me.cbx_TodosEmpleados.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TodosEmpleados.TabIndex = 7
        Me.cbx_TodosEmpleados.Text = "Todos"
        Me.cbx_TodosEmpleados.UseVisualStyleBackColor = True
        '
        'tab_Mensajes
        '
        Me.tab_Mensajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Mensajes.Controls.Add(Me.TabPage1)
        Me.tab_Mensajes.Controls.Add(Me.TabPage2)
        Me.tab_Mensajes.Location = New System.Drawing.Point(6, 131)
        Me.tab_Mensajes.Name = "tab_Mensajes"
        Me.tab_Mensajes.SelectedIndex = 0
        Me.tab_Mensajes.Size = New System.Drawing.Size(352, 348)
        Me.tab_Mensajes.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbx_Pendientes)
        Me.TabPage1.Controls.Add(Me.lsv_MensajesRecibidos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(344, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Recibidos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbx_Pendientes
        '
        Me.cbx_Pendientes.AutoSize = True
        Me.cbx_Pendientes.Checked = True
        Me.cbx_Pendientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_Pendientes.Location = New System.Drawing.Point(6, 6)
        Me.cbx_Pendientes.Name = "cbx_Pendientes"
        Me.cbx_Pendientes.Size = New System.Drawing.Size(138, 17)
        Me.cbx_Pendientes.TabIndex = 0
        Me.cbx_Pendientes.Text = "Mostrar solo pendientes"
        Me.cbx_Pendientes.UseVisualStyleBackColor = True
        '
        'lsv_MensajesRecibidos
        '
        Me.lsv_MensajesRecibidos.AllowColumnReorder = True
        Me.lsv_MensajesRecibidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_MensajesRecibidos.ContextMenuStrip = Me.cms
        Me.lsv_MensajesRecibidos.FullRowSelect = True
        Me.lsv_MensajesRecibidos.HideSelection = False
        Me.lsv_MensajesRecibidos.LargeImageList = Me.il_Mensajes
        Me.lsv_MensajesRecibidos.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_MensajesRecibidos.Lvs = ListViewColumnSorter1
        Me.lsv_MensajesRecibidos.MultiSelect = False
        Me.lsv_MensajesRecibidos.Name = "lsv_MensajesRecibidos"
        Me.lsv_MensajesRecibidos.Row1 = 20
        Me.lsv_MensajesRecibidos.Row10 = 0
        Me.lsv_MensajesRecibidos.Row2 = 25
        Me.lsv_MensajesRecibidos.Row3 = 25
        Me.lsv_MensajesRecibidos.Row4 = 20
        Me.lsv_MensajesRecibidos.Row5 = 10
        Me.lsv_MensajesRecibidos.Row6 = 0
        Me.lsv_MensajesRecibidos.Row7 = 0
        Me.lsv_MensajesRecibidos.Row8 = 0
        Me.lsv_MensajesRecibidos.Row9 = 0
        Me.lsv_MensajesRecibidos.Size = New System.Drawing.Size(332, 287)
        Me.lsv_MensajesRecibidos.SmallImageList = Me.il_Mensajes
        Me.lsv_MensajesRecibidos.StateImageList = Me.il_Mensajes
        Me.lsv_MensajesRecibidos.TabIndex = 1
        Me.lsv_MensajesRecibidos.UseCompatibleStateImageBehavior = False
        Me.lsv_MensajesRecibidos.View = System.Windows.Forms.View.Details
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Atendido})
        Me.cms.Name = "cms"
        Me.cms.Size = New System.Drawing.Size(124, 26)
        '
        'tsm_Atendido
        '
        Me.tsm_Atendido.Enabled = False
        Me.tsm_Atendido.Image = Global.Modulo_Proceso.My.Resources.Resources.HoraSi
        Me.tsm_Atendido.Name = "tsm_Atendido"
        Me.tsm_Atendido.Size = New System.Drawing.Size(123, 22)
        Me.tsm_Atendido.Text = "&Atendido"
        '
        'il_Mensajes
        '
        Me.il_Mensajes.ImageStream = CType(resources.GetObject("il_Mensajes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il_Mensajes.TransparentColor = System.Drawing.Color.Transparent
        Me.il_Mensajes.Images.SetKeyName(0, "Mail_Cerrado.png")
        Me.il_Mensajes.Images.SetKeyName(1, "Mail_Abierto.png")
        Me.il_Mensajes.Images.SetKeyName(2, "Mail_Enviado.png")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lsv_MensajesEnviados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(344, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Enviados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lsv_MensajesEnviados
        '
        Me.lsv_MensajesEnviados.AllowColumnReorder = True
        Me.lsv_MensajesEnviados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_MensajesEnviados.ContextMenuStrip = Me.cms
        Me.lsv_MensajesEnviados.FullRowSelect = True
        Me.lsv_MensajesEnviados.HideSelection = False
        Me.lsv_MensajesEnviados.LargeImageList = Me.il_Mensajes
        Me.lsv_MensajesEnviados.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_MensajesEnviados.Lvs = ListViewColumnSorter2
        Me.lsv_MensajesEnviados.MultiSelect = False
        Me.lsv_MensajesEnviados.Name = "lsv_MensajesEnviados"
        Me.lsv_MensajesEnviados.Row1 = 20
        Me.lsv_MensajesEnviados.Row10 = 0
        Me.lsv_MensajesEnviados.Row2 = 25
        Me.lsv_MensajesEnviados.Row3 = 25
        Me.lsv_MensajesEnviados.Row4 = 20
        Me.lsv_MensajesEnviados.Row5 = 10
        Me.lsv_MensajesEnviados.Row6 = 0
        Me.lsv_MensajesEnviados.Row7 = 0
        Me.lsv_MensajesEnviados.Row8 = 0
        Me.lsv_MensajesEnviados.Row9 = 0
        Me.lsv_MensajesEnviados.Size = New System.Drawing.Size(332, 299)
        Me.lsv_MensajesEnviados.SmallImageList = Me.il_Mensajes
        Me.lsv_MensajesEnviados.StateImageList = Me.il_Mensajes
        Me.lsv_MensajesEnviados.TabIndex = 1
        Me.lsv_MensajesEnviados.UseCompatibleStateImageBehavior = False
        Me.lsv_MensajesEnviados.View = System.Windows.Forms.View.Details
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.Location = New System.Drawing.Point(3, 51)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Empleado.TabIndex = 5
        Me.lbl_Empleado.Text = "Remitente"
        Me.lbl_Empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Respuesta
        '
        Me.gbx_Respuesta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Respuesta.Controls.Add(Me.rtb_Respuesta)
        Me.gbx_Respuesta.Controls.Add(Me.btn_Responder)
        Me.gbx_Respuesta.Location = New System.Drawing.Point(3, 282)
        Me.gbx_Respuesta.Name = "gbx_Respuesta"
        Me.gbx_Respuesta.Size = New System.Drawing.Size(386, 207)
        Me.gbx_Respuesta.TabIndex = 1
        Me.gbx_Respuesta.TabStop = False
        Me.gbx_Respuesta.Text = "Responder"
        '
        'rtb_Respuesta
        '
        Me.rtb_Respuesta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Respuesta.BackColor = System.Drawing.Color.White
        Me.rtb_Respuesta.Location = New System.Drawing.Point(6, 19)
        Me.rtb_Respuesta.MaxLength = 5000
        Me.rtb_Respuesta.Name = "rtb_Respuesta"
        Me.rtb_Respuesta.Size = New System.Drawing.Size(374, 143)
        Me.rtb_Respuesta.TabIndex = 0
        Me.rtb_Respuesta.Text = ""
        '
        'btn_Responder
        '
        Me.btn_Responder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Responder.Enabled = False
        Me.btn_Responder.Image = Global.Modulo_Proceso.My.Resources.Resources.mail_replay
        Me.btn_Responder.Location = New System.Drawing.Point(240, 171)
        Me.btn_Responder.Name = "btn_Responder"
        Me.btn_Responder.Size = New System.Drawing.Size(140, 30)
        Me.btn_Responder.TabIndex = 1
        Me.btn_Responder.Text = "&Responder"
        Me.btn_Responder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Responder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Responder.UseVisualStyleBackColor = True
        '
        'gbx_Mensaje
        '
        Me.gbx_Mensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Mensaje.Controls.Add(Me.tbx_Hora)
        Me.gbx_Mensaje.Controls.Add(Me.tbx_Fecha)
        Me.gbx_Mensaje.Controls.Add(Me.tbx_Remitente)
        Me.gbx_Mensaje.Controls.Add(Me.tbx_Tipo)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_Nota)
        Me.gbx_Mensaje.Controls.Add(Me.Label1)
        Me.gbx_Mensaje.Controls.Add(Me.tbx_Asunto)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_Asunto)
        Me.gbx_Mensaje.Controls.Add(Me.tbx_Modulo)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_RemitenteDetalle)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_ModuloDestinatario)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_ModuloRemitente)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_Hora)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Mensaje.Controls.Add(Me.rtb_Mensaje)
        Me.gbx_Mensaje.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Mensaje.Name = "gbx_Mensaje"
        Me.gbx_Mensaje.Size = New System.Drawing.Size(386, 275)
        Me.gbx_Mensaje.TabIndex = 0
        Me.gbx_Mensaje.TabStop = False
        '
        'tbx_Hora
        '
        Me.tbx_Hora.BackColor = System.Drawing.Color.White
        Me.tbx_Hora.Location = New System.Drawing.Point(226, 19)
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.ReadOnly = True
        Me.tbx_Hora.Size = New System.Drawing.Size(51, 20)
        Me.tbx_Hora.TabIndex = 3
        '
        'tbx_Fecha
        '
        Me.tbx_Fecha.BackColor = System.Drawing.Color.White
        Me.tbx_Fecha.Location = New System.Drawing.Point(113, 19)
        Me.tbx_Fecha.Name = "tbx_Fecha"
        Me.tbx_Fecha.ReadOnly = True
        Me.tbx_Fecha.Size = New System.Drawing.Size(71, 20)
        Me.tbx_Fecha.TabIndex = 1
        '
        'tbx_Remitente
        '
        Me.tbx_Remitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Remitente.BackColor = System.Drawing.Color.White
        Me.tbx_Remitente.Location = New System.Drawing.Point(113, 45)
        Me.tbx_Remitente.Name = "tbx_Remitente"
        Me.tbx_Remitente.ReadOnly = True
        Me.tbx_Remitente.Size = New System.Drawing.Size(267, 20)
        Me.tbx_Remitente.TabIndex = 5
        '
        'tbx_Tipo
        '
        Me.tbx_Tipo.BackColor = System.Drawing.Color.White
        Me.tbx_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Tipo.Location = New System.Drawing.Point(113, 123)
        Me.tbx_Tipo.Name = "tbx_Tipo"
        Me.tbx_Tipo.ReadOnly = True
        Me.tbx_Tipo.Size = New System.Drawing.Size(116, 20)
        Me.tbx_Tipo.TabIndex = 13
        '
        'lbl_Nota
        '
        Me.lbl_Nota.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Nota.Location = New System.Drawing.Point(102, 146)
        Me.lbl_Nota.Name = "lbl_Nota"
        Me.lbl_Nota.Size = New System.Drawing.Size(209, 13)
        Me.lbl_Nota.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo"
        '
        'tbx_Asunto
        '
        Me.tbx_Asunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Asunto.BackColor = System.Drawing.Color.White
        Me.tbx_Asunto.Location = New System.Drawing.Point(113, 97)
        Me.tbx_Asunto.Name = "tbx_Asunto"
        Me.tbx_Asunto.ReadOnly = True
        Me.tbx_Asunto.Size = New System.Drawing.Size(267, 20)
        Me.tbx_Asunto.TabIndex = 11
        '
        'lbl_Asunto
        '
        Me.lbl_Asunto.AutoSize = True
        Me.lbl_Asunto.Location = New System.Drawing.Point(67, 100)
        Me.lbl_Asunto.Name = "lbl_Asunto"
        Me.lbl_Asunto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Asunto.TabIndex = 10
        Me.lbl_Asunto.Text = "Asunto"
        '
        'tbx_Modulo
        '
        Me.tbx_Modulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Modulo.BackColor = System.Drawing.Color.White
        Me.tbx_Modulo.Location = New System.Drawing.Point(113, 71)
        Me.tbx_Modulo.Name = "tbx_Modulo"
        Me.tbx_Modulo.ReadOnly = True
        Me.tbx_Modulo.Size = New System.Drawing.Size(267, 20)
        Me.tbx_Modulo.TabIndex = 9
        '
        'lbl_RemitenteDetalle
        '
        Me.lbl_RemitenteDetalle.Location = New System.Drawing.Point(43, 48)
        Me.lbl_RemitenteDetalle.Name = "lbl_RemitenteDetalle"
        Me.lbl_RemitenteDetalle.Size = New System.Drawing.Size(64, 13)
        Me.lbl_RemitenteDetalle.TabIndex = 4
        Me.lbl_RemitenteDetalle.Text = "Remitente"
        Me.lbl_RemitenteDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_ModuloDestinatario
        '
        Me.lbl_ModuloDestinatario.AutoSize = True
        Me.lbl_ModuloDestinatario.Location = New System.Drawing.Point(6, 74)
        Me.lbl_ModuloDestinatario.Name = "lbl_ModuloDestinatario"
        Me.lbl_ModuloDestinatario.Size = New System.Drawing.Size(101, 13)
        Me.lbl_ModuloDestinatario.TabIndex = 7
        Me.lbl_ModuloDestinatario.Text = "Módulo Destinatario"
        Me.lbl_ModuloDestinatario.Visible = False
        '
        'lbl_ModuloRemitente
        '
        Me.lbl_ModuloRemitente.AutoSize = True
        Me.lbl_ModuloRemitente.Location = New System.Drawing.Point(14, 74)
        Me.lbl_ModuloRemitente.Name = "lbl_ModuloRemitente"
        Me.lbl_ModuloRemitente.Size = New System.Drawing.Size(93, 13)
        Me.lbl_ModuloRemitente.TabIndex = 8
        Me.lbl_ModuloRemitente.Text = "Módulo Remitente"
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Location = New System.Drawing.Point(190, 22)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Hora.TabIndex = 2
        Me.lbl_Hora.Text = "Hora"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(70, 22)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha"
        '
        'rtb_Mensaje
        '
        Me.rtb_Mensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Mensaje.BackColor = System.Drawing.Color.White
        Me.rtb_Mensaje.Location = New System.Drawing.Point(6, 164)
        Me.rtb_Mensaje.Name = "rtb_Mensaje"
        Me.rtb_Mensaje.ReadOnly = True
        Me.rtb_Mensaje.Size = New System.Drawing.Size(374, 105)
        Me.rtb_Mensaje.TabIndex = 0
        Me.rtb_Mensaje.Text = ""
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(10, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cancelar.Location = New System.Drawing.Point(619, 12)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "&Cerrar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.HoraSi
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Atendido"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Mensajes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_Respuesta)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_Mensaje)
        Me.SplitContainer1.Size = New System.Drawing.Size(777, 493)
        Me.SplitContainer1.SplitterDistance = 378
        Me.SplitContainer1.TabIndex = 0
        '
        'frm_VerMensajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_VerMensajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Mensajes"
        Me.gbx_Mensajes.ResumeLayout(False)
        Me.gbx_Mensajes.PerformLayout()
        Me.tab_Mensajes.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.cms.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.gbx_Respuesta.ResumeLayout(False)
        Me.gbx_Mensaje.ResumeLayout(False)
        Me.gbx_Mensaje.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Mensajes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_MensajesRecibidos As Modulo_Proceso.cp_Listview
    Friend WithEvents cbx_Pendientes As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents il_Mensajes As System.Windows.Forms.ImageList
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsm_Atendido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbx_Mensaje As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Hora As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Fecha As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Remitente As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Asunto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Asunto As System.Windows.Forms.Label
    Friend WithEvents tbx_Modulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ModuloRemitente As System.Windows.Forms.Label
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents rtb_Mensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents tbx_Tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents gbx_Respuesta As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Respuesta As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_Responder As System.Windows.Forms.Button
    Friend WithEvents tab_Mensajes As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cbx_TodosEmpleados As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lsv_MensajesEnviados As Modulo_Proceso.cp_Listview
    Friend WithEvents cmb_Empleados As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cbx_TodasFechas As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_ModuloDestinatario As System.Windows.Forms.Label
    Friend WithEvents lbl_RemitenteDetalle As System.Windows.Forms.Label
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tbx_Buscar As Modulo_Proceso.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
