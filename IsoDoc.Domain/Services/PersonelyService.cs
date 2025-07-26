using IsoDoc.Domain.Entities;
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

      

        public async Task<List<Colleague>> GetAllEmployees()
        {
           return await personelyRepo.GetAllEmployees();
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await personelyRepo.GetDepartments();
        }

        public async Task<List<Colleague>> GetUnSupervisedBosses()
        {
            return await personelyRepo.GetUnSupervisedBosses();
        }

        public async Task<List<Colleague>> GetUserColleagues(string userDepCode, string userManagerDepCode, bool adminOnly, bool sysOfficeOnly = false)
        {
            return await personelyRepo.GetUserColleagues(userDepCode, userManagerDepCode,adminOnly,sysOfficeOnly);
        }

        public async Task<Person> GetUserInfoByCardNumber(string userCardNumber)
        {
            return await personelyRepo.GetUserInfoByCardNumber(userCardNumber);
        }

        public async Task<Person> GetUserInfoByPersonCode(string personCode)
        {
            return await personelyRepo.GetUserInfoByPersonCode(personCode);

        }

        public async Task<string> GetUserPersonCodeByLoginName(string loginName)
        {
            return await personelyRepo.GetUserPersonCodeByLoginName(loginName);
        }

        public async Task<PersonSignature> SavePersonSignature(PersonSignature personSignature)
        {
            return await personelyRepo.SavePersonSignature(personSignature);
        }

        //public async Task<Person?> GetUserManager(string userManagerDepCode)
        //{
        //    return await personelyRepo.GetUserManager(userManagerDepCode);
        //}
    }
}
