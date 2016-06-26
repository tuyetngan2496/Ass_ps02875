Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=Ps02875QLBH.mssql.somee.com;packet size=4096;user id=nganvttps02875_SQLLogin_1;pwd=2hm3lh3wd9;data source=Ps02875QLBH.mssql.somee.com;persist security info=False;initial catalog=Ps02875QLBH"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', Sdt as 'SĐT' from Ps02875_SP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=Ps02875QLBH.mssql.somee.com;packet size=4096;user id=nganvttps02875_SQLLogin_1;pwd=2hm3lh3wd9;data source=Ps02875QLBH.mssql.somee.com;persist security info=False;initial catalog=Ps02875QLBH"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select Ps02875_SP.MaSP as 'Mã sản phẩm',PS02875_SP.TenSP as 'Tên sản phẩm', Ps02875_LoaiSP.MaLoaiSP as 'Mã Loại', Ps02875_LoaiSP.TenLoaiSP as 'Tên Loại' from Ps02875_LoaiSP inner join Ps02875_SP on Ps02875_LoaiSP.MaLoaiSP = Ps02875_SP.MaLoaiSP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
