Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDoanhThu
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim db3 As New DataTable
    Private Sub frmDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load dữ liệu lên datagridview
        Dim thongke As New SqlDataAdapter("select phieu_tra.ma_phieu_tra as ' Mã phiếu trả', ngay_tra as 'Ngày lap phieu ', ten_nv as 'Tên nhân viên',ten_sach as 'Tên sách',CHI_TIET_PHIEU_MUON.ma_sach as ' Mã sách',PARSENAME(convert(varchar,convert(money,gia_muon),0),2 ) as 'Giá cho thuê',convert(varchar(15),datediff(day,ngay_muon,ngay_tra))  +' Ngày' as 'Số ngày mượn',PARSENAME(convert(varchar,convert(money,thanh_tien),0),2 ) as 'Thành tiền'  from  nhan_vien ,CHI_TIET_PHIEU_TRA, phieu_tra,CHI_TIET_PHIEU_MUON, bang_gia,phieu_muon,sach where phieu_tra.ma_nv = nhan_vien.ma_nv and chi_tiet_phieu_muon.ma_sach = bang_gia.ma_sach and chi_tiet_phieu_muon.ID_CTPM = chi_tiet_phieu_tra.ID_CTPM and chi_tiet_phieu_tra.ma_phieu_tra = phieu_tra.ma_phieu_tra and CHI_TIET_PHIEU_MUON.Ma_phieu_muon = PHIEU_MUON.Ma_phieu_muon and sach.Ma_sach = CHI_TIET_PHIEU_MUON.Ma_sach ", conn)
        conn.Open()
        db.Clear()
        dgvBangDT.DataSource = db.DefaultView
        thongke.Fill(db)
        Dim sodong As Integer = dgvBangDT.Rows.Count
        Dim tongdt As Decimal = 0
        Dim tongsohd As Integer = sodong
        If sodong < 1 Then
            txtTongSoHoaDon.Text = tongsohd
            txtTongDT.Text = "0 Đồng"
            MessageBox.Show("Không tìm thấy dữ liệu", "Dữ liệu trống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            For i = 0 To sodong - 1
                tongdt += db.Rows(i)(7)
            Next
            txtTongSoHoaDon.Text = tongsohd
            txtTongDT.Text = tongdt.ToString("###,###,###") & " Đồng"
        End If
        conn.Close()

    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        ' load dữ liệu lên datagridview
        Dim thongke As New SqlDataAdapter("select phieu_tra.ma_phieu_tra as ' Mã phiếu trả', ngay_tra as 'Ngày lap phieu ', ten_nv as 'Tên nhân viên',ten_sach as 'Tên sách',CHI_TIET_PHIEU_MUON.ma_sach as ' Mã sách',PARSENAME(convert(varchar,convert(money,gia_muon),0),2 ) as 'Giá cho thuê',convert(varchar(15),datediff(day,ngay_muon,ngay_tra))  +' Ngày' as 'Số ngày mượn',PARSENAME(convert(varchar,convert(money,thanh_tien),0),2 ) as 'Thành tiền'  from  nhan_vien ,CHI_TIET_PHIEU_TRA, phieu_tra,CHI_TIET_PHIEU_MUON, bang_gia,phieu_muon,sach where phieu_tra.ma_nv = nhan_vien.ma_nv and chi_tiet_phieu_muon.ma_sach = bang_gia.ma_sach and chi_tiet_phieu_muon.ID_CTPM = chi_tiet_phieu_tra.ID_CTPM and chi_tiet_phieu_tra.ma_phieu_tra = phieu_tra.ma_phieu_tra and CHI_TIET_PHIEU_MUON.Ma_phieu_muon = PHIEU_MUON.Ma_phieu_muon and sach.Ma_sach = CHI_TIET_PHIEU_MUON.Ma_sach and  ngay_tra <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' and ngay_tra >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' ", conn)
        conn.Open()
        db.Clear()
        dgvBangDT.DataSource = db.DefaultView
        thongke.Fill(db)
        Dim sodong As Integer = dgvBangDT.Rows.Count
        Dim tongdt As Decimal = 0
        Dim tongsohd As Integer = sodong
        If sodong < 1 Then
            txtTongSoHoaDon.Text = tongsohd
            txtTongDT.Text = "0 Đồng"
            MessageBox.Show("Không tìm thấy dữ liệu", "Dữ liệu trống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            For i = 0 To sodong - 1
                tongdt += db.Rows(i)(7)
            Next
            txtTongSoHoaDon.Text = tongsohd
            txtTongDT.Text = tongdt.ToString("###,###,###") & " Đồng"
        End If
        conn.Close()
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        Dim thongke As New SqlDataAdapter("select phieu_tra.ma_phieu_tra as ' Mã phiếu trả', ngay_tra as 'Ngày lap phieu ', ten_nv as 'Tên nhân viên',ten_sach as 'Tên sách',CHI_TIET_PHIEU_MUON.ma_sach as ' Mã sách',PARSENAME(convert(varchar,convert(money,gia_muon),0),2 ) as 'Giá cho thuê',convert(varchar(15),datediff(day,ngay_muon,ngay_tra))  +' Ngày' as 'Số ngày mượn',PARSENAME(convert(varchar,convert(money,thanh_tien),0),2 ) as 'Thành tiền'  from  nhan_vien ,CHI_TIET_PHIEU_TRA, phieu_tra,CHI_TIET_PHIEU_MUON, bang_gia,phieu_muon,sach where phieu_tra.ma_nv = nhan_vien.ma_nv and chi_tiet_phieu_muon.ma_sach = bang_gia.ma_sach and chi_tiet_phieu_muon.ID_CTPM = chi_tiet_phieu_tra.ID_CTPM and chi_tiet_phieu_tra.ma_phieu_tra = phieu_tra.ma_phieu_tra and CHI_TIET_PHIEU_MUON.Ma_phieu_muon = PHIEU_MUON.Ma_phieu_muon and sach.Ma_sach = CHI_TIET_PHIEU_MUON.Ma_sach ", conn)
        conn.Open()
        db.Clear()
        dgvBangDT.DataSource = db.DefaultView
        thongke.Fill(db)
        Dim sodong As Integer = dgvBangDT.Rows.Count
        Dim tongdt As Decimal = 0
        Dim tongsohd As Integer = sodong
        If sodong < 1 Then
            txtTongSoHoaDon.Text = tongsohd
            txtTongDT.Text = "0 Đồng"
            MessageBox.Show("Không tìm thấy dữ liệu", "Dữ liệu trống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            For i = 0 To sodong - 1
                tongdt += db.Rows(i)(7)
            Next
            txtTongSoHoaDon.Text = tongsohd
            txtTongDT.Text = tongdt.ToString("###,###,###") & " Đồng"
        End If
        conn.Close()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class