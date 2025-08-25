
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IDocConfirmationRepository
    {
        Task<NewDocConfirmation> AddNewDocConfirmation(int docReqId, string ownerDepCode, string docTitle, string docCode, string reviewNo, string reviewText, string creatorUserPersonCode);
        Task<DocSigner> AddNewDocSigner(int newDocConfirmationId, string personCode, string name, string post, SignerColleagueType signerType, int signingOrder, string creatorUserPersonCode, string signRequestSentDate);
        Task<List<NewDocConfirmation>> GetAllDocConfirmations();
        Task<List<DocSigner>> GetDocConfirmationSigners(int docConfirmationId);
        Task<List<NewDocConfirmation>> GetUserDocConfirmations(string personCode, bool showCancelledDocConfirms, bool showAllDocConfirms);
        Task<NewDocConfirmation> GetDocConfirmationByDocReqIdAsync(int docReqId);
        Task<bool> SignDocConfirmationAsync(int docSignerId, string modifiedByPersonCode);
        Task<bool> UpdateSendSignRequestDate(int newDocSignerId, string personCode);
        Task<bool> UpdateDocConfirmStatusAsync(int docConfirmationId, DocRequestStatus status, string modifiedByUserPersonCode);
        Task<NewDocConfirmation> GetDocConfirmationByIdAsync(int docConfirmId);
        Task<bool> CancelSigningAsync(int docConfirmationId, string canceledByUserPersonCode);
        Task<DocConfirmationStateChange> AddDocConfirmationStateChangeAsync(int docConfirmationId, string senderUserPersonCode, string senderUserFullName, string senderUserPost, string receiverUserPersonCode, string receiverUserFullName, string receiverUserPost, string description, DocConfirmationStatus state);
        Task<List<DocConfirmationStateChange>> GetDocConfirmationStateChangesAsync(int docConfirmationId);
    }
}
