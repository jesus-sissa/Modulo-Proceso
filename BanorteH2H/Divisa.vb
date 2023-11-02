Imports Modulo_Proceso.Cn_Proceso
Public Class Divisa

    Public Sub getDivisa(ByRef Divisa As ds_Banorte.DivisaDataTable)
        fn_Banorte_Divisa_Obtener(Divisa)
    End Sub

    Public Sub getTipoSolicitud(ByRef TSolicitud As ds_Banorte.TipoSolicitudDataTable)
        fn_Banorte_TipoSolicitud_Obtener(TSolicitud)
    End Sub

    Public Sub getDivisaTipo(ByRef TipoDivisa As ds_Banorte.DivisaTipoDataTable)
        fn_Banorte_TipoDivisa_Obtener(TipoDivisa)
    End Sub

    Public Sub getTipoDotacion(ByRef TipoDota As ds_Banorte.TipoDotacionDataTable)
        fn_Banorte_TipoDotacion_Obtener(TipoDota)
    End Sub

    Public Sub getDenominaciones(ByRef denoniminaciones As ds_Banorte.DenominacionesDataTable)
        Fn_DenominacionTotal_Obtener(denoniminaciones)
    End Sub

End Class
