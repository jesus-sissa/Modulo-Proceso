Public Class frm_CancelaResguardo
    Public Tipo As Modo = Modo.Cancela

    Enum Modo
        Cancela
        Reintegra
    End Enum

    Private Sub frm_CancelaResguardo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BanderA = False
        cmb_CajaBancaria.Actualizar()
        BanderA = True

        Select Case Tipo
            Case Modo.Cancela
                Me.Text = "Cancela Resguardos"
                btn_Cancelar.Text = "&Cancelar"
                btn_Cancelar.ImageIndex = 0
            Case Modo.Reintegra
                Me.Text = "Reintegra resguardos al saldo"
                btn_Cancelar.Text = "&Reintegrar"
                btn_Cancelar.ImageIndex = 1
        End Select

        lsv_Resguardo.Columns.Add("Caja")
        lsv_Resguardo.Columns.Add("Remision", 100, HorizontalAlignment.Right)
        lsv_Resguardo.Columns.Add("Importe", 100, HorizontalAlignment.Right)
        lsv_Resguardo.Columns.Add("Envases", 100, HorizontalAlignment.Right)
        lsv_Resguardo.Columns.Add("Fecha")
        lsv_Resguardo.Columns.Add("Hora")

        lsv_ResguardoD.Columns.Add("Denominacion", 100, HorizontalAlignment.Right)
        lsv_ResguardoD.Columns.Add("Cantidad", 100, HorizontalAlignment.Right)
        lsv_ResguardoD.Columns.Add("CantidadA", 100, HorizontalAlignment.Right)
        lsv_ResguardoD.Columns.Add("CantidadB", 100, HorizontalAlignment.Right)
        lsv_ResguardoD.Columns.Add("CantidadC", 100, HorizontalAlignment.Right)
        lsv_ResguardoD.Columns.Add("CantidadD", 100, HorizontalAlignment.Right)
        lsv_ResguardoD.Columns.Add("CantidadE", 100, HorizontalAlignment.Right)

        lsv_Envases.Columns.Add("Tipo Envase")
        lsv_Envases.Columns.Add("Numero")

    End Sub

    Private Sub lsv_Resguardo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardo.SelectedIndexChanged

        If BanderA = True Then
            If lsv_Resguardo.SelectedItems.Count > 0 Then
                Cn_Proceso.fn_EnvBovedaResDLlenalista(lsv_ResguardoD, lsv_Resguardo.SelectedItems(0).Tag)

                lsv_ResguardoD.Columns(0).TextAlign = HorizontalAlignment.Right
                lsv_ResguardoD.Columns(1).TextAlign = HorizontalAlignment.Right
                lsv_ResguardoD.Columns(2).TextAlign = HorizontalAlignment.Right
                lsv_ResguardoD.Columns(3).TextAlign = HorizontalAlignment.Right
                lsv_ResguardoD.Columns(4).TextAlign = HorizontalAlignment.Right
                lsv_ResguardoD.Columns(5).TextAlign = HorizontalAlignment.Right
                lsv_ResguardoD.Columns(6).TextAlign = HorizontalAlignment.Right

                Cn_Proceso.fn_CancelarEnvioProceso_Envases(lsv_Resguardo.SelectedItems(0).SubItems(6).Text, lsv_Envases)


            Else
                lsv_ResguardoD.Items.Clear()
                lsv_Envases.Items.Clear()
            End If
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros2, lsv_ResguardoD.Items.Count)
        FuncionesGlobales.RegistrosNum(lbl_Registros3, lsv_Envases.Items.Count)

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        If lsv_Resguardo.CheckedItems.Count > 0 Then
            If Cn_Proceso.fn_CancelaResRemision(Tipo, lsv_Resguardo.CheckedItems) Then
                If Tipo = Modo.Cancela Then MsgBox("Registro Cancelado", MsgBoxStyle.Information, frm_MENU.Text) Else MsgBox("Registro Reingresado", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            LlenaLista(True)
            lsv_ResguardoD.Items.Clear()
            FuncionesGlobales.RegistrosNum(Lbl_Registros2, lsv_ResguardoD.Items.Count)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub ckb_Caja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_Caja.CheckedChanged
        If ckb_Caja.Checked = True Then
            cmb_CajaBancaria.Enabled = False
            LlenaLista(True)
        Else
            cmb_CajaBancaria.Enabled = True
        End If
    End Sub

    Private Sub cmb_CajaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CajaBancaria.SelectedIndexChanged
        LlenaLista()
    End Sub

    Private Sub LlenaLista(Optional ByVal idcaja As Boolean = False)
        SegundosDesconexion = 0

        If BanderA = True Then
            If idcaja = True Then
                Cn_Proceso.fn_EnvBovedaResLlenalista(lsv_Resguardo, 0, Tipo)
            Else
                Cn_Proceso.fn_EnvBovedaResLlenalista(lsv_Resguardo, cmb_CajaBancaria.SelectedValue, Tipo)
            End If
            lsv_Resguardo.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_Resguardo.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_Resguardo.Columns(3).TextAlign = HorizontalAlignment.Right
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Resguardo.Items.Count)
    End Sub

    Private Sub lsv_Resguardo_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Resguardo.ItemChecked
        btn_Cancelar.Enabled = lsv_Resguardo.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Resguardo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Resguardo.MouseHover, lsv_ResguardoD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class