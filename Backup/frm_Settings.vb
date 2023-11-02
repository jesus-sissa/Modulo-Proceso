Public Class frm_Settings
    Dim NombreSett As String
    Dim Cont As Integer = 0

    Private Sub frm_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Esquema.AgregarItem("1", "CENTRALIZADA")
        cmb_Esquema.AgregarItem("2", "DISTRIBUIDA")

        cmb_Esquema.SelectedValue = My.Settings.TipoEsquema
        cmb_Esquema.Enabled = (cmb_Esquema.SelectedValue = "0")

        btn_First_Click(btn_First, New EventArgs)
        If cmb_Esquema.SelectedValue = "1" AndAlso cmb_Esquema.SelectedValue <> "0" Then
            gbx_TeclasNavega.Enabled = False
        Else
            gbx_TeclasNavega.Enabled = True
        End If
    End Sub

    Private Sub frm_Settings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.Alt And e.KeyCode = Keys.S Then
            cmb_Esquema.Enabled = True
        End If
    End Sub

    Private Sub cmb_Esquema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Esquema.SelectedIndexChanged
        If cmb_Esquema.SelectedValue = "1" OrElse cmb_Esquema.SelectedValue = "0" Then
            gbx_TeclasNavega.Enabled = False
            tbx_Sucursal.Enabled = False
            tbx_Sucursal.Text = "DEFAULT"
        Else
            gbx_TeclasNavega.Enabled = True
            tbx_Sucursal.Enabled = True
            tbx_Sucursal.Text = ""
        End If

        btn_First_Click(btn_First, New EventArgs)
    End Sub

    Sub Limpiar()
        tbx_NombreBDD.Text = ""
        tbx_Contra.Text = ""
        tbx_Usuario.Text = ""
        tbx_Sucursal.Text = ""
    End Sub

    Private Sub btn_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_First.Click
        Dim Datos() As String
        Cont = 0
        Call Limpiar()
        NombreSett = "ServDatos" & Cont
        Datos = My.Settings(NombreSett).ToString.Split(",")
        If Datos(0).Split("/")(0) = "VACIO" Then
            tbx_NombreServidor.Text = "VACIO" & " " & Cont
        Else
            Dim Datos1() As String
            Datos1 = Datos(0).Split("/")
            tbx_NombreServidor.Text = Datos1(0)
            tbx_NombreBDD.Text = Datos1(1)
            If Datos1.Length > 2 Then
                tbx_Usuario.Text = Datos1(2)
                tbx_Contra.Text = Datos1(3)
            End If
            tbx_Sucursal.Text = Datos(1)
        End If
        btn_Back.Enabled = False
        btn_Next.Enabled = True
    End Sub

    Private Sub btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back.Click
        Dim Datos() As String
        Cont -= 1
        Call Limpiar()
        NombreSett = "ServDatos" & Cont
        Datos = My.Settings(NombreSett).ToString.Split(",")
        If Datos(0).Split("/")(0) = "VACIO" Then
            tbx_NombreServidor.Text = "VACIO" & " " & Cont
        Else
            Dim Datos1() As String
            Datos1 = Datos(0).Split("/")
            tbx_NombreServidor.Text = Datos1(0)
            tbx_NombreBDD.Text = Datos1(1)
            If Datos1.Length > 2 Then
                tbx_Usuario.Text = Datos1(2)
                tbx_Contra.Text = Datos1(3)
            End If
            tbx_Sucursal.Text = Datos(1)
        End If
        btn_Next.Enabled = True
        If Cont = 0 Then
            btn_Back.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        Dim Datos() As String
        Cont += 1
        Call Limpiar()
        NombreSett = "ServDatos" & Cont
        Datos = My.Settings(NombreSett).ToString.Split(",")
        If Datos(0).Split("/")(0).ToUpper = "VACIO" Then
            tbx_NombreServidor.Text = "VACIO" & " " & Cont
        Else
            Dim Datos1() As String
            Datos1 = Datos(0).Split("/")
            tbx_NombreServidor.Text = Datos1(0)
            tbx_NombreBDD.Text = Datos1(1)
            If Datos1.Length > 2 Then
                tbx_Usuario.Text = Datos1(2)
                tbx_Contra.Text = Datos1(3)
            End If
            tbx_Sucursal.Text = Datos(1)
        End If
        btn_Back.Enabled = True
        If Cont = 9 Then
            btn_Next.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub btn_Last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Last.Click
        Dim Datos() As String
        Cont = 9
        Call Limpiar()
        NombreSett = "ServDatos" & Cont
        Datos = My.Settings(NombreSett).ToString.Split(",")
        If Datos(0).Split("/")(0).ToUpper = "VACIO" Then
            tbx_NombreServidor.Text = "VACIO" & " " & Cont
        Else
            Dim Datos1() As String
            Datos1 = Datos(0).Split("/")
            tbx_NombreServidor.Text = Datos1(0)
            tbx_NombreBDD.Text = Datos1(1)
            If Datos1.Length > 2 Then
                tbx_Usuario.Text = Datos1(2)
                tbx_Contra.Text = Datos1(3)
            End If
            tbx_Sucursal.Text = Datos(1)
        End If
        btn_Next.Enabled = False
        btn_Back.Enabled = True
    End Sub

    Private Sub cmd_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_NombreServidor.Text.Trim = "VACIO" Then
            My.Settings(NombreSett) = "VACIO"
            My.Settings.Save()

            My.Settings.TipoEsquema = cmb_Esquema.SelectedValue
            My.Settings.Save()

            MsgBox("Datos Guardados Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_NombreServidor.Text = "VACIO" & " " & Cont
            tbx_NombreBDD.Text = ""
            tbx_Contra.Text = ""
            tbx_Usuario.Text = ""
            tbx_Sucursal.Text = ""
            Exit Sub
        End If

        If cmb_Esquema.SelectedValue = "0" Then
            MsgBox("Seleccione el tipo de esquema a utilizar en el sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_NombreServidor.Text.Trim = "" Then
            MsgBox("Capture el nombre del Servidor.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreServidor.Focus()
            Exit Sub
        End If

        If tbx_NombreBDD.Text.Trim = "" Then
            MsgBox("Capture el nombre de la Base de Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreBDD.Focus()
            Exit Sub
        End If

        If tbx_Usuario.Text.Trim = "" Then
            MsgBox("Capture el nombre de Usuario de Base de Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Usuario.Focus()
            Exit Sub
        End If

        If tbx_Contra.Text.Trim = "" Then
            MsgBox("Capture la contraseña para la Conexión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Contra.Focus()
            Exit Sub
        End If

        If tbx_Sucursal.Text.Trim = "" Then
            MsgBox("Capture el nombre de la Sucursal.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Sucursal.Focus()
            Exit Sub
        End If
        'Verificar que no se repita Sucursal(cuando es Distribuida) es loque se muestra en Display del ComboBox
        If My.Settings.TipoEsquema = "2" Then
            For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
                If My.Settings(setting.Name).ToString = "VACIO" Then Continue For
                If My.Settings(setting.Name).ToString = "" Then Continue For
                If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) <> "SERVDATOS" Then Continue For

                If (My.Settings(setting.Name)).ToString.Split(",")(0) <> "VACIO" Then
                    If (My.Settings(setting.Name)).ToString.Split(",")(1) = tbx_Sucursal.Text.Trim Then
                        MsgBox("La Sucursal ya ha sido Capturada.", MsgBoxStyle.Critical)
                        tbx_Contra.Focus()
                        Exit Sub
                    End If

                End If
            Next
        End If
        'verificar que no exista esa cadena de Conexion
        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) <> "SERVDATOS" Then Continue For
            If (My.Settings(setting.Name)).ToString.Split(",")(0) <> "VACIO" Then
                If (My.Settings(setting.Name)).ToString.Split(",")(0) = tbx_NombreServidor.Text.Trim & "/" & tbx_NombreBDD.Text.Trim & "/" & tbx_Usuario.Text.Trim & "/" & tbx_Contra.Text.Trim Then
                    MsgBox("El Servidor y/o la Base de Datos ya han sido capturados.", MsgBoxStyle.Critical)
                    tbx_NombreServidor.Focus()
                    Exit Sub
                End If
            End If
        Next
        'Probar la Conexion
        Dim Conex As String = ""
        Cursor = Cursors.WaitCursor
        Conex = "Data Source=" & tbx_NombreServidor.Text.Trim & " ;Initial Catalog=" & tbx_NombreBDD.Text.Trim & ";User Id=" & tbx_Usuario.Text.Trim & ";Password=" & tbx_Contra.Text.Trim & ";"
        If ProbarConexion(Conex) = False Then
            MsgBox("No se pudo conectar al Servidor... Consulte al Administrador del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreServidor.SelectAll()
            tbx_NombreServidor.Focus()
            Cursor = Cursors.Default
            Exit Sub
        End If
        Cursor = Cursors.Default

        My.Settings(NombreSett) = tbx_NombreServidor.Text.Trim & "/" & tbx_NombreBDD.Text.Trim & "/" & tbx_Usuario.Text.Trim & "/" & tbx_Contra.Text.Trim & "," & tbx_Sucursal.Text.Trim
        My.Settings.Save()
        My.Settings.TipoEsquema = cmb_Esquema.SelectedValue
        My.Settings.Save()
        If My.Settings.TipoEsquema <> "0" Then cmb_Esquema.Enabled = False
        SegundosDesconexion = 0
        MsgBox("Datos Guardados Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
    End Sub

    Function ProbarConexion(ByVal CadConex As String) As Boolean
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(CadConex)
        Try
            con.Open()
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub tbx_Contra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Contra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_Sucursal.Focus()
        End If
    End Sub

    Private Sub cmd_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

End Class