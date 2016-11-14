<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiMatKhau
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXacNhan = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMatKhauCu = New System.Windows.Forms.TextBox()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMatKhauMoi = New System.Windows.Forms.TextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNhapLai = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.QuanLyThuVien.My.Resources.Resources.bookshelf__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(431, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 61)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 23.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(48, 23)
        Me.LabelControl3.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(375, 37)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "Phần mềm quản lý thư viện"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(298, 271)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 35
        Me.btnThoat.Text = "Thoát"
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Location = New System.Drawing.Point(159, 271)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(75, 23)
        Me.btnXacNhan.TabIndex = 34
        Me.btnXacNhan.Text = "Xác nhận"
        '
        'txtMatKhauCu
        '
        Me.txtMatKhauCu.Location = New System.Drawing.Point(247, 127)
        Me.txtMatKhauCu.Name = "txtMatKhauCu"
        Me.txtMatKhauCu.Size = New System.Drawing.Size(161, 20)
        Me.txtMatKhauCu.TabIndex = 31
        Me.txtMatKhauCu.UseSystemPasswordChar = True
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Enabled = False
        Me.txtTenDangNhap.Location = New System.Drawing.Point(247, 84)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.ReadOnly = True
        Me.txtTenDangNhap.Size = New System.Drawing.Size(161, 20)
        Me.txtTenDangNhap.TabIndex = 30
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(115, 130)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "Mật khẩu cũ:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(115, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 28
        Me.LabelControl1.Text = "Tên đăng nhập:"
        '
        'txtMatKhauMoi
        '
        Me.txtMatKhauMoi.Location = New System.Drawing.Point(247, 165)
        Me.txtMatKhauMoi.Name = "txtMatKhauMoi"
        Me.txtMatKhauMoi.Size = New System.Drawing.Size(161, 20)
        Me.txtMatKhauMoi.TabIndex = 32
        Me.txtMatKhauMoi.UseSystemPasswordChar = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(115, 168)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl4.TabIndex = 36
        Me.LabelControl4.Text = "Mật khẩu mới:"
        '
        'txtNhapLai
        '
        Me.txtNhapLai.Location = New System.Drawing.Point(247, 207)
        Me.txtNhapLai.Name = "txtNhapLai"
        Me.txtNhapLai.Size = New System.Drawing.Size(161, 20)
        Me.txtNhapLai.TabIndex = 33
        Me.txtNhapLai.UseSystemPasswordChar = True
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(115, 210)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl5.TabIndex = 38
        Me.LabelControl5.Text = "Nhập lại mật khẩu:"
        '
        'frmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 334)
        Me.Controls.Add(Me.txtNhapLai)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtMatKhauMoi)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXacNhan)
        Me.Controls.Add(Me.txtMatKhauCu)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmDoiMatKhau"
        Me.Text = "Đổi mật khẩu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXacNhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMatKhauCu As System.Windows.Forms.TextBox
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMatKhauMoi As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNhapLai As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
