using SQLiteApp.Domain.Entities;

namespace SQLiteApp.Application.Contracts.Data
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetItems();
        int Save(Movie movie);
        Movie GetItem(int id);
    }
}