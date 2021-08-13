<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnTransaksi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.DGUser = New System.Windows.Forms.DataGridView()
        Me.TxtNamaUser = New System.Windows.Forms.TextBox()
        Me.TxtIDUser = New System.Windows.Forms.TextBox()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(283, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(161, 32)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Tambah User"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnTransaksi)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnUser)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnMenu)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 640)
        Me.Panel2.TabIndex = 53
        '
        'BtnTransaksi
        '
        Me.BtnTransaksi.AutoSize = True
        Me.BtnTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTransaksi.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTransaksi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTransaksi.Location = New System.Drawing.Point(31, 348)
        Me.BtnTransaksi.Name = "BtnTransaksi"
        Me.BtnTransaksi.Size = New System.Drawing.Size(169, 47)
        Me.BtnTransaksi.TabIndex = 51
        Me.BtnTransaksi.Text = "Transaksi"
        Me.BtnTransaksi.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(31, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 45)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Bakery "
        '
        'BtnUser
        '
        Me.BtnUser.AutoSize = True
        Me.BtnUser.BackColor = System.Drawing.Color.DarkSalmon
        Me.BtnUser.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUser.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUser.Location = New System.Drawing.Point(31, 268)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(169, 47)
        Me.BtnUser.TabIndex = 50
        Me.BtnUser.Text = "User"
        Me.BtnUser.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(106, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 45)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Kita"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnMenu
        '
        Me.BtnMenu.AutoSize = True
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMenu.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnMenu.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMenu.Location = New System.Drawing.Point(31, 181)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(169, 47)
        Me.BtnMenu.TabIndex = 48
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.BtnBatal)
        Me.Panel8.Controls.Add(Me.BtnUbah)
        Me.Panel8.Controls.Add(Me.DGUser)
        Me.Panel8.Controls.Add(Me.TxtNamaUser)
        Me.Panel8.Controls.Add(Me.TxtIDUser)
        Me.Panel8.Controls.Add(Me.BtnHapus)
        Me.Panel8.Controls.Add(Me.TxtPassword)
        Me.Panel8.Controls.Add(Me.BtnTambah)
        Me.Panel8.Controls.Add(Me.BtnSimpan)
        Me.Panel8.Controls.Add(Me.Label16)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Controls.Add(Me.TxtUsername)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Location = New System.Drawing.Point(231, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(715, 678)
        Me.Panel8.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(57, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Data User"
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBatal.Image = Global.AplikasiBakery.My.Resources.Resources.close
        Me.BtnBatal.Location = New System.Drawing.Point(256, 497)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(52, 50)
        Me.BtnBatal.TabIndex = 79
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUbah.Image = Global.AplikasiBakery.My.Resources.Resources.edit__1_
        Me.BtnUbah.Location = New System.Drawing.Point(118, 497)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(52, 50)
        Me.BtnUbah.TabIndex = 78
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'DGUser
        '
        Me.DGUser.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUser.Location = New System.Drawing.Point(52, 268)
        Me.DGUser.Name = "DGUser"
        Me.DGUser.RowTemplate.Height = 25
        Me.DGUser.Size = New System.Drawing.Size(603, 205)
        Me.DGUser.TabIndex = 77
        '
        'TxtNamaUser
        '
        Me.TxtNamaUser.Location = New System.Drawing.Point(235, 108)
        Me.TxtNamaUser.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNamaUser.Name = "TxtNamaUser"
        Me.TxtNamaUser.Size = New System.Drawing.Size(159, 23)
        Me.TxtNamaUser.TabIndex = 76
        '
        'TxtIDUser
        '
        Me.TxtIDUser.Location = New System.Drawing.Point(235, 75)
        Me.TxtIDUser.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtIDUser.Name = "TxtIDUser"
        Me.TxtIDUser.Size = New System.Drawing.Size(109, 23)
        Me.TxtIDUser.TabIndex = 75
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHapus.Image = Global.AplikasiBakery.My.Resources.Resources.bin
        Me.BtnHapus.Location = New System.Drawing.Point(324, 497)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(52, 50)
        Me.BtnHapus.TabIndex = 53
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(235, 167)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(109, 23)
        Me.TxtPassword.TabIndex = 74
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTambah.Image = Global.AplikasiBakery.My.Resources.Resources.plus__2_
        Me.BtnTambah.Location = New System.Drawing.Point(51, 497)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(52, 50)
        Me.BtnTambah.TabIndex = 8
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSimpan.Image = Global.AplikasiBakery.My.Resources.Resources.save
        Me.BtnSimpan.Location = New System.Drawing.Point(186, 497)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(52, 50)
        Me.BtnSimpan.TabIndex = 52
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(216, 168)
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
        Me.Label15.Location = New System.Drawing.Point(57, 168)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(235, 138)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(109, 23)
        Me.TxtUsername.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(216, 136)
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
        Me.Label10.Location = New System.Drawing.Point(57, 140)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 15)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Username Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(57, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "ID User"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(216, 110)
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
        Me.Label7.Location = New System.Drawing.Point(216, 77)
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
        Me.Label6.Location = New System.Drawing.Point(57, 110)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Nama User"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 608)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "FormUser"
        Me.Text = "FormUser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label22 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUser As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnMenu As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DGUser As DataGridView
    Friend WithEvents TxtNamaUser As TextBox
    Friend WithEvents TxtIDUser As TextBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTransaksi As Button
End Class
