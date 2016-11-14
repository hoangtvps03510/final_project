Partial Public Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnLogin = New DevExpress.XtraBars.BarButtonItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(75, 113)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Tên đăng nhập:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(75, 161)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Mật khẩu:"
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Location = New System.Drawing.Point(229, 110)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(161, 21)
        Me.txtTenDangNhap.TabIndex = 10
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(229, 153)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(161, 21)
        Me.txtMatKhau.TabIndex = 11
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(148, 217)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnDangNhap.TabIndex = 16
        Me.btnDangNhap.Text = "Đăng nhập"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(287, 217)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 17
        Me.btnThoat.Text = "Thoát"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 23.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(42, 26)
        Me.LabelControl3.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(375, 37)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Phần mềm quản lý thư viện"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Main menu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Main menu"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Main menu"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Main menu"
        '
        'btnLogin
        '
        Me.btnLogin.Caption = "Login"
        Me.btnLogin.Glyph = Global.QuanLyThuVien.My.Resources.Resources.App_login_manager_icon__1_
        Me.btnLogin.Id = 1
        Me.btnLogin.Name = "btnLogin"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.QuanLyThuVien.My.Resources.Resources.bookshelf__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(425, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 61)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.ClientSize = New System.Drawing.Size(509, 275)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(270, 85)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(525, 314)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(517, 302)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Đăng nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDangNhap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnLogin As DevExpress.XtraBars.BarButtonItem

#End Region

End Class
