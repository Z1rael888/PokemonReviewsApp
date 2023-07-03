﻿using PokemonReviewsApp.Models;

namespace PokemonReviewsApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsForAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
    }
}
