using System.Text.Json.Serialization;

namespace Exercise24.Models
{
    internal class Film
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("year")]
        public string? Year { get; set; }
        [JsonPropertyName("crew")]
        public string? Crew { get; set; }

        public void DisplayMovieData()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Crew: " + Crew);
        }
    }
}