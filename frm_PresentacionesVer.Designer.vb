<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PresentacionesVer
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
        Me.lsv_Presentaciones = New Modulo_Proceso.cp_Listview
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.lsv_PresentacionesD = New Modulo_Proceso.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Ver = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Ver = New System.Windows.Forms.GroupBox
        Me.pct_Diapositiva = New System.Windows.Forms.PictureBox
        Me.gbx_Botones2 = New System.Windows.Forms.GroupBox
        Me.lbl_Contador = New System.Windows.Forms.Label
        Me.btn_Anterior = New System.Windows.Forms.Button
        Me.btn_Siguiente = New System.Windows.Forms.Button
        Me.btn_CerrarPresentacion = New System.Windows.Forms.Button
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Ver.SuspendLayout()
        CType(Me.pct_Diapositiva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Botones2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.lsv_Presentaciones)
        Me.gbx_Datos.Location = New System.Drawing.Point(9, 12)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(767, 277)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'lsv_Presentaciones
        '
        Me.lsv_Presentaciones.AllowColumnReorder = True
        Me.lsv_Presentaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Presentaciones.FullRowSelect = True
        Me.lsv_Presentaciones.HideSelection = False
        Me.lsv_Presentaciones.Location = New System.Drawing.Point(3, 10)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Presentaciones.Lvs = ListViewColumnSorter1
        Me.lsv_Presentaciones.MultiSelect = False
        Me.lsv_Presentaciones.Name = "lsv_Presentaciones"
        Me.lsv_Presentaciones.Row1 = 10
        Me.lsv_Presentaciones.Row10 = 0
        Me.lsv_Presentaciones.Row2 = 30
        Me.lsv_Presentaciones.Row3 = 40
        Me.lsv_Presentaciones.Row4 = 15
        Me.lsv_Presentaciones.Row5 = 0
        Me.lsv_Presentaciones.Row6 = 0
        Me.lsv_Presentaciones.Row7 = 0
        Me.lsv_Presentaciones.Row8 = 0
        Me.lsv_Presentaciones.Row9 = 0
        Me.lsv_Presentaciones.Size = New System.Drawing.Size(761, 264)
        Me.lsv_Presentaciones.TabIndex = 1
        Me.lsv_Presentaciones.UseCompatibleStateImageBehavior = False
        Me.lsv_Presentaciones.View = System.Windows.Forms.View.Details
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.lsv_PresentacionesD)
        Me.gbx_Detalle.Location = New System.Drawing.Point(9, 295)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(767, 211)
        Me.gbx_Detalle.TabIndex = 1
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Diapositivas"
        '
        'lsv_PresentacionesD
        '
        Me.lsv_PresentacionesD.AllowColumnReorder = True
        Me.lsv_PresentacionesD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_PresentacionesD.FullRowSelect = True
        Me.lsv_PresentacionesD.HideSelection = False
        Me.lsv_PresentacionesD.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_PresentacionesD.Lvs = ListViewColumnSorter2
        Me.lsv_PresentacionesD.MultiSelect = False
        Me.lsv_PresentacionesD.Name = "lsv_PresentacionesD"
        Me.lsv_PresentacionesD.Row1 = 15
        Me.lsv_PresentacionesD.Row10 = 0
        Me.lsv_PresentacionesD.Row2 = 30
        Me.lsv_PresentacionesD.Row3 = 30
        Me.lsv_PresentacionesD.Row4 = 0
        Me.lsv_PresentacionesD.Row5 = 0
        Me.lsv_PresentacionesD.Row6 = 0
        Me.lsv_PresentacionesD.Row7 = 0
        Me.lsv_PresentacionesD.Row8 = 0
        Me.lsv_PresentacionesD.Row9 = 0
        Me.lsv_PresentacionesD.Size = New System.Drawing.Size(761, 192)
        Me.lsv_PresentacionesD.TabIndex = 2
        Me.lsv_PresentacionesD.UseCompatibleStateImageBehavior = False
        Me.lsv_PresentacionesD.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Ver)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 512)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(767, 50)
        Me.gbx_Botones.TabIndex = 6
        Me.gbx_Botones.TabStop = False
        '
        'btn_Ver
        '
        Me.btn_Ver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Ver.Enabled = False
        Me.btn_Ver.Image = Global.Modulo_Proceso.My.Resources.Resources.VerPresentacion
        Me.btn_Ver.Location = New System.Drawing.Point(6, 14)
        Me.btn_Ver.Name = "btn_Ver"
        Me.btn_Ver.Size = New System.Drawing.Size(140, 30)
        Me.btn_Ver.TabIndex = 2
        Me.btn_Ver.Text = "&Ver Presentación"
        Me.btn_Ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Ver.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Ver
        '
        Me.gbx_Ver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Ver.Controls.Add(Me.pct_Diapositiva)
        Me.gbx_Ver.Controls.Add(Me.gbx_Botones2)
        Me.gbx_Ver.Location = New System.Drawing.Point(9, 3)
        Me.gbx_Ver.Name = "gbx_Ver"
        Me.gbx_Ver.Size = New System.Drawing.Size(767, 156)
        Me.gbx_Ver.TabIndex = 7
        Me.gbx_Ver.TabStop = False
        Me.gbx_Ver.Text = "Ver Presentación"
        Me.gbx_Ver.Visible = False
        '
        'pct_Diapositiva
        '
        Me.pct_Diapositiva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_Diapositiva.BackColor = System.Drawing.Color.White
        Me.pct_Diapositiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Diapositiva.Location = New System.Drawing.Point(6, 19)
        Me.pct_Diapositiva.Name = "pct_Diapositiva"
        Me.pct_Diapositiva.Size = New System.Drawing.Size(755, 75)
        Me.pct_Diapositiva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Diapositiva.TabIndex = 128
        Me.pct_Diapositiva.TabStop = False
        '
        'gbx_Botones2
        '
        Me.gbx_Botones2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones2.Controls.Add(Me.lbl_Contador)
        Me.gbx_Botones2.Controls.Add(Me.btn_Anterior)
        Me.gbx_Botones2.Controls.Add(Me.btn_Siguiente)
        Me.gbx_Botones2.Controls.Add(Me.btn_CerrarPresentacion)
        Me.gbx_Botones2.Location = New System.Drawing.Point(6, 100)
        Me.gbx_Botones2.Name = "gbx_Botones2"
        Me.gbx_Botones2.Size = New System.Drawing.Size(755, 50)
        Me.gbx_Botones2.TabIndex = 7
        Me.gbx_Botones2.TabStop = False
        '
        'lbl_Contador
        '
        Me.lbl_Contador.AutoSize = True
        Me.lbl_Contador.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contador.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Contador.Location = New System.Drawing.Point(315, 16)
        Me.lbl_Contador.Name = "lbl_Contador"
        Me.lbl_Contador.Size = New System.Drawing.Size(104, 26)
        Me.lbl_Contador.TabIndex = 4
        Me.lbl_Contador.Text = "00 de 00"
        '
        'btn_Anterior
        '
        Me.btn_Anterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Anterior.Enabled = False
        Me.btn_Anterior.Image = Global.Modulo_Proceso.My.Resources.Resources.previous
        Me.btn_Anterior.Location = New System.Drawing.Point(10, 14)
        Me.btn_Anterior.Name = "btn_Anterior"
        Me.btn_Anterior.Size = New System.Drawing.Size(140, 30)
        Me.btn_Anterior.TabIndex = 3
        Me.btn_Anterior.Text = "&Anterior"
        Me.btn_Anterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Anterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Anterior.UseVisualStyleBackColor = True
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Siguiente.Image = Global.Modulo_Proceso.My.Resources.Resources._next
        Me.btn_Siguiente.Location = New System.Drawing.Point(156, 14)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(140, 30)
        Me.btn_Siguiente.TabIndex = 2
        Me.btn_Siguiente.Text = "&Siguiente"
        Me.btn_Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Siguiente.UseVisualStyleBackColor = True
        '
        'btn_CerrarPresentacion
        '
        Me.btn_CerrarPresentacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CerrarPresentacion.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_CerrarPresentacion.Location = New System.Drawing.Point(609, 14)
        Me.btn_CerrarPresentacion.Name = "btn_CerrarPresentacion"
        Me.btn_CerrarPresentacion.Size = New System.Drawing.Size(140, 30)
        Me.btn_CerrarPresentacion.TabIndex = 1
        Me.btn_CerrarPresentacion.Text = "&Cerrar"
        Me.btn_CerrarPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CerrarPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CerrarPresentacion.UseVisualStyleBackColor = True
        '
        'frm_PresentacionesVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 574)
        Me.Controls.Add(Me.gbx_Ver)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Datos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_PresentacionesVer"
        Me.Text = "Presentaciones Disponibles"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Ver.ResumeLayout(False)
        CType(Me.pct_Diapositiva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Botones2.ResumeLayout(False)
        Me.gbx_Botones2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Presentaciones As Modulo_Proceso.cp_Listview
    Friend WithEvents lsv_PresentacionesD As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Ver As System.Windows.Forms.Button
    Friend WithEvents gbx_Ver As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Anterior As System.Windows.Forms.Button
    Friend WithEvents btn_Siguiente As System.Windows.Forms.Button
    Friend WithEvents btn_CerrarPresentacion As System.Windows.Forms.Button
    Friend WithEvents pct_Diapositiva As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Contador As System.Windows.Forms.Label
End Class
