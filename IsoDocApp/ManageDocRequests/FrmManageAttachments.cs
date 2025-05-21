using DevExpress.Utils.Extensions;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.ManageDocRequests
{
    public partial class FrmManageAttachments : DevExpress.XtraEditors.XtraForm
    {
        private IDocRequestAttachmentsService docRequestAttachmentsService;
        private List<DocRequestAttachment> attachments;
        private int docReqId = 0;
        public FrmManageAttachments(IDocRequestAttachmentsService docRequestAttachmentsService, int docReqId)
        {
            InitializeComponent();
            this.docRequestAttachmentsService = docRequestAttachmentsService;
            this.docReqId = docReqId;
        }

        private void ShowProgressBar(bool isVisible)
        {
            progressBar.Visible = isVisible;
        }

        private async void FrmManageAttachments_Load(object sender, EventArgs e)
        {
            ShowProgressBar(true);
            attachments = await docRequestAttachmentsService.GetAttachments(docReqId);
            foreach (var attachment in attachments)
            {
                attachment.UploadDate = attachment.CreatedAt.FormatPersianDate();
            }
            grdAttachments.DataSource = attachments;
            ShowProgressBar(false);
        }

        private async Task<bool> OpenAttachment()
        {
            var attachmentId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            var attachment = await docRequestAttachmentsService.GetDocRequestAttachment(attachmentId);

            try
            {
                // Create a temporary file path
                string tempFilePath = Path.Combine(Path.GetTempPath(), attachment.Name);

                // Save the byte array to the temporary file
                File.WriteAllBytes(tempFilePath, attachment.FileContent);

                // Create a new process to open the file
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = tempFilePath,
                    UseShellExecute = true // This is important to use the default program
                };

                Process.Start(psi);

                //toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
                return true;
            }
            catch (Exception ex)
            {
                var frmMsgBox = new FrmMessageBox();
                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ErrorProccessingData,
                    Message = $"{ex.Message} \n {ex.InnerException}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
                return false;
            }
        }

        private async void btnDownloadAttachment_Click(object sender, EventArgs e)
        {
           await OpenAttachment();
        }

        private async void gridView1_DoubleClick(object sender, EventArgs e)
        {
           await OpenAttachment();
        }
    }
}