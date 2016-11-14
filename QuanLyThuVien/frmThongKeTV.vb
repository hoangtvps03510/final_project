Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmThongKeTV
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim giatri As String
    Private Sub frmThongKeTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load dữ liệu lên datagridview
        Dim thongke As New SqlDataAdapter("select ten_tv as 'Tên thành viên', convert(varchar(11),nam_sinh,103) as 'Năm sinh', case gioi_tinh when 1 then 'Nam' else 'Nữ' end as 'Giới tính',dia_chi as 'Địa chỉ', nghe_nghiep as 'Nghề nghiệp',ngay_DK as 'Ngày đăng kí',count(ma_phieu_muon) as 'Số lượt mượn'  from thanh_vien,phieu_muon where PHIEU_MUON.Ma_TV=THANH_VIEN.Ma_TV group by Ten_TV,nam_sinh,Gioi_tinh,Dia_chi,Nghe_nghiep,Ngay_DK", conn)
        'Dim tongsotv As New SqlDataAdapter("select count(ma_tv) as 'Tổng số TV' from thanh_vien", conn)
        conn.Open()
        db.Clear()
        dgvBangTV.DataSource = db.DefaultView
        thongke.Fill(db)
        Dim sodong As Integer = dgvBangTV.Rows.Count
        txtTongsoTV.Text = sodong.ToString

        cbbTop.SelectedIndex = 0

        conn.Close()
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim thongke As New SqlDataAdapter
        If cbbTop.SelectedIndex = 0 And cbbLoai.SelectedIndex = 0 Then
            Dim query As String = "select ten_tv as 'Tên thành viên', convert(varchar(11),nam_sinh,103) as 'Năm sinh', case gioi_tinh when 1 then 'Nam' else 'Nữ' end as 'Giới tính',dia_chi as 'Địa chỉ', nghe_nghiep as 'Nghề nghiệp',ngay_DK as 'Ngày đăng kí',count(ma_phieu_muon) as 'Số lượt mượn'  from thanh_vien,phieu_muon where PHIEU_MUON.Ma_TV=THANH_VIEN.Ma_TV and ngay_DK <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' and ngay_DK >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' group by Ten_TV,nam_sinh,Gioi_tinh,Dia_chi,Nghe_nghiep,Ngay_DK"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex > 0 And cbbLoai.SelectedIndex = 0 Then
            Dim query As String = "select " & cbbTop.Text & " ten_tv as 'Tên thành viên', convert(varchar(11),nam_sinh,103) as 'Năm sinh', case gioi_tinh when 1 then 'Nam' else 'Nữ' end as 'Giới tính',dia_chi as 'Địa chỉ', nghe_nghiep as 'Nghề nghiệp',ngay_DK as 'Ngày đăng kí',count(ma_phieu_muon) as 'Số lượt mượn'  from thanh_vien,phieu_muon where PHIEU_MUON.Ma_TV=THANH_VIEN.Ma_TV and ngay_DK <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' and ngay_DK >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' group by Ten_TV,nam_sinh,Gioi_tinh,Dia_chi,Nghe_nghiep,Ngay_DK"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex = 0 And cbbLoai.SelectedIndex = 1 And cbbGiaTri.Text = "Tất cả" Then
            Dim query As String = "select nghe_nghiep as 'Nghề nghiệp',count(ma_tv) as 'Số tv'  from thanh_vien group by Nghe_nghiep order by count(ma_tv) desc"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex = 0 And cbbLoai.SelectedIndex = 1 And cbbGiaTri.SelectedIndex > 0 Then
            Dim query As String = "select nghe_nghiep as 'Nghề nghiệp',count(ma_tv) as 'Số tv'  from thanh_vien where nghe_nghiep = '" & cbbGiaTri.Text & "' group by Nghe_nghiep order by count(ma_tv) desc"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex = 0 And cbbLoai.SelectedIndex = 2 And cbbGiaTri.Text = "Tất cả" Then
            Dim query As String = "select ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên', nghe_nghiep as 'Nghề nghiệp', DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi' from THANH_VIEN"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex = 0 And cbbLoai.SelectedIndex = 2 And cbbGiaTri.SelectedIndex > 0 Then
            Dim query As String = "select ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên', nghe_nghiep as 'Nghề nghiệp', DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi' from THANH_VIEN " & giatri & " "
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex > 0 And cbbLoai.SelectedIndex = 1 And cbbGiaTri.Text = "Tất cả" Then
            Dim query As String = "select " & cbbTop.Text & " nghe_nghiep as 'Nghề nghiệp',count(ma_tv) as 'Số tv'  from thanh_vien group by Nghe_nghiep order by count(ma_tv) desc"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex > 0 And cbbLoai.SelectedIndex = 1 And cbbGiaTri.SelectedIndex > 0 Then
            Dim query As String = "select " & cbbTop.Text & " nghe_nghiep as 'Nghề nghiệp',count(ma_tv) as 'Số tv'  from thanh_vien where nghe_nghiep = '" & cbbGiaTri.Text & "' group by Nghe_nghiep order by count(ma_tv) desc"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex > 0 And cbbLoai.SelectedIndex = 2 And cbbGiaTri.Text = "Tất cả" Then
            Dim query As String = "select " & cbbTop.Text & " ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên', nghe_nghiep as 'Nghề nghiệp', DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi' from THANH_VIEN"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex > 0 And cbbLoai.SelectedIndex = 2 And cbbGiaTri.SelectedIndex > 0 Then
            Dim query As String = "select " & cbbTop.Text & " ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên', nghe_nghiep as 'Nghề nghiệp', DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi' from THANH_VIEN " & giatri & " "
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex = 0 And cbbLoai.SelectedIndex = 3 And cbbGiaTri.Text = "Tất cả" Then
            Dim query As String = "select ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên',DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi', dia_chi as 'Địa chỉ' from THANH_VIEN"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex = 0 And cbbLoai.SelectedIndex = 3 And cbbGiaTri.SelectedIndex > 0 Then
            Dim query As String = "select ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên',DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi', dia_chi as 'Địa chỉ' from THANH_VIEN where dia_chi like N'%" & cbbGiaTri.Text & "%'"
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex > 0 And cbbLoai.SelectedIndex = 3 And cbbGiaTri.Text = "Tất cả" Then
            Dim query As String = "select " & cbbTop.Text & " ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên',DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi', dia_chi as 'Địa chỉ' from THANH_VIEN "
            thongke = New SqlDataAdapter(query, conn)
        ElseIf cbbTop.SelectedIndex > 0 And cbbLoai.SelectedIndex = 3 And cbbGiaTri.SelectedIndex > 0 Then
            Dim query As String = "select " & cbbTop.Text & " ma_tv as 'Mã thành viên',ten_tv as 'Tên thành viên',DATEDIFF(year,nam_sinh,GETDATE()) as 'Tuổi', dia_chi as 'Địa chỉ' from THANH_VIEN where dia_chi like N'%" & cbbGiaTri.Text & "%' "
            thongke = New SqlDataAdapter(query, conn)
        End If

        Try
            conn.Open()
            db.Columns.Clear()
            db.Clear()
            thongke.Fill(db)
            dgvBangTV.DataSource = db.DefaultView
            conn.Close()

            Dim sodong As Integer = dgvBangTV.Rows.Count
            Dim socot As Integer = dgvBangTV.Columns.Count - 1
            Dim i As Integer
            Dim a As Integer
            If socot <= 2 Then
                For i = 0 To sodong - 1
                    a += db.Rows(i)(socot).ToString
                Next
                txtTongsoTV.Text = a.ToString
            Else
                txtTongsoTV.Text = sodong.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công")
            frmThongKeTV_Load(Nothing, Nothing)
        End Try
        conn.Close()
    End Sub

    Private Sub cbbLoai_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbbLoai.SelectedIndexChanged
        If cbbLoai.SelectedIndex > 0 Then
            cbbGiaTri.Enabled = True

        Else
            cbbGiaTri.Enabled = False
            cbbGiaTri.Text = "Tất cả"
        End If

        If cbbLoai.SelectedIndex = 1 Then
            cbbGiaTri.Items.Clear()
            cbbGiaTri.Items.Add("Tất cả")
            cbbGiaTri.Items.Add("Sinh viên")
            cbbGiaTri.Items.Add("Nhân viên văn phòng")
            cbbGiaTri.Items.Add("Kỹ thuật viên")
            cbbGiaTri.Items.Add("Hành chính - Văn phòng")
            cbbGiaTri.Items.Add("Điện - Điện tử")
            cbbGiaTri.Items.Add("Marketing-PR")
            cbbGiaTri.Items.Add("Y tế - Dược")
            cbbGiaTri.Items.Add("Quản trị kinh doanh")
            cbbGiaTri.Items.Add("Bán hàng")
            cbbGiaTri.Items.Add("Khác")
            cbbGiaTri.SelectedIndex = 0
        ElseIf cbbLoai.SelectedIndex = 2 Then
            cbbGiaTri.Items.Clear()
            cbbGiaTri.Items.Add("Tất cả")
            cbbGiaTri.Items.Add("Từ 15 đến 20")
            cbbGiaTri.Items.Add("Từ 20 đến 30")
            cbbGiaTri.Items.Add("Trên 30")
            cbbGiaTri.SelectedIndex = 0
        ElseIf cbbLoai.SelectedIndex = 3 Then
            cbbGiaTri.Items.Clear()
            cbbGiaTri.Items.Add("Tất cả")
            cbbGiaTri.Items.Add("TP.HCM")
            cbbGiaTri.Items.Add("Bình Dương")
            cbbGiaTri.SelectedIndex = 0
        End If



    End Sub



   




    Private Sub cbbGiaTri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbGiaTri.SelectedIndexChanged
        If cbbLoai.SelectedIndex = 2 And cbbGiaTri.SelectedIndex = 1 Then
            giatri = "where DATEDIFF(year,nam_sinh,GETDATE()) between 15 and 20"
        ElseIf cbbLoai.SelectedIndex = 2 And cbbGiaTri.SelectedIndex = 2 Then
            giatri = "where DATEDIFF(year,nam_sinh,GETDATE()) between 25 and 30"
        ElseIf cbbLoai.SelectedIndex = 2 And cbbGiaTri.SelectedIndex = 3 Then
            giatri = "where DATEDIFF(year,nam_sinh,GETDATE()) > 30 "
        Else
            giatri = ""
        End If
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        Dim thongke As New SqlDataAdapter("select ten_tv as 'Tên thành viên', convert(varchar(11),nam_sinh,103) as 'Năm sinh', case gioi_tinh when 1 then 'Nam' else 'Nữ' end as 'Giới tính',dia_chi as 'Địa chỉ', nghe_nghiep as 'Nghề nghiệp',ngay_DK as 'Ngày đăng kí',count(ma_phieu_muon) as 'Số lượt mượn'  from thanh_vien,phieu_muon where PHIEU_MUON.Ma_TV=THANH_VIEN.Ma_TV group by Ten_TV,nam_sinh,Gioi_tinh,Dia_chi,Nghe_nghiep,Ngay_DK", conn)
        'Dim tongsotv As New SqlDataAdapter("select count(ma_tv) as 'Tổng số TV' from thanh_vien", conn)
        conn.Open()
        db.Clear()
        dgvBangTV.DataSource = db.DefaultView
        thongke.Fill(db)
        Dim sodong As Integer = dgvBangTV.Rows.Count
        txtTongsoTV.Text = sodong.ToString

        cbbTop.SelectedIndex = 0

        conn.Close()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class