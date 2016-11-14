Imports System.Data.SqlClient
Imports System.Data.DataSet
Imports System.Text.RegularExpressions
Public Class frmQuanLyCP
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim db3 As New DataTable
    Dim masach, tensach, ngaygio, gia As String
    Private Sub frmQuanLyCP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim chonsach As New SqlDataAdapter("select * from sach", conn)
            Dim sach As New DataSet
            db3.Clear()
            chonsach.Fill(db3)

            'load tên sách
            chonsach.Fill(sach)
            CboTenSach.DataSource = sach.Tables(0)
            CboTenSach.DisplayMember = "Ten_sach"
            ' load dữ liệu lên datagridview
            Dim Gia As New SqlDataAdapter("select Sach.ma_sach as 'Mã sach',ten_sach as 'tên sach', gia_muon as 'Giá mượn',ngay_gio as 'ngày giờ' from  sach,bang_gia where sach.ma_sach=bang_gia.ma_sach", conn)
            db.Clear()
            DgvGia.DataSource = db.DefaultView
            Gia.Fill(db)
        Catch ex As Exception
            MessageBox.Show("Bạn cần thêm sách vào thư viện trước")
        End Try
        conn.Close()
        'load ngày giờ
        DtpNgay.Value = Now
        dtbTimKiem.Value = Now
    End Sub

   
   

    Private Sub CboTenSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTenSach.SelectedIndexChanged
        DtpNgay.Value = DateTime.Now
        CboTenSach.ValueMember = "ma_sach"
        TxtMaSach.Text = CboTenSach.SelectedValue.ToString
    End Sub

   
    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        Dim query As String = "insert into BANG_GIA values(@Ma_sach,@Ngay_gio,@Gia_muon) "
        Dim save As SqlCommand = New SqlCommand(query, conn)

        Try
            TxtMaSach.Focus()
            If TxtMaSach.Text = "" Or Not IsNumeric(TxtMaSach.Text) Then
                MessageBox.Show("Bạn chưa chọn sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else

                TxtGia.Focus()
                If TxtGia.Text = "" Or Not IsNumeric(TxtGia.Text) Then
                    MessageBox.Show("Bạn chưa nhập giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    'them vao bang bang nxb
                    conn.Open()
                    save.Parameters.AddWithValue("@Ngay_gio", DtpNgay.Value.ToString("MM/dd/yyyy HH:mm"))
                    save.Parameters.AddWithValue("@Ma_sach", TxtMaSach.Text)
                    save.Parameters.AddWithValue("@Gia_muon", TxtGia.Text)
                    save.ExecuteNonQuery()
                    conn.Close() 'đóng kết nối
                    MessageBox.Show("thêm thành công")
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                    TxtMaSach.Text = Nothing
                    TxtGia.Text = Nothing
                    DtpNgay.Text = Nothing

                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("không thể thêm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
        'load lai form
        frmQuanLyCP_Load(Nothing, Nothing)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim query As String = "delete from BANG_GIA where Ngay_gio=@Ngay_gio and Ma_sach=@Ma_sach "
        Dim del As SqlCommand = New SqlCommand(query, conn)
        Try
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' hỏi trước khi xóa
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                del.Parameters.AddWithValue("@Ngay_gio", DtpNgay.Value.ToString("MM/dd/yyyy  HH:mm"))
                del.Parameters.AddWithValue("@Ma_sach", TxtMaSach.Text)
                del.ExecuteNonQuery()
                conn.Close() 'đóng kết nối
                MessageBox.Show("xóa thành công")
                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                TxtMaSach.Text = Nothing
                TxtGia.Text = Nothing
                DtpNgay.Text = Nothing

            End If



        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("không thể xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
        'load lai form
        frmQuanLyCP_Load(Nothing, Nothing)
    End Sub

   

    Private Sub DgvGia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvGia.CellContentClick
        Dim click As Integer = DgvGia.CurrentCell.RowIndex

        masach = DgvGia.Item(0, click).Value
        tensach = DgvGia.Item(1, click).Value
        ngaygio = DgvGia.Item(3, click).Value
        gia = DgvGia.Item(2, click).Value
        TxtMaSach.Text = masach
        TxtGia.Text = gia
        CboTenSach.Text = tensach
        DtpNgay.Text = ngaygio


    End Sub


    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles btntk.Click
        Dim Gia As New SqlDataAdapter("select Sach.ma_sach as 'Mã sach',ten_sach as 'tên sach', gia_muon as 'Giá mượn',ngay_gio as 'ngày giờ' from  sach,bang_gia where sach.ma_sach=bang_gia.ma_sach and sach.ten_sach like N'%" & txttk.Text & "%' and ngay_gio = '" & dtbTimKiem.Value.ToString("MM/dd/yyyy  HH:mm") & "' ", conn)
        conn.Open()
        db.Clear()
        DgvGia.DataSource = db.DefaultView
        Gia.Fill(db)
        conn.Close()
    End Sub


    Private Sub TxtMaSach_EditValueChanged(sender As Object, e As EventArgs) Handles TxtMaSach.EditValueChanged
        DtpNgay.Value = DateTime.Now
    End Sub

    Private Sub TxtGia_EditValueChanged(sender As Object, e As EventArgs) Handles TxtGia.EditValueChanged
        DtpNgay.Value = DateTime.Now
    End Sub
End Class