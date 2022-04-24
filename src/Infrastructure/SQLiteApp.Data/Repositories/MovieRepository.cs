using Dapper;
using SQLiteApp.Application.Contracts.Data;
using SQLiteApp.Domain.Entities;
using System.Data;

namespace SQLiteApp.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IDBConnectionFactory _connectionFactory;

        public MovieRepository(IDBConnectionFactory connection)
        {
            _connectionFactory = connection;
        }

        public Movie GetItem(int id)
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();
            return connection.QuerySingleOrDefault<Movie>(sql: "select * from movie where Id = @Id", new { Id = id });
        }

        public IEnumerable<Movie> GetItems()
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();
            return connection.Query<Movie>(sql: "select * from movie", new { });
        }

        public int Save(Movie movie)
        {
            using IDbConnection connection = _connectionFactory.CreateConnection();
            return connection.Execute("Insert into movie(Name, Year) values (@Name, @Year)", movie);
        }
    }
}