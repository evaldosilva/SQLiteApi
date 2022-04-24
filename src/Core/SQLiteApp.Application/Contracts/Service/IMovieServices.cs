using SQLiteApp.Domain.Entities;

namespace SQLiteApp.Application.Contracts.Service
{
    public interface IMovieServices
    {
        IEnumerable<Movie> GetItems();
        int Save(Movie movie);
        Movie GetItem(int id);
    }
}