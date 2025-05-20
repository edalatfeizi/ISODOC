using DevExpress.Images;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Helpers;
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
            try
            {
                if (steps.Count() > 0)
                {
                    DateTime gregorianDate;
                    string persianDateStr;
                    foreach (var docReqStep in steps)
                    {
                        // Create a new StepItem for each task
                        StepProgressBarItem stepItem = new StepProgressBarItem();
                        stepItem.ContentBlock2.Caption = $"{docReqStep.SenderUserFullName} - {docReqStep.SenderUserPost}";

                        gregorianDate = PersianDateParser.ParsePersianDateTime(docReqStep.CreatedAt);
                        persianDateStr = PersianDateParser.GetPersianDateParts(gregorianDate);

                        stepItem.ContentBlock2.Description = $"{StringResources.CreateDateAndTime} {persianDateStr} \n \n {docReqStep.Description}";
                        stepItem.State = StepProgressBarItemState.Active;
                        //stepItem.ContentBlock1.Caption = "تاریخ ثبت";
                        //stepItem.ContentBlock1.Description = $"{docReqStep.CreatedAt}";
                        // Add the StepItem to the StepProgressBar
                        items.Add(stepItem);
                    }

                    StepProgressBarItem lastStep = new StepProgressBarItem();
                    lastStep.ContentBlock2.Caption = $"{steps[steps.Count - 1].ReceiverUserFullName} - {steps[steps.Count - 1].ReceiverUserPost}";

                    gregorianDate = PersianDateParser.ParsePersianDateTime(steps[steps.Count - 1].CreatedAt);

                    persianDateStr = PersianDateParser.GetPersianDateParts(gregorianDate);

                    lastStep.State = StepProgressBarItemState.Active;
                    var desc = $"{StringResources.CreateDateAndTime} {persianDateStr} \n \n {StringResources.Status} ";
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
                            desc = $"{StringResources.ReceiveDateAndTime} {persianDateStr} \n \n {StringResources.Status} {StringResources.InProgress}";

                            lastStep.ContentBlock2.Description = desc;

                            break;

                    }

                    items.Add(lastStep);
                }
            }
            catch (Exception ex)
            {
                var frmMsgBox = new FrmMessageBox();
                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ErrorProccessingData,
                    Message = $"{ex.Message} \n {ex.InnerException}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
            }

            return items;

        }
    }
}
