Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCapNhatKH
    Dim noiluu As String = Application.StartupPath & "\data\hinh\KhachHang\"
    Dim tenhinh As String
    Dim duongdan As String
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update NHAN_VIEN_PS03423 set MaKH=@MaKH, TenKH=@TenKH,DienThoai=@DienThoai, CMND=@CMND DiaChi=@DiaChi, Email=@Email  where MaKH=@MaKh"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        'Try
        txtMaKH.Focus()
        If txtMaKH.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            txtMaKH.Focus()
            If txtTenKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtCMND.Focus()
                If txtCMND.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập số CMND", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtDienThoai.Focus()
                    If txtDienThoai.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDienThoai.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtEmail.Focus()
                        Else
                            addupdate.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                            addupdate.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                            addupdate.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)
                            addupdate.Parameters.AddWithValue("@CMND", txtCMND.Text)
                            addupdate.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                            addupdate.Parameters.AddWithValue("@Email", txtEmail.Text)
                            addupdate.ExecuteNonQuery()
                            Try 'nếu không lựa chọn hình ảnh thì bỏ qua
                                If System.IO.File.Exists(noiluu & txtMaKH.Text & ".jpg") Then ' nếu đã có ảnh tồn tại vs tên đó thì tự xóa và chép mới
                                    Kill(noiluu & txtMaKH.Text & ".jpg")
                                    FileCopy(duongdan, noiluu & tenhinh & "1")
                                    Rename(noiluu & tenhinh & "1", noiluu & txtMaKH.Text & ".jpg")
                                Else
                                    FileCopy(duongdan, noiluu & tenhinh & "1")
                                    Rename(noiluu & tenhinh & "1", noiluu & txtMaKH.Text & ".jpg")
                                End If
                            Catch ex As Exception
                            End Try 'co chinh ji dau . neu tu them khoang trang thi` la do insert du~ lieu vao`
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtMaKH.Text = Nothing
                            txtTenKH.Text = Nothing
                            txtDienThoai.Text = Nothing
                            txtCMND.Text = Nothing
                            txtDiaChi.Text = Nothing
                            txtEmail.Text = Nothing
                        End If
                    End If
                End If
            End If
        End If

        'Catch ex As Exception
        ' MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        'End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DienThoai as 'Điện thoại',CMND as 'CMND',  DiaChi as 'Địa chỉ', Email from KHACHHANG_PS03423", conn)
        db.Clear()
        refesh.Fill(db)
        frmThongTinKH.dgvHienThi.DataSource = db.DefaultView
    End Sub

    Private Sub ptbHinhAnh_Click(sender As Object, e As EventArgs) Handles ptbHinhAnh.Click

    End Sub

    Private Sub btnHinhAnh_Click(sender As Object, e As EventArgs) Handles btnHinhAnh.Click
        Dim hinhanh As New OpenFileDialog
        'điều kiện để lấy file
        If hinhanh.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            duongdan = hinhanh.FileName
            If duongdan.EndsWith(".jpg") Then
                tenhinh = hinhanh.FileName.Substring(hinhanh.FileName.LastIndexOf("\") + 1)
            Else
                MessageBox.Show("Chỉ cho phép file JPG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                hinhanh.FileName = Nothing
                duongdan = Nothing
            End If
        End If
        'hiển thị ảnh vừa chọn lên khung hình sua ket noi di
        Dim image As Image
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(duongdan, IO.FileMode.Open, IO.FileAccess.Read)
        image = System.Drawing.Image.FromStream(fs)
        fs.Close()
        ptbHinhAnh.BackgroundImage = image
    End Sub

    Private Sub frmCapNhatKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDienThoai_TextChanged(sender As Object, e As EventArgs) Handles txtDienThoai.TextChanged

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmThongTinKH.Show()
        Me.Close()
    End Sub
End Class