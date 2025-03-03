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
        Task<Person?> GetUserInfo(string userCardNumber);
        Task<List<Colleague>> GetUserColleagues(string userDepCode, string userManagerDepCode);
        Task<Person> GetUserManager(string userManagerDepCode);
        Task<List<Department>> GetDepartments();

    }
}
