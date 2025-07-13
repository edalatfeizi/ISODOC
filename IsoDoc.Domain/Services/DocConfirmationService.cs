using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Extensions;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using System.Collections.Generic;
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
            var newDocConfirmation = await docConfirmationRepo.AddNewDocConfirmation(dto.DocOwnerDepCode, dto.DocTitle, dto.DocCode, dto.ReviewNo, dto.ReviewText, dto.CreatorUserPersonCode);
            
            return newDocConfirmation;
        }

        public async Task<DocSigner> AddNewDocSigners(NewDocSignerDto dto)
        {
            var newDocSigner = await docConfirmationRepo.AddNewDocSigner(dto.NewDocConfirmationId,dto.PersonCode,dto.Name,dto.Post,dto.SignerType,dto.SigningOrder,dto.IsSigned, dto.CreatorUserPersonCode);

            return newDocSigner;
        }

        public async Task<List<NewDocConfirmationResDto>> GetAllDocConfirmations()
        {
            var result = await docConfirmationRepo.GetAllDocConfirmations();

            return result.MapToNewDocConfirmationDtos();
        }

        public async Task<List<DocSignerResDto>> GetDocConfirmationSigners(int docConfirmationId)
        {
           var result = await docConfirmationRepo.GetDocConfirmationSigners(docConfirmationId);

           return result.MapToDocSignerResDtos();
        }
    }
}
