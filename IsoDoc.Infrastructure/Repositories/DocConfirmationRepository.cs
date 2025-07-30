using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Extensions;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IsoDoc.Infrastructure.Repositories
{
    public class DocConfirmationRepository : IDocConfirmationRepository
    {
        private readonly IDbConnection connection;
        public DocConfirmationRepository(IDbConnection dbConnection)
        {
            connection = dbConnection;
        }

        public async Task<NewDocConfirmation> AddNewDocConfirmation(int docReqId, string ownerDepCode, string docTitle, string docCode, string reviewNo, string reviewText, string creatorUserPersonCode)
        {
            var newDocConfirm = new NewDocConfirmation
            {
                DocReqId = docReqId,
                DocOwnerDepCode = ownerDepCode,
                DocTitle = docTitle,
                DocCode = docCode,
                ReviewNo = reviewNo,
                ReviewText = reviewText,
                CreatedBy = creatorUserPersonCode,
                ModifiedBy = creatorUserPersonCode,
                Active = true,
            };
            var newConfirmDocQuery = @"
                    INSERT INTO tb_NewDocConfirmations (
                        DocReqId,
                        DocOwnerDepCode,
                        DocTitle,
                        DocCode,
                        ReviewNo,
                        ReviewText,
                        CreatedBy, 
                        ModifiedBy, 
                        CreatedAt, 
                        ModifiedAt,
                        Active
                    )
                    OUTPUT INSERTED.Id
                    VALUES (
                        @DocReqId,
                        @DocOwnerDepCode,
                        @DocTitle,
                        @DocCode,
                        @ReviewNo,
                        @ReviewText,
                        @CreatedBy,
                        @ModifiedBy,
                        @CreatedAt,
                        @ModifiedAt,
                        @Active
                    );";


            var newDocConfirmId = await connection.QuerySingleAsync<int>(newConfirmDocQuery, newDocConfirm);
            newDocConfirm.Id = newDocConfirmId;
            return newDocConfirm;
        }

        public async Task<DocSigner> AddNewDocSigner(int newDocConfirmationId, string personCode, string name, string post, SignerColleagueType signerType, int signingOrder, bool isSigned, string creatorUserPersonCode, string signRequestSentDate, bool active)
        {
            var newDocSigner = new DocSigner
            {
                NewDocConfirmationId = newDocConfirmationId,
                PersonCode = personCode,
                Name = name,
                Post = post,
                SignerType = signerType,
                SigningOrder = signingOrder,
                SignRequestSentDate = signRequestSentDate,
                IsSigned = isSigned,
                CreatedBy = creatorUserPersonCode,
                ModifiedBy = creatorUserPersonCode,
                Active = active,
            };
            var newDocSignerQuery = @"
                    INSERT INTO tb_NewDocSigners (
                        NewDocConfirmationId,
                        PersonCode,
                        Name,
                        Post,
                        SignerType,
                        SigningOrder,
                        IsSigned,
                        CreatedBy, 
                        ModifiedBy, 
                        CreatedAt, 
                        ModifiedAt,
                        SignRequestSentDate,
                        Active
                    )
                    OUTPUT INSERTED.Id
                    VALUES (
                        @NewDocConfirmationId,
                        @PersonCode,
                        @Name,
                        @Post,
                        @SignerType,
                        @SigningOrder,
                        @IsSigned,
                        @CreatedBy,
                        @ModifiedBy,
                        @CreatedAt,
                        @ModifiedAt,
                        @SignRequestSentDate,
                        @Active
                    );";


            var newDocSignerId = await connection.QuerySingleAsync<int>(newDocSignerQuery, newDocSigner);
            newDocSigner.Id = newDocSignerId;
            return newDocSigner;
        }

        public async Task<List<NewDocConfirmation>> GetAllDocConfirmations()
        {
            const string query = @"SELECT * FROM tb_NewDocConfirmations where Active = 'true'";

            var result = await connection.QueryAsync<NewDocConfirmation>(query);

            return result.ToList();
        }

        public async Task<NewDocConfirmation> GetDocConfirmationByDocReqIdAsync(int docReqId)
        {
            const string query = @"SELECT * FROM tb_NewDocConfirmations where DocReqId = @DocReqId and Active = 'true'";

            var result = await connection.QueryFirstOrDefaultAsync<NewDocConfirmation>(query, new { DocReqId = docReqId });

            return result;
        }

        public async Task<List<DocSigner>> GetDocConfirmationSigners(int docConfirmationId)
        {
            const string query = @"SELECT * FROM tb_NewDocSigners where NewDocConfirmationId = @NewDocConfirmationId";

            var result = await connection.QueryAsync<DocSigner>(query, new { NewDocConfirmationId = docConfirmationId });

            return result.ToList();
        }

        public async Task<List<NewDocConfirmation>> GetUserDocConfirmations(string personCode)
        {
            const string query = @"select * from tb_NewDocConfirmations where Id in (select NewDocConfirmationId from [tb_NewDocSigners] where PersonCode = @PersonCode and Active = 'true') and Active = 'true'";

            var result = await connection.QueryAsync<NewDocConfirmation>(query, new { PersonCode = personCode });

            return result.ToList();
        }

        public async Task<bool> SignDocConfirmationAsync(int newDocSignersId)
        {
            var query = @"UPDATE [Isodoc_New].[dbo].[tb_NewDocSigners]
                  SET IsSigned = 'true', SigningDate = @SigningDate 
                  WHERE Id = @NewDocSignersId";

            int rowsAffected = await connection.ExecuteAsync(query, new { NewDocSignersId = newDocSignersId , SigningDate = DateTime.Now.ToPersianDateTime() });
            return rowsAffected > 0;
        }

        public async Task<bool> UpdateSendSignRequestDate(int newDocSignersId, string personCode)
        {
            var query = @"UPDATE [Isodoc_New].[dbo].[tb_NewDocSigners]
                  SET SignRequestSentDate = @SignRequestSentDate , Active = 'true'
                  WHERE Id = @NewDocSignersId and PersonCode = @PersonCode";

            int rowsAffected = await connection.ExecuteAsync(query, new { NewDocSignersId = newDocSignersId, SignRequestSentDate = DateTime.Now.ToPersianDateTime(), PersonCode = personCode });
            return rowsAffected > 0;
        }
    }
}
