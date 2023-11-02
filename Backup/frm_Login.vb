Imports System
Imports System.Web.Security
Imports System.Text
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Deployment

Public Class frm_Login
    Dim Tbl As New DataTable
    Dim Veces As Integer = 0

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Veces = 0
        lbl_Bloqueado.Visible = False
        lbl_Modulo.Visible = False
        Call Deshabilitar_Todo()

        If TipoBloqueo = 0 Or TipoBloqueo = 3 Then
            lbl_Modulo.Visible = True
        ElseIf TipoBloqueo = 1 Then
            lbl_Bloqueado.Text = "BLOQUEADO POR EL USUARIO"
            lbl_Bloqueado.Visible = True
        ElseIf TipoBloqueo = 2 Then
            lbl_Bloqueado.Text = "BLOQUEADO POR INACTIVIDAD"
            lbl_Bloqueado.Visible = True
        End If

        Dim myVersion As Version
        ModuloNombre = "Proceso"



        If (Application.ApplicationDeployment.IsNetworkDeployed) Then

            Modo_Depuracion = False
            myVersion = Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
            lbl_Modulo.Text = "Modulo Proceso v" & String.Format("{0}", myVersion)
            ModuloVersion = String.Format("{0}", myVersion)
        Else
            Modo_Depuracion = True
            lbl_Modulo.Text = "Modulo Proceso"
            ModuloVersion = "1.0.0.0"
        End If

        ModuloClave = "10"
        EstacioN = FuncionesGlobales.fn_GetComputerName
        EstacionIp = FuncionesGlobales.fn_GetComputerIP
        EstacionMac = FuncionesGlobales.fn_GetComputarMAC

        'Llenar el Combo de Sitios
        Call Llenar_ComboSucursales()

    End Sub

    Private Sub cmd_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_OK.Click
        Dim hora As String = Now.ToString("HH:mm")
        Dim hora24 As String = DateAdd(DateInterval.Hour, 3.0, Now).ToString("HH:mm")

        Call Validar()
    End Sub

    Private Sub cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancel.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub tbx_Clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Clave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Validar()
        End If
    End Sub

    Sub Validar()
        LoginId = 0

        If Cmb_Sitio.Visible AndAlso Cmb_Sitio.Enabled Then
            If Cmb_Sitio.SelectedValue.ToString.Trim = "0" Then
                MsgBox("Debe Seleccionar un Sitio.", MsgBoxStyle.Critical, frm_MENU.Text)
                Cmb_Sitio.Focus()
                Exit Sub
            End If
        End If

        If Cmb_Sitio.Items.Count < 2 Then
            MsgBox("No ha Capturado ningun Servidor y Base de Datos al cual conectarse.", MsgBoxStyle.Critical, frm_MENU.Text)
            Windows.Forms.Application.Exit()
            Exit Sub
        End If

        Dim Contra As String = tbx_Clave.Text.Trim
        tbx_Clave.Clear()
        If tbx_Numero.Text.Trim = "" Then
            MsgBox("Indique el ID de Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.Focus()
            Exit Sub
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(tbx_Numero.Text.Trim, FuncionesGlobales.Validar_Cadena.Numeros_Enteros) Then
            MsgBox("'" & tbx_Numero.Text.Trim & "', No es un ID de Empleado válido.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Contra = "" Then
            MsgBox("Indique la Contraseña.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(Contra, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            MsgBox("Indique una Contraseña válida.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        Dim Datos() As String = Split(Cmb_Sitio.SelectedValue, "/")
        If Datos.Length < 4 Then
            MsgBox("No se pudo obtener la información suficiente para establecer la conexión... Consulte al Administrador del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        ServDatos = Datos(0).ToString
        BaseDatos = Datos(1).ToString
        UsuarioDatos = Datos(2).ToString
        ContraDatos = Datos(3).ToString
        SucursalDatos = Cmb_Sitio.Text

        If ServDatos <> "" And BaseDatos <> "" And UsuarioDatos <> "" And ContraDatos <> "" Then
            Cnx_Datos = "Data Source=" & ServDatos & ";Initial Catalog=" & BaseDatos & ";User Id=" & UsuarioDatos & ";Password=" & ContraDatos & ";"
        Else
            MsgBox("No se pudo obtener la información suficiente para establecer la conexión... Consulte al Administrador del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            Windows.Forms.Application.Exit()
            Exit Sub
        End If

        'probar la conexion
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            con.Open()
            con.Close()

            Dim dt_ParametrosGlobales As DataTable = Cn_Login.ParametrosGlobales_Leer

            If dt_ParametrosGlobales Is Nothing Then
                MsgBox("Ocurrió un error al consultar los Parámetros del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If dt_ParametrosGlobales.Rows.Count = 0 Then
                MsgBox("No se encontraron los Parámetros del Sistema o no fué posible consultarlos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                Intentos_Login = dt_ParametrosGlobales.Rows(0)("Intentos_Login")
            End If
            dt_ParametrosGlobales.Dispose()

        Catch ex As Exception
            MsgBox("No se pudo conectar al Servidor... Consulte al Administrador del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            Windows.Forms.Application.Exit()
            Exit Sub
        End Try

        Veces += 1
        If Veces > Intentos_Login Then
            'Bloquear al usuario por exceder los intentos.
            ResP = Cn_Login.Usuarios_Bloquear(Integer.Parse(tbx_Numero.Text.Trim))
            If ResP > 0 Then
                MsgBox("Usted ha sido Bloqueado por exceder los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Veces = 0
                'Guardar en Bitacora
                FuncionesGlobales.fn_GuardaBitacora(5, "ID_EMPLEADO:" & tbx_Numero.Text)
                Exit Sub
            Else
                MsgBox("Usted ha excedido los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Dim DT As DataTable = Cn_Login.Usuarios_Read(Integer.Parse(tbx_Numero.Text.Trim))
        If DT Is Nothing Then
            MsgBox("Usuario no encontrado.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        If DT.Rows.Count = 0 Then
            DT.Dispose()
            MsgBox("Usuario no encontrado.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        Else
            ContraHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Contra, "SHA1")
            If DT.Rows(0)("Password") <> ContraHash Then
                DT.Dispose()
                MsgBox("Usuario o Contraseña Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Clave.Focus()
                Exit Sub
            End If

            'Cerrar modales dependiendo del tipo de bloqueo
            If TipoBloqueo = 3 Then
                For Each element As Form In frm_MENU.MdiChildren
                    element.Close()
                Next
            ElseIf TipoBloqueo <> 0 Then
                If UsuarioId <> DT.Rows(0)("Id_Empleado") Then
                    For Each element As Form In frm_MENU.MdiChildren
                        element.Close()
                    Next

                End If
            End If

            UsuarioId = DT.Rows(0)("Id_Empleado")
            UsuarioN = DT.Rows(0)("Nombre")
            EmpresaId = DT.Rows(0)("Id_Empresa")
            SucursalId = DT.Rows(0)("Id_Sucursal")
            SucursalN = DT.Rows(0)("Sucursal")
            CiaId = DT.Rows(0)("ID_Cia")
            MonedaId = DT.Rows(0)("Moneda_Local")
            UsuarioTipo = DT.Rows(0)("Tipo")
            MinutosDesconexion = DT.Rows(0)("Minutos_DesconexionSIAC")
            DepartamentoID = DT.Rows(0)("Id_Departamento")
            Mail_ReporteFallas = DT.Rows(0)("Mail_ReporteFallas").ToString.Trim

            Select Case Cn_Login.fn_ObtieneValoresLicencia2014()
                Case -1
                    MsgBox("Ocurrió un Error al Consultar Datos de la Licencia de Uso.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Windows.Forms.Application.Exit()
                Case 0
                    MsgBox("La Información de la Licencia de Uso esta Incompleta o no Existe.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                    Windows.Forms.Application.Exit()
                Case 1
                    MsgBox("La Fecha de la Licencia está Expirada. Consulte al Administrador de Sistemas.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                    Windows.Forms.Application.Exit()
                Case 2
                    MsgBox("El Máximo de Usuarios Locales permitos ha superado lo establecido en su Licencia de uso.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Windows.Forms.Application.Exit()
                Case 3
                    MsgBox("El Registro de Licencia de Uso es Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Windows.Forms.Application.Exit()
            End Select

            frm_MENU.lbl_UsuarioN.Text = UsuarioN
            SesionId = Cn_Login.GetSession

            LoginId = 0
            LoginId = Cn_Login.Login_Insertar()

            If LoginId = 0 Then
                MsgBox("No se pudo obtener el Identificador de Sesión para el Usuario.", MsgBoxStyle.Critical, frm_MENU.Text)
                End
            End If

            If DT.Rows(0)("Status") <> "A" Then
                DT.Dispose()
                Cn_Login.fn_Log_Create("USUARIO BLOQUEADO. IMPOSIBLE ENTRAR AL SISTEMA")
                MsgBox("Usuario Bloqueado. Imposible Entrar al Sistema. Consulte al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
                Veces = 0
                tbx_Clave.Focus()
                Exit Sub
            ElseIf DT.Rows(0)("Dias_Expira") < 1 Then
                MsgBox("La Contraseña está expirada. Por favor capture una nueva.", MsgBoxStyle.Critical, frm_MENU.Text)
                DT.Dispose()
                Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIAR CONTRASEÑA")
                frm_LoginContra.ShowDialog()
                If Not BanderA Then
                    Cn_Login.fn_Log_Create("NO SE CAMBIO LA CONTRASEÑA")
                    MsgBox("No se Capturó la Nueva Contraseña o hubo un Problema al intentar Guardarla.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    Cn_Login.fn_Log_Create("SE CAMBIO LA CONTRASEÑA")
                End If
                Veces = 0
                Exit Sub
            Else

                ContraHash = ""
                TurnoId = Cn_Login.fn_ObtenTurno
                DT.Dispose()

                If UsuarioTipo = 1 Or UsuarioTipo = 3 Then
                    If Not Cn_Login.Usuarios_Horas(UsuarioId) Then
                        MsgBox("Usuario: " & UsuarioN & " No tiene Privilegios para entrar en este Dia y Hora.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    Call MenuS()
                    Call ControlesPermisos()
                Else
                    Call Habilitar_Todo()
                    Call ControlesPermisos()
                End If
                If UsuarioTipo = 3 Or UsuarioTipo = 4 Or UsuarioTipo = 5 Then
                    BanderA = False
                    frm_LoginEmpresa.ShowDialog()
                    If Not BanderA Then
                        Exit Sub
                    End If
                End If
                Veces = 0

                If TipoBloqueo = 3 Then
                    Cn_Login.fn_Log_Create("INICIO DE SESION(DESPUES DE CAMBIO DE CONEXIÓN)")
                ElseIf TipoBloqueo <> 0 Then
                    Cn_Login.fn_Log_Create("INICIO DE SESION(DESPUES DE BLOQUEO)")
                Else
                    Cn_Login.fn_Log_Create("INICIO DE SESION")
                End If

                If TipoBloqueo = 3 Then
                    For Each element As Form In frm_MENU.MdiChildren
                        element.Close()
                    Next
                ElseIf TipoBloqueo <> 0 Then
                    If UsuarioId <> DT.Rows(0)("Id_Empleado") Then
                        For Each element As Form In frm_MENU.MdiChildren
                            element.Close()
                        Next

                    End If
                End If

                'AUDITORIA DE SOFTWARE
                Me.Cursor = Cursors.WaitCursor
                If Not Cn_Login.fn_Software_Existe() Then
                    Cn_Login.fn_Software_Create()
                End If

                Me.Cursor = Cursors.Default
                'REINICIAR EL TIPO DE BLOQUEO
                TipoBloqueo = 0
                SegundosDesconexion = 0
            End If
        End If
        Me.Close()
        frm_MENU.Show()
    End Sub

    Sub MenuS()
        'Leer los permisos del usuario y habilitar solo lo que tenga permiso
        Dim DT As DataTable = Cn_Login.Permisos_Read(UsuarioId)
        If DT Is Nothing Then
            MsgBox("Ocurrió un Error al intentar validar los privilegios del Usuario.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        For Each Row As DataRow In DT.Rows
            For Each element As ToolStripItem In frm_MENU.MenuStrip.Items
                If TypeOf (element) Is ToolStripMenuItem Then
                    For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                        If TypeOf (Child) Is ToolStripMenuItem Then
                            If Child.Tag Is Nothing Then
                                Child.Enabled = True
                            ElseIf Child.Tag = "" Then
                                Child.Enabled = True
                            ElseIf Child.Tag = Row("Descripcion") Then
                                Child.Enabled = True
                            End If
                            For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                                If TypeOf (SubChild) Is ToolStripMenuItem Then
                                    If SubChild.Tag Is Nothing Then
                                        SubChild.Enabled = True
                                    ElseIf SubChild.Tag = "" Then
                                        SubChild.Enabled = True
                                    ElseIf SubChild.Tag = Row("Descripcion") Then
                                        SubChild.Enabled = True
                                        Exit For
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Next

        'ToolStrip
        For Each RowC As DataRow In DT.Rows
            For Each element As ToolStripItem In frm_MENU.ToolStrip.Items
                If TypeOf (element) Is ToolStripButton Then
                    If element.Tag Is Nothing Then
                        element.Enabled = True
                    ElseIf element.Tag = "" Then
                        element.Enabled = True
                    ElseIf element.Tag = RowC("Descripcion") Then
                        element.Enabled = True
                    End If
                End If
            Next
        Next
    End Sub

    Sub ControlesPermisos()
        'Leer los permisos del usuario para los controles de las pantallas. 
        'Esta cadena se utilizará en el load de cada pantallas
        Dim DT As DataTable = Cn_Login.PermisosControles_Read(UsuarioId)
        For Each row As DataRow In DT.Rows
            If CadenaPermisosControles = "" Then
                CadenaPermisosControles = row("Descripcion")
            Else
                CadenaPermisosControles = CadenaPermisosControles & "," & row("Descripcion")
            End If
        Next
    End Sub

    Sub Deshabilitar_Todo()
        Dim SubSub As Integer = 0
        'MenuStrip
        For Each element As ToolStripItem In frm_MENU.MenuStrip.Items
            If TypeOf (element) Is ToolStripMenuItem Then
                SubSub = 0
                For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                    If TypeOf (Child) Is ToolStripMenuItem Then
                        For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                            SubSub = SubSub + 1
                            If TypeOf (SubChild) Is ToolStripMenuItem And SubChild.Tag <> "" Then
                                SubChild.Enabled = False
                            End If
                        Next
                        If SubSub = 0 And Child.Tag <> "" Then
                            Child.Enabled = False
                        End If

                    End If
                Next
            End If
        Next
        'ToolStrip
        For Each element As ToolStripItem In frm_MENU.ToolStrip.Items
            If TypeOf (element) Is ToolStripButton Then
                If element.Tag <> "" Then
                    element.Enabled = False
                End If
            End If
        Next
    End Sub

    Sub Habilitar_Todo()
        'MenuStrip
        For Each element As ToolStripItem In frm_MENU.MenuStrip.Items
            If TypeOf (element) Is ToolStripMenuItem Then
                For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                    If TypeOf (Child) Is ToolStripMenuItem Then
                        Child.Enabled = True
                        For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                            If TypeOf (SubChild) Is ToolStripMenuItem Then SubChild.Enabled = True
                        Next
                    End If
                Next
            End If
        Next
        'ToolStrip
        For Each element As ToolStripItem In frm_MENU.ToolStrip.Items
            If TypeOf (element) Is ToolStripButton Then
                element.Enabled = True
            End If
        Next
    End Sub

    Private Sub tbx_Numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Numero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbx_Clave.Focus()
        End If
    End Sub

    Private Sub tbx_Numero_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Numero.Enter
        tbx_Numero.SelectAll()
    End Sub

    Private Sub tbx_Clave_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Clave.Enter
        tbx_Clave.SelectAll()
    End Sub

    Private Sub Cmb_Sitio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Sitio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_Numero.Focus()
        End If
    End Sub

    Private Sub frm_Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.Alt And e.KeyCode = Keys.S Then
            Dim FrmF As New frm_FirmaConexion

            FrmF.ShowDialog()

            If FrmF.Validar = False Then Exit Sub

            Dim frm As New frm_Settings
            frm.ShowDialog()

            If My.Settings.TipoEsquema = "0" Then
                frm_Settings.ShowDialog()
                If My.Settings.TipoEsquema = "0" Then
                    MsgBox("No se ha especificado el tipo de esquema a utilizar.", MsgBoxStyle.Critical, Me.Text)
                    Me.Close() : Exit Sub
                End If
            End If

            If Cn_Proceso.fn_CuentaSettings() = 10 Then
                frm.ShowDialog()
                If Cn_Proceso.fn_CuentaSettings() = 10 Then
                    MsgBox("No se han capturado el nombre del Servidor y la Base de Datos.", MsgBoxStyle.Critical, Me.Text)
                    Me.Close() : Exit Sub
                End If
            End If

            Cmb_Sitio.DataSource = Nothing
            Cmb_Sitio.Items.Clear()
            Call Llenar_ComboSucursales()
        End If
    End Sub

    Public Sub LlenarComboconDataTable()
        Tbl.Columns.Clear()
        Tbl.Rows.Clear()
        Tbl.Columns.Add("value")
        Tbl.Columns.Add("display")

        Dim dr As DataRow = Tbl.NewRow
        dr("Value") = "0"
        dr("Display") = "Seleccione..."

        cmb_Sitio.ValueMember = "value"
        cmb_Sitio.DisplayMember = "display"
        Tbl.Rows.InsertAt(dr, 0)

        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) <> "SERVDATOS" Then Continue For
            If My.Settings(setting.Name) = "VACIO" Then Continue For
            If My.Settings(setting.Name) = "" Then Continue For

            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) = "SERVDATOS" Then
                Dim Row As DataRow = Tbl.NewRow
                Row("value") = Split(My.Settings(setting.Name), ",")(0)
                Row("display") = Split(My.Settings(setting.Name), ",")(1)
                Tbl.Rows.Add(Row)
            End If
        Next
        Tbl = FuncionesGlobales.fn_OrdenaTabla(Tbl, "display ASC")
        Cmb_Sitio.DataSource = Tbl
    End Sub

    Private Sub Llenar_ComboSucursales()
        If Cmb_Sitio.Items.Count < 2 Then
            Cmb_Sitio.Visible = My.Settings.TipoEsquema = "2"
            lbl_Sitio.Visible = My.Settings.TipoEsquema = "2"
            Call LlenarComboconDataTable()
            If My.Settings.TipoEsquema = "1" OrElse Cmb_Sitio.Items.Count = 2 Then
                Cmb_Sitio.Enabled = False
                Cmb_Sitio.SelectedIndex = 1
            Else
                Cmb_Sitio.SelectedIndex = 0
                Cmb_Sitio.Enabled = True
            End If
        End If
    End Sub

End Class
