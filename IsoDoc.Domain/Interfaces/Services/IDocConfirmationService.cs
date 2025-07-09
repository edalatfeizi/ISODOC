
using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Entities;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IDocConfirmationService
    {
        Task<NewDocConfirmation> AddNewDocConfirmation(NewDocConfirmationDto dto);
        Task<NewDocSigner> AddNewDocSigners(NewDocSignerDto dto);

    }
}
