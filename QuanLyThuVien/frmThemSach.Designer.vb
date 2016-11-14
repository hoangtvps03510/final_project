<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemSach
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemSach))
        Me.SbtnLamMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.SbtnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.lnlNXB = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTacGia = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTenSach = New DevExpress.XtraEditors.TextEdit()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTenHinh = New System.Windows.Forms.Label()
        Me.lblNoiDungTDS = New System.Windows.Forms.Label()
        Me.txtNoiDungTDS = New System.Windows.Forms.RichTextBox()
        Me.BtnHuy = New System.Windows.Forms.Button()
        Me.btnChonHinhAnhTDS = New System.Windows.Forms.Button()
        Me.PtbAnh = New System.Windows.Forms.PictureBox()
        Me.btnThemSach = New System.Windows.Forms.Button()
        Me.btnNhapLaiTDS = New System.Windows.Forms.Button()
        Me.CboTenKe = New System.Windows.Forms.ComboBox()
        Me.CboTacGia = New System.Windows.Forms.ComboBox()
        Me.CboNXB = New System.Windows.Forms.ComboBox()
        Me.CboTheLoai = New System.Windows.Forms.ComboBox()
        Me.DtpNgayPH = New System.Windows.Forms.DateTimePicker()
        CType(Me.TxtTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SbtnLamMoi
        '
        Me.SbtnLamMoi.Location = New System.Drawing.Point(491, 488)
        Me.SbtnLamMoi.Name = "SbtnLamMoi"
        Me.SbtnLamMoi.Size = New System.Drawing.Size(100, 30)
        Me.SbtnLamMoi.TabIndex = 102
        Me.SbtnLamMoi.Text = "Làm Mới"
        '
        'SbtnThem
        '
        Me.SbtnThem.Location = New System.Drawing.Point(321, 488)
        Me.SbtnThem.Name = "SbtnThem"
        Me.SbtnThem.Size = New System.Drawing.Size(100, 30)
        Me.SbtnThem.TabIndex = 101
        Me.SbtnThem.Text = "Thêm"
        '
        'lnlNXB
        '
        Me.lnlNXB.Location = New System.Drawing.Point(382, 84)
        Me.lnlNXB.Name = "lnlNXB"
        Me.lnlNXB.Size = New System.Drawing.Size(69, 13)
        Me.lnlNXB.TabIndex = 95
        Me.lnlNXB.Text = "Nhà Xuất Bản:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(54, 81)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 91
        Me.LabelControl6.Text = "Thể Loại:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(382, 128)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 88
        Me.LabelControl1.Text = "Ngày phát hành:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(54, 128)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl7.TabIndex = 86
        Me.LabelControl7.Text = "Tên kệ:"
        '
        'lblTacGia
        '
        Me.lblTacGia.Location = New System.Drawing.Point(382, 30)
        Me.lblTacGia.Name = "lblTacGia"
        Me.lblTacGia.Size = New System.Drawing.Size(39, 13)
        Me.lblTacGia.TabIndex = 85
        Me.lblTacGia.Text = "Tác Giả:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(54, 27)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 84
        Me.LabelControl3.Text = "Tên sách:"
        '
        'TxtTenSach
        '
        Me.TxtTenSach.Location = New System.Drawing.Point(138, 24)
        Me.TxtTenSach.Name = "TxtTenSach"
        Me.TxtTenSach.Size = New System.Drawing.Size(171, 20)
        Me.TxtTenSach.TabIndex = 1
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(39, 190)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl12.TabIndex = 108
        Me.LabelControl12.Text = "Hình bìa sách:"
        '
        'lblTenHinh
        '
        Me.lblTenHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTenHinh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenHinh.Location = New System.Drawing.Point(124, 387)
        Me.lblTenHinh.Name = "lblTenHinh"
        Me.lblTenHinh.Size = New System.Drawing.Size(154, 38)
        Me.lblTenHinh.TabIndex = 110
        Me.lblTenHinh.Text = "Sach000.png"
        Me.lblTenHinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNoiDungTDS
        '
        Me.lblNoiDungTDS.AutoSize = True
        Me.lblNoiDungTDS.Location = New System.Drawing.Point(352, 190)
        Me.lblNoiDungTDS.Name = "lblNoiDungTDS"
        Me.lblNoiDungTDS.Size = New System.Drawing.Size(90, 13)
        Me.lblNoiDungTDS.TabIndex = 112
        Me.lblNoiDungTDS.Text = "Nội dung ghi chú:"
        '
        'txtNoiDungTDS
        '
        Me.txtNoiDungTDS.Location = New System.Drawing.Point(448, 187)
        Me.txtNoiDungTDS.MaxLength = 255
        Me.txtNoiDungTDS.Name = "txtNoiDungTDS"
        Me.txtNoiDungTDS.Size = New System.Drawing.Size(243, 188)
        Me.txtNoiDungTDS.TabIndex = 111
        Me.txtNoiDungTDS.Text = ""
        '
        'BtnHuy
        '
        Me.BtnHuy.Image = Global.QuanLyThuVien.My.Resources.Resources.Thoat
        Me.BtnHuy.Location = New System.Drawing.Point(413, 435)
        Me.BtnHuy.Name = "BtnHuy"
        Me.BtnHuy.Size = New System.Drawing.Size(38, 38)
        Me.BtnHuy.TabIndex = 113
        Me.BtnHuy.UseVisualStyleBackColor = True
        '
        'btnChonHinhAnhTDS
        '
        Me.btnChonHinhAnhTDS.Image = Global.QuanLyThuVien.My.Resources.Resources.open_file_icon
        Me.btnChonHinhAnhTDS.Location = New System.Drawing.Point(80, 387)
        Me.btnChonHinhAnhTDS.Name = "btnChonHinhAnhTDS"
        Me.btnChonHinhAnhTDS.Size = New System.Drawing.Size(38, 38)
        Me.btnChonHinhAnhTDS.TabIndex = 8
        Me.btnChonHinhAnhTDS.UseVisualStyleBackColor = True
        '
        'PtbAnh
        '
        Me.PtbAnh.BackgroundImage = Global.QuanLyThuVien.My.Resources.Resources.Sach000
        Me.PtbAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PtbAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbAnh.Location = New System.Drawing.Point(124, 190)
        Me.PtbAnh.Name = "PtbAnh"
        Me.PtbAnh.Size = New System.Drawing.Size(154, 184)
        Me.PtbAnh.TabIndex = 107
        Me.PtbAnh.TabStop = False
        '
        'btnThemSach
        '
        Me.btnThemSach.Image = Global.QuanLyThuVien.My.Resources.Resources.Ok_icon
        Me.btnThemSach.Location = New System.Drawing.Point(267, 435)
        Me.btnThemSach.Name = "btnThemSach"
        Me.btnThemSach.Size = New System.Drawing.Size(38, 38)
        Me.btnThemSach.TabIndex = 106
        Me.btnThemSach.UseVisualStyleBackColor = True
        '
        'btnNhapLaiTDS
        '
        Me.btnNhapLaiTDS.Image = Global.QuanLyThuVien.My.Resources.Resources.Refresh_icon
        Me.btnNhapLaiTDS.Location = New System.Drawing.Point(557, 387)
        Me.btnNhapLaiTDS.Name = "btnNhapLaiTDS"
        Me.btnNhapLaiTDS.Size = New System.Drawing.Size(38, 38)
        Me.btnNhapLaiTDS.TabIndex = 9
        Me.btnNhapLaiTDS.UseVisualStyleBackColor = True
        '
        'CboTenKe
        '
        Me.CboTenKe.FormattingEnabled = True
        Me.CboTenKe.Location = New System.Drawing.Point(138, 125)
        Me.CboTenKe.Name = "CboTenKe"
        Me.CboTenKe.Size = New System.Drawing.Size(173, 21)
        Me.CboTenKe.TabIndex = 3
        '
        'CboTacGia
        '
        Me.CboTacGia.FormattingEnabled = True
        Me.CboTacGia.Location = New System.Drawing.Point(485, 27)
        Me.CboTacGia.Name = "CboTacGia"
        Me.CboTacGia.Size = New System.Drawing.Size(186, 21)
        Me.CboTacGia.TabIndex = 4
        '
        'CboNXB
        '
        Me.CboNXB.FormattingEnabled = True
        Me.CboNXB.Location = New System.Drawing.Point(485, 81)
        Me.CboNXB.Name = "CboNXB"
        Me.CboNXB.Size = New System.Drawing.Size(186, 21)
        Me.CboNXB.TabIndex = 5
        '
        'CboTheLoai
        '
        Me.CboTheLoai.FormattingEnabled = True
        Me.CboTheLoai.Location = New System.Drawing.Point(138, 78)
        Me.CboTheLoai.Name = "CboTheLoai"
        Me.CboTheLoai.Size = New System.Drawing.Size(171, 21)
        Me.CboTheLoai.TabIndex = 2
        '
        'DtpNgayPH
        '
        Me.DtpNgayPH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpNgayPH.Location = New System.Drawing.Point(485, 128)
        Me.DtpNgayPH.Name = "DtpNgayPH"
        Me.DtpNgayPH.Size = New System.Drawing.Size(186, 21)
        Me.DtpNgayPH.TabIndex = 6
        Me.DtpNgayPH.Value = New Date(2016, 10, 23, 10, 45, 39, 0)
        '
        'frmThemSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.Controls.Add(Me.DtpNgayPH)
        Me.Controls.Add(Me.CboTheLoai)
        Me.Controls.Add(Me.CboNXB)
        Me.Controls.Add(Me.CboTacGia)
        Me.Controls.Add(Me.CboTenKe)
        Me.Controls.Add(Me.BtnHuy)
        Me.Controls.Add(Me.lblNoiDungTDS)
        Me.Controls.Add(Me.txtNoiDungTDS)
        Me.Controls.Add(Me.lblTenHinh)
        Me.Controls.Add(Me.btnChonHinhAnhTDS)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.PtbAnh)
        Me.Controls.Add(Me.btnThemSach)
        Me.Controls.Add(Me.btnNhapLaiTDS)
        Me.Controls.Add(Me.SbtnLamMoi)
        Me.Controls.Add(Me.SbtnThem)
        Me.Controls.Add(Me.lnlNXB)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.lblTacGia)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TxtTenSach)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmThemSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Thêm sách"
        CType(Me.TxtTenSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbAnh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SbtnLamMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SbtnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lnlNXB As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTacGia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTenSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btnThemSach As System.Windows.Forms.Button
    Friend WithEvents btnNhapLaiTDS As System.Windows.Forms.Button
    Friend WithEvents PtbAnh As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTenHinh As System.Windows.Forms.Label
    Friend WithEvents btnChonHinhAnhTDS As System.Windows.Forms.Button
    Friend WithEvents lblNoiDungTDS As System.Windows.Forms.Label
    Friend WithEvents txtNoiDungTDS As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnHuy As System.Windows.Forms.Button
    Friend WithEvents CboTenKe As System.Windows.Forms.ComboBox
    Friend WithEvents CboTacGia As System.Windows.Forms.ComboBox
    Friend WithEvents CboNXB As System.Windows.Forms.ComboBox
    Friend WithEvents CboTheLoai As System.Windows.Forms.ComboBox
    Friend WithEvents DtpNgayPH As System.Windows.Forms.DateTimePicker
End Class
