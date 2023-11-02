Imports Modulo_Proceso.Cn_Actualizaciones

Public Class frm_ActualizacionesConsultar

    Private Sub frm_ActualizacionesConsultar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not fn_Actualizaciones_LlenarLista(lsv_Datos) Then
            MsgBox("Ha ocurrido un error al intentar consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text)

            FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Datos.Items.Count)

        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Sub Limpiar()
        'limpiar los controles
        tbx_Descripcion.Clear()
        FuncionesGlobales.RegistrosNum(Lbl_Registros, lsv_Datos.Items.Count)
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        Call Limpiar()
        Dim Cadena As New System.Text.StringBuilder

        If lsv_Datos.SelectedItems.Count = 0 Then Exit Sub
        Dim dt As DataTable
        dt = fn_Actualizaciones_Read(lsv_Datos.SelectedItems(0).Tag)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                'mostrar los datos
                Cadena.Append("Modulo: ")
                Cadena.Append(dt.Rows(0)("Modulo"))
                Cadena.Append(Chr(13))
                Cadena.Append(Chr(13))

                Cadena.Append("Menu: ")
                Cadena.Append(dt.Rows(0)("Menu"))
                Cadena.Append(Chr(13))
                Cadena.Append(Chr(13))

                Cadena.Append("Opción: ")
                Cadena.Append(dt.Rows(0)("Opcion"))
                Cadena.Append(Chr(13))
                Cadena.Append(Chr(13))

                Cadena.Append("Fecha: ")
                Cadena.Append(dt.Rows(0)("Fecha"))
                Cadena.Append(Chr(13))
                Cadena.Append(Chr(13))

                Cadena.Append("Registró: ")
                Cadena.Append(dt.Rows(0)("Usuario_Registro"))
                Cadena.Append(Chr(13))
                Cadena.Append(Chr(13))

                Cadena.Append("Descripción: ")
                Cadena.Append(Chr(13))
                Cadena.Append(dt.Rows(0)("Descripcion"))
                Cadena.Append(Chr(13))
                Cadena.Append(Chr(13))

                tbx_Descripcion.Text = Cadena.ToString
            Else
                MsgBox("No se encontró el detalle de la Actualización.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            MsgBox("Ocurrió un error al intentar consultar el detalle de la Actualización.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Datos_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Datos.MouseMove
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class