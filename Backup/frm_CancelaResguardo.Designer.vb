<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelaResguardo
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CancelaResguardo))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.il_Cancelar = New System.Windows.Forms.ImageList(Me.components)
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.ckb_Caja = New System.Windows.Forms.CheckBox
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.lsv_ResguardoD = New Modulo_Proceso.cp_Listview
        Me.lsv_Resguardo = New Modulo_Proceso.cp_Listview
        Me.Lbl_Registros2 = New System.Windows.Forms.Label
        Me.lbl_Registros3 = New System.Windows.Forms.Label
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'il_Cancelar
        '
        Me.il_Cancelar.ImageStream = CType(resources.GetObject("il_Cancelar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il_Cancelar.TransparentColor = System.Drawing.Color.Transparent
        Me.il_Cancelar.Images.SetKeyName(0, "Cancelar.png")
        Me.il_Cancelar.Images.SetKeyName(1, "bundle-24x24x32b.png")
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.ckb_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(12, 7)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(762, 43)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'ckb_Caja
        '
        Me.ckb_Caja.AutoSize = True
        Me.ckb_Caja.Location = New System.Drawing.Point(489, 15)
        Me.ckb_Caja.Name = "ckb_Caja"
        Me.ckb_Caja.Size = New System.Drawing.Size(56, 17)
        Me.ckb_Caja.TabIndex = 2
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
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 1
        Me.cmb_CajaBancaria.ValueMember = "id_CajaBancaria"
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(568, 51)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(205, 17)
        Me.Lbl_Registros.TabIndex = 50
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(10, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(764, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.Location = New System.Drawing.Point(618, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.ImageIndex = 0
        Me.btn_Cancelar.ImageList = Me.il_Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 0
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'lsv_ResguardoD
        '
        Me.lsv_ResguardoD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ResguardoD.FullRowSelect = True
        Me.lsv_ResguardoD.HideSelection = False
        Me.lsv_ResguardoD.Location = New System.Drawing.Point(9, 223)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ResguardoD.Lvs = ListViewColumnSorter1
        Me.lsv_ResguardoD.MultiSelect = False
        Me.lsv_ResguardoD.Name = "lsv_ResguardoD"
        Me.lsv_ResguardoD.Row1 = 10
        Me.lsv_ResguardoD.Row10 = 0
        Me.lsv_ResguardoD.Row2 = 10
        Me.lsv_ResguardoD.Row3 = 10
        Me.lsv_ResguardoD.Row4 = 10
        Me.lsv_ResguardoD.Row5 = 10
        Me.lsv_ResguardoD.Row6 = 10
        Me.lsv_ResguardoD.Row7 = 10
        Me.lsv_ResguardoD.Row8 = 0
        Me.lsv_ResguardoD.Row9 = 0
        Me.lsv_ResguardoD.Size = New System.Drawing.Size(764, 126)
        Me.lsv_ResguardoD.TabIndex = 2
        Me.lsv_ResguardoD.UseCompatibleStateImageBehavior = False
        Me.lsv_ResguardoD.View = System.Windows.Forms.View.Details
        '
        'lsv_Resguardo
        '
        Me.lsv_Resguardo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Resguardo.CheckBoxes = True
        Me.lsv_Resguardo.FullRowSelect = True
        Me.lsv_Resguardo.HideSelection = False
        Me.lsv_Resguardo.Location = New System.Drawing.Point(10, 69)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Resguardo.Lvs = ListViewColumnSorter2
        Me.lsv_Resguardo.MultiSelect = False
        Me.lsv_Resguardo.Name = "lsv_Resguardo"
        Me.lsv_Resguardo.Row1 = 10
        Me.lsv_Resguardo.Row10 = 0
        Me.lsv_Resguardo.Row2 = 15
        Me.lsv_Resguardo.Row3 = 15
        Me.lsv_Resguardo.Row4 = 10
        Me.lsv_Resguardo.Row5 = 10
        Me.lsv_Resguardo.Row6 = 10
        Me.lsv_Resguardo.Row7 = 0
        Me.lsv_Resguardo.Row8 = 0
        Me.lsv_Resguardo.Row9 = 0
        Me.lsv_Resguardo.Size = New System.Drawing.Size(764, 125)
        Me.lsv_Resguardo.TabIndex = 1
        Me.lsv_Resguardo.UseCompatibleStateImageBehavior = False
        Me.lsv_Resguardo.View = System.Windows.Forms.View.Details
        '
        'Lbl_Registros2
        '
        Me.Lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros2.Location = New System.Drawing.Point(618, 198)
        Me.Lbl_Registros2.Name = "Lbl_Registros2"
        Me.Lbl_Registros2.Size = New System.Drawing.Size(155, 23)
        Me.Lbl_Registros2.TabIndex = 50
        Me.Lbl_Registros2.Text = "Registros: 0"
        Me.Lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Registros3
        '
        Me.lbl_Registros3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros3.Location = New System.Drawing.Point(620, 351)
        Me.lbl_Registros3.Name = "lbl_Registros3"
        Me.lbl_Registros3.Size = New System.Drawing.Size(155, 23)
        Me.lbl_Registros3.TabIndex = 54
        Me.lbl_Registros3.Text = "Registros: 0"
        Me.lbl_Registros3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(10, 374)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter3
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
        Me.lsv_Envases.Size = New System.Drawing.Size(764, 127)
        Me.lsv_Envases.TabIndex = 53
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'frm_CancelaResguardo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lbl_Registros3)
        Me.Controls.Add(Me.lsv_Envases)
        Me.Controls.Add(Me.Lbl_Registros)
        Me.Controls.Add(Me.Lbl_Registros2)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.lsv_ResguardoD)
        Me.Controls.Add(Me.lsv_Resguardo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CancelaResguardo"
        Me.Text = "Cancela Resguardos"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Resguardo As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_ResguardoD As Modulo_Proceso.cp_Listview
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents ckb_Caja As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents il_Cancelar As System.Windows.Forms.ImageList
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros3 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
End Class
