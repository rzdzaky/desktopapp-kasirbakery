Imports System.Data.Odbc
Public Class ClsCltNota : Implements InfProsesNota

    Public Function tampilData() As DataView Implements InfProsesNota.tampilData
        Try
            DTA = New OdbcDataAdapter("select idmenu,namamenu,qty,harga from nota", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Nota")
            Dim grid As New DataView(DTS.Tables("Tabel_Nota"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function tampiltotal() As DataView Implements InfProsesNota.tampiltotal
        Try
            DTA = New OdbcDataAdapter("select totalharga from transaksi", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "total")
            Dim grid As New DataView(DTS.Tables("total"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Throw New NotImplementedException()
    End Function
End Class
