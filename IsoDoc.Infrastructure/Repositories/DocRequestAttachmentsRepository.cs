using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IsoDoc.Infrastructure.Repositories
{
    public class DocRequestAttachmentsRepository : IDocRequestAttachmentsRepository
    {
        private readonly IDbConnection connection;
        public DocRequestAttachmentsRepository(IDbConnection dbConnection)
        {
            connection = dbConnection;
        }

        public async Task<List<DocRequestAttachment>> GetAttachments(int docReqId)
        {
            try
            {
                connection.Open();
                var docRequestStepsQuery = $"select Id,Name,ContentType,Size from DocRequestAttachments where DocRequestId = '{docReqId}' and Active = '1' order by Id desc ";


                var docRequestAttachments = await connection.QueryAsync<DocRequestAttachment>(docRequestStepsQuery);
                connection.Close();
                return docRequestAttachments.ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        public async Task<DocRequestAttachment?> GetDocRequestAttachment(int attachmentId)
        {
            try
            {
                connection.Open();
                var docRequestStepsQuery = $"select * from DocRequestAttachments where Id = '{attachmentId}' and Active = '1' ";


                var docRequestAttachments = await connection.QueryAsync<DocRequestAttachment>(docRequestStepsQuery);
                connection.Close();
                return docRequestAttachments.FirstOrDefault();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
    }
}
