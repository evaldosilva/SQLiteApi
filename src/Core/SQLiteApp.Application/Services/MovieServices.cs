using SQLiteApp.Application.Contracts.Data;
using SQLiteApp.Application.Contracts.Service;
using SQLiteApp.Domain.Entities;

namespace SQLiteApp.Application.Services
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieRepository _movieRepository;

        public MovieServices(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie GetItem(int id)
        {
            return _movieRepository.GetItem(id);
        }

        public IEnumerable<Movie> GetItems()
        {
            return _movieRepository.GetItems();
        }

        public int Save(Movie movie)
        {
            return _movieRepository.Save(movie);
        }
    }
}