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
 

        public static async Task<List<StepProgressBarItem>> GetProcessSteps(List<ProcessStep> steps)
        {
            var items = new List<StepProgressBarItem>();
            try
            {
                foreach (var step in steps)
                {
                    // Create a new StepItem for each task
                    var stepItem = new StepProgressBarItem();
                    stepItem.ContentBlock2.Caption = step.Title;
                    stepItem.ContentBlock2.Description = step.Description;
                    switch (step.Status)
                    {
                        case ProcessStepStatus.InProgress:
                        case ProcessStepStatus.Inactive:
                            stepItem.State = StepProgressBarItemState.Inactive;
                            // used a local icon for inactive state in order to prevent overwriting of last active item icon over last inactive items
                            SetStepItemIcon(stepItem, "img_inactive_state", true);
                            break;
                        case ProcessStepStatus.Completed:
                            stepItem.State = StepProgressBarItemState.Active;
                            break;
                        case ProcessStepStatus.Canceled:
                            stepItem.State = StepProgressBarItemState.Active;
                            SetStepItemIcon(stepItem, "cancel", false);

                            break;
                        case ProcessStepStatus.Deleted:
                            stepItem.State = StepProgressBarItemState.Active;
                            SetStepItemIcon(stepItem, "trash", false);
                            break;
                    }
                    items.Add(stepItem);
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
