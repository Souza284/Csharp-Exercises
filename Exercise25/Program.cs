using System.Text.Json;
using Exercise25.Filter;
using Exercise25.Models;

using (HttpClient client = new())
{
    var apiCountry = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");

    //Console.WriteLine(apiCountry);

    var countries = JsonSerializer.Deserialize<List<Country>>(apiCountry)!;
    //LinqFilter.CountryNameFilter(countries);
    LinqFilter.CountryNamePopulationFilter(countries);
}