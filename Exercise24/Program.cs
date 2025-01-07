using System.Text.Json;
using Exercise24.Filters;
using Exercise24.Models;

using (HttpClient client = new HttpClient())
{
    string apiFilms = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

    //Console.WriteLine(apiFilms);

    var movies = JsonSerializer.Deserialize<List<Film>>(apiFilms)!;

    LinqFilter.FilterTitle(movies);
}
