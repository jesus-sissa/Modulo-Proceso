<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReportesDiarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReportesDiarios))
        Me.cbx_Todos = New System.Windows.Forms.CheckBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.lbl_Sesion = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Corte = New System.Windows.Forms.Label
        Me.lbl_Grupo = New System.Windows.Forms.Label
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.lbl_Reporte = New System.Windows.Forms.Label
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_Cia = New System.Windows.Forms.Label
        Me.cbx_TCajero = New System.Windows.Forms.CheckBox
        Me.cbx_TProceso = New System.Windows.Forms.CheckBox
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.lbl_DiaSemana = New System.Windows.Forms.Label
        Me.lbl_FechaAplicacion = New System.Windows.Forms.Label
        Me.dtp_FechaAplicacion = New System.Windows.Forms.DateTimePicker
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.cmb_cia = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveCajero = New Modulo_Proceso.cp_Textbox
        Me.cmb_Reporte = New Modulo_Proceso.cp_cmb_Manual
        Me.cmb_Sesiones = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_Corte = New Modulo_Proceso.cp_cmb_SimpleParametros
        Me.cmb_Grupo = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbx_Todos
        '
        Me.cbx_Todos.AutoSize = True
        Me.cbx_Todos.Enabled = False
        Me.cbx_Todos.Location = New System.Drawing.Point(200, 153)
        Me.cbx_Todos.Name = "cbx_Todos"
        Me.cbx_Todos.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Todos.TabIndex = 16
        Me.cbx_Todos.Text = "Todos"
        Me.cbx_Todos.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(449, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Image = Global.Modulo_Proceso.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(8, 11)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 0
        Me.btn_Imprimir.Text = "&Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.Location = New System.Drawing.Point(203, 128)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Sesion.TabIndex = 12
        Me.lbl_Sesion.Text = "Sesion"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(56, 128)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 10
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Enabled = False
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(102, 124)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 11
        '
        'lbl_Corte
        '
        Me.lbl_Corte.AutoSize = True
        Me.lbl_Corte.Location = New System.Drawing.Point(61, 153)
        Me.lbl_Corte.Name = "lbl_Corte"
        Me.lbl_Corte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Corte.TabIndex = 14
        Me.lbl_Corte.Text = "Corte"
        '
        'lbl_Grupo
        '
        Me.lbl_Grupo.AutoSize = True
        Me.lbl_Grupo.Location = New System.Drawing.Point(15, 100)
        Me.lbl_Grupo.Name = "lbl_Grupo"
        Me.lbl_Grupo.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Grupo.TabIndex = 7
        Me.lbl_Grupo.Text = "Grupo Proceso"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(47, 46)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 2
        Me.lbl_Moneda.Text = "Moneda"
        '
        'lbl_Reporte
        '
        Me.lbl_Reporte.AutoSize = True
        Me.lbl_Reporte.Location = New System.Drawing.Point(48, 20)
        Me.lbl_Reporte.Name = "lbl_Reporte"
        Me.lbl_Reporte.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Reporte.TabIndex = 0
        Me.lbl_Reporte.Text = "Reporte"
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(56, 181)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Cajero.TabIndex = 17
        Me.lbl_Cajero.Text = "Cajero"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(20, 74)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 4
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'lbl_Cia
        '
        Me.lbl_Cia.AutoSize = True
        Me.lbl_Cia.Location = New System.Drawing.Point(24, 207)
        Me.lbl_Cia.Name = "lbl_Cia"
        Me.lbl_Cia.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Cia.TabIndex = 21
        Me.lbl_Cia.Text = "Cia. Traslado"
        '
        'cbx_TCajero
        '
        Me.cbx_TCajero.AutoSize = True
        Me.cbx_TCajero.Enabled = False
        Me.cbx_TCajero.Location = New System.Drawing.Point(478, 179)
        Me.cbx_TCajero.Name = "cbx_TCajero"
        Me.cbx_TCajero.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TCajero.TabIndex = 20
        Me.cbx_TCajero.Text = "Todos"
        Me.cbx_TCajero.UseVisualStyleBackColor = True
        '
        'cbx_TProceso
        '
        Me.cbx_TProceso.AutoSize = True
        Me.cbx_TProceso.Enabled = False
        Me.cbx_TProceso.Location = New System.Drawing.Point(380, 99)
        Me.cbx_TProceso.Name = "cbx_TProceso"
        Me.cbx_TProceso.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TProceso.TabIndex = 9
        Me.cbx_TProceso.Text = "Todos"
        Me.cbx_TProceso.UseVisualStyleBackColor = True
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Controls.Add(Me.cmb_cia)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cia)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Filtro.Controls.Add(Me.tbx_ClaveCajero)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Reporte)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Reporte)
        Me.gbx_Filtro.Controls.Add(Me.cbx_TProceso)
        Me.gbx_Filtro.Controls.Add(Me.cbx_TCajero)
        Me.gbx_Filtro.Controls.Add(Me.cbx_Todos)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Sesiones)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Sesion)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Corte)
        Me.gbx_Filtro.Controls.Add(Me.lbl_DiaSemana)
        Me.gbx_Filtro.Controls.Add(Me.lbl_FechaAplicacion)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Filtro.Controls.Add(Me.dtp_FechaAplicacion)
        Me.gbx_Filtro.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Corte)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Grupo)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Filtro.Location = New System.Drawing.Point(5, 6)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(602, 277)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'lbl_DiaSemana
        '
        Me.lbl_DiaSemana.AutoSize = True
        Me.lbl_DiaSemana.Location = New System.Drawing.Point(203, 235)
        Me.lbl_DiaSemana.Name = "lbl_DiaSemana"
        Me.lbl_DiaSemana.Size = New System.Drawing.Size(91, 13)
        Me.lbl_DiaSemana.TabIndex = 23
        Me.lbl_DiaSemana.Text = "Dia de la Semana"
        '
        'lbl_FechaAplicacion
        '
        Me.lbl_FechaAplicacion.AutoSize = True
        Me.lbl_FechaAplicacion.Location = New System.Drawing.Point(7, 235)
        Me.lbl_FechaAplicacion.Name = "lbl_FechaAplicacion"
        Me.lbl_FechaAplicacion.Size = New System.Drawing.Size(89, 13)
        Me.lbl_FechaAplicacion.TabIndex = 23
        Me.lbl_FechaAplicacion.Text = "Fecha Aplicación"
        '
        'dtp_FechaAplicacion
        '
        Me.dtp_FechaAplicacion.Enabled = False
        Me.dtp_FechaAplicacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaAplicacion.Location = New System.Drawing.Point(102, 231)
        Me.dtp_FechaAplicacion.Name = "dtp_FechaAplicacion"
        Me.dtp_FechaAplicacion.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaAplicacion.TabIndex = 24
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 289)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(602, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'cmb_cia
        '
        Me.cmb_cia.Control_Siguiente = Nothing
        Me.cmb_cia.DisplayMember = "Nombre"
        Me.cmb_cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cia.Empresa = False
        Me.cmb_cia.Enabled = False
        Me.cmb_cia.FormattingEnabled = True
        Me.cmb_cia.Location = New System.Drawing.Point(102, 204)
        Me.cmb_cia.MaxDropDownItems = 20
        Me.cmb_cia.Name = "cmb_cia"
        Me.cmb_cia.Pista = True
        Me.cmb_cia.Size = New System.Drawing.Size(428, 21)
        Me.cmb_cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_cia.Sucursal = False
        Me.cmb_cia.TabIndex = 22
        Me.cmb_cia.ValueMember = "Id_Cia"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Enabled = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(102, 70)
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
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Nothing
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Enabled = False
        Me.cmb_Cajero.Filtro = Me.tbx_ClaveCajero
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.ItemHeight = 13
        Me.cmb_Cajero.Location = New System.Drawing.Point(102, 177)
        Me.cmb_Cajero.MaxDropDownItems = 20
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(370, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 19
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveCajero
        '
        Me.tbx_ClaveCajero.Control_Siguiente = Nothing
        Me.tbx_ClaveCajero.Enabled = False
        Me.tbx_ClaveCajero.Filtrado = True
        Me.tbx_ClaveCajero.Location = New System.Drawing.Point(102, 178)
        Me.tbx_ClaveCajero.MaxLength = 12
        Me.tbx_ClaveCajero.Name = "tbx_ClaveCajero"
        Me.tbx_ClaveCajero.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveCajero.TabIndex = 18
        Me.tbx_ClaveCajero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveCajero.Visible = False
        '
        'cmb_Reporte
        '
        Me.cmb_Reporte.Control_Siguiente = Nothing
        Me.cmb_Reporte.DisplayMember = "display"
        Me.cmb_Reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Reporte.FormattingEnabled = True
        Me.cmb_Reporte.Location = New System.Drawing.Point(102, 17)
        Me.cmb_Reporte.MaxDropDownItems = 20
        Me.cmb_Reporte.Name = "cmb_Reporte"
        Me.cmb_Reporte.Size = New System.Drawing.Size(334, 21)
        Me.cmb_Reporte.TabIndex = 1
        Me.cmb_Reporte.ValueMember = "value"
        '
        'cmb_Sesiones
        '
        Me.cmb_Sesiones.Cia = False
        Me.cmb_Sesiones.Control_Siguiente = Nothing
        Me.cmb_Sesiones.DisplayMember = "Numero_Sesion"
        Me.cmb_Sesiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sesiones.Empresa = False
        Me.cmb_Sesiones.Enabled = False
        Me.cmb_Sesiones.FormattingEnabled = True
        Me.cmb_Sesiones.Location = New System.Drawing.Point(248, 125)
        Me.cmb_Sesiones.MaxDropDownItems = 20
        Me.cmb_Sesiones.Name = "cmb_Sesiones"
        Me.cmb_Sesiones.NombreParametro = "@Fecha"
        Me.cmb_Sesiones.Pista = False
        Me.cmb_Sesiones.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Sesiones.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Sesiones.Sucursal = True
        Me.cmb_Sesiones.TabIndex = 13
        Me.cmb_Sesiones.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Sesiones.ValorParametro = Nothing
        Me.cmb_Sesiones.ValueMember = "Id_Sesion"
        '
        'cmb_Corte
        '
        Me.cmb_Corte.Cia = False
        Me.cmb_Corte.Control_Siguiente = Nothing
        Me.cmb_Corte.DisplayMember = "Descripcion"
        Me.cmb_Corte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corte.Enabled = False
        Me.cmb_Corte.FormattingEnabled = True
        Me.cmb_Corte.Location = New System.Drawing.Point(102, 150)
        Me.cmb_Corte.MaxDropDownItems = 20
        Me.cmb_Corte.Name = "cmb_Corte"
        Me.cmb_Corte.Pista = False
        Me.cmb_Corte.Size = New System.Drawing.Size(89, 21)
        Me.cmb_Corte.StoredProcedure = "Pro_Cortes_Get"
        Me.cmb_Corte.Sucursal = False
        Me.cmb_Corte.TabIndex = 15
        Me.cmb_Corte.ValueMember = "Numero_Corte"
        '
        'cmb_Grupo
        '
        Me.cmb_Grupo.Cia = False
        Me.cmb_Grupo.Control_Siguiente = Nothing
        Me.cmb_Grupo.DisplayMember = "Descripcion"
        Me.cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Grupo.Empresa = False
        Me.cmb_Grupo.Enabled = False
        Me.cmb_Grupo.FormattingEnabled = True
        Me.cmb_Grupo.Location = New System.Drawing.Point(102, 97)
        Me.cmb_Grupo.MaxDropDownItems = 20
        Me.cmb_Grupo.Name = "cmb_Grupo"
        Me.cmb_Grupo.NombreParametro = "@Id_CajaBancaria"
        Me.cmb_Grupo.Pista = True
        Me.cmb_Grupo.Size = New System.Drawing.Size(272, 21)
        Me.cmb_Grupo.StoredProcedure = "Cat_GrupoDeposito_Get"
        Me.cmb_Grupo.Sucursal = False
        Me.cmb_Grupo.TabIndex = 8
        Me.cmb_Grupo.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_Grupo.ValorParametro = Nothing
        Me.cmb_Grupo.ValueMember = "Id_GrupoDepo"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.Enabled = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(102, 43)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(272, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 3
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'frm_ReportesDiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 351)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(620, 380)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(620, 380)
        Me.Name = "frm_ReportesDiarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes Diarios."
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbx_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents cmb_Sesiones As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents cmb_Corte As Modulo_Proceso.cp_cmb_SimpleParametros
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Corte As System.Windows.Forms.Label
    Friend WithEvents lbl_Grupo As System.Windows.Forms.Label
    Friend WithEvents cmb_Grupo As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Reporte As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_Reporte As System.Windows.Forms.Label
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveCajero As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents lbl_Cia As System.Windows.Forms.Label
    Friend WithEvents cmb_cia As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents cbx_TCajero As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_TProceso As System.Windows.Forms.CheckBox
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FechaAplicacion As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaAplicacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_DiaSemana As System.Windows.Forms.Label
End Class
