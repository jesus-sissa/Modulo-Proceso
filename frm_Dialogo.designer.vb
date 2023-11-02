<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Dialogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Dialogo))
        Dim ListViewColumnSorter1 As Modulo_Proceso.ListViewColumnSorter = New Modulo_Proceso.ListViewColumnSorter
        Me.gbx_Titulo = New System.Windows.Forms.GroupBox
        Me.Lbl_CIA = New System.Windows.Forms.Label
        Me.lbl_CiaTV = New System.Windows.Forms.Label
        Me.lbl_Clave = New System.Windows.Forms.Label
        Me.lbl_Domicilio = New System.Windows.Forms.Label
        Me.Lbl_DomicilioT = New System.Windows.Forms.Label
        Me.lbl_NombreCompañia = New System.Windows.Forms.Label
        Me.Lbl_Origen = New System.Windows.Forms.Label
        Me.lbl_NombreCliente = New System.Windows.Forms.Label
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.GpoDatos = New System.Windows.Forms.GroupBox
        Me.rdo_No = New System.Windows.Forms.RadioButton
        Me.rdo_Si = New System.Windows.Forms.RadioButton
        Me.Lbl_Imprimir = New System.Windows.Forms.Label
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.grbEnvases = New System.Windows.Forms.GroupBox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lbl_TipoEnvase = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cmb_TipoImpresion = New Modulo_Proceso.cp_cmb_Manual
        Me.tbx_Remision = New Modulo_Proceso.cp_Textbox
        Me.tbx_Envases = New Modulo_Proceso.cp_Textbox
        Me.tbx_Numero = New Modulo_Proceso.cp_Textbox
        Me.cmb_TipoEnvase = New Modulo_Proceso.cp_cmb_Simple
        Me.lsv_Envases = New Modulo_Proceso.cp_Listview
        Me.gbx_Titulo.SuspendLayout()
        Me.GpoDatos.SuspendLayout()
        Me.grbEnvases.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Titulo
        '
        Me.gbx_Titulo.Controls.Add(Me.Lbl_CIA)
        Me.gbx_Titulo.Controls.Add(Me.lbl_CiaTV)
        Me.gbx_Titulo.Controls.Add(Me.lbl_Clave)
        Me.gbx_Titulo.Controls.Add(Me.lbl_Domicilio)
        Me.gbx_Titulo.Controls.Add(Me.Lbl_DomicilioT)
        Me.gbx_Titulo.Controls.Add(Me.lbl_NombreCompañia)
        Me.gbx_Titulo.Controls.Add(Me.Lbl_Origen)
        Me.gbx_Titulo.Controls.Add(Me.lbl_NombreCliente)
        Me.gbx_Titulo.Controls.Add(Me.lbl_Destino)
        Me.gbx_Titulo.Location = New System.Drawing.Point(8, 5)
        Me.gbx_Titulo.Name = "gbx_Titulo"
        Me.gbx_Titulo.Size = New System.Drawing.Size(492, 127)
        Me.gbx_Titulo.TabIndex = 0
        Me.gbx_Titulo.TabStop = False
        '
        'Lbl_CIA
        '
        Me.Lbl_CIA.AutoSize = True
        Me.Lbl_CIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CIA.Location = New System.Drawing.Point(8, 100)
        Me.Lbl_CIA.Name = "Lbl_CIA"
        Me.Lbl_CIA.Size = New System.Drawing.Size(106, 13)
        Me.Lbl_CIA.TabIndex = 6
        Me.Lbl_CIA.Text = "Compañía de TV:"
        '
        'lbl_CiaTV
        '
        Me.lbl_CiaTV.AutoSize = True
        Me.lbl_CiaTV.Location = New System.Drawing.Point(114, 100)
        Me.lbl_CiaTV.Name = "lbl_CiaTV"
        Me.lbl_CiaTV.Size = New System.Drawing.Size(36, 13)
        Me.lbl_CiaTV.TabIndex = 7
        Me.lbl_CiaTV.Text = "CiaTV"
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(452, 100)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 8
        Me.lbl_Clave.Text = "Clave"
        Me.lbl_Clave.Visible = False
        '
        'lbl_Domicilio
        '
        Me.lbl_Domicilio.AutoSize = True
        Me.lbl_Domicilio.Location = New System.Drawing.Point(108, 76)
        Me.lbl_Domicilio.Name = "lbl_Domicilio"
        Me.lbl_Domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Domicilio.TabIndex = 5
        Me.lbl_Domicilio.Text = "Domicilio"
        '
        'Lbl_DomicilioT
        '
        Me.Lbl_DomicilioT.AutoSize = True
        Me.Lbl_DomicilioT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DomicilioT.Location = New System.Drawing.Point(48, 76)
        Me.Lbl_DomicilioT.Name = "Lbl_DomicilioT"
        Me.Lbl_DomicilioT.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_DomicilioT.TabIndex = 4
        Me.Lbl_DomicilioT.Text = "Domicilio:"
        '
        'lbl_NombreCompañia
        '
        Me.lbl_NombreCompañia.AutoSize = True
        Me.lbl_NombreCompañia.Location = New System.Drawing.Point(108, 16)
        Me.lbl_NombreCompañia.Name = "lbl_NombreCompañia"
        Me.lbl_NombreCompañia.Size = New System.Drawing.Size(119, 13)
        Me.lbl_NombreCompañia.TabIndex = 1
        Me.lbl_NombreCompañia.Text = "Nombre de la compañia"
        '
        'Lbl_Origen
        '
        Me.Lbl_Origen.AutoSize = True
        Me.Lbl_Origen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Origen.Location = New System.Drawing.Point(62, 16)
        Me.Lbl_Origen.Name = "Lbl_Origen"
        Me.Lbl_Origen.Size = New System.Drawing.Size(48, 13)
        Me.Lbl_Origen.TabIndex = 0
        Me.Lbl_Origen.Text = "Origen:"
        '
        'lbl_NombreCliente
        '
        Me.lbl_NombreCliente.Location = New System.Drawing.Point(108, 39)
        Me.lbl_NombreCliente.Name = "lbl_NombreCliente"
        Me.lbl_NombreCliente.Size = New System.Drawing.Size(376, 37)
        Me.lbl_NombreCliente.TabIndex = 3
        Me.lbl_NombreCliente.Text = "Nombre del Cliente"
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Destino.Location = New System.Drawing.Point(57, 39)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Destino.TabIndex = 2
        Me.lbl_Destino.Text = "Destino:"
        '
        'GpoDatos
        '
        Me.GpoDatos.Controls.Add(Me.cmb_TipoImpresion)
        Me.GpoDatos.Controls.Add(Me.rdo_No)
        Me.GpoDatos.Controls.Add(Me.rdo_Si)
        Me.GpoDatos.Controls.Add(Me.Lbl_Imprimir)
        Me.GpoDatos.Controls.Add(Me.tbx_Remision)
        Me.GpoDatos.Controls.Add(Me.tbx_Envases)
        Me.GpoDatos.Controls.Add(Me.grbEnvases)
        Me.GpoDatos.Controls.Add(Me.Label2)
        Me.GpoDatos.Controls.Add(Me.lbl_Remision)
        Me.GpoDatos.Location = New System.Drawing.Point(8, 138)
        Me.GpoDatos.Name = "GpoDatos"
        Me.GpoDatos.Size = New System.Drawing.Size(492, 287)
        Me.GpoDatos.TabIndex = 1
        Me.GpoDatos.TabStop = False
        '
        'rdo_No
        '
        Me.rdo_No.AutoSize = True
        Me.rdo_No.Location = New System.Drawing.Point(248, 257)
        Me.rdo_No.Name = "rdo_No"
        Me.rdo_No.Size = New System.Drawing.Size(39, 17)
        Me.rdo_No.TabIndex = 7
        Me.rdo_No.TabStop = True
        Me.rdo_No.Text = "No"
        Me.rdo_No.UseVisualStyleBackColor = True
        '
        'rdo_Si
        '
        Me.rdo_Si.AutoSize = True
        Me.rdo_Si.Location = New System.Drawing.Point(165, 257)
        Me.rdo_Si.Name = "rdo_Si"
        Me.rdo_Si.Size = New System.Drawing.Size(34, 17)
        Me.rdo_Si.TabIndex = 6
        Me.rdo_Si.TabStop = True
        Me.rdo_Si.Text = "Si"
        Me.rdo_Si.UseVisualStyleBackColor = True
        '
        'Lbl_Imprimir
        '
        Me.Lbl_Imprimir.Location = New System.Drawing.Point(16, 253)
        Me.Lbl_Imprimir.Name = "Lbl_Imprimir"
        Me.Lbl_Imprimir.Size = New System.Drawing.Size(116, 29)
        Me.Lbl_Imprimir.TabIndex = 5
        Me.Lbl_Imprimir.Text = "Imprimir Desglose de Denominaciones?"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Image = CType(resources.GetObject("Btn_Agregar.Image"), System.Drawing.Image)
        Me.Btn_Agregar.Location = New System.Drawing.Point(6, 113)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(110, 30)
        Me.Btn_Agregar.TabIndex = 4
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'grbEnvases
        '
        Me.grbEnvases.Controls.Add(Me.btn_Eliminar)
        Me.grbEnvases.Controls.Add(Me.lsv_Envases)
        Me.grbEnvases.Controls.Add(Me.Btn_Agregar)
        Me.grbEnvases.Controls.Add(Me.tbx_Numero)
        Me.grbEnvases.Controls.Add(Me.cmb_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_numero)
        Me.grbEnvases.Location = New System.Drawing.Point(9, 50)
        Me.grbEnvases.Name = "grbEnvases"
        Me.grbEnvases.Size = New System.Drawing.Size(477, 195)
        Me.grbEnvases.TabIndex = 4
        Me.grbEnvases.TabStop = False
        Me.grbEnvases.Text = "Envases"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.Location = New System.Drawing.Point(6, 149)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(110, 30)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_TipoEnvase
        '
        Me.lbl_TipoEnvase.AutoSize = True
        Me.lbl_TipoEnvase.Location = New System.Drawing.Point(7, 70)
        Me.lbl_TipoEnvase.Name = "lbl_TipoEnvase"
        Me.lbl_TipoEnvase.Size = New System.Drawing.Size(82, 13)
        Me.lbl_TipoEnvase.TabIndex = 2
        Me.lbl_TipoEnvase.Text = "Tipo de Envase"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(6, 25)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 0
        Me.lbl_numero.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Envases sin Número:"
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(108, 13)
        Me.lbl_Remision.TabIndex = 0
        Me.lbl_Remision.Text = "Numero de Remisión:"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(8, 431)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(492, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Image = CType(resources.GetObject("btn_Imprimir.Image"), System.Drawing.Image)
        Me.btn_Imprimir.Location = New System.Drawing.Point(173, 14)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 1
        Me.btn_Imprimir.Text = "Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(341, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = CType(resources.GetObject("btn_Guardar.Image"), System.Drawing.Image)
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'cmb_TipoImpresion
        '
        Me.cmb_TipoImpresion.Control_Siguiente = Nothing
        Me.cmb_TipoImpresion.DisplayMember = "display"
        Me.cmb_TipoImpresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoImpresion.FormattingEnabled = True
        Me.cmb_TipoImpresion.Location = New System.Drawing.Point(344, 256)
        Me.cmb_TipoImpresion.MaxDropDownItems = 20
        Me.cmb_TipoImpresion.Name = "cmb_TipoImpresion"
        Me.cmb_TipoImpresion.Size = New System.Drawing.Size(140, 21)
        Me.cmb_TipoImpresion.TabIndex = 8
        Me.cmb_TipoImpresion.ValueMember = "value"
        Me.cmb_TipoImpresion.Visible = False
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.tbx_Envases
        Me.tbx_Remision.Filtrado = False
        Me.tbx_Remision.Location = New System.Drawing.Point(117, 13)
        Me.tbx_Remision.MaxLength = 10
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Remision.TabIndex = 1
        Me.tbx_Remision.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Envases
        '
        Me.tbx_Envases.Control_Siguiente = Me.tbx_Numero
        Me.tbx_Envases.Filtrado = True
        Me.tbx_Envases.Location = New System.Drawing.Point(372, 13)
        Me.tbx_Envases.MaxLength = 4
        Me.tbx_Envases.Name = "tbx_Envases"
        Me.tbx_Envases.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Envases.TabIndex = 3
        Me.tbx_Envases.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Control_Siguiente = Me.cmb_TipoEnvase
        Me.tbx_Numero.Filtrado = False
        Me.tbx_Numero.Location = New System.Drawing.Point(6, 47)
        Me.tbx_Numero.MaxLength = 15
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Numero.TabIndex = 1
        Me.tbx_Numero.TipoDatos = Modulo_Proceso.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_TipoEnvase
        '
        Me.cmb_TipoEnvase.Control_Siguiente = Me.Btn_Agregar
        Me.cmb_TipoEnvase.DisplayMember = "Descripcion"
        Me.cmb_TipoEnvase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoEnvase.Empresa = False
        Me.cmb_TipoEnvase.FormattingEnabled = True
        Me.cmb_TipoEnvase.Location = New System.Drawing.Point(6, 86)
        Me.cmb_TipoEnvase.MaxDropDownItems = 20
        Me.cmb_TipoEnvase.Name = "cmb_TipoEnvase"
        Me.cmb_TipoEnvase.Pista = True
        Me.cmb_TipoEnvase.Size = New System.Drawing.Size(110, 21)
        Me.cmb_TipoEnvase.StoredProcedure = "CAT_TipoEnvase_GET"
        Me.cmb_TipoEnvase.Sucursal = False
        Me.cmb_TipoEnvase.TabIndex = 3
        Me.cmb_TipoEnvase.ValueMember = "Id_TipoE"
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(122, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 49
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 49
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(343, 165)
        Me.lsv_Envases.TabIndex = 6
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'frm_Dialogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 491)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.GpoDatos)
        Me.Controls.Add(Me.gbx_Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(510, 520)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(510, 520)
        Me.Name = "frm_Dialogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura numero de Remision y Envases."
        Me.gbx_Titulo.ResumeLayout(False)
        Me.gbx_Titulo.PerformLayout()
        Me.GpoDatos.ResumeLayout(False)
        Me.GpoDatos.PerformLayout()
        Me.grbEnvases.ResumeLayout(False)
        Me.grbEnvases.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Titulo As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_NombreCompañia As System.Windows.Forms.Label
    Friend WithEvents Lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreCliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents GpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grbEnvases As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TipoEnvase As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Proceso.cp_Textbox
    Friend WithEvents tbx_Envases As Modulo_Proceso.cp_Textbox
    Friend WithEvents cmb_TipoEnvase As Modulo_Proceso.cp_cmb_Simple
    Friend WithEvents tbx_Numero As Modulo_Proceso.cp_Textbox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Proceso.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents lbl_Domicilio As System.Windows.Forms.Label
    Friend WithEvents Lbl_DomicilioT As System.Windows.Forms.Label
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents lbl_CiaTV As System.Windows.Forms.Label
    Friend WithEvents Lbl_CIA As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_No As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Si As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_Imprimir As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoImpresion As Modulo_Proceso.cp_cmb_Manual
End Class
