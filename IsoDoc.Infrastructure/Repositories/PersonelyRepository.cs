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

        public async Task<List<Colleague>> GetUserColleagues(string userDepCode = null, string userManagerDepCode = null, bool adminOnly = false, bool sysOfficeOnly = false)
        {
            try
            {
                connection.Open();
                if (adminOnly)
                {
                    var adminsQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where PostTypeID in (26,27,3)";
                    var admins = await connection.QueryAsync<Person>(adminsQuery);
                    connection.Close();
                    return admins.Select(x => new Colleague { PersonCode = x.PersonCode, CardNumber = x.CardNumber, Name = $"{x.FirstName + " " + x.LastName}", Post = x.Posttxt }).ToList();

                } else if (sysOfficeOnly)
                {
                    var sysOfficeQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CodeEdare = 'SI300' or UpperCode ='SI300'";
                    var sysOfficeEmps = await connection.QueryAsync<Person>(sysOfficeQuery);
                    connection.Close();
                    return sysOfficeEmps.Select(x => new Colleague { PersonCode = x.PersonCode, CardNumber = x.CardNumber, Name = $"{x.FirstName + " " + x.LastName}", Post = x.Posttxt }).ToList();

                }
                else
                {
                    var userManagerQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CodeEdare = '{userManagerDepCode}'";
                    var userEmployeesQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where UpperCode = '{userDepCode}'";

                    var userManagers = await connection.QueryAsync<Person>(userManagerQuery);
                    var userEmployees = await connection.QueryAsync<Person>(userEmployeesQuery);
                    connection.Close();

                    return userManagers.Union(userEmployees).Select(x => new Colleague { PersonCode = x.PersonCode, CardNumber = x.CardNumber, Name = $"{x.FirstName + " " + x.LastName}", Post = x.Posttxt }).ToList();


                }


            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        //public async Task<Person?> GetUserManager( string userManagerDepCode)
        //{
        //    try
        //    {
        //        connection.Open();
        //        var userManagerQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CodeEdare = '{userManagerDepCode}' and PostTypeID in (27,3) order by PostTypeID";

        //        var userManager = await connection.QueryAsync<Person>(userManagerQuery);

        //        connection.Close();

        //        return userManager.FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        connection.Close();
        //        throw ex;
        //    }
        //}

        public async Task<Person?> GetUserInfoByCardNumber(string userCardNumber)
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

        public async Task<Person> GetUserInfoByPersonCode(string personCode)
        {
            try
            {
                connection.Open();
                var userInfoQuery = $"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where PersonCode = ${personCode}";

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

        public async Task<string> GetUserPersonCodeByLoginName(string loginName)
        {
            try
            {
                connection.Open();
                var userPersonCodeQuery = $"SELECT TOP (100) PERCENT PersonID FROM  GeneralObjects.dbo.tbGen_User WHERE   (Is_Active = '1') AND (NetLoginName = '{loginName}')";

                var personCode = await connection.QueryAsync<string>(userPersonCodeQuery);
                connection.Close();
                return personCode.FirstOrDefault();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
    }

}
