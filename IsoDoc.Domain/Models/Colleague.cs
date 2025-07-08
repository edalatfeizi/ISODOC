
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Models
{
    public class Colleague
    {
        [Display(Name = "شماره پرسنلی", Order =1)]
        [Editable(false)]
        public string PersonCode { get; set; }

        [Browsable(false)]
        public string CardNumber { get; set; }

        [Display(Name = "نام و نام خانوادگی", Order =2)]
        [Editable(false)]
        public string Name { get; set; }

        [Display(Name = "پست", Order =3)]
        [Editable(false)]
        public string Post { get; set; }

        [Browsable(false)]
        public string Mobile { get; set; }

        [Browsable(false)]
        public string PostTypeID { get; set; }

        [Browsable(false)]
        public string UpperCode { get; set; }

        [Browsable(false)]
        public string CodeEdare { get; set; }

    }
}
