Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmThongTinNV
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim manv As String
    Private Sub bntThem_Click(sender As Object, e As EventArgs) Handles bntThem.Click
        frmInsertNV.Show()
        Me.Hide()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        frmCapNhat.Show()
        Me.Hide()
    End Sub

    Private Sub frmThongTinNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Hienthi As New Load
        dgvHienThi.DataSource = Hienthi.LoadNhanvien.Tables(0)
        If frmHeThong.tsbTenDN.Text <> "admin" Then
            btnCapNhat.Hide()
            btnXoa.Hide()
            bntThem.Hide()
        End If
    End Sub

    Private Sub dgvHienThi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHienThi.CellContentClick
        Dim click As Integer = dgvHienThi.CurrentCell.RowIndex
        frmCapNhat.txtMaNV.Text = dgvHienThi.Item(0, click).Value
        frmCapNhat.txtTenNV.Text = dgvHienThi.Item(1, click).Value
        frmCapNhat.txtGioiTinh.Text = dgvHienThi.Item(2, click).Value
        frmCapNhat.txtDienThoai.Text = dgvHienThi.Item(3, click).Value
        frmCapNhat.txtDiaChi.Text = dgvHienThi.Item(4, click).Value
        frmCapNhat.txtMoTaThem.Text = dgvHienThi.Item(5, click).Value
        frmCapNhat.dtpNgaySinh.Text = dgvHienThi.Item(6, click).Value
        manv = dgvHienThi.Item(0, click).Value
        'MessageBox.Show(Application.StartupPath & "\data\hinh\" & manv & ".jpg")
        Dim image As Image
        Dim fs As System.IO.FileStream
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\NhanVien\" & manv & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            frmCapNhat.ptbHinhAnh.BackgroundImage = image
        Catch ex As Exception
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\NhanVien\HinhNV.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            frmCapNhat.ptbHinhAnh.BackgroundImage = image
        End Try
        click = Nothing
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from NHAN_VIEN_PS03423 where MaNV=@MaNV"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If resulft = Windows.Forms.DialogResult.Yes Then
                delete.Parameters.AddWithValue("@MaNV", manv)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")

            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng

        frmThongTinNV_Load(Nothing, Nothing)
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Try
            If cbbTimkiem.Text = "Mã nhân viên" Then
                Dim sql As String = "select MaNV as 'Mã nhân viên',Ten as 'Tên nhân viên',GioiTinh as 'Giới tính',DienThoai as 'Điện thoại',DiaChi as 'Địa chỉ',MoTaThem as 'Mô tả thêm' ,NgaySinh as 'Ngày sinh' from NHAN_VIEN_PS03423 where MaNV like  '%" & txtTimKiem.Text & "%' "
                conn.Open()
                Dim timkiem As SqlDataAdapter = New SqlDataAdapter(sql, conn)
                dgvHienThi.DataSource = db.DefaultView
                db.Clear()
                timkiem.Fill(db)
                conn.Close()
            End If
            If cbbTimkiem.Text = "Tên nhân viên" Then
                Dim sql As String = "select MaNV as 'Mã nhân viên',Ten as 'Tên nhân viên',GioiTinh as 'Giới tính',DienThoai as 'Điện thoại',DiaChi as 'Địa chỉ',MoTaThem as 'Mô tả thêm' ,NgaySinh as 'Ngày sinh' from NHAN_VIEN_PS03423 where Ten like  '%" & txtTimKiem.Text & "%' "
                conn.Open()
                Dim timkiem As SqlDataAdapter = New SqlDataAdapter(sql, conn)
                dgvHienThi.DataSource = db.DefaultView
                db.Clear()
                timkiem.Fill(db)
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Không tìm thấy dữ liệu")
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmHeThong.Show()
        Me.Close()
    End Sub
End Class