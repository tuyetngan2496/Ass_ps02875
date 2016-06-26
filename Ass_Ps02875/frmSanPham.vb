Imports System.Data.SqlClient
Imports System.Data.DataTable


Public Class frmSanPham
    'Kết Nối Database
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Ps02875QLBH.mssql.somee.com;packet size=4096;user id=nganvttps02875_SQLLogin_1;pwd=2hm3lh3wd9;data source=Ps02875QLBH.mssql.somee.com;persist security info=False;initial catalog=Ps02875QLBH"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    'Thêm Dữ Liệu
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub
    Private Sub reset()
        txtDongia.Text = ""
        txtMaSP.Text = ""
        txtMaloai.Text = ""
        txtTenSP.Text = ""
        txtMaSP.Focus()
    End Sub
    'Load Database
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã Sản Phẩm' ,TenSP as 'Tên Sản phẩm', DonGia as 'Đơn giá', MaLoaiSP as 'Mã Loại SP' from Ps02875_SP", conn)
        db.Clear()
        refesh.Fill(db)
        dgv1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    ' Lưu Dữ Liệu
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Chua nhap mã sản phẩm")
            txtMaSP.Focus()
        ElseIf txtTenSP.Text = "" Then
            MessageBox.Show("Chua nhap Tên sản phẩm")
            txtTenSP.Focus()
        ElseIf txtMaloai.Text = "" Then
            MessageBox.Show("Chua nhap Mã loại")
            txtMaloai.Focus()
        ElseIf txtDongia.Text = "" Then
            MessageBox.Show("Chua nhap đơn giá")
            txtDongia.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into Ps02875_SP values(@MaSP,@TenSP,@DonGia,@MaLoaiSP)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@DonGia", txtDongia.Text)
            save.Parameters.AddWithValue("@MaLoaiSP", txtMaloai.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub
    'Xóa Dữ Liệu
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Nhap MaSP cần xóa")
            txtMaSP.Focus()
        Else
            Dim delquery As String = "delete from PS02875_SP where MaSP=@MaSP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub
    'Sửa Dữ Liệu
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaSP.ReadOnly = True
            btnSua.Text = "Update"
            txtTenSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update PS02875_SP set TenSP=@TenSP, DonGia=@DONGIA, MaLoaiSP=@MaLoaiSP where MaSP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@MaLoaiSP", txtMaloai.Text)
            save.Parameters.AddWithValue("@DonGia", txtDongia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaSP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub
    'Bảng Hiển Thị DataGridView1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Dim click As Integer = dgv1.CurrentCell.RowIndex
        txtMaSP.Text = dgv1.Item(0, click).Value
        txtTenSP.Text = dgv1.Item(1, click).Value
        txtDongia.Text = dgv1.Item(2, click).Value
        txtMaloai.Text = dgv1.Item(3, click).Value
    End Sub
    'Load Dữ Liệu Tìm Kiếm
    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataTimKiem()
    End Sub
    Private Sub LoadDataTimKiem()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã Sản Phẩm' ,TenSP as 'Tên Sản Phẩm', DonGia as 'Đơn Giá', MaLoaiSP as 'Mã Loại SP' from Ps02875_SP", conn)
        db.Clear()
        refesh.Fill(db)
        dgv1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    'Định Nghĩa hàm Tìm Kiếm
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        SearchSanPham(txtTimKiem.Text)
    End Sub
    Private Sub SearchSanPham(value As String)
        Dim sqlQuery As String = String.Format("select MaSP as 'Mã Sản Phẩm' ,TenSP as 'Tên Sản Phẩm', DonGia as 'Đơn Giá', MaLoaiSP as 'Mã Loại SP' from Ps02875_SP")
        If cmbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaSP like '{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TenSP LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where DonGia LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where MaLoaiSP LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgv1.DataSource = data
        With dgv1
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Tên Sản Phẩm"
            .Columns(2).HeaderText = "Đơn Giá"
            .Columns(3).HeaderText = "Mã Loại"
            .Columns(3).Width = 250
        End With
    End Sub
End Class