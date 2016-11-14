<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeTV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKeTV))
        Me.dgvBangTV = New System.Windows.Forms.DataGridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLamMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTongsoTV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.chkChiTiet = New System.Windows.Forms.CheckBox()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.cbbGiaTri = New System.Windows.Forms.ComboBox()
        Me.cbbLoai = New System.Windows.Forms.ComboBox()
        Me.cbbTop = New System.Windows.Forms.ComboBox()
        Me.btnThongKe = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dgvBangTV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtTongsoTV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBangTV
        '
        Me.dgvBangTV.AllowUserToAddRows = False
        Me.dgvBangTV.AllowUserToDeleteRows = False
        Me.dgvBangTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBangTV.Location = New System.Drawing.Point(6, 68)
        Me.dgvBangTV.Name = "dgvBangTV"
        Me.dgvBangTV.ReadOnly = True
        Me.dgvBangTV.Size = New System.Drawing.Size(728, 325)
        Me.dgvBangTV.TabIndex = 26
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnThoat)
        Me.PanelControl3.Controls.Add(Me.btnLamMoi)
        Me.PanelControl3.Controls.Add(Me.txtTongsoTV)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Location = New System.Drawing.Point(6, 402)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(728, 61)
        Me.PanelControl3.TabIndex = 25
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnThoat.Location = New System.Drawing.Point(600, 6)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(117, 50)
        Me.btnThoat.TabIndex = 87
        Me.btnThoat.Text = "Thoát"
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnLamMoi.Location = New System.Drawing.Point(446, 5)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(117, 50)
        Me.btnLamMoi.TabIndex = 86
        Me.btnLamMoi.Text = "Làm mới"
        '
        'txtTongsoTV
        '
        Me.txtTongsoTV.Enabled = False
        Me.txtTongsoTV.Location = New System.Drawing.Point(110, 20)
        Me.txtTongsoTV.Name = "txtTongsoTV"
        Me.txtTongsoTV.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTongsoTV.Properties.Appearance.Options.UseBackColor = True
        Me.txtTongsoTV.Size = New System.Drawing.Size(151, 20)
        Me.txtTongsoTV.TabIndex = 83
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 23)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Tổng số thành viên:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.chkChiTiet)
        Me.PanelControl1.Controls.Add(Me.dtpDenNgay)
        Me.PanelControl1.Controls.Add(Me.dtpTuNgay)
        Me.PanelControl1.Controls.Add(Me.cbbGiaTri)
        Me.PanelControl1.Controls.Add(Me.cbbLoai)
        Me.PanelControl1.Controls.Add(Me.cbbTop)
        Me.PanelControl1.Controls.Add(Me.btnThongKe)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 11)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(728, 51)
        Me.PanelControl1.TabIndex = 24
        '
        'chkChiTiet
        '
        Me.chkChiTiet.AutoSize = True
        Me.chkChiTiet.Enabled = False
        Me.chkChiTiet.Location = New System.Drawing.Point(302, 37)
        Me.chkChiTiet.Name = "chkChiTiet"
        Me.chkChiTiet.Size = New System.Drawing.Size(15, 14)
        Me.chkChiTiet.TabIndex = 27
        Me.chkChiTiet.UseVisualStyleBackColor = True
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(573, 14)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(99, 21)
        Me.dtpDenNgay.TabIndex = 26
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(438, 14)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(99, 21)
        Me.dtpTuNgay.TabIndex = 25
        '
        'cbbGiaTri
        '
        Me.cbbGiaTri.Enabled = False
        Me.cbbGiaTri.FormattingEnabled = True
        Me.cbbGiaTri.Location = New System.Drawing.Point(302, 14)
        Me.cbbGiaTri.Name = "cbbGiaTri"
        Me.cbbGiaTri.Size = New System.Drawing.Size(95, 21)
        Me.cbbGiaTri.TabIndex = 24
        Me.cbbGiaTri.Text = "Tất cả"
        '
        'cbbLoai
        '
        Me.cbbLoai.FormattingEnabled = True
        Me.cbbLoai.Items.AddRange(New Object() {"Tên thành viên", "Nghề nghiệp", "Độ tuổi", "Nơi ở"})
        Me.cbbLoai.Location = New System.Drawing.Point(201, 14)
        Me.cbbLoai.Name = "cbbLoai"
        Me.cbbLoai.Size = New System.Drawing.Size(95, 21)
        Me.cbbLoai.TabIndex = 23
        Me.cbbLoai.Text = "Tên thành viên"
        '
        'cbbTop
        '
        Me.cbbTop.FormattingEnabled = True
        Me.cbbTop.Items.AddRange(New Object() {"Tất cả", "Top 5", "Top 50", "Top 100"})
        Me.cbbTop.Location = New System.Drawing.Point(65, 14)
        Me.cbbTop.Name = "cbbTop"
        Me.cbbTop.Size = New System.Drawing.Size(95, 21)
        Me.cbbTop.TabIndex = 22
        '
        'btnThongKe
        '
        Me.btnThongKe.Image = Global.QuanLyThuVien.My.Resources.Resources.statistical_icon
        Me.btnThongKe.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnThongKe.Location = New System.Drawing.Point(680, 8)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(37, 35)
        Me.btnThongKe.TabIndex = 21
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(543, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Đến:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(414, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Từ:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(167, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Theo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Thống kê:"
        '
        'frmThongKeTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvBangTV)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmThongKeTV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.dgvBangTV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtTongsoTV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBangTV As System.Windows.Forms.DataGridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTongsoTV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnThongKe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpDenNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTuNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbbGiaTri As System.Windows.Forms.ComboBox
    Friend WithEvents cbbLoai As System.Windows.Forms.ComboBox
    Friend WithEvents cbbTop As System.Windows.Forms.ComboBox
    Friend WithEvents chkChiTiet As System.Windows.Forms.CheckBox
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLamMoi As DevExpress.XtraEditors.SimpleButton
End Class
