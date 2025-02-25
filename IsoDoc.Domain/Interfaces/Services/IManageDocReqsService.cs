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
        Task<List<DocRequest>> GetAll();
        Task<int> GetLastDocReqId();
        Task<List<Document>> GetDocuments();

    }
}
