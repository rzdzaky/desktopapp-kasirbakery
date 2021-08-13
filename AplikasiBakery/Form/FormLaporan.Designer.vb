<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporan))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnTransaksi = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnPelaporan = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGLaporan = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.DGLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnTransaksi)
        Me.Panel2.Controls.Add(Me.BtnUser)
        Me.Panel2.Controls.Add(Me.BtnPelaporan)
        Me.Panel2.Controls.Add(Me.BtnMenu)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, -9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 650)
        Me.Panel2.TabIndex = 45
        '
        'BtnTransaksi
        '
        Me.BtnTransaksi.AutoSize = True
        Me.BtnTransaksi.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTransaksi.Location = New System.Drawing.Point(62, 305)
        Me.BtnTransaksi.Name = "BtnTransaksi"
        Me.BtnTransaksi.Size = New System.Drawing.Size(93, 31)
        Me.BtnTransaksi.TabIndex = 6
        Me.BtnTransaksi.Text = "Transaksi"
        Me.BtnTransaksi.UseVisualStyleBackColor = True
        '
        'BtnUser
        '
        Me.BtnUser.AutoSize = True
        Me.BtnUser.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUser.Location = New System.Drawing.Point(62, 246)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(93, 31)
        Me.BtnUser.TabIndex = 5
        Me.BtnUser.Text = "User"
        Me.BtnUser.UseVisualStyleBackColor = True
        '
        'BtnPelaporan
        '
        Me.BtnPelaporan.AutoSize = True
        Me.BtnPelaporan.BackColor = System.Drawing.Color.DarkGray
        Me.BtnPelaporan.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPelaporan.Location = New System.Drawing.Point(62, 361)
        Me.BtnPelaporan.Name = "BtnPelaporan"
        Me.BtnPelaporan.Size = New System.Drawing.Size(93, 36)
        Me.BtnPelaporan.TabIndex = 4
        Me.BtnPelaporan.Text = "Pelaporan"
        Me.BtnPelaporan.UseVisualStyleBackColor = False
        '
        'BtnMenu
        '
        Me.BtnMenu.AutoSize = True
        Me.BtnMenu.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMenu.Location = New System.Drawing.Point(62, 182)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(93, 31)
        Me.BtnMenu.TabIndex = 2
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(70, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bakery "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(86, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kita"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DGLaporan
        '
        Me.DGLaporan.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLaporan.Location = New System.Drawing.Point(275, 86)
        Me.DGLaporan.Name = "DGLaporan"
        Me.DGLaporan.RowTemplate.Height = 25
        Me.DGLaporan.Size = New System.Drawing.Size(574, 482)
        Me.DGLaporan.TabIndex = 47
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label22.Location = New System.Drawing.Point(286, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(226, 32)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Laporan Penjualan"
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.Controls.Add(Me.BtnSave)
        Me.Panel8.Controls.Add(Me.BtnEdit)
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Location = New System.Drawing.Point(232, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(721, 641)
        Me.Panel8.TabIndex = 52
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.Image = Global.AplikasiBakery.My.Resources.Resources.save
        Me.BtnSave.Location = New System.Drawing.Point(633, 96)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(58, 52)
        Me.BtnSave.TabIndex = 53
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEdit.Image = Global.AplikasiBakery.My.Resources.Resources.edit__1_
        Me.BtnEdit.Location = New System.Drawing.Point(633, 165)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(58, 50)
        Me.BtnEdit.TabIndex = 53
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(479, 615)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Beli"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 627)
        Me.Controls.Add(Me.DGLaporan)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "FormLaporan"
        Me.Text = "FormLaporan"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnUser As Button
    Friend WithEvents BtnPelaporan As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGLaporan As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnTransaksi As Button
End Class
