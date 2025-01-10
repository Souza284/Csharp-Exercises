using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exercise29.Models
{
    internal class Book
    {
        [JsonPropertyName("titulo")]
        public string? Title { get; set; }
        [JsonPropertyName("autor")]
        public string? Author { get; set; }
        [JsonPropertyName("ano_publicacao")]
        public int Year { get; set; }
        [JsonPropertyName("genero")]
        public string? Genre { get; set; }
        [JsonPropertyName("paginas")]
        public int Pages { get; set; }
        [JsonPropertyName("editora")]
        public string? Publisher { get; set; }

        public void DisplayBookData()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Pages: " + Pages);
            Console.WriteLine("Publisher: " + Publisher);
        }
    }
}