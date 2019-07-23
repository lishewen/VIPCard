Public Class AddUserExForm
    Dim db As New VIPCardEntities

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub Init()
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox1.Focus()
    End Sub

    Private Sub AddUserExForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Init()
        BindingSource.DataSource = db.CardIssues
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) AndAlso IsNumeric(TextBox2.Text) Then
            Dim startno = CInt(TextBox1.Text)
            Dim endno = CInt(TextBox2.Text)
            Dim fid = CInt(ComboBox1.SelectedValue)
            db.LSWAddUserEx(startno, endno, fid)
            DialogResult = Windows.Forms.DialogResult.OK
            Init()
            Me.Close()
        Else
            MsgBox("请输入有效的数字")
            Return
        End If
    End Sub
End Class