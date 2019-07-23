Imports LSW.Windows.Controls.Forms

Public Class TradeForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities

    Private Sub TradeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("是否保存已做的修改！", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            db.SaveChanges()
        End If
    End Sub

    Private Sub TradeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindingSource.DataSource = db.Trades
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        db.SaveChanges()
        MsgBox("保存成功！")
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        BindingSource.DataSource = Nothing
        db = New VIPCardEntities
        BindingSource.DataSource = db.Trades
    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        If e.ColumnIndex > 1 Then
            If IsNumeric(e.FormattedValue) Then
                If e.FormattedValue >= 0 And e.FormattedValue <= 100 Then
                    Return
                End If
            End If
            e.Cancel = True
        End If
    End Sub
End Class