<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemNV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemNV))
        Me.CbbChucVu = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CbbGioiTinh = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LblChucVu = New DevExpress.XtraEditors.LabelControl()
        Me.LblCMND = New DevExpress.XtraEditors.LabelControl()
        Me.LblSDT = New DevExpress.XtraEditors.LabelControl()
        Me.LblGioiTinh = New DevExpress.XtraEditors.LabelControl()
        Me.LblMatKhau = New DevExpress.XtraEditors.LabelControl()
        Me.LblNgaySinh = New DevExpress.XtraEditors.LabelControl()
        Me.LblDiaChi = New DevExpress.XtraEditors.LabelControl()
        Me.lblTaiKhoan = New DevExpress.XtraEditors.LabelControl()
        Me.LblHoTen = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSDT = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCMND = New DevExpress.XtraEditors.TextEdit()
        Me.TxtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTaiKhoan = New DevExpress.XtraEditors.TextEdit()
        Me.TxtHoTen = New DevExpress.XtraEditors.TextEdit()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.TxtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnThemNV = New System.Windows.Forms.Button()
        Me.DtpNamSinh = New System.Windows.Forms.DateTimePicker()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        CType(Me.CbbChucVu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSDT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCMND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTaiKhoan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtHoTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbbChucVu
        '
        Me.CbbChucVu.EditValue = "Quản lý"
        Me.CbbChucVu.Location = New System.Drawing.Point(443, 71)
        Me.CbbChucVu.Name = "CbbChucVu"
        Me.CbbChucVu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbbChucVu.Properties.Items.AddRange(New Object() {"Quản lý", "Thủ thư"})
        Me.CbbChucVu.Size = New System.Drawing.Size(108, 20)
        Me.CbbChucVu.TabIndex = 7
        '
        'CbbGioiTinh
        '
        Me.CbbGioiTinh.EditValue = "Nam"
        Me.CbbGioiTinh.Location = New System.Drawing.Point(106, 155)
        Me.CbbGioiTinh.Name = "CbbGioiTinh"
        Me.CbbGioiTinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbbGioiTinh.Properties.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.CbbGioiTinh.Size = New System.Drawing.Size(69, 20)
        Me.CbbGioiTinh.TabIndex = 4
        '
        'LblChucVu
        '
        Me.LblChucVu.Location = New System.Drawing.Point(360, 78)
        Me.LblChucVu.Name = "LblChucVu"
        Me.LblChucVu.Size = New System.Drawing.Size(44, 13)
        Me.LblChucVu.TabIndex = 87
        Me.LblChucVu.Text = "Chức Vụ:"
        '
        'LblCMND
        '
        Me.LblCMND.Location = New System.Drawing.Point(356, 196)
        Me.LblCMND.Name = "LblCMND"
        Me.LblCMND.Size = New System.Drawing.Size(48, 13)
        Me.LblCMND.TabIndex = 86
        Me.LblCMND.Text = "Số CMND:"
        '
        'LblSDT
        '
        Me.LblSDT.Location = New System.Drawing.Point(338, 158)
        Me.LblSDT.Name = "LblSDT"
        Me.LblSDT.Size = New System.Drawing.Size(66, 13)
        Me.LblSDT.TabIndex = 85
        Me.LblSDT.Text = "Số điện thoại:"
        '
        'LblGioiTinh
        '
        Me.LblGioiTinh.Location = New System.Drawing.Point(30, 158)
        Me.LblGioiTinh.Name = "LblGioiTinh"
        Me.LblGioiTinh.Size = New System.Drawing.Size(44, 13)
        Me.LblGioiTinh.TabIndex = 88
        Me.LblGioiTinh.Text = "Giới Tính:"
        '
        'LblMatKhau
        '
        Me.LblMatKhau.Location = New System.Drawing.Point(26, 115)
        Me.LblMatKhau.Name = "LblMatKhau"
        Me.LblMatKhau.Size = New System.Drawing.Size(48, 13)
        Me.LblMatKhau.TabIndex = 84
        Me.LblMatKhau.Text = "Mật khẩu:"
        '
        'LblNgaySinh
        '
        Me.LblNgaySinh.Location = New System.Drawing.Point(356, 35)
        Me.LblNgaySinh.Name = "LblNgaySinh"
        Me.LblNgaySinh.Size = New System.Drawing.Size(48, 13)
        Me.LblNgaySinh.TabIndex = 81
        Me.LblNgaySinh.Text = "Năm Sinh:"
        '
        'LblDiaChi
        '
        Me.LblDiaChi.Location = New System.Drawing.Point(366, 115)
        Me.LblDiaChi.Name = "LblDiaChi"
        Me.LblDiaChi.Size = New System.Drawing.Size(38, 13)
        Me.LblDiaChi.TabIndex = 80
        Me.LblDiaChi.Text = "Địa Chỉ:"
        '
        'lblTaiKhoan
        '
        Me.lblTaiKhoan.Location = New System.Drawing.Point(23, 75)
        Me.lblTaiKhoan.Name = "lblTaiKhoan"
        Me.lblTaiKhoan.Size = New System.Drawing.Size(51, 13)
        Me.lblTaiKhoan.TabIndex = 79
        Me.lblTaiKhoan.Text = "Tài Khoản:"
        '
        'LblHoTen
        '
        Me.LblHoTen.Location = New System.Drawing.Point(23, 35)
        Me.LblHoTen.Name = "LblHoTen"
        Me.LblHoTen.Size = New System.Drawing.Size(51, 13)
        Me.LblHoTen.TabIndex = 78
        Me.LblHoTen.Text = "Họ và tên:"
        '
        'TxtSDT
        '
        Me.TxtSDT.Location = New System.Drawing.Point(443, 155)
        Me.TxtSDT.Name = "TxtSDT"
        Me.TxtSDT.Properties.MaxLength = 11
        Me.TxtSDT.Size = New System.Drawing.Size(171, 20)
        Me.TxtSDT.TabIndex = 9
        '
        'TxtCMND
        '
        Me.TxtCMND.Location = New System.Drawing.Point(443, 193)
        Me.TxtCMND.Name = "TxtCMND"
        Me.TxtCMND.Properties.MaxLength = 10
        Me.TxtCMND.Size = New System.Drawing.Size(171, 20)
        Me.TxtCMND.TabIndex = 11
        '
        'TxtDiaChi
        '
        Me.TxtDiaChi.Location = New System.Drawing.Point(443, 112)
        Me.TxtDiaChi.Name = "TxtDiaChi"
        Me.TxtDiaChi.Properties.MaxLength = 50
        Me.TxtDiaChi.Size = New System.Drawing.Size(171, 20)
        Me.TxtDiaChi.TabIndex = 8
        '
        'TxtTaiKhoan
        '
        Me.TxtTaiKhoan.Location = New System.Drawing.Point(106, 72)
        Me.TxtTaiKhoan.Name = "TxtTaiKhoan"
        Me.TxtTaiKhoan.Properties.MaxLength = 20
        Me.TxtTaiKhoan.Size = New System.Drawing.Size(171, 20)
        Me.TxtTaiKhoan.TabIndex = 2
        '
        'TxtHoTen
        '
        Me.TxtHoTen.Location = New System.Drawing.Point(106, 32)
        Me.TxtHoTen.Name = "TxtHoTen"
        Me.TxtHoTen.Properties.MaxLength = 30
        Me.TxtHoTen.Size = New System.Drawing.Size(171, 20)
        Me.TxtHoTen.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(46, 196)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(28, 13)
        Me.lblEmail.TabIndex = 83
        Me.lblEmail.Text = "Email:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(106, 193)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Properties.MaxLength = 30
        Me.TxtEmail.Size = New System.Drawing.Size(171, 20)
        Me.TxtEmail.TabIndex = 5
        '
        'btnHuy
        '
        Me.btnHuy.Image = Global.QuanLyThuVien.My.Resources.Resources.Thoat
        Me.btnHuy.Location = New System.Drawing.Point(376, 245)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(38, 38)
        Me.btnHuy.TabIndex = 115
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnThemNV
        '
        Me.btnThemNV.Image = Global.QuanLyThuVien.My.Resources.Resources.Ok_icon
        Me.btnThemNV.Location = New System.Drawing.Point(230, 245)
        Me.btnThemNV.Name = "btnThemNV"
        Me.btnThemNV.Size = New System.Drawing.Size(38, 38)
        Me.btnThemNV.TabIndex = 114
        Me.btnThemNV.UseVisualStyleBackColor = True
        '
        'DtpNamSinh
        '
        Me.DtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpNamSinh.Location = New System.Drawing.Point(443, 27)
        Me.DtpNamSinh.Name = "DtpNamSinh"
        Me.DtpNamSinh.Size = New System.Drawing.Size(171, 21)
        Me.DtpNamSinh.TabIndex = 6
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(106, 112)
        Me.txtMatKhau.MaxLength = 20
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(171, 21)
        Me.txtMatKhau.TabIndex = 3
        Me.txtMatKhau.Text = "11111111"
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'frmThemNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 307)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.DtpNamSinh)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnThemNV)
        Me.Controls.Add(Me.CbbChucVu)
        Me.Controls.Add(Me.CbbGioiTinh)
        Me.Controls.Add(Me.LblChucVu)
        Me.Controls.Add(Me.LblCMND)
        Me.Controls.Add(Me.LblSDT)
        Me.Controls.Add(Me.LblGioiTinh)
        Me.Controls.Add(Me.LblMatKhau)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.LblNgaySinh)
        Me.Controls.Add(Me.LblDiaChi)
        Me.Controls.Add(Me.lblTaiKhoan)
        Me.Controls.Add(Me.LblHoTen)
        Me.Controls.Add(Me.TxtSDT)
        Me.Controls.Add(Me.TxtCMND)
        Me.Controls.Add(Me.TxtDiaChi)
        Me.Controls.Add(Me.TxtTaiKhoan)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtHoTen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmThemNV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm nhân viên"
        CType(Me.CbbChucVu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSDT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCMND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTaiKhoan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtHoTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbChucVu As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CbbGioiTinh As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LblChucVu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCMND As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblSDT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblGioiTinh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMatKhau As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblNgaySinh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDiaChi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTaiKhoan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblHoTen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSDT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCMND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTaiKhoan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtHoTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnThemNV As System.Windows.Forms.Button
    Friend WithEvents DtpNamSinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
End Class
