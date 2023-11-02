<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpleadosAutoriza
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
        Me.grb_autoriza = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.lsv_Empleados = New Modulo_Proceso.cp_Listview
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.cmb_Empleados = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.btn_baja = New System.Windows.Forms.Button
        Me.grb_autoriza.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_autoriza
        '
        Me.grb_autoriza.Controls.Add(Me.Lbl_Registros)
        Me.grb_autoriza.Controls.Add(Me.lbl_Empleado)
        Me.grb_autoriza.Controls.Add(Me.lsv_Empleados)
        Me.grb_autoriza.Controls.Add(Me.btn_Agregar)
        Me.grb_autoriza.Controls.Add(Me.cmb_Empleados)
        Me.grb_autoriza.Location = New System.Drawing.Point(8, 12)
        Me.grb_autoriza.Name = "grb_autoriza"
        Me.grb_autoriza.Size = New System.Drawing.Size(881, 377)
        Me.grb_autoriza.TabIndex = 0
        Me.grb_autoriza.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(686, 25)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(186, 23)
        Me.Lbl_Registros.TabIndex = 52
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(6, 22)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Empleado.TabIndex = 0
        Me.lbl_Empleado.Text = "Empleado"
        '
        'lsv_Empleados
        '
        Me.lsv_Empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Empleados.FullRowSelect = True
        Me.lsv_Empleados.HideSelection = False
        Me.lsv_Empleados.Location = New System.Drawing.Point(6, 49)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Empleados.Lvs = ListViewColumnSorter1
        Me.lsv_Empleados.MultiSelect = False
        Me.lsv_Empleados.Name = "lsv_Empleados"
        Me.lsv_Empleados.Row1 = 15
        Me.lsv_Empleados.Row10 = 0
        Me.lsv_Empleados.Row2 = 30
        Me.lsv_Empleados.Row3 = 20
        Me.lsv_Empleados.Row4 = 25
        Me.lsv_Empleados.Row5 = 8
        Me.lsv_Empleados.Row6 = 0
        Me.lsv_Empleados.Row7 = 0
        Me.lsv_Empleados.Row8 = 0
        Me.lsv_Empleados.Row9 = 0
        Me.lsv_Empleados.Size = New System.Drawing.Size(869, 322)
        Me.lsv_Empleados.TabIndex = 4
        Me.lsv_Empleados.UseCompatibleStateImageBehavior = False
        Me.lsv_Empleados.View = System.Windows.Forms.View.Details
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Proceso.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(472, 13)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 3
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'cmb_Empleados
        '
        Me.cmb_Empleados.Clave = "Clave_Empleado"
        Me.cmb_Empleados.Control_Siguiente = Nothing
        Me.cmb_Empleados.DisplayMember = "Nombre"
        Me.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleados.Empresa = False
        Me.cmb_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Empleados.FormattingEnabled = True
        Me.cmb_Empleados.Location = New System.Drawing.Point(66, 17)
        Me.cmb_Empleados.MaxDropDownItems = 20
        Me.cmb_Empleados.Name = "cmb_Empleados"
        Me.cmb_Empleados.Pista = False
        Me.cmb_Empleados.Size = New System.Drawing.Size(400, 23)
        Me.cmb_Empleados.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Empleados.Sucursal = True
        Me.cmb_Empleados.TabIndex = 2
        Me.cmb_Empleados.Tipo = 0
        Me.cmb_Empleados.ValueMember = "Id_Empleado"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_baja)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 395)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(881, 51)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(726, 15)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_cerrar.TabIndex = 1
        Me.btn_cerrar.Text = "&Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_baja
        '
        Me.btn_baja.Enabled = False
        Me.btn_baja.Image = Global.Modulo_Proceso.My.Resources.Resources.BajaReing
        Me.btn_baja.Location = New System.Drawing.Point(6, 15)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_baja.TabIndex = 0
        Me.btn_baja.Text = "&Baja/Reingreso"
        Me.btn_baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'frm_EmpleadosAutoriza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 451)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.grb_autoriza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 480)
        Me.Name = "frm_EmpleadosAutoriza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados que autorizan Diferencias"
        Me.grb_autoriza.ResumeLayout(False)
        Me.grb_autoriza.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_autoriza As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Empleados As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_Empleados As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_baja As System.Windows.Forms.Button
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
