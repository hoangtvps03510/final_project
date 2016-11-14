Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmThemNV
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)

    
    Private Sub btnThemTDS_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click
        Dim query As String = "if not exists (select * from tai_khoan where username = '@username') begin insert into tai_khoan values (@username,@pass,1) insert into NHAN_VIEN values(@Ten_NV,@Ngay_sinh,@gioi_tinh,@cmnd,@Sdt,@Dia_chi,@Email,@Chuc_vu,@username) end"
 
        Dim save As SqlCommand = New SqlCommand(query, conn)

        conn.Open()
        If CbbGioiTinh.Text = "Nam" Then
            CbbGioiTinh.Text = "1"
        Else : CbbGioiTinh.Text = "0"
        End If
        Try
            TxtHoTen.Focus()
            If TxtHoTen.Text = "" Or Regex.IsMatch(TxtHoTen.Text, "['-]") Then
                MessageBox.Show("Bạn chưa nhập Tên thành viên", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                DtpNamSinh.Focus()
                If DtpNamSinh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập ngày tháng năm sinh", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    TxtSDT.Focus()
                    If TxtSDT.Text = "" Or Not IsNumeric(TxtSDT.Text) Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        TxtDiaChi.Focus()
                        If TxtDiaChi.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập địa chỉ liên lạc", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtMatKhau.Focus()
                            If txtMatKhau.Text = "" Then
                                MessageBox.Show("pass word không được để trống", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                CbbChucVu.Focus()
                                If CbbChucVu.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập vị trí chức vụ", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                                Else
                                    TxtEmail.Focus()
                                    If TxtEmail.Text = "" Or Not Regex.IsMatch(TxtEmail.Text, "^[0-9a-zA-Z._-]+@[0-9a-zA-Z]+.[0-9a-zA-Z]+$") Then
                                        MessageBox.Show("Bạn chưa nhập email hoặc nhập sai cú pháp", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                    Else
                                        TxtTaiKhoan.Focus()
                                        If TxtTaiKhoan.Text = "" Then
                                            MessageBox.Show("Tài khoản không được bỏ trống", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                        Else
                                            TxtCMND.Focus()
                                            If TxtCMND.Text = "" And Not IsNumeric(TxtCMND.Text) Then
                                                MessageBox.Show("Bạn chưa nhập số cmnd", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                            Else
                                                'them vao bang nhan vien

                                                save.Parameters.AddWithValue("@pass", txtMatKhau.Text)
                                                save.Parameters.AddWithValue("@Chuc_vu", CbbChucVu.Text)
                                                save.Parameters.AddWithValue("@username", TxtTaiKhoan.Text)
                                                save.Parameters.AddWithValue("@Ten_NV", TxtHoTen.Text)
                                                save.Parameters.AddWithValue("@Ngay_sinh", DtpNamSinh.Value.ToString("MM/dd/yyyy"))
                                                save.Parameters.AddWithValue("@Dia_chi", TxtDiaChi.Text)
                                                save.Parameters.AddWithValue("@Sdt", TxtSDT.Text)
                                                save.Parameters.AddWithValue("@email", TxtEmail.Text)
                                                save.Parameters.AddWithValue("@gioi_tinh", CbbGioiTinh.Text)
                                                save.Parameters.AddWithValue("@cmnd", TxtCMND.Text)
                                                save.ExecuteNonQuery()
                                                conn.Close() 'đóng kết nối
                                                MessageBox.Show("Lưu thành công")
                                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                                TxtHoTen.Text = Nothing
                                                DtpNamSinh.Value = Now
                                                TxtSDT.Text = Nothing
                                                TxtDiaChi.Text = Nothing
                                                TxtEmail.Text = Nothing
                                                CbbChucVu.SelectedIndex = 0
                                                TxtTaiKhoan.Text = Nothing
                                                txtMatKhau.Text = "11111111"
                                                Dim db As New DataTable
                                                Dim Nhanvien As New SqlDataAdapter("select Ma_NV as'Mã Nhân Viên',Ten_NV as 'Tên Nhân Viên', Ngay_sinh as 'Ngày Sinh', case Gioi_tinh when 1 then 'Nam' else 'Nữ' end as 'Giới tính', cmnd as 'Số CMND', Sdt as 'Số Điện thoại', Dia_chi as 'Địa Chỉ',Email,Chuc_vu as 'Chức Vụ',username as 'Tên Tài Khoản'  from NHAN_VIEN", conn)
                                                db.Clear()
                                                frmQuanLyNV.DgvNhanVien.DataSource = db.DefaultView
                                                Nhanvien.Fill(db)
                                            End If
                                        End If
                                    End If
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