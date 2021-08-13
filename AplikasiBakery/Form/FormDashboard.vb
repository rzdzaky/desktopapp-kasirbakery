Public Class FormDashboard

    Private Sub BtnUser_Click_1(sender As Object, e As EventArgs) Handles BtnUser.Click
        FormUser.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTransaksi_Click(sender As Object, e As EventArgs) Handles BtnTransaksi.Click
        FormTransaksi.Show()
        Me.Hide()
    End Sub
End Class