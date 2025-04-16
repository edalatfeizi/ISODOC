using IsoDoc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Helpers
{
    public static class UserHelper
    {
        public static bool CheckIsAdmin(string postTypeId)
        {
            return AdminTypes.GetAdminTypes().Any(x => x == ((AdminType)Convert.ToInt32(postTypeId)));
        }
    }
}
