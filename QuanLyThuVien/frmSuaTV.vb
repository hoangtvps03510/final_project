Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmSuaTV
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)


    Private Sub btnSuaTDS_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click

        Dim updatequery As String = "update THANH_VIEN set Ten_TV=@Ten_TV, Nam_sinh=@Nam_sinh, So_CMND=@So_CMND, Dia_chi=@Dia_chi, Dien_thoai=@Dien_thoai, Gioi_tinh=@Gioi_tinh, Nghe_nghiep=@Nghe_nghiep where Ma_TV=@Ma_TV"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        If cbbGioiTinh.Text = "Nam" Then
            cbbGioiTinh.Text = "1"
        Else : cbbGioiTinh.Text = "0"
        End If
        Try
            TxtHoten.Focus()
            If TxtHoten.Text = "" Or Regex.IsMatch(TxtHoten.Text, "['-]") Then
                MessageBox.Show("Bạn chưa nhập Tên thành viên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                DtpNamSinh.Focus()
                If DtpNamSinh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập ngày tháng năm sinh", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    TxtSDT.Focus()
                    If TxtSDT.Text = "" Or Not IsNumeric(TxtSDT.Text) Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        TxtCMND.Focus()
                        If TxtCMND.Text = "" Or Not IsNumeric(TxtCMND.Text) Then
                            MessageBox.Show("Bạn chưa nhập Số chứng minh nhân dân", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            TxtDiaChi.Focus()
                            If TxtDiaChi.Text = "" Or Regex.IsMatch(TxtDiaChi.Text, "['-]") Then
                                MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                cbbGioiTinh.Focus()
                                If cbbGioiTinh.Text = "" Then
                                    MessageBox.Show("Bạn chưa chọn giới tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                                Else
                                    conn.Open()
                                    addupdate.Parameters.AddWithValue("@Ten_TV", TxtHoten.Text)
                                    addupdate.Parameters.AddWithValue("@Nam_sinh", DtpNamSinh.Value.ToString("MM/dd/yyyy"))
                                    addupdate.Parameters.AddWithValue("@So_CMND", TxtCMND.Text)
                                    addupdate.Parameters.AddWithValue("@Dia_chi", TxtDiaChi.Text)
                                    addupdate.Parameters.AddWithValue("@Dien_thoai", TxtSDT.Text)
                                    addupdate.Parameters.AddWithValue("@Gioi_tinh", cbbGioiTinh.Text)
                                    addupdate.Parameters.AddWithValue("@Nghe_nghiep", CbbNghe.Text)
                                    addupdate.Parameters.AddWithValue("@Ma_TV", TxtMaTV.Text)
                                    addupdate.ExecuteNonQuery()
                                    MessageBox.Show("Cập nhật thông tin thành viên thành công")
                                    'Sau khi nhập thành công tự động làm mới
                                    Dim db As New DataTable
                                    Dim thanhvien As New SqlDataAdapter("select Ma_TV as 'Mã Thành Viên', Ten_TV as 'Tên Thành Viên',Nam_sinh as 'Năm Sinh',So_CMND as 'Số CMND',Dia_chi as 'Địa Chỉ', Dien_thoai as 'Điện Thoại', case Gioi_tinh when 1 then N'Nam' else N'Nữ' end as 'Giới Tính',Nghe_nghiep as 'Nghề Nghiệp'from THANH_VIEN", conn)
                                    db.Clear()
                                    frmQuanLyTV.DgvThanhVien.DataSource = db.DefaultView
                                    thanhvien.Fill(db)
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Cập nhật không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            conn.Close()
        End Try

        conn.Close()
    End Sub

    Private Sub BtnHuy_Click(sender As Object, e As EventArgs) Handles BtnHuy.Click
        Me.Close()
    End Sub
End Class