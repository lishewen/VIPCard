Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server


Partial Public Class Triggers
    ' 为目标输入现有表或视图并取消对特性行的注释
    <Microsoft.SqlServer.Server.SqlTrigger(Name:="LSWTriggerEx", Target:="[User]", Event:="FOR INSERT,UPDATE")> _
    Public Shared Sub LSWTriggerEx()
        ' 用您的代码替换
        'SqlContext.Pipe.Send("Trigger FIRED")
        Using cnn As New SqlConnection("Context Connection=true")
            cnn.Open()
            Using sqlCmd As New SqlCommand
                sqlCmd.Connection = cnn
                Dim sqlp As SqlPipe = SqlContext.Pipe
                Dim trigContext As SqlTriggerContext = SqlContext.TriggerContext
                Select Case trigContext.TriggerAction
                    Case TriggerAction.Insert
                        sqlCmd.CommandText = "SELECT [卡号] FROM INSERTED"
                        Dim cardno = sqlCmd.ExecuteScalar.ToString
                        sqlCmd.CommandText = "SELECT count([卡号]) FROM [User] WHERE [卡号]='" & cardno & "'"
                        Dim count = CInt(sqlCmd.ExecuteScalar)
                        If count > 1 Then
                            sqlCmd.CommandText = "SELECT [编号] FROM INSERTED"
                            Dim id = CInt(sqlCmd.ExecuteScalar)
                            sqlCmd.CommandText = "DELETE FROM [User] WHERE [编号]=" & id
                            sqlCmd.ExecuteNonQuery()
                        End If
                        sqlp.Send("触发Insert")
                    Case TriggerAction.Update
                        sqlCmd.CommandText = "SELECT [用户名] FROM DELETED"
                        Dim name = sqlCmd.ExecuteScalar.ToString
                        If String.IsNullOrEmpty(name) Then
                            sqlCmd.CommandText = "SELECT [用户名] FROM INSERTED"
                            Dim newname = sqlCmd.ExecuteScalar.ToString
                            If Not String.IsNullOrEmpty(newname) Then
                                sqlCmd.CommandText = "SELECT [编号] FROM INSERTED"
                                Dim id = CInt(sqlCmd.ExecuteScalar)
                                sqlCmd.CommandText = "UPDATE [User] Set [激活时间]=getdate() Where [编号]=" & id
                                sqlCmd.ExecuteNonQuery()
                            End If
                        End If
                        sqlp.Send("触发Update")
                End Select
            End Using
            cnn.Close()
        End Using
    End Sub
End Class
