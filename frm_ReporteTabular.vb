Public Class frm_ReporteTabular

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Buscar()
        SegundosDesconexion = 0

        If tbx_Remision.Text <> "" Then
            cmb_Cia.ValorParametro = CLng(tbx_Remision.Text)
            cmb_Cia.Actualizar()

            If cmb_Cia.Items.Count = 2 Then
                cmb_Cia.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Buscar()
    End Sub


    Private Sub cmb_Cia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedValueChanged
        SegundosDesconexion = 0

        Dim row As DataRow = Cn_Proceso.fn_Rastreo_LlenarProceso(cmb_Cia.SelectedValue)

        If row IsNot Nothing Then
            tbx_Sesion.Text = row("Numero_Sesion").ToString
            tbx_CajaBancaria.Text = row("Caja").ToString
            tbx_Cliente.Text = row("Cliente").ToString
            tbx_Cajero.Text = row("Cajero").ToString
            tbx_GrupoDeposito.Text = row("GrupoDepo").ToString
            tbx_FechaRecepcion.Text = row("Fecha_Recibe").ToString
            tbx_FechaAsignacion.Text = row("Fecha_Asigna").ToString
            tbx_FechaInicioVerificacion.Text = row("Fecha_InicioV").ToString
            tbx_FechaFinVerificacion.Text = row("Fecha_FinV").ToString
            tbx_FechaContabilizacion.Text = row("Fecha_Contabiliza").ToString
            tbx_Fichas.Text = row("Cantidad_Fichas").ToString
            tbx_FichasContabilizadas.Text = row("Cantidad_FichasC").ToString
            tbx_Corte.Text = row("Corte_Turno").ToString
            tbx_EstacionRecibe.Text = row("Estacion_Recibe").ToString
            tbx_EstacionAsigna.Text = row("Estacion_Asigna").ToString
            tbx_EstacionVerifica.Text = row("Estacion_Verifica").ToString
            tbx_MinutosVerificando.Text = row("MinutosVerificando").ToString
            tbx_StatusPro.Text = row("Status").ToString
        Else
            tbx_Sesion.Clear()
            tbx_CajaBancaria.Clear()
            tbx_Cliente.Clear()
            tbx_Cajero.Clear()
            tbx_GrupoDeposito.Clear()
            tbx_FechaRecepcion.Clear()
            tbx_FechaAsignacion.Clear()
            tbx_FechaInicioVerificacion.Clear()
            tbx_FechaFinVerificacion.Clear()
            tbx_FechaContabilizacion.Clear()
            tbx_Fichas.Clear()
            tbx_FichasContabilizadas.Clear()
            tbx_Corte.Clear()
            tbx_EstacionRecibe.Clear()
            tbx_EstacionAsigna.Clear()
            tbx_EstacionVerifica.Clear()
            tbx_MinutosVerificando.Clear()
            tbx_StatusPro.Clear()
        End If

        btn_Imprimir.Enabled = False
        Select Case tbx_StatusPro.Text
            Case "VERIFICADO", "CONTABILIZADO"
                btn_Imprimir.Enabled = True
                btn_Fichas.Enabled = True
        End Select

    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0

        Dim frm As New frm_Reporte
        Dim rpt As New rpt_Tabular
        Dim ds As New ds_Reportes
        Dim Id_Remision As Integer = cmb_Cia.SelectedValue

        If Not Cn_Proceso.fn_Tabular_LlenarEncabezado(ds.Tbl_Tabular, Id_Remision) Then
            MsgBox("Ha ocurrido un error al intentar cargar el reporte", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim txt_Cajera As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cajera")
        Dim txt_Cliente As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cliente")

        Dim row As DataRow = Cn_Proceso.fn_Tabular_ObtenCajerayCliente(Id_Remision)
        txt_Cajera.Text = row("Cajera")
        txt_Cliente.Text = row("Cliente")

        rpt.SetDataSource(ds)
        rpt.Subreports(0).SetDataSource(ds)
        rpt.Subreports(1).SetDataSource(ds)
        frm.crv.ReportSource = rpt
        frm.ShowDialog()
    End Sub

    Private Sub btn_Fichas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Fichas.Click
        SegundosDesconexion = 0

        Dim frm As New frm_Reporte
        Dim rpt As New rpt_TabularFicha
        Dim ds As New ds_Reportes
        Dim Id_Remision As Integer = cmb_Cia.SelectedValue

        If Not Cn_Proceso.fn_Tabular_LlenarEncabezadoFichas(ds.Tbl_TabularFicha, Id_Remision) Then
            MsgBox("Ha ocurrido un error al intentar buscar las Fichas", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not Cn_Proceso.fn_Tabular_LlenarSubInformesFichas(ds.Tbl_DenominacionesFichas, Id_Remision) Then
            MsgBox("Ha ocurrido un error al intentar buscar las Denominaciones", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim txt_Cajera As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cajera")
        Dim txt_Cliente As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cliente")
        Dim txt_Cia As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cia")
        Dim txt_Fecha As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Fecha")

        Dim row As DataRow = Cn_Proceso.fn_Tabular_ObtenCajerayCliente(Id_Remision)
        txt_Cajera.Text = row("Cajera")
        txt_Cliente.Text = row("Cliente")
        txt_Cia.Text = cmb_Cia.Text
        txt_Fecha.Text = row("Fecha")

        rpt.SetDataSource(ds)

        frm.crv.ReportSource = rpt
        frm.ShowDialog()

    End Sub

    Private Sub gbx_Campos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Campos.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

End Class