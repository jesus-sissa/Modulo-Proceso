<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaDepositosLavado
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
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cbx_Corte = New System.Windows.Forms.CheckBox
        Me.lbl_Corte = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.lbl_TipoConsulta = New System.Windows.Forms.Label
        Me.Tab_TipoConsulta = New System.Windows.Forms.TabControl
        Me.Tab_Fecha = New System.Windows.Forms.TabPage
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Tab_Sesion = New System.Windows.Forms.TabPage
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lsv_Depositos = New Modulo_Proceso.cp_Listview
        Me.tbx_Corte = New Modulo_Proceso.cp_Textbox
        Me.cmb_Hasta = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_Desde = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.gbx_Parametros.SuspendLayout()
        Me.Tab_TipoConsulta.SuspendLayout()
        Me.Tab_Fecha.SuspendLayout()
        Me.Tab_Sesion.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Parametros.Controls.Add(Me.cbx_Corte)
        Me.gbx_Parametros.Controls.Add(Me.tbx_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Corte)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.lbl_TipoConsulta)
        Me.gbx_Parametros.Controls.Add(Me.Tab_TipoConsulta)
        Me.gbx_Parametros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Parametros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Parametros.Location = New System.Drawing.Point(3, 2)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(778, 159)
        Me.gbx_Parametros.TabIndex = 1
        Me.gbx_Parametros.TabStop = False
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(103, 123)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 5
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cbx_Corte
        '
        Me.cbx_Corte.AutoSize = True
        Me.cbx_Corte.Location = New System.Drawing.Point(476, 97)
        Me.cbx_Corte.Name = "cbx_Corte"
        Me.cbx_Corte.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Corte.TabIndex = 11
        Me.cbx_Corte.Text = "Todos"
        Me.cbx_Corte.UseVisualStyleBackColor = True
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(323, 97)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Corte.TabIndex = 9
        Me.lbl_Corte.Text = "Corte"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(58, 75)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 3
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(61, 101)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 1
        Me.lbl_Hasta.Text = "Hasta"
        '
        'lbl_TipoConsulta
        '
        Me.lbl_TipoConsulta.AutoSize = True
        Me.lbl_TipoConsulta.Location = New System.Drawing.Point(9, 47)
        Me.lbl_TipoConsulta.Name = "lbl_TipoConsulta"
        Me.lbl_TipoConsulta.Size = New System.Drawing.Size(87, 13)
        Me.lbl_TipoConsulta.TabIndex = 2
        Me.lbl_TipoConsulta.Text = "Tipo de Consulta"
        '
        'Tab_TipoConsulta
        '
        Me.Tab_TipoConsulta.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Tab_TipoConsulta.Controls.Add(Me.Tab_Fecha)
        Me.Tab_TipoConsulta.Controls.Add(Me.Tab_Sesion)
        Me.Tab_TipoConsulta.Location = New System.Drawing.Point(102, 42)
        Me.Tab_TipoConsulta.Name = "Tab_TipoConsulta"
        Me.Tab_TipoConsulta.SelectedIndex = 0
        Me.Tab_TipoConsulta.Size = New System.Drawing.Size(145, 86)
        Me.Tab_TipoConsulta.TabIndex = 4
        '
        'Tab_Fecha
        '
        Me.Tab_Fecha.Controls.Add(Me.dtp_Hasta)
        Me.Tab_Fecha.Controls.Add(Me.dtp_Desde)
        Me.Tab_Fecha.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Fecha.Name = "Tab_Fecha"
        Me.Tab_Fecha.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Fecha.Size = New System.Drawing.Size(137, 57)
        Me.Tab_Fecha.TabIndex = 0
        Me.Tab_Fecha.Text = "Por Fecha"
        Me.Tab_Fecha.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(1, 29)
        Me.dtp_Hasta.MinDate = New Date(2009, 8, 13, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 1
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(1, 3)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 0
        '
        'Tab_Sesion
        '
        Me.Tab_Sesion.Controls.Add(Me.cmb_Hasta)
        Me.Tab_Sesion.Controls.Add(Me.cmb_Desde)
        Me.Tab_Sesion.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Sesion.Name = "Tab_Sesion"
        Me.Tab_Sesion.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Sesion.Size = New System.Drawing.Size(137, 57)
        Me.Tab_Sesion.TabIndex = 1
        Me.Tab_Sesion.Text = "Por Sesion"
        Me.Tab_Sesion.UseVisualStyleBackColor = True
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(24, 18)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'gbx_Dotaciones
        '
        Me.gbx_Dotaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Dotaciones.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_Depositos)
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(3, 164)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(778, 342)
        Me.gbx_Dotaciones.TabIndex = 2
        Me.gbx_Dotaciones.TabStop = False
        Me.gbx_Dotaciones.Text = "Depósitos"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(604, 10)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(171, 17)
        Me.Lbl_Registros.TabIndex = 1
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 510)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 13)
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
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lsv_Depositos
        '
        Me.lsv_Depositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Depositos.FullRowSelect = True
        Me.lsv_Depositos.HideSelection = False
        Me.lsv_Depositos.Location = New System.Drawing.Point(3, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Depositos.Lvs = ListViewColumnSorter1
        Me.lsv_Depositos.MultiSelect = False
        Me.lsv_Depositos.Name = "lsv_Depositos"
        Me.lsv_Depositos.Row1 = 9
        Me.lsv_Depositos.Row10 = 0
        Me.lsv_Depositos.Row2 = 9
        Me.lsv_Depositos.Row3 = 9
        Me.lsv_Depositos.Row4 = 5
        Me.lsv_Depositos.Row5 = 20
        Me.lsv_Depositos.Row6 = 20
        Me.lsv_Depositos.Row7 = 5
        Me.lsv_Depositos.Row8 = 9
        Me.lsv_Depositos.Row9 = 15
        Me.lsv_Depositos.Size = New System.Drawing.Size(772, 304)
        Me.lsv_Depositos.TabIndex = 2
        Me.lsv_Depositos.UseCompatibleStateImageBehavior = False
        Me.lsv_Depositos.View = System.Windows.Forms.View.Details
        '
        'tbx_Corte
        '
        Me.tbx_Corte.Control_Siguiente = Nothing
        Me.tbx_Corte.Filtrado = False
        Me.tbx_Corte.Location = New System.Drawing.Point(361, 95)
        Me.tbx_Corte.MaxLength = 10
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.Size = New System.Drawing.Size(109, 20)
        Me.tbx_Corte.TabIndex = 10
        Me.tbx_Corte.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Hasta
        '
        Me.cmb_Hasta.Control_Siguiente = Nothing
        Me.cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hasta.Empresa = False
        Me.cmb_Hasta.FormattingEnabled = True
        Me.cmb_Hasta.Location = New System.Drawing.Point(3, 30)
        Me.cmb_Hasta.MaxDropDownItems = 20
        Me.cmb_Hasta.Name = "cmb_Hasta"
        Me.cmb_Hasta.Pista = False
        Me.cmb_Hasta.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Hasta.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Hasta.Sucursal = True
        Me.cmb_Hasta.TabIndex = 1
        Me.cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'cmb_Desde
        '
        Me.cmb_Desde.Control_Siguiente = Nothing
        Me.cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desde.Empresa = False
        Me.cmb_Desde.FormattingEnabled = True
        Me.cmb_Desde.Location = New System.Drawing.Point(3, 3)
        Me.cmb_Desde.MaxDropDownItems = 20
        Me.cmb_Desde.Name = "cmb_Desde"
        Me.cmb_Desde.Pista = False
        Me.cmb_Desde.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Desde.StoredProcedure = "Pro_Sesion_Get"
        Me.cmb_Desde.Sucursal = True
        Me.cmb_Desde.TabIndex = 0
        Me.cmb_Desde.ValueMember = "Id_Sesion"
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
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(103, 15)
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
        'frm_ConsultaDepositosLavado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Dotaciones)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.Name = "frm_ConsultaDepositosLavado"
        Me.Text = "Consulta de Depósitos(Procesado)"
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.Tab_TipoConsulta.ResumeLayout(False)
        Me.Tab_Fecha.ResumeLayout(False)
        Me.Tab_Sesion.ResumeLayout(False)
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents cbx_Corte As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_Corte As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoConsulta As System.Windows.Forms.Label
    Friend WithEvents Tab_TipoConsulta As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Fecha As System.Windows.Forms.TabPage
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tab_Sesion As System.Windows.Forms.TabPage
    Friend WithEvents cmb_Hasta As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cmb_Desde As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Dotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Depositos As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
End Class
