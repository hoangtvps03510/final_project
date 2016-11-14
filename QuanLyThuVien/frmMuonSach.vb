Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmMuonSach

    'khai báo biến
    Dim db As New DataTable
    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)

    Dim masach As String
    Dim ten_sach As String
    Dim dongia As Integer
    Dim image As Image

    Dim fs As System.IO.FileStream

    Dim soluong As Integer
    Dim sosachchon As Integer = 0

    Dim sqlnew As String
    Dim sqlnew1 As String

    Dim sqlnew2 As String
    Dim sqlnew3 As String

    Dim sql As String = "" &
    "SELECT SACH.Ma_sach as 'Mã Sách', Ten_sach as 'Tên Sách', SL as 'Số Lượng', Ten_tac_gia as 'Tác Giả', Ten_NXB as 'NXB', " &
    "Ten_the_loai as 'Thể Loại', Don_gia as 'Đơn Gía' " &
    "FROM SACH " &
    "JOIN  (SELECT Ma_sach, Sum(SL) as 'SL' from " &
            "( SELECT Ma_sach, So_luong as 'SL' from CHI_TIET_KHO " &
            "UNION all (SELECT Ma_sach,  -1 AS 'SL' FROM CHI_TIET_PHIEU_MUON  ) " &
             "UNION all (SELECT Ma_sach, 1 AS 'SL' " &
                        "FROM CHI_TIET_PHIEU_TRA JOIN CHI_TIET_PHIEU_MUON " &
                        "ON CHI_TIET_PHIEU_TRA.ID_CTPM = CHI_TIET_PHIEU_MUON.ID_CTPM " &
                        "WHERE Trang_thai=0 ) " &
            ") AS gop3bang " &
            "GROUP BY Ma_sach)  AS gop3bang_groupma ON SACH.Ma_sach = gop3bang_groupma.Ma_sach " &
  "JOIN TAC_GIA ON SACH.Ma_tac_gia= TAC_GIA.Ma_tac_gia " &
  "JOIN THE_LOAI ON SACH.Ma_the_loai=THE_LOAI.Ma_the_loai " &
  "JOIN NXB ON SACH.Ma_NXB=NXB.Ma_NXB " &
  "JOIN (SELECT Ma_sach, MAX(Don_gia) AS 'Don_gia' FROM CHI_TIET_KHO GROUP BY Ma_sach ) AS DONGIA ON SACH.Ma_sach  = DONGIA.Ma_sach "

    Dim conn As SqlDataAdapter


    Private Sub frmQuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtsosach.Text = 0

        connect.Open()
        conn = New SqlDataAdapter(sql, connect)
        dgvXemDanhSach.DataSource = db.DefaultView
        db.Clear()
        conn.Fill(db)
        connect.Close()

        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachQL.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachQL.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\Sach001.jpg")
        End Try


    End Sub




    Private Sub txtsosach_TextChanged(sender As Object, e As EventArgs) Handles txtsosach.TextChanged
        sosachchon = txtsosach.Text
    End Sub

    Private Sub txtTenSachTK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTenSachTK.TextChanged
        Dim sqlsach As String
        If txtTenSachTK.Text = "" Then
            connect.Open()
            conn = New SqlDataAdapter(sql, connect)
            dgvXemDanhSach.DataSource = db.DefaultView
            db.Clear()
            conn.Fill(db)
            connect.Close()
        Else
            sqlsach = sql & " WHERE Ten_Sach Like N'" & txtTenSachTK.Text & "%' "
            connect.Open()
            Dim lammoi As SqlDataAdapter = New SqlDataAdapter(sqlsach, connect)
            dgvXemDanhSach.DataSource = db.DefaultView
            db.Clear()
            lammoi.Fill(db)
            connect.Close()
        End If
    End Sub

    Private Sub dgvXemDanhSach_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvXemDanhSach.CellFormatting

        Dim sodong As Integer = dgvXemDanhSach.Rows.Count - 1
        Dim m As Integer = 0
        If sodong > 0 Then

            Do While m < sodong
                If dgvXemDanhSach.Rows(m).Cells(2).Value = 0 Then
                    dgvXemDanhSach.Rows(m).DefaultCellStyle.BackColor = Color.IndianRed
                    dgvXemDanhSach.Rows(m).DefaultCellStyle.ForeColor = Color.WhiteSmoke
                    'dgvXemDanhSach.Rows(m).DefaultCellStyle.
                Else
                End If
                m += 1
            Loop
        End If

    End Sub

    Private Sub dgvXemDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemDanhSach.CellContentClick
        Dim click As Integer = dgvXemDanhSach.CurrentCell.RowIndex
        masach = dgvXemDanhSach.Item(0, click).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachQL.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachQL.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\Sach001.jpg")
        End Try
    End Sub

    Private Sub btnMuonSach_Click(sender As Object, e As EventArgs) Handles btnMuonSach.Click
        frmPhieuMuonSach.Show()
        frmPhieuMuonSach.Focus()
        Me.Hide()
    End Sub

    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click
        Dim tiencoc As Integer

        If dgvXemDanhSach.Rows.Count = 1 Then
            Exit Sub
        End If

        Dim click As Integer = dgvXemDanhSach.CurrentCell.RowIndex
        Dim sosach As Integer = (frmPhieuMuonSach.dgvgiohang.Rows.Count - 1)

        masach = dgvXemDanhSach.Item(0, click).Value
        ten_sach = dgvXemDanhSach.Item(1, click).Value
        soluong = dgvXemDanhSach.Item(2, click).Value
        dongia = dgvXemDanhSach.Item(6, click).Value
        tiencoc = dgvXemDanhSach.Item(6, click).Value * 110 / 100

        If soluong > 0 Then
            Select Case sosachchon
                Case 0 To 2
                    sosachchon = sosachchon + 1
                    soluong -= 1
                    dgvXemDanhSach.Item(2, click).Value = soluong
                    frmPhieuMuonSach.dgvgiohang.Rows.Add(masach, ten_sach, dongia, tiencoc)
                    dgvXemDanhSach.Rows.RemoveAt(click)
                Case Is > 2
                    MessageBox.Show("đã chọn đủ sách để mượn")
            End Select
        Else
            MessageBox.Show("Sách tạm hết")
        End If
        'End If

        txtsosach.Text = sosachchon
        'Tính tổng tiền cọc

        Dim i As Integer = 0
        Dim tongcoc As Integer
        Do While i <= sosach
            tongcoc += frmPhieuMuonSach.dgvgiohang.Rows(i).Cells(3).Value
            i += 1
        Loop
        frmPhieuMuonSach.txttiencoc.Text = tongcoc

        'End If
    End Sub
End Class