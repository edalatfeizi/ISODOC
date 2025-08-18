using IsoDoc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Extensions
{
    public static class FileAttachmentExtensions
    {
        public static PersonSignature MapToPersonSignature(this FileAttachment fileAttachment, string personCode)
        {

            var personSignature = new PersonSignature()
            {
                Id = fileAttachment.Id,
                Name = fileAttachment.Name,
                ContentType = fileAttachment.ContentType,
                FileContent = fileAttachment.FileContent,
                Size = fileAttachment.Size,
                UploadedBy = fileAttachment.UploadedBy,
                UploadDate = fileAttachment.UploadDate,
                PersonCode = personCode,
                CreatedBy = fileAttachment.CreatedBy,
                ModifiedBy = fileAttachment.ModifiedBy,
                CreatedAt = fileAttachment.CreatedAt,
                ModifiedAt = fileAttachment.ModifiedAt,
                Active = fileAttachment.Active,

            };
            return personSignature;
        }
        public static List<DocRequestAttachment> MapToDocRequestAttachments(this List<FileAttachment> fileAttachments, int docReqId)
        {
            var result = new List<DocRequestAttachment>();
            foreach (var fileAttachment in fileAttachments)
            {
             
                result.Add(fileAttachment.MapToDocRequestAttachment(docReqId));
            }
         
            return result;
        }
        public static DocRequestAttachment MapToDocRequestAttachment(this FileAttachment fileAttachment, int docReqId)
        {
            var docRequestAttachment = new DocRequestAttachment()
            {
                Id = fileAttachment.Id,
                Name = fileAttachment.Name,
                ContentType = fileAttachment.ContentType,
                FileContent = fileAttachment.FileContent,
                Size = fileAttachment.Size,
                UploadedBy = fileAttachment.UploadedBy,
                UploadDate = fileAttachment.UploadDate,
                DocRequestId = docReqId,
                CreatedBy = fileAttachment.CreatedBy,
                ModifiedBy = fileAttachment.ModifiedBy,
                CreatedAt = fileAttachment.CreatedAt,
                ModifiedAt = fileAttachment.ModifiedAt,
                Active = fileAttachment.Active,

            };
            return docRequestAttachment;
        }
    }
}
