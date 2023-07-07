using PokemonReviewsApp.Models;

namespace PokemonReviewsApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);//!!!REVIEW NAVIGATION  NOT REVIEWER!!!
        bool ReviewerExists(int reviewerId);
        bool CreateReviewer (Reviewer reviewer);
        bool Save();
    }
}
