Imports System.Data.Odbc
Public Class ClsCltLaporan : Implements InfProsesUser

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProsesUser.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProsesUser.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProsesUser.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProsesUser.tampilData
        Try
            DTA = New OdbcDataAdapter("SELECT * from laporan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Laporan")
            Dim grid As New DataView(DTS.Tables("Tabel_Laporan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView
        Throw New NotImplementedException()
    End Function
End Class
