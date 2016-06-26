Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmKhachHang
    'Kết Nối Database
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Ps02875QLBH.mssql.somee.com;packet size=4096;user id=nganvttps02875_SQLLogin_1;pwd=2hm3lh3wd9;data source=Ps02875QLBH.mssql.somee.com;persist security info=False;initial catalog=Ps02875QLBH"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    'Thêm Dữ Liệu
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Reset()
    End Sub
    Private Sub reset()
        txtMAKH.Text = ""
        txtTenKH.Text = ""
        txtDiaChi.Text = ""
        txtSDT.Text = ""
        txtMAKH.Focus()
    End Sub
    'Load Database
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa Chỉ', Sdt as 'Số Điện Thoại' from PS02875_KH", conn)
        db.Clear()
        refesh.Fill(db)
        dgv1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    'Lưu Dữ Liệu
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("Chua nhap mã Khách Hàng")
            txtTenKH.Focus()
        ElseIf txtTenKH.Text = "" Then
            MessageBox.Show("Chua nhap Tên Khách Hàng")
            txtTenKH.Focus()
        ElseIf txtDiaChi.Text = "" Then
            MessageBox.Show("Chua nhap Địa Chỉ")
            txtDiaChi.Focus()
        ElseIf txtSDT.Text = "" Then
            MessageBox.Show("Chua nhap Số Điện Thoại")
            txtSDT.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into Ps02875_KH values(@MAKH,@TENKH,@DIACHI,@SDT)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTenKH.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text)
            save.Parameters.AddWithValue("@SDT", txtSDT.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub
    'Xóa Dữ Liệu
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("Nhap MaKH cần xóa")
            txtMAKH.Focus()
        Else
            Dim delquery As String = "delete from PS02875_KH where MaKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
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
            txtMAKH.ReadOnly = True
            btnSua.Text = "Update"
            txtTenKH.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update Ps02875_KH set TenKH=@TENKH, DiaChi=@DIACHI, Sdt=@SDT where MaKH=@MAKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTenKH.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text)
            save.Parameters.AddWithValue("@SDT", txtSDT.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMAKH.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub
    'Bảng Hiển Thị DataGridView1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Dim click As Integer = dgv1.CurrentCell.RowIndex
        txtMAKH.Text = dgv1.Item(0, click).Value
        txtTenKH.Text = dgv1.Item(1, click).Value
        txtDiaChi.Text = dgv1.Item(2, click).Value
        txtSDT.Text = dgv1.Item(3, click).Value
    End Sub
    'Load Dữ Liệu Tìm Kiếm
    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataTimKiem()
    End Sub
    Private Sub LoadDataTimKiem()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa Chỉ', Sdt as 'Số Điện Thoại' from Ps02875_KH", conn)
        db.Clear()
        refesh.Fill(db)
        dgv1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    'Định Nghĩa hàm Tìm Kiếm
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        SearchKhachHang(txtTimKiem.Text)
    End Sub
    Private Sub SearchKhachHang(value As String)
        Dim sqlQuery As String = String.Format("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa Chỉ', Sdt as 'Số Điện Thoại' from Ps02875_KH")
        If cmbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaKH like '{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TenKH LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where DiaChi LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where Sdt LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgv1.DataSource = data
        With dgv1
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Địa Chỉ"
            .Columns(3).HeaderText = "Số Điện Thoại"
            .Columns(3).Width = 250
        End With
    End Sub
End Class