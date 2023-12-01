<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ArchivoDepositos
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
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbx_ArchivosDepositos = New System.Windows.Forms.GroupBox()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.pgr_Barra = New System.Windows.Forms.ProgressBar()
        Me.chk_Todos = New System.Windows.Forms.CheckBox()
        Me.lbl_Registros = New System.Windows.Forms.Label()
        Me.lsv_Archivos = New Modulo_Proceso.cp_Listview()
        Me.btn_Destino = New System.Windows.Forms.Button()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Enviar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_Sesiones = New Modulo_Proceso.cp_cmb_Parametro()
        Me.lbl_Sesion = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lsv_Banregio = New Modulo_Proceso.cp_Listview()
        Me.Chk_TodosBanregio = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbx_ArchivosDepositos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1053, 536)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbx_ArchivosDepositos)
        Me.TabPage1.Controls.Add(Me.gbx_Botones)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1045, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BANORTE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbx_ArchivosDepositos
        '
        Me.gbx_ArchivosDepositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ArchivosDepositos.Controls.Add(Me.lbl_Mensaje)
        Me.gbx_ArchivosDepositos.Controls.Add(Me.pgr_Barra)
        Me.gbx_ArchivosDepositos.Controls.Add(Me.chk_Todos)
        Me.gbx_ArchivosDepositos.Controls.Add(Me.lbl_Registros)
        Me.gbx_ArchivosDepositos.Controls.Add(Me.lsv_Archivos)
        Me.gbx_ArchivosDepositos.Controls.Add(Me.btn_Destino)
        Me.gbx_ArchivosDepositos.Location = New System.Drawing.Point(1, 6)
        Me.gbx_ArchivosDepositos.Name = "gbx_ArchivosDepositos"
        Me.gbx_ArchivosDepositos.Size = New System.Drawing.Size(1042, 456)
        Me.gbx_ArchivosDepositos.TabIndex = 3
        Me.gbx_ArchivosDepositos.TabStop = False
        Me.gbx_ArchivosDepositos.Text = "Archivos"
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.Location = New System.Drawing.Point(204, 29)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(11, 13)
        Me.lbl_Mensaje.TabIndex = 11
        Me.lbl_Mensaje.Text = "*"
        '
        'pgr_Barra
        '
        Me.pgr_Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgr_Barra.Location = New System.Drawing.Point(9, 427)
        Me.pgr_Barra.Name = "pgr_Barra"
        Me.pgr_Barra.Size = New System.Drawing.Size(1027, 23)
        Me.pgr_Barra.TabIndex = 10
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(9, 49)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(51, 17)
        Me.chk_Todos.TabIndex = 9
        Me.chk_Todos.Text = "Todo"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.AutoSize = True
        Me.lbl_Registros.Location = New System.Drawing.Point(961, 36)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Registros.TabIndex = 8
        Me.lbl_Registros.Text = "Registros: 0"
        '
        'lsv_Archivos
        '
        Me.lsv_Archivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Archivos.CheckBoxes = True
        Me.lsv_Archivos.FullRowSelect = True
        Me.lsv_Archivos.HideSelection = False
        Me.lsv_Archivos.Location = New System.Drawing.Point(7, 69)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Archivos.Lvs = ListViewColumnSorter1
        Me.lsv_Archivos.MultiSelect = False
        Me.lsv_Archivos.Name = "lsv_Archivos"
        Me.lsv_Archivos.Row1 = 40
        Me.lsv_Archivos.Row10 = 10
        Me.lsv_Archivos.Row2 = 10
        Me.lsv_Archivos.Row3 = 10
        Me.lsv_Archivos.Row4 = 10
        Me.lsv_Archivos.Row5 = 10
        Me.lsv_Archivos.Row6 = 10
        Me.lsv_Archivos.Row7 = 10
        Me.lsv_Archivos.Row8 = 10
        Me.lsv_Archivos.Row9 = 10
        Me.lsv_Archivos.Size = New System.Drawing.Size(1029, 351)
        Me.lsv_Archivos.TabIndex = 7
        Me.lsv_Archivos.UseCompatibleStateImageBehavior = False
        Me.lsv_Archivos.View = System.Windows.Forms.View.Details
        '
        'btn_Destino
        '
        Me.btn_Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Destino.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar1
        Me.btn_Destino.Location = New System.Drawing.Point(6, 13)
        Me.btn_Destino.Name = "btn_Destino"
        Me.btn_Destino.Size = New System.Drawing.Size(140, 30)
        Me.btn_Destino.TabIndex = 6
        Me.btn_Destino.Text = "Cargar Archivos"
        Me.btn_Destino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Destino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Destino.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Enviar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(1, 462)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(1042, 45)
        Me.gbx_Botones.TabIndex = 4
        Me.gbx_Botones.TabStop = False
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Enabled = False
        Me.btn_Enviar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Enviar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Enviar.TabIndex = 2
        Me.btn_Enviar.Text = "&Enviar"
        Me.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Enviar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(896, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1045, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BANREGIO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmb_Sesiones)
        Me.GroupBox1.Controls.Add(Me.lbl_Sesion)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Chk_TodosBanregio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Lsv_Banregio)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1042, 456)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Archivos"
        '
        'cmb_Sesiones
        '
        Me.cmb_Sesiones.Cia = False
        Me.cmb_Sesiones.Control_Siguiente = Nothing
        Me.cmb_Sesiones.DisplayMember = "Numero_Sesion"
        Me.cmb_Sesiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sesiones.Empresa = False
        Me.cmb_Sesiones.FormattingEnabled = True
        Me.cmb_Sesiones.Location = New System.Drawing.Point(249, 21)
        Me.cmb_Sesiones.MaxDropDownItems = 20
        Me.cmb_Sesiones.Name = "cmb_Sesiones"
        Me.cmb_Sesiones.NombreParametro = "@Fecha"
        Me.cmb_Sesiones.Pista = False
        Me.cmb_Sesiones.Size = New System.Drawing.Size(132, 21)
        Me.cmb_Sesiones.StoredProcedure = "Pro_Sesion_GetByFecha"
        Me.cmb_Sesiones.Sucursal = True
        Me.cmb_Sesiones.TabIndex = 17
        Me.cmb_Sesiones.Tipodedatos = System.Data.SqlDbType.DateTime
        Me.cmb_Sesiones.ValorParametro = Nothing
        Me.cmb_Sesiones.ValueMember = "Id_Sesion"
        '
        'lbl_Sesion
        '
        Me.lbl_Sesion.Location = New System.Drawing.Point(204, 26)
        Me.lbl_Sesion.Name = "lbl_Sesion"
        Me.lbl_Sesion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Sesion.TabIndex = 16
        Me.lbl_Sesion.Text = "Sesion"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(5, 26)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 14
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(51, 22)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(130, 20)
        Me.dtp_Fecha.TabIndex = 15
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 427)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1029, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(961, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Registros: 0"
        '
        'Lsv_Banregio
        '
        Me.Lsv_Banregio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Banregio.CheckBoxes = True
        Me.Lsv_Banregio.FullRowSelect = True
        Me.Lsv_Banregio.HideSelection = False
        Me.Lsv_Banregio.Location = New System.Drawing.Point(7, 72)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Banregio.Lvs = ListViewColumnSorter2
        Me.Lsv_Banregio.MultiSelect = False
        Me.Lsv_Banregio.Name = "Lsv_Banregio"
        Me.Lsv_Banregio.Row1 = 10
        Me.Lsv_Banregio.Row10 = 0
        Me.Lsv_Banregio.Row2 = 10
        Me.Lsv_Banregio.Row3 = 10
        Me.Lsv_Banregio.Row4 = 10
        Me.Lsv_Banregio.Row5 = 10
        Me.Lsv_Banregio.Row6 = 10
        Me.Lsv_Banregio.Row7 = 10
        Me.Lsv_Banregio.Row8 = 0
        Me.Lsv_Banregio.Row9 = 0
        Me.Lsv_Banregio.Size = New System.Drawing.Size(1029, 348)
        Me.Lsv_Banregio.TabIndex = 7
        Me.Lsv_Banregio.UseCompatibleStateImageBehavior = False
        Me.Lsv_Banregio.View = System.Windows.Forms.View.Details
        '
        'Chk_TodosBanregio
        '
        Me.Chk_TodosBanregio.AutoSize = True
        Me.Chk_TodosBanregio.Checked = True
        Me.Chk_TodosBanregio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_TodosBanregio.Location = New System.Drawing.Point(9, 49)
        Me.Chk_TodosBanregio.Name = "Chk_TodosBanregio"
        Me.Chk_TodosBanregio.Size = New System.Drawing.Size(51, 17)
        Me.Chk_TodosBanregio.TabIndex = 9
        Me.Chk_TodosBanregio.Text = "Todo"
        Me.Chk_TodosBanregio.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar1
        Me.Button1.Location = New System.Drawing.Point(400, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cargar Archivos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 462)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1042, 45)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.Button2.Location = New System.Drawing.Point(6, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Enviar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.Button3.Location = New System.Drawing.Point(894, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 30)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "&Cerrar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frm_ArchivoDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 548)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_ArchivoDepositos"
        Me.Text = "Envío de Archivos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbx_ArchivosDepositos.ResumeLayout(False)
        Me.gbx_ArchivosDepositos.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbx_ArchivosDepositos As GroupBox
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents pgr_Barra As ProgressBar
    Friend WithEvents chk_Todos As CheckBox
    Friend WithEvents lbl_Registros As Label
    Friend WithEvents lsv_Archivos As cp_Listview
    Friend WithEvents btn_Destino As Button
    Friend WithEvents gbx_Botones As GroupBox
    Friend WithEvents btn_Enviar As Button
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Lsv_Banregio As cp_Listview
    Friend WithEvents cmb_Sesiones As cp_cmb_Parametro
    Friend WithEvents lbl_Sesion As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents Chk_TodosBanregio As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
