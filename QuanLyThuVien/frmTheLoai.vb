Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmTheLoai
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim matl, tentl As String

    Private Sub frmQuantl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'phân quyền
        Dim db5 As New DataTable
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & frmMainform.btnNguoiDung.Caption & "' and Chuc_vu like N'quản lý' ", conn)
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
            Dim TG As New SqlDataAdapter("select Ma_the_loai  as 'Mã thể loại', Ten_the_loai as 'Tên thể loại' from  the_loai", conn)

            db.Clear()
            DgvTL.DataSource = db.DefaultView
            TG.Fill(db)
            matl = DgvTL.Item(0, 0).Value
            tentl = DgvTL.Item(1, 0).Value
            TxtTenTl.Text = tentl
            TxtMaTl.Text = matl
            Dim sach As New SqlDataAdapter("select the_loai.Ma_the_loai  as 'Mã Thể loại', Ten_the_loai as 'Tên thể loại',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  the_loai,sach where sach.ma_the_loai=the_loai.ma_the_loai and the_loai.ma_the_loai = '" & TxtMaTl.Text & "' ", conn)
            db2.Clear()
            dgvSach.DataSource = db2.DefaultView
            sach.Fill(db2)
            conn.Close()
        Catch ex As Exception
            MsgBox("Chưa có dữ liệu")
        End Try
        conn.Close()
    End Sub

    Private Sub DgvTl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTL.CellContentClick, dgvSach.CellContentClick
        Dim click As Integer = DgvTL.CurrentCell.RowIndex
        matl = DgvTL.Item(0, click).Value
        tentl = DgvTL.Item(1, click).Value
        TxtTenTl.Text = tentl
        TxtMaTl.Text = matl
        conn.Open()
        Dim sach As New SqlDataAdapter("select the_loai.Ma_the_loai as 'Mã Thể loại', Ten_the_loai as 'Tên thể loại',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  the_loai,sach where sach.ma_the_loai=the_loai.ma_the_loai and the_loai.ma_the_loai = '" & TxtMaTl.Text & "' ", conn)
        db2.Clear()
        dgvSach.DataSource = db2.DefaultView
        sach.Fill(db2)
        conn.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = "insert into the_loai values(@Ten_the_loai) "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Try
            TxtTenTl.Focus()
            If TxtTenTl.Text = "" Or Regex.IsMatch(TxtTenTl.Text, "['-]") Then
                MessageBox.Show("Bạn chưa điền tên thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                'them vao bang bang tác giả
                conn.Open()

                save.Parameters.AddWithValue("@Ten_the_loai", TxtTenTl.Text)
                save.ExecuteNonQuery()
                conn.Close() 'đóng kết nối
                MessageBox.Show("Lưu thành công")
                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                TxtMaTl.Text = Nothing
                TxtTenTl.Text = Nothing


            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("trùng mã thể loại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
        'load lai form
        frmQuantl_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        ' Lệnh xóa tác giả
        Dim query As String = "delete from The_loai where Ma_The_loai=@Ma_The_loai"
        Dim delete As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Dim resulft As DialogResult = MessageBox.Show("Mọi dữ liệu liên đến thể loại " & tentl & " sẽ bị xóa. ", "Bạn chắc chứ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' hỏi trước khi xóa
        If resulft = Windows.Forms.DialogResult.Yes Then
            ' Gán mã thành viên để xóa
            Dim sodong As Integer = db2.Rows.Count
            If sodong > 0 Then
                Dim i As Integer
                For i = 0 To sodong - 1
                    Dim queryDel2 As String = "delete from bang_gia where Ma_sach=@Ma_sach delete from Chi_Tiet_Phieu_tra where Ma_sach=@Ma_sach delete from Chi_Tiet_Phieu_muon where Ma_sach=@Ma_sach delete from chi_tiet_kho where Ma_sach=@Ma_sach delete from sach where Ma_sach=@Ma_sach "
                    Dim delete2 As SqlCommand = New SqlCommand(queryDel2, conn)
                    delete2.Parameters.AddWithValue("@Ma_sach", db2.Rows(i)(2).ToString)
                    delete2.ExecuteNonQuery()

                Next
                delete.Parameters.AddWithValue("@Ma_The_loai", TxtMaTl.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
            Else
                delete.Parameters.AddWithValue("@Ma_The_loai", TxtMaTl.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
            End If

            'làm mới bảng
            frmQuantl_Load(Nothing, Nothing)
        End If
        conn.Close()

    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim query As String = "update the_loai set Ten_the_loai=@Ten_the_loai where Ma_the_loai=@Ma_the_loai"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Try
            TxtTenTl.Focus()
            If TxtTenTl.Text = "" Or Regex.IsMatch(TxtTenTl.Text, "['-]") Then
                MessageBox.Show("Bạn chưa điền tên thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                conn.Open()
                'them cap nhat bang tác giả
                save.Parameters.AddWithValue("@Ma_the_loai", TxtMaTl.Text)
                save.Parameters.AddWithValue("@Ten_the_loai", TxtTenTl.Text)
                save.ExecuteNonQuery()
                conn.Close() 'đóng kết nối
                MessageBox.Show("Lưu thành công")

                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                TxtMaTl.Text = Nothing
                TxtTenTl.Text = Nothing
                frmQuantl_Load(Nothing, Nothing)
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()

    End Sub

    Private Sub btnTK_Click(sender As Object, e As EventArgs) Handles btnTK.Click

        If TxtMaTl2.Text = "" Then
            TxtMaTl2.Text = "%"
        End If
        Dim TG As New SqlDataAdapter("select Ma_the_loai as 'Mã Thể loại', Ten_the_loai as 'Tên thể loại' from  the_loai where ma_the_loai like '" & TxtMaTl2.Text & "' and ten_the_loai like '%" & TxtTenTL2.Text & "%'", conn)
        conn.Open()
        db.Clear()
        DgvTL.DataSource = db.DefaultView
        TG.Fill(db)
        matl = DgvTL.Item(0, 0).Value
        tentl = DgvTL.Item(1, 0).Value
        TxtTenTl.Text = tentl
        TxtMaTl.Text = matl
        Dim sach As New SqlDataAdapter("select the_loai.Ma_the_loai as 'Mã Thể loại', Ten_the_loai as 'Tên Thể loại ',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  the_loai,sach where sach.ma_the_loai=the_loai.ma_the_loai and the_loai.ma_the_loai = '" & TxtMaTl.Text & "' ", conn)
        db2.Clear()
        dgvSach.DataSource = db2.DefaultView
        sach.Fill(db2)
        conn.Close()
        TxtMaTl2.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class