using Microsoft.AspNetCore.Mvc;
using Movie.Pages.Interface;

namespace Movie.Pages.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        ImovieRepository movieRepository;
        public MovieController(ImovieRepository _movieRepository)
        {
            movieRepository = _movieRepository;
        }

        // GET: api/Movie
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Model.Movie> movies = movieRepository.GetAll();
            if (movies.Any() == false)
                return NoContent();
            return Ok(movies);
        }

        // GET: api/Movie/5
        [HttpGet("{movieId}")]
        public IActionResult Get(int movieId)
        {
            Model.Movie movie = movieRepository.Get(movieId);
            if (movie == null)
                return NoContent();

            return Ok(movie);
        }
        // POST: api/Movie
        [HttpPost]
        public IActionResult Post([FromBody] Model.Movie movie)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newMovie = movieRepository.Post(movie);
            return CreatedAtAction(nameof(Get), new { movieId = newMovie.MovieId }, newMovie);
        }

        // PUT: api/Movie/5
        [HttpPut]
        public IActionResult Put([FromBody] Model.Movie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedMovie = movieRepository.Put(movie);
            return Ok(updatedMovie);
        }

        // DELETE: api/Movie/5
        [HttpDelete("{movieId}")]
        public IActionResult Delete(int movieId)
        {

            var deletedMovie = movieRepository.Delete(movieId);
            if (deletedMovie == null)
                return NoContent();
            return Ok(deletedMovie);
        }
    }
}
