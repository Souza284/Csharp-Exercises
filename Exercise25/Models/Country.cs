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
    }
}