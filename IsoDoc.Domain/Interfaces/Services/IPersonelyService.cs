using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Services
{
    public interface IPersonelyService
    {
        Task<Person?> GetUserInfo(string userCardNumber);
        Task<List<Department>> GetDepartments();

    }
}
