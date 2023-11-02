Imports Modulo_Proceso.Cn_Proceso

Public Class frm_RecibirServicioRec

    Public tbl As DataTable

    Private Sub frm_RecibirServicioRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Envases.Columns.Add("Fecha")
        lsv_Envases.Columns.Add("Hora")
        lsv_Envases.Columns.Add("Remision")
        lsv_Envases.Columns.Add("Envases")
        lsv_Envases.Columns.Add("Banco")
        lsv_Envases.Columns.Add("Cliente")
        lsv_Envases.Columns.Add("Envia")

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

        lsv_RemisionesD.Columns.Add("Moneda")
        lsv_RemisionesD.Columns.Add("Efectivo")
        lsv_RemisionesD.Columns.Add("Documentos")
        lsv_RemisionesD.Columns.Add("TC")

        Call LlenaLista()

    End Sub

#Region "Eventos Privados"

    Private Sub LlenaLista()
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()
        lsv_Remisiones.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Remisiones.Items.Count)

        BanderA = False
        btn_Recibir.Enabled = False
        If Not fn_RecibirLotesBoveda_LlenarListaNew(lsv_Remisiones) Then
            MsgBox("Ocurrió un error al intentar consultar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        tbl = fn_RecibirLotesBoveda_LlenarListaNewEnvase(lsv_Remisiones)

        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Remisiones.Items.Count)
        BanderA = True
    End Sub

    Private Sub Buscar()
        SegundosDesconexion = 0

        'Marcar la remisión buscada
        fn_BuscarSeleccionarMarca_enListView(lsv_Remisiones, tbx_Buscar.Text, 0)
        tbx_Buscar.Focus()
        tbx_Buscar.SelectAll()
    End Sub

#End Region
    
    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarBoveda() Then
                Call Buscar_Envase(tbx_Buscar.Text)
            End If
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        If Not BuscarBoveda() Then
            Call Buscar_Envase(tbx_Buscar.Text)
        End If
    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0
        If tbx_Buscar.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Remisiones, Remision, 0)
            tbx_Buscar.Focus()
            tbx_Buscar.SelectAll()
        End If

    End Sub

    Sub Buscar_Envase(ByVal Numero As String)
        For Each row As DataRow In tbl.Rows
            If (row(1).ToString() = Numero) Then
                Buscar(row(0).ToString())
                Seleccionar(row(0).ToString)
                Exit Sub
            End If
        Next
    End Sub
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In lsv_Remisiones.Items
            If (item.SubItems(2).Text = Remision) Then
                item.Selected = True
            End If
        Next
    End Sub

    Private Sub lsv_datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remisiones.SelectedIndexChanged, lsv_Envases.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envases.Items.Clear()
        lsv_RemisionesD.Items.Clear()

        If lsv_Remisiones.SelectedItems.Count > 0 Then
            If Not fn_CancelarEnvioProceso_Envases(lsv_Remisiones.SelectedItems(0).SubItems(8).Text, lsv_Envases) Then
                MsgBox("Ocurrió un error al intentar consultar los Envases.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If Not fn_CancelarEnvioProceso_RemisionesD(lsv_Remisiones.SelectedItems(0).SubItems(8).Text, lsv_RemisionesD) Then
                MsgBox("Ocurrió un error al intentar consultar los Importes de la Remision.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub lsv_Remisiones_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Remisiones.ItemChecked
        SegundosDesconexion = 0

        btn_Recibir.Enabled = lsv_Remisiones.CheckedItems.Count > 0
        If BanderA Then lsv_Remisiones.Items(e.Item.Index).Selected = True
    End Sub

    Private Sub btn_Recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibir.Click
        SegundosDesconexion = 0
        If SesionId = 0 Then
            MsgBox("No es posible Recibir los Depósitos porque no hay Sesión Abierta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Remisiones.CheckedItems.Count = 0 Then
            MsgBox("Debe seleccionar por lo menos una Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Dim frm As New frm_FirmaElectronica
        frm.ShowDialog()
        If Not frm.Firma Then Exit Sub

        For Each Elemento As ListViewItem In lsv_Remisiones.CheckedItems
            If fn_RecLotesBoveda_ValidarNew(Elemento.Tag) = True Then
                MsgBox("Algunos de los Depósitos ya no están disponibles, se actualizará la Lista.", MsgBoxStyle.Critical, Me.Text)
                Call LlenaLista()
                Exit Sub
            End If
        Next
        If Not fn_ReciboLotesBoveda_GuardarNew(CInt(frm.tbx_Empleado.Text.Trim), lsv_Remisiones) Then
            MsgBox("Ocurrió un Error al intentar recibir los depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call LlenaLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub
    Function BuscarBoveda() As Boolean
        SegundosDesconexion = 0

        If Not fn_BuscarSeleccionarMarca_enListView(lsv_Remisiones, tbx_Buscar.Text.Trim, 2) Then
            Return False
        End If
        tbx_Buscar.SelectAll()
        tbx_Buscar.Focus()

        Dim elementoSeleccionado As String = lsv_Remisiones.SelectedItems(0).SubItems(2).Text
        If elementoSeleccionado <> 0 Then
            'lsv_Remisiones.Items(0).Selected = True
        End If
        Return True
    End Function

End Class