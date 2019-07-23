Public Class SetupForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Save()
        Me.Close()
    End Sub
End Class