using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Models;
using IsoDoc.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Extensions
{
    public static class DocRequestStepExtensions
    {
        public static List<ProcessStep> MapToProcessSteps(this List<DocRequestStep> docSteps,DocRequest docRequest, int? page = null, int? pageSize = null)
        {
            var result = new List<ProcessStep>();
            if (page == null || pageSize == null)
            {
                page = 1;
                pageSize = docSteps.Count;
            }
            for (int i = 0; i < docSteps.Count; i++)
            {
                var index = (page - 1) * pageSize + i + 1;
                var dto = docSteps[i].MapToProcessStep(index);
                dto.Index = index ?? 0;
                result.Add(dto);
            }
            result.Add(docSteps.Last().GenerateLastProcessStep(docRequest));
            return result;
        }

        public static ProcessStep MapToProcessStep(this DocRequestStep docReqStep, int? index = 0)
        {
            var processStep = new ProcessStep()
            {
                Title = $"{StringResources.From}: {docReqStep.SenderUserFullName} - {docReqStep.SenderUserPost} \n {StringResources.To}: {docReqStep.ReceiverUserFullName} - {docReqStep.ReceiverUserPost}",
                Description = $"{StringResources.CreateDateAndTime} {docReqStep.CreatedAt.FormatPersianDate()} \n \n {docReqStep.Description}",
                Status = ProcessStepStatus.Completed,
                CreatedAt = docReqStep.CreatedAt,
            };
            
            return processStep;
        }

        private static ProcessStep GenerateLastProcessStep(this DocRequestStep step, DocRequest docRequest)
        {
            var lastStep = new ProcessStep();
            lastStep.Title = $"{step.ReceiverUserFullName} - {step.ReceiverUserPost}";
            lastStep.Description = $"{StringResources.CreateDateAndTime} {step.CreatedAt.FormatPersianDate()} \n \n {StringResources.Status} ";
            switch (docRequest.DocRequestStatus)
            {
                case DocRequestStatus.InProgress:
                    lastStep.Status = ProcessStepStatus.InProgress;
                    lastStep.Description = $"{StringResources.ReceiveDateAndTime} {step.CreatedAt.FormatPersianDate()} \n \n {StringResources.Status} {StringResources.InProgress}";
                    break;
                case DocRequestStatus.Completed:
                    lastStep.Status = ProcessStepStatus.Completed;
                    lastStep.Description += $"{StringResources.Completed}";
                    break;
                case DocRequestStatus.Canceled:
                    lastStep.Status = ProcessStepStatus.Canceled;
                    lastStep.Description += $"{StringResources.CancelRequest} \n {StringResources.Description}: {docRequest.CancelDesc}";

                    break;
                case DocRequestStatus.Deleted:
                    lastStep.Status = ProcessStepStatus.Deleted;
                    lastStep.Description += $"{StringResources.DeleteRequest} \n {StringResources.Description}: {docRequest.DeleteDesc}";
                    break;
                default:
                    break;
            }
            return lastStep;
        }

    }
}
