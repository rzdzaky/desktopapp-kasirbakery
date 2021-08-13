Imports System.Data.Odbc
Public Class FormTransaksi

    Private Sub LVTransaksi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVTransaksi.SelectedIndexChanged

    End Sub

    Private Sub TPTanggal_Tick(sender As Object, e As EventArgs) Handles TPTanggal.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", " \S\e\n\i\n", " \S\e\l\a\s\a", " \R\a\b\u", " \K\a\m\i\s", " \J\u\m\a\t", " \S\a\b\t\u"}
        lblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & ", dd MMMM yyyy")
    End Sub

    Sub Buattabel()
        LVTransaksi.Columns.Add("ID Menu", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Nama Menu", 180, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Harga Menu", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Qty", 90, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)

        LVTransaksi.View = View.Details
        LVTransaksi.GridLines = True
        LVTransaksi.FullRowSelect = True
    End Sub


    Private Sub FormTransaksi_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buattabel()
        lblIDJual.Text = KontrolMenu.kodebaru()
        lblNamaKasir.Text = NAMALOG
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim lsdetail As New List(Of ClsEntLaporan)()
        If LVTransaksi.Items.Count = 0 Then
            MsgBox("Masukan Menu yang akan dipesan terlebih dahulu")
            Exit Sub
        End If
        With EntitasTransaksi
            .Totalharga = lblTotal.Text
            .tgltransaksi = Format(Now, "dd/MM/yyyy")

        End With
        For i = 0 To LVTransaksi.Items.Count - 1

            EntitasLaporan = New ClsEntLaporan
            With LVTransaksi.Items(i)
                EntitasLaporan.idmenu = .SubItems(0).Text
                EntitasLaporan.harga = .SubItems(2).Text
                EntitasLaporan.qty = .SubItems(3).Text
            End With

            lsdetail.Add(EntitasLaporan)
        Next i
        For I = 0 To lsdetail.Count - 1

        Next
        KontrolTransaksi.SIMPAN_DATA(EntitasTransaksi, lsdetail)

    End Sub


    Private Sub btnCariMenu_Click(sender As Object, e As EventArgs) Handles BtnCariMenu.Click
        FormCariMenu.Show()
    End Sub

    Sub jumlahLVMenu()
        Dim JumMenu As Integer = 0
        Dim JumHarga As Integer = 0
        Dim totalharga As Double = 0
        For baris As Integer = 0 To LVTransaksi.Items.Count - 1
            JumMenu = JumMenu + LVTransaksi.Items(baris).SubItems(3).Text
            JumHarga = JumHarga + LVTransaksi.Items(baris).SubItems(4).Text
        Next
        lblTotal.Text = JumHarga
        lblJumlahMenu.Text = JumMenu
    End Sub

    Sub TambahMenu()
        txtIDMenu.Text = ""
        txtNamaMenu.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim strMenu(5) As String

        strMenu(0) = txtIDMenu.Text
        strMenu(1) = txtNamaMenu.Text
        strMenu(2) = txtHarga.Text
        strMenu(3) = txtJumlah.Text
        strMenu(4) = Val(txtHarga.Text * txtJumlah.Text)
        LVTransaksi.Items.Add(New ListViewItem(strMenu))
        Call jumlahLVMenu()
        Call TambahMenu()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        LVTransaksi.SelectedItems(0).Remove()
        Call jumlahLVMenu()
    End Sub


    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(lblTotal.Text) Then
                MsgBox("Pembayaran Kurang")
                Exit Sub
            ElseIf Val(txtBayar.Text) = Val(lblTotal.Text) Then
                txtKembali.Text = 0
                BtnSimpan.Focus()
            ElseIf Val(txtBayar.Text) > Val(lblTotal.Text) Then
                txtKembali.Text = Val(txtBayar.Text) - Val(lblTotal.Text)
                BtnSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        FormUser.Show()
        Me.Hide()
    End Sub
End Class