Imports Modulo_Proceso.Cn_Proceso
Imports System.IO
Public Class frm_ReimprimirCorte

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Imprimir.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Eliminar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Extraer.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(Chr(Keys.Tab))
            e.Handled = True
        End If
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        If cmb_Desde.SelectedValue > cmb_Hasta.SelectedValue And Not cmb_Desde.SelectedValue = "0" And Not cmb_Hasta.SelectedValue = "0" Then
            cmb_Hasta.SelectedValue = cmb_Desde.SelectedValue
        End If
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Dim frm As New frm_Reporte
            frm.crv.ReportSource = fn_GuardarArchivo_GenerarReporte(lsv_Catalogo.SelectedItems(0).Tag, lsv_Catalogo.SelectedItems(0).SubItems(3).Text)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub frm_ReimprimirCorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Moneda.Actualizar()
        cmb_CajaBancaria.Actualizar()

        'cmb_Cajero.AgregaParametro("@Id_Puesto", FuncionesGlobales.fn_ParametrosGlobales(FuncionesGlobales.ParametrosGlobales.Puesto_Cajero), 1)
        cmb_Cajero.Actualizar()

        cmb_Corte.AgregarParametros("@Id_Sesion", SqlDbType.Int, 0)
        cmb_Corte.AgregarParametros("@Id_CajaBancaria", SqlDbType.Int, 0)
        cmb_Corte.Actualizar()

        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()

        cmb_cia.Actualizar()

        lsv_Catalogo.Columns.Add("Numero Proceso")
        lsv_Catalogo.Columns.Add("Fecha Genera")
        lsv_Catalogo.Columns.Add("Hora Genera")
        lsv_Catalogo.Columns.Add("Fecha Aplicacion")
        lsv_Catalogo.Columns.Add("Grupo")
        lsv_Catalogo.Columns.Add("Corte")
        lsv_Catalogo.Columns.Add("Cia")
        lsv_Catalogo.Columns.Add("Numero Archivo")
        lsv_Catalogo.Columns.Add("Direccion")

    End Sub

    Private Sub Combo_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.EnabledChanged, cmb_Grupo.EnabledChanged, cmb_Corte.EnabledChanged, cmb_Cajero.EnabledChanged, cmb_CajaBancaria.EnabledChanged, Cp_cmb_Parametro1.EnabledChanged
        sender.SelectedValue = "0"
    End Sub

    Private Sub cmb_CajaBancaria_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0

        cmb_Grupo.ValorParametro = cmb_CajaBancaria.SelectedValue
        cmb_Grupo.Actualizar()
    End Sub

    Private Sub cmb_Grupo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Grupo.SelectedValueChanged, Cp_cmb_Parametro1.SelectedValueChanged
        If cmb_Desde.SelectedValue Is Nothing Or cmb_Hasta.SelectedValue Is Nothing Then Exit Sub
        If cmb_Desde.SelectedValue = cmb_Hasta.SelectedValue Then
            cmb_Corte.LimpiarParametros()
            cmb_Corte.AgregarParametros("@Id_Sesion", SqlDbType.Int, cmb_Desde.SelectedValue)
            cmb_Corte.AgregarParametros("@Id_CajaBancaria", SqlDbType.Int, cmb_CajaBancaria.SelectedValue)
            cmb_Corte.Actualizar()
        End If
    End Sub

    Private Sub cmb_Sesiones_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged, cmb_Hasta.SelectedValueChanged
        If cmb_Desde.SelectedValue Is Nothing Or cmb_Hasta.SelectedValue Is Nothing Then Exit Sub
        If cmb_Desde.SelectedValue = cmb_Hasta.SelectedValue Then
            cmb_Corte.LimpiarParametros()
            cmb_Corte.AgregarParametros("@Id_Sesion", SqlDbType.Int, cmb_Desde.SelectedValue)
            cmb_Corte.AgregarParametros("@Id_CajaBancaria", SqlDbType.Int, cmb_CajaBancaria.SelectedValue)
            cmb_Corte.Actualizar()
        End If
    End Sub

    Private Sub cbx_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Todos.CheckedChanged
        If cbx_Todos.Checked Then cmb_Corte.SelectedValue = "0"
        cmb_Corte.Enabled = Not cbx_Todos.Checked
    End Sub

    Private Sub cbx_Todos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_Todos.KeyPress, cbx_TTraslado.KeyPress, cbx_TGrupos.KeyPress, cbx_TCajero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If validar() Then
            If Not fn_ReimprimirCorte_ListarArchivos(lsv_Catalogo, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue, _
                                              cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Moneda.SelectedValue, cmb_Corte.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar consultar los Archivos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cbx_TTraslado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TTraslado.CheckedChanged
        If cbx_TTraslado.Checked Then cmb_cia.SelectedValue = "0"
        cmb_cia.Enabled = Not cbx_TTraslado.Checked
    End Sub

    Private Sub cbx_TGrupos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TGrupos.CheckedChanged
        If cbx_TGrupos.Checked Then cmb_Grupo.SelectedValue = "0"
        cmb_Grupo.Enabled = Not cbx_TGrupos.Checked
    End Sub

    Private Sub cbx_TCajero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TCajero.CheckedChanged
        If cbx_TCajero.Checked Then cmb_Cajero.SelectedValue = "0"
        cmb_Cajero.Enabled = Not cbx_TCajero.Checked
        tbx_ClaveCajero.Enabled = Not cbx_TCajero.Checked
    End Sub

    Private Function validar() As Boolean
        SegundosDesconexion = 0

        If cmb_Desde.SelectedValue = "0" Then
            MsgBox("Debe Seleccionar un valor en el campo Desde", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Return False
        End If
        If cmb_Hasta.SelectedValue = "0" Then
            MsgBox("Debe Seleccionar un valor en el campo Hasta", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Hasta.Focus()
            Return False
        End If
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe Seleccionar una caja Bancaria", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If
        If cmb_Moneda.SelectedValue = "0" Then
            MsgBox("Debe Seleccionar una Moneda", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Return False
        End If
        If cmb_cia.SelectedValue = "0" And Not cbx_TTraslado.Checked Then
            MsgBox("Debe Seleccionar una CIA de Traslado", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_cia.Focus()
            Return False
        End If
        If cmb_Grupo.SelectedValue = "0" And Not cbx_TGrupos.Checked Then
            MsgBox("Debe Seleccionar un grupo de Proceso", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Grupo.Focus()
            Return False
        End If
        If cmb_Corte.SelectedValue = "0" And Not cbx_Todos.Checked Then
            MsgBox("Debe Seleccionar un Corte", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Corte.Focus()
            Return False
        End If
        If cmb_Cajero.SelectedValue = "0" And Not cbx_TCajero.Checked Then
            MsgBox("Debe Seleccionar un Cajero", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cajero.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Dim firma As New frm_FirmaElectronica
            firma.ShowDialog()
            If firma.Firma Then
                If fn_ReimprimirCorte_Eliminar(lsv_Catalogo.SelectedItems(0).Tag) Then
                    Cn_Login.fn_Log_Create("SE ELIMINO EL ARCHIVO: " & lsv_Catalogo.SelectedItems(0).SubItems(7).Text.Trim & " CIA: " & lsv_Catalogo.SelectedItems(0).SubItems(6).Text.Trim & " CAJA: " & cmb_CajaBancaria.Text & "  " & lsv_Catalogo.SelectedItems(0).SubItems(9).Text.Trim & "/" & lsv_Catalogo.SelectedItems(0).SubItems(10).Text.Trim)
                    MsgBox("El corte se elimino correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    If validar() Then
                        If Not fn_ReimprimirCorte_ListarArchivos(lsv_Catalogo, cmb_CajaBancaria.SelectedValue, cmb_Grupo.SelectedValue, cmb_Cajero.SelectedValue, cmb_cia.SelectedValue, _
                                                          cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Moneda.SelectedValue, cmb_Corte.SelectedValue) Then
                            MsgBox("Ha ocurrido un error al llenar la lista de archivos.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    End If
                Else
                    Cn_Login.fn_Log_Create("NO SE PUDO ELIMINAR EL ARCHIVO: " & lsv_Catalogo.SelectedItems(0).SubItems(7).Text.Trim & " CIA: " & lsv_Catalogo.SelectedItems(0).SubItems(6).Text.Trim & " CAJA: " & cmb_CajaBancaria.Text & "  " & lsv_Catalogo.SelectedItems(0).SubItems(9).Text.Trim & "/" & lsv_Catalogo.SelectedItems(0).SubItems(10).Text.Trim)
                    MsgBox("No se pudo eliminar el corte.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Sub gbx_Parametros_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Parametros.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Extraer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Extraer.Click
        If lsv_Catalogo.SelectedItems.Count = 0 Then Exit Sub
        Call DescargarArchivo()
    End Sub

    Sub DescargarArchivo()
        Dim Dialogo As New FolderBrowserDialog With {.Description = "Destino del Archivo.", .ShowNewFolderButton = True}
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            lsv_Catalogo.SelectedItems.Clear()
            Exit Sub
        End If

        Dim CarpetaDestino As String = Dialogo.SelectedPath
        If CarpetaDestino.Length = 3 Then
            CarpetaDestino = CarpetaDestino
        Else
            CarpetaDestino = CarpetaDestino
        End If

        Try
            Dim ArchivosGenerados As Integer = 0
            Dim ArchivoD As Byte() = Nothing
            Dim ArchivoC As Byte() = Nothing
            Dim NombreArchivoD As String = ""
            Dim NombreArchivoC As String = ""
            Dim Archivos As DataRow = Cn_Proceso.fn_Archivos_Extraer(lsv_Catalogo.SelectedItems(0).Tag)

            If Archivos Is Nothing Then
                MsgBox("Ocurrió un Error al intentar Extraer los Archivos", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If Not IsDBNull(Archivos("ArchivoD")) Then ArchivoD = Archivos("ArchivoD")
            If Not IsDBNull(Archivos("ArchivoC")) Then ArchivoC = Archivos("ArchivoC")

            NombreArchivoD = System.IO.Path.GetFileName(Archivos("Nombre_Archivo").ToString)

            NombreArchivoC = Replace(NombreArchivoD, "D", "C")
            NombreArchivoC = Replace(NombreArchivoC, "d", "c")

            If Not ArchivoD Is Nothing Then
                If File.Exists(CarpetaDestino & "\" & NombreArchivoD) Then
                    MsgBox("El Archivo: " & NombreArchivoD & " ya existe en la ruta seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    Using fs As New FileStream(CarpetaDestino & "\" & NombreArchivoD, FileMode.OpenOrCreate, FileAccess.Write)
                        fs.Write(ArchivoD, 0, ArchivoD.Length)
                        fs.Flush()
                        fs.Close()
                        ArchivosGenerados += 1
                    End Using
                End If
            End If

            If Not ArchivoC Is Nothing Then
                If File.Exists(CarpetaDestino & "\" & NombreArchivoC) Then
                    MsgBox("El Archivo: " & NombreArchivoC & " ya existe en la ruta seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    Using fs As New FileStream(CarpetaDestino & "\" & NombreArchivoC, FileMode.OpenOrCreate, FileAccess.Write)
                        fs.Write(ArchivoC, 0, ArchivoC.Length)
                        fs.Flush()
                        fs.Close()
                        ArchivosGenerados += 1
                    End Using
                End If
            End If
            If ArchivosGenerados > 0 Then
                Cn_Login.fn_Log_Create("SE DESCARGARON " & ArchivosGenerados & " ARCHIVOS. NUM:" & lsv_Catalogo.SelectedItems(0).SubItems(7).Text.Trim & " CIA: " & lsv_Catalogo.SelectedItems(0).SubItems(6).Text.Trim & " CAJA: " & cmb_CajaBancaria.Text & "  " & lsv_Catalogo.SelectedItems(0).SubItems(9).Text.Trim & "/" & lsv_Catalogo.SelectedItems(0).SubItems(10).Text.Trim)
            End If
            MsgBox("Se Generaron: " & ArchivosGenerados & " Archivo(s).", MsgBoxStyle.Information, frm_MENU.Text)

        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar guardar el Archivo. " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Catalogo.SelectedItems.Clear()
        End Try
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Hasta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        lsv_Catalogo.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cia.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Grupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Grupo.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Corte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Corte.SelectedIndexChanged
        Call Limpiar()
    End Sub

    Private Sub cmb_Cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cajero.SelectedIndexChanged
        Call Limpiar()
    End Sub
End Class