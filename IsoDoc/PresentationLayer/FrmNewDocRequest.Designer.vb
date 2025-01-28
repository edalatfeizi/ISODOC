<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewDocRequest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbReqTypes = New System.Windows.Forms.ComboBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericTextBox1 = New IsoDoc.NumericTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Location = New System.Drawing.Point(98, 147)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.BtnSave.Size = New System.Drawing.Size(193, 35)
        Me.BtnSave.TabIndex = 88
        Me.BtnSave.Text = "ثبت درخواست"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(961, 79)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "عنوان سند:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(957, 111)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 91
        Me.LabelControl2.Text = "شماره سند:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(948, 146)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl3.TabIndex = 94
        Me.LabelControl3.Text = "نوع درخواست:"
        '
        'cmbReqTypes
        '
        Me.cmbReqTypes.FormattingEnabled = True
        Me.cmbReqTypes.Location = New System.Drawing.Point(701, 146)
        Me.cmbReqTypes.Name = "cmbReqTypes"
        Me.cmbReqTypes.Size = New System.Drawing.Size(162, 24)
        Me.cmbReqTypes.TabIndex = 95
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(915, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.TabIndex = 96
        Me.LabelControl4.Text = "واحد درخواست کننده:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(891, 182)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl5.TabIndex = 98
        Me.LabelControl5.Text = "مدت زمان نگهداری سوابق:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(580, 43)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl6.TabIndex = 102
        Me.LabelControl6.Text = "شرح تغییرات:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(381, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 94)
        Me.TextBox1.TabIndex = 103
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(580, 147)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "علت تغییر/ایجاد سند:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(701, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(162, 23)
        Me.TextBox2.TabIndex = 105
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(701, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(162, 23)
        Me.TextBox3.TabIndex = 106
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(701, 182)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(162, 23)
        Me.TextBox4.TabIndex = 107
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(98, 114)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(193, 23)
        Me.TextBox6.TabIndex = 110
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(297, 117)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl8.TabIndex = 109
        Me.LabelControl8.Text = "تاریخ درخواست:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(381, 144)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(193, 68)
        Me.TextBox5.TabIndex = 111
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(98, 43)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(193, 23)
        Me.TextBox7.TabIndex = 113
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(297, 46)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl9.TabIndex = 112
        Me.LabelControl9.Text = "تاریخ ثبت:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(98, 82)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(193, 23)
        Me.TextBox8.TabIndex = 115
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(297, 85)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl10.TabIndex = 114
        Me.LabelControl10.Text = "شماره درخواست:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.NumericTextBox1)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.cmbReqTypes)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1021, 234)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "درخواست تغییر/ایجاد مستندات"
        '
        'NumericTextBox1
        '
        Me.NumericTextBox1.Location = New System.Drawing.Point(701, 111)
        Me.NumericTextBox1.Name = "NumericTextBox1"
        Me.NumericTextBox1.Size = New System.Drawing.Size(162, 23)
        Me.NumericTextBox1.TabIndex = 93
        '
        'FrmNewDocRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 268)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmNewDocRequest"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "درخواست سند جدید"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NumericTextBox1 As NumericTextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbReqTypes As ComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As GroupBox
End Class
