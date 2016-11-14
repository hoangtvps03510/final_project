<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyKho
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTenKho2 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtMaKho2 = New DevExpress.XtraEditors.TextEdit()
        Me.dgvChiTietKho = New System.Windows.Forms.DataGridView()
        Me.DgvKho = New System.Windows.Forms.DataGridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSuaKho = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnXoaKho = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnThemKho = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttenkho = New System.Windows.Forms.TextBox()
        Me.txtmakho = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpngaynhap = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtmasach = New System.Windows.Forms.TextBox()
        Me.tabKho = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtTenKho2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMaKho2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChiTietKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvKho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabKho.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.TxtTenKho2)
        Me.GroupBox2.Controls.Add(Me.TxtMaKho2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 76)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin kho"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 82
        Me.LabelControl3.Text = "Tên kho:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(405, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Mã kho:"
        '
        'TxtTenKho2
        '
        Me.TxtTenKho2.Location = New System.Drawing.Point(90, 35)
        Me.TxtTenKho2.Name = "TxtTenKho2"
        Me.TxtTenKho2.Size = New System.Drawing.Size(240, 20)
        Me.TxtTenKho2.TabIndex = 81
        '
        'TxtMaKho2
        '
        Me.TxtMaKho2.Enabled = False
        Me.TxtMaKho2.Location = New System.Drawing.Point(468, 35)
        Me.TxtMaKho2.Name = "TxtMaKho2"
        Me.TxtMaKho2.Size = New System.Drawing.Size(240, 20)
        Me.TxtMaKho2.TabIndex = 80
        '
        'dgvChiTietKho
        '
        Me.dgvChiTietKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChiTietKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietKho.Location = New System.Drawing.Point(0, 149)
        Me.dgvChiTietKho.Name = "dgvChiTietKho"
        Me.dgvChiTietKho.ReadOnly = True
        Me.dgvChiTietKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChiTietKho.Size = New System.Drawing.Size(730, 202)
        Me.dgvChiTietKho.TabIndex = 0
        '
        'DgvKho
        '
        Me.DgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvKho.Location = New System.Drawing.Point(11, 125)
        Me.DgvKho.Name = "DgvKho"
        Me.DgvKho.ReadOnly = True
        Me.DgvKho.Size = New System.Drawing.Size(709, 215)
        Me.DgvKho.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnBack)
        Me.PanelControl3.Controls.Add(Me.BtnSuaKho)
        Me.PanelControl3.Controls.Add(Me.BtnXoaKho)
        Me.PanelControl3.Controls.Add(Me.BtnThemKho)
        Me.PanelControl3.Location = New System.Drawing.Point(5, 382)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(721, 82)
        Me.PanelControl3.TabIndex = 94
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
        'BtnSuaKho
        '
        Me.BtnSuaKho.Image = Global.QuanLyThuVien.My.Resources.Resources.edit_validated_icon
        Me.BtnSuaKho.Location = New System.Drawing.Point(397, 17)
        Me.BtnSuaKho.Name = "BtnSuaKho"
        Me.BtnSuaKho.Size = New System.Drawing.Size(115, 55)
        Me.BtnSuaKho.TabIndex = 2
        Me.BtnSuaKho.Text = "Sửa"
        '
        'BtnXoaKho
        '
        Me.BtnXoaKho.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Delete_icon
        Me.BtnXoaKho.Location = New System.Drawing.Point(218, 17)
        Me.BtnXoaKho.Name = "BtnXoaKho"
        Me.BtnXoaKho.Size = New System.Drawing.Size(115, 55)
        Me.BtnXoaKho.TabIndex = 1
        Me.BtnXoaKho.Text = "Xóa"
        '
        'BtnThemKho
        '
        Me.BtnThemKho.Image = Global.QuanLyThuVien.My.Resources.Resources.Button_Add_icon
        Me.BtnThemKho.Location = New System.Drawing.Point(36, 17)
        Me.BtnThemKho.Name = "BtnThemKho"
        Me.BtnThemKho.Size = New System.Drawing.Size(115, 55)
        Me.BtnThemKho.TabIndex = 0
        Me.BtnThemKho.Text = "Thêm"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(10, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 18)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách kho"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txttenkho)
        Me.GroupBox4.Controls.Add(Me.txtmakho)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dtpngaynhap)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtsoluong)
        Me.GroupBox4.Controls.Add(Me.txtdongia)
        Me.GroupBox4.Controls.Add(Me.txtmasach)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(718, 137)
        Me.GroupBox4.TabIndex = 97
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chi tiết trong kho"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Tên kho:"
        '
        'txttenkho
        '
        Me.txttenkho.Enabled = False
        Me.txttenkho.Location = New System.Drawing.Point(488, 28)
        Me.txttenkho.Name = "txttenkho"
        Me.txttenkho.Size = New System.Drawing.Size(207, 21)
        Me.txttenkho.TabIndex = 109
        '
        'txtmakho
        '
        Me.txtmakho.Enabled = False
        Me.txtmakho.Location = New System.Drawing.Point(121, 28)
        Me.txtmakho.Name = "txtmakho"
        Me.txtmakho.Size = New System.Drawing.Size(207, 21)
        Me.txtmakho.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Mã Kho:"
        '
        'dtpngaynhap
        '
        Me.dtpngaynhap.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngaynhap.Location = New System.Drawing.Point(488, 61)
        Me.dtpngaynhap.Name = "dtpngaynhap"
        Me.dtpngaynhap.Size = New System.Drawing.Size(207, 21)
        Me.dtpngaynhap.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Ngày Nhập:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Đơn Gía:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Số Lượng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Mã Sách:"
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(121, 96)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(207, 21)
        Me.txtsoluong.TabIndex = 101
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(488, 96)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(207, 21)
        Me.txtdongia.TabIndex = 100
        '
        'txtmasach
        '
        Me.txtmasach.Location = New System.Drawing.Point(121, 61)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.Size = New System.Drawing.Size(207, 21)
        Me.txtmasach.TabIndex = 98
        '
        'tabKho
        '
        Me.tabKho.Controls.Add(Me.TabPage1)
        Me.tabKho.Controls.Add(Me.TabPage2)
        Me.tabKho.Location = New System.Drawing.Point(-2, -1)
        Me.tabKho.Name = "tabKho"
        Me.tabKho.SelectedIndex = 0
        Me.tabKho.Size = New System.Drawing.Size(738, 377)
        Me.tabKho.TabIndex = 84
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.DgvKho)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(730, 351)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "KHO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.dgvChiTietKho)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(730, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Thông Tin Kho"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmQuanLyKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(735, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabKho)
        Me.Controls.Add(Me.PanelControl3)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmQuanLyKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtTenKho2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMaKho2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChiTietKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvKho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabKho.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTenKho2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMaKho2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DgvKho As System.Windows.Forms.DataGridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSuaKho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnXoaKho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnThemKho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvChiTietKho As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tabKho As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtmasach As System.Windows.Forms.TextBox
    Friend WithEvents dtpngaynhap As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttenkho As System.Windows.Forms.TextBox
    Friend WithEvents txtmakho As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
