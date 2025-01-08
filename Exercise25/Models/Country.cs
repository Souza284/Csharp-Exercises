using System.Text.Json.Serialization;

namespace Exercise25.Models
{
    internal class Country
    {
        [JsonPropertyName("nome")]
        public string? Name { get; set; }
        [JsonPropertyName("capital")]
        public string? Capital { get; set; }
        [JsonPropertyName("populacao")]
        public int Population { get; set; }
        [JsonPropertyName("continente")]
        public string? Continent { get; set; }
        [JsonPropertyName("idioma")]
        public string? Language { get; set; }

        public void DisplayCountryData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Capital: " + Capital);
            Console.WriteLine("Population: " + Population);
            Console.WriteLine("Continent: " + Continent);
            Console.WriteLine("Language: " + Language);
        }
    }
}