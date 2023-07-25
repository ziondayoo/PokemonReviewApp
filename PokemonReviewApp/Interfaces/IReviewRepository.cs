using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewsExists(int reviewId); 
        bool CreateReview(Review review);
        bool UpdateReview(Review review);   
        bool Save();

    }
}
