﻿Public Class OrdenDotacionesRetirosBanxico
    Inherits OrdenConcentracionesDivisas
    Public Sub New(ByVal OrdenesServicio As Banorte.IOrdenesServicios)
        MyBase.New(OrdenesServicio)
    End Sub
End Class
