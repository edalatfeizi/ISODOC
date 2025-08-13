
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Models;
using IsoDoc.Domain.Resources;
using System.Collections.Generic;

namespace IsoDoc.Domain.Extensions
{
    public static class DocConfirmationStateChangeExtensions
    {
        public static List<DocConfirmationStateChangeResDto> MapToDocConfirmationStateChangeResDtos(this List<DocConfirmationStateChange> statesChanges, int? page = null, int? pageSize = null)
        {
            var result = new List<DocConfirmationStateChangeResDto>();
            if (page == null || pageSize == null)
            {
                page = 1;
                pageSize = statesChanges.Count;
            }
            for (int i = 0; i < statesChanges.Count; i++)
            {
                var index = (page - 1) * pageSize + i + 1;
                var dto = statesChanges[i].MapToDocConfirmationStateChangeResDto(index);
                dto.Index = index ?? 0;
                result.Add(dto);
            }
            return result;
        }

        public static DocConfirmationStateChangeResDto MapToDocConfirmationStateChangeResDto(this DocConfirmationStateChange statesChange, int? index = 0)
        {
            var statesChangeResDto = new DocConfirmationStateChangeResDto()
            {
                Index = index ?? 0,
                Id = statesChange.Id,
                DocConfirmationId = statesChange.DocConfirmationId,
                SenderUserPersonCode = statesChange.SenderUserPersonCode,
                SenderUserFullName = statesChange.SenderUserFullName,
                SenderUserPost = statesChange.SenderUserPost,
                ReceiverUserPersonCode = statesChange.ReceiverUserPersonCode,
                ReceiverUserFullName = statesChange.ReceiverUserFullName,
                ReceiverUserPost = statesChange.ReceiverUserPost,
                Description = statesChange.Description,
                CreatedBy = statesChange.CreatedBy,
                ModifiedBy = statesChange.ModifiedBy,
                CreatedAt = statesChange.CreatedAt,
                ModifiedAt = statesChange.ModifiedAt,
                Status = statesChange.Status,
                Active = statesChange.Active,

            };
            return statesChangeResDto;
        }

        public static List<ProcessStep> MapToProcessSteps(this List<DocConfirmationStateChangeResDto> statesChanges, int? page = null, int? pageSize = null)
        {
            var result = new List<ProcessStep>();
            if (page == null || pageSize == null)
            {
                page = 1;
                pageSize = statesChanges.Count;
            }
            for (int i = 0; i < statesChanges.Count; i++)
            {
                var index = (page - 1) * pageSize + i + 1;
                var dto = statesChanges[i].MapToProcessStep(index);
                dto.Index = index ?? 0;
                result.Add(dto);
            }
            return result;
        }
        public static ProcessStep MapToProcessStep(this DocConfirmationStateChangeResDto statesChange, int? index = 0)
        {
            var processStep = new ProcessStep()
            {
                Title = $"{StringResources.From}: {statesChange.SenderUserFullName} - {statesChange.SenderUserPost} \n {StringResources.To}: {statesChange.ReceiverUserFullName} - {statesChange.ReceiverUserPost}",
                CreatedAt = statesChange.CreatedAt,
            };
            switch (statesChange.Status)
            {
                case DocConfirmationStatus.Completed:
                    processStep.Description = $"{StringResources.Status} {StringResources.StartingDocSigningProcess} \n {StringResources.Description} : {statesChange.Description} \n {StringResources.StartTime} : {statesChange.CreatedAt.FormatPersianDate()}";
                    processStep.Status = ProcessStepStatus.Completed;

                    break;
                case DocConfirmationStatus.Canceled:
                    processStep.Description = $"{StringResources.Status} {StringResources.CancelSigningDoc} \n {StringResources.CancelSigningReason} : {statesChange.Description} \n {StringResources.CancelSigningDate} : {statesChange.CreatedAt.FormatPersianDate()}";
                    processStep.Status = ProcessStepStatus.Canceled;

                    break;
                default:
                    break;
            }
            return processStep;
        }
    }

}

