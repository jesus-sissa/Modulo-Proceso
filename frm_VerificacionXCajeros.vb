Imports Modulo_Proceso.Cn_Proceso
Imports Modulo_Proceso.Cn_DepositosXcuenta
Imports Modulo_Proceso.FuncionesGlobales

Public Class frm_VerificacionXCajeros

    Private Sub frm_VerificacionXCajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_CajaBancaria.Actualizar()
        cmb_Moneda.Actualizar()

        cmb_Desde.ValorParametro = dtp_Desde.Value
        cmb_Desde.Actualizar()

        cmb_Hasta.ValorParametro = dtp_Hasta.Value
        cmb_Hasta.Actualizar()

        'cmb_Cajero.AgregaParametro("@Status", "A", 0)
        cmb_Cajero.Actualizar()

        lsv_Listado.Columns.Add("Cajero")
        lsv_Listado.Columns.Add("Denominaciones")
        lsv_Listado.Columns.Add("TotalEfvo")
        lsv_Listado.Columns.Add("Documentos")
        lsv_Listado.Columns.Add("ImporteDoctos")
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        lsv_Listado.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        btn_Exportar.Enabled = False
        cmb_Desde.ValorParametro = dtp_Desde.Value
        cmb_Desde.Actualizar()
        If cmb_Desde.Items.Count = 2 Then
            cmb_Desde.SelectedIndex = 1
        End If
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        lsv_Listado.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        btn_Exportar.Enabled = False
        cmb_Hasta.ValorParametro = dtp_Hasta.Value
        cmb_Hasta.Actualizar()
        If cmb_Hasta.Items.Count = 2 Then
            cmb_Hasta.SelectedIndex = 1
        End If
    End Sub

    Private Sub chk_CajaBancaria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_CajaBancaria.CheckedChanged
        lsv_Listado.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        btn_Exportar.Enabled = False
        If chk_CajaBancaria.Checked Then
            cmb_CajaBancaria.SelectedValue = 0
            cmb_CajaBancaria.Enabled = False
        Else
            cmb_CajaBancaria.Enabled = True
        End If
    End Sub

    Private Sub chk_Corte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Corte.CheckedChanged
        lsv_Listado.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
        btn_Exportar.Enabled = False
        If chk_Corte.Checked Then
            tbx_Corte.Clear()
            tbx_Corte.Enabled = False
        Else
            tbx_Corte.Enabled = True
        End If
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

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Dim CajeroAnterior As Integer = 0

        If cmb_CajaBancaria.Enabled And cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Seleccione la Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If
        If cmb_Moneda.SelectedValue = 0 Then
            MsgBox("Seleccione la Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Exit Sub
        End If
        If tbx_Corte.Enabled And tbx_Corte.Text = "" Then
            MsgBox("Capture el número de Corte.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Corte.Focus()
            Exit Sub
        End If
        If cmb_CajaBancaria.Enabled And cmb_CajaBancaria.SelectedValue = 0 Then
            MsgBox("Seleccione la Caja Bancaria.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CajaBancaria.Focus()
            Exit Sub
        End If
        If cmb_Desde.SelectedValue = 0 Then
            MsgBox("Seleccione la Sesión Inicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Desde.Focus()
            Exit Sub
        End If
        If cmb_Hasta.SelectedValue = 0 Then
            MsgBox("Seleccione la Sesión Fin.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Hasta.Focus()
            Exit Sub
        End If
        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas es Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If
        If cmb_Cajero.Enabled And cmb_Cajero.SelectedValue = 0 Then
            MsgBox("Seleccione el Cajero.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cajero.Focus()
            Exit Sub
        End If

        lsv_Listado.Items.Clear()
        Call LlenarLista()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Listado.Items.Count)

    End Sub

    Sub LlenarLista()

        Dim TotalEfvo As Decimal = 0
        Dim TotalPiezas As Integer = 0

        Dim Denominaciones As DataTable = fn_VerificacionXCajero_GetDenominacionesPresentacion(cmb_Moneda.SelectedValue)
        If Denominaciones Is Nothing Then Exit Sub

        'Crear columnas de la lista ----------------------
        lsv_Listado.Columns.Clear()

        'Se crea la columna Cajero
        lsv_Listado.Columns.Add("Cajero", 300)

        'Se crea una columna por cada denominación
        For Each d As DataRow In Denominaciones.Rows
            Dim presentacion As String = Microsoft.VisualBasic.Left(d("Presentacion"), 1)
            Dim denominacion As String = d("Denominacion")
            Dim encabezado = presentacion & denominacion
            lsv_Listado.Columns.Add(encabezado, 70, HorizontalAlignment.Right)
            lsv_Listado.Columns(lsv_Listado.Columns.Count - 1).Tag = d("Id_Denominacion")
        Next

        'Se crean las columnas de los Totales
        lsv_Listado.Columns.Add("Piezas", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Total Efvo.", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Cantidad Doctos.", 100, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Importe Doctos.", 100, HorizontalAlignment.Right)

        '-------------------------------------------------


        Dim dt_Efvo As DataTable = fn_VerificacionXCajero_ObtenerDatos(cmb_CajaBancaria.SelectedValue, cmb_Moneda.SelectedValue, Val(tbx_Corte.Text), cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue)
        Dim dt_Doctos As DataTable = fn_VerificacionXCajero_ObtenerDatosDoctos(cmb_CajaBancaria.SelectedValue, Val(tbx_Corte.Text), cmb_Desde.SelectedValue, cmb_Hasta.SelectedValue, cmb_Cajero.SelectedValue)


        Dim CajeroAnterior As Integer = 0
        Dim indiceC As Integer = -1

        If dt_Efvo IsNot Nothing Then
            btn_Exportar.Enabled = True

            'Se recorre cada fila de la consulta de cantidades en Efectivo verificados
            'En esta consulta tenemos una fila por cada Denominación verificada
            For Each cajero As DataRow In dt_Efvo.Rows
                If cajero("IDC") <> CajeroAnterior And CajeroAnterior > 0 Then
                    'Si es un Cajero diferente al anterior y no es el primer Cajero se muestran los totales
                    lsv_Listado.Items(indiceC).SubItems(lsv_Listado.Columns.Count - 4).Text = Format(TotalPiezas, "###,###,##0")
                    lsv_Listado.Items(indiceC).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(TotalEfvo, "n2")
                    TotalEfvo = 0.0
                    TotalPiezas = 0
                End If

                If cajero("IDC") <> CajeroAnterior Then
                    CajeroAnterior = cajero("IDC")
                    indiceC += 1

                    'Agregar un nuevo item con el siguiente Cajero
                    lsv_Listado.Items.Add(cajero("Cajero"))
                    lsv_Listado.Items(indiceC).Tag = cajero("IDC")

                    'Agregar en la misma fila para cada denominación y para las columnas de Totales el valor cero(0)
                    'y cada tag de cada columna le asignamos tambien el valor de cero(0)
                    For d As Integer = 1 To lsv_Listado.Columns.Count - 1
                        lsv_Listado.Items(indiceC).SubItems.Add("0")
                        lsv_Listado.Items(indiceC).SubItems(d).Tag = 0
                    Next
                End If

                'Recorremos las columnas del listado para colocar la cantidad de la denominación
                'del row(cajero) actual en la columna correspondiente
                For c As Integer = 1 To lsv_Listado.Columns.Count - 4
                    If cajero("Id_Denominacion") = lsv_Listado.Columns(c).Tag Then
                        lsv_Listado.Items(indiceC).SubItems(c).Text = Format(cajero("Cantidad"), "###,###,##0")
                        TotalEfvo += CDec(cajero("Denominacion")) * CDec(cajero("Cantidad"))
                        TotalPiezas += cajero("Cantidad")
                        Exit For
                    End If
                Next
            Next

            'Agregar los Totales para el último Cajero
            lsv_Listado.Items(indiceC).SubItems(lsv_Listado.Columns.Count - 4).Text = Format(TotalPiezas, "###,###,##0")
            lsv_Listado.Items(indiceC).SubItems(lsv_Listado.Columns.Count - 3).Text = Format(TotalEfvo, "n2")

            'Recorrer el dt_Doctos y colocar la Cantidad de Documentos y el Importe de Documentos
            'en la fila del Cajero correspondiente
            If dt_Doctos IsNot Nothing Then
                For Each row As DataRow In dt_Doctos.Rows
                    For Each item As ListViewItem In lsv_Listado.Items
                        If row("cajero") = item.Tag Then
                            item.SubItems(lsv_Listado.Columns.Count - 2).Text = Format(row("CantidadDoctos"), "###,###,##0")
                            item.SubItems(lsv_Listado.Columns.Count - 1).Text = Format(row("ImporteDoctos"), "n2")
                        End If
                    Next
                Next
            End If
            'Agregar fila de Totales
            Dim TotalCol As Decimal = 0
            Dim lsv_item As ListViewItem

            lsv_item = lsv_Listado.Items.Add("TOTALES")
            lsv_item.Font = New Font(lsv_Listado.Font, FontStyle.Bold)

            For c As Integer = 1 To lsv_Listado.Columns.Count - 1
                For fila = 0 To lsv_Listado.Items.Count - 2
                    TotalCol += CDec(lsv_Listado.Items(fila).SubItems(c).Text)
                Next
                lsv_item.SubItems.Add("")
                If c = lsv_Listado.Columns.Count - 3 Then
                    lsv_item.SubItems(c).Text = Format(TotalCol, "n2")
                ElseIf c = lsv_Listado.Columns.Count - 1 Then
                    lsv_item.SubItems(c).Text = Format(TotalCol, "n2")
                Else
                    lsv_item.SubItems(c).Text = Format(TotalCol, "###,###,##0")
                End If
                lsv_item.SubItems(c).Font = New Font(lsv_Listado.Font, FontStyle.Bold)
                TotalCol = 0
            Next
        End If
    End Sub

    Private Sub LimpiarLista()
        SegundosDesconexion = 0
        lsv_Listado.Items.Clear()
        btn_Exportar.Enabled = False
        FuncionesGlobales.RegistrosNum(Lbl_Registros, 0)
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Listado, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        LimpiarLista()
    End Sub

    Private Sub cmb_Moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Moneda.SelectedIndexChanged
        LimpiarLista()
    End Sub

    Private Sub tbx_Corte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Corte.TextChanged
        LimpiarLista()
    End Sub

    Private Sub cmb_Desde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Desde.SelectedIndexChanged
        LimpiarLista()
    End Sub

    Private Sub cmb_Hasta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Hasta.SelectedIndexChanged
        LimpiarLista()
    End Sub

    Private Sub cmb_Cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cajero.SelectedIndexChanged
        LimpiarLista()
    End Sub

    Private Sub chk_Billetes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarLista()
    End Sub

    Private Sub chk_Monedas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarLista()
    End Sub

 
End Class