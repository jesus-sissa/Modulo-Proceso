
Imports Modulo_Proceso.Cn_Proceso

Public Class frm_CatalogarServicios

    Public Tipo_Movimiento As Char = ""

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_PrepararDotaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Servicios.Items.Count)
        cmb_CajaBancaria.Actualizar()
        'TIPO_ENTRADA SE MANDA DESDE EL MENU DEPENDIENDO SI ES ENTRADA O SALIDA
        If Tipo_Movimiento = "E" Then
            Me.Text = "Catalogar Servicios de ENTRADA."
            lbl_TipoDotación.Text = "Tipo Entrada:"
            cmb_TipoDotacion.AgregarItem("1", "DEPOSITO DE CLIENTE")
            cmb_TipoDotacion.AgregarItem("2", "CONCENTRACION DE SUCURSAL BANCARIA")
            cmb_TipoDotacion.AgregarItem("3", "RETIRO DE BANXICO")
            cmb_TipoDotacion.AgregarItem("4", "PAGO DE MORRALLA")
            cmb_TipoDotacion.AgregarItem("5", "PAGO DE NOMINA")
            cmb_TipoDotacion.AgregarItem("6", "ENTRADA DESDE OTRA CAJA PRINCIPAL")
            cmb_Sesion.AgregaParametro("@Fecha", dtp_Fecha.Value, 2)
            cmb_Sesion.Actualizar()

            lsv_Servicios.Columns.Add("Remision")
            lsv_Servicios.Columns.Add("Fecha Recibe")
            lsv_Servicios.Columns.Add("Cia. Traslado")
            lsv_Servicios.Columns.Add("Caja Bancaria")
            lsv_Servicios.Columns.Add("Cliente")
            lsv_Servicios.Columns.Add("Importe")
            lsv_Servicios.Columns.Add("Tipo")

            lsv_Servicios.Row1 = 7
            lsv_Servicios.Row2 = 8
            lsv_Servicios.Row3 = 8
            lsv_Servicios.Row4 = 15
            lsv_Servicios.Row5 = 30
            lsv_Servicios.Row6 = 10
            lsv_Servicios.Row7 = 17
            lsv_Servicios.Row8 = 0
            lsv_Servicios.Row9 = 0
            lsv_Servicios.Row10 = 0

        ElseIf Tipo_Movimiento = "S" Then
            Me.Text = "Catalogoar Servicios de SALIDA."
            lbl_TipoDotación.Text = "Tipo Salida:"
            cmb_TipoDotacion.AgregarItem("1", "DOTACION A CLIENTE")
            cmb_TipoDotacion.AgregarItem("2", "DOTACION A SUCURSAL BANCARIA")
            cmb_TipoDotacion.AgregarItem("3", "ENVIO A UNA CAJA PRINCIPAL")
            cmb_TipoDotacion.AgregarItem("4", "DEPOSITO A BANXICO")
            cmb_TipoDotacion.AgregarItem("5", "VENTA DE MORRALLA")
            cmb_Sesion.AgregaParametro("@Fecha", dtp_Fecha.Value, 2)
            cmb_Sesion.Actualizar()


            lsv_Servicios.Columns.Add("Remision")
            lsv_Servicios.Columns.Add("Fecha Captura")
            lsv_Servicios.Columns.Add("Fecha Entrega")
            lsv_Servicios.Columns.Add("Caja")
            lsv_Servicios.Columns.Add("Cliente")
            lsv_Servicios.Columns.Add("ETV")
            lsv_Servicios.Columns.Add("Importe")
            lsv_Servicios.Columns.Add("Moneda")
            lsv_Servicios.Columns.Add("Tipo")

            lsv_Servicios.Row1 = 7
            lsv_Servicios.Row2 = 8
            lsv_Servicios.Row3 = 8
            lsv_Servicios.Row4 = 15
            lsv_Servicios.Row5 = 20
            lsv_Servicios.Row6 = 8
            lsv_Servicios.Row7 = 8
            lsv_Servicios.Row8 = 6
            lsv_Servicios.Row9 = 17
            lsv_Servicios.Row10 = 0
        End If

    End Sub

    Private Function Validar() As Boolean

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If

        If cmb_Sesion.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Sesión", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Sesion.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        lsv_Servicios.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Servicios.Items.Count)
        cmb_Sesion.ActualizaValorParametro("@Fecha", dtp_Fecha.Value)
        cmb_Sesion.Actualizar()
        If cmb_Sesion.Items.Count = 2 Then
            cmb_Sesion.SelectedIndex = 1
        End If

    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        lsv_Servicios.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Servicios.Items.Count)
        chk_Todos.Checked = False
        If Validar() Then
            If Tipo_Movimiento = "E" Then
                If Not fn_CatalogarServiciosLlenalista(lsv_Servicios, cmb_CajaBancaria.SelectedValue, cmb_Sesion.SelectedValue) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista de servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                If chk_Omitir.Checked Then
                    For Each Elem As ListViewItem In lsv_Servicios.Items
                        If Elem.SubItems(6).Text <> "" Then Elem.Remove()
                    Next
                End If
            ElseIf Tipo_Movimiento = "S" Then
                If Not fn_CatalogarDotacionesLlenalista(lsv_Servicios, cmb_CajaBancaria.SelectedValue, cmb_Sesion.SelectedValue) Then
                    MsgBox("Ha ocurrido un error al intentar cargar la lista de servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                If chk_Omitir.Checked Then
                    For Each Elem As ListViewItem In lsv_Servicios.Items
                        If Elem.SubItems(8).Text <> "" Then Elem.Remove()
                    Next
                End If
            End If
        End If

        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Servicios.Items.Count)
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call LlenarLista()
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0
        If lsv_Servicios.Items.Count = 0 Then Exit Sub
        If chk_Todos.Checked Then
            For Each Elem As ListViewItem In lsv_Servicios.Items
                Elem.Checked = True
            Next
        Else
            For Each Elem As ListViewItem In lsv_Servicios.Items
                Elem.Checked = False
            Next
        End If

    End Sub

    Private Sub chk_Omitir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Omitir.CheckedChanged
        If lsv_Servicios.Items.Count = 0 Then Exit Sub
        If chk_Omitir.Checked Then
            For Each Elem As ListViewItem In lsv_Servicios.Items
                If Tipo_Movimiento = "S" Then
                    If Elem.SubItems(8).Text <> "" Then Elem.Remove()
                ElseIf Tipo_Movimiento = "E" Then
                    If Elem.SubItems(6).Text <> "" Then Elem.Remove()
                End If
            Next
            FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Servicios.Items.Count)
        Else
            Call LlenarLista()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If lsv_Servicios.CheckedItems.Count = 0 Then
            MsgBox("Marque la casilla de los servicios que va a catalogar", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Servicios.Focus()
            Exit Sub
        End If

        If Tipo_Movimiento = "E" Then
            If cmb_TipoDotacion.SelectedValue = "0" Then
                MsgBox("Seleccione el tipo de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_TipoDotacion.Focus()
                Exit Sub
            End If
            If Not fn_CatalogarServicioUpdate(lsv_Servicios, cmb_TipoDotacion.SelectedValue) Then
                MsgBox("Ocurrio un error al intentar Catalogar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        ElseIf Tipo_Movimiento = "S" Then
            If cmb_TipoDotacion.SelectedValue = "0" Then
                MsgBox("Seleccione el tipo de Salida.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_TipoDotacion.Focus()
                Exit Sub
            End If
            If Not fn_CatalogarDotacioensUpdate(lsv_Servicios, cmb_TipoDotacion.SelectedValue) Then
                MsgBox("Ocurrio un error al intentar Catalogar los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Call LlenarLista()

    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        lsv_Servicios.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Registros, 0)
    End Sub

    Private Sub cmb_Sesion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sesion.SelectedIndexChanged
        lsv_Servicios.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Registros, 0)
    End Sub

    Private Sub CopiarToolStripMenuItemCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItemCopiar.Click


        If lsv_Servicios.Items.Count <> 0 Then
            Dim remision As String = lsv_Servicios.SelectedItems(0).SubItems(0).Text
            Clipboard.SetText(remision)
        End If

      
    End Sub
End Class