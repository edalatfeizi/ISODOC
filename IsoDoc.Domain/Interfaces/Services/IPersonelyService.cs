using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IPersonelyService
    {
        Task<Person?> GetUserInfoByCardNumber(string userCardNumber);
        Task<Person?> GetUserInfoByPersonCode(string personCode);
        Task<List<Department>> GetDepartments();
        Task<List<Colleague>> GetUserColleagues(string userDepCode = null, string userManagerDepCode = null, bool adminOnly = false, bool sysOfficeOnly = false);
       // Task<Person?> GetUserManager(string userManagerDepCode);


    }
}
