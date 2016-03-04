<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.lblTaiKhoan = New System.Windows.Forms.Label()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Blue
        Me.lblTieuDe.Location = New System.Drawing.Point(64, 26)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(375, 24)
        Me.lblTieuDe.TabIndex = 14
        Me.lblTieuDe.Text = "ỨNG DỤNG QUẢN LÝ KHÁCH HÀNG"
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatKhau.Location = New System.Drawing.Point(191, 129)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(76, 19)
        Me.lblMatKhau.TabIndex = 13
        Me.lblMatKhau.Text = "Mật khẩu:"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(288, 128)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtMatKhau.Size = New System.Drawing.Size(183, 20)
        Me.txtMatKhau.TabIndex = 12
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(265, 208)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(131, 28)
        Me.btnThoat.TabIndex = 11
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.Location = New System.Drawing.Point(192, 174)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(131, 28)
        Me.btnDangNhap.TabIndex = 10
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'lblTaiKhoan
        '
        Me.lblTaiKhoan.AutoSize = True
        Me.lblTaiKhoan.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaiKhoan.Location = New System.Drawing.Point(188, 97)
        Me.lblTaiKhoan.Name = "lblTaiKhoan"
        Me.lblTaiKhoan.Size = New System.Drawing.Size(79, 19)
        Me.lblTaiKhoan.TabIndex = 9
        Me.lblTaiKhoan.Text = "Tài khoản:"
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(288, 98)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(183, 20)
        Me.txtTaiKhoan.TabIndex = 8
        '
        'btnDangKy
        '
        Me.btnDangKy.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangKy.Location = New System.Drawing.Point(340, 174)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(131, 28)
        Me.btnDangKy.TabIndex = 16
        Me.btnDangKy.Text = "Đăng kí"
        Me.btnDangKy.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INF205_QLKH_PS03423.My.Resources.Resources.login_user_profile_account_logout_people_man_human_512
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(21, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 177)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Pristina", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "By: Nguyễn Cao Hoàng"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 281)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDangKy)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.lblMatKhau)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.lblTaiKhoan)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTieuDe As System.Windows.Forms.Label
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents lblTaiKhoan As System.Windows.Forms.Label
    Friend WithEvents txtTaiKhoan As System.Windows.Forms.TextBox
    Friend WithEvents btnDangKy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
