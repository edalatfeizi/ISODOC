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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewDocRequest))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbReqTypes = New System.Windows.Forms.ComboBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChanges = New System.Windows.Forms.TextBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtStoreDuration = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtRegDate = New System.Windows.Forms.TextBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnAttachFiles = New DevComponents.DotNetBar.ButtonX()
        Me.pbAttachFiles = New System.Windows.Forms.PictureBox()
        Me.lblReqId = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDeps = New System.Windows.Forms.ComboBox()
        Me.PersianCalender = New BehComponents.MonthCalendarX()
        Me.btnFileName = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDocNo = New IsoDoc.NumericTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbAttachFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(906, 101)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "عنوان سند:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(906, 138)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 91
        Me.LabelControl2.Text = "شماره سند:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(897, 169)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl3.TabIndex = 94
        Me.LabelControl3.Text = "نوع درخواست:"
        '
        'cmbReqTypes
        '
        Me.cmbReqTypes.FormattingEnabled = True
        Me.cmbReqTypes.Items.AddRange(New Object() {"ایجاد", "تغییر", "حذف"})
        Me.cmbReqTypes.Location = New System.Drawing.Point(586, 168)
        Me.cmbReqTypes.Name = "cmbReqTypes"
        Me.cmbReqTypes.Size = New System.Drawing.Size(255, 24)
        Me.cmbReqTypes.TabIndex = 95
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(873, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.TabIndex = 96
        Me.LabelControl4.Text = "واحد درخواست کننده:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(849, 204)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl5.TabIndex = 98
        Me.LabelControl5.Text = "مدت زمان نگهداری سوابق:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(467, 56)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl6.TabIndex = 102
        Me.LabelControl6.Text = "شرح تغییرات:"
        '
        'txtChanges
        '
        Me.txtChanges.Location = New System.Drawing.Point(268, 57)
        Me.txtChanges.Multiline = True
        Me.txtChanges.Name = "txtChanges"
        Me.txtChanges.Size = New System.Drawing.Size(193, 94)
        Me.txtChanges.TabIndex = 103
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(467, 168)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "علت تغییر/ایجاد سند:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(586, 101)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(255, 23)
        Me.txtTitle.TabIndex = 106
        '
        'txtStoreDuration
        '
        Me.txtStoreDuration.Location = New System.Drawing.Point(586, 204)
        Me.txtStoreDuration.Name = "txtStoreDuration"
        Me.txtStoreDuration.Size = New System.Drawing.Size(255, 23)
        Me.txtStoreDuration.TabIndex = 107
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(268, 157)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(193, 70)
        Me.txtReason.TabIndex = 111
        '
        'txtRegDate
        '
        Me.txtRegDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtRegDate.Location = New System.Drawing.Point(268, 234)
        Me.txtRegDate.Name = "txtRegDate"
        Me.txtRegDate.ReadOnly = True
        Me.txtRegDate.Size = New System.Drawing.Size(193, 23)
        Me.txtRegDate.TabIndex = 113
        Me.txtRegDate.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(482, 239)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl9.TabIndex = 112
        Me.LabelControl9.Text = "تاریخ ثبت:"
        Me.LabelControl9.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(890, 26)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl10.TabIndex = 114
        Me.LabelControl10.Text = "شماره درخواست:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFileName)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.btnAttachFiles)
        Me.GroupBox1.Controls.Add(Me.pbAttachFiles)
        Me.GroupBox1.Controls.Add(Me.lblReqId)
        Me.GroupBox1.Controls.Add(Me.LabelControl14)
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.cmbDeps)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txtDocNo)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.cmbReqTypes)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txtRegDate)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Controls.Add(Me.txtChanges)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.txtStoreDuration)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.PersianCalender)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 284)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "درخواست تغییر/ایجاد مستندات"
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Location = New System.Drawing.Point(6, 223)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.BtnSave.Size = New System.Drawing.Size(226, 34)
        Me.BtnSave.TabIndex = 88
        Me.BtnSave.Text = "ثبت درخواست"
        '
        'btnAttachFiles
        '
        Me.btnAttachFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAttachFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAttachFiles.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAttachFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttachFiles.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAttachFiles.Location = New System.Drawing.Point(6, 183)
        Me.btnAttachFiles.Name = "btnAttachFiles"
        Me.btnAttachFiles.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnAttachFiles.Size = New System.Drawing.Size(226, 34)
        Me.btnAttachFiles.TabIndex = 125
        Me.btnAttachFiles.Text = "پیوست سند"
        '
        'pbAttachFiles
        '
        Me.pbAttachFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttachFiles.Image = Global.IsoDoc.My.Resources.Resources.attach_files2
        Me.pbAttachFiles.Location = New System.Drawing.Point(6, 26)
        Me.pbAttachFiles.Name = "pbAttachFiles"
        Me.pbAttachFiles.Size = New System.Drawing.Size(226, 150)
        Me.pbAttachFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAttachFiles.TabIndex = 123
        Me.pbAttachFiles.TabStop = False
        '
        'lblReqId
        '
        Me.lblReqId.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReqId.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblReqId.Appearance.Options.UseBackColor = True
        Me.lblReqId.Appearance.Options.UseForeColor = True
        Me.lblReqId.Location = New System.Drawing.Point(841, 26)
        Me.lblReqId.Name = "lblReqId"
        Me.lblReqId.Size = New System.Drawing.Size(0, 13)
        Me.lblReqId.TabIndex = 122
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(571, 169)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(8, 17)
        Me.LabelControl14.TabIndex = 121
        Me.LabelControl14.Text = "*"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(537, 57)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(8, 17)
        Me.LabelControl13.TabIndex = 120
        Me.LabelControl13.Text = "*"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(970, 165)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(8, 17)
        Me.LabelControl12.TabIndex = 119
        Me.LabelControl12.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(964, 97)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(8, 17)
        Me.LabelControl11.TabIndex = 118
        Me.LabelControl11.Text = "*"
        '
        'cmbDeps
        '
        Me.cmbDeps.Enabled = False
        Me.cmbDeps.FormattingEnabled = True
        Me.cmbDeps.Location = New System.Drawing.Point(586, 60)
        Me.cmbDeps.Name = "cmbDeps"
        Me.cmbDeps.Size = New System.Drawing.Size(255, 24)
        Me.cmbDeps.TabIndex = 116
        '
        'PersianCalender
        '
        Me.PersianCalender.BoldedDayForeColor = System.Drawing.Color.Blue
        Me.PersianCalender.BorderColor = System.Drawing.Color.CadetBlue
        Me.PersianCalender.CalendarType = BehComponents.CalendarTypes.Persian
        Me.PersianCalender.DayRectTickness = 2.0!
        Me.PersianCalender.DaysBackColor = System.Drawing.Color.White
        Me.PersianCalender.DaysFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PersianCalender.DaysForeColor = System.Drawing.Color.Black
        Me.PersianCalender.EnglishAnnuallyBoldedDates = New Date(-1) {}
        Me.PersianCalender.EnglishBoldedDates = New Date(-1) {}
        Me.PersianCalender.EnglishHolidayDates = New Date(-1) {}
        Me.PersianCalender.EnglishMonthlyBoldedDates = New Date(-1) {}
        Me.PersianCalender.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PersianCalender.HolidayForeColor = System.Drawing.Color.Red
        Me.PersianCalender.HolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday
        Me.PersianCalender.LineWeekColor = System.Drawing.Color.Black
        Me.PersianCalender.Location = New System.Drawing.Point(467, 81)
        Me.PersianCalender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PersianCalender.Name = "PersianCalender"
        Me.PersianCalender.PersianAnnuallyBoldedDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.PersianBoldedDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.PersianHolidayDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.PersianMonthlyBoldedDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.ShowToday = True
        Me.PersianCalender.ShowTodayRect = True
        Me.PersianCalender.ShowToolTips = False
        Me.PersianCalender.ShowTrailing = True
        Me.PersianCalender.Size = New System.Drawing.Size(86, 82)
        Me.PersianCalender.Style_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple
        Me.PersianCalender.Style_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green
        Me.PersianCalender.Style_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue
        Me.PersianCalender.Style_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green
        Me.PersianCalender.Style_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green
        Me.PersianCalender.Style_YearButton = BehComponents.ButtonX.ButtonStyles.Blue
        Me.PersianCalender.TabIndex = 117
        Me.PersianCalender.TitleBackColor = System.Drawing.Color.White
        Me.PersianCalender.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PersianCalender.TitleForeColor = System.Drawing.Color.Black
        Me.PersianCalender.TodayBackColor = System.Drawing.Color.White
        Me.PersianCalender.TodayFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PersianCalender.TodayForeColor = System.Drawing.Color.Black
        Me.PersianCalender.TodayRectColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PersianCalender.TodayRectTickness = 2.0!
        Me.PersianCalender.TrailingForeColor = System.Drawing.Color.DarkGray
        Me.PersianCalender.Visible = False
        Me.PersianCalender.WeekDaysBackColor = System.Drawing.Color.White
        Me.PersianCalender.WeekDaysFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PersianCalender.WeekDaysForeColor = System.Drawing.Color.Blue
        Me.PersianCalender.WeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday
        '
        'btnFileName
        '
        Me.btnFileName.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnFileName.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnFileName.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnFileName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileName.Appearance.Options.UseBackColor = True
        Me.btnFileName.Appearance.Options.UseBorderColor = True
        Me.btnFileName.Appearance.Options.UseFont = True
        Me.btnFileName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFileName.ImageOptions.Image = CType(resources.GetObject("btnFileName.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFileName.Location = New System.Drawing.Point(6, 138)
        Me.btnFileName.Name = "btnFileName"
        Me.btnFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFileName.Size = New System.Drawing.Size(226, 38)
        Me.btnFileName.TabIndex = 126
        Me.btnFileName.Text = "نام فایل"
        Me.btnFileName.Visible = False
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(586, 133)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(255, 23)
        Me.txtDocNo.TabIndex = 93
        '
        'FrmNewDocRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewDocRequest"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "درخواست تغییر یا ایجاد مستندات"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbAttachFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDocNo As NumericTextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbReqTypes As ComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChanges As TextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtStoreDuration As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents txtRegDate As TextBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbDeps As ComboBox
    Private WithEvents PersianCalender As BehComponents.MonthCalendarX
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblReqId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbAttachFiles As PictureBox
    Friend WithEvents btnAttachFiles As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFileName As DevExpress.XtraEditors.SimpleButton
End Class
