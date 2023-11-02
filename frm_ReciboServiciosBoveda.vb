Imports Modulo_Proceso.FuncionesGlobales.Func
Imports Modulo_Proceso.FuncionesGlobales.Modo

Public Class frm_ReciboServiciosBoveda

    Dim ColumnasD() As Integer = {1, 3, 4, 5}
    Dim NombresD() As String = {"Remisiones", "Importe", "Envases", "Envases S/N"}
    Dim FormatosD() As String = {"g", "n", "g", "g"}
    Dim FuncionesD() As FuncionesGlobales.Func = {Conteo, Suma, Suma, Suma}
    Dim ColumnasE() As Integer = {1}
    Dim NombresE() As String = {"Envases"}
    Dim FormatosE() As String = {"g"}
    Dim FuncionesE() As FuncionesGlobales.Func = {Conteo}

    Private Sub frm_ReciboLotesBoveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Caja Bancaria")
        lsv_Remisiones.Columns.Add("Cliente")
        lsv_Remisiones.Columns.Add("Importe")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("EnvasesSN")

        lsv_Envases.Columns.Add("Numero Envase")
        lsv_Envases.Columns.Add("Tipo Envase")
        'Aqui se llena la lista
        Call LlenaLista()

        lsv_Remisiones.CheckBoxes = True

    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        SegundosDesconexion = 0

        tbx_Buscar.Clear()
        tbx_BuscarE.Clear()
        If lsv_Datos.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_RecibirLotesBovedaDotacionesD_Llenalista(lsv_Remisiones, lsv_Datos.SelectedItems(0).Tag)
            FuncionesGlobales.fn_TotalesListView(lsv_Remisiones, lsv_DotacionDT, ColumnasD, NombresD, FormatosD, FuncionesD, TotalySeleccionados)

            Cn_Proceso.fn_RecibirLotesBovedaDotacionesD_LlenaEnvases(lsv_Envases, lsv_Datos.SelectedItems(0).Tag)
            FuncionesGlobales.fn_TotalesListView(lsv_Envases, lsv_EnvasesT, ColumnasE, NombresE, FormatosE, FuncionesE, TotalySeleccionados)

            lsv_Remisiones.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv_Remisiones.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv_Remisiones.Columns(5).TextAlign = HorizontalAlignment.Right

        End If

    End Sub

    Private Sub btn_Recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibir.Click
        SegundosDesconexion = 0
        If SesionId = 0 Then
            MsgBox("No es posible Recibir los Depósitos porque no hay Sesión Abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Datos.SelectedItems.Count > 0 Then
            Dim frm As New frm_FirmaElectronica
            frm.ShowDialog()

            If Not frm.Firma Then Exit Sub

            For Each Elementos As ListViewItem In lsv_Datos.CheckedItems
                If Cn_Proceso.fn_RecLotesBoveda_Validar(Elementos.Tag) = True Then
                    MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, Me.Text)
                    LlenaLista()
                    Exit Sub
                End If
            Next

            If Cn_Proceso.fn_ReciboLotesBoveda_Guardar(CInt(frm.tbx_Empleado.Text), lsv_Datos.SelectedItems(0).Tag) = True Then
                MsgBox("Registro Guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                btn_Recibir.Enabled = False
                LlenaLista()
                lsv_Remisiones.Items.Clear()

            End If

            LlenaLista()
        Else
            MsgBox("Debe seleccionar un Lote.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LlenaLista()
        SegundosDesconexion = 0

        lsv_Remisiones.Items.Clear()
        lsv_Envases.Items.Clear()
        btn_Recibir.Enabled = False

        Cn_Proceso.fn_RecibirLotesBoveda_LlenarLista(lsv_Datos, 1)
        lsv_Datos.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(3).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(4).TextAlign = HorizontalAlignment.Right
        lsv_Datos.Columns(5).TextAlign = HorizontalAlignment.Right
        'lsv_Datos.Columns(5).DisplayIndex = 2

        'Cn_Proceso.fn_RecibirLotesBovedaDotacionesD_Llenalista(lsv_Remisiones, -1)
        'Cn_Proceso.fn_RecibirLotesBovedaDotacionesD_LlenaEnvases(lsv_Envases, -1)
        FuncionesGlobales.fn_TotalesListView(lsv_Remisiones, lsv_DotacionDT, ColumnasD, NombresD, FormatosD, FuncionesD, TotalySeleccionados)
        FuncionesGlobales.fn_TotalesListView(lsv_Envases, lsv_EnvasesT, ColumnasE, NombresE, FormatosE, FuncionesE, TotalySeleccionados)
        FuncionesGlobales.RagistrosNum(Lbl_Registros, lsv_Datos.Items.Count)
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click, ButtonBuscarE.Click

        If sender Is btn_Buscar Then
            Buscar()
            tbx_Buscar.SelectAll()
            tbx_Buscar.Focus()
        Else
            BuscarEnvase()
            tbx_BuscarE.SelectAll()
            tbx_BuscarE.Focus()
        End If

    End Sub

    Private Sub tbx_Buscar_EnterPress(ByRef Cancel As Boolean) Handles tbx_Buscar.EnterPress, tbx_BuscarE.EnterPress
        Cancel = True
    End Sub


    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress, tbx_BuscarE.KeyPress

        If sender Is tbx_Buscar Then
            If Asc(e.KeyChar) = 13 Then
                If tbx_Buscar.Text.Trim <> "" Then
                    Buscar()
                    tbx_Buscar.SelectAll()
                    tbx_Buscar.Focus()
                End If
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                If tbx_BuscarE.Text.Trim <> "" Then
                    BuscarEnvase()
                    tbx_BuscarE.SelectAll()
                    tbx_BuscarE.Focus()
                End If
            End If
        End If


    End Sub

    Private Sub Buscar()

        If tbx_Buscar.Text.Trim <> "" Then
            Cn_Proceso.fn_BuscaryMarca_enListView(lsv_Remisiones, tbx_Buscar.Text, 1)
        End If

    End Sub

    Private Sub BuscarEnvase()

        If tbx_BuscarE.Text.Trim <> "" Then
            Cn_Proceso.fn_BuscaryMarca_enListView(lsv_Envases, tbx_BuscarE.Text, 1)
        End If

    End Sub

    Private Sub lsv_DotacionD_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Remisiones.ItemChecked, Cp_Listview1.ItemChecked
        FuncionesGlobales.fn_TotalesListView(lsv_Remisiones, lsv_DotacionDT, ColumnasD, NombresD, FormatosD, FuncionesD, TotalySeleccionados)

        If lsv_Remisiones.CheckedItems.Count <> 0 Then

            If lsv_Remisiones.Items.Count = lsv_Remisiones.CheckedItems.Count Then
                lsv_Datos.SelectedItems(0).Checked = True
            Else
                lsv_Datos.SelectedItems(0).Checked = False
            End If

        End If

        btn_Recibir.Enabled = lsv_Remisiones.CheckedItems.Count = lsv_Remisiones.Items.Count

    End Sub

    Private Sub lsv_Envases_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Envases.ItemChecked
        FuncionesGlobales.fn_TotalesListView(lsv_Envases, lsv_EnvasesT, ColumnasE, NombresE, FormatosE, FuncionesE, TotalySeleccionados)
    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.MouseHover, lsv_Remisiones.MouseHover, lsv_DotacionDT.MouseHover, lsv_Envases.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class