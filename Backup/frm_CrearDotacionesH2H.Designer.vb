<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CrearDotacionesH2H
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
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CrearDotacionesH2H))
        Me.gbx_TipoDotacion = New System.Windows.Forms.GroupBox
        Me.lbl_TipoDotación = New System.Windows.Forms.Label
        Me.gbx_dotacion = New System.Windows.Forms.GroupBox
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.mtb_HoraSolicita = New System.Windows.Forms.MaskedTextBox
        Me.lbl_ImpNom = New System.Windows.Forms.Label
        Me.lbl_ImporteDoc = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_HoraSolicita = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_HoraSolicita = New System.Windows.Forms.Label
        Me.lbl_Importe = New System.Windows.Forms.Label
        Me.lbl_Tipos = New System.Windows.Forms.Label
        Me.dtp_Entrega = New System.Windows.Forms.DateTimePicker
        Me.lbl_Documentos = New System.Windows.Forms.Label
        Me.lbl_Entrega = New System.Windows.Forms.Label
        Me.btn_Cliente = New System.Windows.Forms.Button
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.lbl_Cia = New System.Windows.Forms.Label
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.gbx_ListaDotaciones = New System.Windows.Forms.GroupBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_DotacionesD = New System.Windows.Forms.GroupBox
        Me.lsv_Denominacion = New Modulo_Proceso.cp_Listview
        Me.lsv_Dotaciones = New Modulo_Proceso.cp_Listview
        Me.cmb_TipoDotacion = New Modulo_Proceso.cp_cmb_Manual
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.tbx_ImpNom = New Modulo_Proceso.cp_Textbox
        Me.tbx_ImpDoc = New Modulo_Proceso.cp_Textbox
        Me.tbx_Sobres = New Modulo_Proceso.cp_Textbox
        Me.cmb_Nomina = New Modulo_Proceso.cp_cmb_Manual
        Me.tbx_Importe = New Modulo_Proceso.cp_Textbox
        Me.cmb_Tipos = New Modulo_Proceso.cp_cmb_Manual
        Me.cmb_Documentos = New Modulo_Proceso.cp_cmb_Manual
        Me.cmb_Cliente = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.cmb_Cia = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.gbx_TipoDotacion.SuspendLayout()
        Me.gbx_dotacion.SuspendLayout()
        Me.gbx_ListaDotaciones.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.gbx_DotacionesD.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_TipoDotacion
        '
        Me.gbx_TipoDotacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_TipoDotacion.Controls.Add(Me.cmb_TipoDotacion)
        Me.gbx_TipoDotacion.Controls.Add(Me.lbl_TipoDotación)
        Me.gbx_TipoDotacion.Location = New System.Drawing.Point(5, 0)
        Me.gbx_TipoDotacion.Name = "gbx_TipoDotacion"
        Me.gbx_TipoDotacion.Size = New System.Drawing.Size(811, 39)
        Me.gbx_TipoDotacion.TabIndex = 2
        Me.gbx_TipoDotacion.TabStop = False
        '
        'lbl_TipoDotación
        '
        Me.lbl_TipoDotación.AutoSize = True
        Me.lbl_TipoDotación.Location = New System.Drawing.Point(26, 15)
        Me.lbl_TipoDotación.Name = "lbl_TipoDotación"
        Me.lbl_TipoDotación.Size = New System.Drawing.Size(60, 13)
        Me.lbl_TipoDotación.TabIndex = 0
        Me.lbl_TipoDotación.Text = "Tipo Salida"
        '
        'gbx_dotacion
        '
        Me.gbx_dotacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_dotacion.Controls.Add(Me.lbl_Moneda)
        Me.gbx_dotacion.Controls.Add(Me.cmb_Moneda)
        Me.gbx_dotacion.Controls.Add(Me.lbl_ImpNom)
        Me.gbx_dotacion.Controls.Add(Me.lbl_ImporteDoc)
        Me.gbx_dotacion.Controls.Add(Me.tbx_ImpNom)
        Me.gbx_dotacion.Controls.Add(Me.tbx_ImpDoc)
        Me.gbx_dotacion.Controls.Add(Me.Label11)
        Me.gbx_dotacion.Controls.Add(Me.Label10)
        Me.gbx_dotacion.Controls.Add(Me.Label9)
        Me.gbx_dotacion.Controls.Add(Me.Label8)
        Me.gbx_dotacion.Controls.Add(Me.Label7)
        Me.gbx_dotacion.Controls.Add(Me.Label6)
        Me.gbx_dotacion.Controls.Add(Me.Label5)
        Me.gbx_dotacion.Controls.Add(Me.Label4)
        Me.gbx_dotacion.Controls.Add(Me.Label3)
        Me.gbx_dotacion.Controls.Add(Me.dtp_HoraSolicita)
        Me.gbx_dotacion.Controls.Add(Me.Label1)
        Me.gbx_dotacion.Controls.Add(Me.tbx_Sobres)
        Me.gbx_dotacion.Controls.Add(Me.Label2)
        Me.gbx_dotacion.Controls.Add(Me.cmb_Nomina)
        Me.gbx_dotacion.Controls.Add(Me.mtb_HoraSolicita)
        Me.gbx_dotacion.Controls.Add(Me.lbl_HoraSolicita)
        Me.gbx_dotacion.Controls.Add(Me.lbl_Importe)
        Me.gbx_dotacion.Controls.Add(Me.tbx_Importe)
        Me.gbx_dotacion.Controls.Add(Me.lbl_Tipos)
        Me.gbx_dotacion.Controls.Add(Me.cmb_Tipos)
        Me.gbx_dotacion.Controls.Add(Me.lbl_Documentos)
        Me.gbx_dotacion.Controls.Add(Me.cmb_Documentos)
        Me.gbx_dotacion.Controls.Add(Me.dtp_Entrega)
        Me.gbx_dotacion.Controls.Add(Me.lbl_Entrega)
        Me.gbx_dotacion.Controls.Add(Me.btn_Cliente)
        Me.gbx_dotacion.Controls.Add(Me.lbl_Cliente)
        Me.gbx_dotacion.Controls.Add(Me.cmb_Cliente)
        Me.gbx_dotacion.Controls.Add(Me.lbl_Cia)
        Me.gbx_dotacion.Controls.Add(Me.cmb_Cia)
        Me.gbx_dotacion.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_dotacion.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_dotacion.Enabled = False
        Me.gbx_dotacion.Location = New System.Drawing.Point(5, 36)
        Me.gbx_dotacion.Name = "gbx_dotacion"
        Me.gbx_dotacion.Size = New System.Drawing.Size(811, 176)
        Me.gbx_dotacion.TabIndex = 3
        Me.gbx_dotacion.TabStop = False
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(40, 91)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 38
        Me.lbl_Moneda.Text = "Moneda"
        '
        'mtb_HoraSolicita
        '
        Me.mtb_HoraSolicita.Location = New System.Drawing.Point(421, 145)
        Me.mtb_HoraSolicita.Mask = "00:00"
        Me.mtb_HoraSolicita.Name = "mtb_HoraSolicita"
        Me.mtb_HoraSolicita.Size = New System.Drawing.Size(39, 20)
        Me.mtb_HoraSolicita.TabIndex = 15
        Me.mtb_HoraSolicita.ValidatingType = GetType(Date)
        Me.mtb_HoraSolicita.Visible = False
        '
        'lbl_ImpNom
        '
        Me.lbl_ImpNom.AutoSize = True
        Me.lbl_ImpNom.Location = New System.Drawing.Point(5, 258)
        Me.lbl_ImpNom.Name = "lbl_ImpNom"
        Me.lbl_ImpNom.Size = New System.Drawing.Size(81, 13)
        Me.lbl_ImpNom.TabIndex = 34
        Me.lbl_ImpNom.Text = "Importe Nomina"
        '
        'lbl_ImporteDoc
        '
        Me.lbl_ImporteDoc.AutoSize = True
        Me.lbl_ImporteDoc.Location = New System.Drawing.Point(231, 229)
        Me.lbl_ImporteDoc.Name = "lbl_ImporteDoc"
        Me.lbl_ImporteDoc.Size = New System.Drawing.Size(105, 13)
        Me.lbl_ImporteDoc.TabIndex = 32
        Me.lbl_ImporteDoc.Text = "Importe Documentos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(193, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(193, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(193, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(193, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(586, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(327, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(533, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(466, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(498, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "*"
        '
        'dtp_HoraSolicita
        '
        Me.dtp_HoraSolicita.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_HoraSolicita.Location = New System.Drawing.Point(482, 121)
        Me.dtp_HoraSolicita.MinDate = New Date(2009, 7, 25, 0, 0, 0, 0)
        Me.dtp_HoraSolicita.Name = "dtp_HoraSolicita"
        Me.dtp_HoraSolicita.Size = New System.Drawing.Size(98, 20)
        Me.dtp_HoraSolicita.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Cantidad Sobres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nomina"
        '
        'lbl_HoraSolicita
        '
        Me.lbl_HoraSolicita.AutoSize = True
        Me.lbl_HoraSolicita.Location = New System.Drawing.Point(346, 126)
        Me.lbl_HoraSolicita.Name = "lbl_HoraSolicita"
        Me.lbl_HoraSolicita.Size = New System.Drawing.Size(130, 13)
        Me.lbl_HoraSolicita.TabIndex = 15
        Me.lbl_HoraSolicita.Text = "Hora que solicita el banco"
        '
        'lbl_Importe
        '
        Me.lbl_Importe.AutoSize = True
        Me.lbl_Importe.Location = New System.Drawing.Point(44, 232)
        Me.lbl_Importe.Name = "lbl_Importe"
        Me.lbl_Importe.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Importe.TabIndex = 30
        Me.lbl_Importe.Text = "Importe"
        '
        'lbl_Tipos
        '
        Me.lbl_Tipos.AutoSize = True
        Me.lbl_Tipos.Location = New System.Drawing.Point(34, 123)
        Me.lbl_Tipos.Name = "lbl_Tipos"
        Me.lbl_Tipos.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Tipos.TabIndex = 18
        Me.lbl_Tipos.Text = "Por Tipos"
        '
        'dtp_Entrega
        '
        Me.dtp_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Entrega.Location = New System.Drawing.Point(92, 147)
        Me.dtp_Entrega.MinDate = New Date(2009, 7, 25, 0, 0, 0, 0)
        Me.dtp_Entrega.Name = "dtp_Entrega"
        Me.dtp_Entrega.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Entrega.TabIndex = 22
        '
        'lbl_Documentos
        '
        Me.lbl_Documentos.AutoSize = True
        Me.lbl_Documentos.Location = New System.Drawing.Point(19, 176)
        Me.lbl_Documentos.Name = "lbl_Documentos"
        Me.lbl_Documentos.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Documentos.TabIndex = 24
        Me.lbl_Documentos.Text = "Documentos"
        '
        'lbl_Entrega
        '
        Me.lbl_Entrega.AutoSize = True
        Me.lbl_Entrega.Location = New System.Drawing.Point(42, 150)
        Me.lbl_Entrega.Name = "lbl_Entrega"
        Me.lbl_Entrega.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Entrega.TabIndex = 21
        Me.lbl_Entrega.Text = "Entrega"
        '
        'btn_Cliente
        '
        Me.btn_Cliente.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Cliente.Location = New System.Drawing.Point(552, 61)
        Me.btn_Cliente.Name = "btn_Cliente"
        Me.btn_Cliente.Size = New System.Drawing.Size(26, 23)
        Me.btn_Cliente.TabIndex = 11
        Me.btn_Cliente.UseVisualStyleBackColor = True
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(44, 67)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 7
        Me.lbl_Cliente.Text = "Cliente"
        '
        'lbl_Cia
        '
        Me.lbl_Cia.AutoSize = True
        Me.lbl_Cia.Location = New System.Drawing.Point(2, 40)
        Me.lbl_Cia.Name = "lbl_Cia"
        Me.lbl_Cia.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Cia.TabIndex = 4
        Me.lbl_Cia.Text = "Cia de Traslado"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(10, 13)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'gbx_ListaDotaciones
        '
        Me.gbx_ListaDotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ListaDotaciones.Controls.Add(Me.lbl_Registros)
        Me.gbx_ListaDotaciones.Controls.Add(Me.lsv_Dotaciones)
        Me.gbx_ListaDotaciones.Location = New System.Drawing.Point(5, 218)
        Me.gbx_ListaDotaciones.Name = "gbx_ListaDotaciones"
        Me.gbx_ListaDotaciones.Size = New System.Drawing.Size(811, 353)
        Me.gbx_ListaDotaciones.TabIndex = 4
        Me.gbx_ListaDotaciones.TabStop = False
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.AutoSize = True
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(717, 18)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Registros.TabIndex = 1
        Me.lbl_Registros.Text = "Registros: 0"
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_botones.Location = New System.Drawing.Point(5, 813)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(811, 51)
        Me.gbx_botones.TabIndex = 5
        Me.gbx_botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(662, 12)
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
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.bundle_24x24x32b
        Me.btn_Guardar.Location = New System.Drawing.Point(13, 12)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'gbx_DotacionesD
        '
        Me.gbx_DotacionesD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DotacionesD.Controls.Add(Me.lsv_Denominacion)
        Me.gbx_DotacionesD.Location = New System.Drawing.Point(5, 571)
        Me.gbx_DotacionesD.Name = "gbx_DotacionesD"
        Me.gbx_DotacionesD.Size = New System.Drawing.Size(811, 236)
        Me.gbx_DotacionesD.TabIndex = 6
        Me.gbx_DotacionesD.TabStop = False
        '
        'lsv_Denominacion
        '
        Me.lsv_Denominacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Denominacion.FullRowSelect = True
        Me.lsv_Denominacion.HideSelection = False
        Me.lsv_Denominacion.Location = New System.Drawing.Point(4, 12)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Denominacion.Lvs = ListViewColumnSorter2
        Me.lsv_Denominacion.MultiSelect = False
        Me.lsv_Denominacion.Name = "lsv_Denominacion"
        Me.lsv_Denominacion.Row1 = 10
        Me.lsv_Denominacion.Row10 = 10
        Me.lsv_Denominacion.Row2 = 10
        Me.lsv_Denominacion.Row3 = 10
        Me.lsv_Denominacion.Row4 = 10
        Me.lsv_Denominacion.Row5 = 10
        Me.lsv_Denominacion.Row6 = 10
        Me.lsv_Denominacion.Row7 = 10
        Me.lsv_Denominacion.Row8 = 10
        Me.lsv_Denominacion.Row9 = 10
        Me.lsv_Denominacion.Size = New System.Drawing.Size(801, 218)
        Me.lsv_Denominacion.TabIndex = 0
        Me.lsv_Denominacion.UseCompatibleStateImageBehavior = False
        Me.lsv_Denominacion.View = System.Windows.Forms.View.Details
        '
        'lsv_Dotaciones
        '
        Me.lsv_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotaciones.CheckBoxes = True
        Me.lsv_Dotaciones.FullRowSelect = True
        Me.lsv_Dotaciones.HideSelection = False
        Me.lsv_Dotaciones.Location = New System.Drawing.Point(6, 37)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotaciones.Lvs = ListViewColumnSorter1
        Me.lsv_Dotaciones.MultiSelect = False
        Me.lsv_Dotaciones.Name = "lsv_Dotaciones"
        Me.lsv_Dotaciones.Row1 = 10
        Me.lsv_Dotaciones.Row10 = 10
        Me.lsv_Dotaciones.Row2 = 10
        Me.lsv_Dotaciones.Row3 = 10
        Me.lsv_Dotaciones.Row4 = 10
        Me.lsv_Dotaciones.Row5 = 10
        Me.lsv_Dotaciones.Row6 = 10
        Me.lsv_Dotaciones.Row7 = 10
        Me.lsv_Dotaciones.Row8 = 10
        Me.lsv_Dotaciones.Row9 = 10
        Me.lsv_Dotaciones.Size = New System.Drawing.Size(799, 309)
        Me.lsv_Dotaciones.TabIndex = 0
        Me.lsv_Dotaciones.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotaciones.View = System.Windows.Forms.View.Details
        '
        'cmb_TipoDotacion
        '
        Me.cmb_TipoDotacion.Control_Siguiente = Nothing
        Me.cmb_TipoDotacion.DisplayMember = "display"
        Me.cmb_TipoDotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDotacion.FormattingEnabled = True
        Me.cmb_TipoDotacion.Location = New System.Drawing.Point(92, 12)
        Me.cmb_TipoDotacion.MaxDropDownItems = 20
        Me.cmb_TipoDotacion.Name = "cmb_TipoDotacion"
        Me.cmb_TipoDotacion.Size = New System.Drawing.Size(273, 21)
        Me.cmb_TipoDotacion.TabIndex = 1
        Me.cmb_TipoDotacion.ValueMember = "value"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Me.mtb_HoraSolicita
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(92, 88)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = False
        Me.cmb_Moneda.Size = New System.Drawing.Size(232, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_ComboGet"
        Me.cmb_Moneda.Sucursal = False
        Me.cmb_Moneda.TabIndex = 39
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'tbx_ImpNom
        '
        Me.tbx_ImpNom.Control_Siguiente = Nothing
        Me.tbx_ImpNom.Enabled = False
        Me.tbx_ImpNom.Filtrado = False
        Me.tbx_ImpNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ImpNom.Location = New System.Drawing.Point(92, 253)
        Me.tbx_ImpNom.Name = "tbx_ImpNom"
        Me.tbx_ImpNom.Size = New System.Drawing.Size(133, 22)
        Me.tbx_ImpNom.TabIndex = 35
        Me.tbx_ImpNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImpNom.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        Me.tbx_ImpNom.Visible = False
        '
        'tbx_ImpDoc
        '
        Me.tbx_ImpDoc.Control_Siguiente = Nothing
        Me.tbx_ImpDoc.Enabled = False
        Me.tbx_ImpDoc.Filtrado = False
        Me.tbx_ImpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ImpDoc.Location = New System.Drawing.Point(342, 224)
        Me.tbx_ImpDoc.Name = "tbx_ImpDoc"
        Me.tbx_ImpDoc.Size = New System.Drawing.Size(133, 22)
        Me.tbx_ImpDoc.TabIndex = 33
        Me.tbx_ImpDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_ImpDoc.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        Me.tbx_ImpDoc.Visible = False
        '
        'tbx_Sobres
        '
        Me.tbx_Sobres.Control_Siguiente = Nothing
        Me.tbx_Sobres.Enabled = False
        Me.tbx_Sobres.Filtrado = True
        Me.tbx_Sobres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Sobres.Location = New System.Drawing.Point(342, 253)
        Me.tbx_Sobres.MaxLength = 4
        Me.tbx_Sobres.Name = "tbx_Sobres"
        Me.tbx_Sobres.Size = New System.Drawing.Size(49, 23)
        Me.tbx_Sobres.TabIndex = 37
        Me.tbx_Sobres.TabStop = False
        Me.tbx_Sobres.Text = "0"
        Me.tbx_Sobres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Sobres.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_Sobres.Visible = False
        '
        'cmb_Nomina
        '
        Me.cmb_Nomina.Control_Siguiente = Me.tbx_Importe
        Me.cmb_Nomina.DisplayMember = "display"
        Me.cmb_Nomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Nomina.FormattingEnabled = True
        Me.cmb_Nomina.Location = New System.Drawing.Point(92, 200)
        Me.cmb_Nomina.MaxDropDownItems = 20
        Me.cmb_Nomina.Name = "cmb_Nomina"
        Me.cmb_Nomina.Size = New System.Drawing.Size(95, 21)
        Me.cmb_Nomina.TabIndex = 28
        Me.cmb_Nomina.ValueMember = "value"
        Me.cmb_Nomina.Visible = False
        '
        'tbx_Importe
        '
        Me.tbx_Importe.Control_Siguiente = Me.tbx_Sobres
        Me.tbx_Importe.Enabled = False
        Me.tbx_Importe.Filtrado = True
        Me.tbx_Importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Importe.Location = New System.Drawing.Point(92, 224)
        Me.tbx_Importe.MaxLength = 14
        Me.tbx_Importe.Name = "tbx_Importe"
        Me.tbx_Importe.Size = New System.Drawing.Size(133, 23)
        Me.tbx_Importe.TabIndex = 31
        Me.tbx_Importe.TabStop = False
        Me.tbx_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Importe.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        Me.tbx_Importe.Visible = False
        '
        'cmb_Tipos
        '
        Me.cmb_Tipos.Control_Siguiente = Me.dtp_Entrega
        Me.cmb_Tipos.DisplayMember = "display"
        Me.cmb_Tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipos.FormattingEnabled = True
        Me.cmb_Tipos.Location = New System.Drawing.Point(92, 120)
        Me.cmb_Tipos.MaxDropDownItems = 20
        Me.cmb_Tipos.Name = "cmb_Tipos"
        Me.cmb_Tipos.Size = New System.Drawing.Size(95, 21)
        Me.cmb_Tipos.TabIndex = 19
        Me.cmb_Tipos.ValueMember = "value"
        '
        'cmb_Documentos
        '
        Me.cmb_Documentos.Control_Siguiente = Me.cmb_Nomina
        Me.cmb_Documentos.DisplayMember = "display"
        Me.cmb_Documentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Documentos.FormattingEnabled = True
        Me.cmb_Documentos.Location = New System.Drawing.Point(92, 173)
        Me.cmb_Documentos.MaxDropDownItems = 20
        Me.cmb_Documentos.Name = "cmb_Documentos"
        Me.cmb_Documentos.Size = New System.Drawing.Size(95, 21)
        Me.cmb_Documentos.TabIndex = 25
        Me.cmb_Documentos.ValueMember = "value"
        Me.cmb_Documentos.Visible = False
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = ""
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Nothing
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(92, 61)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.NombreParametro = Nothing
        Me.cmb_Cliente.Pista = True
        Me.cmb_Cliente.Size = New System.Drawing.Size(435, 21)
        Me.cmb_Cliente.StoredProcedure = ""
        Me.cmb_Cliente.Sucursal = False
        Me.cmb_Cliente.TabIndex = 9
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_Cliente.ValorParametro = Nothing
        Me.cmb_Cliente.ValueMember = "Id_ClienteP"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Control_Siguiente = Nothing
        Me.cmb_Cia.DisplayMember = "Nombre"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(92, 35)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(371, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 5
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = ""
        Me.cmb_CajaBancaria.Control_Siguiente = Me.cmb_Cia
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(92, 10)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 2
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'frm_CrearDotacionesH2H
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 868)
        Me.Controls.Add(Me.gbx_DotacionesD)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_ListaDotaciones)
        Me.Controls.Add(Me.gbx_TipoDotacion)
        Me.Controls.Add(Me.gbx_dotacion)
        Me.Name = "frm_CrearDotacionesH2H"
        Me.Text = "Dotaciones H2H"
        Me.gbx_TipoDotacion.ResumeLayout(False)
        Me.gbx_TipoDotacion.PerformLayout()
        Me.gbx_dotacion.ResumeLayout(False)
        Me.gbx_dotacion.PerformLayout()
        Me.gbx_ListaDotaciones.ResumeLayout(False)
        Me.gbx_ListaDotaciones.PerformLayout()
        Me.gbx_botones.ResumeLayout(False)
        Me.gbx_DotacionesD.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_TipoDotacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_TipoDotacion As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_TipoDotación As System.Windows.Forms.Label
    Friend WithEvents gbx_dotacion As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ImpNom As System.Windows.Forms.Label
    Friend WithEvents lbl_ImporteDoc As System.Windows.Forms.Label
    Friend WithEvents tbx_ImpNom As Modulo_Proceso.cp_Textbox
    Friend WithEvents tbx_ImpDoc As Modulo_Proceso.cp_Textbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraSolicita As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Sobres As Modulo_Proceso.cp_Textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Nomina As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents tbx_Importe As Modulo_Proceso.cp_Textbox
    Friend WithEvents mtb_HoraSolicita As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_HoraSolicita As System.Windows.Forms.Label
    Friend WithEvents lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipos As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipos As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents dtp_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Documentos As System.Windows.Forms.Label
    Friend WithEvents cmb_Documentos As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_Entrega As System.Windows.Forms.Label
    Friend WithEvents btn_Cliente As System.Windows.Forms.Button
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Cliente As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents lbl_Cia As System.Windows.Forms.Label
    Friend WithEvents cmb_Cia As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents gbx_ListaDotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Dotaciones As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents gbx_DotacionesD As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Denominacion As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
End Class
