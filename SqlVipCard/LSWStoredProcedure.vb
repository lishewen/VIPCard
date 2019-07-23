Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Partial Public Class StoredProcedures
    <Microsoft.SqlServer.Server.SqlProcedure()> _
    Public Shared Sub LSWAddUserEx(startno As Integer, endno As Integer, fid As Integer)
        ' 在此处添加您的代码
        If startno > endno Then Exit Sub
        Using cnn As New SqlConnection("Context Connection=true")
            cnn.Open()
            Using sqlCmd As New SqlCommand
                sqlCmd.Connection = cnn
                For i As Integer = startno To endno
                    sqlCmd.CommandText = "INSERT INTO [User]([卡号],[发卡方编号]) VALUES('" & i & "'," & fid & ")"
                    sqlCmd.ExecuteNonQuery()
                Next
            End Using
            cnn.Close()
        End Using
    End Sub
End Class
