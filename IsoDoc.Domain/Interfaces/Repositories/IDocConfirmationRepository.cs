
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IDocConfirmationRepository
    {
        Task<NewDocConfirmation> AddNewDocConfirmation(string ownerDepCode, string docTitle, string docCode, string reviewNo, string reviewText, string creatorUserPersonCode);
        Task<NewDocSigner> AddNewDocSigner(int newDocConfirmationId, string personCode, string name, string post, SignerColleagueType signerType, int signingOrder, bool isSigned, string creatorUserPersonCode);

    }
}
