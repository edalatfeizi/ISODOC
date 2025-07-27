using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IPersonelyRepository
    {
        Task<List<Colleague>> GetAllEmployees();
        Task<Person?> GetUserInfoByCardNumber(string userCardNumber);
        Task<string> GetUserPersonCodeByLoginName(string loginName);
        Task<Person> GetUserInfoByPersonCode(string personCode);
        Task<List<Colleague>> GetUserColleagues(string userDepCode = null, string userManagerDepCode = null, bool adminOnly = false, bool sysOfficeOnly = false);
        //Task<Person?> GetUserManager(string userManagerDepCode);
        Task<List<Department>> GetDepartments();
        Task<List<Colleague>> GetUnSupervisedBosses();
        Task<PersonSignature> SavePersonSignature(PersonSignature personSignature);
        Task<PersonSignature> GetPersonSignature(string personCode);

        Task<bool> DeletePersonSignature(string personCode);
    }
}
