<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheLoai
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTheLoai))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        Me.DgvTL = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTenTl = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMaTl = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTenTL2 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMaTl2 = New DevExpress.XtraEditors.TextEdit()
        Me.btnTK = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtTenTl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMaTl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtTenTL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMaTl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(371, 89)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(358, 18)
        Me.GroupBox4.TabIndex = 105
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sách trong thư viện"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(11, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 18)
        Me.GroupBox3.TabIndex = 106
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách Thể loại"
        '
        'dgvSach
        '
        Me.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.Location = New System.Drawing.Point(372, 113)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.ReadOnly = True
        Me.dgvSach.Size = New System.Drawing.Size(357, 267)
        Me.dgvSach.TabIndex = 100
        '
        'DgvTL
        '
        Me.DgvTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTL.Location = New System.Drawing.Point(12, 113)
        Me.DgvTL.Name = "DgvTL"
        Me.DgvTL.ReadOnly = True
        Me.DgvTL.Size = New System.Drawing.Size(355, 267)
        Me.DgvTL.TabIndex = 101
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.TxtTenTl)
        Me.GroupBox2.Controls.Add(Me.TxtMaTl)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 76)
        Me.GroupBox2.TabIndex = 104
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thể loại hiện tại"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "Tên Thể loại:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Mã Thể loại:"
        '
        'TxtTenTl
        '
        Me.TxtTenTl.Location = New System.Drawing.Point(90, 16)
        Me.TxtTenTl.Name = "TxtTenTl"
        Me.TxtTenTl.Size = New System.Drawing.Size(151, 20)
        Me.TxtTenTl.TabIndex = 81
        '
        'TxtMaTl
        '
        Me.TxtMaTl.Enabled = False
        Me.TxtMaTl.Location = New System.Drawing.Point(90, 52)
        Me.TxtMaTl.Name = "TxtMaTl"
        Me.TxtMaTl.Size = New System.Drawing.Size(151, 20)
        Me.TxtMaTl.TabIndex = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTenTL2)
        Me.GroupBox1.Controls.Add(Me.TxtMaTl2)
        Me.GroupBox1.Controls.Add(Me.btnTK)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 76)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'TxtTenTL2
        '
        Me.TxtTenTL2.Location = New System.Drawing.Point(101, 16)
        Me.TxtTenTL2.Name = "TxtTenTL2"
        Me.TxtTenTL2.Size = New System.Drawing.Size(151, 20)
        Me.TxtTenTL2.TabIndex = 83
        '
        'TxtMaTl2
        '
        Me.TxtMaTl2.Location = New System.Drawing.Point(101, 52)
        Me.TxtMaTl2.Name = "TxtMaTl2"
        Me.TxtMaTl2.Size = New System.Drawing.Size(151, 20)
        Me.TxtMaTl2.TabIndex = 82
        '
        'btnTK
        '
        Me.btnTK.Image = CType(resources.GetObject("btnTK.Image"), System.Drawing.Image)
        Me.btnTK.Location = New System.Drawing.Point(261, 19)
        Me.btnTK.Name = "btnTK"
        Me.btnTK.Size = New System.Drawing.Size(93, 45)
        Me.btnTK.TabIndex = 4
        Me.btnTK.Text = "Tìm kiếm"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(42, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Mã Thể loại:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(42, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tên Thể loại:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnBack)
        Me.PanelControl3.Controls.Add(Me.BtnSua)
        Me.PanelControl3.Controls.Add(Me.BtnXoa)
        Me.PanelControl3.Controls.Add(Me.btnThem)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 386)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(717, 82)
        Me.PanelControl3.TabIndex = 102
        '
        'btnBack
        '
        Me.btnBack.Image = Global.QuanLyThuVien.My.Resources.Resources.exit__2_
        Me.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(564, 17)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 55)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Trở về"
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.QuanLyThuVien.My.Resources.Resources.edit_validated_icon
        Me.BtnSua.Location = New System.Drawing.Point(397, 17)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(115, 55)
        Me.BtnSua.TabIndex = 2
        Me.BtnSua.Text = "Sửa"
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Delete_icon
        Me.BtnXoa.Location = New System.Drawing.Point(218, 17)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(115, 55)
        Me.BtnXoa.TabIndex = 1
        Me.BtnXoa.Text = "Xóa"
        '
        'btnThem
        '
        Me.btnThem.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Add_icon
        Me.btnThem.Location = New System.Drawing.Point(36, 17)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(115, 55)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm"
        '
        'frmTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvSach)
        Me.Controls.Add(Me.DgvTL)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmTheLoai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtTenTl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMaTl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TxtTenTL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMaTl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSach As System.Windows.Forms.DataGridView
    Friend WithEvents DgvTL As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTenTl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaTl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTenTL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaTl2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
End Class
