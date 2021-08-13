Imports System.Data.Odbc

Public Interface InfProsesUser
    Function InsertData(Ob As Object) As OdbcCommand

    Function updateData(Ob As Object) As OdbcCommand

    Function deleteData(kunci As String) As OdbcCommand

    Function tampilData() As DataView

End Interface
