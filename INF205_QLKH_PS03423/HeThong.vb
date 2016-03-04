Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmHeThong
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03423.mssql.somee.com;packet size=4096;user id=PS03423_SQLLogin_1;pwd=ewt4p8vvdl;data source=PS03423.mssql.somee.com;persist security info=False;initial catalog=PS03423"

    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub HeThong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New DataTable
        Dim chuoiketnoi As String = "workstation id=PS03423.mssql.somee.com;packet size=4096;user id=PS03423_SQLLogin_1;pwd=ewt4p8vvdl;data source=PS03423.mssql.somee.com;persist security info=False;initial catalog=PS03423"

        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'btnXoa.Enabled = False
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', CMND as 'CMND', DienThoai as 'SDT', DiaChi as 'Địa chỉ', Email from KHACHHANG_PS03423", conn)

        conn.Open()
        load.Fill(db)
        'dgvHienThi.DataSource = db.DefaultView
    End Sub


    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        frmThongTinNV.Show()
        Me.Hide()
    End Sub

    Private Sub ThêmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmToolStripMenuItem.Click
    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        frmThongTinKH.Show()
        Me.Hide()
    End Sub

    Private Sub tsbTrangThai_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ThoatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
