Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmThemTV
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Private Sub btnThemTDS_Click(sender As Object, e As EventArgs) Handles btnThemTV.Click
        Dim query As String = "insert into THANH_VIEN values(@Ten_TV,@Nam_sinh,@So_CMND,@Dia_chi,@Dien_thoai,@Gioi_tinh,@Nghe_nghiep,@ngay_dang_ky)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        If cbbGioiTinh.Text = "Nam" Then
            cbbGioiTinh.Text = "1"
        Else : cbbGioiTinh.Text = "0"
        End If
        Try
            TxtHoten.Focus()
            If TxtHoten.Text = "" Or Regex.IsMatch(TxtHoten.Text, "['-]") Then
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
                        TxtCMND.Focus()
                        If TxtCMND.Text = "" Or Not IsNumeric(TxtCMND.Text) Then
                            MessageBox.Show("Bạn chưa nhập Số chứng minh nhân dân", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            TxtDiaChi.Focus()
                            If TxtDiaChi.Text = "" Or Regex.IsMatch(TxtDiaChi.Text, "['-]") Then
                                MessageBox.Show("Bạn chưa nhập địa chỉ", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                cbbGioiTinh.Focus()
                                If cbbGioiTinh.Text = "" Then
                                    MessageBox.Show("Bạn chưa chọn giới tính", "Sai dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                                Else
                                    save.Parameters.AddWithValue("@Ten_TV", TxtHoten.Text)
                                    save.Parameters.AddWithValue("@Nam_sinh", DtpNamSinh.Value.ToString("MM/dd/yyyy"))
                                    save.Parameters.AddWithValue("@So_CMND", TxtCMND.Text)
                                    save.Parameters.AddWithValue("@Dia_chi", TxtDiaChi.Text)
                                    save.Parameters.AddWithValue("@Dien_thoai", TxtSDT.Text)
                                    save.Parameters.AddWithValue("@Gioi_tinh", cbbGioiTinh.Text)
                                    save.Parameters.AddWithValue("@Nghe_nghiep", cbbNghe.Text)
                                    save.Parameters.AddWithValue("@ngay_dang_ky", DtpNgayDK.Value.ToString("MM/dd/yyyy"))
                                    save.ExecuteNonQuery()
                                    MessageBox.Show("Lưu thành công")
                                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                    TxtHoten.Text = Nothing
                                    DtpNamSinh.Text = Nothing
                                    TxtCMND.Text = Nothing
                                    TxtDiaChi.Text = Nothing
                                    TxtSDT.Text = Nothing
                                    cbbGioiTinh.Text = Nothing
                                    cbbNghe.Text = Nothing
                                    Dim thanhvien As New SqlDataAdapter("select Ma_TV as 'Mã Thành Viên', Ten_TV as 'Tên Thành Viên',Format(Nam_sinh,'dd/MM/yyyy') as 'Năm Sinh',So_CMND as 'Số CMND',Dia_chi as 'Địa Chỉ', Dien_thoai as 'Điện Thoại', case Gioi_tinh when 1 then N'Nam' else N'Nữ' end as 'Giới Tính',Nghe_nghiep as 'Nghề Nghiệp'from THANH_VIEN", conn)
                                    db.Clear()
                                    frmQuanLyTV.DgvThanhVien.DataSource = db.DefaultView
                                    thanhvien.Fill(db)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không thành công ", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
    End Sub

    Private Sub BtnHuy_Click(sender As Object, e As EventArgs) Handles BtnHuy.Click
        Me.Close()
    End Sub

End Class