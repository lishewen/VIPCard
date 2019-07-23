Public Class EventWrapper
    Inherits MarshalByRefObject

    Public Event LocalLoginError(sender As ShopActivatedObject, e As String)
    Public Sub EventLoginError(sender As ShopActivatedObject, e As String)
        RaiseEvent LocalLoginError(sender, e)
    End Sub

    Public Overrides Function InitializeLifetimeService() As Object
        Return Nothing
    End Function
End Class
