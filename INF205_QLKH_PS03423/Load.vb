Imports System.Data.SqlClient
Imports System.Data
Public Class Load
    Public Function LoadNhanvien() As DataSet
        Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadNV As New SqlDataAdapter("select MaNV as 'Mã nhân viên',Ten as 'Tên nhân viên',GioiTinh as 'Giới tính',DienThoai as 'Điện thoại',DiaChi as 'Địa chỉ',MoTaThem as 'Mô tả thêm' ,NgaySinh as 'Ngày sinh' from NHAN_VIEN_PS03423", conn)
        Dim db As New DataSet
        conn.Open()
        LoadNV.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=PS03423_QLKH;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', CMND as 'CMND', DienThoai as 'SDT', DiaChi as 'Địa chỉ', Email from KHACHHANG_PS03423", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
