<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CatalogoOrdenesCuentas
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
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Me.gbx_Entradas = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.lbl_NombreCliente = New System.Windows.Forms.Label()
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label()
        Me.gbx_Cuentas = New System.Windows.Forms.GroupBox()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Baja = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_CerrarExp = New System.Windows.Forms.Button()
        Me.lsv_CuentasClientes = New Modulo_Proceso.cp_Listview()
        Me.tbx_Cuenta = New Modulo_Proceso.cp_Textbox()
        Me.tbx_Cliente = New Modulo_Proceso.cp_Textbox()
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado()
        Me.gbx_Entradas.SuspendLayout()
        Me.gbx_Cuentas.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Entradas
        '
        Me.gbx_Entradas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Entradas.Controls.Add(Me.Label1)
        Me.gbx_Entradas.Controls.Add(Me.tbx_Cuenta)
        Me.gbx_Entradas.Controls.Add(Me.btn_Guardar)
        Me.gbx_Entradas.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Entradas.Controls.Add(Me.lbl_NombreCliente)
        Me.gbx_Entradas.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Entradas.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Entradas.Location = New System.Drawing.Point(7, 6)
        Me.gbx_Entradas.Name = "gbx_Entradas"
        Me.gbx_Entradas.Size = New System.Drawing.Size(705, 117)
        Me.gbx_Entradas.TabIndex = 0
        Me.gbx_Entradas.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Cuenta"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(385, 72)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(100, 30)
        Me.btn_Guardar.TabIndex = 14
        Me.btn_Guardar.Tag = "0"
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_NombreCliente
        '
        Me.lbl_NombreCliente.AutoSize = True
        Me.lbl_NombreCliente.Location = New System.Drawing.Point(42, 46)
        Me.lbl_NombreCliente.Name = "lbl_NombreCliente"
        Me.lbl_NombreCliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_NombreCliente.TabIndex = 12
        Me.lbl_NombreCliente.Text = "Cliente"
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(8, 19)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 11
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'gbx_Cuentas
        '
        Me.gbx_Cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cuentas.Controls.Add(Me.lsv_CuentasClientes)
        Me.gbx_Cuentas.Location = New System.Drawing.Point(7, 129)
        Me.gbx_Cuentas.Name = "gbx_Cuentas"
        Me.gbx_Cuentas.Size = New System.Drawing.Size(705, 281)
        Me.gbx_Cuentas.TabIndex = 1
        Me.gbx_Cuentas.TabStop = False
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Baja)
        Me.gbx_Botones.Controls.Add(Me.btn_Modificar)
        Me.gbx_Botones.Controls.Add(Me.btn_CerrarExp)
        Me.gbx_Botones.Location = New System.Drawing.Point(7, 416)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(705, 58)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Location = New System.Drawing.Point(351, 19)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Location = New System.Drawing.Point(205, 19)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 4
        Me.btn_Baja.Text = "&Baja"
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Location = New System.Drawing.Point(9, 19)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 2
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_CerrarExp
        '
        Me.btn_CerrarExp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CerrarExp.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_CerrarExp.Location = New System.Drawing.Point(548, 19)
        Me.btn_CerrarExp.Name = "btn_CerrarExp"
        Me.btn_CerrarExp.Size = New System.Drawing.Size(140, 30)
        Me.btn_CerrarExp.TabIndex = 3
        Me.btn_CerrarExp.Text = "&Cerrar"
        Me.btn_CerrarExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CerrarExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CerrarExp.UseVisualStyleBackColor = True
        '
        'lsv_CuentasClientes
        '
        Me.lsv_CuentasClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_CuentasClientes.FullRowSelect = True
        Me.lsv_CuentasClientes.HideSelection = False
        Me.lsv_CuentasClientes.Location = New System.Drawing.Point(9, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_CuentasClientes.Lvs = ListViewColumnSorter1
        Me.lsv_CuentasClientes.MultiSelect = False
        Me.lsv_CuentasClientes.Name = "lsv_CuentasClientes"
        Me.lsv_CuentasClientes.Row1 = 30
        Me.lsv_CuentasClientes.Row10 = 10
        Me.lsv_CuentasClientes.Row2 = 30
        Me.lsv_CuentasClientes.Row3 = 30
        Me.lsv_CuentasClientes.Row4 = 30
        Me.lsv_CuentasClientes.Row5 = 10
        Me.lsv_CuentasClientes.Row6 = 10
        Me.lsv_CuentasClientes.Row7 = 10
        Me.lsv_CuentasClientes.Row8 = 10
        Me.lsv_CuentasClientes.Row9 = 10
        Me.lsv_CuentasClientes.Size = New System.Drawing.Size(690, 256)
        Me.lsv_CuentasClientes.TabIndex = 0
        Me.lsv_CuentasClientes.UseCompatibleStateImageBehavior = False
        Me.lsv_CuentasClientes.View = System.Windows.Forms.View.Details
        '
        'tbx_Cuenta
        '
        Me.tbx_Cuenta.Control_Siguiente = Nothing
        Me.tbx_Cuenta.Filtrado = False
        Me.tbx_Cuenta.Location = New System.Drawing.Point(85, 69)
        Me.tbx_Cuenta.MaxLength = 15
        Me.tbx_Cuenta.Name = "tbx_Cuenta"
        Me.tbx_Cuenta.Size = New System.Drawing.Size(204, 20)
        Me.tbx_Cuenta.TabIndex = 15
        Me.tbx_Cuenta.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Nothing
        Me.tbx_Cliente.Filtrado = False
        Me.tbx_Cliente.Location = New System.Drawing.Point(85, 43)
        Me.tbx_Cliente.MaxLength = 200
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Cliente.TabIndex = 13
        Me.tbx_Cliente.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = ""
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(85, 16)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 10
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'frm_CatalogoOrdenesCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 486)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Cuentas)
        Me.Controls.Add(Me.gbx_Entradas)
        Me.Name = "frm_CatalogoOrdenesCuentas"
        Me.Text = "Catalogo de ördenes de Cuentas"
        Me.gbx_Entradas.ResumeLayout(False)
        Me.gbx_Entradas.PerformLayout()
        Me.gbx_Cuentas.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Entradas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Cuentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_NombreCliente As System.Windows.Forms.Label
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Cliente As Modulo_Proceso.cp_Textbox
    Friend WithEvents lsv_CuentasClientes As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_CerrarExp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Cuenta As Modulo_Proceso.cp_Textbox
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
End Class
