Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmHoaDon
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
        txtMaHD.Text = ""
        txtNgayXuatHD.Text = ""
        txtMaKH.Text = ""
        txtMaHD.Focus()
    End Sub
    'Load Database
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã Hóa Đơn' ,NgayXuatHD as 'Ngày Xuất HD', MaKH as 'Mã Khách Hàng' from Ps02875_HD", conn)
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
        If txtMaHD.Text = "" Then
            MessageBox.Show("Chua nhap mã Hóa Đơn")
            txtMaHD.Focus()
        ElseIf txtNgayXuatHD.Text = "" Then
            MessageBox.Show("Chua nhap Ngày Xuất Hóa Đơn")
            txtNgayXuatHD.Focus()
        ElseIf txtMaKH.Text = "" Then
            MessageBox.Show("Chua nhap Mã Khách Hàng")
            txtMaKH.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into Ps02875_HD values(@MaHD,@NgayXuatHD,@MaKH)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            save.Parameters.AddWithValue("@NgayXuatHD", txtNgayXuatHD.Text)
            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub
    'Xóa Dữ Liệu
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaHD.Text = "" Then
            MessageBox.Show("Nhap MaHD cần xóa")
            txtMaHD.Focus()
        Else
            Dim delquery As String = "delete from PS02875_HD where MaHD=@MaHD"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
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
            txtMaHD.ReadOnly = True
            btnSua.Text = "Update"
            txtNgayXuatHD.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update PS02875_HD set NgayXuatHD=@NgayXuatHD, MaKH=@MaKH where MaHD=@MaHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            save.Parameters.AddWithValue("@NgayXuatHD", txtNgayXuatHD.Text)
            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaHD.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub
    'Bảng Hiển Thị DataGridView1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Dim click As Integer = dgv1.CurrentCell.RowIndex
        txtMaHD.Text = dgv1.Item(0, click).Value
        txtNgayXuatHD.Text = dgv1.Item(1, click).Value
        txtMaKH.Text = dgv1.Item(2, click).Value
    End Sub
    'Load Dữ Liệu Tìm Kiếm
    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataTimKiem()
    End Sub
    Private Sub LoadDataTimKiem()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã Hóa Đơn' ,NgayXuatHD as 'Ngày Xuất HD', MaKH as 'Mã Khách Hàng' from Ps02875_HD", conn)
        db.Clear()
        refesh.Fill(db)
        dgv1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    'Định Nghĩa hàm Tìm Kiếm
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        SearchHoaDon(txtTimKiem.Text)
    End Sub
    Private Sub SearchHoaDon(value As String)
        Dim sqlQuery As String = String.Format("select MaHD as 'Mã Hóa Đơn' ,NgayXuatHD as 'Ngày Xuất HD', MaKH as 'Mã Khách Hàng' from Ps02875_HD")
        If cmbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaHD like '{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where NgayXuatHD LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where MaKH LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgv1.DataSource = data
        With dgv1
            .Columns(0).HeaderText = "Mã Hóa Đơn"
            .Columns(1).HeaderText = "Ngày Xuất Hóa Đơn"
            .Columns(2).HeaderText = "Mã Khách Hàng"
            .Columns(2).Width = 250
        End With
    End Sub
End Class