using PokemonReviewsApp.Models;

namespace PokemonReviewsApp.Interfaces
{
    public interface ICountryRepository
    {
        //ICollection vs IEnumerable
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountrybyOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int Id);
    }
}
