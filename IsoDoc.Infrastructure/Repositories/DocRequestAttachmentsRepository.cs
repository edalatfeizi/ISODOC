using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces;
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
        //private readonly IDbConnection connection;
        private readonly IDbConnectionFactory _factory;
        public DocRequestAttachmentsRepository(IDbConnectionFactory factory) => _factory = factory;
        //public DocRequestAttachmentsRepository(IDbConnection dbConnection)
        //{
        //    connection = dbConnection;
        //}

        public async Task<List<DocRequestAttachment>> GetAttachments(int attachmentId)
        {
            using var connection = _factory.Create();
            var docRequestStepsQuery = @"SELECT a.Id, a.Name, a.ContentType, a.Size, a.CreatedBy,a.CreatedAt, p.FirstName + ' ' + p.LastName as UploadedBy FROM [Isodoc_New].[dbo].[DocRequestAttachments] a " +
                $"LEFT JOIN [Personely].[dbo].[Vw_AllPersonWithDepartName] p ON a.CreatedBy = p.PersonCode WHERE a.DocRequestId = @DocRequestId AND a.Active = '1' ORDER BY a.Id DESC";


            var docRequestAttachments = await connection.QueryAsync<DocRequestAttachment>(docRequestStepsQuery, new { DocRequestId = attachmentId });

            return docRequestAttachments.ToList();

        }
        public async Task<DocRequestAttachment?> GetDocRequestAttachment(int attachmentId)
        {
            using var connection = _factory.Create();
            var docRequestStepsQuery = @"select * from DocRequestAttachments where Id = @Id and Active = '1' ";


            var docRequestAttachments = await connection.QueryAsync<DocRequestAttachment>(docRequestStepsQuery, new { Id = attachmentId });
            return docRequestAttachments.FirstOrDefault();

        }
    }
}
