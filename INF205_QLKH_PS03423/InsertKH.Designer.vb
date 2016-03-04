<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertKH
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
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMoTaThem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbHinhAnh = New System.Windows.Forms.PictureBox()
        Me.btnHinhAnh = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(481, 506)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(84, 33)
        Me.btnThoat.TabIndex = 29
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(356, 506)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(82, 33)
        Me.btnThem.TabIndex = 28
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMoTaThem)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(30, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(535, 153)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mô tả thêm"
        '
        'txtMoTaThem
        '
        Me.txtMoTaThem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoTaThem.Location = New System.Drawing.Point(7, 25)
        Me.txtMoTaThem.Multiline = True
        Me.txtMoTaThem.Name = "txtMoTaThem"
        Me.txtMoTaThem.Size = New System.Drawing.Size(522, 121)
        Me.txtMoTaThem.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtCMND)
        Me.GroupBox1.Controls.Add(Me.txtDienThoai)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtTenKH)
        Me.GroupBox1.Controls.Add(Me.txtMaKH)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 226)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(134, 124)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(188, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(134, 184)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(188, 20)
        Me.txtCMND.TabIndex = 12
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(134, 155)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(188, 20)
        Me.txtDienThoai.TabIndex = 11
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(134, 95)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(188, 20)
        Me.txtDiaChi.TabIndex = 9
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(134, 65)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(188, 20)
        Me.txtTenKH.TabIndex = 8
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(134, 33)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(188, 20)
        Me.txtMaKH.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã khách hàng:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Điện thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên khách hàng:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CMND:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(135, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 31)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "THÔNG TIN KHÁCH HÀNG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbHinhAnh
        '
        Me.ptbHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhAnh.Location = New System.Drawing.Point(400, 106)
        Me.ptbHinhAnh.Name = "ptbHinhAnh"
        Me.ptbHinhAnh.Size = New System.Drawing.Size(159, 173)
        Me.ptbHinhAnh.TabIndex = 31
        Me.ptbHinhAnh.TabStop = False
        '
        'btnHinhAnh
        '
        Me.btnHinhAnh.Location = New System.Drawing.Point(444, 291)
        Me.btnHinhAnh.Name = "btnHinhAnh"
        Me.btnHinhAnh.Size = New System.Drawing.Size(75, 23)
        Me.btnHinhAnh.TabIndex = 30
        Me.btnHinhAnh.Text = "Chọn ảnh"
        Me.btnHinhAnh.UseVisualStyleBackColor = True
        '
        'frmInsertKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 581)
        Me.Controls.Add(Me.ptbHinhAnh)
        Me.Controls.Add(Me.btnHinhAnh)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInsertKH"
        Me.Text = "Thêm khách hàng"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMoTaThem As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCMND As System.Windows.Forms.TextBox
    Friend WithEvents txtDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents ptbHinhAnh As System.Windows.Forms.PictureBox
    Friend WithEvents btnHinhAnh As System.Windows.Forms.Button
End Class
