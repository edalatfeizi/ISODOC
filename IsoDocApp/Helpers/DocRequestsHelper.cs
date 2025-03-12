using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
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
        public static async Task<List<StepProgressBarItem>> GetDocRequestProgressBarSteps(List<DocRequestStep> steps)
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

                    stepItem.ContentBlock2.Description = $"زمان ارجاع درخواست: {dateTime} \n \n {docReqStep.Description}";
                    stepItem.State = StepProgressBarItemState.Active;

                    //stepItem.ContentBlock1.Caption = "تاریخ ثبت";
                    //stepItem.ContentBlock1.Description = $"{docReqStep.CreatedAt}";
                    // Add the StepItem to the StepProgressBar
                    items.Add(stepItem);
                }

                StepProgressBarItem lastStep = new StepProgressBarItem();
                lastStep.ContentBlock2.Caption = $"{steps[steps.Count - 1].ReceiverUserFullName} - {steps[steps.Count - 1].ReceiverUserPost}";
                lastStep.State = StepProgressBarItemState.Inactive;

                items.Add(lastStep);
            }
            return items;

        }
    }
}
