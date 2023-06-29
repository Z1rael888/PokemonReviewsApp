using PokemonReviewsApp.Data;
using PokemonReviewsApp.Interfaces;
using PokemonReviewsApp.Models;

namespace PokemonReviewsApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context = context; 
        }
        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p=>p.Id).ToList();
        }
    }
}
