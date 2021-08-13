Public Class FormUser

    Dim modeProses As Integer
        Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        BtnTambah.Enabled = st
        BtnUbah.Enabled = st
        BtnHapus.Enabled = st
        BtnSimpan.Enabled = Not st
        BtnBatal.Enabled = Not st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGUser.Rows(br)
                TxtIDUser.Text = .Cells(0).Value.ToString
                TxtNamaUser.Text = .Cells(1).Value.ToString
                TxtUsername.Text = .Cells(2).Value.ToString
                TxtPassword.Text = .Cells(3).Value.ToString

            End With
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolUser.tampilData.ToTable
        DGUser.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGUser.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUser.CurrentCell = DGUser.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        'atur texbox menjadi disable
        TxtIDUser.Enabled = False

    End Sub
    Private Sub DGUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUser.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGUser.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasUser
            .iduser = TxtIDUser.Text
            .namauser = TxtNamaUser.Text
            .username = TxtUsername.Text
            .password = TxtPassword.Text
        End With

        If modeProses = 1 Then
            KontrolUser.InsertData(EntitasUser)
        ElseIf modeProses = 2 Then
            KontrolUser.updateData(EntitasUser)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolUser.cekKasirDireferensi(TxtIDUser.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin akan menghapus kasir " & TxtNamaUser.Text & "?",
                    MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            KontrolUser.deleteData(TxtIDUser.Text)
        End If
        RefreshGrid()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        AturButton(False)
        modeProses = 1
        TxtIDUser.Text = "Otomatis Generate oleh sistem"
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        'atur button false 
        AturButton(False)
        modeProses = 2
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        'panggil fungsi refresh grid 
        RefreshGrid()

        'panggil fungsi aturbutton dengan nilai true
        AturButton(True)

        'set nilai modeproses menjadi 0
        modeProses = 0
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTransaksi_Click(sender As Object, e As EventArgs) Handles BtnTransaksi.Click
        FormTransaksi.Show()
        Me.Hide()
    End Sub
End Class