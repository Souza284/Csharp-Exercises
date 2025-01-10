using Exercise29.Models;

namespace Exercise29.Filters
{
    internal class LinqFilter
    {
        public static void DisplayBooksByYear(List<Book> books)
        {
            var booksByYear = books.OrderBy(b => b.Year);

            foreach(var book in booksByYear)
            {
                book.DisplayBookData();
                Console.WriteLine();
            }
        }
    }
}