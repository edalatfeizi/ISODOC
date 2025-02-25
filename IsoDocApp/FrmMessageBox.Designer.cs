namespace IsoDocApp
{
    partial class FrmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBox));
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.grpMessage = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMessage)).BeginInit();
            this.grpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Appearance.Options.UseBackColor = true;
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(0, 107);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnConfirm.Size = new System.Drawing.Size(127, 52);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "تایید";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Vazirmatn", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(135, 107);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(127, 52);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Vazirmatn", 10F);
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMessage.Location = new System.Drawing.Point(508, 33);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(48, 24);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.Text = "متن پیام";
            // 
            // grpMessage
            // 
            this.grpMessage.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.grpMessage.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMessage.Appearance.Options.UseBackColor = true;
            this.grpMessage.Appearance.Options.UseFont = true;
            this.grpMessage.AppearanceCaption.BackColor = System.Drawing.SystemColors.Menu;
            this.grpMessage.AppearanceCaption.Options.UseBackColor = true;
            this.grpMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grpMessage.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.grpMessage.Controls.Add(this.lblMessage);
            this.grpMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMessage.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.grpMessage.Location = new System.Drawing.Point(0, 0);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(558, 101);
            this.grpMessage.TabIndex = 28;
            this.grpMessage.Text = "لبیلیبل";
            // 
            // FrmMessageBox
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 163);
            this.ControlBox = false;
            this.Controls.Add(this.grpMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMessage)).EndInit();
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private DevExpress.XtraEditors.GroupControl grpMessage;
    }
}