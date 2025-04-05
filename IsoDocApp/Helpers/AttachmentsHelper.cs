using IsoDoc.Domain.Entities;
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
    }
}
