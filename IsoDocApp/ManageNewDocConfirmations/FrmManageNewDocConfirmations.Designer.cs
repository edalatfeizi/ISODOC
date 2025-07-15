namespace IsoDocApp.ManageDocRequests
{
    partial class FrmManageNewDocConfirmations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageNewDocConfirmations));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewDocReq = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirmNewDoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddNewConfirmDoc = new DevExpress.XtraBars.BarButtonItem();
            this.tabReceivedRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabAllRequests = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabNewDocConfirmation = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.panelStates = new DevExpress.XtraEditors.PanelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridDocConfirms = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelOperations = new DevExpress.XtraEditors.PanelControl();
            this.btnAddAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnForwardDocReq = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowAttachments = new DevExpress.XtraEditors.SimpleButton();
            this.loading = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.confirmationSigners = new DevExpress.XtraEditors.StepProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelStates)).BeginInit();
            this.panelStates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocConfirms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOperations)).BeginInit();
            this.panelOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmationSigners)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnNewDocReq,
            this.barButtonItem2,
            this.btnConfirmNewDoc,
            this.barButtonItem4,
            this.btnAddNewConfirmDoc});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tabReceivedRequests,
            this.tabAllRequests,
            this.tabNewDocConfirmation});
            this.ribbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Right;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(1297, 152);
            this.ribbonControl1.SelectedPageChanged += new System.EventHandler(this.ribbonControl1_SelectedPageChanged);
            // 
            // btnNewDocReq
            // 
            this.btnNewDocReq.Caption = " درخواست جدید";
            this.btnNewDocReq.Id = 5;
            this.btnNewDocReq.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewDocReq.ImageOptions.SvgImage")));
            this.btnNewDocReq.Name = "btnNewDocReq";
            this.btnNewDocReq.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "ثبت درخواست تایید سند";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnConfirmNewDoc
            // 
            this.btnConfirmNewDoc.Caption = "برگه ثبت و تنظیم سند";
            this.btnConfirmNewDoc.Enabled = false;
            this.btnConfirmNewDoc.Id = 7;
            this.btnConfirmNewDoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmNewDoc.ImageOptions.Image")));
            this.btnConfirmNewDoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmNewDoc.ImageOptions.LargeImage")));
            this.btnConfirmNewDoc.Name = "btnConfirmNewDoc";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnAddNewConfirmDoc
            // 
            this.btnAddNewConfirmDoc.Caption = "برگه ثبت و تنظیم سند جدید";
            this.btnAddNewConfirmDoc.Id = 10;
            this.btnAddNewConfirmDoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewConfirmDoc.ImageOptions.Image")));
            this.btnAddNewConfirmDoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewConfirmDoc.ImageOptions.LargeImage")));
            this.btnAddNewConfirmDoc.Name = "btnAddNewConfirmDoc";
            this.btnAddNewConfirmDoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNewConfirmDoc_ItemClick);
            // 
            // tabReceivedRequests
            // 
            this.tabReceivedRequests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabReceivedRequests.ImageOptions.Image")));
            this.tabReceivedRequests.Name = "tabReceivedRequests";
            this.tabReceivedRequests.Text = "درخواست های دریافتی";
            // 
            // tabAllRequests
            // 
            this.tabAllRequests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabAllRequests.ImageOptions.Image")));
            this.tabAllRequests.Name = "tabAllRequests";
            this.tabAllRequests.Text = "همه درخواست ها";
            // 
            // tabNewDocConfirmation
            // 
            this.tabNewDocConfirmation.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.tabNewDocConfirmation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNewDocConfirmation.ImageOptions.Image")));
            this.tabNewDocConfirmation.Name = "tabNewDocConfirmation";
            this.tabNewDocConfirmation.Text = "ثبت و تنظیم سند جدید";
            this.tabNewDocConfirmation.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAddNewConfirmDoc);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "برگه ثبت و تنظیم سند";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "برگه ثبت و تنظیم سند";
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = " درخواست جدید";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // panelStates
            // 
            this.panelStates.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelStates.Controls.Add(this.textEdit4);
            this.panelStates.Controls.Add(this.textEdit3);
            this.panelStates.Controls.Add(this.textEdit2);
            this.panelStates.Controls.Add(this.textEdit1);
            this.panelStates.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStates.Location = new System.Drawing.Point(382, 152);
            this.panelStates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStates.Name = "panelStates";
            this.panelStates.Size = new System.Drawing.Size(915, 29);
            this.panelStates.TabIndex = 12;
            // 
            // textEdit4
            // 
            this.textEdit4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit4.EditValue = "حذف شده";
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(95, 5);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit4.MenuManager = this.ribbonControl1;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.textEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit4.Size = new System.Drawing.Size(95, 18);
            this.textEdit4.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit3.EditValue = "لغو شده";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(278, 5);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit3.MenuManager = this.ribbonControl1;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit3.Size = new System.Drawing.Size(95, 18);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit2.EditValue = "تکمیل شده";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(480, 5);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.MenuManager = this.ribbonControl1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit2.Size = new System.Drawing.Size(95, 18);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit1.EditValue = "در حال بررسی";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(658, 5);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gold;
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Size = new System.Drawing.Size(95, 18);
            this.textEdit1.TabIndex = 0;
            // 
            // gridDocConfirms
            // 
            this.gridDocConfirms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDocConfirms.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridDocConfirms.Location = new System.Drawing.Point(382, 152);
            this.gridDocConfirms.MainView = this.gridView1;
            this.gridDocConfirms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridDocConfirms.MenuManager = this.ribbonControl1;
            this.gridDocConfirms.Name = "gridDocConfirms";
            this.gridDocConfirms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridDocConfirms.Size = new System.Drawing.Size(915, 429);
            this.gridDocConfirms.TabIndex = 11;
            this.gridDocConfirms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.DetailHeight = 239;
            this.gridView1.GridControl = this.gridDocConfirms;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(154, 8);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(98, 62);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panelOperations
            // 
            this.panelOperations.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelOperations.Appearance.Options.UseBackColor = true;
            this.panelOperations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelOperations.Controls.Add(this.btnAddAttachment);
            this.panelOperations.Controls.Add(this.btnReload);
            this.panelOperations.Controls.Add(this.btnForwardDocReq);
            this.panelOperations.Controls.Add(this.btnShowAttachments);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOperations.Location = new System.Drawing.Point(382, 581);
            this.panelOperations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(915, 60);
            this.panelOperations.TabIndex = 13;
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
            this.btnAddAttachment.Location = new System.Drawing.Point(258, 12);
            this.btnAddAttachment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(191, 45);
            this.btnAddAttachment.TabIndex = 15;
            this.btnAddAttachment.Text = "اضافه کردن فایل پیوست";
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
            this.btnReload.Location = new System.Drawing.Point(59, 12);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(191, 45);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "بروزرسانی اطلاعات";
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
            this.btnForwardDocReq.Location = new System.Drawing.Point(463, 12);
            this.btnForwardDocReq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnForwardDocReq.Name = "btnForwardDocReq";
            this.btnForwardDocReq.Size = new System.Drawing.Size(191, 45);
            this.btnForwardDocReq.TabIndex = 13;
            this.btnForwardDocReq.Text = "ارجاع درخواست";
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
            this.btnShowAttachments.Location = new System.Drawing.Point(667, 12);
            this.btnShowAttachments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowAttachments.Name = "btnShowAttachments";
            this.btnShowAttachments.Size = new System.Drawing.Size(191, 45);
            this.btnShowAttachments.TabIndex = 12;
            this.btnShowAttachments.Text = "مشاهده فایل های پیوست";
            // 
            // loading
            // 
            this.loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loading.Appearance.BackColor = System.Drawing.Color.White;
            this.loading.Appearance.Options.UseBackColor = true;
            this.loading.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.loading.Controls.Add(this.labelControl2);
            this.loading.Controls.Add(this.labelControl1);
            this.loading.Controls.Add(this.pictureEdit1);
            this.loading.Location = new System.Drawing.Point(498, 312);
            this.loading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(257, 81);
            this.loading.TabIndex = 14;
            this.loading.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(55, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "لطفا کمی صبر کنید ...";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "در حال دریافت اطلاعات";
            // 
            // confirmationSigners
            // 
            this.confirmationSigners.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            this.confirmationSigners.Appearances.CommonActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmationSigners.Appearances.CommonInactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.Caption.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.Caption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.CaptionActive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.CaptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.CaptionInactive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.CaptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.Description.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.Description.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.DescriptionActive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.DescriptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.DescriptionInactive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.FirstContentBlockAppearance.DescriptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Options.UseFont = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Caption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.CaptionActive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.CaptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.CaptionInactive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.CaptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Description.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseFont = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.Description.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.Options.UseTextOptions = true;
            this.confirmationSigners.Appearances.ItemAppearance.ContentBlockAppearance.DescriptionInactive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.confirmationSigners.Dock = System.Windows.Forms.DockStyle.Left;
            this.confirmationSigners.ItemOptions.Indicator.ActiveStateImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("confirmationSigners.ItemOptions.Indicator.ActiveStateImageOptions.Image")));
            this.confirmationSigners.Location = new System.Drawing.Point(0, 152);
            this.confirmationSigners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmationSigners.Name = "confirmationSigners";
            this.confirmationSigners.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.confirmationSigners.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.confirmationSigners.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmationSigners.Size = new System.Drawing.Size(382, 489);
            this.confirmationSigners.TabIndex = 10;
            // 
            // FrmManageNewDocConfirmations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 641);
            this.Controls.Add(this.panelStates);
            this.Controls.Add(this.gridDocConfirms);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.confirmationSigners);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManageNewDocConfirmations";
            this.Text = "تایید اسناد جدید";
            this.Load += new System.EventHandler(this.FrmManageNewDocConfirmations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelStates)).EndInit();
            this.panelStates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocConfirms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOperations)).EndInit();
            this.panelOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.loading.ResumeLayout(false);
            this.loading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmationSigners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnNewDocReq;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnConfirmNewDoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabReceivedRequests;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabNewDocConfirmation;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnAddNewConfirmDoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabAllRequests;
        private DevExpress.XtraEditors.PanelControl panelStates;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl gridDocConfirms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelOperations;
        private DevExpress.XtraEditors.SimpleButton btnAddAttachment;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnForwardDocReq;
        private DevExpress.XtraEditors.SimpleButton btnShowAttachments;
        private DevExpress.XtraEditors.PanelControl loading;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.StepProgressBar confirmationSigners;
    }
}