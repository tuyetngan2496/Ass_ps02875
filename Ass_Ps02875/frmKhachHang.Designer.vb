<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.lblKH = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lblSĐT = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.lblTimKiem = New System.Windows.Forms.Label()
        Me.cmbTimKiem = New System.Windows.Forms.ComboBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKH
        '
        Me.lblKH.AutoSize = True
        Me.lblKH.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKH.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblKH.Location = New System.Drawing.Point(188, 9)
        Me.lblKH.Name = "lblKH"
        Me.lblKH.Size = New System.Drawing.Size(220, 30)
        Me.lblKH.TabIndex = 0
        Me.lblKH.Text = "Quản Lý Khách Hàng"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKH.Location = New System.Drawing.Point(14, 62)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(95, 15)
        Me.lblMaKH.TabIndex = 1
        Me.lblMaKH.Text = "Mã Khách Hàng:"
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(118, 63)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(186, 23)
        Me.txtMAKH.TabIndex = 2
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenKH.Location = New System.Drawing.Point(14, 117)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(98, 15)
        Me.lblTenKH.TabIndex = 1
        Me.lblTenKH.Text = "Tên Khách Hàng:"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(118, 114)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(186, 23)
        Me.txtTenKH.TabIndex = 2
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaChi.Location = New System.Drawing.Point(325, 66)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(48, 15)
        Me.lblDiaChi.TabIndex = 1
        Me.lblDiaChi.Text = "Địa Chỉ:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(423, 63)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(191, 23)
        Me.txtDiaChi.TabIndex = 2
        '
        'lblSĐT
        '
        Me.lblSĐT.AutoSize = True
        Me.lblSĐT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSĐT.Location = New System.Drawing.Point(325, 117)
        Me.lblSĐT.Name = "lblSĐT"
        Me.lblSĐT.Size = New System.Drawing.Size(83, 15)
        Me.lblSĐT.TabIndex = 1
        Me.lblSĐT.Text = "Số Điện Thoại:"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(423, 117)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(191, 23)
        Me.txtSDT.TabIndex = 2
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(118, 156)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(87, 37)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(305, 158)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(87, 36)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(398, 158)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(87, 37)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Location = New System.Drawing.Point(212, 156)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(87, 38)
        Me.btnLuu.TabIndex = 3
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 255)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(600, 237)
        Me.dgv1.TabIndex = 4
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(266, 214)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(348, 23)
        Me.txtTimKiem.TabIndex = 7
        '
        'lblTimKiem
        '
        Me.lblTimKiem.AutoSize = True
        Me.lblTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimKiem.Location = New System.Drawing.Point(14, 216)
        Me.lblTimKiem.Name = "lblTimKiem"
        Me.lblTimKiem.Size = New System.Drawing.Size(119, 15)
        Me.lblTimKiem.TabIndex = 6
        Me.lblTimKiem.Text = "Tìm Kiếm Thông Tin:"
        '
        'cmbTimKiem
        '
        Me.cmbTimKiem.FormattingEnabled = True
        Me.cmbTimKiem.Items.AddRange(New Object() {"Mã Khách Hàng", "Tên Khách Hàng", "Địa Chỉ", "Số Điện Thoại"})
        Me.cmbTimKiem.Location = New System.Drawing.Point(139, 214)
        Me.cmbTimKiem.Name = "cmbTimKiem"
        Me.cmbTimKiem.Size = New System.Drawing.Size(121, 23)
        Me.cmbTimKiem.TabIndex = 5
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 508)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.lblTimKiem)
        Me.Controls.Add(Me.cmbTimKiem)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.lblSĐT)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblTenKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.lblKH)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKhachHang"
        Me.Text = "frmKhachHang"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKH As Label
    Friend WithEvents lblMaKH As Label
    Friend WithEvents txtMAKH As TextBox
    Friend WithEvents lblTenKH As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents lblDiaChi As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents lblSĐT As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents lblTimKiem As Label
    Friend WithEvents cmbTimKiem As ComboBox
End Class
