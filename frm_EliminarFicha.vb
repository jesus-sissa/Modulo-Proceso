Imports Modulo_Proceso.Cn_Proceso

Public Class frm_EliminarFicha

#Region "Variables Globales"
    Dim Id_Servicio As Integer
#End Region

#Region "Manejo de Eventos"

    Private Sub tbx_Remision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Remision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call BuscarRemision()
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Call BuscarRemision()
    End Sub

    Private Sub cmb_CompañiaTraslado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CompañiaTraslado.SelectedValueChanged
        SegundosDesconexion = 0
        lsv_Fichas.Items.Clear()
        Id_Servicio = 0
        tbx_CajaBancaria.Text = ""
        tbx_Cliente.Text = ""
        tbx_Cajero.Text = ""
        Lbl_Registros.Text = "Registros: 0"
        If tbx_Remision.Text = "" Then Exit Sub
        If cmb_CompañiaTraslado.SelectedValue = 0 Then Exit Sub
        If cmb_CompañiaTraslado.Items.Count > 0 AndAlso cmb_CompañiaTraslado.SelectedValue > 0 Then
            fn_EliminarFicha_LlenarListview(lsv_Fichas, cmb_CompañiaTraslado.SelectedValue)

            With fn_EliminarFicha_DatosRemision(cmb_CompañiaTraslado.SelectedValue)
                Id_Servicio = .Item("Id_Servicio")
                tbx_CajaBancaria.Text = .Item("Banco")
                tbx_Cliente.Text = .Item("Cliente")
                tbx_Cajero.Text = .Item("Cajero")
            End With
            'Else
            '    lsv_Fichas.Items.Clear()
            '    Id_Servicio = 0
            '    tbx_CajaBancaria.Text = ""
            '    tbx_Cliente.Text = ""
            '    tbx_Cajero.Text = ""
            'MsgBox("No se encontro la remision", MsgBoxStyle.Information, frm_MENU.Text)
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Fichas.Items.Count)
    End Sub
#End Region

#Region "Metodos generales"

    Private Sub BuscarRemision()
        SegundosDesconexion = 0

        If Not tbx_Remision.Text = "" AndAlso fn_EliminarFicha_LlenarCias(tbx_Remision.Text.Trim, cmb_CompañiaTraslado) Then
            If cmb_CompañiaTraslado.Items.Count > 2 Then
                cmb_CompañiaTraslado.Focus()
            Else
                cmb_CompañiaTraslado.SelectedIndex = 1
            End If
        Else
            cmb_CompañiaTraslado.SelectedValue = 0
            lsv_Fichas.Items.Clear()
            Id_Servicio = 0
            tbx_CajaBancaria.Text = ""
            tbx_Cliente.Text = ""
            tbx_Cajero.Text = ""
            Lbl_Registros.Text = "Registros: 0"
            MsgBox("No se encontro la Remisión", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

#End Region

    Private Sub lsv_Fichas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_Eliminar.Enabled = lsv_Fichas.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        If lsv_Fichas.SelectedItems.Count = 0 Then Exit Sub
        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = True
        frm.ShowDialog()
        If frm.Firma = True Then
            If fn_EliminarFicha_Eliminar(lsv_Fichas.SelectedItems(0).Tag, Id_Servicio, tbx_Remision.Text, lsv_Fichas.SelectedItems(0).Text, lsv_Fichas.SelectedItems(0).SubItems(1).Text, lsv_Fichas.SelectedItems(0).SubItems(3).Text, lsv_Fichas.SelectedItems(0).SubItems(4).Text, frm.Observaciones) Then
                MsgBox("La Ficha se eliminó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                fn_EliminarFicha_LlenarListview(lsv_Fichas, cmb_CompañiaTraslado.SelectedValue)
            Else
                MsgBox("Ha ocurrido un error al intentar eliminar la Ficha.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If

    End Sub

    Private Sub lsv_Fichas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.MouseHover

        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

    End Sub

    Private Sub frm_EliminarFicha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Fichas.Columns.Add("Ficha")
        lsv_Fichas.Columns.Add("Moneda")
        lsv_Fichas.Columns.Add("Tipo")
        lsv_Fichas.Columns.Add("Efectivo")
        lsv_Fichas.Columns.Add("Cheques")
        lsv_Fichas.Columns.Add("Otros")
        lsv_Fichas.Columns.Add("Dif. Efectivo")
        lsv_Fichas.Columns.Add("Dif. Cheques")
        lsv_Fichas.Columns.Add("Dif. Otros")
        lsv_Fichas.Columns.Add("Falsos")
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Fichas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Fichas.DoubleClick
        If lsv_Fichas.SelectedItems.Count > 0 Then
            Dim frm As New frm_FichasDesglose
            frm.Id_Ficha = lsv_Fichas.SelectedItems(0).Tag
            frm.ShowDialog()
        End If
    End Sub
End Class