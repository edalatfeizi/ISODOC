
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IDocConfirmationService
    {
        Task<NewDocConfirmation> AddNewDocConfirmation(NewDocConfirmationDto dto);
        Task<DocSigner> AddNewDocSigners(NewDocSignerDto dto);
        Task<List<NewDocConfirmationResDto>> GetAllDocConfirmations();
        Task<List<DocSignerResDto>> GetDocConfirmationSigners(int docConfirmationId);

    }
}
