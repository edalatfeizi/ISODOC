using DevExpress.Images;
using DevExpress.XtraEditors;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using IsoDoc.Domain.Models;
using IsoDocApp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace IsoDocApp
{
    public static class StepsProgressBarHelper
    {
        public static async Task<List<StepProgressBarItem>> GetDocRequestProgressBarSteps(List<DocRequestStep> steps, DocRequestStatus docRequestStatus, string cancelOrDeleteDsc)
        {
            var items = new List<StepProgressBarItem>();
            try
            {
                if (steps.Count() > 0)
                {
                    foreach (var docReqStep in steps)
                    {
                        // Create a new StepItem for each task
                        StepProgressBarItem stepItem = new StepProgressBarItem();
                        stepItem.ContentBlock2.Caption = $"{StringResources.From}: {docReqStep.SenderUserFullName} - {docReqStep.SenderUserPost} {StringResources.To}: {docReqStep.ReceiverUserFullName} - {docReqStep.ReceiverUserPost}";

                        stepItem.ContentBlock2.Description = $"{StringResources.CreateDateAndTime} {docReqStep.CreatedAt.FormatPersianDate()} \n \n {docReqStep.Description}";
                        stepItem.State = StepProgressBarItemState.Active;
                        //stepItem.ContentBlock1.Caption = "تاریخ ثبت";
                        //stepItem.ContentBlock1.Description = $"{docReqStep.CreatedAt}";
                        // Add the StepItem to the StepProgressBar
                        items.Add(stepItem);
                    }

                    StepProgressBarItem lastStep = new StepProgressBarItem();
                    lastStep.ContentBlock2.Caption = $"{steps[steps.Count - 1].ReceiverUserFullName} - {steps[steps.Count - 1].ReceiverUserPost}";

                    lastStep.State = StepProgressBarItemState.Active;
                    var desc = $"{StringResources.CreateDateAndTime} {steps[steps.Count - 1].CreatedAt.FormatPersianDate()} \n \n {StringResources.Status} ";
                    switch (docRequestStatus)
                    {
                        case DocRequestStatus.Canceled:
                            SetStepItemIcon(lastStep, "cancel",false);
                            var cancelDesc = $"{StringResources.CancelReason} \n {StringResources.Description} {cancelOrDeleteDsc}";
                            desc += cancelDesc;

                            lastStep.ContentBlock2.Description = desc;
                            break;

                        case DocRequestStatus.Deleted:
                            SetStepItemIcon(lastStep, "trash", false);

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
                            desc = $"{StringResources.ReceiveDateAndTime} {steps[steps.Count - 1].CreatedAt.FormatPersianDate()} \n \n {StringResources.Status} {StringResources.InProgress}";

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

        public static async Task<List<StepProgressBarItem>> GetDocConfirmationSignersSteps(List<DocSignerResDto> signers, NewDocConfirmationResDto docConfirm, Person sysAdmin, Person sysOfficeBoss)
        {
            var items = new List<StepProgressBarItem>();
            try
            {
                var desc = "";
                if (signers.Count() > 0)
                {
                    StepProgressBarItem startStep = new StepProgressBarItem();
                    startStep.ContentBlock2.Caption = $"{StringResources.StartingDocSigningProcess}";
                    startStep.State = StepProgressBarItemState.Inactive;
                    SetStepItemIcon(startStep, "img_inactive_state", true);
                    desc = $"{StringResources.DocTitle} : {docConfirm.DocTitle} \n {StringResources.StartTime} : {docConfirm.CreatedAt.FormatPersianDate()}";
                    startStep.ContentBlock2.Description = desc;
                    items.Add(startStep);

                    foreach (var signer in signers)
                    {
                        // Create a new StepItem for each task
                        var stepItem = new StepProgressBarItem();
                        stepItem.ContentBlock2.Caption = $"{signer.Name} - {signer.Post}";

                        if (signer.IsCanceled)
                        {

                            stepItem.ContentBlock2.Caption = $"{StringResources.From}: {signer.Name} - {signer.Post} {StringResources.To} {sysOfficeBoss.FirstName} {sysOfficeBoss.LastName} - {sysOfficeBoss.Posttxt}";

                            desc = $"{StringResources.Status} {StringResources.CancelSigningDoc} \n {StringResources.CancelSigningReason} : {signer.CancelReason} \n {StringResources.CancelSigningDate} : {signer.CreatedAt.FormatPersianDate()}";
                            stepItem.State = StepProgressBarItemState.Active;
                            SetStepItemIcon(stepItem, "cancel", false);
                            stepItem.ContentBlock2.Description = desc;

                        }
                        else if ((signer.IsSigned && signer.Active) || (signer.IsSigned && !signer.Active))
                        {
                            stepItem.State = StepProgressBarItemState.Active;
                            desc = $"{StringResources.SignerType}: {signer.SignerType} \n {StringResources.Status} {StringResources.Signed} \n {StringResources.SigningDate}: {signer.SigningDate.FormatPersianDate()}";
                            stepItem.ContentBlock2.Description = desc;
                            stepItem.State = StepProgressBarItemState.Active;


                        }
                        else if (!signer.IsSigned && signer.Active) //sign request sent
                        {
                            desc = $"{StringResources.SignerType}: {signer.SignerType} \n {StringResources.Status} {StringResources.SignRequestSent} \n {StringResources.SignRequestSentDate}: {signer.SignRequestSentDate.FormatPersianDate()}";
                            stepItem.ContentBlock2.Description = desc;
                            stepItem.State = StepProgressBarItemState.Inactive;
                            SetStepItemIcon(stepItem, "img_inactive_state", true);

                        }
                        else if (!signer.IsSigned && !signer.Active) // sign request not sent
                        {
                            desc = $"{StringResources.SignerType}: {signer.SignerType} \n{StringResources.Status} {StringResources.SignRequestNotSent}";
                            stepItem.ContentBlock2.Description = desc;
                            stepItem.State = StepProgressBarItemState.Inactive;
                            SetStepItemIcon(stepItem, "img_inactive_state", true);

                        }

                        items.Add(stepItem);
                    }

                    var endStepItem = new StepProgressBarItem();
                    endStepItem.ContentBlock2.Caption = $"{StringResources.EndSigningDocProcess}";

                    if (docConfirm.ConfirmationStatus == DocRequestStatus.Completed)
                    {
                        endStepItem.State = StepProgressBarItemState.Active;
                        desc = $"{StringResources.EndTime} : {docConfirm.ModifiedAt}";
                    }
                    else
                    {
                        endStepItem.State = StepProgressBarItemState.Inactive;
                        desc = "";
                        SetStepItemIcon(endStepItem, "img_inactive_state", true);

                    }
                    endStepItem.ContentBlock2.Description = desc;


                    items.Add(endStepItem);


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
        private static void SetStepItemIcon(StepProgressBarItem stepItem, string iconName, bool fromLocalResources)
        {
            if (fromLocalResources)
            {
                stepItem.Options.Indicator.ActiveStateImageOptions.Image = Properties.Resources.ResourceManager.GetObject(iconName) as Image;
            }
            else
            {
                stepItem.Options.Indicator.ActiveStateImageOptions.Image = ImageResourceCache.Default.GetImageById(iconName, DevExpress.Utils.Design.ImageSize.Size32x32, DevExpress.Utils.Design.ImageType.Colored);
            }

        }
    }
}
