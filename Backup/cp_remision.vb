
Public Enum Horario As Byte
    Matutino
    Vespertino
    Nocturno
    No_Imprimir
End Enum

Public Enum Servicio As Byte
    Ordinario
    Especial
    No_Imprimir
End Enum

Public Enum Tipo_Desglose As Byte
    Solo_Piezas
    Solo_Importe
    Piezas_e_Importe
End Enum

Public Structure cp_Remision

#Region "Variables Privadas"
    'Campos de la tabla de uso del cliente
    Private _Clave As String
    Private _Cia As String
    Private _Unidad As String
    Private _Horario As Horario
    Private _Servicio As Servicio
    Private _Origen As String
    Private _DireccionOrigen As String
    Private _Efectivo As Decimal
    Private _Doctos As Decimal
    Private _MonedaNacional As Decimal
    Private _MonedaExtranjera As Decimal
    Private _Otros As Decimal
    Private _Imprime_EquivalenteMN As Boolean
    Private _EquivalenteMN As Decimal
    Private _Total As Decimal
    Private _EnvasesBilletes As Short
    Private _EnvasesMorralla As Short
    Private _EnvasesDocumentos As Short
    Private _EnvasesSN As Short
    Private _EnvasesTotal As Short
    Private _Destino As String
    Private _DireccionDestino As String
    Private _NumeroMach As String
    Private _Sellos As String
    Private _Sobres As Integer

    Private _Imprime_Denominaciones As Boolean
    Private _Tipo_Imprime_Denominaciones As Tipo_Desglose
    Private _Formato2011 As Boolean
    Private _Id_Moneda As Integer 'Moneda de la Dotacion, resguardo o envío
    Private _Moneda As String 'Descripcion de la Moneda de la Dotacion, resguardo o envío

    'Campos de la tabla de uso de sissa
    Private _Remitente As String

    'Campos de la tabla Billetes
    Private _B1000 As Integer
    Private _B500 As Integer
    Private _B200 As Integer
    Private _B100 As Integer
    Private _B50 As Integer
    Private _B20 As Integer
    Private _B10 As Integer
    Private _B5 As Integer
    Private _B2 As Integer
    Private _B1 As Integer

    'Campos de la tabla Monedas
    Private _M100 As Integer
    Private _M50 As Integer
    Private _M20 As Integer
    Private _M10 As Integer
    Private _M5 As Integer
    Private _M2 As Integer
    Private _M1 As Integer
    Private _M05 As Integer
    Private _M02 As Integer
    Private _M01 As Integer
    Private _M005 As Integer
    Private _TotalEnvio As Integer
#End Region

