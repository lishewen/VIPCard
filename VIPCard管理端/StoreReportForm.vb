Imports LSW.Windows.Controls.Forms

Public Class StoreReportForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities
    Dim mindate As New DateTimePicker
    Dim maxdate As New DateTimePicker

    Private Sub StoreReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip1.Items.Insert(1, New ToolStripControlHost(mindate))
        ToolStrip1.Items.Insert(3, New ToolStripControlHost(maxdate))
        ToolStripComboBox1.SelectedIndex = 0
        BindingSource.DataSource = db.V_OrderT
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If mindate.Value > maxdate.Value Then
            MsgBox("日期选择有误")
            Return
        End If
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        BindingSource.DataSource = db.V_OrderT.Where(Function(v) v.时间 > min AndAlso v.时间 <= max)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If mindate.Value > maxdate.Value Then
            MsgBox("日期选择有误")
            Return
        End If
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        If ToolStripComboBox1.SelectedItem.ToString = "全部" Then
            BindingSource.DataSource = db.V_OrderT.Where(Function(v) v.时间 > min AndAlso v.时间 <= max)
        Else
            Dim str = ToolStripComboBox1.SelectedItem.ToString
            BindingSource.DataSource = db.V_OrderT.Where(Function(v) v.时间 > min AndAlso v.时间 <= max).Where(Function(v) v.消费类型 = str)
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class