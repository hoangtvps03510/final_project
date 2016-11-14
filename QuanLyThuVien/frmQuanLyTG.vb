Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmQuanLyTG
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim matg, tentg As String

    Private Sub frmQuantg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim TG As New SqlDataAdapter("select Ma_tac_gia as 'Mã Tác Giả', Ten_tac_gia as 'Tên Tác Giả' from  TAC_GIA", conn)

        db.Clear()
        DgvTG.DataSource = db.DefaultView
        TG.Fill(db)
        matg = DgvTG.Item(0, 0).Value
        tentg = DgvTG.Item(1, 0).Value
        TxtTenTG.Text = tentg
        TxtMaTG.Text = matg
        Dim sach As New SqlDataAdapter("select tac_gia.Ma_tac_gia as 'Mã Tác Giả', Ten_tac_gia as 'Tên Tác Giả',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  TAC_GIa,sach where sach.ma_tac_gia=TAC_GIa.ma_tac_gia and TAC_GIa.ma_tac_gia = '" & TxtMaTG.Text & "' ", conn)
        db2.Clear()
        dgvSach.DataSource = db2.DefaultView
        sach.Fill(db2)
            conn.Close()
        Catch ex As Exception
            MsgBox("Chưa có dữ liệu")
        End Try
        conn.Close()
    End Sub

    Private Sub DgvTG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTG.CellContentClick, dgvSach.CellContentClick
        Dim click As Integer = DgvTG.CurrentCell.RowIndex
        matg = DgvTG.Item(0, click).Value
        tentg = DgvTG.Item(1, click).Value
        TxtTenTG.Text = tentg
        TxtMaTG.Text = matg
        conn.Open()
        Dim sach As New SqlDataAdapter("select tac_gia.Ma_tac_gia as 'Mã Tác Giả', Ten_tac_gia as 'Tên Tác Giả',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  TAC_GIa,sach where sach.ma_tac_gia=TAC_GIa.ma_tac_gia and TAC_GIa.ma_tac_gia = '" & TxtMaTG.Text & "' ", conn)
        db2.Clear()
        dgvSach.DataSource = db2.DefaultView
        sach.Fill(db2)
        conn.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = "insert into TAC_GIA values(@Ten_tac_gia) "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Try
            TxtTenTG.Focus()
            If TxtTenTG.Text = "" Or Regex.IsMatch(TxtTenTG.Text, "['-]") Then
                MessageBox.Show("Bạn chưa điền tên tác giả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                'them vao bang bang tác giả
                conn.Open()

                save.Parameters.AddWithValue("@Ten_tac_gia", TxtTenTG.Text)
                save.ExecuteNonQuery()
                conn.Close() 'đóng kết nối
                MessageBox.Show("Lưu thành công")
                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                TxtMaTG.Text = Nothing
                TxtTenTG.Text = Nothing


            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("trùng mã tác giả", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
        'load lai form
        frmQuantg_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        ' Lệnh xóa tác giả
        Dim query As String = "delete from TAC_GIA where Ma_tac_gia=@Ma_tac_gia"
        Dim delete As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Dim resulft As DialogResult = MessageBox.Show("Mọi dữ liệu liên đến tác giả " & tentg & " sẽ bị xóa. ", "Bạn chắc chứ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' hỏi trước khi xóa
        If resulft = Windows.Forms.DialogResult.Yes Then
            ' Gán biến để xóa
            Dim sodong As Integer = db2.Rows.Count
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
                delete.Parameters.AddWithValue("@Ma_tac_gia", TxtMaTG.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
            Else
                delete.Parameters.AddWithValue("@Ma_tac_gia", TxtMaTG.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
            End If

            'làm mới bảng
            frmQuantg_Load(Nothing, Nothing)
        End If
        conn.Close()

    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim query As String = "update TAC_GIA set Ten_tac_gia=@Ten_tac_gia where Ma_tac_gia=@Ma_tac_gia "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Try
            TxtTenTG.Focus()
            If TxtTenTG.Text = "" Or Regex.IsMatch(TxtTenTG.Text, "['-]") Then
                MessageBox.Show("Bạn chưa điền tên tác giả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                conn.Open()
                'them cap nhat bang tác giả
                save.Parameters.AddWithValue("@Ma_tac_gia", TxtMaTG.Text)
                save.Parameters.AddWithValue("@Ten_tac_gia", TxtTenTG.Text)
                save.ExecuteNonQuery()
                conn.Close() 'đóng kết nối
                MessageBox.Show("Lưu thành công")

                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                TxtMaTG.Text = Nothing
                TxtTenTG.Text = Nothing
                frmQuantg_Load(Nothing, Nothing)
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()

    End Sub

    Private Sub btnTK_Click(sender As Object, e As EventArgs) Handles btnTK.Click
        If TxtMaTG2.Text = "" Then
            TxtMaTG2.Text = "%"
        End If
        Dim TG As New SqlDataAdapter("select Ma_tac_gia as 'Mã Tác Giả', Ten_tac_gia as 'Tên Tác Giả' from  TAC_GIA where ma_tac_gia like '" & TxtMaTG2.Text & "' and ten_tac_gia like '%" & TxtTenTG2.Text & "%'", conn)
        conn.Open()
        db.Clear()
        DgvTG.DataSource = db.DefaultView
        TG.Fill(db)
        matg = DgvTG.Item(0, 0).Value
        tentg = DgvTG.Item(1, 0).Value
        TxtTenTG.Text = tentg
        TxtMaTG.Text = matg
        Dim sach As New SqlDataAdapter("select tac_gia.Ma_tac_gia as 'Mã Tác Giả', Ten_tac_gia as 'Tên Tác Giả',  ma_sach as 'Mã sách',ten_sach as 'Tên sách' from  TAC_GIa,sach where sach.ma_tac_gia=TAC_GIa.ma_tac_gia and TAC_GIa.ma_tac_gia = '" & TxtMaTG.Text & "' ", conn)
        db2.Clear()
        dgvSach.DataSource = db2.DefaultView
        sach.Fill(db2)
        conn.Close()
        TxtMaTG2.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class