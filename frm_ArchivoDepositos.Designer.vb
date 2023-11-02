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
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_ArchivosDepositos = New System.Windows.Forms.GroupBox
        Me.pgr_Barra = New System.Windows.Forms.ProgressBar
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Archivos = New Modulo_Proceso.cp_Listview
        Me.btn_Destino = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Enviar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_Mensaje = New System.Windows.Forms.Label
        Me.gbx_ArchivosDepositos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gbx_ArchivosDepositos.Location = New System.Drawing.Point(6, 4)
        Me.gbx_ArchivosDepositos.Name = "gbx_ArchivosDepositos"
        Me.gbx_ArchivosDepositos.Size = New System.Drawing.Size(1042, 463)
        Me.gbx_ArchivosDepositos.TabIndex = 0
        Me.gbx_ArchivosDepositos.TabStop = False
        Me.gbx_ArchivosDepositos.Text = "Archivos"
        '
        'pgr_Barra
        '
        Me.pgr_Barra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgr_Barra.Location = New System.Drawing.Point(9, 434)
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
        Me.lsv_Archivos.Size = New System.Drawing.Size(1029, 358)
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
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 467)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(1042, 55)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Enabled = False
        Me.btn_Enviar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Enviar.Location = New System.Drawing.Point(6, 13)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(894, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
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
        'frm_ArchivoDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 534)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_ArchivosDepositos)
        Me.Name = "frm_ArchivoDepositos"
        Me.Text = "Envío de Archivos"
        Me.gbx_ArchivosDepositos.ResumeLayout(False)
        Me.gbx_ArchivosDepositos.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_ArchivosDepositos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Destino As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Enviar As System.Windows.Forms.Button
    Friend WithEvents lsv_Archivos As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents pgr_Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Mensaje As System.Windows.Forms.Label
End Class
