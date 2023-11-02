
Public Class frm_MaterialesReporte

    Dim _Departamento As Dpto

    Private Sub frm_AceptaMaterialesReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Status.AgregarItem("SO", "PENDIENTE")
        cmb_Status.AgregarItem("EM", "RECIBIDO")
        cmb_Status.AgregarItem("CA", "CANCELADO")

        lsv_Ventas.Columns.Add("Fecha")
        lsv_Ventas.Columns.Add("Hora")
        lsv_Ventas.Columns.Add("Envia")
        lsv_Ventas.Columns.Add("Status")

        lsv_VentasD.Columns.Add("Clave")
        lsv_VentasD.Columns.Add("Descripcion")
        lsv_VentasD.Columns.Add("Cantidad")
    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0

        Dim Desde As String = FuncionesGlobales.fn_Fecha102(dtp_Desde.Value.ToShortDateString)
        Dim Hasta As String = FuncionesGlobales.fn_Fecha102(dtp_Hasta.Value.ToShortDateString)
        Dim Status As String = ""

        If cmb_Status.SelectedValue <> "0" Then
            Status = cmb_Status.SelectedValue
        End If
        'Aqui se llena la lista
        Cn_Proceso.fn_AceptaMaterialesReporte_LlenarLista(lsv_Ventas, _Departamento, Desde, Hasta, Status)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Ventas.Items.Count)
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_Desde.Value > dtp_Hasta.Value Then
            MsgBox("Las fechas seleccionadas parecen ser incorrectas.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If
        If cmb_Status.Enabled = True And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Status.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If
        Call LlenarLista()
    End Sub

    Public Sub New(ByVal Departamento As Dpto)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _Departamento = Departamento
    End Sub

    Private Sub lsv_Ventas_AlActualizar() Handles lsv_Ventas.AlActualizar
        lsv_VentasD.Items.Clear()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        Call LimpiarListas()
        If chk_Status.Checked = True Then
            cmb_Status.SelectedValue = "0"
            cmb_Status.Enabled = False
        Else
            cmb_Status.SelectedValue = "0"
            cmb_Status.Enabled = True
        End If
    End Sub

    Private Sub lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Ventas.SelectedIndexChanged
        lsv_VentasD.Items.Clear()
        FuncionesGlobales.RegistrosNum(lbl_Registros1, 0)
        If lsv_Ventas.SelectedItems.Count > 0 Then
            Cn_Proceso.fn_AceptaMaterialesDReporte_LlenarLista(lsv_VentasD, lsv_Ventas.SelectedItems(0).Tag)
            lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
        End If
        FuncionesGlobales.RegistrosNum(lbl_Registros1, lsv_VentasD.Items.Count)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        Call LimpiarListas()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        Call LimpiarListas()
    End Sub

    Sub LimpiarListas()
        SegundosDesconexion = 0

        lsv_Ventas.Items.Clear()
        lsv_VentasD.Items.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Ventas.Items.Count)
    End Sub

    Private Sub lsv_Ventas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Ventas.MouseHover, lsv_VentasD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

End Class