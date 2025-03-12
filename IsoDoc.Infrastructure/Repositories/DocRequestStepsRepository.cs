using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Infrastructure.Repositories
{
    public class DocRequestStepsRepository : IDocRequestStepsRepository
    {
        private readonly IDbConnection connection;
        private readonly string baseEntityInsertProps = "CreatedBy,ModifiedBy,CreatedAt,ModifiedAt,Active";
        private readonly string baseEntityInsertPropsValues = "@CreatedBy,@ModifiedBy,@CreatedAt,@ModifiedAt,@Active";
        public DocRequestStepsRepository(IDbConnection dbConnection)
        {
            connection = dbConnection;
            //connection = new SqlConnection("Data Source=sqlsrv;Initial Catalog=Isodoc_New;User Id=samane;Password=#@Samane1367!#;Encrypt=False;");
        }

        public Task<DocRequestStep> SetDocRequestStepApproved(int docReqStepId)
        {
            throw new NotImplementedException();
        }

        //public async Task<DocRequestStep> SetDocRequestStepApproved(int docReqId, string userPersonCode)
        //{
        //try
        //{

        //    connection.Open();
        //    var docRequestStepQuery = $@"
        //        update DocRequestSteps set IsApproved = 'true' where DocRequestId = '{docReqId}' and ReceiverUserPersonCode = '{userPersonCode}'";


        //    var newDocReqStepId = await connection.QuerySingleAsync<int>(docRequestStepQuery, docRequestStep);
        //    connection.Close();
        //    docRequestStep.Id = newDocReqStepId;
        //    return docRequestStep;
        //}
        //catch (Exception ex)
        //{
        //    connection.Close();
        //    throw ex;
        //}
        //}
    }
}
