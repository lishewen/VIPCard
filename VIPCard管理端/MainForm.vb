Imports LSW.Windows.Controls.Forms

Public Class MainForm
    Inherits MDIParentFormBase

    Private Sub 管理员ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理员ToolStripMenuItem.Click
        'AdminForm.MdiParent = Me
        'AdminForm.Show()
        ShowChild(AdminForm)
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("是否退出系统？", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
#If Not Debug Then
        If LoginForm.ShowDialog <> Windows.Forms.DialogResult.OK Then
            End
        End If
#End If
    End Sub

    Private Sub 会员列表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 会员列表ToolStripMenuItem.Click
        'UserListForm.MdiParent = Me
        'UserListForm.Show()
        ShowChild(UserListForm)
    End Sub

    Private Sub 添加会员ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加会员ToolStripMenuItem.Click
        'UserInfoForm.MdiParent = Me
        UserInfoForm.Action = ActionType.Add
        If UserInfoForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            MsgBox("添加会员成功！")
        End If
    End Sub

    Private Sub 会员卡充值ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 会员卡充值ToolStripMenuItem.Click
        If RechargeDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            MsgBox("充值成功！" & vbCrLf & "卡号：" & RechargeDialog.CardNo & vbCrLf & "余额：" & RechargeDialog.NewMoney)
        End If
    End Sub

    Private Sub 查找会员ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查找会员ToolStripMenuItem.Click
        If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            UserInfoForm.Action = ActionType.Edit
            If UserInfoForm.ShowDialog(PinCardDialog.CardNo) = Windows.Forms.DialogResult.Abort Then
                MsgBox("此会员卡没有被登记！")
            End If
        End If
    End Sub

    Private Sub 行业管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 行业管理ToolStripMenuItem.Click
        'TradeForm.MdiParent = Me
        'TradeForm.Show()
        ShowChild(TradeForm)
    End Sub

    Private Sub 店铺管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 店铺管理ToolStripMenuItem.Click
        'StoreForm.MdiParent = Me
        'StoreForm.Show()
        ShowChild(StoreForm)
    End Sub

    Private Sub 消费明细ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 消费明细ToolStripMenuItem.Click
        'OrderForm.MdiParent = Me
        ''OrderForm.WindowState = FormWindowState.Maximized
        'OrderForm.Show()
        ShowChild(OrderForm)
    End Sub

    Private Sub 行业报表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 行业报表ToolStripMenuItem.Click
        'TradeReportForm.MdiParent = Me
        'TradeReportForm.Show()
        ShowChild(TradeReportForm)
    End Sub

    Private Sub 店铺分成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 店铺分成ToolStripMenuItem.Click
        'StoreReportForm.MdiParent = Me
        'StoreReportForm.Show()
        ShowChild(StoreReportForm)
    End Sub

    Private Sub 发卡方管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发卡方管理ToolStripMenuItem.Click
        ShowChild(CardIssueForm)
    End Sub

    Private Sub 业务员管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 业务员管理ToolStripMenuItem.Click
        ShowChild(SalesmanForm)
    End Sub

    Private Sub 发卡分成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发卡分成ToolStripMenuItem.Click
        ShowChild(CardIssueReportForm)
    End Sub

    Private Sub 批量添加会员ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 批量添加会员ToolStripMenuItem.Click
        AddUserExForm.ShowDialog()
    End Sub

    Private Sub 短信平台用户清单ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 短信平台用户清单ToolStripMenuItem.Click
        Dim frm As New VIPCard短信平台.UserListForm
        ShowChild(frm)
    End Sub

    Private Sub 短信平台设置ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 短信平台设置ToolStripMenuItem.Click
        Dim di As New VIPCard短信平台.SettingDialog
        di.ShowDialog()
    End Sub
End Class
