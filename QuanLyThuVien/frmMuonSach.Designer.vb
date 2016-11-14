<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuonSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuonSach))
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenSachTK = New DevExpress.XtraEditors.SearchControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnMuonSach = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChonSach = New DevExpress.XtraEditors.SimpleButton()
        Me.txtsosach = New System.Windows.Forms.TextBox()
        Me.dgvXemDanhSach = New System.Windows.Forms.DataGridView()
        Me.ptbHinhSachQL = New System.Windows.Forms.PictureBox()
        Me.lblTieuDeQL = New System.Windows.Forms.Label()
        Me.grbTieuDe2QL = New System.Windows.Forms.GroupBox()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenSachTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhSachQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabFormDefaultManager1
        '
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
        Me.TabFormDefaultManager1.Form = Me
        Me.TabFormDefaultManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(739, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 474)
        Me.barDockControlBottom.Size = New System.Drawing.Size(739, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 474)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(739, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 474)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.txtTenSachTK)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(735, 73)
        Me.PanelControl1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Tên Sách:"
        '
        'txtTenSachTK
        '
        Me.txtTenSachTK.Location = New System.Drawing.Point(96, 27)
        Me.txtTenSachTK.MenuManager = Me.TabFormDefaultManager1
        Me.txtTenSachTK.Name = "txtTenSachTK"
        Me.txtTenSachTK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txtTenSachTK.Size = New System.Drawing.Size(204, 20)
        Me.txtTenSachTK.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnMuonSach)
        Me.PanelControl2.Controls.Add(Me.btnChonSach)
        Me.PanelControl2.Controls.Add(Me.txtsosach)
        Me.PanelControl2.Controls.Add(Me.dgvXemDanhSach)
        Me.PanelControl2.Controls.Add(Me.ptbHinhSachQL)
        Me.PanelControl2.Controls.Add(Me.lblTieuDeQL)
        Me.PanelControl2.Controls.Add(Me.grbTieuDe2QL)
        Me.PanelControl2.Location = New System.Drawing.Point(0, 82)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(735, 386)
        Me.PanelControl2.TabIndex = 20
        '
        'btnMuonSach
        '
        Me.btnMuonSach.Location = New System.Drawing.Point(636, 325)
        Me.btnMuonSach.Name = "btnMuonSach"
        Me.btnMuonSach.Size = New System.Drawing.Size(75, 23)
        Me.btnMuonSach.TabIndex = 65
        Me.btnMuonSach.Text = "Hoàn tất"
        '
        'btnChonSach
        '
        Me.btnChonSach.Location = New System.Drawing.Point(418, 325)
        Me.btnChonSach.Name = "btnChonSach"
        Me.btnChonSach.Size = New System.Drawing.Size(75, 23)
        Me.btnChonSach.TabIndex = 64
        Me.btnChonSach.Text = "Chọn sách"
        '
        'txtsosach
        '
        Me.txtsosach.Location = New System.Drawing.Point(303, 327)
        Me.txtsosach.Name = "txtsosach"
        Me.txtsosach.Size = New System.Drawing.Size(100, 21)
        Me.txtsosach.TabIndex = 63
        '
        'dgvXemDanhSach
        '
        Me.dgvXemDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemDanhSach.Location = New System.Drawing.Point(15, 60)
        Me.dgvXemDanhSach.Name = "dgvXemDanhSach"
        Me.dgvXemDanhSach.ReadOnly = True
        Me.dgvXemDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvXemDanhSach.Size = New System.Drawing.Size(469, 229)
        Me.dgvXemDanhSach.TabIndex = 60
        '
        'ptbHinhSachQL
        '
        Me.ptbHinhSachQL.BackgroundImage = CType(resources.GetObject("ptbHinhSachQL.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSachQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSachQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSachQL.Location = New System.Drawing.Point(513, 33)
        Me.ptbHinhSachQL.Name = "ptbHinhSachQL"
        Me.ptbHinhSachQL.Size = New System.Drawing.Size(198, 256)
        Me.ptbHinhSachQL.TabIndex = 57
        Me.ptbHinhSachQL.TabStop = False
        '
        'lblTieuDeQL
        '
        Me.lblTieuDeQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTieuDeQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTieuDeQL.Location = New System.Drawing.Point(15, 33)
        Me.lblTieuDeQL.Name = "lblTieuDeQL"
        Me.lblTieuDeQL.Size = New System.Drawing.Size(469, 24)
        Me.lblTieuDeQL.TabIndex = 58
        Me.lblTieuDeQL.Text = "Danh Sách"
        Me.lblTieuDeQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbTieuDe2QL
        '
        Me.grbTieuDe2QL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grbTieuDe2QL.Location = New System.Drawing.Point(491, 17)
        Me.grbTieuDe2QL.Name = "grbTieuDe2QL"
        Me.grbTieuDe2QL.Size = New System.Drawing.Size(236, 19)
        Me.grbTieuDe2QL.TabIndex = 59
        Me.grbTieuDe2QL.TabStop = False
        Me.grbTieuDe2QL.Text = "Trang bìa"
        '
        'frmMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmMuonSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTenSachTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhSachQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabFormDefaultManager1 As DevExpress.XtraBars.TabFormDefaultManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents txtsosach As System.Windows.Forms.TextBox
    Friend WithEvents dgvXemDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents ptbHinhSachQL As System.Windows.Forms.PictureBox
    Friend WithEvents lblTieuDeQL As System.Windows.Forms.Label
    Friend WithEvents grbTieuDe2QL As System.Windows.Forms.GroupBox
    Friend WithEvents txtTenSachTK As DevExpress.XtraEditors.SearchControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMuonSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChonSach As DevExpress.XtraEditors.SimpleButton
End Class
