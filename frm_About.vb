Public Class frm_About

    Private Sub frm_About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr_Move.Enabled = True

        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        'Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = ModuloVersion 'String.Format("Versión {0}", My.Application.Info.Version.ToString)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        TextBoxDescription.Text = My.Application.Info.Description
        LabelProductName.Visible = True

        'Consultar los Programadores
        Dim dt As DataTable

        dt = Cn_Login.Programadores_Get
        If dt Is Nothing Then Exit Sub
        Dim Contador As Integer = 0
        Lsv_Programadores.Columns.Add("", Lsv_Programadores.Width + 50)
        For Each fila As DataRow In dt.Rows
            Lsv_Programadores.Items.Add(fila("Nombre"))
            Contador += 1
            If fila("Tipo") = 1 Then
                Lsv_Programadores.Items(Lsv_Programadores.Items.Count - 1).ForeColor = Color.Maroon
            Else
                Lsv_Programadores.Items(Lsv_Programadores.Items.Count - 1).ForeColor = Color.Goldenrod
            End If
            If fila("Tipo") = 3 Then
                Lsv_Programadores.Items.Add("")
                Contador += 1
            End If
        Next
        Lsv_Programadores.Height = Contador * 20
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub tmr_Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Move.Tick
        Lsv_Programadores.Top -= 1
        If (Lsv_Programadores.Top + Lsv_Programadores.Height) < 0 Then
            Lsv_Programadores.Top = 150
        End If
    End Sub

    Private Sub Lsv_Programadores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Programadores.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

End Class
