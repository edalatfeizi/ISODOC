using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace IsoDoc.Domain.Services
{
    public class DocRequestAttachmentsService : IDocRequestAttachmentsService
    {
        private readonly IDocRequestAttachmentsRepository docReqAttachmentsRepo;
        public DocRequestAttachmentsService(IDocRequestAttachmentsRepository docRequestAttachmentsRepository)
        {
            docReqAttachmentsRepo = docRequestAttachmentsRepository;
        }

        public async Task<List<DocRequestAttachment>> GetAttachments(int docReqId)
        {
            return await docReqAttachmentsRepo.GetAttachments(docReqId);
        }
        public async Task<DocRequestAttachment?> GetDocRequestAttachment(int attachmentId)
        {
            return await docReqAttachmentsRepo.GetDocRequestAttachment(attachmentId);
        }
    }
}
