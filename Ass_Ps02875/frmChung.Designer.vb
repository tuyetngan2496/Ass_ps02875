<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChung))
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.lblThongTinCN = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnQLSP = New System.Windows.Forms.Button()
        Me.btnQLKH = New System.Windows.Forms.Button()
        Me.btnHoaDon = New System.Windows.Forms.Button()
        Me.btnTDWEB = New System.Windows.Forms.Button()
        Me.btmGamePlay = New System.Windows.Forms.Button()
        Me.gb1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.lblThongTinCN)
        Me.gb1.Location = New System.Drawing.Point(12, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(239, 130)
        Me.gb1.TabIndex = 0
        Me.gb1.TabStop = False
        Me.gb1.Text = "Thông tin Cá Nhân"
        '
        'lblThongTinCN
        '
        Me.lblThongTinCN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThongTinCN.Location = New System.Drawing.Point(6, 16)
        Me.lblThongTinCN.Name = "lblThongTinCN"
        Me.lblThongTinCN.Size = New System.Drawing.Size(227, 111)
        Me.lblThongTinCN.TabIndex = 0
        Me.lblThongTinCN.Text = "Tên: Võ Thị Tuyết Ngân" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mssv: Ps02875" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lớp: PT11101" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Môn: INF205-Điện Toán Đám Mâ" &
    "y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Giảng viên: Lê Văn Phụng"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnQLSP
        '
        Me.btnQLSP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQLSP.Location = New System.Drawing.Point(32, 166)
        Me.btnQLSP.Name = "btnQLSP"
        Me.btnQLSP.Size = New System.Drawing.Size(107, 35)
        Me.btnQLSP.TabIndex = 2
        Me.btnQLSP.Text = "QL Sản Phẩm"
        Me.btnQLSP.UseVisualStyleBackColor = True
        '
        'btnQLKH
        '
        Me.btnQLKH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQLKH.Location = New System.Drawing.Point(145, 166)
        Me.btnQLKH.Name = "btnQLKH"
        Me.btnQLKH.Size = New System.Drawing.Size(107, 36)
        Me.btnQLKH.TabIndex = 2
        Me.btnQLKH.Text = "QL Khách Hàng"
        Me.btnQLKH.UseVisualStyleBackColor = True
        '
        'btnHoaDon
        '
        Me.btnHoaDon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoaDon.Location = New System.Drawing.Point(32, 207)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Size = New System.Drawing.Size(107, 35)
        Me.btnHoaDon.TabIndex = 2
        Me.btnHoaDon.Text = "QL Hóa Đơn"
        Me.btnHoaDon.UseVisualStyleBackColor = True
        '
        'btnTDWEB
        '
        Me.btnTDWEB.Location = New System.Drawing.Point(146, 207)
        Me.btnTDWEB.Name = "btnTDWEB"
        Me.btnTDWEB.Size = New System.Drawing.Size(106, 35)
        Me.btnTDWEB.TabIndex = 3
        Me.btnTDWEB.Text = "WEB"
        Me.btnTDWEB.UseVisualStyleBackColor = True
        '
        'btmGamePlay
        '
        Me.btmGamePlay.Location = New System.Drawing.Point(258, 188)
        Me.btmGamePlay.Name = "btmGamePlay"
        Me.btmGamePlay.Size = New System.Drawing.Size(105, 35)
        Me.btmGamePlay.TabIndex = 4
        Me.btmGamePlay.Text = "Game"
        Me.btmGamePlay.UseVisualStyleBackColor = True
        '
        'frmChung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 257)
        Me.Controls.Add(Me.btmGamePlay)
        Me.Controls.Add(Me.btnTDWEB)
        Me.Controls.Add(Me.btnHoaDon)
        Me.Controls.Add(Me.btnQLKH)
        Me.Controls.Add(Me.btnQLSP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gb1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChung"
        Me.Text = "Quản Lý Bán Hàng"
        Me.gb1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb1 As GroupBox
    Friend WithEvents lblThongTinCN As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnQLSP As Button
    Friend WithEvents btnQLKH As Button
    Friend WithEvents btnHoaDon As Button
    Friend WithEvents btnTDWEB As Button
    Friend WithEvents btmGamePlay As Button
End Class
