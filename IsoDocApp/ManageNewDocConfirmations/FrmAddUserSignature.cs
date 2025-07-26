using DevExpress.Images;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.ManageNewDocConfirmations
{
    public partial class FrmAddUserSignature : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPersonelyService personelyService;
        private readonly string personCode;
        private PersonSignature personSignature;
          private Person userInfo;
        public FrmAddUserSignature(IPersonelyService personelyService, string personCode)
        {
            this.personelyService = personelyService;
            this.personCode = personCode;

            InitializeComponent();

        }
        private async void FrmAddUserSignature_Load(object sender, EventArgs e)
        {
            var userName = SystemInformation.UserName.ToString();
            if (Program.DebugMode)
                userName = "3910";

            var userPersonCode = "";
            userPersonCode = await personelyService.GetUserPersonCodeByLoginName(userName);
            userInfo = await personelyService.GetUserInfoByPersonCode(userPersonCode);

        }
      
        private bool CheckAttachment()
        {
            if (personSignature == null)
            {
                var frmMsgBox = new FrmMessageBox();
                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ErrorProccessingData,
                    Message = $"{StringResources.ErrorAttachFile}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
                return false;
            }
            return true;
        }

        private void ShowProgressBar(bool isVisible)
        {
            progressBar.Visible = isVisible;
        }
     

        private void ToggleAttachFileButtonView(string iconId, string buttonText)
        {
            btnAttachFile.ImageOptions.Image = ImageResourceCache.Default.GetImageById(iconId, DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored);
            btnAttachFile.Text = buttonText;
        }

        private void AttachFile()
        {
            personSignature = AttachmentsHelper.AttachFile(Constants.PersonSignatureFileTypes).MapToPersonSignature(personCode);
            if (personSignature != null)
            {
                btnFileName.Visible = true;
                btnFileName.Text = personSignature.Name;
                ToggleAttachFileButtonView("cancel", StringResources.DeleteAttachedFile);
                using (MemoryStream ms = new MemoryStream(personSignature.FileContent))
                {
                    Image img = Image.FromStream(ms);
                    pictureEdit1.Image = img;
                }
            }

        }

      

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            AttachFile();

        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            if (personSignature != null)
            {
                personSignature = null;
                btnFileName.Visible = false;
                ToggleAttachFileButtonView("attachment", StringResources.AttachFile);

            }
            else
            {
                AttachFile();

            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var frmMsgBox = new FrmMessageBox();

            try
            {

                if (CheckAttachment())
                {
                    ShowProgressBar(true);

                    if (personSignature != null)
                    {
                        personSignature.PersonCode = personCode;
                        personSignature.CreatedBy = userInfo.PersonCode;
                        personSignature.ModifiedBy = userInfo.PersonCode;

                        await personelyService.SavePersonSignature(personSignature);
                    }
                    ShowProgressBar(false);

                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ShowProgressBar(false);

                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ErrorProccessingData,
                    Message = $"{ex.Message} \n {ex.InnerException}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
            }
        }
    }
}