Public Class FormLaporan
    Private Sub RefreshGrid()
        DTGrid = KontrolLaporan.tampilData.ToTable
        DGLaporan.DataSource = DTGrid

    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

    End Sub
    Private Sub BtnTransaksi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUser.Click

        FormTransaksi.Show()
        Me.Hide()
    End Sub
    Private Sub BtnUser_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        FormUser.Show()
        Me.Hide()
    End Sub
    Private Sub BtnMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnMenu.Click

        FormDashboard.Show()
        Me.Hide()
    End Sub
End Class