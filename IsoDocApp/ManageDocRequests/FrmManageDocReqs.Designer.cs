namespace IsoDocApp
{
    partial class FrmManageDocReqs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageDocReqs));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabSentRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabReceivedRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabForwardedDocRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabAllDocRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabDeletedRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabReferredRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.docReqSteps = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem4 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem5 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem6 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem7 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem8 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem9 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem10 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.grdUserDocRequests = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.progressBar = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnForwardDocReq = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowAttachments = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCompleteReq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelReq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteReq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnableReq = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docReqSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserDocRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(30, 44, 30, 44);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tabSentRequests,
            this.tabReceivedRequests,
            this.tabForwardedDocRequests,
            this.tabAllDocRequests,
            this.tabDeletedRequests});
            this.ribbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Right;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(1192, 173);
            this.ribbonControl1.SelectedPageChanged += new System.EventHandler(this.ribbonControl1_SelectedPageChanged);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ثبت درخواست جدید";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // tabSentRequests
            // 
            this.tabSentRequests.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.tabSentRequests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabSentRequests.ImageOptions.Image")));
            this.tabSentRequests.Name = "tabSentRequests";
            this.tabSentRequests.Text = "درخواست های من";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // tabReceivedRequests
            // 
            this.tabReceivedRequests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabReceivedRequests.ImageOptions.Image")));
            this.tabReceivedRequests.Name = "tabReceivedRequests";
            this.tabReceivedRequests.Text = "درخواست های دریافتی";
            // 
            // tabForwardedDocRequests
            // 
            this.tabForwardedDocRequests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabForwardedDocRequests.ImageOptions.Image")));
            this.tabForwardedDocRequests.Name = "tabForwardedDocRequests";
            this.tabForwardedDocRequests.Text = "درخواست های ارجاع شده";
            // 
            // tabAllDocRequests
            // 
            this.tabAllDocRequests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabAllDocRequests.ImageOptions.Image")));
            this.tabAllDocRequests.Name = "tabAllDocRequests";
            this.tabAllDocRequests.Text = "همه درخواست ها";
            // 
            // tabDeletedRequests
            // 
            this.tabDeletedRequests.Name = "tabDeletedRequests";
            this.tabDeletedRequests.Text = "درخواست های حذف شده";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // tabReferredRequests
            // 
            this.tabReferredRequests.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.tabReferredRequests.Name = "tabReferredRequests";
            this.tabReferredRequests.Text = "درخواست های ارجاع داده شده";
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "treeListBand1";
            this.treeListBand1.Name = "treeListBand1";
            // 
            // treeListBand2
            // 
            this.treeListBand2.Caption = "treeListBand2";
            this.treeListBand2.Name = "treeListBand2";
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
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseFont = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.docReqSteps.ItemOptions.Indicator.ActiveStateImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("docReqSteps.ItemOptions.Indicator.ActiveStateImageOptions.Image")));
            this.docReqSteps.Location = new System.Drawing.Point(0, 173);
            this.docReqSteps.Name = "docReqSteps";
            this.docReqSteps.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.docReqSteps.Size = new System.Drawing.Size(382, 565);
            this.docReqSteps.TabIndex = 3;
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem3.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem3.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem3.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem3.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            // 
            // stepProgressBarItem4
            // 
            this.stepProgressBarItem4.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem4.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem4.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem4.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem4.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem4.Name = "stepProgressBarItem4";
            // 
            // stepProgressBarItem5
            // 
            this.stepProgressBarItem5.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem5.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem5.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem5.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem5.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem5.Name = "stepProgressBarItem5";
            // 
            // stepProgressBarItem6
            // 
            this.stepProgressBarItem6.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem6.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem6.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem6.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem6.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem6.Name = "stepProgressBarItem6";
            // 
            // stepProgressBarItem7
            // 
            this.stepProgressBarItem7.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem7.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem7.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem7.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem7.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem7.Name = "stepProgressBarItem7";
            // 
            // stepProgressBarItem8
            // 
            this.stepProgressBarItem8.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem8.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem8.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem8.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem8.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem8.Name = "stepProgressBarItem8";
            // 
            // stepProgressBarItem9
            // 
            this.stepProgressBarItem9.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem9.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem9.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem9.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem9.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem9.Name = "stepProgressBarItem9";
            // 
            // stepProgressBarItem10
            // 
            this.stepProgressBarItem10.ContentBlock1.ActiveStateImageOptions.SvgImage = global::IsoDocApp.Properties.Resources.actions_checkcircled;
            this.stepProgressBarItem10.ContentBlock1.Caption = "تست 1";
            this.stepProgressBarItem10.ContentBlock1.Description = "تست 1";
            this.stepProgressBarItem10.ContentBlock2.Caption = "تست 3";
            this.stepProgressBarItem10.ContentBlock2.Description = "تست 4";
            this.stepProgressBarItem10.Name = "stepProgressBarItem10";
            // 
            // grdUserDocRequests
            // 
            this.grdUserDocRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUserDocRequests.Location = new System.Drawing.Point(0, 0);
            this.grdUserDocRequests.MainView = this.gridView1;
            this.grdUserDocRequests.MenuManager = this.ribbonControl1;
            this.grdUserDocRequests.Name = "grdUserDocRequests";
            this.grdUserDocRequests.Size = new System.Drawing.Size(810, 477);
            this.grdUserDocRequests.TabIndex = 5;
            this.grdUserDocRequests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.DetailHeight = 349;
            this.gridView1.GridControl = this.grdUserDocRequests;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.progressBar.Location = new System.Drawing.Point(262, 204);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(308, 58);
            this.progressBar.TabIndex = 32;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.progressBar);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(382, 173);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(810, 565);
            this.panelControl1.TabIndex = 34;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.grdUserDocRequests);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(810, 477);
            this.panelControl3.TabIndex = 33;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.textEdit4);
            this.panelControl4.Controls.Add(this.textEdit3);
            this.panelControl4.Controls.Add(this.textEdit2);
            this.panelControl4.Controls.Add(this.textEdit1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(810, 42);
            this.panelControl4.TabIndex = 6;
            // 
            // textEdit4
            // 
            this.textEdit4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit4.EditValue = "حذف شده";
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(43, 7);
            this.textEdit4.MenuManager = this.ribbonControl1;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.textEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit4.Size = new System.Drawing.Size(95, 24);
            this.textEdit4.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit3.EditValue = "لغو شده";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(226, 7);
            this.textEdit3.MenuManager = this.ribbonControl1;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit3.Size = new System.Drawing.Size(95, 24);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit2.EditValue = "تکمیل شده";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(428, 7);
            this.textEdit2.MenuManager = this.ribbonControl1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit2.Size = new System.Drawing.Size(95, 24);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit1.EditValue = "در حال انجام";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(606, 7);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gold;
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Size = new System.Drawing.Size(95, 24);
            this.textEdit1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnAddAttachment);
            this.panelControl2.Controls.Add(this.btnReload);
            this.panelControl2.Controls.Add(this.btnForwardDocReq);
            this.panelControl2.Controls.Add(this.btnShowAttachments);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 477);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(810, 88);
            this.panelControl2.TabIndex = 6;
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAttachment.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAttachment.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddAttachment.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttachment.Appearance.Options.UseBackColor = true;
            this.btnAddAttachment.Appearance.Options.UseBorderColor = true;
            this.btnAddAttachment.Appearance.Options.UseFont = true;
            this.btnAddAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAttachment.Enabled = false;
            this.btnAddAttachment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAttachment.ImageOptions.Image")));
            this.btnAddAttachment.Location = new System.Drawing.Point(206, 18);
            this.btnAddAttachment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(191, 66);
            this.btnAddAttachment.TabIndex = 15;
            this.btnAddAttachment.Text = "اضافه کردن فایل پیوست";
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReload.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Appearance.Options.UseBackColor = true;
            this.btnReload.Appearance.Options.UseFont = true;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Location = new System.Drawing.Point(7, 18);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(191, 66);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "بروزرسانی اطلاعات";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnForwardDocReq
            // 
            this.btnForwardDocReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForwardDocReq.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForwardDocReq.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForwardDocReq.Appearance.Options.UseBackColor = true;
            this.btnForwardDocReq.Appearance.Options.UseFont = true;
            this.btnForwardDocReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForwardDocReq.Enabled = false;
            this.btnForwardDocReq.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnForwardDocReq.ImageOptions.Image")));
            this.btnForwardDocReq.Location = new System.Drawing.Point(411, 18);
            this.btnForwardDocReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForwardDocReq.Name = "btnForwardDocReq";
            this.btnForwardDocReq.Size = new System.Drawing.Size(191, 66);
            this.btnForwardDocReq.TabIndex = 13;
            this.btnForwardDocReq.Text = "ارجاع درخواست";
            this.btnForwardDocReq.Click += new System.EventHandler(this.btnForwardDocReq_Click);
            // 
            // btnShowAttachments
            // 
            this.btnShowAttachments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAttachments.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowAttachments.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowAttachments.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAttachments.Appearance.Options.UseBackColor = true;
            this.btnShowAttachments.Appearance.Options.UseBorderColor = true;
            this.btnShowAttachments.Appearance.Options.UseFont = true;
            this.btnShowAttachments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAttachments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAttachments.ImageOptions.Image")));
            this.btnShowAttachments.Location = new System.Drawing.Point(615, 18);
            this.btnShowAttachments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAttachments.Name = "btnShowAttachments";
            this.btnShowAttachments.Size = new System.Drawing.Size(191, 66);
            this.btnShowAttachments.TabIndex = 12;
            this.btnShowAttachments.Text = "مشاهده فایل های پیوست";
            this.btnShowAttachments.Click += new System.EventHandler(this.btnDownloadAttachment_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "336d853b-db33-40b1-b4d4-6bb2b17cc2b8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("5064271b-6465-45af-93b2-6ba6b8d55777", null, "پیوست فایل جدید", "پیوست فایل جدید با موفقیت انجام شد", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01)});
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCompleteReq,
            this.mnuCancelReq,
            this.mnuDeleteReq,
            this.mnuEnableReq});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip2.Size = new System.Drawing.Size(180, 108);
            // 
            // mnuCompleteReq
            // 
            this.mnuCompleteReq.Enabled = false;
            this.mnuCompleteReq.Image = global::IsoDocApp.Properties.Resources.Yes;
            this.mnuCompleteReq.Name = "mnuCompleteReq";
            this.mnuCompleteReq.Size = new System.Drawing.Size(179, 26);
            this.mnuCompleteReq.Text = "تکمیل درخواست";
            this.mnuCompleteReq.Click += new System.EventHandler(this.mnuCompleteReq_Click);
            // 
            // mnuCancelReq
            // 
            this.mnuCancelReq.Enabled = false;
            this.mnuCancelReq.Image = global::IsoDocApp.Properties.Resources.No;
            this.mnuCancelReq.Name = "mnuCancelReq";
            this.mnuCancelReq.Size = new System.Drawing.Size(179, 26);
            this.mnuCancelReq.Text = "لغو درخواست";
            this.mnuCancelReq.Click += new System.EventHandler(this.mnuCancelReq_Click);
            // 
            // mnuDeleteReq
            // 
            this.mnuDeleteReq.Enabled = false;
            this.mnuDeleteReq.Image = global::IsoDocApp.Properties.Resources._1231;
            this.mnuDeleteReq.Name = "mnuDeleteReq";
            this.mnuDeleteReq.Size = new System.Drawing.Size(179, 26);
            this.mnuDeleteReq.Text = "حذف درخواست";
            this.mnuDeleteReq.Click += new System.EventHandler(this.mnuDeleteReq_Click);
            // 
            // mnuEnableReq
            // 
            this.mnuEnableReq.Enabled = false;
            this.mnuEnableReq.Image = global::IsoDocApp.Properties.Resources.CheckBox_32x32;
            this.mnuEnableReq.Name = "mnuEnableReq";
            this.mnuEnableReq.Size = new System.Drawing.Size(179, 26);
            this.mnuEnableReq.Text = "فعال کردن درخواست";
            this.mnuEnableReq.Click += new System.EventHandler(this.mnuEnableReq_Click);
            // 
            // FrmManageDocReqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 738);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.docReqSteps);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmManageDocReqs";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت درخواست ها";
            this.Load += new System.EventHandler(this.FrmManageDocReqs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docReqSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserDocRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabSentRequests;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabReceivedRequests;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabReferredRequests;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.XtraEditors.StepProgressBar docReqSteps;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem4;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem5;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem6;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem7;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem8;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem9;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem10;
        private DevExpress.XtraGrid.GridControl grdUserDocRequests;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.SimpleButton btnShowAttachments;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnForwardDocReq;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabForwardedDocRequests;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabAllDocRequests;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabDeletedRequests;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuCompleteReq;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelReq;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteReq;
        private System.Windows.Forms.ToolStripMenuItem mnuEnableReq;
        private DevExpress.XtraEditors.SimpleButton btnAddAttachment;
    }
}

