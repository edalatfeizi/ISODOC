using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
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
        Task<DocRequest> GetDocRequest(int docReqId);
        Task<DocRequestAttachment> AttachFileAsync(DocRequestAttachment docRequestAttachment);
        Task<List<DocRequest>> FilterDocRequests(FilterDocRequests filterDocRequests);
        Task<int> GetLastDocReqId();
        Task<List<Document>> GetDocuments(string depCode);
        Task<List<DocType>> GetDocTypes();
        Task<List<DocRequestStep>> GetDocRequestSteps(int docReqId);
        Task<bool> SetDocRequestStepApproved(int docReqId, string userPersonCode);
        Task<bool> UpdateDocRequestStatus(int docReqId, DocRequestStatus docRequestStatus, string cancelDesc, string modifiedBy);
        Task<bool> UpdateDocRequestEditOrReviewStatus(int docReqId, EditOrReviewStatus editOrReviewStatus, int editOrReviewNo);
        Task<bool> SetDocRequestActive(int docReqId, string deleteDesc, bool isActive);
        Task<List<Colleague>> GetDocRequestActivePeopleAsync(int docReqId);
        Task<List<DocRequestChatMessage>> GetDocRequestAllChatMessagesAsync(int docReqId);
        Task<List<DocRequestChatMessage>> GetDocRequestUserReceivedChatMessagesAsync(int docReqId,string userPersonCode);
        Task<List<DocRequestChatMessage>> GetDocRequestUserSentChatMessagesAsync(int docReqId,string userPersonCode);
        Task<DocRequestChatMessage> SendMessageAsync(DocRequestChatMessage message);
    }
}
