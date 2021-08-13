<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnTransaksi = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblJumlahMenu = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LVTransaksi = New System.Windows.Forms.ListView()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblNamaKasir = New System.Windows.Forms.Label()
        Me.lblIDJual = New System.Windows.Forms.Label()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.BtnCariMenu = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TPTanggal = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnUser)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnMenu)
        Me.Panel2.Controls.Add(Me.BtnTransaksi)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 640)
        Me.Panel2.TabIndex = 43
        '
        'BtnUser
        '
        Me.BtnUser.AutoSize = True
        Me.BtnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUser.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUser.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUser.Location = New System.Drawing.Point(30, 291)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(169, 47)
        Me.BtnUser.TabIndex = 57
        Me.BtnUser.Text = "User"
        Me.BtnUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(30, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 45)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Bakery "
        '
        'BtnMenu
        '
        Me.BtnMenu.AutoSize = True
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMenu.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnMenu.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMenu.Location = New System.Drawing.Point(30, 196)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(169, 47)
        Me.BtnMenu.TabIndex = 55
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'BtnTransaksi
        '
        Me.BtnTransaksi.AutoSize = True
        Me.BtnTransaksi.BackColor = System.Drawing.Color.DarkSalmon
        Me.BtnTransaksi.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTransaksi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTransaksi.Location = New System.Drawing.Point(30, 377)
        Me.BtnTransaksi.Name = "BtnTransaksi"
        Me.BtnTransaksi.Size = New System.Drawing.Size(169, 47)
        Me.BtnTransaksi.TabIndex = 56
        Me.BtnTransaksi.Text = "Transaksi"
        Me.BtnTransaksi.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(105, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 45)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Kita"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(551, 121)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(216, 155)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 15)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(216, 122)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(57, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Nama Kasir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(414, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tanggal Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(57, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "No Penjualan"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(283, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(238, 32)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Transaksi Penjualan"
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.Controls.Add(Me.txtHarga)
        Me.Panel8.Controls.Add(Me.txtKembali)
        Me.Panel8.Controls.Add(Me.txtBayar)
        Me.Panel8.Controls.Add(Me.Label21)
        Me.Panel8.Controls.Add(Me.Label19)
        Me.Panel8.Controls.Add(Me.lblJumlahMenu)
        Me.Panel8.Controls.Add(Me.Label18)
        Me.Panel8.Controls.Add(Me.BtnSimpan)
        Me.Panel8.Controls.Add(Me.Label16)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Controls.Add(Me.lblTotal)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Controls.Add(Me.GroupBox1)
        Me.Panel8.Controls.Add(Me.txtJumlah)
        Me.Panel8.Controls.Add(Me.lblTanggal)
        Me.Panel8.Controls.Add(Me.lblNamaKasir)
        Me.Panel8.Controls.Add(Me.lblIDJual)
        Me.Panel8.Controls.Add(Me.txtNamaMenu)
        Me.Panel8.Controls.Add(Me.txtIDMenu)
        Me.Panel8.Controls.Add(Me.BtnCariMenu)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Location = New System.Drawing.Point(231, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(715, 678)
        Me.Panel8.TabIndex = 52
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(235, 212)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(85, 23)
        Me.txtHarga.TabIndex = 74
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(537, 540)
        Me.txtKembali.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(85, 23)
        Me.txtKembali.TabIndex = 73
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(537, 509)
        Me.txtBayar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(85, 23)
        Me.txtBayar.TabIndex = 72
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.Location = New System.Drawing.Point(411, 549)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 18)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Kembali"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(411, 509)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 18)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Bayar"
        '
        'lblJumlahMenu
        '
        Me.lblJumlahMenu.AutoSize = True
        Me.lblJumlahMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlahMenu.Location = New System.Drawing.Point(279, 507)
        Me.lblJumlahMenu.Name = "lblJumlahMenu"
        Me.lblJumlahMenu.Size = New System.Drawing.Size(18, 20)
        Me.lblJumlahMenu.TabIndex = 68
        Me.lblJumlahMenu.Text = "X"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(131, 508)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 18)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "Jumlah Pesanan"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Maroon
        Me.BtnSimpan.Image = Global.AplikasiBakery.My.Resources.Resources.save
        Me.BtnSimpan.Location = New System.Drawing.Point(51, 521)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(52, 50)
        Me.BtnSimpan.TabIndex = 52
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(216, 213)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 15)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(57, 213)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 15)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Harga"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(260, 547)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(23, 25)
        Me.lblTotal.TabIndex = 63
        Me.lblTotal.Text = "X"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(131, 547)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 24)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Total Bayar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LVTransaksi)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 229)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'LVTransaksi
        '
        Me.LVTransaksi.HideSelection = False
        Me.LVTransaksi.Location = New System.Drawing.Point(6, 19)
        Me.LVTransaksi.Name = "LVTransaksi"
        Me.LVTransaksi.Size = New System.Drawing.Size(638, 156)
        Me.LVTransaksi.TabIndex = 54
        Me.LVTransaksi.UseCompatibleStateImageBehavior = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Maroon
        Me.BtnHapus.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.ForeColor = System.Drawing.Color.Transparent
        Me.BtnHapus.Location = New System.Drawing.Point(528, 181)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(79, 34)
        Me.BtnHapus.TabIndex = 53
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Maroon
        Me.BtnTambah.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTambah.Location = New System.Drawing.Point(421, 181)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(79, 34)
        Me.BtnTambah.TabIndex = 8
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(235, 245)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(66, 23)
        Me.txtJumlah.TabIndex = 60
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(569, 121)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(14, 15)
        Me.lblTanggal.TabIndex = 59
        Me.lblTanggal.Text = "X"
        '
        'lblNamaKasir
        '
        Me.lblNamaKasir.AutoSize = True
        Me.lblNamaKasir.Location = New System.Drawing.Point(235, 155)
        Me.lblNamaKasir.Name = "lblNamaKasir"
        Me.lblNamaKasir.Size = New System.Drawing.Size(14, 15)
        Me.lblNamaKasir.TabIndex = 58
        Me.lblNamaKasir.Text = "X"
        '
        'lblIDJual
        '
        Me.lblIDJual.AutoSize = True
        Me.lblIDJual.Location = New System.Drawing.Point(235, 122)
        Me.lblIDJual.Name = "lblIDJual"
        Me.lblIDJual.Size = New System.Drawing.Size(14, 15)
        Me.lblIDJual.TabIndex = 57
        Me.lblIDJual.Text = "X"
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.Location = New System.Drawing.Point(328, 183)
        Me.txtNamaMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(176, 23)
        Me.txtNamaMenu.TabIndex = 56
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(235, 183)
        Me.txtIDMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(85, 23)
        Me.txtIDMenu.TabIndex = 55
        '
        'BtnCariMenu
        '
        Me.BtnCariMenu.BackColor = System.Drawing.Color.Maroon
        Me.BtnCariMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCariMenu.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCariMenu.Location = New System.Drawing.Point(511, 181)
        Me.BtnCariMenu.Name = "BtnCariMenu"
        Me.BtnCariMenu.Size = New System.Drawing.Size(63, 31)
        Me.BtnCariMenu.TabIndex = 54
        Me.BtnCariMenu.Text = "Cari"
        Me.BtnCariMenu.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(216, 245)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 15)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(57, 245)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 15)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Qty"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(216, 181)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(57, 181)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(57, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data Transaksi"
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(479, 615)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 42)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Beli"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TPTanggal
        '
        Me.TPTanggal.Enabled = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 610)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents lblIDJual As Label
    Friend WithEvents txtNamaMenu As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents BtnCariMenu As Button
    Friend WithEvents lblJumlahMenu As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LVTransaksi As ListView
    Friend WithEvents TPTTanggal As Timer
    Friend WithEvents TPTanggal As Timer
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents BtnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnTransaksi As Button
    Friend WithEvents Label2 As Label
End Class
