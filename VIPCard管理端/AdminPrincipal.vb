Imports System.Security.Principal
Imports LSW.Web

Public Class AdminPrincipal
    Implements IPrincipal

    Private identityValue As AdminIdentity

    Public Sub New(cardno As String)
        identityValue = New AdminIdentity(cardno)
    End Sub

    Public Sub New(username As String, password As String)
        identityValue = New AdminIdentity(username, password)
    End Sub

    Public ReadOnly Property Identity As IIdentity Implements IPrincipal.Identity
        Get
            Return identityValue
        End Get
    End Property

    Public Function IsInRole(role As String) As Boolean Implements IPrincipal.IsInRole
        Return role = identityValue.Role.ToString
    End Function
End Class

Public Class AdminIdentity
    Implements IIdentity
    Dim db As New VIPCardEntities

    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole
    Private adminValue As Admin

    Public Sub New(cardno As String)
        If IsValidCard(cardno) Then
            nameValue = Admin.用户名
            authenticatedValue = True
            roleValue = ApplicationServices.BuiltInRole.Administrator
        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If
    End Sub

    Public Sub New(username As String, password As String)
        If IsValidPass(username, password) Then
            nameValue = Admin.用户名
            authenticatedValue = True
            roleValue = ApplicationServices.BuiltInRole.Administrator
        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If
    End Sub

    Private Function IsValidCard(cardno As String) As Boolean
        adminValue = db.Admins.Where(Function(a) a.卡号 = cardno).FirstOrDefault
        Return adminValue IsNot Nothing
    End Function

    Private Function IsValidPass(username As String, password As String) As Boolean
        password = Utils.MD5(password)
        adminValue = db.Admins.Where(Function(a) a.用户名 = username AndAlso a.密码 = password).FirstOrDefault
        Return adminValue IsNot Nothing
    End Function

    Public ReadOnly Property AuthenticationType As String Implements IIdentity.AuthenticationType
        Get
            Return "Custom Authentication"
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property

    Public ReadOnly Property Role As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property

    Public ReadOnly Property Admin As Admin
        Get
            Return adminValue
        End Get
    End Property
End Class