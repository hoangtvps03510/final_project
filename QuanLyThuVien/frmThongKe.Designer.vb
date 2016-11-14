<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKe
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btntonkho = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSach = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThanhVien = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChiPhi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDoanhThu = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.btntonkho)
        Me.PanelControl1.Controls.Add(Me.btnSach)
        Me.PanelControl1.Controls.Add(Me.btnThanhVien)
        Me.PanelControl1.Controls.Add(Me.btnChiPhi)
        Me.PanelControl1.Controls.Add(Me.btnDoanhThu)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(739, 474)
        Me.PanelControl1.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.QuanLyThuVien.My.Resources.Resources.exitt
        Me.SimpleButton1.Location = New System.Drawing.Point(448, 362)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(180, 70)
        Me.SimpleButton1.TabIndex = 15
        Me.SimpleButton1.Text = "Thoát"
        '
        'btntonkho
        '
        Me.btntonkho.Image = Global.QuanLyThuVien.My.Resources.Resources.kho
        Me.btntonkho.Location = New System.Drawing.Point(129, 362)
        Me.btntonkho.Name = "btntonkho"
        Me.btntonkho.Size = New System.Drawing.Size(180, 70)
        Me.btntonkho.TabIndex = 14
        Me.btntonkho.Text = "Tồn Kho"
        '
        'btnSach
        '
        Me.btnSach.Image = Global.QuanLyThuVien.My.Resources.Resources.bookshelf__1_
        Me.btnSach.Location = New System.Drawing.Point(129, 204)
        Me.btnSach.Name = "btnSach"
        Me.btnSach.Size = New System.Drawing.Size(180, 70)
        Me.btnSach.TabIndex = 13
        Me.btnSach.Text = "Sách"
        '
        'btnThanhVien
        '
        Me.btnThanhVien.Image = Global.QuanLyThuVien.My.Resources.Resources.people_icon
        Me.btnThanhVien.Location = New System.Drawing.Point(448, 204)
        Me.btnThanhVien.Name = "btnThanhVien"
        Me.btnThanhVien.Size = New System.Drawing.Size(180, 70)
        Me.btnThanhVien.TabIndex = 12
        Me.btnThanhVien.Text = "Thành viên"
        '
        'btnChiPhi
        '
        Me.btnChiPhi.Image = Global.QuanLyThuVien.My.Resources.Resources.Money_icon
        Me.btnChiPhi.Location = New System.Drawing.Point(448, 41)
        Me.btnChiPhi.Name = "btnChiPhi"
        Me.btnChiPhi.Size = New System.Drawing.Size(180, 70)
        Me.btnChiPhi.TabIndex = 11
        Me.btnChiPhi.Text = "Chi phí"
        '
        'btnDoanhThu
        '
        Me.btnDoanhThu.Image = Global.QuanLyThuVien.My.Resources.Resources.Money_icon
        Me.btnDoanhThu.Location = New System.Drawing.Point(129, 41)
        Me.btnDoanhThu.Name = "btnDoanhThu"
        Me.btnDoanhThu.Size = New System.Drawing.Size(180, 70)
        Me.btnDoanhThu.TabIndex = 10
        Me.btnDoanhThu.Text = "Doanh thu"
        '
        'frmThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmThongKe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnChiPhi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDoanhThu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThanhVien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btntonkho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
