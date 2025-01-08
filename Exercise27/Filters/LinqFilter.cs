using Exercise27.Models;

namespace Exercise27.Filters
{
    internal class LinqFilter
    {
        public static void FilterCarByType(List<Car> cars)
        {
            var sedanCars = cars.Where(c => c.Type == "Sedan").Select(c => c.Model).OrderBy(c => c);

            foreach(var car in sedanCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}