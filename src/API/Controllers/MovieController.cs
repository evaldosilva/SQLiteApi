using Microsoft.AspNetCore.Mvc;
using SQLiteApp.Application.Contracts.Service;
using SQLiteApp.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SQLiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices _movieServices;

        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movieServices.GetItems();
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return _movieServices.GetItem(id);
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            if (movie != null)
                _movieServices.Save(movie);
        }
    }
}