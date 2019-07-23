Imports LSW.Windows.Controls.Forms

Public Class TradeReportForm
    Inherits MDIChildFormBase

    Dim db As New VIPCardEntities

    Private Sub TradeReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSource.DataSource = db.V_OrderT
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class