Imports LSW.Windows.Controls.Forms
Imports LSW.Extension

Public Class UserListForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities

    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindingSource.DataSource = db.V_User.CopyToDataTable
    End Sub

    Sub RefreshData()
        BindingSource.DataSource = Nothing
        db = New VIPCardEntities
        BindingSource.DataSource = db.V_User.CopyToDataTable
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If RechargeDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub UserListForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F2 Then
            ToolStripButton4.PerformClick()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        UserInfoForm.Action = ActionType.Add
        If UserInfoForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Dim dv = DirectCast(sender, DataGridView)
        UserInfoForm.Action = ActionType.Edit
        If UserInfoForm.ShowDialog(dv("编号DataGridViewTextBoxColumn", e.RowIndex).Value) = Windows.Forms.DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If MsgBox("是否删除当前行？", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            BindingSource.RemoveCurrent()
            db.SaveChanges()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim str = ToolStripTextBox1.Text
        BindingSource.DataSource = db.V_User.Where(Function(u) u.用户名.Contains(str) OrElse u.卡号.Contains(str) OrElse u.手机.Contains(str)).CopyToDataTable
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        If AddUserExForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        LSW.Print.PrintDG.Print_DataGrid(DataGridView1)
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        ProgressBar1.Visible = True
        DataGridView1.ExportToCsv(ProgressBar1)
        ProgressBar1.Visible = False
    End Sub
End Class