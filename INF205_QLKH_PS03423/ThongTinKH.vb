Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmThongTinKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim makh As String
    Private Sub bntThem_Click(sender As Object, e As EventArgs) Handles bntThem.Click
        frmInsertKH.Show()
        Me.Hide()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        frmCapNhatKH.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTimkiem.SelectedIndexChanged

    End Sub

  

    Private Sub frmThongTinKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Hienthi As New Load
        dgvHienThi.DataSource = Hienthi.Loadkhachang.Tables(0)
        If frmHeThong.tsbTenDN.Text <> "admin" Then
            btnCapNhat.Hide()
            btnXoa.Hide()
            bntThem.Hide()
        End If
    End Sub

    Private Sub dgvHienThi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHienThi.CellContentClick
        Dim click As Integer = dgvHienThi.CurrentCell.RowIndex
        frmCapNhatKH.txtMaKH.Text = dgvHienThi.Item(0, click).Value
        frmCapNhatKH.txtTenKH.Text = dgvHienThi.Item(1, click).Value
        frmCapNhatKH.txtCMND.Text = dgvHienThi.Item(3, click).Value
        frmCapNhatKH.txtEmail.Text = dgvHienThi.Item(5, click).Value
        frmCapNhatKH.txtDiaChi.Text = dgvHienThi.Item(4, click).Value

        Makh = dgvHienThi.Item(0, click).Value
        'MessageBox.Show(Application.StartupPath & "\data\hinh\" & manv & ".jpg")
        Dim image As Image
        Dim fs As System.IO.FileStream
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\KhachHang\" & makh & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            frmCapNhat.ptbHinhAnh.BackgroundImage = image
        Catch ex As Exception
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\KhachHang\HinhKH.jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            frmCapNhat.ptbHinhAnh.BackgroundImage = image
        End Try
        click = Nothing
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Try
            If cbbTimkiem.Text = "Mã khách hàng" Then
                Dim sql As String = "select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', CMND as 'CMND', DienThoai as 'SDT', DiaChi as 'Địa chỉ', Email from KHACHHANG_PS03423 where MaKH like  '%" & txtTimKiem.Text & "%' "
                conn.Open()
                Dim timkiem As SqlDataAdapter = New SqlDataAdapter(sql, conn)
                dgvHienThi.DataSource = db.DefaultView
                db.Clear()
                timkiem.Fill(db)
                conn.Close()
            End If
            If cbbTimkiem.Text = "Tên khách hàng" Then
                Dim sql As String = "select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', CMND as 'CMND', DienThoai as 'SDT', DiaChi as 'Địa chỉ', Email from KHACHHANG_PS03423 where TenKH like  '%" & txtTimKiem.Text & "%' "
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

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from KHACHHANG_PS03423 where MaKH=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        ' Try
        If resulft = Windows.Forms.DialogResult.Yes Then
            delete.Parameters.AddWithValue("@MaKH", makh)
            delete.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Xóa thành công")
        End If
        'Catch ex As Exception
        'MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        '  End Try
        'làm mới bảng
        frmThongTinKH_Load(Nothing, Nothing)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmHeThong.Show()
        Me.Close()
    End Sub
End Class