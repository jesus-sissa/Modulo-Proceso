<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesProceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClientesProceso))
        Me.Tab_General = New System.Windows.Forms.TabControl
        Me.Tab_Listado = New System.Windows.Forms.TabPage
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.chk_Activas = New System.Windows.Forms.CheckBox
        Me.lbl_0_Banco = New System.Windows.Forms.Label
        Me.lbl_0_Cia = New System.Windows.Forms.Label
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Baja = New System.Windows.Forms.Button
        Me.btn_BuscarCajaBancaria = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.Lbl_0_Buscar = New System.Windows.Forms.Label
        Me.tab_Nuevo = New System.Windows.Forms.TabPage
        Me.gbx_Generales = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbx_Cuentas = New System.Windows.Forms.GroupBox
        Me.btn_CuentasBaja = New System.Windows.Forms.Button
        Me.gbx_Referencias = New System.Windows.Forms.GroupBox
        Me.btn_ReferenciaBaja = New System.Windows.Forms.Button
        Me.btn_CajaBancariaDetalles = New System.Windows.Forms.Button
        Me.lbl_EstadoDetalles = New System.Windows.Forms.Label
        Me.lbl_PaisDetalles = New System.Windows.Forms.Label
        Me.lbl_GrupoDotaDetalles = New System.Windows.Forms.Label
        Me.lbl_GrupoDepoDetalles = New System.Windows.Forms.Label
        Me.btn_BuscarClienteDetalles = New System.Windows.Forms.Button
        Me.lbl_GrupoFDetalles = New System.Windows.Forms.Label
        Me.lbl_RequiereCuentaDetalles = New System.Windows.Forms.Label
        Me.lbl_BancoDetalles = New System.Windows.Forms.Label
        Me.lbl_CiudadDetalles = New System.Windows.Forms.Label
        Me.lbl_ContratoDetalles = New System.Windows.Forms.Label
        Me.lbl_DireccionDetalles = New System.Windows.Forms.Label
        Me.lbl_CompañiaDetalles = New System.Windows.Forms.Label
        Me.lbl_ClienteDetalles = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Cuentas = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cmb_Banco = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_Cia = New Modulo_Proceso.cp_cmb_Simple
        Me.lsv_Catalogo = New Modulo_Proceso.cp_Listview
        Me.tbx_Buscar = New Modulo_Proceso.cp_Textbox
        Me.lsv_Cuentas = New Modulo_Proceso.cp_Listview
        Me.lsv_Referencias = New Modulo_Proceso.cp_Listview
        Me.cmb_BancoDetalles = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_CompañiaDetalles = New Modulo_Proceso.cp_cmb_Simple
        Me.tbx_ClienteDetalles = New Modulo_Proceso.cp_Textbox
        Me.cmb_GrupoDotaDetalles = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_GrupoDepositoDetalles = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_GrupoFDetalles = New Modulo_Proceso.cp_cmb_Parametro
        Me.tbx_ContratoDetalles = New Modulo_Proceso.cp_Textbox
        Me.cmb_ClienteDetalles = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.tbx_DireccionDetalles = New Modulo_Proceso.cp_Textbox
        Me.cmb_PaisDetalles = New Modulo_Proceso.cp_cmb_Simple
        Me.cmb_EstadoDetalles = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_CiudadDetalles = New Modulo_Proceso.cp_cmb_Parametro
        Me.cmb_RequiereCuentasDetalles = New Modulo_Proceso.cp_cmb_Manual
        Me.tbx_1_ClienteLibre = New Modulo_Proceso.cp_Textbox
        Me.Tab_General.SuspendLayout()
        Me.Tab_Listado.SuspendLayout()
        Me.tab_Nuevo.SuspendLayout()
        Me.gbx_Generales.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbx_Cuentas.SuspendLayout()
        Me.gbx_Referencias.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_General
        '
        Me.Tab_General.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_General.Controls.Add(Me.Tab_Listado)
        Me.Tab_General.Controls.Add(Me.tab_Nuevo)
        Me.Tab_General.Location = New System.Drawing.Point(0, 0)
        Me.Tab_General.Name = "Tab_General"
        Me.Tab_General.SelectedIndex = 0
        Me.Tab_General.Size = New System.Drawing.Size(784, 554)
        Me.Tab_General.TabIndex = 0
        '
        'Tab_Listado
        '
        Me.Tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.Tab_Listado.Controls.Add(Me.chk_Activas)
        Me.Tab_Listado.Controls.Add(Me.cmb_Banco)
        Me.Tab_Listado.Controls.Add(Me.lbl_0_Banco)
        Me.Tab_Listado.Controls.Add(Me.lbl_0_Cia)
        Me.Tab_Listado.Controls.Add(Me.cmb_Cia)
        Me.Tab_Listado.Controls.Add(Me.btn_Modificar)
        Me.Tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.Tab_Listado.Controls.Add(Me.btn_Exportar)
        Me.Tab_Listado.Controls.Add(Me.btn_Baja)
        Me.Tab_Listado.Controls.Add(Me.btn_BuscarCajaBancaria)
        Me.Tab_Listado.Controls.Add(Me.btn_Buscar)
        Me.Tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.Tab_Listado.Controls.Add(Me.Lbl_0_Buscar)
        Me.Tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.Tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Listado.Name = "Tab_Listado"
        Me.Tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Listado.Size = New System.Drawing.Size(776, 528)
        Me.Tab_Listado.TabIndex = 2
        Me.Tab_Listado.Text = "Listado"
        Me.Tab_Listado.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(556, 88)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(217, 23)
        Me.lbl_Registros.TabIndex = 50
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_Activas
        '
        Me.chk_Activas.AutoSize = True
        Me.chk_Activas.Checked = True
        Me.chk_Activas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Activas.Location = New System.Drawing.Point(75, 91)
        Me.chk_Activas.Name = "chk_Activas"
        Me.chk_Activas.Size = New System.Drawing.Size(162, 17)
        Me.chk_Activas.TabIndex = 9
        Me.chk_Activas.Text = "Solo mostrar Clientes Activos"
        Me.chk_Activas.UseVisualStyleBackColor = True
        '
        'lbl_0_Banco
        '
        Me.lbl_0_Banco.AutoSize = True
        Me.lbl_0_Banco.Location = New System.Drawing.Point(6, 40)
        Me.lbl_0_Banco.Name = "lbl_0_Banco"
        Me.lbl_0_Banco.Size = New System.Drawing.Size(62, 13)
        Me.lbl_0_Banco.TabIndex = 3
        Me.lbl_0_Banco.Text = "C. Bancaria"
        '
        'lbl_0_Cia
        '
        Me.lbl_0_Cia.AutoSize = True
        Me.lbl_0_Cia.Location = New System.Drawing.Point(14, 67)
        Me.lbl_0_Cia.Name = "lbl_0_Cia"
        Me.lbl_0_Cia.Size = New System.Drawing.Size(54, 13)
        Me.lbl_0_Cia.TabIndex = 7
        Me.lbl_0_Cia.Text = "Compañia"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Proceso.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(155, 492)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 12
        Me.btn_Modificar.Text = "&Detalles"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(631, 492)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 15
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(301, 492)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 13
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_Baja.Location = New System.Drawing.Point(9, 492)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 11
        Me.btn_Baja.Text = "&Baja / Reing."
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        Me.btn_Baja.Visible = False
        '
        'btn_BuscarCajaBancaria
        '
        Me.btn_BuscarCajaBancaria.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_BuscarCajaBancaria.Location = New System.Drawing.Point(481, 32)
        Me.btn_BuscarCajaBancaria.Name = "btn_BuscarCajaBancaria"
        Me.btn_BuscarCajaBancaria.Size = New System.Drawing.Size(25, 23)
        Me.btn_BuscarCajaBancaria.TabIndex = 6
        Me.btn_BuscarCajaBancaria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarCajaBancaria.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(636, 6)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_0_Buscar
        '
        Me.Lbl_0_Buscar.AutoSize = True
        Me.Lbl_0_Buscar.Location = New System.Drawing.Point(26, 11)
        Me.Lbl_0_Buscar.Name = "Lbl_0_Buscar"
        Me.Lbl_0_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_0_Buscar.TabIndex = 0
        Me.Lbl_0_Buscar.Text = "Buscar:"
        '
        'tab_Nuevo
        '
        Me.tab_Nuevo.Controls.Add(Me.gbx_Generales)
        Me.tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.tab_Nuevo.Controls.Add(Me.btn_Cuentas)
        Me.tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.tab_Nuevo.Name = "tab_Nuevo"
        Me.tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Nuevo.Size = New System.Drawing.Size(776, 528)
        Me.tab_Nuevo.TabIndex = 0
        Me.tab_Nuevo.Tag = "0"
        Me.tab_Nuevo.Text = "Detalles"
        Me.tab_Nuevo.UseVisualStyleBackColor = True
        '
        'gbx_Generales
        '
        Me.gbx_Generales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Generales.Controls.Add(Me.SplitContainer1)
        Me.gbx_Generales.Controls.Add(Me.btn_CajaBancariaDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_BancoDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_EstadoDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_PaisDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_GrupoDotaDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_GrupoDepoDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_GrupoDotaDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_GrupoDepositoDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_CompañiaDetalles)
        Me.gbx_Generales.Controls.Add(Me.tbx_ClienteDetalles)
        Me.gbx_Generales.Controls.Add(Me.btn_BuscarClienteDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_ClienteDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_GrupoFDetalles)
        Me.gbx_Generales.Controls.Add(Me.tbx_DireccionDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_BancoDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_PaisDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_CiudadDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_EstadoDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_RequiereCuentaDetalles)
        Me.gbx_Generales.Controls.Add(Me.tbx_ContratoDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_ContratoDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_RequiereCuentasDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_CiudadDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_DireccionDetalles)
        Me.gbx_Generales.Controls.Add(Me.cmb_GrupoFDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_CompañiaDetalles)
        Me.gbx_Generales.Controls.Add(Me.lbl_ClienteDetalles)
        Me.gbx_Generales.Controls.Add(Me.tbx_1_ClienteLibre)
        Me.gbx_Generales.Location = New System.Drawing.Point(8, 6)
        Me.gbx_Generales.Name = "gbx_Generales"
        Me.gbx_Generales.Size = New System.Drawing.Size(760, 478)
        Me.gbx_Generales.TabIndex = 0
        Me.gbx_Generales.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 234)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Cuentas)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_Referencias)
        Me.SplitContainer1.Size = New System.Drawing.Size(746, 238)
        Me.SplitContainer1.SplitterDistance = 368
        Me.SplitContainer1.TabIndex = 97
        '
        'gbx_Cuentas
        '
        Me.gbx_Cuentas.Controls.Add(Me.lsv_Cuentas)
        Me.gbx_Cuentas.Controls.Add(Me.btn_CuentasBaja)
        Me.gbx_Cuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Cuentas.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Cuentas.Name = "gbx_Cuentas"
        Me.gbx_Cuentas.Size = New System.Drawing.Size(368, 238)
        Me.gbx_Cuentas.TabIndex = 0
        Me.gbx_Cuentas.TabStop = False
        Me.gbx_Cuentas.Text = "Cuentas"
        '
        'btn_CuentasBaja
        '
        Me.btn_CuentasBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CuentasBaja.Enabled = False
        Me.btn_CuentasBaja.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_CuentasBaja.Location = New System.Drawing.Point(3, 202)
        Me.btn_CuentasBaja.Name = "btn_CuentasBaja"
        Me.btn_CuentasBaja.Size = New System.Drawing.Size(140, 30)
        Me.btn_CuentasBaja.TabIndex = 1
        Me.btn_CuentasBaja.Text = "&Baja / Reingreso"
        Me.btn_CuentasBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CuentasBaja.UseVisualStyleBackColor = True
        Me.btn_CuentasBaja.Visible = False
        '
        'gbx_Referencias
        '
        Me.gbx_Referencias.Controls.Add(Me.lsv_Referencias)
        Me.gbx_Referencias.Controls.Add(Me.btn_ReferenciaBaja)
        Me.gbx_Referencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Referencias.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Referencias.Name = "gbx_Referencias"
        Me.gbx_Referencias.Size = New System.Drawing.Size(374, 238)
        Me.gbx_Referencias.TabIndex = 1
        Me.gbx_Referencias.TabStop = False
        Me.gbx_Referencias.Text = "Referencias"
        '
        'btn_ReferenciaBaja
        '
        Me.btn_ReferenciaBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ReferenciaBaja.Enabled = False
        Me.btn_ReferenciaBaja.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_ReferenciaBaja.Location = New System.Drawing.Point(6, 202)
        Me.btn_ReferenciaBaja.Name = "btn_ReferenciaBaja"
        Me.btn_ReferenciaBaja.Size = New System.Drawing.Size(140, 30)
        Me.btn_ReferenciaBaja.TabIndex = 1
        Me.btn_ReferenciaBaja.Text = "&Baja / Reingreso"
        Me.btn_ReferenciaBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ReferenciaBaja.UseVisualStyleBackColor = True
        Me.btn_ReferenciaBaja.Visible = False
        '
        'btn_CajaBancariaDetalles
        '
        Me.btn_CajaBancariaDetalles.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_CajaBancariaDetalles.Location = New System.Drawing.Point(517, 13)
        Me.btn_CajaBancariaDetalles.Name = "btn_CajaBancariaDetalles"
        Me.btn_CajaBancariaDetalles.Size = New System.Drawing.Size(26, 23)
        Me.btn_CajaBancariaDetalles.TabIndex = 3
        Me.btn_CajaBancariaDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CajaBancariaDetalles.UseVisualStyleBackColor = True
        '
        'lbl_EstadoDetalles
        '
        Me.lbl_EstadoDetalles.AutoSize = True
        Me.lbl_EstadoDetalles.Location = New System.Drawing.Point(67, 155)
        Me.lbl_EstadoDetalles.Name = "lbl_EstadoDetalles"
        Me.lbl_EstadoDetalles.Size = New System.Drawing.Size(40, 13)
        Me.lbl_EstadoDetalles.TabIndex = 16
        Me.lbl_EstadoDetalles.Text = "Estado"
        Me.lbl_EstadoDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_PaisDetalles
        '
        Me.lbl_PaisDetalles.AutoSize = True
        Me.lbl_PaisDetalles.Location = New System.Drawing.Point(79, 128)
        Me.lbl_PaisDetalles.Name = "lbl_PaisDetalles"
        Me.lbl_PaisDetalles.Size = New System.Drawing.Size(27, 13)
        Me.lbl_PaisDetalles.TabIndex = 12
        Me.lbl_PaisDetalles.Text = "Pais"
        Me.lbl_PaisDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_GrupoDotaDetalles
        '
        Me.lbl_GrupoDotaDetalles.AutoSize = True
        Me.lbl_GrupoDotaDetalles.Location = New System.Drawing.Point(343, 128)
        Me.lbl_GrupoDotaDetalles.Name = "lbl_GrupoDotaDetalles"
        Me.lbl_GrupoDotaDetalles.Size = New System.Drawing.Size(108, 13)
        Me.lbl_GrupoDotaDetalles.TabIndex = 14
        Me.lbl_GrupoDotaDetalles.Text = "Grupo de Dotaciones"
        Me.lbl_GrupoDotaDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_GrupoDepoDetalles
        '
        Me.lbl_GrupoDepoDetalles.AutoSize = True
        Me.lbl_GrupoDepoDetalles.Location = New System.Drawing.Point(355, 155)
        Me.lbl_GrupoDepoDetalles.Name = "lbl_GrupoDepoDetalles"
        Me.lbl_GrupoDepoDetalles.Size = New System.Drawing.Size(96, 13)
        Me.lbl_GrupoDepoDetalles.TabIndex = 18
        Me.lbl_GrupoDepoDetalles.Text = "Grupo de Deposito"
        '
        'btn_BuscarClienteDetalles
        '
        Me.btn_BuscarClienteDetalles.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_BuscarClienteDetalles.Location = New System.Drawing.Point(608, 70)
        Me.btn_BuscarClienteDetalles.Name = "btn_BuscarClienteDetalles"
        Me.btn_BuscarClienteDetalles.Size = New System.Drawing.Size(26, 23)
        Me.btn_BuscarClienteDetalles.TabIndex = 9
        Me.btn_BuscarClienteDetalles.UseVisualStyleBackColor = True
        '
        'lbl_GrupoFDetalles
        '
        Me.lbl_GrupoFDetalles.AutoSize = True
        Me.lbl_GrupoFDetalles.Location = New System.Drawing.Point(356, 183)
        Me.lbl_GrupoFDetalles.Name = "lbl_GrupoFDetalles"
        Me.lbl_GrupoFDetalles.Size = New System.Drawing.Size(95, 13)
        Me.lbl_GrupoFDetalles.TabIndex = 22
        Me.lbl_GrupoFDetalles.Text = "Grupo Facturación"
        Me.lbl_GrupoFDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_RequiereCuentaDetalles
        '
        Me.lbl_RequiereCuentaDetalles.AutoSize = True
        Me.lbl_RequiereCuentaDetalles.Location = New System.Drawing.Point(4, 210)
        Me.lbl_RequiereCuentaDetalles.Name = "lbl_RequiereCuentaDetalles"
        Me.lbl_RequiereCuentaDetalles.Size = New System.Drawing.Size(101, 13)
        Me.lbl_RequiereCuentaDetalles.TabIndex = 24
        Me.lbl_RequiereCuentaDetalles.Text = "Requiere Cuentas ?"
        Me.lbl_RequiereCuentaDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_BancoDetalles
        '
        Me.lbl_BancoDetalles.AutoSize = True
        Me.lbl_BancoDetalles.Location = New System.Drawing.Point(32, 19)
        Me.lbl_BancoDetalles.Name = "lbl_BancoDetalles"
        Me.lbl_BancoDetalles.Size = New System.Drawing.Size(73, 13)
        Me.lbl_BancoDetalles.TabIndex = 0
        Me.lbl_BancoDetalles.Text = "Caja Bancaria"
        Me.lbl_BancoDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_CiudadDetalles
        '
        Me.lbl_CiudadDetalles.AutoSize = True
        Me.lbl_CiudadDetalles.Location = New System.Drawing.Point(67, 182)
        Me.lbl_CiudadDetalles.Name = "lbl_CiudadDetalles"
        Me.lbl_CiudadDetalles.Size = New System.Drawing.Size(40, 13)
        Me.lbl_CiudadDetalles.TabIndex = 20
        Me.lbl_CiudadDetalles.Text = "Ciudad"
        Me.lbl_CiudadDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ContratoDetalles
        '
        Me.lbl_ContratoDetalles.AutoSize = True
        Me.lbl_ContratoDetalles.Location = New System.Drawing.Point(370, 210)
        Me.lbl_ContratoDetalles.Name = "lbl_ContratoDetalles"
        Me.lbl_ContratoDetalles.Size = New System.Drawing.Size(81, 13)
        Me.lbl_ContratoDetalles.TabIndex = 26
        Me.lbl_ContratoDetalles.Text = "Contrato Banco"
        Me.lbl_ContratoDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_DireccionDetalles
        '
        Me.lbl_DireccionDetalles.AutoSize = True
        Me.lbl_DireccionDetalles.Location = New System.Drawing.Point(53, 100)
        Me.lbl_DireccionDetalles.Name = "lbl_DireccionDetalles"
        Me.lbl_DireccionDetalles.Size = New System.Drawing.Size(52, 13)
        Me.lbl_DireccionDetalles.TabIndex = 10
        Me.lbl_DireccionDetalles.Text = "Dirección"
        Me.lbl_DireccionDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_CompañiaDetalles
        '
        Me.lbl_CompañiaDetalles.AutoSize = True
        Me.lbl_CompañiaDetalles.Location = New System.Drawing.Point(32, 45)
        Me.lbl_CompañiaDetalles.Name = "lbl_CompañiaDetalles"
        Me.lbl_CompañiaDetalles.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CompañiaDetalles.TabIndex = 4
        Me.lbl_CompañiaDetalles.Text = "Compañía TV"
        Me.lbl_CompañiaDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ClienteDetalles
        '
        Me.lbl_ClienteDetalles.AutoSize = True
        Me.lbl_ClienteDetalles.Location = New System.Drawing.Point(66, 73)
        Me.lbl_ClienteDetalles.Name = "lbl_ClienteDetalles"
        Me.lbl_ClienteDetalles.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ClienteDetalles.TabIndex = 6
        Me.lbl_ClienteDetalles.Text = "Cliente"
        Me.lbl_ClienteDetalles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(628, 490)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 3
        Me.btn_Cancelar.Text = "&Regresar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cuentas
        '
        Me.btn_Cuentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cuentas.Enabled = False
        Me.btn_Cuentas.Image = Global.Modulo_Proceso.My.Resources.Resources.Agregar
        Me.btn_Cuentas.Location = New System.Drawing.Point(154, 490)
        Me.btn_Cuentas.Name = "btn_Cuentas"
        Me.btn_Cuentas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cuentas.TabIndex = 2
        Me.btn_Cuentas.Text = "&Agregar Cuentas"
        Me.btn_Cuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cuentas.UseVisualStyleBackColor = True
        Me.btn_Cuentas.Visible = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(8, 490)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        Me.btn_Guardar.Visible = False
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Clave = "Clave_Cliente"
        Me.cmb_Banco.Control_Siguiente = Me.cmb_Cia
        Me.cmb_Banco.DisplayMember = "Nombre Comercial"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.Filtro = Nothing
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(75, 34)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = False
        Me.cmb_Banco.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Banco.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_Banco.Sucursal = True
        Me.cmb_Banco.TabIndex = 5
        Me.cmb_Banco.Tipo = 0
        Me.cmb_Banco.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Control_Siguiente = Me.lsv_Catalogo
        Me.cmb_Cia.DisplayMember = "Nombre"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(75, 64)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(490, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 8
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(4, 114)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 20
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 20
        Me.lsv_Catalogo.Row3 = 20
        Me.lsv_Catalogo.Row4 = 20
        Me.lsv_Catalogo.Row5 = 20
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(769, 373)
        Me.lsv_Catalogo.TabIndex = 10
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(75, 8)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(554, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Cuentas
        '
        Me.lsv_Cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cuentas.FullRowSelect = True
        Me.lsv_Cuentas.HideSelection = False
        Me.lsv_Cuentas.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Cuentas.Lvs = ListViewColumnSorter2
        Me.lsv_Cuentas.MultiSelect = False
        Me.lsv_Cuentas.Name = "lsv_Cuentas"
        Me.lsv_Cuentas.Row1 = 35
        Me.lsv_Cuentas.Row10 = 0
        Me.lsv_Cuentas.Row2 = 35
        Me.lsv_Cuentas.Row3 = 25
        Me.lsv_Cuentas.Row4 = 0
        Me.lsv_Cuentas.Row5 = 0
        Me.lsv_Cuentas.Row6 = 0
        Me.lsv_Cuentas.Row7 = 0
        Me.lsv_Cuentas.Row8 = 0
        Me.lsv_Cuentas.Row9 = 0
        Me.lsv_Cuentas.Size = New System.Drawing.Size(362, 180)
        Me.lsv_Cuentas.TabIndex = 0
        Me.lsv_Cuentas.UseCompatibleStateImageBehavior = False
        Me.lsv_Cuentas.View = System.Windows.Forms.View.Details
        '
        'lsv_Referencias
        '
        Me.lsv_Referencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Referencias.FullRowSelect = True
        Me.lsv_Referencias.HideSelection = False
        Me.lsv_Referencias.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Referencias.Lvs = ListViewColumnSorter3
        Me.lsv_Referencias.MultiSelect = False
        Me.lsv_Referencias.Name = "lsv_Referencias"
        Me.lsv_Referencias.Row1 = 20
        Me.lsv_Referencias.Row10 = 0
        Me.lsv_Referencias.Row2 = 20
        Me.lsv_Referencias.Row3 = 20
        Me.lsv_Referencias.Row4 = 10
        Me.lsv_Referencias.Row5 = 10
        Me.lsv_Referencias.Row6 = 5
        Me.lsv_Referencias.Row7 = 5
        Me.lsv_Referencias.Row8 = 0
        Me.lsv_Referencias.Row9 = 0
        Me.lsv_Referencias.Size = New System.Drawing.Size(368, 180)
        Me.lsv_Referencias.TabIndex = 0
        Me.lsv_Referencias.UseCompatibleStateImageBehavior = False
        Me.lsv_Referencias.View = System.Windows.Forms.View.Details
        '
        'cmb_BancoDetalles
        '
        Me.cmb_BancoDetalles.Clave = "Clave_Cliente"
        Me.cmb_BancoDetalles.Control_Siguiente = Me.cmb_CompañiaDetalles
        Me.cmb_BancoDetalles.DisplayMember = "Nombre Comercial"
        Me.cmb_BancoDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BancoDetalles.Empresa = False
        Me.cmb_BancoDetalles.Filtro = Nothing
        Me.cmb_BancoDetalles.FormattingEnabled = True
        Me.cmb_BancoDetalles.Location = New System.Drawing.Point(111, 15)
        Me.cmb_BancoDetalles.MaxDropDownItems = 20
        Me.cmb_BancoDetalles.Name = "cmb_BancoDetalles"
        Me.cmb_BancoDetalles.Pista = False
        Me.cmb_BancoDetalles.Size = New System.Drawing.Size(400, 21)
        Me.cmb_BancoDetalles.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_BancoDetalles.Sucursal = True
        Me.cmb_BancoDetalles.TabIndex = 2
        Me.cmb_BancoDetalles.Tipo = 0
        Me.cmb_BancoDetalles.ValueMember = "Id_CajaBancaria"
        '
        'cmb_CompañiaDetalles
        '
        Me.cmb_CompañiaDetalles.Control_Siguiente = Me.tbx_ClienteDetalles
        Me.cmb_CompañiaDetalles.DisplayMember = "Nombre"
        Me.cmb_CompañiaDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CompañiaDetalles.Empresa = False
        Me.cmb_CompañiaDetalles.FormattingEnabled = True
        Me.cmb_CompañiaDetalles.Location = New System.Drawing.Point(111, 42)
        Me.cmb_CompañiaDetalles.MaxDropDownItems = 20
        Me.cmb_CompañiaDetalles.Name = "cmb_CompañiaDetalles"
        Me.cmb_CompañiaDetalles.Pista = True
        Me.cmb_CompañiaDetalles.Size = New System.Drawing.Size(491, 21)
        Me.cmb_CompañiaDetalles.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_CompañiaDetalles.Sucursal = False
        Me.cmb_CompañiaDetalles.TabIndex = 5
        Me.cmb_CompañiaDetalles.ValueMember = "Id_Cia"
        '
        'tbx_ClienteDetalles
        '
        Me.tbx_ClienteDetalles.Control_Siguiente = Nothing
        Me.tbx_ClienteDetalles.Filtrado = True
        Me.tbx_ClienteDetalles.Location = New System.Drawing.Point(111, 70)
        Me.tbx_ClienteDetalles.MaxLength = 12
        Me.tbx_ClienteDetalles.Name = "tbx_ClienteDetalles"
        Me.tbx_ClienteDetalles.Size = New System.Drawing.Size(85, 20)
        Me.tbx_ClienteDetalles.TabIndex = 7
        Me.tbx_ClienteDetalles.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_GrupoDotaDetalles
        '
        Me.cmb_GrupoDotaDetalles.Cia = False
        Me.cmb_GrupoDotaDetalles.Control_Siguiente = Me.cmb_GrupoDepositoDetalles
        Me.cmb_GrupoDotaDetalles.DisplayMember = "Descripcion"
        Me.cmb_GrupoDotaDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GrupoDotaDetalles.Empresa = False
        Me.cmb_GrupoDotaDetalles.FormattingEnabled = True
        Me.cmb_GrupoDotaDetalles.Location = New System.Drawing.Point(457, 125)
        Me.cmb_GrupoDotaDetalles.MaxDropDownItems = 20
        Me.cmb_GrupoDotaDetalles.Name = "cmb_GrupoDotaDetalles"
        Me.cmb_GrupoDotaDetalles.NombreParametro = "@Id_CajaBancaria"
        Me.cmb_GrupoDotaDetalles.Pista = True
        Me.cmb_GrupoDotaDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_GrupoDotaDetalles.StoredProcedure = "Cat_GrupoDota_Get"
        Me.cmb_GrupoDotaDetalles.Sucursal = False
        Me.cmb_GrupoDotaDetalles.TabIndex = 15
        Me.cmb_GrupoDotaDetalles.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_GrupoDotaDetalles.ValorParametro = Nothing
        Me.cmb_GrupoDotaDetalles.ValueMember = "Id_GrupoDota"
        '
        'cmb_GrupoDepositoDetalles
        '
        Me.cmb_GrupoDepositoDetalles.Cia = False
        Me.cmb_GrupoDepositoDetalles.Control_Siguiente = Me.cmb_GrupoFDetalles
        Me.cmb_GrupoDepositoDetalles.DisplayMember = "Descripcion"
        Me.cmb_GrupoDepositoDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GrupoDepositoDetalles.Empresa = False
        Me.cmb_GrupoDepositoDetalles.FormattingEnabled = True
        Me.cmb_GrupoDepositoDetalles.Location = New System.Drawing.Point(457, 152)
        Me.cmb_GrupoDepositoDetalles.MaxDropDownItems = 20
        Me.cmb_GrupoDepositoDetalles.Name = "cmb_GrupoDepositoDetalles"
        Me.cmb_GrupoDepositoDetalles.NombreParametro = "@Id_CajaBancaria"
        Me.cmb_GrupoDepositoDetalles.Pista = True
        Me.cmb_GrupoDepositoDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_GrupoDepositoDetalles.StoredProcedure = "Cat_GrupoDeposito_Get"
        Me.cmb_GrupoDepositoDetalles.Sucursal = False
        Me.cmb_GrupoDepositoDetalles.TabIndex = 19
        Me.cmb_GrupoDepositoDetalles.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_GrupoDepositoDetalles.ValorParametro = Nothing
        Me.cmb_GrupoDepositoDetalles.ValueMember = "Id_GrupoDepo"
        '
        'cmb_GrupoFDetalles
        '
        Me.cmb_GrupoFDetalles.Cia = False
        Me.cmb_GrupoFDetalles.Control_Siguiente = Me.tbx_ContratoDetalles
        Me.cmb_GrupoFDetalles.DisplayMember = "Descripcion"
        Me.cmb_GrupoFDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GrupoFDetalles.Empresa = False
        Me.cmb_GrupoFDetalles.FormattingEnabled = True
        Me.cmb_GrupoFDetalles.Location = New System.Drawing.Point(457, 180)
        Me.cmb_GrupoFDetalles.MaxDropDownItems = 20
        Me.cmb_GrupoFDetalles.Name = "cmb_GrupoFDetalles"
        Me.cmb_GrupoFDetalles.NombreParametro = "@Id_CajaBancaria"
        Me.cmb_GrupoFDetalles.Pista = False
        Me.cmb_GrupoFDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_GrupoFDetalles.StoredProcedure = "Pro_GruposFactura_Get"
        Me.cmb_GrupoFDetalles.Sucursal = False
        Me.cmb_GrupoFDetalles.TabIndex = 23
        Me.cmb_GrupoFDetalles.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_GrupoFDetalles.ValorParametro = Nothing
        Me.cmb_GrupoFDetalles.ValueMember = "Id_GrupoF"
        '
        'tbx_ContratoDetalles
        '
        Me.tbx_ContratoDetalles.Control_Siguiente = Nothing
        Me.tbx_ContratoDetalles.Filtrado = True
        Me.tbx_ContratoDetalles.Location = New System.Drawing.Point(457, 207)
        Me.tbx_ContratoDetalles.MaxLength = 50
        Me.tbx_ContratoDetalles.Name = "tbx_ContratoDetalles"
        Me.tbx_ContratoDetalles.Size = New System.Drawing.Size(228, 20)
        Me.tbx_ContratoDetalles.TabIndex = 27
        Me.tbx_ContratoDetalles.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_ClienteDetalles
        '
        Me.cmb_ClienteDetalles.Clave = "Clave_Cliente"
        Me.cmb_ClienteDetalles.Control_Siguiente = Nothing
        Me.cmb_ClienteDetalles.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClienteDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClienteDetalles.Empresa = False
        Me.cmb_ClienteDetalles.Filtro = Me.tbx_ClienteDetalles
        Me.cmb_ClienteDetalles.FormattingEnabled = True
        Me.cmb_ClienteDetalles.Location = New System.Drawing.Point(202, 70)
        Me.cmb_ClienteDetalles.MaxDropDownItems = 20
        Me.cmb_ClienteDetalles.Name = "cmb_ClienteDetalles"
        Me.cmb_ClienteDetalles.Pista = True
        Me.cmb_ClienteDetalles.Size = New System.Drawing.Size(400, 21)
        Me.cmb_ClienteDetalles.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_ClienteDetalles.Sucursal = True
        Me.cmb_ClienteDetalles.TabIndex = 8
        Me.cmb_ClienteDetalles.Tipo = 0
        Me.cmb_ClienteDetalles.ValueMember = "Id_Cliente"
        '
        'tbx_DireccionDetalles
        '
        Me.tbx_DireccionDetalles.Control_Siguiente = Me.cmb_PaisDetalles
        Me.tbx_DireccionDetalles.Filtrado = True
        Me.tbx_DireccionDetalles.Location = New System.Drawing.Point(111, 97)
        Me.tbx_DireccionDetalles.MaxLength = 150
        Me.tbx_DireccionDetalles.Name = "tbx_DireccionDetalles"
        Me.tbx_DireccionDetalles.Size = New System.Drawing.Size(574, 20)
        Me.tbx_DireccionDetalles.TabIndex = 11
        Me.tbx_DireccionDetalles.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_PaisDetalles
        '
        Me.cmb_PaisDetalles.Control_Siguiente = Me.cmb_EstadoDetalles
        Me.cmb_PaisDetalles.DisplayMember = "Nombre"
        Me.cmb_PaisDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PaisDetalles.Empresa = False
        Me.cmb_PaisDetalles.FormattingEnabled = True
        Me.cmb_PaisDetalles.Location = New System.Drawing.Point(112, 125)
        Me.cmb_PaisDetalles.MaxDropDownItems = 20
        Me.cmb_PaisDetalles.Name = "cmb_PaisDetalles"
        Me.cmb_PaisDetalles.Pista = True
        Me.cmb_PaisDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_PaisDetalles.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_PaisDetalles.Sucursal = False
        Me.cmb_PaisDetalles.TabIndex = 13
        Me.cmb_PaisDetalles.ValueMember = "Id_Pais"
        '
        'cmb_EstadoDetalles
        '
        Me.cmb_EstadoDetalles.Cia = False
        Me.cmb_EstadoDetalles.Control_Siguiente = Me.cmb_CiudadDetalles
        Me.cmb_EstadoDetalles.DisplayMember = "Nombre"
        Me.cmb_EstadoDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EstadoDetalles.Empresa = False
        Me.cmb_EstadoDetalles.FormattingEnabled = True
        Me.cmb_EstadoDetalles.Location = New System.Drawing.Point(113, 152)
        Me.cmb_EstadoDetalles.MaxDropDownItems = 20
        Me.cmb_EstadoDetalles.Name = "cmb_EstadoDetalles"
        Me.cmb_EstadoDetalles.NombreParametro = "@Id_Pais"
        Me.cmb_EstadoDetalles.Pista = True
        Me.cmb_EstadoDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_EstadoDetalles.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_EstadoDetalles.Sucursal = False
        Me.cmb_EstadoDetalles.TabIndex = 17
        Me.cmb_EstadoDetalles.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_EstadoDetalles.ValorParametro = Nothing
        Me.cmb_EstadoDetalles.ValueMember = "Id_Estado"
        '
        'cmb_CiudadDetalles
        '
        Me.cmb_CiudadDetalles.Cia = False
        Me.cmb_CiudadDetalles.Control_Siguiente = Me.lbl_RequiereCuentaDetalles
        Me.cmb_CiudadDetalles.DisplayMember = "Nombre"
        Me.cmb_CiudadDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadDetalles.Empresa = False
        Me.cmb_CiudadDetalles.FormattingEnabled = True
        Me.cmb_CiudadDetalles.Location = New System.Drawing.Point(113, 179)
        Me.cmb_CiudadDetalles.MaxDropDownItems = 20
        Me.cmb_CiudadDetalles.Name = "cmb_CiudadDetalles"
        Me.cmb_CiudadDetalles.NombreParametro = "@Id_Estado"
        Me.cmb_CiudadDetalles.Pista = True
        Me.cmb_CiudadDetalles.Size = New System.Drawing.Size(228, 21)
        Me.cmb_CiudadDetalles.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_CiudadDetalles.Sucursal = False
        Me.cmb_CiudadDetalles.TabIndex = 21
        Me.cmb_CiudadDetalles.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_CiudadDetalles.ValorParametro = Nothing
        Me.cmb_CiudadDetalles.ValueMember = "Id_Ciudad"
        '
        'cmb_RequiereCuentasDetalles
        '
        Me.cmb_RequiereCuentasDetalles.Control_Siguiente = Me.cmb_GrupoDotaDetalles
        Me.cmb_RequiereCuentasDetalles.DisplayMember = "display"
        Me.cmb_RequiereCuentasDetalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RequiereCuentasDetalles.FormattingEnabled = True
        Me.cmb_RequiereCuentasDetalles.Location = New System.Drawing.Point(111, 207)
        Me.cmb_RequiereCuentasDetalles.MaxDropDownItems = 20
        Me.cmb_RequiereCuentasDetalles.Name = "cmb_RequiereCuentasDetalles"
        Me.cmb_RequiereCuentasDetalles.Size = New System.Drawing.Size(89, 21)
        Me.cmb_RequiereCuentasDetalles.TabIndex = 25
        Me.cmb_RequiereCuentasDetalles.ValueMember = "value"
        '
        'tbx_1_ClienteLibre
        '
        Me.tbx_1_ClienteLibre.Control_Siguiente = Me.tbx_DireccionDetalles
        Me.tbx_1_ClienteLibre.Filtrado = True
        Me.tbx_1_ClienteLibre.Location = New System.Drawing.Point(112, 70)
        Me.tbx_1_ClienteLibre.MaxLength = 150
        Me.tbx_1_ClienteLibre.Name = "tbx_1_ClienteLibre"
        Me.tbx_1_ClienteLibre.Size = New System.Drawing.Size(490, 20)
        Me.tbx_1_ClienteLibre.TabIndex = 4
        Me.tbx_1_ClienteLibre.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.tbx_1_ClienteLibre.Visible = False
        '
        'frm_ClientesProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Tab_General)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ClientesProceso"
        Me.Text = "Catalogo de Clientes con Proceso"
        Me.Tab_General.ResumeLayout(False)
        Me.Tab_Listado.ResumeLayout(False)
        Me.Tab_Listado.PerformLayout()
        Me.tab_Nuevo.ResumeLayout(False)
        Me.gbx_Generales.ResumeLayout(False)
        Me.gbx_Generales.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbx_Cuentas.ResumeLayout(False)
        Me.gbx_Referencias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_General As System.Windows.Forms.TabControl
    Friend WithEvents tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents cmb_ClienteDetalles As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClienteDetalles As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_ClienteDetalles As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarClienteDetalles As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_CompañiaDetalles As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_CompañiaDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_DireccionDetalles As System.Windows.Forms.Label
    Friend WithEvents tbx_DireccionDetalles As Modulo_Proceso.cp_Textbox
    Friend WithEvents cmb_EstadoDetalles As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_EstadoDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_PaisDetalles As System.Windows.Forms.Label
    Friend WithEvents cmb_PaisDetalles As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents tbx_ContratoDetalles As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_ContratoDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_RequiereCuentaDetalles As System.Windows.Forms.Label
    Friend WithEvents cmb_RequiereCuentasDetalles As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents cmb_CiudadDetalles As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_CiudadDetalles As System.Windows.Forms.Label
    Friend WithEvents lbl_GrupoFDetalles As System.Windows.Forms.Label
    Friend WithEvents cmb_GrupoFDetalles As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_BancoDetalles As System.Windows.Forms.Label
    Friend WithEvents tbx_1_ClienteLibre As Modulo_Proceso.cp_Textbox
    Friend WithEvents Tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_0_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_0_Banco As System.Windows.Forms.Label
    Friend WithEvents lbl_0_Cia As System.Windows.Forms.Label
    Friend WithEvents cmb_Cia As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents gbx_Generales As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cuentas As System.Windows.Forms.Button
    Friend WithEvents gbx_Cuentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Referencias As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Cuentas As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_Referencias As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_GrupoDepoDetalles As System.Windows.Forms.Label
    Friend WithEvents cmb_GrupoDotaDetalles As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents cmb_GrupoDepositoDetalles As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_GrupoDotaDetalles As System.Windows.Forms.Label
    Friend WithEvents cmb_BancoDetalles As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Banco As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_BuscarCajaBancaria As System.Windows.Forms.Button
    Friend WithEvents btn_CajaBancariaDetalles As System.Windows.Forms.Button
    Friend WithEvents btn_CuentasBaja As System.Windows.Forms.Button
    Friend WithEvents btn_ReferenciaBaja As System.Windows.Forms.Button
    Friend WithEvents chk_Activas As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
