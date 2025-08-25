
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Req;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IDocConfirmationService
    {
        Task<NewDocConfirmationResDto> GetDocConfirmationByIdAsync(int docConfirmId);
        Task<NewDocConfirmation> AddNewDocConfirmationAsync(NewDocConfirmationDto dto);
        Task<DocSigner> AddNewDocSignersAsync(NewDocSignerDto dto);
        Task<List<NewDocConfirmationResDto>> GetAllDocConfirmationsAsync();
        Task<List<DocSignerResDto>> GetDocConfirmationSignersAsync(int docConfirmationId);
        Task<List<NewDocConfirmationResDto>> GetUserDocConfirmationsAsync(string personCode, bool showCancelledDocConfirms, bool showAllDocConfirms);
        Task<NewDocConfirmationResDto> GetDocConfirmationByDocReqIdAsync(int docReqId);
        Task<bool> SignDocConfirmationAsync(int docSignerId, string modifiedByPersonCode);
        Task<bool> UpdateSendSignRequestDate(int newDocSignerId, string personCode);
        Task<bool> UpdateDocConfirmStatusAsync(int docConfirmationId,DocRequestStatus status, string updatedByUserPersonCode);
        Task<bool> CancelSigningAsync(int docConfirmationId, string canceledByUserPersonCode);
        Task<DocConfirmationStateChangeResDto> AddDocConfirmationStateChangeAsync(DocConfirmationStateChangeReqDto dto);
        Task<List<DocConfirmationStateChangeResDto>> GetDocConfirmationStateChangesAsync(int docConfirmationId);

    }
}
