Imports LSW.Web

Public Class UserInfoForm
    Public Property Action As ActionType
    Dim uid As Integer
    Dim user As User
    Dim db As New VIPCardEntities

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Action = ActionType.Add Then
            If String.IsNullOrEmpty(txt_card.Text.Trim) OrElse String.IsNullOrEmpty(txt_pass.Text.Trim) Then
                MsgBox("卡号或密码不能为空")
                Return
            End If
            Dim str = txt_card.Text
            If db.Users.Where(Function(u) u.卡号 = str).Count > 0 Then
                MsgBox("此卡已经激活")
                Return
            End If
            str = txt_user.Text
            If db.Users.Where(Function(u) u.用户名 = str).Count > 0 Then
                MsgBox("姓名已存在")
                Return
            End If
            Dim user As New User With {
                .用户名 = txt_user.Text,
                .密码 = Utils.MD5(txt_pass.Text),
                .卡号 = txt_card.Text,
                .手机 = txt_mobile.Text,
                .余额 = 0,
                .发卡方编号 = ComboBox1.SelectedValue,
                .性别 = cb_sex.SelectedItem.ToString
                }
            db.Users.AddObject(user)
            'db.SaveChanges()
        ElseIf Action = ActionType.Edit Then
            If String.IsNullOrEmpty(txt_card.Text.Trim) Then
                MsgBox("卡号不能为空")
                Return
            End If
            With user
                .用户名 = txt_user.Text
                .卡号 = txt_card.Text
                .密码 = IIf(String.IsNullOrEmpty(txt_pass.Text.Trim), .密码, Utils.MD5(txt_pass.Text))
                .手机 = txt_mobile.Text
                .发卡方编号 = ComboBox1.SelectedValue
                .性别 = cb_sex.SelectedItem.ToString
            End With
        End If
        db.SaveChanges()
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PinCardDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_card.Text = PinCardDialog.CardNo
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub UserInfoForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.F1 Then
            Button2.PerformClick()
        ElseIf e.KeyData = Keys.F2 AndAlso Action = ActionType.Edit Then
            Button4.PerformClick()
        End If
    End Sub

    Private Sub UserInfoForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindingSource.DataSource = db.CardIssues
        If Action = ActionType.Add Then
            Me.Text = "添加会员"
            Button4.Visible = False
            txt_card.Text = String.Empty
            txt_pass.Text = String.Empty
            txt_user.Text = String.Empty
            txt_mobile.Text = String.Empty
            txt_money.Text = 0
        ElseIf Action = ActionType.Edit Then
            Me.Text = "编辑会员"
            Button4.Visible = True
            db = New VIPCardEntities
            user = db.Users.Where(Function(a) a.编号 = uid).FirstOrDefault
            With user
                txt_card.Text = .卡号
                txt_pass.Text = String.Empty
                txt_user.Text = .用户名
                txt_mobile.Text = .手机
                txt_money.Text = .余额
                ComboBox1.SelectedValue = .发卡方编号
                cb_sex.SelectedItem = .性别
                txt_time.Text = .激活时间
            End With
        End If
    End Sub

    Public Overloads Function ShowDialog(uid As Integer) As DialogResult
        Me.uid = uid
        Action = ActionType.Edit
        Return Me.ShowDialog
    End Function

    Public Overloads Function ShowDialog(cardno As String) As DialogResult
        user = db.Users.Where(Function(u) u.卡号 = cardno).FirstOrDefault
        If user Is Nothing Then Return Windows.Forms.DialogResult.Abort
        Me.uid = user.编号
        Action = ActionType.Edit
        Return Me.ShowDialog
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RechargeDialog.ShowDialog(user.卡号) = Windows.Forms.DialogResult.OK Then
            txt_money.Text = RechargeDialog.NewMoney
        End If
    End Sub
End Class