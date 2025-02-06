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
        Me.txtReqCode = New System.Windows.Forms.TextBox()
        Me.cmbDocOwnerDep = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.btnFileName = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnAttachFiles = New DevComponents.DotNetBar.ButtonX()
        Me.pbAttachFiles = New System.Windows.Forms.PictureBox()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDeps = New System.Windows.Forms.ComboBox()
        Me.PersianCalender = New BehComponents.MonthCalendarX()
        Me.grdDocRequests = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequesterDepName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OffererName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Title = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocumentCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequestType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StoreDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Changes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UpdateOrNewDocReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RegDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ReqDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Attachment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EditNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EditOrReview = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequesterDepBossOrAdminComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocOwnerDepBossOrAdminComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SysOfficeBossComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SysAdminComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OkDocOwnerDepAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OkSysOfficeBoss = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OkSysAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocOwnerDepName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDocNoStar = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbDocOwnerDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttachFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDocRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(1139, 147)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "عنوان سند:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(1139, 184)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 91
        Me.LabelControl2.Text = "شماره سند:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(1130, 215)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl3.TabIndex = 94
        Me.LabelControl3.Text = "نوع درخواست:"
        '
        'cmbReqTypes
        '
        Me.cmbReqTypes.FormattingEnabled = True
        Me.cmbReqTypes.Items.AddRange(New Object() {"ایجاد", "تغییر", "حذف"})
        Me.cmbReqTypes.Location = New System.Drawing.Point(816, 214)
        Me.cmbReqTypes.Name = "cmbReqTypes"
        Me.cmbReqTypes.Size = New System.Drawing.Size(258, 24)
        Me.cmbReqTypes.TabIndex = 95
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(1106, 71)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.TabIndex = 96
        Me.LabelControl4.Text = "واحد درخواست کننده:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(1082, 250)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl5.TabIndex = 98
        Me.LabelControl5.Text = "مدت زمان نگهداری سوابق:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(652, 31)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl6.TabIndex = 102
        Me.LabelControl6.Text = "شرح تغییرات:"
        '
        'txtChanges
        '
        Me.txtChanges.Location = New System.Drawing.Point(453, 32)
        Me.txtChanges.Multiline = True
        Me.txtChanges.Name = "txtChanges"
        Me.txtChanges.Size = New System.Drawing.Size(193, 94)
        Me.txtChanges.TabIndex = 103
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(652, 143)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "علت تغییر/ایجاد سند:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(816, 147)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(258, 23)
        Me.txtTitle.TabIndex = 106
        '
        'txtStoreDuration
        '
        Me.txtStoreDuration.Location = New System.Drawing.Point(816, 244)
        Me.txtStoreDuration.Name = "txtStoreDuration"
        Me.txtStoreDuration.Size = New System.Drawing.Size(258, 23)
        Me.txtStoreDuration.TabIndex = 107
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(453, 132)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(193, 70)
        Me.txtReason.TabIndex = 111
        '
        'txtRegDate
        '
        Me.txtRegDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtRegDate.Location = New System.Drawing.Point(453, 209)
        Me.txtRegDate.Name = "txtRegDate"
        Me.txtRegDate.ReadOnly = True
        Me.txtRegDate.Size = New System.Drawing.Size(193, 23)
        Me.txtRegDate.TabIndex = 113
        Me.txtRegDate.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(667, 214)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl9.TabIndex = 112
        Me.LabelControl9.Text = "تاریخ ثبت:"
        Me.LabelControl9.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(1123, 35)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl10.TabIndex = 114
        Me.LabelControl10.Text = "شماره درخواست:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDocNoStar)
        Me.GroupBox1.Controls.Add(Me.txtReqCode)
        Me.GroupBox1.Controls.Add(Me.cmbDocOwnerDep)
        Me.GroupBox1.Controls.Add(Me.LabelControl15)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.txtDocNo)
        Me.GroupBox1.Controls.Add(Me.btnFileName)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.btnAttachFiles)
        Me.GroupBox1.Controls.Add(Me.pbAttachFiles)
        Me.GroupBox1.Controls.Add(Me.LabelControl14)
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.cmbDeps)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
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
        Me.GroupBox1.Size = New System.Drawing.Size(1224, 284)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "درخواست تغییر/ایجاد مستندات"
        '
        'txtReqCode
        '
        Me.txtReqCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReqCode.Enabled = False
        Me.txtReqCode.Location = New System.Drawing.Point(816, 40)
        Me.txtReqCode.Name = "txtReqCode"
        Me.txtReqCode.Size = New System.Drawing.Size(258, 23)
        Me.txtReqCode.TabIndex = 132
        Me.txtReqCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbDocOwnerDep
        '
        Me.cmbDocOwnerDep.EnterMoveNextControl = True
        Me.cmbDocOwnerDep.Location = New System.Drawing.Point(816, 103)
        Me.cmbDocOwnerDep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDocOwnerDep.Name = "cmbDocOwnerDep"
        Me.cmbDocOwnerDep.Properties.Appearance.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbDocOwnerDep.Properties.Appearance.Options.UseFont = True
        Me.cmbDocOwnerDep.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbDocOwnerDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDocOwnerDep.Properties.NullText = "-"
        Me.cmbDocOwnerDep.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cmbDocOwnerDep.Properties.ShowNullValuePrompt = CType(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) _
            Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.cmbDocOwnerDep.Size = New System.Drawing.Size(258, 32)
        Me.cmbDocOwnerDep.TabIndex = 131
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(1203, 109)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(8, 17)
        Me.LabelControl15.TabIndex = 129
        Me.LabelControl15.Text = "*"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(1116, 109)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl8.TabIndex = 128
        Me.LabelControl8.Text = "واحد متولی سند:"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(816, 179)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(258, 23)
        Me.txtDocNo.TabIndex = 127
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
        Me.btnFileName.Location = New System.Drawing.Point(140, 147)
        Me.btnFileName.Name = "btnFileName"
        Me.btnFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFileName.Size = New System.Drawing.Size(226, 38)
        Me.btnFileName.TabIndex = 126
        Me.btnFileName.Text = "نام فایل"
        Me.btnFileName.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Location = New System.Drawing.Point(140, 232)
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
        Me.btnAttachFiles.Location = New System.Drawing.Point(140, 192)
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
        Me.pbAttachFiles.Location = New System.Drawing.Point(140, 35)
        Me.pbAttachFiles.Name = "pbAttachFiles"
        Me.pbAttachFiles.Size = New System.Drawing.Size(226, 150)
        Me.pbAttachFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAttachFiles.TabIndex = 123
        Me.pbAttachFiles.TabStop = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(756, 144)
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
        Me.LabelControl13.Location = New System.Drawing.Point(722, 32)
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
        Me.LabelControl12.Location = New System.Drawing.Point(1203, 211)
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
        Me.LabelControl11.Location = New System.Drawing.Point(1203, 147)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(8, 17)
        Me.LabelControl11.TabIndex = 118
        Me.LabelControl11.Text = "*"
        '
        'cmbDeps
        '
        Me.cmbDeps.Enabled = False
        Me.cmbDeps.FormattingEnabled = True
        Me.cmbDeps.Location = New System.Drawing.Point(816, 69)
        Me.cmbDeps.Name = "cmbDeps"
        Me.cmbDeps.Size = New System.Drawing.Size(258, 24)
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
        Me.PersianCalender.Location = New System.Drawing.Point(652, 56)
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
        'grdDocRequests
        '
        Me.grdDocRequests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDocRequests.Location = New System.Drawing.Point(3, 19)
        Me.grdDocRequests.MainView = Me.GridView1
        Me.grdDocRequests.Name = "grdDocRequests"
        Me.grdDocRequests.Size = New System.Drawing.Size(1218, 446)
        Me.grdDocRequests.TabIndex = 121
        Me.grdDocRequests.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Id, Me.RequesterDepName, Me.OffererName, Me.Title, Me.DocumentCode, Me.RequestType, Me.StoreDuration, Me.Changes, Me.UpdateOrNewDocReason, Me.RegDateTime, Me.ReqDateTime, Me.Attachment, Me.EditNo, Me.EditOrReview, Me.RequesterDepBossOrAdminComment, Me.DocOwnerDepBossOrAdminComment, Me.SysOfficeBossComment, Me.SysAdminComment, Me.OkDocOwnerDepAdmin, Me.OkSysOfficeBoss, Me.OkSysAdmin, Me.DocOwnerDepName})
        Me.GridView1.GridControl = Me.grdDocRequests
        Me.GridView1.HorzScrollStep = 1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'Id
        '
        Me.Id.Caption = "شماره درخواست"
        Me.Id.FieldName = "Id"
        Me.Id.MinWidth = 50
        Me.Id.Name = "Id"
        Me.Id.Visible = True
        Me.Id.VisibleIndex = 0
        Me.Id.Width = 82
        '
        'RequesterDepName
        '
        Me.RequesterDepName.Caption = "واحد درخواست کننده"
        Me.RequesterDepName.FieldName = "RequesterDepName"
        Me.RequesterDepName.Name = "RequesterDepName"
        Me.RequesterDepName.Visible = True
        Me.RequesterDepName.VisibleIndex = 1
        Me.RequesterDepName.Width = 191
        '
        'OffererName
        '
        Me.OffererName.Caption = "پیشنهاد دهنده"
        Me.OffererName.FieldName = "OffererName"
        Me.OffererName.Name = "OffererName"
        Me.OffererName.Visible = True
        Me.OffererName.VisibleIndex = 2
        Me.OffererName.Width = 103
        '
        'Title
        '
        Me.Title.Caption = "عنوان سند"
        Me.Title.FieldName = "Title"
        Me.Title.Name = "Title"
        Me.Title.Visible = True
        Me.Title.VisibleIndex = 4
        Me.Title.Width = 93
        '
        'DocumentCode
        '
        Me.DocumentCode.Caption = "شماره سند"
        Me.DocumentCode.FieldName = "DocumentCode"
        Me.DocumentCode.Name = "DocumentCode"
        Me.DocumentCode.Visible = True
        Me.DocumentCode.VisibleIndex = 7
        Me.DocumentCode.Width = 84
        '
        'RequestType
        '
        Me.RequestType.Caption = "نوع درخواست"
        Me.RequestType.FieldName = "RequestType"
        Me.RequestType.Name = "RequestType"
        Me.RequestType.Visible = True
        Me.RequestType.VisibleIndex = 3
        Me.RequestType.Width = 76
        '
        'StoreDuration
        '
        Me.StoreDuration.Caption = "مدت نگهداری سوابق(مخصوص فرم ها)"
        Me.StoreDuration.FieldName = "StoreDuration"
        Me.StoreDuration.Name = "StoreDuration"
        Me.StoreDuration.Visible = True
        Me.StoreDuration.VisibleIndex = 8
        Me.StoreDuration.Width = 20
        '
        'Changes
        '
        Me.Changes.Caption = "شرح تغییرات"
        Me.Changes.FieldName = "Changes"
        Me.Changes.Name = "Changes"
        Me.Changes.Visible = True
        Me.Changes.VisibleIndex = 5
        Me.Changes.Width = 148
        '
        'UpdateOrNewDocReason
        '
        Me.UpdateOrNewDocReason.Caption = "علت تغییر/ایجاد سند"
        Me.UpdateOrNewDocReason.FieldName = "UpdateOrNewDocReason"
        Me.UpdateOrNewDocReason.Name = "UpdateOrNewDocReason"
        Me.UpdateOrNewDocReason.Visible = True
        Me.UpdateOrNewDocReason.VisibleIndex = 6
        Me.UpdateOrNewDocReason.Width = 120
        '
        'RegDateTime
        '
        Me.RegDateTime.Caption = "تاریخ ثبت"
        Me.RegDateTime.FieldName = "RegDateTime"
        Me.RegDateTime.Name = "RegDateTime"
        Me.RegDateTime.Visible = True
        Me.RegDateTime.VisibleIndex = 9
        Me.RegDateTime.Width = 20
        '
        'ReqDateTime
        '
        Me.ReqDateTime.Caption = "تاریخ درخواست"
        Me.ReqDateTime.FieldName = "ReqDateTime"
        Me.ReqDateTime.Name = "ReqDateTime"
        Me.ReqDateTime.Visible = True
        Me.ReqDateTime.VisibleIndex = 10
        Me.ReqDateTime.Width = 20
        '
        'Attachment
        '
        Me.Attachment.Caption = "فایل پیوست"
        Me.Attachment.FieldName = "Attachment"
        Me.Attachment.ImageOptions.Image = CType(resources.GetObject("Attachment.ImageOptions.Image"), System.Drawing.Image)
        Me.Attachment.Name = "Attachment"
        Me.Attachment.OptionsColumn.AllowEdit = False
        Me.Attachment.Visible = True
        Me.Attachment.VisibleIndex = 11
        Me.Attachment.Width = 20
        '
        'EditNo
        '
        Me.EditNo.Caption = "شماره ویرایش"
        Me.EditNo.FieldName = "EditNo"
        Me.EditNo.Name = "EditNo"
        Me.EditNo.Visible = True
        Me.EditNo.VisibleIndex = 12
        Me.EditNo.Width = 20
        '
        'EditOrReview
        '
        Me.EditOrReview.Caption = "بازنگری/ویرایش"
        Me.EditOrReview.FieldName = "EditOrReview"
        Me.EditOrReview.Name = "EditOrReview"
        Me.EditOrReview.Visible = True
        Me.EditOrReview.VisibleIndex = 13
        Me.EditOrReview.Width = 20
        '
        'RequesterDepBossOrAdminComment
        '
        Me.RequesterDepBossOrAdminComment.Caption = "نظر مدیر/رئیس واحد درخواست کننده"
        Me.RequesterDepBossOrAdminComment.FieldName = "RequesterDepBossOrAdminComment"
        Me.RequesterDepBossOrAdminComment.Name = "RequesterDepBossOrAdminComment"
        Me.RequesterDepBossOrAdminComment.Visible = True
        Me.RequesterDepBossOrAdminComment.VisibleIndex = 14
        Me.RequesterDepBossOrAdminComment.Width = 20
        '
        'DocOwnerDepBossOrAdminComment
        '
        Me.DocOwnerDepBossOrAdminComment.Caption = "نظر مدیر/رئیس واحد متولی سند"
        Me.DocOwnerDepBossOrAdminComment.FieldName = "DocOwnerDepBossOrAdminComment"
        Me.DocOwnerDepBossOrAdminComment.Name = "DocOwnerDepBossOrAdminComment"
        Me.DocOwnerDepBossOrAdminComment.Visible = True
        Me.DocOwnerDepBossOrAdminComment.VisibleIndex = 15
        Me.DocOwnerDepBossOrAdminComment.Width = 20
        '
        'SysOfficeBossComment
        '
        Me.SysOfficeBossComment.Caption = "نظر رئیس اداره سیستم ها و روش ها"
        Me.SysOfficeBossComment.FieldName = "SysOfficeBossComment"
        Me.SysOfficeBossComment.Name = "SysOfficeBossComment"
        Me.SysOfficeBossComment.Visible = True
        Me.SysOfficeBossComment.VisibleIndex = 16
        Me.SysOfficeBossComment.Width = 20
        '
        'SysAdminComment
        '
        Me.SysAdminComment.Caption = "نظر مدیر سیستم ها و انفورماتیک"
        Me.SysAdminComment.FieldName = "SysAdminComment"
        Me.SysAdminComment.Name = "SysAdminComment"
        Me.SysAdminComment.Visible = True
        Me.SysAdminComment.VisibleIndex = 17
        Me.SysAdminComment.Width = 20
        '
        'OkDocOwnerDepAdmin
        '
        Me.OkDocOwnerDepAdmin.Caption = "تایید واحد متولی سند"
        Me.OkDocOwnerDepAdmin.FieldName = "OkDocOwnerDepAdmin"
        Me.OkDocOwnerDepAdmin.Name = "OkDocOwnerDepAdmin"
        Me.OkDocOwnerDepAdmin.Visible = True
        Me.OkDocOwnerDepAdmin.VisibleIndex = 18
        Me.OkDocOwnerDepAdmin.Width = 20
        '
        'OkSysOfficeBoss
        '
        Me.OkSysOfficeBoss.Caption = "تایید رئیس اداره سیستم ها و روش ها"
        Me.OkSysOfficeBoss.FieldName = "OkSysOfficeBoss"
        Me.OkSysOfficeBoss.Name = "OkSysOfficeBoss"
        Me.OkSysOfficeBoss.Visible = True
        Me.OkSysOfficeBoss.VisibleIndex = 19
        Me.OkSysOfficeBoss.Width = 20
        '
        'OkSysAdmin
        '
        Me.OkSysAdmin.Caption = "تایید مدیر سیستم ها و انفورماتیک"
        Me.OkSysAdmin.FieldName = "OkSysAdmin"
        Me.OkSysAdmin.Name = "OkSysAdmin"
        Me.OkSysAdmin.Visible = True
        Me.OkSysAdmin.VisibleIndex = 20
        Me.OkSysAdmin.Width = 20
        '
        'DocOwnerDepName
        '
        Me.DocOwnerDepName.Caption = "واحد متولی سند"
        Me.DocOwnerDepName.FieldName = "DocOwnerDepName"
        Me.DocOwnerDepName.Name = "DocOwnerDepName"
        Me.DocOwnerDepName.Visible = True
        Me.DocOwnerDepName.VisibleIndex = 21
        Me.DocOwnerDepName.Width = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdDocRequests)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1224, 468)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "درخواست های ثبت شده"
        '
        'lblDocNoStar
        '
        Me.lblDocNoStar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.lblDocNoStar.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblDocNoStar.Appearance.Options.UseFont = True
        Me.lblDocNoStar.Appearance.Options.UseForeColor = True
        Me.lblDocNoStar.Location = New System.Drawing.Point(1203, 184)
        Me.lblDocNoStar.Name = "lblDocNoStar"
        Me.lblDocNoStar.Size = New System.Drawing.Size(8, 17)
        Me.lblDocNoStar.TabIndex = 133
        Me.lblDocNoStar.Text = "*"
        Me.lblDocNoStar.Visible = False
        '
        'FrmNewDocRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 782)
        Me.Controls.Add(Me.GroupBox2)
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
        CType(Me.cmbDocOwnerDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttachFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDocRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents pbAttachFiles As PictureBox
    Friend WithEvents btnAttachFiles As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFileName As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents grdDocRequests As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequesterDepName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OffererName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Title As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocumentCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequestType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StoreDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Changes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UpdateOrNewDocReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RegDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReqDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Attachment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EditNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EditOrReview As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequesterDepBossOrAdminComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocOwnerDepBossOrAdminComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SysOfficeBossComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SysAdminComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OkDocOwnerDepAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OkSysOfficeBoss As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OkSysAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DocOwnerDepName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents cmbDocOwnerDep As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtReqCode As TextBox
    Friend WithEvents lblDocNoStar As DevExpress.XtraEditors.LabelControl
End Class
