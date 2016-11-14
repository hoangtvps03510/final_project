Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanLy

    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)

    Private Sub btnQuanLySach_Click(sender As Object, e As EventArgs) Handles btnQuanLySach.Click
        frmQuanLySach.MdiParent = frmMainform
        frmQuanLySach.Show()
        frmQuanLySach.BringToFront()
    End Sub

    Private Sub btnQuanLyTV_Click(sender As Object, e As EventArgs) Handles btnQuanLyTV.Click
        frmQuanLyTV.MdiParent = frmMainform
        frmQuanLyTV.Show()
        frmQuanLyTV.BringToFront()
    End Sub

    Private Sub btnQuanLyNV_Click(sender As Object, e As EventArgs) Handles btnQuanLyNV.Click
        frmQuanLyNV.MdiParent = frmMainform
        frmQuanLyNV.Show()
        frmQuanLyNV.BringToFront()
    End Sub

    Private Sub btnQuanLyTG_Click(sender As Object, e As EventArgs) Handles btnQuanLyTG.Click
        frmQuanLyTG.MdiParent = frmMainform
        frmQuanLyTG.Show()
        frmQuanLyTG.BringToFront()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btnQuanLyNXB.Click
        frmQuanLyNXB.MdiParent = frmMainform
        frmQuanLyNXB.Show()
        frmQuanLyNXB.BringToFront()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles btnQuanLyKeSach.Click
        FrmQuanLyKe.MdiParent = frmMainform
        FrmQuanLyKe.Show()
        FrmQuanLyKe.BringToFront()
    End Sub

    Private Sub btnQuanLyKho_Click(sender As Object, e As EventArgs) Handles btnQuanLyKho.Click
        frmQuanLyKho.MdiParent = frmMainform
        frmQuanLyKho.Show()
        frmQuanLyKho.BringToFront()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btnQuanLYPhiSach.Click
        frmQuanLyCP.MdiParent = frmMainform
        frmQuanLyCP.Show()
        frmQuanLyCP.BringToFront()
    End Sub

    Private Sub frmQuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'phân quyền
        Dim db5 As New DataTable
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & frmMainform.btnNguoiDung.Caption & "' and Chuc_vu like N'quản lý'  ", conn)
        'load phan quyen form
        conn.Open()
        db5.Clear()
        TK.Fill(db5)
        If db5.Rows.Count > 0 Then
            btnQuanLyNV.Enabled = True
        Else
            btnQuanLyNV.Enabled = False
        End If
        conn.Close()

    End Sub

    Private Sub BtnTheLoai_Click(sender As Object, e As EventArgs) Handles BtnTheLoai.Click
        frmTheLoai.MdiParent = frmMainform
        frmTheLoai.Show()
        frmTheLoai.BringToFront()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class