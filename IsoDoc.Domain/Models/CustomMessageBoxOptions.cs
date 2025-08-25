using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Models
{
    public class CustomMessageBoxOptions
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public bool ShowConfirmButton { get; set; } = true;
        public bool ShowCancelButton { get; set; } = false;
        public string ConfirmButtonText { get; set; }
        public string CancelButtonText { get; set; }
        public string DevExpressIconId { get; set; }
        public string CustomTitleIconName { get; set; } 
        public int DevExpressImageType { get; set; } //DevExpress.Utils.Design.ImageType.Colored
        public bool IsInputBox { get; set; } = false;
    }
}
