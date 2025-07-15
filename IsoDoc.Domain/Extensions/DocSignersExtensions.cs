
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Resources;
using System.Collections.Generic;

namespace IsoDoc.Domain.Extensions
{
    public static class DocSignersExtensions
    {
        public static List<DocSignerResDto> MapToDocSignerResDtos(this List<DocSigner> docSigners, int? page = null, int? pageSize = null)
        {
            var result = new List<DocSignerResDto>();
            if (page == null || pageSize == null)
            {
                page = 1;
                pageSize = docSigners.Count;
            }
            for (int i = 0; i < docSigners.Count; i++)
            {
                var index = (page - 1) * pageSize + i + 1;
                var dto = docSigners[i].MapToDocSignerResDto(index);
                dto.Index = index ?? 0;
                result.Add(dto);
            }
            return result;
        }

        public static DocSignerResDto MapToDocSignerResDto(this DocSigner docSigner, int? index = 0)
        {
            var signerType = "";
            switch (docSigner.SignerType)
            {
                case Enums.SignerColleagueType.Creator:
                    signerType = StringResources.Creator;
                    break;

                case Enums.SignerColleagueType.Confirmer:
                    signerType = StringResources.Confirmer;
                    break;

                case Enums.SignerColleagueType.Acceptor:
                    signerType = StringResources.Acceptor;  
                    break;
            }
            var docSignerResDto = new DocSignerResDto()
            {
                Index = index ?? 0,
                Id = docSigner.Id,
                NewDocConfirmationId = docSigner.NewDocConfirmationId,
                PersonCode = docSigner.PersonCode,
                Name = docSigner.Name,
                Post = docSigner.Post,
                SignerType = signerType,
                SigningOrder = docSigner.SigningOrder,
                IsSigned = docSigner.IsSigned,
                SigningDate = docSigner.SigningDate,
                SignRequestSentDate = docSigner.SignRequestSentDate,
                CreatedBy = docSigner.CreatedBy,
                ModifiedBy = docSigner.ModifiedBy,
                CreatedAt = docSigner.CreatedAt,
                ModifiedAt = docSigner.ModifiedAt,
                Active = docSigner.Active,

            };
            return docSignerResDto;
        }

    }

}

