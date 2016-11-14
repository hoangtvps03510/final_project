<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyCP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyCP))
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtMaSach = New DevExpress.XtraEditors.TextEdit()
        Me.TxtGia = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.DgvGia = New System.Windows.Forms.DataGridView()
        Me.CboTenSach = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.dtbTimKiem = New System.Windows.Forms.DateTimePicker()
        Me.btntk = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TxtMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.DgvGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(220, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Giá:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(192, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Tên sách:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Mã sách:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Ngày:"
        '
        'TxtMaSach
        '
        Me.TxtMaSach.Location = New System.Drawing.Point(60, 49)
        Me.TxtMaSach.Name = "TxtMaSach"
        Me.TxtMaSach.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMaSach.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMaSach.Size = New System.Drawing.Size(126, 20)
        Me.TxtMaSach.TabIndex = 8
        '
        'TxtGia
        '
        Me.TxtGia.Location = New System.Drawing.Point(246, 49)
        Me.TxtGia.Name = "TxtGia"
        Me.TxtGia.Size = New System.Drawing.Size(142, 20)
        Me.TxtGia.TabIndex = 7
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnBack)
        Me.PanelControl3.Controls.Add(Me.BtnXoa)
        Me.PanelControl3.Controls.Add(Me.BtnThem)
        Me.PanelControl3.Location = New System.Drawing.Point(3, 390)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(728, 82)
        Me.PanelControl3.TabIndex = 14
        '
        'btnBack
        '
        Me.btnBack.Image = Global.QuanLyThuVien.My.Resources.Resources.exit__2_
        Me.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(571, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 55)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Trở về"
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Delete_icon
        Me.BtnXoa.Location = New System.Drawing.Point(320, 14)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(115, 55)
        Me.BtnXoa.TabIndex = 5
        Me.BtnXoa.Text = "Xóa"
        '
        'BtnThem
        '
        Me.BtnThem.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Add_icon
        Me.BtnThem.Location = New System.Drawing.Point(62, 14)
        Me.BtnThem.Name = "BtnThem"
        Me.BtnThem.Size = New System.Drawing.Size(115, 55)
        Me.BtnThem.TabIndex = 4
        Me.BtnThem.Text = "Thêm"
        '
        'DgvGia
        '
        Me.DgvGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGia.Location = New System.Drawing.Point(3, 83)
        Me.DgvGia.Name = "DgvGia"
        Me.DgvGia.ReadOnly = True
        Me.DgvGia.Size = New System.Drawing.Size(728, 301)
        Me.DgvGia.TabIndex = 15
        '
        'CboTenSach
        '
        Me.CboTenSach.FormattingEnabled = True
        Me.CboTenSach.Location = New System.Drawing.Point(246, 17)
        Me.CboTenSach.Name = "CboTenSach"
        Me.CboTenSach.Size = New System.Drawing.Size(142, 21)
        Me.CboTenSach.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpNgay)
        Me.GroupBox2.Controls.Add(Me.CboTenSach)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.TxtGia)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.TxtMaSach)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 76)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin giá"
        '
        'DtpNgay
        '
        Me.DtpNgay.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DtpNgay.Enabled = False
        Me.DtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpNgay.Location = New System.Drawing.Point(60, 19)
        Me.DtpNgay.Name = "DtpNgay"
        Me.DtpNgay.Size = New System.Drawing.Size(126, 21)
        Me.DtpNgay.TabIndex = 15
        Me.DtpNgay.Value = New Date(2016, 10, 18, 21, 57, 11, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttk)
        Me.GroupBox1.Controls.Add(Me.dtbTimKiem)
        Me.GroupBox1.Controls.Add(Me.btntk)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 76)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'txttk
        '
        Me.txttk.Location = New System.Drawing.Point(105, 16)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(143, 21)
        Me.txttk.TabIndex = 12
        '
        'dtbTimKiem
        '
        Me.dtbTimKiem.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtbTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbTimKiem.Location = New System.Drawing.Point(105, 49)
        Me.dtbTimKiem.Name = "dtbTimKiem"
        Me.dtbTimKiem.Size = New System.Drawing.Size(143, 21)
        Me.dtbTimKiem.TabIndex = 11
        Me.dtbTimKiem.Value = New Date(2016, 10, 18, 21, 57, 11, 0)
        '
        'btntk
        '
        Me.btntk.Image = CType(resources.GetObject("btntk.Image"), System.Drawing.Image)
        Me.btntk.Location = New System.Drawing.Point(269, 20)
        Me.btntk.Name = "btntk"
        Me.btntk.Size = New System.Drawing.Size(43, 45)
        Me.btntk.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(60, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Ngày:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(42, 19)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "Tên sách:"
        '
        'frmQuanLyCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DgvGia)
        Me.Controls.Add(Me.PanelControl3)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmQuanLyCP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.TxtMaSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.DgvGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TxtMaSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvGia As System.Windows.Forms.DataGridView
    Friend WithEvents CboTenSach As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btntk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtbTimKiem As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttk As System.Windows.Forms.TextBox
End Class
