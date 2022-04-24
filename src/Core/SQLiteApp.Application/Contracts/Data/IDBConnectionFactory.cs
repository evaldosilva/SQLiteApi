using System.Data;

namespace SQLiteApp.Application.Contracts.Data
{
    public interface IDBConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}