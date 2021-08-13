<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNota))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnNota = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTransaksi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPelaporan = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DGNota = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DGNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnNota)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnTransaksi)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnPelaporan)
        Me.Panel2.Controls.Add(Me.BtnMenu)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 640)
        Me.Panel2.TabIndex = 44
        '
        'BtnNota
        '
        Me.BtnNota.AutoSize = True
        Me.BtnNota.BackColor = System.Drawing.Color.DarkGray
        Me.BtnNota.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNota.Location = New System.Drawing.Point(59, 296)
        Me.BtnNota.Name = "BtnNota"
        Me.BtnNota.Size = New System.Drawing.Size(93, 34)
        Me.BtnNota.TabIndex = 51
        Me.BtnNota.Text = "Nota"
        Me.BtnNota.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(83, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 25)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Kita"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnTransaksi
        '
        Me.BtnTransaksi.AutoSize = True
        Me.BtnTransaksi.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTransaksi.Location = New System.Drawing.Point(59, 237)
        Me.BtnTransaksi.Name = "BtnTransaksi"
        Me.BtnTransaksi.Size = New System.Drawing.Size(93, 31)
        Me.BtnTransaksi.TabIndex = 50
        Me.BtnTransaksi.Text = "Transaksi"
        Me.BtnTransaksi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(67, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Bakery "
        '
        'BtnPelaporan
        '
        Me.BtnPelaporan.AutoSize = True
        Me.BtnPelaporan.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPelaporan.Location = New System.Drawing.Point(59, 352)
        Me.BtnPelaporan.Name = "BtnPelaporan"
        Me.BtnPelaporan.Size = New System.Drawing.Size(93, 34)
        Me.BtnPelaporan.TabIndex = 49
        Me.BtnPelaporan.Text = "Pelaporan"
        Me.BtnPelaporan.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.AutoSize = True
        Me.BtnMenu.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMenu.Location = New System.Drawing.Point(59, 173)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(93, 31)
        Me.BtnMenu.TabIndex = 48
        Me.BtnMenu.Text = "Menu"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label22.Location = New System.Drawing.Point(284, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(196, 32)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Nota Pembelian"
        '
        'DGNota
        '
        Me.DGNota.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGNota.Location = New System.Drawing.Point(53, 85)
        Me.DGNota.Name = "DGNota"
        Me.DGNota.RowTemplate.Height = 25
        Me.DGNota.Size = New System.Drawing.Size(612, 342)
        Me.DGNota.TabIndex = 45
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.Controls.Add(Me.LbTotal)
        Me.Panel8.Controls.Add(Me.DGNota)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Location = New System.Drawing.Point(231, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(723, 609)
        Me.Panel8.TabIndex = 52
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(348, 459)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Bayar  :"
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbTotal.Location = New System.Drawing.Point(557, 459)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(25, 32)
        Me.LbTotal.TabIndex = 46
        Me.LbTotal.Text = "x"
        '
        'FormNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 601)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "FormNota"
        Me.Text = "FormNota"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGNota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents DGNota As DataGridView
    Friend WithEvents BtnNota As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTransaksi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPelaporan As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LbTotal As Label
End Class
