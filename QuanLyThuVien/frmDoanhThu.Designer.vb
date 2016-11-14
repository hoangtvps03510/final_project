<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoanhThu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoanhThu))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTongDT = New DevExpress.XtraEditors.TextEdit()
        Me.txtTongSoHoaDon = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnThongKe = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.dgvBangDT = New System.Windows.Forms.DataGridView()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLamMoi = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtTongDT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongSoHoaDon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvBangDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(295, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Đến ngày:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(35, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Từ ngày:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtTongDT)
        Me.PanelControl3.Controls.Add(Me.txtTongSoHoaDon)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Location = New System.Drawing.Point(11, 405)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(714, 63)
        Me.PanelControl3.TabIndex = 17
        '
        'txtTongDT
        '
        Me.txtTongDT.Enabled = False
        Me.txtTongDT.Location = New System.Drawing.Point(482, 25)
        Me.txtTongDT.Name = "txtTongDT"
        Me.txtTongDT.Size = New System.Drawing.Size(151, 20)
        Me.txtTongDT.TabIndex = 83
        '
        'txtTongSoHoaDon
        '
        Me.txtTongSoHoaDon.Enabled = False
        Me.txtTongSoHoaDon.Location = New System.Drawing.Point(123, 21)
        Me.txtTongSoHoaDon.Name = "txtTongSoHoaDon"
        Me.txtTongSoHoaDon.Size = New System.Drawing.Size(151, 20)
        Me.txtTongSoHoaDon.TabIndex = 83
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(396, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Tổng doanh thu:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(33, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Tổng số hóa đơn:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnThoat)
        Me.PanelControl1.Controls.Add(Me.btnLamMoi)
        Me.PanelControl1.Controls.Add(Me.btnThongKe)
        Me.PanelControl1.Controls.Add(Me.dtpDenNgay)
        Me.PanelControl1.Controls.Add(Me.dtpTuNgay)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(714, 51)
        Me.PanelControl1.TabIndex = 15
        '
        'btnThongKe
        '
        Me.btnThongKe.Image = Global.QuanLyThuVien.My.Resources.Resources.statistical_icon
        Me.btnThongKe.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnThongKe.Location = New System.Drawing.Point(533, 9)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(37, 35)
        Me.btnThongKe.TabIndex = 18
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(364, 17)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(143, 21)
        Me.dtpDenNgay.TabIndex = 17
        Me.dtpDenNgay.Value = New Date(2016, 10, 23, 9, 44, 24, 0)
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(98, 17)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(143, 21)
        Me.dtpTuNgay.TabIndex = 16
        Me.dtpTuNgay.Value = New Date(2016, 10, 20, 22, 0, 0, 0)
        '
        'dgvBangDT
        '
        Me.dgvBangDT.AllowUserToAddRows = False
        Me.dgvBangDT.AllowUserToDeleteRows = False
        Me.dgvBangDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBangDT.Location = New System.Drawing.Point(11, 72)
        Me.dgvBangDT.Name = "dgvBangDT"
        Me.dgvBangDT.ReadOnly = True
        Me.dgvBangDT.Size = New System.Drawing.Size(714, 325)
        Me.dgvBangDT.TabIndex = 18
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnThoat.Location = New System.Drawing.Point(647, 11)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(37, 35)
        Me.btnThoat.TabIndex = 21
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnLamMoi.Location = New System.Drawing.Point(588, 10)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(37, 35)
        Me.btnLamMoi.TabIndex = 20
        '
        'frmDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvBangDT)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmDoanhThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtTongDT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongSoHoaDon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgvBangDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvBangDT As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDenNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTuNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTongDT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTongSoHoaDon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnThongKe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLamMoi As DevExpress.XtraEditors.SimpleButton
End Class
