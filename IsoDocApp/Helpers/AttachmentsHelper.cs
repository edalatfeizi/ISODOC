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
        public static List<FileAttachment> AttachFiles(string filterFileTypes, bool isSignatureAttachment)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = filterFileTypes;
                    openFileDialog.Title = StringResources.SelectAttachment;
                    openFileDialog.Multiselect = true; // ⬅️ allow multiple files

                    if (openFileDialog.ShowDialog() != DialogResult.OK)
                        return null;

                    var attachments = new List<FileAttachment>();

                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        // size check first (so we can error out before reading big files into memory)
                        var fi = new FileInfo(filePath);
                        long sizeBytes = fi.Length;

                        if (isSignatureAttachment && (sizeBytes / 1024) > 300)
                            throw new Exception(StringResources.ErrorFileSizeLimit300K);

                        byte[] fileBytes = File.ReadAllBytes(filePath);

                        attachments.Add(new FileAttachment
                        {
                            Name = Path.GetFileName(filePath),
                            ContentType = GetMimeTypeFromExtension(filePath), // better than just ".pdf"
                            Size = fileBytes.Length,
                            FileContent = fileBytes
                        });
                    }

                    return attachments;
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

        public static FileAttachment AttachFile(string filterFileTypes, bool isSignatureAttachment)
        {
            var list = AttachFiles(filterFileTypes, isSignatureAttachment);
            return list?.FirstOrDefault();
        }

        // Minimal MIME helper for common office/PDF types used in your filter.
        // If you're on .NET Framework, you could also use System.Web.MimeMapping.GetMimeMapping(path).
        private static string GetMimeTypeFromExtension(string path)
        {
            switch (Path.GetExtension(path).ToLowerInvariant())
            {
                case ".pdf": return "PDF Document";
                case ".doc": return "Word Document";
                case ".docx": return "Word Document";
                case ".xls": return "Excel Spreadsheet";
                case ".xlsx": return "Excel Spreadsheet";
                case ".png": return "PNG Image";
                case ".jpg":
                case ".jpeg": return "JPEG Image";
                case ".gif": return "GIF Image";
                case ".txt": return "Text File";
                case ".zip": return "ZIP Archive";
                default: return "Unknown File Type";
            }
        }

    }
}
