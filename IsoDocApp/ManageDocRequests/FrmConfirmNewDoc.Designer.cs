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
            this.cmbDocs = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocCode = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridUsers = new DevExpress.XtraGrid.GridControl();
            this.grdUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.txtEditOrReviewNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbConfirmers = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCreators = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbAcceptors = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.cmbDocOwnerDep = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOrReviewNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConfirmers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCreators.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAcceptors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocOwnerDep.Properties)).BeginInit();
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
            this.progressBar.Size = new System.Drawing.Size(952, 15);
            this.progressBar.TabIndex = 31;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.gridUsers);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 15);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(952, 612);
            this.panel.TabIndex = 10;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // cmbDocs
            // 
            this.cmbDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDocs.Location = new System.Drawing.Point(71, 69);
            this.cmbDocs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.cmbDocs.TabIndex = 157;
            this.cmbDocs.EditValueChanged += new System.EventHandler(this.cmbDocs_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(434, 72);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 24);
            this.labelControl6.TabIndex = 156;
            this.labelControl6.Text = "انتخاب سند:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(434, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 24);
            this.labelControl5.TabIndex = 154;
            this.labelControl5.Text = "شماره سند:";
            // 
            // txtDocCode
            // 
            this.txtDocCode.EditValue = "";
            this.txtDocCode.Enabled = false;
            this.txtDocCode.Location = new System.Drawing.Point(71, 114);
            this.txtDocCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocCode.Name = "txtDocCode";
            this.txtDocCode.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocCode.Properties.Appearance.Options.UseFont = true;
            this.txtDocCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDocCode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtDocCode.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDocCode.Properties.MaskSettings.Set("mask", "d");
            this.txtDocCode.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.txtDocCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDocCode.Size = new System.Drawing.Size(347, 28);
            this.txtDocCode.TabIndex = 155;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(13, 540);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(388, 54);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ثبت ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridUsers
            // 
            this.gridUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridUsers.Location = new System.Drawing.Point(12, 12);
            this.gridUsers.MainView = this.grdUsers;
            this.gridUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.Size = new System.Drawing.Size(388, 521);
            this.gridUsers.TabIndex = 148;
            this.gridUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUsers});
            // 
            // grdUsers
            // 
            this.grdUsers.DetailHeight = 512;
            this.grdUsers.GridControl = this.gridUsers;
            this.grdUsers.Name = "grdUsers";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(434, 162);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "شماره بازنگری:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = "";
            this.memoEdit1.Location = new System.Drawing.Point(69, 218);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.memoEdit1.Size = new System.Drawing.Size(347, 167);
            this.memoEdit1.TabIndex = 142;
            this.memoEdit1.Tag = "";
            // 
            // txtEditOrReviewNo
            // 
            this.txtEditOrReviewNo.EditValue = "";
            this.txtEditOrReviewNo.Location = new System.Drawing.Point(71, 160);
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
            this.txtEditOrReviewNo.Size = new System.Drawing.Size(347, 28);
            this.txtEditOrReviewNo.TabIndex = 141;
            // 
            // cmbConfirmers
            // 
            this.cmbConfirmers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbConfirmers.Location = new System.Drawing.Point(69, 458);
            this.cmbConfirmers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbConfirmers.Name = "cmbConfirmers";
            this.cmbConfirmers.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbConfirmers.Properties.Appearance.Options.UseFont = true;
            this.cmbConfirmers.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbConfirmers.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbConfirmers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbConfirmers.Properties.NullText = "";
            this.cmbConfirmers.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbConfirmers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbConfirmers.Size = new System.Drawing.Size(349, 28);
            this.cmbConfirmers.TabIndex = 152;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(432, 220);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 24);
            this.labelControl2.TabIndex = 143;
            this.labelControl2.Text = "شرح بازنگری:";
            // 
            // cmbCreators
            // 
            this.cmbCreators.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCreators.Location = new System.Drawing.Point(69, 406);
            this.cmbCreators.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCreators.Name = "cmbCreators";
            this.cmbCreators.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbCreators.Properties.Appearance.Options.UseFont = true;
            this.cmbCreators.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbCreators.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbCreators.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCreators.Properties.NullText = "";
            this.cmbCreators.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbCreators.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbCreators.Size = new System.Drawing.Size(349, 28);
            this.cmbCreators.TabIndex = 147;
            // 
            // cmbAcceptors
            // 
            this.cmbAcceptors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAcceptors.Location = new System.Drawing.Point(69, 507);
            this.cmbAcceptors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAcceptors.Name = "cmbAcceptors";
            this.cmbAcceptors.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbAcceptors.Properties.Appearance.Options.UseFont = true;
            this.cmbAcceptors.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.cmbAcceptors.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbAcceptors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAcceptors.Properties.NullText = "";
            this.cmbAcceptors.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbAcceptors.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbAcceptors.Size = new System.Drawing.Size(349, 28);
            this.cmbAcceptors.TabIndex = 150;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(428, 509);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 24);
            this.labelControl3.TabIndex = 146;
            this.labelControl3.Text = "تصویب کننده:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(428, 459);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 24);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "تایید کنندگان:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(428, 406);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 24);
            this.labelControl9.TabIndex = 135;
            this.labelControl9.Text = "تهیه کنندگان:";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(20, 399);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.AllowFocused = false;
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(43, 44);
            this.pictureEdit3.TabIndex = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDocOwnerDep);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.pictureEdit2);
            this.groupBox1.Controls.Add(this.pictureEdit1);
            this.groupBox1.Controls.Add(this.cmbDocs);
            this.groupBox1.Controls.Add(this.pictureEdit3);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.cmbAcceptors);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.cmbCreators);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtDocCode);
            this.groupBox1.Controls.Add(this.cmbConfirmers);
            this.groupBox1.Controls.Add(this.txtEditOrReviewNo);
            this.groupBox1.Controls.Add(this.memoEdit1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(407, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 592);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات سند جدید";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(20, 499);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(43, 44);
            this.pictureEdit1.TabIndex = 161;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(20, 449);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(43, 44);
            this.pictureEdit2.TabIndex = 162;
            // 
            // cmbDocOwnerDep
            // 
            this.cmbDocOwnerDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDocOwnerDep.Location = new System.Drawing.Point(71, 24);
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
            this.cmbDocOwnerDep.TabIndex = 165;
            this.cmbDocOwnerDep.EditValueChanged += new System.EventHandler(this.cmbDocOwnerDep_EditValueChanged_1);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(434, 28);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 24);
            this.labelControl7.TabIndex = 166;
            this.labelControl7.Text = "واحد متولی سند:";
            // 
            // FrmConfirmNewDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 627);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOrReviewNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConfirmers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCreators.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAcceptors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocOwnerDep.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        internal DevExpress.XtraEditors.TextEdit txtEditOrReviewNo;
        private DevExpress.XtraGrid.GridControl gridUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView grdUsers;
        private DevExpress.XtraEditors.LookUpEdit cmbCreators;
        private DevExpress.XtraEditors.LookUpEdit cmbConfirmers;
        private DevExpress.XtraEditors.LookUpEdit cmbAcceptors;
        private DevExpress.XtraEditors.LookUpEdit cmbDocs;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        internal DevExpress.XtraEditors.TextEdit txtDocCode;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit cmbDocOwnerDep;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}