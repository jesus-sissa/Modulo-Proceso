﻿Imports System.IO
Imports Modulo_Proceso.HostToHost
Imports System.Threading
Imports Modulo_Proceso.Cn_Proceso
Imports Api_Bank
Imports Newtonsoft.Json

Public Class frm_ArchivoDepositos

    Private Sub frm_ArchivoDepositos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Archivos.Columns.Add("Archivos", 500)
        cmb_Sesion.Actualizar()
    End Sub


    Public Sub HostToHost_Finalizado(ByVal e As Modulo_Proceso.HostToHost.RecibirArchivosDepositosTXTCompletedEventArgs)
        Dim descripcion As String = ""
        Dim Status As ClsDepositoEstatus = e.Result

        Select Case Status.iEstatus
            Case EnumEstatusArchivoDeposito.Aceptado
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
            Case EnumEstatusArchivoDeposito.Cancelado
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
            Case EnumEstatusArchivoDeposito.CorreoEnviado
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
            Case EnumEstatusArchivoDeposito.Pendiente
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
            Case EnumEstatusArchivoDeposito.PendienteParaPrecarga
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
            Case EnumEstatusArchivoDeposito.PreCarga
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
            Case EnumEstatusArchivoDeposito.RechazadoEnvio
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
            Case EnumEstatusArchivoDeposito.RechazadoPrecarga
                descripcion &= "DESCRIPCION STATUS " & Status.sDescripcionEstatus & vbLf & " MENSAJE ERROR " & Status.sMensajeError & vbLf & " MENSAJE SALIDA " & Status.sMensajeSalida
        End Select

        MessageBox.Show(descripcion)
        chk_Todos.Checked = False
        lsv_Archivos.Items.Clear()
    End Sub

    Public Sub ActivarDesactivar()
        For Each item As ListViewItem In lsv_Archivos.Items
            item.Checked = chk_Todos.Checked
        Next
    End Sub

    Public Function ExisteArchivo(ByVal Path As String)
        If Not File.Exists(Path) Then Return False
        Return True
    End Function

    Public Function ArchivoCheque(ByVal NombreArchivoDeposito As String)
        Return NombreArchivoDeposito.Replace(NombreArchivoDeposito.Substring(NombreArchivoDeposito.LastIndexOf("D")), NombreArchivoDeposito.Substring(NombreArchivoDeposito.LastIndexOf("D")).Replace("D", "C"))
    End Function

    Public Function ValidaArchivo() As Boolean
        Try
            For Each item As ListViewItem In lsv_Archivos.CheckedItems

                'valida archivos de depósitos seleccionados
                If Not ExisteArchivo(item.Text.Trim) Then
                    Return False
                End If

                'valida archvos de cheques de cada archivo de depósitos
                If Not ExisteArchivo(ArchivoCheque(item.Text.Trim)) Then
                    File.Create(ArchivoCheque(item.Text.Trim))
                End If
            Next
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Function LeerArchivo(ByVal Path As String) As String
        Dim ContenidoArchivo As String = ""
        Try
            Dim sr As New StreamReader(Path)
            ContenidoArchivo = sr.ReadToEnd()
            sr.Close()
            sr.Dispose()
        Catch ex As Exception
            ContenidoArchivo = ""
        End Try
        Return ContenidoArchivo
    End Function

    Private Function NombreArchivo(ByVal Path As String) As String
        Dim Archivo As String = ""
        Dim Fi As New FileInfo(Path)
        Return Fi.Name
    End Function

    Class HostToHost
        Dim HostToHost As New Modulo_Proceso.HostToHost.wsDepositosClientesETV
        Public Delegate Sub HostToHostEventHandler(ByVal e As Modulo_Proceso.HostToHost.RecibirArchivosDepositosTXTCompletedEventArgs)
        Public Event EventHostToHost As HostToHostEventHandler


        Public Sub Enviar(ByVal NombreArchivoDepositos As String, ByVal ArchivoDepositos As String, ByVal NombreArchivoCheques As String, ByVal ArchivoCheques As String)
            AddHandler HostToHost.RecibirArchivosDepositosTXTCompleted, AddressOf RequestCompleted
            HostToHost.RecibirArchivosDepositosTXTAsync("90011", NombreArchivoDepositos, ArchivoDepositos, NombreArchivoCheques, ArchivoCheques)
        End Sub

        Public Sub RequestCompleted(ByVal sender As Object, ByVal e As Modulo_Proceso.HostToHost.RecibirArchivosDepositosTXTCompletedEventArgs)
            RaiseEvent EventHostToHost(e)
        End Sub
    End Class

    Private Sub btn_Destino_Click_1(sender As Object, e As EventArgs) Handles btn_Destino.Click
        lsv_Archivos.Items.Clear()


        lbl_Registros.Text = "Registros: 0"
        Dim Dialogo As New FolderBrowserDialog
        Dialogo.Description = "Seleccione la Carpeta."
        Dialogo.ShowNewFolderButton = False
        btn_Enviar.Enabled = lsv_Archivos.Items.Count

        If Dialogo.ShowDialog() = DialogResult.OK Then
            lsv_Archivos.Items.Clear()
            Try
                Dim di As New IO.DirectoryInfo(Dialogo.SelectedPath)
                Dim aryFi As IO.FileInfo() = di.GetFiles("D*.txt")


                For Each fi As FileInfo In aryFi
                    lsv_Archivos.Items.Add(fi.FullName)
                Next

                If lsv_Archivos.Items.Count = 0 Then
                    MsgBox("No se encotnraron archivos en la carpeta seleccionada: " & Dialogo.SelectedPath)
                End If

                If lsv_Archivos.Items.Count > 0 Then lbl_Registros.Text = "Registros: " & lsv_Archivos.Items.Count

                btn_Enviar.Enabled = lsv_Archivos.Items.Count
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            End Try
        End If
    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click
        If lsv_Archivos.CheckedItems.Count = 0 Then
            MsgBox("Seleccione por lo menos un Archivo.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        If Not ValidaArchivo() Then
            MsgBox("Ocurrió un error al validar archivo", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        pgr_Barra.Maximum = lsv_Archivos.Items.Count
        pgr_Barra.Value = 0


        For Each item As ListViewItem In lsv_Archivos.CheckedItems
            Dim Deposito As New HostToHost
            AddHandler Deposito.EventHostToHost, AddressOf HostToHost_Finalizado
            item.Tag = Deposito
            Deposito = Nothing
        Next

        'Envía archivos de depósitos
        For Each item As ListViewItem In lsv_Archivos.CheckedItems
            CType(item.Tag, HostToHost).Enviar(NombreArchivo(item.Text), LeerArchivo(item.Text), NombreArchivo(ArchivoCheque(item.Text)), IIf(ExisteArchivo(ArchivoCheque(item.Text.Trim)), LeerArchivo(ArchivoCheque(item.Text)), ""))
            pgr_Barra.Value += 1
            item.Tag = Nothing
        Next
    End Sub

    Private Sub chk_Todos_CheckedChanged_1(sender As Object, e As EventArgs) Handles chk_Todos.CheckedChanged
        ActivarDesactivar()
    End Sub

#Region "API BANREGIO"
    Public Sub ActivarDesactivarBanregio()
        For Each item As ListViewItem In Lsv_Banregio.Items
            item.Checked = Chk_TodosBanregio.Checked
        Next
    End Sub

    Private Sub Chk_TodosBanregio_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_TodosBanregio.CheckedChanged
        'ActivarDesactivarBanregio()
    End Sub

    Private Sub Btn_EnviarArchivosBanregio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '8 es la posicion del Json en el listview
        Dim Json(Lsv_Banregio.Items.Count - 1) As String
        For cont As Integer = 0 To Json.Length - 1
            Json(cont) = Lsv_Banregio.Items(cont).SubItems(10).Text
        Next
        Dim s As New Class1
        Dim Peticion As String = JsonConvert.SerializeObject(s.General_Json(Json))



    End Sub

    Private Sub cmb_Sesion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Sesion.SelectedIndexChanged

    End Sub

    Private Sub cmb_Sesion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_Sesion.SelectedValueChanged
        fn_ReadFileList(Lsv_Banregio, cmb_Sesion.SelectedValue)
        'ActivarDesactivarBanregio()
    End Sub

    Private Sub Lsv_Banregio_DoubleClick(sender As Object, e As EventArgs) Handles Lsv_Banregio.DoubleClick
        Dim frm As New Frm_ArchivosBanregioDepositos
        frm.Json = Lsv_Banregio.SelectedItems(0).SubItems(10).Text
        frm.Titulo = Lsv_Banregio.SelectedItems(0).SubItems(3).Text + " / " + Lsv_Banregio.SelectedItems(0).SubItems(2).Text
        frm.ShowDialog()
    End Sub

    Private Sub Lsv_Banregio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lsv_Banregio.SelectedIndexChanged

    End Sub
#End Region

End Class