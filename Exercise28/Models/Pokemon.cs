using System.Text.Json;
using System.Text.Json.Serialization;

namespace Exercise28.Models
{
    internal class Pokemon
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Sex { get; set; }
        public static List<Pokemon> Pokemons = new();
        public string? PokemonTrainer { get; set; }

        public Pokemon(string? pokemonTrainer)
        {
            PokemonTrainer = pokemonTrainer;
            //Pokemons = new List<Pokemon>();
        }
        public Pokemon(string? name, string? type, string? sex)
        {
            Name = name;
            Type = type;
            Sex = sex; 
        }

        public void GeneratePokeDataJsonFile()
        {
            string json = JsonSerializer.Serialize(new {name = Name, type = Type, sex = Sex});
            string fileName = Name + " data";

            File.WriteAllText(fileName, json);

            Console.WriteLine(fileName + Path.GetFullPath(fileName));
        }

        public void GeneratePokeListDataJsonFile()
        {
            string json = JsonSerializer.Serialize(new {pokemons = Pokemons});
            string fileName = PokemonTrainer + " Pokedex";

            File.WriteAllText(fileName, json);
            Console.WriteLine(fileName + Path.GetFullPath(fileName));
        }

        public static void AddPokemonToList(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }
        public void DisplayPokemonList()
        {
            Console.WriteLine(PokemonTrainer + " Pokemon List");
            foreach (var pokemon in Pokemons)
            {
                Console.WriteLine($"{pokemon.Name} - {pokemon.Type} - {pokemon.Sex}");
            }
        }

        public void DisplayPokemonData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Sex: " + Sex);
        }
    }
}