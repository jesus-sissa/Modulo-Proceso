<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConfigurarPlantilla
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
        Me.gbx_Plantillas = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cmb_PlantillaResguardos = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_PlantillaDotaciones = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.cmb_PlantillaEfectivo = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.gbx_Plantillas.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Plantillas
        '
        Me.gbx_Plantillas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Plantillas.Controls.Add(Me.cmb_PlantillaResguardos)
        Me.gbx_Plantillas.Controls.Add(Me.cmb_PlantillaDotaciones)
        Me.gbx_Plantillas.Controls.Add(Me.cmb_PlantillaEfectivo)
        Me.gbx_Plantillas.Controls.Add(Me.Label3)
        Me.gbx_Plantillas.Controls.Add(Me.Label2)
        Me.gbx_Plantillas.Controls.Add(Me.Label1)
        Me.gbx_Plantillas.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Plantillas.Name = "gbx_Plantillas"
        Me.gbx_Plantillas.Size = New System.Drawing.Size(348, 146)
        Me.gbx_Plantillas.TabIndex = 0
        Me.gbx_Plantillas.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Plantilla para Dotaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Plantilla para Resguardos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plantilla para Envíos de Efectivo"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 154)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(348, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(202, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'cmb_PlantillaResguardos
        '
        Me.cmb_PlantillaResguardos.Clave = "Clave"
        Me.cmb_PlantillaResguardos.Control_Siguiente = Nothing
        Me.cmb_PlantillaResguardos.DisplayMember = "Nombre"
        Me.cmb_PlantillaResguardos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PlantillaResguardos.Empresa = False
        Me.cmb_PlantillaResguardos.Filtro = Nothing
        Me.cmb_PlantillaResguardos.FormattingEnabled = True
        Me.cmb_PlantillaResguardos.Location = New System.Drawing.Point(9, 112)
        Me.cmb_PlantillaResguardos.MaxDropDownItems = 20
        Me.cmb_PlantillaResguardos.Name = "cmb_PlantillaResguardos"
        Me.cmb_PlantillaResguardos.Pista = False
        Me.cmb_PlantillaResguardos.Size = New System.Drawing.Size(333, 21)
        Me.cmb_PlantillaResguardos.StoredProcedure = "Cat_ImpresionPlantilla_Get"
        Me.cmb_PlantillaResguardos.Sucursal = True
        Me.cmb_PlantillaResguardos.TabIndex = 7
        Me.cmb_PlantillaResguardos.Tipo = 0
        Me.cmb_PlantillaResguardos.ValueMember = "Clave"
        '
        'cmb_PlantillaDotaciones
        '
        Me.cmb_PlantillaDotaciones.Clave = "Clave"
        Me.cmb_PlantillaDotaciones.Control_Siguiente = Nothing
        Me.cmb_PlantillaDotaciones.DisplayMember = "Nombre"
        Me.cmb_PlantillaDotaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PlantillaDotaciones.Empresa = False
        Me.cmb_PlantillaDotaciones.Filtro = Nothing
        Me.cmb_PlantillaDotaciones.FormattingEnabled = True
        Me.cmb_PlantillaDotaciones.Location = New System.Drawing.Point(9, 72)
        Me.cmb_PlantillaDotaciones.MaxDropDownItems = 20
        Me.cmb_PlantillaDotaciones.Name = "cmb_PlantillaDotaciones"
        Me.cmb_PlantillaDotaciones.Pista = False
        Me.cmb_PlantillaDotaciones.Size = New System.Drawing.Size(333, 21)
        Me.cmb_PlantillaDotaciones.StoredProcedure = "Cat_ImpresionPlantilla_Get"
        Me.cmb_PlantillaDotaciones.Sucursal = True
        Me.cmb_PlantillaDotaciones.TabIndex = 6
        Me.cmb_PlantillaDotaciones.Tipo = 0
        Me.cmb_PlantillaDotaciones.ValueMember = "Clave"
        '
        'cmb_PlantillaEfectivo
        '
        Me.cmb_PlantillaEfectivo.Clave = "Clave"
        Me.cmb_PlantillaEfectivo.Control_Siguiente = Nothing
        Me.cmb_PlantillaEfectivo.DisplayMember = "Nombre"
        Me.cmb_PlantillaEfectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PlantillaEfectivo.Empresa = False
        Me.cmb_PlantillaEfectivo.Filtro = Nothing
        Me.cmb_PlantillaEfectivo.FormattingEnabled = True
        Me.cmb_PlantillaEfectivo.Location = New System.Drawing.Point(9, 32)
        Me.cmb_PlantillaEfectivo.MaxDropDownItems = 20
        Me.cmb_PlantillaEfectivo.Name = "cmb_PlantillaEfectivo"
        Me.cmb_PlantillaEfectivo.Pista = False
        Me.cmb_PlantillaEfectivo.Size = New System.Drawing.Size(333, 21)
        Me.cmb_PlantillaEfectivo.StoredProcedure = "Cat_ImpresionPlantilla_Get"
        Me.cmb_PlantillaEfectivo.Sucursal = True
        Me.cmb_PlantillaEfectivo.TabIndex = 5
        Me.cmb_PlantillaEfectivo.Tipo = 0
        Me.cmb_PlantillaEfectivo.ValueMember = "Clave"
        '
        'frm_ConfigurarPlantilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 211)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Plantillas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ConfigurarPlantilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Plantilla de Impresion"
        Me.gbx_Plantillas.ResumeLayout(False)
        Me.gbx_Plantillas.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Plantillas As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_PlantillaEfectivo As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_PlantillaResguardos As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_PlantillaDotaciones As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
End Class
