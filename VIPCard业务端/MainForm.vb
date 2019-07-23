Imports LSW.Windows.Controls.Forms

Public Class MainForm
    Inherits MDIParentFormBase

    Dim salesman As Salesman

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("是否退出系统？", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If LoginForm.ShowDialog <> Windows.Forms.DialogResult.OK Then
            End
        Else
            salesman = DirectCast(My.User.CurrentPrincipal.Identity, AdminIdentity).Admin
            Me.Text += " - [" & salesman.姓名 & "]"
        End If
    End Sub

    Private Sub 修改密码ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改密码ToolStripMenuItem.Click
        PasswordForm.ShowDialog()
    End Sub

    Private Sub 消费明细ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 消费明细ToolStripMenuItem.Click
        ShowChild(ReportForm)
    End Sub
End Class
