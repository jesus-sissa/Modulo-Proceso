<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EnviarMensajes
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Mensaje = New System.Windows.Forms.GroupBox
        Me.lbl_Mensaje = New System.Windows.Forms.Label
        Me.lbl_Asunto = New System.Windows.Forms.Label
        Me.tbx_Asunto = New System.Windows.Forms.TextBox
        Me.rtb_Mensaje = New System.Windows.Forms.RichTextBox
        Me.gbx_Mensajes = New System.Windows.Forms.GroupBox
        Me.Tab_Opciones = New System.Windows.Forms.TabControl
        Me.Tab_Usuario = New System.Windows.Forms.TabPage
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_Proceso.cp_Textbox
        Me.lsv_Usuarios = New Modulo_Proceso.cp_Listview
        Me.Tab_Modulo = New System.Windows.Forms.TabPage
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.lsv_Modulos = New Modulo_Proceso.cp_Listview
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Mensaje.SuspendLayout()
        Me.gbx_Mensajes.SuspendLayout()
        Me.Tab_Opciones.SuspendLayout()
        Me.Tab_Usuario.SuspendLayout()
        Me.Tab_Modulo.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 508)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cancelar.Location = New System.Drawing.Point(631, 13)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "&Cerrar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.HoraSi
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Enviar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'gbx_Mensaje
        '
        Me.gbx_Mensaje.Controls.Add(Me.lbl_Mensaje)
        Me.gbx_Mensaje.Controls.Add(Me.lbl_Asunto)
        Me.gbx_Mensaje.Controls.Add(Me.tbx_Asunto)
        Me.gbx_Mensaje.Controls.Add(Me.rtb_Mensaje)
        Me.gbx_Mensaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Mensaje.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Mensaje.Name = "gbx_Mensaje"
        Me.gbx_Mensaje.Size = New System.Drawing.Size(390, 490)
        Me.gbx_Mensaje.TabIndex = 1
        Me.gbx_Mensaje.TabStop = False
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.Location = New System.Drawing.Point(6, 62)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Mensaje.TabIndex = 2
        Me.lbl_Mensaje.Text = "Mensaje"
        '
        'lbl_Asunto
        '
        Me.lbl_Asunto.AutoSize = True
        Me.lbl_Asunto.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Asunto.Name = "lbl_Asunto"
        Me.lbl_Asunto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Asunto.TabIndex = 0
        Me.lbl_Asunto.Text = "Asunto"
        '
        'tbx_Asunto
        '
        Me.tbx_Asunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Asunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Asunto.Location = New System.Drawing.Point(9, 32)
        Me.tbx_Asunto.Name = "tbx_Asunto"
        Me.tbx_Asunto.Size = New System.Drawing.Size(372, 20)
        Me.tbx_Asunto.TabIndex = 1
        '
        'rtb_Mensaje
        '
        Me.rtb_Mensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_Mensaje.HideSelection = False
        Me.rtb_Mensaje.Location = New System.Drawing.Point(9, 83)
        Me.rtb_Mensaje.MaxLength = 5000
        Me.rtb_Mensaje.Name = "rtb_Mensaje"
        Me.rtb_Mensaje.Size = New System.Drawing.Size(372, 401)
        Me.rtb_Mensaje.TabIndex = 3
        Me.rtb_Mensaje.Text = ""
        '
        'gbx_Mensajes
        '
        Me.gbx_Mensajes.Controls.Add(Me.Tab_Opciones)
        Me.gbx_Mensajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Mensajes.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Mensajes.Name = "gbx_Mensajes"
        Me.gbx_Mensajes.Size = New System.Drawing.Size(384, 490)
        Me.gbx_Mensajes.TabIndex = 0
        Me.gbx_Mensajes.TabStop = False
        Me.gbx_Mensajes.Text = "Destino"
        '
        'Tab_Opciones
        '
        Me.Tab_Opciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Opciones.Controls.Add(Me.Tab_Usuario)
        Me.Tab_Opciones.Controls.Add(Me.Tab_Modulo)
        Me.Tab_Opciones.Location = New System.Drawing.Point(3, 22)
        Me.Tab_Opciones.Name = "Tab_Opciones"
        Me.Tab_Opciones.SelectedIndex = 0
        Me.Tab_Opciones.Size = New System.Drawing.Size(375, 462)
        Me.Tab_Opciones.TabIndex = 0
        '
        'Tab_Usuario
        '
        Me.Tab_Usuario.Controls.Add(Me.Lbl_Registros)
        Me.Tab_Usuario.Controls.Add(Me.btn_Buscar)
        Me.Tab_Usuario.Controls.Add(Me.lbl_Buscar)
        Me.Tab_Usuario.Controls.Add(Me.tbx_Buscar)
        Me.Tab_Usuario.Controls.Add(Me.lsv_Usuarios)
        Me.Tab_Usuario.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Usuario.Name = "Tab_Usuario"
        Me.Tab_Usuario.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Usuario.Size = New System.Drawing.Size(367, 436)
        Me.Tab_Usuario.TabIndex = 1
        Me.Tab_Usuario.Text = "Por Usuario"
        Me.Tab_Usuario.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(146, 36)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(215, 23)
        Me.Lbl_Registros.TabIndex = 52
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(288, 11)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(26, 23)
        Me.btn_Buscar.TabIndex = 14
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(5, 16)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 12
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(54, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Buscar.TabIndex = 13
        Me.tbx_Buscar.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Usuarios
        '
        Me.lsv_Usuarios.AllowColumnReorder = True
        Me.lsv_Usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Usuarios.CheckBoxes = True
        Me.lsv_Usuarios.FullRowSelect = True
        Me.lsv_Usuarios.HideSelection = False
        Me.lsv_Usuarios.Location = New System.Drawing.Point(4, 62)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Usuarios.Lvs = ListViewColumnSorter1
        Me.lsv_Usuarios.MultiSelect = False
        Me.lsv_Usuarios.Name = "lsv_Usuarios"
        Me.lsv_Usuarios.Row1 = 20
        Me.lsv_Usuarios.Row10 = 0
        Me.lsv_Usuarios.Row2 = 75
        Me.lsv_Usuarios.Row3 = 0
        Me.lsv_Usuarios.Row4 = 0
        Me.lsv_Usuarios.Row5 = 0
        Me.lsv_Usuarios.Row6 = 0
        Me.lsv_Usuarios.Row7 = 0
        Me.lsv_Usuarios.Row8 = 0
        Me.lsv_Usuarios.Row9 = 0
        Me.lsv_Usuarios.Size = New System.Drawing.Size(360, 368)
        Me.lsv_Usuarios.TabIndex = 2
        Me.lsv_Usuarios.UseCompatibleStateImageBehavior = False
        Me.lsv_Usuarios.View = System.Windows.Forms.View.Details
        '
        'Tab_Modulo
        '
        Me.Tab_Modulo.Controls.Add(Me.chk_Todos)
        Me.Tab_Modulo.Controls.Add(Me.lsv_Modulos)
        Me.Tab_Modulo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Modulo.Name = "Tab_Modulo"
        Me.Tab_Modulo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Modulo.Size = New System.Drawing.Size(336, 434)
        Me.Tab_Modulo.TabIndex = 0
        Me.Tab_Modulo.Text = "Por Módulo"
        Me.Tab_Modulo.UseVisualStyleBackColor = True
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(6, 6)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(115, 17)
        Me.chk_Todos.TabIndex = 0
        Me.chk_Todos.Text = "Seleccionar Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lsv_Modulos
        '
        Me.lsv_Modulos.AllowColumnReorder = True
        Me.lsv_Modulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Modulos.CheckBoxes = True
        Me.lsv_Modulos.FullRowSelect = True
        Me.lsv_Modulos.HideSelection = False
        Me.lsv_Modulos.Location = New System.Drawing.Point(3, 29)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Modulos.Lvs = ListViewColumnSorter2
        Me.lsv_Modulos.MultiSelect = False
        Me.lsv_Modulos.Name = "lsv_Modulos"
        Me.lsv_Modulos.Row1 = 95
        Me.lsv_Modulos.Row10 = 0
        Me.lsv_Modulos.Row2 = 0
        Me.lsv_Modulos.Row3 = 0
        Me.lsv_Modulos.Row4 = 0
        Me.lsv_Modulos.Row5 = 0
        Me.lsv_Modulos.Row6 = 0
        Me.lsv_Modulos.Row7 = 0
        Me.lsv_Modulos.Row8 = 0
        Me.lsv_Modulos.Row9 = 0
        Me.lsv_Modulos.Size = New System.Drawing.Size(327, 399)
        Me.lsv_Modulos.TabIndex = 1
        Me.lsv_Modulos.UseCompatibleStateImageBehavior = False
        Me.lsv_Modulos.View = System.Windows.Forms.View.Details
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Mensajes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_Mensaje)
        Me.SplitContainer1.Size = New System.Drawing.Size(778, 490)
        Me.SplitContainer1.SplitterDistance = 384
        Me.SplitContainer1.TabIndex = 3
        '
        'frm_EnviarMensajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EnviarMensajes"
        Me.Text = "Enviar Mensajes"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Mensaje.ResumeLayout(False)
        Me.gbx_Mensaje.PerformLayout()
        Me.gbx_Mensajes.ResumeLayout(False)
        Me.Tab_Opciones.ResumeLayout(False)
        Me.Tab_Usuario.ResumeLayout(False)
        Me.Tab_Usuario.PerformLayout()
        Me.Tab_Modulo.ResumeLayout(False)
        Me.Tab_Modulo.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Mensaje As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Mensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_Mensajes As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Modulos As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Asunto As System.Windows.Forms.Label
    Friend WithEvents tbx_Asunto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Tab_Opciones As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Modulo As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Usuario As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Usuarios As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tbx_Buscar As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
