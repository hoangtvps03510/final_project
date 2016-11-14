<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTV
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyTV))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.DgvThanhVien = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaTV = New System.Windows.Forms.TextBox()
        Me.txtTenTV = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.txtMa = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.DgvThanhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Mã thành viên:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tên thành viên:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnBack)
        Me.PanelControl3.Controls.Add(Me.btnSua)
        Me.PanelControl3.Controls.Add(Me.btnXoa)
        Me.PanelControl3.Controls.Add(Me.BtnThem)
        Me.PanelControl3.Location = New System.Drawing.Point(8, 388)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(721, 82)
        Me.PanelControl3.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.Image = Global.QuanLyThuVien.My.Resources.Resources.exit__1_
        Me.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(565, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(102, 50)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Trở về"
        '
        'btnSua
        '
        Me.btnSua.Image = Global.QuanLyThuVien.My.Resources.Resources.edit_validated_icon
        Me.btnSua.Location = New System.Drawing.Point(402, 19)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(100, 50)
        Me.btnSua.TabIndex = 2
        Me.btnSua.Text = "Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Delete_icon
        Me.btnXoa.Location = New System.Drawing.Point(228, 19)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 50)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa"
        '
        'BtnThem
        '
        Me.BtnThem.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Add_icon
        Me.BtnThem.Location = New System.Drawing.Point(58, 19)
        Me.BtnThem.Name = "BtnThem"
        Me.BtnThem.Size = New System.Drawing.Size(100, 50)
        Me.BtnThem.TabIndex = 0
        Me.BtnThem.Text = "Thêm"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.Name = "SqlDataSource1"
        '
        'DgvThanhVien
        '
        Me.DgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvThanhVien.Location = New System.Drawing.Point(8, 83)
        Me.DgvThanhVien.Name = "DgvThanhVien"
        Me.DgvThanhVien.ReadOnly = True
        Me.DgvThanhVien.Size = New System.Drawing.Size(721, 299)
        Me.DgvThanhVien.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaTV)
        Me.GroupBox1.Controls.Add(Me.txtTenTV)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 76)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm"
        '
        'txtMaTV
        '
        Me.txtMaTV.Location = New System.Drawing.Point(111, 51)
        Me.txtMaTV.Name = "txtMaTV"
        Me.txtMaTV.Size = New System.Drawing.Size(100, 21)
        Me.txtMaTV.TabIndex = 10
        '
        'txtTenTV
        '
        Me.txtTenTV.Location = New System.Drawing.Point(111, 11)
        Me.txtTenTV.Name = "txtTenTV"
        Me.txtTenTV.Size = New System.Drawing.Size(100, 21)
        Me.txtTenTV.TabIndex = 9
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Image = CType(resources.GetObject("btnTimKiem.Image"), System.Drawing.Image)
        Me.btnTimKiem.Location = New System.Drawing.Point(258, 19)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(93, 45)
        Me.btnTimKiem.TabIndex = 8
        Me.btnTimKiem.Text = "Tìm kiếm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.txtTen)
        Me.GroupBox2.Controls.Add(Me.txtMa)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 76)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thành viên hiện tại"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(26, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "Họ và tên:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(26, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Mã thành viên:"
        '
        'txtTen
        '
        Me.txtTen.Enabled = False
        Me.txtTen.Location = New System.Drawing.Point(109, 12)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(171, 20)
        Me.txtTen.TabIndex = 81
        '
        'txtMa
        '
        Me.txtMa.Enabled = False
        Me.txtMa.Location = New System.Drawing.Point(109, 52)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(171, 20)
        Me.txtMa.TabIndex = 80
        '
        'frmQuanLyTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvThanhVien)
        Me.Controls.Add(Me.PanelControl3)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmQuanLyTV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.DgvThanhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents DgvThanhVien As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTimKiem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMaTV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenTV As System.Windows.Forms.TextBox
End Class
