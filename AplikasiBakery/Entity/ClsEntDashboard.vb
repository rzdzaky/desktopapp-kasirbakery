Public Class ClsEntDashboard

    Private _idmenu As String
    Private _namamenu As String
    Private _harga As Integer
    Private _qty As Integer

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
End Class
