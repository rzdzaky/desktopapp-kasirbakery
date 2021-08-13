Imports System.Data.Odbc

Public Class ClsCltMenu : Implements InfProsesMenu
    Public Function cariData(kunci As String) As DataView Implements InfProsesMenu.cariData
        Try
            DTA = New OdbcDataAdapter("select * from menu where namamenu " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_menu")
            Dim grid As New DataView(DTS.Tables("Cari_menu"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(idtransaksi,3))from transaksi", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KD" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
