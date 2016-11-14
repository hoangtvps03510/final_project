<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuTraSach
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
        Me.dtpngaytra = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvtra = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtthanhtien = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtmatv = New DevExpress.XtraEditors.TextEdit()
        Me.txttentv = New DevExpress.XtraEditors.TextEdit()
        Me.txtmaphieu = New DevExpress.XtraEditors.TextEdit()
        Me.btnXoaDong1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChonSach1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuuPhieu = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtmanv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtthanhtien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmatv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttentv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmaphieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmanv
        '
        Me.txtmanv.Enabled = False
        Me.txtmanv.Location = New System.Drawing.Point(172, 184)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmanv.Properties.Appearance.Options.UseBackColor = True
        Me.txtmanv.Size = New System.Drawing.Size(372, 20)
        Me.txtmanv.TabIndex = 202
        '
        'dtpngaytra
        '
        Me.dtpngaytra.CustomFormat = "dd/MM/yyyy"
        Me.dtpngaytra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpngaytra.Location = New System.Drawing.Point(493, 53)
        Me.dtpngaytra.Name = "dtpngaytra"
        Me.dtpngaytra.Size = New System.Drawing.Size(187, 21)
        Me.dtpngaytra.TabIndex = 201
        Me.dtpngaytra.Value = New Date(2016, 10, 14, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Ngày:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Mã nhân viên:"
        '
        'dgvtra
        '
        Me.dgvtra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.dgvtra.Location = New System.Drawing.Point(17, 271)
        Me.dgvtra.Name = "dgvtra"
        Me.dgvtra.Size = New System.Drawing.Size(615, 150)
        Me.dgvtra.TabIndex = 195
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID_Mượn"
        Me.Column1.Name = "Column1"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Mã Phiếu Mượn"
        Me.Column6.Name = "Column6"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tên Sách"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ngày Mượn"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Số Ngày Mượn"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Thành Tiền"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.FalseValue = "False"
        Me.Column7.HeaderText = "Sách Hư"
        Me.Column7.IndeterminateValue = ""
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.TrueValue = "True"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(74, 229)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl9.TabIndex = 194
        Me.LabelControl9.Text = "Thành tiền:"
        '
        'txtthanhtien
        '
        Me.txtthanhtien.Enabled = False
        Me.txtthanhtien.Location = New System.Drawing.Point(172, 226)
        Me.txtthanhtien.Name = "txtthanhtien"
        Me.txtthanhtien.Size = New System.Drawing.Size(372, 20)
        Me.txtthanhtien.TabIndex = 193
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(74, 149)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl5.TabIndex = 192
        Me.LabelControl5.Text = "Mã Thành viên:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(74, 114)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl11.TabIndex = 191
        Me.LabelControl11.Text = "Tên Thành Viên:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(31, 59)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 190
        Me.LabelControl3.Text = "Mã phiếu trả:"
        '
        'txtmatv
        '
        Me.txtmatv.Location = New System.Drawing.Point(172, 146)
        Me.txtmatv.Name = "txtmatv"
        Me.txtmatv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmatv.Properties.Appearance.Options.UseBackColor = True
        Me.txtmatv.Size = New System.Drawing.Size(372, 20)
        Me.txtmatv.TabIndex = 189
        '
        'txttentv
        '
        Me.txttentv.Location = New System.Drawing.Point(172, 111)
        Me.txttentv.Name = "txttentv"
        Me.txttentv.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txttentv.Properties.Appearance.Options.UseBackColor = True
        Me.txttentv.Size = New System.Drawing.Size(372, 20)
        Me.txttentv.TabIndex = 188
        '
        'txtmaphieu
        '
        Me.txtmaphieu.Enabled = False
        Me.txtmaphieu.Location = New System.Drawing.Point(111, 56)
        Me.txtmaphieu.Name = "txtmaphieu"
        Me.txtmaphieu.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmaphieu.Properties.Appearance.Options.UseBackColor = True
        Me.txtmaphieu.Size = New System.Drawing.Size(119, 20)
        Me.txtmaphieu.TabIndex = 187
        '
        'btnXoaDong1
        '
        Me.btnXoaDong1.Location = New System.Drawing.Point(642, 350)
        Me.btnXoaDong1.Name = "btnXoaDong1"
        Me.btnXoaDong1.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaDong1.TabIndex = 213
        Me.btnXoaDong1.Text = "Xóa Dòng"
        '
        'btnChonSach1
        '
        Me.btnChonSach1.Location = New System.Drawing.Point(642, 304)
        Me.btnChonSach1.Name = "btnChonSach1"
        Me.btnChonSach1.Size = New System.Drawing.Size(75, 23)
        Me.btnChonSach1.TabIndex = 212
        Me.btnChonSach1.Text = "Chọn sách"
        '
        'btnThoat1
        '
        Me.btnThoat1.Location = New System.Drawing.Point(585, 189)
        Me.btnThoat1.Name = "btnThoat1"
        Me.btnThoat1.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat1.TabIndex = 211
        Me.btnThoat1.Text = "Thoát"
        '
        'btnHuy1
        '
        Me.btnHuy1.Location = New System.Drawing.Point(585, 151)
        Me.btnHuy1.Name = "btnHuy1"
        Me.btnHuy1.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy1.TabIndex = 210
        Me.btnHuy1.Text = "Hủy phiếu"
        '
        'btnLuuPhieu
        '
        Me.btnLuuPhieu.Location = New System.Drawing.Point(585, 109)
        Me.btnLuuPhieu.Name = "btnLuuPhieu"
        Me.btnLuuPhieu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuuPhieu.TabIndex = 209
        Me.btnLuuPhieu.Text = "Lưu phiếu"
        '
        'frmPhieuTraSach
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
        Me.Controls.Add(Me.dtpngaytra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvtra)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtthanhtien)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtmatv)
        Me.Controls.Add(Me.txttentv)
        Me.Controls.Add(Me.txtmaphieu)
        Me.Location = New System.Drawing.Point(212, 0)
        Me.Name = "frmPhieuTraSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.txtmanv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtthanhtien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmatv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttentv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmaphieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmanv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpngaytra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvtra As System.Windows.Forms.DataGridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtthanhtien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmatv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttentv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmaphieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnXoaDong1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChonSach1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuuPhieu As DevExpress.XtraEditors.SimpleButton
End Class
