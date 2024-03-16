using Movie.Pages.Model;

namespace Movie.Pages.Interface
{
    
    public interface ImovieRepository
    {
        Model.Movie Get(int movieId);
        IEnumerable<Model.Movie> GetAll();
        Model.Movie Post(Model.Movie newMovie);
        Model.Movie Put(Model.Movie updatedMovie);
        Model.Movie Delete(int movieId);
    }
}