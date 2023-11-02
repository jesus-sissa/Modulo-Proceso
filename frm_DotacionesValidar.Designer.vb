<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DotacionesValidar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DotacionesValidar))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.ckb_Caja = New System.Windows.Forms.CheckBox
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Gbx_Listados = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros1 = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lsv_Dotacion = New Modulo_Proceso.cp_Listview
        Me.Lsv_DotacionD = New Modulo_Proceso.cp_Listview
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Listados.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(628, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 40
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = CType(resources.GetObject("btn_Validar.Image"), System.Drawing.Image)
        Me.btn_Validar.Location = New System.Drawing.Point(12, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 39
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.ckb_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(4, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(776, 43)
        Me.Gbx_Filtro.TabIndex = 43
        Me.Gbx_Filtro.TabStop = False
        '
        'ckb_Caja
        '
        Me.ckb_Caja.AutoSize = True
        Me.ckb_Caja.Location = New System.Drawing.Point(490, 15)
        Me.ckb_Caja.Name = "ckb_Caja"
        Me.ckb_Caja.Size = New System.Drawing.Size(56, 17)
        Me.ckb_Caja.TabIndex = 31
        Me.ckb_Caja.Text = "Todos"
        Me.ckb_Caja.UseVisualStyleBackColor = True
        '
        'lbl_Caja
        '
        Me.lbl_Caja.AutoSize = True
        Me.lbl_Caja.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Caja.Name = "lbl_Caja"
        Me.lbl_Caja.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Caja.TabIndex = 29
        Me.lbl_Caja.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(83, 13)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(401, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 30
        Me.cmb_CajaBancaria.ValueMember = "id_CajaBancaria"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(776, 50)
        Me.Gbx_Botones.TabIndex = 44
        Me.Gbx_Botones.TabStop = False
        '
        'Gbx_Listados
        '
        Me.Gbx_Listados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listados.Controls.Add(Me.Lbl_Registros1)
        Me.Gbx_Listados.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Listados.Controls.Add(Me.Lsv_Dotacion)
        Me.Gbx_Listados.Controls.Add(Me.Lsv_DotacionD)
        Me.Gbx_Listados.Location = New System.Drawing.Point(4, 46)
        Me.Gbx_Listados.Name = "Gbx_Listados"
        Me.Gbx_Listados.Size = New System.Drawing.Size(776, 459)
        Me.Gbx_Listados.TabIndex = 45
        Me.Gbx_Listados.TabStop = False
        '
        'Lbl_Registros1
        '
        Me.Lbl_Registros1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros1.Location = New System.Drawing.Point(586, 178)
        Me.Lbl_Registros1.Name = "Lbl_Registros1"
        Me.Lbl_Registros1.Size = New System.Drawing.Size(184, 23)
        Me.Lbl_Registros1.TabIndex = 52
        Me.Lbl_Registros1.Text = "Registros: 0"
        Me.Lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(510, 10)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(260, 23)
        Me.Lbl_Registros.TabIndex = 51
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Dotacion
        '
        Me.Lsv_Dotacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Dotacion.CheckBoxes = True
        Me.Lsv_Dotacion.FullRowSelect = True
        Me.Lsv_Dotacion.HideSelection = False
        Me.Lsv_Dotacion.Location = New System.Drawing.Point(9, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Dotacion.Lvs = ListViewColumnSorter1
        Me.Lsv_Dotacion.MultiSelect = False
        Me.Lsv_Dotacion.Name = "Lsv_Dotacion"
        Me.Lsv_Dotacion.Row1 = 20
        Me.Lsv_Dotacion.Row10 = 0
        Me.Lsv_Dotacion.Row2 = 30
        Me.Lsv_Dotacion.Row3 = 15
        Me.Lsv_Dotacion.Row4 = 10
        Me.Lsv_Dotacion.Row5 = 10
        Me.Lsv_Dotacion.Row6 = 10
        Me.Lsv_Dotacion.Row7 = 0
        Me.Lsv_Dotacion.Row8 = 0
        Me.Lsv_Dotacion.Row9 = 0
        Me.Lsv_Dotacion.Size = New System.Drawing.Size(758, 141)
        Me.Lsv_Dotacion.TabIndex = 41
        Me.Lsv_Dotacion.UseCompatibleStateImageBehavior = False
        Me.Lsv_Dotacion.View = System.Windows.Forms.View.Details
        '
        'Lsv_DotacionD
        '
        Me.Lsv_DotacionD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_DotacionD.FullRowSelect = True
        Me.Lsv_DotacionD.HideSelection = False
        Me.Lsv_DotacionD.Location = New System.Drawing.Point(12, 203)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_DotacionD.Lvs = ListViewColumnSorter2
        Me.Lsv_DotacionD.MultiSelect = False
        Me.Lsv_DotacionD.Name = "Lsv_DotacionD"
        Me.Lsv_DotacionD.Row1 = 10
        Me.Lsv_DotacionD.Row10 = 0
        Me.Lsv_DotacionD.Row2 = 10
        Me.Lsv_DotacionD.Row3 = 10
        Me.Lsv_DotacionD.Row4 = 10
        Me.Lsv_DotacionD.Row5 = 10
        Me.Lsv_DotacionD.Row6 = 10
        Me.Lsv_DotacionD.Row7 = 10
        Me.Lsv_DotacionD.Row8 = 0
        Me.Lsv_DotacionD.Row9 = 0
        Me.Lsv_DotacionD.Size = New System.Drawing.Size(758, 250)
        Me.Lsv_DotacionD.TabIndex = 42
        Me.Lsv_DotacionD.UseCompatibleStateImageBehavior = False
        Me.Lsv_DotacionD.View = System.Windows.Forms.View.Details
        '
        'frm_DotacionesValidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Listados)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DotacionesValidar"
        Me.Text = "Valida Dotaciones"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Listados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Dotacion As Modulo_Proceso.cp_Listview
    Friend WithEvents Lsv_DotacionD As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents ckb_Caja As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Listados As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros1 As System.Windows.Forms.Label
End Class
