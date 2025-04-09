using Dapper;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Infrastructure.Repositories
{
    public class DocsRepository : IDocsRepository
    {
        private readonly IDbConnection connection;
        public DocsRepository(IDbConnection dbConnection)
        {
            connection = dbConnection;
        }
        public async Task<List<SearchResult>> FilterDocs(bool isAdmin, string searchTerm, string userDepId)
        {
            try
            {
                var query = "";
                connection.Open();

                if (isAdmin) {
                    query = $"SELECT   ROW_NUMBER() OVER (ORDER BY RevisionDate DESC) AS RowId, * FROM  (select DISTINCT  * from VwAllDocument where LTRIM(RTRIM(DocumentName)) Like '%{searchTerm}%' or DocumentCode like '%{searchTerm}%'   AND (IsoDocViewID = 1)) as SubQuery ";
                }
                else
                {
                    query = $"SELECT   ROW_NUMBER() OVER (ORDER BY RevisionDate DESC) AS RowId, * FROM  (select DISTINCT  * from VwAllDocument where (MdepartID ='{userDepId}' or mdepartid='PublicTechnicalDocuments') and  LTRIM(RTRIM(DocumentName)) Like '%{searchTerm}%' or DocumentCode like '%{searchTerm}%'   AND (IsoDocViewID = 1) and  IsShowPublic=1) as SubQuery";

                }
                var docs = await connection.QueryAsync<SearchResult>(query);
                connection.Close();
                return docs.ToList();

            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

    }
}
