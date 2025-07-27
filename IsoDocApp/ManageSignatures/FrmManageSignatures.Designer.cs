namespace IsoDocApp.ManageSignatures
{
    partial class FrmManageSignatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageSignatures));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteSignature = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSignature = new DevExpress.XtraEditors.SimpleButton();
            this.peSignature = new DevExpress.XtraEditors.PictureEdit();
            this.gridUsers = new DevExpress.XtraGrid.GridControl();
            this.grdUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.progressBar = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peSignature.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDeleteSignature);
            this.panelControl1.Controls.Add(this.btnAddSignature);
            this.panelControl1.Controls.Add(this.peSignature);
            this.panelControl1.Controls.Add(this.gridUsers);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1012, 713);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDeleteSignature
            // 
            this.btnDeleteSignature.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteSignature.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnDeleteSignature.Appearance.Options.UseBackColor = true;
            this.btnDeleteSignature.Appearance.Options.UseFont = true;
            this.btnDeleteSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSignature.Enabled = false;
            this.btnDeleteSignature.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnDeleteSignature.Location = new System.Drawing.Point(5, 653);
            this.btnDeleteSignature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteSignature.Name = "btnDeleteSignature";
            this.btnDeleteSignature.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteSignature.Size = new System.Drawing.Size(440, 54);
            this.btnDeleteSignature.TabIndex = 152;
            this.btnDeleteSignature.Text = "حذف امضاء";
            this.btnDeleteSignature.Click += new System.EventHandler(this.btnDeleteSignature_Click);
            // 
            // btnAddSignature
            // 
            this.btnAddSignature.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddSignature.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnAddSignature.Appearance.Options.UseBackColor = true;
            this.btnAddSignature.Appearance.Options.UseFont = true;
            this.btnAddSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSignature.Enabled = false;
            this.btnAddSignature.ImageOptions.Image = global::IsoDocApp.Properties.Resources.signature;
            this.btnAddSignature.Location = new System.Drawing.Point(5, 592);
            this.btnAddSignature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddSignature.Name = "btnAddSignature";
            this.btnAddSignature.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddSignature.Size = new System.Drawing.Size(440, 54);
            this.btnAddSignature.TabIndex = 151;
            this.btnAddSignature.Text = "افزودن امضاء";
            this.btnAddSignature.Click += new System.EventHandler(this.btnAddSignature_Click);
            // 
            // peSignature
            // 
            this.peSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peSignature.EditValue = global::IsoDocApp.Properties.Resources.Businessman_signing_contract1;
            this.peSignature.Location = new System.Drawing.Point(5, 17);
            this.peSignature.Name = "peSignature";
            this.peSignature.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSignature.Size = new System.Drawing.Size(441, 567);
            this.peSignature.TabIndex = 150;
            // 
            // gridUsers
            // 
            this.gridUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridUsers.Location = new System.Drawing.Point(453, 17);
            this.gridUsers.MainView = this.grdUsers;
            this.gridUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.Size = new System.Drawing.Size(554, 690);
            this.gridUsers.TabIndex = 149;
            this.gridUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUsers});
            // 
            // grdUsers
            // 
            this.grdUsers.DetailHeight = 512;
            this.grdUsers.GridControl = this.gridUsers;
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdUsers_FocusedRowChanged);
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
            this.progressBar.Size = new System.Drawing.Size(1012, 14);
            this.progressBar.TabIndex = 132;
            this.progressBar.Text = "progressPanel1";
            this.progressBar.Visible = false;
            this.progressBar.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // FrmManageSignatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 713);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1014, 745);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1014, 745);
            this.Name = "FrmManageSignatures";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت امضاء پرسنل";
            this.Load += new System.EventHandler(this.FrmManageSignatures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peSignature.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraWaitForm.ProgressPanel progressBar;
        private DevExpress.XtraGrid.GridControl gridUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView grdUsers;
        private DevExpress.XtraEditors.PictureEdit peSignature;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSignature;
        private DevExpress.XtraEditors.SimpleButton btnAddSignature;
    }
}