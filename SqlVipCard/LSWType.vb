Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Runtime.InteropServices

<Serializable()> _
<Microsoft.SqlServer.Server.SqlUserDefinedType(Format.UserDefined, MaxByteSize:=4000, IsByteOrdered:=True)> _
<StructLayout(LayoutKind.Sequential)>
Public Class UserInfo
    Implements INullable, IBinarySerialize

    Public Sub New()
        性别 = "未知"
        QQ = "未知"
        生日 = Date.MinValue
        m_Null = True
    End Sub

    Private m_sex As String
    Public Property 性别 As String
        Get
            Return m_sex
        End Get
        Set(value As String)
            m_sex = value
            m_Null = False
        End Set
    End Property
    Private m_qq As String
    Public Property QQ As String
        Get
            Return m_qq
        End Get
        Set(value As String)
            m_qq = value
            m_Null = False
        End Set
    End Property
    Private m_bday As Date
    Public Property 生日 As Date
        Get
            Return m_bday
        End Get
        Set(value As Date)
            m_bday = value
            m_Null = False
        End Set
    End Property
    Public ReadOnly Property 年 As Integer
        Get
            Return 生日.Year
        End Get
    End Property
    Public ReadOnly Property 月 As Integer
        Get
            Return 生日.Month
        End Get
    End Property
    Public ReadOnly Property 日 As Integer
        Get
            Return 生日.Day
        End Get
    End Property

    Public Overrides Function ToString() As String
        ' 在此处放置代码
        If IsNull Then
            Return "NULL"
        Else
            Return 性别 & "," & QQ & "," & 生日
        End If
    End Function

    Public ReadOnly Property IsNull() As Boolean Implements INullable.IsNull
        Get
            ' 在此处放置代码
            Return m_Null
        End Get
    End Property

    Public Shared ReadOnly Property Null As UserInfo
        Get
            Dim h As New UserInfo
            h.m_Null = True
            Return h
        End Get
    End Property

    Public Shared Function Parse(ByVal s As SqlString) As UserInfo
        If s.IsNull Then
            Return Null
        End If

        Dim u As New UserInfo
        ' 在此处放置代码
        Try
            Dim stra = s.Value.Split(",")
            u.性别 = stra(0)
            u.QQ = stra(1)
            u.生日 = CDate(stra(2))
        Catch ex As Exception
            u = Null
        End Try
        Return u
    End Function

    ' 这是占位符方法
    Public Function Method1() As String
        ' 在此处放置代码
        Return "Hello"
    End Function

    ' 这是占位符静态方法
    Public Shared Function Method2() As SqlString
        ' 在此处放置代码
        Return New SqlString("Hello")
    End Function

    ' 这是占位符字段成员
    Public m_var1 As Integer
    ' 私有成员
    Private m_Null As Boolean = True

    Public Sub Read(r As System.IO.BinaryReader) Implements Microsoft.SqlServer.Server.IBinarySerialize.Read
        Dim bNull = r.ReadByte
        If bNull = 0 Then
            m_Null = True
        Else
            m_Null = False
            性别 = r.ReadString
            QQ = r.ReadString
            生日 = Date.FromBinary(r.ReadInt64)
        End If
    End Sub

    Public Sub Write(w As System.IO.BinaryWriter) Implements Microsoft.SqlServer.Server.IBinarySerialize.Write
        Dim bNull As Byte
        If IsNull Then
            bNull = 0
            w.Write(bNull)
        Else
            bNull = 1
            w.Write(bNull)
            w.Write(性别)
            w.Write(QQ)
            w.Write(生日.ToBinary)
        End If
    End Sub
End Class

