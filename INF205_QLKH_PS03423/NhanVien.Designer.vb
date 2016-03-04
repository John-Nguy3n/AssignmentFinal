<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhanVien
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvHienThi = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        CType(Me.dgvHienThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(202, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DANH SÁCH NHÂN VIÊN CTY"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(457, 513)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(110, 23)
        Me.btnThem.TabIndex = 1
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvHienThi
        '
        Me.dgvHienThi.AllowUserToAddRows = False
        Me.dgvHienThi.AllowUserToDeleteRows = False
        Me.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHienThi.Location = New System.Drawing.Point(12, 121)
        Me.dgvHienThi.Name = "dgvHienThi"
        Me.dgvHienThi.ReadOnly = True
        Me.dgvHienThi.Size = New System.Drawing.Size(868, 375)
        Me.dgvHienThi.TabIndex = 20
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(770, 513)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(110, 23)
        Me.btnXoa.TabIndex = 21
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(614, 513)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(110, 23)
        Me.btnCapNhat.TabIndex = 22
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(630, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(563, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tìm kiếm:"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(805, 92)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btnTimKiem.TabIndex = 25
        Me.btnTimKiem.Text = "Tìm "
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 548)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.dgvHienThi)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NhanVien"
        Me.Text = "NhanVien"
        CType(Me.dgvHienThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents dgvHienThi As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
End Class
