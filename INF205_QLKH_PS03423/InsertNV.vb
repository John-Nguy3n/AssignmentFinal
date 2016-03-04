Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmInsertNV
    Dim noiluu As String = Application.StartupPath & "\data\hinh\NhanVien\"
    Dim tenhinh As String
    Dim duongdan As String
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
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
        'hiển thị ảnh vừa chọn lên khung hình no noi bo nho' 
        Dim image As Image
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(duongdan, IO.FileMode.Open, IO.FileAccess.Read)
        image = System.Drawing.Image.FromStream(fs)
        fs.Close()
        ptbHinhAnh.BackgroundImage = image
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "Insert into NHAN_VIEN_PS03423 values (@MaNV,@Ten,@GioiTinh,@DienThoai,@DiaChi,@MoTaThem,@NgaySinh)"
        Dim Save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        ' Try
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
                                    Save.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
                                    Save.Parameters.AddWithValue("@Ten", txtTenNV.Text)
                                    Save.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
                                    Save.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text)
                                    Save.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)
                                    Save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                                    Save.Parameters.AddWithValue("@MoTaThem", txtMoTaThem.Text)
                                    MessageBox.Show(txtMaNV.Text.Count)
                                    Save.ExecuteNonQuery()
                                    'chép file ảnh vào thư mục
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
                                    End Try
                                    MessageBox.Show("Cập nhật thành công")
                                    conn.Close() '("Cập nhật thành công")
                                    txtMaNV.Text = Nothing
                                    txtTenNV.Text = Nothing
                                    txtGioiTinh.Text = Nothing
                                    dtpNgaySinh.Value = Today
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

        'Catch ex As Exception  'Ngược lại báo lỗi
        ' MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        ' End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaNV as 'Mã nhân viên',Ten as 'Tên nhân viên',GioiTinh as 'Giới tính',DienThoai as 'Điện thoại',DiaChi as 'Địa chỉ',MoTaThem as 'Mô tả thêm' ,NgaySinh as 'Ngày sinh' from NHAN_VIEN_PS03423", conn)
        db.Clear()
        refesh.Fill(db)
        frmThongTinNV.dgvHienThi.DataSource = db.DefaultView
    End Sub

    Private Sub frmInsertNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmThongTinNV.Show()
        Me.Close()
    End Sub
End Class