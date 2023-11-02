<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActasReporteD
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
        Dim ListViewColumnSorter3 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ActasReporteD))
        Me.gbx_Remisiones = New System.Windows.Forms.GroupBox
        Me.lbl_RemisionNum = New System.Windows.Forms.Label
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.lsv_Remisiones = New Modulo_Proceso.cp_Listview
        Me.gbx_Ficha = New System.Windows.Forms.GroupBox
        Me.lbl_TotalFichas = New System.Windows.Forms.Label
        Me.lsv_Fichas = New Modulo_Proceso.cp_Listview
        Me.lbl_Fichas = New System.Windows.Forms.Label
        Me.gbx_Desglose = New System.Windows.Forms.GroupBox
        Me.lbl_NumeroFicha = New System.Windows.Forms.Label
        Me.lbl_TotFicha = New System.Windows.Forms.Label
        Me.lsv_Desglose = New Modulo_Proceso.cp_Listview
        Me.lbl_Ficha = New System.Windows.Forms.Label
        Me.Lbl_Total = New System.Windows.Forms.Label
        Me.Gbx_TotFichas = New System.Windows.Forms.GroupBox
        Me.lbl_TotFichaGeneral = New System.Windows.Forms.Label
        Me.lsv_TotFichas = New Modulo_Proceso.cp_Listview
        Me.Lbl_ContieneReal = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Remisiones.SuspendLayout()
        Me.gbx_Ficha.SuspendLayout()
        Me.gbx_Desglose.SuspendLayout()
        Me.Gbx_TotFichas.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Remisiones
        '
        Me.gbx_Remisiones.Controls.Add(Me.lbl_RemisionNum)
        Me.gbx_Remisiones.Controls.Add(Me.lbl_Remision)
        Me.gbx_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_Remisiones.Location = New System.Drawing.Point(7, 13)
        Me.gbx_Remisiones.Name = "gbx_Remisiones"
        Me.gbx_Remisiones.Size = New System.Drawing.Size(1041, 300)
        Me.gbx_Remisiones.TabIndex = 0
        Me.gbx_Remisiones.TabStop = False
        Me.gbx_Remisiones.Text = "Remisiones"
        '
        'lbl_RemisionNum
        '
        Me.lbl_RemisionNum.AutoSize = True
        Me.lbl_RemisionNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RemisionNum.ForeColor = System.Drawing.Color.Red
        Me.lbl_RemisionNum.Location = New System.Drawing.Point(91, 16)
        Me.lbl_RemisionNum.Name = "lbl_RemisionNum"
        Me.lbl_RemisionNum.Size = New System.Drawing.Size(54, 20)
        Me.lbl_RemisionNum.TabIndex = 2
        Me.lbl_RemisionNum.Text = "$0.00"
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remision.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(79, 20)
        Me.lbl_Remision.TabIndex = 1
        Me.lbl_Remision.Text = "Remisión:"
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(6, 44)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter1
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 15
        Me.lsv_Remisiones.Row10 = 0
        Me.lsv_Remisiones.Row2 = 25
        Me.lsv_Remisiones.Row3 = 15
        Me.lsv_Remisiones.Row4 = 15
        Me.lsv_Remisiones.Row5 = 0
        Me.lsv_Remisiones.Row6 = 0
        Me.lsv_Remisiones.Row7 = 0
        Me.lsv_Remisiones.Row8 = 0
        Me.lsv_Remisiones.Row9 = 0
        Me.lsv_Remisiones.Size = New System.Drawing.Size(1028, 249)
        Me.lsv_Remisiones.TabIndex = 0
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'gbx_Ficha
        '
        Me.gbx_Ficha.Controls.Add(Me.lbl_TotalFichas)
        Me.gbx_Ficha.Controls.Add(Me.lsv_Fichas)
        Me.gbx_Ficha.Controls.Add(Me.lbl_Fichas)
        Me.gbx_Ficha.Location = New System.Drawing.Point(7, 319)
        Me.gbx_Ficha.Name = "gbx_Ficha"
        Me.gbx_Ficha.Size = New System.Drawing.Size(340, 300)
        Me.gbx_Ficha.TabIndex = 1
        Me.gbx_Ficha.TabStop = False
        Me.gbx_Ficha.Text = "Fichas"
        '
        'lbl_TotalFichas
        '
        Me.lbl_TotalFichas.AutoSize = True
        Me.lbl_TotalFichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalFichas.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotalFichas.Location = New System.Drawing.Point(127, 16)
        Me.lbl_TotalFichas.Name = "lbl_TotalFichas"
        Me.lbl_TotalFichas.Size = New System.Drawing.Size(54, 20)
        Me.lbl_TotalFichas.TabIndex = 2
        Me.lbl_TotalFichas.Text = "$0.00"
        '
        'lsv_Fichas
        '
        Me.lsv_Fichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Fichas.FullRowSelect = True
        Me.lsv_Fichas.HideSelection = False
        Me.lsv_Fichas.Location = New System.Drawing.Point(6, 44)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Fichas.Lvs = ListViewColumnSorter2
        Me.lsv_Fichas.MultiSelect = False
        Me.lsv_Fichas.Name = "lsv_Fichas"
        Me.lsv_Fichas.Row1 = 30
        Me.lsv_Fichas.Row10 = 0
        Me.lsv_Fichas.Row2 = 0
        Me.lsv_Fichas.Row3 = 0
        Me.lsv_Fichas.Row4 = 20
        Me.lsv_Fichas.Row5 = 20
        Me.lsv_Fichas.Row6 = 20
        Me.lsv_Fichas.Row7 = 0
        Me.lsv_Fichas.Row8 = 0
        Me.lsv_Fichas.Row9 = 0
        Me.lsv_Fichas.Size = New System.Drawing.Size(328, 249)
        Me.lsv_Fichas.TabIndex = 0
        Me.lsv_Fichas.UseCompatibleStateImageBehavior = False
        Me.lsv_Fichas.View = System.Windows.Forms.View.Details
        '
        'lbl_Fichas
        '
        Me.lbl_Fichas.AutoSize = True
        Me.lbl_Fichas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fichas.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Fichas.Name = "lbl_Fichas"
        Me.lbl_Fichas.Size = New System.Drawing.Size(115, 20)
        Me.lbl_Fichas.TabIndex = 1
        Me.lbl_Fichas.Text = "Dice Contener:"
        '
        'gbx_Desglose
        '
        Me.gbx_Desglose.Controls.Add(Me.lbl_NumeroFicha)
        Me.gbx_Desglose.Controls.Add(Me.lbl_TotFicha)
        Me.gbx_Desglose.Controls.Add(Me.lsv_Desglose)
        Me.gbx_Desglose.Controls.Add(Me.lbl_Ficha)
        Me.gbx_Desglose.Controls.Add(Me.Lbl_Total)
        Me.gbx_Desglose.Location = New System.Drawing.Point(362, 320)
        Me.gbx_Desglose.Name = "gbx_Desglose"
        Me.gbx_Desglose.Size = New System.Drawing.Size(340, 300)
        Me.gbx_Desglose.TabIndex = 2
        Me.gbx_Desglose.TabStop = False
        Me.gbx_Desglose.Text = "Desglose de Fichas"
        '
        'lbl_NumeroFicha
        '
        Me.lbl_NumeroFicha.AutoSize = True
        Me.lbl_NumeroFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumeroFicha.ForeColor = System.Drawing.Color.Red
        Me.lbl_NumeroFicha.Location = New System.Drawing.Point(60, 15)
        Me.lbl_NumeroFicha.Name = "lbl_NumeroFicha"
        Me.lbl_NumeroFicha.Size = New System.Drawing.Size(19, 20)
        Me.lbl_NumeroFicha.TabIndex = 2
        Me.lbl_NumeroFicha.Text = "0"
        '
        'lbl_TotFicha
        '
        Me.lbl_TotFicha.AutoSize = True
        Me.lbl_TotFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotFicha.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotFicha.Location = New System.Drawing.Point(189, 15)
        Me.lbl_TotFicha.Name = "lbl_TotFicha"
        Me.lbl_TotFicha.Size = New System.Drawing.Size(54, 20)
        Me.lbl_TotFicha.TabIndex = 2
        Me.lbl_TotFicha.Text = "$0.00"
        '
        'lsv_Desglose
        '
        Me.lsv_Desglose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Desglose.FullRowSelect = True
        Me.lsv_Desglose.HideSelection = False
        Me.lsv_Desglose.Location = New System.Drawing.Point(6, 44)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Desglose.Lvs = ListViewColumnSorter3
        Me.lsv_Desglose.MultiSelect = False
        Me.lsv_Desglose.Name = "lsv_Desglose"
        Me.lsv_Desglose.Row1 = 25
        Me.lsv_Desglose.Row10 = 0
        Me.lsv_Desglose.Row2 = 20
        Me.lsv_Desglose.Row3 = 20
        Me.lsv_Desglose.Row4 = 25
        Me.lsv_Desglose.Row5 = 0
        Me.lsv_Desglose.Row6 = 0
        Me.lsv_Desglose.Row7 = 0
        Me.lsv_Desglose.Row8 = 0
        Me.lsv_Desglose.Row9 = 0
        Me.lsv_Desglose.Size = New System.Drawing.Size(328, 249)
        Me.lsv_Desglose.TabIndex = 0
        Me.lsv_Desglose.UseCompatibleStateImageBehavior = False
        Me.lsv_Desglose.View = System.Windows.Forms.View.Details
        '
        'lbl_Ficha
        '
        Me.lbl_Ficha.AutoSize = True
        Me.lbl_Ficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ficha.Location = New System.Drawing.Point(6, 15)
        Me.lbl_Ficha.Name = "lbl_Ficha"
        Me.lbl_Ficha.Size = New System.Drawing.Size(52, 20)
        Me.lbl_Ficha.TabIndex = 1
        Me.lbl_Ficha.Text = "Ficha:"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(135, 15)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(48, 20)
        Me.Lbl_Total.TabIndex = 1
        Me.Lbl_Total.Text = "Total:"
        '
        'Gbx_TotFichas
        '
        Me.Gbx_TotFichas.Controls.Add(Me.lbl_TotFichaGeneral)
        Me.Gbx_TotFichas.Controls.Add(Me.lsv_TotFichas)
        Me.Gbx_TotFichas.Controls.Add(Me.Lbl_ContieneReal)
        Me.Gbx_TotFichas.Location = New System.Drawing.Point(708, 320)
        Me.Gbx_TotFichas.Name = "Gbx_TotFichas"
        Me.Gbx_TotFichas.Size = New System.Drawing.Size(340, 300)
        Me.Gbx_TotFichas.TabIndex = 3
        Me.Gbx_TotFichas.TabStop = False
        Me.Gbx_TotFichas.Text = "Total Fichas"
        '
        'lbl_TotFichaGeneral
        '
        Me.lbl_TotFichaGeneral.AutoSize = True
        Me.lbl_TotFichaGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotFichaGeneral.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotFichaGeneral.Location = New System.Drawing.Point(126, 16)
        Me.lbl_TotFichaGeneral.Name = "lbl_TotFichaGeneral"
        Me.lbl_TotFichaGeneral.Size = New System.Drawing.Size(54, 20)
        Me.lbl_TotFichaGeneral.TabIndex = 2
        Me.lbl_TotFichaGeneral.Text = "$0.00"
        '
        'lsv_TotFichas
        '
        Me.lsv_TotFichas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_TotFichas.FullRowSelect = True
        Me.lsv_TotFichas.HideSelection = False
        Me.lsv_TotFichas.Location = New System.Drawing.Point(10, 43)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_TotFichas.Lvs = ListViewColumnSorter4
        Me.lsv_TotFichas.MultiSelect = False
        Me.lsv_TotFichas.Name = "lsv_TotFichas"
        Me.lsv_TotFichas.Row1 = 30
        Me.lsv_TotFichas.Row10 = 0
        Me.lsv_TotFichas.Row2 = 30
        Me.lsv_TotFichas.Row3 = 30
        Me.lsv_TotFichas.Row4 = 0
        Me.lsv_TotFichas.Row5 = 0
        Me.lsv_TotFichas.Row6 = 0
        Me.lsv_TotFichas.Row7 = 0
        Me.lsv_TotFichas.Row8 = 0
        Me.lsv_TotFichas.Row9 = 0
        Me.lsv_TotFichas.Size = New System.Drawing.Size(324, 251)
        Me.lsv_TotFichas.TabIndex = 0
        Me.lsv_TotFichas.UseCompatibleStateImageBehavior = False
        Me.lsv_TotFichas.View = System.Windows.Forms.View.Details
        '
        'Lbl_ContieneReal
        '
        Me.Lbl_ContieneReal.AutoSize = True
        Me.Lbl_ContieneReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ContieneReal.Location = New System.Drawing.Point(6, 16)
        Me.Lbl_ContieneReal.Name = "Lbl_ContieneReal"
        Me.Lbl_ContieneReal.Size = New System.Drawing.Size(114, 20)
        Me.Lbl_ContieneReal.TabIndex = 1
        Me.Lbl_ContieneReal.Text = "Contiene Real:"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 626)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(1041, 50)
        Me.Gbx_Botones.TabIndex = 4
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(894, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_ActasReporteD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(1054, 681)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_TotFichas)
        Me.Controls.Add(Me.gbx_Desglose)
        Me.Controls.Add(Me.gbx_Ficha)
        Me.Controls.Add(Me.gbx_Remisiones)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1070, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1070, 720)
        Me.Name = "frm_ActasReporteD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles"
        Me.gbx_Remisiones.ResumeLayout(False)
        Me.gbx_Remisiones.PerformLayout()
        Me.gbx_Ficha.ResumeLayout(False)
        Me.gbx_Ficha.PerformLayout()
        Me.gbx_Desglose.ResumeLayout(False)
        Me.gbx_Desglose.PerformLayout()
        Me.Gbx_TotFichas.ResumeLayout(False)
        Me.Gbx_TotFichas.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Ficha As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Fichas As Modulo_Proceso.cp_Listview
    Friend WithEvents gbx_Desglose As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Desglose As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_RemisionNum As System.Windows.Forms.Label
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents lbl_Fichas As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalFichas As System.Windows.Forms.Label
    Friend WithEvents Gbx_TotFichas As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_TotFichas As Modulo_Proceso.cp_Listview
    Friend WithEvents lbl_TotFicha As System.Windows.Forms.Label
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_TotFichaGeneral As System.Windows.Forms.Label
    Friend WithEvents Lbl_ContieneReal As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_NumeroFicha As System.Windows.Forms.Label
    Friend WithEvents lbl_Ficha As System.Windows.Forms.Label
End Class
