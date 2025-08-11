using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Enums
{
    public enum PostTypes
    {
        [Display(Name = "سرپرست اداره")]
        OfficeSupervisor = 50,

        [Display(Name = "رئیس/مسئول بلافصل")]
        Boss = 4,

        [Display(Name = "مدیر")]
        Admin = 3,

        [Display(Name = "جانشین مدیر")]
        DepDeputyManager = 27,

        [Display(Name = "جانشین مدیر")]
        DepSupervisor = 26,
    }
}
