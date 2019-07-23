Imports LSW.Extension
Imports LSW.Windows.Controls.Forms

Public Class AdminForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSource.DataSource = db.Admins
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If AddAdminForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            BindingSource.DataSource = Nothing
            BindingSource.DataSource = db.Admins
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim dv = DirectCast(sender, DataGridView)
        If EditAdminForm.ShowDialog(dv("编号DataGridViewTextBoxColumn", e.RowIndex).Value) = Windows.Forms.DialogResult.OK Then
            BindingSource.DataSource = Nothing
            db = New VIPCardEntities
            BindingSource.DataSource = db.Admins
        End If
    End Sub
End Class