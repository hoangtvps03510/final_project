Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class FrmQuanLyKe
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim db3 As New DataTable
    Dim db4 As New DataTable

    Dim make, tenke, makhu, tenkhu, makhu2, tenkhu2 As String
   
    Private Sub frmQuanlyke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'phân quyền
        Dim db5 As New DataTable
        Dim TK As New SqlDataAdapter("select TAI_KHOAN.username, chuc_vu from NHAN_VIEN,TAI_KHOAN where NHAN_VIEN.username=TAI_KHOAN.username and NHAN_VIEN.username = '" & frmMainform.btnNguoiDung.Caption & "' and Chuc_vu like N'quản lý'  ", conn)
        'load phan quyen form
        conn.Open()
        db5.Clear()
        TK.Fill(db5)
        If db5.Rows.Count > 0 Then
            BtnXoaKe.Enabled = True
        Else
            BtnXoaKe.Enabled = False
        End If
        TxtMaKhu.Text = ""
        txtMaKhu2.Text = ""
        Try

            'load dữ liệu lên datagridview

            Dim khu As New SqlDataAdapter("select ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  khu ", conn)

            db.Clear()
            dgvKhu.DataSource = db.DefaultView
            khu.Fill(db)
            If db.Rows.Count > 0 Then
                makhu = dgvKhu.Item(0, 0).Value
                tenkhu = dgvKhu.Item(1, 0).Value
                TxtMaKhu.Text = makhu
                TxtTenKhu.Text = tenkhu
            End If
            Dim ke As New SqlDataAdapter("select ma_ke as 'Mã kệ', ten_ke as 'Tên kệ', ke.ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  Ke, khu where khu.ma_khu=ke.ma_khu and ke.ma_khu like '" & TxtMaKhu.Text & "'", conn)
            db2.Clear()
            DgvKe.DataSource = db2.DefaultView
            ke.Fill(db2)
            Dim khu2 As New SqlDataAdapter("select ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  khu ", conn)
            db3.Clear()
            dgvKhu2.DataSource = db3.DefaultView
            khu2.Fill(db3)
            If db3.Rows.Count > 0 Then
                makhu2 = dgvKhu2.Item(0, 0).Value
                tenkhu2 = dgvKhu2.Item(1, 0).Value
                txtMaKhu2.Text = makhu2
                txtTenKhu2.Text = tenkhu2
            End If
            Dim ke2 As New SqlDataAdapter("select ma_ke as 'Mã kệ', ten_ke as 'Tên kệ', ke.ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  Ke, khu where khu.ma_khu=ke.ma_khu and ke.ma_khu like '" & TxtMaKhu.Text & "'", conn)
            db4.Clear()
            dgvKe2.DataSource = db4.DefaultView
            ke2.Fill(db4)
            Try
                make = dgvKe2.Item(0, 0).Value
                tenke = dgvKe2.Item(1, 0).Value
                txtMaKe.Text = make
                txtTenKe.Text = tenke
            Catch ex As Exception

            End Try
            conn.Close()
        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

   
    Private Sub Dgvkhu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhu.CellContentClick
        Dim click As Integer = dgvKhu.CurrentCell.RowIndex
        makhu = dgvKhu.Item(0, click).Value
        tenkhu = dgvKhu.Item(1, click).Value
        TxtMaKhu.Text = makhu
        TxtTenKhu.Text = tenkhu
        conn.Open()
        Dim ke As New SqlDataAdapter("select ma_ke as 'Mã kệ', ten_ke as 'Tên kệ', ke.ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  Ke, khu where khu.ma_khu=ke.ma_khu and ke.ma_khu= '" & TxtMaKhu.Text & "'", conn)
        db2.Clear()
        DgvKe.DataSource = db2.DefaultView
        ke.Fill(db2)
        conn.Close()

    End Sub
    Private Sub BtnThemke_Click(sender As Object, e As EventArgs) Handles BtnThemke.Click
        Dim query1 As String = "insert into khu values(@ten_khu) "
        Dim query2 As String = " insert into ke values(@ten_ke,@ma_khu)"
        Dim save As SqlCommand = New SqlCommand(query1, conn)
        Dim save2 As SqlCommand = New SqlCommand(query2, conn)
        conn.Open()

        If tabChonQL.SelectedIndex = 0 Then
            Try
                TxtTenKhu.Focus()
                If TxtTenKhu.Text = "" Or Regex.IsMatch(TxtTenKhu.Text, "['-]") Then
                    MessageBox.Show("Bạn chưa tên Khu", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    save.Parameters.AddWithValue("@ten_khu", TxtTenKhu.Text)
                    save.ExecuteNonQuery()
                    MessageBox.Show("Lưu thành công")
                    TxtMaKhu.Reset()
                    TxtTenKhu.Reset()
                End If

            Catch ex As Exception
                MessageBox.Show("Mã khu đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        ElseIf tabChonQL.SelectedIndex = 1 Then
            Try
                txtTenKe.Focus()
                If txtTenKe.Text = "" Or Regex.IsMatch(txtTenKe.Text, "['-]") Then
                    MessageBox.Show("Bạn chưa nhập tên kệ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKhu2.Focus()
                    If txtTenKhu2.Text = "" Or Regex.IsMatch(txtTenKhu2.Text, "['-]") Then
                        MessageBox.Show("Bạn chưa tên Khu", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        save2.Parameters.AddWithValue("@ten_ke", txtTenKe.Text)
                        save2.Parameters.AddWithValue("@ma_khu", txtMaKhu2.Text)
                        save2.ExecuteNonQuery()
                        MessageBox.Show("Lưu thành công")
                    End If
                End If
            Catch ex As Exception
            MessageBox.Show("Mã kệ đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        End If

        conn.Close()
        'load lai form
        frmQuanlyke_Load(Nothing, Nothing)
    End Sub


    Private Sub BtnXoaKe_Click(sender As Object, e As EventArgs) Handles BtnXoaKe.Click
        ' Lệnh xóa bảng khu

        Dim query As String = "delete from ke where Ma_khu=@Ma_khu delete from khu where Ma_khu=@Ma_khu"
        Dim delete As SqlCommand = New SqlCommand(query, conn)
        Dim query4 As String = "delete from ke where Ma_ke=@Ma_ke"
        Dim delete4 As SqlCommand = New SqlCommand(query4, conn)
        Dim query2 As New SqlDataAdapter("select ma_sach, khu.ma_khu from sach,ke,khu where sach.ma_ke = ke.ma_ke and khu.ma_khu = ke.ma_khu and khu.ma_khu = '" & TxtMaKhu.Text & "'", conn)
        conn.Open()
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' hỏi trước khi xóa
        If resulft = Windows.Forms.DialogResult.Yes Then
            'xóa tab khu
                If tabChonQL.SelectedIndex = 0 Then
                Dim sodong As Integer = db2.Rows.Count
                If sodong > 0 Then
                    ' Gán biến để xóa
                    Dim i As Integer
                    For i = 0 To sodong - 1
                        Dim dbmapt As New DataTable
                        Dim ma As New SqlDataAdapter("select ID_CTPT from CHI_TIET_PHIEU_MUON,CHI_TIET_PHIEU_TRA,KE,SACH where CHI_TIET_PHIEU_MUON.ID_CTPM=CHI_TIET_PHIEU_TRA.ID_CTPM and SACH.Ma_ke=ke.Ma_ke and SACH.Ma_sach= CHI_TIET_PHIEU_MUON.Ma_sach and ke.Ma_ke ='" & db2.Rows(i)(0).ToString & "'", conn)
                        dbmapt.Clear()
                        ma.Fill(dbmapt)
                        If dbmapt.Rows.Count > 0 Then
                            Dim a As Integer
                            For a = 0 To dbmapt.Rows.Count - 1
                                Dim query3 As String = "delete from Chi_Tiet_Phieu_Tra where ID_CTPT=@mapt"
                                Dim delete3 As SqlCommand = New SqlCommand(query3, conn)
                                delete3.Parameters.AddWithValue("@mapt", dbmapt.Rows(a)(0).ToString)
                                delete3.ExecuteNonQuery()

                            Next
                        End If
                        Dim dbmasach As New DataTable
                        Dim masach As New SqlDataAdapter("select sach.ma_sach from KE,SACH where  SACH.Ma_ke=ke.Ma_ke and ke.Ma_ke ='" & db2.Rows(i)(0).ToString & "'", conn)
                        dbmasach.Clear()
                        masach.Fill(dbmasach)
                        If dbmasach.Rows.Count > 0 Then
                            Dim b As Integer
                            For b = 0 To dbmasach.Rows.Count - 1
                                Dim queryDel6 As String = "delete from bang_gia where Ma_sach=@Ma_sach delete from Chi_Tiet_Phieu_muon where Ma_sach=@Ma_sach delete from chi_tiet_kho where Ma_sach=@Ma_sach delete from sach where Ma_sach=@Ma_sach "
                                Dim delete6 As SqlCommand = New SqlCommand(queryDel6, conn)
                                delete6.Parameters.AddWithValue("@Ma_sach", dbmasach.Rows(b)(0).ToString)
                                delete6.ExecuteNonQuery()
                            Next
                        End If

                    Next
                    delete.Parameters.AddWithValue("@Ma_khu", TxtMaKhu.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                Else
                    Dim query8 As String = "delete from ke where Ma_khu=@Ma_khu delete from khu where Ma_khu=@Ma_khu"
                    Dim delete8 As SqlCommand = New SqlCommand(query8, conn)
                    delete8.Parameters.AddWithValue("@Ma_khu", TxtMaKhu.Text)
                    delete8.ExecuteNonQuery()
                    MessageBox.Show("Xóa thành công")
                    conn.Close()
                End If
            ElseIf tabChonQL.SelectedIndex = 1 Then
                ' xóa tab kệ
                Dim sodong As Integer = db4.Rows.Count
                If sodong > 0 Then
                    Dim i As Integer
                    For i = 0 To sodong - 1
                        Dim dbmapt As New DataTable
                        Dim ma As New SqlDataAdapter("select ID_CTPT from CHI_TIET_PHIEU_MUON,CHI_TIET_PHIEU_TRA,KE,SACH where CHI_TIET_PHIEU_MUON.ID_CTPM=CHI_TIET_PHIEU_TRA.ID_CTPM and SACH.Ma_ke=ke.Ma_ke and SACH.Ma_sach= CHI_TIET_PHIEU_MUON.Ma_sach and ke.Ma_ke ='" & db2.Rows(i)(0).ToString & "'", conn)
                        dbmapt.Clear()
                        ma.Fill(dbmapt)
                        If dbmapt.Rows.Count > 0 Then
                            Dim a As Integer
                            For a = 0 To dbmapt.Rows.Count - 1
                                Dim query3 As String = "delete from Chi_Tiet_Phieu_Tra where ID_CTPT=@mapt"
                                Dim delete3 As SqlCommand = New SqlCommand(query3, conn)
                                delete3.Parameters.AddWithValue("@mapt", dbmapt.Rows(a)(0).ToString)
                                delete3.ExecuteNonQuery()

                            Next
                        End If
                        Dim dbmasach As New DataTable
                        Dim masach As New SqlDataAdapter("select sach.ma_sach from KE,SACH where  SACH.Ma_ke=ke.Ma_ke and ke.Ma_ke ='" & db2.Rows(i)(0).ToString & "'", conn)
                        dbmasach.Clear()
                        masach.Fill(dbmasach)
                        If dbmasach.Rows.Count > 0 Then
                            Dim b As Integer
                            For b = 0 To dbmasach.Rows.Count - 1
                                Dim queryDel6 As String = "delete from bang_gia where Ma_sach=@Ma_sach delete from Chi_Tiet_Phieu_muon where Ma_sach=@Ma_sach delete from chi_tiet_kho where Ma_sach=@Ma_sach delete from sach where Ma_sach=@Ma_sach "
                                Dim delete6 As SqlCommand = New SqlCommand(queryDel6, conn)
                                delete6.Parameters.AddWithValue("@Ma_sach", dbmasach.Rows(b)(0).ToString)
                                delete6.ExecuteNonQuery()
                            Next
                        End If
                    Next
                    delete4.Parameters.AddWithValue("@Ma_ke", txtMaKe.Text)
                    delete4.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                Else
                    Dim query7 As String = "delete from ke where Ma_ke=@Ma_ke"
                    Dim delete7 As SqlCommand = New SqlCommand(query7, conn)
                    delete7.Parameters.AddWithValue("@Ma_ke", txtMaKe.Text)
                    delete7.ExecuteNonQuery()
                    MessageBox.Show("Xóa thành công")
                    conn.Close()
                End If
            End If
        End If

        conn.Close()
        'làm mới bảng
        frmQuanlyke_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim query As String = "update khu set ten_khu=@ten_khu where Ma_khu=@Ma_khu  "
        Dim update As SqlCommand = New SqlCommand(query, conn)
        Dim query2 As String = "update ke set ten_ke=@ten_ke where Ma_ke=@Ma_ke "
        Dim update2 As SqlCommand = New SqlCommand(query2, conn)
        Try
            conn.Open()
            If tabChonQL.SelectedIndex = 0 Then
                'them cap nhat bang khu
                update.Parameters.AddWithValue("@Ma_khu", TxtMaKhu.Text)
                update.Parameters.AddWithValue("@ten_khu", TxtTenKhu.Text)
                update.ExecuteNonQuery()
                MessageBox.Show("Lưu thành công")
                conn.Close()
            ElseIf tabChonQL.SelectedIndex = 1 Then
                'them cap nhat bang kệ
                update2.Parameters.AddWithValue("@ten_ke", txtTenKe.Text)
                update2.Parameters.AddWithValue("@Ma_ke", txtMaKe.Text)
                update2.ExecuteNonQuery()
                conn.Close() 'đóng kết nối
                MessageBox.Show("Lưu thành công")
            End If
            'Sau khi nhập thành công, tự động làm mới 
            frmQuanlyke_Load(Nothing, Nothing)


        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
    End Sub


    Private Sub dgvKhu2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhu2.CellContentClick
        Dim click As Integer = dgvKhu2.CurrentCell.RowIndex
        makhu2 = dgvKhu2.Item(0, click).Value
        tenkhu2 = dgvKhu2.Item(1, click).Value
        txtMaKhu2.Text = makhu2
        txtTenKhu2.Text = tenkhu2
        conn.Open()
        Dim ke As New SqlDataAdapter("select ma_ke as 'Mã kệ', ten_ke as 'Tên kệ', ke.ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  Ke, khu where khu.ma_khu=ke.ma_khu and ke.ma_khu= '" & txtMaKhu2.Text & "'", conn)
        db2.Clear()
        dgvKe2.DataSource = db2.DefaultView
        ke.Fill(db2)
        If db2.Rows.Count > 0 Then
            make = DgvKe.Item(0, 0).Value
            tenke = DgvKe.Item(1, 0).Value
            txtMaKe.Text = make
            txtTenKe.Text = tenke
        Else

            txtMaKe.Text = Nothing
            txtTenKe.Text = Nothing
        End If
        conn.Close()
    End Sub

    Private Sub dgvKe2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKe2.CellContentClick
        Dim click As Integer = dgvKe2.CurrentCell.RowIndex
        make = DgvKe.Item(0, click).Value
        tenke = DgvKe.Item(1, click).Value
        txtMaKe.Text = make
        txtTenKe.Text = tenke
    End Sub

 
    
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnTK.Click
            Dim khu As New SqlDataAdapter("select ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  khu where ten_khu like N'%" & txtTenTK.Text & "%' ", conn)
            conn.Open()
            Try
                db.Clear()
                dgvKhu.DataSource = db.DefaultView
                khu.Fill(db)
                makhu = dgvKhu.Item(0, 0).Value
                tenkhu = dgvKhu.Item(1, 0).Value
                TxtMaKhu.Text = makhu
                TxtTenKhu.Text = tenkhu
                Dim ke As New SqlDataAdapter("select ma_ke as 'Mã kệ', ten_ke as 'Tên kệ', ke.ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  Ke, khu where khu.ma_khu=ke.ma_khu and ten_khu like N'%" & txtTenTK.Text & "%' ", conn)
                db2.Clear()
                DgvKe.DataSource = db2.DefaultView
                ke.Fill(db2)
            Catch ex As Exception
                MessageBox.Show("Không tìm thấy khu này")
                frmQuanlyke_Load(Nothing, Nothing)
            End Try
            conn.Close()

    End Sub

    Private Sub btnTK2_Click(sender As Object, e As EventArgs) Handles btnTK2.Click
        Dim khu2 As New SqlDataAdapter("select khu.ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  Ke,khu where khu.ma_khu = ke.ma_khu and ke.ten_ke like N'%" & TxtTenTK2.Text & "%'  ", conn)
        conn.Open()
        Try
            db3.Clear()
            dgvKhu2.DataSource = db3.DefaultView
            khu2.Fill(db3)
            makhu2 = dgvKhu2.Item(0, 0).Value
            tenkhu2 = dgvKhu2.Item(1, 0).Value
            txtMaKhu2.Text = makhu2
            txtTenKhu2.Text = tenkhu2
            Dim ke2 As New SqlDataAdapter("select ma_ke as 'Mã kệ', ten_ke as 'Tên kệ', ke.ma_khu as 'Mã Khu', ten_khu as 'Tên Khu' from  Ke, khu where khu.ma_khu=ke.ma_khu and ke.ten_ke like N'%" & TxtTenTK2.Text & "%'", conn)
            db4.Clear()
            dgvKe2.DataSource = db4.DefaultView
            ke2.Fill(db4)
            make = dgvKe2.Item(0, 0).Value
            tenke = dgvKe2.Item(1, 0).Value
            txtMaKe.Text = make
            txtTenKe.Text = tenke
        Catch ex As Exception
            MessageBox.Show("Không tìm thấy kệ này")
            frmQuanlyke_Load(Nothing, Nothing)
        End Try
        conn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class