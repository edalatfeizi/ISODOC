namespace IsoDocApp.ManageDocRequests
{
    partial class FrmForwardDocReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForwardDocReq));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grpEditOrReview = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditOrReviewNo = new DevExpress.XtraEditors.TextEdit();
            this.rdbWithEdit = new System.Windows.Forms.RadioButton();
            this.rdbWithReview = new System.Windows.Forms.RadioButton();
            this.progressBar = new DevExpress.XtraWaitForm.ProgressPanel();
            this.txtDocReqStepDesc = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUserColleagues = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocReqId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.docReqSteps = new DevExpress.XtraEditors.StepProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.grpEditOrReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOrReviewNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocReqStepDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserColleagues.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocReqId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docReqSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(20, 437);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(329, 45);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "ثبت ارجاع";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.grpEditOrReview);
            this.panelControl1.Controls.Add(this.progressBar);
            this.panelControl1.Controls.Add(this.txtDocReqStepDesc);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cmbUserColleagues);
            this.panelControl1.Controls.Add(this.labelControl17);
            this.panelControl1.Controls.Add(this.txtDocReqId);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(316, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(482, 550);
            this.panelControl1.TabIndex = 27;
            // 
            // grpEditOrReview
            // 
            this.grpEditOrReview.Controls.Add(this.labelControl2);
            this.grpEditOrReview.Controls.Add(this.txtEditOrReviewNo);
            this.grpEditOrReview.Controls.Add(this.rdbWithEdit);
            this.grpEditOrReview.Controls.Add(this.rdbWithReview);
            this.grpEditOrReview.Enabled = false;
            this.grpEditOrReview.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditOrReview.Location = new System.Drawing.Point(20, 297);
            this.grpEditOrReview.Name = "grpEditOrReview";
            this.grpEditOrReview.Size = new System.Drawing.Size(329, 125);
            this.grpEditOrReview.TabIndex = 139;
            this.grpEditOrReview.TabStop = false;
            this.grpEditOrReview.Text = "ویرایش/بازنگری";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(198, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 24);
            this.labelControl2.TabIndex = 140;
            this.labelControl2.Text = "شماره ویرایش/بازنگری:";
            // 
            // txtEditOrReviewNo
            // 
            this.txtEditOrReviewNo.EditValue = "";
            this.txtEditOrReviewNo.Location = new System.Drawing.Point(45, 81);
            this.txtEditOrReviewNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditOrReviewNo.Name = "txtEditOrReviewNo";
            this.txtEditOrReviewNo.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditOrReviewNo.Properties.Appearance.Options.UseFont = true;
            this.txtEditOrReviewNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEditOrReviewNo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtEditOrReviewNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtEditOrReviewNo.Properties.MaskSettings.Set("mask", "d");
            this.txtEditOrReviewNo.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.txtEditOrReviewNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEditOrReviewNo.Size = new System.Drawing.Size(147, 28);
            this.txtEditOrReviewNo.TabIndex = 140;
            // 
            // rdbWithEdit
            // 
            this.rdbWithEdit.AutoSize = true;
            this.rdbWithEdit.BackColor = System.Drawing.Color.Transparent;
            this.rdbWithEdit.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWithEdit.Location = new System.Drawing.Point(66, 36);
            this.rdbWithEdit.Name = "rdbWithEdit";
            this.rdbWithEdit.Size = new System.Drawing.Size(126, 25);
            this.rdbWithEdit.TabIndex = 139;
            this.rdbWithEdit.TabStop = true;
            this.rdbWithEdit.Text = "با ویرایش انجام شود";
            this.rdbWithEdit.UseVisualStyleBackColor = false;
            this.rdbWithEdit.CheckedChanged += new System.EventHandler(this.rdbWithEdit_CheckedChanged);
            // 
            // rdbWithReview
            // 
            this.rdbWithReview.AutoSize = true;
            this.rdbWithReview.BackColor = System.Drawing.Color.Transparent;
            this.rdbWithReview.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWithReview.Location = new System.Drawing.Point(199, 36);
            this.rdbWithReview.Name = "rdbWithReview";
            this.rdbWithReview.Size = new System.Drawing.Size(124, 25);
            this.rdbWithReview.TabIndex = 138;
            this.rdbWithReview.TabStop = true;
            this.rdbWithReview.Text = "با بازنگری انجام شود";
            this.rdbWithReview.UseVisualStyleBackColor = false;
            this.rdbWithReview.CheckedChanged += new System.EventHandler(this.rdbWithReview_CheckedChanged);
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
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.LineAnimationElementHeight = 5;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.ShowCaption = false;
            this.progressBar.ShowDescription = false;
            this.progressBar.Size = new System.Drawing.Size(482, 14);
            this.progressBar.TabIndex = 136;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // txtDocReqStepDesc
            // 
            this.txtDocReqStepDesc.EditValue = "";
            this.txtDocReqStepDesc.Location = new System.Drawing.Point(20, 130);
            this.txtDocReqStepDesc.Name = "txtDocReqStepDesc";
            this.txtDocReqStepDesc.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.txtDocReqStepDesc.Properties.Appearance.Options.UseFont = true;
            this.txtDocReqStepDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDocReqStepDesc.Size = new System.Drawing.Size(329, 161);
            this.txtDocReqStepDesc.TabIndex = 134;
            this.txtDocReqStepDesc.Tag = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(399, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 24);
            this.labelControl7.TabIndex = 135;
            this.labelControl7.Text = "شرح ارجاع:";
            // 
            // cmbUserColleagues
            // 
            this.cmbUserColleagues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUserColleagues.Location = new System.Drawing.Point(20, 76);
            this.cmbUserColleagues.Name = "cmbUserColleagues";
            this.cmbUserColleagues.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbUserColleagues.Properties.Appearance.Options.UseFont = true;
            this.cmbUserColleagues.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbUserColleagues.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbUserColleagues.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserColleagues.Properties.NullText = "";
            this.cmbUserColleagues.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbUserColleagues.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbUserColleagues.Size = new System.Drawing.Size(329, 28);
            this.cmbUserColleagues.TabIndex = 132;
            this.cmbUserColleagues.EditValueChanged += new System.EventHandler(this.cmbUserColleagues_EditValueChanged);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(390, 79);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(70, 24);
            this.labelControl17.TabIndex = 133;
            this.labelControl17.Text = "گیرنده ارجاع:";
            // 
            // txtDocReqId
            // 
            this.txtDocReqId.EditValue = "1005";
            this.txtDocReqId.Enabled = false;
            this.txtDocReqId.Location = new System.Drawing.Point(20, 28);
            this.txtDocReqId.Name = "txtDocReqId";
            this.txtDocReqId.Properties.Appearance.BackColor = System.Drawing.Color.FloralWhite;
            this.txtDocReqId.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.txtDocReqId.Properties.Appearance.Options.UseBackColor = true;
            this.txtDocReqId.Properties.Appearance.Options.UseFont = true;
            this.txtDocReqId.Properties.ReadOnly = true;
            this.txtDocReqId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDocReqId.Size = new System.Drawing.Size(329, 28);
            this.txtDocReqId.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(365, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 24);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "شماره درخواست:";
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "336d853b-db33-40b1-b4d4-6bb2b17cc2b8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("bba561b0-42d8-408b-9c05-85d9d87f4052", null, "ارجاع درخواست", "ثبت ارجاع درخواست با موفقیت انجام شد.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01)});
            // 
            // docReqSteps
            // 
            this.docReqSteps.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            this.docReqSteps.Appearances.CommonActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.docReqSteps.Appearances.CommonInactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.docReqSteps.Appearances.FirstContentBlockAppearance.Caption.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.Caption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.CaptionActive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.CaptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.CaptionInactive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.CaptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.Description.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.Description.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.DescriptionActive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.DescriptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.DescriptionInactive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.FirstContentBlockAppearance.DescriptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Options.UseFont = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Caption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionActive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionInactive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseFont = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.docReqSteps.ItemOptions.Indicator.ActiveStateImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("docReqSteps.ItemOptions.Indicator.ActiveStateImageOptions.Image")));
            this.docReqSteps.Location = new System.Drawing.Point(0, 0);
            this.docReqSteps.Name = "docReqSteps";
            this.docReqSteps.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.docReqSteps.Size = new System.Drawing.Size(316, 550);
            this.docReqSteps.TabIndex = 26;
            // 
            // FrmForwardDocReq
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 550);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.docReqSteps);
            this.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmForwardDocReq.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 582);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 582);
            this.Name = "FrmForwardDocReq";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ارجاع درخواست";
            this.Load += new System.EventHandler(this.FrmForwardDocReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.grpEditOrReview.ResumeLayout(false);
            this.grpEditOrReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOrReviewNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocReqStepDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserColleagues.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocReqId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docReqSteps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtDocReqId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbUserColleagues;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.MemoEdit txtDocReqStepDesc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.StepProgressBar docReqSteps;
        private System.Windows.Forms.RadioButton rdbWithReview;
        private System.Windows.Forms.GroupBox grpEditOrReview;
        private System.Windows.Forms.RadioButton rdbWithEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        internal DevExpress.XtraEditors.TextEdit txtEditOrReviewNo;
    }
}