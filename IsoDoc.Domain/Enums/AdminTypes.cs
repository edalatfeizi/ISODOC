using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Enums
{
    public static class AdminTypes
    {
        public static List<AdminType> GetAdminTypes()
        {
            return new List<AdminType>() { AdminType.TopManager, AdminType.VP, AdminType.MidManager, AdminType.SuperVisor, AdminType.ViceManager };
        }
  
    }
    public enum AdminType
    {
        CEO = 1,
        TopManager = 2,
        VP = 49,
        MidManager = 3,
        SuperVisor = 26,
        ViceManager = 27
    }
}
