Imports System.Data.SqlClient
Imports Modulo_Proceso.Cn_Proceso
Imports Modulo_Proceso.FuncionesGlobales

Public Class frm_CatalogoCuentas
    Private Tbl_Referencias As DataTable

    ''' <summary>
    ''' Aqui se crea la tabla de referencias
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreaTbl_Referencias() As DataTable
        Dim Tbl As New DataTable
        Tbl.Columns.Add(New DataColumn("Id_Referencia"))
        Tbl.Columns.Add(New DataColumn("Id_Cuenta"))
        Tbl.Columns.Add(New DataColumn("Referencia"))
        Tbl.Columns.Add(New DataColumn("Status"))
        Tbl.Columns.Add(New DataColumn("Modificado"))

        lsv_ReferenciaDetalles.Columns.Add("Referencia")
        lsv_ReferenciaDetalles.Columns.Add("Status")

        Return Tbl
    End Function


    Private Sub frm_CatalogoCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_ReferenciadaDetalles.AgregarItem("S", "Sí")
        cmb_ReferenciadaDetalles.AgregarItem("N", "No")
        cmb_ReferenciaFijaDetalles.AgregarItem("S", "Sí")
        cmb_ReferenciaFijaDetalles.AgregarItem("N", "No")

        cmb_MonedaDetalles.Actualizar()
        cmb_PaisDetalles.Actualizar()

        cmb_Banco.Actualizar()
        cmb_Banco2.Actualizar()

        Tbl_Referencias = CreaTbl_Referencias()

        'Sacar el Pais, Estado y Ciuadd de la Sucursal para ponerlos como sugerencia
        cmb_MonedaDetalles.SelectedValue = MonedaId
        Dim dt As DataTable = fn_Sucursales_Read(SucursalId)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                cmb_PaisDetalles.SelectedValue = dt.Rows(0)("Id_Pais")
                cmb_EstadoDetalles.SelectedValue = dt.Rows(0)("Id_Estado")
                cmb_CiudadDetalles.SelectedValue = dt.Rows(0)("Id_Ciudad")
            End If
        End If
    End Sub

    Private Sub cmb_2_Pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PaisDetalles.SelectedIndexChanged
        cmb_EstadoDetalles.ValorParametro = cmb_PaisDetalles.SelectedValue
        cmb_EstadoDetalles.Actualizar()
    End Sub

    Private Sub cmb_2_Estado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_EstadoDetalles.SelectedIndexChanged
        cmb_CiudadDetalles.ValorParametro = cmb_EstadoDetalles.SelectedValue
        cmb_CiudadDetalles.Actualizar()
    End Sub

    Private Sub Btn_2_AgregarReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarReferenciaDetalles.Click
        SegundosDesconexion = 0

        If Not tbx_ReferenciaDetalles.Text = "" Then
            If Btn_AgregarReferenciaDetalles.Tag = "" Then
                'revisar si ya existe la referencia  en la lista
                For Each Elemento As ListViewItem In lsv_ReferenciaDetalles.Items
                    If Elemento.Text = tbx_ReferenciaDetalles.Text Then
                        Elemento.Selected = True
                        MsgBox("La Referencia indicada ya existe en la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                        tbx_ReferenciaDetalles.SelectAll()
                        tbx_ReferenciaDetalles.Focus()
                        Exit Sub
                    End If
                Next

                Dim Row As DataRow = Tbl_Referencias.NewRow()
                Row("Id_Referencia") = Tbl_Referencias.Rows.Count + 1
                If lsv_Catalogo.SelectedItems.Count > 0 Then
                    Row("Id_Cuenta") = lsv_Catalogo.SelectedItems(0).Tag
                Else
                    Row("Id_Cuenta") = 0
                End If

                Row("Referencia") = tbx_ReferenciaDetalles.Text
                Row("Status") = "ACTIVO"
                If Tab_Detalles.Tag > 0 Then Row("Modificado") = 2 Else Row("Modificado") = 1

                Tbl_Referencias.Rows.Add(Row)
            Else
                If lsv_ReferenciaDetalles.SelectedItems.Count > 0 Then
                    For Each Row As DataRow In Tbl_Referencias.Rows

                        If Row("Id_Referencia") = lsv_ReferenciaDetalles.SelectedItems(0).Tag Then
                            Row("Referencia") = tbx_ReferenciaDetalles.Text
                            Row("Modificado") = 1
                            Exit For
                        End If
                    Next
                End If
            End If

            Btn_AgregarReferenciaDetalles.Text = "Agregar" & Chr(13) & "Referencia"
            Btn_AgregarReferenciaDetalles.Tag = ""

            ActualizarReferencias()

            tbx_ReferenciaDetalles.Clear()
            tbx_ReferenciaDetalles.Focus()
        Else
            MsgBox("No se puede dejar el campo vacio.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
    End Sub

    ''' <summary>
    ''' Actualiza los valores de la lista lsv_2_Referencia de acuerdo a la tabla Tbl_Referencias
    ''' </summary>
    Private Sub ActualizarReferencias()
        SegundosDesconexion = 0

        Dim Item As ListViewItem
        lsv_ReferenciaDetalles.Columns.Clear()
        lsv_ReferenciaDetalles.Items.Clear()
        lsv_ReferenciaDetalles.Columns.Add("Referencia")
        lsv_ReferenciaDetalles.Columns.Add("Status")

        For Each element As DataRow In Tbl_Referencias.Rows
            If lsv_Catalogo.SelectedItems.Count > 0 Then
                If lsv_Catalogo.SelectedItems(0).Tag = element("Id_Cuenta") Then
                    Item = lsv_ReferenciaDetalles.Items.Add(element("Referencia").ToString)
                    Item.Tag = element("Id_Referencia")
                    'Item.SubItems.Add(IIf(element("Status") Is DBNull.Value, "", element("Status")))
                    Item.SubItems.Add(element("Status"))

                End If
            Else
                If 0 = element("Id_Cuenta") Then
                    Item = lsv_ReferenciaDetalles.Items.Add(element("Referencia").ToString)
                    Item.Tag = element("Id_Referencia")
                    Item.SubItems.Add(element("Status"))
                End If
            End If
        Next
        fn_Columna(lsv_ReferenciaDetalles, 60, 40, 0, 0, 0, 0, 0, 0, 0, 0)
    End Sub

    Private Sub LimpiarCasillas()
        cmb_Banco2.SelectedValue = "0"
        cmb_ReferenciadaDetalles.SelectedValue = "0"
        cmb_ReferenciaFijaDetalles.SelectedValue = "0"
        cmb_MonedaDetalles.SelectedValue = "0"
        cmb_MonedaDetalles.Tag = ""
        tbx_CuentaDetalles.Clear()
        tbx_CuentaDetalles.Tag = ""
        cmb_PaisDetalles.SelectedValue = "0"
        cmb_EstadoDetalles.SelectedValue = "0"
        cmb_CiudadDetalles.SelectedValue = "0"

        Tbl_Referencias.Rows.Clear()
        ActualizarReferencias()

        Tab_Detalles.Text = "Detalles"
        Tab_Detalles.Tag = 0

        If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, chk_Activas.Checked) Then
            MsgBox("Ocurro un error al buscar las cuentas del banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Catalogo.Items.Count)
        Tab_Catalogo.SelectedTab = tab_Listado
    End Sub

    Private Function Validar() As Boolean
        If cmb_Banco2.SelectedValue = 0 Then
            MsgBox("Debe seleccionar una Caja Bancaria.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If cmb_ReferenciadaDetalles.SelectedValue = "0" Then
            MsgBox("Debe Indicar si la Cuenta es Referenciada.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If cmb_ReferenciaFijaDetalles.SelectedValue = "0" And cmb_ReferenciaFijaDetalles.Enabled Then
            MsgBox("Debe indicar si la Referencia es Fija.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If cmb_MonedaDetalles.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Moneda.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If tbx_CuentaDetalles.Text = "" Then
            MsgBox("Debe escribir un Numero de Cuenta.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If cmb_PaisDetalles.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Pais.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If cmb_EstadoDetalles.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Estado.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If cmb_CiudadDetalles.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Ciudad.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If

        If lsv_ReferenciaDetalles.Items.Count = 0 And cmb_ReferenciaFijaDetalles.SelectedValue = "S" And cmb_ReferenciaFijaDetalles.Enabled Then
            MsgBox("Debe capturar al menos una Referencia.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If




        Return True
    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If Not Validar() Then Exit Sub

        If Tab_Detalles.Text = "Detalles" Then
            If Not fn_Cuentas_Modificar(lsv_Catalogo.SelectedItems(0).Tag, tbx_CuentaDetalles.Text, cmb_MonedaDetalles.SelectedValue, cmb_CiudadDetalles.SelectedValue, 1, cmb_ReferenciadaDetalles.SelectedValue, cmb_ReferenciaFijaDetalles.SelectedValue, cmb_Banco2.SelectedValue, Tbl_Referencias, cmb_Banco2.Text, cmb_MonedaDetalles.Text, cmb_MonedaDetalles.Tag, tbx_CuentaDetalles.Tag) Then
                MsgBox("Ha ocurrido un error al intentar guardar la Cuenta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Else
                LimpiarCasillas()
            End If
        Else
            If Not fn_Cuentas_Guardar(tbx_CuentaDetalles.Text, cmb_MonedaDetalles.SelectedValue, cmb_CiudadDetalles.SelectedValue, 1, cmb_ReferenciadaDetalles.SelectedValue, cmb_ReferenciaFijaDetalles.SelectedValue, "A", cmb_Banco2.SelectedValue, Tbl_Referencias, cmb_Banco2.Text, cmb_MonedaDetalles.Text) Then
                MsgBox("Ha ocurrido un error al intentar guardar la Cuenta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Else
                LimpiarCasillas()
            End If
        End If

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        LimpiarCasillas()
    End Sub

    Private Sub cmb_Banco_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedValueChanged
        SegundosDesconexion = 0

        If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, chk_Activas.Checked) Then
            MsgBox("Ocurro un error al buscar las Cuentas del Banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            If lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "ACTIVO" Then
                fn_Cuentas_Baja(lsv_Catalogo.SelectedItems(0).Tag, "B", lsv_Catalogo.SelectedItems(0).Text, cmb_Banco.Text, lsv_Catalogo.SelectedItems(0).SubItems(1).Text)
            Else
                fn_Cuentas_Baja(lsv_Catalogo.SelectedItems(0).Tag, "A", lsv_Catalogo.SelectedItems(0).Text, cmb_Banco.Text, lsv_Catalogo.SelectedItems(0).SubItems(1).Text)
            End If

            If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, chk_Activas.Checked) Then
                MsgBox("Ocurro un error al buscar las Cuentas del Banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If

            Btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
            btn_Detalles.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        End If
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Btn_Baja.Enabled = True
            btn_Detalles.Enabled = True
        Else
            Btn_Baja.Enabled = False
            btn_Detalles.Enabled = False
        End If
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Detalles.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            IniciarModificacion(lsv_Catalogo.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub IniciarModificacion(ByVal Id_Cuenta As Integer)
        Dim Fila As DataRow = fn_Cuentas_Read(Id_Cuenta)

        cmb_Banco2.SelectedValue = Fila("Id_CajaBancaria")
        cmb_ReferenciadaDetalles.SelectedValue = Fila("Referenciada")
        cmb_ReferenciaFijaDetalles.SelectedValue = Fila("Referencia_Fija")
        cmb_MonedaDetalles.SelectedValue = Fila("Id_Moneda")
        cmb_MonedaDetalles.Tag = cmb_MonedaDetalles.Text
        tbx_CuentaDetalles.Text = Fila("Numero_Cuenta")
        tbx_CuentaDetalles.Tag = tbx_CuentaDetalles.Text
        cmb_PaisDetalles.SelectedValue = Fila("Id_Pais")
        cmb_EstadoDetalles.SelectedValue = Fila("Id_Estado")
        cmb_CiudadDetalles.SelectedValue = Fila("Id_Ciudad")

        Tbl_Referencias = fn_Cuentas_Get1(Id_Cuenta)
        ActualizarReferencias()

        Tab_Detalles.Text = "Detalles"
        Tab_Detalles.Tag = Id_Cuenta
        Tab_Catalogo.SelectedTab = Tab_Detalles
    End Sub

    Private Sub cmb_2_Referenciada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ReferenciadaDetalles.SelectedIndexChanged
        cmb_ReferenciaFijaDetalles.Enabled = cmb_ReferenciadaDetalles.SelectedValue = "S"
    End Sub

    Private Sub cmb_2_ReferenciaFija_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ReferenciaFijaDetalles.SelectedValueChanged
        gbx_Referencias.Enabled = cmb_ReferenciaFijaDetalles.SelectedValue = "S"
    End Sub

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.DoubleClick
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            IniciarModificacion(lsv_Catalogo.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub btn_Banco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Banco.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_Banco.SelectedValue = 0
        Else
            cmb_Banco.SelectedValue = frm.Id
        End If
    End Sub

    Private Sub btn_Banco2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Banco2.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_Banco2.SelectedValue = 0
        Else
            cmb_Banco2.SelectedValue = frm.Id
        End If
    End Sub

    Private Sub cbx_Activas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Activas.CheckedChanged
        If Not fn_Cuentas_LLenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, chk_Activas.Checked) Then
            MsgBox("Ocurro un error al buscar las Cuentas del Banco seleccionado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_2_ReferenciaFija_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ReferenciaFijaDetalles.EnabledChanged
        If cmb_ReferenciaFijaDetalles.Enabled = False Then cmb_ReferenciaFijaDetalles.SelectedValue = "N"
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        If Not FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio) Then
            MsgBox("No se encontró.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_BajaRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BajaRef.Click
        SegundosDesconexion = 0

        'lsv_2_Referencia 
        If MsgBox("ADVERTENCIA: Si la Referencia está ligada a un Cliente, también se dará de Baja o Reingreso esta relación con el mismo. Desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, frm_MENU.Text) <> MsgBoxResult.Yes Then Exit Sub
        If lsv_ReferenciaDetalles.SelectedItems(0).SubItems(1).Text = "ACTIVO" Then
            'DARLA DE BAJA
            If Not fn_CuentasReferencias_Baja(lsv_ReferenciaDetalles.SelectedItems(0).Tag) Then
                MsgBox("Ocurro un error al intentar dar de baja la Referencia " & lsv_ReferenciaDetalles.SelectedItems(0).Text, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If
        ElseIf lsv_ReferenciaDetalles.SelectedItems(0).SubItems(1).Text = "INACTIVO" Then
            'DARLA DE ALTA
            If Not fn_CuentasReferencias_Reingreso(lsv_ReferenciaDetalles.SelectedItems(0).Tag) Then
                MsgBox("Ocurro un error al intentar reingresar la Referencia " & lsv_ReferenciaDetalles.SelectedItems(0).Text, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            End If
        End If
        Tbl_Referencias = fn_Cuentas_Get1(lsv_Catalogo.SelectedItems(0).Tag)
        ActualizarReferencias()
    End Sub

    Private Sub lsv_2_Referencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_ReferenciaDetalles.SelectedIndexChanged
        btn_BajaRef.Enabled = lsv_ReferenciaDetalles.SelectedItems.Count > 0
    End Sub

    Private Sub btn_BuscarRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarRefDetalles.Click
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_ReferenciaDetalles.SelectedItems.Count > 0 Then Fila_Inicio = lsv_ReferenciaDetalles.SelectedItems(0).Index + 1
        If Not FuncionesGlobales.fn_Buscar_enListView(lsv_ReferenciaDetalles, tbx_BuscarRefDetalles.Text, 0, Fila_Inicio) Then
            MsgBox("No se encontró.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover, lsv_ReferenciaDetalles.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Banco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedIndexChanged
        If lsv_Catalogo.Items.Count > 0 Then
            btn_Exportar.Enabled = True
        Else
            btn_Exportar.Enabled = False
        End If
    End Sub
End Class