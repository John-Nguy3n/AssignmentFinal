Imports System.Data.SqlClient
Imports System.Data.DataTable
'Chuỗi kết nối CSDL
Public Class DangKy
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub bntDangKy_Click(sender As Object, e As EventArgs) Handles bntDangKy.Click
        'Khai báo chuỗi kết nối và thêm thông tin vào CSDL
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query As String = "Insert into Account values (@Username, @Password, @Email)"
        Dim Save As SqlCommand = New SqlCommand(Query, conn)
        Dim Email As String
        'Gán giá trị Email 
        Email = txtEmail.Text + cbbEmail.SelectedItem.ToString
        conn.Open()
        Try
            'Kiểm tra CSDL nếu trống sẽ hiện thông báo lỗi,ngược lại sẽ được lưu vào DATABASE
            If txtTaiKhoan.Text = "" Or txtEmail.Text = "" Then
                MsgBox("Điền đầy đủ thông tin trước khi đăng ký", MsgBoxStyle.Exclamation, "Thông báo")
            Else
                Save.Parameters.AddWithValue("@Username", txtTaiKhoan.Text)
                Save.Parameters.AddWithValue("@Password", txtMatKhau.Text)
                Save.Parameters.AddWithValue("@Email", Email)
                Save.ExecuteNonQuery()
                MessageBox.Show("Lưu thành công")
                txtTaiKhoan.Text = Nothing
                txtMatKhau.Text = Nothing
                txtEmail.Text = Nothing
                txtTaiKhoan.Text = Focus()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        txtTaiKhoan.Text = Nothing
        txtMatKhau.Text = Nothing
        txtEmail.Text = Nothing
    End Sub

    Private Sub bntThoat_Click(sender As Object, e As EventArgs) Handles bntThoat.Click
        'Tắn form 
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class