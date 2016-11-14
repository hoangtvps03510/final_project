Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Imports System.Text.RegularExpressions
Public Class FrmNhapKho

    Dim db As New DataTable
    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)

    Dim masach As String
    Dim image As Image
    Dim conn As SqlDataAdapter
    Dim fs As System.IO.FileStream
    Dim sql As String = "SELECT * FROM SACH"
    Dim sqlchitietkho As String = "SELECT KHO.Ma_kho, Ten_kho, SACH.Ma_sach, Ten_sach, So_luong, Don_gia, Ngay_nhap FROM CHI_TIET_KHO JOIN KHO ON CHI_TIET_KHO.Ma_kho=KHO.Ma_kho JOIN SACH ON CHI_TIET_KHO.Ma_sach=SACH.Ma_sach "

    Private Sub FrmNhapKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpngay.Value = DateTime.Now

        txtmakho.Text = frmQuanLyKho.txtmakho.Text
        connect.Open()
        conn = New SqlDataAdapter(sql, connect)
        dgvsach.DataSource = db.DefaultView
        db.Clear()
        conn.Fill(db)
        connect.Close()

        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachQL.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachQL.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach001.jpg")
        End Try
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        If txtmakho.Text <> "" Or txtmasach.Text <> "" Or txtsoluong.Text <> "" Or txtdongia.Text <> "" Then
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

    Private Sub dgvsach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsach.CellContentClick
        Dim click As Integer = dgvsach.CurrentCell.RowIndex
        masach = dgvsach.Rows(click).Cells(0).Value
        txtmasach.Text = masach

    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Dim resulft As DialogResult = MessageBox.Show("Bạn có muốn hủy phiếu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resulft = Windows.Forms.DialogResult.Yes Then
            frmMuonSach.Close()
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
        End If
        FrmNhapKho_Load(Nothing, Nothing)
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim queryNK As String = "Insert Into CHI_TIET_KHO values (@MAKHO,@MASACH,@SL,@DONGIA,@NGAY)"
        Dim insertNK As SqlCommand = New SqlCommand(queryNK, connect)

        If txtmasach.Text = "" Or Not IsNumeric(txtmasach.Text) Then
            MessageBox.Show("Bạn chưa nhập mã sách ", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtsoluong.Text = "" Or Not IsNumeric(txtsoluong.Text) Then
                MessageBox.Show("Bạn chưa nhập số lượng", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtdongia.Text = "" Or Not IsNumeric(txtdongia.Text) Then
                    MessageBox.Show("Bạn chưa nhập đơn giá", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    connect.Open() 'mở kết nối
                    insertNK.Parameters.AddWithValue("@MAKHO", txtmakho.Text)
                    insertNK.Parameters.AddWithValue("@MASACH", txtmasach.Text)
                    insertNK.Parameters.AddWithValue("@SL", txtsoluong.Text)
                    insertNK.Parameters.AddWithValue("@DONGIA", txtdongia.Text)
                    insertNK.Parameters.AddWithValue("@NGAY", dtpngay.Value)
                    insertNK.ExecuteNonQuery()
                    connect.Close()

                    MessageBox.Show("Thêm thành công")
                    Me.Controls.Clear() 'removes all the controls on the form
                    InitializeComponent() 'load all the controls again
                    FrmNhapKho_Load(Nothing, Nothing)
                End If
            End If
        End If

        Dim db2 As New DataTable
        Dim newsql As String = sqlchitietkho & "WHERE kho.ma_kho = '" & frmQuanLyKho.TxtMaKho2.Text & "'"
        conn = New SqlDataAdapter(newsql, connect)
        connect.Open()
        db2.Clear()
        frmQuanLyKho.dgvChiTietKho.DataSource = db2.DefaultView
        conn.Fill(db2)
        connect.Close()
    End Sub


End Class