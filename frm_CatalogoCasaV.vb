
Public Class frm_CatalogoCasaV
    Private Sub frm_CatalogoCasaV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_status.AgregarItem("A", "ACTIVOS")
        cmb_status.AgregarItem("B", "BAJAS")
        cmb_status.SelectedValue = "A"

        lsv_catalogo.Columns.Add("Nombre")
        lsv_catalogo.Columns.Add("Estatus")
        Call Llenar_Lista()

        lbl_Registros.Text = "Registros: " & lsv_catalogo.Items.Count
        btn_Exportar.Enabled = lsv_catalogo.Items.Count > 0
    End Sub

    Private Sub Llenar_Lista()
        lsv_catalogo.Items.Clear()

        Cn_Proceso.fn_Llenar_listaCasasValeras(lsv_catalogo, cmb_status.SelectedValue)
        lbl_Registros.Text = "Registros: " & lsv_catalogo.Items.Count
    End Sub

    Private Sub chk_tieneCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tieneCB.CheckedChanged
        gbx_codigoBarras.Enabled = chk_tieneCB.Checked
    End Sub

    Private Sub chk_tieneBM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tieneBM.CheckedChanged
        gbx_BandaMagnetica.Enabled = chk_tieneBM.Checked
    End Sub

    Private Sub LimpiarTexboxMicr()
        chk_tieneBM.Checked = False
        tbx_longitudMicr.Text = String.Empty
        tbx_inicioImporteMicr.Text = String.Empty
        tbx_finImporteMicr.Text = String.Empty
        tbx_inicioNumeroMicr.Text = String.Empty
        tbx_finNumeroMicr.Text = String.Empty
    End Sub

    Private Sub LimpiarTexboxCodigoBarras()
        chk_tieneCB.Checked = False
        tbx_longitudCB.Text = String.Empty
        tbx_inicioImporteCB.Text = String.Empty
        tbx_finImporteCB.Text = String.Empty
        tbx_inicioNumeroCB.Text = String.Empty
        tbx_finNumeroCB.Text = String.Empty
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        'validar campos
        Dim TieneMicr As Char = "N"
        Dim TieneCB As Char = "N"
        If chk_tieneBM.Checked Then TieneMicr = "S"
        If chk_tieneCB.Checked Then TieneCB = "S"

        If tbx_NombreCasa.Text.Trim = "" Then
            MsgBox("Capture el nombre de la casa valera.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreCasa.Focus()
            Exit Sub
        End If

        If Not chk_tieneBM.Checked And Not chk_tieneCB.Checked Then
            MsgBox("Debe seleccionar si tiene banda magnetica o codigo de barras o las dos. ", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If chk_tieneBM.Checked = False Then
            tbx_longitudMicr.Text = 0
            tbx_inicioImporteMicr.Text = 0
            tbx_finImporteMicr.Text = 0
            tbx_inicioNumeroMicr.Text = 0
            tbx_finNumeroMicr.Text = 0
        Else
            If tbx_longitudMicr.Text = "" OrElse tbx_longitudMicr.Text = 0 Then
                MsgBox("capture la longitud de la banda magnetica. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_longitudMicr.Focus()
                Exit Sub
            End If
            If tbx_inicioImporteMicr.Text = "" OrElse tbx_inicioImporteMicr.Text = 0 Then
                MsgBox("capture inicio importe de la banda magnetica. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioImporteMicr.Focus()
                Exit Sub
            End If
            If tbx_finImporteMicr.Text = "" OrElse tbx_finImporteMicr.Text = 0 Then
                MsgBox("capture fin importe de la banda magnetica. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_finImporteMicr.Focus()
                Exit Sub
            End If
            If tbx_inicioNumeroMicr.Text = "" OrElse tbx_inicioNumeroMicr.Text = 0 Then
                MsgBox("capture inicio de numero de la banda magnetica. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioNumeroMicr.Focus()
                Exit Sub
            End If
            If tbx_inicioNumeroMicr.Text = "" OrElse tbx_finNumeroMicr.Text = 0 Then
                MsgBox("capture fin de numero de la banda magnetica. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_finNumeroMicr.Focus()
                Exit Sub
            End If

            If CInt(tbx_inicioImporteMicr.Text) >= CInt(tbx_finImporteMicr.Text) Then
                MsgBox("El importe inicio de banda magnetica debe ser menor que el importe fin.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioImporteMicr.Focus()
                Exit Sub
            End If
            If CInt(tbx_inicioNumeroMicr.Text) >= CInt(tbx_finNumeroMicr.Text) Then
                MsgBox("El inicio numero de banda magnetica debe ser menor que el numero fin.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioNumeroMicr.Focus()
                Exit Sub
            End If

        End If

        If chk_tieneCB.Checked = False Then
            tbx_longitudCB.Text = 0
            tbx_inicioImporteCB.Text = 0
            tbx_finImporteCB.Text = 0
            tbx_inicioNumeroCB.Text = 0
            tbx_finNumeroCB.Text = 0
        Else
            If tbx_longitudCB.Text = "" OrElse tbx_longitudCB.Text = 0 Then
                MsgBox("capture la longitud del código de barras. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_longitudCB.Focus()
                Exit Sub
            End If
            If tbx_inicioImporteCB.Text = "" OrElse tbx_inicioImporteCB.Text = 0 Then
                MsgBox("capture incio de importe del código de barras. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioImporteCB.Focus()
                Exit Sub
            End If
            If tbx_finImporteCB.Text = "" OrElse tbx_finImporteCB.Text = 0 Then
                MsgBox("capture fin de importe del código de barras. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_finImporteCB.Focus()
                Exit Sub
            End If
            If tbx_inicioNumeroCB.Text = "" OrElse tbx_inicioNumeroCB.Text = 0 Then
                MsgBox("capture inicio de numero del código de barras. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioNumeroCB.Focus()
                Exit Sub
            End If
            If tbx_finNumeroCB.Text = "" OrElse tbx_finNumeroCB.Text = 0 Then
                MsgBox("capture fin de numero del código de barras. ", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_finNumeroCB.Focus()
                Exit Sub
            End If

            If CInt(tbx_inicioImporteCB.Text) >= CInt(tbx_finImporteCB.Text) Then
                MsgBox("El importe inicio de codigo de barras debe ser menor que el importe fin de codigo de barras.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioImporteCB.Focus()
                Exit Sub
            End If
            If CInt(tbx_inicioNumeroCB.Text) >= CInt(tbx_finNumeroCB.Text) Then
                MsgBox("El inicio numero de codigo de barras debe ser menor que el numero fin de codigo de barras.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_inicioNumeroCB.Focus()
                Exit Sub
            End If

        End If
        'falta ver si ya existe la casa valera
        If tab_nuevo.Text = "Modificar" Then
            If lbl_nombreCasa.Tag <> tbx_NombreCasa.Text Then
                If Cn_Proceso.fn_Verifcar_ExisteCasaValera(tbx_NombreCasa.Text) Then
                    MsgBox("ya existe el nombre de esa casa valera, capture otra.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_NombreCasa.Focus()
                    Exit Sub
                End If
            End If
        Else
            If Cn_Proceso.fn_Verifcar_ExisteCasaValera(tbx_NombreCasa.Text) Then
                MsgBox("ya existe el nombre de esa casa valera, capture otra.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_NombreCasa.Focus()
                Exit Sub
            End If
        End If

        If tab_nuevo.Text = "Nuevo" Then
            If Cn_Proceso.fn_Guardar_CasaValera(tbx_NombreCasa.Text, TieneMicr, tbx_longitudMicr.Text, tbx_inicioImporteMicr.Text, _
                                            tbx_finImporteMicr.Text, tbx_inicioNumeroMicr.Text, tbx_finNumeroMicr.Text, TieneCB, _
                                            tbx_longitudCB.Text, tbx_inicioImporteCB.Text, tbx_finImporteCB.Text, tbx_inicioNumeroCB.Text, _
                                            tbx_finNumeroCB.Text) Then
                MsgBox("Datos guardados correctamente. ", MsgBoxStyle.Information, frm_MENU.Text)
                Call LimpiarTexboxCodigoBarras()
                Call LimpiarTexboxMicr()
                tbx_NombreCasa.Text = String.Empty
                lbl_nombreCasa.Tag = Nothing
                tbx_NombreCasa.Focus()
                Call Llenar_Lista()
            Else
                MsgBox("Ocurrió un error al guardar en la base de datos", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

        Else
            'si es 'Modificar'
            If Cn_Proceso.fn_Actualizar_CasaValera(tbx_NombreCasa.Tag, tbx_NombreCasa.Text, TieneMicr, tbx_longitudMicr.Text, tbx_inicioImporteMicr.Text, _
                                           tbx_finImporteMicr.Text, tbx_inicioNumeroMicr.Text, tbx_finNumeroMicr.Text, TieneCB, _
                                           tbx_longitudCB.Text, tbx_inicioImporteCB.Text, tbx_finImporteCB.Text, tbx_inicioNumeroCB.Text, _
                                           tbx_finNumeroCB.Text) Then
                MsgBox("Datos actualizados correctamente. ", MsgBoxStyle.Information, frm_MENU.Text)
                Call Llenar_Lista()
                Tab_catalogo.SelectedIndex = 0
            Else
                MsgBox("Ocurrió un error al actualizar el registro en la base de datos", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

        End If
    End Sub

    Private Sub lsv_catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_modificar.Enabled = lsv_catalogo.SelectedItems.Count > 0
        btn_bajaReing.Enabled = lsv_catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        Tab_catalogo.SelectedIndex = 0
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_catalogo, 2, "Catálogo de Casas Valeras", 0, 0, frm_MENU.prg_Barra)

    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        SegundosDesconexion = 0

        'cargar los datos del lsv a los texbox
        Tab_catalogo.SelectedIndex = 1
        tab_nuevo.Text = "Modificar"

        With lsv_catalogo.SelectedItems(0)
            tbx_NombreCasa.Tag = .Tag
            lbl_nombreCasa.Tag = .SubItems(0).Text

            tbx_NombreCasa.Text = .SubItems(0).Text
            chk_tieneBM.Checked = .SubItems(1).Text = "S"

            tbx_longitudMicr.Text = .SubItems(2).Text
            tbx_inicioImporteMicr.Text = .SubItems(3).Text
            tbx_finImporteMicr.Text = .SubItems(4).Text
            tbx_inicioNumeroMicr.Text = .SubItems(5).Text
            tbx_finNumeroMicr.Text = .SubItems(6).Text

            chk_tieneCB.Checked = .SubItems(7).Text = "S"
            tbx_longitudCB.Text = .SubItems(8).Text
            tbx_inicioImporteCB.Text = .SubItems(9).Text
            tbx_finImporteCB.Text = .SubItems(10).Text
            tbx_inicioNumeroCB.Text = .SubItems(11).Text
            tbx_finNumeroCB.Text = .SubItems(12).Text

        End With

    End Sub

    Private Sub lsv_catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_catalogo.DoubleClick
        SegundosDesconexion = 0

        If lsv_catalogo.SelectedItems.Count > 0 Then
            btn_modificar_Click(btn_modificar, New EventArgs)
        End If
    End Sub

    Private Sub Tab_catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_catalogo.SelectedIndexChanged
        If Tab_catalogo.SelectedIndex = 0 Then
            tab_nuevo.Text = "Nuevo"
            Call LimpiarTexboxCodigoBarras()
            Call LimpiarTexboxMicr()
            tbx_NombreCasa.Text = String.Empty
            lsv_catalogo.Items.Clear()
            lbl_nombreCasa.Tag = Nothing
        Else
            tbx_NombreCasa.Focus()
        End If

    End Sub

    Private Sub btn_bajaReing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bajaReing.Click
        SegundosDesconexion = 0
        Dim status As Char = "A"

        If lsv_catalogo.SelectedItems(0).SubItems(13).Text = "A" Then
            status = "B"
        End If

        If Cn_Proceso.fn_CambiaStatus_casaValera(lsv_catalogo.SelectedItems(0).Tag, status) Then
            Call Llenar_Lista()
        End If

        btn_modificar.Enabled = lsv_catalogo.SelectedItems.Count > 0
        btn_bajaReing.Enabled = lsv_catalogo.SelectedItems.Count > 0
        btn_Exportar.Enabled = lsv_catalogo.Items.Count > 0
    End Sub

    Private Sub cmb_status_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_status.SelectedValueChanged
        If cmb_status.SelectedValue <> "0" Then
            Cn_Proceso.fn_Llenar_listaCasasValeras(lsv_catalogo, cmb_status.SelectedValue)
            lbl_Registros.Text = "Registros: " & lsv_catalogo.Items.Count
            btn_modificar.Enabled = lsv_catalogo.SelectedItems.Count > 0
            btn_bajaReing.Enabled = lsv_catalogo.SelectedItems.Count > 0
            btn_Exportar.Enabled = lsv_catalogo.Items.Count > 0
        End If

    End Sub

    Private Sub cmb_status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_status.SelectedIndexChanged

    End Sub
End Class