using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
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

        public async Task<NewDocConfirmation> AddNewDocConfirmation(string ownerDepCode, string docTitle, string docCode, string reviewNo, string reviewText, string creatorUserPersonCode)
        {
            var newDocConfirm = new NewDocConfirmation
            {
                DocOwnerDepCode = ownerDepCode,
                DocTitle = docTitle,
                DocCode = docCode,
                ReviewNo = reviewNo,
                ReviewText = reviewText,
                CreatedAt = DateTime.UtcNow.ToString(),
                ModifiedAt = DateTime.UtcNow.ToString(),
                CreatedBy = creatorUserPersonCode,
                ModifiedBy = creatorUserPersonCode,
                Active = true,
            };
            var newConfirmDocQuery = @"
                    INSERT INTO tb_NewDocConfirmations (
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

        public async Task<DocSigner> AddNewDocSigner(int newDocConfirmationId, string personCode, string name, string post, SignerColleagueType signerType, int signingOrder, bool isSigned, string creatorUserPersonCode)
        {
            var newDocSigner = new DocSigner
            {
                NewDocConfirmationId = newDocConfirmationId,
                PersonCode = personCode,
                Name = name,
                Post = post,
                SignerType = signerType,
                SigningOrder = signingOrder,
                IsSigned = isSigned,
                CreatedAt = DateTime.UtcNow.ToString(),
                ModifiedAt = DateTime.UtcNow.ToString(),
                CreatedBy = creatorUserPersonCode,
                ModifiedBy = creatorUserPersonCode,
                Active = true,
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
                        @Active
                    );";


            var newDocSignerId = await connection.QuerySingleAsync<int>(newDocSignerQuery, newDocSigner);
            newDocSigner.Id = newDocSignerId;
            return newDocSigner;
        }

        public async Task<List<NewDocConfirmation>> GetAllDocConfirmations()
        {
            const string query = @"SELECT * FROM tb_NewDocConfirmations where Active = 'true'";

            // Dapper automatically opens/closes the connection if not already open
            var result = await connection.QueryAsync<NewDocConfirmation>(query);

            return result.ToList();
        }

        public async Task<List<DocSigner>> GetDocConfirmationSigners(int docConfirmationId)
        {
            const string query = @"SELECT * FROM tb_NewDocSigners where NewDocConfirmationId = @NewDocConfirmationId";

            // Dapper automatically opens/closes the connection if not already open
            var result = await connection.QueryAsync<DocSigner>(query, new { NewDocConfirmationId = docConfirmationId });

            return result.ToList();
        }
    }
}
