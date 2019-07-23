Public Class LoginForm

    ' TODO: 插入代码，以使用提供的用户名和密码执行自定义的身份验证
    ' (请参见 http://go.microsoft.com/fwlink/?LinkId=35339)。 
    ' 随后自定义主体可附加到当前线程的主体，如下所示: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' 其中 CustomPrincipal 是用于执行身份验证的 IPrincipal 实现。 
    ' 随后，My.User 将返回 CustomPrincipal 对象中封装的标识信息
    ' 如用户名、显示名等

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim adminPrincipal As New AdminPrincipal(UsernameTextBox.Text, PasswordTextBox.Text)
        If Not adminPrincipal.Identity.IsAuthenticated Then
            MsgBox("登录错误")
        Else
            My.User.CurrentPrincipal = adminPrincipal
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Me.Close()
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim cardno = PinCardDialog.CardNo
            Dim adminPrincipal As New AdminPrincipal(cardno)
            If Not adminPrincipal.Identity.IsAuthenticated Then
                MsgBox("登录错误")
            Else
                My.User.CurrentPrincipal = adminPrincipal
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.F1 Then
            Button1.PerformClick()
        End If
    End Sub
End Class
