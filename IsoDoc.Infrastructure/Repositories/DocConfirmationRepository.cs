using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Repositories;
using System;
using System.Data;
using System.Reflection.Emit;
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
    }
}
