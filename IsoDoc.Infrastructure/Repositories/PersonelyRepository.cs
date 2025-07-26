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

        public async Task<List<Colleague>> GetAllEmployees()
        {
            const string query = @"SELECT 
                    p.PersonCode, 
                    p.FirstName + ' ' + p.LastName as Name, 
                    p.Posttxt as Post,
                    CASE 
                        WHEN s.PersonCode IS NOT NULL AND s.Active = 'true' THEN 'دارد'
                        ELSE 'ندارد'
                    END as HasSignature
                        FROM 
                            Personely.dbo.Vw_AllPersonWithDepartName p
                        LEFT JOIN 
                    Personely.dbo.tbHR_PersonSignatures s ON p.PersonCode = s.PersonCode AND s.Active = 'true'";

            return (List<Colleague>) await connection.QueryAsync<Colleague>(query);
        }

        public async Task<List<Department>> GetDepartments()
        {
            const string query = @"
                                    SELECT MDepartName, MDepartCode 
                                    FROM Personely.dbo.VwHR_MDepart 
                                    WHERE MDepartCode <> '0'  
                                    ORDER BY DepartID";

            var departments = await connection.QueryAsync<Department>(query);
            return departments.ToList();
        }

        public async Task<List<Colleague>> GetUnSupervisedBosses()
        {
            const string query = @"
                                   SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where (PostTypeID = '50' or PostTypeID = '4') and UpperCode in (SELECT UpperCode 
                                    FROM Personely.dbo.Vw_AllPersonWithDepartName 
                                    WHERE PostTypeId = '50' OR PostTypeId = '4'
                                    EXCEPT
                                    SELECT CodeEdare 
                                    FROM Personely.dbo.Vw_AllPersonWithDepartName 
                                    WHERE PostTypeId = '27' OR PostTypeId = '3')";

            var colleagues = await connection.QueryAsync<Colleague>(query);
            return colleagues.ToList();
        }

        public async Task<List<Colleague>> GetUserColleagues(string userDepCode = null, string userManagerDepCode = null, bool adminOnly = false, bool sysOfficeOnly = false)
        {
                if (adminOnly)
                {
                    var adminsQuery = "SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where PostTypeID in (26,27,3)";
                    var admins = await connection.QueryAsync<Person>(adminsQuery);
                    connection.Close();
                    return admins.Select(x => new Colleague { PersonCode = x.PersonCode, CardNumber = x.CardNumber, Name = $"{x.FirstName + " " + x.LastName}", Post = x.Posttxt, PostTypeID = x.PostTypeID, Mobile = x.Mobile, CodeEdare = x.CodeEdare, UpperCode = x.UpperCode }).ToList();

                }
                else if (sysOfficeOnly)
                {
                    var sysOfficeQuery = "SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CodeEdare = 'SI300' or UpperCode ='SI300'";
                    var sysOfficeEmps = await connection.QueryAsync<Person>(sysOfficeQuery);
                    connection.Close();
                    return sysOfficeEmps.Select(x => new Colleague { PersonCode = x.PersonCode, CardNumber = x.CardNumber, Name = $"{x.FirstName + " " + x.LastName}", Post = x.Posttxt, PostTypeID = x.PostTypeID, Mobile = x.Mobile, CodeEdare = x.CodeEdare, UpperCode = x.UpperCode }).ToList();

                }
                else
                {
                    var userManagerQuery = @"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where CodeEdare = @CodeEdare";
                    var userEmployeesQuery = @"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where UpperCode = @UpperCode";

                    var userManagers = await connection.QueryAsync<Person>(userManagerQuery, new { CodeEdare = userManagerDepCode });
                    var userEmployees = await connection.QueryAsync<Person>(userEmployeesQuery, new { UpperCode = userDepCode});
                    connection.Close();

                    return userManagers.Union(userEmployees).Select(x => new Colleague { PersonCode = x.PersonCode, CardNumber = x.CardNumber, Name = $"{x.FirstName + " " + x.LastName}", Post = x.Posttxt, PostTypeID = x.PostTypeID, Mobile = x.Mobile, CodeEdare = x.CodeEdare, UpperCode = x.UpperCode }).ToList();


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
            const string query = @"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName WHERE CardNumber = @CardNumber";

            // Dapper automatically opens/closes the connection if not already open
            return await connection.QueryFirstOrDefaultAsync<Person>(query, new { CardNumber = userCardNumber });
        }

        public async Task<Person> GetUserInfoByPersonCode(string personCode)
        {

            var query = @"SELECT * FROM Personely.dbo.Vw_AllPersonWithDepartName where PersonCode = @PersonCode";

            return await connection.QueryFirstOrDefaultAsync<Person>(query, new { PersonCode = personCode });

        }

        public async Task<string> GetUserPersonCodeByLoginName(string loginName)
        {
                var query = @"SELECT TOP (100) PERCENT PersonID FROM  GeneralObjects.dbo.tbGen_User WHERE   (Is_Active = '1') AND (NetLoginName = @LoginName)";

                return await connection.QueryFirstOrDefaultAsync<string>(query, new { LoginName = loginName });

        }

        public async Task<PersonSignature> SavePersonSignature(PersonSignature personSignature)
        {
            var newSignatureQuery = @"
                    INSERT INTO Personely.dbo.tbHR_PersonSignatures (
                        PersonCode,
                        Name,
                        ContentType,
                        FileContent,
                        Size,
                        CreatedBy, 
                        ModifiedBy, 
                        CreatedAt, 
                        ModifiedAt,
                        Active
                    )
                    OUTPUT INSERTED.Id
                    VALUES (
                        @PersonCode,
                        @Name,
                        @ContentType,
                        @FileContent,
                        @Size,
                        @CreatedBy, 
                        @ModifiedBy, 
                        @CreatedAt, 
                        @ModifiedAt,
                        @Active
                    );";


            var newSignatureId = await connection.QuerySingleAsync<int>(newSignatureQuery, personSignature);
            personSignature.Id = newSignatureId;
            return personSignature;
        }
    }

}
