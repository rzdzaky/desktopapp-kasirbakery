Public Class ClsEntUser

    Private _iduser As String
    Private _username As String
    Private _password As String
    Private _namauser As String

    Public Property iduser As String

        Get
            Return _iduser
        End Get
        Set(value As String)
            _iduser = value
        End Set
    End Property
    Public Property password As String

        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property namauser As String
        Get
            Return _namauser
        End Get
        Set(value As String)
            _namauser = value
        End Set
    End Property
End Class
