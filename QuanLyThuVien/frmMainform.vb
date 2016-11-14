Public Class frmMainform
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btnQuanLy.Click
        frmQuanLy.MdiParent = Me
        frmQuanLy.Show()
        frmQuanLy.BringToFront()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        frmThongKe.MdiParent = Me
        frmThongKe.Show()
        frmThongKe.BringToFront()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnMuonSach.Click
        frmPhieuMuonSach.MdiParent = Me
        frmPhieuMuonSach.Show()
        frmPhieuMuonSach.BringToFront()
    End Sub


    Private Sub frmMainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.MdiParent = Me
        frmLogin.Show()
        frmLogin.BringToFront()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDangNhap.ItemClick
        If btnDangNhap.Caption = "Đăng nhập" Then
            frmLogin.MdiParent = Me
            frmLogin.Show()
            frmLogin.BringToFront()
        Else
            Dim frmcon As Form
            btnNguoiDung.Caption = "User name"
            btnMuonSach.Enabled = False
            btnQuanLy.Enabled = False
            btnThongKe.Enabled = False
            btnTraSach.Enabled = False
            For Each frmcon In Me.MdiChildren
                frmcon.Close()
            Next
            btnDangNhap.Caption = "Đăng nhập"
            btnNguoiDung.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnTraSach.Click
        frmPhieuTraSach.MdiParent = Me
        frmPhieuTraSach.Show()
        frmPhieuTraSach.BringToFront()
    End Sub

    Private Sub btnNguoiDung_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNguoiDung.ItemClick
        frmDoiMatKhau.Show()
        frmDoiMatKhau.BringToFront()
        frmDoiMatKhau.txtTenDangNhap.Text = btnNguoiDung.Caption
    End Sub
End Class