using Dapper;
using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Interfaces.Repositories;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IsoDoc.Infrastructure.Repositories
{
    public class PersonelyRepository : IPersonelyRepository
    {
        private readonly IDbConnection connection;
        public PersonelyRepository(IDbConnection dbConnection)
        {
            connection = dbConnection;
        }

        public async Task<List<Department>> GetDepartments()
        {
            try
            {
                connection.Open();
                var depsQuery = "select MDepartName ,MDepartCode from Personely.dbo.VwHR_MDepart where MDepartCode <> '0'  order by DepartID";

                var deps = await connection.QueryAsync<Department>(depsQuery);
                connection.Close();
                return deps.ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public async Task<List<Colleague>> GetUserColleagues(string userDepCode, string userManagerDepCode)
        {
            try
            {
                connection.Open();
                var userManagerQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CodeEdare = '{userManagerDepCode}'";
                var userEmployeesQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where UpperCode = '{userDepCode}'";

                var userManagers = await connection.QueryAsync<Person>(userManagerQuery);
                var userEmployees = await connection.QueryAsync<Person>(userEmployeesQuery);

                connection.Close();

                return userManagers.Union(userEmployees).Select(x => new Colleague { PersonCode = x.PersonCode, Name = $"{x.FirstName + " " + x.LastName}", Post = x.Posttxt }).ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        public async Task<Person> GetUserManager( string userManagerDepCode)
        {
            try
            {
                connection.Open();
                var userManagerQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CodeEdare = '{userManagerDepCode}'";

                var userManager = await connection.QueryAsync<Person>(userManagerQuery);

                connection.Close();

                return userManager.First();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public async Task<Person?> GetUserInfo(string userCardNumber)
        {
            try
            {
                connection.Open();
                var userInfoQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CardNumber = ${userCardNumber}";

                var userInfo = await connection.QueryAsync<Person>(userInfoQuery);
                connection.Close();
                return userInfo.FirstOrDefault();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
    }

}
