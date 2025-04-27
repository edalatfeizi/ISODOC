using DevExpress.Images;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp
{
    public static class DocRequestsHelper
    {
        public static async Task<List<StepProgressBarItem>> GetDocRequestProgressBarSteps(List<DocRequestStep> steps, DocRequestStatus docRequestStatus, string cancelOrDeleteDsc)
        {
            var items = new List<StepProgressBarItem>();

            if (steps.Count() > 0)
            {
                foreach (var docReqStep in steps)
                {
                    // Create a new StepItem for each task
                    StepProgressBarItem stepItem = new StepProgressBarItem();
                    stepItem.ContentBlock2.Caption = $"{docReqStep.SenderUserFullName} - {docReqStep.SenderUserPost}";

                    var createDate = DateTime.Parse(docReqStep.CreatedAt);
                    var dateTime = $"{createDate.Hour}:{createDate.Minute} {createDate.Year}/{createDate.Month}/{createDate.Day}";
                    //var amPm =  createDate.ToString("tt") ;

                    stepItem.ContentBlock2.Description = $"{StringResources.CreateDateAndTime} {dateTime} \n \n {docReqStep.Description}";
                    stepItem.State = StepProgressBarItemState.Active;
                    //stepItem.ContentBlock1.Caption = "تاریخ ثبت";
                    //stepItem.ContentBlock1.Description = $"{docReqStep.CreatedAt}";
                    // Add the StepItem to the StepProgressBar
                    items.Add(stepItem);
                }

                StepProgressBarItem lastStep = new StepProgressBarItem();
                lastStep.ContentBlock2.Caption = $"{steps[steps.Count - 1].ReceiverUserFullName} - {steps[steps.Count - 1].ReceiverUserPost}";
                var lastStepcreateDate = DateTime.Parse(steps[steps.Count - 1].CreatedAt);
                var lastStepDateTime = $"{lastStepcreateDate.Hour}:{lastStepcreateDate.Minute} {lastStepcreateDate.Year}/{lastStepcreateDate.Month}/{lastStepcreateDate.Day}";
                lastStep.State = StepProgressBarItemState.Active;
                var desc = $"{StringResources.CreateDateAndTime} {lastStepDateTime} \n \n {StringResources.Status} ";
                switch (docRequestStatus)
                {
                    case DocRequestStatus.Canceled:
                        lastStep.Options.Indicator.ActiveStateImageOptions.Image = ImageResourceCache.Default.GetImageById("cancel", DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored);
                        var cancelDesc = $"{StringResources.CancelReason} \n {StringResources.Description} {cancelOrDeleteDsc}";
                        desc += cancelDesc;

                        lastStep.ContentBlock2.Description = desc;
                        break;

                    case DocRequestStatus.Deleted:
                        lastStep.Options.Indicator.ActiveStateImageOptions.Image = ImageResourceCache.Default.GetImageById("trash", DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored);
                        var deletedDesc = $"{StringResources.DeleteRequest} \n {StringResources.Description} {cancelOrDeleteDsc}";
                        desc += deletedDesc;

                        lastStep.ContentBlock2.Description = desc;

                        break;
                    case DocRequestStatus.Completed:
                        var completedDesc = $"{StringResources.Completed}";
                        desc += completedDesc;
                        lastStep.ContentBlock2.Description = desc;
                        break;
                    case DocRequestStatus.InProgress:
                        lastStep.State = StepProgressBarItemState.Inactive;
                         desc = $"{StringResources.ReceiveDateAndTime} {lastStepDateTime} \n \n {StringResources.Status} {StringResources.InProgress}";

                        lastStep.ContentBlock2.Description = desc;

                        break;

                }

                items.Add(lastStep);
            }
            return items;

        }
    }
}
