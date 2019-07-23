Imports LSW.Windows.Controls.Forms

Public Class StoreForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities

    Private Sub StoreForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("是否保存已做的修改！", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            db.SaveChanges()
        End If
    End Sub

    Private Sub StoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSource2.DataSource = db.Salesmen.ToList
        BindingSource1.DataSource = db.Trades.ToList
        BindingSource.DataSource = db.Stores
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        db.SaveChanges()
        MsgBox("保存成功！")
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        BindingSource.DataSource = Nothing
        db = New VIPCardEntities
        BindingSource.DataSource = db.Stores
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim gid = Guid.NewGuid.ToString
        My.Computer.Clipboard.SetText(gid)
        MsgBox("生成新的Guid： " & gid & " 已经复制到剪切板")
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        'MsgBox(e.Exception.Message)
    End Sub
End Class