Public Class frmThongKe 



    Private Sub btnDoanhThu_Click(sender As Object, e As EventArgs) Handles btnDoanhThu.Click
        frmDoanhThu.MdiParent = frmMainform
        frmDoanhThu.Show()
        frmDoanhThu.BringToFront()
    End Sub

    Private Sub btnchiphi_click(sender As Object, e As EventArgs) Handles btnChiPhi.Click
        frmChiPhi.MdiParent = frmMainform
        frmChiPhi.Show()
        frmChiPhi.BringToFront()
    End Sub

    Private Sub btnSach_click(sender As Object, e As EventArgs) Handles btnSach.Click
        frmThongKeSach.MdiParent = frmMainform
        frmThongKeSach.Show()
        frmThongKeSach.BringToFront()

    End Sub


    Private Sub btnThanhVien_Click(sender As Object, e As EventArgs) Handles btnThanhVien.Click
        frmThongKeTV.MdiParent = frmMainform
        frmThongKeTV.Show()
        frmThongKeTV.BringToFront()
    End Sub



    Private Sub btntonkho_Click(sender As Object, e As EventArgs) Handles btntonkho.Click
        frmThongKeTonKho1.MdiParent = frmMainform
        frmThongKeTonKho1.Show()
        frmThongKeTonKho1.BringToFront()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class