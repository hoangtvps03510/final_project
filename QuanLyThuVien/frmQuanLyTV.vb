Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanLyTV
    Dim matv, hoten, ngaysinh, cmnd, diachi, dienthoai, gioitinh, nghe As String
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable


    Private Sub frmQuanLyTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'phân quyền
        Dim db5 As New DataTable
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & frmMainform.btnNguoiDung.Caption & "' and Chuc_vu like N'quản lý'  ", conn)
        'load phan quyen form
        conn.Open()
        db5.Clear()
        TK.Fill(db5)
        If db5.Rows.Count > 0 Then
            btnXoa.Enabled = True
        Else
            btnXoa.Enabled = False
        End If
        Try
        

        ' load dữ liệu lên datagridview
            Dim thanhvien As New SqlDataAdapter("select Ma_TV as 'Mã Thành Viên', Ten_TV as 'Tên Thành Viên',Nam_sinh as 'Năm Sinh',So_CMND as 'Số CMND',Dia_chi as 'Địa Chỉ', Dien_thoai as 'Điện Thoại', case Gioi_tinh when 1 then N'Nam' else N'Nữ' end as 'Giới Tính',Nghe_nghiep as 'Nghề Nghiệp'from THANH_VIEN", conn)

        db.Clear()
        DgvThanhVien.DataSource = db.DefaultView
        thanhvien.Fill(db)
        conn.Close()
        matv = DgvThanhVien.Item(0, 0).Value
        hoten = DgvThanhVien.Item(1, 0).Value
        txtTen.Text = hoten
            txtMa.Text = matv
        Catch ex As Exception
            MsgBox("Chưa có dữ liệu")
        End Try
        conn.Close()

    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        ' hiện from để thêm
        frmThemTV.Show()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            ' load dữ liệu lên from sửa
            frmSuaTV.TxtMaTV.Text = matv
            frmSuaTV.TxtHoten.Text = hoten
            frmSuaTV.DtpNamSinh.Value = ngaysinh
            frmSuaTV.TxtCMND.Text = cmnd
            frmSuaTV.TxtDiaChi.Text = diachi
            frmSuaTV.TxtSDT.Text = dienthoai
            frmSuaTV.cbbGioiTinh.Text = gioitinh
            frmSuaTV.CbbNghe.Text = nghe
            ' hiện from để sửa thông tin thành viên
            frmSuaTV.Show()
        Catch ex As Exception
            MessageBox.Show("Chưa chọn thành viên")
        End Try

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim db2 As New DataTable
        ' Lệnh xóa thành viên của bảng thành viên
        Dim query As String = " delete from Phieu_muon where Ma_TV=@Ma_TV delete from THANH_VIEN where Ma_TV=@Ma_tv"
        Dim delete As SqlCommand = New SqlCommand(query, conn)
        Dim queryMP As New SqlDataAdapter("select CHI_TIET_PHIEU_MUON.ID_CTPM from  phieu_muon,CHI_TIET_PHIEU_TRA,CHI_TIET_PHIEU_MUON where CHI_TIET_PHIEU_MUON.ID_CTPM = CHI_TIET_PHIEU_TRA.ID_CTPM and CHI_TIET_PHIEU_MUON.Ma_phieu_muon=PHIEU_MUON.Ma_phieu_muon and phieu_muon.ma_tv ='" & matv & "'  ", conn)
        conn.Open()
        db2.Clear()
        queryMP.Fill(db2)
        Dim sodong As Integer = db2.Rows.Count

        Try
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' hỏi trước khi xóa
            If resulft = Windows.Forms.DialogResult.Yes Then
                If sodong > 0 Then
                    Dim i As Integer
                    For i = 0 To sodong - 1
                        Dim queryDel2 As String = "delete from Chi_Tiet_Phieu_tra where ID_CTPM=@Ma_CTPhieuMuon delete from Chi_Tiet_Phieu_muon where ID_CTPM=@Ma_CTPhieuMuon "
                        Dim delete2 As SqlCommand = New SqlCommand(queryDel2, conn)
                        delete2.Parameters.AddWithValue("@Ma_CTPhieuMuon", db2.Rows(i)(0).ToString)
                        delete2.ExecuteNonQuery()
                    Next
                End If
                ' Gán mã thành viên để xóa
                delete.Parameters.AddWithValue("@Ma_tv", matv)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                'làm mới bảng
                frmQuanLyTV_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show("Chưa Chọn Thành Viên")
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub DgvThanhVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvThanhVien.CellContentClick
        ' Cắt dữ liệu để load lên from sửa thành viên
        Dim click As Integer = DgvThanhVien.CurrentCell.RowIndex

        matv = DgvThanhVien.Item(0, click).Value
        hoten = DgvThanhVien.Item(1, click).Value
        ngaysinh = DgvThanhVien.Item(2, click).Value
        cmnd = DgvThanhVien.Item(3, click).Value
        diachi = DgvThanhVien.Item(4, click).Value
        dienthoai = DgvThanhVien.Item(5, click).Value
        gioitinh = DgvThanhVien.Item(6, click).Value
        nghe = DgvThanhVien.Item(7, click).Value
        txtTen.Text = hoten
        txtMa.Text = matv
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        If txtMaTV.Text = "" Then
            txtMaTV.Text = "%"
        End If
        Dim Nhanvien As New SqlDataAdapter("select Ma_TV as 'Mã Thành Viên', Ten_TV as 'Tên Thành Viên',Nam_sinh as 'Năm Sinh',So_CMND as 'Số CMND',Dia_chi as 'Địa Chỉ', Dien_thoai as 'Điện Thoại', case Gioi_tinh when 1 then N'Nam' else N'Nữ' end as 'Giới Tính',Nghe_nghiep as 'Nghề Nghiệp'from THANH_VIEN where Ma_TV like '" & txtMaTV.Text & "' and Ten_TV like N'%" & txtTenTV.Text & "%' ", conn)
        conn.Open()
        db.Clear()
        DgvThanhVien.DataSource = db.DefaultView
        Nhanvien.Fill(db)
        conn.Close()
        txtMaTV.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class