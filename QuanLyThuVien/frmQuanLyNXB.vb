Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmQuanLyNXB

    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim manxb, tennxb As String

    Private Sub frmQuanlyNXB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'phân quyền
        Dim db5 As New DataTable
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & frmMainform.btnNguoiDung.Caption & "' and Chuc_vu like N'quản lý'  ", conn)
        'load phan quyen form
        conn.Open()
        db5.Clear()
        TK.Fill(db5)
        If db5.Rows.Count > 0 Then
            BtnXoaNXB.Enabled = True
        Else
            BtnXoaNXB.Enabled = False
        End If



        ' load dữ liệu lên datagridview
        Dim NXB As New SqlDataAdapter("select ma_nxb as 'Mã Nhà Xuất Bản', ten_NXB as 'Tên Nhà Xuất Bản' from  NXB", conn)

        db.Clear()
        DgvNXB.DataSource = db.DefaultView
        NXB.Fill(db)
        manxb = DgvNXB.Item(0, 0).Value
        tennxb = DgvNXB.Item(1, 0).Value
        TxtTenNXB.Text = tennxb
        TxtMaNXB.Text = manxb
        Try
            Dim sach As New SqlDataAdapter("select nxb.ma_nxb as 'Mã Nhà Xuất Bản', ten_NXB as 'Tên Nhà Xuất Bản',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  nxb,sach where sach.ma_nxb=nxb.ma_nxb and nxb.ma_nxb like '" & TxtMaNXB.Text & "' ", conn)
            db2.Clear()
            dgvSach.DataSource = db2.DefaultView
            sach.Fill(db2)
            conn.Close()
        Catch ex As Exception
            MsgBox("Chưa có dữ liệu")
        End Try
        conn.Close()
    End Sub

    Private Sub DgvNXB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvNXB.CellContentClick
        Dim click As Integer = DgvNXB.CurrentCell.RowIndex
        manxb = DgvNXB.Item(0, click).Value
        tennxb = DgvNXB.Item(1, click).Value
        TxtTenNXB.Text = tennxb
        TxtMaNXB.Text = manxb
        Dim sach As New SqlDataAdapter("select nxb.ma_nxb as 'Mã Nhà Xuất Bản', ten_NXB as 'Tên Nhà Xuất Bản',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  nxb,sach where sach.ma_nxb=nxb.ma_nxb and nxb.ma_nxb like '" & TxtMaNXB.Text & "' ", conn)
        conn.Open()
        db2.Clear()
        dgvSach.DataSource = db2.DefaultView
        sach.Fill(db2)
        conn.Close()
    End Sub

    Private Sub BtnThemNXB_Click(sender As Object, e As EventArgs) Handles BtnThemNXB.Click
        Dim query As String = "insert into NXB values(@ten_nxb) "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Try
            conn.Open()
            TxtTenNXB.Focus()
            If TxtTenNXB.Text = "" Or Regex.IsMatch(TxtTenNXB.Text, "['-]") Then
                MessageBox.Show("Bạn chưa tên nhà xuất bản", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                'them vao bang bang nxb


                save.Parameters.AddWithValue("@ten_nxb", TxtTenNXB.Text)
                save.ExecuteNonQuery()
                'conn.Close() 'đóng kết nối
                MessageBox.Show("Lưu thành công")
                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                TxtMaNXB.Text = Nothing
                TxtTenNXB.Text = Nothing


            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Tên nhà xuát bị trùng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
        'load lai form
        frmQuanlyNXB_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnXoaNXB_Click(sender As Object, e As EventArgs) Handles BtnXoaNXB.Click
        ' Lệnh xóa nhà xuất bản
        Dim query As String = "delete from nxb where Ma_nxb=@Ma_nxb"
        Dim delete As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Dim resulft As DialogResult = MessageBox.Show("Mọi dữ liệu liên đến nhà xuất bản " & tennxb & " sẽ bị xóa. ", "Bạn chắc chứ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' hỏi trước khi xóa
        If resulft = Windows.Forms.DialogResult.Yes Then
            ' Gán mã thành viên để xóa
            Dim sodong As Integer = db2.Rows.Count
            ' Gán mã thành viên để xóa
            If sodong > 0 Then
                Dim i As Integer
                For i = 0 To sodong - 1
                    Dim db3 As New DataTable
                    Dim ma As New SqlDataAdapter("select ID_CTPT from CHI_TIET_PHIEU_MUON,CHI_TIET_PHIEU_TRA where CHI_TIET_PHIEU_MUON.ID_CTPM=CHI_TIET_PHIEU_TRA.ID_CTPM and Ma_sach = '" & db2.Rows(i)(2).ToString & "'", conn)
                    db3.Clear()
                    ma.Fill(db3)
                    If db3.Rows.Count > 0 Then
                        Dim a As Integer
                        For a = 0 To db3.Rows.Count - 1
                            Dim query2 As String = "delete from Chi_Tiet_Phieu_Tra where ID_CTPT=@mapt"
                            Dim delete2 As SqlCommand = New SqlCommand(query2, conn)
                            delete2.Parameters.AddWithValue("@mapt", db3.Rows(a)(0).ToString)
                            delete2.ExecuteNonQuery()

                        Next
                    End If
                    Dim queryDel3 As String = "delete from bang_gia where Ma_sach=@Ma_sach delete from Chi_Tiet_Phieu_muon where Ma_sach=@Ma_sach delete from chi_tiet_kho where Ma_sach=@Ma_sach delete from sach where Ma_sach=@Ma_sach "
                    Dim delete3 As SqlCommand = New SqlCommand(queryDel3, conn)
                    delete3.Parameters.AddWithValue("@Ma_sach", db2.Rows(i)(2).ToString)
                    delete3.ExecuteNonQuery()

                Next
                delete.Parameters.AddWithValue("@Ma_nxb", TxtMaNXB.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
            Else
                delete.Parameters.AddWithValue("@Ma_nxb", TxtMaNXB.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
            End If
            'làm mới bảng
            frmQuanlyNXB_Load(Nothing, Nothing)
        End If
        conn.Close()
    End Sub

    Private Sub BtnSuaNXB_Click(sender As Object, e As EventArgs) Handles BtnSuaNXB.Click
        Dim query As String = "update nxb set ten_nxb=@ten_nxb where Ma_nxb=@Ma_nxb "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Try
            TxtTenNXB.Focus()
            If TxtTenNXB.Text = "" Or Regex.IsMatch(TxtTenNXB.Text, "['-]") Then
                MessageBox.Show("Bạn chưa tên nhà xuất bản", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                conn.Open()
                'them cap nhat bang nxb
                save.Parameters.AddWithValue("@Ma_nxb", TxtMaNXB.Text)
                save.Parameters.AddWithValue("@ten_nxb", TxtTenNXB.Text)
                save.ExecuteNonQuery()
                conn.Close() 'đóng kết nối
                MessageBox.Show("Lưu thành công")

                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                TxtMaNXB.Text = Nothing
                TxtTenNXB.Text = Nothing
                frmQuanlyNXB_Load(Nothing, Nothing)

            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close() 'đóng kết nối

    End Sub

    Private Sub btnTK_Click(sender As Object, e As EventArgs) Handles btnTK.Click
        If TxtMaNXB2.Text = "" Then
            TxtMaNXB2.Text = "%"
        End If
        Dim NXB As New SqlDataAdapter("select ma_nxb as 'Mã Nhà Xuất Bản', ten_NXB as 'Tên Nhà Xuất Bản' from  NXB where ma_nxb like '" & TxtMaNXB2.Text & "' and ma_nxb like '%" & TxtTenNXB2.Text & "%'", conn)
            conn.Open()
            db.Clear()
            DgvNXB.DataSource = db.DefaultView
            NXB.Fill(db)
            manxb = DgvNXB.Item(0, 0).Value
            tennxb = DgvNXB.Item(1, 0).Value
            TxtTenNXB.Text = tennxb
            TxtMaNXB.Text = manxb
            Dim sach As New SqlDataAdapter("select nxb.ma_nxb as 'Mã Nhà Xuất Bản', ten_NXB as 'Tên Nhà Xuất Bản',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  nxb,sach where sach.ma_nxb=nxb.ma_nxb and nxb.ma_nxb = '" & TxtMaNXB.Text & "' ", conn)
            db2.Clear()
            dgvSach.DataSource = db2.DefaultView
            sach.Fill(db2)
            conn.Close()
            TxtMaNXB2.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class