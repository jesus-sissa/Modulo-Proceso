<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EliminarFicha
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
        Me.gbx_Buscar = New System.Windows.Forms.GroupBox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.cmb_CompañiaTraslado = New Modulo_Proceso.cp_cmb_Simple
        Me.Lbl_CompTras = New System.Windows.Forms.Label
        Me.tbx_Remision = New Modulo_Proceso.cp_Textbox
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox
        Me.tbx_Cajero = New System.Windows.Forms.TextBox
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.tbx_Cliente = New System.Windows.Forms.TextBox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.tbx_CajaBancaria = New System.Windows.Forms.TextBox
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.gbx_Fichas = New System.Windows.Forms.GroupBox
        Me.lbl_DobleClick = New System.Windows.Forms.Label
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Fichas = New Modulo_Proceso.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.gbx_Buscar.SuspendLayout()
        Me.gbx_Remisiones.SuspendLayout()
        Me.gbx_Fichas.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buscar
        '
        Me.gbx_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Buscar.Controls.Add(Me.btn_Buscar)
        Me.gbx_Buscar.Controls.Add(Me.cmb_CompañiaTraslado)
        Me.gbx_Buscar.Controls.Add(Me.Lbl_CompTras)
        Me.gbx_Buscar.Controls.Add(Me.tbx_Remision)
        Me.gbx_Buscar.Controls.Add(Me.lbl_Remision)
        Me.gbx_Buscar.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Buscar.Name = "gbx_Buscar"
        Me.gbx_Buscar.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Buscar.TabIndex = 0
        Me.gbx_Buscar.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(181, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(28, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'cmb_CompañiaTraslado
        '
        Me.cmb_CompañiaTraslado.Control_Siguiente = Nothing
        Me.cmb_CompañiaTraslado.DisplayMember = "Nombre"
        Me.cmb_CompañiaTraslado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CompañiaTraslado.Empresa = False
        Me.cmb_CompañiaTraslado.FormattingEnabled = True
        Me.cmb_CompañiaTraslado.Location = New System.Drawing.Point(334, 19)
        Me.cmb_CompañiaTraslado.MaxDropDownItems = 20
        Me.cmb_CompañiaTraslado.Name = "cmb_CompañiaTraslado"
        Me.cmb_CompañiaTraslado.Pista = True
        Me.cmb_CompañiaTraslado.Size = New System.Drawing.Size(373, 21)
        Me.cmb_CompañiaTraslado.StoredProcedure = Nothing
        Me.cmb_CompañiaTraslado.Sucursal = False
        Me.cmb_CompañiaTraslado.TabIndex = 3
        Me.cmb_CompañiaTraslado.ValueMember = "id_remision"
        '
        'Lbl_CompTras
        '
        Me.Lbl_CompTras.AutoSize = True
        Me.Lbl_CompTras.Location = New System.Drawing.Point(215, 22)
        Me.Lbl_CompTras.Name = "Lbl_CompTras"
        Me.Lbl_CompTras.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_CompTras.TabIndex = 2
        Me.Lbl_CompTras.Text = "Compañia de Traslado"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = False
        Me.tbx_Remision.Location = New System.Drawing.Point(65, 19)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Remision.TabIndex = 0
        Me.tbx_Remision.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(9, 22)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Remision.TabIndex = 0
        Me.lbl_Remision.Text = "Remision"
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Remisiones.Controls.Add(Me.tbx_Cajero)
        Me.gbx_Remisiones.Controls.Add(Me.lbl_Cajero)
        Me.gbx_Remisiones.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Remisiones.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Remisiones.Controls.Add(Me.tbx_CajaBancaria)
        Me.gbx_Remisiones.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(3, 56)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(778, 95)
        Me.gbx_Remisiones.TabIndex = 1
        Me.gbx_Remisiones.TabStop = False
        '
        'tbx_Cajero
        '
        Me.tbx_Cajero.BackColor = System.Drawing.Color.White
        Me.tbx_Cajero.Location = New System.Drawing.Point(99, 66)
        Me.tbx_Cajero.Name = "tbx_Cajero"
        Me.tbx_Cajero.ReadOnly = True
        Me.tbx_Cajero.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Cajero.TabIndex = 5
        Me.tbx_Cajero.TabStop = False
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(3, 69)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(90, 13)
        Me.lbl_Cajero.TabIndex = 4
        Me.lbl_Cajero.Text = "Cajero Verificador"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.BackColor = System.Drawing.Color.White
        Me.tbx_Cliente.Location = New System.Drawing.Point(99, 39)
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.ReadOnly = True
        Me.tbx_Cliente.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Cliente.TabIndex = 3
        Me.tbx_Cliente.TabStop = False
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(54, 42)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 2
        Me.lbl_Cliente.Text = "Cliente"
        '
        'tbx_CajaBancaria
        '
        Me.tbx_CajaBancaria.BackColor = System.Drawing.Color.White
        Me.tbx_CajaBancaria.Location = New System.Drawing.Point(99, 13)
        Me.tbx_CajaBancaria.Name = "tbx_CajaBancaria"
        Me.tbx_CajaBancaria.ReadOnly = True
        Me.tbx_CajaBancaria.Size = New System.Drawing.Size(400, 20)
        Me.tbx_CajaBancaria.TabIndex = 1
        Me.tbx_CajaBancaria.TabStop = False
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(20, 16)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 0
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'gbx_Fichas
        '
        Me.gbx_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Fichas.Controls.Add(Me.lbl_DobleClick)
        Me.gbx_Fichas.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Fichas.Controls.Add(Me.lsv_Fichas)
        Me.gbx_Fichas.Location = New System.Drawing.Point(3, 155)
        Me.gbx_Fichas.Name = "gbx_Fichas"
        Me.gbx_Fichas.Size = New System.Drawing.Size(778, 356)
        Me.gbx_Fichas.TabIndex = 2
        Me.gbx_Fichas.TabStop = False
        Me.gbx_Fichas.Text = "Fichas"
        '
        'lbl_DobleClick
        '
        Me.lbl_DobleClick.AutoSize = True
        Me.lbl_DobleClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DobleClick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_DobleClick.Location = New System.Drawing.Point(3, 17)
        Me.lbl_DobleClick.Name = "lbl_DobleClick"
        Me.lbl_DobleClick.Size = New System.Drawing.Size(167, 13)
        Me.lbl_DobleClick.TabIndex = 53
        Me.lbl_DobleClick.Text = "Doble clik para ver detalles."
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(629, 13)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(143, 21)
        Me.Lbl_Registros.TabIndex = 52
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Fichas
        '
        Me.lsv_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Fichas.FullRowSelect = True
        Me.lsv_Fichas.HideSelection = False
        Me.lsv_Fichas.Location = New System.Drawing.Point(3, 37)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Fichas.Lvs = ListViewColumnSorter1
        Me.lsv_Fichas.MultiSelect = False
        Me.lsv_Fichas.Name = "lsv_Fichas"
        Me.lsv_Fichas.Row1 = 7
        Me.lsv_Fichas.Row10 = 10
        Me.lsv_Fichas.Row2 = 7
        Me.lsv_Fichas.Row3 = 10
        Me.lsv_Fichas.Row4 = 10
        Me.lsv_Fichas.Row5 = 10
        Me.lsv_Fichas.Row6 = 10
        Me.lsv_Fichas.Row7 = 10
        Me.lsv_Fichas.Row8 = 10
        Me.lsv_Fichas.Row9 = 10
        Me.lsv_Fichas.Size = New System.Drawing.Size(772, 316)
        Me.lsv_Fichas.TabIndex = 4
        Me.lsv_Fichas.UseCompatibleStateImageBehavior = False
        Me.lsv_Fichas.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Eliminar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 508)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 5
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_Proceso.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(9, 11)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'frm_EliminarFicha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Fichas)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.Controls.Add(Me.gbx_Buscar)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EliminarFicha"
        Me.Text = "Eliminar Ficha"
        Me.gbx_Buscar.ResumeLayout(False)
        Me.gbx_Buscar.PerformLayout()
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_Remisiones.PerformLayout()
        Me.gbx_Fichas.ResumeLayout(False)
        Me.gbx_Fichas.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Fichas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_CompTras As System.Windows.Forms.Label
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents tbx_CajaBancaria As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents tbx_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Cajero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents lsv_Fichas As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_CompañiaTraslado As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_DobleClick As System.Windows.Forms.Label
End Class
