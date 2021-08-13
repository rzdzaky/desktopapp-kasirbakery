Imports System.Data.Odbc


Public Class ClsCltTransaksi
    Dim SQL As String

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(idtransaksi,4))from transaksi", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "MN" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function

    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntTransaksi, ByVal _item As List(Of ClsEntLaporan)) As String
        Dim IDT As String
        IDT = ""
        TUTUPKONEKSI()
        With _pbl
            SQL = "SP_INSERTTRANSAKSI" & .totalharga & ",'" & Format(.tgltransaksi, "yyyy/MM/dd") & "','" & .iduser & "'"
            MsgBox(SQL)
            Try
                DTA = New OdbcDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_ID_JUAL")
                IDT = DTS.Tables("TABEL_ID_JUAL").Rows(0)(0).To
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End With
        TUTUPKONEKSI()
        For i = 0 To _item.Count - 1
            With _item(1)
                SQL = "insert into nota values ('" & IDT & "','" & .idmenu & "'," & .harga & "," & .qty & ")"
                MsgBox(SQL)
                CMD = New OdbcCommand(SQL, BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OdbcCommand("", TUTUPKONEKSI)

            End With
        Next
        Return IDT
    End Function
End Class