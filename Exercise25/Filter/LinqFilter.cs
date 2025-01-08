using Exercise25.Models;

namespace Exercise25.Filter
{
    internal class LinqFilter
    {
        public static void CountryNameFilter(List<Country> countries)
        {
            var countryName = countries.Select(c => c.Name).OrderBy(c => c);

            foreach(var country in countryName)
            {
                Console.WriteLine(country);
            }
        }

        public static void CountryNamePopulationFilter(List<Country> countries)
        {
            var countryNamePopulation = new Dictionary<string, int>();
            
            foreach(var country in countries)
            {
                countryNamePopulation.Add(country.Name!, country.Population);
            }
            foreach(var country in countryNamePopulation)
            {
                Console.WriteLine(country.Key + " - " + country.Value);
            }
        }
    }
}