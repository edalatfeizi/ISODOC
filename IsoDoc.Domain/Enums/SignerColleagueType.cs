
using System.ComponentModel.DataAnnotations;

namespace IsoDoc.Domain.Enums
{
    public enum SignerColleagueType
    {
        [Display(Name = "تهیه کننده")]
        Creator ,
        [Display(Name = "تایید کننده")]
        Confirmer,
        [Display(Name = "تصویب کننده")]
        Acceptor
    }
}
