using DevExpress.Images;
using DevExpress.Xpo.Logger;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp
{
    public partial class FrmMessageBox : DevExpress.XtraEditors.XtraForm
    {


        public FrmMessageBox()
        {
            InitializeComponent();
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {

            //lblMsgTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //lblMsgTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

            lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void SetMessageOptions(CustomMessageBoxOptions options)
        {
            //lblMsgTitle.Text = options.Title;
            lblMessage.Text = options.Message;
            grpMessage.Text = options.Title;
            grpMessage.CaptionImageOptions.Image = ImageResourceCache.Default.GetImageById(options.DevExpressIconId, DevExpress.Utils.Design.ImageSize.Size32x32, (DevExpress.Utils.Design.ImageType) options.DevExpressImageType);

            btnConfirm.Visible = options.ShowConfirmButton;
            btnConfirm.Text = options.ConfirmButtonText;

            btnCancel.Visible = options.ShowCancelButton;
            btnCancel.Text = options.CancelButtonText;


            btnCancel.Focus();
        }
    }
}