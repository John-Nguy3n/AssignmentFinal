<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeThong
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HêThôngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiơiThiêuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbTenDN = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HêThôngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.KhachHangToolStripMenuItem, Me.GiơiThiêuToolStripMenuItem, Me.tsbTenDN})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HêThôngToolStripMenuItem
        '
        Me.HêThôngToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HêThôngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoatToolStripMenuItem})
        Me.HêThôngToolStripMenuItem.Image = Global.INF205_QLKH_PS03423.My.Resources.Resources.home_ico
        Me.HêThôngToolStripMenuItem.Name = "HêThôngToolStripMenuItem"
        Me.HêThôngToolStripMenuItem.Size = New System.Drawing.Size(85, 23)
        Me.HêThôngToolStripMenuItem.Text = "Hệ thống"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThoatToolStripMenuItem.Text = "Thoát"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmToolStripMenuItem})
        Me.NhânViênToolStripMenuItem.Image = Global.INF205_QLKH_PS03423.My.Resources.Resources.nam
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(89, 23)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'ThêmToolStripMenuItem
        '
        Me.ThêmToolStripMenuItem.Name = "ThêmToolStripMenuItem"
        Me.ThêmToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.ThêmToolStripMenuItem.Text = "Thêm"
        '
        'KhachHangToolStripMenuItem
        '
        Me.KhachHangToolStripMenuItem.Image = Global.INF205_QLKH_PS03423.My.Resources.Resources.customer_icon
        Me.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem"
        Me.KhachHangToolStripMenuItem.Size = New System.Drawing.Size(98, 23)
        Me.KhachHangToolStripMenuItem.Text = "Khách hàng"
        '
        'GiơiThiêuToolStripMenuItem
        '
        Me.GiơiThiêuToolStripMenuItem.Image = Global.INF205_QLKH_PS03423.My.Resources.Resources.about_xxl
        Me.GiơiThiêuToolStripMenuItem.Name = "GiơiThiêuToolStripMenuItem"
        Me.GiơiThiêuToolStripMenuItem.Size = New System.Drawing.Size(86, 23)
        Me.GiơiThiêuToolStripMenuItem.Text = "Giới thiệu"
        '
        'tsbTenDN
        '
        Me.tsbTenDN.AutoSize = False
        Me.tsbTenDN.Name = "tsbTenDN"
        Me.tsbTenDN.ReadOnly = True
        Me.tsbTenDN.Size = New System.Drawing.Size(70, 23)
        Me.tsbTenDN.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmHeThong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.INF205_QLKH_PS03423.My.Resources.Resources.Year_of_the_monkey_2016_calendar_vector_illustration__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(639, 538)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHeThong"
        Me.Text = "QUẢN LÝ KHÁCH HÀNG"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HêThôngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KhachHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiơiThiêuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbTenDN As System.Windows.Forms.ToolStripTextBox

End Class
