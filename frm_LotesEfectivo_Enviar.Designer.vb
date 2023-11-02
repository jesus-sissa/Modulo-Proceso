<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LotesEfectivo_Enviar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LotesEfectivo_Enviar))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Enviar = New System.Windows.Forms.Button
        Me.gbx_EfectivoB = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_Registros3 = New System.Windows.Forms.Label
        Me.gbx_Lotes = New System.Windows.Forms.GroupBox
        Me.Lsv_Efectivo = New Modulo_Proceso.cp_Listview
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.Lsv_EfectivoD = New Modulo_Proceso.cp_Listview
        Me.gbx_EfectivoF = New System.Windows.Forms.GroupBox
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.cmb_Destino = New Modulo_Proceso.cp_cmb_Manual
        Me.chk_CajaTodos = New System.Windows.Forms.CheckBox
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.gbx_EfectivoB.SuspendLayout()
        Me.gbx_Lotes.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_EfectivoF.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Enviar.Enabled = False
        Me.btn_Enviar.Image = Global.Modulo_Proceso.My.Resources.Resources.Money_Enviar
        Me.btn_Enviar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Enviar.TabIndex = 0
        Me.btn_Enviar.Text = "&Enviar"
        Me.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Enviar.UseVisualStyleBackColor = True
        '
        'gbx_EfectivoB
        '
        Me.gbx_EfectivoB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoB.Controls.Add(Me.btn_Enviar)
        Me.gbx_EfectivoB.Controls.Add(Me.btn_Cerrar)
        Me.gbx_EfectivoB.Location = New System.Drawing.Point(3, 508)
        Me.gbx_EfectivoB.Name = "gbx_EfectivoB"
        Me.gbx_EfectivoB.Size = New System.Drawing.Size(775, 50)
        Me.gbx_EfectivoB.TabIndex = 3
        Me.gbx_EfectivoB.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(614, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(155, 23)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Registros3
        '
        Me.Lbl_Registros3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros3.Location = New System.Drawing.Point(613, 16)
        Me.Lbl_Registros3.Name = "Lbl_Registros3"
        Me.Lbl_Registros3.Size = New System.Drawing.Size(155, 22)
        Me.Lbl_Registros3.TabIndex = 0
        Me.Lbl_Registros3.Text = "Registros: 0"
        Me.Lbl_Registros3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Lotes
        '
        Me.gbx_Lotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lotes.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Lotes.Controls.Add(Me.Lsv_Efectivo)
        Me.gbx_Lotes.Location = New System.Drawing.Point(3, 87)
        Me.gbx_Lotes.Name = "gbx_Lotes"
        Me.gbx_Lotes.Size = New System.Drawing.Size(774, 134)
        Me.gbx_Lotes.TabIndex = 1
        Me.gbx_Lotes.TabStop = False
        Me.gbx_Lotes.Text = "Lotes"
        '
        'Lsv_Efectivo
        '
        Me.Lsv_Efectivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Efectivo.CheckBoxes = True
        Me.Lsv_Efectivo.FullRowSelect = True
        Me.Lsv_Efectivo.HideSelection = False
        Me.Lsv_Efectivo.Location = New System.Drawing.Point(6, 42)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Efectivo.Lvs = ListViewColumnSorter1
        Me.Lsv_Efectivo.MultiSelect = False
        Me.Lsv_Efectivo.Name = "Lsv_Efectivo"
        Me.Lsv_Efectivo.Row1 = 8
        Me.Lsv_Efectivo.Row10 = 0
        Me.Lsv_Efectivo.Row2 = 23
        Me.Lsv_Efectivo.Row3 = 24
        Me.Lsv_Efectivo.Row4 = 8
        Me.Lsv_Efectivo.Row5 = 8
        Me.Lsv_Efectivo.Row6 = 7
        Me.Lsv_Efectivo.Row7 = 10
        Me.Lsv_Efectivo.Row8 = 8
        Me.Lsv_Efectivo.Row9 = 0
        Me.Lsv_Efectivo.Size = New System.Drawing.Size(762, 86)
        Me.Lsv_Efectivo.TabIndex = 1
        Me.Lsv_Efectivo.UseCompatibleStateImageBehavior = False
        Me.Lsv_Efectivo.View = System.Windows.Forms.View.Details
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.Lbl_Registros3)
        Me.gbx_Detalle.Controls.Add(Me.Lsv_EfectivoD)
        Me.gbx_Detalle.Location = New System.Drawing.Point(3, 228)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(774, 151)
        Me.gbx_Detalle.TabIndex = 2
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Detalle"
        '
        'Lsv_EfectivoD
        '
        Me.Lsv_EfectivoD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_EfectivoD.FullRowSelect = True
        Me.Lsv_EfectivoD.HideSelection = False
        Me.Lsv_EfectivoD.Location = New System.Drawing.Point(6, 41)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_EfectivoD.Lvs = ListViewColumnSorter2
        Me.Lsv_EfectivoD.MultiSelect = False
        Me.Lsv_EfectivoD.Name = "Lsv_EfectivoD"
        Me.Lsv_EfectivoD.Row1 = 10
        Me.Lsv_EfectivoD.Row10 = 0
        Me.Lsv_EfectivoD.Row2 = 10
        Me.Lsv_EfectivoD.Row3 = 10
        Me.Lsv_EfectivoD.Row4 = 10
        Me.Lsv_EfectivoD.Row5 = 10
        Me.Lsv_EfectivoD.Row6 = 10
        Me.Lsv_EfectivoD.Row7 = 10
        Me.Lsv_EfectivoD.Row8 = 0
        Me.Lsv_EfectivoD.Row9 = 10
        Me.Lsv_EfectivoD.Size = New System.Drawing.Size(762, 104)
        Me.Lsv_EfectivoD.TabIndex = 1
        Me.Lsv_EfectivoD.UseCompatibleStateImageBehavior = False
        Me.Lsv_EfectivoD.View = System.Windows.Forms.View.Details
        '
        'gbx_EfectivoF
        '
        Me.gbx_EfectivoF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoF.Controls.Add(Me.lbl_Destino)
        Me.gbx_EfectivoF.Controls.Add(Me.cmb_Destino)
        Me.gbx_EfectivoF.Controls.Add(Me.chk_CajaTodos)
        Me.gbx_EfectivoF.Controls.Add(Me.lbl_Caja)
        Me.gbx_EfectivoF.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_EfectivoF.Location = New System.Drawing.Point(9, 12)
        Me.gbx_EfectivoF.Name = "gbx_EfectivoF"
        Me.gbx_EfectivoF.Size = New System.Drawing.Size(769, 69)
        Me.gbx_EfectivoF.TabIndex = 0
        Me.gbx_EfectivoF.TabStop = False
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(36, 43)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 4
        Me.lbl_Destino.Text = "Destino"
        '
        'cmb_Destino
        '
        Me.cmb_Destino.Control_Siguiente = Nothing
        Me.cmb_Destino.DisplayMember = "display"
        Me.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Destino.FormattingEnabled = True
        Me.cmb_Destino.Location = New System.Drawing.Point(85, 40)
        Me.cmb_Destino.MaxDropDownItems = 20
        Me.cmb_Destino.Name = "cmb_Destino"
        Me.cmb_Destino.Size = New System.Drawing.Size(128, 21)
        Me.cmb_Destino.TabIndex = 5
        Me.cmb_Destino.ValueMember = "value"
        '
        'chk_CajaTodos
        '
        Me.chk_CajaTodos.AutoSize = True
        Me.chk_CajaTodos.Location = New System.Drawing.Point(491, 15)
        Me.chk_CajaTodos.Name = "chk_CajaTodos"
        Me.chk_CajaTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_CajaTodos.TabIndex = 3
        Me.chk_CajaTodos.Text = "Todos"
        Me.chk_CajaTodos.UseVisualStyleBackColor = True
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
        Me.cmb_CajaBancaria.Clave = ""
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.Filtro = Nothing
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(85, 13)
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_Registros2)
        Me.GroupBox1.Controls.Add(Me.lsv_Envases)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 120)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Envase"
        '
        'lbl_Registros2
        '
        Me.lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros2.Location = New System.Drawing.Point(613, 12)
        Me.lbl_Registros2.Name = "lbl_Registros2"
        Me.lbl_Registros2.Size = New System.Drawing.Size(155, 22)
        Me.lbl_Registros2.TabIndex = 0
        Me.lbl_Registros2.Text = "Registros: 0"
        Me.lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(6, 37)
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
        Me.lsv_Envases.Row9 = 10
        Me.lsv_Envases.Size = New System.Drawing.Size(762, 77)
        Me.lsv_Envases.TabIndex = 1
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'frm_LotesEfectivo_Enviar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbx_EfectivoF)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Lotes)
        Me.Controls.Add(Me.gbx_EfectivoB)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_LotesEfectivo_Enviar"
        Me.Text = "Enviar Efectivo"
        Me.gbx_EfectivoB.ResumeLayout(False)
        Me.gbx_Lotes.ResumeLayout(False)
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_EfectivoF.ResumeLayout(False)
        Me.gbx_EfectivoF.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Enviar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Efectivo As Modulo_Proceso.cp_Listview
    Friend WithEvents Lsv_EfectivoD As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_EfectivoB As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros3 As System.Windows.Forms.Label
    Friend WithEvents gbx_Lotes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_EfectivoF As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents cmb_Destino As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents chk_CajaTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
End Class
