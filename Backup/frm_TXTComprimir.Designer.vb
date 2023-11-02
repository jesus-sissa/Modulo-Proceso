<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TXTComprimir
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
        Me.btn_Comprimir = New System.Windows.Forms.Button
        Me.btn_Descomprimir = New System.Windows.Forms.Button
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.rb_Carpeta = New System.Windows.Forms.RadioButton
        Me.rb_Archivos = New System.Windows.Forms.RadioButton
        Me.btn_Seleccionar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Lista = New System.Windows.Forms.GroupBox
        Me.tbx_Archivo = New Modulo_Proceso.cp_Textbox
        Me.Lbl_Zip = New System.Windows.Forms.Label
        Me.Lbl_ArchDest = New System.Windows.Forms.Label
        Me.Lbl_Ubicacion = New System.Windows.Forms.Label
        Me.btn_Destino = New System.Windows.Forms.Button
        Me.tbx_Destino = New System.Windows.Forms.TextBox
        Me.lsv_Datos = New Modulo_Proceso.cp_Listview
        Me.dlg_Folder = New System.Windows.Forms.FolderBrowserDialog
        Me.Gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.Gbx_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Comprimir
        '
        Me.btn_Comprimir.Enabled = False
        Me.btn_Comprimir.Image = Global.Modulo_Proceso.My.Resources.Resources._1rightarrow
        Me.btn_Comprimir.Location = New System.Drawing.Point(5, 14)
        Me.btn_Comprimir.Name = "btn_Comprimir"
        Me.btn_Comprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Comprimir.TabIndex = 0
        Me.btn_Comprimir.Text = "&Comprimir"
        Me.btn_Comprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Comprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Comprimir.UseVisualStyleBackColor = True
        '
        'btn_Descomprimir
        '
        Me.btn_Descomprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_Descomprimir.Enabled = False
        Me.btn_Descomprimir.Image = Global.Modulo_Proceso.My.Resources.Resources.Cancelar
        Me.btn_Descomprimir.Location = New System.Drawing.Point(303, 14)
        Me.btn_Descomprimir.Name = "btn_Descomprimir"
        Me.btn_Descomprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Descomprimir.TabIndex = 0
        Me.btn_Descomprimir.Text = "&Descomprimir"
        Me.btn_Descomprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Descomprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Descomprimir.UseVisualStyleBackColor = True
        Me.btn_Descomprimir.Visible = False
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.rb_Carpeta)
        Me.Gbx_Filtro.Controls.Add(Me.rb_Archivos)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(9, 3)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(767, 48)
        Me.Gbx_Filtro.TabIndex = 1
        Me.Gbx_Filtro.TabStop = False
        '
        'rb_Carpeta
        '
        Me.rb_Carpeta.AutoSize = True
        Me.rb_Carpeta.Enabled = False
        Me.rb_Carpeta.Location = New System.Drawing.Point(209, 19)
        Me.rb_Carpeta.Name = "rb_Carpeta"
        Me.rb_Carpeta.Size = New System.Drawing.Size(110, 17)
        Me.rb_Carpeta.TabIndex = 1
        Me.rb_Carpeta.Text = "Comprimir Carpeta"
        Me.rb_Carpeta.UseVisualStyleBackColor = True
        '
        'rb_Archivos
        '
        Me.rb_Archivos.AutoSize = True
        Me.rb_Archivos.Checked = True
        Me.rb_Archivos.Location = New System.Drawing.Point(31, 19)
        Me.rb_Archivos.Name = "rb_Archivos"
        Me.rb_Archivos.Size = New System.Drawing.Size(114, 17)
        Me.rb_Archivos.TabIndex = 0
        Me.rb_Archivos.TabStop = True
        Me.rb_Archivos.Text = "Comprimir Archivos"
        Me.rb_Archivos.UseVisualStyleBackColor = True
        '
        'btn_Seleccionar
        '
        Me.btn_Seleccionar.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar
        Me.btn_Seleccionar.Location = New System.Drawing.Point(6, 15)
        Me.btn_Seleccionar.Name = "btn_Seleccionar"
        Me.btn_Seleccionar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Seleccionar.TabIndex = 2
        Me.btn_Seleccionar.Text = "&Seleccionar..."
        Me.btn_Seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Seleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Comprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Descomprimir)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(620, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Lista
        '
        Me.Gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Lista.Controls.Add(Me.tbx_Archivo)
        Me.Gbx_Lista.Controls.Add(Me.Lbl_Zip)
        Me.Gbx_Lista.Controls.Add(Me.Lbl_ArchDest)
        Me.Gbx_Lista.Controls.Add(Me.Lbl_Ubicacion)
        Me.Gbx_Lista.Controls.Add(Me.btn_Destino)
        Me.Gbx_Lista.Controls.Add(Me.tbx_Destino)
        Me.Gbx_Lista.Controls.Add(Me.lsv_Datos)
        Me.Gbx_Lista.Controls.Add(Me.btn_Seleccionar)
        Me.Gbx_Lista.Location = New System.Drawing.Point(10, 57)
        Me.Gbx_Lista.Name = "Gbx_Lista"
        Me.Gbx_Lista.Size = New System.Drawing.Size(765, 443)
        Me.Gbx_Lista.TabIndex = 4
        Me.Gbx_Lista.TabStop = False
        '
        'tbx_Archivo
        '
        Me.tbx_Archivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Archivo.Control_Siguiente = Nothing
        Me.tbx_Archivo.Filtrado = True
        Me.tbx_Archivo.Location = New System.Drawing.Point(144, 384)
        Me.tbx_Archivo.MaxLength = 20
        Me.tbx_Archivo.Name = "tbx_Archivo"
        Me.tbx_Archivo.Size = New System.Drawing.Size(133, 20)
        Me.tbx_Archivo.TabIndex = 10
        Me.tbx_Archivo.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Lbl_Zip
        '
        Me.Lbl_Zip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Zip.AutoSize = True
        Me.Lbl_Zip.Location = New System.Drawing.Point(279, 387)
        Me.Lbl_Zip.Name = "Lbl_Zip"
        Me.Lbl_Zip.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_Zip.TabIndex = 9
        Me.Lbl_Zip.Text = ".ZIP"
        '
        'Lbl_ArchDest
        '
        Me.Lbl_ArchDest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ArchDest.AutoSize = True
        Me.Lbl_ArchDest.Location = New System.Drawing.Point(56, 387)
        Me.Lbl_ArchDest.Name = "Lbl_ArchDest"
        Me.Lbl_ArchDest.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_ArchDest.TabIndex = 8
        Me.Lbl_ArchDest.Text = "Archivo Destino"
        '
        'Lbl_Ubicacion
        '
        Me.Lbl_Ubicacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Ubicacion.AutoSize = True
        Me.Lbl_Ubicacion.Location = New System.Drawing.Point(12, 413)
        Me.Lbl_Ubicacion.Name = "Lbl_Ubicacion"
        Me.Lbl_Ubicacion.Size = New System.Drawing.Size(129, 13)
        Me.Lbl_Ubicacion.TabIndex = 6
        Me.Lbl_Ubicacion.Text = "Ubicación del Archivo Zip"
        '
        'btn_Destino
        '
        Me.btn_Destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Destino.Location = New System.Drawing.Point(547, 409)
        Me.btn_Destino.Name = "btn_Destino"
        Me.btn_Destino.Size = New System.Drawing.Size(32, 21)
        Me.btn_Destino.TabIndex = 5
        Me.btn_Destino.Text = "..."
        Me.btn_Destino.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Destino.UseVisualStyleBackColor = True
        '
        'tbx_Destino
        '
        Me.tbx_Destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Destino.Enabled = False
        Me.tbx_Destino.Location = New System.Drawing.Point(144, 410)
        Me.tbx_Destino.Name = "tbx_Destino"
        Me.tbx_Destino.Size = New System.Drawing.Size(394, 20)
        Me.tbx_Destino.TabIndex = 4
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 55)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 95
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 0
        Me.lsv_Datos.Row3 = 0
        Me.lsv_Datos.Row4 = 0
        Me.lsv_Datos.Row5 = 0
        Me.lsv_Datos.Row6 = 0
        Me.lsv_Datos.Row7 = 0
        Me.lsv_Datos.Row8 = 0
        Me.lsv_Datos.Row9 = 0
        Me.lsv_Datos.Size = New System.Drawing.Size(753, 323)
        Me.lsv_Datos.TabIndex = 3
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'frm_TXTComprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 568)
        Me.Controls.Add(Me.Gbx_Lista)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_TXTComprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprimir Archivos"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.Gbx_Lista.ResumeLayout(False)
        Me.Gbx_Lista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Comprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Descomprimir As System.Windows.Forms.Button
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Carpeta As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Archivos As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents dlg_Folder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_Destino As System.Windows.Forms.Button
    Friend WithEvents tbx_Destino As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ubicacion As System.Windows.Forms.Label
    Friend WithEvents tbx_Archivo As Modulo_Proceso.cp_Textbox
    Friend WithEvents Lbl_Zip As System.Windows.Forms.Label
    Friend WithEvents Lbl_ArchDest As System.Windows.Forms.Label
End Class
