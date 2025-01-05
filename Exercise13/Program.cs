using Exercise13.Models;

Book book1 = new("Não confie em ninguém", "Charlie Donlea", 2018);
Book book2 = new("A biblioteca da meia noite", "Matt Haig", 2020);
Book book3 = new("Orgulho e Preconceito", "Jane Austen", 1813);
Book book4 = new("Diário de Anne Frank", "Anne Frank", 1947);
Book book5 = new("Morte no Nilo", "Agatha Christie", 1937);

var bookList = new List<Book>{book1, book2, book3, book4, book5};

var OrderedBookList = bookList.OrderBy(b => b.Name);

foreach (var book in OrderedBookList)
{
    Console.WriteLine(book.ToString());
}
