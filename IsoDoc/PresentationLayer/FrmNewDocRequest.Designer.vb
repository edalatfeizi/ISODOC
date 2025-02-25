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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewDocRequest))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChanges = New System.Windows.Forms.TextBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStoreDuration = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtRegDate = New System.Windows.Forms.TextBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.f = New System.Windows.Forms.Label()
        Me.txtNewDocTitle = New System.Windows.Forms.TextBox()
        Me.cmbDocTitle = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtReqCode = New System.Windows.Forms.TextBox()
        Me.cmbDocOwnerDep = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnFileName = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnAttachFiles = New DevComponents.DotNetBar.ButtonX()
        Me.pbAttachFiles = New System.Windows.Forms.PictureBox()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDeps = New System.Windows.Forms.ComboBox()
        Me.cmbReqTypes = New System.Windows.Forms.ComboBox()
        Me.PersianCalender = New BehComponents.MonthCalendarX()
        Me.grdDocRequests = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RowNumber = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.FileExtension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Attachment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EditNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EditOrReview = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequesterDepBossOrAdminComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OkDocOwnerDepAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocOwnerDepBossOrAdminComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OkSysOfficeBoss = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SysOfficeBossComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocOwnerDepName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OkSysAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SysAdminComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Active = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuUploadAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbDocTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDocOwnerDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttachFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDocRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(1139, 183)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 19)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "عنوان سند:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(1130, 107)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl3.TabIndex = 94
        Me.LabelControl3.Text = "نوع درخواست:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(1106, 71)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(96, 19)
        Me.LabelControl4.TabIndex = 96
        Me.LabelControl4.Text = "واحد درخواست کننده:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(1082, 220)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(116, 19)
        Me.LabelControl5.TabIndex = 98
        Me.LabelControl5.Text = "مدت زمان نگهداری سوابق:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(734, 38)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl6.TabIndex = 102
        Me.LabelControl6.Text = "شرح تغییرات:"
        '
        'txtChanges
        '
        Me.txtChanges.Location = New System.Drawing.Point(283, 33)
        Me.txtChanges.MaxLength = 250
        Me.txtChanges.Multiline = True
        Me.txtChanges.Name = "txtChanges"
        Me.txtChanges.Size = New System.Drawing.Size(410, 94)
        Me.txtChanges.TabIndex = 103
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(699, 148)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(94, 19)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "علت تغییر/ایجاد سند:"
        '
        'txtStoreDuration
        '
        Me.txtStoreDuration.Enabled = False
        Me.txtStoreDuration.Location = New System.Drawing.Point(816, 215)
        Me.txtStoreDuration.Multiline = True
        Me.txtStoreDuration.Name = "txtStoreDuration"
        Me.txtStoreDuration.Size = New System.Drawing.Size(258, 31)
        Me.txtStoreDuration.TabIndex = 107
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(283, 149)
        Me.txtReason.MaxLength = 150
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(410, 97)
        Me.txtReason.TabIndex = 111
        '
        'txtRegDate
        '
        Me.txtRegDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtRegDate.Location = New System.Drawing.Point(816, 255)
        Me.txtRegDate.Name = "txtRegDate"
        Me.txtRegDate.ReadOnly = True
        Me.txtRegDate.Size = New System.Drawing.Size(193, 23)
        Me.txtRegDate.TabIndex = 113
        Me.txtRegDate.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(1030, 260)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(46, 19)
        Me.LabelControl9.TabIndex = 112
        Me.LabelControl9.Text = "تاریخ ثبت:"
        Me.LabelControl9.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(1123, 35)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl10.TabIndex = 114
        Me.LabelControl10.Text = "شماره درخواست:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Controls.Add(Me.f)
        Me.GroupBox1.Controls.Add(Me.txtNewDocTitle)
        Me.GroupBox1.Controls.Add(Me.cmbDocTitle)
        Me.GroupBox1.Controls.Add(Me.txtReqCode)
        Me.GroupBox1.Controls.Add(Me.cmbDocOwnerDep)
        Me.GroupBox1.Controls.Add(Me.LabelControl15)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
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
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.cmbReqTypes)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txtRegDate)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.txtChanges)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.txtStoreDuration)
        Me.GroupBox1.Controls.Add(Me.PersianCalender)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1224, 284)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ثبت درخواست تغییر/ایجاد مستندات"
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Location = New System.Drawing.Point(546, 196)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(264, 16)
        Me.f.TabIndex = 136
        Me.f.Text = "<= cmbDocTitle is placed below this textbox "
        Me.f.Visible = False
        '
        'txtNewDocTitle
        '
        Me.txtNewDocTitle.Location = New System.Drawing.Point(766, 244)
        Me.txtNewDocTitle.Multiline = True
        Me.txtNewDocTitle.Name = "txtNewDocTitle"
        Me.txtNewDocTitle.Size = New System.Drawing.Size(258, 34)
        Me.txtNewDocTitle.TabIndex = 135
        Me.txtNewDocTitle.Visible = False
        '
        'cmbDocTitle
        '
        Me.cmbDocTitle.EnterMoveNextControl = True
        Me.cmbDocTitle.Location = New System.Drawing.Point(816, 178)
        Me.cmbDocTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDocTitle.Name = "cmbDocTitle"
        Me.cmbDocTitle.Properties.Appearance.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbDocTitle.Properties.Appearance.Options.UseFont = True
        Me.cmbDocTitle.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbDocTitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDocTitle.Properties.NullText = "-"
        Me.cmbDocTitle.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cmbDocTitle.Properties.ShowNullValuePrompt = CType(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) _
            Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.cmbDocTitle.Size = New System.Drawing.Size(258, 32)
        Me.cmbDocTitle.TabIndex = 134
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
        Me.cmbDocOwnerDep.Location = New System.Drawing.Point(816, 139)
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
        Me.LabelControl15.Location = New System.Drawing.Point(1203, 145)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(8, 17)
        Me.LabelControl15.TabIndex = 129
        Me.LabelControl15.Text = "*"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(1116, 145)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl8.TabIndex = 128
        Me.LabelControl8.Text = "واحد متولی سند:"
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
        Me.btnFileName.Location = New System.Drawing.Point(6, 134)
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
        Me.BtnSave.Location = New System.Drawing.Point(6, 212)
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
        Me.btnAttachFiles.Location = New System.Drawing.Point(6, 175)
        Me.btnAttachFiles.Name = "btnAttachFiles"
        Me.btnAttachFiles.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnAttachFiles.Size = New System.Drawing.Size(226, 34)
        Me.btnAttachFiles.TabIndex = 125
        Me.btnAttachFiles.Text = "پیوست فایل"
        '
        'pbAttachFiles
        '
        Me.pbAttachFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttachFiles.Image = Global.IsoDoc.My.Resources.Resources.attach_files2
        Me.pbAttachFiles.Location = New System.Drawing.Point(6, 33)
        Me.pbAttachFiles.Name = "pbAttachFiles"
        Me.pbAttachFiles.Size = New System.Drawing.Size(226, 139)
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
        Me.LabelControl14.Location = New System.Drawing.Point(803, 149)
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
        Me.LabelControl13.Location = New System.Drawing.Point(804, 39)
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
        Me.LabelControl12.Location = New System.Drawing.Point(1203, 107)
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
        Me.LabelControl11.Location = New System.Drawing.Point(1203, 183)
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
        'cmbReqTypes
        '
        Me.cmbReqTypes.FormattingEnabled = True
        Me.cmbReqTypes.Items.AddRange(New Object() {"ایجاد", "تغییر", "حذف"})
        Me.cmbReqTypes.Location = New System.Drawing.Point(816, 102)
        Me.cmbReqTypes.Name = "cmbReqTypes"
        Me.cmbReqTypes.Size = New System.Drawing.Size(258, 24)
        Me.cmbReqTypes.TabIndex = 95
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
        Me.PersianCalender.Location = New System.Drawing.Point(181, 22)
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
        Me.grdDocRequests.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox1, Me.RepositoryItemLookUpEdit1})
        Me.grdDocRequests.Size = New System.Drawing.Size(1218, 446)
        Me.grdDocRequests.TabIndex = 121
        Me.grdDocRequests.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RowNumber, Me.Id, Me.RequesterDepName, Me.OffererName, Me.Title, Me.DocumentCode, Me.RequestType, Me.StoreDuration, Me.Changes, Me.UpdateOrNewDocReason, Me.RegDateTime, Me.ReqDateTime, Me.FileExtension, Me.Attachment, Me.EditNo, Me.EditOrReview, Me.RequesterDepBossOrAdminComment, Me.OkDocOwnerDepAdmin, Me.DocOwnerDepBossOrAdminComment, Me.OkSysOfficeBoss, Me.SysOfficeBossComment, Me.DocOwnerDepName, Me.OkSysAdmin, Me.SysAdminComment, Me.Active})
        Me.GridView1.GridControl = Me.grdDocRequests
        Me.GridView1.HorzScrollStep = 1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'RowNumber
        '
        Me.RowNumber.Caption = "ردیف"
        Me.RowNumber.FieldName = "RowNumber"
        Me.RowNumber.Name = "RowNumber"
        Me.RowNumber.OptionsColumn.AllowEdit = False
        Me.RowNumber.UnboundDataType = GetType(Integer)
        Me.RowNumber.Visible = True
        Me.RowNumber.VisibleIndex = 0
        '
        'Id
        '
        Me.Id.Caption = "شماره درخواست"
        Me.Id.FieldName = "Id"
        Me.Id.MinWidth = 50
        Me.Id.Name = "Id"
        Me.Id.OptionsColumn.AllowEdit = False
        Me.Id.Visible = True
        Me.Id.VisibleIndex = 1
        Me.Id.Width = 92
        '
        'RequesterDepName
        '
        Me.RequesterDepName.Caption = "واحد درخواست کننده"
        Me.RequesterDepName.FieldName = "RequesterDepName"
        Me.RequesterDepName.Name = "RequesterDepName"
        Me.RequesterDepName.OptionsColumn.AllowEdit = False
        Me.RequesterDepName.Visible = True
        Me.RequesterDepName.VisibleIndex = 3
        Me.RequesterDepName.Width = 81
        '
        'OffererName
        '
        Me.OffererName.Caption = "پیشنهاد دهنده"
        Me.OffererName.FieldName = "OffererName"
        Me.OffererName.Name = "OffererName"
        Me.OffererName.OptionsColumn.AllowEdit = False
        Me.OffererName.Visible = True
        Me.OffererName.VisibleIndex = 4
        Me.OffererName.Width = 36
        '
        'Title
        '
        Me.Title.Caption = "عنوان سند"
        Me.Title.FieldName = "Title"
        Me.Title.Name = "Title"
        Me.Title.OptionsColumn.AllowEdit = False
        Me.Title.Visible = True
        Me.Title.VisibleIndex = 6
        Me.Title.Width = 56
        '
        'DocumentCode
        '
        Me.DocumentCode.Caption = "شماره سند"
        Me.DocumentCode.FieldName = "DocumentCode"
        Me.DocumentCode.Name = "DocumentCode"
        Me.DocumentCode.OptionsColumn.AllowEdit = False
        Me.DocumentCode.Visible = True
        Me.DocumentCode.VisibleIndex = 9
        Me.DocumentCode.Width = 52
        '
        'RequestType
        '
        Me.RequestType.Caption = "نوع درخواست"
        Me.RequestType.FieldName = "RequestType"
        Me.RequestType.Name = "RequestType"
        Me.RequestType.OptionsColumn.AllowEdit = False
        Me.RequestType.Visible = True
        Me.RequestType.VisibleIndex = 5
        Me.RequestType.Width = 38
        '
        'StoreDuration
        '
        Me.StoreDuration.Caption = "مدت نگهداری سوابق(مخصوص فرم ها)"
        Me.StoreDuration.FieldName = "StoreDuration"
        Me.StoreDuration.Name = "StoreDuration"
        Me.StoreDuration.OptionsColumn.AllowEdit = False
        Me.StoreDuration.Visible = True
        Me.StoreDuration.VisibleIndex = 10
        Me.StoreDuration.Width = 36
        '
        'Changes
        '
        Me.Changes.Caption = "شرح تغییرات"
        Me.Changes.FieldName = "Changes"
        Me.Changes.Name = "Changes"
        Me.Changes.OptionsColumn.AllowEdit = False
        Me.Changes.Visible = True
        Me.Changes.VisibleIndex = 7
        Me.Changes.Width = 52
        '
        'UpdateOrNewDocReason
        '
        Me.UpdateOrNewDocReason.Caption = "علت تغییر/ایجاد سند"
        Me.UpdateOrNewDocReason.FieldName = "UpdateOrNewDocReason"
        Me.UpdateOrNewDocReason.Name = "UpdateOrNewDocReason"
        Me.UpdateOrNewDocReason.OptionsColumn.AllowEdit = False
        Me.UpdateOrNewDocReason.Visible = True
        Me.UpdateOrNewDocReason.VisibleIndex = 8
        Me.UpdateOrNewDocReason.Width = 65
        '
        'RegDateTime
        '
        Me.RegDateTime.Caption = "تاریخ ثبت"
        Me.RegDateTime.FieldName = "RegDateTime"
        Me.RegDateTime.Name = "RegDateTime"
        Me.RegDateTime.OptionsColumn.AllowEdit = False
        Me.RegDateTime.Visible = True
        Me.RegDateTime.VisibleIndex = 13
        Me.RegDateTime.Width = 41
        '
        'ReqDateTime
        '
        Me.ReqDateTime.Caption = "تاریخ درخواست"
        Me.ReqDateTime.FieldName = "ReqDateTime"
        Me.ReqDateTime.Name = "ReqDateTime"
        Me.ReqDateTime.OptionsColumn.AllowEdit = False
        Me.ReqDateTime.Visible = True
        Me.ReqDateTime.VisibleIndex = 2
        Me.ReqDateTime.Width = 41
        '
        'FileExtension
        '
        Me.FileExtension.Caption = "نوع فایل پیوست"
        Me.FileExtension.FieldName = "FileExtension"
        Me.FileExtension.Name = "FileExtension"
        Me.FileExtension.OptionsColumn.AllowEdit = False
        Me.FileExtension.Visible = True
        Me.FileExtension.VisibleIndex = 12
        '
        'Attachment
        '
        Me.Attachment.Caption = "فایل پیوست"
        Me.Attachment.FieldName = "Attachment"
        Me.Attachment.Name = "Attachment"
        Me.Attachment.OptionsColumn.AllowEdit = False
        Me.Attachment.Visible = True
        Me.Attachment.VisibleIndex = 11
        Me.Attachment.Width = 62
        '
        'EditNo
        '
        Me.EditNo.Caption = "شماره ویرایش"
        Me.EditNo.FieldName = "EditNo"
        Me.EditNo.Name = "EditNo"
        Me.EditNo.OptionsColumn.AllowEdit = False
        Me.EditNo.Width = 39
        '
        'EditOrReview
        '
        Me.EditOrReview.Caption = "بازنگری/ویرایش"
        Me.EditOrReview.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.EditOrReview.FieldName = "EditOrReview"
        Me.EditOrReview.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.EditOrReview.Name = "EditOrReview"
        Me.EditOrReview.OptionsColumn.AllowEdit = False
        Me.EditOrReview.Visible = True
        Me.EditOrReview.VisibleIndex = 14
        Me.EditOrReview.Width = 55
        '
        'RequesterDepBossOrAdminComment
        '
        Me.RequesterDepBossOrAdminComment.Caption = "نظر مدیر/رئیس واحد درخواست کننده"
        Me.RequesterDepBossOrAdminComment.FieldName = "RequesterDepBossOrAdminComment"
        Me.RequesterDepBossOrAdminComment.Name = "RequesterDepBossOrAdminComment"
        Me.RequesterDepBossOrAdminComment.OptionsColumn.AllowEdit = False
        Me.RequesterDepBossOrAdminComment.Visible = True
        Me.RequesterDepBossOrAdminComment.VisibleIndex = 22
        Me.RequesterDepBossOrAdminComment.Width = 87
        '
        'OkDocOwnerDepAdmin
        '
        Me.OkDocOwnerDepAdmin.Caption = "تایید واحد متولی سند"
        Me.OkDocOwnerDepAdmin.FieldName = "OkDocOwnerDepAdmin"
        Me.OkDocOwnerDepAdmin.Name = "OkDocOwnerDepAdmin"
        Me.OkDocOwnerDepAdmin.OptionsColumn.AllowEdit = False
        Me.OkDocOwnerDepAdmin.Visible = True
        Me.OkDocOwnerDepAdmin.VisibleIndex = 20
        Me.OkDocOwnerDepAdmin.Width = 35
        '
        'DocOwnerDepBossOrAdminComment
        '
        Me.DocOwnerDepBossOrAdminComment.Caption = "نظر مدیر/رئیس واحد متولی سند"
        Me.DocOwnerDepBossOrAdminComment.FieldName = "DocOwnerDepBossOrAdminComment"
        Me.DocOwnerDepBossOrAdminComment.Name = "DocOwnerDepBossOrAdminComment"
        Me.DocOwnerDepBossOrAdminComment.OptionsColumn.AllowEdit = False
        Me.DocOwnerDepBossOrAdminComment.Visible = True
        Me.DocOwnerDepBossOrAdminComment.VisibleIndex = 21
        Me.DocOwnerDepBossOrAdminComment.Width = 52
        '
        'OkSysOfficeBoss
        '
        Me.OkSysOfficeBoss.Caption = "تایید رئیس اداره سیستم ها و روش ها"
        Me.OkSysOfficeBoss.FieldName = "OkSysOfficeBoss"
        Me.OkSysOfficeBoss.Name = "OkSysOfficeBoss"
        Me.OkSysOfficeBoss.OptionsColumn.AllowEdit = False
        Me.OkSysOfficeBoss.Visible = True
        Me.OkSysOfficeBoss.VisibleIndex = 15
        Me.OkSysOfficeBoss.Width = 50
        '
        'SysOfficeBossComment
        '
        Me.SysOfficeBossComment.Caption = "نظر رئیس اداره سیستم ها و روش ها"
        Me.SysOfficeBossComment.FieldName = "SysOfficeBossComment"
        Me.SysOfficeBossComment.Name = "SysOfficeBossComment"
        Me.SysOfficeBossComment.OptionsColumn.AllowEdit = False
        Me.SysOfficeBossComment.Visible = True
        Me.SysOfficeBossComment.VisibleIndex = 16
        Me.SysOfficeBossComment.Width = 33
        '
        'DocOwnerDepName
        '
        Me.DocOwnerDepName.Caption = "واحد متولی سند"
        Me.DocOwnerDepName.FieldName = "DocOwnerDepName"
        Me.DocOwnerDepName.Name = "DocOwnerDepName"
        Me.DocOwnerDepName.OptionsColumn.AllowEdit = False
        Me.DocOwnerDepName.Visible = True
        Me.DocOwnerDepName.VisibleIndex = 19
        Me.DocOwnerDepName.Width = 58
        '
        'OkSysAdmin
        '
        Me.OkSysAdmin.Caption = "تایید مدیر سیستم ها و انفورماتیک"
        Me.OkSysAdmin.FieldName = "OkSysAdmin"
        Me.OkSysAdmin.Name = "OkSysAdmin"
        Me.OkSysAdmin.OptionsColumn.AllowEdit = False
        Me.OkSysAdmin.Visible = True
        Me.OkSysAdmin.VisibleIndex = 17
        Me.OkSysAdmin.Width = 92
        '
        'SysAdminComment
        '
        Me.SysAdminComment.Caption = "نظر مدیر سیستم ها و انفورماتیک"
        Me.SysAdminComment.FieldName = "SysAdminComment"
        Me.SysAdminComment.Name = "SysAdminComment"
        Me.SysAdminComment.OptionsColumn.AllowEdit = False
        Me.SysAdminComment.Visible = True
        Me.SysAdminComment.VisibleIndex = 18
        Me.SysAdminComment.Width = 40
        '
        'Active
        '
        Me.Active.Caption = "وضعیت درخواست"
        Me.Active.FieldName = "Active"
        Me.Active.Name = "Active"
        Me.Active.OptionsColumn.AllowEdit = False
        Me.Active.OptionsColumn.AllowFocus = False
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUploadAttachment, Me.mnuOpenAttachment, Me.mnuDeleteAttachment})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 70)
        '
        'mnuUploadAttachment
        '
        Me.mnuUploadAttachment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUploadAttachment.Image = Global.IsoDoc.My.Resources.Resources.attachment
        Me.mnuUploadAttachment.Name = "mnuUploadAttachment"
        Me.mnuUploadAttachment.Size = New System.Drawing.Size(165, 22)
        Me.mnuUploadAttachment.Text = "آپلود فایل پیوست"
        '
        'mnuOpenAttachment
        '
        Me.mnuOpenAttachment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuOpenAttachment.Image = Global.IsoDoc.My.Resources.Resources.Download
        Me.mnuOpenAttachment.Name = "mnuOpenAttachment"
        Me.mnuOpenAttachment.Size = New System.Drawing.Size(165, 22)
        Me.mnuOpenAttachment.Text = "دانلود فایل پیوست"
        '
        'mnuDeleteAttachment
        '
        Me.mnuDeleteAttachment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDeleteAttachment.Image = Global.IsoDoc.My.Resources.Resources.DeleteLarge
        Me.mnuDeleteAttachment.Name = "mnuDeleteAttachment"
        Me.mnuDeleteAttachment.Size = New System.Drawing.Size(165, 22)
        Me.mnuDeleteAttachment.Text = "حذف فایل پیوست"
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
        Me.Text = "مدیریت درخواست ها"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbDocTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDocOwnerDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttachFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDocRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChanges As TextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Private WithEvents cmbDocTitle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Active As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNewDocTitle As TextBox
    Friend WithEvents cmbReqTypes As ComboBox
    Friend WithEvents f As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mnuUploadAttachment As ToolStripMenuItem
    Friend WithEvents mnuOpenAttachment As ToolStripMenuItem
    Friend WithEvents mnuDeleteAttachment As ToolStripMenuItem
    Friend WithEvents FileExtension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RowNumber As DevExpress.XtraGrid.Columns.GridColumn
End Class
