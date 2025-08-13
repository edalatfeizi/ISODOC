
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Models;
using IsoDoc.Domain.Resources;
using System.Collections.Generic;

namespace IsoDoc.Domain.Extensions
{
    public static class DocSignersResExtensions
    {
       
      
        public static List<ProcessStep> MapToProcessSteps(this List<DocSignerResDto> signer, int? page = null, int? pageSize = null)
        {
            var result = new List<ProcessStep>();
            if (page == null || pageSize == null)
            {
                page = 1;
                pageSize = signer.Count;
            }
            for (int i = 0; i < signer.Count; i++)
            {
                var index = (page - 1) * pageSize + i + 1;
                var dto = signer[i].MapToProcessStep(index);
                dto.Index = index ?? 0;
                result.Add(dto);
            }
            return result;
        }

        public static ProcessStep MapToProcessStep(this DocSignerResDto signer, int? index = 0)
        {
            var processStep = new ProcessStep()
            {
                Title = $"{signer.Name} - {signer.Post}",
                CreatedAt = signer.CreatedAt,
            };

            if (signer.IsSigned)
            {
                processStep.Status = ProcessStepStatus.Completed;
                processStep.Description = $"{StringResources.SignerType}: {signer.SignerType} \n {StringResources.Status} {StringResources.Signed} \n {StringResources.SigningDate}: {signer.SigningDate.FormatPersianDate()}";
            }
            else if (!signer.IsSigned && signer.SignRequestSentDate != null) //sign request sent
            {
                processStep.Status = ProcessStepStatus.Inactive;
                processStep.Description = $"{StringResources.SignerType}: {signer.SignerType} \n {StringResources.Status} {StringResources.SignRequestSent} \n {StringResources.SignRequestSentDate}: {signer.SignRequestSentDate.FormatPersianDate()}";

            }
            else if (!signer.IsSigned && signer.SignRequestSentDate == null) // sign request not sent
            {
                processStep.Status = ProcessStepStatus.Inactive;
                processStep.Description = $"{StringResources.SignerType}: {signer.SignerType} \n{StringResources.Status} {StringResources.SignRequestNotSent}";

            }
            return processStep;
        }
    }

}

