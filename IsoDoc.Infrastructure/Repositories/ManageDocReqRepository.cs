using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Infrastructure.Repositories
{
    public class ManageDocReqRepository : IManageDocReqsRepository
    {
        private readonly IDbConnection connection;
        public ManageDocReqRepository(IDbConnection dbConnection)
        {
            connection = dbConnection;  
            //connection = new SqlConnection("Data Source=sqlsrv;Initial Catalog=Isodoc_New;User Id=samane;Password=#@Samane1367!#;Encrypt=False;");
        }
        public async Task<DocRequest> CreateNewDocRequest(DocRequest docRequest)
        {
            return new DocRequest();
        }

        public async Task<List<DocRequest>> GetAll()
        {
            connection.Open();
            var docRequestsQuery = "select * from DocRequests";

            var docRequests = await connection.QueryAsync<DocRequest>(docRequestsQuery);
            connection.Close();
            return docRequests.ToList();
        }
    }
}
