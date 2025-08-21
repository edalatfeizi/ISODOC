using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces
{
    public sealed class SqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connStr;
        public SqlConnectionFactory(string connStr) => _connStr = connStr;
        public IDbConnection Create() => new SqlConnection(_connStr);
    }
}
