Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class frm_ConsultaRemision
    Public Remision As String
    Public ms As MemoryStream
    Private Sub frm_ConsultaRemision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'PictureBox1.Image.(ms, System.Drawing.Imaging.ImageFormat.Jpeg) '= System.Drawing.Image.FromStream(ms)
        'PictureBox1.Image = System.Drawing.Image.FromStream(ms, True)
        'Dim ms As MemoryStream = New MemoryStream()
        Dim file As FileStream = New FileStream("Remision.pdf", FileMode.Create, FileAccess.ReadWrite)
        ms.WriteTo(file)
        file.Close()
        ms.Close()
        pdf.src = file.Name
        'MessageBox.Show(file.Name.ToString)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    '    WebBrowser1.Document.GetElementById("cunica").SetAttribute("value", "SISSA")
    '    WebBrowser1.Document.GetElementById("usuario").SetAttribute("value", "SISSA")
    '    WebBrowser1.Document.GetElementById("password").SetAttribute("value", "12345")
    '    WebBrowser1.Document.GetElementById("btn_Entrar").InvokeMember("click")

    '    'WebBrowser1.Navigate("http://localhost:56611/Traslado/ImprimirR.aspx")
    '    'WebBrowser1.Document.GetElementById("btn_Buscar").InnerText = Remision
    '    'WebBrowser1.Document.GetElementById("btn_Buscar").InvokeMember("click")

    'End Sub

    'Private Sub RegresarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegresarToolStripMenuItem.Click
    '    WebBrowser1.Navigate("http://www.sissaseguridad.com/AccesoPortal/Remision/Consultar_Remision.aspx")
    '    'WebBrowser1.GoBack()
    'End Sub
End Class