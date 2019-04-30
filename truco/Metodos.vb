Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient


'
' MARCO INTENTA CONECTARTE 
' A LA BDD DE MYSQL DE ABAJO
'
'
Public Class Metodos
    Public Shared conexion As New Odbc.OdbcConnection
    Public Shared comando As New Odbc.OdbcCommand
    Public Shared dataAdapter As New Odbc.OdbcDataAdapter
    Public Shared dataReader As Odbc.OdbcDataReader
    Public Shared dataSet As New Data.DataSet


    Public Shared Function connect()
        Try
            Dim connStr As String = "server=server=remotemysql.com;user=NcLoWnwZLU;database=NcLoWnwZLU;port=3306;password=Id7oeIHexF;" 'ESTA
            Dim conn As New MySqlConnection(connStr)

            If conexion.State = ConnectionState.Open Then
                disconnect()
            End If
            conexion.ConnectionTimeout = 10
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Return True
        Catch BDex As Exception
            MsgBox("ERROR AL CONECTAR")
            Return False
        End Try
    End Function

    Public Shared Sub disconnect()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("ERROR AL DESCONECTAR")
        End Try
    End Sub

    Public Shared Sub DA(tabla As DataGridView)
        If connect() Then
            Try
                comando.ExecuteNonQuery()
                dataAdapter.SelectCommand = comando
                dataAdapter.Fill(dataSet, "truco")
                tabla.DataSource = dataSet.Tables("truco")
                tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                disconnect()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Shared Function randomLetter()
        Dim r As New Random
        Dim s As String = "BECO"
        Dim sb As New StringBuilder
        Dim idx As Integer = r.Next(1, 4)
        sb.Append(s.Substring(idx, 1))
        Return sb.ToString()
    End Function
    Public Shared Function randomNumber()
        Dim r As New Random
        Dim s As String = "1234567890"
        Dim sb As New StringBuilder
        Dim idx As Integer = r.Next(1, 10)
        sb.Append(s.Substring(idx, 1))
        Return sb.ToString()
    End Function
End Class
