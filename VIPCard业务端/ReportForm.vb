Imports LSW.Windows.Controls.Forms

Public Class ReportForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities
    Dim salesman As Salesman
    Dim mindate As New DateTimePicker
    Dim maxdate As New DateTimePicker

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip1.Items.Insert(1, New ToolStripControlHost(mindate))
        ToolStrip1.Items.Insert(3, New ToolStripControlHost(maxdate))
        salesman = DirectCast(My.User.CurrentPrincipal.Identity, AdminIdentity).Admin
        BindingSource1.DataSource = salesman.Stores
        ToolStripComboBox1.ComboBox.DataSource = BindingSource1
        ToolStripComboBox1.ComboBox.DisplayMember = "店名"
        ToolStripComboBox1.ComboBox.ValueMember = "店名"
        BindingSource.DataSource = db.V_OrderS.Where(Function(v) v.业务员ID = salesman.编号)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If mindate.Value > maxdate.Value Then
            MsgBox("日期选择有误")
            Return
        End If
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        BindingSource.DataSource = db.V_OrderS.Where(Function(v) v.业务员ID = salesman.编号).Where(Function(v) v.时间 > min AndAlso v.时间 <= max)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim str = ToolStripComboBox1.ComboBox.SelectedValue.ToString
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        BindingSource.DataSource = db.V_OrderS.Where(Function(v) v.业务员ID = salesman.编号).Where(Function(v) v.时间 > min AndAlso v.时间 <= max).Where(Function(v) v.店名 = str)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        BindingSource.DataSource = db.V_OrderS.Where(Function(v) v.业务员ID = salesman.编号)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class