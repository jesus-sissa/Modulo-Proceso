Imports System.Data.SqlClient
Imports Modulo_Proceso.FuncionesGlobales
Imports Modulo_Proceso.Cn_Proceso

Public Class frm_ClientesProceso

#Region "Variables Globales Privadas"

    Private Id_Compañia As Integer

#End Region

#Region "Eventos Manejados"

    Private Sub frm_CajasBancarias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Aqui se llenan los combos de la pestaña 0
        cmb_Cia.Actualizar()
        cmb_Banco.Actualizar()

        'Aqui se llenan los combos de la pestaña 1
        cmb_CompañiaDetalles.Actualizar()
        cmb_ClienteDetalles.Actualizar()
        cmb_BancoDetalles.Actualizar()
        cmb_PaisDetalles.Actualizar()
        ComboSiNo(cmb_RequiereCuentasDetalles)

        'Aqui se actualiza el list view lsv_0_Catalogo
        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre Comercial")
        lsv_Catalogo.Columns.Add("Numero Contrato")
        lsv_Catalogo.Columns.Add("Descripcion")
        lsv_Catalogo.Columns.Add("Status")
        lsv_Cuentas.Columns.Add("Numero Cuenta")
        lsv_Cuentas.Columns.Add("Moneda")
        lsv_Cuentas.Columns.Add("Status")
        lsv_Referencias.Columns.Add("Referencia")
        lsv_Referencias.Columns.Add("Status")

        Id_Compañia = fn_ParametrosG_Read()(7)
        'Sacar el Pais, Estado y Ciuadd de la Sucursal para ponerlos como sugerencia
        Dim dt As DataTable = fn_Sucursales_Read(SucursalId)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                cmb_PaisDetalles.SelectedValue = dt.Rows(0)("Id_Pais")
                cmb_EstadoDetalles.SelectedValue = dt.Rows(0)("Id_Estado")
                cmb_CiudadDetalles.SelectedValue = dt.Rows(0)("Id_Ciudad")
            End If
        End If
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub cmb_Pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PaisDetalles.SelectedIndexChanged
        cmb_EstadoDetalles.ValorParametro = cmb_PaisDetalles.SelectedValue
        cmb_EstadoDetalles.Actualizar()
    End Sub

    Private Sub cmb_Estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_EstadoDetalles.SelectedIndexChanged
        cmb_CiudadDetalles.ValorParametro = cmb_EstadoDetalles.SelectedValue
        cmb_CiudadDetalles.Actualizar()
    End Sub

    Private Sub cmb_1_Banco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BancoDetalles.SelectedIndexChanged
        cmb_GrupoFDetalles.ValorParametro = cmb_BancoDetalles.SelectedValue
        cmb_GrupoFDetalles.Actualizar()

        cmb_GrupoDepositoDetalles.ValorParametro = cmb_BancoDetalles.SelectedValue
        cmb_GrupoDepositoDetalles.Actualizar()

        cmb_GrupoDotaDetalles.ValorParametro = cmb_BancoDetalles.SelectedValue
        cmb_GrupoDotaDetalles.Actualizar()
    End Sub

    Private Sub btn_1_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        tab_Nuevo.Tag = 0
        Tab_General.SelectedTab = Tab_Listado
        tab_Nuevo.Text = "Detalles"
        LimpiarFicha1()
        cmb_BancoDetalles.Enabled = True
        cmb_ClienteDetalles.Enabled = True
        tbx_ClienteDetalles.Enabled = True

    End Sub

    Private Sub btn_1_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarClienteDetalles.Click
        SegundosDesconexion = 0

        Frm_BuscarCliente.ShowDialog()
        tbx_ClienteDetalles.Text = Frm_BuscarCliente.Clave
    End Sub

    Private Sub cmb_1_Compañias_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CompañiaDetalles.SelectedValueChanged
        If cmb_CompañiaDetalles.SelectedValue = Id_Compañia Then
            cmb_ClienteDetalles.Visible = True
            btn_BuscarClienteDetalles.Visible = True
            tbx_1_ClienteLibre.Visible = False
        Else
            cmb_ClienteDetalles.Visible = False
            cmb_ClienteDetalles.SelectedValue = "0"
            btn_BuscarClienteDetalles.Visible = False
            tbx_1_ClienteLibre.Visible = True
        End If
    End Sub

    'Private Sub cmb_1_Banco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_1_Banco.SelectedIndexChanged
    '    cmb_1_GrupoF.ValorParametro = cmb_1_Banco.SelectedValue
    '    cmb_1_GrupoF.Actualizar()
    'End Sub

    Private Sub BTN_0_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicial As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then Fila_Inicial = lsv_Catalogo.SelectedItems(0).Index + 1

        fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicial)
    End Sub

    Private Sub lsv_0_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub BTN_0_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_0_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_1_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim NombreComercial As String
        Dim Id_Cliente As Integer

        If cmb_BancoDetalles.SelectedValue = 0 Then
            MsgBox("Seleccione una Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_BancoDetalles.Focus()
            Exit Sub
        End If

        If cmb_ClienteDetalles.Visible Then
            If cmb_ClienteDetalles.SelectedValue = "0" Then
                MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_ClienteDetalles.Focus()
                Exit Sub
            End If

            NombreComercial = cmb_ClienteDetalles.Text
            Id_Cliente = cmb_ClienteDetalles.SelectedValue
        Else
            If tbx_1_ClienteLibre.Text = "" Then
                MsgBox("Capture el Nombre del Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_1_ClienteLibre.Focus()
                Exit Sub
            End If
            NombreComercial = tbx_1_ClienteLibre.Text
            Id_Cliente = 0
        End If
        If cmb_CiudadDetalles.SelectedValue = "0" Then
            MsgBox("Seleccione la Ciudad.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CiudadDetalles.Focus()
            Exit Sub
        End If
        If cmb_RequiereCuentasDetalles.SelectedValue = "0" Then
            MsgBox("Seleccione si requiere cuentas o no.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_RequiereCuentasDetalles.Focus()
            Exit Sub
        End If

        If tab_Nuevo.Tag = 0 Then

            tab_Nuevo.Tag = fn_ClientesProceso_Crear(Id_Cliente, cmb_CompañiaDetalles.SelectedValue, tbx_ClienteDetalles.Text, NombreComercial, tbx_DireccionDetalles.Text, cmb_CiudadDetalles.SelectedValue, _
                                     cmb_BancoDetalles.SelectedValue, cmb_GrupoFDetalles.SelectedValue, tbx_ContratoDetalles.Text, cmb_RequiereCuentasDetalles.Text, cmb_GrupoDepositoDetalles.SelectedValue, cmb_GrupoDotaDetalles.SelectedValue, UsuarioId, EstacioN)

            If tab_Nuevo.Tag = 0 Then
                MsgBox("No se pudo insertar el registro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Else
                tab_Nuevo.Tag = 0
                Tab_General.SelectedTab = Tab_Listado
                tab_Nuevo.Text = "Detalles"
                LimpiarFicha1()
            End If


        Else
            If Not fn_ClientesProceso_Modificar(tab_Nuevo.Tag, cmb_CompañiaDetalles.SelectedValue, Id_Cliente, tbx_ClienteDetalles.Text, NombreComercial, tbx_DireccionDetalles.Text, cmb_CiudadDetalles.SelectedValue, _
                                     cmb_BancoDetalles.SelectedValue, cmb_GrupoFDetalles.SelectedValue, tbx_ContratoDetalles.Text, cmb_RequiereCuentasDetalles.Text, cmb_GrupoDepositoDetalles.SelectedValue, cmb_GrupoDotaDetalles.SelectedValue) Then MsgBox("No se pudo actualizar el registro")
            Tab_General.SelectedTab = Tab_Listado
            tab_Nuevo.Tag = 0
            Tab_General.SelectedTab = Tab_Listado
            tab_Nuevo.Text = "Detalles"
            LimpiarFicha1()
        End If



        'Aqui se actualiza el list view lsv_0_Catalogo
        fn_ClientesProceso_LlenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, chk_Activas.Checked)
        btn_Cuentas.Enabled = tab_Nuevo.Tag > 0

    End Sub

    Private Sub cmb_1_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClienteDetalles.SelectedIndexChanged

        If cmb_CompañiaDetalles.SelectedValue = Id_Compañia Then
            'obtiene los valores de la basede datos
            Dim Arr As DataRow = fn_Clientes_Generales(cmb_ClienteDetalles.SelectedValue)

            'Escribe los valores en los campos
            If Not Arr Is Nothing Then
                tbx_DireccionDetalles.Text = Arr(12) & " " & Arr(13) & " " & Arr(14) & ", " & Arr(15)   'Direccion_Comercial
                Dim ArrC As Array = fn_Clientes_Lugar(Arr(17))  'Zona_Comercial
                cmb_PaisDetalles.SelectedValue = ArrC(3) 'Id_Pais
                cmb_EstadoDetalles.SelectedValue = ArrC(2) 'Id_Estado
                cmb_CiudadDetalles.SelectedValue = ArrC(1) 'Id_Ciudad
            Else
                LimpiarParcialFicha1()
            End If
        End If

    End Sub

    Private Sub cmb_0_Banco_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedValueChanged
        SegundosDesconexion = 0

        'Aqui se actualiza el list view lsv_0_Catalogo
        If cmb_Banco.SelectedValue <> "0" And cmb_Cia.SelectedValue <> "0" Then
            fn_ClientesProceso_LlenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, chk_Activas.Checked)
        Else
            lsv_Catalogo.Items.Clear()
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_0_Cia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedValueChanged
        'Aqui se actualiza el list view lsv_0_Catalogo
        If cmb_Banco.SelectedValue <> "0" And cmb_Cia.SelectedValue <> "0" Then
            fn_ClientesProceso_LlenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, chk_Activas.Checked)
        Else
            lsv_Catalogo.Items.Clear()
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Catalogo.Items.Count)

        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0

    End Sub

    Private Sub BTN_0_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            LimpiarFicha1()
            tab_Nuevo.Text = "Detalles"

            Dim Arr As Array = fn_ClientesProceso_Leer(lsv_Catalogo.SelectedItems(0).Tag)

            tab_Nuevo.Tag = lsv_Catalogo.SelectedItems(0).Tag
            cmb_CompañiaDetalles.SelectedValue = Arr(6)          'Id_Cia,
            cmb_ClienteDetalles.SelectedValue = Arr(0)            'Id_Cliente,
            tbx_ClienteDetalles.Text = Trim(Arr(1))               'Clave_Cliente,
            tbx_1_ClienteLibre.Text = Arr(2)                'Nombre_Comercial,
            tbx_DireccionDetalles.Text = Arr(3)                   'Direccion_Comercial,
            If Arr(4) > 0 Then
                Dim Arr2 As Array = fn_Ciudad_Read(Arr(4))      'Id_Ciudad,
                If Arr2 IsNot Nothing Then
                    cmb_PaisDetalles.SelectedValue = Arr2(0)              'Id_Pais, 
                    cmb_EstadoDetalles.SelectedValue = Arr2(1)            'Id_Estado, 
                    cmb_CiudadDetalles.SelectedValue = Arr2(2)            'Id_Ciudad
                End If
            End If
            cmb_BancoDetalles.SelectedValue = Arr(5)              'Id_CajaBancaria,
            cmb_GrupoFDetalles.SelectedValue = Arr(7)             'Id_GrupoF,
            tbx_ContratoDetalles.Text = Arr(11)                   'Numero_Contrato,
            cmb_RequiereCuentasDetalles.SelectedValue = Arr(13)   'Requiere_Cuenta,
            cmb_GrupoDepositoDetalles.SelectedValue = Arr(18)       'Id_GrupoDepo,
            cmb_GrupoDotaDetalles.SelectedValue = Arr(19)           'Id_GrupoDota

            Tab_General.SelectedTab = tab_Nuevo
            btn_Cuentas.Enabled = tab_Nuevo.Tag > 0

            fn_Proceso_ObtenerCuentas(lsv_Cuentas, tab_Nuevo.Tag)

            cmb_BancoDetalles.Enabled = False
            cmb_ClienteDetalles.Enabled = False
            tbx_ClienteDetalles.Enabled = False
        End If
    End Sub

    Private Sub cmb_1_Compañias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CompañiaDetalles.SelectedIndexChanged
        LimpiarParcialFicha1()
        If cmb_CompañiaDetalles.SelectedValue = CiaId Then
            tbx_ClienteDetalles.Visible = True
            cmb_ClienteDetalles.Visible = True
            tbx_1_ClienteLibre.Visible = False
        Else
            tbx_ClienteDetalles.Visible = False
            cmb_ClienteDetalles.Visible = False
            tbx_1_ClienteLibre.Visible = True
        End If
    End Sub

#End Region

#Region "Metodos Privados"

    ''' <summary>
    ''' Agrega los valores si y no a un combo
    ''' </summary>
    ''' <param name="cmb">Es el combo al que se le van a agregar los valores</param>
    Private Sub ComboSiNo(ByVal cmb As cp_cmb_Manual)
        cmb.AgregarItem("S", "Sí")
        cmb.AgregarItem("N", "No")
    End Sub

    ''' <summary>
    ''' Limpia todas las casilas de la ficha 1
    ''' </summary>
    Private Sub LimpiarFicha1()
        tbx_1_ClienteLibre.Clear()
        cmb_CompañiaDetalles.SelectedValue = "0"
        tbx_ClienteDetalles.Clear()
        cmb_ClienteDetalles.SelectedValue = "0"
        tbx_DireccionDetalles.Clear()
        cmb_PaisDetalles.SelectedValue = "0"
        cmb_BancoDetalles.SelectedValue = "0"
        cmb_GrupoFDetalles.SelectedValue = "0"
        tbx_ContratoDetalles.Clear()
        cmb_RequiereCuentasDetalles.SelectedValue = "0"

        cmb_BancoDetalles.Enabled = True
        cmb_ClienteDetalles.Enabled = True
        tbx_ClienteDetalles.Enabled = True

        lsv_Cuentas.Items.Clear()
        lsv_Referencias.Items.Clear()
    End Sub

    ''' <summary>
    ''' Limpia solo las casillas que se ven afectadas al cambiar la casilla del cliente
    ''' </summary>
    Private Sub LimpiarParcialFicha1()
        cmb_ClienteDetalles.SelectedValue = "0"
        tbx_ClienteDetalles.Clear()
        tbx_1_ClienteLibre.Clear()
        tbx_DireccionDetalles.Clear()
        cmb_PaisDetalles.SelectedValue = "0"
    End Sub

    ''' <summary>
    ''' Valida que no existan casillas vacias en la ficha 1
    ''' </summary>
    Private Function ValidarFicha1() As Boolean
        If cmb_CompañiaDetalles.SelectedValue = "0" Then Return False
        'If tbx__Cliente.Text = "" Then Return False
        'If cmb_1_Cliente.SelectedValue = "0" And cmb_1_Cliente.Visible Then Return False
        'If tbx_1_Direccion.Text = "" Then Return False
        If cmb_CiudadDetalles.SelectedValue = "0" Then Return False
        If cmb_BancoDetalles.SelectedValue = "0" Then Return False
        'If tbx_1_Contrato.Text = "" Then Return False
        If cmb_RequiereCuentasDetalles.SelectedValue = "0" Then Return False
        'If cmb_GrupoDeposito.Text = "" Then Return False
        'If cmb_GrupoDota.Text = "" Then Return False

        Return True
    End Function

#End Region

    Private Sub btn_Cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cuentas.Click
        SegundosDesconexion = 0

        If tab_Nuevo.Tag > 0 Then
            Dim Frm As New frm_CuentasModal
            Frm.Id_ClienteP = tab_Nuevo.Tag
            Frm.Id_Banco = cmb_BancoDetalles.SelectedValue
            Frm.ShowDialog()
            Frm.Dispose()
            fn_Proceso_ObtenerCuentas(lsv_Cuentas, tab_Nuevo.Tag)
        End If
    End Sub

    Private Sub lsv_Cuentas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Cuentas.SelectedIndexChanged
        If lsv_Cuentas.SelectedItems.Count > 0 Then
            fn_Proceso_ObtenerReferencias(lsv_Referencias, tab_Nuevo.Tag, lsv_Cuentas.SelectedItems(0).Tag)
            btn_CuentasBaja.Enabled = True
        Else
            lsv_Referencias.Items.Clear()
            btn_CuentasBaja.Enabled = False
        End If
    End Sub

    Private Sub btn_BuscarCajaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCajaBancaria.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_Banco.SelectedValue = 0
        End If

    End Sub

    Private Sub btn_CajaBancaria2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CajaBancariaDetalles.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.CajaBancaria
        frm.ShowDialog()

        If frm.Clave = "" Then
            cmb_BancoDetalles.SelectedValue = 0
        End If

    End Sub

    Private Sub Btn_0_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            If Not fn_Proceso_BajaReing(lsv_Catalogo.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar Dar de Baja o Alta el Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Not fn_ClientesProceso_LlenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, chk_Activas.Checked) Then
                    MsgBox("Ha ocurrido un error al intentar actualizar la lista", MsgBoxStyle.Critical, frm_MENU)
                End If
            End If
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub lsv_Referencias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Referencias.SelectedIndexChanged
        btn_ReferenciaBaja.Enabled = lsv_Referencias.SelectedItems.Count > 0
    End Sub

    Private Sub lsv_Referencias_AlActualizar() Handles lsv_Referencias.AlActualizar
        btn_ReferenciaBaja.Enabled = False
    End Sub

    Private Sub lsv_Cuentas_AlActualizar() Handles lsv_Cuentas.AlActualizar
        btn_CuentasBaja.Enabled = False
    End Sub

    Private Sub btn_CuentasBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CuentasBaja.Click
        SegundosDesconexion = 0

        If lsv_Cuentas.SelectedItems.Count > 0 Then
            If Not fn_Proceso_CuentasBaja_Reing(tab_Nuevo.Tag, lsv_Cuentas.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un Error al intentar Modificar la Cuenta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Not fn_Proceso_ObtenerCuentas(lsv_Cuentas, tab_Nuevo.Tag) Then
                    MsgBox("Ha ocurrido un Error al intentar Actualizar las Cuentas.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Sub btn_ReferenciaBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReferenciaBaja.Click
        SegundosDesconexion = 0

        If lsv_Referencias.SelectedItems.Count > 0 Then
            If Not fn_Proceso_ReferenciasBaja_Reing(tab_Nuevo.Tag, lsv_Referencias.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un Error al intentar Modificar la Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Not fn_Proceso_ObtenerReferencias(lsv_Referencias, tab_Nuevo.Tag, lsv_Cuentas.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un Error al intentar Actualizar la Referencias", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Sub cbx_Activas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Activas.CheckedChanged
        fn_ClientesProceso_LlenarLista(lsv_Catalogo, cmb_Banco.SelectedValue, cmb_Cia.SelectedValue, chk_Activas.Checked)
        FuncionesGlobales.RegistrosNum(lbl_Registros, lsv_Catalogo.Items.Count)
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
    End Sub

    Private Sub lsv_0_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover, lsv_Cuentas.MouseHover, lsv_Referencias.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Banco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedIndexChanged
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
            btn_Modificar.Enabled = False
            btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedIndexChanged
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
            btn_Modificar.Enabled = False
            btn_Guardar.Enabled = False
        End If
    End Sub
End Class