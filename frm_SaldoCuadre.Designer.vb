<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SaldoCuadre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SaldoCuadre))
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.Lbl_Columna = New System.Windows.Forms.Label
        Me.tbx_Verde = New System.Windows.Forms.TextBox
        Me.Chk_Todas = New System.Windows.Forms.CheckBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Presentacion = New System.Windows.Forms.Label
        Me.cmb_Presentacion = New Modulo_Proceso.cp_cmb_Manual
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_Caja = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_Simple
        Me.Gbx_Grietview = New System.Windows.Forms.GroupBox
        Me.lbl_Diferencia = New System.Windows.Forms.Label
        Me.lbl_Total1 = New System.Windows.Forms.Label
        Me.Dgv_Saldo = New System.Windows.Forms.DataGridView
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad_Anterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe_Inicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CandidadA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Suma = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe_Final = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Grietview.SuspendLayout()
        CType(Me.Dgv_Saldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Columna)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_Verde)
        Me.Gbx_Filtro.Controls.Add(Me.Chk_Todas)
        Me.Gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Presentacion)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Presentacion)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Moneda)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Moneda)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_CajaBancaria)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(8, 12)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(768, 79)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'Lbl_Columna
        '
        Me.Lbl_Columna.AutoSize = True
        Me.Lbl_Columna.Location = New System.Drawing.Point(530, 16)
        Me.Lbl_Columna.Name = "Lbl_Columna"
        Me.Lbl_Columna.Size = New System.Drawing.Size(103, 13)
        Me.Lbl_Columna.TabIndex = 62
        Me.Lbl_Columna.Text = "Columna Modificada"
        '
        'tbx_Verde
        '
        Me.tbx_Verde.BackColor = System.Drawing.Color.LightGreen
        Me.tbx_Verde.Location = New System.Drawing.Point(502, 13)
        Me.tbx_Verde.Name = "tbx_Verde"
        Me.tbx_Verde.Size = New System.Drawing.Size(22, 20)
        Me.tbx_Verde.TabIndex = 61
        '
        'Chk_Todas
        '
        Me.Chk_Todas.AutoSize = True
        Me.Chk_Todas.Location = New System.Drawing.Point(468, 49)
        Me.Chk_Todas.Name = "Chk_Todas"
        Me.Chk_Todas.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Todas.TabIndex = 60
        Me.Chk_Todas.Text = "Todas"
        Me.Chk_Todas.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(530, 43)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 59
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Presentacion
        '
        Me.lbl_Presentacion.AutoSize = True
        Me.lbl_Presentacion.Location = New System.Drawing.Point(266, 50)
        Me.lbl_Presentacion.Name = "lbl_Presentacion"
        Me.lbl_Presentacion.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Presentacion.TabIndex = 57
        Me.lbl_Presentacion.Text = "Presentacion"
        '
        'cmb_Presentacion
        '
        Me.cmb_Presentacion.Control_Siguiente = Nothing
        Me.cmb_Presentacion.DisplayMember = "display"
        Me.cmb_Presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Presentacion.FormattingEnabled = True
        Me.cmb_Presentacion.Location = New System.Drawing.Point(341, 47)
        Me.cmb_Presentacion.MaxDropDownItems = 20
        Me.cmb_Presentacion.Name = "cmb_Presentacion"
        Me.cmb_Presentacion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Presentacion.TabIndex = 56
        Me.cmb_Presentacion.ValueMember = "value"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(33, 50)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Moneda.TabIndex = 55
        Me.lbl_Moneda.Text = "Moneda"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(85, 47)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(153, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 54
        Me.cmb_Moneda.ValueMember = "id_Moneda"
        '
        'lbl_Caja
        '
        Me.lbl_Caja.AutoSize = True
        Me.lbl_Caja.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Caja.Name = "lbl_Caja"
        Me.lbl_Caja.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Caja.TabIndex = 50
        Me.lbl_Caja.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(85, 13)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 51
        Me.cmb_CajaBancaria.ValueMember = "id_CajaBancaria"
        '
        'Gbx_Grietview
        '
        Me.Gbx_Grietview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Grietview.Controls.Add(Me.lbl_Diferencia)
        Me.Gbx_Grietview.Controls.Add(Me.lbl_Total1)
        Me.Gbx_Grietview.Controls.Add(Me.Dgv_Saldo)
        Me.Gbx_Grietview.Controls.Add(Me.lbl_Total)
        Me.Gbx_Grietview.Location = New System.Drawing.Point(8, 97)
        Me.Gbx_Grietview.Name = "Gbx_Grietview"
        Me.Gbx_Grietview.Size = New System.Drawing.Size(767, 423)
        Me.Gbx_Grietview.TabIndex = 1
        Me.Gbx_Grietview.TabStop = False
        '
        'lbl_Diferencia
        '
        Me.lbl_Diferencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Diferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Diferencia.Location = New System.Drawing.Point(244, 397)
        Me.lbl_Diferencia.Name = "lbl_Diferencia"
        Me.lbl_Diferencia.Size = New System.Drawing.Size(295, 23)
        Me.lbl_Diferencia.TabIndex = 44
        Me.lbl_Diferencia.Text = "Diferencia: 0"
        Me.lbl_Diferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Total1
        '
        Me.lbl_Total1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total1.Location = New System.Drawing.Point(545, 397)
        Me.lbl_Total1.Name = "lbl_Total1"
        Me.lbl_Total1.Size = New System.Drawing.Size(216, 23)
        Me.lbl_Total1.TabIndex = 43
        Me.lbl_Total1.Text = "Importe Final Total: 0"
        Me.lbl_Total1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dgv_Saldo
        '
        Me.Dgv_Saldo.AllowUserToAddRows = False
        Me.Dgv_Saldo.AllowUserToDeleteRows = False
        Me.Dgv_Saldo.AllowUserToOrderColumns = True
        Me.Dgv_Saldo.AllowUserToResizeColumns = False
        Me.Dgv_Saldo.AllowUserToResizeRows = False
        Me.Dgv_Saldo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Saldo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Saldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Saldo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Presentacion, Me.Denominacion, Me.Cantidad_Anterior, Me.Importe_Inicial, Me.Cantidad, Me.CandidadA, Me.CantidadB, Me.CantidadC, Me.CantidadD, Me.CantidadE, Me.Suma, Me.Importe_Final})
        Me.Dgv_Saldo.Location = New System.Drawing.Point(6, 19)
        Me.Dgv_Saldo.Name = "Dgv_Saldo"
        Me.Dgv_Saldo.Size = New System.Drawing.Size(755, 375)
        Me.Dgv_Saldo.TabIndex = 0
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(6, 397)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(232, 23)
        Me.lbl_Total.TabIndex = 42
        Me.lbl_Total.Text = "Importe Anterior Total: 0"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(8, 526)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(767, 47)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 16
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 41
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Presentacion
        '
        Me.Presentacion.HeaderText = "Presentacion"
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.Width = 94
        '
        'Denominacion
        '
        Me.Denominacion.HeaderText = "Denominacion"
        Me.Denominacion.Name = "Denominacion"
        '
        'Cantidad_Anterior
        '
        Me.Cantidad_Anterior.HeaderText = "Cantidad Anterior"
        Me.Cantidad_Anterior.Name = "Cantidad_Anterior"
        Me.Cantidad_Anterior.Width = 104
        '
        'Importe_Inicial
        '
        Me.Importe_Inicial.HeaderText = "Importe Inicial"
        Me.Importe_Inicial.Name = "Importe_Inicial"
        Me.Importe_Inicial.Width = 89
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 74
        '
        'CandidadA
        '
        Me.CandidadA.HeaderText = "CantidadA"
        Me.CandidadA.Name = "CandidadA"
        Me.CandidadA.Width = 81
        '
        'CantidadB
        '
        Me.CantidadB.HeaderText = "CantidadB"
        Me.CantidadB.Name = "CantidadB"
        Me.CantidadB.Width = 81
        '
        'CantidadC
        '
        Me.CantidadC.HeaderText = "CantidadC"
        Me.CantidadC.Name = "CantidadC"
        Me.CantidadC.Width = 81
        '
        'CantidadD
        '
        Me.CantidadD.HeaderText = "CantidadD"
        Me.CantidadD.Name = "CantidadD"
        Me.CantidadD.Width = 82
        '
        'CantidadE
        '
        Me.CantidadE.HeaderText = "CantiadadE"
        Me.CantidadE.Name = "CantidadE"
        Me.CantidadE.Width = 87
        '
        'Suma
        '
        Me.Suma.HeaderText = "Suma"
        Me.Suma.Name = "Suma"
        Me.Suma.Width = 59
        '
        'Importe_Final
        '
        Me.Importe_Final.HeaderText = "Importe Final"
        Me.Importe_Final.Name = "Importe_Final"
        Me.Importe_Final.Width = 85
        '
        'frm_SaldoCuadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 585)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Grietview)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_SaldoCuadre"
        Me.Text = "Clasificar Saldo"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Grietview.ResumeLayout(False)
        CType(Me.Dgv_Saldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Grietview As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Caja As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_Presentacion As System.Windows.Forms.Label
    Friend WithEvents cmb_Presentacion As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Dgv_Saldo As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Chk_Todas As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Total1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Lbl_Columna As System.Windows.Forms.Label
    Friend WithEvents tbx_Verde As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Diferencia As System.Windows.Forms.Label
    Friend WithEvents Presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_Anterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe_Inicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CandidadA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Suma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe_Final As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
