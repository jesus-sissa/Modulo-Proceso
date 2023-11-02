<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DotacionesCancelar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DotacionesCancelar))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.ckb_Caja = New System.Windows.Forms.CheckBox
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_Registros1 = New System.Windows.Forms.Label
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.tbx_CajaBancaria = New Modulo_Proceso.cp_Textbox
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.Lsv_DotacionD = New Modulo_Proceso.cp_Listview
        Me.Lsv_Dotacion = New Modulo_Proceso.cp_Listview
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_CajaBancaria)
        Me.Gbx_Filtro.Controls.Add(Me.ckb_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(3, 4)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(778, 43)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'ckb_Caja
        '
        Me.ckb_Caja.AutoSize = True
        Me.ckb_Caja.Location = New System.Drawing.Point(568, 15)
        Me.ckb_Caja.Name = "ckb_Caja"
        Me.ckb_Caja.Size = New System.Drawing.Size(56, 17)
        Me.ckb_Caja.TabIndex = 3
        Me.ckb_Caja.Text = "Todos"
        Me.ckb_Caja.UseVisualStyleBackColor = True
        '
        'lbl_Caja
        '
        Me.lbl_Caja.AutoSize = True
        Me.lbl_Caja.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Caja.Name = "lbl_Caja"
        Me.lbl_Caja.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Caja.TabIndex = 0
        Me.lbl_Caja.Text = "Caja Bancaria"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(3, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(632, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Proceso.My.Resources.Resources.Baja
        Me.btn_Cancelar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 0
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(573, 47)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(208, 23)
        Me.Lbl_Registros.TabIndex = 51
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Registros1
        '
        Me.Lbl_Registros1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros1.Location = New System.Drawing.Point(597, 228)
        Me.Lbl_Registros1.Name = "Lbl_Registros1"
        Me.Lbl_Registros1.Size = New System.Drawing.Size(184, 23)
        Me.Lbl_Registros1.TabIndex = 51
        Me.Lbl_Registros1.Text = "Registros: 0"
        Me.Lbl_Registros1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(3, 388)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 10
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 10
        Me.lsv_Envases.Row3 = 10
        Me.lsv_Envases.Row4 = 10
        Me.lsv_Envases.Row5 = 10
        Me.lsv_Envases.Row6 = 10
        Me.lsv_Envases.Row7 = 10
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(778, 114)
        Me.lsv_Envases.TabIndex = 53
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'tbx_CajaBancaria
        '
        Me.tbx_CajaBancaria.Control_Siguiente = Nothing
        Me.tbx_CajaBancaria.Filtrado = True
        Me.tbx_CajaBancaria.Location = New System.Drawing.Point(81, 14)
        Me.tbx_CajaBancaria.MaxLength = 12
        Me.tbx_CajaBancaria.Name = "tbx_CajaBancaria"
        Me.tbx_CajaBancaria.Size = New System.Drawing.Size(75, 20)
        Me.tbx_CajaBancaria.TabIndex = 1
        Me.tbx_CajaBancaria.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave_Cliente"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Me.tbx_CajaBancaria
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(161, 13)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 2
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "id_CajaBancaria"
        '
        'Lsv_DotacionD
        '
        Me.Lsv_DotacionD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_DotacionD.FullRowSelect = True
        Me.Lsv_DotacionD.HideSelection = False
        Me.Lsv_DotacionD.Location = New System.Drawing.Point(3, 254)
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
        Me.Lsv_DotacionD.Size = New System.Drawing.Size(778, 126)
        Me.Lsv_DotacionD.TabIndex = 2
        Me.Lsv_DotacionD.UseCompatibleStateImageBehavior = False
        Me.Lsv_DotacionD.View = System.Windows.Forms.View.Details
        '
        'Lsv_Dotacion
        '
        Me.Lsv_Dotacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Dotacion.FullRowSelect = True
        Me.Lsv_Dotacion.HideSelection = False
        Me.Lsv_Dotacion.Location = New System.Drawing.Point(3, 73)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.Lsv_Dotacion.Lvs = ListViewColumnSorter3
        Me.Lsv_Dotacion.MultiSelect = False
        Me.Lsv_Dotacion.Name = "Lsv_Dotacion"
        Me.Lsv_Dotacion.Row1 = 8
        Me.Lsv_Dotacion.Row10 = 0
        Me.Lsv_Dotacion.Row2 = 20
        Me.Lsv_Dotacion.Row3 = 25
        Me.Lsv_Dotacion.Row4 = 8
        Me.Lsv_Dotacion.Row5 = 8
        Me.Lsv_Dotacion.Row6 = 8
        Me.Lsv_Dotacion.Row7 = 10
        Me.Lsv_Dotacion.Row8 = 8
        Me.Lsv_Dotacion.Row9 = 10
        Me.Lsv_Dotacion.Size = New System.Drawing.Size(778, 154)
        Me.Lsv_Dotacion.TabIndex = 1
        Me.Lsv_Dotacion.UseCompatibleStateImageBehavior = False
        Me.Lsv_Dotacion.View = System.Windows.Forms.View.Details
        '
        'frm_DotacionesCancelar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lsv_Envases)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.Lbl_Registros1)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.Lsv_DotacionD)
        Me.Controls.Add(Me.Lsv_Dotacion)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DotacionesCancelar"
        Me.Text = "Cancelar Dotaciones."
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lsv_Dotacion As Modulo_Proceso.cp_Listview
    Friend WithEvents Lsv_DotacionD As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents ckb_Caja As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents tbx_CajaBancaria As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros1 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
End Class
