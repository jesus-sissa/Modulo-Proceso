<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ValidarArchivo
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
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Depositos = New System.Windows.Forms.GroupBox
        Me.lbl_Diferencia = New System.Windows.Forms.Label
        Me.lbl_DifDetalle = New System.Windows.Forms.Label
        Me.lbl_EfectivoDesglose = New System.Windows.Forms.Label
        Me.lbl_TotDesglose = New System.Windows.Forms.Label
        Me.lbl_EfectivoFichas = New System.Windows.Forms.Label
        Me.lbl_Fichas = New System.Windows.Forms.Label
        Me.lbl_ImporteCabezera = New System.Windows.Forms.Label
        Me.lbl_ImporteGeneral = New System.Windows.Forms.Label
        Me.lsv_Depositos = New Modulo_Proceso.cp_Listview
        Me.btn_Destino = New System.Windows.Forms.Button
        Me.dlg_Folder = New System.Windows.Forms.FolderBrowserDialog
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.lsv_Archivos = New Modulo_Proceso.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Depositos.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 477)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(946, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(800, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Depositos
        '
        Me.gbx_Depositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Depositos.Controls.Add(Me.lbl_Diferencia)
        Me.gbx_Depositos.Controls.Add(Me.lbl_DifDetalle)
        Me.gbx_Depositos.Controls.Add(Me.lbl_EfectivoDesglose)
        Me.gbx_Depositos.Controls.Add(Me.lbl_TotDesglose)
        Me.gbx_Depositos.Controls.Add(Me.lbl_EfectivoFichas)
        Me.gbx_Depositos.Controls.Add(Me.lbl_Fichas)
        Me.gbx_Depositos.Controls.Add(Me.lbl_ImporteCabezera)
        Me.gbx_Depositos.Controls.Add(Me.lbl_ImporteGeneral)
        Me.gbx_Depositos.Controls.Add(Me.lsv_Depositos)
        Me.gbx_Depositos.Location = New System.Drawing.Point(9, 315)
        Me.gbx_Depositos.Name = "gbx_Depositos"
        Me.gbx_Depositos.Size = New System.Drawing.Size(946, 156)
        Me.gbx_Depositos.TabIndex = 4
        Me.gbx_Depositos.TabStop = False
        Me.gbx_Depositos.Text = "Depositos"
        '
        'lbl_Diferencia
        '
        Me.lbl_Diferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Diferencia.AutoSize = True
        Me.lbl_Diferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Diferencia.ForeColor = System.Drawing.Color.Black
        Me.lbl_Diferencia.Location = New System.Drawing.Point(716, 132)
        Me.lbl_Diferencia.Name = "lbl_Diferencia"
        Me.lbl_Diferencia.Size = New System.Drawing.Size(89, 18)
        Me.lbl_Diferencia.TabIndex = 5
        Me.lbl_Diferencia.Text = "Diferencia:"
        '
        'lbl_DifDetalle
        '
        Me.lbl_DifDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_DifDetalle.AutoSize = True
        Me.lbl_DifDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DifDetalle.ForeColor = System.Drawing.Color.Red
        Me.lbl_DifDetalle.Location = New System.Drawing.Point(803, 133)
        Me.lbl_DifDetalle.Name = "lbl_DifDetalle"
        Me.lbl_DifDetalle.Size = New System.Drawing.Size(31, 18)
        Me.lbl_DifDetalle.TabIndex = 5
        Me.lbl_DifDetalle.Text = "0.0"
        '
        'lbl_EfectivoDesglose
        '
        Me.lbl_EfectivoDesglose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_EfectivoDesglose.AutoSize = True
        Me.lbl_EfectivoDesglose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EfectivoDesglose.ForeColor = System.Drawing.Color.Black
        Me.lbl_EfectivoDesglose.Location = New System.Drawing.Point(344, 133)
        Me.lbl_EfectivoDesglose.Name = "lbl_EfectivoDesglose"
        Me.lbl_EfectivoDesglose.Size = New System.Drawing.Size(193, 18)
        Me.lbl_EfectivoDesglose.TabIndex = 5
        Me.lbl_EfectivoDesglose.Text = "Total Efectivo Desglose:"
        '
        'lbl_TotDesglose
        '
        Me.lbl_TotDesglose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotDesglose.AutoSize = True
        Me.lbl_TotDesglose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotDesglose.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotDesglose.Location = New System.Drawing.Point(535, 134)
        Me.lbl_TotDesglose.Name = "lbl_TotDesglose"
        Me.lbl_TotDesglose.Size = New System.Drawing.Size(31, 18)
        Me.lbl_TotDesglose.TabIndex = 5
        Me.lbl_TotDesglose.Text = "0.0"
        '
        'lbl_EfectivoFichas
        '
        Me.lbl_EfectivoFichas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_EfectivoFichas.AutoSize = True
        Me.lbl_EfectivoFichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EfectivoFichas.ForeColor = System.Drawing.Color.Black
        Me.lbl_EfectivoFichas.Location = New System.Drawing.Point(11, 132)
        Me.lbl_EfectivoFichas.Name = "lbl_EfectivoFichas"
        Me.lbl_EfectivoFichas.Size = New System.Drawing.Size(172, 18)
        Me.lbl_EfectivoFichas.TabIndex = 5
        Me.lbl_EfectivoFichas.Text = "Total Efectivo Fichas:"
        '
        'lbl_Fichas
        '
        Me.lbl_Fichas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Fichas.AutoSize = True
        Me.lbl_Fichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fichas.ForeColor = System.Drawing.Color.Red
        Me.lbl_Fichas.Location = New System.Drawing.Point(181, 133)
        Me.lbl_Fichas.Name = "lbl_Fichas"
        Me.lbl_Fichas.Size = New System.Drawing.Size(31, 18)
        Me.lbl_Fichas.TabIndex = 5
        Me.lbl_Fichas.Text = "0.0"
        '
        'lbl_ImporteCabezera
        '
        Me.lbl_ImporteCabezera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ImporteCabezera.AutoSize = True
        Me.lbl_ImporteCabezera.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ImporteCabezera.ForeColor = System.Drawing.Color.Black
        Me.lbl_ImporteCabezera.Location = New System.Drawing.Point(35, 107)
        Me.lbl_ImporteCabezera.Name = "lbl_ImporteCabezera"
        Me.lbl_ImporteCabezera.Size = New System.Drawing.Size(147, 18)
        Me.lbl_ImporteCabezera.TabIndex = 5
        Me.lbl_ImporteCabezera.Text = "Importe Cabecera:"
        '
        'lbl_ImporteGeneral
        '
        Me.lbl_ImporteGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ImporteGeneral.AutoSize = True
        Me.lbl_ImporteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ImporteGeneral.ForeColor = System.Drawing.Color.Red
        Me.lbl_ImporteGeneral.Location = New System.Drawing.Point(181, 108)
        Me.lbl_ImporteGeneral.Name = "lbl_ImporteGeneral"
        Me.lbl_ImporteGeneral.Size = New System.Drawing.Size(31, 18)
        Me.lbl_ImporteGeneral.TabIndex = 5
        Me.lbl_ImporteGeneral.Text = "0.0"
        '
        'lsv_Depositos
        '
        Me.lsv_Depositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Depositos.FullRowSelect = True
        Me.lsv_Depositos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_Depositos.HideSelection = False
        Me.lsv_Depositos.Location = New System.Drawing.Point(6, 26)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Depositos.Lvs = ListViewColumnSorter1
        Me.lsv_Depositos.MultiSelect = False
        Me.lsv_Depositos.Name = "lsv_Depositos"
        Me.lsv_Depositos.Row1 = 8
        Me.lsv_Depositos.Row10 = 10
        Me.lsv_Depositos.Row2 = 9
        Me.lsv_Depositos.Row3 = 8
        Me.lsv_Depositos.Row4 = 12
        Me.lsv_Depositos.Row5 = 5
        Me.lsv_Depositos.Row6 = 9
        Me.lsv_Depositos.Row7 = 10
        Me.lsv_Depositos.Row8 = 15
        Me.lsv_Depositos.Row9 = 8
        Me.lsv_Depositos.Size = New System.Drawing.Size(934, 78)
        Me.lsv_Depositos.TabIndex = 3
        Me.lsv_Depositos.UseCompatibleStateImageBehavior = False
        Me.lsv_Depositos.View = System.Windows.Forms.View.Details
        '
        'btn_Destino
        '
        Me.btn_Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Destino.Image = Global.Modulo_Proceso.My.Resources.Resources.Buscar1
        Me.btn_Destino.Location = New System.Drawing.Point(11, 19)
        Me.btn_Destino.Name = "btn_Destino"
        Me.btn_Destino.Size = New System.Drawing.Size(140, 30)
        Me.btn_Destino.TabIndex = 5
        Me.btn_Destino.Text = "Cargar Archivos"
        Me.btn_Destino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Destino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Destino.UseVisualStyleBackColor = True
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.lsv_Archivos)
        Me.Gbx_Listado.Controls.Add(Me.btn_Destino)
        Me.Gbx_Listado.Location = New System.Drawing.Point(9, 8)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(946, 297)
        Me.Gbx_Listado.TabIndex = 5
        Me.Gbx_Listado.TabStop = False
        Me.Gbx_Listado.Text = "Archivos"
        '
        'lsv_Archivos
        '
        Me.lsv_Archivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Archivos.FullRowSelect = True
        Me.lsv_Archivos.HideSelection = False
        Me.lsv_Archivos.Location = New System.Drawing.Point(11, 55)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Archivos.Lvs = ListViewColumnSorter2
        Me.lsv_Archivos.MultiSelect = False
        Me.lsv_Archivos.Name = "lsv_Archivos"
        Me.lsv_Archivos.Row1 = 50
        Me.lsv_Archivos.Row10 = 0
        Me.lsv_Archivos.Row2 = 0
        Me.lsv_Archivos.Row3 = 0
        Me.lsv_Archivos.Row4 = 0
        Me.lsv_Archivos.Row5 = 0
        Me.lsv_Archivos.Row6 = 0
        Me.lsv_Archivos.Row7 = 0
        Me.lsv_Archivos.Row8 = 0
        Me.lsv_Archivos.Row9 = 0
        Me.lsv_Archivos.Size = New System.Drawing.Size(929, 236)
        Me.lsv_Archivos.TabIndex = 0
        Me.lsv_Archivos.UseCompatibleStateImageBehavior = False
        Me.lsv_Archivos.View = System.Windows.Forms.View.Details
        '
        'frm_ValidarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 531)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.gbx_Depositos)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(980, 570)
        Me.Name = "frm_ValidarArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar Archivo"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Depositos.ResumeLayout(False)
        Me.gbx_Depositos.PerformLayout()
        Me.Gbx_Listado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Depositos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Depositos As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents dlg_Folder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_Destino As System.Windows.Forms.Button
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Archivos As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_ImporteGeneral As System.Windows.Forms.Label
    Friend WithEvents lbl_ImporteCabezera As System.Windows.Forms.Label
    Friend WithEvents lbl_EfectivoFichas As System.Windows.Forms.Label
    Friend WithEvents lbl_Fichas As System.Windows.Forms.Label
    Friend WithEvents lbl_Diferencia As System.Windows.Forms.Label
    Friend WithEvents lbl_DifDetalle As System.Windows.Forms.Label
    Friend WithEvents lbl_EfectivoDesglose As System.Windows.Forms.Label
    Friend WithEvents lbl_TotDesglose As System.Windows.Forms.Label
End Class
