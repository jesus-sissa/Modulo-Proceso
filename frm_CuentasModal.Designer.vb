<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CuentasModal
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
        Me.gbx_Banco = New System.Windows.Forms.GroupBox
        Me.Lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cbx_Todos = New System.Windows.Forms.CheckBox
        Me.cmb_ClientesP = New Modulo_Proceso.cp_cmb_Parametro
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.cmb_Banco = New Modulo_Proceso.cp_cmb_Simple
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Btn_GuardarTodo = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Listados = New System.Windows.Forms.GroupBox
        Me.Lbl_Buscar2 = New System.Windows.Forms.Label
        Me.tbx_BuscarR = New System.Windows.Forms.TextBox
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_ReferenciasAdd = New Modulo_Proceso.cp_Listview
        Me.tbx_Buscar = New System.Windows.Forms.TextBox
        Me.lsv_Cuentas = New Modulo_Proceso.cp_Listview
        Me.lsv_CuentasAdd = New Modulo_Proceso.cp_Listview
        Me.lsv_Referencias = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.gbx_Banco.SuspendLayout()
        Me.Gbx_Listados.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Banco
        '
        Me.gbx_Banco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Banco.Controls.Add(Me.Lbl_CajaBancaria)
        Me.gbx_Banco.Controls.Add(Me.cbx_Todos)
        Me.gbx_Banco.Controls.Add(Me.cmb_ClientesP)
        Me.gbx_Banco.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Banco.Controls.Add(Me.cmb_Banco)
        Me.gbx_Banco.Location = New System.Drawing.Point(6, 4)
        Me.gbx_Banco.Name = "gbx_Banco"
        Me.gbx_Banco.Size = New System.Drawing.Size(784, 68)
        Me.gbx_Banco.TabIndex = 0
        Me.gbx_Banco.TabStop = False
        '
        'Lbl_CajaBancaria
        '
        Me.Lbl_CajaBancaria.AutoSize = True
        Me.Lbl_CajaBancaria.Location = New System.Drawing.Point(15, 16)
        Me.Lbl_CajaBancaria.Name = "Lbl_CajaBancaria"
        Me.Lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.Lbl_CajaBancaria.TabIndex = 0
        Me.Lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cbx_Todos
        '
        Me.cbx_Todos.AutoSize = True
        Me.cbx_Todos.Checked = True
        Me.cbx_Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_Todos.Location = New System.Drawing.Point(500, 43)
        Me.cbx_Todos.Name = "cbx_Todos"
        Me.cbx_Todos.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Todos.TabIndex = 4
        Me.cbx_Todos.Text = "Todos"
        Me.cbx_Todos.UseVisualStyleBackColor = True
        '
        'cmb_ClientesP
        '
        Me.cmb_ClientesP.Cia = False
        Me.cmb_ClientesP.Control_Siguiente = Nothing
        Me.cmb_ClientesP.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClientesP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClientesP.Empresa = False
        Me.cmb_ClientesP.Enabled = False
        Me.cmb_ClientesP.FormattingEnabled = True
        Me.cmb_ClientesP.Location = New System.Drawing.Point(94, 39)
        Me.cmb_ClientesP.MaxDropDownItems = 20
        Me.cmb_ClientesP.Name = "cmb_ClientesP"
        Me.cmb_ClientesP.NombreParametro = "@Id_CajaBancaria"
        Me.cmb_ClientesP.Pista = False
        Me.cmb_ClientesP.Size = New System.Drawing.Size(400, 21)
        Me.cmb_ClientesP.StoredProcedure = "Cat_ClientesP_GetByCaja"
        Me.cmb_ClientesP.Sucursal = False
        Me.cmb_ClientesP.TabIndex = 3
        Me.cmb_ClientesP.Tipodedatos = System.Data.SqlDbType.Int
        Me.cmb_ClientesP.ValorParametro = Nothing
        Me.cmb_ClientesP.ValueMember = "Id_ClienteP"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(49, 42)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 2
        Me.lbl_Cliente.Text = "Cliente"
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Control_Siguiente = Nothing
        Me.cmb_Banco.DisplayMember = "Nombre Comercial"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(94, 13)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = False
        Me.cmb_Banco.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Banco.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_Banco.Sucursal = True
        Me.cmb_Banco.TabIndex = 1
        Me.cmb_Banco.ValueMember = "Id_CajaBancaria"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Agregar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 244)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "&Agregar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_GuardarTodo
        '
        Me.Btn_GuardarTodo.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.Btn_GuardarTodo.Location = New System.Drawing.Point(12, 13)
        Me.Btn_GuardarTodo.Name = "Btn_GuardarTodo"
        Me.Btn_GuardarTodo.Size = New System.Drawing.Size(140, 30)
        Me.Btn_GuardarTodo.TabIndex = 0
        Me.Btn_GuardarTodo.Text = "&Guardar"
        Me.Btn_GuardarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_GuardarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_GuardarTodo.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(638, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Listados
        '
        Me.Gbx_Listados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listados.Controls.Add(Me.Lbl_Buscar2)
        Me.Gbx_Listados.Controls.Add(Me.tbx_BuscarR)
        Me.Gbx_Listados.Controls.Add(Me.Lbl_Buscar)
        Me.Gbx_Listados.Controls.Add(Me.lsv_ReferenciasAdd)
        Me.Gbx_Listados.Controls.Add(Me.tbx_Buscar)
        Me.Gbx_Listados.Controls.Add(Me.lsv_Cuentas)
        Me.Gbx_Listados.Controls.Add(Me.lsv_CuentasAdd)
        Me.Gbx_Listados.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Listados.Controls.Add(Me.lsv_Referencias)
        Me.Gbx_Listados.Location = New System.Drawing.Point(6, 78)
        Me.Gbx_Listados.Name = "Gbx_Listados"
        Me.Gbx_Listados.Size = New System.Drawing.Size(784, 434)
        Me.Gbx_Listados.TabIndex = 1
        Me.Gbx_Listados.TabStop = False
        '
        'Lbl_Buscar2
        '
        Me.Lbl_Buscar2.AutoSize = True
        Me.Lbl_Buscar2.Location = New System.Drawing.Point(469, 16)
        Me.Lbl_Buscar2.Name = "Lbl_Buscar2"
        Me.Lbl_Buscar2.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Buscar2.TabIndex = 3
        Me.Lbl_Buscar2.Text = "Buscar"
        '
        'tbx_BuscarR
        '
        Me.tbx_BuscarR.Location = New System.Drawing.Point(515, 13)
        Me.tbx_BuscarR.Name = "tbx_BuscarR"
        Me.tbx_BuscarR.Size = New System.Drawing.Size(261, 20)
        Me.tbx_BuscarR.TabIndex = 4
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(8, 16)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar"
        '
        'lsv_ReferenciasAdd
        '
        Me.lsv_ReferenciasAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ReferenciasAdd.FullRowSelect = True
        Me.lsv_ReferenciasAdd.HideSelection = False
        Me.lsv_ReferenciasAdd.Location = New System.Drawing.Point(472, 279)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ReferenciasAdd.Lvs = ListViewColumnSorter1
        Me.lsv_ReferenciasAdd.MultiSelect = False
        Me.lsv_ReferenciasAdd.Name = "lsv_ReferenciasAdd"
        Me.lsv_ReferenciasAdd.Row1 = 40
        Me.lsv_ReferenciasAdd.Row10 = 0
        Me.lsv_ReferenciasAdd.Row2 = 40
        Me.lsv_ReferenciasAdd.Row3 = 0
        Me.lsv_ReferenciasAdd.Row4 = 0
        Me.lsv_ReferenciasAdd.Row5 = 0
        Me.lsv_ReferenciasAdd.Row6 = 0
        Me.lsv_ReferenciasAdd.Row7 = 0
        Me.lsv_ReferenciasAdd.Row8 = 0
        Me.lsv_ReferenciasAdd.Row9 = 0
        Me.lsv_ReferenciasAdd.Size = New System.Drawing.Size(305, 146)
        Me.lsv_ReferenciasAdd.TabIndex = 8
        Me.lsv_ReferenciasAdd.UseCompatibleStateImageBehavior = False
        Me.lsv_ReferenciasAdd.View = System.Windows.Forms.View.Details
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Location = New System.Drawing.Point(52, 12)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(411, 20)
        Me.tbx_Buscar.TabIndex = 1
        '
        'lsv_Cuentas
        '
        Me.lsv_Cuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cuentas.FullRowSelect = True
        Me.lsv_Cuentas.HideSelection = False
        Me.lsv_Cuentas.Location = New System.Drawing.Point(6, 38)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Cuentas.Lvs = ListViewColumnSorter2
        Me.lsv_Cuentas.MultiSelect = False
        Me.lsv_Cuentas.Name = "lsv_Cuentas"
        Me.lsv_Cuentas.Row1 = 25
        Me.lsv_Cuentas.Row10 = 0
        Me.lsv_Cuentas.Row2 = 25
        Me.lsv_Cuentas.Row3 = 15
        Me.lsv_Cuentas.Row4 = 15
        Me.lsv_Cuentas.Row5 = 15
        Me.lsv_Cuentas.Row6 = 0
        Me.lsv_Cuentas.Row7 = 0
        Me.lsv_Cuentas.Row8 = 0
        Me.lsv_Cuentas.Row9 = 0
        Me.lsv_Cuentas.Size = New System.Drawing.Size(460, 199)
        Me.lsv_Cuentas.TabIndex = 2
        Me.lsv_Cuentas.UseCompatibleStateImageBehavior = False
        Me.lsv_Cuentas.View = System.Windows.Forms.View.Details
        '
        'lsv_CuentasAdd
        '
        Me.lsv_CuentasAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_CuentasAdd.FullRowSelect = True
        Me.lsv_CuentasAdd.HideSelection = False
        Me.lsv_CuentasAdd.Location = New System.Drawing.Point(6, 279)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_CuentasAdd.Lvs = ListViewColumnSorter3
        Me.lsv_CuentasAdd.MultiSelect = False
        Me.lsv_CuentasAdd.Name = "lsv_CuentasAdd"
        Me.lsv_CuentasAdd.Row1 = 25
        Me.lsv_CuentasAdd.Row10 = 0
        Me.lsv_CuentasAdd.Row2 = 25
        Me.lsv_CuentasAdd.Row3 = 15
        Me.lsv_CuentasAdd.Row4 = 15
        Me.lsv_CuentasAdd.Row5 = 15
        Me.lsv_CuentasAdd.Row6 = 0
        Me.lsv_CuentasAdd.Row7 = 0
        Me.lsv_CuentasAdd.Row8 = 0
        Me.lsv_CuentasAdd.Row9 = 0
        Me.lsv_CuentasAdd.Size = New System.Drawing.Size(460, 146)
        Me.lsv_CuentasAdd.TabIndex = 7
        Me.lsv_CuentasAdd.UseCompatibleStateImageBehavior = False
        Me.lsv_CuentasAdd.View = System.Windows.Forms.View.Details
        '
        'lsv_Referencias
        '
        Me.lsv_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Referencias.CheckBoxes = True
        Me.lsv_Referencias.FullRowSelect = True
        Me.lsv_Referencias.HideSelection = False
        Me.lsv_Referencias.Location = New System.Drawing.Point(471, 38)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Referencias.Lvs = ListViewColumnSorter4
        Me.lsv_Referencias.MultiSelect = False
        Me.lsv_Referencias.Name = "lsv_Referencias"
        Me.lsv_Referencias.Row1 = 60
        Me.lsv_Referencias.Row10 = 0
        Me.lsv_Referencias.Row2 = 30
        Me.lsv_Referencias.Row3 = 0
        Me.lsv_Referencias.Row4 = 0
        Me.lsv_Referencias.Row5 = 0
        Me.lsv_Referencias.Row6 = 0
        Me.lsv_Referencias.Row7 = 0
        Me.lsv_Referencias.Row8 = 0
        Me.lsv_Referencias.Row9 = 0
        Me.lsv_Referencias.Size = New System.Drawing.Size(306, 199)
        Me.lsv_Referencias.TabIndex = 5
        Me.lsv_Referencias.UseCompatibleStateImageBehavior = False
        Me.lsv_Referencias.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_GuardarTodo)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 514)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(784, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'frm_CuentasModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.gbx_Banco)
        Me.Controls.Add(Me.Gbx_Listados)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CuentasModal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas"
        Me.gbx_Banco.ResumeLayout(False)
        Me.gbx_Banco.PerformLayout()
        Me.Gbx_Listados.ResumeLayout(False)
        Me.Gbx_Listados.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Cuentas As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_Referencias As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_ReferenciasAdd As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_CuentasAdd As Modulo_Proceso.cp_Listview
    Friend WithEvents Btn_GuardarTodo As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents gbx_Banco As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cbx_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_ClientesP As Modulo_Proceso.cp_cmb_Parametro
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents cmb_Banco As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Listados As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tbx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Buscar2 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarR As System.Windows.Forms.TextBox
End Class
