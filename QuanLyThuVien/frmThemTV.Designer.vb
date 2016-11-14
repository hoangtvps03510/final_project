<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemTV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemTV))
        Me.LblNghe = New DevExpress.XtraEditors.LabelControl()
        Me.LblSDT = New DevExpress.XtraEditors.LabelControl()
        Me.lblGioiTinh = New DevExpress.XtraEditors.LabelControl()
        Me.lblNamSinh = New DevExpress.XtraEditors.LabelControl()
        Me.LblDiachi = New DevExpress.XtraEditors.LabelControl()
        Me.lblHoTen = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSDT = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.TxtHoten = New DevExpress.XtraEditors.TextEdit()
        Me.cbbGioiTinh = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BtnHuy = New System.Windows.Forms.Button()
        Me.btnThemTV = New System.Windows.Forms.Button()
        Me.DtpNamSinh = New System.Windows.Forms.DateTimePicker()
        Me.TxtCMND = New DevExpress.XtraEditors.TextEdit()
        Me.lblCMND = New DevExpress.XtraEditors.LabelControl()
        Me.cbbNghe = New System.Windows.Forms.ComboBox()
        Me.lblNgayDK = New DevExpress.XtraEditors.LabelControl()
        Me.DtpNgayDK = New System.Windows.Forms.DateTimePicker()
        CType(Me.TxtSDT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtHoten.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCMND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNghe
        '
        Me.LblNghe.Location = New System.Drawing.Point(340, 40)
        Me.LblNghe.Name = "LblNghe"
        Me.LblNghe.Size = New System.Drawing.Size(65, 13)
        Me.LblNghe.TabIndex = 144
        Me.LblNghe.Text = "Nghề Nghiệp:"
        '
        'LblSDT
        '
        Me.LblSDT.Location = New System.Drawing.Point(340, 133)
        Me.LblSDT.Name = "LblSDT"
        Me.LblSDT.Size = New System.Drawing.Size(66, 13)
        Me.LblSDT.TabIndex = 142
        Me.LblSDT.Text = "Số điện thoại:"
        '
        'lblGioiTinh
        '
        Me.lblGioiTinh.Location = New System.Drawing.Point(40, 89)
        Me.lblGioiTinh.Name = "lblGioiTinh"
        Me.lblGioiTinh.Size = New System.Drawing.Size(44, 13)
        Me.lblGioiTinh.TabIndex = 145
        Me.lblGioiTinh.Text = "Giới Tính:"
        '
        'lblNamSinh
        '
        Me.lblNamSinh.Location = New System.Drawing.Point(40, 133)
        Me.lblNamSinh.Name = "lblNamSinh"
        Me.lblNamSinh.Size = New System.Drawing.Size(48, 13)
        Me.lblNamSinh.TabIndex = 139
        Me.lblNamSinh.Text = "Năm Sinh:"
        '
        'LblDiachi
        '
        Me.LblDiachi.Location = New System.Drawing.Point(340, 89)
        Me.LblDiachi.Name = "LblDiachi"
        Me.LblDiachi.Size = New System.Drawing.Size(38, 13)
        Me.LblDiachi.TabIndex = 138
        Me.LblDiachi.Text = "Địa Chỉ:"
        '
        'lblHoTen
        '
        Me.lblHoTen.Location = New System.Drawing.Point(40, 40)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(51, 13)
        Me.lblHoTen.TabIndex = 137
        Me.lblHoTen.Text = "Họ và tên:"
        '
        'TxtSDT
        '
        Me.TxtSDT.Location = New System.Drawing.Point(423, 130)
        Me.TxtSDT.Name = "TxtSDT"
        Me.TxtSDT.Properties.MaxLength = 11
        Me.TxtSDT.Size = New System.Drawing.Size(171, 20)
        Me.TxtSDT.TabIndex = 11
        '
        'TxtDiaChi
        '
        Me.TxtDiaChi.Location = New System.Drawing.Point(423, 86)
        Me.TxtDiaChi.Name = "TxtDiaChi"
        Me.TxtDiaChi.Properties.MaxLength = 50
        Me.TxtDiaChi.Size = New System.Drawing.Size(171, 20)
        Me.TxtDiaChi.TabIndex = 6
        '
        'TxtHoten
        '
        Me.TxtHoten.Location = New System.Drawing.Point(123, 37)
        Me.TxtHoten.Name = "TxtHoten"
        Me.TxtHoten.Properties.MaxLength = 30
        Me.TxtHoten.Size = New System.Drawing.Size(171, 20)
        Me.TxtHoten.TabIndex = 1
        '
        'cbbGioiTinh
        '
        Me.cbbGioiTinh.EditValue = "Nam"
        Me.cbbGioiTinh.Location = New System.Drawing.Point(123, 86)
        Me.cbbGioiTinh.Name = "cbbGioiTinh"
        Me.cbbGioiTinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbGioiTinh.Properties.DropDownRows = 3
        Me.cbbGioiTinh.Properties.ImmediatePopup = True
        Me.cbbGioiTinh.Properties.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbbGioiTinh.Size = New System.Drawing.Size(73, 20)
        Me.cbbGioiTinh.TabIndex = 2
        '
        'BtnHuy
        '
        Me.BtnHuy.Image = Global.QuanLyThuVien.My.Resources.Resources.Thoat
        Me.BtnHuy.Location = New System.Drawing.Point(392, 222)
        Me.BtnHuy.Name = "BtnHuy"
        Me.BtnHuy.Size = New System.Drawing.Size(38, 38)
        Me.BtnHuy.TabIndex = 151
        Me.BtnHuy.UseVisualStyleBackColor = True
        '
        'btnThemTV
        '
        Me.btnThemTV.Image = Global.QuanLyThuVien.My.Resources.Resources.Ok_icon
        Me.btnThemTV.Location = New System.Drawing.Point(246, 222)
        Me.btnThemTV.Name = "btnThemTV"
        Me.btnThemTV.Size = New System.Drawing.Size(38, 38)
        Me.btnThemTV.TabIndex = 150
        Me.btnThemTV.UseVisualStyleBackColor = True
        '
        'DtpNamSinh
        '
        Me.DtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpNamSinh.Location = New System.Drawing.Point(123, 133)
        Me.DtpNamSinh.Name = "DtpNamSinh"
        Me.DtpNamSinh.Size = New System.Drawing.Size(171, 21)
        Me.DtpNamSinh.TabIndex = 3
        Me.DtpNamSinh.Value = New Date(2016, 10, 23, 11, 54, 25, 0)
        '
        'TxtCMND
        '
        Me.TxtCMND.Location = New System.Drawing.Point(123, 173)
        Me.TxtCMND.Name = "TxtCMND"
        Me.TxtCMND.Properties.MaxLength = 10
        Me.TxtCMND.Size = New System.Drawing.Size(171, 20)
        Me.TxtCMND.TabIndex = 4
        '
        'lblCMND
        '
        Me.lblCMND.Location = New System.Drawing.Point(40, 176)
        Me.lblCMND.Name = "lblCMND"
        Me.lblCMND.Size = New System.Drawing.Size(48, 13)
        Me.lblCMND.TabIndex = 143
        Me.lblCMND.Text = "Số CMND:"
        '
        'cbbNghe
        '
        Me.cbbNghe.FormattingEnabled = True
        Me.cbbNghe.Items.AddRange(New Object() {"Sinh viên", "Nhân viên văn phòng", "Kỹ thuật viên", "Hành chính - Văn phòng", "Điện - Điện tử", "Marketing-PR", "Y tế - Dược", "Quản trị kinh doanh", "Bán hàng", "Khác"})
        Me.cbbNghe.Location = New System.Drawing.Point(423, 37)
        Me.cbbNghe.Name = "cbbNghe"
        Me.cbbNghe.Size = New System.Drawing.Size(121, 21)
        Me.cbbNghe.TabIndex = 5
        Me.cbbNghe.Text = "Chọn 1 nghề "
        '
        'lblNgayDK
        '
        Me.lblNgayDK.Location = New System.Drawing.Point(340, 176)
        Me.lblNgayDK.Name = "lblNgayDK"
        Me.lblNgayDK.Size = New System.Drawing.Size(73, 13)
        Me.lblNgayDK.TabIndex = 139
        Me.lblNgayDK.Text = "Ngày Đăng Ký:"
        '
        'DtpNgayDK
        '
        Me.DtpNgayDK.Enabled = False
        Me.DtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpNgayDK.Location = New System.Drawing.Point(423, 168)
        Me.DtpNgayDK.Name = "DtpNgayDK"
        Me.DtpNgayDK.Size = New System.Drawing.Size(171, 21)
        Me.DtpNgayDK.TabIndex = 12
        Me.DtpNgayDK.Value = New Date(2016, 10, 30, 0, 0, 0, 0)
        '
        'frmThemTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 296)
        Me.Controls.Add(Me.cbbNghe)
        Me.Controls.Add(Me.DtpNgayDK)
        Me.Controls.Add(Me.DtpNamSinh)
        Me.Controls.Add(Me.BtnHuy)
        Me.Controls.Add(Me.btnThemTV)
        Me.Controls.Add(Me.LblNghe)
        Me.Controls.Add(Me.lblCMND)
        Me.Controls.Add(Me.LblSDT)
        Me.Controls.Add(Me.lblNgayDK)
        Me.Controls.Add(Me.lblGioiTinh)
        Me.Controls.Add(Me.lblNamSinh)
        Me.Controls.Add(Me.LblDiachi)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.TxtSDT)
        Me.Controls.Add(Me.TxtCMND)
        Me.Controls.Add(Me.TxtDiaChi)
        Me.Controls.Add(Me.TxtHoten)
        Me.Controls.Add(Me.cbbGioiTinh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemTV"
        Me.Text = "Đăng kí thành viên"
        CType(Me.TxtSDT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtHoten.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCMND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNghe As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblSDT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiTinh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNamSinh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDiachi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHoTen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSDT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtHoten As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbbGioiTinh As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BtnHuy As System.Windows.Forms.Button
    Friend WithEvents btnThemTV As System.Windows.Forms.Button
    Friend WithEvents DtpNamSinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCMND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCMND As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbbNghe As System.Windows.Forms.ComboBox
    Friend WithEvents lblNgayDK As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtpNgayDK As System.Windows.Forms.DateTimePicker
End Class
