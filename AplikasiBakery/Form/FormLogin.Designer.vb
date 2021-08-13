<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnMasuk = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(363, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 540)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(-38, -71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(652, 627)
        Me.Panel2.TabIndex = 1
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(16, 207)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(323, 23)
        Me.TxtUser.TabIndex = 1
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Username.Location = New System.Drawing.Point(16, 165)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(97, 25)
        Me.Username.TabIndex = 2
        Me.Username.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(16, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(16, 293)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(323, 23)
        Me.TxtPassword.TabIndex = 4
        '
        'BtnMasuk
        '
        Me.BtnMasuk.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnMasuk.Location = New System.Drawing.Point(58, 403)
        Me.BtnMasuk.Name = "BtnMasuk"
        Me.BtnMasuk.Size = New System.Drawing.Size(233, 41)
        Me.BtnMasuk.TabIndex = 5
        Me.BtnMasuk.Text = "LOGIN"
        Me.BtnMasuk.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.Location = New System.Drawing.Point(16, 356)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(155, 24)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Keep me logged in"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(11, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Forgot your password?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(72, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 57)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Bakery "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(148, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 57)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Kita"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 544)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnMasuk)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnMasuk As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
