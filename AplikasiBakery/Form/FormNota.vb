Public Class FormNota
    Private Sub RefreshGrid()
        DTGrid = KontrolNota.tampilData.ToTable
        DGNota.DataSource = DTGrid

    End Sub

    Private Sub FormNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

    End Sub
    Private Sub BtnLaporan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPelaporan.Click

        FormLaporan.Show()
        Me.Hide()
    End Sub
    Private Sub BtnTransaksi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTransaksi.Click

        FormTransaksi.Show()
        Me.Hide()
    End Sub
    Private Sub BtnMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnMenu.Click

        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub LbTotal_Click(sender As Object, e As EventArgs) Handles LbTotal.Click

    End Sub
End Class