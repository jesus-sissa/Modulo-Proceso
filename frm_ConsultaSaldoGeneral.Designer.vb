<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaSaldoGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ConsultaSaldoGeneral))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.tlp = New System.Windows.Forms.TableLayoutPanel
        Me.gbx_Filtros = New System.Windows.Forms.GroupBox
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.tbx_Total = New Modulo_Proceso.cp_Textbox
        Me.lbl_Presentacion = New System.Windows.Forms.Label
        Me.cmb_Presentacion = New Modulo_Proceso.cp_cmb_Manual
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Tab = New System.Windows.Forms.TabControl
        Me.tab_Saldos = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Proceso.cp_Listview
        Me.tab_Mazos = New System.Windows.Forms.TabPage
        Me.Lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Mazos = New Modulo_Proceso.cp_Listview
        Me.tlp.SuspendLayout()
        Me.gbx_Filtros.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.tab_Saldos.SuspendLayout()
        Me.tab_Mazos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp
        '
        Me.tlp.ColumnCount = 1
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp.Controls.Add(Me.gbx_Filtros, 0, 0)
        Me.tlp.Controls.Add(Me.gbx_Controles, 0, 2)
        Me.tlp.Controls.Add(Me.Tab, 0, 1)
        Me.tlp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp.Location = New System.Drawing.Point(0, 0)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 3
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlp.Size = New System.Drawing.Size(722, 550)
        Me.tlp.TabIndex = 0
        '
        'gbx_Filtros
        '
        Me.gbx_Filtros.Controls.Add(Me.lbl_Total)
        Me.gbx_Filtros.Controls.Add(Me.tbx_Total)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Presentacion)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Presentacion)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Caja)
        Me.gbx_Filtros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Filtros.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Filtros.Name = "gbx_Filtros"
        Me.gbx_Filtros.Size = New System.Drawing.Size(716, 80)
        Me.gbx_Filtros.TabIndex = 0
        Me.gbx_Filtros.TabStop = False
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Location = New System.Drawing.Point(495, 49)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Total.TabIndex = 55
        Me.lbl_Total.Text = "Total"
        '
        'tbx_Total
        '
        Me.tbx_Total.BackColor = System.Drawing.Color.White
        Me.tbx_Total.Control_Siguiente = Nothing
        Me.tbx_Total.Filtrado = True
        Me.tbx_Total.Location = New System.Drawing.Point(532, 46)
        Me.tbx_Total.MaxLength = 10
        Me.tbx_Total.Name = "tbx_Total"
        Me.tbx_Total.ReadOnly = True
        Me.tbx_Total.Size = New System.Drawing.Size(119, 20)
        Me.tbx_Total.TabIndex = 54
        Me.tbx_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Total.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'lbl_Presentacion
        '
        Me.lbl_Presentacion.AutoSize = True
        Me.lbl_Presentacion.Location = New System.Drawing.Point(258, 46)
        Me.lbl_Presentacion.Name = "lbl_Presentacion"
        Me.lbl_Presentacion.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Presentacion.TabIndex = 53
        Me.lbl_Presentacion.Text = "Presentacion"
        '
        'cmb_Presentacion
        '
        Me.cmb_Presentacion.Control_Siguiente = Nothing
        Me.cmb_Presentacion.DisplayMember = "display"
        Me.cmb_Presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Presentacion.FormattingEnabled = True
        Me.cmb_Presentacion.Location = New System.Drawing.Point(333, 43)
        Me.cmb_Presentacion.MaxDropDownItems = 20
        Me.cmb_Presentacion.Name = "cmb_Presentacion"
        Me.cmb_Presentacion.Size = New System.Drawing.Size(117, 21)
        Me.cmb_Presentacion.TabIndex = 52
        Me.cmb_Presentacion.ValueMember = "value"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(38, 46)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 51
        Me.lbl_Moneda.Text = "Moneda"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(90, 43)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(147, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 50
        Me.cmb_Moneda.ValueMember = "id_Moneda"
        '
        'lbl_Caja
        '
        Me.lbl_Caja.AutoSize = True
        Me.lbl_Caja.Location = New System.Drawing.Point(11, 22)
        Me.lbl_Caja.Name = "lbl_Caja"
        Me.lbl_Caja.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Caja.TabIndex = 48
        Me.lbl_Caja.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(90, 19)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 49
        Me.cmb_CajaBancaria.ValueMember = "id_CajaBancaria"
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Controles.Location = New System.Drawing.Point(3, 497)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(716, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.Location = New System.Drawing.Point(567, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 41
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.tab_Saldos)
        Me.Tab.Controls.Add(Me.tab_Mazos)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(3, 89)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(716, 402)
        Me.Tab.TabIndex = 3
        '
        'tab_Saldos
        '
        Me.tab_Saldos.Controls.Add(Me.Lbl_Registros)
        Me.tab_Saldos.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Saldos.Location = New System.Drawing.Point(4, 22)
        Me.tab_Saldos.Name = "tab_Saldos"
        Me.tab_Saldos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Saldos.Size = New System.Drawing.Size(708, 376)
        Me.tab_Saldos.TabIndex = 0
        Me.tab_Saldos.Text = "Saldos"
        Me.tab_Saldos.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(547, 3)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(155, 23)
        Me.Lbl_Registros.TabIndex = 50
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 29)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 10
        Me.lsv_Catalogo.Row2 = 10
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 10
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 10
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 10
        Me.lsv_Catalogo.Size = New System.Drawing.Size(702, 344)
        Me.lsv_Catalogo.TabIndex = 1
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tab_Mazos
        '
        Me.tab_Mazos.Controls.Add(Me.Lbl_Registros2)
        Me.tab_Mazos.Controls.Add(Me.lsv_Mazos)
        Me.tab_Mazos.Location = New System.Drawing.Point(4, 22)
        Me.tab_Mazos.Name = "tab_Mazos"
        Me.tab_Mazos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Mazos.Size = New System.Drawing.Size(708, 376)
        Me.tab_Mazos.TabIndex = 1
        Me.tab_Mazos.Text = "Mazos y Bolsas"
        Me.tab_Mazos.UseVisualStyleBackColor = True
        '
        'Lbl_Registros2
        '
        Me.Lbl_Registros2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros2.Location = New System.Drawing.Point(547, 3)
        Me.Lbl_Registros2.Name = "Lbl_Registros2"
        Me.Lbl_Registros2.Size = New System.Drawing.Size(155, 23)
        Me.Lbl_Registros2.TabIndex = 50
        Me.Lbl_Registros2.Text = "Registros: 0"
        Me.Lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Mazos
        '
        Me.lsv_Mazos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Mazos.FullRowSelect = True
        Me.lsv_Mazos.HideSelection = False
        Me.lsv_Mazos.Location = New System.Drawing.Point(3, 29)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Mazos.Lvs = ListViewColumnSorter2
        Me.lsv_Mazos.MultiSelect = False
        Me.lsv_Mazos.Name = "lsv_Mazos"
        Me.lsv_Mazos.Row1 = 10
        Me.lsv_Mazos.Row10 = 10
        Me.lsv_Mazos.Row2 = 10
        Me.lsv_Mazos.Row3 = 10
        Me.lsv_Mazos.Row4 = 10
        Me.lsv_Mazos.Row5 = 10
        Me.lsv_Mazos.Row6 = 10
        Me.lsv_Mazos.Row7 = 10
        Me.lsv_Mazos.Row8 = 10
        Me.lsv_Mazos.Row9 = 10
        Me.lsv_Mazos.Size = New System.Drawing.Size(702, 344)
        Me.lsv_Mazos.TabIndex = 1
        Me.lsv_Mazos.UseCompatibleStateImageBehavior = False
        Me.lsv_Mazos.View = System.Windows.Forms.View.Details
        '
        'frm_ConsultaSaldoGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 550)
        Me.Controls.Add(Me.tlp)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_ConsultaSaldoGeneral"
        Me.Text = "Consulta de Saldo General"
        Me.tlp.ResumeLayout(False)
        Me.gbx_Filtros.ResumeLayout(False)
        Me.gbx_Filtros.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.Tab.ResumeLayout(False)
        Me.tab_Saldos.ResumeLayout(False)
        Me.tab_Mazos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlp As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbx_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Presentacion As System.Windows.Forms.Label
    Friend WithEvents cmb_Presentacion As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents tbx_Total As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents tab_Saldos As System.Windows.Forms.TabPage
    Friend WithEvents tab_Mazos As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Catalogo As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_Mazos As Modulo_Proceso.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros2 As System.Windows.Forms.Label
End Class
