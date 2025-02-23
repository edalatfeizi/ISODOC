using IsoDoc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IManageDocReqsRepository
    {
        Task<DocRequest> CreateNewDocRequest(DocRequest docRequest);
        Task<List<DocRequest>> GetAll();
    }
}
