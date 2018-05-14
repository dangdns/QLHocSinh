<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhapHS
    Inherits System.Windows.Forms.Form

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
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtLop = New System.Windows.Forms.TextBox()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(183, 30)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(208, 22)
        Me.txtHoTen.TabIndex = 0
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(183, 71)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(208, 22)
        Me.txtNgaySinh.TabIndex = 1
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(183, 112)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(100, 22)
        Me.txtGioiTinh.TabIndex = 2
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(183, 151)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(265, 22)
        Me.txtDiaChi.TabIndex = 3
        '
        'txtLop
        '
        Me.txtLop.Location = New System.Drawing.Point(183, 191)
        Me.txtLop.Name = "txtLop"
        Me.txtLop.Size = New System.Drawing.Size(100, 22)
        Me.txtLop.TabIndex = 4
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(147, 236)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(156, 23)
        Me.btnNhap.TabIndex = 5
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Họ và tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ngày sinh (dd-mm-yyyy)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Giới tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Địa chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lớp"
        '
        'frmNhapHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 285)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.txtLop)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtGioiTinh)
        Me.Controls.Add(Me.txtNgaySinh)
        Me.Controls.Add(Me.txtHoTen)
        Me.Name = "frmNhapHS"
        Me.Text = "frmNhapHS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtLop As TextBox
    Friend WithEvents btnNhap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
