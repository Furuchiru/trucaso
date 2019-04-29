Imports System.Text

Public Class Metodos
    Public Shared Function randomLetter()
        Dim r As New Random
        Dim s As String = "BECO"
        Dim sb As New StringBuilder
        Dim idx As Integer = r.Next(0, 4)
        sb.Append(s.Substring(idx, 1))
        Return sb.ToString()
    End Function
    Public Shared Function randomNumber()
        Dim r As New Random
        Dim s As String = "1234567890"
        Dim sb As New StringBuilder
        Dim idx As Integer = r.Next(0, 10)
        sb.Append(s.Substring(idx, 1))
        Return sb.ToString()
    End Function
End Class
