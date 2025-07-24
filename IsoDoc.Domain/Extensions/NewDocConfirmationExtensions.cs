
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using System.Collections.Generic;

namespace IsoDoc.Domain.Extensions
{
    public static class NewDocConfirmationExtensions
    {
        public static List<NewDocConfirmationResDto> MapToNewDocConfirmationDtos(this List<NewDocConfirmation> docConfirmations, int? page = null, int? pageSize = null)
        {
            var result = new List<NewDocConfirmationResDto>();
            if (page == null || pageSize == null)
            {
                page = 1;
                pageSize = docConfirmations.Count;
            }
            for (int i = 0; i < docConfirmations.Count; i++)
            {
                var index = (page - 1) * pageSize + i + 1;
                var dto = docConfirmations[i].MapToNewDocConfirmationDto(index);
                dto.Index = index ?? 0;
                result.Add(dto);
            }
            return result;
        }

        public static NewDocConfirmationResDto MapToNewDocConfirmationDto(this NewDocConfirmation docConfirmation, int? index = 0)
        {
            var docConfirmResDto = new NewDocConfirmationResDto()
            {
                Index = index ?? 0,
                Id = docConfirmation.Id,
                DocReqId = docConfirmation.DocReqId,
                DocOwnerDepCode = docConfirmation.DocOwnerDepCode,
                DocTitle = docConfirmation.DocTitle,
                DocCode = docConfirmation.DocCode,
                ReviewNo = docConfirmation.ReviewNo,
                ReviewText = docConfirmation.ReviewText,
                CreatedBy = docConfirmation.CreatedBy,
                ModifiedBy = docConfirmation.ModifiedBy,
                CreatedAt = docConfirmation.CreatedAt,
                ModifiedAt = docConfirmation.ModifiedAt,
                Active = docConfirmation.Active,

            };
            return docConfirmResDto;
        }

    }

}

