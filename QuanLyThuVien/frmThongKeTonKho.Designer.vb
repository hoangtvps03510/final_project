<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeTonKho
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
        Me.dgvkho = New System.Windows.Forms.DataGridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dtpngayketthuc = New System.Windows.Forms.DateTimePicker()
        Me.dtpngaybatdau = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnthoat = New System.Windows.Forms.Button()
        CType(Me.dgvkho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvkho
        '
        Me.dgvkho.AllowUserToAddRows = False
        Me.dgvkho.AllowUserToDeleteRows = False
        Me.dgvkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkho.Location = New System.Drawing.Point(6, 56)
        Me.dgvkho.Name = "dgvkho"
        Me.dgvkho.ReadOnly = True
        Me.dgvkho.Size = New System.Drawing.Size(728, 325)
        Me.dgvkho.TabIndex = 29
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnthoat)
        Me.PanelControl3.Location = New System.Drawing.Point(6, 387)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(728, 61)
        Me.PanelControl3.TabIndex = 28
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dtpngayketthuc)
        Me.PanelControl1.Controls.Add(Me.dtpngaybatdau)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(6, -1)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(728, 51)
        Me.PanelControl1.TabIndex = 30
        '
        'dtpngayketthuc
        '
        Me.dtpngayketthuc.CustomFormat = "dd/MM/yyyy"
        Me.dtpngayketthuc.Enabled = False
        Me.dtpngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngayketthuc.Location = New System.Drawing.Point(466, 17)
        Me.dtpngayketthuc.Name = "dtpngayketthuc"
        Me.dtpngayketthuc.Size = New System.Drawing.Size(241, 21)
        Me.dtpngayketthuc.TabIndex = 17
        Me.dtpngayketthuc.Value = New Date(2016, 10, 21, 23, 20, 45, 0)
        '
        'dtpngaybatdau
        '
        Me.dtpngaybatdau.CustomFormat = "dd/MM/yyyy"
        Me.dtpngaybatdau.Enabled = False
        Me.dtpngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpngaybatdau.Location = New System.Drawing.Point(98, 17)
        Me.dtpngaybatdau.Name = "dtpngaybatdau"
        Me.dtpngaybatdau.Size = New System.Drawing.Size(217, 21)
        Me.dtpngaybatdau.TabIndex = 16
        Me.dtpngaybatdau.Value = New Date(2016, 7, 1, 0, 0, 0, 0)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(397, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Đến ngày:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(35, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Từ ngày:"
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(632, 20)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 1
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmThongKeTonKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(741, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgvkho)
        Me.Controls.Add(Me.PanelControl3)
        Me.Location = New System.Drawing.Point(210, 0)
        Me.Name = "frmThongKeTonKho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.dgvkho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvkho As System.Windows.Forms.DataGridView
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtpngayketthuc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpngaybatdau As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
