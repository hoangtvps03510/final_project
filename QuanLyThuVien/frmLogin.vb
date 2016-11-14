Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Partial Public Class frmLogin
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'kiểm tra user và pass có trống hay không
        If txtTenDangNhap.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Tài Khoản", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If txtMatKhau.Text = "" Then
                MessageBox.Show("Chưa Nhập Mật Khẩu", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        'ngăn k thêm ký tự
        If Regex.IsMatch(txtTenDangNhap.Text, "['-]") Or Regex.IsMatch(txtMatKhau.Text, "['-]") Then
            MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ")
            Exit Sub
        End If

        'kiểm tra user
        Dim dbuser As New DataTable
        Dim sqluser As String = "select username from TAI_KHOAN where username = '" & txtTenDangNhap.Text & "'"
        Dim ktuser As New SqlDataAdapter(sqluser, conn)
        conn.Open()
        ktuser.Fill(dbuser)
        conn.Close()
        If dbuser.Rows.Count < 1 Then
            MessageBox.Show("Sai Tên Tài Khoản " & vbNewLine & "Nếu Chưa Đăng Ký Tài Khoản, Vui lòng Liên Hệ Admin", "Sai Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'kiểm tra pass
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username, pass , trangthai, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & txtTenDangNhap.Text & "' and pass = '" & txtMatKhau.Text & "' ", conn)
        conn.Open()
        db.Clear()
        TK.Fill(db)
        conn.Close()

        If db.Rows.Count < 1 Then
            MessageBox.Show("Sai Mật Khẩu" & vbNewLine & "Nếu Quên Mật Khẩu, Vui Lòng Liên Hệ Admin", "Sai Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'kiểm tra trạng thái của tài khoản
        If db.Rows(0)(2).ToString = "False" Then
            MessageBox.Show("Tài khoản của bạn đã bị khóa bởi quản lý")
        Else
            MessageBox.Show("Đăng nhập thành công dưới quyền: " & db.Rows(0)(3).ToString & "")
            frmMainform.btnMuonSach.Enabled = True
            frmMainform.btnTraSach.Enabled = True
            frmMainform.btnQuanLy.Enabled = True
            frmMainform.btnThongKe.Enabled = True
            frmMainform.btnDangNhap.Caption = "Đăng xuất"
            frmMainform.btnNguoiDung.Caption = db.Rows(0)(0).ToString
            frmMainform.btnNguoiDung.Enabled = True
            Me.Close()
        End If
        conn.Close()

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub txtMatKhau_TextChanged(sender As Object, e As KeyEventArgs) Handles txtMatKhau.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnDangNhap_Click(sender, e)
        End If

    End Sub
End Class
