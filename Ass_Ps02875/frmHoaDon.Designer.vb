<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.lblTimKiem = New System.Windows.Forms.Label()
        Me.cmbTimKiem = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtNgayXuatHD = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(261, 163)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(275, 20)
        Me.txtTimKiem.TabIndex = 28
        '
        'lblTimKiem
        '
        Me.lblTimKiem.AutoSize = True
        Me.lblTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimKiem.Location = New System.Drawing.Point(9, 165)
        Me.lblTimKiem.Name = "lblTimKiem"
        Me.lblTimKiem.Size = New System.Drawing.Size(119, 15)
        Me.lblTimKiem.TabIndex = 27
        Me.lblTimKiem.Text = "Tìm Kiếm Thông Tin:"
        '
        'cmbTimKiem
        '
        Me.cmbTimKiem.FormattingEnabled = True
        Me.cmbTimKiem.Items.AddRange(New Object() {"Mã Hóa Đơn", "Ngày Xuất HD", "Mã Khách Hàng"})
        Me.cmbTimKiem.Location = New System.Drawing.Point(134, 163)
        Me.cmbTimKiem.Name = "cmbTimKiem"
        Me.cmbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cmbTimKiem.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(183, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Quản Lý Hóa Đơn"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 190)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(528, 183)
        Me.dgv1.TabIndex = 25
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(306, 103)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(89, 37)
        Me.btnLuu.TabIndex = 24
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(401, 60)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(89, 37)
        Me.btnXoa.TabIndex = 22
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(401, 99)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(89, 37)
        Me.btnSua.TabIndex = 23
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(306, 60)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(89, 37)
        Me.btnThem.TabIndex = 20
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ngày Xuất HD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mã Khách Hàng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Mã Hóa Đơn:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(103, 125)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(152, 20)
        Me.txtMaKH.TabIndex = 18
        '
        'txtNgayXuatHD
        '
        Me.txtNgayXuatHD.Location = New System.Drawing.Point(103, 92)
        Me.txtNgayXuatHD.Name = "txtNgayXuatHD"
        Me.txtNgayXuatHD.Size = New System.Drawing.Size(152, 20)
        Me.txtNgayXuatHD.TabIndex = 17
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(103, 63)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(152, 20)
        Me.txtMaHD.TabIndex = 12
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 388)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.lblTimKiem)
        Me.Controls.Add(Me.cmbTimKiem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtNgayXuatHD)
        Me.Controls.Add(Me.txtMaHD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHoaDon"
        Me.Text = "Quản Lý Hóa Đơn"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents lblTimKiem As Label
    Friend WithEvents cmbTimKiem As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtNgayXuatHD As TextBox
    Friend WithEvents txtMaHD As TextBox
End Class
