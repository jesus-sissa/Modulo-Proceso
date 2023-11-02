<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarPre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AsignarPre))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Filtros = New System.Windows.Forms.GroupBox
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Asignar = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New System.Windows.Forms.TextBox
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Dotacion = New Modulo_Proceso.cp_Listview
        Me.cmb_Cajero = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveCajero = New Modulo_Proceso.cp_Textbox
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.gbx_Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtros
        '
        Me.gbx_Filtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Cajero)
        Me.gbx_Filtros.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Filtros.Controls.Add(Me.tbx_ClaveCajero)
        Me.gbx_Filtros.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Filtros.Location = New System.Drawing.Point(12, 11)
        Me.gbx_Filtros.Name = "gbx_Filtros"
        Me.gbx_Filtros.Size = New System.Drawing.Size(721, 66)
        Me.gbx_Filtros.TabIndex = 43
        Me.gbx_Filtros.TabStop = False
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(19, 16)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(76, 13)
        Me.lbl_CajaBancaria.TabIndex = 3
        Me.lbl_CajaBancaria.Text = "Caja Bancaria:"
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(55, 44)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Cajero.TabIndex = 0
        Me.lbl_Cajero.Text = "Cajero:"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(547, 96)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(186, 23)
        Me.Lbl_Registros.TabIndex = 53
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Asignar
        '
        Me.btn_Asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Asignar.Image = CType(resources.GetObject("btn_Asignar.Image"), System.Drawing.Image)
        Me.btn_Asignar.Location = New System.Drawing.Point(12, 475)
        Me.btn_Asignar.Name = "btn_Asignar"
        Me.btn_Asignar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Asignar.TabIndex = 54
        Me.btn_Asignar.Text = "&Asignar"
        Me.btn_Asignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Asignar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Asignar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(382, 94)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 67
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Location = New System.Drawing.Point(113, 96)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(263, 20)
        Me.tbx_Buscar.TabIndex = 66
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(67, 99)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 65
        Me.lbl_Buscar.Text = "Buscar"
        '
        'lsv_Dotacion
        '
        Me.lsv_Dotacion.AllowColumnReorder = True
        Me.lsv_Dotacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotacion.FullRowSelect = True
        Me.lsv_Dotacion.HideSelection = False
        Me.lsv_Dotacion.Location = New System.Drawing.Point(12, 122)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotacion.Lvs = ListViewColumnSorter1
        Me.lsv_Dotacion.MultiSelect = False
        Me.lsv_Dotacion.Name = "lsv_Dotacion"
        Me.lsv_Dotacion.Row1 = 8
        Me.lsv_Dotacion.Row10 = 0
        Me.lsv_Dotacion.Row2 = 13
        Me.lsv_Dotacion.Row3 = 13
        Me.lsv_Dotacion.Row4 = 8
        Me.lsv_Dotacion.Row5 = 8
        Me.lsv_Dotacion.Row6 = 7
        Me.lsv_Dotacion.Row7 = 7
        Me.lsv_Dotacion.Row8 = 10
        Me.lsv_Dotacion.Row9 = 7
        Me.lsv_Dotacion.Size = New System.Drawing.Size(721, 336)
        Me.lsv_Dotacion.TabIndex = 44
        Me.lsv_Dotacion.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotacion.View = System.Windows.Forms.View.Details
        '
        'cmb_Cajero
        '
        Me.cmb_Cajero.Clave = "Clave"
        Me.cmb_Cajero.Control_Siguiente = Nothing
        Me.cmb_Cajero.DisplayMember = "Nombre"
        Me.cmb_Cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajero.Empresa = False
        Me.cmb_Cajero.Filtro = Me.tbx_ClaveCajero
        Me.cmb_Cajero.FormattingEnabled = True
        Me.cmb_Cajero.Location = New System.Drawing.Point(101, 40)
        Me.cmb_Cajero.MaxDropDownItems = 15
        Me.cmb_Cajero.Name = "cmb_Cajero"
        Me.cmb_Cajero.Pista = False
        Me.cmb_Cajero.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cajero.StoredProcedure = "Cat_EmpleadosVerfica_Get"
        Me.cmb_Cajero.Sucursal = True
        Me.cmb_Cajero.TabIndex = 2
        Me.cmb_Cajero.Tipo = 0
        Me.cmb_Cajero.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveCajero
        '
        Me.tbx_ClaveCajero.Control_Siguiente = Nothing
        Me.tbx_ClaveCajero.Filtrado = True
        Me.tbx_ClaveCajero.Location = New System.Drawing.Point(607, 13)
        Me.tbx_ClaveCajero.MaxLength = 12
        Me.tbx_ClaveCajero.Name = "tbx_ClaveCajero"
        Me.tbx_ClaveCajero.Size = New System.Drawing.Size(69, 20)
        Me.tbx_ClaveCajero.TabIndex = 1
        Me.tbx_ClaveCajero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.tbx_ClaveCajero.Visible = False
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
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(101, 13)
        Me.cmb_CajaBancaria.MaxDropDownItems = 15
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 5
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'frm_AsignarPre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 529)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.btn_Asignar)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.lsv_Dotacion)
        Me.Controls.Add(Me.gbx_Filtros)
        Me.Name = "frm_AsignarPre"
        Me.Text = "frm_AsignarPre"
        Me.gbx_Filtros.ResumeLayout(False)
        Me.gbx_Filtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_Dotacion As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Cajero As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveCajero As Modulo_Proceso.cp_Textbox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Asignar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
End Class
