Imports System.Windows.Forms

Public Class PinCardDialog
    Public Property CardNo As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        CardNo = TextBox1.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PinCardDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        CardNo = String.Empty
        TextBox1.Text = String.Empty
        TextBox1.Focus()
    End Sub
End Class
