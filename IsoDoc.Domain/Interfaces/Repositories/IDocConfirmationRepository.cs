
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IDocConfirmationRepository
    {
        Task<NewDocConfirmation> AddNewDocConfirmation(int docReqId, string ownerDepCode, string docTitle, string docCode, string reviewNo, string reviewText, string creatorUserPersonCode);
        Task<DocSigner> AddNewDocSigner(int newDocConfirmationId, string personCode, string name, string post, SignerColleagueType signerType, int signingOrder, bool isSigned, string creatorUserPersonCode, bool active);
        Task<List<NewDocConfirmation>> GetAllDocConfirmations();
        Task<List<DocSigner>> GetDocConfirmationSigners(int docConfirmationId);
        Task<List<NewDocConfirmation>> GetUserDocConfirmations(string personCode);
        Task<NewDocConfirmation> GetDocConfirmationByDocReqIdAsync(int docReqId);
    }
}
