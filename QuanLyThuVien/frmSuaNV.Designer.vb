<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaNV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuaNV))
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnSuaTV = New System.Windows.Forms.Button()
        Me.LblChucVu = New DevExpress.XtraEditors.LabelControl()
        Me.LblSDT = New DevExpress.XtraEditors.LabelControl()
        Me.LblGioiTinh = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl()
        Me.LblNgaySinh = New DevExpress.XtraEditors.LabelControl()
        Me.LblDiaChi = New DevExpress.XtraEditors.LabelControl()
        Me.LblMaNV = New DevExpress.XtraEditors.LabelControl()
        Me.lblHoTen = New DevExpress.XtraEditors.LabelControl()
        Me.dtpNamSinh = New System.Windows.Forms.DateTimePicker()
        Me.LblCMND = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.TxtHoTen = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtCMND = New System.Windows.Forms.TextBox()
        Me.CbbChucVu = New System.Windows.Forms.ComboBox()
        Me.TxtDiaChi = New System.Windows.Forms.TextBox()
        Me.TxtSDT = New System.Windows.Forms.TextBox()
        Me.CbbGioiTinh = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.CbbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.Image = Global.QuanLyThuVien.My.Resources.Resources.Thoat
        Me.btnHuy.Location = New System.Drawing.Point(359, 228)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(38, 38)
        Me.btnHuy.TabIndex = 11
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnSuaTV
        '
        Me.btnSuaTV.Image = Global.QuanLyThuVien.My.Resources.Resources.Ok_icon
        Me.btnSuaTV.Location = New System.Drawing.Point(213, 228)
        Me.btnSuaTV.Name = "btnSuaTV"
        Me.btnSuaTV.Size = New System.Drawing.Size(38, 38)
        Me.btnSuaTV.TabIndex = 10
        Me.btnSuaTV.UseVisualStyleBackColor = True
        '
        'LblChucVu
        '
        Me.LblChucVu.Location = New System.Drawing.Point(329, 80)
        Me.LblChucVu.Name = "LblChucVu"
        Me.LblChucVu.Size = New System.Drawing.Size(44, 13)
        Me.LblChucVu.TabIndex = 132
        Me.LblChucVu.Text = "Chức Vụ:"
        '
        'LblSDT
        '
        Me.LblSDT.Location = New System.Drawing.Point(307, 160)
        Me.LblSDT.Name = "LblSDT"
        Me.LblSDT.Size = New System.Drawing.Size(66, 13)
        Me.LblSDT.TabIndex = 130
        Me.LblSDT.Text = "Số điện thoại:"
        '
        'LblGioiTinh
        '
        Me.LblGioiTinh.Location = New System.Drawing.Point(34, 198)
        Me.LblGioiTinh.Name = "LblGioiTinh"
        Me.LblGioiTinh.Size = New System.Drawing.Size(44, 13)
        Me.LblGioiTinh.TabIndex = 133
        Me.LblGioiTinh.Text = "Giới Tính:"
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(50, 117)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(28, 13)
        Me.lblEmail.TabIndex = 128
        Me.lblEmail.Text = "Email:"
        '
        'LblNgaySinh
        '
        Me.LblNgaySinh.Location = New System.Drawing.Point(325, 37)
        Me.LblNgaySinh.Name = "LblNgaySinh"
        Me.LblNgaySinh.Size = New System.Drawing.Size(48, 13)
        Me.LblNgaySinh.TabIndex = 127
        Me.LblNgaySinh.Text = "Năm Sinh:"
        '
        'LblDiaChi
        '
        Me.LblDiaChi.Location = New System.Drawing.Point(335, 117)
        Me.LblDiaChi.Name = "LblDiaChi"
        Me.LblDiaChi.Size = New System.Drawing.Size(38, 13)
        Me.LblDiaChi.TabIndex = 126
        Me.LblDiaChi.Text = "Địa Chỉ:"
        '
        'LblMaNV
        '
        Me.LblMaNV.Location = New System.Drawing.Point(10, 37)
        Me.LblMaNV.Name = "LblMaNV"
        Me.LblMaNV.Size = New System.Drawing.Size(68, 13)
        Me.LblMaNV.TabIndex = 124
        Me.LblMaNV.Text = "Mã nhân viên:"
        '
        'lblHoTen
        '
        Me.lblHoTen.Location = New System.Drawing.Point(27, 76)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(51, 13)
        Me.lblHoTen.TabIndex = 124
        Me.lblHoTen.Text = "Họ và tên:"
        '
        'dtpNamSinh
        '
        Me.dtpNamSinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNamSinh.Location = New System.Drawing.Point(412, 29)
        Me.dtpNamSinh.Name = "dtpNamSinh"
        Me.dtpNamSinh.Size = New System.Drawing.Size(171, 21)
        Me.dtpNamSinh.TabIndex = 6
        Me.dtpNamSinh.Value = New Date(2016, 10, 24, 0, 0, 0, 0)
        '
        'LblCMND
        '
        Me.LblCMND.Location = New System.Drawing.Point(30, 160)
        Me.LblCMND.Name = "LblCMND"
        Me.LblCMND.Size = New System.Drawing.Size(48, 13)
        Me.LblCMND.TabIndex = 140
        Me.LblCMND.Text = "Số CMND:"
        '
        'txtMaNV
        '
        Me.txtMaNV.Enabled = False
        Me.txtMaNV.Location = New System.Drawing.Point(110, 37)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(171, 21)
        Me.txtMaNV.TabIndex = 1
        '
        'TxtHoTen
        '
        Me.TxtHoTen.Location = New System.Drawing.Point(110, 72)
        Me.TxtHoTen.MaxLength = 30
        Me.TxtHoTen.Name = "TxtHoTen"
        Me.TxtHoTen.Size = New System.Drawing.Size(171, 21)
        Me.TxtHoTen.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(110, 109)
        Me.TxtEmail.MaxLength = 30
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(171, 21)
        Me.TxtEmail.TabIndex = 3
        '
        'TxtCMND
        '
        Me.TxtCMND.Location = New System.Drawing.Point(110, 152)
        Me.TxtCMND.MaxLength = 10
        Me.TxtCMND.Name = "TxtCMND"
        Me.TxtCMND.Size = New System.Drawing.Size(171, 21)
        Me.TxtCMND.TabIndex = 4
        '
        'CbbChucVu
        '
        Me.CbbChucVu.FormattingEnabled = True
        Me.CbbChucVu.Location = New System.Drawing.Point(412, 71)
        Me.CbbChucVu.Name = "CbbChucVu"
        Me.CbbChucVu.Size = New System.Drawing.Size(171, 21)
        Me.CbbChucVu.TabIndex = 7
        '
        'TxtDiaChi
        '
        Me.TxtDiaChi.Location = New System.Drawing.Point(412, 109)
        Me.TxtDiaChi.MaxLength = 50
        Me.TxtDiaChi.Name = "TxtDiaChi"
        Me.TxtDiaChi.Size = New System.Drawing.Size(171, 21)
        Me.TxtDiaChi.TabIndex = 8
        '
        'TxtSDT
        '
        Me.TxtSDT.Location = New System.Drawing.Point(412, 152)
        Me.TxtSDT.MaxLength = 11
        Me.TxtSDT.Name = "TxtSDT"
        Me.TxtSDT.Size = New System.Drawing.Size(171, 21)
        Me.TxtSDT.TabIndex = 9
        '
        'CbbGioiTinh
        '
        Me.CbbGioiTinh.EditValue = "Nam"
        Me.CbbGioiTinh.Location = New System.Drawing.Point(110, 195)
        Me.CbbGioiTinh.Name = "CbbGioiTinh"
        Me.CbbGioiTinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbbGioiTinh.Properties.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.CbbGioiTinh.Size = New System.Drawing.Size(69, 20)
        Me.CbbGioiTinh.TabIndex = 5
        '
        'frmSuaNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 289)
        Me.Controls.Add(Me.CbbGioiTinh)
        Me.Controls.Add(Me.CbbChucVu)
        Me.Controls.Add(Me.TxtCMND)
        Me.Controls.Add(Me.TxtSDT)
        Me.Controls.Add(Me.TxtDiaChi)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtHoTen)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.LblCMND)
        Me.Controls.Add(Me.dtpNamSinh)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnSuaTV)
        Me.Controls.Add(Me.LblChucVu)
        Me.Controls.Add(Me.LblSDT)
        Me.Controls.Add(Me.LblGioiTinh)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.LblNgaySinh)
        Me.Controls.Add(Me.LblDiaChi)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.LblMaNV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSuaNV"
        Me.Text = "Sửa thông tin nhân viên"
        CType(Me.CbbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnSuaTV As System.Windows.Forms.Button
    Friend WithEvents LblChucVu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblSDT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblGioiTinh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblNgaySinh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDiaChi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMaNV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHoTen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpNamSinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblCMND As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents TxtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtCMND As System.Windows.Forms.TextBox
    Friend WithEvents CbbChucVu As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents TxtSDT As System.Windows.Forms.TextBox
    Friend WithEvents CbbGioiTinh As DevExpress.XtraEditors.ComboBoxEdit
End Class
