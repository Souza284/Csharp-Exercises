using System.Text.Json;
using Exercise29.Filters;
using Exercise29.Models;

using (HttpClient client = new())
{
    string apiBook = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");

    var books = JsonSerializer.Deserialize<List<Book>>(apiBook)!;

    LinqFilter.DisplayBooksByYear(books);
}