#Region "Propiedades Publicas"

    ''' <summary>
    ''' Es un campo que desplega la clave del cliente en la esquina superior izquierda de la remision
    ''' </summary>
    Public Property Clave() As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property

    ''' <summary>
    ''' Es un campo que desplega el nombre de la cia de traslado en la parte superior de la remision
    ''' </summary>
    Public Property Cia() As String
        Get
            Return _Cia
        End Get
        Set(ByVal value As String)
            _Cia = value
        End Set
    End Property

    ''' <summary>
    ''' Es un campo que desplega la unidad en la esquina superior derecha de la remision
    ''' </summary>
    Public Property Unidad() As String
        Get
            Return _Unidad
        End Get
        Set(ByVal value As String)
            _Unidad = value
        End Set
    End Property

    ''' <summary>
    ''' El la fecha de impresión de la remision, siempre es la fecha actual
    ''' </summary>
    Public ReadOnly Property Fecha() As Date
        Get
            Return Today
        End Get
    End Property

    ''' <summary>
    ''' El el checkbox de horario que va a ir tachado en la remision
    ''' </summary>
    Public Property Horario() As Horario
        Get
            Return _Horario
        End Get
        Set(ByVal value As Horario)
            _Horario = value
        End Set
    End Property

    ''' <summary>
    ''' El el checkbox de servicio que va a ir tachado en la remision
    ''' </summary>
    Public Property Servicio() As Servicio
        Get
            Return _Servicio
        End Get
        Set(ByVal value As Servicio)
            _Servicio = value
        End Set
    End Property

    ''' <summary>
    ''' Indica si se imprimirá solo la cantidad de Piezas, Solo los Importes o Ambos
    ''' </summary>
    Public Property Tipo_Imprime_Denominaciones() As Tipo_Desglose
        Get
            Return _Tipo_Imprime_Denominaciones
        End Get
        Set(ByVal value As Tipo_Desglose)
            _Tipo_Imprime_Denominaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Es el valor que se colocara en el campo "valores recibidos de:"
    ''' de la remision
    ''' </summary>
    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property

    ''' <summary>
    ''' Es el valor que se colocara en el campo "Direccion:"
    ''' Debajo del campo "valores recibidos de:" de la remision
    ''' </summary>
    Public Property DireccionOrigen() As String
        Get
            Return _DireccionOrigen
        End Get
        Set(ByVal value As String)
            _DireccionOrigen = value
        End Set
    End Property

    ''' <summary>
    ''' Es en el total en efectivo cuyo valor se colocara en el 
    ''' campo "EFEVO." de la remision
    ''' </summary>
    Public Property Efectivo() As Decimal
        Get
            Return _Efectivo
        End Get
        Set(ByVal value As Decimal)
            _Efectivo = value
        End Set
    End Property

    ''' <summary>
    ''' Es el importe en documentos que va contenido en el campo
    ''' "DOCTOS." de la remision
    ''' </summary>
    Public Property Doctos() As Decimal
        Get
            Return _Doctos
        End Get
        Set(ByVal value As Decimal)
            _Doctos = value
        End Set
    End Property

    ''' <summary>
    ''' Es el importe en Moneda Local que va contenido en
    ''' el campo "Moneda Nacional" de la remision
    ''' </summary>
    Public Property MonedaNacional() As Decimal
        Get
            Return _MonedaNacional
        End Get
        Set(ByVal value As Decimal)
            _MonedaNacional = value
        End Set
    End Property

    ''' <summary>
    ''' Es la suma de los importes en monedas diferentes a la local
    ''' sin convertir a la moneda local y van contenidas en el campo
    ''' "MONEDA EXTRANJERA" de la remision
    ''' </summary>
    Public Property MonedaExtranjera() As Decimal
        Get
            Return _MonedaExtranjera
        End Get
        Set(ByVal value As Decimal)
            _MonedaExtranjera = value
        End Set
    End Property

    ''' <summary>
    ''' Es el import de otros documentos que va contenido en el campo
    ''' "OTROS" de la tabla
    ''' </summary>
    Public Property Otros() As Decimal
        Get
            Return _Otros
        End Get
        Set(ByVal value As Decimal)
            _Otros = value
        End Set
    End Property

    ''' <summary>
    ''' Indica si se imprimira en la remision el campo  Equivalente (MN)
    ''' </summary>
    ''' <value>
    ''' Cuando el Campo es True = Se muestra el valor
    ''' Cuando el Campo es False = No se muestra el valor
    ''' El valor por defautl es False
    ''' </value>
    Public Property Imprime_EquivalenteMN() As Boolean
        Get
            Return _Imprime_EquivalenteMN
        End Get
        Set(ByVal value As Boolean)
            _Imprime_EquivalenteMN = value
        End Set
    End Property

    ''' <summary>
    ''' Es el importe en moneda extranjera convertido a moneda local
    ''' va contenido en el campo "Equivalente MN"
    ''' </summary>
    Public Property EquivalenteMN() As Decimal
        Get
            Return _EquivalenteMN
        End Get
        Set(ByVal value As Decimal)
            _EquivalenteMN = value
        End Set
    End Property

    ''' <summary>
    ''' Es la suma de los importes en Moneda Nacional, Otros y Equivalente de Moneda Extranjera
    ''' que ira contenido en el campo "Total" de la remision
    ''' </summary>
    Public Property Total() As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            _Total = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de envases con billetes
    ''' y va contenida en el campor "Envases con Billetes"
    ''' de la remision
    ''' </summary>
    Public Property EnvasesBilletes() As Short
        Get
            Return _EnvasesBilletes
        End Get
        Set(ByVal value As Short)
            _EnvasesBilletes = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de envases con morralla y va contenida en el campo
    ''' "Con Morralla de la remision"
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EnvasesMorralla() As Short
        Get
            Return _EnvasesMorralla
        End Get
        Set(ByVal value As Short)
            _EnvasesMorralla = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de envases con Documentos y va contenida en el campo
    ''' "Envases Documentos de la Remision"
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EnvasesDocumentos() As Short
        Get
            Return _EnvasesDocumentos
        End Get
        Set(ByVal value As Short)
            _EnvasesDocumentos = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Envases Sin Numero y va contenido en el campo "Envases con Morralla" en la Remision
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EnvasesSN() As Short
        Get
            Return _EnvasesSN
        End Get
        Set(ByVal value As Short)
            _EnvasesSN = value
        End Set
    End Property

    ''' <summary>
    ''' Es la suma "Tentativamente" de los envases con billetes y los envases con Morralla
    ''' y se desplega en el campo total
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EnvasesTotal() As Short
        Get
            Return _EnvasesTotal
        End Get
        Set(ByVal value As Short)
            _EnvasesTotal = value
        End Set
    End Property

    ''' <summary>
    ''' Es el importe total en texto que va en el campo "Cantidad en Letra:"
    ''' de la remision
    ''' </summary>
    Public ReadOnly Property CantidadLetra() As String
        Get
            Return FuncionesGlobales.fn_EnLetras(_Total, Id_Moneda)
        End Get
    End Property

    ''' <summary>
    ''' Es el valor que va en el campo Entregar Envases de la remisión
    ''' </summary>
    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property

    ''' <summary>
    ''' Es el valor que va en el campo remision de la remision
    ''' </summary>
    Public Property DireccionDestino() As String
        Get
            Return _DireccionDestino
        End Get
        Set(ByVal value As String)
            _DireccionDestino = value
        End Set
    End Property

    ''' <summary>
    ''' Es el valor que va en el campo No de Match de la Remisión
    ''' </summary>
    Public Property NumeroMach() As String
        Get
            Return _NumeroMach
        End Get
        Set(ByVal value As String)
            _NumeroMach = value
        End Set
    End Property

    ''' <summary>
    ''' Es el valor que va en el campo sellos
    ''' Equivale a 2 renglones
    ''' </summary>
    Public Property Sellos() As String
        Get
            Return _Sellos
        End Get
        Set(ByVal value As String)
            _Sellos = value
        End Set
    End Property

    ''' <summary>
    ''' La cantidad de Sobres cuando es una Dotacion de Nómina
    ''' </summary>
    Public Property Sobres() As Integer
        Get
            Return _Sobres
        End Get
        Set(ByVal value As Integer)
            _Sobres = value
        End Set
    End Property

    ''' <summary>
    ''' Es la hora de impresion siempre es la hora actual
    ''' </summary>
    Public ReadOnly Property Hora() As Date
        Get
            Return Now
        End Get
    End Property

    ''' <summary>
    ''' Es el valor que se va a imprimir en el campo Remitente
    ''' </summary>
    Public Property Remitente() As String
        Get
            Return _Remitente
        End Get
        Set(ByVal value As String)
            _Remitente = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $1000.00
    ''' </summary>
    Public Property B1000() As Integer
        Get
            Return _B1000
        End Get
        Set(ByVal value As Integer)
            _B1000 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $500.00
    ''' </summary>
    Public Property B500() As Integer
        Get
            Return _B500
        End Get
        Set(ByVal value As Integer)
            _B500 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $200.00
    ''' </summary>
    Public Property B200() As Integer
        Get
            Return _B200
        End Get
        Set(ByVal value As Integer)
            _B200 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $100.00
    ''' </summary>
    Public Property B100() As Integer
        Get
            Return _B100
        End Get
        Set(ByVal value As Integer)
            _B100 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $50.00
    ''' </summary>
    Public Property B50() As Integer
        Get
            Return _B50
        End Get
        Set(ByVal value As Integer)
            _B50 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $20.00
    ''' </summary>
    Public Property B20() As Integer
        Get
            Return _B20
        End Get
        Set(ByVal value As Integer)
            _B20 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $10.00
    ''' </summary>
    Public Property B10() As Integer
        Get
            Return _B10
        End Get
        Set(ByVal value As Integer)
            _B10 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $5.00
    ''' </summary>
    Public Property B5() As Integer
        Get
            Return _B5
        End Get
        Set(ByVal value As Integer)
            _B5 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $2.00
    ''' </summary>
    Public Property B2() As Integer
        Get
            Return _B2
        End Get
        Set(ByVal value As Integer)
            _B2 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Billetes de $1.00
    ''' </summary>
    Public Property B1() As Integer
        Get
            Return _B1
        End Get
        Set(ByVal value As Integer)
            _B1 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $100.00
    ''' </summary>
    Public Property M100() As Integer
        Get
            Return _M100
        End Get
        Set(ByVal value As Integer)
            _M100 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $50.00
    ''' </summary>
    Public Property M50() As Integer
        Get
            Return _M50
        End Get
        Set(ByVal value As Integer)
            _M50 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $20.00
    ''' </summary>
    Public Property M20() As Integer
        Get
            Return _M20
        End Get
        Set(ByVal value As Integer)
            _M20 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $10.00
    ''' </summary>
    Public Property M10() As Integer
        Get
            Return _M10
        End Get
        Set(ByVal value As Integer)
            _M10 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $5.00
    ''' </summary>
    Public Property M5() As Integer
        Get
            Return _M5
        End Get
        Set(ByVal value As Integer)
            _M5 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $2.00
    ''' </summary>
    Public Property M2() As Integer
        Get
            Return _M2
        End Get
        Set(ByVal value As Integer)
            _M2 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $1.00
    ''' </summary>
    Public Property M1() As Integer
        Get
            Return _M1
        End Get
        Set(ByVal value As Integer)
            _M1 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $0.50
    ''' </summary>
    Public Property M05() As Integer
        Get
            Return _M05
        End Get
        Set(ByVal value As Integer)
            _M05 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $0.20
    ''' </summary>
    Public Property M02() As Integer
        Get
            Return _M02
        End Get
        Set(ByVal value As Integer)
            _M02 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $0.10
    ''' </summary>
    Public Property M01() As Integer
        Get
            Return _M01
        End Get
        Set(ByVal value As Integer)
            _M01 = value
        End Set
    End Property

    ''' <summary>
    ''' Es la cantidad de Monedas de $0.05
    ''' </summary>
    Public Property M005() As Integer
        Get
            Return _M005
        End Get
        Set(ByVal value As Integer)
            _M005 = value
        End Set
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $1000.00
    ''' </summary>
    Public ReadOnly Property B1000L() As Integer
        Get
            Return _B1000 * 1000
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $500.00
    ''' </summary>
    Public ReadOnly Property B500L() As Integer
        Get
            Return _B500 * 500
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $200.00
    ''' </summary>
    Public ReadOnly Property B200L() As Integer
        Get
            Return _B200 * 200
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $100.00
    ''' </summary>
    Public ReadOnly Property B100L() As Integer
        Get
            Return _B100 * 100
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $50.00
    ''' </summary>
    Public ReadOnly Property B50L() As Integer
        Get
            Return _B50 * 50
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $20.00
    ''' </summary>
    Public ReadOnly Property B20L() As Integer
        Get
            Return _B20 * 20
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $10.00
    ''' </summary>
    Public ReadOnly Property B10L() As Integer
        Get
            Return _B10 * 10
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $5.00
    ''' </summary>
    Public ReadOnly Property B5L() As Integer
        Get
            Return _B5 * 5
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $2.00
    ''' </summary>
    Public ReadOnly Property B2L() As Integer
        Get
            Return _B2 * 2
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en billetes de $1.00
    ''' </summary>
    Public ReadOnly Property B1L() As Integer
        Get
            Return _B1 * 1
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $100.00
    ''' </summary>
    Public ReadOnly Property M100L() As Integer
        Get
            Return _M100 * 100
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $50.00
    ''' </summary>
    Public ReadOnly Property M50L() As Integer
        Get
            Return _M50 * 50
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $20.00
    ''' </summary>
    Public ReadOnly Property M20L() As Integer
        Get
            Return _M20 * 20
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $10.00
    ''' </summary>
    Public ReadOnly Property M10L() As Integer
        Get
            Return _M10 * 10
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $5.00
    ''' </summary>
    Public ReadOnly Property M5L() As Integer
        Get
            Return _M5 * 5
        End Get
    End Property

    ''' <summary>
    ''' Es importe en monedas de $2.00
    ''' </summary>
    Public ReadOnly Property M2L() As Integer
        Get
            Return _M2 * 2
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $1.00
    ''' </summary>
    Public ReadOnly Property M1L() As Integer
        Get
            Return _M1
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $0.50
    ''' </summary>
    Public ReadOnly Property M05L() As Integer
        Get
            Return _M05 * 0.5
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $0.20
    ''' </summary>
    Public ReadOnly Property M02L() As Integer
        Get
            Return _M02 * 0.2
        End Get
    End Property

    ''' <summary>
    ''' Es importe en monedas de $0.10
    ''' </summary>
    Public ReadOnly Property M01L() As Integer
        Get
            Return _M01 * 0.1
        End Get
    End Property

    ''' <summary>
    ''' Es el importe en monedas de $0.05
    ''' </summary>
    Public ReadOnly Property M005L() As Integer
        Get
            Return _M005 * 0.05
        End Get
    End Property

    ''' <summary>
    ''' Es el importe de la suma total de las denominaciones de la remision
    ''' el cual se coloca dentro del campo total envio
    ''' </summary>
    Public Property TotalEnvio() As Decimal
        Get
            Return _TotalEnvio
        End Get
        Set(ByVal value As Decimal)
            _TotalEnvio = value
        End Set
    End Property

    ''' <summary>
    ''' Para saber si se imprimen o no las denominaciones
    ''' </summary>
    Public Property Imprime_Denominaciones() As Boolean
        Get
            Return _Imprime_Denominaciones
        End Get
        Set(ByVal value As Boolean)
            _Imprime_Denominaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Para saber si se imprimen en el Formato Tradicional o en el Nuevo Formato 2011
    ''' </summary>
    Public Property Formato2011() As Boolean
        Get
            Return _Formato2011
        End Get
        Set(ByVal value As Boolean)
            _Formato2011 = value
        End Set
    End Property

    ''' <summary>
    ''' Para imprimir en la cantidad con letra
    ''' </summary>
    Public Property Id_Moneda() As Integer
        Get
            Return _Id_Moneda
        End Get
        Set(ByVal value As Integer)
            _Id_Moneda = value
        End Set
    End Property

    ''' <summary>
    ''' Descripcion de la Moneda 'Para imprimir en la cantidad con letra
    ''' </summary>
    Public Property Moneda() As String
        Get
            Return _Moneda
        End Get
        Set(ByVal value As String)
            _Moneda = value
        End Set
    End Property

