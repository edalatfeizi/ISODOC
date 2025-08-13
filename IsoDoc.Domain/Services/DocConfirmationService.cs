using IsoDoc.Domain.Dtos;
using IsoDoc.Domain.Dtos.Req;
using IsoDoc.Domain.Dtos.Res;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Enums;
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
            var newDocSigner = await docConfirmationRepo.AddNewDocSigner(dto.NewDocConfirmationId,dto.PersonCode,dto.Name,dto.Post,dto.SignerType,dto.SigningOrder, dto.CreatorUserPersonCode, dto.SignRequestSentDate);

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

        public async Task<List<NewDocConfirmationResDto>> GetUserDocConfirmationsAsync(string personCode, bool isSysOfficeStaff)
        {
            var result = await docConfirmationRepo.GetUserDocConfirmations(personCode, isSysOfficeStaff);
            
            return result.MapToNewDocConfirmationDtos();
        }

        public async Task<bool> SignDocConfirmationAsync(int docSignerId)
        {
            var result = await docConfirmationRepo.SignDocConfirmationAsync(docSignerId);
            return result;
        }

        public async Task<bool> UpdateSendSignRequestDate(int newDocSignerId, string personCode)
        {
            var result = await docConfirmationRepo.UpdateSendSignRequestDate(newDocSignerId, personCode);

            return result;
        }
        public async Task<bool> UpdateDocConfirmStatusAsync(int docConfirmationId,DocRequestStatus status, string modifiedByUserPersonCode)
        {
            var result = await docConfirmationRepo.UpdateDocConfirmStatusAsync(docConfirmationId, status, modifiedByUserPersonCode);

            return result;
        }

        public async Task<NewDocConfirmationResDto> GetDocConfirmationByIdAsync(int docConfirmId)
        {
            var result = await docConfirmationRepo.GetDocConfirmationByIdAsync(docConfirmId);
            return result.MapToNewDocConfirmationDto();
        }

        public async Task<bool> CancelSigningAsync(int docConfirmationId, string canceledByUserPersonCode)
        {
           return await docConfirmationRepo.CancelSigningAsync(docConfirmationId, canceledByUserPersonCode);
        }
        public async Task<DocConfirmationStateChangeResDto> AddDocConfirmationStateChangeAsync(DocConfirmationStateChangeReqDto dto)
        {
            var result = await docConfirmationRepo.AddDocConfirmationStateChangeAsync(dto.DocConfirmationId, dto.SenderUserPersonCode, dto.SenderUserFullName, dto.SenderUserPost, dto.ReceiverUserPersonCode, dto.ReceiverUserFullName, dto.ReceiverUserPost, dto.Description,dto.Status);
            return result.MapToDocConfirmationStateChangeResDto();
        }

        public async Task<List<DocConfirmationStateChangeResDto>> GetDocConfirmationStateChangesAsync(int docConfirmationId)
        {
            var result = await docConfirmationRepo.GetDocConfirmationStateChangesAsync(docConfirmationId);

            return result.MapToDocConfirmationStateChangeResDtos();
        }
    }
}
