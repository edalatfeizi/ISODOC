namespace IsoDocApp.ManageDocRequests
{
    partial class FrmConfirmNewDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmNewDoc));
            this.progressBar = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teAcceptor = new DevExpress.XtraEditors.TokenEdit();
            this.teConfirmers = new DevExpress.XtraEditors.TokenEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.txtEditOrReviewNo = new DevExpress.XtraEditors.TextEdit();
            this.teCreators = new DevExpress.XtraEditors.TokenEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pbAttachFile = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teAcceptor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOrReviewNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCreators.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttachFile.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.progressBar.Size = new System.Drawing.Size(713, 14);
            this.progressBar.TabIndex = 31;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.labelControl3);
            this.panel.Controls.Add(this.teAcceptor);
            this.panel.Controls.Add(this.teConfirmers);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Controls.Add(this.memoEdit1);
            this.panel.Controls.Add(this.txtEditOrReviewNo);
            this.panel.Controls.Add(this.teCreators);
            this.panel.Controls.Add(this.labelControl9);
            this.panel.Controls.Add(this.pbAttachFile);
            this.panel.Controls.Add(this.labelControl4);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 14);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(713, 499);
            this.panel.TabIndex = 10;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(599, 412);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 24);
            this.labelControl3.TabIndex = 146;
            this.labelControl3.Text = "تصویب کننده:";
            // 
            // teAcceptor
            // 
            this.teAcceptor.Location = new System.Drawing.Point(314, 412);
            this.teAcceptor.Name = "teAcceptor";
            this.teAcceptor.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teAcceptor.Properties.Appearance.Options.UseFont = true;
            this.teAcceptor.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Regular;
            this.teAcceptor.Properties.PopupFilterMode = DevExpress.XtraEditors.TokenEditPopupFilterMode.Contains;
            this.teAcceptor.Properties.Separators.AddRange(new string[] {
            ","});
            this.teAcceptor.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("عدالت فیضی - کارشناس IT", "عدالت فیضی - کارشناس IT"));
            this.teAcceptor.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("مجتبی نوروزی", "مجتبی نوروزی"));
            this.teAcceptor.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("مجید کلانتری", "903015"));
            this.teAcceptor.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("ss", "ss"));
            this.teAcceptor.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("ff", "ff"));
            this.teAcceptor.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("vv", "vv"));
            this.teAcceptor.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("aa", "aa"));
            this.teAcceptor.Size = new System.Drawing.Size(269, 28);
            this.teAcceptor.TabIndex = 145;
            // 
            // teConfirmers
            // 
            this.teConfirmers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teConfirmers.Location = new System.Drawing.Point(314, 233);
            this.teConfirmers.Name = "teConfirmers";
            this.teConfirmers.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teConfirmers.Properties.Appearance.Options.UseFont = true;
            this.teConfirmers.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.TokenList;
            this.teConfirmers.Properties.MinRowCount = 4;
            this.teConfirmers.Properties.PopupFilterMode = DevExpress.XtraEditors.TokenEditPopupFilterMode.Contains;
            this.teConfirmers.Properties.Separators.AddRange(new string[] {
            ","});
            this.teConfirmers.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("عدالت فیضی - کارشناس IT", "عدالت فیضی - کارشناس IT"));
            this.teConfirmers.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("مجتبی نوروزی", "مجتبی نوروزی"));
            this.teConfirmers.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("مجید کلانتری", "903015"));
            this.teConfirmers.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("هومن امیدوار خمیران - مدیر فروش", "هومن امیدوار خمیران - مدیر فروش"));
            this.teConfirmers.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("غریب رضا براری نیا خلیل - جانشین مدیر منابع انسانی", "غریب رضا براری نیا خلیل - جانشین مدیر منابع انسانی"));
            this.teConfirmers.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("سامان براری تازه آبادی - جانشین مدیر سیستم ها و انفورماتیک", "سامان براری تازه آبادی - جانشین مدیر سیستم ها و انفورماتیک"));
            this.teConfirmers.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("جعفر نویدی علویان - مدیر تعمیرات و نگهداری", "جعفر نویدی علویان - مدیر تعمیرات و نگهداری"));
            this.teConfirmers.Size = new System.Drawing.Size(269, 103);
            this.teConfirmers.TabIndex = 144;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(599, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 24);
            this.labelControl2.TabIndex = 143;
            this.labelControl2.Text = "شرح بازنگری:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = "";
            this.memoEdit1.Location = new System.Drawing.Point(314, 64);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.memoEdit1.Size = new System.Drawing.Size(269, 65);
            this.memoEdit1.TabIndex = 142;
            this.memoEdit1.Tag = "";
            // 
            // txtEditOrReviewNo
            // 
            this.txtEditOrReviewNo.EditValue = "";
            this.txtEditOrReviewNo.Location = new System.Drawing.Point(314, 11);
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
            this.txtEditOrReviewNo.Size = new System.Drawing.Size(269, 28);
            this.txtEditOrReviewNo.TabIndex = 141;
            // 
            // teCreators
            // 
            this.teCreators.EnterMoveNextControl = true;
            this.teCreators.Location = new System.Drawing.Point(314, 152);
            this.teCreators.Name = "teCreators";
            this.teCreators.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCreators.Properties.Appearance.Options.UseFont = true;
            this.teCreators.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Regular;
            this.teCreators.Properties.MinRowCount = 2;
            this.teCreators.Properties.PopupFilterMode = DevExpress.XtraEditors.TokenEditPopupFilterMode.Contains;
            this.teCreators.Properties.Separators.AddRange(new string[] {
            ","});
            this.teCreators.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("عدالت فیضی - کارشناس IT", "عدالت فیضی - کارشناس IT"));
            this.teCreators.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("مجتبی نوروزی", "مجتبی نوروزی"));
            this.teCreators.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("مجید کلانتری", "903015"));
            this.teCreators.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("سامان براری تازه آبادی - جانشین مدیر سیستم ها و انفورماتیک", "سامان براری تازه آبادی - جانشین مدیر سیستم ها و انفورماتیک"));
            this.teCreators.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("سید کمال علائی طباطبائی - مدیر مهندسی طراحی", "سید کمال علائی طباطبائی - مدیر مهندسی طراحی"));
            this.teCreators.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("جعفر نویدی علویان - مدیر تعمیرات و نگهداری", "جعفر نویدی علویان - مدیر تعمیرات و نگهداری"));
            this.teCreators.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("هومن امیدوار خمیران - مدیر فروش", "هومن امیدوار خمیران - مدیر فروش"));
            this.teCreators.Size = new System.Drawing.Size(269, 53);
            this.teCreators.TabIndex = 138;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(599, 152);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 24);
            this.labelControl9.TabIndex = 135;
            this.labelControl9.Text = "تهیه کنندگان:";
            // 
            // pbAttachFile
            // 
            this.pbAttachFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAttachFile.EditValue = ((object)(resources.GetObject("pbAttachFile.EditValue")));
            this.pbAttachFile.Location = new System.Drawing.Point(5, 12);
            this.pbAttachFile.Name = "pbAttachFile";
            this.pbAttachFile.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbAttachFile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pbAttachFile.Size = new System.Drawing.Size(277, 428);
            this.pbAttachFile.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(599, 245);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 24);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "تایید کنندگان:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(5, 446);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(276, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ثبت ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(599, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "شماره بازنگری:";
            // 
            // FrmConfirmNewDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 513);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.progressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfirmNewDoc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تایید سند جدید";
            this.Load += new System.EventHandler(this.FrmConfirmNewDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teAcceptor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOrReviewNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCreators.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttachFile.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PictureEdit pbAttachFile;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TokenEdit teCreators;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TokenEdit teAcceptor;
        private DevExpress.XtraEditors.TokenEdit teConfirmers;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        internal DevExpress.XtraEditors.TextEdit txtEditOrReviewNo;
    }
}