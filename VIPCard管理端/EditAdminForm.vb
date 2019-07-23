Imports LSW.Web

Public Class EditAdminForm
    Dim uid As Integer
    Dim admin As Admin
    Dim db As New VIPCardEntities

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
        If String.IsNullOrEmpty(txt_user.Text.Trim) Then
            MsgBox("用户名不能为空")
            Return
        End If
        With admin
            .用户名 = txt_user.Text
            .卡号 = txt_card.Text
            .密码 = IIf(String.IsNullOrEmpty(txt_pass.Text.Trim), .密码, Utils.MD5(txt_pass.Text))
        End With
        db.SaveChanges()
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Public Overloads Function ShowDialog(uid As Integer) As DialogResult
        Me.uid = uid
        Return Me.ShowDialog
    End Function

    Private Sub AddAdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        db = New VIPCardEntities
        admin = db.Admins.Where(Function(a) a.编号 = uid).FirstOrDefault
        txt_card.Text = admin.卡号
        txt_pass.Text = String.Empty
        txt_user.Text = admin.用户名
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        db.Admins.DeleteObject(admin)
        db.SaveChanges()
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class