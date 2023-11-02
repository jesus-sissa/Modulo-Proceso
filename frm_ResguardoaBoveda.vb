Public Class frm_ResguardoaBoveda

    Private Sub frm_ResguardoaBoveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista
        Call Llenalista()

        lsv_ResguardoD.Columns.Add("Denominacion")
        lsv_ResguardoD.Columns.Add("Cantidad")
        lsv_ResguardoD.Columns.Add("CantidadA")
        lsv_ResguardoD.Columns.Add("CantidadB")
        lsv_ResguardoD.Columns.Add("CantidadC")
        lsv_ResguardoD.Columns.Add("CantidadD")
        lsv_ResguardoD.Columns.Add("CantidadE")

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

    End Sub

    Private Sub lsv_Resguardo_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Resguardo.ItemChecked
        If lsv_Resguardo.CheckedItems.Count = 0 Then
            btn_Enviar.Enabled = False
        Else
            btn_Enviar.Enabled = True
        End If
    End Sub

    Private Sub lsv_Resguardo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardo.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Resguardo.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Cn_Proceso.fn_EnvBovedaResDLlenalista(lsv_ResguardoD, lsv_Resguardo.SelectedItems(0).Tag)
            'lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right

            lsv_ResguardoD.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv_ResguardoD.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_ResguardoD.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_ResguardoD.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv_ResguardoD.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv_ResguardoD.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv_ResguardoD.Columns(6).TextAlign = HorizontalAlignment.Right

            Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_Resguardo.SelectedItems(0).SubItems(6).Text, lsv_Envases)

        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_ResguardoD.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_Registros2, lsv_Envases.Items.Count)

    End Sub

    Private Sub btn_Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Enviar.Click

        Dim Elementos As ListViewItem
        Dim CantidadRemisiones As Integer = 0
        Dim CantidadEnvases As Integer = 0
        Dim lc_dt As New DataTable
        Dim lc_dr As DataRow

        lc_dt.TableName = "detalle"
        lc_dt.Columns.Add("Id_Resguardo")
        lc_dt.Columns.Add("Id_remision")

        'validar status 

        If lsv_Resguardo.CheckedItems.Count = 0 Then
            MsgBox("Seleccione un envío", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        For Each Elementos In lsv_Resguardo.CheckedItems
            If Cn_Proceso.fn_ValidaBovedaResg(Elementos.Tag.ToString) = True Then
                MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, Me.Text)
                'llena lista
                Exit Sub
            End If

        Next

        Try
            For Each Elementos In lsv_Resguardo.CheckedItems
                CantidadRemisiones += 1
                CantidadEnvases += Elementos.SubItems(3).Text

                lc_dr = lc_dt.NewRow
                lc_dr("Id_Resguardo") = Elementos.Tag.ToString
                lc_dr("Id_remision") = Elementos.SubItems(6).Text
                lc_dt.Rows.Add(lc_dr)

            Next

            If Cn_Proceso.fn_BovedaResg_Nuevo(CantidadRemisiones, CantidadEnvases, lc_dt) = False Then
                MsgBox("No se encontro el turno", MsgBoxStyle.Information, Me.Text)
                Exit Sub

            End If

        Catch ex As Exception
            Exit Sub
        End Try

        MsgBox("El envío del resguardo se realizó correctamente.", MsgBoxStyle.Information, Me.Text)

        Call Llenalista()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Llenalista()
        SegundosDesconexion = 0

        Cn_Proceso.fn_EnvBovedaResLlenalista(lsv_Resguardo, 0)
        lsv_Resguardo.CheckBoxes = True

        lsv_Resguardo.Columns(1).TextAlign = HorizontalAlignment.Right
        lsv_Resguardo.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_Resguardo.Columns(3).TextAlign = HorizontalAlignment.Right

        lsv_ResguardoD.Items.Clear()
        lsv_Envases.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Resguardo.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_ResguardoD.Items.Count)
    End Sub

    Private Sub lsv_Resguardo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardo.MouseHover, lsv_ResguardoD.MouseHover
        SegundosDesconexion = 0
    End Sub
End Class