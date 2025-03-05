using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Services
{
    public class ManageDocReqsService : IManageDocReqsService
    {
        private readonly IManageDocReqsRepository manageDocReqsRepo;
        public ManageDocReqsService(IManageDocReqsRepository manageDocReqsRepository)
        {
            manageDocReqsRepo = manageDocReqsRepository;
        }

        public async Task<DocRequestStep> AddNewDocRequestStepAsync(DocRequestStep docRequestStep)
        {
            return await manageDocReqsRepo.AddNewDocRequestStepAsync(docRequestStep);
        }

        public async Task<DocRequestAttachment> AttachFileAsync(DocRequestAttachment docRequestAttachment)
        {
            return await manageDocReqsRepo.AttachFileAsync(docRequestAttachment);
        }

        public async Task<DocRequest> CreateNewDocRequest(DocRequest docRequest)
        {

            return await manageDocReqsRepo.CreateNewDocRequest(docRequest);
        }

        public async Task<List<DocRequest>> GetAll(string creatorPersonCode = null, bool active = true)
        {
            return await manageDocReqsRepo.GetAll(creatorPersonCode);
        }

        public async Task<List<DocRequestStep>> GetDocRequestSteps(int docReqId)
        {
            return await manageDocReqsRepo.GetDocRequestSteps(docReqId);
        }

        public async Task<List<DocType>> GetDocTypes()
        {
            return await manageDocReqsRepo.GetDocTypes();
        }

        public async Task<List<Document>> GetDocuments(string depCode)
        {
            return await manageDocReqsRepo.GetDocuments(depCode);  
        }

        public async Task<int> GetLastDocReqId()
        {
            return await manageDocReqsRepo.GetLastDocReqId();

        }
    }
}
