Imports System.Data.Odbc
Public Class FormLogin
    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click
        DTGrid = KontrolUser.loginuser(TxtUser.Text).ToTable
        If TxtUser.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Silahkan isikan username dan password anda")
        ElseIf TxtPassword.Text = "" Then
            MsgBox("Silahkan isikan password anda")
        ElseIf TxtUser.Text = "" Then
            MsgBox("Silahkan isikan username anda")
        Else
            If DTGrid.Rows.Count > 0 Then
                EntitasUser.iduser = DTGrid.Rows(0).Item(0)
                EntitasUser.namauser = DTGrid.Rows(0).Item(3)
                EntitasUser.username = DTGrid.Rows(0).Item(1)
                EntitasUser.password = DTGrid.Rows(0).Item(2)

                NAMALOG = EntitasUser.namauser

                If TxtPassword.Text = EntitasUser.password Then
                    FormDashboard.Show()
                    TxtPassword.Text = ""
                    TxtUser.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TxtPassword.Text = ""
                    TxtUser.Focus()
                End If
            Else
                MessageBox.Show("ID tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtPassword.Text = ""
                TxtUser.Text = ""
                TxtUser.Focus()
            End If
        End If
    End Sub
End Class