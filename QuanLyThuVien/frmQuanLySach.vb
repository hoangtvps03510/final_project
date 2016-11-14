Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLySach
    Dim masach, tensach, tg, nxb, ngayphathanh, ke, ghichu, theloai, kho, soluong, dongia, nguonnhap, ngaynhap As String
    Dim bang As String
    Dim thuoctinh As String
    Dim khoachinh As String
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim image As Image
    Dim fs As System.IO.FileStream
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        frmThemSach.Show()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        ' hiện from để sửa thông tin sách
        frmSuaSach.Show()
        ' load dữ liệu lên from sửa

        frmSuaSach.TxtTenSach.Text = tensach
        frmSuaSach.CboTacGia.Text = tg
        frmSuaSach.CboNXB.Text = nxb
        frmSuaSach.CboTenKe.Text = ke
        frmSuaSach.CboTheLoai.Text = theloai
        frmSuaSach.txtMaSach.Text = masach
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            frmSuaSach.PtbAnh.BackgroundImage = image
            frmSuaSach.lblTenHinh.Text = masach + ".jpg"
        Catch ex As Exception
            frmSuaSach.PtbAnh.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\sach001.jpg")
            frmSuaSach.lblTenHinh.Text = "sach001.jpg"
        End Try
        Dim a As Boolean
    End Sub


    Private Sub frmQuanLySach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'phân quyền
        Dim db5 As New DataTable
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & frmMainform.btnNguoiDung.Caption & "' and Chuc_vu like N'quản lý'  ", conn)
        'load phan quyen form
        conn.Open()
        db5.Clear()
        TK.Fill(db5)
        If db5.Rows.Count > 0 Then
            BtnXoa.Enabled = True
        Else
            BtnXoa.Enabled = False
        End If
        Try


            ' load dữ liệu lên datagridview
            Dim TG As New SqlDataAdapter("select sach.Ma_sach  as 'Mã Sách', Ten_sach  as 'Tên Sách',ten_the_loai  as 'Thể loại', ten_tac_gia   as 'Tên Tác Giả', Ten_NXB   as 'Tên NXB',Ten_ke as 'Tên kệ',Ngay_phat_hanh    as 'Ngày phát hành',ghi_chu as 'Ghi chú' from  SACH,Tac_gia,The_loai,nxb,ke where sach.Ma_tac_gia=tac_gia.Ma_tac_gia and sach.Ma_NXB=nxb.Ma_NXB and sach.Ma_ke=ke.Ma_ke and sach.Ma_the_loai=the_loai.Ma_the_loai ", conn)

            db.Clear()
            DgvSach.DataSource = db.DefaultView
            TG.Fill(db)
            conn.Close()

            masach = DgvSach.Item(0, 0).Value
            tensach = DgvSach.Item(1, 0).Value
            Try
                fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
                image = System.Drawing.Image.FromStream(fs)
                fs.Close()
                ptbBia.BackgroundImage = image
            Catch ex As Exception
                ptbBia.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\sach001.jpg")
            End Try
        Catch ex As Exception
            MsgBox("Chưa có dữ liệu")
        End Try
        conn.Close()

    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        ' Lệnh xóa sách
        Dim db2 As New DataTable
        Dim ma As New SqlDataAdapter("select ID_CTPT from CHI_TIET_PHIEU_MUON,CHI_TIET_PHIEU_TRA where CHI_TIET_PHIEU_MUON.ID_CTPM=CHI_TIET_PHIEU_TRA.ID_CTPM and Ma_sach = '" & masach & "'", conn)
        Dim query As String = "delete from bang_gia where Ma_sach=@Ma_sach delete from Chi_Tiet_Phieu_muon where Ma_sach=@Ma_sach delete from chi_tiet_kho where Ma_sach=@Ma_sach delete from sach where Ma_sach=@Ma_sach"
        Dim delete As SqlCommand = New SqlCommand(query, conn)

        conn.Open()
        db2.Clear()
        ma.Fill(db2)

        Dim sodong As Integer = db2.Rows.Count


        Try

            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' hỏi trước khi xóa
            If resulft = Windows.Forms.DialogResult.Yes Then
                ' Gán mã thành viên để xóa


                If sodong > 0 Then
                    For i = 0 To sodong - 1
                        Dim query2 As String = "delete from Chi_Tiet_Phieu_Tra where ID_CTPT=@mapt"
                        Dim delete2 As SqlCommand = New SqlCommand(query2, conn)
                        delete2.Parameters.AddWithValue("@mapt", db2.Rows(i)(0).ToString)
                        delete2.ExecuteNonQuery()
                    Next
                End If

                delete.Parameters.AddWithValue("@Ma_sach", masach)
                delete.ExecuteNonQuery()

                MessageBox.Show("Xóa thành công")
                'làm mới bảng
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Chưa Chọn Sách")
            conn.Close()

        End Try
        conn.Close()
        frmQuanLySach_Load(Nothing, Nothing)

    End Sub


    Private Sub DgvSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSach.CellContentClick
        ' Cắt dữ liệu để load lên from 
        Dim click As Integer = DgvSach.CurrentCell.RowIndex

        masach = DgvSach.Item(0, click).Value
        tensach = DgvSach.Item(1, click).Value
        theloai = DgvSach.Item(2, click).Value
        tg = DgvSach.Item(3, click).Value
        nxb = DgvSach.Item(4, click).Value
        ke = DgvSach.Item(5, click).Value
        ngayphathanh = DgvSach.Item(6, click).Value
        ghichu = DgvSach.Item(7, click).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbBia.BackgroundImage = image
        Catch ex As Exception
            ptbBia.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\sach001.jpg")
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub CboTheLoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoai.SelectedIndexChanged
        If cboLoai.SelectedIndex = 0 Then
            cboGiaTri.Enabled = False
            cboGiaTri.Text = ""
        ElseIf cboLoai.SelectedIndex = 1 Then
            cboGiaTri.Enabled = True
            bang = "the_loai"
            thuoctinh = "ten_the_loai"
            khoachinh = "ma_the_loai"
        ElseIf cboLoai.SelectedIndex = 2 Then
            cboGiaTri.Enabled = True
            bang = "tac_gia"
            thuoctinh = "ten_tac_gia"
            khoachinh = "ma_tac_gia"
        ElseIf cboLoai.SelectedIndex = 3 Then
            cboGiaTri.Enabled = True
            bang = "NXB"
            thuoctinh = "ten_nxb"
            khoachinh = "ma_nxb"
        End If
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select * from " & bang & "", conn)
        If cboGiaTri.Enabled = True Then
            conn.Open()
            da.Fill(ds)
            cboGiaTri.DataSource = ds.Tables(0)
            cboGiaTri.DisplayMember = thuoctinh
            cboGiaTri.ValueMember = khoachinh
            cboGiaTri.SelectedIndex = 0
            conn.Close()
        End If
        conn.Close()
    End Sub

    Private Sub BtnTimKiem_Click(sender As Object, e As EventArgs) Handles BtnTimKiem.Click
        conn.Open()
        If cboLoai.SelectedIndex > 0 Then
            Dim TG As New SqlDataAdapter("select sach.Ma_sach  as 'Mã Sách', Ten_sach  as 'Tên Sách',ten_the_loai  as 'Thể loại', ten_tac_gia   as 'Tên Tác Giả', Ten_NXB   as 'Tên NXB',Ten_ke as 'Tên kệ',Ngay_phat_hanh    as 'Ngày phát hành',ghi_chu as 'Ghi chú' from  SACH,Tac_gia,The_loai,nxb,ke where sach.Ma_tac_gia=tac_gia.Ma_tac_gia and sach.Ma_NXB=nxb.Ma_NXB and sach.Ma_ke=ke.Ma_ke and sach.Ma_the_loai=the_loai.Ma_the_loai and sach." & khoachinh & " like N'" & cboGiaTri.SelectedValue.ToString & "' and ten_sach like N'%" & TxtTim.Text & "%' ", conn)
            db.Clear()
            DgvSach.DataSource = db.DefaultView
            TG.Fill(db)
        Else
            Dim TG As New SqlDataAdapter("select sach.Ma_sach  as 'Mã Sách', Ten_sach  as 'Tên Sách',ten_the_loai  as 'Thể loại', ten_tac_gia   as 'Tên Tác Giả', Ten_NXB   as 'Tên NXB',Ten_ke as 'Tên kệ',Ngay_phat_hanh    as 'Ngày phát hành',ghi_chu as 'Ghi chú' from  SACH,Tac_gia,The_loai,nxb,ke where sach.Ma_tac_gia=tac_gia.Ma_tac_gia and sach.Ma_NXB=nxb.Ma_NXB and sach.Ma_ke=ke.Ma_ke and sach.Ma_the_loai=the_loai.Ma_the_loai and ten_sach like N'%" & TxtTim.Text & "%' ", conn)
            db.Clear()
            DgvSach.DataSource = db.DefaultView
            TG.Fill(db)
        End If
        masach = DgvSach.Item(0, 0).Value
        tensach = DgvSach.Item(1, 0).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbBia.BackgroundImage = image
        Catch ex As Exception
            ptbBia.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\sach001.jpg")
        End Try
        conn.Close()

    End Sub
End Class