Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.Runtime.Remoting
Imports System.Net.Sockets
Imports VIPCardSharedLibrary

Public Class Form1
    Dim rObj As ShopActivatedObject
    Dim clientid As String = "61f6013b-1da0-4349-9dae-71b60c3a6fe7"
    Dim flag As Boolean = True

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AccessRemotingServerByCode()
    End Sub

    Sub AccessRemotingServerByCode()

        ' Create and register a channel (TCP channel in this example) that 
        ' is used to transport messages across the remoting boundary.

        ' Set the properties of the channel.
        Dim props As New Hashtable()
        props("typeFilterLevel") = TypeFilterLevel.Full

        ' Set the formatters of the messages for delivery.
        Dim clientProvider As New BinaryClientFormatterSinkProvider()
        Dim serverProvider As New BinaryServerFormatterSinkProvider()
        serverProvider.TypeFilterLevel = TypeFilterLevel.Full

        ' Create a TCP channel.
        Dim tcpChannel As New TcpChannel(props, clientProvider, serverProvider)

        ' Register the TCP channel.
        ChannelServices.RegisterChannel(tcpChannel, True)

        Try
            RemotingConfiguration.RegisterActivatedClientType(GetType(ShopActivatedObject), "tcp://localhost:6100/ShopService")
            rObj = New ShopActivatedObject
            'Me.rObj = rObj
            'Dim rObj = CType(Activator.GetObject(GetType(ShopActivatedObject), "tcp://localhost:6100/ShopService"), ShopActivatedObject)
            'Dim wrapper As New EventWrapper
            'AddHandler wrapper.LocalLoginError, AddressOf rObj_LoginError
            'AddHandler rObj.LoginError, AddressOf wrapper.EventLoginError

            TextBox1.AppendText("A client-activated object is created" & vbCrLf)

            TextBox1.AppendText(rObj.GetClientVersion & vbCrLf)
            TextBox1.AppendText(rObj.Login("123", clientid) & vbCrLf)
            Dim s = rObj.GetShoreByClientID(clientid)
            TextBox1.AppendText(s.店名 & vbCrLf)
            TextBox1.AppendText(s.所属行业ID & vbCrLf)
        Catch ex As SocketException
            MsgBox(ex.Message)
        End Try
        'Console.Read()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        TextBox1.AppendText(rObj.CheckLogin("12", clientid).msg)
    End Sub

    'Private Sub rObj_LoginError(sender As VIPCardSharedLibrary.ShopActivatedObject, e As String)
    '    If flag Then
    '        flag = False
    '        MsgBox(e)
    '        End
    '    End If
    'End Sub
End Class
