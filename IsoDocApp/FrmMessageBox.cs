using DevExpress.Images;
using IsoDoc.Domain.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IsoDocApp
{
    public partial class FrmMessageBox : DevExpress.XtraEditors.XtraForm
    {

        public string InputText { get; private set; }

        public FrmMessageBox()
        {
            InitializeComponent();
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtMessage.Enabled && txtMessage.Text.Trim() != "")
            {
                InputText = txtMessage.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (txtMessage.Enabled == false)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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

            if (!string.IsNullOrEmpty(options.CustomTitleIconName))
                grpMessage.CaptionImageOptions.Image = Properties.Resources.ResourceManager.GetObject(options.CustomTitleIconName) as Image;
            else
                grpMessage.CaptionImageOptions.Image = ImageResourceCache.Default.GetImageById(options.DevExpressIconId, DevExpress.Utils.Design.ImageSize.Size32x32, (DevExpress.Utils.Design.ImageType)options.DevExpressImageType);

            btnConfirm.Visible = options.ShowConfirmButton;
            btnConfirm.Text = options.ConfirmButtonText;

            btnCancel.Visible = options.ShowCancelButton;
            btnCancel.Text = options.CancelButtonText;

            txtMessage.Enabled = options.IsInputBox;
            if (options.IsInputBox)
                txtMessage.Properties.Appearance.BackColor = Color.White;


            btnCancel.Focus();
        }
    }
}