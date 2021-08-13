Imports System.Data.Odbc


Public Class ClsCltUser : Implements InfProsesUser
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(iduser,3))from user", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "U" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProsesUser.InsertData
        Try
            Dim data As New ClsEntUser
            data = Ob
            CMD = New OdbcCommand("insert into user values('" & kodebaru() & "','" & data.namauser & "','" & data.username & "','" & data.password & "')", BUKAKONEKSI)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OdbcCommand("", TUTUPKONEKSI)
            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProsesUser.updateData
        Try
            Dim data As New ClsEntUser
            data = Ob
            CMD = New OdbcCommand("update user set namauser = '" & data.namauser & "', username= '" & data.username & "', password = '" & data.password & "' where iduser='" & data.iduser & "'", BUKAKONEKSI)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OdbcCommand("", TUTUPKONEKSI)
            Return CMD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProsesUser.deleteData
        CMD = New OdbcCommand("delete from user " & "where iduser = '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function tampilData() As DataView Implements InfProsesUser.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from user", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "tabel user")
            Dim grid As New DataView(DTS.Tables("tabel user"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Throw New NotImplementedException()
    End Function
    Public Function cekKasirDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New Odbc.OdbcDataAdapter("Select count(iduser) from transaksi " & " where iduser = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

    Public Function loginuser(username As String) As DataView
        Try
            DTA = New OdbcDataAdapter("select * from user where username = '" & username & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "login user")
            Dim grid As New DataView(DTS.Tables("login user"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class


