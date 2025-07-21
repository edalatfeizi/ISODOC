
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IDocConfirmationService
    {
        Task<NewDocConfirmation> AddNewDocConfirmationAsync(NewDocConfirmationDto dto);
        Task<DocSigner> AddNewDocSignersAsync(NewDocSignerDto dto);
        Task<List<NewDocConfirmationResDto>> GetAllDocConfirmationsAsync();
        Task<List<DocSignerResDto>> GetDocConfirmationSignersAsync(int docConfirmationId);
        Task<List<NewDocConfirmationResDto>> GetUserDocConfirmationsAsync(string personCode);
        Task<NewDocConfirmationResDto> GetDocConfirmationByDocReqIdAsync(int docReqId);

    }
}
