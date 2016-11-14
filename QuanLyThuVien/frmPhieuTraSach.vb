Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.DataSet
Imports System.Text.RegularExpressions
Public Class frmPhieuTraSach
    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)
    Dim sql As String = "" &
    "SELECT ID_CTPM,PHIEU_MUON.Ma_phieu_muon as 'Mã Phiếu Mượn', SACH.Ma_sach as 'Mã Sách', Ten_sach as 'Tên Sách', THANH_VIEN.Ma_TV as 'Mã Thành Viên', Ten_TV as 'Tên Thành Viên', Gia_muon as 'Phí Mượn', Ngay_muon as 'Ngày Mượn' " &
    "FROM CHI_TIET_PHIEU_MUON " &
    "JOIN PHIEU_MUON ON CHI_TIET_PHIEU_MUON.Ma_phieu_muon =PHIEU_MUON.Ma_phieu_muon " &
    "JOIN SACH ON CHI_TIET_PHIEU_MUON.Ma_sach = SACH.Ma_sach " &
    "JOIN THANH_VIEN ON THANH_VIEN.Ma_TV = PHIEU_MUON.Ma_TV " &
    "JOIN BANG_GIA ON CHI_TIET_PHIEU_MUON.Ma_sach=BANG_GIA.Ma_sach " &
    "WHERE ID_CTPM NOT IN (SELECT ID_CTPM FROM CHI_TIET_PHIEU_TRA ) "
    Private Sub frmPhieuTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmPhieuMuonSach.Close()
        frmMuonSach.Close()
        Dim maphieu As String
        Dim mp1 As String = ""
        Dim mp2 As Integer = 0
        Dim dbmapt As New DataTable

        Dim conn As SqlDataAdapter
        Dim sql As String = "select max(cast(right(Ma_phieu_tra, 3) as int)) + 1 as 'Tên Phiếu' from PHIEU_TRA"

        dtpngaytra.Value = DateTime.Now

        'Tính mã phiếu tự tăng dần
        connect.Open()
        conn = New SqlDataAdapter(sql, connect)
        dbmapt.Clear()
        conn.Fill(dbmapt)
        connect.Close()

        'Tự động sinh mã phiếu
        Try
            mp2 = dbmapt.Rows(0)(0)
            If mp2 < 10 Then
                mp1 = "PT000"
            Else
                If mp2 < 100 Then
                    mp1 = "PT00"
                Else
                    If mp2 < 1000 Then
                        mp1 = "PT0"
                    Else
                        If mp2 < 10000 Then
                            mp1 = "PT"
                        End If
                    End If
                End If
            End If
            maphieu = mp1 & mp2.ToString
        Catch ex As Exception
            maphieu = "PT0001"
        End Try
        txtmaphieu.Text = maphieu

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






    Private Sub txttentv_EditValueChanged(sender As Object, e As EventArgs) Handles txttentv.TextChanged
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

    Private Sub txtmatv_EditValueChanged(sender As Object, e As EventArgs) Handles txtmatv.TextChanged
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

    Private Sub txtmanv_EditValueChanged(sender As Object, e As EventArgs) Handles txtmanv.EditValueChanged

    End Sub

    Private Sub btnLuuPhieu_Click(sender As Object, e As EventArgs) Handles btnLuuPhieu.Click
        Dim sosach As Integer = (dgvtra.Rows.Count - 1)


        If txttentv.Text = "" Or Regex.IsMatch(txttentv.Text, "['-]") Then
            MessageBox.Show("Bạn chưa nhập tên thành viên", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtmatv.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã thành viên", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtmanv.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If sosach < 1 Then
                        MessageBox.Show("Bạn chưa chọn sách", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else
                        Dim queryPM As String = "Insert Into PHIEU_TRA values (@MAPT,@NGAY,@MANV)"
                        Dim insertPM As SqlCommand = New SqlCommand(queryPM, connect)
                        Dim i As Integer = 0
                        Dim maphieu As String
                        maphieu = txtmaphieu.Text
                        connect.Open() 'mở kết nối
                        insertPM.Parameters.AddWithValue("@MAPT", txtmaphieu.Text)
                        insertPM.Parameters.AddWithValue("@NGAY", dtpngaytra.Value.ToString("MM/dd/yyyy HH:mm"))
                        insertPM.Parameters.AddWithValue("@MANV", txtmanv.Text)
                        insertPM.ExecuteNonQuery()
                        connect.Close()

                        Do While i < sosach
                            Dim queryCTPM As String = "Insert into CHI_TIET_PHIEU_TRA values(@IDMUON,@MAPT,@TRANGTHAI,@THANHTIEN)"
                            Dim insertCTPM As SqlCommand = New SqlCommand(queryCTPM, connect)
                            connect.Open()
                            insertCTPM.Parameters.AddWithValue("@IDMUON", dgvtra.Rows(i).Cells(0).Value)
                            insertCTPM.Parameters.AddWithValue("@MAPT", txtmaphieu.Text)
                            Dim kiemtra As Integer
                            If dgvtra.Rows(i).Cells(6).Value = True Then
                                kiemtra = 1
                            Else
                                kiemtra = 0
                            End If
                            insertCTPM.Parameters.AddWithValue("@TRANGTHAI", kiemtra)
                            insertCTPM.Parameters.AddWithValue("@THANHTIEN", dgvtra.Rows(i).Cells(5).Value)
                            insertCTPM.ExecuteNonQuery()
                            i += 1
                            connect.Close()
                        Loop
                        MessageBox.Show("Trả Sách thành công")
                        frmTraSach.Close()
                        Me.Controls.Clear() 'removes all the controls on the form
                        InitializeComponent() 'load all the controls again
                        frmPhieuTraSach_Load(Nothing, Nothing)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnHuy1_Click(sender As Object, e As EventArgs) Handles btnHuy1.Click
        frmTraSach.Close()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frmPhieuTraSach_Load(Nothing, Nothing)
    End Sub

    Private Sub btnThoat1_Click(sender As Object, e As EventArgs) Handles btnThoat1.Click
        Dim sosach As Integer = (dgvtra.Rows.Count - 1)
        If txttentv.Text <> "" Or txtmatv.Text <> "" Or txtmanv.Text <> "" Or sosach > 0 Then
            Dim result As DialogResult = MessageBox.Show("Phiếu chưa được lưu. Bạn có muốn Thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                frmTraSach.Close()
            End If
        Else
            Me.Close()
            frmTraSach.Close()
        End If
    End Sub

    Private Sub btnChonSach1_Click(sender As Object, e As EventArgs) Handles btnChonSach1.Click
        frmTraSach.MdiParent = frmMainform
        frmTraSach.Show()
        frmTraSach.BringToFront()

        frmTraSach.txttentv.Text = txttentv.Text
    End Sub

    Private Sub btnXoaDong1_Click(sender As Object, e As EventArgs) Handles btnXoaDong1.Click
        'Try
        If dgvtra.Rows.Count < 2 Then
            Exit Sub
        End If

        Dim click As Integer = dgvtra.CurrentCell.RowIndex
        If Not dgvtra.Rows(click).Cells(0).Value Is Nothing Then
            dgvtra.Rows.RemoveAt(click)


            frmTraSach.txtsosach.Text -= 1

            'Tính tổng tiền mượn
            Dim sosach As Integer = (dgvtra.Rows.Count - 1)
            Dim i As Integer = 0
            Dim DK As String
            Dim thanhtien As Integer
            Do While i < sosach
                thanhtien += dgvtra.Rows(i).Cells(5).Value
                DK &= "AND ID_CTPM <> " & dgvtra.Rows(i).Cells(0).Value.ToString & ""
                i += 1
            Loop
            txtthanhtien.Text = thanhtien

            Dim sqlnew As String
            Dim conn As SqlDataAdapter
            Dim db As New DataTable
            sqlnew = sql & DK
            connect.Open()
            conn = New SqlDataAdapter(sqlnew, connect)
            frmTraSach.dgvsachmuon.DataSource = db.DefaultView
            db.Clear()
            conn.Fill(db)
            connect.Close()

            If sosach = 0 Then
                txtmatv.Text = ""
                txtmatv.Enabled = True
                txttentv.Text = ""
                txtmatv.Enabled = True
            End If
        End If
        'Catch ex As Exception
        'MessageBox.Show("chưa chọn sách để xóa")
        'End Try
    End Sub
End Class