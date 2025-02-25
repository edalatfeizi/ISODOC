using IsoDoc.Domain.Entities;
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
        Task<List<DocRequest>> GetAll();
        Task<List<Document>> GetDocuments();
    }
}
