<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num_withw = New System.Windows.Forms.NumericUpDown()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num_hight = New System.Windows.Forms.NumericUpDown()
        Me.btn_convert = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.num_withw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_hight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(324, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "برنامج تغير حجم صور"
        '
        'num_withw
        '
        Me.num_withw.Location = New System.Drawing.Point(378, 48)
        Me.num_withw.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.num_withw.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_withw.Name = "num_withw"
        Me.num_withw.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.num_withw.Size = New System.Drawing.Size(120, 36)
        Me.num_withw.TabIndex = 1
        Me.num_withw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_withw.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'btn_select
        '
        Me.btn_select.Location = New System.Drawing.Point(151, -1)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(149, 53)
        Me.btn_select.TabIndex = 2
        Me.btn_select.Text = "اختيار صور"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 29
        Me.ListBox1.Location = New System.Drawing.Point(12, 134)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(769, 352)
        Me.ListBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "العرض"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "الارتفاع"
        '
        'num_hight
        '
        Me.num_hight.Location = New System.Drawing.Point(378, 92)
        Me.num_hight.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.num_hight.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_hight.Name = "num_hight"
        Me.num_hight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.num_hight.Size = New System.Drawing.Size(120, 36)
        Me.num_hight.TabIndex = 6
        Me.num_hight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_hight.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'btn_convert
        '
        Me.btn_convert.Enabled = False
        Me.btn_convert.Location = New System.Drawing.Point(632, 26)
        Me.btn_convert.Name = "btn_convert"
        Me.btn_convert.Size = New System.Drawing.Size(149, 53)
        Me.btn_convert.TabIndex = 7
        Me.btn_convert.Text = "تحويل"
        Me.btn_convert.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "حذف"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(822, 575)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_convert)
        Me.Controls.Add(Me.num_hight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.num_withw)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.num_withw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_hight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num_withw As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents num_hight As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_convert As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
