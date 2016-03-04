Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmLogin
    'Khai báo biến toàn cục để kết nối với SQL
    Private _Connectionstring As String = ConfigurationSettings.AppSettings("MyConnectionString")
    Private conn As SqlConnection
    Private da As SqlDataAdapter
    'Định nghĩa hàm trả vào bảng
    Private Function getDataTable(sqlQuery As String) As DataTable
        Dim DTable As New DataTable
        'Khởi tạo các biến conn
        conn = New SqlConnection(_Connectionstring)
        'Khởi tạo biến da
        da = New SqlDataAdapter(sqlQuery, conn)
        Try
            'Mở chuỗi kết nối
            conn.Open()
            'Thêm dữ liệu vào
            da.Fill(DTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lỗi")  'Thông báo lỗi 
        Finally
            conn.Close()        'Đóng chuỗi kết nối
        End Try
        Return DTable
    End Function
    'Định nghĩa hàm kiểm tra dữ liệu
    Private Function Kiemtra(user As String, pass As String)
        Dim sqlQuery As String = String.Format("select * from dbo.Account where Username = '{0}' and Password = '{1}'", user, pass)
        Dim Dtable As DataTable = getDataTable(sqlQuery)
        Return Dtable.Rows.Count > 0
    End Function
    'Kiểm tra hàm có rỗng hay không
    Private Function Trong() As Boolean
        'Hàm kiểm tra dữ liệu nhập vào
        Return String.IsNullOrEmpty(Me.txtTaiKhoan.Text) OrElse String.IsNullOrEmpty(Me.txtMatKhau.Text)
    End Function

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'Kiểm tra 
        If Trong() Then
            MsgBox("Tài khoản và mật khẩu không được bỏ trống", MsgBoxStyle.Exclamation, "Thông báo")
        Else
            If txtTaiKhoan.Text = "admin" And txtMatKhau.Text = "admin" Then
                'Me.Close()
                frmHeThong.tsbTenDN.Text = txtTaiKhoan.Text

                MessageBox.Show("Đăng nhâp thành công")
                frmHeThong.Show() 'User thường ko vào được phần đó :))
            Else
                If Kiemtra(Me.txtTaiKhoan.Text.ToLower, Me.txtMatKhau.Text.ToLower) And txtTaiKhoan.Text <> "admin" Then  'Kiểm tra đúng sai trong CSDL
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    MessageBox.Show("Đăng nhâp thành công")
                    frmHeThong.tsbTenDN.Text = txtTaiKhoan.Text
                    frmHeThong.Show()
                Else
                    MsgBox("Tài khoản hoặc mật khẩu không đúng", MsgBoxStyle.Exclamation, "Thông báo")
                End If
            End If
        End If
    End Sub

    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnDangKy_Click_1(sender As Object, e As EventArgs) Handles btnDangKy.Click
        DangKy.Show()
    End Sub
End Class