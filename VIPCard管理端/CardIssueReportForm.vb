Imports LSW.Windows.Controls.Forms

Public Class CardIssueReportForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities
    Dim mindate As New DateTimePicker
    Dim maxdate As New DateTimePicker

    Private Sub CardIssueReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip1.Items.Insert(1, New ToolStripControlHost(mindate))
        ToolStrip1.Items.Insert(3, New ToolStripControlHost(maxdate))
        BindingSource.DataSource = db.V_OrderC
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If mindate.Value > maxdate.Value Then
            MsgBox("日期选择有误")
            Return
        End If
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        BindingSource.DataSource = db.V_OrderC.Where(Function(v) v.时间 > min AndAlso v.时间 <= max)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If String.IsNullOrEmpty(ToolStripTextBox1.Text) Then
            BindingSource.DataSource = db.V_OrderC
            Me.ReportViewer1.RefreshReport()
            Return
        End If
        If mindate.Value > maxdate.Value Then
            MsgBox("日期选择有误")
            Return
        End If
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        Dim str = ToolStripTextBox1.Text
        BindingSource.DataSource = db.V_OrderC.Where(Function(v) v.时间 > min AndAlso v.时间 <= max).Where(Function(v) v.名称 = str)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class