using Movie.Pages.Interface;
using Movie.Pages.Model;

namespace Movie.Pages.Service
{
    public class MovieRepository : ImovieRepository
    {
        private readonly InstrukcjaDbContext context;

        public MovieRepository(InstrukcjaDbContext _context)
        {
            context = _context;
        }
        public Model.Movie Delete(int movieId)
        {
            Model.Movie movie = context.Movies.Find(movieId);
            if (movie != null)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();
            }
            return movie;
        }

        public Model.Movie Get(int movieId)
        {
            return context.Movies.Find(movieId);
        }
        public IEnumerable<Model.Movie> GetAll()
        {
            return context.Movies;
        }

        public Model.Movie Post(Model.Movie newMovie)
        {
            context.Movies.Add(newMovie);
            context.SaveChanges();
            return newMovie;
        }

        public Model.Movie Put(Model.Movie updatedMovie)
        {
            var movie = context.Movies.Attach(updatedMovie);
            movie.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return updatedMovie;
        }
    }
}
