<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNhapKho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNhapKho))
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.txtsoluong = New DevExpress.XtraEditors.TextEdit()
        Me.dtpngay = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdongia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtmakho = New DevExpress.XtraEditors.TextEdit()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.txtmasach = New DevExpress.XtraEditors.TextEdit()
        Me.ptbHinhSachQL = New System.Windows.Forms.PictureBox()
        Me.grbTieuDe2QL = New System.Windows.Forms.GroupBox()
        Me.lblTieuDeQL = New System.Windows.Forms.Label()
        CType(Me.txtsoluong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdongia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmakho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmasach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhSachQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(573, 168)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 24)
        Me.btnthoat.TabIndex = 6
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(166, 133)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtsoluong.Properties.Appearance.Options.UseBackColor = True
        Me.txtsoluong.Size = New System.Drawing.Size(365, 20)
        Me.txtsoluong.TabIndex = 2
        '
        'dtpngay
        '
        Me.dtpngay.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngay.Location = New System.Drawing.Point(510, 41)
        Me.dtpngay.Name = "dtpngay"
        Me.dtpngay.Size = New System.Drawing.Size(181, 20)
        Me.dtpngay.TabIndex = 201
        Me.dtpngay.Value = New Date(2016, 10, 14, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Ngày:"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(573, 96)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 22)
        Me.btnthem.TabIndex = 4
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Số Lượng:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(68, 174)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl9.TabIndex = 194
        Me.LabelControl9.Text = "Đơn Gía:"
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(166, 171)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(365, 20)
        Me.txtdongia.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(37, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl5.TabIndex = 192
        Me.LabelControl5.Text = "Mã Kho:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(68, 99)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl11.TabIndex = 191
        Me.LabelControl11.Text = "Mã Sách:"
        '
        'txtmakho
        '
        Me.txtmakho.Enabled = False
        Me.txtmakho.Location = New System.Drawing.Point(101, 41)
        Me.txtmakho.Name = "txtmakho"
        Me.txtmakho.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmakho.Properties.Appearance.Options.UseBackColor = True
        Me.txtmakho.Size = New System.Drawing.Size(179, 20)
        Me.txtmakho.TabIndex = 189
        '
        'dgvsach
        '
        Me.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsach.Location = New System.Drawing.Point(22, 237)
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.Size = New System.Drawing.Size(509, 202)
        Me.dgvsach.TabIndex = 204
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(573, 132)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 5
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'txtmasach
        '
        Me.txtmasach.Enabled = False
        Me.txtmasach.Location = New System.Drawing.Point(166, 96)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtmasach.Properties.Appearance.Options.UseBackColor = True
        Me.txtmasach.Size = New System.Drawing.Size(365, 20)
        Me.txtmasach.TabIndex = 1
        '
        'ptbHinhSachQL
        '
        Me.ptbHinhSachQL.BackgroundImage = CType(resources.GetObject("ptbHinhSachQL.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSachQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSachQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSachQL.Location = New System.Drawing.Point(537, 225)
        Me.ptbHinhSachQL.Name = "ptbHinhSachQL"
        Me.ptbHinhSachQL.Size = New System.Drawing.Size(190, 214)
        Me.ptbHinhSachQL.TabIndex = 210
        Me.ptbHinhSachQL.TabStop = False
        '
        'grbTieuDe2QL
        '
        Me.grbTieuDe2QL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grbTieuDe2QL.Location = New System.Drawing.Point(537, 203)
        Me.grbTieuDe2QL.Name = "grbTieuDe2QL"
        Me.grbTieuDe2QL.Size = New System.Drawing.Size(190, 26)
        Me.grbTieuDe2QL.TabIndex = 211
        Me.grbTieuDe2QL.TabStop = False
        Me.grbTieuDe2QL.Text = "Trang bìa"
        '
        'lblTieuDeQL
        '
        Me.lblTieuDeQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTieuDeQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTieuDeQL.Location = New System.Drawing.Point(22, 210)
        Me.lblTieuDeQL.Name = "lblTieuDeQL"
        Me.lblTieuDeQL.Size = New System.Drawing.Size(509, 24)
        Me.lblTieuDeQL.TabIndex = 212
        Me.lblTieuDeQL.Text = "Danh Sách"
        Me.lblTieuDeQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmNhapKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 451)
        Me.Controls.Add(Me.lblTieuDeQL)
        Me.Controls.Add(Me.ptbHinhSachQL)
        Me.Controls.Add(Me.grbTieuDe2QL)
        Me.Controls.Add(Me.txtmasach)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.dgvsach)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.dtpngay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtmakho)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNhapKho"
        Me.Text = "Nhập kho"
        CType(Me.txtsoluong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdongia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmakho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvsach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmasach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhSachQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents txtsoluong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdongia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtmakho As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgvsach As System.Windows.Forms.DataGridView
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents txtmasach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ptbHinhSachQL As System.Windows.Forms.PictureBox
    Friend WithEvents grbTieuDe2QL As System.Windows.Forms.GroupBox
    Friend WithEvents lblTieuDeQL As System.Windows.Forms.Label
End Class
