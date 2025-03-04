namespace IsoDocApp.ManageDocRequests
{
    partial class FrmNewDocReq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDocReq));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewDocReqId = new DevExpress.XtraEditors.TextEdit();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.progressBar = new DevExpress.XtraWaitForm.ProgressPanel();
            this.cmbDocTypes = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDocs = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btnFileName = new DevExpress.XtraEditors.SimpleButton();
            this.btnAttachFile = new DevExpress.XtraEditors.SimpleButton();
            this.pbAttachFile = new DevExpress.XtraEditors.PictureEdit();
            this.txtReason = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtChanges = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKeepDurations = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.cmbDocOwnerDep = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbReqTypes = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbDeps = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewDocReqId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttachFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChanges.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKeepDurations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocOwnerDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReqTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDeps.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(6, 396);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(294, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ثبت درخواست";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(764, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "شماره درخواست:";
            // 
            // txtNewDocReqId
            // 
            this.txtNewDocReqId.EditValue = "1005";
            this.txtNewDocReqId.Enabled = false;
            this.txtNewDocReqId.Location = new System.Drawing.Point(584, 15);
            this.txtNewDocReqId.Name = "txtNewDocReqId";
            this.txtNewDocReqId.Properties.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNewDocReqId.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.txtNewDocReqId.Properties.Appearance.Options.UseBackColor = true;
            this.txtNewDocReqId.Properties.Appearance.Options.UseFont = true;
            this.txtNewDocReqId.Properties.ReadOnly = true;
            this.txtNewDocReqId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewDocReqId.Size = new System.Drawing.Size(107, 28);
            this.txtNewDocReqId.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.progressBar);
            this.panel.Controls.Add(this.cmbDocTypes);
            this.panel.Controls.Add(this.labelControl17);
            this.panel.Controls.Add(this.cmbDocs);
            this.panel.Controls.Add(this.labelControl15);
            this.panel.Controls.Add(this.btnFileName);
            this.panel.Controls.Add(this.btnAttachFile);
            this.panel.Controls.Add(this.pbAttachFile);
            this.panel.Controls.Add(this.txtReason);
            this.panel.Controls.Add(this.labelControl8);
            this.panel.Controls.Add(this.txtChanges);
            this.panel.Controls.Add(this.labelControl7);
            this.panel.Controls.Add(this.cmbKeepDurations);
            this.panel.Controls.Add(this.txtTitle);
            this.panel.Controls.Add(this.cmbDocOwnerDep);
            this.panel.Controls.Add(this.cmbReqTypes);
            this.panel.Controls.Add(this.cmbDeps);
            this.panel.Controls.Add(this.labelControl6);
            this.panel.Controls.Add(this.labelControl5);
            this.panel.Controls.Add(this.labelControl4);
            this.panel.Controls.Add(this.labelControl3);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Controls.Add(this.txtNewDocReqId);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(903, 465);
            this.panel.TabIndex = 9;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // progressBar
            // 
            this.progressBar.AnimationElementCount = 50;
            this.progressBar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.Appearance.Options.UseBackColor = true;
            this.progressBar.Appearance.Options.UseFont = true;
            this.progressBar.AppearanceCaption.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.progressBar.AppearanceCaption.Options.UseFont = true;
            this.progressBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressBar.Caption = "در حال دریافت اطلاعات";
            this.progressBar.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressBar.Description = "لطفا کمی صبر کنید...";
            this.progressBar.LineAnimationElementHeight = 5;
            this.progressBar.Location = new System.Drawing.Point(-12, -4);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.ShowCaption = false;
            this.progressBar.ShowDescription = false;
            this.progressBar.Size = new System.Drawing.Size(911, 14);
            this.progressBar.TabIndex = 31;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // cmbDocTypes
            // 
            this.cmbDocTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDocTypes.Enabled = false;
            this.cmbDocTypes.Location = new System.Drawing.Point(345, 226);
            this.cmbDocTypes.Name = "cmbDocTypes";
            this.cmbDocTypes.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDocTypes.Properties.Appearance.Options.UseFont = true;
            this.cmbDocTypes.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDocTypes.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbDocTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDocTypes.Properties.NullText = "";
            this.cmbDocTypes.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbDocTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbDocTypes.Size = new System.Drawing.Size(347, 28);
            this.cmbDocTypes.TabIndex = 7;
            this.cmbDocTypes.EditValueChanged += new System.EventHandler(this.cmbDocTypes_EditValueChanged);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(813, 229);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(46, 24);
            this.labelControl17.TabIndex = 131;
            this.labelControl17.Text = "نوع سند";
            // 
            // cmbDocs
            // 
            this.cmbDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDocs.Enabled = false;
            this.cmbDocs.Location = new System.Drawing.Point(344, 156);
            this.cmbDocs.Name = "cmbDocs";
            this.cmbDocs.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDocs.Properties.Appearance.Options.UseFont = true;
            this.cmbDocs.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDocs.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbDocs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDocs.Properties.NullText = "";
            this.cmbDocs.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbDocs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbDocs.Size = new System.Drawing.Size(347, 28);
            this.cmbDocs.TabIndex = 5;
            this.cmbDocs.EditValueChanged += new System.EventHandler(this.cmbDocs_EditValueChanged);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(793, 153);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(65, 24);
            this.labelControl15.TabIndex = 128;
            this.labelControl15.Text = "انتخاب سند";
            // 
            // btnFileName
            // 
            this.btnFileName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnFileName.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnFileName.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnFileName.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileName.Appearance.Options.UseBackColor = true;
            this.btnFileName.Appearance.Options.UseBorderColor = true;
            this.btnFileName.Appearance.Options.UseFont = true;
            this.btnFileName.Appearance.Options.UseTextOptions = true;
            this.btnFileName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnFileName.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFileName.Enabled = false;
            this.btnFileName.Location = new System.Drawing.Point(6, 286);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(294, 53);
            this.btnFileName.TabIndex = 127;
            this.btnFileName.Text = "نام فایل";
            this.btnFileName.Visible = false;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAttachFile.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnAttachFile.Appearance.Options.UseBackColor = true;
            this.btnAttachFile.Appearance.Options.UseFont = true;
            this.btnAttachFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttachFile.Enabled = false;
            this.btnAttachFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachFile.ImageOptions.Image")));
            this.btnAttachFile.Location = new System.Drawing.Point(6, 345);
            this.btnAttachFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(294, 45);
            this.btnAttachFile.TabIndex = 25;
            this.btnAttachFile.Text = "پیوست فایل";
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // pbAttachFile
            // 
            this.pbAttachFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAttachFile.EditValue = ((object)(resources.GetObject("pbAttachFile.EditValue")));
            this.pbAttachFile.Enabled = false;
            this.pbAttachFile.Location = new System.Drawing.Point(6, 53);
            this.pbAttachFile.Name = "pbAttachFile";
            this.pbAttachFile.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbAttachFile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pbAttachFile.Size = new System.Drawing.Size(294, 286);
            this.pbAttachFile.TabIndex = 24;
            this.pbAttachFile.Click += new System.EventHandler(this.pbAttachFile_Click);
            // 
            // txtReason
            // 
            this.txtReason.EditValue = "";
            this.txtReason.Enabled = false;
            this.txtReason.Location = new System.Drawing.Point(344, 367);
            this.txtReason.Name = "txtReason";
            this.txtReason.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.txtReason.Properties.Appearance.Options.UseFont = true;
            this.txtReason.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtReason.Size = new System.Drawing.Size(347, 74);
            this.txtReason.TabIndex = 10;
            this.txtReason.Tag = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(702, 368);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(156, 24);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "علت تغییر/حذف/ایجاد سند:";
            // 
            // txtChanges
            // 
            this.txtChanges.EditValue = "";
            this.txtChanges.Enabled = false;
            this.txtChanges.Location = new System.Drawing.Point(344, 292);
            this.txtChanges.Name = "txtChanges";
            this.txtChanges.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.txtChanges.Properties.Appearance.Options.UseFont = true;
            this.txtChanges.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtChanges.Size = new System.Drawing.Size(347, 71);
            this.txtChanges.TabIndex = 9;
            this.txtChanges.Tag = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(782, 293);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 24);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "شرح تغییرات:";
            // 
            // cmbKeepDurations
            // 
            this.cmbKeepDurations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbKeepDurations.Enabled = false;
            this.cmbKeepDurations.Location = new System.Drawing.Point(344, 260);
            this.cmbKeepDurations.Name = "cmbKeepDurations";
            this.cmbKeepDurations.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbKeepDurations.Properties.Appearance.Options.UseFont = true;
            this.cmbKeepDurations.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbKeepDurations.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbKeepDurations.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKeepDurations.Properties.NullText = "";
            this.cmbKeepDurations.Size = new System.Drawing.Size(347, 28);
            this.cmbKeepDurations.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.EditValue = "";
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(344, 191);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.txtTitle.Properties.Appearance.Options.UseFont = true;
            this.txtTitle.Size = new System.Drawing.Size(347, 28);
            this.txtTitle.TabIndex = 6;
            // 
            // cmbDocOwnerDep
            // 
            this.cmbDocOwnerDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDocOwnerDep.Enabled = false;
            this.cmbDocOwnerDep.Location = new System.Drawing.Point(344, 122);
            this.cmbDocOwnerDep.Name = "cmbDocOwnerDep";
            this.cmbDocOwnerDep.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDocOwnerDep.Properties.Appearance.Options.UseFont = true;
            this.cmbDocOwnerDep.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDocOwnerDep.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbDocOwnerDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDocOwnerDep.Properties.NullText = "";
            this.cmbDocOwnerDep.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbDocOwnerDep.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbDocOwnerDep.Size = new System.Drawing.Size(347, 28);
            this.cmbDocOwnerDep.TabIndex = 4;
            this.cmbDocOwnerDep.EditValueChanged += new System.EventHandler(this.cmbDocOwnerDep_EditValueChanged);
            // 
            // cmbReqTypes
            // 
            this.cmbReqTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReqTypes.Location = new System.Drawing.Point(344, 86);
            this.cmbReqTypes.Name = "cmbReqTypes";
            this.cmbReqTypes.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbReqTypes.Properties.Appearance.Options.UseFont = true;
            this.cmbReqTypes.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbReqTypes.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbReqTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbReqTypes.Properties.NullText = "";
            this.cmbReqTypes.Size = new System.Drawing.Size(347, 28);
            this.cmbReqTypes.TabIndex = 3;
            this.cmbReqTypes.EditValueChanged += new System.EventHandler(this.cmbReqTypes_EditValueChanged);
            // 
            // cmbDeps
            // 
            this.cmbDeps.Enabled = false;
            this.cmbDeps.Location = new System.Drawing.Point(344, 49);
            this.cmbDeps.Name = "cmbDeps";
            this.cmbDeps.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDeps.Properties.Appearance.Options.UseFont = true;
            this.cmbDeps.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbDeps.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbDeps.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDeps.Properties.NullText = "انتخاب واحد";
            this.cmbDeps.Size = new System.Drawing.Size(347, 28);
            this.cmbDeps.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(798, 192);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 24);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "عنوان سند:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(727, 261);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(132, 24);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "مدت زمان نگهداری سند:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(768, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 24);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "واحد متولی سند:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(779, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 24);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "نوع درخواست:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(739, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "واحد درخواست کننده:";
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "336d853b-db33-40b1-b4d4-6bb2b17cc2b8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("2ac05d1e-a6ac-4d98-8785-94f8fb42de06", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "عملیات موفقیت آمیز", "ثبت درخواست جدید با موفقیت انجام شد.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // FrmNewDocReq
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 480);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmNewDocReq.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 512);
            this.Name = "FrmNewDocReq";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت درخواست جدید";
            this.Load += new System.EventHandler(this.FrmNewDocReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewDocReqId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttachFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChanges.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKeepDurations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocOwnerDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReqTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDeps.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNewDocReqId;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbKeepDurations;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LookUpEdit cmbDocOwnerDep;
        private DevExpress.XtraEditors.LookUpEdit cmbReqTypes;
        private DevExpress.XtraEditors.LookUpEdit cmbDeps;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit txtChanges;
        private DevExpress.XtraEditors.MemoEdit txtReason;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PictureEdit pbAttachFile;
        private DevExpress.XtraEditors.SimpleButton btnAttachFile;
        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        internal DevExpress.XtraEditors.SimpleButton btnFileName;
        private DevExpress.XtraEditors.LookUpEdit cmbDocs;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.LookUpEdit cmbDocTypes;
        private DevExpress.XtraEditors.LabelControl labelControl17;
    }
}