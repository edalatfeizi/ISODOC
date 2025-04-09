namespace IsoDocApp
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.panelShowDoc = new DevExpress.XtraEditors.PanelControl();
            this.btnShowDoc = new DevExpress.XtraEditors.SimpleButton();
            this.grdSearchResult = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelShowDoc)).BeginInit();
            this.panelShowDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.btnSave);
            this.PanelControl1.Controls.Add(this.txtSearch);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1107, 93);
            this.PanelControl1.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(648, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 35);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "جستجو";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.EditValue = "";
            this.txtSearch.Location = new System.Drawing.Point(781, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSearch.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtSearch.Properties.NullText = "جستجو بر اساس عنوان یا کد سند";
            this.txtSearch.Properties.NullValuePrompt = "جستجو بر اساس عنوان یا کد سند";
            this.txtSearch.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(318, 28);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // panelShowDoc
            // 
            this.panelShowDoc.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelShowDoc.Appearance.Options.UseBackColor = true;
            this.panelShowDoc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelShowDoc.Controls.Add(this.btnShowDoc);
            this.panelShowDoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShowDoc.Location = new System.Drawing.Point(0, 814);
            this.panelShowDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShowDoc.Name = "panelShowDoc";
            this.panelShowDoc.Size = new System.Drawing.Size(1107, 57);
            this.panelShowDoc.TabIndex = 12;
            // 
            // btnShowDoc
            // 
            this.btnShowDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowDoc.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowDoc.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowDoc.Appearance.Font = new System.Drawing.Font("Vazirmatn SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDoc.Appearance.Options.UseBackColor = true;
            this.btnShowDoc.Appearance.Options.UseBorderColor = true;
            this.btnShowDoc.Appearance.Options.UseFont = true;
            this.btnShowDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDoc.ImageOptions.Image")));
            this.btnShowDoc.Location = new System.Drawing.Point(471, 9);
            this.btnShowDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowDoc.Name = "btnShowDoc";
            this.btnShowDoc.Size = new System.Drawing.Size(141, 45);
            this.btnShowDoc.TabIndex = 12;
            this.btnShowDoc.Text = "مشاهده سند";
            this.btnShowDoc.Click += new System.EventHandler(this.btnShowDoc_Click);
            // 
            // grdSearchResult
            // 
            this.grdSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSearchResult.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.grdSearchResult.Location = new System.Drawing.Point(0, 93);
            this.grdSearchResult.MainView = this.gridView1;
            this.grdSearchResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdSearchResult.Name = "grdSearchResult";
            this.grdSearchResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdSearchResult.Size = new System.Drawing.Size(1107, 721);
            this.grdSearchResult.TabIndex = 13;
            this.grdSearchResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.DetailHeight = 239;
            this.gridView1.GridControl = this.grdSearchResult;
            this.gridView1.Name = "gridView1";
            // 
            // FrmSearch
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 871);
            this.Controls.Add(this.grdSearchResult);
            this.Controls.Add(this.panelShowDoc);
            this.Controls.Add(this.PanelControl1);
            this.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmSearch.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی اسناد";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelShowDoc)).EndInit();
            this.panelShowDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.PanelControl panelShowDoc;
        private DevExpress.XtraEditors.SimpleButton btnShowDoc;
        private DevExpress.XtraGrid.GridControl grdSearchResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}