Imports Banorte
Public MustInherit Class BaseOrdenServicio

    Protected OrdenServicio As IOrdenesServicios
    Protected dt_Dotaciones As New DataTable
    Protected dt_DotacionesD As New DataTable
    Public dsBanorte As New ds_Banorte
    Protected divisa As New Divisa
    Private _CRCajaBancaria As Integer



    Public Sub New(ByVal OrdenServicio As IOrdenesServicios)
        Me.OrdenServicio = OrdenServicio
        SetColumnas()
        divisa.getDivisaTipo(dsBanorte.DivisaTipo)
        divisa.getTipoSolicitud(dsBanorte.TipoSolicitud)
        divisa.getDivisa(dsBanorte.Divisa)
        divisa.getDenominaciones(dsBanorte.Denominaciones)
        divisa.getTipoDotacion(dsBanorte.TipoDotacion)
    End Sub

    Public Property CrCajaBancaria() As Integer
        Get
            Return _CRCajaBancaria
        End Get
        Set(ByVal value As Integer)
            _CRCajaBancaria = value
        End Set
    End Property

    Public MustOverride Function GestionarOrdenServicio() As Boolean
    Public MustOverride Function GetDotaciones() As DataTable
    Public MustOverride Function GetDotacionesD(ByVal Id_Dotacion As Integer) As DataTable
    Protected MustOverride Sub SetColumnas()
    'Public MustOverride Sub MapearDenominaciones()
    Protected Sub LimpiarDS()

        dsBanorte.DotacionesD.Rows.Clear()
        dsBanorte.Dotaciones.Rows.Clear()
        dsBanorte.OrdenesArchivo.Rows.Clear()

        dt_Dotaciones.Rows.Clear()
        dt_DotacionesD.Rows.Clear()


    End Sub

    Private Function GetDenominacionID(ByVal Moneda As Integer, ByVal Denominacion As Decimal, ByVal Presentacion As String) As Integer
        Dim DivisaDenominacion = (From r As ds_Banorte.DenominacionesRow In dsBanorte.Denominaciones _
                                 Where r.Id_Moneda = Moneda _
                                 And r.Denominacion = Denominacion _
                                 And r.Presentacion = Presentacion _
                                 Select r.Id_Denominacion).First()

        Return CInt(DivisaDenominacion)
    End Function

    Public Sub MapearDenominaciones()

        ' en expresión del case, es el valor de las monedas con respecto al archivo que envía el banco.
        ' el primer parametro que recibe el metodo GetDenominacionID es el valor de las Monedas con respecto a la taba de Monedas de nuestra BD
        For Each r As ds_Banorte.DotacionesDRow In dsBanorte.DotacionesD
            Dim Presentacion As String = ""

            'para obtener el tipo de presentacion de las denominaciones de cada divisa, se compara el tipo divisa de la orden contra el valor(Id) tipo divisa de la taba Banorte_TipoDivisa
            'Esto se hace con el objeto de mapear el Id_Denominacion de nuestra BD de la tabla 'denominacion' de forma correcta, en nuestra orden de servicio
            'En algunas divisas no hubo la necesidad de evaluarle su tipo,si es  billete o Moneda ya que solo tienen un tipo, Monedas.
            Select Case r.ID_Divisa
                Case 1 'pesos
                    Presentacion = EvaluarTipoDivisa(r.ID_TipoDivisa)
                    'If r.ID_TipoDivisa = 1 Or r.ID_TipoDivisa = 500 Or r.ID_TipoDivisa = 100 Then Presentacion = "B"
                    If r.ID_TipoDivisa = 2 Then Presentacion = "M"

                    r.Id_Denominacion = GetDenominacionID(1, r.Denominacion, Presentacion)
                    r.Id_Moneda = 1
                Case 2 'dolar
                    If r.ID_TipoDivisa = 1 Then Presentacion = "B"
                    If r.ID_TipoDivisa = 2 Then Presentacion = "M"

                    r.Id_Denominacion = GetDenominacionID(2, r.Denominacion, Presentacion)
                    r.Id_Moneda = 2
                Case 3 'oro
                    r.Id_Denominacion = GetDenominacionID(5, r.Denominacion, "M")
                    r.Id_Moneda = 5
                Case 4 'plata
                    r.Id_Denominacion = GetDenominacionID(4, r.Denominacion, "M")
                    r.Id_Moneda = 4
                Case 5 'Euro
                    r.Id_Denominacion = GetDenominacionID(3, r.Denominacion, "B")
                    r.Id_Moneda = 3
                Case 6 'Dolar Canadiense
                    If r.ID_TipoDivisa = 1 Then Presentacion = "B"
                    If r.ID_TipoDivisa = 2 Then Presentacion = "M"

                    r.Id_Denominacion = GetDenominacionID(7, r.Denominacion, Presentacion)
                    r.Id_Moneda = 7
                Case 7 'Franco Frances
                    If r.ID_TipoDivisa = 1 Then Presentacion = "B"
                    If r.ID_TipoDivisa = 2 Then Presentacion = "M"

                    r.Id_Denominacion = GetDenominacionID(8, r.Denominacion, Presentacion)
                    r.Id_Moneda = 8
                Case 8 'Franco Suizo
                    If r.ID_TipoDivisa = 1 Then Presentacion = "B"
                    If r.ID_TipoDivisa = 2 Then Presentacion = "M"

                    r.Id_Denominacion = GetDenominacionID(9, r.Denominacion, Presentacion)
                    r.Id_Moneda = 9
                Case 9 'Libra Esterlina
                    If r.ID_TipoDivisa = 1 Then Presentacion = "B"
                    If r.ID_TipoDivisa = 2 Then Presentacion = "M"

                    r.Id_Denominacion = GetDenominacionID(10, r.Denominacion, Presentacion)
                    r.Id_Moneda = 10
                Case 10 'Peseta Española
                    If r.ID_TipoDivisa = 1 Then Presentacion = "B"
                    If r.ID_TipoDivisa = 2 Then Presentacion = "M"

                    r.Id_Denominacion = GetDenominacionID(11, r.Id_Denominacion, Presentacion)
                    r.Id_Moneda = 11
            End Select
            r.AcceptChanges()
        Next
    End Sub


    Private Function EvaluarTipoDivisa(ByVal Id_TipoDivisa As Long) As String
        Select Case Id_TipoDivisa
            Case 1
                Return "B"
            Case 1000
                Return "B"
            Case 500
                Return "B"
            Case 200
                Return "B"
            Case 100
                Return "B"
            Case 50
                Return "B"
            Case 20
                Return "B"
        End Select
    End Function


    Public Sub GestionarNombreArchivo()
        dsBanorte.OrdenesArchivo.Rows.Clear()

        Dim odesNombreArchivo As List(Of OrdenArchivo) = Me.OrdenServicio.ObtenerNombreArchivo()

        For Each Archivo In odesNombreArchivo
            Dim r As ds_Banorte.OrdenesArchivoRow = dsBanorte.OrdenesArchivo.NewRow
            r.Odes = Archivo.Odes
            r.Archivo = Archivo.Archivo
            r.NumeroOrden = Archivo.NumeroOrden
            dsBanorte.OrdenesArchivo.Rows.Add(r)
        Next
    End Sub
End Class
