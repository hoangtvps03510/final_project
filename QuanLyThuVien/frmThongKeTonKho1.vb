Public Class frmThongKeTonKho1

    Private Sub frmThongKeTonKho1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnTinh1_Click(sender As Object, e As EventArgs) Handles btnTinh.Click
        frmThongKeTonKho.Close()
        frmThongKeTonKho.MdiParent = frmMainform

        frmThongKeTonKho.Show()
        frmThongKeTonKho.BringToFront()


    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        frmThongKeTonKho.Close()

    End Sub
End Class