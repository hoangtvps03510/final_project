Imports System.Data.SqlClient
Imports System.Data.DataTable
Partial Public Class frmQuanLyNV
    Dim manv, hoten, ngaysinh, sdt, diachi, email, chucvu, username, cmnd, gioitinh As String
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        frmThemNV.Show()
        frmThemNV.BringToFront()
    End Sub


    Private Sub DgvThanhVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNhanVien.CellContentClick
        Dim click As Integer = DgvNhanVien.CurrentCell.RowIndex
        manv = DgvNhanVien.Item(0, click).Value
        hoten = DgvNhanVien.Item(1, click).Value
        ngaysinh = DgvNhanVien.Item(2, click).Value
        gioitinh = DgvNhanVien.Item(3, click).Value
        cmnd = DgvNhanVien.Item(4, click).Value
        sdt = DgvNhanVien.Item(5, click).Value
        diachi = DgvNhanVien.Item(6, click).Value
        chucvu = DgvNhanVien.Item(8, click).Value
        email = DgvNhanVien.Item(7, click).Value
        username = DgvNhanVien.Item(9, click).Value
        txttentvht.Text = hoten
        txtusernameht.Text = username

    End Sub

    Private Sub frmQuanLyNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ' load dữ liệu lên datagridview
        Dim Nhanvien As New SqlDataAdapter("select Ma_NV as'Mã Nhân Viên',Ten_NV as 'Tên Nhân Viên', Ngay_sinh as 'Ngày Sinh', case Gioi_tinh when 1 then 'Nam' else 'Nữ' end as 'Giới tính', cmnd as 'Số CMND', Sdt as 'Số Điện thoại', Dia_chi as 'Địa Chỉ',Email,Chuc_vu as 'Chức Vụ',Nhan_vien.username as 'Tên Tài Khoản',case Trangthai when 0 then 'Lock' else 'Working' end as 'Trạng thái'  from NHAN_VIEN,Tai_khoan where Tai_khoan.username = NHAN_VIEN.username ", conn)

        db.Clear()
        DgvNhanVien.DataSource = db.DefaultView
        Nhanvien.Fill(db)
        conn.Close()
        

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim db2 As New DataTable
        Dim queryDel As String = "delete from Phieu_tra where Ma_NV=@Ma_NV delete from Phieu_muon where Ma_NV=@Ma_NV delete from NHAN_VIEN where Ma_NV=@Ma_NV delete from tai_khoan where username=@User "
        Dim delete As SqlCommand = New SqlCommand(queryDel, conn)
        Dim queryMP As New SqlDataAdapter("select CHI_TIET_PHIEU_MUON.ID_CTPM from  phieu_muon,CHI_TIET_PHIEU_TRA,CHI_TIET_PHIEU_MUON,PHIEU_TRA where CHI_TIET_PHIEU_MUON.ID_CTPM = CHI_TIET_PHIEU_TRA.ID_CTPM and CHI_TIET_PHIEU_MUON.Ma_phieu_muon=PHIEU_MUON.Ma_phieu_muon and CHI_TIET_PHIEU_TRA.Ma_phieu_tra=PHIEU_TRA.Ma_phieu_tra and PHIEU_TRA.Ma_NV ='" & manv & "'  and phieu_tra.ma_nv = '" & manv & "' ", conn)
        conn.Open()
        db2.Clear()
        queryMP.Fill(db2)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' hỏi trước khi xóa
        If resulft = Windows.Forms.DialogResult.Yes Then
            Dim sodong As Integer = db2.Rows.Count
            ' Gán mã thành viên để xóa
            If sodong > 0 Then
                Dim i As Integer
                For i = 0 To sodong - 1
                    Dim queryDel2 As String = "delete from Chi_Tiet_Phieu_tra where ID_CTPM=@Ma_CTPhieuMuon delete from Chi_Tiet_Phieu_muon where ID_CTPM=@Ma_CTPhieuMuon "
                    Dim delete2 As SqlCommand = New SqlCommand(queryDel2, conn)
                    delete2.Parameters.AddWithValue("@Ma_CTPhieuMuon", db2.Rows(i)(0).ToString)
                    delete2.ExecuteNonQuery()

                Next
            End If
            delete.Parameters.AddWithValue("@Ma_NV", manv)
            delete.Parameters.AddWithValue("@User", username)
            delete.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Xóa thành công")
            'làm mới bảng
            frmQuanLyNV_Load(Nothing, Nothing)
            End If
            conn.Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        frmSuaNV.Show()
        frmSuaNV.txtMaNV.Text = manv
        frmSuaNV.TxtHoTen.Text = hoten
        frmSuaNV.dtpNamSinh.Text = ngaysinh
        frmSuaNV.TxtEmail.Text = email
        frmSuaNV.CbbChucVu.Text = chucvu
        frmSuaNV.TxtSDT.Text = sdt
        frmSuaNV.TxtDiaChi.Text = diachi
        frmSuaNV.CbbGioiTinh.Text = gioitinh
        frmSuaNV.TxtCMND.Text = cmnd

    End Sub


    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        If txtMaNV.Text = "" Then
            txtMaNV.Text = "%"
        End If
        Dim Nhanvien As New SqlDataAdapter("select Ma_NV as'Mã Nhân Viên',Ten_NV as 'Tên Nhân Viên', Ngay_sinh as 'Ngày Sinh',gioi_tinh as 'Giới tính', cmnd as 'Số CMND', Sdt as 'Số Điện thoại', Dia_chi as 'Địa Chỉ',Email,Chuc_vu as 'Chức Vụ',username as 'Tên Tài Khoản'  from NHAN_VIEN where Ma_NV like '" & txtMaNV.Text & "' and ten_NV like N'%" & txtTenNV.Text & "%' ", conn)
        conn.Open()
        db.Clear()
        DgvNhanVien.DataSource = db.DefaultView
        Nhanvien.Fill(db)
        conn.Close()
        txtMaNV.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnCaiLaiMK_Click(sender As Object, e As EventArgs) Handles btnCaiLaiMK.Click
        Dim query As String = "update Tai_khoan set pass='11111111' where username=@User "
        Dim reset As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        reset.Parameters.AddWithValue("@User", username)
        reset.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Reset mật khẩu của " & username & " thành công")
    End Sub

    Private Sub btnKhoaTK_Click(sender As Object, e As EventArgs) Handles btnKhoaTK.Click
        Dim query As String = "update Tai_khoan set Trangthai='0' where username=@User "
        Dim lock As SqlCommand = New SqlCommand(query, conn)
        Dim dbchucvu As New DataTable
        Dim chucvu As New SqlDataAdapter("select TAI_KHOAN.username, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & username & "' and Chuc_vu like N'quản lý' ", conn)
        conn.Open()
        dbchucvu.Clear()
        chucvu.Fill(dbchucvu)
        If dbchucvu.Rows.Count = 0 Then
            lock.Parameters.AddWithValue("@User", username)
            lock.ExecuteNonQuery()
            MessageBox.Show("Đã khóa tài khoản " & username & " thành công ")
        Else
            MessageBox.Show("Bạn không thể khóa tài khoản quản lý")
        End If
        conn.Close()
        frmQuanLyNV_Load(Nothing, Nothing)
        DgvThanhVien_CellFormatting(Nothing, Nothing)

    End Sub

    Private Sub btnMoTK_Click(sender As Object, e As EventArgs) Handles btnMoTK.Click
        Dim query As String = "update Tai_khoan set Trangthai='1' where username=@User "
        Dim unlock As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        unlock.Parameters.AddWithValue("@User", username)
        unlock.ExecuteNonQuery()
        MessageBox.Show("Đã mở khóa tài khoản " & username & " thành công ")
        conn.Close()
        frmQuanLyNV_Load(Nothing, Nothing)
        DgvThanhVien_CellFormatting(Nothing, Nothing)

    End Sub
    Private Sub DgvThanhVien_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvNhanVien.CellFormatting
        Dim sodong As Integer = db.Rows.Count
        If sodong > 0 Then
            Dim i As Integer
            For i = 0 To sodong - 1
                If db.Rows(i)(10).ToString = "Lock" Then
                    DgvNhanVien.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                Else
                    DgvNhanVien.Rows(i).DefaultCellStyle.BackColor = Nothing
                End If
            Next
        End If

    End Sub

End Class