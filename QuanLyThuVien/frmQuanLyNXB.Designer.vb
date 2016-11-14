<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyNXB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyNXB))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTenNXB = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMaNXB = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTenNXB2 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMaNXB2 = New DevExpress.XtraEditors.TextEdit()
        Me.btnTK = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DgvNXB = New System.Windows.Forms.DataGridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSuaNXB = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnXoaNXB = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnThemNXB = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtTenNXB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMaNXB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtTenNXB2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMaNXB2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvNXB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.TxtTenNXB)
        Me.GroupBox2.Controls.Add(Me.TxtMaNXB)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 76)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NXB hiện tại"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "Tên NXB:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Mã NXB:"
        '
        'TxtTenNXB
        '
        Me.TxtTenNXB.Location = New System.Drawing.Point(90, 16)
        Me.TxtTenNXB.Name = "TxtTenNXB"
        Me.TxtTenNXB.Size = New System.Drawing.Size(151, 20)
        Me.TxtTenNXB.TabIndex = 81
        '
        'TxtMaNXB
        '
        Me.TxtMaNXB.Location = New System.Drawing.Point(90, 52)
        Me.TxtMaNXB.Name = "TxtMaNXB"
        Me.TxtMaNXB.Size = New System.Drawing.Size(151, 20)
        Me.TxtMaNXB.TabIndex = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTenNXB2)
        Me.GroupBox1.Controls.Add(Me.TxtMaNXB2)
        Me.GroupBox1.Controls.Add(Me.btnTK)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 76)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'TxtTenNXB2
        '
        Me.TxtTenNXB2.Location = New System.Drawing.Point(92, 17)
        Me.TxtTenNXB2.Name = "TxtTenNXB2"
        Me.TxtTenNXB2.Size = New System.Drawing.Size(151, 20)
        Me.TxtTenNXB2.TabIndex = 85
        '
        'TxtMaNXB2
        '
        Me.TxtMaNXB2.Location = New System.Drawing.Point(92, 53)
        Me.TxtMaNXB2.Name = "TxtMaNXB2"
        Me.TxtMaNXB2.Size = New System.Drawing.Size(151, 20)
        Me.TxtMaNXB2.TabIndex = 84
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
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Mã NXB:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(42, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tên NXB:"
        '
        'DgvNXB
        '
        Me.DgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNXB.Location = New System.Drawing.Point(12, 115)
        Me.DgvNXB.Name = "DgvNXB"
        Me.DgvNXB.ReadOnly = True
        Me.DgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNXB.Size = New System.Drawing.Size(354, 268)
        Me.DgvNXB.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnBack)
        Me.PanelControl3.Controls.Add(Me.BtnSuaNXB)
        Me.PanelControl3.Controls.Add(Me.BtnXoaNXB)
        Me.PanelControl3.Controls.Add(Me.BtnThemNXB)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 387)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(721, 82)
        Me.PanelControl3.TabIndex = 90
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
        'BtnSuaNXB
        '
        Me.BtnSuaNXB.Image = Global.QuanLyThuVien.My.Resources.Resources.edit_validated_icon
        Me.BtnSuaNXB.Location = New System.Drawing.Point(397, 17)
        Me.BtnSuaNXB.Name = "BtnSuaNXB"
        Me.BtnSuaNXB.Size = New System.Drawing.Size(115, 55)
        Me.BtnSuaNXB.TabIndex = 2
        Me.BtnSuaNXB.Text = "Sửa"
        '
        'BtnXoaNXB
        '
        Me.BtnXoaNXB.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Delete_icon
        Me.BtnXoaNXB.Location = New System.Drawing.Point(218, 17)
        Me.BtnXoaNXB.Name = "BtnXoaNXB"
        Me.BtnXoaNXB.Size = New System.Drawing.Size(115, 55)
        Me.BtnXoaNXB.TabIndex = 1
        Me.BtnXoaNXB.Text = "Xóa"
        '
        'BtnThemNXB
        '
        Me.BtnThemNXB.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Add_icon
        Me.BtnThemNXB.Location = New System.Drawing.Point(36, 17)
        Me.BtnThemNXB.Name = "BtnThemNXB"
        Me.BtnThemNXB.Size = New System.Drawing.Size(115, 55)
        Me.BtnThemNXB.TabIndex = 0
        Me.BtnThemNXB.Text = "Thêm"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(372, 92)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(361, 18)
        Me.GroupBox4.TabIndex = 101
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sách trong thư viện"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(13, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 18)
        Me.GroupBox3.TabIndex = 102
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách nhà xuất bản"
        '
        'dgvSach
        '
        Me.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.Location = New System.Drawing.Point(372, 116)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.ReadOnly = True
        Me.dgvSach.Size = New System.Drawing.Size(361, 267)
        Me.dgvSach.TabIndex = 100
        '
        'frmQuanLyNXB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvSach)
        Me.Controls.Add(Me.DgvNXB)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmQuanLyNXB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtTenNXB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMaNXB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TxtTenNXB2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMaNXB2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvNXB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTenNXB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaNXB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DgvNXB As System.Windows.Forms.DataGridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSuaNXB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnXoaNXB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnThemNXB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtTenNXB2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaNXB2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSach As System.Windows.Forms.DataGridView
End Class
