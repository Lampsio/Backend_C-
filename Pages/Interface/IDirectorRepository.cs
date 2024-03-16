using Movie.Pages.Model;

namespace Movie.Pages.Interface
{
    public interface IDirectorRepository
    {
        Director Get(int directorId);
        IEnumerable<Director> GetAll();
        Director Post(Director newDirector);
        Director Put(Director updatedDirector);
        Director Delete(int directorId);
    }
}
