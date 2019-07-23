Imports System.Windows.Forms

Public Class RechargeDialog
    Public Property CardNo As String
    Dim flag As Boolean = True
    Public Property NewMoney As Decimal

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text.Trim) Then
            MsgBox("卡号不能为空")
            TextBox1.Focus()
            Return
        End If
        Dim money As Decimal
        If IsNumeric(TextBox2.Text) Then
            money = CDec(TextBox2.Text)
        Else
            MsgBox("请输入正确的金额")
            TextBox1.Focus()
            Return
        End If
        Using db = New VIPCardEntities
            Dim user = db.Users.Where(Function(a) a.卡号 = TextBox1.Text).FirstOrDefault
            If user Is Nothing Then
                MsgBox("此卡没有被登记")
                TextBox1.Focus()
                Return
            Else
                user.余额 += money
                db.SaveChanges()
                NewMoney = user.余额
                CardNo = user.卡号
            End If
        End Using
        flag = True
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        flag = True
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RechargeDialog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.F1 Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub RechargeDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        CardNo = String.Empty
        TextBox2.Clear()
        If flag Then
            TextBox1.Clear()
            TextBox1.Focus()
        Else
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If String.IsNullOrEmpty(TextBox1.Text) Then Return
        If Not flag Then TextBox2.Focus() : Return
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyData = Keys.Enter Then
            OK_Button.PerformClick()
        End If
    End Sub

    Public Overloads Function ShowDialog(cardno As String) As DialogResult
        TextBox1.Text = cardno
        flag = False
        'TextBox2.Focus()
        Return Me.ShowDialog
    End Function
End Class
