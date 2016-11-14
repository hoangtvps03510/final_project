Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDoiMatKhau
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        Dim db5 As New DataTable
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username,pass, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & frmMainform.btnNguoiDung.Caption & "' ", conn)
        'load phan quyen form
        conn.Open()
        db5.Clear()
        TK.Fill(db5)
        If txtMatKhauCu.Text = "" Or txtMatKhauMoi.Text = "" Or txtNhapLai.Text = "" Then
            MessageBox.Show("Vui lòng nhập đúng thông tin")
            conn.Close()
            Exit Sub
        End If
        If txtMatKhauCu.Text = db5.Rows(0)(1).ToString And txtMatKhauMoi.Text = txtNhapLai.Text Then
            Dim query As String = "update Tai_khoan set pass=@pass where username=@User "
            Dim doimk As SqlCommand = New SqlCommand(query, conn)
            doimk.Parameters.AddWithValue("@User", txtTenDangNhap.Text)
            doimk.Parameters.AddWithValue("@pass", txtMatKhauMoi.Text)
            doimk.ExecuteNonQuery()
            MessageBox.Show("Đổi mật khẩu thành công")
            Me.Close()
        Else
            MessageBox.Show("Vui lòng nhập đúng thông tin")
            conn.Close()
            Exit Sub
        End If
        conn.Close()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub


End Class