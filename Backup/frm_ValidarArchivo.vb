Imports System
Imports System.IO
Imports System.Collections
Imports System.Drawing.Color

Public Class frm_ValidarArchivo

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_ValidarArchivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call CargarColumnas()
        lsv_Archivos.Columns.Add("Nombre del Archivo")

    End Sub

    Private Sub btn_Destino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Destino.Click

        Dim Dialogo As New FolderBrowserDialog
        Dialogo.Description = "Seleccione la Carpeta."
        Dialogo.ShowNewFolderButton = False

        If Dialogo.ShowDialog() = DialogResult.OK Then
            lsv_Archivos.Items.Clear()
            lsv_Depositos.Items.Clear()

            Dim di As New IO.DirectoryInfo(Dialogo.SelectedPath)
            Dim aryFi As IO.FileInfo() = di.GetFiles("D*.txt")
            Dim fi As IO.FileInfo

            For Each fi In aryFi
                lsv_Archivos.Items.Add(fi.FullName)
            Next
            If lsv_Archivos.Items.Count = 0 Then
                MsgBox("No se encotnraron archivos en la carpeta seleccionada: " & Dialogo.SelectedPath)
            End If
        End If

    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Depositos.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Archivos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Archivos.SelectedIndexChanged
        SegundosDesconexion = 0

        lbl_ImporteGeneral.Text = "$0.0"
        lbl_Fichas.Text = "$0.0"
        lbl_TotDesglose.Text = "$0.0"
        lbl_DifDetalle.Text = "$0.0"
        lsv_Depositos.Items.Clear()
        gbx_Depositos.Text = "Depositos: 0"
        If lsv_Archivos.SelectedItems.Count = 0 Then Exit Sub
        lsv_Depositos.Clear()
        Call CargarColumnas()
        Dim Dialogo As New OpenFileDialog
        Dim Linea As String = ""
        Dim Ruta As String
        Dim Valor1() As String
        Dim Total As Decimal = 0
        Dim Conta As Integer
        Dim Tot_Fichas As Decimal = 0
        Dim Tot_Gral As Decimal = 0
        Dim Total_Desglose As Decimal = 0

        Ruta = lsv_Archivos.SelectedItems(0).Text

        If Not File.Exists(Ruta) Then
            MsgBox("El Archivo fue Eliminado o Movido de Carpeta.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Archivos.Items.Remove(lsv_Archivos.SelectedItems(0))
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Archivo As New StreamReader(Ruta)
            Do
                Linea = Archivo.ReadLine()
                If Linea Is Nothing Then Exit Do

                Valor1 = Split(Linea, ",")

                If Valor1(0) = "D" Then '
                    lbl_ImporteGeneral.Text = FormatCurrency(Valor1(4))
                    Tot_Gral = Valor1(4)
                    Continue Do
                End If
                If Valor1(0) = "C" Then
                    lsv_Depositos.Clear()
                    MsgBox("El Archivo de Texto no es Valido.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Archivo.Close()
                    lsv_Archivos.Items.Remove(lsv_Archivos.SelectedItems(0))
                    Call CargarColumnas()
                    Me.Cursor = Cursors.Default
                    Exit Try
                End If
                lsv_Depositos.Items.Add(Valor1(0))
                For ILocal As Integer = 1 To Valor1.Length - 1
                    If Conta <= Valor1.Length - 11 Then
                        If ILocal >= 11 And ILocal <= Valor1.Length - 1 Then
                            lsv_Depositos.Columns.Add(" ")
                            Conta += 1
                        End If
                    End If
                    If ILocal >= 5 And ILocal <= 9 Then
                        lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).SubItems.Add(FormatCurrency(Valor1(ILocal)))
                    Else
                        lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).SubItems.Add(Valor1(ILocal))
                    End If
                Next
                For ILocal As Integer = 13 To Valor1.Length - 1
                    Total += lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).SubItems(ILocal).Text
                    ILocal += 2
                Next
                Total_Desglose += Total
                If Total > 0 Then
                    If Not lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).SubItems(5).Text = Total Then
                        lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).ForeColor = Color.Yellow
                        lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).BackColor = Color.Red
                        lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).Font = New Font(lsv_Depositos.Items(lsv_Depositos.Items.Count - 1).Font, FontStyle.Bold)
                    End If
                End If
                Total = 0
                For ILocal As Integer = 11 To Valor1.Length - 1
                    lsv_Depositos.Columns(ILocal).TextAlign = HorizontalAlignment.Right
                Next

            Loop Until Linea Is Nothing
            Archivo.Close()

            lsv_Depositos.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv_Depositos.Columns(9).TextAlign = HorizontalAlignment.Right

            For Ilocal As Integer = 0 To lsv_Depositos.Items.Count - 1
                Tot_Fichas += lsv_Depositos.Items(Ilocal).SubItems(5).Text
            Next
            lbl_Fichas.Text = FormatCurrency(Tot_Fichas)
            lbl_TotDesglose.Text = FormatCurrency(Total_Desglose)
            lbl_DifDetalle.Text = FormatCurrency(Math.Abs(Tot_Fichas - Total_Desglose))
            gbx_Depositos.Text = "Depositos: " & lsv_Depositos.Items.Count
            Me.Cursor = Cursors.Default
        Catch
            lsv_Depositos.Clear()
            MsgBox("Ocurrio un Error al Intentar Leer el Archivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Call CargarColumnas()
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Sub CargarColumnas()

        lsv_Depositos.Columns.Add("Deposito", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("CuentaCheques", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("Comprobante", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("Refrencia", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("Divisa", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("ImporteEfectivo", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("ImporteCheques", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("ImporteChequesOtroBanco", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("FICHA", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("ImporteDiferencia", 100, HorizontalAlignment.Center)
        lsv_Depositos.Columns.Add("TipoDiferencia", 100, HorizontalAlignment.Center)

    End Sub

End Class
