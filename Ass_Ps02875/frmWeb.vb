Public Class frmWeb
    Private Web As New Collection

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        WebBrowser1.Navigate(txtSearch.Text)
    End Sub
    Private Sub frmWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Web.Add(txtSearch.Text)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        WebBrowser1.Refresh()
    End Sub
End Class