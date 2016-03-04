<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangKy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DangKy))
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.bntThoat = New System.Windows.Forms.Button()
        Me.bntDangKy = New System.Windows.Forms.Button()
        Me.cbbEmail = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(243, 212)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(108, 23)
        Me.btnXoa.TabIndex = 21
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'bntThoat
        '
        Me.bntThoat.Location = New System.Drawing.Point(185, 250)
        Me.bntThoat.Name = "bntThoat"
        Me.bntThoat.Size = New System.Drawing.Size(108, 23)
        Me.bntThoat.TabIndex = 20
        Me.bntThoat.Text = "Thoát"
        Me.bntThoat.UseVisualStyleBackColor = True
        '
        'bntDangKy
        '
        Me.bntDangKy.Location = New System.Drawing.Point(122, 212)
        Me.bntDangKy.Name = "bntDangKy"
        Me.bntDangKy.Size = New System.Drawing.Size(108, 23)
        Me.bntDangKy.TabIndex = 19
        Me.bntDangKy.Text = "Đăng ký"
        Me.bntDangKy.UseVisualStyleBackColor = True
        '
        'cbbEmail
        '
        Me.cbbEmail.FormattingEnabled = True
        Me.cbbEmail.Items.AddRange(New Object() {"@Yahoo.com", "@Gmail.com"})
        Me.cbbEmail.Location = New System.Drawing.Point(256, 157)
        Me.cbbEmail.Name = "cbbEmail"
        Me.cbbEmail.Size = New System.Drawing.Size(95, 21)
        Me.cbbEmail.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 157)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(128, 20)
        Me.txtEmail.TabIndex = 17
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(122, 117)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(229, 20)
        Me.txtMatKhau.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mật khẩu:"
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(122, 77)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(229, 20)
        Me.txtTaiKhoan.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tên đăng nhập:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(135, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Đăng ký"
        '
        'DangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 302)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.bntThoat)
        Me.Controls.Add(Me.bntDangKy)
        Me.Controls.Add(Me.cbbEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DangKy"
        Me.Text = "Đăng ký người dùng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents bntThoat As System.Windows.Forms.Button
    Friend WithEvents bntDangKy As System.Windows.Forms.Button
    Friend WithEvents cbbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTaiKhoan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
