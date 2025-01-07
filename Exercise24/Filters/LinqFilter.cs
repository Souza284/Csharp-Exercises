using Exercise24.Models;
using Microsoft.VisualBasic;

namespace Exercise24.Filters
{
    internal class LinqFilter
    {
        public static void FilterTitle(List<Film> movies)
        {
            var titles = movies.OrderBy(m => m.Title).Select(m => m.Title);

            foreach(var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}