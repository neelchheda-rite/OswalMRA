using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace OswalMRA.DAL {
    public class DBContext
    {
        readonly string _connectionString;
        public DBContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        }


        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
