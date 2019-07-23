Imports LSW.Windows.Controls.Forms
Imports LSW.Windows.Controls.DgvFilterPopup
Imports LSW.Extension
Imports LSW.Windows.Controls.DGVPaste

Public Class UserListForm
    Inherits MDIChildFormBase

    Dim db As New SMSVIPCardEntities
    Dim mindate As New DateTimePicker
    Dim maxdate As New DateTimePicker
    'Dim WithEvents fm As New DgvFilterManager
    Dim sid As Integer = 0

    Sub Init()
        Dim ls = db.Stores.ToList
        ls.Add(New Store With {.编号 = 0, .店名 = "(全部)"})
        ToolStripComboBox1.ComboBox.DataSource = ls.OrderBy(Function(s) s.编号).ToList
        ToolStripComboBox1.ComboBox.DisplayMember = "店名"
        ToolStripComboBox1.ComboBox.ValueMember = "编号"
        'ToolStrip1.Items.Insert(1, New ToolStripControlHost(mindate))
        'ToolStrip1.Items.Insert(3, New ToolStripControlHost(maxdate))
        ToolStripComboBox1.SelectedIndex = 0
        'fm.DataGridView = DataGridView1
        DgvHelper1.oDGV = DataGridView1
    End Sub

    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Init()
        BindingSource.DataSource = db.SP_VUser(sid).CopyToDataTable
    End Sub

    Sub RefreshData()
        BindingSource.DataSource = Nothing
        db = New SMSVIPCardEntities
        BindingSource.DataSource = db.SP_VUser(sid).CopyToDataTable
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim str = ToolStripTextBox1.Text
        BindingSource.DataSource = db.SP_VUser(sid).Where(Function(u) u.用户名.Contains(str) OrElse u.卡号.Contains(str) OrElse u.手机.Contains(str)).CopyToDataTable
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs)
        LSW.Print.PrintDG.Print_DataGrid(DataGridView1)
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        DataGridView1.ExportToCsv()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        'MsgBox("接口不被支持")
        Dim ls As New List(Of String)
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            ls.Add(row.Cells("手机DataGridViewTextBoxColumn").Value)
        Next
        If ls.Count < 1 Then MsgBox("请选择要发送到的用户") : Return
        Dim str = InputBox("请输入短信内容：")
        If String.IsNullOrWhiteSpace(str) Then Return
        Dim mo = String.Join(",", ls.ToArray)
        If MsgBox("是否将短信内容发送到下列手机：" & vbCrLf & mo, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox(SMS.Send(mo, str))
        End If
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        sid = CInt(ToolStripComboBox1.SelectedItem.编号)
        RefreshData()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        'BindingSource.Filter = ""
        'fm.ActivateAllFilters(False)
        DgvHelper1.ResetFilter()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        If mindate.Value > maxdate.Value Then
            MsgBox("日期选择有误")
            Return
        End If
        Dim min = mindate.Value.Date '.AddDays(-1)
        Dim max = maxdate.Value.Date.AddDays(1)
        If BindingSource.Filter = "" Then
            BindingSource.Filter = String.Format("[激活时间] >= #{0}# AND [激活时间] <= #{1}#", min.ToString, max.ToString)
        Else
            BindingSource.Filter &= String.Format("AND [激活时间] >= #{0}# AND [激活时间] <= #{1}#", min.ToString, max.ToString)
        End If
    End Sub

    Private Sub fm_ColumnFilterAdding(sender As Object, e As LSW.Windows.Controls.DgvFilterPopup.ColumnFilterEventArgs) ' Handles fm.ColumnFilterAdding
        'Dim dfm = DirectCast(sender, DgvFilterManager)
        If e.Column.Name = "DataGridViewTextBoxColumn5" Then e.ColumnFilter = New DgvDateRangeColumnFilter
    End Sub
End Class