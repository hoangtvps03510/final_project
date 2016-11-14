<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiPhi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiPhi))
        Me.dgvBangCP = New System.Windows.Forms.DataGridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLamMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.btnThongKe = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTongCP = New DevExpress.XtraEditors.TextEdit()
        Me.txtTongSachNhap = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgvBangCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtTongCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongSachNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBangCP
        '
        Me.dgvBangCP.AllowUserToAddRows = False
        Me.dgvBangCP.AllowUserToDeleteRows = False
        Me.dgvBangCP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBangCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBangCP.Location = New System.Drawing.Point(14, 67)
        Me.dgvBangCP.Name = "dgvBangCP"
        Me.dgvBangCP.ReadOnly = True
        Me.dgvBangCP.Size = New System.Drawing.Size(714, 325)
        Me.dgvBangCP.TabIndex = 22
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnThoat)
        Me.PanelControl1.Controls.Add(Me.btnLamMoi)
        Me.PanelControl1.Controls.Add(Me.dtpDenNgay)
        Me.PanelControl1.Controls.Add(Me.dtpTuNgay)
        Me.PanelControl1.Controls.Add(Me.btnThongKe)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(14, 7)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(714, 51)
        Me.PanelControl1.TabIndex = 21
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnLamMoi.Location = New System.Drawing.Point(579, 11)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(37, 35)
        Me.btnLamMoi.TabIndex = 18
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(364, 17)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(143, 21)
        Me.dtpDenNgay.TabIndex = 17
        Me.dtpDenNgay.Value = New Date(2016, 10, 21, 23, 20, 45, 0)
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(98, 17)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(143, 21)
        Me.dtpTuNgay.TabIndex = 16
        Me.dtpTuNgay.Value = New Date(2016, 7, 1, 0, 0, 0, 0)
        '
        'btnThongKe
        '
        Me.btnThongKe.Image = Global.QuanLyThuVien.My.Resources.Resources.statistical_icon
        Me.btnThongKe.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnThongKe.Location = New System.Drawing.Point(524, 11)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(37, 35)
        Me.btnThongKe.TabIndex = 15
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
        Me.PanelControl3.Controls.Add(Me.txtTongCP)
        Me.PanelControl3.Controls.Add(Me.txtTongSachNhap)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 403)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(714, 63)
        Me.PanelControl3.TabIndex = 23
        '
        'txtTongCP
        '
        Me.txtTongCP.Enabled = False
        Me.txtTongCP.Location = New System.Drawing.Point(515, 25)
        Me.txtTongCP.Name = "txtTongCP"
        Me.txtTongCP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTongCP.Properties.Appearance.Options.UseBackColor = True
        Me.txtTongCP.Size = New System.Drawing.Size(151, 20)
        Me.txtTongCP.TabIndex = 82
        '
        'txtTongSachNhap
        '
        Me.txtTongSachNhap.Enabled = False
        Me.txtTongSachNhap.Location = New System.Drawing.Point(133, 21)
        Me.txtTongSachNhap.Name = "txtTongSachNhap"
        Me.txtTongSachNhap.Size = New System.Drawing.Size(151, 20)
        Me.txtTongSachNhap.TabIndex = 82
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(396, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Tổng chi phí nhập sách:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(33, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Tổng số sách nhập:"
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnThoat.Location = New System.Drawing.Point(638, 12)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(37, 35)
        Me.btnThoat.TabIndex = 19
        '
        'frmChiPhi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.dgvBangCP)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmChiPhi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.dgvBangCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtTongCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongSachNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBangCP As System.Windows.Forms.DataGridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtpDenNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTuNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnThongKe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTongCP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTongSachNhap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLamMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
End Class
