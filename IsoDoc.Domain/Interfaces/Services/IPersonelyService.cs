using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IPersonelyService
    {
        Task<string> GetUserPersonCodeByLoginName(string loginName);

        Task<Person?> GetUserInfoByCardNumber(string userCardNumber);
        Task<List<Colleague>> GetAllEmployees();
        Task<Person?> GetUserInfoByPersonCode(string personCode);
        Task<List<Department>> GetDepartments();
        Task<List<Colleague>> GetUserColleagues(string userDepCode = null, string userManagerDepCode = null, bool adminOnly = false, bool sysOfficeOnly = false);
        Task<List<Colleague>> GetUnSupervisedBosses();
        Task<PersonSignature> SavePersonSignature(PersonSignature personSignature);


        // Task<Person?> GetUserManager(string userManagerDepCode);


    }
}
