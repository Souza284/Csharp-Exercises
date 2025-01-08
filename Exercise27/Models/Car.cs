using System.Text.Json.Serialization;

namespace Exercise27.Models
{
    internal class Car
    {
        [JsonPropertyName("marca")]
        public string? Brand { get; set; }
        [JsonPropertyName("modelo")]
        public string? Model { get; set; }
        [JsonPropertyName("ano")]
        public int Year { get; set; }
        [JsonPropertyName("tipo")]
        public string? Type { get; set; }
        [JsonPropertyName("motor")]
        public string? Motor { get; set; }

        public void DisplayCarData()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Motor: " + Motor);
        }
    }
}