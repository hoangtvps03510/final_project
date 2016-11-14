<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainform))
        Me.RealTimeSource1 = New DevExpress.Data.RealTimeSource()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnNguoiDung = New DevExpress.XtraBars.BarButtonItem()
        Me.GalleryDropDown1 = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
        Me.btnTroGiup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDangNhap = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnMuonSach = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTraSach = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuanLy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThongKe = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RealTimeSource1
        '
        Me.RealTimeSource1.DisplayableProperties = Nothing
        Me.RealTimeSource1.UseWeakEventHandler = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.btnTroGiup, Me.btnDangNhap, Me.btnNguoiDung})
        Me.BarManager1.MaxItemId = 5
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnNguoiDung, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTroGiup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDangNhap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Tools"
        '
        'btnNguoiDung
        '
        Me.btnNguoiDung.ActAsDropDown = True
        Me.btnNguoiDung.Caption = "User name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNguoiDung.DropDownControl = Me.GalleryDropDown1
        Me.btnNguoiDung.Enabled = False
        Me.btnNguoiDung.Glyph = Global.QuanLyThuVien.My.Resources.Resources.App_login_manager_icon__1_
        Me.btnNguoiDung.Id = 4
        Me.btnNguoiDung.Name = "btnNguoiDung"
        '
        'GalleryDropDown1
        '
        Me.GalleryDropDown1.Manager = Me.BarManager1
        Me.GalleryDropDown1.Name = "GalleryDropDown1"
        '
        'btnTroGiup
        '
        Me.btnTroGiup.Caption = "Help"
        Me.btnTroGiup.Glyph = Global.QuanLyThuVien.My.Resources.Resources.Actions_help_about_icon__2_
        Me.btnTroGiup.Id = 1
        Me.btnTroGiup.Name = "btnTroGiup"
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Caption = "Đăng nhập"
        Me.btnDangNhap.Glyph = Global.QuanLyThuVien.My.Resources.Resources.logout_icon
        Me.btnDangNhap.Id = 2
        Me.btnDangNhap.Name = "btnDangNhap"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(965, 63)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 573)
        Me.barDockControlBottom.Size = New System.Drawing.Size(965, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 63)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 510)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(965, 63)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 510)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "User name 1"
        Me.BarButtonItem1.Glyph = Global.QuanLyThuVien.My.Resources.Resources.App_login_manager_icon__1_
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'btnMuonSach
        '
        Me.btnMuonSach.Enabled = False
        Me.btnMuonSach.Image = Global.QuanLyThuVien.My.Resources.Resources.borrow1
        Me.btnMuonSach.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnMuonSach.Location = New System.Drawing.Point(53, 44)
        Me.btnMuonSach.Name = "btnMuonSach"
        Me.btnMuonSach.Size = New System.Drawing.Size(95, 95)
        Me.btnMuonSach.TabIndex = 0
        Me.btnMuonSach.Text = "Mượn sách"
        '
        'btnTraSach
        '
        Me.btnTraSach.Enabled = False
        Me.btnTraSach.Image = Global.QuanLyThuVien.My.Resources.Resources.return1
        Me.btnTraSach.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnTraSach.Location = New System.Drawing.Point(53, 163)
        Me.btnTraSach.Name = "btnTraSach"
        Me.btnTraSach.Size = New System.Drawing.Size(95, 95)
        Me.btnTraSach.TabIndex = 1
        Me.btnTraSach.Text = "Trả sách"
        '
        'btnQuanLy
        '
        Me.btnQuanLy.Enabled = False
        Me.btnQuanLy.Image = Global.QuanLyThuVien.My.Resources.Resources.bookshelf__1_
        Me.btnQuanLy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnQuanLy.Location = New System.Drawing.Point(53, 279)
        Me.btnQuanLy.Name = "btnQuanLy"
        Me.btnQuanLy.Size = New System.Drawing.Size(95, 95)
        Me.btnQuanLy.TabIndex = 2
        Me.btnQuanLy.Text = "Quản lý"
        '
        'btnThongKe
        '
        Me.btnThongKe.Enabled = False
        Me.btnThongKe.Image = Global.QuanLyThuVien.My.Resources.Resources.SEO_icon
        Me.btnThongKe.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnThongKe.Location = New System.Drawing.Point(53, 393)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(95, 95)
        Me.btnThongKe.TabIndex = 3
        Me.btnThongKe.Text = "Thống kê"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.btnThongKe)
        Me.PanelControl1.Controls.Add(Me.btnQuanLy)
        Me.PanelControl1.Controls.Add(Me.btnTraSach)
        Me.PanelControl1.Controls.Add(Me.btnMuonSach)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 64)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(212, 507)
        Me.PanelControl1.TabIndex = 9
        '
        'GroupControl1
        '
        Me.GroupControl1.Location = New System.Drawing.Point(218, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(887, 567)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "GroupControl1"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = Global.QuanLyThuVien.My.Resources.Resources.Books_2_icon
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton5.Location = New System.Drawing.Point(67, 104)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(95, 95)
        Me.SimpleButton5.TabIndex = 0
        Me.SimpleButton5.Text = "Mượn sách"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = Global.QuanLyThuVien.My.Resources.Resources.Books_2_icon
        Me.SimpleButton6.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton6.Location = New System.Drawing.Point(67, 223)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(95, 95)
        Me.SimpleButton6.TabIndex = 1
        Me.SimpleButton6.Text = "Trả sách"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = Global.QuanLyThuVien.My.Resources.Resources.books_icon
        Me.SimpleButton7.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton7.Location = New System.Drawing.Point(67, 339)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(95, 95)
        Me.SimpleButton7.TabIndex = 2
        Me.SimpleButton7.Text = "SimpleButton3"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'frmMainform
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.None
        Me.BackgroundImageStore = Global.QuanLyThuVien.My.Resources.Resources.nen
        Me.ClientSize = New System.Drawing.Size(965, 573)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximumSize = New System.Drawing.Size(981, 612)
        Me.MinimumSize = New System.Drawing.Size(973, 600)
        Me.Name = "frmMainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý thư viện"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RealTimeSource1 As DevExpress.Data.RealTimeSource
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTroGiup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDangNhap As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnNguoiDung As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnThongKe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuanLy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTraSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMuonSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents GalleryDropDown1 As DevExpress.XtraBars.Ribbon.GalleryDropDown
End Class
