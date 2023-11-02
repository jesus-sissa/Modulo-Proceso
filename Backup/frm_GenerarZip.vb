Imports fs = Microsoft.VisualBasic.FileIO.FileSystem
Imports Z = Ionic.Utils.Zip
Imports System.IO
Imports System.Drawing.Imaging

Public Class frm_GenerarZip
    Dim FileName As String
    Dim FileNameOriginal As String

    Private Sub frm_GenerarZip_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_Banco.Actualizar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_SeleccionarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SeleccionarArchivo.Click
        SegundosDesconexion = 0

        Dim Dialogo As New OpenFileDialog With {.Filter = "Archivos de Texto|*.txt", .Multiselect = False}
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            tbx_Archivo.Text = Dialogo.FileName
            tbx_Nombre.Text = NombrarArchivo(Dialogo.FileName)
            BloquearFecha(Dialogo.FileName)
        End If

        FileName = Dialogo.FileName
        btn_Comprimir.Enabled = Validar()
    End Sub

    Private Sub BloquearFecha(ByVal Path As String)
        If tbx_Archivo.Text = "" Then Exit Sub
        Dim Arr As Array = Split(Path, "\")
        Dim Nombre As String = Arr(Arr.Length - 1)
        Dim Fecha As String = CInt(Microsoft.VisualBasic.Right(Split(Nombre, "_")(0), 6))
        Dim Año As Integer = "20" & Microsoft.VisualBasic.Left(Fecha, 2)
        Dim Mes As Integer = Mid(Fecha, 3, 2)
        Dim Dia As Integer = Microsoft.VisualBasic.Right(Fecha, 2)

        mc_Nombre.MinDate = DateSerial(Año, Mes, Dia)
    End Sub

    Private Function NombrarArchivo(ByVal Path As String) As String
        If tbx_Archivo.Text = "" Then Return ""
        Dim Arr As Array = Split(Path, "\")
        Dim Nombre As String = Arr(Arr.Length - 1)
        FileNameOriginal = Replace(Nombre, "C", "D")
        Dim Numero As Integer = CInt(Microsoft.VisualBasic.Left(Split(Nombre, "_")(1), Len(Split(Nombre, "_")(1)) - 4))

        Dim Numero_Plaza As String = ""
        If cmb_Banco.SelectedValue <> "0" Then
            Numero_Plaza = fn_GetNumeroPlaza(cmb_Banco.SelectedValue)
        End If
        Return Numero_Plaza & mc_Nombre.SelectionStart.ToString("yyyyMMdd") & "_" & Format(Numero, "00") & ".zip"
    End Function

    Private Sub btn_SeleccionarDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SeleccionarDestino.Click
        SegundosDesconexion = 0

        Dim Dialogo As New FolderBrowserDialog
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            tbx_Destino.Text = Dialogo.SelectedPath
        End If

        btn_Comprimir.Enabled = Validar()
    End Sub

    Private Sub mc_Nombre_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_Nombre.DateChanged
        tbx_Nombre.Text = NombrarArchivo(tbx_Archivo.Text)
    End Sub

    Public Function Validar() As Boolean
        SegundosDesconexion = 0

        If tbx_Archivo.Text = "" Then Return False

        If tbx_Nombre.Text = "" Then Return False

        If cmb_Banco.SelectedValue = "0" Then Return False

        If tbx_Destino.Text = "" Then Return False

        Return True
    End Function

    Private Sub cmb_Banco_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedValueChanged
        btn_Comprimir.Enabled = Validar()
        tbx_Nombre.Text = NombrarArchivo(FileName)
    End Sub

    Private Sub btn_Comprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Comprimir.Click
        SegundosDesconexion = 0

        Dim Archivo As String = Split(tbx_Archivo.Text, "\")(Split(tbx_Archivo.Text, "\").Length - 1)
        Dim CarpetaTemporal As String = Split(Split(tbx_Nombre.Text, ".")(0), "_")(0)
        Dim CarpetaImagenes As String = CarpetaTemporal & "\Imagenes"
        Dim ArchivoDenominaciones, ArchivoCheques, Path As String
        Dim ChequesArchivo, ChequesDB As Integer

        If Not fn_ValidarImagenes(cmb_Banco.SelectedValue, FileNameOriginal) Then
            Exit Sub
        End If

        'Aqui se obtienen los datos necesarios
        If Archivo.IndexOf("D") >= 0 Then
            ArchivoDenominaciones = Archivo
            ArchivoCheques = Replace(Archivo, "D", "C")
            Path = Microsoft.VisualBasic.Left(tbx_Archivo.Text, Len(tbx_Archivo.Text) - Len(Archivo))
        ElseIf Archivo.IndexOf("C") >= 0 Then
            ArchivoCheques = Archivo
            ArchivoDenominaciones = Replace(Archivo, "C", "D")
            Path = Microsoft.VisualBasic.Left(tbx_Archivo.Text, Len(tbx_Archivo.Text) - Len(Archivo))
        Else
            MsgBox("No se puede definir el tipo del archivo seleccionado", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        pb_Progreso.Value = 10

        'Aqui se valida que exista el archivo de denominaciones
        If Not fs.FileExists(Path & ArchivoDenominaciones) Then
            MsgBox("El archivo " & ArchivoDenominaciones & " no existe", MsgBoxStyle.Critical, frm_MENU.Text)
            pb_Progreso.Value = 0
            Exit Sub
        End If
        pb_Progreso.Value = 20

        'Aqui se valida que exista el archivo de cheques
        If Not fs.FileExists(Path & ArchivoCheques) Then
            MsgBox("El archivo " & ArchivoCheques & " no existe", MsgBoxStyle.Critical, frm_MENU.Text)
            pb_Progreso.Value = 0
            Exit Sub
        End If
        pb_Progreso.Value = 30

        'Aqui se crea la carpeta temporal
        fs.CreateDirectory(CarpetaTemporal)
        pb_Progreso.Value = 40

        'Aqui se crea la carpeta de las imagenes
        fs.CreateDirectory(CarpetaImagenes)
        pb_Progreso.Value = 50

        'Aqui se agrega el archivo de denominaciones
        fs.CopyFile(Path & ArchivoDenominaciones, CarpetaTemporal & "\" & ArchivoDenominaciones, True)
        fs.CopyFile(Path & ArchivoCheques, CarpetaTemporal & "\" & ArchivoCheques, True)
        pb_Progreso.Value = 60

        'Aqui se abre el archivo de los cheques
        Dim rdr As New System.IO.StreamReader(Path & ArchivoCheques)
        Dim Contenido As Array = Split(rdr.ReadToEnd, Chr(13))
        rdr.Dispose()
        pb_Progreso.Value = 70

        'Aqui se guarda cada uno de los cheques en la carpeta temporal
        For i As Integer = 1 To Contenido.Length - 1
            If Split(Contenido(i), ",").Length > 1 Then
                Dim BandaMagnetica As String = Split(Contenido(i), ",")(4)

                Dim Clave_Banco As String = Mid(BandaMagnetica, 10, 3)
                Dim Cuenta As String = Mid(BandaMagnetica, 14, 11)
                Dim Numero As String = Mid(BandaMagnetica, 25, 7)

                If Clave_Banco = cmb_Banco.SelectedValue Then
                    Dim Id_Cheque As Long = fn_Buscar_IdCheque(Clave_Banco, Cuenta, Numero)

                    If fn_LeerCheque(Id_Cheque, CarpetaImagenes & "\" & BandaMagnetica) Then ChequesDB += 1

                    ChequesArchivo += 1
                End If
            End If
            pb_Progreso.Value = ((i / (Contenido.Length - 1)) * 100) + 70
        Next

        'Aqui se comprime el contenido de la carpeta temporal
        If fs.FileExists(tbx_Destino.Text & "\" & tbx_Nombre.Text) Then
            If MsgBox("El archivo " & tbx_Destino.Text & "\" & tbx_Nombre.Text & " ya existe. ¿Desea Enviarlo a la papelera?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                fs.DeleteFile(tbx_Destino.Text & "\" & tbx_Nombre.Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Else
                pb_Progreso.Value = 0
                Exit Sub
            End If

        End If
        Dim Zip As New Z.ZipFile(tbx_Destino.Text & "\" & tbx_Nombre.Text)
        Zip.Comment = "SISSA. Sistema Integral de Administración y Control."
        Zip.AddDirectory(CarpetaTemporal)
        Zip.Save()
        pb_Progreso.Value = 180

        'Aqui se eliminan los archivos temporales
        System.IO.Directory.Delete(CarpetaTemporal, True)
        pb_Progreso.Value = 200

        'Aqui se informa de la finalizacion del proceso
        If ChequesDB = ChequesArchivo Then
            MsgBox("Todos los Cheques se han exportado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("En la base de datos solo se han encontrado " & ChequesDB & " de los " & ChequesArchivo & "Cheques del banco. ", MsgBoxStyle.Exclamation, frm_MENU.Text)
        End If
        pb_Progreso.Value = 0

    End Sub

    Private Function fn_ValidarImagenes(ByVal ClaveBanco As String, ByVal NombreArchivo As String) As Boolean
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasCheques_ValidarImagenes", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, NombreArchivo)
        Cn_Datos.Crea_Parametro(cmd, "@ClaveBanco", SqlDbType.VarChar, ClaveBanco)

        Try
            Dim tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
            If tbl.Rows.Count > 0 Then
                If tbl.Rows(0)("Cheques_Capturados") <> tbl.Rows(0)("Cheques_Scaneados") Then
                    If MsgBox("Solo se encontraron " & tbl.Rows(0)("Cheques_Scaneados") & " Imagenes de los " & tbl.Rows(0)("Cheques_Capturados") & " Cheques contenidos en el Archivo seleccionado. ¿Desea Continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return True
                End If
            Else
                If MsgBox("No se pudo validar la cantidad de Cheques scaneados contra la cantidad de Cheques original. ¿Desea Continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            If MsgBox("No se pudo validar la cantidad de Cheques scaneados contra la cantidad de Cheques original. ¿Desea Continuar?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                Return True
            Else
                Return False
            End If
        End Try
    End Function

    Private Function fn_GetNumeroPlaza(ByVal ClaveBanco As String) As String
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_CajasBancarias_GetPlaza", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@ClaveBanco", SqlDbType.VarChar, ClaveBanco)

        Try
            Return Cn_Datos.EjecutarScalar(cmd)
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return ""
        End Try
    End Function

    Private Function fn_LeerCheque(ByVal Id_Cheque As Long, ByVal Archivo As String) As Boolean
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasChequesI_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_Cheque", SqlDbType.BigInt, Id_Cheque)

        'Leer de SQL
        Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

        If dt.Rows.Count > 0 Then
            'convertir los bytes a Imagen
            Dim ms1 As MemoryStream = New MemoryStream(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
            ms1.Write(dt.Rows(0)("Front1"), 0, dt.Rows(0)("Front1").Length)
            Image.FromStream(ms1, True).Save(Archivo & ".tif", ImageFormat.Tiff)

            Return True
        Else
            Return False
        End If
    End Function

    Public Function fn_Buscar_IdCheque(ByVal Clave_Banco As String, ByVal Cuenta As String, ByVal Numero As String) As Long
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_FichasCheques_GetId", CommandType.StoredProcedure, Cn_Datos.Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Clave_Banco", SqlDbType.VarChar, Clave_Banco)
        Cn_Datos.Crea_Parametro(cmd, "@Cuenta", SqlDbType.VarChar, Cuenta)
        Cn_Datos.Crea_Parametro(cmd, "@Numero", SqlDbType.VarChar, Numero)

        Try
            Dim tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)
            If tbl.Rows.Count > 0 Then
                If tbl.Rows(0).Item("Imagen") = 0 Then
                    Return 0
                Else
                    Return tbl.Rows(0)("Id_Cheque")
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Private Sub cmb_Banco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Banco.SelectedIndexChanged

    End Sub

    Private Sub frm_GenerarZip_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class