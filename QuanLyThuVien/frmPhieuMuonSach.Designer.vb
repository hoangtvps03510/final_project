<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuMuonSach
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
        Me.txtmanv = New DevExpress.XtraEditors.TextEdit()
        Me.txtmatv = New DevExpress.XtraEditors.TextEdit()
        Me.txttentv = New DevExpress.XtraEditors.TextEdit()
        Me.txtmaphieu = New DevExpress.XtraEditors.TextEdit()
        Me.txttiencoc = New DevExpress.XtraEditors.TextEdit()
        Me.dgvgiohang = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpngaymuon = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLuuPhieu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChonSach1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoaDong1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtmanv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmatv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttentv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmaphieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttiencoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvgiohang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmanv
        '
        Me.txtmanv.Enabled = False
        Me.txtmanv.Location = New System.Drawing.Point(166, 172)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmanv.Properties.Appearance.Options.UseBackColor = True
        Me.txtmanv.Size = New System.Drawing.Size(349, 20)
        Me.txtmanv.TabIndex = 203
        '
        'txtmatv
        '
        Me.txtmatv.Location = New System.Drawing.Point(166, 132)
        Me.txtmatv.Name = "txtmatv"
        Me.txtmatv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmatv.Properties.Appearance.Options.UseBackColor = True
        Me.txtmatv.Size = New System.Drawing.Size(349, 20)
        Me.txtmatv.TabIndex = 202
        '
        'txttentv
        '
        Me.txttentv.Location = New System.Drawing.Point(166, 97)
        Me.txttentv.Name = "txttentv"
        Me.txttentv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txttentv.Properties.Appearance.Options.UseBackColor = True
        Me.txttentv.Properties.MaxLength = 30
        Me.txttentv.Size = New System.Drawing.Size(349, 20)
        Me.txttentv.TabIndex = 201
        '
        'txtmaphieu
        '
        Me.txtmaphieu.Enabled = False
        Me.txtmaphieu.Location = New System.Drawing.Point(146, 47)
        Me.txtmaphieu.Name = "txtmaphieu"
        Me.txtmaphieu.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmaphieu.Properties.Appearance.Options.UseBackColor = True
        Me.txtmaphieu.Size = New System.Drawing.Size(119, 20)
        Me.txtmaphieu.TabIndex = 200
        '
        'txttiencoc
        '
        Me.txttiencoc.Enabled = False
        Me.txttiencoc.Location = New System.Drawing.Point(166, 215)
        Me.txttiencoc.Name = "txttiencoc"
        Me.txttiencoc.Size = New System.Drawing.Size(349, 20)
        Me.txttiencoc.TabIndex = 199
        '
        'dgvgiohang
        '
        Me.dgvgiohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvgiohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgiohang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column4})
        Me.dgvgiohang.Location = New System.Drawing.Point(20, 270)
        Me.dgvgiohang.Name = "dgvgiohang"
        Me.dgvgiohang.ReadOnly = True
        Me.dgvgiohang.Size = New System.Drawing.Size(614, 158)
        Me.dgvgiohang.TabIndex = 195
        '
        'Column1
        '
        Me.Column1.HeaderText = "Mã Sách"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tên sách"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Đơn Gía"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tiền cọc"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 194
        Me.Label9.Text = "Tiền cọc:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 193
        Me.Label8.Text = "Mã nhân viên:"
        '
        'dtpngaymuon
        '
        Me.dtpngaymuon.CustomFormat = "dd/MM/yyyy"
        Me.dtpngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpngaymuon.Location = New System.Drawing.Point(474, 48)
        Me.dtpngaymuon.Name = "dtpngaymuon"
        Me.dtpngaymuon.Size = New System.Drawing.Size(208, 21)
        Me.dtpngaymuon.TabIndex = 192
        Me.dtpngaymuon.Value = New Date(2016, 10, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Mã thành viên:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 188
        Me.Label6.Text = "Tên thành viên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 187
        Me.Label3.Text = "Ngày:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Mã phiếu:"
        '
        'btnLuuPhieu
        '
        Me.btnLuuPhieu.Location = New System.Drawing.Point(586, 99)
        Me.btnLuuPhieu.Name = "btnLuuPhieu"
        Me.btnLuuPhieu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuuPhieu.TabIndex = 204
        Me.btnLuuPhieu.Text = "Lưu phiếu"
        '
        'btnHuy1
        '
        Me.btnHuy1.Location = New System.Drawing.Point(586, 141)
        Me.btnHuy1.Name = "btnHuy1"
        Me.btnHuy1.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy1.TabIndex = 205
        Me.btnHuy1.Text = "Hủy phiếu"
        '
        'btnThoat1
        '
        Me.btnThoat1.Location = New System.Drawing.Point(586, 179)
        Me.btnThoat1.Name = "btnThoat1"
        Me.btnThoat1.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat1.TabIndex = 206
        Me.btnThoat1.Text = "Thoát"
        '
        'btnChonSach1
        '
        Me.btnChonSach1.Location = New System.Drawing.Point(643, 294)
        Me.btnChonSach1.Name = "btnChonSach1"
        Me.btnChonSach1.Size = New System.Drawing.Size(75, 23)
        Me.btnChonSach1.TabIndex = 207
        Me.btnChonSach1.Text = "Chọn sách"
        '
        'btnXoaDong1
        '
        Me.btnXoaDong1.Location = New System.Drawing.Point(643, 340)
        Me.btnXoaDong1.Name = "btnXoaDong1"
        Me.btnXoaDong1.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaDong1.TabIndex = 208
        Me.btnXoaDong1.Text = "Xóa Dòng"
        '
        'frmPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(739, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnXoaDong1)
        Me.Controls.Add(Me.btnChonSach1)
        Me.Controls.Add(Me.btnThoat1)
        Me.Controls.Add(Me.btnHuy1)
        Me.Controls.Add(Me.btnLuuPhieu)
        Me.Controls.Add(Me.txtmanv)
        Me.Controls.Add(Me.txtmatv)
        Me.Controls.Add(Me.txttentv)
        Me.Controls.Add(Me.txtmaphieu)
        Me.Controls.Add(Me.txttiencoc)
        Me.Controls.Add(Me.dgvgiohang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpngaymuon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmPhieuMuonSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.txtmanv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmatv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttentv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmaphieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttiencoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvgiohang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmanv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmatv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttentv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmaphieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttiencoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgvgiohang As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpngaymuon As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLuuPhieu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChonSach1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoaDong1 As DevExpress.XtraEditors.SimpleButton
End Class
