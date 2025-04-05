using IsoDoc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IDocRequestAttachmentsRepository
    {
        Task<List<DocRequestAttachment>> GetAttachments(int docReqId);
        Task<DocRequestAttachment?> GetDocRequestAttachment(int attachmentId);

    }

}
