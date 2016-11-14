Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data.DataTable
'Inherits DevExpress.XtraEditors.XtraForm
Public Class frmSuaNV
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaTV.Click
        Dim query As String = "update NHAN_VIEN set Ten_NV=@Ten_NV, Ngay_sinh=@Ngay_sinh,gioi_tinh=@gioi_tinh, cmnd=@cmnd, Sdt=@Sdt, Dia_chi=@Dia_chi,Chuc_vu=@Chuc_vu, Email=@Email where Ma_NV=@Ma_NV "

        Dim save As SqlCommand = New SqlCommand(query, conn)

        conn.Open()

        Try
            If CbbGioiTinh.Text = "Nam" Then
                CbbGioiTinh.Text = "1"
            Else
                CbbGioiTinh.Text = "0"
            End If
            dtpNamSinh.Focus()
            If dtpNamSinh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập ngày tháng năm sinh", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                TxtDiaChi.Focus()
                If TxtDiaChi.Text = "" Or Regex.IsMatch(TxtDiaChi.Text, "['-]") Then
                    MessageBox.Show("Bạn chưa nhập địa chỉ liên lạc", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    CbbChucVu.Focus()
                    If CbbChucVu.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập vị trí chức vụ", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                    Else
                        TxtEmail.Focus()
                        If TxtEmail.Text = "" Or Not Regex.IsMatch(TxtEmail.Text, "^[0-9a-zA-Z._-]+@[0-9a-zA-Z]+.[0-9a-zA-Z]+$") Then
                            MessageBox.Show("Bạn chưa nhập email or nhập sai cú pháp", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                        Else
                            TxtCMND.Focus()
                            If TxtCMND.Text = "" Or Not IsNumeric(TxtCMND.Text) Then
                                MessageBox.Show("Bạn chưa nhập số CMND", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                TxtSDT.Focus()
                                If TxtSDT.Text = "" Or Not IsNumeric(TxtSDT.Text) Then
                                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else

                                    'them vao bang nhan vien

                                    save.Parameters.AddWithValue("@Ma_NV", txtMaNV.Text)
                                    save.Parameters.AddWithValue("@Chuc_vu", CbbChucVu.Text)
                                    save.Parameters.AddWithValue("@Ten_NV", TxtHoTen.Text)
                                    save.Parameters.AddWithValue("@Ngay_sinh", dtpNamSinh.Value.ToString("MM/dd/yyyy"))
                                    save.Parameters.AddWithValue("@Dia_chi", TxtDiaChi.Text)
                                    save.Parameters.AddWithValue("@gioi_tinh", CbbGioiTinh.Text)
                                    save.Parameters.AddWithValue("@cmnd", TxtCMND.Text)
                                    save.Parameters.AddWithValue("@Sdt", TxtSDT.Text)
                                    save.Parameters.AddWithValue("@email", TxtEmail.Text)

                                    save.ExecuteNonQuery()
                                    conn.Close() 'đóng kết nối
                                    MessageBox.Show("Lưu thành công")
                                    'Sau khi nhập thành công tự động làm mới 
                                    Dim Nhanvien As New SqlDataAdapter("select Ma_NV as'Mã Nhân Viên',Ten_NV as 'Tên Nhân Viên', Ngay_sinh as 'Ngày Sinh', case Gioi_tinh when 1 then 'Nam' else 'Nữ' end as 'Giới tính', cmnd as 'Số CMND', Sdt as 'Số Điện thoại', Dia_chi as 'Địa Chỉ',Email,Chuc_vu as 'Chức Vụ',username as 'Tên Tài Khoản'  from NHAN_VIEN", conn)
                                    db.Clear()
                                    frmQuanLyNV.DgvNhanVien.DataSource = db.DefaultView
                                    Nhanvien.Fill(db)

                                    Me.Close()
                                End If
                            End If
                        End If
                    End If
                End If
            End If


        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

        End Try

        conn.Close()


    End Sub


    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub
End Class