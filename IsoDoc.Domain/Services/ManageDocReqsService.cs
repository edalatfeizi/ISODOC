using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public Task<DocRequest> CreateNewDocRequest(DocRequest docRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DocRequest>> GetAll()
        {
            return await manageDocReqsRepo.GetAll();
        }

        public async Task<int> GetLastDocReqId()
        {
            return await manageDocReqsRepo.GetLastDocReqId();

        }
    }
}
