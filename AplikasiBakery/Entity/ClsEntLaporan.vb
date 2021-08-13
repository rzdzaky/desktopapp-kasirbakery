Public Class ClsEntLaporan
    Private _idtransaksi As String
    Private _idmenu As String
    Private _harga As Integer
    Private _qty As Integer

    Public Property idtransaksi As String
        Get
            Return _idtransaksi
        End Get
        Set
            _idtransaksi = Value
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
        Set(value As Integer)
            _qty = value
        End Set
    End Property
End Class
