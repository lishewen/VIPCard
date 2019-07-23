Imports LSW.Windows.Controls.Forms

Public Class MainForm
    Inherits MDIParentFormBase

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

    Private Sub 用户清单ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 用户清单ToolStripMenuItem.Click
        'UserListForm.Show()
        ShowChild(UserListForm)
    End Sub

    Private Sub 设置ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 设置ToolStripMenuItem.Click
        SettingDialog.ShowDialog()
    End Sub
End Class
