Public Class frm_MaterialesAcepta

    Dim _Departamento As Dpto

    Private Sub frm_Valida_Ventas_Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenarLista()

        lsv_VentasD.Columns.Add("Clave")
        lsv_VentasD.Columns.Add("Descripcion")
        lsv_VentasD.Columns.Add("Cantidad")

        lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
    End Sub

    Sub LlenarLista()

        Cn_Proceso.fn_AceptaMateriales_LlenarLista(lsv_Ventas, _Departamento)
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Ventas.Items.Count)

    End Sub

    Private Sub lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Ventas.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Ventas.SelectedItems.Count = 0 Then
            lsv_VentasD.Items.Clear()
            btn_Validar.Enabled = False
            'Exit Sub
        Else
            btn_Validar.Enabled = True
            Cn_Proceso.fn_AceptaMaterialesD_LlenarLista(lsv_VentasD, lsv_Ventas.SelectedItems(0).Tag)
            lsv_VentasD.Columns(2).TextAlign = HorizontalAlignment.Right
        End If
        FuncionesGlobales.RegistrosNum(Lbl_Registros1, lsv_VentasD.Items.Count)
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        If lsv_Ventas.SelectedItems.Count > 0 Then

            If Cn_Proceso.fn_AceptaMateriales_Validar(lsv_Ventas.SelectedItems(0).Tag) = True Then
                Dim frm As New frm_FirmaElectronica
                frm.ShowDialog()
                If Not frm.Firma Then Exit Sub
                'Validar que aun siga en Status='SO'
                If Not Cn_Proceso.fn_AceptaMateriales_ValidaStatus(lsv_Ventas.SelectedItems(0).Tag, "SO") Then
                    MsgBox("El Lote ya no está disponible. Es posible que otro usuario lo haya recibido desde otra estación de trabajo o que el remitente lo haya cancelado.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                    Call LlenarLista()
                    btn_Validar.Enabled = False
                    Exit Sub
                End If
                'Validar el lote
                If Cn_Proceso.fn_AceptaMateriales_Aceptar(lsv_Ventas.SelectedItems(0).Tag, _Departamento, CInt(frm.tbx_Empleado.Text)) Then
                    Call LlenarLista()
                    MsgBox("Los Materiales se han aceptado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    btn_Validar.Enabled = False
                Else
                    MsgBox("Ha ocurrido un error al intentar aceptar los Materiales.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                MsgBox("No hay suficientes existencias.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
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

    Private Sub lsv_Ventas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Ventas.MouseHover, lsv_VentasD.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class