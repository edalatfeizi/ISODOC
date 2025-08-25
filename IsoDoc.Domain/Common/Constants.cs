using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Common
{
    public static class Constants
    {
        public static readonly string DocReqAttachmentFileTypes = "All supported|*.pdf;*.doc;*.docx;*.xls;*.xlsx|Word Files|*.docx;*.doc|Excel Files|*.xlsx;*.xls|PDF Files|*.pdf";
        public static readonly string PersonSignatureFileTypes = "PNG Images|*.png";
        public static readonly List<string> DeveloperPersonCodes = new List<string>()
        {
            "14023910",
            "903015"
        };

        public static readonly string SysAdminCode = "SI000";
        public static readonly string SysOfficeCode = "SI300"; //

        public static readonly string CEOOfficeBossDepCode = "AI0950"; //کد اداره رئیس حوزه مدیر عامل
        public static readonly string CEOOfficeSecretaryDepCode = "AI0954"; //کد اداره مسئول دفتر مدیرعامل

        public static readonly string CEODepCode = "A1000"; //کد اداره مدیر عامل
        public static readonly string DeputyDepCode = "DM1038"; //کد ادراه قائم مقام 
        public static readonly string BoardOfDirectorsDepCode = "A0000"; //کد اداره اعضای هیئت مدیره 
    }
}
