Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmChiPhi
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Private Sub frmChiPhi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load dữ liệu lên datagridview
        Dim thongkeCP As New SqlDataAdapter("select ten_sach as 'Tên sách', so_luong as 'Số lượng' , PARSENAME(convert(varchar,convert(money,Don_gia),0),2 ) as 'Đơn giá', ngay_nhap as 'Ngày nhập sách', ten_kho as 'Tên kho', PARSENAME(convert(varchar,convert(money,(so_luong * don_gia)),0),2 ) as 'Tổng tiền' from Sach,Chi_tiet_kho,kho where chi_tiet_kho.ma_sach = sach.ma_sach and kho.Ma_kho = chi_tiet_kho.Ma_kho", conn)
        conn.Open()
        db.Clear()
        dgvBangCP.DataSource = db.DefaultView
        thongkeCP.Fill(db)
        Dim sodong As Integer = dgvBangCP.Rows.Count
        Dim tongcp As Decimal = 0
        Dim tongsachnhap As Integer = 0


        If sodong < 1 Then
            txtTongSachNhap.Text = tongsachnhap
            txtTongCP.Text = "0 Đồng"
            MessageBox.Show("Không tìm thấy dữ liệu", "Dữ liệu trống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            For i = 0 To sodong - 1
                tongcp += db.Rows(i)(5)
                tongsachnhap += db.Rows(i)(1)
            Next
            txtTongSachNhap.Text = tongsachnhap
            txtTongCP.Text = tongcp.ToString("###,###,###") & " Đồng"
        End If
        conn.Close()

    End Sub


    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        ' load dữ liệu lên datagridview
        Dim thongkeCP As New SqlDataAdapter("select ten_sach as 'Tên sách', so_luong as 'Số lượng' , PARSENAME(convert(varchar,convert(money,Don_gia),0),2 ) as 'Đơn giá', ngay_nhap as 'Ngày nhập sách', ten_kho as 'Tên kho', PARSENAME(convert(varchar,convert(money,(so_luong * don_gia)),0),2 ) as 'Tổng tiền' from Sach,Chi_tiet_kho,kho where chi_tiet_kho.ma_sach = sach.ma_sach and kho.Ma_kho = chi_tiet_kho.Ma_kho and  ngay_nhap <= '" & dtpDenNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' and ngay_nhap >= '" & dtpTuNgay.Value.ToString("MM/dd/yyyy HH:mm:ss") & "' ", conn)
        conn.Open()
        db.Clear()
        dgvBangCP.DataSource = db.DefaultView
        thongkeCP.Fill(db)
        Dim sodong As Integer = dgvBangCP.Rows.Count
        Dim tongcp As Decimal = 0
        Dim tongsachnhap As Integer = 0
        If sodong < 1 Then
            txtTongSachNhap.Text = tongsachnhap
            txtTongCP.Text = "0 Đồng"
            MessageBox.Show("Không tìm thấy dữ liệu", "Dữ liệu trống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            For i = 0 To sodong - 1
                tongcp += db.Rows(i)(5)
                tongsachnhap += db.Rows(i)(1)
            Next
            txtTongSachNhap.Text = tongsachnhap
            txtTongCP.Text = tongcp.ToString("###,###,###") & " Đồng"
        End If

        conn.Close()
    End Sub


    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        Dim thongkeCP As New SqlDataAdapter("select ten_sach as 'Tên sách', so_luong as 'Số lượng' , PARSENAME(convert(varchar,convert(money,Don_gia),0),2 ) as 'Đơn giá', ngay_nhap as 'Ngày nhập sách', ten_kho as 'Tên kho', PARSENAME(convert(varchar,convert(money,(so_luong * don_gia)),0),2 ) as 'Tổng tiền' from Sach,Chi_tiet_kho,kho where chi_tiet_kho.ma_sach = sach.ma_sach and kho.Ma_kho = chi_tiet_kho.Ma_kho", conn)
        conn.Open()
        db.Clear()
        dgvBangCP.DataSource = db.DefaultView
        thongkeCP.Fill(db)
        Dim sodong As Integer = dgvBangCP.Rows.Count
        Dim tongcp As Decimal = 0
        Dim tongsachnhap As Integer = 0


        If sodong < 1 Then
            txtTongSachNhap.Text = tongsachnhap
            txtTongCP.Text = "0 Đồng"
            MessageBox.Show("Không tìm thấy dữ liệu", "Dữ liệu trống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            For i = 0 To sodong - 1
                tongcp += db.Rows(i)(5)
                tongsachnhap += db.Rows(i)(1)

            Next
            txtTongSachNhap.Text = tongsachnhap
            txtTongCP.Text = tongcp.ToString("###,###,###") & " Đồng"
        End If
        conn.Close()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class