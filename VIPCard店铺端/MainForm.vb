Imports LSW.Web
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility
Imports System.Threading

Public Class MainForm
    Dim db As New VIPCardEntities
    Public Property Store As Store
    Dim user As User

    Sub Init()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        user = Nothing
        db = New VIPCardEntities
        Button1.Focus()
    End Sub

    Sub LoadCard()
        Dim pass = Utils.MD5(TextBox2.Text)
        user = db.Users.Where(Function(u) u.卡号 = TextBox1.Text AndAlso u.密码 = pass).FirstOrDefault
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
        Store = db.Stores.Where(Function(s) s.客户端ID = My.Settings.客户端ID).FirstOrDefault
        If Store Is Nothing Then
            MsgBox("该客户端没有权限！管理员刷卡后进入配置界面")
            If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                If db.Admins.Where(Function(a) a.卡号 = PinCardDialog.CardNo).Count > 0 Then
                    SetupForm.ShowDialog()
                Else
                    MsgBox("无法识别此卡")
                End If
            End If
            End
        Else
            Me.Text = Store.店名 & " - 梧州金银阁投资管理有限公司 - 一卡通消费平台"
        End If
        Button1.Focus()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.LControlKey And e.KeyData = Keys.F6 Then
            If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                If db.Admins.Where(Function(a) a.卡号 = PinCardDialog.CardNo).Count > 0 Then
                    SetupForm.ShowDialog()
                Else
                    MsgBox("无法识别此卡")
                End If
            End If
        End If
        If e.KeyData = Keys.F1 Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = PinCardDialog.CardNo
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
        Dim order As New Order With {
            .用户ID = user.编号,
            .店铺ID = Store.编号,
            .金额 = money,
            .时间 = Now,
            .成本 = money * Store.Trade.成本比重 / 100,
            .消费返还 = (money - .成本) * Store.Trade.消费方分成 / 100,
            .发卡方提成 = (money - .成本) * Store.Trade.发卡方分成 / 100,
            .我方提成 = money - .成本 - .发卡方提成 - .消费返还
            }
        db.Orders.AddObject(order)
        user.余额 -= money
        user.余额 += order.消费返还
        db.SaveChanges()
        MsgBox("消费成功！" & vbCrLf & "本次消费：" & money & vbCrLf & "本卡尚有余额：" & user.余额 & vbCrLf & "消费返还：" & order.消费返还)
        If MsgBox("是否打印小票？", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Dim printer As New VB6.Printer
            printer.Print("———————————")
            printer.Print("商盟一卡通消费平台小票")
            printer.Print("——（客户存根）——")
            printer.Print("———————————")
            printer.Print("商户名称：" & Store.店名)
            printer.Print("消费卡号：" & order.User.卡号)
            printer.Print("返还积分：" & order.消费返还)
            printer.Print("交易类型：积分通道")
            printer.Print("交易金额：" & money)
            printer.Print("打印时间:" & Now)
            printer.Print("———————————")
            printer.EndDoc()

            Thread.Sleep(1000)

            printer.Print("———————————")
            printer.Print("商盟一卡通消费平台小票")
            printer.Print("——（商户存根）——")
            printer.Print("———————————")
            printer.Print("商户名称：" & Store.店名)
            printer.Print("消费卡号：" & order.User.卡号)
            printer.Print("返还积分：" & order.消费返还)
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
        user = db.Users.Where(Function(u) u.用户名 = str OrElse u.手机 = str).FirstOrDefault
        If user IsNot Nothing Then
            TextBox1.Text = user.卡号
            TextBox2.Focus()
        Else
            Button1.Focus()
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If String.IsNullOrEmpty(TextBox2.Text) Then
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
        Dim order As New CashOrder With {
            .用户ID = user.编号,
            .店铺ID = Store.编号,
            .金额 = money,
            .时间 = Now,
            .成本 = 0,
            .消费返还 = 0,
            .发卡方提成 = 0,
            .我方提成 = 0
        }
        db.CashOrders.AddObject(order)
        'user.余额 -= money
        'user.余额 += order.消费返还
        db.SaveChanges()
        MsgBox("消费成功！" & vbCrLf & "本次消费：" & money & vbCrLf & "本卡尚有余额：" & user.余额) '& vbCrLf & "消费返还：" & order.消费返还)
        If MsgBox("是否打印小票？", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Dim printer As New VB6.Printer
            printer.Print("———————————")
            printer.Print("商盟一卡通消费平台小票")
            printer.Print("——（客户存根）——")
            printer.Print("———————————")
            printer.Print("商户名称：" & Store.店名)
            printer.Print("消费卡号：" & order.User.卡号)
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
            printer.Print("消费卡号：" & order.User.卡号)
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
End Class
