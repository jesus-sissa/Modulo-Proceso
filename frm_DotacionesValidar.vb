Public Class frm_DotacionesValidar

    Private Sub frm_ValidaDotaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        BanderA = False
        cmb_CajaBancaria.Actualizar()
        BanderA = True
        Lsv_Dotacion.Columns.Add("CajaBancaria")
        Lsv_Dotacion.Columns.Add("Cliente")
        Lsv_Dotacion.Columns.Add("FechaCaptura")
        Lsv_Dotacion.Columns.Add("Moneda")
        Lsv_Dotacion.Columns.Add("Importe")

        Lsv_DotacionD.Columns.Add("Denominacion")
        Lsv_DotacionD.Columns.Add("Cantidad")
        Lsv_DotacionD.Columns.Add("CantidadA")
        Lsv_DotacionD.Columns.Add("CantidadB")
        Lsv_DotacionD.Columns.Add("CantidadC")
        Lsv_DotacionD.Columns.Add("CantidadD")
        Lsv_DotacionD.Columns.Add("CantidadE")

    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_Dialogo2014
        Dim Elemento As ListViewItem
        Dim Importe As Decimal = 0.0

        For Each Elemento In Lsv_DotacionD.Items
            Importe += CDec(Elemento.SubItems(0).Text) * (CInt(Elemento.SubItems(1).Text) + CInt(Elemento.SubItems(2).Text) + CInt(Elemento.SubItems(3).Text) + CInt(Elemento.SubItems(4).Text) + CInt(Elemento.SubItems(5).Text) + CInt(Elemento.SubItems(6).Text))
        Next

        For Each Elemento In Lsv_Dotacion.CheckedItems
            Elemento.Selected = True
            If Cn_Proceso.fn_ValidaDotValidaDotacion(Lsv_DotacionD, Elemento.SubItems(7).Text) = True Then
                'Consultar la Clave y el Domicilio del Origen
                Dim dt As DataTable = Cn_Proceso.fn_ConsultaDatosOrigen(SucursalId)
                If dt.Rows.Count > 0 Then
                    frm.Domicilio_Origen = dt.Rows(0)("Direccion") & ", " & dt.Rows(0)("Ciudad") & ", " & dt.Rows(0)("Estado")
                    frm.CiaTV = dt.Rows(0)("Nombre")
                End If
                'Consultar la Clave y el Domicilio del Cliente Destino
                Dim Dr As DataRow = Cn_Proceso.fn_ClientesProceso_Generales(Elemento.SubItems(6).Text)

                frm.DotacionID = Elemento.Tag
                frm.IdCajaBancaria = Elemento.SubItems(7).Text
                frm.ImporteTotal = Elemento.SubItems(4).Text
                frm.Importe_Doc = Elemento.SubItems(11).Text
                frm.Importe_Efectivo = Elemento.SubItems(12).Text
                frm.Id_Moneda = Elemento.SubItems(8).Text
                frm.TipodeCambio = Cn_Proceso.fn_ValidaDotTipoCambio(Elemento.SubItems(8).Text)

                frm.Nombre_Origen = Elemento.Text
                frm.Clave_Destino = Dr.Item("Clave")
                frm.Nombre_Destino = Elemento.SubItems(1).Text
                frm.Domicilio_Destino = Dr.Item("Direccion_Comercial")
                frm.CiaTV = Dr.Item("Cia")
                frm.IdCliente = Dr.Item("Id_Cliente")
                frm.tbx_Numero.Clear()
                frm.tbx_Remision.Clear()
                frm.lsv_Envases.Items.Clear()

                frm.ShowDialog()

            Else
                MsgBox("No existe suficiente saldo para validar la Dotación.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit For
            End If
        Next
        Lsv_DotacionD.Items.Clear()
        btn_Validar.Enabled = False
        Call LlenaLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub ckb_Caja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_Caja.CheckedChanged
        SegundosDesconexion = 0
        If ckb_Caja.Checked = True Then
            cmb_CajaBancaria.SelectedIndex = 0
            cmb_CajaBancaria.Enabled = False
            Call LlenaLista()
        Else
            cmb_CajaBancaria.Enabled = True
            Lsv_Dotacion.Items.Clear()
            Lsv_DotacionD.Items.Clear()
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, Lsv_Dotacion.Items.Count)
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, Lsv_DotacionD.Items.Count)
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LlenaLista()
    End Sub

    Sub LlenaLista()

        If BanderA = True Then
            Cn_Proceso.fn_ValidaDotLlenalista(Lsv_Dotacion, cmb_CajaBancaria.SelectedValue)
            Lsv_Dotacion.Columns(4).TextAlign = HorizontalAlignment.Right
            Lsv_Dotacion.Columns(8).Width = 0
            Lsv_Dotacion.Columns(9).Width = 0
            Lsv_Dotacion.Columns(10).Width = 0
            Lsv_Dotacion.Columns(11).Width = 0
            Lsv_Dotacion.Columns(12).Width = 0


            ''Agregar las columnas en la tabla Detalle
            'Lsv_DotacionD.Items.Clear()
            'Lsv_DotacionD.Columns.Add("Denominacion")
            'Lsv_DotacionD.Columns.Add("Cantidad")
            'Lsv_DotacionD.Columns.Add("CantidadA")
            'Lsv_DotacionD.Columns.Add("CantidadB")
            'Lsv_DotacionD.Columns.Add("CantidadC")
            'Lsv_DotacionD.Columns.Add("CantidadD")
            'Lsv_DotacionD.Columns.Add("CantidadE")
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, Lsv_Dotacion.Items.Count)
    End Sub

    Private Sub Lsv_Dotacion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Dotacion.MouseHover, Lsv_DotacionD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Lsv_Dotacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Dotacion.SelectedIndexChanged
        SegundosDesconexion = 0

        If BanderA = True Then
            If Lsv_Dotacion.SelectedItems.Count > 0 Then
                Cn_Proceso.fn_ValidaDotDLlenalista(Lsv_DotacionD, Lsv_Dotacion.SelectedItems(0).Tag)

                Lsv_DotacionD.Columns(0).TextAlign = HorizontalAlignment.Right
                Lsv_DotacionD.Columns(1).TextAlign = HorizontalAlignment.Right
                Lsv_DotacionD.Columns(2).TextAlign = HorizontalAlignment.Right
                Lsv_DotacionD.Columns(3).TextAlign = HorizontalAlignment.Right
                Lsv_DotacionD.Columns(4).TextAlign = HorizontalAlignment.Right
                Lsv_DotacionD.Columns(5).TextAlign = HorizontalAlignment.Right
                Lsv_DotacionD.Columns(6).TextAlign = HorizontalAlignment.Right

            Else
                Lsv_DotacionD.Items.Clear()
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, Lsv_DotacionD.Items.Count)
    End Sub

    Private Sub Lsv_Dotacion_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Dotacion.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Dotacion.CheckedItems.Count = 0 Then
            btn_Validar.Enabled = False
        Else
            'smc en esta parte seleccionamos el registro del data Grid View y verifcamos que cuente con remision digital.... en base a su SubItems
            'Dim elementOne As String = Lsv_Dotacion.SelectedItems(0).SubItems(1).Text
            'MsgBox(elementOne)
            btn_Validar.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class