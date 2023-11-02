<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ClientesInternosAExternos
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
        Me.Gbx_Personalizar = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.cmb_Clientes = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam()
        Me.tbx_ClaveEmpleado = New Modulo_Proceso.cp_Textbox()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.tbx_Empresa = New Modulo_Proceso.cp_Textbox()
        Me.lbl_Empresa = New System.Windows.Forms.Label()
        Me.lsv_Clientes = New Modulo_Proceso.cp_Listview()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.Gbx_Personalizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Personalizar
        '
        Me.Gbx_Personalizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Personalizar.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Personalizar.Controls.Add(Me.cmb_Clientes)
        Me.Gbx_Personalizar.Controls.Add(Me.btn_Borrar)
        Me.Gbx_Personalizar.Controls.Add(Me.tbx_ClaveEmpleado)
        Me.Gbx_Personalizar.Controls.Add(Me.lbl_Empleado)
        Me.Gbx_Personalizar.Controls.Add(Me.tbx_Empresa)
        Me.Gbx_Personalizar.Controls.Add(Me.lbl_Empresa)
        Me.Gbx_Personalizar.Controls.Add(Me.btn_Agregar)
        Me.Gbx_Personalizar.Controls.Add(Me.lsv_Clientes)
        Me.Gbx_Personalizar.Location = New System.Drawing.Point(12, 12)
        Me.Gbx_Personalizar.Name = "Gbx_Personalizar"
        Me.Gbx_Personalizar.Size = New System.Drawing.Size(646, 570)
        Me.Gbx_Personalizar.TabIndex = 4
        Me.Gbx_Personalizar.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(451, 71)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(186, 23)
        Me.Lbl_Registros.TabIndex = 53
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Clientes
        '
        Me.cmb_Clientes.Clave = "Clave_Cliente"
        Me.cmb_Clientes.Control_Siguiente = Nothing
        Me.cmb_Clientes.DisplayMember = "Nombre_Comercial"
        Me.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Clientes.Empresa = False
        Me.cmb_Clientes.Filtro = Me.tbx_ClaveEmpleado
        Me.cmb_Clientes.FormattingEnabled = True
        Me.cmb_Clientes.Location = New System.Drawing.Point(83, 18)
        Me.cmb_Clientes.MaxDropDownItems = 20
        Me.cmb_Clientes.Name = "cmb_Clientes"
        Me.cmb_Clientes.Pista = False
        Me.cmb_Clientes.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Clientes.StoredProcedure = "Cat_Clientes_SISSA"
        Me.cmb_Clientes.Sucursal = False
        Me.cmb_Clientes.TabIndex = 5
        Me.cmb_Clientes.Tipo = 0
        Me.cmb_Clientes.ValueMember = "Id_Cliente"
        '
        'tbx_ClaveEmpleado
        '
        Me.tbx_ClaveEmpleado.Control_Siguiente = Nothing
        Me.tbx_ClaveEmpleado.Filtrado = True
        Me.tbx_ClaveEmpleado.Location = New System.Drawing.Point(497, 15)
        Me.tbx_ClaveEmpleado.MaxLength = 12
        Me.tbx_ClaveEmpleado.Name = "tbx_ClaveEmpleado"
        Me.tbx_ClaveEmpleado.Size = New System.Drawing.Size(52, 20)
        Me.tbx_ClaveEmpleado.TabIndex = 4
        Me.tbx_ClaveEmpleado.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveEmpleado.Visible = False
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(35, 21)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Empleado.TabIndex = 3
        Me.lbl_Empleado.Text = "Cliente:"
        '
        'tbx_Empresa
        '
        Me.tbx_Empresa.Control_Siguiente = Nothing
        Me.tbx_Empresa.Filtrado = False
        Me.tbx_Empresa.Location = New System.Drawing.Point(83, 45)
        Me.tbx_Empresa.Name = "tbx_Empresa"
        Me.tbx_Empresa.ReadOnly = True
        Me.tbx_Empresa.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Empresa.TabIndex = 9
        Me.tbx_Empresa.Text = "SERVICIO INTEGRAL DE SEGURIDAD, S.A. DE C.V."
        Me.tbx_Empresa.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Empresa
        '
        Me.lbl_Empresa.AutoSize = True
        Me.lbl_Empresa.Location = New System.Drawing.Point(29, 48)
        Me.lbl_Empresa.Name = "lbl_Empresa"
        Me.lbl_Empresa.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Empresa.TabIndex = 8
        Me.lbl_Empresa.Text = "Empresa"
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(3, 97)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter1
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 50
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 30
        Me.lsv_Clientes.Row3 = 30
        Me.lsv_Clientes.Row4 = 0
        Me.lsv_Clientes.Row5 = 0
        Me.lsv_Clientes.Row6 = 0
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(634, 425)
        Me.lsv_Clientes.TabIndex = 11
        Me.lsv_Clientes.Tag = "Id_TipoParentesco"
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar.Enabled = False
        Me.btn_Borrar.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_Borrar.Location = New System.Drawing.Point(6, 530)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar.TabIndex = 1
        Me.btn_Borrar.Text = "&Borrar"
        Me.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Proceso.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(497, 37)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 10
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'Frm_ClientesInternosAExternos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 594)
        Me.Controls.Add(Me.Gbx_Personalizar)
        Me.Name = "Frm_ClientesInternosAExternos"
        Me.Text = "Frm_ClientesInternosAExternos"
        Me.Gbx_Personalizar.ResumeLayout(False)
        Me.Gbx_Personalizar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gbx_Personalizar As GroupBox
    Friend WithEvents btn_Borrar As Button
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents tbx_Empresa As cp_Textbox
    Friend WithEvents lbl_Empresa As Label
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents lsv_Clientes As cp_Listview
    Friend WithEvents cmb_Clientes As cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveEmpleado As cp_Textbox
    Friend WithEvents Lbl_Registros As Label
End Class
