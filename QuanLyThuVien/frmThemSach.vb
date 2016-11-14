Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmThemSach
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim masach As String
    Dim noiluu As String = Application.StartupPath & "\data\hinh\"
    Dim tenhinh As String
    Dim duongdan As String
    Dim chonhinh As Boolean
    Private Sub btnThemTDS_Click(sender As Object, e As EventArgs) Handles btnThemSach.Click
        Dim query As String = " insert into SACH values(@Ten_sach,@Ma_tac_gia,@Ma_NXB,@Ma_ke,@Ma_the_loai,@Ngay_phat_hanh,@Ghi_chu)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()

        Try
            TxtTenSach.Focus()
            If TxtTenSach.Text = "" Or Regex.IsMatch(TxtTenSach.Text, "['-]") Then
                MessageBox.Show("Bạn chưa nhập Tên sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                CboNXB.Focus()
                If CboNXB.Text = "" Then
                    MessageBox.Show("Bạn chưa chọn nhà xuất bản", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    CboTacGia.Focus()
                    If CboTacGia.Text = "" Then
                        MessageBox.Show("Bạn chưa chọn tác giả cho sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        CboTenKe.Focus()
                        If CboTenKe.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập vị kệ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                        Else
                            CboTheLoai.Focus()
                            If CboTheLoai.Text = "" Then
                                MessageBox.Show("Bạn chưa chọnthể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                DtpNgayPH.Focus()
                                If DtpNgayPH.Text = "" Then
                                    MessageBox.Show("Ngày phát hành không được bỏ trống", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    '   them vao bang sach

                                    save.Parameters.AddWithValue("@Ten_sach", TxtTenSach.Text)

                                    save.Parameters.AddWithValue("@Ma_tac_gia", CboTacGia.SelectedValue.ToString)
                                    save.Parameters.AddWithValue("@Ma_NXB", CboNXB.SelectedValue.ToString)

                                    save.Parameters.AddWithValue("@Ngay_phat_hanh", DtpNgayPH.Value.ToString("MM/dd/yyyy"))
                                    save.Parameters.AddWithValue("@Ma_ke", CboTenKe.SelectedValue.ToString)
                                    save.Parameters.AddWithValue("@Ma_the_loai", CboTheLoai.SelectedValue.ToString)
                                    save.Parameters.AddWithValue("@Ghi_chu", txtNoiDungTDS.Text)
                                    save.ExecuteNonQuery()

                                    'tiến hành chép file ảnh vào thư mục của ứng dụng
                                    If chonhinh = True Then
                                        Dim dbms As New DataTable
                                        Dim ms As New SqlDataAdapter("select top 1 Ma_sach from Sach order by Ma_sach Desc ", conn)
                                        dbms.Clear()
                                        ms.Fill(dbms)
                                        masach = dbms.Rows(0)(0).ToString
                                        If System.IO.File.Exists(noiluu & masach & ".jpg") Then
                                            Kill(noiluu & masach & ".jpg")
                                            FileCopy(duongdan, noiluu & tenhinh & "1")
                                            Rename(noiluu & tenhinh & "1", noiluu & masach & ".jpg")
                                        Else
                                            FileCopy(duongdan, noiluu & tenhinh & "1")
                                            Rename(noiluu & tenhinh & "1", noiluu & masach & ".jpg")
                                        End If
                                    End If
                                    frmQuanLySach.DgvSach.Rows(0).Selected = True
                                    conn.Close() 'đóng kết nối
                                    MessageBox.Show("Lưu thành công")
                                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                    Dim db2 As New DataTable
                                    Dim sach2 As New SqlDataAdapter("select sach.Ma_sach  as 'Mã Sách', Ten_sach  as 'Tên Sách',ten_the_loai  as 'Thể loại', ten_tac_gia   as 'Tên Tác Giả', Ten_NXB   as 'Tên NXB',Ten_ke as 'Tên kệ',Ngay_phat_hanh    as 'Ngày phát hành',ghi_chu as 'Ghi chú' from  SACH,Tac_gia,The_loai,nxb,ke where sach.Ma_tac_gia=tac_gia.Ma_tac_gia and sach.Ma_NXB=nxb.Ma_NXB and sach.Ma_ke=ke.Ma_ke and sach.Ma_the_loai=the_loai.Ma_the_loai", conn)
                                    db2.Clear()
                                    frmQuanLySach.DgvSach.DataSource = db2.DefaultView
                                    sach2.Fill(db2)
                                    frmQuanLySach.DgvSach.Rows(0).Selected = True

                                    Me.Controls.Clear() 'removes all the controls on the form
                                    InitializeComponent() 'load all the controls again
                                    frmThemSach_Load(Nothing, Nothing)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        conn.Close()
    End Sub

    Private Sub frmThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dake As New SqlDataAdapter("select * from Ke", conn)
        Dim datg As New SqlDataAdapter("select * from Tac_gia", conn)
        Dim daNXB As New SqlDataAdapter("select * from NXB", conn)
        Dim daTL As New SqlDataAdapter("select * from The_loai", conn)

        Dim dske As New DataSet
        Dim dstg As New DataSet
        Dim dsNXB As New DataSet
        Dim dsTL As New DataSet


        Try
            'load mã kệ
            conn.Open()
            dake.Fill(dske)
            CboTenKe.DataSource = dske.Tables(0)
            CboTenKe.DisplayMember = "Ten_ke"
            CboTenKe.ValueMember = "Ma_ke"
            CboTenKe.SelectedIndex = 0

            'load mã TG

            datg.Fill(dstg)
            CboTacGia.DataSource = dstg.Tables(0)
            CboTacGia.DisplayMember = "Ten_tac_gia"
            CboTacGia.ValueMember = "Ma_Tac_gia"
            CboTacGia.SelectedIndex = 0



            'load mã NXB

            daNXB.Fill(dsNXB)
            CboNXB.DataSource = dsNXB.Tables(0)
            CboNXB.DisplayMember = "Ten_nxb"
            CboNXB.ValueMember = "Ma_nxb"
            CboNXB.SelectedIndex = 0

            'load mã thể loại

            daTL.Fill(dsTL)
            CboTheLoai.DataSource = dsTL.Tables(0)
            CboTheLoai.DisplayMember = "Ten_the_loai"
            CboTheLoai.ValueMember = "Ma_the_loai"
            CboTheLoai.SelectedIndex = 0
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Cần nhập thông tin tác giả, nhà xuất bản, thể loại, kệ trước khi thêm sách")
            Me.Close()
        End Try
        conn.Close()
    End Sub


    Private Sub BtnHuy_Click(sender As Object, e As EventArgs) Handles BtnHuy.Click
        Me.Close()
    End Sub

    Private Sub btnChonHinhAnhTDS_Click(sender As Object, e As EventArgs) Handles btnChonHinhAnhTDS.Click
        Dim hinhanh As New OpenFileDialog
        'điều kiện để lấy file
        If hinhanh.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            duongdan = hinhanh.FileName
            If duongdan.EndsWith(".jpg") Then
                tenhinh = hinhanh.FileName.Substring(hinhanh.FileName.LastIndexOf("\") + 1)
                chonhinh = True
            Else
                MessageBox.Show("Chỉ cho phép file JPG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                hinhanh.FileName = Nothing
                duongdan = Nothing
                Exit Sub
            End If
        Else
            chonhinh = False
            Exit Sub
        End If
        Dim image As Image
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(duongdan, IO.FileMode.Open, IO.FileAccess.Read)
        image = System.Drawing.Image.FromStream(fs)
        fs.Close()
        PtbAnh.BackgroundImage = image
        lblTenHinh.Text = tenhinh
    End Sub

End Class