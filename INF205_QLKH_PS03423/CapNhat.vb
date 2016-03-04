Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCapNhat
    Dim noiluu As String = Application.StartupPath & "\data\hinh\NhanVien\"
    Dim tenhinh As String
    Dim duongdan As String
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"

    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)


    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update NHAN_VIEN_PS03423 set MaNV=@MaNV, Ten=@Ten, GioiTinh=@GioiTinh, DienThoai=@DienThoai, DiaChi=@DiaChi, MoTaThem=@MoTaThem, NgaySinh=@NgaySinh where MaNV=@MaNV"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaNV.Focus()
            If txtMaNV.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaNV.Focus()
                If txtTenNV.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenNV.Focus()
                    If txtGioiTinh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtGioiTinh.Focus()
                        If dtpNgaySinh.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập ngày sinh", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            dtpNgaySinh.Focus()
                            If txtDienThoai.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtDienThoai.Focus()
                                If txtDiaChi.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    txtDiaChi.Focus()
                                    If txtMoTaThem.Text = "" Then
                                        MessageBox.Show("Bạn chưa nhập mô tả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                    Else
                                        addupdate.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
                                        addupdate.Parameters.AddWithValue("@Ten", txtTenNV.Text)
                                        addupdate.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
                                        addupdate.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text)
                                        addupdate.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)
                                        addupdate.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                                        addupdate.Parameters.AddWithValue("@MoTaThem", txtMoTaThem.Text)
                                        addupdate.ExecuteNonQuery()
                                        Try 'nếu không lựa chọn hình ảnh thì bỏ qua
                                            If System.IO.File.Exists(noiluu & txtMaNV.Text & ".jpg") Then ' nếu đã có ảnh tồn tại vs tên đó thì tự xóa và chép mới
                                                Kill(noiluu & txtMaNV.Text & ".jpg")
                                                FileCopy(duongdan, noiluu & tenhinh & "1")
                                                Rename(noiluu & tenhinh & "1", noiluu & txtMaNV.Text & ".jpg")
                                            Else
                                                FileCopy(duongdan, noiluu & tenhinh & "1")
                                                Rename(noiluu & tenhinh & "1", noiluu & txtMaNV.Text & ".jpg")
                                            End If
                                        Catch ex As Exception
                                        End Try 'co chinh ji dau . neu tu them khoang trang thi` la do insert du~ lieu vao`
                                        conn.Close() 'đóng kết nối
                                        MessageBox.Show("Cập nhật thành công")
                                        txtMaNV.Text = Nothing
                                        txtTenNV.Text = Nothing
                                        txtGioiTinh.Text = Nothing
                                        dtpNgaySinh.Text = Nothing
                                        txtDienThoai.Text = Nothing
                                        txtDiaChi.Text = Nothing
                                        txtMoTaThem.Text = Nothing
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        frmThongTinNV.dgvHienThi.DataSource = db
        frmThongTinNV.dgvHienThi.DataSource = Nothing
        LoadData()
        
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter(" select MaNV as 'Mã nhân viên',Ten as 'Tên nhân viên',GioiTinh as 'Giới tính',DienThoai as 'Điện thoại',DiaChi as 'Địa chỉ',MoTaThem as 'Mô tả thêm' ,NgaySinh as 'Ngày sinh' from NHAN_VIEN_PS03423", conn)

        conn.Open()
        load.Fill(db)
        frmThongTinNV.dgvHienThi.DataSource = db.DefaultView
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

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmThongTinNV.Show()
        Me.Close()
    End Sub
End Class