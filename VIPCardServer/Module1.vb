Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.Runtime.Remoting
Imports VIPCardSharedLibrary

Public Module Module1
    Sub Main()
        Dim props As New Hashtable()
        props("port") = 6200 'My.Settings.端口号    ' Port of the TCP channel
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
        My.Settings.端口号 = 6100
        My.Settings.Save()
        ShopActivatedObject.Save()

        AddHandler ShopActivatedObject.Logined, AddressOf Logined

        'Console.WriteLine((New ShopActivatedObject).GetShoreByClientID("61f6013b-1da0-4349-9dae-71b60c3a6fe7").所属行业ID)
        Console.WriteLine((New ShopActivatedObject).GetUserByName("880938").余额)
        Console.WriteLine("Press Enter to exit the Remoting server")
        Console.ReadLine()
    End Sub

    Private Sub Logined(sender As ShopActivatedObject, e As Client)
        Console.WriteLine(ShopActivatedObject.ClientList.Count)
        Console.WriteLine("Mac:" & e.MAC & "，已经登录")
    End Sub
End Module
