<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyNV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyNV))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCaiLaiMK = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txttentvht = New DevExpress.XtraEditors.TextEdit()
        Me.txtusernameht = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvNhanVien = New System.Windows.Forms.DataGridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMoTK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKhoaTK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txttentvht.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusernameht.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCaiLaiMK)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.txttentvht)
        Me.GroupBox2.Controls.Add(Me.txtusernameht)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 76)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhân viên hiện tại"
        '
        'btnCaiLaiMK
        '
        Me.btnCaiLaiMK.Image = CType(resources.GetObject("btnCaiLaiMK.Image"), System.Drawing.Image)
        Me.btnCaiLaiMK.Location = New System.Drawing.Point(254, 22)
        Me.btnCaiLaiMK.Name = "btnCaiLaiMK"
        Me.btnCaiLaiMK.Size = New System.Drawing.Size(93, 45)
        Me.btnCaiLaiMK.TabIndex = 4
        Me.btnCaiLaiMK.Text = "Reset " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(7, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "Tên nhân viên:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Username:"
        '
        'txttentvht
        '
        Me.txttentvht.Enabled = False
        Me.txttentvht.Location = New System.Drawing.Point(90, 16)
        Me.txttentvht.Name = "txttentvht"
        Me.txttentvht.Size = New System.Drawing.Size(151, 20)
        Me.txttentvht.TabIndex = 81
        '
        'txtusernameht
        '
        Me.txtusernameht.Enabled = False
        Me.txtusernameht.Location = New System.Drawing.Point(90, 52)
        Me.txtusernameht.Name = "txtusernameht"
        Me.txtusernameht.Size = New System.Drawing.Size(151, 20)
        Me.txtusernameht.TabIndex = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Controls.Add(Me.txtTenNV)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 76)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(114, 46)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(100, 21)
        Me.txtMaNV.TabIndex = 9
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(114, 11)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(100, 21)
        Me.txtTenNV.TabIndex = 8
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Image = CType(resources.GetObject("btnTimKiem.Image"), System.Drawing.Image)
        Me.btnTimKiem.Location = New System.Drawing.Point(249, 25)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(93, 45)
        Me.btnTimKiem.TabIndex = 7
        Me.btnTimKiem.Text = "Tìm kiếm"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Mã nhân viên:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tên nhân viên:"
        '
        'DgvNhanVien
        '
        Me.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNhanVien.Location = New System.Drawing.Point(12, 89)
        Me.DgvNhanVien.Name = "DgvNhanVien"
        Me.DgvNhanVien.Size = New System.Drawing.Size(719, 299)
        Me.DgvNhanVien.TabIndex = 85
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnThoat)
        Me.PanelControl3.Controls.Add(Me.btnMoTK)
        Me.PanelControl3.Controls.Add(Me.btnKhoaTK)
        Me.PanelControl3.Controls.Add(Me.btnSua)
        Me.PanelControl3.Controls.Add(Me.btnXoa)
        Me.PanelControl3.Controls.Add(Me.BtnThem)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 394)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(719, 80)
        Me.PanelControl3.TabIndex = 88
        '
        'btnThoat
        '
        Me.btnThoat.Image = Global.QuanLyThuVien.My.Resources.Resources.exit__1_
        Me.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(605, 19)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(102, 50)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Trở về"
        '
        'btnMoTK
        '
        Me.btnMoTK.Image = CType(resources.GetObject("btnMoTK.Image"), System.Drawing.Image)
        Me.btnMoTK.Location = New System.Drawing.Point(486, 19)
        Me.btnMoTK.Name = "btnMoTK"
        Me.btnMoTK.Size = New System.Drawing.Size(100, 50)
        Me.btnMoTK.TabIndex = 2
        Me.btnMoTK.Text = "Mở " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tài khoản"
        '
        'btnKhoaTK
        '
        Me.btnKhoaTK.Image = CType(resources.GetObject("btnKhoaTK.Image"), System.Drawing.Image)
        Me.btnKhoaTK.Location = New System.Drawing.Point(368, 19)
        Me.btnKhoaTK.Name = "btnKhoaTK"
        Me.btnKhoaTK.Size = New System.Drawing.Size(100, 50)
        Me.btnKhoaTK.TabIndex = 2
        Me.btnKhoaTK.Text = "Khóa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tài khoản"
        '
        'btnSua
        '
        Me.btnSua.Image = Global.QuanLyThuVien.My.Resources.Resources.edit_validated_icon
        Me.btnSua.Location = New System.Drawing.Point(249, 19)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(100, 50)
        Me.btnSua.TabIndex = 2
        Me.btnSua.Text = "Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Delete_icon
        Me.btnXoa.Location = New System.Drawing.Point(132, 19)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 50)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa"
        '
        'BtnThem
        '
        Me.BtnThem.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Add_icon
        Me.BtnThem.Location = New System.Drawing.Point(14, 19)
        Me.BtnThem.Name = "BtnThem"
        Me.BtnThem.Size = New System.Drawing.Size(100, 50)
        Me.BtnThem.TabIndex = 0
        Me.BtnThem.Text = "Thêm"
        '
        'frmQuanLyNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvNhanVien)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmQuanLyNV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txttentvht.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusernameht.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttentvht As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtusernameht As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvNhanVien As System.Windows.Forms.DataGridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCaiLaiMK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMoTK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKhoaTK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTimKiem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
End Class
