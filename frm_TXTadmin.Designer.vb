<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TXTadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TXTadmin))
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.btn_RutaEncriptador = New System.Windows.Forms.Button
        Me.tbx_Encriptador = New System.Windows.Forms.TextBox
        Me.Lbl_Encriptador = New System.Windows.Forms.Label
        Me.btn_RutaNueva = New System.Windows.Forms.Button
        Me.tbx_Destino = New System.Windows.Forms.TextBox
        Me.Lbl_UbicacionDestino = New System.Windows.Forms.Label
        Me.tbx_Consecutivo = New System.Windows.Forms.TextBox
        Me.Lbl_Consecutivo = New System.Windows.Forms.Label
        Me.tbx_NombreNuevo = New System.Windows.Forms.TextBox
        Me.Lbl_NombreNuevo = New System.Windows.Forms.Label
        Me.btn_Ruta = New System.Windows.Forms.Button
        Me.txt_Archivo = New System.Windows.Forms.TextBox
        Me.lbl_Ruta = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.lbl_Archivo = New System.Windows.Forms.Label
        Me.dlg_Archivo = New System.Windows.Forms.OpenFileDialog
        Me.gbx_Botones2 = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_ExtraerCheques = New System.Windows.Forms.Button
        Me.btn_Encriptar = New System.Windows.Forms.Button
        Me.dlg_Destino = New System.Windows.Forms.FolderBrowserDialog
        Me.Tab_Principal = New System.Windows.Forms.TabControl
        Me.Tab_Encriptar = New System.Windows.Forms.TabPage
        Me.Gbx_Botones1 = New System.Windows.Forms.GroupBox
        Me.Tab_Cheques = New System.Windows.Forms.TabPage
        Me.gbx_Cheques = New System.Windows.Forms.GroupBox
        Me.btn_RutaArchivoI = New System.Windows.Forms.Button
        Me.tbx_ArchivoI = New System.Windows.Forms.TextBox
        Me.lbl_UbicacionIB64 = New System.Windows.Forms.Label
        Me.btn_GuardaImaB64 = New System.Windows.Forms.Button
        Me.Gbx = New System.Windows.Forms.GroupBox
        Me.rdb_Back = New System.Windows.Forms.RadioButton
        Me.rdb_Ambas = New System.Windows.Forms.RadioButton
        Me.rdb_Frente = New System.Windows.Forms.RadioButton
        Me.lbl_Zoom = New System.Windows.Forms.Label
        Me.tbx_Importe = New System.Windows.Forms.TextBox
        Me.Lbl_Importe = New System.Windows.Forms.Label
        Me.pct_Back = New System.Windows.Forms.PictureBox
        Me.pct_Front = New System.Windows.Forms.PictureBox
        Me.lsv_Cheques = New System.Windows.Forms.ListView
        Me.btn_DestinoCheques = New System.Windows.Forms.Button
        Me.tbx_DestinoCheques = New System.Windows.Forms.TextBox
        Me.lbl_Rojo = New System.Windows.Forms.Label
        Me.Lbl_UbicacionDes = New System.Windows.Forms.Label
        Me.btn_RutaArchivos = New System.Windows.Forms.Button
        Me.tbx_ArchivoCheques = New System.Windows.Forms.TextBox
        Me.Lbl_SeleccionarArch = New System.Windows.Forms.Label
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Botones2.SuspendLayout()
        Me.Tab_Principal.SuspendLayout()
        Me.Tab_Encriptar.SuspendLayout()
        Me.Gbx_Botones1.SuspendLayout()
        Me.Tab_Cheques.SuspendLayout()
        Me.gbx_Cheques.SuspendLayout()
        Me.Gbx.SuspendLayout()
        CType(Me.pct_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Front, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.btn_RutaEncriptador)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Encriptador)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Encriptador)
        Me.gbx_Filtro.Controls.Add(Me.btn_RutaNueva)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Destino)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_UbicacionDestino)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Consecutivo)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_Consecutivo)
        Me.gbx_Filtro.Controls.Add(Me.tbx_NombreNuevo)
        Me.gbx_Filtro.Controls.Add(Me.Lbl_NombreNuevo)
        Me.gbx_Filtro.Controls.Add(Me.btn_Ruta)
        Me.gbx_Filtro.Controls.Add(Me.txt_Archivo)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Ruta)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Fecha)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Archivo)
        Me.gbx_Filtro.Location = New System.Drawing.Point(6, 6)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(699, 183)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'btn_RutaEncriptador
        '
        Me.btn_RutaEncriptador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RutaEncriptador.Location = New System.Drawing.Point(540, 157)
        Me.btn_RutaEncriptador.Name = "btn_RutaEncriptador"
        Me.btn_RutaEncriptador.Size = New System.Drawing.Size(32, 22)
        Me.btn_RutaEncriptador.TabIndex = 14
        Me.btn_RutaEncriptador.Text = "..."
        Me.btn_RutaEncriptador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_RutaEncriptador.UseVisualStyleBackColor = True
        '
        'tbx_Encriptador
        '
        Me.tbx_Encriptador.BackColor = System.Drawing.Color.White
        Me.tbx_Encriptador.Location = New System.Drawing.Point(110, 157)
        Me.tbx_Encriptador.Name = "tbx_Encriptador"
        Me.tbx_Encriptador.ReadOnly = True
        Me.tbx_Encriptador.Size = New System.Drawing.Size(425, 20)
        Me.tbx_Encriptador.TabIndex = 13
        '
        'Lbl_Encriptador
        '
        Me.Lbl_Encriptador.AutoSize = True
        Me.Lbl_Encriptador.Location = New System.Drawing.Point(40, 160)
        Me.Lbl_Encriptador.Name = "Lbl_Encriptador"
        Me.Lbl_Encriptador.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_Encriptador.TabIndex = 12
        Me.Lbl_Encriptador.Text = "Encriptador:"
        '
        'btn_RutaNueva
        '
        Me.btn_RutaNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RutaNueva.Location = New System.Drawing.Point(540, 121)
        Me.btn_RutaNueva.Name = "btn_RutaNueva"
        Me.btn_RutaNueva.Size = New System.Drawing.Size(32, 22)
        Me.btn_RutaNueva.TabIndex = 11
        Me.btn_RutaNueva.Text = "..."
        Me.btn_RutaNueva.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_RutaNueva.UseVisualStyleBackColor = True
        '
        'tbx_Destino
        '
        Me.tbx_Destino.BackColor = System.Drawing.Color.White
        Me.tbx_Destino.Location = New System.Drawing.Point(110, 121)
        Me.tbx_Destino.Name = "tbx_Destino"
        Me.tbx_Destino.ReadOnly = True
        Me.tbx_Destino.Size = New System.Drawing.Size(425, 20)
        Me.tbx_Destino.TabIndex = 10
        '
        'Lbl_UbicacionDestino
        '
        Me.Lbl_UbicacionDestino.AutoSize = True
        Me.Lbl_UbicacionDestino.Location = New System.Drawing.Point(6, 124)
        Me.Lbl_UbicacionDestino.Name = "Lbl_UbicacionDestino"
        Me.Lbl_UbicacionDestino.Size = New System.Drawing.Size(97, 13)
        Me.Lbl_UbicacionDestino.TabIndex = 9
        Me.Lbl_UbicacionDestino.Text = "Ubicación Destino:"
        '
        'tbx_Consecutivo
        '
        Me.tbx_Consecutivo.Location = New System.Drawing.Point(109, 71)
        Me.tbx_Consecutivo.MaxLength = 2
        Me.tbx_Consecutivo.Name = "tbx_Consecutivo"
        Me.tbx_Consecutivo.Size = New System.Drawing.Size(45, 20)
        Me.tbx_Consecutivo.TabIndex = 8
        '
        'Lbl_Consecutivo
        '
        Me.Lbl_Consecutivo.AutoSize = True
        Me.Lbl_Consecutivo.Location = New System.Drawing.Point(37, 74)
        Me.Lbl_Consecutivo.Name = "Lbl_Consecutivo"
        Me.Lbl_Consecutivo.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_Consecutivo.TabIndex = 7
        Me.Lbl_Consecutivo.Text = "Consecutivo"
        '
        'tbx_NombreNuevo
        '
        Me.tbx_NombreNuevo.BackColor = System.Drawing.Color.White
        Me.tbx_NombreNuevo.Location = New System.Drawing.Point(109, 45)
        Me.tbx_NombreNuevo.Name = "tbx_NombreNuevo"
        Me.tbx_NombreNuevo.ReadOnly = True
        Me.tbx_NombreNuevo.Size = New System.Drawing.Size(131, 20)
        Me.tbx_NombreNuevo.TabIndex = 4
        '
        'Lbl_NombreNuevo
        '
        Me.Lbl_NombreNuevo.AutoSize = True
        Me.Lbl_NombreNuevo.Location = New System.Drawing.Point(24, 50)
        Me.Lbl_NombreNuevo.Name = "Lbl_NombreNuevo"
        Me.Lbl_NombreNuevo.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_NombreNuevo.TabIndex = 3
        Me.Lbl_NombreNuevo.Text = "Nombre Nuevo"
        '
        'btn_Ruta
        '
        Me.btn_Ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ruta.Location = New System.Drawing.Point(540, 17)
        Me.btn_Ruta.Name = "btn_Ruta"
        Me.btn_Ruta.Size = New System.Drawing.Size(32, 22)
        Me.btn_Ruta.TabIndex = 2
        Me.btn_Ruta.Text = "..."
        Me.btn_Ruta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Ruta.UseVisualStyleBackColor = True
        '
        'txt_Archivo
        '
        Me.txt_Archivo.BackColor = System.Drawing.Color.White
        Me.txt_Archivo.Location = New System.Drawing.Point(109, 19)
        Me.txt_Archivo.Name = "txt_Archivo"
        Me.txt_Archivo.ReadOnly = True
        Me.txt_Archivo.Size = New System.Drawing.Size(425, 20)
        Me.txt_Archivo.TabIndex = 1
        '
        'lbl_Ruta
        '
        Me.lbl_Ruta.AutoSize = True
        Me.lbl_Ruta.Location = New System.Drawing.Point(311, 48)
        Me.lbl_Ruta.Name = "lbl_Ruta"
        Me.lbl_Ruta.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Ruta.TabIndex = 6
        Me.lbl_Ruta.Text = "lbl_Ruta"
        Me.lbl_Ruta.Visible = False
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(252, 48)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Fecha.TabIndex = 5
        Me.lbl_Fecha.Text = "lbl_Fecha"
        Me.lbl_Fecha.Visible = False
        '
        'lbl_Archivo
        '
        Me.lbl_Archivo.AutoSize = True
        Me.lbl_Archivo.Location = New System.Drawing.Point(60, 23)
        Me.lbl_Archivo.Name = "lbl_Archivo"
        Me.lbl_Archivo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Archivo.TabIndex = 0
        Me.lbl_Archivo.Text = "Archivo"
        '
        'dlg_Archivo
        '
        Me.dlg_Archivo.FileName = "OpenFileDialog1"
        '
        'gbx_Botones2
        '
        Me.gbx_Botones2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones2.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones2.Location = New System.Drawing.Point(6, 543)
        Me.gbx_Botones2.Name = "gbx_Botones2"
        Me.gbx_Botones2.Size = New System.Drawing.Size(771, 50)
        Me.gbx_Botones2.TabIndex = 1
        Me.gbx_Botones2.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Proceso.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(625, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_ExtraerCheques
        '
        Me.Btn_ExtraerCheques.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_ExtraerCheques.Enabled = False
        Me.Btn_ExtraerCheques.Image = CType(resources.GetObject("Btn_ExtraerCheques.Image"), System.Drawing.Image)
        Me.Btn_ExtraerCheques.Location = New System.Drawing.Point(10, 454)
        Me.Btn_ExtraerCheques.Name = "Btn_ExtraerCheques"
        Me.Btn_ExtraerCheques.Size = New System.Drawing.Size(126, 30)
        Me.Btn_ExtraerCheques.TabIndex = 10
        Me.Btn_ExtraerCheques.Text = "Extraer Imágenes"
        Me.Btn_ExtraerCheques.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ExtraerCheques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_ExtraerCheques.UseVisualStyleBackColor = True
        '
        'btn_Encriptar
        '
        Me.btn_Encriptar.Enabled = False
        Me.btn_Encriptar.Image = CType(resources.GetObject("btn_Encriptar.Image"), System.Drawing.Image)
        Me.btn_Encriptar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Encriptar.Name = "btn_Encriptar"
        Me.btn_Encriptar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Encriptar.TabIndex = 0
        Me.btn_Encriptar.Text = "Encriptar"
        Me.btn_Encriptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Encriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Encriptar.UseVisualStyleBackColor = True
        '
        'Tab_Principal
        '
        Me.Tab_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Principal.Controls.Add(Me.Tab_Encriptar)
        Me.Tab_Principal.Controls.Add(Me.Tab_Cheques)
        Me.Tab_Principal.Location = New System.Drawing.Point(6, 6)
        Me.Tab_Principal.Name = "Tab_Principal"
        Me.Tab_Principal.SelectedIndex = 0
        Me.Tab_Principal.Size = New System.Drawing.Size(771, 531)
        Me.Tab_Principal.TabIndex = 0
        '
        'Tab_Encriptar
        '
        Me.Tab_Encriptar.Controls.Add(Me.Gbx_Botones1)
        Me.Tab_Encriptar.Controls.Add(Me.gbx_Filtro)
        Me.Tab_Encriptar.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Encriptar.Name = "Tab_Encriptar"
        Me.Tab_Encriptar.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Encriptar.Size = New System.Drawing.Size(763, 505)
        Me.Tab_Encriptar.TabIndex = 0
        Me.Tab_Encriptar.Text = "Encriptar"
        Me.Tab_Encriptar.UseVisualStyleBackColor = True
        '
        'Gbx_Botones1
        '
        Me.Gbx_Botones1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones1.Controls.Add(Me.btn_Encriptar)
        Me.Gbx_Botones1.Location = New System.Drawing.Point(10, 195)
        Me.Gbx_Botones1.Name = "Gbx_Botones1"
        Me.Gbx_Botones1.Size = New System.Drawing.Size(694, 50)
        Me.Gbx_Botones1.TabIndex = 1
        Me.Gbx_Botones1.TabStop = False
        '
        'Tab_Cheques
        '
        Me.Tab_Cheques.Controls.Add(Me.gbx_Cheques)
        Me.Tab_Cheques.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Cheques.Name = "Tab_Cheques"
        Me.Tab_Cheques.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Cheques.Size = New System.Drawing.Size(763, 505)
        Me.Tab_Cheques.TabIndex = 1
        Me.Tab_Cheques.Text = "Extraer Cheques"
        Me.Tab_Cheques.UseVisualStyleBackColor = True
        '
        'gbx_Cheques
        '
        Me.gbx_Cheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Cheques.Controls.Add(Me.btn_RutaArchivoI)
        Me.gbx_Cheques.Controls.Add(Me.tbx_ArchivoI)
        Me.gbx_Cheques.Controls.Add(Me.lbl_UbicacionIB64)
        Me.gbx_Cheques.Controls.Add(Me.btn_GuardaImaB64)
        Me.gbx_Cheques.Controls.Add(Me.Gbx)
        Me.gbx_Cheques.Controls.Add(Me.lbl_Zoom)
        Me.gbx_Cheques.Controls.Add(Me.tbx_Importe)
        Me.gbx_Cheques.Controls.Add(Me.Lbl_Importe)
        Me.gbx_Cheques.Controls.Add(Me.pct_Back)
        Me.gbx_Cheques.Controls.Add(Me.pct_Front)
        Me.gbx_Cheques.Controls.Add(Me.Btn_ExtraerCheques)
        Me.gbx_Cheques.Controls.Add(Me.lsv_Cheques)
        Me.gbx_Cheques.Controls.Add(Me.btn_DestinoCheques)
        Me.gbx_Cheques.Controls.Add(Me.tbx_DestinoCheques)
        Me.gbx_Cheques.Controls.Add(Me.lbl_Rojo)
        Me.gbx_Cheques.Controls.Add(Me.Lbl_UbicacionDes)
        Me.gbx_Cheques.Controls.Add(Me.btn_RutaArchivos)
        Me.gbx_Cheques.Controls.Add(Me.tbx_ArchivoCheques)
        Me.gbx_Cheques.Controls.Add(Me.Lbl_SeleccionarArch)
        Me.gbx_Cheques.Location = New System.Drawing.Point(6, 9)
        Me.gbx_Cheques.Name = "gbx_Cheques"
        Me.gbx_Cheques.Size = New System.Drawing.Size(751, 490)
        Me.gbx_Cheques.TabIndex = 0
        Me.gbx_Cheques.TabStop = False
        '
        'btn_RutaArchivoI
        '
        Me.btn_RutaArchivoI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RutaArchivoI.Location = New System.Drawing.Point(540, 65)
        Me.btn_RutaArchivoI.Name = "btn_RutaArchivoI"
        Me.btn_RutaArchivoI.Size = New System.Drawing.Size(32, 22)
        Me.btn_RutaArchivoI.TabIndex = 47
        Me.btn_RutaArchivoI.Text = "..."
        Me.btn_RutaArchivoI.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_RutaArchivoI.UseVisualStyleBackColor = True
        '
        'tbx_ArchivoI
        '
        Me.tbx_ArchivoI.BackColor = System.Drawing.Color.White
        Me.tbx_ArchivoI.Location = New System.Drawing.Point(119, 67)
        Me.tbx_ArchivoI.Name = "tbx_ArchivoI"
        Me.tbx_ArchivoI.ReadOnly = True
        Me.tbx_ArchivoI.Size = New System.Drawing.Size(415, 20)
        Me.tbx_ArchivoI.TabIndex = 46
        '
        'lbl_UbicacionIB64
        '
        Me.lbl_UbicacionIB64.AutoSize = True
        Me.lbl_UbicacionIB64.Location = New System.Drawing.Point(23, 70)
        Me.lbl_UbicacionIB64.Name = "lbl_UbicacionIB64"
        Me.lbl_UbicacionIB64.Size = New System.Drawing.Size(91, 13)
        Me.lbl_UbicacionIB64.TabIndex = 45
        Me.lbl_UbicacionIB64.Text = "UbicacionImgB64"
        '
        'btn_GuardaImaB64
        '
        Me.btn_GuardaImaB64.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardaImaB64.Enabled = False
        Me.btn_GuardaImaB64.Image = CType(resources.GetObject("btn_GuardaImaB64.Image"), System.Drawing.Image)
        Me.btn_GuardaImaB64.Location = New System.Drawing.Point(143, 454)
        Me.btn_GuardaImaB64.Name = "btn_GuardaImaB64"
        Me.btn_GuardaImaB64.Size = New System.Drawing.Size(126, 30)
        Me.btn_GuardaImaB64.TabIndex = 44
        Me.btn_GuardaImaB64.Text = "Guardar ImgB64"
        Me.btn_GuardaImaB64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardaImaB64.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardaImaB64.UseVisualStyleBackColor = True
        '
        'Gbx
        '
        Me.Gbx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Gbx.Controls.Add(Me.rdb_Back)
        Me.Gbx.Controls.Add(Me.rdb_Ambas)
        Me.Gbx.Controls.Add(Me.rdb_Frente)
        Me.Gbx.Location = New System.Drawing.Point(10, 371)
        Me.Gbx.Name = "Gbx"
        Me.Gbx.Size = New System.Drawing.Size(177, 77)
        Me.Gbx.TabIndex = 39
        Me.Gbx.TabStop = False
        '
        'rdb_Back
        '
        Me.rdb_Back.AutoSize = True
        Me.rdb_Back.Location = New System.Drawing.Point(11, 31)
        Me.rdb_Back.Name = "rdb_Back"
        Me.rdb_Back.Size = New System.Drawing.Size(121, 17)
        Me.rdb_Back.TabIndex = 37
        Me.rdb_Back.TabStop = True
        Me.rdb_Back.Text = "Extraer Solo Endoso"
        Me.rdb_Back.UseVisualStyleBackColor = True
        '
        'rdb_Ambas
        '
        Me.rdb_Ambas.AutoSize = True
        Me.rdb_Ambas.Location = New System.Drawing.Point(11, 50)
        Me.rdb_Ambas.Name = "rdb_Ambas"
        Me.rdb_Ambas.Size = New System.Drawing.Size(142, 17)
        Me.rdb_Ambas.TabIndex = 38
        Me.rdb_Ambas.TabStop = True
        Me.rdb_Ambas.Text = "Extraer Ambas Imagenes"
        Me.rdb_Ambas.UseVisualStyleBackColor = True
        '
        'rdb_Frente
        '
        Me.rdb_Frente.AutoSize = True
        Me.rdb_Frente.Location = New System.Drawing.Point(11, 12)
        Me.rdb_Frente.Name = "rdb_Frente"
        Me.rdb_Frente.Size = New System.Drawing.Size(115, 17)
        Me.rdb_Frente.TabIndex = 36
        Me.rdb_Frente.TabStop = True
        Me.rdb_Frente.Text = "Extraer Solo Frente"
        Me.rdb_Frente.UseVisualStyleBackColor = True
        '
        'lbl_Zoom
        '
        Me.lbl_Zoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Zoom.AutoSize = True
        Me.lbl_Zoom.Location = New System.Drawing.Point(488, 97)
        Me.lbl_Zoom.Name = "lbl_Zoom"
        Me.lbl_Zoom.Size = New System.Drawing.Size(257, 13)
        Me.lbl_Zoom.TabIndex = 35
        Me.lbl_Zoom.Text = "Coloque el Mouse sobre la Imagen para hacer Zoom."
        Me.lbl_Zoom.Visible = False
        '
        'tbx_Importe
        '
        Me.tbx_Importe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Importe.Enabled = False
        Me.tbx_Importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Importe.Location = New System.Drawing.Point(164, 344)
        Me.tbx_Importe.Name = "tbx_Importe"
        Me.tbx_Importe.Size = New System.Drawing.Size(105, 21)
        Me.tbx_Importe.TabIndex = 9
        Me.tbx_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl_Importe
        '
        Me.Lbl_Importe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Importe.AutoSize = True
        Me.Lbl_Importe.Location = New System.Drawing.Point(89, 348)
        Me.Lbl_Importe.Name = "Lbl_Importe"
        Me.Lbl_Importe.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_Importe.TabIndex = 8
        Me.Lbl_Importe.Text = "Importe Total"
        '
        'pct_Back
        '
        Me.pct_Back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_Back.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Back.Location = New System.Drawing.Point(275, 299)
        Me.pct_Back.Name = "pct_Back"
        Me.pct_Back.Size = New System.Drawing.Size(470, 180)
        Me.pct_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Back.TabIndex = 34
        Me.pct_Back.TabStop = False
        '
        'pct_Front
        '
        Me.pct_Front.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_Front.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Front.Location = New System.Drawing.Point(275, 113)
        Me.pct_Front.Name = "pct_Front"
        Me.pct_Front.Size = New System.Drawing.Size(470, 180)
        Me.pct_Front.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Front.TabIndex = 33
        Me.pct_Front.TabStop = False
        '
        'lsv_Cheques
        '
        Me.lsv_Cheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cheques.FullRowSelect = True
        Me.lsv_Cheques.HideSelection = False
        Me.lsv_Cheques.Location = New System.Drawing.Point(10, 113)
        Me.lsv_Cheques.MultiSelect = False
        Me.lsv_Cheques.Name = "lsv_Cheques"
        Me.lsv_Cheques.Size = New System.Drawing.Size(259, 209)
        Me.lsv_Cheques.TabIndex = 7
        Me.lsv_Cheques.UseCompatibleStateImageBehavior = False
        Me.lsv_Cheques.View = System.Windows.Forms.View.Details
        '
        'btn_DestinoCheques
        '
        Me.btn_DestinoCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DestinoCheques.Location = New System.Drawing.Point(540, 41)
        Me.btn_DestinoCheques.Name = "btn_DestinoCheques"
        Me.btn_DestinoCheques.Size = New System.Drawing.Size(32, 22)
        Me.btn_DestinoCheques.TabIndex = 5
        Me.btn_DestinoCheques.Text = "..."
        Me.btn_DestinoCheques.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_DestinoCheques.UseVisualStyleBackColor = True
        '
        'tbx_DestinoCheques
        '
        Me.tbx_DestinoCheques.BackColor = System.Drawing.Color.White
        Me.tbx_DestinoCheques.Location = New System.Drawing.Point(120, 41)
        Me.tbx_DestinoCheques.Name = "tbx_DestinoCheques"
        Me.tbx_DestinoCheques.ReadOnly = True
        Me.tbx_DestinoCheques.Size = New System.Drawing.Size(415, 20)
        Me.tbx_DestinoCheques.TabIndex = 4
        '
        'lbl_Rojo
        '
        Me.lbl_Rojo.AutoSize = True
        Me.lbl_Rojo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Rojo.Location = New System.Drawing.Point(7, 97)
        Me.lbl_Rojo.Name = "lbl_Rojo"
        Me.lbl_Rojo.Size = New System.Drawing.Size(308, 13)
        Me.lbl_Rojo.TabIndex = 6
        Me.lbl_Rojo.Text = "Los cheques no encontrados en el sistema se marcan en ROJO"
        Me.lbl_Rojo.Visible = False
        '
        'Lbl_UbicacionDes
        '
        Me.Lbl_UbicacionDes.AutoSize = True
        Me.Lbl_UbicacionDes.Location = New System.Drawing.Point(20, 44)
        Me.Lbl_UbicacionDes.Name = "Lbl_UbicacionDes"
        Me.Lbl_UbicacionDes.Size = New System.Drawing.Size(94, 13)
        Me.Lbl_UbicacionDes.TabIndex = 3
        Me.Lbl_UbicacionDes.Text = "Ubicación Destino"
        '
        'btn_RutaArchivos
        '
        Me.btn_RutaArchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RutaArchivos.Location = New System.Drawing.Point(540, 13)
        Me.btn_RutaArchivos.Name = "btn_RutaArchivos"
        Me.btn_RutaArchivos.Size = New System.Drawing.Size(32, 22)
        Me.btn_RutaArchivos.TabIndex = 2
        Me.btn_RutaArchivos.Text = "..."
        Me.btn_RutaArchivos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_RutaArchivos.UseVisualStyleBackColor = True
        '
        'tbx_ArchivoCheques
        '
        Me.tbx_ArchivoCheques.BackColor = System.Drawing.Color.White
        Me.tbx_ArchivoCheques.Location = New System.Drawing.Point(120, 15)
        Me.tbx_ArchivoCheques.Name = "tbx_ArchivoCheques"
        Me.tbx_ArchivoCheques.ReadOnly = True
        Me.tbx_ArchivoCheques.Size = New System.Drawing.Size(414, 20)
        Me.tbx_ArchivoCheques.TabIndex = 1
        '
        'Lbl_SeleccionarArch
        '
        Me.Lbl_SeleccionarArch.AutoSize = True
        Me.Lbl_SeleccionarArch.Location = New System.Drawing.Point(7, 19)
        Me.Lbl_SeleccionarArch.Name = "Lbl_SeleccionarArch"
        Me.Lbl_SeleccionarArch.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_SeleccionarArch.TabIndex = 0
        Me.Lbl_SeleccionarArch.Text = "Seleccionar Archivos"
        '
        'frm_TXTadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 598)
        Me.Controls.Add(Me.Tab_Principal)
        Me.Controls.Add(Me.gbx_Botones2)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_TXTadmin"
        Me.Text = "Administración de Archivos de Depósitos."
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Botones2.ResumeLayout(False)
        Me.Tab_Principal.ResumeLayout(False)
        Me.Tab_Encriptar.ResumeLayout(False)
        Me.Gbx_Botones1.ResumeLayout(False)
        Me.Tab_Cheques.ResumeLayout(False)
        Me.gbx_Cheques.ResumeLayout(False)
        Me.gbx_Cheques.PerformLayout()
        Me.Gbx.ResumeLayout(False)
        Me.Gbx.PerformLayout()
        CType(Me.pct_Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Front, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Ruta As System.Windows.Forms.Button
    Friend WithEvents txt_Archivo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Archivo As System.Windows.Forms.Label
    Friend WithEvents dlg_Archivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbx_Botones2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Encriptar As System.Windows.Forms.Button
    Friend WithEvents Btn_ExtraerCheques As System.Windows.Forms.Button
    Friend WithEvents tbx_NombreNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_NombreNuevo As System.Windows.Forms.Label
    Friend WithEvents tbx_Consecutivo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Consecutivo As System.Windows.Forms.Label
    Friend WithEvents btn_RutaNueva As System.Windows.Forms.Button
    Friend WithEvents tbx_Destino As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_UbicacionDestino As System.Windows.Forms.Label
    Friend WithEvents dlg_Destino As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Tab_Principal As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Encriptar As System.Windows.Forms.TabPage
    Friend WithEvents Gbx_Botones1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tab_Cheques As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Cheques As System.Windows.Forms.GroupBox
    Friend WithEvents btn_DestinoCheques As System.Windows.Forms.Button
    Friend WithEvents tbx_DestinoCheques As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_UbicacionDes As System.Windows.Forms.Label
    Friend WithEvents btn_RutaArchivos As System.Windows.Forms.Button
    Friend WithEvents tbx_ArchivoCheques As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_SeleccionarArch As System.Windows.Forms.Label
    Friend WithEvents lsv_Cheques As System.Windows.Forms.ListView
    Friend WithEvents pct_Back As System.Windows.Forms.PictureBox
    Friend WithEvents pct_Front As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Rojo As System.Windows.Forms.Label
    Friend WithEvents tbx_Importe As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents lbl_Zoom As System.Windows.Forms.Label
    Friend WithEvents rdb_Ambas As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Back As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Frente As System.Windows.Forms.RadioButton
    Friend WithEvents Gbx As System.Windows.Forms.GroupBox
    Friend WithEvents btn_RutaEncriptador As System.Windows.Forms.Button
    Friend WithEvents tbx_Encriptador As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Encriptador As System.Windows.Forms.Label
    Friend WithEvents btn_GuardaImaB64 As System.Windows.Forms.Button
    Friend WithEvents btn_RutaArchivoI As System.Windows.Forms.Button
    Friend WithEvents tbx_ArchivoI As System.Windows.Forms.TextBox
    Friend WithEvents lbl_UbicacionIB64 As System.Windows.Forms.Label
End Class
