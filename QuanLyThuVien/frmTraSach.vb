Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmTraSach

    Dim db As New DataTable
    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)
    Dim ten As String
    Dim tacgia As String
    Dim masach As String
    Dim khu As String
    Dim ke As String
    Dim NXB As String
    Dim theloai As String
    Dim tinhtrang As String
    Dim phimuon As Integer
    Dim image As Image
    Dim fs As System.IO.FileStream

    Dim soluong As Integer
    Dim sosachchon As Integer = 0

    Dim sqlmaphieu As String
    Dim sqlsach As String
    Dim conn As SqlDataAdapter
    Dim sql As String = "" &
        "SELECT ID_CTPM,PHIEU_MUON.Ma_phieu_muon as 'Mã Phiếu Mượn', SACH.Ma_sach as 'Mã Sách', Ten_sach as 'Tên Sách', THANH_VIEN.Ma_TV as 'Mã Thành Viên', Ten_TV as 'Tên Thành Viên', GIA.Gia_muon as 'Phí Mượn', Ngay_muon as 'Ngày Mượn' " &
        "FROM CHI_TIET_PHIEU_MUON " &
        "JOIN PHIEU_MUON ON CHI_TIET_PHIEU_MUON.Ma_phieu_muon =PHIEU_MUON.Ma_phieu_muon " &
        "JOIN SACH ON CHI_TIET_PHIEU_MUON.Ma_sach = SACH.Ma_sach " &
        "JOIN THANH_VIEN ON THANH_VIEN.Ma_TV = PHIEU_MUON.Ma_TV " &
        "LEFT JOIN  (select BANG_GIA.ma_sach, Gia_muon " &
        "FROM BANG_GIA join ( select ma_sach, Max(Ngay_gio) as NGAY from BANG_GIA group by Ma_sach) as a on BANG_GIA.Ngay_gio=a.NGAY and BANG_GIA.Ma_sach=a.Ma_sach " &
        "UNION (SELECT DISTINCT Ma_sach, 0 as Gia_muon from CHI_TIET_PHIEU_MUON WHERE Ma_sach NOT IN (SELECT Ma_sach FROM BANG_GIA ))) as GIA ON CHI_TIET_PHIEU_MUON.Ma_sach = GIA.Ma_sach " &
        "WHERE ID_CTPM NOT IN (SELECT ID_CTPM FROM CHI_TIET_PHIEU_TRA ) "

    Private Sub frmTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsosach.Text = 0

        If txttentv.Text = "" Then
            connect.Open()
            conn = New SqlDataAdapter(sql, connect)
            dgvsachmuon.DataSource = db.DefaultView
            db.Clear()
            conn.Fill(db)
            connect.Close()
        Else
            sqlsach = sql & "AND Ten_TV Like N'" & txttentv.Text & "%' "
            connect.Open()
            Dim lammoi As SqlDataAdapter = New SqlDataAdapter(sqlmaphieu, connect)
            dgvsachmuon.DataSource = db.DefaultView
            db.Clear()
            lammoi.Fill(db)
            connect.Close()
        End If
    End Sub


    Private Sub txttentv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txttentv.TextChanged
        Dim i As Integer = 0
        Dim sqlsachdachon As String
        Dim sosach As Integer = (frmPhieuTraSach.dgvtra.Rows.Count - 1)
        Do While i < sosach
            sqlsachdachon &= " AND ID_CTPM <> " & frmPhieuTraSach.dgvtra.Rows(i).Cells(0).Value.ToString & ""
            i += 1
        Loop

        If txtmaphieu.Text = "" Then
            If txttentv.Text = "" Then
                sqlsach = sql
            Else
                sqlsach = sql & " AND Ten_TV Like N'" & txttentv.Text & "%' "
            End If
        Else
            sqlsach = sqlmaphieu & " AND Ten_TV Like N'" & txttentv.Text & "%' "
        End If

        sqlsach &= (sqlsachdachon)
        connect.Open()
        Dim lammoi As SqlDataAdapter = New SqlDataAdapter(sqlsach, connect)
        dgvsachmuon.DataSource = db.DefaultView
        db.Clear()
        lammoi.Fill(db)
        connect.Close()
    End Sub

    Private Sub txtmaphieu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmaphieu.TextChanged
        Dim i As Integer = 0
        Dim sqlsachdachon As String
        Dim sosach As Integer = (frmPhieuTraSach.dgvtra.Rows.Count - 1)
        Do While i < sosach
            sqlsachdachon &= "AND ID_CTPM <> " & frmPhieuTraSach.dgvtra.Rows(i).Cells(0).Value.ToString & ""
            i += 1
        Loop

        If txttentv.Text = "" Then
            If txtmaphieu.Text = "" Then
                sqlmaphieu = sql & "AND PHIEU_MUON.Ma_phieu_muon Like N'" & txtmaphieu.Text & "' " & sqlmaphieu
            Else
                sqlmaphieu = sql & "AND PHIEU_MUON.Ma_phieu_muon Like N'%" & txtmaphieu.Text & "%' " & sqlmaphieu
            End If
        Else
            sqlmaphieu = sqlsach & "AND PHIEU_MUON.Ma_phieu_muon Like N'%" & txtmaphieu.Text & "%' "
        End If

        sqlmaphieu &= (sqlsachdachon)
        connect.Open()
        Dim lammoi As SqlDataAdapter = New SqlDataAdapter(sqlmaphieu, connect)
        dgvsachmuon.DataSource = db.DefaultView
        db.Clear()
        lammoi.Fill(db)
        connect.Close()
    End Sub


    Private Sub btnTraSach_Click(sender As Object, e As EventArgs) Handles btnTraSach.Click
        frmPhieuTraSach.Show()
        frmPhieuTraSach.Focus()
        Me.Hide()
    End Sub

    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click

        If dgvsachmuon.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim click As Integer = dgvsachmuon.CurrentCell.RowIndex
        If dgvsachmuon.Rows.Count = 1 Then
            Exit Sub
        End If
        Dim id_ctpm As Integer
        Dim maphieu As String
        Dim tensach As String
        Dim tentv As String
        Dim matv As String
        Dim ngaymuon As New DateTime
        Dim ngaytra As DateTime
        Dim songaymuon As Integer
        Dim phimuon As Integer
        Dim thanhtien As Integer

        If dgvsachmuon.Rows.Count = 1 Then
            Exit Sub
        End If

        id_ctpm = dgvsachmuon.Rows(click).Cells(0).Value
        maphieu = dgvsachmuon.Rows(click).Cells(1).Value
        matv = dgvsachmuon.Rows(click).Cells(4).Value
        tentv = dgvsachmuon.Rows(click).Cells(5).Value
        tensach = dgvsachmuon.Rows(click).Cells(5).Value
        ngaymuon = Convert.ToDateTime(dgvsachmuon.Rows(click).Cells(7).Value)
        ngaytra = Convert.ToDateTime(frmPhieuTraSach.dtpngaytra.Value)
        songaymuon = (ngaytra - ngaymuon).Days
        phimuon = dgvsachmuon.Rows(click).Cells(6).Value

        thanhtien = songaymuon * phimuon


        Dim sosach As Integer = (frmPhieuTraSach.dgvtra.Rows.Count - 1)
        Dim a As Integer = 0
        Dim kiemtra As Integer

        Do While a < sosach
            If matv <> frmPhieuTraSach.txtmatv.Text Then
                kiemtra = 1
            End If
            a += 1
        Loop

        If frmPhieuTraSach.txtmatv.Text = "" Then

        End If


        If kiemtra = 1 Then
            MessageBox.Show("Chọn sai Thành viên để trả sách", "Chọn Lại")
        Else
            txtsosach.Text += 1
            frmPhieuTraSach.dgvtra.Rows.Add(id_ctpm, maphieu, tensach, ngaymuon, songaymuon, thanhtien)

            frmPhieuTraSach.txtmatv.Text = matv
            frmPhieuTraSach.txtmatv.Enabled = False
            frmPhieuTraSach.txttentv.Text = tentv
            frmPhieuTraSach.txttentv.Enabled = False
            dgvsachmuon.Rows.RemoveAt(click)
        End If

        'Tính tổng tiền mượn sách
        Dim i As Integer = 0
        Dim tongtien As Integer
        Do While i <= sosach
            tongtien += frmPhieuTraSach.dgvtra.Rows(i).Cells(5).Value
            i += 1
            frmPhieuTraSach.txtthanhtien.Text = tongtien
        Loop
    End Sub
End Class