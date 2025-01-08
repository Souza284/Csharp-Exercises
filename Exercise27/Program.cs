using System.Text.Json;
using Exercise27.Filters;
using Exercise27.Models;

using (HttpClient client = new())
{
    var apiCar =  await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");

    var cars = JsonSerializer.Deserialize<List<Car>>(apiCar)!;

    //cars[0].DisplayCarData();
    LinqFilter.FilterCarByType(cars);

}