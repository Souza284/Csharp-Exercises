using Exercise28.Filters;
using Exercise28.Models;


Pokemon pokemonTrainer1 = new("Pedro");

Pokemon pokemon1 = new("Blastoise", "Water", "Male");
//pokemon1.GeneratePokeDataJsonFile();
Pokemon.AddPokemonToList(pokemon1);

Pokemon pokemon2 = new("Charizard", "Fire", "Female");
//pokemon2.GeneratePokeDataJsonFile();
Pokemon.AddPokemonToList(pokemon2);

Pokemon pokemon3 = new("Venosaur", "Plant", "Male");
//pokemon3.GeneratePokeDataJsonFile();
Pokemon.AddPokemonToList(pokemon3);

Pokemon pokemon4 = new("Totodile", "Water", "Female");
//pokemon4.GeneratePokeDataJsonFile();
Pokemon.AddPokemonToList(pokemon4);

pokemonTrainer1.GeneratePokeListDataJsonFile();
pokemonTrainer1.DisplayPokemonList();
Console.WriteLine();
LinqFilter.FilterWaterPokemon(Pokemon.Pokemons);
