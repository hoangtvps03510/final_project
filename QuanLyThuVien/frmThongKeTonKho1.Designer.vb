<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeTonKho1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpngaybatdau = New System.Windows.Forms.DateTimePicker()
        Me.dtpngayketthuc = New System.Windows.Forms.DateTimePicker()
        Me.btnTinh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Từ Ngày:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(199, 55)
        Me.Label2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Thống Kê Nhập Xuất Tồn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đến Ngày:"
        '
        'dtpngaybatdau
        '
        Me.dtpngaybatdau.CustomFormat = "dd/MM/yyyy"
        Me.dtpngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpngaybatdau.Location = New System.Drawing.Point(159, 154)
        Me.dtpngaybatdau.MinimumSize = New System.Drawing.Size(4, 40)
        Me.dtpngaybatdau.Name = "dtpngaybatdau"
        Me.dtpngaybatdau.Size = New System.Drawing.Size(465, 40)
        Me.dtpngaybatdau.TabIndex = 3
        '
        'dtpngayketthuc
        '
        Me.dtpngayketthuc.CustomFormat = "dd/MM/yyyy"
        Me.dtpngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpngayketthuc.Location = New System.Drawing.Point(159, 253)
        Me.dtpngayketthuc.MinimumSize = New System.Drawing.Size(4, 40)
        Me.dtpngayketthuc.Name = "dtpngayketthuc"
        Me.dtpngayketthuc.Size = New System.Drawing.Size(465, 40)
        Me.dtpngayketthuc.TabIndex = 4
        '
        'btnTinh
        '
        Me.btnTinh.Location = New System.Drawing.Point(228, 347)
        Me.btnTinh.Name = "btnTinh"
        Me.btnTinh.Size = New System.Drawing.Size(99, 48)
        Me.btnTinh.TabIndex = 7
        Me.btnTinh.Text = "Tính"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(390, 347)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(99, 48)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "Thoát"
        '
        'frmThongKeTonKho1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTinh)
        Me.Controls.Add(Me.dtpngayketthuc)
        Me.Controls.Add(Me.dtpngaybatdau)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmThongKeTonKho1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpngaybatdau As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpngayketthuc As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTinh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
End Class
