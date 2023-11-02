<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteTabular
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
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.cmb_Cia = New Modulo_Proceso.cp_cmb_Parametro
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_CiaTraslado = New System.Windows.Forms.Label
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.tbx_Remision = New Modulo_Proceso.cp_Textbox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Fichas = New System.Windows.Forms.Button
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Campos = New System.Windows.Forms.GroupBox
        Me.lbl_EstacionVerifica = New System.Windows.Forms.Label
        Me.lbl_Estacion_Asigna = New System.Windows.Forms.Label
        Me.tbx_EstacionVerifica = New System.Windows.Forms.TextBox
        Me.tbx_EstacionAsigna = New System.Windows.Forms.TextBox
        Me.tbx_EstacionRecibe = New System.Windows.Forms.TextBox
        Me.lbl_EstacionRecibe = New System.Windows.Forms.Label
        Me.tbx_Corte = New System.Windows.Forms.TextBox
        Me.lbl_CorteTurno = New System.Windows.Forms.Label
        Me.tbx_FichasContabilizadas = New System.Windows.Forms.TextBox
        Me.lbl_CantidadFichasC = New System.Windows.Forms.Label
        Me.lbl_StatusPro = New System.Windows.Forms.Label
        Me.tbx_StatusPro = New System.Windows.Forms.TextBox
        Me.lbl_MinutosVerificando = New System.Windows.Forms.Label
        Me.tbx_Fichas = New System.Windows.Forms.TextBox
        Me.lbl_Fichas = New System.Windows.Forms.Label
        Me.tbx_MinutosVerificando = New System.Windows.Forms.TextBox
        Me.tbx_FechaContabilizacion = New System.Windows.Forms.TextBox
        Me.lbl_FechaContabilizacion = New System.Windows.Forms.Label
        Me.lbl_FechaFinVerificacion = New System.Windows.Forms.Label
        Me.tbx_FechaFinVerificacion = New System.Windows.Forms.TextBox
        Me.tbx_FechaInicioVerificacion = New System.Windows.Forms.TextBox
        Me.lbl_FechaInicioVerificacion = New System.Windows.Forms.Label
        Me.tbx_FechaAsignacion = New System.Windows.Forms.TextBox
        Me.lbl_FechaAsignacion = New System.Windows.Forms.Label
        Me.tbx_FechaRecepcion = New System.Windows.Forms.TextBox
        Me.lbl_FechadeRecepcion = New System.Windows.Forms.Label
        Me.tbx_GrupoDeposito = New System.Windows.Forms.TextBox
        Me.lbl_GrupoDeposito = New System.Windows.Forms.Label
        Me.tbx_Cliente = New System.Windows.Forms.TextBox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.tbx_Cajero = New System.Windows.Forms.TextBox
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.tbx_CajaBancaria = New System.Windows.Forms.TextBox
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.tbx_Sesion = New System.Windows.Forms.TextBox
        Me.lbl_Sesion = New System.Windows.Forms.Label
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Campos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cia)
        Me.gbx_Filtro.Controls.Add(Me.btn_Buscar)
        Me.gbx_Filtro.Controls.Add(Me.lbl_CiaTraslado)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Remision)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Remision)
        Me.gbx_Filtro.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(591, 72)
        Me.gbx_Filtro.TabIndex = 2
        Me.gbx_Filtro.TabStop = False
        Me.gbx_Filtro.Text = "Remision:"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Cia = False
        Me.cmb_Cia.Control_Siguiente = Nothing
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Location = New System.Drawing.Point(96, 45)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.NombreParametro = "@Numero_Remision"
        Me.cmb_Cia.Pista = False
        Me.cmb_Cia.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Remisiones_ExisteByNumero"
        Me.cmb_Cia.Sucursal = True
        Me.cmb_Cia.TabIndex = 5
        Me.cmb_Cia.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_Cia.ValorParametro = Nothing
        Me.cmb_Cia.ValueMember = "Id_Remision"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Buscar.Location = New System.Drawing.Point(302, 16)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(25, 25)
        Me.btn_Buscar.TabIndex = 4
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_CiaTraslado
        '
        Me.lbl_CiaTraslado.AutoSize = True
        Me.lbl_CiaTraslado.Location = New System.Drawing.Point(6, 48)
        Me.lbl_CiaTraslado.Name = "lbl_CiaTraslado"
        Me.lbl_CiaTraslado.Size = New System.Drawing.Size(84, 13)
        Me.lbl_CiaTraslado.TabIndex = 3
        Me.lbl_CiaTraslado.Text = "Cia. de Traslado"
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(40, 22)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Remision.TabIndex = 1
        Me.lbl_Remision.Text = "Remision"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Location = New System.Drawing.Point(96, 19)
        Me.tbx_Remision.MaxLength = 20
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(200, 20)
        Me.tbx_Remision.TabIndex = 0
        Me.tbx_Remision.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_Fichas)
        Me.gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(7, 437)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(591, 50)
        Me.gbx_Botones.TabIndex = 0
        Me.gbx_Botones.TabStop = False
        '
        'btn_Fichas
        '
        Me.btn_Fichas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Fichas.Enabled = False
        Me.btn_Fichas.Image = Global.Modulo_Proceso.My.Resources.Resources.Imprimir
        Me.btn_Fichas.Location = New System.Drawing.Point(155, 14)
        Me.btn_Fichas.Name = "btn_Fichas"
        Me.btn_Fichas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Fichas.TabIndex = 7
        Me.btn_Fichas.Text = "&Imprimir por Fichas"
        Me.btn_Fichas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Fichas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Fichas.UseVisualStyleBackColor = True
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Imprimir.Enabled = False
        Me.btn_Imprimir.Image = Global.Modulo_Proceso.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(9, 14)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 7
        Me.btn_Imprimir.Text = "&Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(442, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Campos
        '
        Me.gbx_Campos.Controls.Add(Me.lbl_EstacionVerifica)
        Me.gbx_Campos.Controls.Add(Me.lbl_Estacion_Asigna)
        Me.gbx_Campos.Controls.Add(Me.tbx_EstacionVerifica)
        Me.gbx_Campos.Controls.Add(Me.tbx_EstacionAsigna)
        Me.gbx_Campos.Controls.Add(Me.tbx_EstacionRecibe)
        Me.gbx_Campos.Controls.Add(Me.lbl_EstacionRecibe)
        Me.gbx_Campos.Controls.Add(Me.tbx_Corte)
        Me.gbx_Campos.Controls.Add(Me.lbl_CorteTurno)
        Me.gbx_Campos.Controls.Add(Me.tbx_FichasContabilizadas)
        Me.gbx_Campos.Controls.Add(Me.lbl_CantidadFichasC)
        Me.gbx_Campos.Controls.Add(Me.lbl_StatusPro)
        Me.gbx_Campos.Controls.Add(Me.tbx_StatusPro)
        Me.gbx_Campos.Controls.Add(Me.lbl_MinutosVerificando)
        Me.gbx_Campos.Controls.Add(Me.tbx_Fichas)
        Me.gbx_Campos.Controls.Add(Me.lbl_Fichas)
        Me.gbx_Campos.Controls.Add(Me.tbx_MinutosVerificando)
        Me.gbx_Campos.Controls.Add(Me.tbx_FechaContabilizacion)
        Me.gbx_Campos.Controls.Add(Me.lbl_FechaContabilizacion)
        Me.gbx_Campos.Controls.Add(Me.lbl_FechaFinVerificacion)
        Me.gbx_Campos.Controls.Add(Me.tbx_FechaFinVerificacion)
        Me.gbx_Campos.Controls.Add(Me.tbx_FechaInicioVerificacion)
        Me.gbx_Campos.Controls.Add(Me.lbl_FechaInicioVerificacion)
        Me.gbx_Campos.Controls.Add(Me.tbx_FechaAsignacion)
        Me.gbx_Campos.Controls.Add(Me.lbl_FechaAsignacion)
        Me.gbx_Campos.Controls.Add(Me.tbx_FechaRecepcion)
        Me.gbx_Campos.Controls.Add(Me.lbl_FechadeRecepcion)
        Me.gbx_Campos.Controls.Add(Me.tbx_GrupoDeposito)
        Me.gbx_Campos.Controls.Add(Me.lbl_GrupoDeposito)
        Me.gbx_Campos.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Campos.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Campos.Controls.Add(Me.tbx_Cajero)
        Me.gbx_Campos.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Campos.Controls.Add(Me.tbx_CajaBancaria)
        Me.gbx_Campos.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Campos.Controls.Add(Me.tbx_Sesion)
        Me.gbx_Campos.Controls.Add(Me.lbl_Sesion)
        Me.gbx_Campos.Location = New System.Drawing.Point(7, 80)
        Me.gbx_Campos.Name = "gbx_Campos"
        Me.gbx_Campos.Size = New System.Drawing.Size(591, 354)
        Me.gbx_Campos.TabIndex = 1
        Me.gbx_Campos.TabStop = False
        '
        'lbl_EstacionVerifica
        '
        Me.lbl_EstacionVerifica.AutoSize = True
        Me.lbl_EstacionVerifica.Location = New System.Drawing.Point(290, 204)
        Me.lbl_EstacionVerifica.Name = "lbl_EstacionVerifica"
        Me.lbl_EstacionVerifica.Size = New System.Drawing.Size(86, 13)
        Me.lbl_EstacionVerifica.TabIndex = 71
        Me.lbl_EstacionVerifica.Text = "Estacion Verifica"
        '
        'lbl_Estacion_Asigna
        '
        Me.lbl_Estacion_Asigna.AutoSize = True
        Me.lbl_Estacion_Asigna.Location = New System.Drawing.Point(293, 178)
        Me.lbl_Estacion_Asigna.Name = "lbl_Estacion_Asigna"
        Me.lbl_Estacion_Asigna.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Estacion_Asigna.TabIndex = 70
        Me.lbl_Estacion_Asigna.Text = "Estacion Asigna"
        '
        'tbx_EstacionVerifica
        '
        Me.tbx_EstacionVerifica.Location = New System.Drawing.Point(382, 201)
        Me.tbx_EstacionVerifica.Name = "tbx_EstacionVerifica"
        Me.tbx_EstacionVerifica.Size = New System.Drawing.Size(200, 20)
        Me.tbx_EstacionVerifica.TabIndex = 69
        '
        'tbx_EstacionAsigna
        '
        Me.tbx_EstacionAsigna.Location = New System.Drawing.Point(382, 175)
        Me.tbx_EstacionAsigna.Name = "tbx_EstacionAsigna"
        Me.tbx_EstacionAsigna.Size = New System.Drawing.Size(200, 20)
        Me.tbx_EstacionAsigna.TabIndex = 68
        '
        'tbx_EstacionRecibe
        '
        Me.tbx_EstacionRecibe.Location = New System.Drawing.Point(382, 149)
        Me.tbx_EstacionRecibe.Name = "tbx_EstacionRecibe"
        Me.tbx_EstacionRecibe.Size = New System.Drawing.Size(200, 20)
        Me.tbx_EstacionRecibe.TabIndex = 67
        '
        'lbl_EstacionRecibe
        '
        Me.lbl_EstacionRecibe.AutoSize = True
        Me.lbl_EstacionRecibe.Location = New System.Drawing.Point(291, 152)
        Me.lbl_EstacionRecibe.Name = "lbl_EstacionRecibe"
        Me.lbl_EstacionRecibe.Size = New System.Drawing.Size(85, 13)
        Me.lbl_EstacionRecibe.TabIndex = 66
        Me.lbl_EstacionRecibe.Text = "Estacion Recibe"
        '
        'tbx_Corte
        '
        Me.tbx_Corte.Location = New System.Drawing.Point(120, 331)
        Me.tbx_Corte.Name = "tbx_Corte"
        Me.tbx_Corte.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Corte.TabIndex = 65
        '
        'lbl_CorteTurno
        '
        Me.lbl_CorteTurno.AutoSize = True
        Me.lbl_CorteTurno.Location = New System.Drawing.Point(82, 334)
        Me.lbl_CorteTurno.Name = "lbl_CorteTurno"
        Me.lbl_CorteTurno.Size = New System.Drawing.Size(32, 13)
        Me.lbl_CorteTurno.TabIndex = 64
        Me.lbl_CorteTurno.Text = "Corte"
        '
        'tbx_FichasContabilizadas
        '
        Me.tbx_FichasContabilizadas.Location = New System.Drawing.Point(120, 305)
        Me.tbx_FichasContabilizadas.Name = "tbx_FichasContabilizadas"
        Me.tbx_FichasContabilizadas.Size = New System.Drawing.Size(50, 20)
        Me.tbx_FichasContabilizadas.TabIndex = 63
        '
        'lbl_CantidadFichasC
        '
        Me.lbl_CantidadFichasC.AutoSize = True
        Me.lbl_CantidadFichasC.Location = New System.Drawing.Point(5, 308)
        Me.lbl_CantidadFichasC.Name = "lbl_CantidadFichasC"
        Me.lbl_CantidadFichasC.Size = New System.Drawing.Size(109, 13)
        Me.lbl_CantidadFichasC.TabIndex = 62
        Me.lbl_CantidadFichasC.Text = "Fichas Contabilizadas"
        '
        'lbl_StatusPro
        '
        Me.lbl_StatusPro.AutoSize = True
        Me.lbl_StatusPro.Location = New System.Drawing.Point(339, 256)
        Me.lbl_StatusPro.Name = "lbl_StatusPro"
        Me.lbl_StatusPro.Size = New System.Drawing.Size(37, 13)
        Me.lbl_StatusPro.TabIndex = 61
        Me.lbl_StatusPro.Text = "Status"
        '
        'tbx_StatusPro
        '
        Me.tbx_StatusPro.Location = New System.Drawing.Point(382, 253)
        Me.tbx_StatusPro.Name = "tbx_StatusPro"
        Me.tbx_StatusPro.Size = New System.Drawing.Size(200, 20)
        Me.tbx_StatusPro.TabIndex = 60
        '
        'lbl_MinutosVerificando
        '
        Me.lbl_MinutosVerificando.AutoSize = True
        Me.lbl_MinutosVerificando.Location = New System.Drawing.Point(276, 230)
        Me.lbl_MinutosVerificando.Name = "lbl_MinutosVerificando"
        Me.lbl_MinutosVerificando.Size = New System.Drawing.Size(100, 13)
        Me.lbl_MinutosVerificando.TabIndex = 59
        Me.lbl_MinutosVerificando.Text = "Minutos Verificando"
        '
        'tbx_Fichas
        '
        Me.tbx_Fichas.Location = New System.Drawing.Point(120, 279)
        Me.tbx_Fichas.Name = "tbx_Fichas"
        Me.tbx_Fichas.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Fichas.TabIndex = 58
        '
        'lbl_Fichas
        '
        Me.lbl_Fichas.AutoSize = True
        Me.lbl_Fichas.Location = New System.Drawing.Point(76, 282)
        Me.lbl_Fichas.Name = "lbl_Fichas"
        Me.lbl_Fichas.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Fichas.TabIndex = 57
        Me.lbl_Fichas.Text = "Fichas"
        '
        'tbx_MinutosVerificando
        '
        Me.tbx_MinutosVerificando.Location = New System.Drawing.Point(382, 227)
        Me.tbx_MinutosVerificando.Name = "tbx_MinutosVerificando"
        Me.tbx_MinutosVerificando.Size = New System.Drawing.Size(200, 20)
        Me.tbx_MinutosVerificando.TabIndex = 56
        '
        'tbx_FechaContabilizacion
        '
        Me.tbx_FechaContabilizacion.Location = New System.Drawing.Point(120, 253)
        Me.tbx_FechaContabilizacion.Name = "tbx_FechaContabilizacion"
        Me.tbx_FechaContabilizacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaContabilizacion.TabIndex = 55
        '
        'lbl_FechaContabilizacion
        '
        Me.lbl_FechaContabilizacion.AutoSize = True
        Me.lbl_FechaContabilizacion.Location = New System.Drawing.Point(36, 256)
        Me.lbl_FechaContabilizacion.Name = "lbl_FechaContabilizacion"
        Me.lbl_FechaContabilizacion.Size = New System.Drawing.Size(78, 13)
        Me.lbl_FechaContabilizacion.TabIndex = 54
        Me.lbl_FechaContabilizacion.Text = "Contabilización"
        '
        'lbl_FechaFinVerificacion
        '
        Me.lbl_FechaFinVerificacion.AutoSize = True
        Me.lbl_FechaFinVerificacion.Location = New System.Drawing.Point(20, 230)
        Me.lbl_FechaFinVerificacion.Name = "lbl_FechaFinVerificacion"
        Me.lbl_FechaFinVerificacion.Size = New System.Drawing.Size(94, 13)
        Me.lbl_FechaFinVerificacion.TabIndex = 53
        Me.lbl_FechaFinVerificacion.Text = "Fin de Verificación"
        '
        'tbx_FechaFinVerificacion
        '
        Me.tbx_FechaFinVerificacion.Location = New System.Drawing.Point(120, 227)
        Me.tbx_FechaFinVerificacion.Name = "tbx_FechaFinVerificacion"
        Me.tbx_FechaFinVerificacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaFinVerificacion.TabIndex = 52
        '
        'tbx_FechaInicioVerificacion
        '
        Me.tbx_FechaInicioVerificacion.Location = New System.Drawing.Point(120, 201)
        Me.tbx_FechaInicioVerificacion.Name = "tbx_FechaInicioVerificacion"
        Me.tbx_FechaInicioVerificacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaInicioVerificacion.TabIndex = 51
        '
        'lbl_FechaInicioVerificacion
        '
        Me.lbl_FechaInicioVerificacion.AutoSize = True
        Me.lbl_FechaInicioVerificacion.Location = New System.Drawing.Point(9, 204)
        Me.lbl_FechaInicioVerificacion.Name = "lbl_FechaInicioVerificacion"
        Me.lbl_FechaInicioVerificacion.Size = New System.Drawing.Size(105, 13)
        Me.lbl_FechaInicioVerificacion.TabIndex = 50
        Me.lbl_FechaInicioVerificacion.Text = "Inicio de Verificación"
        '
        'tbx_FechaAsignacion
        '
        Me.tbx_FechaAsignacion.Location = New System.Drawing.Point(120, 175)
        Me.tbx_FechaAsignacion.Name = "tbx_FechaAsignacion"
        Me.tbx_FechaAsignacion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaAsignacion.TabIndex = 49
        '
        'lbl_FechaAsignacion
        '
        Me.lbl_FechaAsignacion.AutoSize = True
        Me.lbl_FechaAsignacion.Location = New System.Drawing.Point(55, 178)
        Me.lbl_FechaAsignacion.Name = "lbl_FechaAsignacion"
        Me.lbl_FechaAsignacion.Size = New System.Drawing.Size(59, 13)
        Me.lbl_FechaAsignacion.TabIndex = 48
        Me.lbl_FechaAsignacion.Text = "Asignación"
        '
        'tbx_FechaRecepcion
        '
        Me.tbx_FechaRecepcion.Location = New System.Drawing.Point(120, 149)
        Me.tbx_FechaRecepcion.Name = "tbx_FechaRecepcion"
        Me.tbx_FechaRecepcion.Size = New System.Drawing.Size(150, 20)
        Me.tbx_FechaRecepcion.TabIndex = 47
        '
        'lbl_FechadeRecepcion
        '
        Me.lbl_FechadeRecepcion.AutoSize = True
        Me.lbl_FechadeRecepcion.Location = New System.Drawing.Point(55, 152)
        Me.lbl_FechadeRecepcion.Name = "lbl_FechadeRecepcion"
        Me.lbl_FechadeRecepcion.Size = New System.Drawing.Size(59, 13)
        Me.lbl_FechadeRecepcion.TabIndex = 46
        Me.lbl_FechadeRecepcion.Text = "Recepción"
        '
        'tbx_GrupoDeposito
        '
        Me.tbx_GrupoDeposito.Location = New System.Drawing.Point(120, 123)
        Me.tbx_GrupoDeposito.Name = "tbx_GrupoDeposito"
        Me.tbx_GrupoDeposito.Size = New System.Drawing.Size(462, 20)
        Me.tbx_GrupoDeposito.TabIndex = 45
        '
        'lbl_GrupoDeposito
        '
        Me.lbl_GrupoDeposito.AutoSize = True
        Me.lbl_GrupoDeposito.Location = New System.Drawing.Point(18, 126)
        Me.lbl_GrupoDeposito.Name = "lbl_GrupoDeposito"
        Me.lbl_GrupoDeposito.Size = New System.Drawing.Size(96, 13)
        Me.lbl_GrupoDeposito.TabIndex = 44
        Me.lbl_GrupoDeposito.Text = "Grupo de Deposito"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Location = New System.Drawing.Point(120, 71)
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(462, 20)
        Me.tbx_Cliente.TabIndex = 43
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(75, 74)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 42
        Me.lbl_Cliente.Text = "Cliente"
        '
        'tbx_Cajero
        '
        Me.tbx_Cajero.Location = New System.Drawing.Point(120, 97)
        Me.tbx_Cajero.Name = "tbx_Cajero"
        Me.tbx_Cajero.Size = New System.Drawing.Size(462, 20)
        Me.tbx_Cajero.TabIndex = 41
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(77, 100)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Cajero.TabIndex = 40
        Me.lbl_Cajero.Text = "Cajero"
        '
        'tbx_CajaBancaria
        '
        Me.tbx_CajaBancaria.Location = New System.Drawing.Point(120, 45)
        Me.tbx_CajaBancaria.Name = "tbx_CajaBancaria"
        Me.tbx_CajaBancaria.Size = New System.Drawing.Size(462, 20)
        Me.tbx_CajaBancaria.TabIndex = 39
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(41, 48)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 38
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'tbx_Sesion
        '
        Me.tbx_Sesion.Location = New System.Drawing.Point(120, 19)
        Me.tbx_Sesion.Name = "tbx_Sesion"
        Me.tbx_Sesion.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Sesion.TabIndex = 37
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Location = New System.Drawing.Point(75, 22)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Sesion.TabIndex = 36
        Me.lbl_Sesion.Text = "Sesion"
        '
        'frm_ReporteTabular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 491)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Campos)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(620, 530)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(620, 530)
        Me.Name = "frm_ReporteTabular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte tabular por remisión"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Campos.ResumeLayout(False)
        Me.gbx_Campos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Campos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Cia As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_CiaTraslado As System.Windows.Forms.Label
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_EstacionVerifica As System.Windows.Forms.Label
    Friend WithEvents lbl_Estacion_Asigna As System.Windows.Forms.Label
    Friend WithEvents tbx_EstacionVerifica As System.Windows.Forms.TextBox
    Friend WithEvents tbx_EstacionAsigna As System.Windows.Forms.TextBox
    Friend WithEvents tbx_EstacionRecibe As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EstacionRecibe As System.Windows.Forms.Label
    Friend WithEvents tbx_Corte As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CorteTurno As System.Windows.Forms.Label
    Friend WithEvents tbx_FichasContabilizadas As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CantidadFichasC As System.Windows.Forms.Label
    Friend WithEvents lbl_StatusPro As System.Windows.Forms.Label
    Friend WithEvents tbx_StatusPro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MinutosVerificando As System.Windows.Forms.Label
    Friend WithEvents tbx_Fichas As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Fichas As System.Windows.Forms.Label
    Friend WithEvents tbx_MinutosVerificando As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaContabilizacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaContabilizacion As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaFinVerificacion As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaFinVerificacion As System.Windows.Forms.TextBox
    Friend WithEvents tbx_FechaInicioVerificacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaInicioVerificacion As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaAsignacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaAsignacion As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechadeRecepcion As System.Windows.Forms.Label
    Friend WithEvents tbx_GrupoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GrupoDeposito As System.Windows.Forms.Label
    Friend WithEvents tbx_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents tbx_Cajero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents tbx_CajaBancaria As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents tbx_Sesion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Fichas As System.Windows.Forms.Button
End Class
