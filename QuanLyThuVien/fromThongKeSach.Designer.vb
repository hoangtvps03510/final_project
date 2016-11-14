<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKeSach))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.TxtTongluotmuon = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.cbbGiaTri = New System.Windows.Forms.ComboBox()
        Me.cbbLoai = New System.Windows.Forms.ComboBox()
        Me.cbbKieu = New System.Windows.Forms.ComboBox()
        Me.chkChiTiet = New System.Windows.Forms.CheckBox()
        Me.btnThongKe = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLamMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.TxtTongluotmuon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(414, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Từ:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Thống kê:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnThoat)
        Me.PanelControl3.Controls.Add(Me.btnLamMoi)
        Me.PanelControl3.Controls.Add(Me.TxtTongluotmuon)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Location = New System.Drawing.Point(4, 401)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(728, 61)
        Me.PanelControl3.TabIndex = 20
        '
        'TxtTongluotmuon
        '
        Me.TxtTongluotmuon.Enabled = False
        Me.TxtTongluotmuon.Location = New System.Drawing.Point(120, 20)
        Me.TxtTongluotmuon.Name = "TxtTongluotmuon"
        Me.TxtTongluotmuon.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtTongluotmuon.Properties.Appearance.Options.UseBackColor = True
        Me.TxtTongluotmuon.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTongluotmuon.Size = New System.Drawing.Size(95, 20)
        Me.TxtTongluotmuon.TabIndex = 83
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(11, 23)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Tổng số lượt mượn:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dtpDenNgay)
        Me.PanelControl1.Controls.Add(Me.dtpTuNgay)
        Me.PanelControl1.Controls.Add(Me.cbbGiaTri)
        Me.PanelControl1.Controls.Add(Me.cbbLoai)
        Me.PanelControl1.Controls.Add(Me.btnThongKe)
        Me.PanelControl1.Controls.Add(Me.cbbKieu)
        Me.PanelControl1.Controls.Add(Me.chkChiTiet)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(4, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(728, 60)
        Me.PanelControl1.TabIndex = 18
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CustomFormat = "dd/MM/yyyy "
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(575, 14)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(101, 21)
        Me.dtpDenNgay.TabIndex = 25
        Me.dtpDenNgay.Value = New Date(2016, 10, 23, 0, 0, 0, 0)
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CustomFormat = "dd/MM/yyyy "
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(436, 14)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(108, 21)
        Me.dtpTuNgay.TabIndex = 24
        Me.dtpTuNgay.Value = New Date(2016, 10, 23, 0, 0, 0, 0)
        '
        'cbbGiaTri
        '
        Me.cbbGiaTri.Enabled = False
        Me.cbbGiaTri.FormattingEnabled = True
        Me.cbbGiaTri.Items.AddRange(New Object() {"Tất cả"})
        Me.cbbGiaTri.Location = New System.Drawing.Point(308, 14)
        Me.cbbGiaTri.Name = "cbbGiaTri"
        Me.cbbGiaTri.Size = New System.Drawing.Size(100, 21)
        Me.cbbGiaTri.TabIndex = 23
        Me.cbbGiaTri.Text = "Tất cả"
        '
        'cbbLoai
        '
        Me.cbbLoai.FormattingEnabled = True
        Me.cbbLoai.Items.AddRange(New Object() {"Sách", "Thể loại", "Tác giả", "Nhà xuất bản"})
        Me.cbbLoai.Location = New System.Drawing.Point(199, 14)
        Me.cbbLoai.Name = "cbbLoai"
        Me.cbbLoai.Size = New System.Drawing.Size(100, 21)
        Me.cbbLoai.TabIndex = 23
        Me.cbbLoai.Text = "Sách"
        '
        'cbbKieu
        '
        Me.cbbKieu.FormattingEnabled = True
        Me.cbbKieu.Items.AddRange(New Object() {"Tất cả", "Top 5", "Top 10", "Top 100"})
        Me.cbbKieu.Location = New System.Drawing.Point(61, 14)
        Me.cbbKieu.Name = "cbbKieu"
        Me.cbbKieu.Size = New System.Drawing.Size(100, 21)
        Me.cbbKieu.TabIndex = 23
        Me.cbbKieu.Text = "Tất cả"
        '
        'chkChiTiet
        '
        Me.chkChiTiet.AutoSize = True
        Me.chkChiTiet.Enabled = False
        Me.chkChiTiet.Location = New System.Drawing.Point(308, 38)
        Me.chkChiTiet.Name = "chkChiTiet"
        Me.chkChiTiet.Size = New System.Drawing.Size(15, 14)
        Me.chkChiTiet.TabIndex = 22
        Me.chkChiTiet.UseVisualStyleBackColor = True
        '
        'btnThongKe
        '
        Me.btnThongKe.Image = Global.QuanLyThuVien.My.Resources.Resources.statistical_icon
        Me.btnThongKe.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnThongKe.Location = New System.Drawing.Point(682, 8)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(37, 35)
        Me.btnThongKe.TabIndex = 21
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(549, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Đến:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(167, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Theo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(728, 325)
        Me.DataGridView1.TabIndex = 23
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnLamMoi.Location = New System.Drawing.Point(436, 5)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(117, 50)
        Me.btnLamMoi.TabIndex = 84
        Me.btnLamMoi.Text = "Làm mới"
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnThoat.Location = New System.Drawing.Point(590, 6)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(117, 50)
        Me.btnThoat.TabIndex = 85
        Me.btnThoat.Text = "Thoát"
        '
        'frmThongKeSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmThongKeSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.TxtTongluotmuon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTongluotmuon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThongKe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chkChiTiet As System.Windows.Forms.CheckBox
    Friend WithEvents cbbKieu As System.Windows.Forms.ComboBox
    Friend WithEvents cbbGiaTri As System.Windows.Forms.ComboBox
    Friend WithEvents cbbLoai As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTuNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDenNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLamMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
End Class
