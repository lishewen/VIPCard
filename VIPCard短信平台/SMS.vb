Imports System.Security.Cryptography
Imports System.Text

Module SMS
    Function Send(mobile As String, content As String) As String
        Dim webserverObject As New cn.entinfo.sdk1.WebService
        Dim md5 As New MD5CryptoServiceProvider
        Dim md5pwd As Byte() = (New ASCIIEncoding).GetBytes(My.Settings.用户名 + My.Settings.密码)
        Dim mdByte As Byte() = md5.ComputeHash(md5pwd)
        Dim mdString As String = System.BitConverter.ToString(mdByte)
        mdString = mdString.Replace("-", "")
        'MessageBox.Show(mdString)
        Dim a As String = webserverObject.mt(My.Settings.用户名, mdString, mobile, content & "[" & My.Settings.签名 & "]", "", "", "")
        If (a.StartsWith("-")) Then
            Return "发送失败 返回值为: " + a
        Else
            Return "发送成功 返回值为: " + a
        End If
    End Function
End Module
