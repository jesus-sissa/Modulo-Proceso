<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Saldos
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
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.cmb_Sesion = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.lbl_Sesion = New System.Windows.Forms.Label
        Me.Lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.cmb_CajaBancaria = New Modulo_Proceso.cp_cmb_SimpleFiltrado
        Me.cmb_Moneda = New Modulo_Proceso.cp_cmb_Simple
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.gbx_EntradasXDisponer = New System.Windows.Forms.GroupBox
        Me.lsv_EntradaxVerificar = New Modulo_Proceso.cp_Listview
        Me.gbx_EntradasDisponibles = New System.Windows.Forms.GroupBox
        Me.lsv_EntradasDisponibles = New Modulo_Proceso.cp_Listview
        Me.spc_SaldosEntrada = New System.Windows.Forms.SplitContainer
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_EntradasXDisponer.SuspendLayout()
        Me.gbx_EntradasDisponibles.SuspendLayout()
        Me.spc_SaldosEntrada.Panel1.SuspendLayout()
        Me.spc_SaldosEntrada.Panel2.SuspendLayout()
        Me.spc_SaldosEntrada.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.cmb_Sesion)
        Me.gbx_Datos.Controls.Add(Me.lbl_Sesion)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Fecha)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Datos.Controls.Add(Me.lbl_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.cmb_CajaBancaria)
        Me.gbx_Datos.Controls.Add(Me.cmb_Moneda)
        Me.gbx_Datos.Controls.Add(Me.lbl_Moneda)
        Me.gbx_Datos.Location = New System.Drawing.Point(8, 12)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(768, 127)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        Me.gbx_Datos.Text = "Datos"
        '
        'cmb_Sesion
        '
        Me.cmb_Sesion.Clave = Nothing
        Me.cmb_Sesion.Control_Siguiente = Nothing
        Me.cmb_Sesion.DisplayMember = "Numero_Sesion"
        Me.cmb_Sesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sesion.Empresa = False
        Me.cmb_Sesion.Filtro = Nothing
        Me.cmb_Sesion.FormattingEnabled = True
        Me.cmb_Sesion.Location = New System.Drawing.Point(245, 27)
        Me.cmb_Sesion.MaxDropDownItems = 20
        Me.cmb_Sesion.Name = "cmb_Sesion"
        Me.cmb_Sesion.Pista = False
        Me.cmb_Sesion.Size = New System.Drawing.Size(101, 21)
        Me.cmb_Sesion.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Sesion.Sucursal = True
        Me.cmb_Sesion.TabIndex = 11
        Me.cmb_Sesion.Tipo = 0
        Me.cmb_Sesion.ValueMember = "Id_Sesion"
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.AutoSize = True
        Me.lbl_Sesion.Location = New System.Drawing.Point(197, 30)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Sesion.TabIndex = 10
        Me.lbl_Sesion.Text = "Sesión:"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(50, 30)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Fecha.TabIndex = 8
        Me.Lbl_Fecha.Text = "Fecha:"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(96, 26)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 9
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(412, 79)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_CajaBancaria
        '
        Me.lbl_CajaBancaria.AutoSize = True
        Me.lbl_CajaBancaria.Location = New System.Drawing.Point(17, 57)
        Me.lbl_CajaBancaria.Name = "lbl_CajaBancaria"
        Me.lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CajaBancaria.TabIndex = 2
        Me.lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'cmb_CajaBancaria
        '
        Me.cmb_CajaBancaria.Clave = "Clave"
        Me.cmb_CajaBancaria.Control_Siguiente = Nothing
        Me.cmb_CajaBancaria.DisplayMember = "Nombre_Comercial"
        Me.cmb_CajaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CajaBancaria.Empresa = False
        Me.cmb_CajaBancaria.FormattingEnabled = True
        Me.cmb_CajaBancaria.Location = New System.Drawing.Point(96, 54)
        Me.cmb_CajaBancaria.MaxDropDownItems = 20
        Me.cmb_CajaBancaria.Name = "cmb_CajaBancaria"
        Me.cmb_CajaBancaria.NombreParametro = Nothing
        Me.cmb_CajaBancaria.Pista = False
        Me.cmb_CajaBancaria.Size = New System.Drawing.Size(400, 21)
        Me.cmb_CajaBancaria.StoredProcedure = "Pro_CajasBancarias_ComboGet"
        Me.cmb_CajaBancaria.Sucursal = True
        Me.cmb_CajaBancaria.TabIndex = 4
        Me.cmb_CajaBancaria.Tipo = 0
        Me.cmb_CajaBancaria.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_CajaBancaria.ValorParametro = Nothing
        Me.cmb_CajaBancaria.ValueMember = "Id_CajaBancaria"
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.Control_Siguiente = Nothing
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(96, 85)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = True
        Me.cmb_Moneda.Size = New System.Drawing.Size(232, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_Monedas_Get"
        Me.cmb_Moneda.Sucursal = True
        Me.cmb_Moneda.TabIndex = 6
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(41, 88)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Moneda.TabIndex = 5
        Me.lbl_Moneda.Text = "Moneda:"
        '
        'gbx_EntradasXDisponer
        '
        Me.gbx_EntradasXDisponer.Controls.Add(Me.lsv_EntradaxVerificar)
        Me.gbx_EntradasXDisponer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_EntradasXDisponer.Location = New System.Drawing.Point(0, 0)
        Me.gbx_EntradasXDisponer.Name = "gbx_EntradasXDisponer"
        Me.gbx_EntradasXDisponer.Size = New System.Drawing.Size(391, 404)
        Me.gbx_EntradasXDisponer.TabIndex = 2
        Me.gbx_EntradasXDisponer.TabStop = False
        Me.gbx_EntradasXDisponer.Text = "Por Verificar"
        '
        'lsv_EntradaxVerificar
        '
        Me.lsv_EntradaxVerificar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EntradaxVerificar.FullRowSelect = True
        Me.lsv_EntradaxVerificar.HideSelection = False
        Me.lsv_EntradaxVerificar.Location = New System.Drawing.Point(7, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_EntradaxVerificar.Lvs = ListViewColumnSorter1
        Me.lsv_EntradaxVerificar.MultiSelect = False
        Me.lsv_EntradaxVerificar.Name = "lsv_EntradaxVerificar"
        Me.lsv_EntradaxVerificar.Row1 = 50
        Me.lsv_EntradaxVerificar.Row10 = 0
        Me.lsv_EntradaxVerificar.Row2 = 45
        Me.lsv_EntradaxVerificar.Row3 = 0
        Me.lsv_EntradaxVerificar.Row4 = 0
        Me.lsv_EntradaxVerificar.Row5 = 0
        Me.lsv_EntradaxVerificar.Row6 = 0
        Me.lsv_EntradaxVerificar.Row7 = 0
        Me.lsv_EntradaxVerificar.Row8 = 0
        Me.lsv_EntradaxVerificar.Row9 = 0
        Me.lsv_EntradaxVerificar.Size = New System.Drawing.Size(378, 378)
        Me.lsv_EntradaxVerificar.TabIndex = 0
        Me.lsv_EntradaxVerificar.UseCompatibleStateImageBehavior = False
        Me.lsv_EntradaxVerificar.View = System.Windows.Forms.View.Details
        '
        'gbx_EntradasDisponibles
        '
        Me.gbx_EntradasDisponibles.Controls.Add(Me.lsv_EntradasDisponibles)
        Me.gbx_EntradasDisponibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_EntradasDisponibles.Location = New System.Drawing.Point(0, 0)
        Me.gbx_EntradasDisponibles.Name = "gbx_EntradasDisponibles"
        Me.gbx_EntradasDisponibles.Size = New System.Drawing.Size(373, 404)
        Me.gbx_EntradasDisponibles.TabIndex = 1
        Me.gbx_EntradasDisponibles.TabStop = False
        Me.gbx_EntradasDisponibles.Text = "Verificado y Disponible"
        '
        'lsv_EntradasDisponibles
        '
        Me.lsv_EntradasDisponibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EntradasDisponibles.FullRowSelect = True
        Me.lsv_EntradasDisponibles.HideSelection = False
        Me.lsv_EntradasDisponibles.Location = New System.Drawing.Point(7, 20)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_EntradasDisponibles.Lvs = ListViewColumnSorter2
        Me.lsv_EntradasDisponibles.MultiSelect = False
        Me.lsv_EntradasDisponibles.Name = "lsv_EntradasDisponibles"
        Me.lsv_EntradasDisponibles.Row1 = 50
        Me.lsv_EntradasDisponibles.Row10 = 0
        Me.lsv_EntradasDisponibles.Row2 = 45
        Me.lsv_EntradasDisponibles.Row3 = 0
        Me.lsv_EntradasDisponibles.Row4 = 0
        Me.lsv_EntradasDisponibles.Row5 = 0
        Me.lsv_EntradasDisponibles.Row6 = 0
        Me.lsv_EntradasDisponibles.Row7 = 0
        Me.lsv_EntradasDisponibles.Row8 = 0
        Me.lsv_EntradasDisponibles.Row9 = 0
        Me.lsv_EntradasDisponibles.Size = New System.Drawing.Size(360, 378)
        Me.lsv_EntradasDisponibles.TabIndex = 0
        Me.lsv_EntradasDisponibles.UseCompatibleStateImageBehavior = False
        Me.lsv_EntradasDisponibles.View = System.Windows.Forms.View.Details
        '
        'spc_SaldosEntrada
        '
        Me.spc_SaldosEntrada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spc_SaldosEntrada.Location = New System.Drawing.Point(8, 145)
        Me.spc_SaldosEntrada.Name = "spc_SaldosEntrada"
        '
        'spc_SaldosEntrada.Panel1
        '
        Me.spc_SaldosEntrada.Panel1.Controls.Add(Me.gbx_EntradasDisponibles)
        '
        'spc_SaldosEntrada.Panel2
        '
        Me.spc_SaldosEntrada.Panel2.Controls.Add(Me.gbx_EntradasXDisponer)
        Me.spc_SaldosEntrada.Size = New System.Drawing.Size(768, 404)
        Me.spc_SaldosEntrada.SplitterDistance = 373
        Me.spc_SaldosEntrada.TabIndex = 3
        '
        'frm_Saldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.spc_SaldosEntrada)
        Me.Controls.Add(Me.gbx_Datos)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Saldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldos"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_EntradasXDisponer.ResumeLayout(False)
        Me.gbx_EntradasDisponibles.ResumeLayout(False)
        Me.spc_SaldosEntrada.Panel1.ResumeLayout(False)
        Me.spc_SaldosEntrada.Panel2.ResumeLayout(False)
        Me.spc_SaldosEntrada.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents lsv_EntradasDisponibles As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_EntradasXDisponer As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_EntradaxVerificar As Modulo_Proceso.cp_Listview
    Friend WithEvents cmb_Moneda As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_CajaBancaria As Modulo_Proceso.cp_cmb_SimpleFiltrado
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_EntradasDisponibles As System.Windows.Forms.GroupBox
    Friend WithEvents spc_SaldosEntrada As System.Windows.Forms.SplitContainer
    Friend WithEvents cmb_Sesion As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Sesion As System.Windows.Forms.Label
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
End Class
