using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Services
{
    public class DocConfirmationService : IDocConfirmationService
    {
        private readonly IDocConfirmationRepository docConfirmationRepo;
        public DocConfirmationService(IDocConfirmationRepository docConfirmationRepo)
        {
            this.docConfirmationRepo = docConfirmationRepo;
        }

        public async Task<NewDocConfirmation> AddNewDocConfirmation(NewDocConfirmationDto dto)
        {
            var newDocConfirmation = await docConfirmationRepo.AddNewDocConfirmation(dto.OwnerDepCode, dto.DocTitle, dto.DocCode, dto.ReviewNo, dto.ReviewText, dto.CreatorUserPersonCode);
            
            return newDocConfirmation;
        }

        public async Task<DocSigner> AddNewDocSigners(NewDocSignerDto dto)
        {
            var newDocSigner = await docConfirmationRepo.AddNewDocSigner(dto.NewDocConfirmationId,dto.PersonCode,dto.Name,dto.Post,dto.SignerType,dto.SigningOrder,dto.IsSigned, dto.CreatorUserPersonCode);

            return newDocSigner;
        }
    }
}
