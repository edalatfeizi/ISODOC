using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Services
{
    public class DocsService : IDocsService
    {
        private readonly IDocsRepository docsRepo;
        public DocsService(IDocsRepository docsRepository)
        {
            docsRepo = docsRepository;
        }
        public async Task<List<SearchResult>> FilterDocs(bool isAdmin, string searchTerm, string userDepId)
        {
            return await docsRepo.FilterDocs(isAdmin, searchTerm, userDepId);

        }
    }
}
