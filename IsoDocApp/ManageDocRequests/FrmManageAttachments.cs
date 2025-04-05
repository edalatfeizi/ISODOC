using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
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
            grdAttachments.DataSource = attachments;
            ShowProgressBar(false);
        }

        private async Task<bool> DownloadAttachment()
        {
            var attachmentId = int.Parse(GridViewHelper.GetGridViewCellValue(gridView1, "Id").ToString());
            var attachment = await docRequestAttachmentsService.GetDocRequestAttachment(attachmentId);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = $"{attachment.Name}"; // File type filter
            saveFileDialog.Filter = "All Files (*.*)|*.*"; // File type filter
            saveFileDialog.Title = "ذخیره فایل پیوست"; // Dialog title
            saveFileDialog.DefaultExt = attachment.ContentType; // Default file extension
            saveFileDialog.AddExtension = true; // Automatically add the file extension

            // Show the dialog and check if the user clicked "OK"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Save the byte array to the selected file path
                    File.WriteAllBytes(filePath, attachment.FileContent);

                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
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
            
            return false;

        }

        private async void btnDownloadAttachment_Click(object sender, EventArgs e)
        {
           await DownloadAttachment();
        }
    }
}