using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IManageDocReqsRepository
    {
        Task<int> GetLastDocReqId();
        Task<DocRequest> CreateNewDocRequest(DocRequest docRequest);
        Task<DocRequest> GetDocRequest(int docReqId);
        Task<DocRequestStep> AddNewDocRequestStepAsync(DocRequestStep docRequestStep);
        Task<DocRequestAttachment> AttachFileAsync(DocRequestAttachment docRequestAttachment);
        Task<List<DocRequest>> FilterDocRequests(FilterDocRequests filterDocRequests);
        Task<List<Document>> GetDocuments(string depCode);
        Task<List<DocType>> GetDocTypes();
        Task<List<DocRequestStep>> GetDocRequestSteps(int docReqId);
        Task<bool> SetDocRequestStepApproved(int docReqId, string userPersonCode);
        Task<bool> UpdateDocRequestStatus(int docReqId, DocRequestStatus docRequestStatus, string cancelDesc);
        Task<bool> UpdateDocRequestEditOrReviewStatus(int docReqId, EditOrReviewStatus editOrReviewStatus, int editOrReviewNo);
        Task<bool> SetDocRequestActive(int docReqId, string deleteDesc, bool isActive);

        //Task<DocRequest> UpdateDocRequest(int docReqId);


    }
}
