<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReciboServiciosBoveda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReciboServiciosBoveda))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter5 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter6 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Recibir = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbx_Buscar = New Modulo_Proceso.cp_Textbox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lsv_Remisiones = New Modulo_Proceso.cp_Listview
        Me.lsv_DotacionDT = New Modulo_Proceso.cp_Listview
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.tbx_BuscarE = New Modulo_Proceso.cp_Textbox
        Me.ButtonBuscarE = New System.Windows.Forms.Button
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.lsv_EnvasesT = New Modulo_Proceso.cp_Listview
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Cp_Listview1 = New Modulo_Proceso.cp_Listview
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cp_tbx_int_N1 = New Modulo_Proceso.cp_Textbox
        Me.Cp_tbx_int_N2 = New Modulo_Proceso.cp_Textbox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lsv_Datos = New Modulo_Proceso.cp_Listview
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(550, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Recibir
        '
        Me.btn_Recibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recibir.Enabled = False
        Me.btn_Recibir.Image = CType(resources.GetObject("btn_Recibir.Image"), System.Drawing.Image)
        Me.btn_Recibir.Location = New System.Drawing.Point(10, 13)
        Me.btn_Recibir.Name = "btn_Recibir"
        Me.btn_Recibir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibir.TabIndex = 5
        Me.btn_Recibir.Text = "&Recibir"
        Me.btn_Recibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tbx_Buscar)
        Me.GroupBox2.Controls.Add(Me.lsv_Remisiones)
        Me.GroupBox2.Controls.Add(Me.btn_Buscar)
        Me.GroupBox2.Controls.Add(Me.lsv_DotacionDT)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 269)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(6, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(147, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(159, 9)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(82, 25)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "&Buscar"
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.AllowColumnReorder = True
        Me.lsv_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter1
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 15
        Me.lsv_Remisiones.Row10 = 0
        Me.lsv_Remisiones.Row2 = 20
        Me.lsv_Remisiones.Row3 = 20
        Me.lsv_Remisiones.Row4 = 20
        Me.lsv_Remisiones.Row5 = 10
        Me.lsv_Remisiones.Row6 = 10
        Me.lsv_Remisiones.Row7 = 0
        Me.lsv_Remisiones.Row8 = 0
        Me.lsv_Remisiones.Row9 = 0
        Me.lsv_Remisiones.Size = New System.Drawing.Size(431, 127)
        Me.lsv_Remisiones.TabIndex = 42
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'lsv_DotacionDT
        '
        Me.lsv_DotacionDT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionDT.FullRowSelect = True
        Me.lsv_DotacionDT.HideSelection = False
        Me.lsv_DotacionDT.Location = New System.Drawing.Point(6, 173)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_DotacionDT.Lvs = ListViewColumnSorter2
        Me.lsv_DotacionDT.MultiSelect = False
        Me.lsv_DotacionDT.Name = "lsv_DotacionDT"
        Me.lsv_DotacionDT.Row1 = 15
        Me.lsv_DotacionDT.Row10 = 10
        Me.lsv_DotacionDT.Row2 = 15
        Me.lsv_DotacionDT.Row3 = 15
        Me.lsv_DotacionDT.Row4 = 15
        Me.lsv_DotacionDT.Row5 = 15
        Me.lsv_DotacionDT.Row6 = 10
        Me.lsv_DotacionDT.Row7 = 10
        Me.lsv_DotacionDT.Row8 = 10
        Me.lsv_DotacionDT.Row9 = 10
        Me.lsv_DotacionDT.Size = New System.Drawing.Size(431, 90)
        Me.lsv_DotacionDT.TabIndex = 46
        Me.lsv_DotacionDT.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionDT.View = System.Windows.Forms.View.Details
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.tbx_BuscarE)
        Me.GroupBox5.Controls.Add(Me.ButtonBuscarE)
        Me.GroupBox5.Controls.Add(Me.lsv_Envases)
        Me.GroupBox5.Controls.Add(Me.lsv_EnvasesT)
        Me.GroupBox5.Location = New System.Drawing.Point(461, 227)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(251, 269)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        '
        'tbx_BuscarE
        '
        Me.tbx_BuscarE.Control_Siguiente = Me.ButtonBuscarE
        Me.tbx_BuscarE.Filtrado = False
        Me.tbx_BuscarE.Location = New System.Drawing.Point(6, 13)
        Me.tbx_BuscarE.Name = "tbx_BuscarE"
        Me.tbx_BuscarE.Size = New System.Drawing.Size(147, 20)
        Me.tbx_BuscarE.TabIndex = 3
        Me.tbx_BuscarE.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'ButtonBuscarE
        '
        Me.ButtonBuscarE.Image = CType(resources.GetObject("ButtonBuscarE.Image"), System.Drawing.Image)
        Me.ButtonBuscarE.Location = New System.Drawing.Point(159, 9)
        Me.ButtonBuscarE.Name = "ButtonBuscarE"
        Me.ButtonBuscarE.Size = New System.Drawing.Size(82, 25)
        Me.ButtonBuscarE.TabIndex = 4
        Me.ButtonBuscarE.Text = "&Buscar"
        Me.ButtonBuscarE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonBuscarE.UseVisualStyleBackColor = True
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.CheckBoxes = True
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter3
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 40
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 50
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(235, 127)
        Me.lsv_Envases.TabIndex = 42
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'lsv_EnvasesT
        '
        Me.lsv_EnvasesT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesT.FullRowSelect = True
        Me.lsv_EnvasesT.HideSelection = False
        Me.lsv_EnvasesT.Location = New System.Drawing.Point(6, 173)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_EnvasesT.Lvs = ListViewColumnSorter4
        Me.lsv_EnvasesT.MultiSelect = False
        Me.lsv_EnvasesT.Name = "lsv_EnvasesT"
        Me.lsv_EnvasesT.Row1 = 45
        Me.lsv_EnvasesT.Row10 = 0
        Me.lsv_EnvasesT.Row2 = 45
        Me.lsv_EnvasesT.Row3 = 0
        Me.lsv_EnvasesT.Row4 = 0
        Me.lsv_EnvasesT.Row5 = 0
        Me.lsv_EnvasesT.Row6 = 0
        Me.lsv_EnvasesT.Row7 = 0
        Me.lsv_EnvasesT.Row8 = 0
        Me.lsv_EnvasesT.Row9 = 0
        Me.lsv_EnvasesT.Size = New System.Drawing.Size(235, 90)
        Me.lsv_EnvasesT.TabIndex = 47
        Me.lsv_EnvasesT.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesT.View = System.Windows.Forms.View.Details
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Cp_Listview1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Cp_Listview1
        '
        Me.Cp_Listview1.AllowColumnReorder = True
        Me.Cp_Listview1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cp_Listview1.FullRowSelect = True
        Me.Cp_Listview1.HideSelection = False
        Me.Cp_Listview1.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.Cp_Listview1.Lvs = ListViewColumnSorter5
        Me.Cp_Listview1.MultiSelect = False
        Me.Cp_Listview1.Name = "Cp_Listview1"
        Me.Cp_Listview1.Row1 = 10
        Me.Cp_Listview1.Row10 = 0
        Me.Cp_Listview1.Row2 = 10
        Me.Cp_Listview1.Row3 = 10
        Me.Cp_Listview1.Row4 = 10
        Me.Cp_Listview1.Row5 = 10
        Me.Cp_Listview1.Row6 = 10
        Me.Cp_Listview1.Row7 = 10
        Me.Cp_Listview1.Row8 = 0
        Me.Cp_Listview1.Row9 = 0
        Me.Cp_Listview1.Size = New System.Drawing.Size(94, 14)
        Me.Cp_Listview1.TabIndex = 42
        Me.Cp_Listview1.UseCompatibleStateImageBehavior = False
        Me.Cp_Listview1.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Cp_tbx_int_N1)
        Me.GroupBox1.Controls.Add(Me.Cp_tbx_int_N2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 39)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cant Remisiones:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Seleccionados:"
        '
        'Cp_tbx_int_N1
        '
        Me.Cp_tbx_int_N1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cp_tbx_int_N1.BackColor = System.Drawing.Color.White
        Me.Cp_tbx_int_N1.Control_Siguiente = Nothing
        Me.Cp_tbx_int_N1.Enabled = False
        Me.Cp_tbx_int_N1.Filtrado = False
        Me.Cp_tbx_int_N1.Location = New System.Drawing.Point(242, 11)
        Me.Cp_tbx_int_N1.MaxLength = 10
        Me.Cp_tbx_int_N1.Name = "Cp_tbx_int_N1"
        Me.Cp_tbx_int_N1.Size = New System.Drawing.Size(56, 20)
        Me.Cp_tbx_int_N1.TabIndex = 1
        Me.Cp_tbx_int_N1.Text = "0"
        Me.Cp_tbx_int_N1.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Cp_tbx_int_N2
        '
        Me.Cp_tbx_int_N2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cp_tbx_int_N2.BackColor = System.Drawing.Color.White
        Me.Cp_tbx_int_N2.Control_Siguiente = Nothing
        Me.Cp_tbx_int_N2.Enabled = False
        Me.Cp_tbx_int_N2.Filtrado = False
        Me.Cp_tbx_int_N2.Location = New System.Drawing.Point(92, 13)
        Me.Cp_tbx_int_N2.MaxLength = 10
        Me.Cp_tbx_int_N2.Name = "Cp_tbx_int_N2"
        Me.Cp_tbx_int_N2.Size = New System.Drawing.Size(49, 20)
        Me.Cp_tbx_int_N2.TabIndex = 0
        Me.Cp_tbx_int_N2.Text = "0"
        Me.Cp_tbx_int_N2.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox3.Controls.Add(Me.btn_Recibir)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 498)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(701, 50)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AllowColumnReorder = True
        Me.lsv_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(12, 35)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter6
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 15
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 30
        Me.lsv_Datos.Row3 = 10
        Me.lsv_Datos.Row4 = 15
        Me.lsv_Datos.Row5 = 15
        Me.lsv_Datos.Row6 = 0
        Me.lsv_Datos.Row7 = 0
        Me.lsv_Datos.Row8 = 0
        Me.lsv_Datos.Row9 = 0
        Me.lsv_Datos.Size = New System.Drawing.Size(700, 186)
        Me.lsv_Datos.TabIndex = 41
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(540, 9)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(173, 23)
        Me.Lbl_Registros.TabIndex = 55
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_ReciboServiciosBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 550)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lsv_Datos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_ReciboServiciosBoveda"
        Me.Text = "Recibir Servicios de Bóveda"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Datos As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents lsv_Remisiones As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Buscar As Modulo_Proceso.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cp_Listview1 As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cp_tbx_int_N1 As Modulo_Proceso.cp_Textbox
    Friend WithEvents Cp_tbx_int_N2 As Modulo_Proceso.cp_Textbox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_BuscarE As Modulo_Proceso.cp_Textbox
    Friend WithEvents ButtonBuscarE As System.Windows.Forms.Button
    Friend WithEvents lsv_DotacionDT As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_EnvasesT As Modulo_Proceso.cp_Listview
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
