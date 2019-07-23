Imports LSW.Data
Imports LSW.Extension

Public Class ShopActivatedObject
    Inherits MarshalByRefObject

    Dim connstr As String = String.Format("data source={0};initial catalog={1};persist security info=True;user id={2};password={3};", My.Settings.数据库IP, My.Settings.数据库名, My.Settings.数据库用户名, My.Settings.数据库密码)
    Shared m_clientlist As New List(Of Client)
    Shared m_bclientlist As New List(Of Client)
    Dim m_shore As Store
    Dim m_client As Client
    Public Shared Event Logined(sender As ShopActivatedObject, e As Client)
    Public Event LoginError(sender As ShopActivatedObject, e As String)

    Public Shared ReadOnly Property ClientList As List(Of Client)
        Get
            Return m_clientlist
        End Get
    End Property

    Public Shared ReadOnly Property BadClientList As List(Of Client)
        Get
            Return m_bclientlist
        End Get
    End Property

    Public Function GetClientVersion() As String
        Return My.Settings.客户端版本号
    End Function

    Public Sub AddOrder(uid As Integer, sid As Integer, money As Decimal)
        Dim sql = String.Format("INSERT INTO [Order]([用户ID],[店铺ID],[金额]) VALUES({0},{1},{2})", uid, sid, money)
        SqlHelper.ExecuteNonquery(connstr, sql)
    End Sub

    Public Sub AddCashOrder(uid As Integer, sid As Integer, money As Decimal)
        Dim sql = String.Format("INSERT INTO [CashOrder]([用户ID],[店铺ID],[金额]) VALUES({0},{1},{2})", uid, sid, money)
        SqlHelper.ExecuteNonquery(connstr, sql)
    End Sub

    Public Sub RemoveClient(mac As String, msg As String)
        Dim mc = m_clientlist.Where(Function(m) m.MAC = mac).FirstOrDefault
        If mc Is Nothing Then Return
        m_clientlist.Remove(mc)
        mc.Msg = msg
        m_bclientlist.Add(mc)
    End Sub

    Public Sub RemoveBadClient(mac As String)
        Dim mc = m_bclientlist.Where(Function(m) m.MAC = mac).FirstOrDefault
        If mc Is Nothing Then Return
        m_bclientlist.Remove(mc)
    End Sub

    Public Function GetUser(cardno As String, password As String) As User
        If String.IsNullOrEmpty(cardno) OrElse String.IsNullOrEmpty(password) Then Return Nothing
        Dim sql = String.Format("SELECT [编号],[卡号],[余额] FROM [User] WHERE [卡号]='{0}' AND [密码]='{1}'", cardno.Replace("'", ""), password.Replace("'", ""))
        Dim dt = SqlHelper.ExecuteDataTable(connstr, sql)
        If dt.Rows.Count < 1 Then Return Nothing
        Return dt(0).ToEntity(Of User)()
    End Function

    Public Function GetUserByName(name As String) As User
        If String.IsNullOrEmpty(name) Then Return Nothing
        Dim sql = String.Format("SELECT [编号],[卡号],[余额] FROM [User] WHERE [用户名]='{0}' OR [手机]='{0}' OR [卡号]='{0}'", name.Replace("'", ""))
        Dim dt = SqlHelper.ExecuteDataTable(connstr, sql)
        If dt.Rows.Count < 1 Then Return Nothing
        Return dt(0).ToEntity(Of User)()
    End Function

    Public Function GetShoreByClientID(clientid As String) As Store
        If String.IsNullOrEmpty(clientid) Then Return Nothing
        Dim sql = String.Format("SELECT [编号],[店名],[所属行业ID] FROM [Store] WHERE [客户端ID]='{0}'", clientid.Replace("'", ""))
        Dim dt = SqlHelper.ExecuteDataTable(connstr, sql)
        If dt.Rows.Count < 1 Then Return Nothing
        m_shore = dt(0).ToEntity(Of Store)()
        Return m_shore
    End Function

    Public Function Login(mac As String, clientid As String) As Boolean
        If String.IsNullOrEmpty(clientid) Or String.IsNullOrEmpty(mac) Then Return False
        If m_clientlist.Where(Function(m) m.MAC = mac AndAlso m.ClientID = clientid).Count > 0 Then Return True
        If m_clientlist.Where(Function(m) m.MAC = mac).Count > 0 Then Return False
        Dim sql = String.Format("SELECT [编号] FROM [Store] WHERE [客户端ID]='{0}'", clientid.Replace("'", ""))
        Dim dt = SqlHelper.ExecuteDataTable(connstr, sql)
        If dt.Rows.Count < 1 Then Return False
        Dim c As New Client With {.MAC = mac, .ClientID = clientid, .Msg = "", .LastTime = Now}
        m_clientlist.Add(c)
        RaiseEvent Logined(Me, c)
        Return True
    End Function

    Public Function CheckLogin(mac As String, clientid As String) As BoolMsg
        If m_bclientlist.Where(Function(m) m.MAC = mac).Count > 0 Then
            m_client = m_bclientlist.Where(Function(m) m.MAC = mac).FirstOrDefault
            Return New BoolMsg With {.bool = False, .msg = m_client.Msg}
        End If
        If m_clientlist.Where(Function(m) m.MAC = mac AndAlso m.ClientID = clientid).Count > 0 Then
            m_client = m_clientlist.Where(Function(m) m.MAC = mac AndAlso m.ClientID = clientid).FirstOrDefault
            m_client.LastTime = Now
            Return New BoolMsg With {.bool = True}
        End If
        If m_clientlist.Where(Function(m) m.MAC = mac).Count > 0 Then
            Return New BoolMsg With {.bool = False, .msg = "当前已经登录了一个客户端"}
        End If
        Return New BoolMsg With {.bool = False, .msg = "检查登录失败"}
    End Function

    Public Shared Sub Save()
        My.Settings.客户端版本号 = "1.0.0.0"
        My.Settings.Save()
    End Sub
End Class
