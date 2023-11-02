<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LotesEfectivo_Regresar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LotesEfectivo_Regresar))
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter5 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Regresar = New System.Windows.Forms.Button
        Me.gbx_EfectivoB = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lbl_Registros3 = New System.Windows.Forms.Label
        Me.gbx_Lotes = New System.Windows.Forms.GroupBox
        Me.Lsv_Efectivo = New Modulo_Proceso.cp_Listview
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.Lsv_EfectivoD = New Modulo_Proceso.cp_Listview
        Me.gbx_EfectivoF = New System.Windows.Forms.GroupBox
        Me.cmb_Origen = New Modulo_Proceso.cp_cmb_Manual
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.chk_CajaTodos = New System.Windows.Forms.CheckBox
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Registros2 = New System.Windows.Forms.Label
        Me.lsv_Envase = New Modulo_Proceso.cp_Listview
        Me.gbx_EfectivoB.SuspendLayout()
        Me.gbx_Lotes.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_EfectivoF.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'btn_Regresar
        '
        Me.btn_Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Regresar.Enabled = False
        Me.btn_Regresar.Image = Global.Modulo_Proceso.My.Resources.Resources.Money_Enviar
        Me.btn_Regresar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Regresar.TabIndex = 0
        Me.btn_Regresar.Text = "&Regresar"
        Me.btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Regresar.UseVisualStyleBackColor = True
        '
        'gbx_EfectivoB
        '
        Me.gbx_EfectivoB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoB.Controls.Add(Me.btn_Regresar)
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
        Me.gbx_Lotes.Size = New System.Drawing.Size(774, 130)
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
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.Lsv_Efectivo.Lvs = ListViewColumnSorter3
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
        Me.Lsv_Efectivo.Row8 = 0
        Me.Lsv_Efectivo.Row9 = 0
        Me.Lsv_Efectivo.Size = New System.Drawing.Size(762, 82)
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
        Me.gbx_Detalle.Location = New System.Drawing.Point(3, 223)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(774, 144)
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
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.Lsv_EfectivoD.Lvs = ListViewColumnSorter4
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
        Me.Lsv_EfectivoD.Size = New System.Drawing.Size(762, 97)
        Me.Lsv_EfectivoD.TabIndex = 1
        Me.Lsv_EfectivoD.UseCompatibleStateImageBehavior = False
        Me.Lsv_EfectivoD.View = System.Windows.Forms.View.Details
        '
        'gbx_EfectivoF
        '
        Me.gbx_EfectivoF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EfectivoF.Controls.Add(Me.cmb_Origen)
        Me.gbx_EfectivoF.Controls.Add(Me.lbl_Destino)
        Me.gbx_EfectivoF.Controls.Add(Me.chk_CajaTodos)
        Me.gbx_EfectivoF.Controls.Add(Me.lbl_Caja)
        Me.gbx_EfectivoF.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_EfectivoF.Location = New System.Drawing.Point(9, 12)
        Me.gbx_EfectivoF.Name = "gbx_EfectivoF"
        Me.gbx_EfectivoF.Size = New System.Drawing.Size(769, 69)
        Me.gbx_EfectivoF.TabIndex = 0
        Me.gbx_EfectivoF.TabStop = False
        '
        'cmb_Origen
        '
        Me.cmb_Origen.Control_Siguiente = Nothing
        Me.cmb_Origen.DisplayMember = "display"
        Me.cmb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Origen.FormattingEnabled = True
        Me.cmb_Origen.Location = New System.Drawing.Point(85, 42)
        Me.cmb_Origen.MaxDropDownItems = 20
        Me.cmb_Origen.Name = "cmb_Origen"
        Me.cmb_Origen.Size = New System.Drawing.Size(191, 21)
        Me.cmb_Origen.TabIndex = 7
        Me.cmb_Origen.ValueMember = "value"
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(41, 45)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Destino.TabIndex = 6
        Me.lbl_Destino.Text = "Origen"
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbl_Registros2)
        Me.GroupBox2.Controls.Add(Me.lsv_Envase)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 366)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(774, 144)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Envase"
        '
        'lbl_Registros2
        '
        Me.lbl_Registros2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros2.Location = New System.Drawing.Point(613, 16)
        Me.lbl_Registros2.Name = "lbl_Registros2"
        Me.lbl_Registros2.Size = New System.Drawing.Size(155, 22)
        Me.lbl_Registros2.TabIndex = 0
        Me.lbl_Registros2.Text = "Registros: 0"
        Me.lbl_Registros2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Envase
        '
        Me.lsv_Envase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envase.FullRowSelect = True
        Me.lsv_Envase.HideSelection = False
        Me.lsv_Envase.Location = New System.Drawing.Point(6, 41)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_Envase.Lvs = ListViewColumnSorter5
        Me.lsv_Envase.MultiSelect = False
        Me.lsv_Envase.Name = "lsv_Envase"
        Me.lsv_Envase.Row1 = 10
        Me.lsv_Envase.Row10 = 0
        Me.lsv_Envase.Row2 = 10
        Me.lsv_Envase.Row3 = 10
        Me.lsv_Envase.Row4 = 10
        Me.lsv_Envase.Row5 = 10
        Me.lsv_Envase.Row6 = 10
        Me.lsv_Envase.Row7 = 10
        Me.lsv_Envase.Row8 = 0
        Me.lsv_Envase.Row9 = 10
        Me.lsv_Envase.Size = New System.Drawing.Size(762, 97)
        Me.lsv_Envase.TabIndex = 1
        Me.lsv_Envase.UseCompatibleStateImageBehavior = False
        Me.lsv_Envase.View = System.Windows.Forms.View.Details
        '
        'frm_LotesEfectivo_Regresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbx_EfectivoF)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Lotes)
        Me.Controls.Add(Me.gbx_EfectivoB)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_LotesEfectivo_Regresar"
        Me.Text = "Regresar Efectivo"
        Me.gbx_EfectivoB.ResumeLayout(False)
        Me.gbx_Lotes.ResumeLayout(False)
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_EfectivoF.ResumeLayout(False)
        Me.gbx_EfectivoF.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Regresar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Efectivo As Modulo_Proceso.cp_Listview
    Friend WithEvents Lsv_EfectivoD As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_EfectivoB As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros3 As System.Windows.Forms.Label
    Friend WithEvents gbx_Lotes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_EfectivoF As System.Windows.Forms.GroupBox
    Friend WithEvents chk_CajaTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents cmb_Origen As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros2 As System.Windows.Forms.Label
    Friend WithEvents lsv_Envase As Modulo_Proceso.cp_Listview
End Class
