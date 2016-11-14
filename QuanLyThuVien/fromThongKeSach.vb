Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmThongKeSach
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim bang As String
    Dim thuoctinh As String
    Dim khoachinh As String
    Private Sub frmThongKeSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sach As New SqlDataAdapter("select chi_tiet_phieu_muon.Ma_sach  as 'Mã Sách', Ten_sach  as 'Tên Sách',ten_the_loai    as 'Thể loại', ten_tac_gia   as 'Tên Tác Giả', Ten_NXB   as 'Tên NXB',Ghi_chu as 'Ghi chú', ngay_nhap as ' Ngày nhập',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn' from  SACH,Tac_gia,The_loai,nxb,chi_tiet_kho,chi_tiet_phieu_muon where sach.Ma_tac_gia=tac_gia.Ma_tac_gia and sach.Ma_NXB=nxb.Ma_NXB and sach.Ma_the_loai=the_loai.Ma_the_loai and sach.ma_sach=chi_tiet_kho.ma_sach and sach.ma_sach=chi_tiet_phieu_muon.ma_sach group by chi_tiet_phieu_muon.ma_sach,Ten_sach,ten_the_loai,ten_tac_gia,Ten_NXB,Ghi_chu,ngay_nhap order by count(chi_tiet_phieu_muon.ma_sach) desc", conn)
        conn.Open()
        db.Clear()
        DataGridView1.DataSource = db.DefaultView
        sach.Fill(db)
        Dim sodong As Integer = DataGridView1.Rows.Count
        Dim i As Integer
        Dim a As Integer
        For i = 0 To sodong - 1
            a += db.Rows(i)(7).ToString
        Next
        TxtTongluotmuon.Text = a
        conn.Close()
        chkChiTiet.Hide()
    End Sub
    Private Sub chkChiTiet_CheckedChanged(sender As Object, e As EventArgs) Handles chkChiTiet.CheckedChanged
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select * from " & bang & "", conn)
        If chkChiTiet.Checked = True Then
            cbbGiaTri.Enabled = True
            conn.Open()
            da.Fill(ds)
            cbbGiaTri.DataSource = ds.Tables(0)
            cbbGiaTri.DisplayMember = thuoctinh
            cbbGiaTri.SelectedIndex = 0
            conn.Close()
        
        Else
            cbbGiaTri.Enabled = False
            chkChiTiet.Checked = False
            cbbGiaTri.Text = "Tất cả"
        End If
        conn.Close()
    End Sub
    Private Sub cbbLoai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbLoai.SelectedIndexChanged


        If cbbLoai.SelectedIndex > 0 Then
            chkChiTiet.Show()
            chkChiTiet.Enabled = True
            chkChiTiet.Text = "Chọn " + LCase(cbbLoai.Text)
        Else
            cbbGiaTri.Enabled = False
            chkChiTiet.Checked = False
            chkChiTiet.Hide()
            cbbGiaTri.Text = "Tất cả"
        End If
        If cbbLoai.SelectedIndex = 1 Then
            bang = "the_loai"
            thuoctinh = "ten_the_loai"
            khoachinh = "ma_the_loai"
        ElseIf cbbLoai.SelectedIndex = 2 Then
            bang = "tac_gia"
            thuoctinh = "ten_tac_gia"
            khoachinh = "ma_tac_gia"
        ElseIf cbbLoai.SelectedIndex = 3 Then
            bang = "NXB"
            thuoctinh = "ten_nxb"
            khoachinh = "ma_nxb"
        End If
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select * from " & bang & "", conn)
        If chkChiTiet.Checked = True Then
            cbbGiaTri.Enabled = True
            conn.Open()
            da.Fill(ds)
            cbbGiaTri.DataSource = ds.Tables(0)
            cbbGiaTri.DisplayMember = thuoctinh
            cbbGiaTri.SelectedIndex = 0
            conn.Close()
        End If
        conn.Close()
    End Sub
    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        ' select ten_the_loai as 'Thể loại',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn', sum(so_luong) as 'Số lượng sách trong kho' from sach,The_loai,chi_tiet_phieu_muon,chi_tiet_kho where sach.Ma_the_loai=the_loai.Ma_the_loai and sach.ma_sach=chi_tiet_phieu_muon.ma_sach and sach.ma_sach=chi_tiet_kho.ma_sach group by ten_the_loai
        Dim sach As New SqlDataAdapter
            If cbbKieu.SelectedIndex = 0 And cbbLoai.SelectedIndex = 0 Then
            Dim query As String = "select chi_tiet_phieu_muon.Ma_sach  as 'Mã Sách', Ten_sach  as 'Tên Sách',ten_the_loai    as 'Thể loại', ten_tac_gia   as 'Tên Tác Giả', Ten_NXB   as 'Tên NXB',ghi_chu    as 'Ghi chú', ngay_nhap as ' Ngày nhập',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn' from  SACH,Tac_gia,The_loai,nxb,chi_tiet_kho,chi_tiet_phieu_muon,phieu_muon where sach.Ma_tac_gia=tac_gia.Ma_tac_gia and sach.Ma_NXB=nxb.Ma_NXB and sach.Ma_the_loai=the_loai.Ma_the_loai and sach.ma_sach=chi_tiet_kho.ma_sach and sach.ma_sach=chi_tiet_phieu_muon.ma_sach and chi_tiet_phieu_muon.ma_phieu_muon= phieu_muon.ma_phieu_muon and ngay_muon <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy") & "' and ngay_muon >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy") & "' group by chi_tiet_phieu_muon.ma_sach,Ten_sach,ten_the_loai,ten_tac_gia,Ten_NXB,ghi_chu,ngay_nhap order by count(chi_tiet_phieu_muon.ma_sach) desc"
                sach = New SqlDataAdapter(query, conn)

            ElseIf cbbKieu.SelectedIndex > 0 And cbbLoai.SelectedIndex = 0 Then
            Dim query As String = "select " & cbbKieu.Text & " chi_tiet_phieu_muon.Ma_sach  as 'Mã Sách', Ten_sach  as 'Tên Sách',ten_the_loai    as 'Thể loại', ten_tac_gia   as 'Tên Tác Giả', Ten_NXB   as 'Tên NXB',ghi_chu    as 'Ghi chú', ngay_nhap as ' Ngày nhập',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn' from  SACH,Tac_gia,The_loai,nxb,chi_tiet_kho,chi_tiet_phieu_muon,phieu_muon where sach.Ma_tac_gia=tac_gia.Ma_tac_gia and sach.Ma_NXB=nxb.Ma_NXB and sach.Ma_the_loai=the_loai.Ma_the_loai and sach.ma_sach=chi_tiet_kho.ma_sach and sach.ma_sach=chi_tiet_phieu_muon.ma_sach and chi_tiet_phieu_muon.ma_phieu_muon= phieu_muon.ma_phieu_muon and ngay_muon <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy") & "' and ngay_muon >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy") & "' group by chi_tiet_phieu_muon.ma_sach,Ten_sach,ten_the_loai,ten_tac_gia,Ten_NXB,ghi_chu,ngay_nhap order by count(chi_tiet_phieu_muon.ma_sach) desc"
                sach = New SqlDataAdapter(query, conn)
            ElseIf cbbKieu.SelectedIndex = 0 And cbbLoai.SelectedIndex > 0 And chkChiTiet.Checked = False Then
                Dim query As String = "select " & thuoctinh & " as '" & cbbLoai.Text & "', sum(so_luong)-count(chi_tiet_phieu_muon.ma_sach) as 'Số lượng sách trong kho',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn' from sach," & bang & ",chi_tiet_phieu_muon,chi_tiet_kho,phieu_muon where sach." & khoachinh & "=" & bang & "." & khoachinh & " and sach.ma_sach=chi_tiet_phieu_muon.ma_sach and sach.ma_sach=chi_tiet_kho.ma_sach and chi_tiet_phieu_muon.ma_phieu_muon= phieu_muon.ma_phieu_muon and ngay_muon <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy") & "' and ngay_muon >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy") & "' group by " & thuoctinh & " order by count(chi_tiet_phieu_muon.ma_sach) desc"
                sach = New SqlDataAdapter(query, conn)
            ElseIf cbbKieu.SelectedIndex > 0 And cbbLoai.SelectedIndex > 0 And chkChiTiet.Checked = False Then
                Dim query As String = "select " & cbbKieu.Text & " " & thuoctinh & " as '" & cbbLoai.Text & "', sum(so_luong)-count(chi_tiet_phieu_muon.ma_sach) as 'Số lượng sách trong kho',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn' from sach," & bang & ",chi_tiet_phieu_muon,chi_tiet_kho,phieu_muon where sach." & khoachinh & "=" & bang & "." & khoachinh & " and sach.ma_sach=chi_tiet_phieu_muon.ma_sach and sach.ma_sach=chi_tiet_kho.ma_sach and chi_tiet_phieu_muon.ma_phieu_muon= phieu_muon.ma_phieu_muon and ngay_muon <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy") & "' and ngay_muon >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy") & "' group by " & thuoctinh & " order by count(chi_tiet_phieu_muon.ma_sach) desc"
                sach = New SqlDataAdapter(query, conn)
            ElseIf cbbKieu.SelectedIndex = 0 And cbbLoai.SelectedIndex > 0 And chkChiTiet.Checked = True Then
                Dim query As String = "select " & thuoctinh & " as '" & cbbLoai.Text & "', sum(so_luong)-count(chi_tiet_phieu_muon.ma_sach) as 'Số lượng sách trong kho',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn' from sach," & bang & ",chi_tiet_phieu_muon,chi_tiet_kho,phieu_muon where sach." & khoachinh & "=" & bang & "." & khoachinh & " and sach.ma_sach=chi_tiet_phieu_muon.ma_sach and sach.ma_sach=chi_tiet_kho.ma_sach and chi_tiet_phieu_muon.ma_phieu_muon= phieu_muon.ma_phieu_muon and ngay_muon <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy") & "' and ngay_muon >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy") & "' and " & thuoctinh & " = '" & cbbGiaTri.Text & "' group by " & thuoctinh & " order by count(chi_tiet_phieu_muon.ma_sach) desc"
                sach = New SqlDataAdapter(query, conn)
            ElseIf cbbKieu.SelectedIndex > 0 And cbbLoai.SelectedIndex > 0 And chkChiTiet.Checked = True Then
                Dim query As String = "select " & cbbKieu.Text & " " & thuoctinh & " as '" & cbbLoai.Text & "', sum(so_luong)-count(chi_tiet_phieu_muon.ma_sach) as 'Số lượng sách trong kho',count(chi_tiet_phieu_muon.ma_sach) 'Lượt mượn' from sach," & bang & ",chi_tiet_phieu_muon,chi_tiet_kho,phieu_muon where sach." & khoachinh & "=" & bang & "." & khoachinh & " and sach.ma_sach=chi_tiet_phieu_muon.ma_sach and sach.ma_sach=chi_tiet_kho.ma_sach and chi_tiet_phieu_muon.ma_phieu_muon= phieu_muon.ma_phieu_muon and ngay_muon <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy") & "' and ngay_muon >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy") & "' and " & thuoctinh & " = '" & cbbGiaTri.Text & "' group by " & thuoctinh & " order by count(chi_tiet_phieu_muon.ma_sach) desc"
                sach = New SqlDataAdapter(query, conn)
                MessageBox.Show(query)
        End If
        Try
            conn.Open()
            db.Columns.Clear()
            db.Clear()

            sach.Fill(db)
            DataGridView1.DataSource = db.DefaultView

            Dim sodong As Integer = DataGridView1.Rows.Count
            Dim socot As Integer = DataGridView1.Columns.Count - 1
            Dim i As Integer
            Dim a As Integer
            For i = 0 To sodong - 1
                a += db.Rows(i)(socot).ToString
            Next
            TxtTongluotmuon.Text = a
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            frmThongKeSach_Load(Nothing, Nothing)
        End Try
        conn.Close()
    End Sub




    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class