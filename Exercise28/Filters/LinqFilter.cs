using Exercise28.Models;

namespace Exercise28.Filters
{
    internal class LinqFilter
    {
        public static void FilterWaterPokemon(List<Pokemon> pokemons)
        {
            var waterPokemons = pokemons.Where(p => p.Type == "Water").Select(p => p.Name).OrderBy(p => p);

            Console.WriteLine("Pokemons type water");

            foreach(var waterPokemon in waterPokemons)
            {
                Console.WriteLine(" - " + waterPokemon);
            }
        }
    }
}