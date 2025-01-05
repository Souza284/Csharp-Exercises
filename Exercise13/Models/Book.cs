namespace Exercise13.Models
{
    internal class Book
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }

        public Book(string? name, string? author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return "Name: " + Name + ". Author: " + Author + ". Year: " + Year;
        }
    }
}