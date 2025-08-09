using IKIDMagfaSMSClientWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp
{
    public static class Constants
    {
        public static readonly SMSConfig SMSConfig = new SMSConfig("irankhodro", "T0XFCS1KAtVC4TOB", "+9830004607");
        public static readonly string DocReqAttachmentFileTypes = "Word Files|*.docx;*.doc|Excel Files|*.xlsx;*.xls|PDF Files|*.pdf";
        public static readonly string PersonSignatureFileTypes = "PNG Images|*.png";
        public static readonly List<string> DeveloperPersonCodes = new List<string>()
        {
            "14023910",
            "903015"
        };
    }
}
