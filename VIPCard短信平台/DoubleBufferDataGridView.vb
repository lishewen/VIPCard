Public Class DoubleBufferDataGridView
    Inherits DataGridView

    Public Sub New()
        SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        UpdateStyles()
    End Sub
End Class
