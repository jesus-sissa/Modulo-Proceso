Imports Banorte
Imports System.Xml

Public Class OrdenDotacionesDivisas
    Inherits BaseOrdenServicio

    Public Sub New(ByVal OrdenesServicio As IOrdenesServicios)
        MyBase.New(OrdenesServicio)
    End Sub

    Public Overrides Function GestionarOrdenServicio() As Boolean
        Dim i As Integer = 0
        Dim xmlDoc As New XmlDocument
        Dim xmlNodeDivisas As XmlNodeList = Nothing
        LimpiarDS()

        Dim OrdenesServicioDotacionesDivisas As List(Of XmlNode) = OrdenServicio.ObtenerOrdeneServicio()

        Try
            For Each Servicio In OrdenesServicioDotacionesDivisas
                xmlDoc = Nothing
                xmlDoc = New XmlDocument

                xmlDoc.LoadXml(Servicio.OuterXml)

                Dim xmlOrdenes As XmlNodeList = xmlDoc.GetElementsByTagName("Orden")

                For Each nodo As XmlNode In xmlOrdenes
                    i += 1
                    Dim hijos As XmlNodeList = nodo.ChildNodes()

                    Dim r As ds_Banorte.DotacionesRow = dsBanorte.Dotaciones.NewRow

                    r.ID_DOTACION = i

                    For Each hijo As XmlNode In hijos
                        If hijo.Name <> "Divisas" Then
                            setDotaciones(hijo.InnerText, hijo.Name, r)
                            Continue For
                        End If
                        xmlNodeDivisas = hijo.ChildNodes()
                    Next

                    dsBanorte.Dotaciones.Rows.Add(r)

                    For Each Divisa As XmlNode In xmlNodeDivisas

                        Dim drDivisa As ds_Banorte.DotacionesDRow = dsBanorte.DotacionesD.NewRow

                        For Each DivisaHijo As XmlNode In Divisa.ChildNodes()
                            setDotacionesD(i, DivisaHijo.InnerText, DivisaHijo.Name, drDivisa)
                        Next
                        dsBanorte.DotacionesD.Rows.Add(drDivisa)
                    Next
                Next
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Overrides Function GetDotaciones() As DataTable
        dt_Dotaciones.Rows.Clear()
        Dim Dotaciones = From DT As ds_Banorte.DotacionesRow In dsBanorte.Dotaciones _
                         Join TS As ds_Banorte.TipoSolicitudRow In dsBanorte.TipoSolicitud On TS.Id_Solicitud Equals DT.ID_TIPOSOLICITUD _
                         Join OA As ds_Banorte.OrdenesArchivoRow In dsBanorte.OrdenesArchivo On OA.Odes Equals DT.ODES _
                         Where DT.ID_CR = CrCajaBancaria _
                         Select DT.ID_DOTACION, DT.ODES, DT.ID_CR, DT.ID_MOVIMIENTO, TS.TipoSolicitud, DT.ID_PROVEEDORPROCESO, DT.ID_PROVEEDORTRASLADO, DT.ID_TIPOSOLICITUD, DT.FECHA_ATENCION, OA.Archivo, OA.NumeroOrden



        For Each item In Dotaciones
            Dim dr As DataRow = dt_Dotaciones.NewRow


            dr("Id_Dotacion") = item.ID_DOTACION
            dr("Odes") = item.ODES
            dr("IDcr") = item.ID_CR
            dr("IDMovimiento") = item.ID_MOVIMIENTO
            dr("TipoSolicitud") = item.TipoSolicitud
            dr("IDProveedorProceso") = item.ID_PROVEEDORPROCESO
            dr("IDProveedorTraslado") = item.ID_PROVEEDORTRASLADO
            dr("IDTipoSolicitud") = item.ID_TIPOSOLICITUD
            dr("FechaAtencion") = item.FECHA_ATENCION
            dr("NombreArchivo") = item.Archivo
            dr("NumeroOrden") = item.NumeroOrden
            dt_Dotaciones.Rows.Add(dr)

        Next
        Return dt_Dotaciones
    End Function

    Public Overrides Function GetDotacionesD(ByVal Id_Dota As Integer) As System.Data.DataTable
        dt_DotacionesD.Rows.Clear()
        Dim DotacionesD = From DD As ds_Banorte.DotacionesDRow In dsBanorte.DotacionesD _
                          Join DI As ds_Banorte.DivisaRow In dsBanorte.Divisa On DD.ID_Divisa Equals DI.Id_Divisa _
                          Join TD As ds_Banorte.DivisaTipoRow In dsBanorte.DivisaTipo On DD.ID_TipoDivisa Equals TD.Id_TipoDivisa _
                          Where DD.Id_Dotacion = Id_Dota _
                          Select DI.Divisa, TD.TipoDivisa, DD.Denominacion, DD.Cantidad, DD.Importe, DD.ID_Divisa, DD.ID_TipoDivisa, DD.Id_Denominacion, DD.Id_Dotacion, DD.Id_Moneda

        For Each item In DotacionesD
            Dim dr As DataRow = dt_DotacionesD.NewRow
            dr("Divisa") = item.Divisa
            dr("TipoDivisa") = item.TipoDivisa
            dr("Denominacion") = item.Denominacion
            dr("Cantidad") = item.Cantidad
            dr("Importe") = item.Importe
            dr("Id_Divisa") = item.ID_Divisa
            dr("Id_TipoDivisa") = item.ID_TipoDivisa
            dr("Id_Denominacion") = item.Id_Denominacion
            dr("Id_Dotacion") = item.Id_Dotacion
            dr("Id_Moneda") = item.Id_Moneda
            dt_DotacionesD.Rows.Add(dr)
        Next
        Return dt_DotacionesD
    End Function

    Private Sub setDotaciones(ByVal Valor As String, ByVal NombreNodo As String, ByRef dr As ds_Banorte.DotacionesRow)
        Select Case NombreNodo.ToUpper()
            Case "ODES"
                dr.ODES = Valor
            Case "ID_CR"
                dr.ID_CR = Valor
            Case "ID_MOVIMIENTO"
                dr.ID_MOVIMIENTO = Valor
            Case "ID_TIPOSOLICITUD"
                dr.ID_TIPOSOLICITUD = Valor
            Case "ID_PROVEEDORPROCESO"
                dr.ID_PROVEEDORPROCESO = Valor
            Case "ID_PROVEEDORTRASLADO"
                dr.ID_PROVEEDORTRASLADO = Valor
            Case "FECHA_ATENCION"
                dr.FECHA_ATENCION = Valor
        End Select
    End Sub

    Private Sub setDotacionesD(ByVal IdDotacion As Integer, ByVal Valor As String, ByVal NombreNodo As String, ByRef dr As ds_Banorte.DotacionesDRow)
        dr.Id_Dotacion = IdDotacion
        Select Case NombreNodo.ToUpper()
            Case "ID_DIVISA"
                dr.ID_Divisa = Valor
            Case "ID_TIPO_DIVISA"
                dr.ID_TipoDivisa = Valor
            Case "DENOMINACION"
                dr.Denominacion = Valor
            Case "CANTIDAD"
                dr.Cantidad = Valor
            Case "IMPORTE"
                dr.Importe = Valor
        End Select
    End Sub

    Protected Overrides Sub SetColumnas()

        dt_Dotaciones.Columns.Add("Id_Dotacion")
        dt_Dotaciones.Columns.Add("Odes")
        dt_Dotaciones.Columns.Add("IDcr")
        dt_Dotaciones.Columns.Add("IDMovimiento")
        dt_Dotaciones.Columns.Add("TipoSolicitud")
        dt_Dotaciones.Columns.Add("IDProveedorProceso")
        dt_Dotaciones.Columns.Add("IDProveedorTraslado")
        dt_Dotaciones.Columns.Add("IDTipoSolicitud")
        dt_Dotaciones.Columns.Add("FechaAtencion")
        dt_Dotaciones.Columns.Add("NombreArchivo")
        dt_Dotaciones.Columns.Add("NumeroOrden")



        dt_DotacionesD.Columns.Add("Divisa")
        dt_DotacionesD.Columns.Add("TipoDivisa")
        dt_DotacionesD.Columns.Add("Denominacion")
        dt_DotacionesD.Columns.Add("Cantidad")
        dt_DotacionesD.Columns.Add("Importe")
        dt_DotacionesD.Columns.Add("Id_Divisa")
        dt_DotacionesD.Columns.Add("Id_TipoDivisa")
        dt_DotacionesD.Columns.Add("Id_Denominacion")
        dt_DotacionesD.Columns.Add("Id_Dotacion")
        dt_DotacionesD.Columns.Add("Id_Moneda")
    End Sub

End Class
