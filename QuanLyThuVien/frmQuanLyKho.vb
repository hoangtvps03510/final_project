Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLyKho
    Dim chuoikn As New Class1
    Dim conn As SqlConnection = New SqlConnection(chuoikn.ketnoi)
    Dim db As New DataTable
    Dim db2 As New DataTable
    Dim makho, tenkho As String
    Dim data As SqlDataAdapter

    Dim sqlchitietkho As String = "SELECT KHO.Ma_kho, Ten_kho, SACH.Ma_sach, Ten_sach, So_luong, Don_gia, Ngay_nhap FROM CHI_TIET_KHO JOIN KHO ON CHI_TIET_KHO.Ma_kho=KHO.Ma_kho JOIN SACH ON CHI_TIET_KHO.Ma_sach=SACH.Ma_sach "

    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)

   
    Private Sub frmQuanLyKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load dữ liệu lên datagridview
        Dim kho As New SqlDataAdapter("select kho.ma_kho as 'Mã kho', ten_kho as 'Tên kho' from  kho", conn)

        conn.Open()
        db.Clear()
        DgvKho.DataSource = db.DefaultView
        kho.Fill(db)
        makho = DgvKho.Item(0, 0).Value
        tenkho = DgvKho.Item(1, 0).Value
        TxtMaKho2.Text = makho
        TxtTenKho2.Text = tenkho
        txtmakho.Text = makho
        txttenkho.Text = tenkho

        data = New SqlDataAdapter(sqlchitietkho & "WHERE kho.ma_kho = '" & TxtMaKho2.Text & "'", conn)
        db2.Clear()
        dgvChiTietKho.DataSource = db2.DefaultView
        data.Fill(db2)
        conn.Close()
        
    End Sub

    Private Sub BtnThemKho_Click(sender As Object, e As EventArgs) Handles BtnThemKho.Click

        'kiểm tra trùng tên kho
        Dim i As Integer = 0
        Dim kiemtra As Integer = 0
        Do While i < DgvKho.RowCount - 1
            If DgvKho.Rows(i).Cells(1).Value = TxtTenKho2.Text Then
                kiemtra += 1
            End If
            i += 1
        Loop

        If tabKho.SelectedIndex = 0 Then
            If kiemtra <> 0 Then
                MessageBox.Show("Bạn đã nhập trùng tên kho", "Trùng thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If TxtTenKho2.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên kho", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim queryNK As String = "Insert Into KHO values (@TENKHO)"
                    Dim insertNK As SqlCommand = New SqlCommand(queryNK, connect)

                    connect.Open() 'mở kết nối
                    insertNK.Parameters.AddWithValue("@TENKHO", TxtTenKho2.Text)
                    insertNK.ExecuteNonQuery()
                    connect.Close()

                    MessageBox.Show("Thêm thành công")
                    Me.Controls.Clear() 'removes all the controls on the form
                    InitializeComponent() 'load all the controls again
                    frmQuanLyKho_Load(Nothing, Nothing)
                End If
            End If
        Else
            FrmNhapKho.Show()
        End If
        connect.Close()

    End Sub

    
    Private Sub BtnSuaKho_Click(sender As Object, e As EventArgs) Handles BtnSuaKho.Click
        If tabKho.SelectedIndex = 0 Then
            'UPDATE kho
            Dim query As String = "update kho set ten_kho=@ten_kho where ma_kho=@ma_kho "
            Dim save As SqlCommand = New SqlCommand(query, conn)
            Dim click As Integer = DgvKho.CurrentCell.RowIndex
            conn.Open()
            'them cap nhat bang kho
            save.Parameters.AddWithValue("@ten_kho", TxtTenKho2.Text)
            save.Parameters.AddWithValue("@ma_kho", makho)

            save.ExecuteNonQuery()
            conn.Close() 'đóng kết nối
            MessageBox.Show("Lưu thành công")

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frmQuanLyKho_Load(Nothing, Nothing)
        Else

            'UPDATE chi tiết kho
            Dim query As String = "update CHI_TIET_KHO SET Ma_sach=@MASACH, So_luong=@SL, Don_gia=@DONGIA, Ngay_nhap=@NGAY WHERE Ma_kho =@MAKHO and Ma_sach =@MASACHDK and Ngay_nhap =@NGAYDK "
            Dim save As SqlCommand = New SqlCommand(query, conn)
            Dim click As Integer = dgvChiTietKho.CurrentCell.RowIndex

            conn.Open()
            'them cap nhat bang kho
            save.Parameters.AddWithValue("@MASACH", txtmasach.Text)
            save.Parameters.AddWithValue("@SL", txtsoluong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtdongia.Text)
            save.Parameters.AddWithValue("@NGAY", dtpngaynhap.Value)
            save.Parameters.AddWithValue("@MAKHO", txtmakho.Text)
            save.Parameters.AddWithValue("@MASACHDK", dgvChiTietKho.Item(2, click).Value)
            save.Parameters.AddWithValue("@NGAYDK", dgvChiTietKho.Item(6, click).Value)
            save.ExecuteNonQuery()
            conn.Close() 'đóng kết nối
            MessageBox.Show("Lưu thành công")

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frmQuanLyKho_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub DgvKho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvKho.CellContentClick
        Dim click As Integer = DgvKho.CurrentCell.RowIndex
        makho = DgvKho.Item(0, click).Value
        tenkho = DgvKho.Item(1, click).Value
        TxtMaKho2.Text = makho
        TxtTenKho2.Text = tenkho
        txtmakho.Text = makho
        txttenkho.Text = tenkho

        Dim ctkho As New SqlDataAdapter(sqlchitietkho & "WHERE kho.ma_kho = '" & TxtMaKho2.Text & "'", conn)
        conn.Open()
        db2.Clear()
        dgvChiTietKho.DataSource = db2.DefaultView
        ctkho.Fill(db2)
        conn.Close()

        txtmasach.Text = ""
        txtsoluong.Text = ""
        txtdongia.Text = ""
        dtpngaynhap.Value = DateTime.Now

    End Sub
    Private Sub dgvChiTietKho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietKho.CellContentClick
        Dim click As Integer = dgvChiTietKho.CurrentCell.RowIndex

        txtmasach.Text = dgvChiTietKho.Item(2, click).Value
        txtsoluong.Text = dgvChiTietKho.Item(4, click).Value
        txtdongia.Text = dgvChiTietKho.Item(5, click).Value
        dtpngaynhap.Value = dgvChiTietKho.Item(6, click).Value

    End Sub

    Private Sub BtnXoaKho_Click(sender As Object, e As EventArgs) Handles BtnXoaKho.Click

        If tabKho.SelectedIndex = 0 Then
            ' Xóa ở tab kho

            Dim kho As Integer = DgvKho.CurrentCell.RowIndex
            Dim query As String = " delete from chi_tiet_kho where Ma_kho=@Ma_kho delete from kho where Ma_kho=@Ma_kho"
            Dim delete As SqlCommand = New SqlCommand(query, conn)
            Dim resulft As DialogResult = MessageBox.Show("Mọi dữ liệu liên đến kho " & tenkho & " sẽ bị xóa. ", "Bạn chắc chứ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@Ma_kho", TxtMaKho2.Text)
                delete.ExecuteNonQuery()
                MessageBox.Show("Xóa thành công", "Kho")
                conn.Close()

                'làm mới bảng
                Me.Controls.Clear() 'removes all the controls on the form
                InitializeComponent() 'load all the controls again
                frmQuanLyKho_Load(Nothing, Nothing)
            End If
        Else
            'xóa ở tab chi tiết kho
            Dim CTkho As Integer = dgvChiTietKho.CurrentCell.RowIndex
            Dim db2 As New DataTable
            Dim query As String = " delete from chi_tiet_kho where Ma_sach=@MASACH AND Ma_kho=@MAKHO AND Ngay_nhap=@NGAY "
            Dim delete As SqlCommand = New SqlCommand(query, conn)
            Dim resulft As DialogResult = MessageBox.Show("Mọi dữ liệu liên đến kho " & tenkho & " sẽ bị xóa. ", "Bạn chắc chứ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKHO", dgvChiTietKho.Rows(CTkho).Cells(0).Value)
                delete.Parameters.AddWithValue("@MASACH", dgvChiTietKho.Rows(CTkho).Cells(2).Value)
                delete.Parameters.AddWithValue("@NGAY", dgvChiTietKho.Rows(CTkho).Cells(6).Value)
                delete.ExecuteNonQuery()
                MessageBox.Show("Xóa thành công", "Chi Tiết Kho")
                conn.Close()

                'làm mới bảng
                data = New SqlDataAdapter(sqlchitietkho & "WHERE kho.ma_kho = '" & TxtMaKho2.Text & "'", conn)
                db2.Clear()
                dgvChiTietKho.DataSource = db2.DefaultView
                data.Fill(db2)
                conn.Close()
            End If
        End If

    End Sub

    Private Sub BtnHuy_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub TxtTenKho2_EditValueChanged(sender As Object, e As EventArgs) Handles TxtTenKho2.EditValueChanged
        Dim makho As String
        Dim dbmakho As New DataTable
        Dim data As SqlDataAdapter
        Dim sql As String = "select max(ma_kho) + 1 from kho"
        'Tính mã phiếu tự tăng dần
        connect.Open()
        data = New SqlDataAdapter(sql, connect)
        dbmakho.Clear()
        data.Fill(dbmakho)
        connect.Close()

        Try
            makho = dbmakho.Rows(0)(0).ToString
        Catch ex As Exception
            makho = "1"
        End Try



        Dim i As Integer = 0
        Dim kiemtra As Integer = 0
        Do While i < DgvKho.RowCount - 1
            If DgvKho.Rows(i).Cells(1).Value = TxtTenKho2.Text Then
                kiemtra += 1
            End If
            i += 1
        Loop

        If kiemtra = 0 Then
            TxtMaKho2.Text = makho
        End If

    End Sub
End Class