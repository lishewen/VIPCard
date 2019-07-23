Imports LSW.Web
Imports LSW.Net
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility
Imports System.Threading
Imports VIPCardSharedLibrary
Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.Runtime.Remoting
Imports System.Net.Sockets

Public Class MainForm
    'Dim db As New VIPCardEntities
    Dim rObj As ShopActivatedObject
    Public Property Store As Store
    Dim user As User

    Sub AccessRemotingServerByCode()
        ' Create and register a channel (TCP channel in this example) that 
        ' is used to transport messages across the remoting boundary.

        ' Set the properties of the channel.
        Dim props As New Hashtable()
        props("typeFilterLevel") = TypeFilterLevel.Full

        ' Set the formatters of the messages for delivery.
        Dim clientProvider As New BinaryClientFormatterSinkProvider()
        Dim serverProvider As New BinaryServerFormatterSinkProvider()
        serverProvider.TypeFilterLevel = TypeFilterLevel.Full

        ' Create a TCP channel.
        Dim tcpChannel As New TcpChannel(props, clientProvider, serverProvider)

        ' Register the TCP channel.
        ChannelServices.RegisterChannel(tcpChannel, False)

        Try
            RemotingConfiguration.RegisterActivatedClientType(GetType(ShopActivatedObject), String.Format("tcp://{0}:{1}/ShopService", My.Settings.服务器IP, My.Settings.端口号))
            rObj = New ShopActivatedObject
        Catch ex As SocketException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Init()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox2.Enabled = False
        TextBox3.Clear()
        TextBox4.Clear()
        user = Nothing
        'db = New VIPCardEntities
        Button1.Focus()
    End Sub

    Sub LoadCard()
        Dim pass = Utils.MD5(TextBox2.Text)
        user = rObj.GetUser(TextBox1.Text, pass)
        If user Is Nothing Then
            MsgBox("卡号或密码有误")
            TextBox2.Clear()
            TextBox2.Focus()
        Else
            TextBox3.Text = user.余额
            TextBox4.Focus()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UpdateVersion()
        'My.Settings.Save()
        'MsgBox(NetCard.GetMacs()(0))
        Try
            AccessRemotingServerByCode()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("首次运行进入配置界面")
            SetupForm.ShowDialog()
            End
        End Try
        CheckVersion()
        If Not rObj.Login(NetCard.GetMac, My.Settings.客户端ID) Then
            MsgBox("当前电脑没有得到授权")
            End
        End If
        Timer1.Enabled = True
        Store = rObj.GetShoreByClientID(My.Settings.客户端ID)
        If Store Is Nothing Then
            MsgBox("该客户端没有权限！管理员刷卡后进入配置界面")
            If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                SetupForm.ShowDialog()
                End
            End If
        Else
            Me.Text = Store.店名 & " - 梧州金银阁投资管理有限公司 - 一卡通消费平台"
        End If
        Button1.Focus()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.LControlKey And e.KeyData = Keys.F6 Then
            SetupForm.ShowDialog()
        End If
        If e.KeyData = Keys.F1 Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = PinCardDialog.CardNo
            TextBox2.Enabled = True
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyData = Keys.Enter Then
            LoadCard()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If user Is Nothing Then
            MsgBox("卡号或密码有误")
            Button1.Focus()
            Return
        End If
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("请输入正确的金额")
            TextBox4.Focus()
            Return
        End If
        Dim money = CDec(TextBox4.Text)
        If user.余额 < money Then
            MsgBox("当前的卡号余额不足")
            TextBox4.Focus()
            Return
        End If
        rObj.AddOrder(user.编号, Store.编号, money)
        Dim nuser = rObj.GetUserByName(user.卡号)
        Dim 消费返还 = money - (user.余额 - nuser.余额)
        MsgBox("消费成功！" & vbCrLf & "本次消费：" & money & vbCrLf & "本卡尚有余额：" & user.余额 & vbCrLf & "消费返还：" & 消费返还)
        If MsgBox("是否打印小票？", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Dim printer As New VB6.Printer
            printer.Print("———————————")
            printer.Print("商盟一卡通消费平台小票")
            printer.Print("——（客户存根）——")
            printer.Print("———————————")
            printer.Print("商户名称：" & Store.店名)
            printer.Print("消费卡号：" & user.卡号)
            printer.Print("返还积分：" & 消费返还)
            printer.Print("交易类型：积分通道")
            printer.Print("交易金额：" & money)
            printer.Print("打印时间:" & Now)
            printer.Print("———————————")
            printer.EndDoc()

            Thread.Sleep(3000)

            printer.Print("———————————")
            printer.Print("商盟一卡通消费平台小票")
            printer.Print("——（商户存根）——")
            printer.Print("———————————")
            printer.Print("商户名称：" & Store.店名)
            printer.Print("消费卡号：" & user.卡号)
            printer.Print("返还积分：" & 消费返还)
            printer.Print("交易类型：积分通道")
            printer.Print("交易金额：" & money)
            printer.Print("打印时间:" & Now)
            printer.Print("———————————")
            printer.Print("客户签名：")
            printer.Print("———————————")
            printer.EndDoc()

            MsgBox("打印完毕！")
        End If
        Init()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str = InputBox("请输入需要查询的名字或手机号", Me.Text)
        user = rObj.GetUserByName(str)
        If user IsNot Nothing Then
            TextBox1.Text = user.卡号
            TextBox2.Enabled = True
            TextBox2.Focus()
        Else
            Button1.Focus()
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If Not String.IsNullOrEmpty(TextBox2.Text) Then
            LoadCard()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Init()
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyData = Keys.Enter Then
            Button3.PerformClick()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If user Is Nothing Then
            MsgBox("卡号或密码有误")
            Button1.Focus()
            Return
        End If
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("请输入正确的金额")
            TextBox4.Focus()
            Return
        End If
        Dim money = CDec(TextBox4.Text)
        rObj.AddCashOrder(user.编号, Store.编号, money)
        MsgBox("消费成功！" & vbCrLf & "本次消费：" & money & vbCrLf & "本卡尚有余额：" & user.余额) '& vbCrLf & "消费返还：" & order.消费返还)
        If MsgBox("是否打印小票？", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Dim printer As New VB6.Printer
            printer.Print("———————————")
            printer.Print("商盟一卡通消费平台小票")
            printer.Print("——（客户存根）——")
            printer.Print("———————————")
            printer.Print("商户名称：" & Store.店名)
            printer.Print("消费卡号：" & user.卡号)
            'printer.Print("返还积分：" & order.消费返还)
            printer.Print("交易类型：现金通道")
            printer.Print("交易金额：" & money)
            printer.Print("打印时间:" & Now)
            printer.Print("———————————")
            printer.EndDoc()

            Thread.Sleep(3000)

            printer.Print("———————————")
            printer.Print("商盟一卡通消费平台小票")
            printer.Print("——（商户存根）——")
            printer.Print("———————————")
            printer.Print("商户名称：" & Store.店名)
            printer.Print("消费卡号：" & user.卡号)
            'printer.Print("返还积分：" & order.消费返还)
            printer.Print("交易类型：现金通道")
            printer.Print("交易金额：" & money)
            printer.Print("打印时间:" & Now)
            printer.Print("———————————")
            printer.Print("客户签名：")
            printer.Print("———————————")
            printer.EndDoc()

            MsgBox("打印完毕！")
        End If
        Init()
    End Sub

    Sub CheckVersion()
        If My.Application.Info.Version.ToString <> rObj.GetClientVersion Then
            MsgBox("当前版本信息与服务器端不匹配，点击确定启动更新程序")
            My.Settings.新版本号 = rObj.GetClientVersion
            My.Settings.Save()
            My.Computer.FileSystem.CopyFile("config.ini", "Update\config.ini", True)
            Process.Start("Update\VIPCardUpdater.exe")
            End
        End If
    End Sub

    Sub UpdateVersion()
        If My.Computer.FileSystem.FileExists("VIPCardClient1.exe") Then
            My.Computer.FileSystem.CopyFile("VIPCardClient1.exe", "VIPCardClient.exe", True)
            My.Computer.FileSystem.DeleteFile("VIPCardClient1.exe")
        End If
    End Sub

    Sub CheckLogin()
        Dim result = rObj.CheckLogin(NetCard.GetMac, My.Settings.客户端ID)
        If Not result.bool Then
            MsgBox(result.msg)
            End
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        CheckVersion()
    End Sub
End Class
