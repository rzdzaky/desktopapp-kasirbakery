Public Class ClsEntTransaksi
    Private _idtransaksi As String
    Private _tgltransaksi As Date
    Private _totalharga As Integer
    Private _iduser As String

    Public Property idtransaksi As String
        Get
            Return _idtransaksi
        End Get
        Set
            _idtransaksi = Value
        End Set
    End Property
    Public Property tgltransaksi As Date
        Get
            Return _tgltransaksi
        End Get
        Set
            _tgltransaksi = Value
        End Set
    End Property

    Public Property totalharga As Integer
        Get
            Return _totalharga
        End Get
        Set(value As Integer)
            _totalharga = value
        End Set
    End Property

    Public Property iduser As String
        Get
            Return _iduser
        End Get
        Set(value As String)
            _iduser = value
        End Set
    End Property
End Class
