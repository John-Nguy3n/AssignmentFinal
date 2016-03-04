<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongTinNV
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bntThem = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvHienThi = New System.Windows.Forms.DataGridView()
        Me.cbbTimkiem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.dgvHienThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil Std", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DANH SÁCH NHÂN VIÊN CTY"
        '
        'bntThem
        '
        Me.bntThem.Location = New System.Drawing.Point(34, 466)
        Me.bntThem.Name = "bntThem"
        Me.bntThem.Size = New System.Drawing.Size(194, 23)
        Me.bntThem.TabIndex = 1
        Me.bntThem.Text = "Thêm"
        Me.bntThem.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(552, 62)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(202, 20)
        Me.txtTimKiem.TabIndex = 2
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(760, 59)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(128, 23)
        Me.btnTim.TabIndex = 6
        Me.btnTim.Text = "Tim kiếm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(257, 466)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(194, 23)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(476, 466)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(194, 23)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvHienThi
        '
        Me.dgvHienThi.AllowUserToAddRows = False
        Me.dgvHienThi.AllowUserToDeleteRows = False
        Me.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHienThi.Location = New System.Drawing.Point(34, 89)
        Me.dgvHienThi.Name = "dgvHienThi"
        Me.dgvHienThi.ReadOnly = True
        Me.dgvHienThi.Size = New System.Drawing.Size(845, 353)
        Me.dgvHienThi.TabIndex = 20
        '
        'cbbTimkiem
        '
        Me.cbbTimkiem.FormattingEnabled = True
        Me.cbbTimkiem.Items.AddRange(New Object() {"Mã nhân viên", "Tên nhân viên"})
        Me.cbbTimkiem.Location = New System.Drawing.Point(411, 62)
        Me.cbbTimkiem.Name = "cbbTimkiem"
        Me.cbbTimkiem.Size = New System.Drawing.Size(121, 21)
        Me.cbbTimkiem.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Tìm kiếm:"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(685, 466)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(194, 23)
        Me.btnThoat.TabIndex = 32
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmThongTinNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 520)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.cbbTimkiem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvHienThi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.bntThem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThongTinNV"
        Me.Text = "Danh sách nhân viên"
        CType(Me.dgvHienThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bntThem As System.Windows.Forms.Button
    Friend WithEvents txtTimKiem As System.Windows.Forms.TextBox
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents dgvHienThi As System.Windows.Forms.DataGridView
    Friend WithEvents cbbTimkiem As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As System.Windows.Forms.Button
End Class
