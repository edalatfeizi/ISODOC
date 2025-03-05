using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IManageDocReqsService
    {
        Task<DocRequest> CreateNewDocRequest(DocRequest docRequest);
        Task<DocRequestStep> AddNewDocRequestStepAsync(DocRequestStep docRequestStep);
        Task<DocRequestAttachment> AttachFileAsync(DocRequestAttachment docRequestAttachment);

        Task<List<DocRequest>> GetAll(string creatorPersonCode = null, bool active = true);
        Task<int> GetLastDocReqId();
        Task<List<Document>> GetDocuments(string depCode);
        Task<List<DocType>> GetDocTypes();
        Task<List<DocRequestStep>> GetDocRequestSteps(int docReqId);

    }
}
