<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaSaldosProc
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
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter5 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter6 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter7 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter8 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter9 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter10 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Moneda = New System.Windows.Forms.GroupBox
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.gbx_Billetes = New System.Windows.Forms.GroupBox
        Me.tbx_TotalB = New System.Windows.Forms.TextBox
        Me.lbl_TotalB = New System.Windows.Forms.Label
        Me.lsv_Billetes = New Modulo_Proceso.cp_Listview
        Me.gbx_Monedas = New System.Windows.Forms.GroupBox
        Me.tbx_TotalM = New System.Windows.Forms.TextBox
        Me.lbl_TotalM = New System.Windows.Forms.Label
        Me.lsv_Monedas = New Modulo_Proceso.cp_Listview
        Me.gbx_Total = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.tbx_TotSaldoM = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lsv_SaldoMonedas = New Modulo_Proceso.cp_Listview
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.tbx_TotSaldoB = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lsv_SaldoBilletes = New Modulo_Proceso.cp_Listview
        Me.Tab_Principal = New System.Windows.Forms.TabControl
        Me.tab_Verificado = New System.Windows.Forms.TabPage
        Me.Tab_Enviado = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tbx_TotBillCla = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lsv_BillCla = New Modulo_Proceso.cp_Listview
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbx_TotMonPro = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lsv_MonPro = New Modulo_Proceso.cp_Listview
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbx_TotBillPro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lsv_BillPro = New Modulo_Proceso.cp_Listview
        Me.gbx_TotEnviado = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cp_Listview1 = New Modulo_Proceso.cp_Listview
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Cp_Listview2 = New Modulo_Proceso.cp_Listview
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Cp_Listview3 = New Modulo_Proceso.cp_Listview
        Me.gbx_Moneda.SuspendLayout()
        Me.gbx_Billetes.SuspendLayout()
        Me.gbx_Monedas.SuspendLayout()
        Me.gbx_Total.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Tab_Principal.SuspendLayout()
        Me.tab_Verificado.SuspendLayout()
        Me.Tab_Enviado.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Moneda
        '
        Me.gbx_Moneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Moneda.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Moneda.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Moneda.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Moneda.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Moneda.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Moneda.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Moneda.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Moneda.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Moneda.Name = "gbx_Moneda"
        Me.gbx_Moneda.Size = New System.Drawing.Size(798, 109)
        Me.gbx_Moneda.TabIndex = 0
        Me.gbx_Moneda.TabStop = False
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Nothing
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Nothing
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.Location = New System.Drawing.Point(98, 46)
        Me.cmb_Cajero.MaxDropDownItems = 15
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 3
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(6, 49)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(90, 13)
        Me.lbl_Cajero.TabIndex = 2
        Me.lbl_Cajero.Text = "Cajero Verificador"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(358, 73)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 6
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(24, 24)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Me.cmb_Moneda
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(98, 19)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 1
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
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
        Me.cmb_Moneda.Location = New System.Drawing.Point(98, 73)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 5
        Me.cmb_Moneda.Tipo = 0
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(46, 76)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 4
        Me.lbl_Moneda.Text = "Moneda"
        '
        'gbx_Billetes
        '
        Me.gbx_Billetes.Controls.Add(Me.tbx_TotalB)
        Me.gbx_Billetes.Controls.Add(Me.lbl_TotalB)
        Me.gbx_Billetes.Controls.Add(Me.lsv_Billetes)
        Me.gbx_Billetes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Billetes.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Billetes.Name = "gbx_Billetes"
        Me.gbx_Billetes.Size = New System.Drawing.Size(375, 186)
        Me.gbx_Billetes.TabIndex = 0
        Me.gbx_Billetes.TabStop = False
        Me.gbx_Billetes.Text = "Billetes Verificados"
        '
        'tbx_TotalB
        '
        Me.tbx_TotalB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotalB.BackColor = System.Drawing.Color.White
        Me.tbx_TotalB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalB.Location = New System.Drawing.Point(249, 160)
        Me.tbx_TotalB.Name = "tbx_TotalB"
        Me.tbx_TotalB.ReadOnly = True
        Me.tbx_TotalB.Size = New System.Drawing.Size(120, 20)
        Me.tbx_TotalB.TabIndex = 2
        Me.tbx_TotalB.TabStop = False
        Me.tbx_TotalB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_TotalB
        '
        Me.lbl_TotalB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalB.AutoSize = True
        Me.lbl_TotalB.Location = New System.Drawing.Point(212, 163)
        Me.lbl_TotalB.Name = "lbl_TotalB"
        Me.lbl_TotalB.Size = New System.Drawing.Size(31, 13)
        Me.lbl_TotalB.TabIndex = 1
        Me.lbl_TotalB.Text = "Total"
        '
        'lsv_Billetes
        '
        Me.lsv_Billetes.AllowColumnReorder = True
        Me.lsv_Billetes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Billetes.FullRowSelect = True
        Me.lsv_Billetes.HideSelection = False
        Me.lsv_Billetes.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Billetes.Lvs = ListViewColumnSorter1
        Me.lsv_Billetes.MultiSelect = False
        Me.lsv_Billetes.Name = "lsv_Billetes"
        Me.lsv_Billetes.Row1 = 30
        Me.lsv_Billetes.Row10 = 0
        Me.lsv_Billetes.Row2 = 30
        Me.lsv_Billetes.Row3 = 30
        Me.lsv_Billetes.Row4 = 0
        Me.lsv_Billetes.Row5 = 0
        Me.lsv_Billetes.Row6 = 0
        Me.lsv_Billetes.Row7 = 0
        Me.lsv_Billetes.Row8 = 0
        Me.lsv_Billetes.Row9 = 0
        Me.lsv_Billetes.Size = New System.Drawing.Size(363, 137)
        Me.lsv_Billetes.TabIndex = 0
        Me.lsv_Billetes.UseCompatibleStateImageBehavior = False
        Me.lsv_Billetes.View = System.Windows.Forms.View.Details
        '
        'gbx_Monedas
        '
        Me.gbx_Monedas.Controls.Add(Me.tbx_TotalM)
        Me.gbx_Monedas.Controls.Add(Me.lbl_TotalM)
        Me.gbx_Monedas.Controls.Add(Me.lsv_Monedas)
        Me.gbx_Monedas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Monedas.Location = New System.Drawing.Point(384, 3)
        Me.gbx_Monedas.Name = "gbx_Monedas"
        Me.gbx_Monedas.Size = New System.Drawing.Size(391, 186)
        Me.gbx_Monedas.TabIndex = 1
        Me.gbx_Monedas.TabStop = False
        Me.gbx_Monedas.Text = "Monedas Verficadas"
        '
        'tbx_TotalM
        '
        Me.tbx_TotalM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotalM.BackColor = System.Drawing.Color.White
        Me.tbx_TotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalM.Location = New System.Drawing.Point(265, 160)
        Me.tbx_TotalM.Name = "tbx_TotalM"
        Me.tbx_TotalM.ReadOnly = True
        Me.tbx_TotalM.Size = New System.Drawing.Size(120, 20)
        Me.tbx_TotalM.TabIndex = 2
        Me.tbx_TotalM.TabStop = False
        Me.tbx_TotalM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_TotalM
        '
        Me.lbl_TotalM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalM.AutoSize = True
        Me.lbl_TotalM.Location = New System.Drawing.Point(228, 163)
        Me.lbl_TotalM.Name = "lbl_TotalM"
        Me.lbl_TotalM.Size = New System.Drawing.Size(31, 13)
        Me.lbl_TotalM.TabIndex = 1
        Me.lbl_TotalM.Text = "Total"
        '
        'lsv_Monedas
        '
        Me.lsv_Monedas.AllowColumnReorder = True
        Me.lsv_Monedas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Monedas.FullRowSelect = True
        Me.lsv_Monedas.HideSelection = False
        Me.lsv_Monedas.Location = New System.Drawing.Point(7, 17)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Monedas.Lvs = ListViewColumnSorter2
        Me.lsv_Monedas.MultiSelect = False
        Me.lsv_Monedas.Name = "lsv_Monedas"
        Me.lsv_Monedas.Row1 = 30
        Me.lsv_Monedas.Row10 = 0
        Me.lsv_Monedas.Row2 = 30
        Me.lsv_Monedas.Row3 = 30
        Me.lsv_Monedas.Row4 = 0
        Me.lsv_Monedas.Row5 = 0
        Me.lsv_Monedas.Row6 = 0
        Me.lsv_Monedas.Row7 = 0
        Me.lsv_Monedas.Row8 = 0
        Me.lsv_Monedas.Row9 = 0
        Me.lsv_Monedas.Size = New System.Drawing.Size(378, 137)
        Me.lsv_Monedas.TabIndex = 0
        Me.lsv_Monedas.UseCompatibleStateImageBehavior = False
        Me.lsv_Monedas.View = System.Windows.Forms.View.Details
        '
        'gbx_Total
        '
        Me.gbx_Total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Total.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Total.Location = New System.Drawing.Point(8, 546)
        Me.gbx_Total.Name = "gbx_Total"
        Me.gbx_Total.Size = New System.Drawing.Size(798, 50)
        Me.gbx_Total.TabIndex = 1
        Me.gbx_Total.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(652, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01234!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98766!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbx_Monedas, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbx_Billetes, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(778, 385)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbx_TotSaldoM)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.lsv_SaldoMonedas)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(384, 195)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(391, 187)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Saldo Monedas"
        '
        'tbx_TotSaldoM
        '
        Me.tbx_TotSaldoM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotSaldoM.BackColor = System.Drawing.Color.White
        Me.tbx_TotSaldoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotSaldoM.Location = New System.Drawing.Point(265, 161)
        Me.tbx_TotSaldoM.Name = "tbx_TotSaldoM"
        Me.tbx_TotSaldoM.ReadOnly = True
        Me.tbx_TotSaldoM.Size = New System.Drawing.Size(120, 20)
        Me.tbx_TotSaldoM.TabIndex = 2
        Me.tbx_TotSaldoM.TabStop = False
        Me.tbx_TotSaldoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(228, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total"
        '
        'lsv_SaldoMonedas
        '
        Me.lsv_SaldoMonedas.AllowColumnReorder = True
        Me.lsv_SaldoMonedas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_SaldoMonedas.FullRowSelect = True
        Me.lsv_SaldoMonedas.HideSelection = False
        Me.lsv_SaldoMonedas.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_SaldoMonedas.Lvs = ListViewColumnSorter3
        Me.lsv_SaldoMonedas.MultiSelect = False
        Me.lsv_SaldoMonedas.Name = "lsv_SaldoMonedas"
        Me.lsv_SaldoMonedas.Row1 = 30
        Me.lsv_SaldoMonedas.Row10 = 0
        Me.lsv_SaldoMonedas.Row2 = 30
        Me.lsv_SaldoMonedas.Row3 = 30
        Me.lsv_SaldoMonedas.Row4 = 0
        Me.lsv_SaldoMonedas.Row5 = 0
        Me.lsv_SaldoMonedas.Row6 = 0
        Me.lsv_SaldoMonedas.Row7 = 0
        Me.lsv_SaldoMonedas.Row8 = 0
        Me.lsv_SaldoMonedas.Row9 = 0
        Me.lsv_SaldoMonedas.Size = New System.Drawing.Size(379, 138)
        Me.lsv_SaldoMonedas.TabIndex = 0
        Me.lsv_SaldoMonedas.UseCompatibleStateImageBehavior = False
        Me.lsv_SaldoMonedas.View = System.Windows.Forms.View.Details
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbx_TotSaldoB)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lsv_SaldoBilletes)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 195)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 187)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Saldo Billetes"
        '
        'tbx_TotSaldoB
        '
        Me.tbx_TotSaldoB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotSaldoB.BackColor = System.Drawing.Color.White
        Me.tbx_TotSaldoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotSaldoB.Location = New System.Drawing.Point(249, 161)
        Me.tbx_TotSaldoB.Name = "tbx_TotSaldoB"
        Me.tbx_TotSaldoB.ReadOnly = True
        Me.tbx_TotSaldoB.Size = New System.Drawing.Size(120, 20)
        Me.tbx_TotSaldoB.TabIndex = 2
        Me.tbx_TotSaldoB.TabStop = False
        Me.tbx_TotSaldoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total"
        '
        'lsv_SaldoBilletes
        '
        Me.lsv_SaldoBilletes.AllowColumnReorder = True
        Me.lsv_SaldoBilletes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_SaldoBilletes.FullRowSelect = True
        Me.lsv_SaldoBilletes.HideSelection = False
        Me.lsv_SaldoBilletes.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_SaldoBilletes.Lvs = ListViewColumnSorter4
        Me.lsv_SaldoBilletes.MultiSelect = False
        Me.lsv_SaldoBilletes.Name = "lsv_SaldoBilletes"
        Me.lsv_SaldoBilletes.Row1 = 30
        Me.lsv_SaldoBilletes.Row10 = 0
        Me.lsv_SaldoBilletes.Row2 = 30
        Me.lsv_SaldoBilletes.Row3 = 30
        Me.lsv_SaldoBilletes.Row4 = 0
        Me.lsv_SaldoBilletes.Row5 = 0
        Me.lsv_SaldoBilletes.Row6 = 0
        Me.lsv_SaldoBilletes.Row7 = 0
        Me.lsv_SaldoBilletes.Row8 = 0
        Me.lsv_SaldoBilletes.Row9 = 0
        Me.lsv_SaldoBilletes.Size = New System.Drawing.Size(363, 138)
        Me.lsv_SaldoBilletes.TabIndex = 0
        Me.lsv_SaldoBilletes.UseCompatibleStateImageBehavior = False
        Me.lsv_SaldoBilletes.View = System.Windows.Forms.View.Details
        '
        'Tab_Principal
        '
        Me.Tab_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Principal.Controls.Add(Me.tab_Verificado)
        Me.Tab_Principal.Controls.Add(Me.Tab_Enviado)
        Me.Tab_Principal.Location = New System.Drawing.Point(8, 117)
        Me.Tab_Principal.Name = "Tab_Principal"
        Me.Tab_Principal.SelectedIndex = 0
        Me.Tab_Principal.Size = New System.Drawing.Size(798, 423)
        Me.Tab_Principal.TabIndex = 1
        '
        'tab_Verificado
        '
        Me.tab_Verificado.Controls.Add(Me.TableLayoutPanel1)
        Me.tab_Verificado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Verificado.Name = "tab_Verificado"
        Me.tab_Verificado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Verificado.Size = New System.Drawing.Size(790, 397)
        Me.tab_Verificado.TabIndex = 0
        Me.tab_Verificado.Text = "Verificado"
        Me.tab_Verificado.UseVisualStyleBackColor = True
        '
        'Tab_Enviado
        '
        Me.Tab_Enviado.Controls.Add(Me.TableLayoutPanel2)
        Me.Tab_Enviado.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Enviado.Name = "Tab_Enviado"
        Me.Tab_Enviado.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Enviado.Size = New System.Drawing.Size(790, 397)
        Me.Tab_Enviado.TabIndex = 1
        Me.Tab_Enviado.Text = "Enviado"
        Me.Tab_Enviado.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.gbx_TotEnviado, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(784, 391)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbx_TotBillCla)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lsv_BillCla)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(386, 190)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Billetes Enviados a Clasificado"
        '
        'tbx_TotBillCla
        '
        Me.tbx_TotBillCla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotBillCla.BackColor = System.Drawing.Color.White
        Me.tbx_TotBillCla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotBillCla.Location = New System.Drawing.Point(260, 164)
        Me.tbx_TotBillCla.Name = "tbx_TotBillCla"
        Me.tbx_TotBillCla.ReadOnly = True
        Me.tbx_TotBillCla.Size = New System.Drawing.Size(120, 20)
        Me.tbx_TotBillCla.TabIndex = 2
        Me.tbx_TotBillCla.TabStop = False
        Me.tbx_TotBillCla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total"
        '
        'lsv_BillCla
        '
        Me.lsv_BillCla.AllowColumnReorder = True
        Me.lsv_BillCla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_BillCla.FullRowSelect = True
        Me.lsv_BillCla.HideSelection = False
        Me.lsv_BillCla.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_BillCla.Lvs = ListViewColumnSorter5
        Me.lsv_BillCla.MultiSelect = False
        Me.lsv_BillCla.Name = "lsv_BillCla"
        Me.lsv_BillCla.Row1 = 30
        Me.lsv_BillCla.Row10 = 0
        Me.lsv_BillCla.Row2 = 30
        Me.lsv_BillCla.Row3 = 30
        Me.lsv_BillCla.Row4 = 0
        Me.lsv_BillCla.Row5 = 0
        Me.lsv_BillCla.Row6 = 0
        Me.lsv_BillCla.Row7 = 0
        Me.lsv_BillCla.Row8 = 0
        Me.lsv_BillCla.Row9 = 0
        Me.lsv_BillCla.Size = New System.Drawing.Size(374, 141)
        Me.lsv_BillCla.TabIndex = 0
        Me.lsv_BillCla.UseCompatibleStateImageBehavior = False
        Me.lsv_BillCla.View = System.Windows.Forms.View.Details
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbx_TotMonPro)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lsv_MonPro)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(395, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 189)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monedas Enviadas a Proceso"
        '
        'tbx_TotMonPro
        '
        Me.tbx_TotMonPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotMonPro.BackColor = System.Drawing.Color.White
        Me.tbx_TotMonPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotMonPro.Location = New System.Drawing.Point(260, 163)
        Me.tbx_TotMonPro.Name = "tbx_TotMonPro"
        Me.tbx_TotMonPro.ReadOnly = True
        Me.tbx_TotMonPro.Size = New System.Drawing.Size(120, 20)
        Me.tbx_TotMonPro.TabIndex = 2
        Me.tbx_TotMonPro.TabStop = False
        Me.tbx_TotMonPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total"
        '
        'lsv_MonPro
        '
        Me.lsv_MonPro.AllowColumnReorder = True
        Me.lsv_MonPro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_MonPro.FullRowSelect = True
        Me.lsv_MonPro.HideSelection = False
        Me.lsv_MonPro.Location = New System.Drawing.Point(7, 17)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.lsv_MonPro.Lvs = ListViewColumnSorter6
        Me.lsv_MonPro.MultiSelect = False
        Me.lsv_MonPro.Name = "lsv_MonPro"
        Me.lsv_MonPro.Row1 = 30
        Me.lsv_MonPro.Row10 = 0
        Me.lsv_MonPro.Row2 = 30
        Me.lsv_MonPro.Row3 = 30
        Me.lsv_MonPro.Row4 = 0
        Me.lsv_MonPro.Row5 = 0
        Me.lsv_MonPro.Row6 = 0
        Me.lsv_MonPro.Row7 = 0
        Me.lsv_MonPro.Row8 = 0
        Me.lsv_MonPro.Row9 = 0
        Me.lsv_MonPro.Size = New System.Drawing.Size(373, 140)
        Me.lsv_MonPro.TabIndex = 0
        Me.lsv_MonPro.UseCompatibleStateImageBehavior = False
        Me.lsv_MonPro.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbx_TotBillPro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lsv_BillPro)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 189)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billetes Enviados a Proceso"
        '
        'tbx_TotBillPro
        '
        Me.tbx_TotBillPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotBillPro.BackColor = System.Drawing.Color.White
        Me.tbx_TotBillPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotBillPro.Location = New System.Drawing.Point(260, 163)
        Me.tbx_TotBillPro.Name = "tbx_TotBillPro"
        Me.tbx_TotBillPro.ReadOnly = True
        Me.tbx_TotBillPro.Size = New System.Drawing.Size(120, 20)
        Me.tbx_TotBillPro.TabIndex = 2
        Me.tbx_TotBillPro.TabStop = False
        Me.tbx_TotBillPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total"
        '
        'lsv_BillPro
        '
        Me.lsv_BillPro.AllowColumnReorder = True
        Me.lsv_BillPro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_BillPro.FullRowSelect = True
        Me.lsv_BillPro.HideSelection = False
        Me.lsv_BillPro.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.lsv_BillPro.Lvs = ListViewColumnSorter7
        Me.lsv_BillPro.MultiSelect = False
        Me.lsv_BillPro.Name = "lsv_BillPro"
        Me.lsv_BillPro.Row1 = 30
        Me.lsv_BillPro.Row10 = 0
        Me.lsv_BillPro.Row2 = 30
        Me.lsv_BillPro.Row3 = 30
        Me.lsv_BillPro.Row4 = 0
        Me.lsv_BillPro.Row5 = 0
        Me.lsv_BillPro.Row6 = 0
        Me.lsv_BillPro.Row7 = 0
        Me.lsv_BillPro.Row8 = 0
        Me.lsv_BillPro.Row9 = 0
        Me.lsv_BillPro.Size = New System.Drawing.Size(374, 140)
        Me.lsv_BillPro.TabIndex = 0
        Me.lsv_BillPro.UseCompatibleStateImageBehavior = False
        Me.lsv_BillPro.View = System.Windows.Forms.View.Details
        '
        'gbx_TotEnviado
        '
        Me.gbx_TotEnviado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_TotEnviado.Location = New System.Drawing.Point(395, 198)
        Me.gbx_TotEnviado.Name = "gbx_TotEnviado"
        Me.gbx_TotEnviado.Size = New System.Drawing.Size(386, 190)
        Me.gbx_TotEnviado.TabIndex = 4
        Me.gbx_TotEnviado.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox7, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Cp_Listview1)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(3, 23)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(94, 74)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Billetes Enviados a Clasificado"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(78, -88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TabStop = False
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, -85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total"
        '
        'Cp_Listview1
        '
        Me.Cp_Listview1.AllowColumnReorder = True
        Me.Cp_Listview1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cp_Listview1.FullRowSelect = True
        Me.Cp_Listview1.HideSelection = False
        Me.Cp_Listview1.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.Cp_Listview1.Lvs = ListViewColumnSorter8
        Me.Cp_Listview1.MultiSelect = False
        Me.Cp_Listview1.Name = "Cp_Listview1"
        Me.Cp_Listview1.Row1 = 30
        Me.Cp_Listview1.Row10 = 0
        Me.Cp_Listview1.Row2 = 30
        Me.Cp_Listview1.Row3 = 30
        Me.Cp_Listview1.Row4 = 0
        Me.Cp_Listview1.Row5 = 0
        Me.Cp_Listview1.Row6 = 0
        Me.Cp_Listview1.Row7 = 0
        Me.Cp_Listview1.Row8 = 0
        Me.Cp_Listview1.Row9 = 0
        Me.Cp_Listview1.Size = New System.Drawing.Size(192, 0)
        Me.Cp_Listview1.TabIndex = 0
        Me.Cp_Listview1.UseCompatibleStateImageBehavior = False
        Me.Cp_Listview1.View = System.Windows.Forms.View.Details
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Cp_Listview2)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(103, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(94, 14)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Monedas Enviadas a Proceso"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(79, -142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TabStop = False
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, -139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total"
        '
        'Cp_Listview2
        '
        Me.Cp_Listview2.AllowColumnReorder = True
        Me.Cp_Listview2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cp_Listview2.FullRowSelect = True
        Me.Cp_Listview2.HideSelection = False
        Me.Cp_Listview2.Location = New System.Drawing.Point(7, 17)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.Cp_Listview2.Lvs = ListViewColumnSorter9
        Me.Cp_Listview2.MultiSelect = False
        Me.Cp_Listview2.Name = "Cp_Listview2"
        Me.Cp_Listview2.Row1 = 30
        Me.Cp_Listview2.Row10 = 0
        Me.Cp_Listview2.Row2 = 30
        Me.Cp_Listview2.Row3 = 30
        Me.Cp_Listview2.Row4 = 0
        Me.Cp_Listview2.Row5 = 0
        Me.Cp_Listview2.Row6 = 0
        Me.Cp_Listview2.Row7 = 0
        Me.Cp_Listview2.Row8 = 0
        Me.Cp_Listview2.Row9 = 0
        Me.Cp_Listview2.Size = New System.Drawing.Size(192, 0)
        Me.Cp_Listview2.TabIndex = 0
        Me.Cp_Listview2.UseCompatibleStateImageBehavior = False
        Me.Cp_Listview2.View = System.Windows.Forms.View.Details
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBox3)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.Cp_Listview3)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(204, 124)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Billetes Enviados a Proceso"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(78, 98)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(120, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TabStop = False
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total"
        '
        'Cp_Listview3
        '
        Me.Cp_Listview3.AllowColumnReorder = True
        Me.Cp_Listview3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cp_Listview3.FullRowSelect = True
        Me.Cp_Listview3.HideSelection = False
        Me.Cp_Listview3.Location = New System.Drawing.Point(6, 17)
        ListViewColumnSorter10.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter10.SortColumn = 0
        Me.Cp_Listview3.Lvs = ListViewColumnSorter10
        Me.Cp_Listview3.MultiSelect = False
        Me.Cp_Listview3.Name = "Cp_Listview3"
        Me.Cp_Listview3.Row1 = 30
        Me.Cp_Listview3.Row10 = 0
        Me.Cp_Listview3.Row2 = 30
        Me.Cp_Listview3.Row3 = 30
        Me.Cp_Listview3.Row4 = 0
        Me.Cp_Listview3.Row5 = 0
        Me.Cp_Listview3.Row6 = 0
        Me.Cp_Listview3.Row7 = 0
        Me.Cp_Listview3.Row8 = 0
        Me.Cp_Listview3.Row9 = 0
        Me.Cp_Listview3.Size = New System.Drawing.Size(192, 75)
        Me.Cp_Listview3.TabIndex = 0
        Me.Cp_Listview3.UseCompatibleStateImageBehavior = False
        Me.Cp_Listview3.View = System.Windows.Forms.View.Details
        '
        'frm_ConsultaSaldosProc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(814, 611)
        Me.Controls.Add(Me.Tab_Principal)
        Me.Controls.Add(Me.gbx_Moneda)
        Me.Controls.Add(Me.gbx_Total)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(830, 650)
        Me.Name = "frm_ConsultaSaldosProc"
        Me.Text = "Consulta de Saldo"
        Me.gbx_Moneda.ResumeLayout(False)
        Me.gbx_Moneda.PerformLayout()
        Me.gbx_Billetes.ResumeLayout(False)
        Me.gbx_Billetes.PerformLayout()
        Me.gbx_Monedas.ResumeLayout(False)
        Me.gbx_Monedas.PerformLayout()
        Me.gbx_Total.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Tab_Principal.ResumeLayout(False)
        Me.tab_Verificado.ResumeLayout(False)
        Me.Tab_Enviado.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Billetes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Monedas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Total As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_TotalB As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalB As System.Windows.Forms.Label
    Friend WithEvents lsv_Billetes As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_Monedas As Modulo_Proceso.cp_Listview
    Friend WithEvents tbx_TotalM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalM As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Moneda As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Tab_Principal As System.Windows.Forms.TabControl
    Friend WithEvents tab_Verificado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Enviado As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_TotBillCla As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lsv_BillCla As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_TotMonPro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsv_MonPro As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_TotBillPro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsv_BillPro As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_TotSaldoM As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lsv_SaldoMonedas As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_TotSaldoB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lsv_SaldoBilletes As Modulo_Proceso.cp_Listview
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cp_Listview1 As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cp_Listview2 As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cp_Listview3 As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_TotEnviado As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
End Class
