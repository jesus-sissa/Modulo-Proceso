Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_ConsultaCheques
    Dim TopF, TopR, LeftR, WidthF, WidthR, HeightF, HeightR As Integer
    Dim Corte As Integer = 0
    Dim Generados As Char
    Dim NumeroCheque As String = ""
    Dim MICR_Anterior As String = ""

    Private Sub frm_ConsultaCheques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtp_Desde.Value = DateTime.Now
        dtp_Hasta.Value = DateTime.Now
        lsv_Cheques.Columns.Add("Imagen")
        lsv_Cheques.Columns.Add("Remision")
        lsv_Cheques.Columns.Add("Cliente")
        lsv_Cheques.Columns.Add("BancoCheque")
        lsv_Cheques.Columns.Add("CuentaCheque")
        lsv_Cheques.Columns.Add("ImporteCheque")
        lsv_Cheques.Columns.Add("NumeroCheque")
        lsv_Cheques.Columns.Add("MICR")
        lsv_Cheques.Columns.Add("DigitoSeguro")

        cmb_Desde.ValorParametro = dtp_Desde.Value
        cmb_Desde.Actualizar()

        cmb_Hasta.ValorParametro = dtp_Hasta.Value
        cmb_Hasta.Actualizar()

        cmb_CajaBancaria.Actualizar()

    End Sub

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        ActualizarObjetos()
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        ActualizarObjetos()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        cmb_Desde.ValorParametro = dtp_Desde.Value.Date
        cmb_Desde.Actualizar()
        If cmb_Desde.Items.Count = 2 Then
            cmb_Desde.SelectedIndex = 1
        End If
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        cmb_Hasta.ValorParametro = dtp_Hasta.Value.Date
        cmb_Hasta.Actualizar()
        If cmb_Hasta.Items.Count = 2 Then
            cmb_Hasta.SelectedIndex = 1
        End If
    End Sub

    Private Sub rdb_GeneradosTXT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_GeneradosTXT.CheckedChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        ActualizarObjetos()
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        ActualizarObjetos()
    End Sub

    Private Sub chk_Corte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Corte.CheckedChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        'lsv_Cheques.Items.Clear()
        ActualizarObjetos()
        Corte = 0
        If chk_Corte.Checked Then
            tbx_Corte.Enabled = False
            tbx_Corte.Text = "0"
        Else
            tbx_Corte.Text = "1"
            tbx_Corte.Enabled = True
        End If
    End Sub

    Private Function Validar() As Boolean
        If cmb_Desde.SelectedValue = 0 Then
            Return False
        End If
        If cmb_Hasta.SelectedValue = 0 Then
            Return False
        End If
        If cmb_CajaBancaria.SelectedValue = 0 Then
            Return False
        End If

        Return True
    End Function

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        If cmb_Desde.SelectedValue = 0 Then
            MsgBox("Seleccione la Sesión Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Exit Sub
        End If
        If cmb_Hasta.SelectedValue = 0 Then
            MsgBox("Seleccione la Sesión Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Hasta.Focus()
            Exit Sub
        End If
        If cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Indique la Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If
        If tbx_Corte.Enabled Then
            If tbx_Corte.Text = "0" Or tbx_Corte.Text = "" Then
                MsgBox("Indique el Número de Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Corte.Focus()
                Exit Sub
            End If
        End If
        If Not rdb_GeneradosTXT.Checked And Not rdb_Todos.Checked Then
            MsgBox("Seleccione Generados o Todos.", MsgBoxStyle.Critical, frm_MENU.Text)
            btn_Mostrar.Focus()
            Exit Sub
        Else
            If rdb_GeneradosTXT.Checked Then
                Generados = "S"
            Else
                Generados = "T"
            End If
        End If

        If tbx_Corte.Enabled Then
            Corte = tbx_Corte.Text
        End If

        Call ActualizarObjetos()
        Call LlenarLista()

        'Dim Tbl As DataTable = Cn_Proceso.fn_ConsultaCheques_GetCheques(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_CajaBancaria.SelectedValue, Corte, Generados)
        'If Tbl IsNot Nothing Then
        '    lsv_Cheques.Actualizar(Tbl, "id_cheque")
        '    lsv_Cheques.Columns(5).TextAlign = HorizontalAlignment.Right
        '    lbl_Cantidad.Text = lsv_Cheques.Items.Count & " Cheques Encontrados."
        'Else
        '    lbl_Cantidad.Text = "0 Cheques Encontrados."
        '    MsgBox("Ha ocurrido un error al intentar obtener los cheques")
        'End If
        'pbx_Frente.Image = Nothing
        'pbx_Reverso.Image = Nothing
    End Sub

    Sub ActualizarObjetos()
        lsv_Cheques.Items.Clear()
        btn_Mostrar.Enabled = Validar()
        pbx_Frente.Image = Nothing
        pbx_Reverso.Image = Nothing
        txt_MICR.Clear()
        txt_MICR.Enabled = False
        btn_Guardar.Enabled = False
        MICR_Anterior = ""
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Cheques.Items.Count)
        btn_Exportar.Enabled = False
    End Sub

    Sub LlenarLista()
        btn_Exportar.Enabled = False
        lsv_Cheques.Items.Clear()
        Dim Tbl As DataTable = Cn_Proceso.fn_ConsultaCheques_GetCheques(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_CajaBancaria.SelectedValue, Corte, Generados)
        If Tbl IsNot Nothing Then
            lsv_Cheques.Actualizar(Tbl, "id_cheque")
            lsv_Cheques.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv_Cheques.Columns(6).TextAlign = HorizontalAlignment.Right
            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Cheques.Items.Count)
            btn_Exportar.Enabled = lsv_Cheques.Items.Count > 0
        Else
            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Cheques.Items.Count)
            MsgBox("Ha ocurrido un error al intentar obtener los cheques")
        End If
    End Sub

    Private Sub lsv_Cheques_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cheques.SelectedIndexChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        pbx_Reverso.Visible = True
        pbx_Frente.Visible = True
        If lsv_Cheques.SelectedItems.Count > 0 Then
            Dim row As DataRow = Cn_Proceso.fn_LeerCheque(lsv_Cheques.SelectedItems(0).Tag)

            If row IsNot Nothing Then
                Dim ms1 As MemoryStream = New MemoryStream(row("Front1"), 0, row("Front1").Length)
                ms1.Write(row("Front1"), 0, row("Front1").Length)
                pbx_Frente.Image = Image.FromStream(ms1, True)

                Dim ms2 As MemoryStream = New MemoryStream(row("Back1"), 0, row("Back1").Length)
                ms2.Write(row("Back1"), 0, row("Back1").Length)
                pbx_Reverso.Image = Image.FromStream(ms2, True)
                btn_Guardar.Enabled = False
                txt_MICR.Enabled = False
            Else
                pbx_Frente.Image = Nothing
                pbx_Reverso.Image = Nothing
                btn_Guardar.Enabled = True
                txt_MICR.Enabled = True
                'Tomar los datos solo cuando no haya imagenes porque esta opcion de Modificar MICR
                'es solo para cuando no se puede escanear el cheque.
                MICR_Anterior = lsv_Cheques.SelectedItems(0).SubItems(7).Text
                txt_MICR.Text = MICR_Anterior
            End If
        Else
            pbx_Frente.Image = Nothing
            pbx_Reverso.Image = Nothing
            btn_Guardar.Enabled = False
            txt_MICR.Enabled = False
            txt_MICR.Clear()
        End If
    End Sub

    Private Sub pbx_Frente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Frente.MouseHover
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        pbx_Frente.Cursor = Cursors.Hand
    End Sub

    Private Sub pbx_Reverso_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Reverso.MouseHover
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        pbx_Reverso.Cursor = Cursors.Hand
    End Sub

    Private Sub lsv_Cheques_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cheques.MouseHover
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        'buscar en el listview
        Dim Fila_Inicial As Integer = 0
        If lsv_Cheques.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Cheques.SelectedItems(0).Index
        FuncionesGlobales.fn_Buscar_enListView(lsv_Cheques, tbx_Buscar.Text.Trim, 8, Fila_Inicial)
    End Sub

    Private Sub pbx_Frente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Frente.Click
        Dim frm As New frm_VisorImagenes
        frm.pct_Imagen.BackColor = Color.Brown
        frm.Imagen = pbx_Frente.Image
        frm.ShowDialog()
    End Sub

    Private Sub pbx_Reverso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Reverso.Click
        Dim frm As New frm_VisorImagenes
        frm.pct_Imagen.BackColor = Color.Brown
        frm.Imagen = pbx_Reverso.Image
        frm.ShowDialog()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        If txt_MICR.Text.Length < 34 Then
            MsgBox("Lectura Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            txt_MICR.SelectAll()
            txt_MICR.Focus()
            Exit Sub
        End If

        If txt_MICR.Text.Trim = MICR_Anterior Then
            MsgBox("No ha hecho cambios en la Banda Magnética.", MsgBoxStyle.Information, frm_MENU.Text)
            txt_MICR.Focus()
            Exit Sub
        End If

        If Not Modulo_Proceso.FuncionesGlobales.ValidaMICR(txt_MICR.Text) Then Exit Sub
        NumeroCheque = Microsoft.VisualBasic.Right(txt_MICR.Text, 7)

        'Actualizar en Pro_FichasCheques
        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()
        If Not frm.Firma Then Exit Sub
        If Not Modulo_Proceso.Cn_Proceso.fn_ConsultaCheques_ActualizarNumero(lsv_Cheques.SelectedItems(0).Tag, txt_MICR.Text, NumeroCheque) Then
            MsgBox("Ha ocurrido un error al intentar actualizar los datos del Cheque.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim Descripcion As String = "CORRECCION DE MICR: " & MICR_Anterior & " > " & txt_MICR.Text

        'INSERTAR EN BITACORA
        Modulo_Proceso.FuncionesGlobales.fn_GuardaBitacora(33, Descripcion)

        'INSERTAR EN EL LOG
        Cn_Login.fn_Log_Create(Descripcion)

        MsgBox("La modificación se ha realizado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

        ActualizarObjetos()
        LlenarLista()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Cheques, 2, "Consulta de Cheques", 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Imagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imagenes.Click
        Dim Ruta As String = ""
        Dim ImagenesExtraidas As Integer = 0
        Dim ChequesMarcados As Integer = 0
        Dim ChequesExtraidos As Integer = 0
        Dim RespuestaFuncion As Integer = 0
        SegundosDesconexion = 0
        If lsv_Cheques.CheckedItems.Count = 0 Then
            MsgBox("Debe marcar los cheques que desea extraer.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        If Not fbd_Imagenes.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Ruta = fbd_Imagenes.SelectedPath
        End If

        If Ruta = "" Then
            MsgBox("Debe seleccionar una carpeta para extrar las Imágenes.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        ChequesMarcados = lsv_Cheques.CheckedItems.Count
        For Each elemento As ListViewItem In lsv_Cheques.CheckedItems

            RespuestaFuncion = fn_LeerCheque(elemento.Tag, Ruta & "\" & elemento.SubItems(7).Text)
            If RespuestaFuncion > 0 Then
                ImagenesExtraidas += RespuestaFuncion
                ChequesExtraidos += 1
            End If
        Next
        MsgBox("En total se extrajeron " & ImagenesExtraidas.ToString & " Imágenes correspondientes a " & ChequesExtraidos & " Cheques. En la Carpeta " & Ruta, MsgBoxStyle.Information, frm_MENU.Text)
    End Sub

    Private Function fn_LeerCheque(ByVal Id_Cheque As Long, ByVal Path As String) As Integer
        Dim Cantidad As Integer = 0
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasChequesI_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_Cheque", SqlDbType.BigInt, Id_Cheque)

        'Leer de SQL
        Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

        If dt.Rows.Count > 0 Then
            'Aqui se obtiene la imagen frontal

            Dim ms1 As MemoryStream = New MemoryStream(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
            ms1.Write(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
            Image.FromStream(ms1, True).Save(Path & "_F.tif", ImageFormat.Tiff)
            Cantidad += 1

            'Aqui se obtiene la imagen trasera
            Dim ms2 As MemoryStream = New MemoryStream(dt.Rows(0)("Back1"), 0, dt.Rows(0)("Back1").Length)
            ms2.Write(dt.Rows(0)("Back1"), 0, dt.Rows(0)("Back1").Length)
            Image.FromStream(ms2, True).Save(Path & "_B.tif", ImageFormat.Tiff)
            Cantidad += 1

            Return Cantidad
        Else
            Return 0
        End If
    End Function

End Class