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

        public async Task<List<DocRequestAttachment>> GetAttachments(int attachmentId)
        {
            try
            {
                connection.Open();
                var docRequestStepsQuery = $"SELECT a.Id, a.Name, a.ContentType, a.Size, a.CreatedBy,a.CreatedAt, p.FirstName + ' ' + p.LastName as UploadedBy FROM [Isodoc_New].[dbo].[DocRequestAttachments] a " +
                    $"LEFT JOIN [Personely].[dbo].[Vw_AllPersonWithDepartName] p ON a.CreatedBy = p.PersonCode WHERE a.DocRequestId = '{attachmentId}' AND a.Active = '1' ORDER BY a.Id DESC";


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
