using DevExpress.Images;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using IsoDocApp.Extensions;
using IsoDocApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp
{
    public static class DocConfirmationsHelper
    {
        public static async Task<List<StepProgressBarItem>> GetDocConfirmationSignersSteps(List<DocSignerResDto> signers)
        {
            var items = new List<StepProgressBarItem>();
            try
            {
                var desc = "";
                if (signers.Count() > 0)
                {
                    foreach (var signer in signers)
                    {
                        // Create a new StepItem for each task
                        StepProgressBarItem stepItem = new StepProgressBarItem();
                        stepItem.ContentBlock2.Caption = $"{signer.Name} - {signer.Post}";

                        stepItem.ContentBlock2.Description = signer.IsSigned ? $"{StringResources.SigningDate}: {signer.SigningDate.FormatPersianDate()}" : $"{StringResources.InProgress}";
                        stepItem.State = signer.IsSigned ? StepProgressBarItemState.Active : StepProgressBarItemState.Inactive;
                        //stepItem.ContentBlock1.Caption = "تاریخ ثبت";
                        //stepItem.ContentBlock1.Description = $"{docReqStep.CreatedAt}";
                        // Add the StepItem to the StepProgressBar
                        items.Add(stepItem);
                    }

                    //StepProgressBarItem lastStep = new StepProgressBarItem();
                    //lastStep.ContentBlock2.Caption = $"{steps[steps.Count - 1].ReceiverUserFullName} - {steps[steps.Count - 1].ReceiverUserPost}";

                    //lastStep.State = StepProgressBarItemState.Active;
                    //desc = $"{StringResources.CreateDateAndTime} {steps[steps.Count - 1].CreatedAt.FormatPersianDate()} \n \n {StringResources.Status} ";
                    //switch (docRequestStatus)
                    //{
                    //    case DocRequestStatus.Canceled:
                    //        lastStep.Options.Indicator.ActiveStateImageOptions.Image = ImageResourceCache.Default.GetImageById("cancel", DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored);
                    //        var cancelDesc = $"{StringResources.CancelReason} \n {StringResources.Description} {cancelOrDeleteDsc}";
                    //        desc += cancelDesc;

                    //        lastStep.ContentBlock2.Description = desc;
                    //        break;

                    //    case DocRequestStatus.Deleted:
                    //        lastStep.Options.Indicator.ActiveStateImageOptions.Image = ImageResourceCache.Default.GetImageById("trash", DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored);
                    //        var deletedDesc = $"{StringResources.DeleteRequest} \n {StringResources.Description} {cancelOrDeleteDsc}";
                    //        desc += deletedDesc;

                    //        lastStep.ContentBlock2.Description = desc;

                    //        break;
                    //    case DocRequestStatus.Completed:
                    //        var completedDesc = $"{StringResources.Completed}";
                    //        desc += completedDesc;
                    //        lastStep.ContentBlock2.Description = desc;
                    //        break;
                    //    case DocRequestStatus.InProgress:
                    //        lastStep.State = StepProgressBarItemState.Inactive;
                    //        desc = $"{StringResources.ReceiveDateAndTime} {steps[steps.Count - 1].CreatedAt.FormatPersianDate()} \n \n {StringResources.Status} {StringResources.InProgress}";

                    //        lastStep.ContentBlock2.Description = desc;

                    //        break;

                    //}

                    //items.Add(lastStep);
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
