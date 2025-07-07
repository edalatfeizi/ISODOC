
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Models
{
    public class SignerColleague : Colleague
    {
        [Display(Name = "نوع امضا کننده", Order = 4)]
        public string SignerColleagueType { get; set; }

        [Browsable(false)]
        public int Order { get; set; }
    }
}
