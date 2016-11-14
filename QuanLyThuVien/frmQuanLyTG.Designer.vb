<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyTG))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvTG = New System.Windows.Forms.DataGridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTenTG2 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMaTG2 = New DevExpress.XtraEditors.TextEdit()
        Me.btnTK = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTenTG = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMaTG = New DevExpress.XtraEditors.TextEdit()
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvTG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtTenTG2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMaTG2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtTenTG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMaTG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(42, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Mã tác giả:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(42, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tên tác giả:"
        '
        'DgvTG
        '
        Me.DgvTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTG.Location = New System.Drawing.Point(14, 107)
        Me.DgvTG.Name = "DgvTG"
        Me.DgvTG.ReadOnly = True
        Me.DgvTG.Size = New System.Drawing.Size(355, 267)
        Me.DgvTG.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnBack)
        Me.PanelControl3.Controls.Add(Me.BtnSua)
        Me.PanelControl3.Controls.Add(Me.BtnXoa)
        Me.PanelControl3.Controls.Add(Me.btnThem)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 380)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(717, 82)
        Me.PanelControl3.TabIndex = 8
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTenTG2)
        Me.GroupBox1.Controls.Add(Me.TxtMaTG2)
        Me.GroupBox1.Controls.Add(Me.btnTK)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 76)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'TxtTenTG2
        '
        Me.TxtTenTG2.Location = New System.Drawing.Point(101, 16)
        Me.TxtTenTG2.Name = "TxtTenTG2"
        Me.TxtTenTG2.Size = New System.Drawing.Size(151, 20)
        Me.TxtTenTG2.TabIndex = 83
        '
        'TxtMaTG2
        '
        Me.TxtMaTG2.Location = New System.Drawing.Point(101, 52)
        Me.TxtMaTG2.Name = "TxtMaTG2"
        Me.TxtMaTG2.Size = New System.Drawing.Size(151, 20)
        Me.TxtMaTG2.TabIndex = 82
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.TxtTenTG)
        Me.GroupBox2.Controls.Add(Me.TxtMaTG)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 76)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tác giả hiện tại"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "Tên tác giả:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Mã tác giả:"
        '
        'TxtTenTG
        '
        Me.TxtTenTG.Location = New System.Drawing.Point(90, 16)
        Me.TxtTenTG.Name = "TxtTenTG"
        Me.TxtTenTG.Size = New System.Drawing.Size(151, 20)
        Me.TxtTenTG.TabIndex = 81
        '
        'TxtMaTG
        '
        Me.TxtMaTG.Enabled = False
        Me.TxtMaTG.Location = New System.Drawing.Point(90, 52)
        Me.TxtMaTG.Name = "TxtMaTG"
        Me.TxtMaTG.Size = New System.Drawing.Size(151, 20)
        Me.TxtMaTG.TabIndex = 80
        '
        'dgvSach
        '
        Me.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.Location = New System.Drawing.Point(374, 107)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.ReadOnly = True
        Me.dgvSach.Size = New System.Drawing.Size(357, 267)
        Me.dgvSach.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(373, 83)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(358, 18)
        Me.GroupBox4.TabIndex = 98
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sách trong thư viện"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(13, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 18)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách tác giả"
        '
        'frmQuanLyTG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvSach)
        Me.Controls.Add(Me.DgvTG)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmQuanLyTG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.DgvTG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TxtTenTG2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMaTG2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtTenTG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMaTG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DgvTG As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTenTG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaTG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTenTG2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaTG2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgvSach As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
