using Microsoft.Extensions.Configuration;
using SQLiteApp.Application.Contracts.Data;
using System.Data;
using System.Data.SQLite;

namespace SQLiteApp.Data.Repositories
{
    public class DBConnectionFactory : IDBConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DBConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            return new SQLiteConnection(_configuration.GetConnectionString("Default"));
        }
    }
}