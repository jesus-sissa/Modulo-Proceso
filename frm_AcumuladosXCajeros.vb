Imports Modulo_Proceso.Cn_Proceso
Imports Modulo_Proceso.Cn_DepositosXcuenta
Imports Modulo_Proceso.FuncionesGlobales

Public Class frm_AcumuladosXCajeros

    Private Sub frm_AcumuladosXCajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Desde.Actualizar()
        cmb_Hasta.Actualizar()
        cmb_Moneda.Actualizar()

        'cmb_Cajero.AgregaParametro("@Status", "A", 0)
        cmb_Cajero.Actualizar()

        Call LimpiarLista()
    End Sub

    Private Sub LimpiarLista()
        SegundosDesconexion = 0
        lsv_Listado.Items.Clear()
        lsv_Listado.Clear()
        lsv_Listado.Columns.Add("Clave")
        lsv_Listado.Columns.Add("Nombre")
        lsv_Listado.Columns.Add("FIngreso", 100)
        lsv_Listado.Columns.Add("Total")
        lsv_Listado.Columns.Add("Promedio")
        btn_Exportar.Enabled = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)

    End Sub

    Private Sub cmb_Desde_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_Hasta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_Cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cajero.SelectedIndexChanged
        Call LimpiarLista()
    End Sub

    Private Sub chk_Cajero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cajero.CheckedChanged
        lsv_Listado.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        btn_Exportar.Enabled = False
        If chk_Cajero.Checked Then
            cmb_Cajero.SelectedValue = 0
            cmb_Cajero.Enabled = False
            tbx_ClaveCajero.Enabled = False
        Else
            cmb_Cajero.Enabled = True
            tbx_ClaveCajero.Enabled = True
        End If
    End Sub

    Function Validar() As Boolean
        SegundosDesconexion = 0
        If cmb_Desde.SelectedIndex < cmb_Hasta.SelectedIndex Then
            MsgBox("El rango de fechas es Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Return False
        End If
        If cmb_Cajero.Enabled And cmb_Cajero.SelectedValue = 0 Then
            MsgBox("Seleccione el Cajero.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cajero.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btn_Remisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remisiones.Click
        Call LimpiarLista()
        If Not Validar() Then Exit Sub
        Call LlenarListaRemisiones()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_PiezasSinDificultad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PiezasSinDificultad.Click
        Call LimpiarLista()
        If Not Validar() Then Exit Sub
        Call LlenarListaPiezasSinDificultad()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_Piezas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Piezas.Click
        Call LimpiarLista()
        If Not Validar() Then Exit Sub
        Call LlenarListaPiezas()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_Importes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Importes.Click
        Call LimpiarLista()
        If Not Validar() Then Exit Sub

        If cmb_Moneda.SelectedValue = 0 Then
            MsgBox("Seleccione una Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Exit Sub
        End If

        Call LlenarListaImportes()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_Tiempos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tiempos.Click
        Call LimpiarLista()
        If Not Validar() Then Exit Sub

        Call LlenarListaTiempos()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_TiemposCajeroCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TiemposCajeroCliente.Click
        Call LimpiarLista()
        If Not Validar() Then Exit Sub

        Call LlenarListaTiemposXcliente()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_RemisionesGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RemisionesGlobal.Click
        SegundosDesconexion = 0
        lsv_Listado.Items.Clear()
        lsv_Listado.Clear()
        lsv_Listado.Columns.Add("Año")
        lsv_Listado.Columns.Add("Mes")
        lsv_Listado.Columns.Add("Total")
        lsv_Listado.Columns.Add("Dias")
        lsv_Listado.Columns.Add("Promedio")
        btn_Exportar.Enabled = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        If cmb_Desde.SelectedIndex < cmb_Hasta.SelectedIndex Then
            MsgBox("El rango de fechas es Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Exit Sub
        End If

        Call LlenarListaRemisionesGlobal()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_PiezasGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PiezasGlobal.Click
        SegundosDesconexion = 0
        lsv_Listado.Items.Clear()
        lsv_Listado.Clear()
        lsv_Listado.Columns.Add("Año")
        lsv_Listado.Columns.Add("Mes")
        lsv_Listado.Columns.Add("Total")
        lsv_Listado.Columns.Add("Dias")
        lsv_Listado.Columns.Add("Promedio")
        btn_Exportar.Enabled = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        If cmb_Desde.SelectedIndex < cmb_Hasta.SelectedIndex Then
            MsgBox("El rango de fechas es Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Exit Sub
        End If

        Call LlenarListaPiezasGlobal()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Sub LlenarListaRemisiones()
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Clave", 100)
        lsv_Listado.Columns.Add("Cajero", 300)
        lsv_Listado.Columns.Add("FIngreso", 100)
        lsv_Listado.Columns.Add("Nivel", 100)
        lsv_Listado.Columns.Add("Dificultad", 100)

        Dim Indice As Integer = cmb_Desde.SelectedIndex
        Dim Dt_Fechas As DataTable = cmb_Desde.DataSource

        For iLocal = cmb_Desde.SelectedIndex To cmb_Hasta.SelectedIndex Step -1
            Dim Encabezado = Microsoft.VisualBasic.Left(Dt_Fechas.Rows(iLocal)(1), 10)
            lsv_Listado.Columns.Add(Encabezado, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosRemisiones(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim CajeroAnterior As String = ""
        Dim DificultadAnterior As Integer = -1
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Integer = 0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0

        For Each Fila As DataRow In dt_Consulta.Rows
            'If Fila("Clave") <> CajeroAnterior And CajeroAnterior <> "" Then
            If CajeroAnterior <> "" And Fila("Dificultad") <> -1 Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")
            End If

            If Fila("Clave") <> CajeroAnterior Or Fila("Dificultad") <> DificultadAnterior Then
                CajeroAnterior = Fila("Clave")
                DificultadAnterior = Fila("Dificultad")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Clave"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Cajero"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("FIngreso"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Nivel"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Dificultad"))
                'Agregar todos los subitems
                For iLocal = 5 To lsv_Listado.Columns.Count
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 5 To lsv_Listado.Columns.Count - 2
                If lsv_Listado.Columns(iLocal).Text = Fila("Fecha") Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "###,###,##0")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")

        btn_Exportar.Enabled = True

    End Sub

    Sub LlenarListaPiezasSinDificultad()

        'PIEZAS VERIFICADAS POR CAJERO
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Clave", 100)
        lsv_Listado.Columns.Add("Cajero", 200)
        lsv_Listado.Columns.Add("FIngreso", 100)
        lsv_Listado.Columns.Add("Nivel", 100)


        Dim Indice As Integer = cmb_Desde.SelectedIndex
        Dim Dt_Fechas As DataTable = cmb_Desde.DataSource

        For iLocal = cmb_Desde.SelectedIndex To cmb_Hasta.SelectedIndex Step -1
            Dim Encabezado = Microsoft.VisualBasic.Left(Dt_Fechas.Rows(iLocal)(1), 10)
            lsv_Listado.Columns.Add(Encabezado, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosPiezasSinDificultad(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim CajeroAnterior As String = ""
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Integer = 0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0

        For Each Fila As DataRow In dt_Consulta.Rows
            'If Fila("Clave") <> CajeroAnterior And CajeroAnterior <> "" And Fila("Dificultad") <> -1 Then
            If CajeroAnterior <> "" Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")
            End If

            If Fila("Clave") <> CajeroAnterior Then
                CajeroAnterior = Fila("Clave")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Clave"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Cajero"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("FIngreso"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Nivel"))
                'Agregar todos los subitems
                For iLocal = 4 To lsv_Listado.Columns.Count - 1
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 4 To lsv_Listado.Columns.Count - 2
                If lsv_Listado.Columns(iLocal).Text = Fila("Fecha") Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "###,###,##0")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")

        btn_Exportar.Enabled = True

    End Sub

    Sub LlenarListaPiezas()
        'PIEZAS VERIFICADAS POR CAJERO
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Clave", 100)
        lsv_Listado.Columns.Add("Cajero", 200)
        lsv_Listado.Columns.Add("FIngreso", 100)
        lsv_Listado.Columns.Add("Nivel", 100)
        lsv_Listado.Columns.Add("Dificultad", 100)


        Dim Indice As Integer = cmb_Desde.SelectedIndex
        Dim Dt_Fechas As DataTable = cmb_Desde.DataSource

        For iLocal = cmb_Desde.SelectedIndex To cmb_Hasta.SelectedIndex Step -1
            Dim Encabezado = Microsoft.VisualBasic.Left(Dt_Fechas.Rows(iLocal)(1), 10)
            lsv_Listado.Columns.Add(Encabezado, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosPiezas(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim CajeroAnterior As String = ""
        Dim DificultadAnterior As Integer = -1
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Integer = 0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0

        For Each Fila As DataRow In dt_Consulta.Rows
            'If Fila("Clave") <> CajeroAnterior And CajeroAnterior <> "" And Fila("Dificultad") <> -1 Then
            If CajeroAnterior <> "" And Fila("Dificultad") <> -1 Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")
            End If

            If Fila("Clave") <> CajeroAnterior Or Fila("Dificultad") <> DificultadAnterior Then
                CajeroAnterior = Fila("Clave")
                DificultadAnterior = Fila("Dificultad")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Clave"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Cajero"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("FIngreso"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Nivel"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Dificultad"))
                'Agregar todos los subitems
                For iLocal = 5 To lsv_Listado.Columns.Count - 1
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 5 To lsv_Listado.Columns.Count - 2
                If lsv_Listado.Columns(iLocal).Text = Fila("Fecha") Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "###,###,##0")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")

        btn_Exportar.Enabled = True

    End Sub



    Sub LlenarListaImportes()
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Clave", 100)
        lsv_Listado.Columns.Add("Cajero", 200)
        lsv_Listado.Columns.Add("FIngreso", 100)

        Dim Indice As Integer = cmb_Desde.SelectedIndex
        Dim Dt_Fechas As DataTable = cmb_Desde.DataSource

        For iLocal = cmb_Desde.SelectedIndex To cmb_Hasta.SelectedIndex Step -1
            Dim Encabezado = Microsoft.VisualBasic.Left(Dt_Fechas.Rows(iLocal)(1), 10)
            lsv_Listado.Columns.Add(Encabezado, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosImportes(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue, cmb_Moneda.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim CajeroAnterior As String = ""
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Decimal = 0.0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0

        For Each Fila As DataRow In dt_Consulta.Rows
            If Fila("Clave") <> CajeroAnterior And CajeroAnterior <> "" Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")
            End If

            If Fila("Clave") <> CajeroAnterior Then
                CajeroAnterior = Fila("Clave")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Clave"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Cajero"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("FIngreso"))
                'Agregar todos los subitems
                For iLocal = 3 To lsv_Listado.Columns.Count
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 3 To lsv_Listado.Columns.Count - 1
                If lsv_Listado.Columns(iLocal).Text = Fila("Fecha") Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "n2")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")

        btn_Exportar.Enabled = True

    End Sub

    Sub LlenarListaTiempos()
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Clave", 100)
        lsv_Listado.Columns.Add("Cajero", 200)
        lsv_Listado.Columns.Add("FIngreso", 100)

        Dim Indice As Integer = cmb_Desde.SelectedIndex
        Dim Dt_Fechas As DataTable = cmb_Desde.DataSource

        For iLocal = cmb_Desde.SelectedIndex To cmb_Hasta.SelectedIndex Step -1
            Dim Encabezado = Microsoft.VisualBasic.Left(Dt_Fechas.Rows(iLocal)(1), 10)
            lsv_Listado.Columns.Add(Encabezado, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("PromedioHHMM", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosTiempos(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim CajeroAnterior As String = ""
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Integer = 0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0
        Dim PromedioHHMM As String = ""

        For Each Fila As DataRow In dt_Consulta.Rows
            If Fila("Clave") <> CajeroAnterior And CajeroAnterior <> "" Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 4).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(Total / CantidadDias, "n2")
                Promedio = Total \ CantidadDias
                PromedioHHMM = fn_PonerCeros(Promedio \ 60, 2)
                PromedioHHMM &= ":"
                PromedioHHMM &= fn_PonerCeros(Math.Truncate(Promedio Mod 60), 2)
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = PromedioHHMM
            End If

            If Fila("Clave") <> CajeroAnterior Then
                CajeroAnterior = Fila("Clave")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Clave"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Cajero"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("FIngreso"))
                'Agregar todos los subitems
                For iLocal = 3 To lsv_Listado.Columns.Count
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 3 To lsv_Listado.Columns.Count - 1
                If lsv_Listado.Columns(iLocal).Text = Fila("Fecha") Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "###,###,##0")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 4).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(Total / CantidadDias, "n2")
        Promedio = Total \ CantidadDias
        PromedioHHMM = fn_PonerCeros(Promedio \ 60, 2)
        PromedioHHMM &= ":"
        PromedioHHMM &= fn_PonerCeros(Math.Truncate(Promedio Mod 60), 2)
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = PromedioHHMM

        btn_Exportar.Enabled = True

    End Sub

    Sub LlenarListaTiemposXcliente()
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Clave", 100)
        lsv_Listado.Columns.Add("Cajero", 200)
        lsv_Listado.Columns.Add("FIngreso", 100)
        lsv_Listado.Columns.Add("Cliente", 100)

        Dim Indice As Integer = cmb_Desde.SelectedIndex
        Dim Dt_Fechas As DataTable = cmb_Desde.DataSource

        For iLocal = cmb_Desde.SelectedIndex To cmb_Hasta.SelectedIndex Step -1
            Dim Encabezado = Microsoft.VisualBasic.Left(Dt_Fechas.Rows(iLocal)(1), 10)
            lsv_Listado.Columns.Add(Encabezado, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("PromedioHHMM", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosTiemposXcliente(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim CajeroAnterior As String = ""
        Dim ClienteAnterior As String = ""
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Integer = 0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0
        Dim PromedioHHMM As String = ""

        For Each Fila As DataRow In dt_Consulta.Rows
            If CajeroAnterior <> "" And Fila("Cliente") <> ClienteAnterior Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 4).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(Total / CantidadDias, "n2")
                Promedio = Total \ CantidadDias
                PromedioHHMM = fn_PonerCeros(Promedio \ 60, 2)
                PromedioHHMM &= ":"
                PromedioHHMM &= fn_PonerCeros(Math.Truncate(Promedio Mod 60), 2)
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = PromedioHHMM
            End If

            If Fila("Clave") <> CajeroAnterior Or Fila("Cliente") <> ClienteAnterior Then
                CajeroAnterior = Fila("Clave")
                ClienteAnterior = Fila("Cliente")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Clave"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Cajero"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("FIngreso"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Cliente"))
                'Agregar todos los subitems
                For iLocal = 4 To lsv_Listado.Columns.Count
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 4 To lsv_Listado.Columns.Count - 3
                If lsv_Listado.Columns(iLocal).Text = Fila("Fecha") Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "###,###,##0")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 4).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(Total / CantidadDias, "n2")
        Promedio = Total \ CantidadDias
        PromedioHHMM = fn_PonerCeros(Promedio \ 60, 2)
        PromedioHHMM &= ":"
        PromedioHHMM &= fn_PonerCeros(Math.Truncate(Promedio Mod 60), 2)
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = PromedioHHMM

        btn_Exportar.Enabled = True

    End Sub

    Sub LlenarListaRemisionesGlobal()
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Año", 100)
        lsv_Listado.Columns.Add("Mes", 300)

        For iLocal = 1 To 31
            lsv_Listado.Columns.Add(iLocal.ToString, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosRemisionesGlobal(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim MesAnterior As Integer = 0
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Integer = 0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0

        For Each Fila As DataRow In dt_Consulta.Rows
            If Fila("Mes") <> MesAnterior And MesAnterior <> 0 Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")
            End If

            If Fila("Mes") <> MesAnterior Then
                MesAnterior = Fila("Mes")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Año"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Mes"))
                'Agregar todos los subitems
                For iLocal = 2 To lsv_Listado.Columns.Count
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 2 To lsv_Listado.Columns.Count - 1
                If lsv_Listado.Columns(iLocal).Text = Fila("Dia").ToString Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "###,###,##0")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")

        btn_Exportar.Enabled = True

    End Sub

    Sub LlenarListaPiezasGlobal()
        Dim iLocal As Integer = 0
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Año", 100)
        lsv_Listado.Columns.Add("Mes", 300)

        For iLocal = 1 To 31
            lsv_Listado.Columns.Add(iLocal.ToString, 70, HorizontalAlignment.Right)
        Next

        lsv_Listado.Columns.Add("Total", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Dias", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Promedio", 100, HorizontalAlignment.Right)

        Dim dt_Consulta As DataTable = fn_AcumuladosXcajero_ObtenerDatosPiezasGlobal(cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar los Depósitos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim MesAnterior As Integer = 0
        Dim IndiceCol As Integer = -1
        Dim IndiceItem As Integer = -1
        Dim Total As Integer = 0
        Dim CantidadDias As Integer = 0
        Dim Promedio As Decimal = 0.0

        For Each Fila As DataRow In dt_Consulta.Rows
            If Fila("Mes") <> MesAnterior And MesAnterior <> 0 Then
                'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
                lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")
            End If

            If Fila("Mes") <> MesAnterior Then
                MesAnterior = Fila("Mes")
                Total = 0
                CantidadDias = 0
                IndiceItem += 1
                'Agregar un nuevo item con el siguiente Cajero
                lsv_Listado.Items.Add(Fila("Año"))
                lsv_Listado.Items(IndiceItem).SubItems.Add(Fila("Mes"))
                'Agregar todos los subitems
                For iLocal = 2 To lsv_Listado.Columns.Count
                    lsv_Listado.Items(IndiceItem).SubItems.Add("0")
                Next
            End If


            For iLocal = 2 To lsv_Listado.Columns.Count - 1
                If lsv_Listado.Columns(iLocal).Text = Fila("Dia").ToString Then
                    lsv_Listado.Items(IndiceItem).SubItems(iLocal).Text = Format(Fila("Cantidad"), "###,###,##0")
                    CantidadDias += 1
                    Total += Fila("Cantidad")
                    Exit For
                End If
            Next

        Next

        'Agregar los Totales para el último Cajero
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(Total, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 2).Text = Format(CantidadDias, "###,###,##0")
        lsv_Listado.Items(IndiceItem).SubItems(lsv_Listado.Columns.Count - 1).Text = Format(Total / CantidadDias, "n2")

        btn_Exportar.Enabled = True

    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Listado, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    '***************************************************************************************************************

    Private Sub btn_Rutas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rutas.Click
        SegundosDesconexion = 0
        lsv_Listado.Items.Clear()
        lsv_Listado.Clear()
        lsv_Listado.Columns.Add("Ruta")
        lsv_Listado.Columns.Add("Fecha")
        lsv_Listado.Columns.Add("Inicio")
        lsv_Listado.Columns.Add("Fin")
        btn_Exportar.Enabled = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        If dtp_Hasta.Value.Date < dtp_Desde.Value.Date Then
            MsgBox("El rango de fechas es Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Exit Sub
        End If

        Call LlenarListaRutas()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)
    End Sub

    Sub LlenarListaRutas()
        Me.Text = "HORAS DE RECEPCION DE RUTAS EN TRANSFER"
        Dim iLocal As Integer = 0
        lsv_Listado.Items.Clear()
        lsv_Listado.Columns.Clear()
        lsv_Listado.Columns.Add("Ruta")
        lsv_Listado.Columns.Add("Fecha")
        lsv_Listado.Columns.Add("Inicio")
        lsv_Listado.Columns.Add("Fin")

        Dim dt_Consulta As DataTable = fn_HorariosRecepcionRutas_Consultar(dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
        If dt_Consulta Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar las Rutas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Consulta.Rows.Count = 0 Then
            MsgBox("No se encontraron Registros.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim RutaAnterior As String = ""
        Dim FechaAnterior As String = ""

        For Each Fila As DataRow In dt_Consulta.Rows

            If IsDBNull(Fila("HoraValida")) Then Continue For

            If Fila("Ruta") <> RutaAnterior Then
                lsv_Listado.Items.Add(Fila("Ruta"))
                lsv_Listado.Items(lsv_Listado.Items.Count - 1).SubItems.Add(Fila("Fecha"))
                lsv_Listado.Items(lsv_Listado.Items.Count - 1).SubItems.Add(Fila("HoraValida"))
                lsv_Listado.Items(lsv_Listado.Items.Count - 1).SubItems.Add(Fila("HoraValida"))
                RutaAnterior = Fila("Ruta")
                FechaAnterior = Fila("Fecha")
            Else
                If Fila("Fecha") <> FechaAnterior Then
                    lsv_Listado.Items.Add(Fila("Ruta"))
                    lsv_Listado.Items(lsv_Listado.Items.Count - 1).SubItems.Add(Fila("Fecha"))
                    lsv_Listado.Items(lsv_Listado.Items.Count - 1).SubItems.Add(Fila("HoraValida"))
                    lsv_Listado.Items(lsv_Listado.Items.Count - 1).SubItems.Add(Fila("HoraValida"))
                    FechaAnterior = Fila("Fecha")
                Else
                    lsv_Listado.Items(lsv_Listado.Items.Count - 1).SubItems(3).Text = Fila("HoraValida")
                End If
            End If


        Next

        btn_Exportar.Enabled = True

    End Sub


End Class