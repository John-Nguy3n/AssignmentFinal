Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmInsertKH
    Dim noiluu As String = Application.StartupPath & "\data\hinh\KhachHang\"
    Dim tenhinh As String
    Dim duongdan As String
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG_PS03423 values(@MaKH,@TenKH,@DiaChi,@Email,@DienThoai,@CMND)"
        Dim Save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
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
                                Save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                                Save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                                Save.Parameters.AddWithValue("@CMND", txtCMND.Text)
                                Save.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text)
                                Save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                                Save.Parameters.AddWithValue("@Email", txtEmail.Text)
                                Save.ExecuteNonQuery()
                                'chép file ảnh vào thư mục
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
                                End Try
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtCMND.Text = Nothing
                                txtDienThoai.Text = Nothing
                                txtDiaChi.Text = Nothing
                                txtEmail.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try


        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', CMND as 'CMND', DienThoai as 'Số điện thoại', DiaChi as 'Địa chỉ', Email from KHACHHANG_PS03423", conn)
        db.Clear()
        refesh.Fill(db)
        frmThongTinKH.dgvHienThi.DataSource = db.DefaultView
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
        'hiển thị ảnh vừa chọn lên khung hình no noi bo nho' 
        Dim image As Image
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(duongdan, IO.FileMode.Open, IO.FileAccess.Read)
        image = System.Drawing.Image.FromStream(fs)
        fs.Close()
        ptbHinhAnh.BackgroundImage = image
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmThongTinKH.Show()
        Me.Close()
    End Sub
End Class