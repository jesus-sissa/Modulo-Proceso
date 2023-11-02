<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LotesEfectivo_Consultar
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
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LotesEfectivo_Consultar))
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.tab_Lotes = New System.Windows.Forms.TabControl
        Me.tab_LotesEnviados = New System.Windows.Forms.TabPage
        Me.tlp_LotesEnviados = New System.Windows.Forms.TableLayoutPanel
        Me.gbx_EfectivoED = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosLotesED = New System.Windows.Forms.Label
        Me.lsv_EfectivoED = New Modulo_Proceso.cp_Listview
        Me.gbx_EfectivoE = New System.Windows.Forms.GroupBox
        Me.lsv_EfectivoE = New Modulo_Proceso.cp_Listview
        Me.lbl_RegistrosLotesE = New System.Windows.Forms.Label
        Me.btn_MostrarLotesEnviados = New System.Windows.Forms.Button
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.cmb_Destino = New Modulo_Proceso.cp_cmb_Manual
        Me.chk_DestinoTodos = New System.Windows.Forms.CheckBox
        Me.tab_LotesRecibidos = New System.Windows.Forms.TabPage
        Me.tlp_LotesRecibidos = New System.Windows.Forms.TableLayoutPanel
        Me.gbx_EfectivoRD = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosLotesRD = New System.Windows.Forms.Label
        Me.lsv_EfectivoRD = New Modulo_Proceso.cp_Listview
        Me.gbx_EfectivoR = New System.Windows.Forms.GroupBox
        Me.btn_MostrarLotesRecibidos = New System.Windows.Forms.Button
        Me.lbl_Origen = New System.Windows.Forms.Label
        Me.cmb_Origen = New Modulo_Proceso.cp_cmb_Manual
        Me.chk_OrigenTodos = New System.Windows.Forms.CheckBox
        Me.lsv_EfectivoR = New Modulo_Proceso.cp_Listview
        Me.lbl_RegistrosLotesR = New System.Windows.Forms.Label
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Lotes = New System.Windows.Forms.GroupBox
        Me.gbx_filtro = New System.Windows.Forms.GroupBox
        Me.chk_CajaTodos = New System.Windows.Forms.CheckBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.tab_Lotes.SuspendLayout()
        Me.tab_LotesEnviados.SuspendLayout()
        Me.tlp_LotesEnviados.SuspendLayout()
        Me.gbx_EfectivoED.SuspendLayout()
        Me.gbx_EfectivoE.SuspendLayout()
        Me.tab_LotesRecibidos.SuspendLayout()
        Me.tlp_LotesRecibidos.SuspendLayout()
        Me.gbx_EfectivoRD.SuspendLayout()
        Me.gbx_EfectivoR.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Lotes.SuspendLayout()
        Me.gbx_filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_Lotes
        '
        Me.tab_Lotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Lotes.Controls.Add(Me.tab_LotesEnviados)
        Me.tab_Lotes.Controls.Add(Me.tab_LotesRecibidos)
        Me.tab_Lotes.Location = New System.Drawing.Point(6, 19)
        Me.tab_Lotes.Name = "tab_Lotes"
        Me.tab_Lotes.SelectedIndex = 0
        Me.tab_Lotes.Size = New System.Drawing.Size(761, 398)
        Me.tab_Lotes.TabIndex = 0
        '
        'tab_LotesEnviados
        '
        Me.tab_LotesEnviados.Controls.Add(Me.tlp_LotesEnviados)
        Me.tab_LotesEnviados.Location = New System.Drawing.Point(4, 22)
        Me.tab_LotesEnviados.Name = "tab_LotesEnviados"
        Me.tab_LotesEnviados.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_LotesEnviados.Size = New System.Drawing.Size(753, 372)
        Me.tab_LotesEnviados.TabIndex = 0
        Me.tab_LotesEnviados.Text = "Lotes Enviados"
        Me.tab_LotesEnviados.UseVisualStyleBackColor = True
        '
        'tlp_LotesEnviados
        '
        Me.tlp_LotesEnviados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_LotesEnviados.ColumnCount = 1
        Me.tlp_LotesEnviados.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_LotesEnviados.Controls.Add(Me.gbx_EfectivoED, 0, 1)
        Me.tlp_LotesEnviados.Controls.Add(Me.gbx_EfectivoE, 0, 0)
        Me.tlp_LotesEnviados.Location = New System.Drawing.Point(6, 6)
        Me.tlp_LotesEnviados.Name = "tlp_LotesEnviados"
        Me.tlp_LotesEnviados.RowCount = 2
        Me.tlp_LotesEnviados.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.25!))
        Me.tlp_LotesEnviados.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.75!))
        Me.tlp_LotesEnviados.Size = New System.Drawing.Size(741, 360)
        Me.tlp_LotesEnviados.TabIndex = 0
        '
        'gbx_EfectivoED
        '
        Me.gbx_EfectivoED.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoED.Controls.Add(Me.lbl_RegistrosLotesED)
        Me.gbx_EfectivoED.Controls.Add(Me.lsv_EfectivoED)
        Me.gbx_EfectivoED.Location = New System.Drawing.Point(3, 212)
        Me.gbx_EfectivoED.Name = "gbx_EfectivoED"
        Me.gbx_EfectivoED.Size = New System.Drawing.Size(735, 145)
        Me.gbx_EfectivoED.TabIndex = 0
        Me.gbx_EfectivoED.TabStop = False
        '
        'lbl_RegistrosLotesED
        '
        Me.lbl_RegistrosLotesED.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosLotesED.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosLotesED.Location = New System.Drawing.Point(552, 10)
        Me.lbl_RegistrosLotesED.Name = "lbl_RegistrosLotesED"
        Me.lbl_RegistrosLotesED.Size = New System.Drawing.Size(177, 23)
        Me.lbl_RegistrosLotesED.TabIndex = 0
        Me.lbl_RegistrosLotesED.Text = "Registros: 0"
        Me.lbl_RegistrosLotesED.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_EfectivoED
        '
        Me.lsv_EfectivoED.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EfectivoED.FullRowSelect = True
        Me.lsv_EfectivoED.HideSelection = False
        Me.lsv_EfectivoED.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_EfectivoED.Lvs = ListViewColumnSorter1
        Me.lsv_EfectivoED.MultiSelect = False
        Me.lsv_EfectivoED.Name = "lsv_EfectivoED"
        Me.lsv_EfectivoED.Row1 = 10
        Me.lsv_EfectivoED.Row10 = 0
        Me.lsv_EfectivoED.Row2 = 10
        Me.lsv_EfectivoED.Row3 = 10
        Me.lsv_EfectivoED.Row4 = 10
        Me.lsv_EfectivoED.Row5 = 10
        Me.lsv_EfectivoED.Row6 = 10
        Me.lsv_EfectivoED.Row7 = 10
        Me.lsv_EfectivoED.Row8 = 0
        Me.lsv_EfectivoED.Row9 = 10
        Me.lsv_EfectivoED.Size = New System.Drawing.Size(723, 103)
        Me.lsv_EfectivoED.TabIndex = 43
        Me.lsv_EfectivoED.UseCompatibleStateImageBehavior = False
        Me.lsv_EfectivoED.View = System.Windows.Forms.View.Details
        '
        'gbx_EfectivoE
        '
        Me.gbx_EfectivoE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoE.Controls.Add(Me.lsv_EfectivoE)
        Me.gbx_EfectivoE.Controls.Add(Me.lbl_RegistrosLotesE)
        Me.gbx_EfectivoE.Controls.Add(Me.btn_MostrarLotesEnviados)
        Me.gbx_EfectivoE.Controls.Add(Me.lbl_Destino)
        Me.gbx_EfectivoE.Controls.Add(Me.cmb_Destino)
        Me.gbx_EfectivoE.Controls.Add(Me.chk_DestinoTodos)
        Me.gbx_EfectivoE.Location = New System.Drawing.Point(3, 3)
        Me.gbx_EfectivoE.Name = "gbx_EfectivoE"
        Me.gbx_EfectivoE.Size = New System.Drawing.Size(735, 203)
        Me.gbx_EfectivoE.TabIndex = 0
        Me.gbx_EfectivoE.TabStop = False
        '
        'lsv_EfectivoE
        '
        Me.lsv_EfectivoE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EfectivoE.AutoArrange = False
        Me.lsv_EfectivoE.FullRowSelect = True
        Me.lsv_EfectivoE.HideSelection = False
        Me.lsv_EfectivoE.Location = New System.Drawing.Point(6, 47)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_EfectivoE.Lvs = ListViewColumnSorter2
        Me.lsv_EfectivoE.MultiSelect = False
        Me.lsv_EfectivoE.Name = "lsv_EfectivoE"
        Me.lsv_EfectivoE.Row1 = 7
        Me.lsv_EfectivoE.Row10 = 7
        Me.lsv_EfectivoE.Row2 = 15
        Me.lsv_EfectivoE.Row3 = 14
        Me.lsv_EfectivoE.Row4 = 10
        Me.lsv_EfectivoE.Row5 = 14
        Me.lsv_EfectivoE.Row6 = 8
        Me.lsv_EfectivoE.Row7 = 8
        Me.lsv_EfectivoE.Row8 = 8
        Me.lsv_EfectivoE.Row9 = 8
        Me.lsv_EfectivoE.Size = New System.Drawing.Size(723, 150)
        Me.lsv_EfectivoE.TabIndex = 48
        Me.lsv_EfectivoE.UseCompatibleStateImageBehavior = False
        Me.lsv_EfectivoE.View = System.Windows.Forms.View.Details
        '
        'lbl_RegistrosLotesE
        '
        Me.lbl_RegistrosLotesE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosLotesE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosLotesE.Location = New System.Drawing.Point(558, 11)
        Me.lbl_RegistrosLotesE.Name = "lbl_RegistrosLotesE"
        Me.lbl_RegistrosLotesE.Size = New System.Drawing.Size(177, 23)
        Me.lbl_RegistrosLotesE.TabIndex = 4
        Me.lbl_RegistrosLotesE.Text = "Registros: 0"
        Me.lbl_RegistrosLotesE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_MostrarLotesEnviados
        '
        Me.btn_MostrarLotesEnviados.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarLotesEnviados.Location = New System.Drawing.Point(289, 11)
        Me.btn_MostrarLotesEnviados.Name = "btn_MostrarLotesEnviados"
        Me.btn_MostrarLotesEnviados.Size = New System.Drawing.Size(140, 30)
        Me.btn_MostrarLotesEnviados.TabIndex = 3
        Me.btn_MostrarLotesEnviados.Text = "&Mostrar"
        Me.btn_MostrarLotesEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarLotesEnviados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarLotesEnviados.UseVisualStyleBackColor = True
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(8, 14)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 0
        Me.lbl_Destino.Text = "Destino"
        '
        'cmb_Destino
        '
        Me.cmb_Destino.Control_Siguiente = Nothing
        Me.cmb_Destino.DisplayMember = "display"
        Me.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Destino.FormattingEnabled = True
        Me.cmb_Destino.Location = New System.Drawing.Point(56, 11)
        Me.cmb_Destino.MaxDropDownItems = 20
        Me.cmb_Destino.Name = "cmb_Destino"
        Me.cmb_Destino.Size = New System.Drawing.Size(160, 21)
        Me.cmb_Destino.TabIndex = 1
        Me.cmb_Destino.ValueMember = "value"
        '
        'chk_DestinoTodos
        '
        Me.chk_DestinoTodos.AutoSize = True
        Me.chk_DestinoTodos.Location = New System.Drawing.Point(228, 18)
        Me.chk_DestinoTodos.Name = "chk_DestinoTodos"
        Me.chk_DestinoTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_DestinoTodos.TabIndex = 2
        Me.chk_DestinoTodos.Text = "Todos"
        Me.chk_DestinoTodos.UseVisualStyleBackColor = True
        Me.chk_DestinoTodos.Visible = False
        '
        'tab_LotesRecibidos
        '
        Me.tab_LotesRecibidos.Controls.Add(Me.tlp_LotesRecibidos)
        Me.tab_LotesRecibidos.Location = New System.Drawing.Point(4, 22)
        Me.tab_LotesRecibidos.Name = "tab_LotesRecibidos"
        Me.tab_LotesRecibidos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_LotesRecibidos.Size = New System.Drawing.Size(753, 372)
        Me.tab_LotesRecibidos.TabIndex = 1
        Me.tab_LotesRecibidos.Text = "Lotes Recibidos"
        Me.tab_LotesRecibidos.UseVisualStyleBackColor = True
        '
        'tlp_LotesRecibidos
        '
        Me.tlp_LotesRecibidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_LotesRecibidos.ColumnCount = 1
        Me.tlp_LotesRecibidos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_LotesRecibidos.Controls.Add(Me.gbx_EfectivoRD, 0, 1)
        Me.tlp_LotesRecibidos.Controls.Add(Me.gbx_EfectivoR, 0, 0)
        Me.tlp_LotesRecibidos.Location = New System.Drawing.Point(6, 6)
        Me.tlp_LotesRecibidos.Name = "tlp_LotesRecibidos"
        Me.tlp_LotesRecibidos.RowCount = 2
        Me.tlp_LotesRecibidos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.25!))
        Me.tlp_LotesRecibidos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.75!))
        Me.tlp_LotesRecibidos.Size = New System.Drawing.Size(741, 360)
        Me.tlp_LotesRecibidos.TabIndex = 1
        '
        'gbx_EfectivoRD
        '
        Me.gbx_EfectivoRD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoRD.Controls.Add(Me.lbl_RegistrosLotesRD)
        Me.gbx_EfectivoRD.Controls.Add(Me.lsv_EfectivoRD)
        Me.gbx_EfectivoRD.Location = New System.Drawing.Point(3, 212)
        Me.gbx_EfectivoRD.Name = "gbx_EfectivoRD"
        Me.gbx_EfectivoRD.Size = New System.Drawing.Size(735, 145)
        Me.gbx_EfectivoRD.TabIndex = 1
        Me.gbx_EfectivoRD.TabStop = False
        '
        'lbl_RegistrosLotesRD
        '
        Me.lbl_RegistrosLotesRD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosLotesRD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosLotesRD.Location = New System.Drawing.Point(552, 8)
        Me.lbl_RegistrosLotesRD.Name = "lbl_RegistrosLotesRD"
        Me.lbl_RegistrosLotesRD.Size = New System.Drawing.Size(177, 23)
        Me.lbl_RegistrosLotesRD.TabIndex = 50
        Me.lbl_RegistrosLotesRD.Text = "Registros: 0"
        Me.lbl_RegistrosLotesRD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_EfectivoRD
        '
        Me.lsv_EfectivoRD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EfectivoRD.FullRowSelect = True
        Me.lsv_EfectivoRD.HideSelection = False
        Me.lsv_EfectivoRD.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_EfectivoRD.Lvs = ListViewColumnSorter3
        Me.lsv_EfectivoRD.MultiSelect = False
        Me.lsv_EfectivoRD.Name = "lsv_EfectivoRD"
        Me.lsv_EfectivoRD.Row1 = 10
        Me.lsv_EfectivoRD.Row10 = 0
        Me.lsv_EfectivoRD.Row2 = 10
        Me.lsv_EfectivoRD.Row3 = 10
        Me.lsv_EfectivoRD.Row4 = 10
        Me.lsv_EfectivoRD.Row5 = 10
        Me.lsv_EfectivoRD.Row6 = 10
        Me.lsv_EfectivoRD.Row7 = 10
        Me.lsv_EfectivoRD.Row8 = 0
        Me.lsv_EfectivoRD.Row9 = 10
        Me.lsv_EfectivoRD.Size = New System.Drawing.Size(723, 103)
        Me.lsv_EfectivoRD.TabIndex = 49
        Me.lsv_EfectivoRD.UseCompatibleStateImageBehavior = False
        Me.lsv_EfectivoRD.View = System.Windows.Forms.View.Details
        '
        'gbx_EfectivoR
        '
        Me.gbx_EfectivoR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoR.Controls.Add(Me.btn_MostrarLotesRecibidos)
        Me.gbx_EfectivoR.Controls.Add(Me.lbl_Origen)
        Me.gbx_EfectivoR.Controls.Add(Me.cmb_Origen)
        Me.gbx_EfectivoR.Controls.Add(Me.chk_OrigenTodos)
        Me.gbx_EfectivoR.Controls.Add(Me.lsv_EfectivoR)
        Me.gbx_EfectivoR.Controls.Add(Me.lbl_RegistrosLotesR)
        Me.gbx_EfectivoR.Location = New System.Drawing.Point(3, 3)
        Me.gbx_EfectivoR.Name = "gbx_EfectivoR"
        Me.gbx_EfectivoR.Size = New System.Drawing.Size(735, 203)
        Me.gbx_EfectivoR.TabIndex = 0
        Me.gbx_EfectivoR.TabStop = False
        '
        'btn_MostrarLotesRecibidos
        '
        Me.btn_MostrarLotesRecibidos.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarLotesRecibidos.Location = New System.Drawing.Point(275, 10)
        Me.btn_MostrarLotesRecibidos.Name = "btn_MostrarLotesRecibidos"
        Me.btn_MostrarLotesRecibidos.Size = New System.Drawing.Size(140, 30)
        Me.btn_MostrarLotesRecibidos.TabIndex = 94
        Me.btn_MostrarLotesRecibidos.Text = "&Mostrar"
        Me.btn_MostrarLotesRecibidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarLotesRecibidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarLotesRecibidos.UseVisualStyleBackColor = True
        '
        'lbl_Origen
        '
        Me.lbl_Origen.AutoSize = True
        Me.lbl_Origen.Location = New System.Drawing.Point(8, 13)
        Me.lbl_Origen.Name = "lbl_Origen"
        Me.lbl_Origen.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Origen.TabIndex = 97
        Me.lbl_Origen.Text = "Origen"
        '
        'cmb_Origen
        '
        Me.cmb_Origen.Control_Siguiente = Nothing
        Me.cmb_Origen.DisplayMember = "display"
        Me.cmb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Origen.FormattingEnabled = True
        Me.cmb_Origen.Location = New System.Drawing.Point(52, 10)
        Me.cmb_Origen.MaxDropDownItems = 20
        Me.cmb_Origen.Name = "cmb_Origen"
        Me.cmb_Origen.Size = New System.Drawing.Size(160, 21)
        Me.cmb_Origen.TabIndex = 96
        Me.cmb_Origen.ValueMember = "value"
        '
        'chk_OrigenTodos
        '
        Me.chk_OrigenTodos.AutoSize = True
        Me.chk_OrigenTodos.Location = New System.Drawing.Point(216, 14)
        Me.chk_OrigenTodos.Name = "chk_OrigenTodos"
        Me.chk_OrigenTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_OrigenTodos.TabIndex = 95
        Me.chk_OrigenTodos.Text = "Todos"
        Me.chk_OrigenTodos.UseVisualStyleBackColor = True
        Me.chk_OrigenTodos.Visible = False
        '
        'lsv_EfectivoR
        '
        Me.lsv_EfectivoR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EfectivoR.AutoArrange = False
        Me.lsv_EfectivoR.FullRowSelect = True
        Me.lsv_EfectivoR.HideSelection = False
        Me.lsv_EfectivoR.Location = New System.Drawing.Point(6, 46)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_EfectivoR.Lvs = ListViewColumnSorter4
        Me.lsv_EfectivoR.MultiSelect = False
        Me.lsv_EfectivoR.Name = "lsv_EfectivoR"
        Me.lsv_EfectivoR.Row1 = 7
        Me.lsv_EfectivoR.Row10 = 7
        Me.lsv_EfectivoR.Row2 = 15
        Me.lsv_EfectivoR.Row3 = 14
        Me.lsv_EfectivoR.Row4 = 10
        Me.lsv_EfectivoR.Row5 = 14
        Me.lsv_EfectivoR.Row6 = 8
        Me.lsv_EfectivoR.Row7 = 8
        Me.lsv_EfectivoR.Row8 = 8
        Me.lsv_EfectivoR.Row9 = 8
        Me.lsv_EfectivoR.Size = New System.Drawing.Size(720, 148)
        Me.lsv_EfectivoR.TabIndex = 50
        Me.lsv_EfectivoR.UseCompatibleStateImageBehavior = False
        Me.lsv_EfectivoR.View = System.Windows.Forms.View.Details
        '
        'lbl_RegistrosLotesR
        '
        Me.lbl_RegistrosLotesR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosLotesR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosLotesR.Location = New System.Drawing.Point(558, 11)
        Me.lbl_RegistrosLotesR.Name = "lbl_RegistrosLotesR"
        Me.lbl_RegistrosLotesR.Size = New System.Drawing.Size(177, 23)
        Me.lbl_RegistrosLotesR.TabIndex = 49
        Me.lbl_RegistrosLotesR.Text = "Registros: 0"
        Me.lbl_RegistrosLotesR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(5, 509)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(773, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Lotes
        '
        Me.gbx_Lotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lotes.Controls.Add(Me.tab_Lotes)
        Me.gbx_Lotes.Location = New System.Drawing.Point(5, 80)
        Me.gbx_Lotes.Name = "gbx_Lotes"
        Me.gbx_Lotes.Size = New System.Drawing.Size(773, 423)
        Me.gbx_Lotes.TabIndex = 1
        Me.gbx_Lotes.TabStop = False
        '
        'gbx_filtro
        '
        Me.gbx_filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_filtro.Controls.Add(Me.chk_CajaTodos)
        Me.gbx_filtro.Controls.Add(Me.dtp_Hasta)
        Me.gbx_filtro.Controls.Add(Me.dtp_Desde)
        Me.gbx_filtro.Controls.Add(Me.lbl_Desde)
        Me.gbx_filtro.Controls.Add(Me.lbl_Hasta)
        Me.gbx_filtro.Controls.Add(Me.lbl_Caja)
        Me.gbx_filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_filtro.Location = New System.Drawing.Point(5, 3)
        Me.gbx_filtro.Name = "gbx_filtro"
        Me.gbx_filtro.Size = New System.Drawing.Size(773, 71)
        Me.gbx_filtro.TabIndex = 0
        Me.gbx_filtro.TabStop = False
        '
        'chk_CajaTodos
        '
        Me.chk_CajaTodos.AutoSize = True
        Me.chk_CajaTodos.Location = New System.Drawing.Point(460, 41)
        Me.chk_CajaTodos.Name = "chk_CajaTodos"
        Me.chk_CajaTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_CajaTodos.TabIndex = 7
        Me.chk_CajaTodos.Text = "Todos"
        Me.chk_CajaTodos.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Hasta.Location = New System.Drawing.Point(221, 16)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Desde.Location = New System.Drawing.Point(54, 15)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(10, 18)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(180, 20)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_Caja
        '
        Me.lbl_Caja.AutoSize = True
        Me.lbl_Caja.Location = New System.Drawing.Point(20, 42)
        Me.lbl_Caja.Name = "lbl_Caja"
        Me.lbl_Caja.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Caja.TabIndex = 4
        Me.lbl_Caja.Text = "Caja"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = ""
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(54, 39)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 6
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "id_CajaBancaria"
        '
        'frm_LotesEfectivo_Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_filtro)
        Me.Controls.Add(Me.gbx_Lotes)
        Me.Controls.Add(Me.gbx_Controles)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_LotesEfectivo_Consultar"
        Me.Text = "Reporte de Lotes de Efectivo"
        Me.tab_Lotes.ResumeLayout(False)
        Me.tab_LotesEnviados.ResumeLayout(False)
        Me.tlp_LotesEnviados.ResumeLayout(False)
        Me.gbx_EfectivoED.ResumeLayout(False)
        Me.gbx_EfectivoE.ResumeLayout(False)
        Me.gbx_EfectivoE.PerformLayout()
        Me.tab_LotesRecibidos.ResumeLayout(False)
        Me.tlp_LotesRecibidos.ResumeLayout(False)
        Me.gbx_EfectivoRD.ResumeLayout(False)
        Me.gbx_EfectivoR.ResumeLayout(False)
        Me.gbx_EfectivoR.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Lotes.ResumeLayout(False)
        Me.gbx_filtro.ResumeLayout(False)
        Me.gbx_filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_Lotes As System.Windows.Forms.TabControl
    Friend WithEvents tab_LotesEnviados As System.Windows.Forms.TabPage
    Friend WithEvents tab_LotesRecibidos As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Lotes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_filtro As System.Windows.Forms.GroupBox
    Friend WithEvents btn_MostrarLotesEnviados As System.Windows.Forms.Button
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents chk_DestinoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents cmb_Destino As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents tlp_LotesEnviados As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbx_EfectivoE As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_EfectivoED As System.Windows.Forms.GroupBox
    Friend WithEvents tlp_LotesRecibidos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbx_EfectivoRD As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_EfectivoR As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_RegistrosLotesE As System.Windows.Forms.Label
    Friend WithEvents lsv_EfectivoE As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_EfectivoED As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_RegistrosLotesED As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosLotesRD As System.Windows.Forms.Label
    Friend WithEvents lsv_EfectivoRD As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_EfectivoR As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_RegistrosLotesR As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents btn_MostrarLotesRecibidos As System.Windows.Forms.Button
    Friend WithEvents lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents cmb_Origen As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents chk_OrigenTodos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CajaTodos As System.Windows.Forms.CheckBox
End Class
