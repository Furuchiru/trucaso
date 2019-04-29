Imports System.Text
Public Class Form1


    Public Shared Function randomString()
        Dim r As New Random
        Dim s As String = "BECO"
        Dim sb As New StringBuilder
        Dim idx As Integer = r.Next(0, 4)
        sb.Append(s.Substring(idx, 1))
        Return sb.ToString()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox(randomString())
    End Sub
End Class
