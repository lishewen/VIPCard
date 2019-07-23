Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.Runtime.Remoting
Imports VIPCardSharedLibrary

Public Class Service1

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' 请在此处添加代码以启动您的服务。此方法应完成设置工作，
        ' 以使您的服务开始工作。
        Dim props As New Hashtable()
        props("port") = My.Settings.端口号    ' Port of the TCP channel
        props("typeFilterLevel") = TypeFilterLevel.Full

        ' Create the formatters of the messages for delivery.
        Dim clientProvider As BinaryClientFormatterSinkProvider = Nothing
        Dim serverProvider As New BinaryServerFormatterSinkProvider
        serverProvider.TypeFilterLevel = TypeFilterLevel.Full

        ' Create a TCP channel.
        Dim tcpChannel As New TcpChannel(props, clientProvider, serverProvider)

        ' Register the TCP channel.
        ChannelServices.RegisterChannel(tcpChannel, False)

        RemotingConfiguration.ApplicationName = "ShopService"
        RemotingConfiguration.RegisterActivatedServiceType(GetType(ShopActivatedObject))

        'RemotingConfiguration.RegisterWellKnownServiceType(GetType(ShopActivatedObject), "ShopService", WellKnownObjectMode.Singleton)

        AddHandler ShopActivatedObject.Logined, AddressOf Logined
    End Sub

    Protected Overrides Sub OnStop()
        ' 在此处添加代码以执行任何必要的拆解操作，从而停止您的服务。
    End Sub

    Private Sub Logined(sender As ShopActivatedObject, e As Client)

    End Sub

End Class
