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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageDocReqs));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabMyRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabReferredRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.docReqSteps = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem11 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem12 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem13 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem14 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem15 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem16 = new DevExpress.XtraEditors.StepProgressBarItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docReqSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserDocRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.tabMyRequests,
            this.ribbonPage1});
            this.ribbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Right;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(1192, 173);
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
            // tabMyRequests
            // 
            this.tabMyRequests.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.tabMyRequests.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabMyRequests.ImageOptions.SvgImage")));
            this.tabMyRequests.Name = "tabMyRequests";
            this.tabMyRequests.Text = "درخواست های من";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage1.ImageOptions.SvgImage")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "درخواست های ارجاع شده";
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
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Caption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionActive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionInactive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.CaptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.Description.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.Options.UseTextOptions = true;
            this.docReqSteps.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.docReqSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.docReqSteps.ItemOptions.Indicator.ActiveStateImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stepProgressBar1.ItemOptions.Indicator.ActiveStateImageOptions.Image")));
            this.docReqSteps.Items.Add(this.stepProgressBarItem1);
            this.docReqSteps.Items.Add(this.stepProgressBarItem2);
            this.docReqSteps.Items.Add(this.stepProgressBarItem11);
            this.docReqSteps.Items.Add(this.stepProgressBarItem12);
            this.docReqSteps.Items.Add(this.stepProgressBarItem13);
            this.docReqSteps.Items.Add(this.stepProgressBarItem14);
            this.docReqSteps.Items.Add(this.stepProgressBarItem15);
            this.docReqSteps.Items.Add(this.stepProgressBarItem16);
            this.docReqSteps.Location = new System.Drawing.Point(0, 173);
            this.docReqSteps.Name = "docReqSteps";
            this.docReqSteps.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.docReqSteps.SelectedItemIndex = 1;
            this.docReqSteps.Size = new System.Drawing.Size(382, 565);
            this.docReqSteps.TabIndex = 3;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.Appearance.ActiveIndicatorColor = System.Drawing.Color.Transparent;
            this.stepProgressBarItem1.ContentBlock2.Appearance.Caption.Options.UseTextOptions = true;
            this.stepProgressBarItem1.ContentBlock2.Appearance.Caption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.stepProgressBarItem1.ContentBlock2.Caption = "عدالت فیضی - مسئول تحلیل و آنالیز سیستم های اطلاعاتی";
            this.stepProgressBarItem1.ContentBlock2.Description = "درخواست تغییر سند  برای واحد مدیریت  حراست با عنوان : ورود اماني كالا به كارخانه";
            this.stepProgressBarItem1.ContentBlock2.InactiveStateImageOptions.ImageUri.Uri = "ExportToDOCX";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            this.stepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.ContentBlock2.Caption = "محسن آزادفلاح - رئیس مهندسی  سیستم های اطلاعاتی";
            this.stepProgressBarItem2.ContentBlock2.Description = "درخواست ایجاد سند جدید برای واحد مدیریت  مهندسی طراحی با عنوان : 2222";
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            this.stepProgressBarItem2.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem11
            // 
            this.stepProgressBarItem11.ContentBlock2.Caption = "سامان براری - مدیر سیستم ها و انفورماتیک";
            this.stepProgressBarItem11.ContentBlock2.Description = "تغییر سند مورد تایید این واحد می باشد";
            this.stepProgressBarItem11.Name = "stepProgressBarItem11";
            // 
            // stepProgressBarItem12
            // 
            this.stepProgressBarItem12.ContentBlock2.Caption = "Item12";
            this.stepProgressBarItem12.Name = "stepProgressBarItem12";
            // 
            // stepProgressBarItem13
            // 
            this.stepProgressBarItem13.ContentBlock2.Caption = "Item13";
            this.stepProgressBarItem13.Name = "stepProgressBarItem13";
            // 
            // stepProgressBarItem14
            // 
            this.stepProgressBarItem14.ContentBlock2.Caption = "Item14";
            this.stepProgressBarItem14.Name = "stepProgressBarItem14";
            // 
            // stepProgressBarItem15
            // 
            this.stepProgressBarItem15.ContentBlock2.Caption = "Item15";
            this.stepProgressBarItem15.Name = "stepProgressBarItem15";
            // 
            // stepProgressBarItem16
            // 
            this.stepProgressBarItem16.ContentBlock2.Caption = "Item16";
            this.stepProgressBarItem16.Name = "stepProgressBarItem16";
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
            this.grdUserDocRequests.Location = new System.Drawing.Point(382, 173);
            this.grdUserDocRequests.MainView = this.gridView1;
            this.grdUserDocRequests.MenuManager = this.ribbonControl1;
            this.grdUserDocRequests.Name = "grdUserDocRequests";
            this.grdUserDocRequests.Size = new System.Drawing.Size(810, 565);
            this.grdUserDocRequests.TabIndex = 5;
            this.grdUserDocRequests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.grdUserDocRequests;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            this.progressBar.Location = new System.Drawing.Point(382, 173);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.ShowCaption = false;
            this.progressBar.ShowDescription = false;
            this.progressBar.Size = new System.Drawing.Size(810, 14);
            this.progressBar.TabIndex = 32;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // FrmManageDocReqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 738);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grdUserDocRequests);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabMyRequests;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabReferredRequests;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.XtraEditors.StepProgressBar docReqSteps;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem4;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem5;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem6;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem7;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem8;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem9;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem10;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem11;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem12;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem13;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem14;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem15;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem16;
        private DevExpress.XtraGrid.GridControl grdUserDocRequests;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
    }
}

