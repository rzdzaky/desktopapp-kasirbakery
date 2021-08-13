Public Class ClsEntNota

    Private _idnota As String
    Private _tgltransaksi As Date
    Private _idmenu As String
    Private _namamenu As String
    Private _harga As Integer
    Private _qty As Integer
    Private _totalharga As Integer

    Public Property idnota As String
        Get
            Return _idnota
        End Get
        Set
            _idnota = Value
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

    Public Property idmenu As String
        Get
            Return _idmenu
        End Get
        Set
            _idmenu = Value
        End Set
    End Property

    Public Property namamenu As String
        Get
            Return _namamenu
        End Get
        Set
            _namamenu = Value
        End Set
    End Property
    Public Property harga As Integer
        Get
            Return _harga
        End Get
        Set
            _harga = Value
        End Set
    End Property
    Public Property qty As Integer
        Get
            Return _qty
        End Get
        Set
            _qty = Value
        End Set
    End Property
    Public Property totalharga As Integer
        Get
            Return _totalharga
        End Get
        Set
            _totalharga = Value
        End Set
    End Property
End Class

