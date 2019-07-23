Imports LSW.Web

Public Class PasswordForm
    Dim salesman As Salesman
    Dim db As New VIPCardEntities

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If salesman.密码 = Utils.MD5(txt_old.Text) Then
            If txt_new.Text = txt_c.Text Then
                salesman = db.Salesmen.Where(Function(s) s.编号 = salesman.编号).FirstOrDefault
                salesman.密码 = Utils.MD5(txt_new.Text)
                db.SaveChanges()
                MsgBox("修改成功！")
            Else
                MsgBox("两次输入的密码不一样")
                Exit Sub
            End If
        Else
            MsgBox("旧密码输入有误！")
            Exit Sub
        End If

        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub PasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        salesman = DirectCast(My.User.CurrentPrincipal.Identity, AdminIdentity).Admin
    End Sub
End Class