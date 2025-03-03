using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Interfaces.Services;
using IsoDoc.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Services
{
    public class PersonelyService : IPersonelyService
    {
        private readonly IPersonelyRepository personelyRepo;
        public PersonelyService(IPersonelyRepository personelyRepository)
        {
            personelyRepo = personelyRepository;
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await personelyRepo.GetDepartments();
        }

        public async Task<List<Colleague>> GetUserColleagues(string userDepCode, string userManagerDepCode)
        {
            return await personelyRepo.GetUserColleagues(userDepCode, userManagerDepCode);
        }

        public async Task<Person> GetUserInfo(string userCardNumber)
        {
            return await personelyRepo.GetUserInfo(userCardNumber);
        }

        public async Task<Person> GetUserManager(string userManagerDepCode)
        {
            return await personelyRepo.GetUserManager(userManagerDepCode);
        }
    }
}
