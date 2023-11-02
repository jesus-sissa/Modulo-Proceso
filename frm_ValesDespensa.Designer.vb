<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ValesdeDespensa
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
        Me.gbx_ListaValesdespensa = New System.Windows.Forms.GroupBox
        Me.tbx_sinGuardar = New System.Windows.Forms.TextBox
        Me.tbx_ExisteBDD = New System.Windows.Forms.TextBox
        Me.tbx_Guardados = New System.Windows.Forms.TextBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Datos = New System.Windows.Forms.ListView
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Inicio = New System.Windows.Forms.Button
        Me.btn_Finalizar = New System.Windows.Forms.Button
        Me.btn_Escanear = New System.Windows.Forms.Button
        Me.gbx_BotonesEscaner = New System.Windows.Forms.GroupBox
        Me.btn_liberarAtasco = New System.Windows.Forms.Button
        Me.cmb_casavalera = New Modulo_Proceso.cp_cmb_SimpleFiltradoParam
        Me.gbx_modoCaptura = New System.Windows.Forms.GroupBox
        Me.rdb_micr = New System.Windows.Forms.RadioButton
        Me.rdb_CodigoBarras = New System.Windows.Forms.RadioButton
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.tbx_MicrCB = New System.Windows.Forms.TextBox
        Me.chk_CapturarManual = New System.Windows.Forms.CheckBox
        Me.lbl_casaValera = New System.Windows.Forms.Label
        Me.lbl_status = New System.Windows.Forms.Label
        Me.gbx_ListaValesdespensa.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.gbx_BotonesEscaner.SuspendLayout()
        Me.gbx_modoCaptura.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_ListaValesdespensa
        '
        Me.gbx_ListaValesdespensa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_ListaValesdespensa.Controls.Add(Me.tbx_sinGuardar)
        Me.gbx_ListaValesdespensa.Controls.Add(Me.tbx_ExisteBDD)
        Me.gbx_ListaValesdespensa.Controls.Add(Me.tbx_Guardados)
        Me.gbx_ListaValesdespensa.Controls.Add(Me.lbl_Registros)
        Me.gbx_ListaValesdespensa.Controls.Add(Me.lsv_Datos)
        Me.gbx_ListaValesdespensa.Location = New System.Drawing.Point(7, 105)
        Me.gbx_ListaValesdespensa.Name = "gbx_ListaValesdespensa"
        Me.gbx_ListaValesdespensa.Size = New System.Drawing.Size(920, 458)
        Me.gbx_ListaValesdespensa.TabIndex = 1
        Me.gbx_ListaValesdespensa.TabStop = False
        '
        'tbx_sinGuardar
        '
        Me.tbx_sinGuardar.BackColor = System.Drawing.Color.Khaki
        Me.tbx_sinGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_sinGuardar.Location = New System.Drawing.Point(235, 9)
        Me.tbx_sinGuardar.Name = "tbx_sinGuardar"
        Me.tbx_sinGuardar.ReadOnly = True
        Me.tbx_sinGuardar.Size = New System.Drawing.Size(100, 22)
        Me.tbx_sinGuardar.TabIndex = 3
        Me.tbx_sinGuardar.Text = "sin Guardar"
        '
        'tbx_ExisteBDD
        '
        Me.tbx_ExisteBDD.BackColor = System.Drawing.Color.LightCoral
        Me.tbx_ExisteBDD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ExisteBDD.Location = New System.Drawing.Point(124, 9)
        Me.tbx_ExisteBDD.Name = "tbx_ExisteBDD"
        Me.tbx_ExisteBDD.ReadOnly = True
        Me.tbx_ExisteBDD.Size = New System.Drawing.Size(75, 22)
        Me.tbx_ExisteBDD.TabIndex = 2
        Me.tbx_ExisteBDD.Text = "ya Existe"
        '
        'tbx_Guardados
        '
        Me.tbx_Guardados.BackColor = System.Drawing.Color.LightGreen
        Me.tbx_Guardados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Guardados.Location = New System.Drawing.Point(7, 9)
        Me.tbx_Guardados.Name = "tbx_Guardados"
        Me.tbx_Guardados.ReadOnly = True
        Me.tbx_Guardados.Size = New System.Drawing.Size(92, 22)
        Me.tbx_Guardados.TabIndex = 1
        Me.tbx_Guardados.Text = "Guardado"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.ForeColor = System.Drawing.Color.Black
        Me.lbl_Registros.Location = New System.Drawing.Point(774, 14)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(140, 13)
        Me.lbl_Registros.TabIndex = 4
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 32)
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Size = New System.Drawing.Size(908, 421)
        Me.lsv_Datos.TabIndex = 0
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_botones.Controls.Add(Me.btn_Eliminar)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_botones.Location = New System.Drawing.Point(7, 569)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(920, 50)
        Me.gbx_botones.TabIndex = 2
        Me.gbx_botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Proceso.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(626, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 2
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_Proceso.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(152, 14)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 1
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(772, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
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
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Inicio
        '
        Me.btn_Inicio.Enabled = False
        Me.btn_Inicio.Image = Global.Modulo_Proceso.My.Resources.Resources.Inicializar
        Me.btn_Inicio.Location = New System.Drawing.Point(10, 24)
        Me.btn_Inicio.Name = "btn_Inicio"
        Me.btn_Inicio.Size = New System.Drawing.Size(140, 30)
        Me.btn_Inicio.TabIndex = 0
        Me.btn_Inicio.Text = "&Inicializar"
        Me.btn_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Inicio.UseVisualStyleBackColor = True
        '
        'btn_Finalizar
        '
        Me.btn_Finalizar.Enabled = False
        Me.btn_Finalizar.Image = Global.Modulo_Proceso.My.Resources.Resources.Finalizar
        Me.btn_Finalizar.Location = New System.Drawing.Point(302, 24)
        Me.btn_Finalizar.Name = "btn_Finalizar"
        Me.btn_Finalizar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Finalizar.TabIndex = 2
        Me.btn_Finalizar.Text = "&Finalizar"
        Me.btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Finalizar.UseVisualStyleBackColor = True
        '
        'btn_Escanear
        '
        Me.btn_Escanear.Enabled = False
        Me.btn_Escanear.Image = Global.Modulo_Proceso.My.Resources.Resources.Escanear
        Me.btn_Escanear.Location = New System.Drawing.Point(156, 24)
        Me.btn_Escanear.Name = "btn_Escanear"
        Me.btn_Escanear.Size = New System.Drawing.Size(140, 30)
        Me.btn_Escanear.TabIndex = 1
        Me.btn_Escanear.Text = "&Escanear"
        Me.btn_Escanear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Escanear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Escanear.UseVisualStyleBackColor = True
        '
        'gbx_BotonesEscaner
        '
        Me.gbx_BotonesEscaner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_BotonesEscaner.Controls.Add(Me.btn_liberarAtasco)
        Me.gbx_BotonesEscaner.Controls.Add(Me.cmb_casavalera)
        Me.gbx_BotonesEscaner.Controls.Add(Me.gbx_modoCaptura)
        Me.gbx_BotonesEscaner.Controls.Add(Me.btn_Agregar)
        Me.gbx_BotonesEscaner.Controls.Add(Me.tbx_MicrCB)
        Me.gbx_BotonesEscaner.Controls.Add(Me.chk_CapturarManual)
        Me.gbx_BotonesEscaner.Controls.Add(Me.lbl_casaValera)
        Me.gbx_BotonesEscaner.Controls.Add(Me.btn_Escanear)
        Me.gbx_BotonesEscaner.Controls.Add(Me.btn_Finalizar)
        Me.gbx_BotonesEscaner.Controls.Add(Me.btn_Inicio)
        Me.gbx_BotonesEscaner.Controls.Add(Me.lbl_status)
        Me.gbx_BotonesEscaner.Location = New System.Drawing.Point(10, 3)
        Me.gbx_BotonesEscaner.Name = "gbx_BotonesEscaner"
        Me.gbx_BotonesEscaner.Size = New System.Drawing.Size(917, 96)
        Me.gbx_BotonesEscaner.TabIndex = 0
        Me.gbx_BotonesEscaner.TabStop = False
        Me.gbx_BotonesEscaner.Text = "Iniciar Escaner"
        '
        'btn_liberarAtasco
        '
        Me.btn_liberarAtasco.Enabled = False
        Me.btn_liberarAtasco.Image = Global.Modulo_Proceso.My.Resources.Resources.Proceso
        Me.btn_liberarAtasco.Location = New System.Drawing.Point(448, 24)
        Me.btn_liberarAtasco.Name = "btn_liberarAtasco"
        Me.btn_liberarAtasco.Size = New System.Drawing.Size(75, 30)
        Me.btn_liberarAtasco.TabIndex = 11
        Me.btn_liberarAtasco.Text = "Liberar"
        Me.btn_liberarAtasco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_liberarAtasco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_liberarAtasco.UseVisualStyleBackColor = True
        '
        'cmb_casavalera
        '
        Me.cmb_casavalera.Clave = Nothing
        Me.cmb_casavalera.Control_Siguiente = Nothing
        Me.cmb_casavalera.DisplayMember = "Nombre"
        Me.cmb_casavalera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_casavalera.Empresa = False
        Me.cmb_casavalera.Filtro = Nothing
        Me.cmb_casavalera.FormattingEnabled = True
        Me.cmb_casavalera.Location = New System.Drawing.Point(78, 61)
        Me.cmb_casavalera.MaxDropDownItems = 20
        Me.cmb_casavalera.Name = "cmb_casavalera"
        Me.cmb_casavalera.Pista = False
        Me.cmb_casavalera.Size = New System.Drawing.Size(228, 21)
        Me.cmb_casavalera.StoredProcedure = "Pro_CasasV_GetCombo"
        Me.cmb_casavalera.Sucursal = False
        Me.cmb_casavalera.TabIndex = 10
        Me.cmb_casavalera.Tipo = 0
        Me.cmb_casavalera.ValueMember = "Id_Casa"
        '
        'gbx_modoCaptura
        '
        Me.gbx_modoCaptura.Controls.Add(Me.rdb_micr)
        Me.gbx_modoCaptura.Controls.Add(Me.rdb_CodigoBarras)
        Me.gbx_modoCaptura.Enabled = False
        Me.gbx_modoCaptura.Location = New System.Drawing.Point(642, 9)
        Me.gbx_modoCaptura.Name = "gbx_modoCaptura"
        Me.gbx_modoCaptura.Size = New System.Drawing.Size(258, 44)
        Me.gbx_modoCaptura.TabIndex = 7
        Me.gbx_modoCaptura.TabStop = False
        Me.gbx_modoCaptura.Text = "Modo Captura"
        '
        'rdb_micr
        '
        Me.rdb_micr.AutoSize = True
        Me.rdb_micr.Enabled = False
        Me.rdb_micr.Location = New System.Drawing.Point(143, 20)
        Me.rdb_micr.Name = "rdb_micr"
        Me.rdb_micr.Size = New System.Drawing.Size(109, 17)
        Me.rdb_micr.TabIndex = 1
        Me.rdb_micr.Text = "Banda Magnetica"
        Me.rdb_micr.UseVisualStyleBackColor = True
        '
        'rdb_CodigoBarras
        '
        Me.rdb_CodigoBarras.AutoSize = True
        Me.rdb_CodigoBarras.Enabled = False
        Me.rdb_CodigoBarras.Location = New System.Drawing.Point(11, 20)
        Me.rdb_CodigoBarras.Name = "rdb_CodigoBarras"
        Me.rdb_CodigoBarras.Size = New System.Drawing.Size(106, 17)
        Me.rdb_CodigoBarras.TabIndex = 0
        Me.rdb_CodigoBarras.Text = "Codigo de Barras"
        Me.rdb_CodigoBarras.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Proceso.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(762, 59)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 9
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbx_MicrCB
        '
        Me.tbx_MicrCB.Enabled = False
        Me.tbx_MicrCB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_MicrCB.Location = New System.Drawing.Point(535, 61)
        Me.tbx_MicrCB.MaxLength = 50
        Me.tbx_MicrCB.Name = "tbx_MicrCB"
        Me.tbx_MicrCB.Size = New System.Drawing.Size(224, 26)
        Me.tbx_MicrCB.TabIndex = 8
        '
        'chk_CapturarManual
        '
        Me.chk_CapturarManual.AutoSize = True
        Me.chk_CapturarManual.Enabled = False
        Me.chk_CapturarManual.Location = New System.Drawing.Point(532, 19)
        Me.chk_CapturarManual.Name = "chk_CapturarManual"
        Me.chk_CapturarManual.Size = New System.Drawing.Size(104, 17)
        Me.chk_CapturarManual.TabIndex = 6
        Me.chk_CapturarManual.Text = "Capturar Manual"
        Me.chk_CapturarManual.UseVisualStyleBackColor = True
        '
        'lbl_casaValera
        '
        Me.lbl_casaValera.AutoSize = True
        Me.lbl_casaValera.Location = New System.Drawing.Point(7, 63)
        Me.lbl_casaValera.Name = "lbl_casaValera"
        Me.lbl_casaValera.Size = New System.Drawing.Size(64, 13)
        Me.lbl_casaValera.TabIndex = 3
        Me.lbl_casaValera.Text = "Casa Valera"
        '
        'lbl_status
        '
        Me.lbl_status.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_status.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(311, 57)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(222, 30)
        Me.lbl_status.TabIndex = 5
        '
        'frm_ValesdeDespensa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 631)
        Me.Controls.Add(Me.gbx_BotonesEscaner)
        Me.Controls.Add(Me.gbx_ListaValesdespensa)
        Me.Controls.Add(Me.gbx_botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(950, 670)
        Me.Name = "frm_ValesdeDespensa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digitalizar Vales de Despensa"
        Me.gbx_ListaValesdespensa.ResumeLayout(False)
        Me.gbx_ListaValesdespensa.PerformLayout()
        Me.gbx_botones.ResumeLayout(False)
        Me.gbx_BotonesEscaner.ResumeLayout(False)
        Me.gbx_BotonesEscaner.PerformLayout()
        Me.gbx_modoCaptura.ResumeLayout(False)
        Me.gbx_modoCaptura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_ListaValesdespensa As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As System.Windows.Forms.ListView
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Inicio As System.Windows.Forms.Button
    Friend WithEvents btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents btn_Escanear As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents gbx_BotonesEscaner As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_casaValera As System.Windows.Forms.Label
    Friend WithEvents tbx_ExisteBDD As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Guardados As System.Windows.Forms.TextBox
    Friend WithEvents tbx_sinGuardar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents tbx_MicrCB As System.Windows.Forms.TextBox
    Friend WithEvents chk_CapturarManual As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents gbx_modoCaptura As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_micr As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_CodigoBarras As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_casavalera As Modulo_Proceso.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_liberarAtasco As System.Windows.Forms.Button
End Class
