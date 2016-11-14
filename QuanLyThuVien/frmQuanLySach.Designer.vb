<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLySach))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboGiaTri = New System.Windows.Forms.ComboBox()
        Me.cboLoai = New System.Windows.Forms.ComboBox()
        Me.TxtTim = New System.Windows.Forms.TextBox()
        Me.BtnTimKiem = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.DgvSach = New System.Windows.Forms.DataGridView()
        Me.grbTieuDe2 = New System.Windows.Forms.GroupBox()
        Me.ptbBia = New System.Windows.Forms.PictureBox()
        Me.BtnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnThem = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.DgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboGiaTri)
        Me.PanelControl1.Controls.Add(Me.cboLoai)
        Me.PanelControl1.Controls.Add(Me.TxtTim)
        Me.PanelControl1.Controls.Add(Me.BtnTimKiem)
        Me.PanelControl1.Location = New System.Drawing.Point(2, 1)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(736, 76)
        Me.PanelControl1.TabIndex = 0
        '
        'cboGiaTri
        '
        Me.cboGiaTri.FormattingEnabled = True
        Me.cboGiaTri.Location = New System.Drawing.Point(330, 22)
        Me.cboGiaTri.Name = "cboGiaTri"
        Me.cboGiaTri.Size = New System.Drawing.Size(104, 21)
        Me.cboGiaTri.TabIndex = 12
        '
        'cboLoai
        '
        Me.cboLoai.FormattingEnabled = True
        Me.cboLoai.Items.AddRange(New Object() {"Sách", "Thể loại", "Tác giả", "Nhà xuất bản"})
        Me.cboLoai.Location = New System.Drawing.Point(215, 22)
        Me.cboLoai.Name = "cboLoai"
        Me.cboLoai.Size = New System.Drawing.Size(109, 21)
        Me.cboLoai.TabIndex = 11
        Me.cboLoai.Text = "Sách"
        '
        'TxtTim
        '
        Me.TxtTim.Location = New System.Drawing.Point(24, 22)
        Me.TxtTim.Name = "TxtTim"
        Me.TxtTim.Size = New System.Drawing.Size(153, 21)
        Me.TxtTim.TabIndex = 10
        '
        'BtnTimKiem
        '
        Me.BtnTimKiem.Image = CType(resources.GetObject("BtnTimKiem.Image"), System.Drawing.Image)
        Me.BtnTimKiem.Location = New System.Drawing.Point(449, 11)
        Me.BtnTimKiem.Name = "BtnTimKiem"
        Me.BtnTimKiem.Size = New System.Drawing.Size(93, 45)
        Me.BtnTimKiem.TabIndex = 9
        Me.BtnTimKiem.Text = "Tìm kiếm"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.DgvSach)
        Me.PanelControl2.Controls.Add(Me.grbTieuDe2)
        Me.PanelControl2.Controls.Add(Me.ptbBia)
        Me.PanelControl2.Location = New System.Drawing.Point(2, 83)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(736, 308)
        Me.PanelControl2.TabIndex = 1
        '
        'DgvSach
        '
        Me.DgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSach.Location = New System.Drawing.Point(0, 0)
        Me.DgvSach.Name = "DgvSach"
        Me.DgvSach.ReadOnly = True
        Me.DgvSach.Size = New System.Drawing.Size(546, 301)
        Me.DgvSach.TabIndex = 14
        '
        'grbTieuDe2
        '
        Me.grbTieuDe2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.grbTieuDe2.Location = New System.Drawing.Point(552, 5)
        Me.grbTieuDe2.Name = "grbTieuDe2"
        Me.grbTieuDe2.Size = New System.Drawing.Size(173, 26)
        Me.grbTieuDe2.TabIndex = 13
        Me.grbTieuDe2.TabStop = False
        Me.grbTieuDe2.Text = "Trang bìa"
        '
        'ptbBia
        '
        Me.ptbBia.BackgroundImage = Global.QuanLyThuVien.My.Resources.Resources.Sach000
        Me.ptbBia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbBia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbBia.Location = New System.Drawing.Point(552, 49)
        Me.ptbBia.Name = "ptbBia"
        Me.ptbBia.Size = New System.Drawing.Size(175, 216)
        Me.ptbBia.TabIndex = 3
        Me.ptbBia.TabStop = False
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.QuanLyThuVien.My.Resources.Resources.edit_validated_icon
        Me.BtnSua.Location = New System.Drawing.Point(388, 21)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(100, 50)
        Me.BtnSua.TabIndex = 2
        Me.BtnSua.Text = "Sửa"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.BtnSua)
        Me.PanelControl3.Controls.Add(Me.btnBack)
        Me.PanelControl3.Controls.Add(Me.BtnXoa)
        Me.PanelControl3.Controls.Add(Me.BtnThem)
        Me.PanelControl3.Location = New System.Drawing.Point(2, 390)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(736, 82)
        Me.PanelControl3.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.Image = Global.QuanLyThuVien.My.Resources.Resources.exit__2_
        Me.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(590, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 58)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Trở về"
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Delete_icon
        Me.BtnXoa.Location = New System.Drawing.Point(224, 21)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(100, 50)
        Me.BtnXoa.TabIndex = 1
        Me.BtnXoa.Text = "Xóa"
        '
        'BtnThem
        '
        Me.BtnThem.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Add_icon
        Me.BtnThem.Location = New System.Drawing.Point(60, 22)
        Me.BtnThem.Name = "BtnThem"
        Me.BtnThem.Size = New System.Drawing.Size(100, 50)
        Me.BtnThem.TabIndex = 0
        Me.BtnThem.Text = "Thêm"
        '
        'frmQuanLySach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmQuanLySach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.DgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ptbBia As System.Windows.Forms.PictureBox
    Friend WithEvents grbTieuDe2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTimKiem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DgvSach As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTim As System.Windows.Forms.TextBox
    Friend WithEvents cboGiaTri As System.Windows.Forms.ComboBox
    Friend WithEvents cboLoai As System.Windows.Forms.ComboBox
End Class
