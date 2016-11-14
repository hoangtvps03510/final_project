<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuaSach))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.CboTheLoai = New System.Windows.Forms.ComboBox()
        Me.CboNXB = New System.Windows.Forms.ComboBox()
        Me.CboTacGia = New System.Windows.Forms.ComboBox()
        Me.CboTenKe = New System.Windows.Forms.ComboBox()
        Me.BtnHuy = New System.Windows.Forms.Button()
        Me.lblNoiDungTDS = New System.Windows.Forms.Label()
        Me.txtNoiDungTDS = New System.Windows.Forms.RichTextBox()
        Me.lblTenHinh = New System.Windows.Forms.Label()
        Me.btnChonHinhAnhTDS = New System.Windows.Forms.Button()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.PtbAnh = New System.Windows.Forms.PictureBox()
        Me.btnSuaSach = New System.Windows.Forms.Button()
        Me.btnNhapLaiTDS = New System.Windows.Forms.Button()
        Me.lblMaSach = New DevExpress.XtraEditors.LabelControl()
        Me.lnlNXB = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTacGia = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTenSach = New DevExpress.XtraEditors.TextEdit()
        Me.DtpNgayPH = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaSach = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PtbAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboTheLoai
        '
        Me.CboTheLoai.FormattingEnabled = True
        Me.CboTheLoai.Location = New System.Drawing.Point(596, 54)
        Me.CboTheLoai.Name = "CboTheLoai"
        Me.CboTheLoai.Size = New System.Drawing.Size(131, 21)
        Me.CboTheLoai.TabIndex = 5
        '
        'CboNXB
        '
        Me.CboNXB.FormattingEnabled = True
        Me.CboNXB.Location = New System.Drawing.Point(333, 54)
        Me.CboNXB.Name = "CboNXB"
        Me.CboNXB.Size = New System.Drawing.Size(159, 21)
        Me.CboNXB.TabIndex = 4
        '
        'CboTacGia
        '
        Me.CboTacGia.FormattingEnabled = True
        Me.CboTacGia.Location = New System.Drawing.Point(333, 13)
        Me.CboTacGia.Name = "CboTacGia"
        Me.CboTacGia.Size = New System.Drawing.Size(159, 21)
        Me.CboTacGia.TabIndex = 2
        '
        'CboTenKe
        '
        Me.CboTenKe.FormattingEnabled = True
        Me.CboTenKe.Location = New System.Drawing.Point(78, 92)
        Me.CboTenKe.Name = "CboTenKe"
        Me.CboTenKe.Size = New System.Drawing.Size(171, 21)
        Me.CboTenKe.TabIndex = 6
        '
        'BtnHuy
        '
        Me.BtnHuy.Image = Global.QuanLyThuVien.My.Resources.Resources.Thoat
        Me.BtnHuy.Location = New System.Drawing.Point(408, 424)
        Me.BtnHuy.Name = "BtnHuy"
        Me.BtnHuy.Size = New System.Drawing.Size(38, 38)
        Me.BtnHuy.TabIndex = 146
        Me.BtnHuy.UseVisualStyleBackColor = True
        '
        'lblNoiDungTDS
        '
        Me.lblNoiDungTDS.AutoSize = True
        Me.lblNoiDungTDS.Location = New System.Drawing.Point(347, 179)
        Me.lblNoiDungTDS.Name = "lblNoiDungTDS"
        Me.lblNoiDungTDS.Size = New System.Drawing.Size(90, 13)
        Me.lblNoiDungTDS.TabIndex = 145
        Me.lblNoiDungTDS.Text = "Nội dung ghi chú:"
        '
        'txtNoiDungTDS
        '
        Me.txtNoiDungTDS.Location = New System.Drawing.Point(443, 179)
        Me.txtNoiDungTDS.MaxLength = 255
        Me.txtNoiDungTDS.Name = "txtNoiDungTDS"
        Me.txtNoiDungTDS.Size = New System.Drawing.Size(243, 188)
        Me.txtNoiDungTDS.TabIndex = 144
        Me.txtNoiDungTDS.Text = ""
        '
        'lblTenHinh
        '
        Me.lblTenHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTenHinh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenHinh.Location = New System.Drawing.Point(119, 376)
        Me.lblTenHinh.Name = "lblTenHinh"
        Me.lblTenHinh.Size = New System.Drawing.Size(154, 38)
        Me.lblTenHinh.TabIndex = 143
        Me.lblTenHinh.Text = "Sach000.png"
        Me.lblTenHinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChonHinhAnhTDS
        '
        Me.btnChonHinhAnhTDS.Image = Global.QuanLyThuVien.My.Resources.Resources.open_file_icon
        Me.btnChonHinhAnhTDS.Location = New System.Drawing.Point(75, 376)
        Me.btnChonHinhAnhTDS.Name = "btnChonHinhAnhTDS"
        Me.btnChonHinhAnhTDS.Size = New System.Drawing.Size(38, 38)
        Me.btnChonHinhAnhTDS.TabIndex = 7
        Me.btnChonHinhAnhTDS.UseVisualStyleBackColor = True
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(34, 179)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl12.TabIndex = 141
        Me.LabelControl12.Text = "Hình bìa sách:"
        '
        'PtbAnh
        '
        Me.PtbAnh.BackgroundImage = Global.QuanLyThuVien.My.Resources.Resources.Sach000
        Me.PtbAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PtbAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbAnh.Location = New System.Drawing.Point(119, 179)
        Me.PtbAnh.Name = "PtbAnh"
        Me.PtbAnh.Size = New System.Drawing.Size(154, 184)
        Me.PtbAnh.TabIndex = 140
        Me.PtbAnh.TabStop = False
        '
        'btnSuaSach
        '
        Me.btnSuaSach.Image = Global.QuanLyThuVien.My.Resources.Resources.Ok_icon
        Me.btnSuaSach.Location = New System.Drawing.Point(262, 424)
        Me.btnSuaSach.Name = "btnSuaSach"
        Me.btnSuaSach.Size = New System.Drawing.Size(38, 38)
        Me.btnSuaSach.TabIndex = 139
        Me.btnSuaSach.UseVisualStyleBackColor = True
        '
        'btnNhapLaiTDS
        '
        Me.btnNhapLaiTDS.Image = Global.QuanLyThuVien.My.Resources.Resources.Refresh_icon
        Me.btnNhapLaiTDS.Location = New System.Drawing.Point(552, 376)
        Me.btnNhapLaiTDS.Name = "btnNhapLaiTDS"
        Me.btnNhapLaiTDS.Size = New System.Drawing.Size(38, 38)
        Me.btnNhapLaiTDS.TabIndex = 9
        Me.btnNhapLaiTDS.UseVisualStyleBackColor = True
        '
        'lblMaSach
        '
        Me.lblMaSach.Location = New System.Drawing.Point(24, 57)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(43, 13)
        Me.lblMaSach.TabIndex = 133
        Me.lblMaSach.Text = "Mã sách:"
        '
        'lnlNXB
        '
        Me.lnlNXB.Location = New System.Drawing.Point(262, 57)
        Me.lnlNXB.Name = "lnlNXB"
        Me.lnlNXB.Size = New System.Drawing.Size(69, 13)
        Me.lnlNXB.TabIndex = 136
        Me.lnlNXB.Text = "Nhà Xuất Bản:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(509, 57)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 132
        Me.LabelControl6.Text = "Thể Loại:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(31, 95)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl7.TabIndex = 127
        Me.LabelControl7.Text = "Tên kệ:"
        '
        'lblTacGia
        '
        Me.lblTacGia.Location = New System.Drawing.Point(262, 16)
        Me.lblTacGia.Name = "lblTacGia"
        Me.lblTacGia.Size = New System.Drawing.Size(39, 13)
        Me.lblTacGia.TabIndex = 126
        Me.lblTacGia.Text = "Tác Giả:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(20, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 125
        Me.LabelControl3.Text = "Tên sách:"
        '
        'TxtTenSach
        '
        Me.TxtTenSach.Location = New System.Drawing.Point(78, 13)
        Me.TxtTenSach.Name = "TxtTenSach"
        Me.TxtTenSach.Size = New System.Drawing.Size(171, 20)
        Me.TxtTenSach.TabIndex = 1
        '
        'DtpNgayPH
        '
        Me.DtpNgayPH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpNgayPH.Location = New System.Drawing.Point(596, 10)
        Me.DtpNgayPH.Name = "DtpNgayPH"
        Me.DtpNgayPH.Size = New System.Drawing.Size(131, 21)
        Me.DtpNgayPH.TabIndex = 3
        Me.DtpNgayPH.Value = New Date(2016, 10, 23, 10, 45, 39, 0)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(509, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 154
        Me.LabelControl1.Text = "Ngày phát hành:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(78, 54)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(171, 20)
        Me.txtMaSach.TabIndex = 121
        '
        'frmSuaSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.Controls.Add(Me.DtpNgayPH)
        Me.Controls.Add(Me.LabelControl1)
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
        Me.Controls.Add(Me.btnSuaSach)
        Me.Controls.Add(Me.btnNhapLaiTDS)
        Me.Controls.Add(Me.lblMaSach)
        Me.Controls.Add(Me.lnlNXB)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.lblTacGia)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.TxtTenSach)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmSuaSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sửa sách"
        CType(Me.PtbAnh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTenSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents CboTheLoai As System.Windows.Forms.ComboBox
    Friend WithEvents CboNXB As System.Windows.Forms.ComboBox
    Friend WithEvents CboTacGia As System.Windows.Forms.ComboBox
    Friend WithEvents CboTenKe As System.Windows.Forms.ComboBox
    Friend WithEvents BtnHuy As System.Windows.Forms.Button
    Friend WithEvents lblNoiDungTDS As System.Windows.Forms.Label
    Friend WithEvents txtNoiDungTDS As System.Windows.Forms.RichTextBox
    Friend WithEvents lblTenHinh As System.Windows.Forms.Label
    Friend WithEvents btnChonHinhAnhTDS As System.Windows.Forms.Button
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PtbAnh As System.Windows.Forms.PictureBox
    Friend WithEvents btnSuaSach As System.Windows.Forms.Button
    Friend WithEvents btnNhapLaiTDS As System.Windows.Forms.Button
    Friend WithEvents lblMaSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lnlNXB As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTacGia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTenSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DtpNgayPH As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaSach As DevExpress.XtraEditors.TextEdit
End Class
