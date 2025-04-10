using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoDocApp.Helpers
{
    public static class AttachmentsHelper
    {
        public static DocRequestAttachment AttachFile()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Word Files|*.docx;*.doc|Excel Files|*.xlsx;*.xls|PDF Files|*.pdf";
                    openFileDialog.Title = StringResources.SelectAttachment;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        var file = File.ReadAllBytes(filePath);
                        string fileExtension = Path.GetExtension(filePath);


                        var docReqAttachment = new DocRequestAttachment
                        {
                            Name = openFileDialog.SafeFileName,
                            ContentType = fileExtension,
                            Size = file.Length,
                            FileContent = file
                        };
                        return docReqAttachment;
                    }
                    else
                        return null;
                }
            }
            catch (IOException ex)
            {
                var frmMsgBox = new FrmMessageBox();

                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ErrorWhileAttachingFile,
                    Message = $"{StringResources.FileInUse} \n\n {StringResources.CloseAppAndAttachAgain} \n\n {ex.Message}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
            }
            catch (Exception ex)
            {
                var frmMsgBox = new FrmMessageBox();

                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ErrorWhileAttachingFile,
                    Message = $"{ex.Message} \n\n {ex.InnerException}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
            }
            return null;

        }
    }
}
