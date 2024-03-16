using Movie.Pages.Model;

namespace Movie.Pages.Interface
{
    public interface IReviewRepository
    {
        Review Get(int reviewId);
        IEnumerable<Review> GetAll();
        Review Post(Review newReview);
        Review Put(Review updatedReview);
        Review Delete(int reviewId);
    }
}
