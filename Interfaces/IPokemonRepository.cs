using WebApplication2.Dto;
using WebApplication2.Models;

namespace WebApplication2.Interfaces;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
    Pokemon GetPokemonId(int id);
    Pokemon GetPokemonName(string name);
    bool PokemonExistsId(int pokeId);
    bool PokemonExistsName(string name);
    Pokemon GetPokemonTrimToUpper(PokemonDto pokemonCreate);
    bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
    bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
    bool DeletePokemon(Pokemon pokemon);
    bool Save();
}