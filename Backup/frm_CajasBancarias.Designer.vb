<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CajasBancarias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CajasBancarias))
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.Lbl_CajasB = New System.Windows.Forms.Label
        Me.Cmb_CajasBancarias = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.Gbx_Datos1 = New System.Windows.Forms.GroupBox
        Me.Tbx_CR = New Modulo_Proceso.cp_Textbox
        Me.Tbx_TipoArchivo = New Modulo_Proceso.cp_Textbox
        Me.Tbx_ClaveProvedorA = New Modulo_Proceso.cp_Textbox
        Me.Tbx_NumPlaza = New Modulo_Proceso.cp_Textbox
        Me.Lbl_ClavePA = New System.Windows.Forms.Label
        Me.Lbl_TipoA = New System.Windows.Forms.Label
        Me.Lbl_Cr = New System.Windows.Forms.Label
        Me.Lbl_NumeroP = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Lbl_DigitoS = New System.Windows.Forms.Label
        Me.Lbl_TipoRD = New System.Windows.Forms.Label
        Me.Lbl_LongitudRD = New System.Windows.Forms.Label
        Me.Gbx_Datos2 = New System.Windows.Forms.GroupBox
        Me.Cmb_DigSeg = New Modulo_Proceso.cp_cmb_Manual
        Me.Cmb_RefDepo = New Modulo_Proceso.cp_cmb_Manual
        Me.Tbx_LongRefepo = New Modulo_Proceso.cp_Textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Datos1.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Datos2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_CajasB)
        Me.Gbx_Filtro.Controls.Add(Me.Cmb_CajasBancarias)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(5, 5)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(665, 49)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'Lbl_CajasB
        '
        Me.Lbl_CajasB.AutoSize = True
        Me.Lbl_CajasB.Location = New System.Drawing.Point(16, 21)
        Me.Lbl_CajasB.Name = "Lbl_CajasB"
        Me.Lbl_CajasB.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_CajasB.TabIndex = 0
        Me.Lbl_CajasB.Text = "Caja Bancaria:"
        '
        'Cmb_CajasBancarias
        '
        Me.Cmb_CajasBancarias.Clave = "Clave_Cliente"
        Me.Cmb_CajasBancarias.Control_Siguiente = Nothing
        Me.Cmb_CajasBancarias.DisplayMember = "Nombre Comercial"
        Me.Cmb_CajasBancarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_CajasBancarias.Empresa = False
        Me.Cmb_CajasBancarias.Filtro = Nothing
        Me.Cmb_CajasBancarias.FormattingEnabled = True
        Me.Cmb_CajasBancarias.Location = New System.Drawing.Point(98, 18)
        Me.Cmb_CajasBancarias.MaxDropDownItems = 20
        Me.Cmb_CajasBancarias.Name = "Cmb_CajasBancarias"
        Me.Cmb_CajasBancarias.Pista = False
        Me.Cmb_CajasBancarias.Size = New System.Drawing.Size(400, 21)
        Me.Cmb_CajasBancarias.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.Cmb_CajasBancarias.Sucursal = True
        Me.Cmb_CajasBancarias.TabIndex = 2
        Me.Cmb_CajasBancarias.Tipo = 0
        Me.Cmb_CajasBancarias.ValueMember = "Id_CajaBancaria"
        '
        'Gbx_Datos1
        '
        Me.Gbx_Datos1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos1.Controls.Add(Me.Tbx_CR)
        Me.Gbx_Datos1.Controls.Add(Me.Tbx_TipoArchivo)
        Me.Gbx_Datos1.Controls.Add(Me.Tbx_ClaveProvedorA)
        Me.Gbx_Datos1.Controls.Add(Me.Tbx_NumPlaza)
        Me.Gbx_Datos1.Controls.Add(Me.Lbl_ClavePA)
        Me.Gbx_Datos1.Controls.Add(Me.Lbl_TipoA)
        Me.Gbx_Datos1.Controls.Add(Me.Lbl_Cr)
        Me.Gbx_Datos1.Controls.Add(Me.Lbl_NumeroP)
        Me.Gbx_Datos1.Enabled = False
        Me.Gbx_Datos1.Location = New System.Drawing.Point(5, 58)
        Me.Gbx_Datos1.Name = "Gbx_Datos1"
        Me.Gbx_Datos1.Size = New System.Drawing.Size(303, 135)
        Me.Gbx_Datos1.TabIndex = 1
        Me.Gbx_Datos1.TabStop = False
        '
        'Tbx_CR
        '
        Me.Tbx_CR.Control_Siguiente = Nothing
        Me.Tbx_CR.Filtrado = False
        Me.Tbx_CR.Location = New System.Drawing.Point(134, 43)
        Me.Tbx_CR.MaxLength = 6
        Me.Tbx_CR.Name = "Tbx_CR"
        Me.Tbx_CR.Size = New System.Drawing.Size(100, 20)
        Me.Tbx_CR.TabIndex = 3
        Me.Tbx_CR.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'Tbx_TipoArchivo
        '
        Me.Tbx_TipoArchivo.Control_Siguiente = Nothing
        Me.Tbx_TipoArchivo.Filtrado = False
        Me.Tbx_TipoArchivo.Location = New System.Drawing.Point(134, 69)
        Me.Tbx_TipoArchivo.MaxLength = 10
        Me.Tbx_TipoArchivo.Name = "Tbx_TipoArchivo"
        Me.Tbx_TipoArchivo.Size = New System.Drawing.Size(100, 20)
        Me.Tbx_TipoArchivo.TabIndex = 5
        Me.Tbx_TipoArchivo.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'Tbx_ClaveProvedorA
        '
        Me.Tbx_ClaveProvedorA.Control_Siguiente = Nothing
        Me.Tbx_ClaveProvedorA.Filtrado = False
        Me.Tbx_ClaveProvedorA.Location = New System.Drawing.Point(134, 95)
        Me.Tbx_ClaveProvedorA.MaxLength = 10
        Me.Tbx_ClaveProvedorA.Name = "Tbx_ClaveProvedorA"
        Me.Tbx_ClaveProvedorA.Size = New System.Drawing.Size(100, 20)
        Me.Tbx_ClaveProvedorA.TabIndex = 7
        Me.Tbx_ClaveProvedorA.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'Tbx_NumPlaza
        '
        Me.Tbx_NumPlaza.Control_Siguiente = Nothing
        Me.Tbx_NumPlaza.Filtrado = False
        Me.Tbx_NumPlaza.Location = New System.Drawing.Point(134, 17)
        Me.Tbx_NumPlaza.MaxLength = 10
        Me.Tbx_NumPlaza.Name = "Tbx_NumPlaza"
        Me.Tbx_NumPlaza.Size = New System.Drawing.Size(100, 20)
        Me.Tbx_NumPlaza.TabIndex = 1
        Me.Tbx_NumPlaza.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'Lbl_ClavePA
        '
        Me.Lbl_ClavePA.AutoSize = True
        Me.Lbl_ClavePA.Location = New System.Drawing.Point(6, 98)
        Me.Lbl_ClavePA.Name = "Lbl_ClavePA"
        Me.Lbl_ClavePA.Size = New System.Drawing.Size(122, 13)
        Me.Lbl_ClavePA.TabIndex = 6
        Me.Lbl_ClavePA.Text = "Clave Provedor Archivo:"
        '
        'Lbl_TipoA
        '
        Me.Lbl_TipoA.AutoSize = True
        Me.Lbl_TipoA.Location = New System.Drawing.Point(58, 72)
        Me.Lbl_TipoA.Name = "Lbl_TipoA"
        Me.Lbl_TipoA.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_TipoA.TabIndex = 4
        Me.Lbl_TipoA.Text = "Tipo Archivo:"
        '
        'Lbl_Cr
        '
        Me.Lbl_Cr.AutoSize = True
        Me.Lbl_Cr.Location = New System.Drawing.Point(103, 46)
        Me.Lbl_Cr.Name = "Lbl_Cr"
        Me.Lbl_Cr.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_Cr.TabIndex = 2
        Me.Lbl_Cr.Text = "CR:"
        '
        'Lbl_NumeroP
        '
        Me.Lbl_NumeroP.AutoSize = True
        Me.Lbl_NumeroP.Location = New System.Drawing.Point(52, 20)
        Me.Lbl_NumeroP.Name = "Lbl_NumeroP"
        Me.Lbl_NumeroP.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_NumeroP.TabIndex = 0
        Me.Lbl_NumeroP.Text = "Numero Plaza:"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 239)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(665, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Guardar.Enabled = False
        Me.Btn_Guardar.Image = Global.Modulo_Proceso.My.Resources.Resources.Guardar
        Me.Btn_Guardar.Location = New System.Drawing.Point(9, 11)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(519, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Lbl_DigitoS
        '
        Me.Lbl_DigitoS.AutoSize = True
        Me.Lbl_DigitoS.Location = New System.Drawing.Point(87, 28)
        Me.Lbl_DigitoS.Name = "Lbl_DigitoS"
        Me.Lbl_DigitoS.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_DigitoS.TabIndex = 0
        Me.Lbl_DigitoS.Text = "Digito Seguro:"
        '
        'Lbl_TipoRD
        '
        Me.Lbl_TipoRD.AutoSize = True
        Me.Lbl_TipoRD.Location = New System.Drawing.Point(46, 56)
        Me.Lbl_TipoRD.Name = "Lbl_TipoRD"
        Me.Lbl_TipoRD.Size = New System.Drawing.Size(115, 13)
        Me.Lbl_TipoRD.TabIndex = 2
        Me.Lbl_TipoRD.Text = "Tipo Referencia Depo:"
        '
        'Lbl_LongitudRD
        '
        Me.Lbl_LongitudRD.AutoSize = True
        Me.Lbl_LongitudRD.Location = New System.Drawing.Point(21, 82)
        Me.Lbl_LongitudRD.Name = "Lbl_LongitudRD"
        Me.Lbl_LongitudRD.Size = New System.Drawing.Size(140, 13)
        Me.Lbl_LongitudRD.TabIndex = 4
        Me.Lbl_LongitudRD.Text = "Longitud Referencias Depo:"
        '
        'Gbx_Datos2
        '
        Me.Gbx_Datos2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos2.Controls.Add(Me.Cmb_DigSeg)
        Me.Gbx_Datos2.Controls.Add(Me.Cmb_RefDepo)
        Me.Gbx_Datos2.Controls.Add(Me.Tbx_LongRefepo)
        Me.Gbx_Datos2.Controls.Add(Me.Lbl_DigitoS)
        Me.Gbx_Datos2.Controls.Add(Me.Lbl_LongitudRD)
        Me.Gbx_Datos2.Controls.Add(Me.Lbl_TipoRD)
        Me.Gbx_Datos2.Enabled = False
        Me.Gbx_Datos2.Location = New System.Drawing.Point(322, 58)
        Me.Gbx_Datos2.Name = "Gbx_Datos2"
        Me.Gbx_Datos2.Size = New System.Drawing.Size(348, 135)
        Me.Gbx_Datos2.TabIndex = 2
        Me.Gbx_Datos2.TabStop = False
        '
        'Cmb_DigSeg
        '
        Me.Cmb_DigSeg.Control_Siguiente = Nothing
        Me.Cmb_DigSeg.DisplayMember = "display"
        Me.Cmb_DigSeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_DigSeg.FormattingEnabled = True
        Me.Cmb_DigSeg.Location = New System.Drawing.Point(167, 25)
        Me.Cmb_DigSeg.MaxDropDownItems = 20
        Me.Cmb_DigSeg.Name = "Cmb_DigSeg"
        Me.Cmb_DigSeg.Size = New System.Drawing.Size(130, 21)
        Me.Cmb_DigSeg.TabIndex = 1
        Me.Cmb_DigSeg.ValueMember = "value"
        '
        'Cmb_RefDepo
        '
        Me.Cmb_RefDepo.Control_Siguiente = Nothing
        Me.Cmb_RefDepo.DisplayMember = "display"
        Me.Cmb_RefDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_RefDepo.FormattingEnabled = True
        Me.Cmb_RefDepo.Location = New System.Drawing.Point(167, 52)
        Me.Cmb_RefDepo.MaxDropDownItems = 20
        Me.Cmb_RefDepo.Name = "Cmb_RefDepo"
        Me.Cmb_RefDepo.Size = New System.Drawing.Size(130, 21)
        Me.Cmb_RefDepo.TabIndex = 3
        Me.Cmb_RefDepo.ValueMember = "value"
        '
        'Tbx_LongRefepo
        '
        Me.Tbx_LongRefepo.Control_Siguiente = Nothing
        Me.Tbx_LongRefepo.Filtrado = False
        Me.Tbx_LongRefepo.Location = New System.Drawing.Point(167, 79)
        Me.Tbx_LongRefepo.Name = "Tbx_LongRefepo"
        Me.Tbx_LongRefepo.Size = New System.Drawing.Size(91, 20)
        Me.Tbx_LongRefepo.TabIndex = 5
        Me.Tbx_LongRefepo.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(664, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Estos parámetros se tomarán en cuenta para la generación de los archivos de depos" & _
            "itos (Archivos TXT)"
        '
        'frm_CajasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Gbx_Datos2)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Datos1)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(575, 300)
        Me.Name = "frm_CajasBancarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros de Bancos"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Datos1.ResumeLayout(False)
        Me.Gbx_Datos1.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Datos2.ResumeLayout(False)
        Me.Gbx_Datos2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_CajasB As System.Windows.Forms.Label
    Friend WithEvents Cmb_CajasBancarias As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Gbx_Datos1 As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_TipoA As System.Windows.Forms.Label
    Friend WithEvents Lbl_LongitudRD As System.Windows.Forms.Label
    Friend WithEvents Lbl_TipoRD As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cr As System.Windows.Forms.Label
    Friend WithEvents Lbl_DigitoS As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumeroP As System.Windows.Forms.Label
    Friend WithEvents Gbx_Datos2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_ClavePA As System.Windows.Forms.Label
    Friend WithEvents Tbx_CR As Modulo_Proceso.cp_Textbox
    Friend WithEvents Tbx_TipoArchivo As Modulo_Proceso.cp_Textbox
    Friend WithEvents Tbx_ClaveProvedorA As Modulo_Proceso.cp_Textbox
    Friend WithEvents Tbx_NumPlaza As Modulo_Proceso.cp_Textbox
    Friend WithEvents Cmb_DigSeg As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents Cmb_RefDepo As Modulo_Proceso.cp_cmb_Manual
    Friend WithEvents Tbx_LongRefepo As Modulo_Proceso.cp_Textbox
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