#End Region

End Structure

Public Class cp_Impresion
    Private WithEvents _Documento As Printing.PrintDocument
    Private _Remision As cp_Remision
    Private _Margen As Integer
    Private _Fuente As Integer = 9

    Public Sub New(ByVal Remision As cp_Remision)
        _Remision = Remision
        _Documento = New Printing.PrintDocument
    End Sub

    Private Function ValidarImpresora() As Boolean

        Dim ResolucionMax As Integer = (From p As Printing.PrinterResolution In _Documento.PrinterSettings.PrinterResolutions Where p.Y > 0 Order By p.Y Descending Select p.Y).FirstOrDefault

        If ResolucionMax > 200 Then
            Select Case MsgBox("La impresora " & _Documento.PrinterSettings.PrinterName & " parece no ser la indicada para las remisiones. Desea continuar?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, frm_MENU.Text)
                Case MsgBoxResult.Yes
                    Return True
                Case MsgBoxResult.No
                    Dim print As New PrintDialog With {.Document = _Documento}
                    If print.ShowDialog = DialogResult.Cancel Then
                        Return False
                    Else
                        Return True
                    End If
                Case MsgBoxResult.Cancel
                    Return False
            End Select
        Else
            Return True
        End If
    End Function

    Private Function ObtenerMargenes() As Boolean
        Dim Impresora As String = _Documento.PrinterSettings.PrinterName
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Impresoras_GetbyNombre", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, Impresora)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                _Margen = Tbl.Rows(0).Item("Margen_Superior")
                Return True
            Else
                _Margen = 0
                Return True
            End If
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            _Margen = 0
            Return False
        End Try
    End Function

    Public Shared Function Imprimir(ByVal Remision As cp_Remision) As Boolean
        Dim yo As New cp_Impresion(Remision)
        If Not yo.ValidarImpresora() Then Return False

        If Not yo.ObtenerMargenes Then
            Return False
        End If
        yo._Documento.DefaultPageSettings = New Printing.PageSettings With {.Landscape = False}

        Try
            yo._Documento.Print()
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _Documento.PrintPage
        e.HasMorePages = False
        Dim Margen As Integer = 0 'En Milimetros. Positivo=Los objetos Bajan, Negativo=Los Objetos Suben
        If _Remision.Formato2011 = True Then
            Margen = 0
            CrearLinea(e.Graphics, _Remision.Unidad, _Fuente, 150, 36 + Margen, 30, 7, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.Cia, _Fuente, 50, 40 + Margen, 100, 3, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.Clave, _Fuente + 2, 50, 46 + Margen, 30, 4, StringAlignment.Far)
            CrearLinea(e.Graphics, _Remision.Fecha, _Fuente + 2, 50, 52 + Margen, 30, 4, StringAlignment.Far)
            Select Case _Remision.Horario
                Case Horario.Matutino
                    CrearLinea(e.Graphics, "X", _Fuente + 1, 105, 45 + Margen, 10, 3, StringAlignment.Near)
                Case Horario.Vespertino
                    CrearLinea(e.Graphics, "X", _Fuente + 1, 105, 48 + Margen, 10, 3, StringAlignment.Near)
                Case Horario.Nocturno
                    CrearLinea(e.Graphics, "X", _Fuente + 1, 105, 51 + Margen, 10, 3, StringAlignment.Near)
            End Select

            Select Case _Remision.Servicio
                Case Servicio.Especial
                    CrearLinea(e.Graphics, "X", _Fuente + 1, 113, 48 + Margen, 10, 3, StringAlignment.Near)
                Case Servicio.Ordinario
                    CrearLinea(e.Graphics, "X", _Fuente + 1, 113, 45 + Margen, 10, 3, StringAlignment.Near)
            End Select

            If _Remision.Origen.Length <= 50 Then
                CrearLinea(e.Graphics, _Remision.Origen, _Fuente + 2, 55, 61 + Margen, 80, 13, StringAlignment.Near)                        'NOMBRE CLIENTE ORIGEN
            Else
                CrearLinea(e.Graphics, _Remision.Origen, _Fuente, 55, 61 + Margen, 80, 13, StringAlignment.Near)                            'NOMBRE CLIENTE ORIGEN
            End If
            If _Remision.DireccionOrigen.Length <= 50 Then
                CrearLinea(e.Graphics, _Remision.DireccionOrigen, _Fuente + 2, 50, 74 + Margen, 80, 13, StringAlignment.Near)               'DIRECCION CLIENTE ORIGEN
            Else
                CrearLinea(e.Graphics, _Remision.DireccionOrigen, _Fuente, 50, 74 + Margen, 80, 13, StringAlignment.Near)                   'DIRECCION CLIENTE ORIGEN
            End If

            CrearLinea(e.Graphics, Format(_Remision.MonedaNacional, "n2"), _Fuente + 2, 150, 60 + Margen, 32, 5, StringAlignment.Far)       'MONEDA NACIONAL
            CrearLinea(e.Graphics, Format(_Remision.MonedaExtranjera, "n2"), _Fuente + 2, 150, 67 + Margen, 32, 5, StringAlignment.Far)     'MONEDA EXTRANJERA
            CrearLinea(e.Graphics, Format(_Remision.Otros, "n2"), _Fuente + 2, 150, 74 + Margen, 32, 5, StringAlignment.Far)                'OTROS
            CrearLinea(e.Graphics, Format(_Remision.Total, "n2"), _Fuente + 2, 145, 81 + Margen, 37, 5, StringAlignment.Far)                'TOTAL
            'AGG 2009-12-28 Estas lineas no se imprimiran porque faltan tipos de envases en la remision
            CrearLinea(e.Graphics, _Remision.EnvasesBilletes, _Fuente + 2, 65, 88 + Margen, 20, 4, StringAlignment.Near)
            If _Remision.EnvasesSN > 0 Then
                Dim Cadena As String = _Remision.EnvasesMorralla & " + " & _Remision.EnvasesSN.ToString & " SN"
                CrearLinea(e.Graphics, Cadena, _Fuente + 2, 85, 88 + Margen, 30, 4, StringAlignment.Near)
            Else
                CrearLinea(e.Graphics, _Remision.EnvasesMorralla, _Fuente + 2, 95, 88 + Margen, 20, 4, StringAlignment.Near)
            End If
            CrearLinea(e.Graphics, _Remision.EnvasesDocumentos & " (Otros)", _Fuente + 2, 120, 88 + Margen, 20, 4, StringAlignment.Near)
            CrearLinea(e.Graphics, _Remision.EnvasesTotal, _Fuente + 2, 160, 88 + Margen, 20, 4, StringAlignment.Near)
            CrearLinea(e.Graphics, _Remision.CantidadLetra, _Fuente, 60, 94 + Margen, 120, 7, StringAlignment.Near)
            If _Remision.Destino.Length <= 50 Then
                CrearLinea(e.Graphics, _Remision.Destino, _Fuente + 2, 65, 102 + Margen, 120, 7, StringAlignment.Near)
            Else
                CrearLinea(e.Graphics, _Remision.Destino, _Fuente, 65, 102 + Margen, 120, 7, StringAlignment.Near)
            End If
            CrearLinea(e.Graphics, _Remision.DireccionDestino, _Fuente, 50, 110 + Margen, 130, 7, StringAlignment.Near)
            CrearLinea(e.Graphics, _Remision.NumeroMach, _Fuente, 50, 123 + Margen, 20, 12, StringAlignment.Near)
            If _Remision.Sellos.Length <= 120 Then
                CrearLinea(e.Graphics, _Remision.Sellos, _Fuente + 4, 70, 118 + Margen, 112, 17, StringAlignment.Near)
            Else
                CrearLinea(e.Graphics, _Remision.Sellos, _Fuente + 1, 70, 118 + Margen, 112, 17, StringAlignment.Near)
            End If
            CrearLinea(e.Graphics, Format(_Remision.Hora, "HH:mm:ss"), _Fuente + 2, 96, 135 + Margen, 20, 4, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.Remitente, _Fuente + 1, 50, 145 + Margen, 65, 4, StringAlignment.Center)

            If _Remision.Imprime_Denominaciones Then

                If _Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Piezas_e_Importe Then
                    'Billetes
                    CrearLinea(e.Graphics, _Remision.B1000, _Fuente, 10, 47 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B1000L, "n2"), _Fuente + 1, 10, 50 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B500, _Fuente, 10, 55 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B500L, "n2"), _Fuente + 1, 10, 58 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B200, _Fuente, 10, 62 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B200L, "n2"), _Fuente + 1, 10, 65 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B100, _Fuente, 10, 70 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B100L, "n2"), _Fuente + 1, 10, 73 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B50, _Fuente, 10, 77 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B50L, "n2"), _Fuente + 1, 10, 80 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B20, _Fuente, 10, 85 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B20L, "n2"), _Fuente + 1, 10, 88 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B10, _Fuente, 10, 92 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B10L, "n2"), _Fuente + 1, 10, 95 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B5, _Fuente, 10, 99 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B5L, "n2"), _Fuente + 1, 10, 102 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B2, _Fuente, 10, 106.5 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B2L, "n2"), _Fuente + 1, 10, 109.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B1, _Fuente, 10, 113.5 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B1L, "n2"), _Fuente + 1, 10, 116.5 + Margen, 28, 4, StringAlignment.Far)
                    'Monedas
                    CrearLinea(e.Graphics, _Remision.M20, _Fuente, 10, 125 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M20L, "n2"), _Fuente + 1, 10, 128 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M10, _Fuente, 10, 132 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M10L, "n2"), _Fuente + 1, 10, 135 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M5, _Fuente, 10, 140 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M5L, "n2"), _Fuente + 1, 10, 143 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M2, _Fuente, 10, 147 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M2L, "n2"), _Fuente + 1, 10, 150 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M1, _Fuente, 10, 154.5 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M1L, "n2"), _Fuente + 1, 10, 157.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M05, _Fuente, 10, 162 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M05L, "n2"), _Fuente + 1, 10, 165 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M02, _Fuente, 10, 169.5 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M02L, "n2"), _Fuente + 1, 10, 172.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M01, _Fuente, 10, 176.5 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M01L, "n2"), _Fuente + 1, 10, 179.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M005, _Fuente, 10, 185 + Margen, 28, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M005L, "n2"), _Fuente + 1, 10, 188 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.TotalEnvio, "n2"), _Fuente + 2, 10, 194 + Margen, 30, 5, StringAlignment.Far)
                ElseIf _Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Solo_Piezas Then
                    'Billetes
                    CrearLinea(e.Graphics, _Remision.B1000, _Fuente + 2, 10, 47 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B500, _Fuente + 2, 10, 55 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B200, _Fuente + 2, 10, 62 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B100, _Fuente + 2, 10, 70 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B50, _Fuente + 2, 10, 77 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B20, _Fuente + 2, 10, 85 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B10, _Fuente + 2, 10, 92 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B5, _Fuente + 2, 10, 99 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B2, _Fuente + 2, 10, 106.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B1, _Fuente + 2, 10, 113.5 + Margen, 28, 4, StringAlignment.Far)
                    'Monedas
                    CrearLinea(e.Graphics, _Remision.M20, _Fuente + 2, 10, 125 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M10, _Fuente + 2, 10, 132 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M5, _Fuente + 2, 10, 140 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M2, _Fuente + 2, 10, 147 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M1, _Fuente + 2, 10, 154.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M05, _Fuente + 2, 10, 162 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M02, _Fuente + 2, 10, 169.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M01, _Fuente + 2, 10, 176.5 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M005, _Fuente + 2, 10, 185 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.TotalEnvio, "n2"), _Fuente + 2, 10, 194 + Margen, 30, 5, StringAlignment.Far)
                ElseIf _Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Solo_Importe Then
                    'Billetes
                    CrearLinea(e.Graphics, Format(_Remision.B1000L, "n2"), _Fuente + 2, 10, 48 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B500L, "n2"), _Fuente + 2, 10, 56 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B200L, "n2"), _Fuente + 2, 10, 63 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B100L, "n2"), _Fuente + 2, 10, 71 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B50L, "n2"), _Fuente + 2, 10, 78 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B20L, "n2"), _Fuente + 2, 10, 86 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B10L, "n2"), _Fuente + 2, 10, 93 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B5L, "n2"), _Fuente + 2, 10, 100 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B2L, "n2"), _Fuente + 2, 10, 107 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B1L, "n2"), _Fuente + 2, 10, 114 + Margen, 28, 4, StringAlignment.Far)
                    'Monedas
                    CrearLinea(e.Graphics, Format(_Remision.M20L, "n2"), _Fuente + 2, 10, 126 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M10L, "n2"), _Fuente + 2, 10, 133 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M5L, "n2"), _Fuente + 2, 10, 141 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M2L, "n2"), _Fuente + 2, 10, 148 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M1L, "n2"), _Fuente + 2, 10, 155 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M05L, "n2"), _Fuente + 2, 10, 163 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M02L, "n2"), _Fuente + 2, 10, 170 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M01L, "n2"), _Fuente + 2, 10, 177 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M005L, "n2"), _Fuente + 2, 10, 186 + Margen, 28, 4, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.TotalEnvio, "n2"), _Fuente + 2, 10, 194 + Margen, 30, 5, StringAlignment.Far)
                End If
            End If
            'Imprimir la cantidad de Sobres cuando sea Mayor que Cero
            If _Remision.Sobres > 0 Then
                CrearLinea(e.Graphics, "SOBRES: " & _Remision.Sobres.ToString, _Fuente + 2, 10, 200 + Margen, 100, 5, StringAlignment.Near)
            End If
        ElseIf _Remision.Formato2011 = False Then
            'FORMATO TRADICIONAL
            CrearLinea(e.Graphics, _Remision.Cia, _Fuente, 45, 23, 100, 5, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.Clave, _Fuente, 5, 38, 30, 5, StringAlignment.Far)
            CrearLinea(e.Graphics, _Remision.Unidad, _Fuente, 150, 35, 30, 42, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.Fecha, _Fuente, 60, 50, 20, 10, StringAlignment.Near)
            Select Case _Remision.Horario
                Case Horario.Matutino
                    CrearLinea(e.Graphics, "X", _Fuente, 105, 45, 10, 5, StringAlignment.Near)
                Case Horario.Vespertino
                    CrearLinea(e.Graphics, "X", _Fuente, 105, 50, 10, 5, StringAlignment.Near)
                Case Horario.Nocturno
                    CrearLinea(e.Graphics, "X", _Fuente, 105, 55, 10, 5, StringAlignment.Near)
            End Select

            Select Case _Remision.Servicio
                Case Servicio.Especial
                    CrearLinea(e.Graphics, "X", _Fuente, 113, 45, 10, 5, StringAlignment.Near)
                Case Servicio.Ordinario
                    CrearLinea(e.Graphics, "X", _Fuente, 113, 50, 10, 5, StringAlignment.Near)
            End Select

            CrearLinea(e.Graphics, _Remision.Origen, _Fuente, 65, 60, 65, 13, StringAlignment.Near)                         'NOMBRE CLIENTE ORIGEN
            CrearLinea(e.Graphics, _Remision.DireccionOrigen, _Fuente, 65, 72, 65, 13, StringAlignment.Near)                'DIRECCION CLIENTE ORIGEN
            CrearLinea(e.Graphics, Format(_Remision.Efectivo, "n2"), _Fuente + 2, 60, 88, 35, 8, StringAlignment.Center)
            CrearLinea(e.Graphics, Format(_Remision.Doctos, "n2"), _Fuente + 2, 95, 88, 35, 8, StringAlignment.Center)
            CrearLinea(e.Graphics, Format(_Remision.MonedaNacional, "n2"), _Fuente + 2, 150, 61, 32, 6, StringAlignment.Far)       'MONEDA NACIONAL
            CrearLinea(e.Graphics, Format(_Remision.MonedaExtranjera, "n2"), _Fuente + 2, 150, 67, 32, 6, StringAlignment.Far)     'MONEDA EXTRANJERA
            CrearLinea(e.Graphics, Format(_Remision.Otros, "n2"), _Fuente + 2, 150, 73, 32, 6, StringAlignment.Far)                'OTROS
            If _Remision.Imprime_EquivalenteMN Then CrearLinea(e.Graphics, Format(_Remision.EquivalenteMN, "n2"), _Fuente + 2, 150, 79, 32, 6, StringAlignment.Far) 'EQUIVALENTE MN
            CrearLinea(e.Graphics, Format(_Remision.Total, "n2"), _Fuente + 2, 150, 88, 32, 8, StringAlignment.Far)                'TOTAL
            'AGG 2009-12-28 Estas lineas no se imprimiran porque faltan tipos de envases en la remision
            'CrearLinea(e.Graphics, _Remision.EnvasesBilletes, _Fuente + 2, 75, 95, 25, 6, StringAlignment.Center)
            'CrearLinea(e.Graphics, _Remision.EnvasesMorralla, _Fuente + 2, 117, 95, 21, 6, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.EnvasesTotal, _Fuente + 2, 150, 95, 30, 6, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.CantidadLetra, _Fuente, 75, 101, 100, 14, StringAlignment.Near)
            CrearLinea(e.Graphics, _Remision.Destino, _Fuente, 75, 113, 105, 7, StringAlignment.Near)
            CrearLinea(e.Graphics, _Remision.DireccionDestino, _Fuente, 65, 120, 115, 7, StringAlignment.Near)
            CrearLinea(e.Graphics, _Remision.NumeroMach, _Fuente, 65, 128, 35, 6, StringAlignment.Near)
            CrearLinea(e.Graphics, _Remision.Sellos, _Fuente + 2, 110, 128, 75, 8, StringAlignment.Near)
            CrearLinea(e.Graphics, Format(_Remision.Hora, "HH:mm:ss"), _Fuente, 60, 137, 50, 5, StringAlignment.Center)
            CrearLinea(e.Graphics, _Remision.Remitente, _Fuente, 50, 142, 70, 6, StringAlignment.Center)

            If _Remision.Imprime_Denominaciones Then
                If _Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Piezas_e_Importe Then
                    'Billetes
                    CrearLinea(e.Graphics, _Remision.B1000, _Fuente, 15, 47, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B1000L, "n2"), _Fuente, 15, 50, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B500, _Fuente, 15, 53, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B500L, "n2"), _Fuente, 15, 56, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B200, _Fuente, 15, 59, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B200L, "n2"), _Fuente, 15, 62, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B100, _Fuente, 15, 65, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B100L, "n2"), _Fuente, 15, 68, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B50, _Fuente, 15, 71, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B50L, "n2"), _Fuente, 15, 74, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B20, _Fuente, 15, 77, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B20L, "n2"), _Fuente, 15, 80, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B10, _Fuente, 15, 83, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B10L, "n2"), _Fuente, 15, 86, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B5, _Fuente, 15, 89, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B5L, "n2"), _Fuente, 15, 92, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B2, _Fuente, 15, 95, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B2L, "n2"), _Fuente, 15, 98, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B1, _Fuente, 15, 101, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B1L, "n2"), _Fuente, 15, 104, 23, 3, StringAlignment.Far)
                    'Monedas
                    CrearLinea(e.Graphics, _Remision.M20, _Fuente, 15, 111, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M20L, "n2"), _Fuente, 15, 114, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M10, _Fuente, 15, 117, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M10L, "n2"), _Fuente, 15, 120, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M5, _Fuente, 15, 123, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M5L, "n2"), _Fuente, 15, 126, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M2, _Fuente, 15, 129, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M2L, "n2"), _Fuente, 15, 132, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M1, _Fuente, 15, 135, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M1L, "n2"), _Fuente, 15, 138, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M05, _Fuente, 15, 141, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M05L, "n2"), _Fuente, 15, 144, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M02, _Fuente, 15, 147, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M02L, "n2"), _Fuente, 15, 150, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M01, _Fuente, 15, 153, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M01L, "n2"), _Fuente, 15, 156, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M005, _Fuente, 15, 159, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M005L, "n2"), _Fuente, 15, 162, 23, 3, StringAlignment.Far)

                    CrearLinea(e.Graphics, Format(_Remision.TotalEnvio, "n2"), _Fuente + 2, 15, 165, 23, 4, StringAlignment.Far)
                ElseIf _Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Solo_Piezas Then
                    'Billetes
                    CrearLinea(e.Graphics, _Remision.B1000, _Fuente, 15, 47, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B500, _Fuente, 15, 53, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B200, _Fuente, 15, 59, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B100, _Fuente, 15, 65, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B50, _Fuente, 15, 71, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B20, _Fuente, 15, 77, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B10, _Fuente, 15, 83, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B5, _Fuente, 15, 89, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B2, _Fuente, 15, 95, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.B1, _Fuente, 15, 101, 23, 3, StringAlignment.Far)
                    'Monedas
                    CrearLinea(e.Graphics, _Remision.M20, _Fuente, 15, 111, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M10, _Fuente, 15, 117, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M5, _Fuente, 15, 123, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M2, _Fuente, 15, 129, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M1, _Fuente, 15, 135, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M05, _Fuente, 15, 141, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M02, _Fuente, 15, 147, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M01, _Fuente, 15, 153, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, _Remision.M005, _Fuente, 15, 159, 23, 3, StringAlignment.Far)

                    CrearLinea(e.Graphics, Format(_Remision.TotalEnvio, "n2"), _Fuente + 2, 15, 165, 23, 4, StringAlignment.Far)
                ElseIf _Remision.Tipo_Imprime_Denominaciones = Tipo_Desglose.Solo_Importe Then
                    'Billetes
                    CrearLinea(e.Graphics, Format(_Remision.B1000L, "n2"), _Fuente, 15, 50, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B500L, "n2"), _Fuente, 15, 56, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B200L, "n2"), _Fuente, 15, 62, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B100L, "n2"), _Fuente, 15, 68, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B50L, "n2"), _Fuente, 15, 74, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B20L, "n2"), _Fuente, 15, 80, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B10L, "n2"), _Fuente, 15, 86, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B5L, "n2"), _Fuente, 15, 92, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B2L, "n2"), _Fuente, 15, 98, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.B1L, "n2"), _Fuente, 15, 104, 23, 3, StringAlignment.Far)
                    'Monedas
                    CrearLinea(e.Graphics, Format(_Remision.M20L, "n2"), _Fuente, 15, 114, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M10L, "n2"), _Fuente, 15, 120, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M5L, "n2"), _Fuente, 15, 126, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M2L, "n2"), _Fuente, 15, 132, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M1L, "n2"), _Fuente, 15, 138, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M05L, "n2"), _Fuente, 15, 144, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M02L, "n2"), _Fuente, 15, 150, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M01L, "n2"), _Fuente, 15, 156, 23, 3, StringAlignment.Far)
                    CrearLinea(e.Graphics, Format(_Remision.M005L, "n2"), _Fuente, 15, 162, 23, 3, StringAlignment.Far)

                    CrearLinea(e.Graphics, Format(_Remision.TotalEnvio, "n2"), _Fuente + 2, 15, 165, 23, 4, StringAlignment.Far)
                End If
            End If
            'Imprimir la cantidad de Sobres cuando sea Mayor que Cero
            If _Remision.Sobres > 0 Then
                CrearLinea(e.Graphics, "SOBRES: " & _Remision.Sobres.ToString, _Fuente + 2, 10, 200 + Margen, 100, 5, StringAlignment.Near)
            End If
        End If
    End Sub

    Private Sub CrearLinea(ByRef G As System.Drawing.Graphics, ByVal Texto As String, ByVal FontSize As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal W As Integer, ByVal H As Integer, Optional ByVal Alineacion As Drawing.StringAlignment = StringAlignment.Near)
        Dim Font As New Font("Arial", FontSize)
        Dim Sf As New Drawing.StringFormat
        Dim R As New Rectangle(X, Y + _Margen, W, H)
        Sf.Alignment = Alineacion
        G.PageUnit = GraphicsUnit.Millimeter

        G.DrawString(Texto, Font, Brushes.Black, R, Sf)
    End Sub
End Class