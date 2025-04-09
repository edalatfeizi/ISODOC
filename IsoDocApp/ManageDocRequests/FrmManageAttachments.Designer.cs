namespace IsoDocApp.ManageDocRequests
{
    partial class FrmManageAttachments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageAttachments));
            this.grdAttachments = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelDownload = new DevExpress.XtraEditors.PanelControl();
            this.btnDownloadAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar = new DevExpress.XtraWaitForm.ProgressPanel();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDownload)).BeginInit();
            this.panelDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAttachments
            // 
            this.grdAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAttachments.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdAttachments.Location = new System.Drawing.Point(0, 0);
            this.grdAttachments.MainView = this.gridView1;
            this.grdAttachments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdAttachments.Name = "grdAttachments";
            this.grdAttachments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdAttachments.Size = new System.Drawing.Size(682, 278);
            this.grdAttachments.TabIndex = 6;
            this.grdAttachments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.DetailHeight = 239;
            this.gridView1.GridControl = this.grdAttachments;
            this.gridView1.Name = "gridView1";
            // 
            // panelDownload
            // 
            this.panelDownload.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDownload.Appearance.Options.UseBackColor = true;
            this.panelDownload.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelDownload.Controls.Add(this.btnDownloadAttachment);
            this.panelDownload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDownload.Location = new System.Drawing.Point(0, 221);
            this.panelDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDownload.Name = "panelDownload";
            this.panelDownload.Size = new System.Drawing.Size(682, 57);
            this.panelDownload.TabIndex = 7;
            // 
            // btnDownloadAttachment
            // 
            this.btnDownloadAttachment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownloadAttachment.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownloadAttachment.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnDownloadAttachment.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadAttachment.Appearance.Options.UseBackColor = true;
            this.btnDownloadAttachment.Appearance.Options.UseBorderColor = true;
            this.btnDownloadAttachment.Appearance.Options.UseFont = true;
            this.btnDownloadAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadAttachment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDownloadAttachment.ImageOptions.Image")));
            this.btnDownloadAttachment.Location = new System.Drawing.Point(259, 9);
            this.btnDownloadAttachment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDownloadAttachment.Name = "btnDownloadAttachment";
            this.btnDownloadAttachment.Size = new System.Drawing.Size(141, 45);
            this.btnDownloadAttachment.TabIndex = 12;
            this.btnDownloadAttachment.Text = "دانلود فایل پیوست ";
            this.btnDownloadAttachment.Click += new System.EventHandler(this.btnDownloadAttachment_Click);
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
            this.progressBar.Location = new System.Drawing.Point(223, 101);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(234, 42);
            this.progressBar.TabIndex = 33;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "336d853b-db33-40b1-b4d4-6bb2b17cc2b8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("5064271b-6465-45af-93b2-6ba6b8d55777", null, "ذخیره فایل پیوست", "فایل پیوست با موفقیت ذخیره شد", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01)});
            // 
            // FrmManageAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 278);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panelDownload);
            this.Controls.Add(this.grdAttachments);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageAttachments";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فایل های پیوست شده";
            this.Load += new System.EventHandler(this.FrmManageAttachments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDownload)).EndInit();
            this.panelDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdAttachments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelDownload;
        private DevExpress.XtraEditors.SimpleButton btnDownloadAttachment;
        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}