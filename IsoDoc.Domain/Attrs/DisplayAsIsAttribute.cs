using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Attrs
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayAsIsAttribute : Attribute
    {
        // Marker attribute to indicate the property should be displayed as-is

    }
}
