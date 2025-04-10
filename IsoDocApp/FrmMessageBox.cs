using DevExpress.Images;
using IsoDoc.Domain.Models;
using System;
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
            txtMessage.Text = options.Message;
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