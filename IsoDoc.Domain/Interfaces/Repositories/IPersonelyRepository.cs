using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
