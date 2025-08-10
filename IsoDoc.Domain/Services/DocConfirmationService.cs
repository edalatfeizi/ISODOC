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

        public async Task<NewDocConfirmation> AddNewDocConfirmationAsync(NewDocConfirmationDto dto)
        {
            var newDocConfirmation = await docConfirmationRepo.AddNewDocConfirmation(dto.DocReqId, dto.DocOwnerDepCode, dto.DocTitle, dto.DocCode, dto.ReviewNo, dto.ReviewText, dto.CreatorUserPersonCode);
            
            return newDocConfirmation;
        }

        public async Task<DocSigner> AddNewDocSignersAsync(NewDocSignerDto dto)
        {
            var newDocSigner = await docConfirmationRepo.AddNewDocSigner(dto.NewDocConfirmationId,dto.PersonCode,dto.Name,dto.Post,dto.SignerType,dto.SigningOrder,dto.IsSigned, dto.CreatorUserPersonCode, dto.SignRequestSentDate,dto.IsCanceled, dto.CancelReason, dto.Active);

            return newDocSigner;
        }

        

        public async Task<List<NewDocConfirmationResDto>> GetAllDocConfirmationsAsync()
        {
            var result = await docConfirmationRepo.GetAllDocConfirmations();

            return result.MapToNewDocConfirmationDtos();
        }

        public async Task<NewDocConfirmationResDto> GetDocConfirmationByDocReqIdAsync(int docReqId)
        {
            var result = await docConfirmationRepo.GetDocConfirmationByDocReqIdAsync(docReqId);
            if (result == null)
                return null;

            return result.MapToNewDocConfirmationDto();
        }

        public async Task<List<DocSignerResDto>> GetDocConfirmationSignersAsync(int docConfirmationId)
        {
           var result = await docConfirmationRepo.GetDocConfirmationSigners(docConfirmationId);

           return result.MapToDocSignerResDtos();
        }

        public async Task<List<NewDocConfirmationResDto>> GetUserDocConfirmationsAsync(string personCode)
        {
            var result = await docConfirmationRepo.GetUserDocConfirmations(personCode);
            
            return result.MapToNewDocConfirmationDtos();
        }

        public async Task<bool> SignDocConfirmationAsync(int newDocSignersId)
        {
            var result = await docConfirmationRepo.SignDocConfirmationAsync(newDocSignersId);
            return result;
        }

        public async Task<bool> UpdateSendSignRequestDate(int newDocSignerId, string personCode)
        {
            var result = await docConfirmationRepo.UpdateSendSignRequestDate(newDocSignerId, personCode);

            return result;
        }
        public async Task<bool> CancelDocSigning(int docConfirmationId, string cancelReason, string canceledByUserPersonCode)
        {
            var result = await docConfirmationRepo.CancelDocSigning(docConfirmationId, cancelReason, canceledByUserPersonCode);

            return result;
        }

        public async Task<NewDocConfirmationResDto> GetDocConfirmationByIdAsync(int docConfirmId)
        {
            var result = await docConfirmationRepo.GetDocConfirmationByIdAsync(docConfirmId);
            return result.MapToNewDocConfirmationDto();
        }
    }
}
