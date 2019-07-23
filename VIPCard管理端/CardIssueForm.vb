Imports LSW.Windows.Controls.Forms

Public Class CardIssueForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities

    Private Sub CardIssueForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("是否保存已做的修改！", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            db.SaveChanges()
        End If
    End Sub

    Private Sub CardIssueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSource.DataSource = db.CardIssues
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        DataGridView1.EndEdit()
        BindingSource.EndEdit()
        db.SaveChanges()
        MsgBox("保存成功！")
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        BindingSource.DataSource = Nothing
        db = New VIPCardEntities
        BindingSource.DataSource = db.CardIssues
    End Sub
End Class