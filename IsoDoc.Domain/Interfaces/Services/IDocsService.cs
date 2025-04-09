using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IDocsService
    {
        Task<List<SearchResult>> FilterDocs(bool isAdmin, string searchTerm, string userDepId);
    }
}
