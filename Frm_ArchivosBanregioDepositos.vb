Imports Api_Bank

Public Class Frm_ArchivosBanregioDepositos
    Public Json As String
    Public Titulo As String
    Dim _Api As New BanregioApi
    Dim _Cuenta As Cuenta
    Private Sub Frm_ArchivosBanregioDepositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Titulo
        _Cuenta = _Api.Detalle_Efectivo(Json)
        For Each Consecutivo As Deposito In _Cuenta.depositos
            Dgv_Depositos.Rows.Add(Consecutivo.consecutivo.ToString(), Consecutivo.divisa, Consecutivo.remesa, Consecutivo.referencia, Consecutivo.importeTotal.ToString(), Consecutivo.importeFicha.ToString(), Consecutivo.diferencia.ToString(), Consecutivo.tipoDiferencia)
        Next
        lbl_RegistrosD.Text = "Registros: " + (Dgv_Depositos.Rows.Count - 1).ToString()
    End Sub

    Private Sub Dgv_Depositos_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv_Depositos.SelectionChanged
        If Dgv_Depositos.SelectedRows.Count > 0 Then
            LlenarEfectivo(Dgv_Depositos.Rows(Dgv_Depositos.CurrentRow.Index).Cells(0).Value)
            LlenarCheque(Dgv_Depositos.Rows(Dgv_Depositos.CurrentRow.Index).Cells(0).Value)
        End If
    End Sub
    Sub LlenarEfectivo(Consecutivo As Integer)
        Dgv_Efectivo.Rows.Clear()
        For Each Depositos As Deposito In _Cuenta.depositos
            If Depositos.consecutivo = Consecutivo And Depositos.detalleEfectivo IsNot Nothing Then
                For Each Efectivo In Depositos.detalleEfectivo.desglose
                    Dgv_Efectivo.Rows.Add(Efectivo.tipo, Efectivo.denominacion.ToString(), Efectivo.cantidad.ToString(), Efectivo.importe.ToString())
                Next
                Exit For
            End If
        Next
        lbl_RegistrosE.Text = "Registros: " + (Dgv_Efectivo.Rows.Count - 1).ToString()
    End Sub
    Sub LlenarCheque(Consecutivo As Integer)
        Dgv_Cheques.Rows.Clear()
        For Each Depositos As Deposito In _Cuenta.depositos
            If Depositos.consecutivo = Consecutivo Then
                For Each Cheque In Depositos.detalleCheque
                    Dgv_Cheques.Rows.Add(Cheque.tipoCheque, Cheque.referenciaControl.ToString(), Cheque.bandaMagnetica, Cheque.numeroSeguridadInvisible, Cheque.importe.ToString())
                Next
                Exit For
            End If
        Next
        lbl_RegistrosC.Text = "Registros: " + (Dgv_Cheques.Rows.Count - 1).ToString()
    End Sub
End Class