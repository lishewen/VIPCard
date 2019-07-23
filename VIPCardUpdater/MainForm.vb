Imports LSW.Extension

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Dim ui As New UpdateInfo
        'With ui
        '    .ProjectName = "VIPCard"
        '    .Version = "1.0.0.1"
        '    .FileList = New List(Of FileInfo)
        '    .FileList.Add(New FileInfo With {.SourceFileName = "1.zip", .NewFileName = "1.dll"})
        '    .FileList.Add(New FileInfo With {.SourceFileName = "2.zip", .NewFileName = "2.exe"})
        'End With
        'My.Computer.FileSystem.WriteAllText(ui.Version & ".xml", ui.XmlSerialize, False)
        'My.Computer.Network.DownloadFile("", "")
        'My.Settings.新版本号 = "1.0.0.1"
        'My.Settings.Save()
        Dim ps = Process.GetProcessesByName("VIPCardClient")
        For Each p In ps
            p.Kill()
        Next
        TextBox1.AppendText("关闭主线程" & vbCrLf)
        Dim xmlfile = String.Format("{0}.xml", My.Settings.新版本号)
        TextBox1.AppendText("下载更新配置文件：" & xmlfile & " ... ")
        My.Computer.Network.DownloadFile(My.Settings.更新路径 & "/" & xmlfile, xmlfile, "", "", True, 3000, True)
        TextBox1.AppendText("成功" & vbCrLf)
        Dim xml = My.Computer.FileSystem.ReadAllText(xmlfile)
        Dim ui = xml.XmlDeserialize(Of UpdateInfo)()
        For Each f In ui.FileList
            TextBox1.AppendText("下载文件：" & f.NewFileName & " ... ")
            My.Computer.Network.DownloadFile(My.Settings.更新路径 & "/" & f.SourceFileName, f.SourceFileName, "", "", True, 3000, True)
            My.Computer.FileSystem.MoveFile(f.SourceFileName, f.NewFileName, True)
            TextBox1.AppendText("成功" & vbCrLf)
        Next
        TextBox1.AppendText("更新完成，请重启程序！" & vbCrLf)
    End Sub
End Class
