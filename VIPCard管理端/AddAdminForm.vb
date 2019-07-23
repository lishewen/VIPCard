Imports LSW.Web

Public Class AddAdminForm
    Private Sub AddAdminForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F1 Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_card.Text = PinCardDialog.CardNo
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txt_user.Text.Trim) OrElse String.IsNullOrEmpty(txt_pass.Text.Trim) Then
            MsgBox("用户名或密码不能为空")
            Return
        End If
        Using db = New VIPCardEntities
            Dim admin As New Admin With {
                .用户名 = txt_user.Text,
                .密码 = Utils.MD5(txt_pass.Text),
                .卡号 = txt_card.Text
                }
            db.Admins.AddObject(admin)
            db.SaveChanges()
        End Using
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AddAdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_card.Text = String.Empty
        txt_pass.Text = String.Empty
        txt_user.Text = String.Empty
    End Sub
End Class