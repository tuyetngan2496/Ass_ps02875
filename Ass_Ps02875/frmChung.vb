Public Class frmChung
    Private Sub btnQLSP_Click(sender As Object, e As EventArgs) Handles btnQLSP.Click
        frmSanPham.Show()
    End Sub

    Private Sub btnQLKH_Click(sender As Object, e As EventArgs) Handles btnQLKH.Click
        frmKhachHang.Show()
    End Sub

    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        frmHoaDon.Show()
    End Sub

    Private Sub btnTDWEB_Click(sender As Object, e As EventArgs) Handles btnTDWEB.Click
        frmWeb.Show()
    End Sub

    Private Sub btmGamePlay_Click(sender As Object, e As EventArgs) Handles btmGamePlay.Click
        frmGame.Show()
    End Sub
End Class
