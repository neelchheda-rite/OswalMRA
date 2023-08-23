using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace OswalMRA.DAL
{
    public class DBContext
    {
        readonly string _connectionString;
        IConfiguration _configuration;
        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration["ConnectionStrings:DBConnectionString"];
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
