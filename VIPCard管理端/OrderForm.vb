Imports LSW.Windows.Controls.Forms

Public Class OrderForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities
    Dim mindate As New DateTimePicker
    Dim maxdate As New DateTimePicker

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        BindingSource.DataSource = Nothing
        db = New VIPCardEntities
        BindingSource.DataSource = db.V_Order
    End Sub

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ToolStrip1.Items.Insert(1, New ToolStripControlHost(mindate))
        ToolStrip1.Items.Insert(3, New ToolStripControlHost(maxdate))
        BindingSource.DataSource = db.V_Order
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim str = ToolStripTextBox1.Text
        BindingSource.DataSource = db.V_Order.Where(Function(v) v.店名.Contains(str) OrElse v.卡号.Contains(str) OrElse v.手机.Contains(str) OrElse v.用户名.Contains(str))
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If mindate.Value > maxdate.Value Then
            MsgBox("日期选择有误")
            Return
        End If
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        BindingSource.DataSource = db.V_Order.Where(Function(v) v.时间 > min AndAlso v.时间 <= max)
    End Sub
End Class