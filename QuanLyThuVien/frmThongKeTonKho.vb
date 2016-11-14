Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmThongKeTonKho
    Dim db As New DataTable
    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)

    Dim conn As SqlDataAdapter
    
   


    Private Sub frmThongKeTonKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpngaybatdau.Value = frmThongKeTonKho1.dtpngaybatdau.Value.ToString("MM/dd/yyyy")
        dtpngayketthuc.Value = frmThongKeTonKho1.dtpngayketthuc.Value.ToString("MM/dd/yyyy")
        Dim ngaybatdau As String = dtpngaybatdau.Value
        Dim ngayketthuc As String = dtpngayketthuc.Value & " 23:59:59"



        Dim sql As String = "" &
   "SELECT SACH.Ma_sach as 'Mã Sách', Ten_sach as 'Tên Sách', " &
           "SLTONDAU as 'Số Lượng Tồn Đầu', SLNHAPMUA as 'Số Lượng Nhập Mua' ,SLSACHTRA as 'Số Lượng Sách Trả' ,SLCHOMUON as 'Số Lượng Sách Mượn' ,SLTONCUOI as 'Số Lượng Tồn Cuối' " &
   "FROM SACH " &
   "JOIN  (SELECT Ma_sach, Sum(SLTONDAU) as 'SLTONDAU', " &
                           "Sum(SLNHAPMUA) as 'SLNHAPMUA' , " &
                           "Sum(SLSACHTRA) as 'SLSACHTRA' , " &
                           "Sum(SLCHOMUON) as 'SLCHOMUON' , " &
                           "Sum(SLTONDAU+SLNHAPMUA+SLSACHTRA-SLCHOMUON) as 'SLTONCUOI' " &
       "FROM " &
           "( SELECT Ma_sach, So_luong * iif(ngay_nhap<'" & ngaybatdau & "',1,0) as 'SLTONDAU' , " &
                             "So_luong * iif(ngay_nhap>='" & ngaybatdau & "',1,0) as 'SLNHAPMUA' , " &
                             "so_luong * 0 as 'SLSACHTRA' , " &
                             "so_luong * 0 as 'SLCHOMUON' " &
                             "from CHI_TIET_KHO  WHERE Ngay_nhap <='" & ngayketthuc & "' " &
           "UNION all (SELECT Ma_sach,  iif(ngay_muon<'" & ngaybatdau & "',-1,0) as 'SLTONDAU' , " &
                             "0 as 'SLNHAPMUA' , " &
                             "0 as 'SLSACHTRA' , " &
                             "iif(ngay_muon>='" & ngaybatdau & "',1,0)  as 'SLCHOMUON' " &
                             "FROM CHI_TIET_PHIEU_MUON JOIN	PHIEU_MUON ON CHI_TIET_PHIEU_MUON.Ma_phieu_muon = PHIEU_MUON.Ma_phieu_muon " &
                             "WHERE ngay_muon <='" & ngayketthuc & "' ) " &
           "UNION all (SELECT Ma_sach,  iif(Ngay_tra<'" & ngaybatdau & "',1,0) as 'SLTONDAU' , " &
                             "0 as 'SLNHAPMUA' , " &
                             "iif(Ngay_tra>='" & ngaybatdau & "',1,0)   as 'SLSACHTRA' , " &
                             "0  as 'SLCHOMUON' " &
                             "FROM CHI_TIET_PHIEU_TRA " &
                               "JOIN CHI_TIET_PHIEU_MUON ON CHI_TIET_PHIEU_TRA.ID_CTPM = CHI_TIET_PHIEU_MUON.ID_CTPM " &
                               "JOIN PHIEU_TRA ON CHI_TIET_PHIEU_TRA.Ma_phieu_tra  = PHIEU_TRA.Ma_phieu_tra  " &
                             "WHERE Ngay_tra <='" & ngayketthuc & "'  ) " &
           ") AS gop3bang " &
       "GROUP BY Ma_sach ) AS " &
       "gop3bang_TONDAU_groupma ON SACH.Ma_sach = gop3bang_TONDAU_groupma.Ma_sach "


        connect.Open()
        conn = New SqlDataAdapter(sql, connect)
        dgvkho.DataSource = db.DefaultView
        db.Clear()
        conn.Fill(db)
        connect.Close()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class