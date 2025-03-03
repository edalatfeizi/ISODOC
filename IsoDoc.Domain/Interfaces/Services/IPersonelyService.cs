using IsoDoc.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IPersonelyService
    {
        Task<Person?> GetUserInfo(string userCardNumber);
        Task<List<Department>> GetDepartments();
        Task<List<Colleague>> GetUserColleagues(string userDepCode, string userManagerDepCode);
        Task<Person> GetUserManager(string userManagerDepCode);
    }
}
