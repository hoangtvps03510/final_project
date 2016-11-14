Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.DataSet
Imports System.Text.RegularExpressions

Public Class frmPhieuMuonSach
    Dim kiemtra As Integer = 0
    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)
    Dim sql As String = "" &
    "SELECT SACH.Ma_sach as 'Mã Sách', Ten_sach as 'Tên Sách', SL as 'Số Lượng', Ten_tac_gia as 'Tác Giả', Ten_NXB as 'NXB', " &
    "Ten_the_loai as 'Thể Loại', Don_gia as 'Đơn Gía' " &
    "FROM SACH " &
    "JOIN " &
        "(SELECT Ma_sach, SUM(SL) AS 'SL' FROM( SELECT Ma_sach, Sum(So_luong) as 'SL' from CHI_TIET_KHO GROUP BY Ma_sach " &
        "UNION (SELECT Ma_sach, SUM(SL) AS 'SL' FROM ((SELECT Ma_sach, COUNT(*) * -1 AS 'SL' FROM CHI_TIET_PHIEU_MUON GROUP BY Ma_sach ) " &
        "UNION (SELECT Ma_sach, SUM(SL) AS 'SL' FROM ((SELECT Ma_sach, COUNT(*) AS 'SL' FROM CHI_TIET_PHIEU_TRA JOIN CHI_TIET_PHIEU_MUON ON CHI_TIET_PHIEU_TRA.ID_CTPM = CHI_TIET_PHIEU_MUON.ID_CTPM GROUP BY Ma_sach)" &
        "UNION (SELECT Ma_sach, COUNT(*) *-1 AS 'SLTT' FROM CHI_TIET_PHIEU_TRA JOIN CHI_TIET_PHIEU_MUON ON CHI_TIET_PHIEU_TRA.ID_CTPM = CHI_TIET_PHIEU_MUON.ID_CTPM " &
        "WHERE Trang_thai = 1 GROUP BY Ma_sach)) AS A " &
        "GROUP BY Ma_sach )) AS B " &
        "GROUP BY Ma_sach )) AS C GROUP BY Ma_sach) AS TONKHO ON SACH.Ma_sach = TONKHO.Ma_sach " &
    "JOIN TAC_GIA ON SACH.Ma_tac_gia= TAC_GIA.Ma_tac_gia " &
    "JOIN THE_LOAI ON SACH.Ma_the_loai=THE_LOAI.Ma_the_loai " &
    "JOIN NXB ON SACH.Ma_NXB=NXB.Ma_NXB " &
    "JOIN (SELECT Ma_sach, MAX(Don_gia) AS 'Don_gia' FROM CHI_TIET_KHO GROUP BY Ma_sach ) AS DONGIA ON SACH.Ma_sach  = DONGIA.Ma_sach "

    Private Sub btnHuy1_Click(sender As Object, e As EventArgs) Handles btnHuy1.Click
    Dim resulft As DialogResult = MessageBox.Show("Bạn có muốn hủy phiếu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resulft = Windows.Forms.DialogResult.Yes Then
            frmMuonSach.Close()
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
        End If
        frmphieumuonsach_Load(Nothing, Nothing)
    End Sub

    Private Sub frmphieumuonsach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmPhieuTraSach.Close()
        frmTraSach.Close()
        dtpngaymuon.Value = DateTime.Now
        Dim maphieu As String
        Dim mp1 As String = ""
        Dim mp2 As Integer = 0

        Dim dbmapm As New DataTable
        Dim conn As SqlDataAdapter
        Dim sql As String = "select max(cast(right(Ma_phieu_muon, 3) as int)) + 1 as 'Tên Phiếu' from PHIEU_MUON"
        'Tính mã phiếu tự tăng dần
        connect.Open()
        conn = New SqlDataAdapter(sql, connect)
        dbmapm.Clear()
        conn.Fill(dbmapm)
        connect.Close()

        Try
            mp2 = dbmapm.Rows(0)(0)
            If mp2 < 10 Then
                mp1 = "PM000"
            Else
                If mp2 < 100 Then
                    mp1 = "PM00"
                Else
                    If mp2 < 1000 Then
                        mp1 = "PM0"
                    Else
                        If mp2 < 10000 Then
                            mp1 = "PM"
                        End If
                    End If
                End If
            End If

            maphieu = mp1 & mp2.ToString

        Catch ex As Exception
            maphieu = "PM0001"
        End Try
        txtmaphieu.Text = maphieu

        'Tính tổng tiền cọc
        Dim sosach As Integer = (dgvgiohang.Rows.Count - 1)
        Dim i As Integer = 0
        Dim tiencoc As Integer
        Do While i < sosach
            tiencoc += dgvgiohang.Rows(i).Cells(3).Value.ToString
            i += 1
        Loop

        'Lấy mã nhân viên
        Dim username As String = frmMainform.btnNguoiDung.Caption
        Dim sqlmanv As String = "SELECT Ma_NV from NHAN_VIEN WHERE username like '" & username & "'"
        Dim data As New SqlDataAdapter(sqlmanv, connect)
        Dim dbmanv As New DataTable
        connect.Open()
        dbmanv.Clear()
        data.Fill(dbmanv)
        connect.Close()
        txtmanv.Text = dbmanv.Rows(0)(0)
    End Sub
    Private Sub btnXoaDong1_Click(sender As Object, e As EventArgs) Handles btnXoaDong1.Click
        If dgvgiohang.Rows.Count < 2 Then
            Exit Sub
        End If

    Dim click As Integer = dgvgiohang.CurrentCell.RowIndex

        If Not dgvgiohang.Rows(click).Cells(0).Value Is Nothing Then
            dgvgiohang.Rows.RemoveAt(click)
            frmMuonSach.txtsosach.Text -= 1

    Dim sqlnew As String
    Dim conn As SqlDataAdapter
    Dim db As New DataTable

    'Tính tổng tiền cọc
    Dim sosach As Integer = (dgvgiohang.Rows.Count - 1)
    Dim i As Integer = 0
    Dim DK As String
    Dim tongcoc As Integer

            If sosach = 0 Then
                sqlnew = sql
            Else
                Do While i < sosach
                    tongcoc += dgvgiohang.Rows(i).Cells(3).Value
                    DK &= "SACH.Ma_sach <> " & dgvgiohang.Rows(i).Cells(0).Value.ToString & " AND "
                    i += 1
                Loop
                sqlnew = sql & "WHERE " & Microsoft.VisualBasic.Left(DK, (Len(DK) - 4))

            End If
            txttiencoc.Text = tongcoc
            connect.Open()
            conn = New SqlDataAdapter(sqlnew, connect)
            frmMuonSach.dgvXemDanhSach.DataSource = db.DefaultView
            db.Clear()
            conn.Fill(db)
            connect.Close()
        End If


    End Sub

    Private Sub btnChonSach1_Click(sender As Object, e As EventArgs) Handles btnChonSach1.Click
        frmMuonSach.MdiParent = frmMainform
        frmMuonSach.Show()
        frmMuonSach.BringToFront()
    End Sub

    Private Sub btnThoat1_Click(sender As Object, e As EventArgs) Handles btnThoat1.Click
        Dim sosach As Integer = (dgvgiohang.Rows.Count - 1)
        If txttentv.Text <> "" Or txtmatv.Text <> "" Or txtmanv.Text <> "" Or sosach > 0 Then
            Dim result As DialogResult = MessageBox.Show("Phiếu chưa được lưu. Bạn có muốn Thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                frmMuonSach.Close()
            End If
        Else
            Me.Close()
            frmMuonSach.Close()
        End If

    End Sub

    Private Sub txttentv_EditValueChanged(sender As Object, e As EventArgs) Handles txttentv.EditValueChanged
        'load matv sau khi nhap ten
        Dim ketnoi As New SqlDataAdapter("select Ma_TV from THANH_VIEN where Ten_TV = N'" & txttentv.Text & "'", connect)
        Dim ds As New DataTable
        connect.Open()
        ketnoi.Fill(ds)
        connect.Close()

        If ds.Rows.Count < 1 Then
            txtmatv.Text = ""
            Exit Sub
        End If

        If txtmatv.Text = "" Then
            txtmatv.Text = ds.Rows(0)(0)
        Else
        End If
    End Sub

    Private Sub txtmatv_EditValueChanged(sender As Object, e As EventArgs) Handles txtmatv.EditValueChanged
        Dim dbtentv As New DataTable
        Dim sqltentv As String = "select Ten_TV from THANH_VIEN WHERE Ma_TV= '" & txtmatv.Text & "'"
        Dim ktuser As New SqlDataAdapter(sqltentv, connect)
        connect.Open()
        ktuser.Fill(dbtentv)
        connect.Close()

        If dbtentv.Rows.Count < 1 Then
            txttentv.Text = ""
            Exit Sub
        End If

        If txttentv.Text = "" Then
            txttentv.Text = dbtentv.Rows(0)(0)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnLuuPhieu_Click(sender As Object, e As EventArgs) Handles btnLuuPhieu.Click
        Dim sosach As Integer = (dgvgiohang.Rows.Count - 1)
        Dim conn2 As SqlDataAdapter
        Dim tongsachmuon As Integer
        Dim sqltongsachmuon As String = "" &
        "SELECT Ma_TV, count(Ma_sach) " &
        "FROM PHIEU_MUON JOIN CHI_TIET_PHIEU_MUON ON PHIEU_MUON.Ma_phieu_muon=CHI_TIET_PHIEU_MUON.Ma_phieu_muon " &
        "WHERE ID_CTPM NOT IN (SELECT ID_CTPM FROM CHI_TIET_PHIEU_TRA ) AND Ma_TV = " & txtmatv.Text & " " &
        "GROUP BY Ma_TV "
        Dim dbtongsachmuon As New DataTable

        txttentv.Focus()
        If txttentv.Text = "" Or Regex.IsMatch(txttentv.Text, "['-]") Then
            MessageBox.Show("Bạn chưa nhập tên thành viên", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtmatv.Focus()
            If txtmanv.Text = "" Or Not IsNumeric(txtmanv.Text) Then
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If sosach < 1 Then
                    MessageBox.Show("Bạn chưa chọn sách", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    conn2 = New SqlDataAdapter(sqltongsachmuon, connect)
                    dbtongsachmuon.Clear()
                    conn2.Fill(dbtongsachmuon)

                    If dbtongsachmuon.Rows.Count > 0 Then
                        tongsachmuon = dbtongsachmuon.Rows(0)(1)
                        If tongsachmuon >= 3 Then
                            MessageBox.Show("Thành Viên " & txttentv.Text & " đã mượn " & tongsachmuon & " cuốn", "Không thể mượn thêm")
                        Else
                            If tongsachmuon + sosach > 3 Then
                                MessageBox.Show("Thành Viên " & txttentv.Text & " đã mượn " & tongsachmuon & " cuốn, Chỉ được phép mượn thêm " & 3 - tongsachmuon & " cuốn ", "Vui lòng chọn lại")
                            Else
                                Dim queryPM As String = "Insert Into PHIEU_MUON values (@MAPM,@NGAY,@MATV,@MANV)"
                                Dim insertPM As SqlCommand = New SqlCommand(queryPM, connect)
                                Dim i As Integer = 0
                                Dim maphieu As String
                                maphieu = txtmaphieu.Text
                                connect.Open() 'mở kết nối
                                insertPM.Parameters.AddWithValue("@MAPM", txtmaphieu.Text)
                                insertPM.Parameters.AddWithValue("@NGAY", dtpngaymuon.Text)
                                insertPM.Parameters.AddWithValue("@MATV", txtmatv.Text)
                                insertPM.Parameters.AddWithValue("@MANV", txtmanv.Text)
                                insertPM.ExecuteNonQuery()
                                connect.Close()

                                Do While i < sosach
                                    Dim queryCTPM As String = "Insert into CHI_TIET_PHIEU_MUON values(@MAPM,@MASACH,@TIENCOC)"
                                    Dim insertCTPM As SqlCommand = New SqlCommand(queryCTPM, connect)
                                    connect.Open()
                                    insertCTPM.Parameters.AddWithValue("@MAPM", txtmaphieu.Text)
                                    insertCTPM.Parameters.AddWithValue("@MASACH", dgvgiohang.Rows(i).Cells(0).Value)
                                    insertCTPM.Parameters.AddWithValue("@TIENCOC", dgvgiohang.Rows(i).Cells(3).Value)
                                    insertCTPM.ExecuteNonQuery()
                                    i += 1
                                    connect.Close()
                                Loop
                                MessageBox.Show("Mượn Sách thành công")
                                frmMuonSach.Close()
                                Me.Controls.Clear() 'removes all the controls on the form
                                InitializeComponent() 'load all the controls again
                                frmphieumuonsach_Load(Nothing, Nothing)
                            End If
                        End If
                    Else
                        Dim queryPM As String = "Insert Into PHIEU_MUON values (@MAPM,@NGAY,@MATV,@MANV)"
                        Dim insertPM As SqlCommand = New SqlCommand(queryPM, connect)
                        Dim i As Integer = 0
                        Dim maphieu As String
                        maphieu = txtmaphieu.Text
                        connect.Open() 'mở kết nối
                        insertPM.Parameters.AddWithValue("@MAPM", txtmaphieu.Text)
                        insertPM.Parameters.AddWithValue("@NGAY", dtpngaymuon.Value.ToString("MM/dd/yyyy HH:mm"))
                        insertPM.Parameters.AddWithValue("@MATV", txtmatv.Text)
                        insertPM.Parameters.AddWithValue("@MANV", txtmanv.Text)
                        insertPM.ExecuteNonQuery()
                        connect.Close()

                        Do While i < sosach
                            Dim queryCTPM As String = "Insert into CHI_TIET_PHIEU_MUON values(@MAPM,@MASACH,@TIENCOC)"
                            Dim insertCTPM As SqlCommand = New SqlCommand(queryCTPM, connect)
                            connect.Open()
                            insertCTPM.Parameters.AddWithValue("@MAPM", txtmaphieu.Text)
                            insertCTPM.Parameters.AddWithValue("@MASACH", dgvgiohang.Rows(i).Cells(0).Value)
                            insertCTPM.Parameters.AddWithValue("@TIENCOC", dgvgiohang.Rows(i).Cells(3).Value)
                            insertCTPM.ExecuteNonQuery()
                            i += 1
                            connect.Close()
                        Loop
                        MessageBox.Show("Mượn Sách thành công")
                        frmMuonSach.Close()
                        Me.Controls.Clear() 'removes all the controls on the form
                        InitializeComponent() 'load all the controls again
                        frmphieumuonsach_Load(Nothing, Nothing)
                    End If
                End If
            End If
        End If
    End Sub





End Class