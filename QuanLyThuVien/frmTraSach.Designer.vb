<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraSach
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
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txttentv = New DevExpress.XtraEditors.SearchControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmaphieu = New DevExpress.XtraEditors.SearchControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnTraSach = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChonSach = New DevExpress.XtraEditors.SimpleButton()
        Me.txtsosach = New System.Windows.Forms.TextBox()
        Me.dgvsachmuon = New System.Windows.Forms.DataGridView()
        Me.lblTieuDeQL = New System.Windows.Forms.Label()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txttentv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmaphieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.dgvsachmuon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Controls.Add(Me.txttentv)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.txtmaphieu)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(727, 73)
        Me.PanelControl1.TabIndex = 21
        '
        'txttentv
        '
        Me.txttentv.Location = New System.Drawing.Point(122, 28)
        Me.txttentv.MenuManager = Me.TabFormDefaultManager1
        Me.txttentv.Name = "txttentv"
        Me.txttentv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txttentv.Size = New System.Drawing.Size(200, 20)
        Me.txttentv.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mã Phiếu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tên Thành Viên:"
        '
        'txtmaphieu
        '
        Me.txtmaphieu.Location = New System.Drawing.Point(477, 27)
        Me.txtmaphieu.MenuManager = Me.TabFormDefaultManager1
        Me.txtmaphieu.Name = "txtmaphieu"
        Me.txtmaphieu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txtmaphieu.Size = New System.Drawing.Size(200, 20)
        Me.txtmaphieu.TabIndex = 2
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnTraSach)
        Me.PanelControl2.Controls.Add(Me.btnChonSach)
        Me.PanelControl2.Controls.Add(Me.txtsosach)
        Me.PanelControl2.Controls.Add(Me.dgvsachmuon)
        Me.PanelControl2.Controls.Add(Me.lblTieuDeQL)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 91)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(727, 386)
        Me.PanelControl2.TabIndex = 32
        '
        'btnTraSach
        '
        Me.btnTraSach.Location = New System.Drawing.Point(627, 322)
        Me.btnTraSach.Name = "btnTraSach"
        Me.btnTraSach.Size = New System.Drawing.Size(75, 23)
        Me.btnTraSach.TabIndex = 67
        Me.btnTraSach.Text = "Hoàn tất"
        '
        'btnChonSach
        '
        Me.btnChonSach.Location = New System.Drawing.Point(507, 322)
        Me.btnChonSach.Name = "btnChonSach"
        Me.btnChonSach.Size = New System.Drawing.Size(75, 23)
        Me.btnChonSach.TabIndex = 66
        Me.btnChonSach.Text = "Chọn sách"
        '
        'txtsosach
        '
        Me.txtsosach.Location = New System.Drawing.Point(383, 322)
        Me.txtsosach.Name = "txtsosach"
        Me.txtsosach.ReadOnly = True
        Me.txtsosach.Size = New System.Drawing.Size(100, 21)
        Me.txtsosach.TabIndex = 63
        '
        'dgvsachmuon
        '
        Me.dgvsachmuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsachmuon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvsachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsachmuon.Location = New System.Drawing.Point(10, 43)
        Me.dgvsachmuon.Name = "dgvsachmuon"
        Me.dgvsachmuon.Size = New System.Drawing.Size(706, 229)
        Me.dgvsachmuon.TabIndex = 60
        '
        'lblTieuDeQL
        '
        Me.lblTieuDeQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTieuDeQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTieuDeQL.Location = New System.Drawing.Point(10, 16)
        Me.lblTieuDeQL.Name = "lblTieuDeQL"
        Me.lblTieuDeQL.Size = New System.Drawing.Size(706, 24)
        Me.lblTieuDeQL.TabIndex = 58
        Me.lblTieuDeQL.Text = "Danh Sách"
        Me.lblTieuDeQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTraSach
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
        Me.Name = "frmTraSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txttentv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmaphieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.dgvsachmuon, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvsachmuon As System.Windows.Forms.DataGridView
    Friend WithEvents lblTieuDeQL As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmaphieu As DevExpress.XtraEditors.SearchControl
    Friend WithEvents txttentv As DevExpress.XtraEditors.SearchControl
    Friend WithEvents txtsosach As System.Windows.Forms.TextBox
    Friend WithEvents btnTraSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChonSach As DevExpress.XtraEditors.SimpleButton
End Class
