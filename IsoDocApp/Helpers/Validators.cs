using DevExpress.XtraEditors;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Helpers
{
    public static class Validators
    {
        public static bool HasEmptyValues<T>(params T[] types)
        {
            var isEmpty = false;
            try
            {
                foreach (var type in types)
                {

                    var control = type as BaseEdit;
                    if (type is BaseEdit && control.Enabled && string.IsNullOrEmpty(control.Text))
                        isEmpty = true;
                }
            }
            catch (Exception ex)
            {
                var frmMsgBox = new FrmMessageBox();

                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.ExceptionThrown,
                    Message = $"{ex.Message} : {ex.InnerException}",
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "cancel",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
                isEmpty = false;
            }
            return isEmpty;

        }
        public static bool ValidateControls<T>(params T[] types)
        {
            var frmMsgBox = new FrmMessageBox();

            if (HasEmptyValues(types))
            {
                frmMsgBox.SetMessageOptions(new CustomMessageBoxOptions()
                {
                    Title = StringResources.EmptyValues,
                    Message = StringResources.FillAllValues,
                    ConfirmButtonText = StringResources.Confirm,
                    DevExpressIconId = "warning",
                    DevExpressImageType = (int)DevExpress.Utils.Design.ImageType.Colored
                });
                frmMsgBox.ShowDialog();
                return false;
            }
            return true;

        }
    }
}
