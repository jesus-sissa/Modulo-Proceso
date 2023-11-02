<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vales
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
        Me.Gpr_Filtro = New System.Windows.Forms.GroupBox
        Me.Cmb_Hasta = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Cmb_Desde = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Btn_Mostrar = New System.Windows.Forms.Button
        Me.Lbl_Caja_Bancaria = New System.Windows.Forms.Label
        Me.Cmb_Caja_Bancaria = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Cmb_Cliente = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Lbl_Cliente = New System.Windows.Forms.Label
        Me.Dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.Dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Desde = New System.Windows.Forms.Label
        Me.Grp_Lista = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lsv_Listado = New Modulo_Proceso.cp_Listview
        Me.Grp_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Exportar = New System.Windows.Forms.Button
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_FormatoExcel = New System.Windows.Forms.Button
        Me.Gpr_Filtro.SuspendLayout()
        Me.Grp_Lista.SuspendLayout()
        Me.Grp_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gpr_Filtro
        '
        Me.Gpr_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gpr_Filtro.Controls.Add(Me.Cmb_Hasta)
        Me.Gpr_Filtro.Controls.Add(Me.Cmb_Desde)
        Me.Gpr_Filtro.Controls.Add(Me.Btn_Mostrar)
        Me.Gpr_Filtro.Controls.Add(Me.Lbl_Caja_Bancaria)
        Me.Gpr_Filtro.Controls.Add(Me.Cmb_Caja_Bancaria)
        Me.Gpr_Filtro.Controls.Add(Me.Cmb_Cliente)
        Me.Gpr_Filtro.Controls.Add(Me.Lbl_Cliente)
        Me.Gpr_Filtro.Controls.Add(Me.Dtp_Hasta)
        Me.Gpr_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.Gpr_Filtro.Controls.Add(Me.Dtp_Desde)
        Me.Gpr_Filtro.Controls.Add(Me.Lbl_Desde)
        Me.Gpr_Filtro.Location = New System.Drawing.Point(8, 9)
        Me.Gpr_Filtro.Name = "Gpr_Filtro"
        Me.Gpr_Filtro.Size = New System.Drawing.Size(768, 121)
        Me.Gpr_Filtro.TabIndex = 0
        Me.Gpr_Filtro.TabStop = False
        '
        'Cmb_Hasta
        '
        Me.Cmb_Hasta.Clave = "Fecha"
        Me.Cmb_Hasta.Control_Siguiente = Nothing
        Me.Cmb_Hasta.DisplayMember = "Numero_Sesion"
        Me.Cmb_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Hasta.Empresa = False
        Me.Cmb_Hasta.Filtro = Nothing
        Me.Cmb_Hasta.FormattingEnabled = True
        Me.Cmb_Hasta.Location = New System.Drawing.Point(187, 41)
        Me.Cmb_Hasta.MaxDropDownItems = 20
        Me.Cmb_Hasta.Name = "Cmb_Hasta"
        Me.Cmb_Hasta.Pista = False
        Me.Cmb_Hasta.Size = New System.Drawing.Size(85, 21)
        Me.Cmb_Hasta.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.Cmb_Hasta.Sucursal = True
        Me.Cmb_Hasta.TabIndex = 5
        Me.Cmb_Hasta.Tipo = 0
        Me.Cmb_Hasta.ValueMember = "Id_Sesion"
        '
        'Cmb_Desde
        '
        Me.Cmb_Desde.Clave = ""
        Me.Cmb_Desde.Control_Siguiente = Nothing
        Me.Cmb_Desde.DisplayMember = "Numero_Sesion"
        Me.Cmb_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Desde.Empresa = False
        Me.Cmb_Desde.Filtro = Nothing
        Me.Cmb_Desde.FormattingEnabled = True
        Me.Cmb_Desde.Location = New System.Drawing.Point(187, 16)
        Me.Cmb_Desde.MaxDropDownItems = 20
        Me.Cmb_Desde.Name = "Cmb_Desde"
        Me.Cmb_Desde.Pista = False
        Me.Cmb_Desde.Size = New System.Drawing.Size(85, 21)
        Me.Cmb_Desde.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.Cmb_Desde.Sucursal = True
        Me.Cmb_Desde.TabIndex = 2
        Me.Cmb_Desde.Tipo = 0
        Me.Cmb_Desde.ValueMember = "Id_Sesion"
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.Btn_Mostrar.Location = New System.Drawing.Point(576, 85)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Mostrar.TabIndex = 11
        Me.Btn_Mostrar.Text = "&Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Lbl_Caja_Bancaria
        '
        Me.Lbl_Caja_Bancaria.AutoSize = True
        Me.Lbl_Caja_Bancaria.Location = New System.Drawing.Point(6, 68)
        Me.Lbl_Caja_Bancaria.Name = "Lbl_Caja_Bancaria"
        Me.Lbl_Caja_Bancaria.Size = New System.Drawing.Size(73, 13)
        Me.Lbl_Caja_Bancaria.TabIndex = 6
        Me.Lbl_Caja_Bancaria.Text = "Caja Bancaria"
        '
        'Cmb_Caja_Bancaria
        '
        Me.Cmb_Caja_Bancaria.Clave = "Clave_Cliente"
        Me.Cmb_Caja_Bancaria.Control_Siguiente = Nothing
        Me.Cmb_Caja_Bancaria.DisplayMember = "Nombre_Comercial"
        Me.Cmb_Caja_Bancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Caja_Bancaria.Empresa = False
        Me.Cmb_Caja_Bancaria.Filtro = Nothing
        Me.Cmb_Caja_Bancaria.FormattingEnabled = True
        Me.Cmb_Caja_Bancaria.Location = New System.Drawing.Point(85, 65)
        Me.Cmb_Caja_Bancaria.MaxDropDownItems = 20
        Me.Cmb_Caja_Bancaria.Name = "Cmb_Caja_Bancaria"
        Me.Cmb_Caja_Bancaria.Pista = False
        Me.Cmb_Caja_Bancaria.Size = New System.Drawing.Size(473, 21)
        Me.Cmb_Caja_Bancaria.StoredProcedure = "pro_cajasbancarias_comboget"
        Me.Cmb_Caja_Bancaria.Sucursal = True
        Me.Cmb_Caja_Bancaria.TabIndex = 7
        Me.Cmb_Caja_Bancaria.Tipo = 0
        Me.Cmb_Caja_Bancaria.ValueMember = "Id_CajaBancaria"
        '
        'Cmb_Cliente
        '
        Me.Cmb_Cliente.Clave = "Clave_Cliente"
        Me.Cmb_Cliente.Control_Siguiente = Nothing
        Me.Cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.Cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Cliente.Empresa = False
        Me.Cmb_Cliente.FormattingEnabled = True
        Me.Cmb_Cliente.Location = New System.Drawing.Point(86, 91)
        Me.Cmb_Cliente.MaxDropDownItems = 20
        Me.Cmb_Cliente.Name = "Cmb_Cliente"
        Me.Cmb_Cliente.Pista = False
        Me.Cmb_Cliente.Size = New System.Drawing.Size(400, 21)
        Me.Cmb_Cliente.StoredProcedure = "cat_ClientesProceso_GetPadres"
        Me.Cmb_Cliente.Sucursal = True
        Me.Cmb_Cliente.TabIndex = 10
        Me.Cmb_Cliente.Tipo = 0
        Me.Cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(38, 94)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 8
        Me.Lbl_Cliente.Text = "Cliente"
        '
        'Dtp_Hasta
        '
        Me.Dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Hasta.Location = New System.Drawing.Point(85, 41)
        Me.Dtp_Hasta.Name = "Dtp_Hasta"
        Me.Dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.Dtp_Hasta.TabIndex = 4
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(44, 42)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Hasta.TabIndex = 3
        Me.Lbl_Hasta.Text = "Hasta"
        '
        'Dtp_Desde
        '
        Me.Dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Desde.Location = New System.Drawing.Point(86, 16)
        Me.Dtp_Desde.Name = "Dtp_Desde"
        Me.Dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.Dtp_Desde.TabIndex = 1
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(42, 18)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Desde.TabIndex = 0
        Me.Lbl_Desde.Text = "Desde"
        '
        'Grp_Lista
        '
        Me.Grp_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_Lista.Controls.Add(Me.Lbl_Registros)
        Me.Grp_Lista.Controls.Add(Me.Lsv_Listado)
        Me.Grp_Lista.Location = New System.Drawing.Point(8, 130)
        Me.Grp_Lista.Name = "Grp_Lista"
        Me.Grp_Lista.Size = New System.Drawing.Size(768, 460)
        Me.Grp_Lista.TabIndex = 1
        Me.Grp_Lista.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(635, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(127, 13)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "0 Registros"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Listado
        '
        Me.Lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Listado.FullRowSelect = True
        Me.Lsv_Listado.HideSelection = False
        Me.Lsv_Listado.Location = New System.Drawing.Point(6, 32)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Listado.Lvs = ListViewColumnSorter1
        Me.Lsv_Listado.MultiSelect = False
        Me.Lsv_Listado.Name = "Lsv_Listado"
        Me.Lsv_Listado.Row1 = 16
        Me.Lsv_Listado.Row10 = 0
        Me.Lsv_Listado.Row2 = 16
        Me.Lsv_Listado.Row3 = 16
        Me.Lsv_Listado.Row4 = 16
        Me.Lsv_Listado.Row5 = 16
        Me.Lsv_Listado.Row6 = 16
        Me.Lsv_Listado.Row7 = 0
        Me.Lsv_Listado.Row8 = 0
        Me.Lsv_Listado.Row9 = 0
        Me.Lsv_Listado.Size = New System.Drawing.Size(756, 422)
        Me.Lsv_Listado.TabIndex = 1
        Me.Lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.Lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'Grp_Botones
        '
        Me.Grp_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_Botones.Controls.Add(Me.Btn_Exportar)
        Me.Grp_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.Grp_Botones.Controls.Add(Me.Btn_FormatoExcel)
        Me.Grp_Botones.Location = New System.Drawing.Point(8, 596)
        Me.Grp_Botones.Name = "Grp_Botones"
        Me.Grp_Botones.Size = New System.Drawing.Size(768, 50)
        Me.Grp_Botones.TabIndex = 2
        Me.Grp_Botones.TabStop = False
        '
        'Btn_Exportar
        '
        Me.Btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.Btn_Exportar.Location = New System.Drawing.Point(152, 14)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Exportar.TabIndex = 1
        Me.Btn_Exportar.Text = "&Exportar"
        Me.Btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(623, 14)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 2
        Me.Btn_Cerrar.Text = "&Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_FormatoExcel
        '
        Me.Btn_FormatoExcel.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.Btn_FormatoExcel.Location = New System.Drawing.Point(6, 14)
        Me.Btn_FormatoExcel.Name = "Btn_FormatoExcel"
        Me.Btn_FormatoExcel.Size = New System.Drawing.Size(140, 30)
        Me.Btn_FormatoExcel.TabIndex = 0
        Me.Btn_FormatoExcel.Text = "&Formato Excel"
        Me.Btn_FormatoExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_FormatoExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_FormatoExcel.UseVisualStyleBackColor = True
        '
        'frm_Vales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.Grp_Botones)
        Me.Controls.Add(Me.Grp_Lista)
        Me.Controls.Add(Me.Gpr_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Vales"
        Me.Text = "Vales"
        Me.Gpr_Filtro.ResumeLayout(False)
        Me.Gpr_Filtro.PerformLayout()
        Me.Grp_Lista.ResumeLayout(False)
        Me.Grp_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gpr_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Grp_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents Lsv_Listado As Modulo_Proceso.cp_Listview
    Friend WithEvents Dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents Cmb_Cliente As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Grp_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_FormatoExcel As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lbl_Caja_Bancaria As System.Windows.Forms.Label
    Friend WithEvents Cmb_Caja_Bancaria As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Cmb_Hasta As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Cmb_Desde As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Btn_Exportar As System.Windows.Forms.Button
End Class
