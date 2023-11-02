<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Scan
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
        Me.dlg_Ruta = New System.Windows.Forms.FolderBrowserDialog
        Me.gbx_Imagen = New System.Windows.Forms.GroupBox
        Me.pct_Back = New System.Windows.Forms.PictureBox
        Me.pct_Front = New System.Windows.Forms.PictureBox
        Me.btn_Manual2 = New System.Windows.Forms.Button
        Me.btn_Manual1 = New System.Windows.Forms.Button
        Me.lbl_Zoom = New System.Windows.Forms.Label
        Me.btn_Ruta = New System.Windows.Forms.Button
        Me.txt_Ruta = New System.Windows.Forms.TextBox
        Me.lbl_Ruta = New System.Windows.Forms.Label
        Me.txt_MICR = New System.Windows.Forms.TextBox
        Me.btn_Inicio = New System.Windows.Forms.Button
        Me.btn_Atascos = New System.Windows.Forms.Button
        Me.btn_Finalizar = New System.Windows.Forms.Button
        Me.btn_Escanear = New System.Windows.Forms.Button
        Me.Gbx_Listas = New System.Windows.Forms.GroupBox
        Me.lsv_Log = New System.Windows.Forms.ListView
        Me.lsv_Datos = New System.Windows.Forms.ListView
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Imagen.SuspendLayout()
        CType(Me.pct_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Front, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Listas.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Imagen
        '
        Me.gbx_Imagen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Imagen.Controls.Add(Me.pct_Back)
        Me.gbx_Imagen.Controls.Add(Me.pct_Front)
        Me.gbx_Imagen.Controls.Add(Me.btn_Manual2)
        Me.gbx_Imagen.Controls.Add(Me.btn_Manual1)
        Me.gbx_Imagen.Controls.Add(Me.lbl_Zoom)
        Me.gbx_Imagen.Controls.Add(Me.btn_Ruta)
        Me.gbx_Imagen.Controls.Add(Me.txt_Ruta)
        Me.gbx_Imagen.Controls.Add(Me.lbl_Ruta)
        Me.gbx_Imagen.Controls.Add(Me.txt_MICR)
        Me.gbx_Imagen.Controls.Add(Me.btn_Inicio)
        Me.gbx_Imagen.Controls.Add(Me.btn_Atascos)
        Me.gbx_Imagen.Controls.Add(Me.btn_Finalizar)
        Me.gbx_Imagen.Controls.Add(Me.btn_Escanear)
        Me.gbx_Imagen.Location = New System.Drawing.Point(9, 6)
        Me.gbx_Imagen.Name = "gbx_Imagen"
        Me.gbx_Imagen.Size = New System.Drawing.Size(951, 319)
        Me.gbx_Imagen.TabIndex = 10
        Me.gbx_Imagen.TabStop = False
        '
        'pct_Back
        '
        Me.pct_Back.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Back.Location = New System.Drawing.Point(479, 103)
        Me.pct_Back.Name = "pct_Back"
        Me.pct_Back.Size = New System.Drawing.Size(460, 182)
        Me.pct_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Back.TabIndex = 24
        Me.pct_Back.TabStop = False
        '
        'pct_Front
        '
        Me.pct_Front.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Front.Location = New System.Drawing.Point(12, 103)
        Me.pct_Front.Name = "pct_Front"
        Me.pct_Front.Size = New System.Drawing.Size(460, 182)
        Me.pct_Front.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Front.TabIndex = 17
        Me.pct_Front.TabStop = False
        '
        'btn_Manual2
        '
        Me.btn_Manual2.Enabled = False
        Me.btn_Manual2.Location = New System.Drawing.Point(597, 291)
        Me.btn_Manual2.Name = "btn_Manual2"
        Me.btn_Manual2.Size = New System.Drawing.Size(112, 22)
        Me.btn_Manual2.TabIndex = 38
        Me.btn_Manual2.Text = "Cap&turar Manual"
        Me.btn_Manual2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Manual2.UseVisualStyleBackColor = True
        '
        'btn_Manual1
        '
        Me.btn_Manual1.Location = New System.Drawing.Point(478, 291)
        Me.btn_Manual1.Name = "btn_Manual1"
        Me.btn_Manual1.Size = New System.Drawing.Size(112, 22)
        Me.btn_Manual1.TabIndex = 37
        Me.btn_Manual1.Text = "&Permitir Manual"
        Me.btn_Manual1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Manual1.UseVisualStyleBackColor = True
        '
        'lbl_Zoom
        '
        Me.lbl_Zoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Zoom.AutoSize = True
        Me.lbl_Zoom.Location = New System.Drawing.Point(230, 87)
        Me.lbl_Zoom.Name = "lbl_Zoom"
        Me.lbl_Zoom.Size = New System.Drawing.Size(257, 13)
        Me.lbl_Zoom.TabIndex = 36
        Me.lbl_Zoom.Text = "Coloque el Mouse sobre la Imagen para hacer Zoom."
        '
        'btn_Ruta
        '
        Me.btn_Ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ruta.Location = New System.Drawing.Point(578, 11)
        Me.btn_Ruta.Name = "btn_Ruta"
        Me.btn_Ruta.Size = New System.Drawing.Size(32, 22)
        Me.btn_Ruta.TabIndex = 21
        Me.btn_Ruta.Text = "..."
        Me.btn_Ruta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Ruta.UseVisualStyleBackColor = True
        '
        'txt_Ruta
        '
        Me.txt_Ruta.Location = New System.Drawing.Point(148, 13)
        Me.txt_Ruta.Name = "txt_Ruta"
        Me.txt_Ruta.Size = New System.Drawing.Size(425, 20)
        Me.txt_Ruta.TabIndex = 20
        '
        'lbl_Ruta
        '
        Me.lbl_Ruta.AutoSize = True
        Me.lbl_Ruta.Location = New System.Drawing.Point(8, 18)
        Me.lbl_Ruta.Name = "lbl_Ruta"
        Me.lbl_Ruta.Size = New System.Drawing.Size(138, 13)
        Me.lbl_Ruta.TabIndex = 19
        Me.lbl_Ruta.Text = "Ubicación de las Imágenes:"
        '
        'txt_MICR
        '
        Me.txt_MICR.BackColor = System.Drawing.SystemColors.Window
        Me.txt_MICR.Enabled = False
        Me.txt_MICR.Location = New System.Drawing.Point(12, 291)
        Me.txt_MICR.Name = "txt_MICR"
        Me.txt_MICR.Size = New System.Drawing.Size(461, 20)
        Me.txt_MICR.TabIndex = 18
        '
        'btn_Inicio
        '
        Me.btn_Inicio.Enabled = False
        Me.btn_Inicio.Image = Global.Modulo_Proceso.My.Resources.Resources.Inicializar
        Me.btn_Inicio.Location = New System.Drawing.Point(12, 45)
        Me.btn_Inicio.Name = "btn_Inicio"
        Me.btn_Inicio.Size = New System.Drawing.Size(140, 30)
        Me.btn_Inicio.TabIndex = 16
        Me.btn_Inicio.Text = "&Inicializar"
        Me.btn_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Inicio.UseVisualStyleBackColor = True
        '
        'btn_Atascos
        '
        Me.btn_Atascos.Enabled = False
        Me.btn_Atascos.Image = Global.Modulo_Proceso.My.Resources.Resources.Engrane
        Me.btn_Atascos.Location = New System.Drawing.Point(304, 45)
        Me.btn_Atascos.Name = "btn_Atascos"
        Me.btn_Atascos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Atascos.TabIndex = 13
        Me.btn_Atascos.Text = "&Liberar Atascos"
        Me.btn_Atascos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Atascos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Atascos.UseVisualStyleBackColor = True
        '
        'btn_Finalizar
        '
        Me.btn_Finalizar.Enabled = False
        Me.btn_Finalizar.Image = Global.Modulo_Proceso.My.Resources.Resources.Finalizar
        Me.btn_Finalizar.Location = New System.Drawing.Point(450, 45)
        Me.btn_Finalizar.Name = "btn_Finalizar"
        Me.btn_Finalizar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Finalizar.TabIndex = 13
        Me.btn_Finalizar.Text = "&Finalizar"
        Me.btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Finalizar.UseVisualStyleBackColor = True
        '
        'btn_Escanear
        '
        Me.btn_Escanear.Enabled = False
        Me.btn_Escanear.Image = Global.Modulo_Proceso.My.Resources.Resources.Escanear
        Me.btn_Escanear.Location = New System.Drawing.Point(158, 45)
        Me.btn_Escanear.Name = "btn_Escanear"
        Me.btn_Escanear.Size = New System.Drawing.Size(140, 30)
        Me.btn_Escanear.TabIndex = 14
        Me.btn_Escanear.Text = "&Escanear"
        Me.btn_Escanear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Escanear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Escanear.UseVisualStyleBackColor = True
        '
        'Gbx_Listas
        '
        Me.Gbx_Listas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listas.Controls.Add(Me.lsv_Log)
        Me.Gbx_Listas.Controls.Add(Me.lsv_Datos)
        Me.Gbx_Listas.Location = New System.Drawing.Point(9, 331)
        Me.Gbx_Listas.Name = "Gbx_Listas"
        Me.Gbx_Listas.Size = New System.Drawing.Size(951, 167)
        Me.Gbx_Listas.TabIndex = 11
        Me.Gbx_Listas.TabStop = False
        '
        'lsv_Log
        '
        Me.lsv_Log.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Log.FullRowSelect = True
        Me.lsv_Log.HideSelection = False
        Me.lsv_Log.Location = New System.Drawing.Point(508, 19)
        Me.lsv_Log.Name = "lsv_Log"
        Me.lsv_Log.Size = New System.Drawing.Size(431, 142)
        Me.lsv_Log.TabIndex = 11
        Me.lsv_Log.UseCompatibleStateImageBehavior = False
        Me.lsv_Log.View = System.Windows.Forms.View.Details
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 19)
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Size = New System.Drawing.Size(496, 143)
        Me.lsv_Datos.TabIndex = 10
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Eliminar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 504)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(951, 50)
        Me.Gbx_Botones.TabIndex = 12
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_Proceso.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(158, 14)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 17
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(803, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 16
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 15
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'frm_Scan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 561)
        Me.Controls.Add(Me.gbx_Imagen)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Listas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(751, 500)
        Me.Name = "frm_Scan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digitalización de Cheques."
        Me.gbx_Imagen.ResumeLayout(False)
        Me.gbx_Imagen.PerformLayout()
        CType(Me.pct_Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Front, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Listas.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlg_Ruta As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents gbx_Imagen As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Listas As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Log As System.Windows.Forms.ListView
    Friend WithEvents lsv_Datos As System.Windows.Forms.ListView
    Friend WithEvents btn_Ruta As System.Windows.Forms.Button
    Friend WithEvents txt_Ruta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents txt_MICR As System.Windows.Forms.TextBox
    Friend WithEvents pct_Front As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Inicio As System.Windows.Forms.Button
    Friend WithEvents btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents btn_Escanear As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents pct_Back As System.Windows.Forms.PictureBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Atascos As System.Windows.Forms.Button
    Friend WithEvents lbl_Zoom As System.Windows.Forms.Label
    Friend WithEvents btn_Manual1 As System.Windows.Forms.Button
    Friend WithEvents btn_Manual2 As System.Windows.Forms.Button
End Class
