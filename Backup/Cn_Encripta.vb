Imports Microsoft.VisualBasic
Imports System.Text

Public Class Cn_Encripta

    Public Shared Function fn_Encode(ByVal data As String) As String
        Try
            Dim encyrpt(0 To data.Length - 1) As Byte
            encyrpt = System.Text.Encoding.UTF8.GetBytes(data)
            Dim encodedata As String = Convert.ToBase64String(encyrpt)
            Return encodedata
        Catch ex As Exception
            Throw New Exception("Error al Encriptar." & ex.Message)
        End Try
    End Function

    Public Shared Function fn_Decode(ByVal data As String) As String
        Dim encoder As New UTF8Encoding()
        Dim decode As Decoder = encoder.GetDecoder()
        Dim bytes As Byte() = Convert.FromBase64String(data)
        Dim count As Integer = decode.GetCharCount(bytes, 0, bytes.Length)
        Dim decodechar(0 To count - 1) As Char
        decode.GetChars(bytes, 0, bytes.Length, decodechar, 0)
        Dim result As New String(decodechar)
        Return result

    End Function

End Class
