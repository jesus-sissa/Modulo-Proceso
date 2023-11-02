Imports Modulo_Proceso.Cn_Proceso
Imports Banorte
Imports System.Xml

Public Class frm_CrearDotacionesH2H
    Dim WithEvents _OrdenesServicio As IOrdenesServicios
    Dim _BaseOrdenServicio As BaseOrdenServicio
    Dim _TipoDotacionSeleccionado As Integer = 0
    Dim i As Integer = 0

    Private Sub frm_CrearDotacionesH2H_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_TipoDotacion.AgregarItem("1", "DOTACION CLIENTE")
        cmb_TipoDotacion.AgregarItem("2", "DOTACION A SUCURSAL BANCARIA")
        cmb_TipoDotacion.AgregarItem("3", "ENVIO A UNA CAJA PRINCIPAL")
        cmb_TipoDotacion.AgregarItem("4", "DEPOSITO BANXICO")
        cmb_TipoDotacion.AgregarItem("5", "VENTA DE MORRALLA")
        cmb_TipoDotacion.AgregarItem("6", "CONCENTRACIONES DIVISAS")

        Dim año As Integer = 2020
        Dim Mes As Integer = 8
        Dim Dia As Integer = 3

        Dim Fecha As New DateTime(año, Mes, Dia)

        cmb_CajaBancaria.Actualizar()
        cmb_Cia.Actualizar()
        ActualizarClientes()
        cmb_Moneda.Actualizar()

        cmb_Documentos.AgregarItem("S", "Sí")
        cmb_Documentos.AgregarItem("N", "No")
        cmb_Documentos.SelectedValue = "N"

        cmb_Tipos.AgregarItem("S", "Sí")
        cmb_Tipos.AgregarItem("N", "No")
        cmb_Tipos.SelectedValue = "N"

        cmb_Nomina.AgregarItem("S", "Sí")
        cmb_Nomina.AgregarItem("N", "No")
        cmb_Nomina.SelectedValue = "N"
    End Sub

    Private Sub btn_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cliente.Click
        SegundosDesconexion = 0
        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Primero debe Indicar la Caja Bancaria.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If
        Dim frm As New Frm_BuscarCliente
        frm.Id_CajaBancaria = cmb_CajaBancaria.SelectedValue
        frm.Consulta = Frm_BuscarCliente.Query.ClientesP

        frm.ShowDialog()

        If frm.Id > 0 Then cmb_Cliente.SelectedValue = frm.Id
    End Sub


    'Private Sub cmb_TipoDotacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDotacion.SelectedIndexChanged

    'End Sub

    Private Sub ActualizarClientes(Optional ByVal sender As Object = Nothing, Optional ByVal e As System.EventArgs = Nothing) Handles cmb_Cia.SelectedValueChanged, cmb_CajaBancaria.SelectedValueChanged
        SegundosDesconexion = 0

        cmb_Cliente.Actualizar(fn_PrepararDotaciones_LlenarClientes(cmb_CajaBancaria.SelectedValue, cmb_Cia.SelectedValue))
        'Le quite la caja bancaria porque se debe poder dotar clientes de una caja con saldo de la otra
        'If cmb_Cia.SelectedValue = Nothing Then Exit Sub
        'cmb_Cliente.Actualizar(fn_PrepararDotaciones_LlenarClientes(cmb_Cia.SelectedValue))
    End Sub


    Private Sub cmb_Documentos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Documentos.SelectedValueChanged

        cmb_Tipos.Enabled = Not cmb_Documentos.SelectedValue = "S"
        tbx_ImpDoc.Enabled = cmb_Documentos.SelectedValue = "S"

        If cmb_Documentos.SelectedValue = "N" Then tbx_ImpDoc.Clear()
        If cmb_Documentos.SelectedValue = "S" Then tbx_ImpNom.Clear()

        cmb_Nomina.Enabled = cmb_Documentos.SelectedValue = "N"

        If Not cmb_Nomina.Enabled Then
            cmb_Nomina.SelectedValue = "N"
            tbx_Sobres.Text = 0
        End If

        DestildarDotacion()

    End Sub

    Private Sub cmb_Nomina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nomina.SelectedIndexChanged
        tbx_Sobres.Enabled = cmb_Nomina.SelectedValue = "S"
        tbx_ImpNom.Clear()
    End Sub

    Private Sub cmb_Nomina_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nomina.SelectedValueChanged
        tbx_Sobres.Enabled = cmb_Nomina.SelectedValue = "S"
        tbx_Sobres.Text = 0
    End Sub

    Private Sub lsv_Dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.SelectedIndexChanged
        If lsv_Dotaciones.SelectedItems.Count = 0 Then Exit Sub
        lsv_Denominacion.Items.Clear()
        lsv_Denominacion.Actualizar(_BaseOrdenServicio.GetDotacionesD(lsv_Dotaciones.SelectedItems(0).Tag), "Id_Dotacion")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If validar() Then
            If tbx_Sobres.Text = "" Then tbx_Sobres.Text = 0
            If tbx_ImpDoc.Text = "" Then tbx_ImpDoc.Text = 0
            If tbx_Importe.Text = "" Then tbx_Importe.Text = 0
            If tbx_ImpNom.Text = "" Then tbx_ImpNom.Text = 0


            If fn_PrepararDotacionesH2H_Guardar(ArchivosConfirma(), lsv_Dotaciones, lsv_Denominacion, cmb_CajaBancaria.SelectedValue, cmb_Cliente.SelectedValue, tbx_Importe.Text, dtp_Entrega.Value, cmb_Documentos.SelectedValue, cmb_Nomina.SelectedValue, CInt(tbx_Sobres.Text), Format(dtp_HoraSolicita.Value, "HH:mm"), cmb_TipoDotacion.SelectedValue, tbx_ImpDoc.Text, tbx_ImpNom.Text, cmb_Moneda.SelectedValue, _BaseOrdenServicio) Then
                MsgBox("La dotacion se ha guardado correctamente", MsgBoxStyle.Information, frm_MENU.Text)
                cmb_TipoDotacion.SelectedValue = 0
                cmb_TipoDotacion.SelectedValue = _TipoDotacionSeleccionado
            Else
                MsgBox("Ha ocurrido un error al intentar generar la dotacion", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Function ArchivosConfirma() As List(Of Banorte.OdesArchivo)
        Dim OdesArchivos As New List(Of Banorte.OdesArchivo)
        Dim i As Integer = 0

        Dim Archivos As System.Collections.Generic.IEnumerable(Of String) = Nothing
        ' el parametro que se le pasa al metodo Archivos, es la posicion de la columna en el servicio correspondiente
        If TypeOf _BaseOrdenServicio Is OrdenDotacionesDivisas Or TypeOf _BaseOrdenServicio Is OrdenDotacionesClientes Then
            i = 8
            Archivos = ObtenerArchivos(i)
        ElseIf TypeOf _BaseOrdenServicio Is OrdenConcentracionesDivisas Then
            i = 5
            Archivos = ObtenerArchivos(i)
        End If

        Dim NumArchivo As Integer = 0

        For Each Archivo In Archivos
            NumArchivo += 1
            Dim Odes As New Banorte.OdesArchivo()
            Odes.NombreArchivo = New String(Archivo.ToArray())
            Odes.NumeroArchivo = NumArchivo

            For Each item As ListViewItem In lsv_Dotaciones.CheckedItems
                If New String(Archivo.ToArray()) = item.SubItems(i).Text Then
                    Dim OdesConfirmar As New Banorte.BaseOdesConfirmacion(item.Text, item.Text & "1", item.SubItems(lsv_Dotaciones.Columns.Count - 1).Text)
                    Odes.OrdeneConfirmada = OdesConfirmar
                End If
            Next
            OdesArchivos.Add(Odes)
        Next
        Return OdesArchivos
    End Function

    Private Function ObtenerArchivos(ByVal i As Integer) As System.Collections.Generic.IEnumerable(Of String)
        Return (From item As ListViewItem In lsv_Dotaciones.CheckedItems _
                        Select item.SubItems(i).Text).Distinct()
    End Function

    Private Sub cmb_TipoDotacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoDotacion.SelectedValueChanged
        SegundosDesconexion = 0
        _OrdenesServicio = Nothing
        _BaseOrdenServicio = Nothing
        lsv_Dotaciones.Items.Clear()
        lsv_Denominacion.Items.Clear()
        cmb_CajaBancaria.SelectedValue = 0
        If cmb_TipoDotacion.SelectedValue = "0" Then Exit Sub

        Try
            Select Case CInt(cmb_TipoDotacion.SelectedValue)
                Case 1
                    _OrdenesServicio = New OdesDotacionesClientes("90011")
                    _BaseOrdenServicio = New OrdenDotacionesClientes(_OrdenesServicio)
                    _TipoDotacionSeleccionado = 1
                Case 2
                    _OrdenesServicio = New OdesDotacionesDivisas("90011")
                    _BaseOrdenServicio = New OrdenDotacionesDivisas(_OrdenesServicio)
                    _TipoDotacionSeleccionado = 2

                Case 6
                    _OrdenesServicio = New OdesDotacionesConcentraciones("90011")
                    _BaseOrdenServicio = New OrdenConcentracionesDivisas(_OrdenesServicio)
                    _TipoDotacionSeleccionado = 6
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End Try

        gbx_dotacion.Enabled = CInt(cmb_TipoDotacion.SelectedValue) > 0
    End Sub

    Private Function validar() As Boolean

        If cmb_TipoDotacion.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Tipo de Dotación.", 16 + 0, frm_MENU.Text)
            cmb_TipoDotacion.Focus()
            Return False
        End If

        If cmb_CajaBancaria.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Caja Bancaria.", 16 + 0, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Return False
        End If
        If cmb_Cia.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Compañia de Traslado.", 16 + 0, frm_MENU.Text)
            cmb_Cia.Focus()
            Return False
        End If
        'If cmb_Cliente.SelectedValue = "0" Then
        '    MsgBox("Debe seleccionar un Cliente.", 16 + 0, frm_MENU.Text)
        '    cmb_Cliente.Focus()
        '    Return False
        'End If
        
        'If cmb_Tipos.SelectedValue = "0" And cmb_Documentos.SelectedValue = "N" Then
        '    MsgBox("Debe seleccionar si la dotacion es por tipos.", 16 + 0, frm_MENU.Text)
        '    cmb_Tipos.Focus()
        '    Return False
        'End If
        'If cmb_Documentos.SelectedValue = "0" Then
        '    MsgBox("Debe indicar si la Dotación es de Documentos o No.", 16 + 0, frm_MENU.Text)
        '    cmb_Documentos.Focus()
        '    Return False
        'End If
        'If tbx_Importe.Text = "" And cmb_Documentos.SelectedValue = "N" And cmb_Nomina.SelectedValue = "N" Then
        '    MsgBox("Debe capturar el Importe de la Dotación.", 16 + 0, frm_MENU.Text)
        '    Return False
        'End If

        'If tbx_ImpDoc.Text = "" And cmb_Documentos.SelectedValue = "S" Then
        '    MsgBox("Debe capturar el Importe de los Documentos.", 16 + 0, frm_MENU.Text)
        '    Return False
        'End If

        'If tbx_ImpNom.Text = "" And cmb_Nomina.SelectedValue = "0" Then
        '    MsgBox("Debe capturar el Importe de la Nomina.", 16 + 0, frm_MENU.Text)
        '    Return False
        'End If

        If cmb_Documentos.SelectedValue = "N" Then
            If cmb_Nomina.SelectedValue = "0" Then
                MsgBox("Debe indicar si la Dotación es de Nominas o No.", 16 + 0, frm_MENU.Text)
                cmb_Nomina.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub cmb_Cliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedValueChanged
        If (cmb_TipoDotacion.SelectedValue > 0 And cmb_Cliente.SelectedValue > 0) And Not _BaseOrdenServicio Is Nothing Then
            _BaseOrdenServicio.GestionarOrdenServicio()
            _BaseOrdenServicio.GestionarNombreArchivo()
            _BaseOrdenServicio.MapearDenominaciones()
            _BaseOrdenServicio.CrCajaBancaria = cmb_CajaBancaria.SelectedValue
            lsv_Dotaciones.Actualizar(_BaseOrdenServicio.GetDotaciones(), "Id_Dotacion")
        End If
    End Sub

    Public Function CalculaImporte(ByVal Id_Dotacion As Integer) As Integer
        Dim Denominacion As DataTable = _BaseOrdenServicio.GetDotacionesD(Id_Dotacion)

        Return (From dr As DataRow In Denominacion _
               Select dr).Sum(Function(dr As DataRow) CDec(dr("Importe")))
    End Function


    Public Sub DestildarDotacion()
        For Each item As ListViewItem In lsv_Dotaciones.CheckedItems
            item.Checked = False
        Next
    End Sub
End Class