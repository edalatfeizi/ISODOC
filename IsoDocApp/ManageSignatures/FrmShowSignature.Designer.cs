namespace IsoDocApp.ManageSignatures
{
    partial class FrmShowSignature
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
            this.peSignature = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.peSignature.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // peSignature
            // 
            this.peSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peSignature.EditValue = global::IsoDocApp.Properties.Resources.Businessman_signing_contract1;
            this.peSignature.Location = new System.Drawing.Point(0, 0);
            this.peSignature.Name = "peSignature";
            this.peSignature.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSignature.Size = new System.Drawing.Size(460, 384);
            this.peSignature.TabIndex = 151;
            // 
            // FrmShowSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 384);
            this.Controls.Add(this.peSignature);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowSignature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش امضاء";
            this.Load += new System.EventHandler(this.FrmShowSignature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peSignature.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peSignature;
    }
}